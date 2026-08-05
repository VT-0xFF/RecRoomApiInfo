using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using RecRoom.Circuits.Protobuf;
using RecRoom.Circuits.Traversal;
using RecRoom.Circuits.Utils;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("Circuits")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Circuits")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: InternalsVisibleTo("NUnit.CircuitTests", AllInternalsVisible = true)]
[assembly: ComVisible(false)]
[assembly: Guid("d45372e6-abad-4794-881e-f0a31371e1c2")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace RecRoom.Circuits
{
	public class BitPacker
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct IntFloatType
		{
			[FieldOffset(0)]
			public uint AsUInt;

			[FieldOffset(0)]
			public float AsFloat;
		}

		private const int DEFAULT_SCRATCH_BUFFER_SIZE = 128;

		private const float SQRT_ONE_HALF = 0.70710677f;

		private static readonly int[] REQUIRED_BITS_LOOKUP = new int[16]
		{
			0, 1, 2, 2, 3, 3, 3, 3, 4, 4,
			4, 4, 4, 4, 4, 4
		};

		private readonly byte[] scratchBuffer;

		private Stream stream;

		private bool isWriting;

		private int totalLength;

		private int scratchByteIndex;

		private int scratchBitIndex;

		private int scratchByteLength;

		private IntFloatType intFloatConverter;

		public static int RequiredBits(uint maxValue)
		{
			int num = 0;
			if ((maxValue & 0xFFFF0000u) != 0)
			{
				num += 16;
				maxValue >>= 16;
			}
			if ((maxValue & 0xFF00) != 0)
			{
				num += 8;
				maxValue >>= 8;
			}
			if ((maxValue & 0xF0) != 0)
			{
				num += 4;
				maxValue >>= 4;
			}
			return num + REQUIRED_BITS_LOOKUP[maxValue];
		}

		public static uint MaxValue(int bits)
		{
			return bits switch
			{
				0 => 0u, 
				32 => uint.MaxValue, 
				_ => (uint)((1 << bits) - 1), 
			};
		}

		public BitPacker(int scratchBufferSize = 128)
		{
			scratchBuffer = new byte[scratchBufferSize];
		}

		public void StartWriting(Stream stream)
		{
			this.stream = stream;
			totalLength = 0;
			isWriting = true;
			scratchByteIndex = 0;
			scratchBitIndex = 0;
			scratchByteLength = scratchBuffer.Length;
		}

		public int FinishWriting()
		{
			if (scratchBitIndex > 0)
			{
				scratchByteIndex++;
				scratchBitIndex = 0;
			}
			FlushScratchBuffer();
			stream = null;
			return totalLength;
		}

		public void StartReading(Stream stream, int length)
		{
			this.stream = stream;
			totalLength = length;
			isWriting = false;
			scratchByteIndex = 0;
			scratchBitIndex = 0;
			scratchByteLength = 0;
			RefillScratchBuffer();
		}

		public void FinishReading()
		{
			stream = null;
		}

		public void WriteBool(bool value)
		{
			WriteBits(value ? 1u : 0u, 1);
		}

		public void ReadBool(out bool value)
		{
			value = ReadBits(1) == 1;
		}

		public void WriteSByte(sbyte value, sbyte minimum, sbyte maximum)
		{
			WriteInt(value, minimum, maximum);
		}

		public void WriteShort(short value, short minimum, short maximum)
		{
			WriteInt(value, minimum, maximum);
		}

		public void WriteInt(int value, int minimum, int maximum)
		{
			uint num = (uint)(maximum - minimum);
			int bits = RequiredBits(num);
			uint value2 = ((value >= minimum) ? ((value > maximum) ? num : ((uint)(value - minimum))) : 0u);
			WriteBits(value2, bits);
		}

		public void ReadSByte(out sbyte value, sbyte minimum, sbyte maximum)
		{
			ReadInt(out var value2, minimum, maximum);
			value = (sbyte)value2;
		}

		public void ReadShort(out short value, short minimum, short maximum)
		{
			ReadInt(out var value2, minimum, maximum);
			value = (short)value2;
		}

		public void ReadInt(out int value, int minimum, int maximum)
		{
			int bits = RequiredBits((uint)(maximum - minimum));
			uint num = ReadBits(bits);
			value = (int)num + minimum;
		}

		public void WriteByte(byte value, byte minimum, byte maximum)
		{
			WriteUInt(value, minimum, maximum);
		}

		public void WriteUShort(ushort value, ushort minimum, ushort maximum)
		{
			WriteUInt(value, minimum, maximum);
		}

		public void WriteUInt(uint value, uint minimum, uint maximum)
		{
			uint num = maximum - minimum;
			int bits = RequiredBits(num);
			uint value2 = ((value >= minimum) ? ((value > maximum) ? num : (value - minimum)) : 0u);
			WriteBits(value2, bits);
		}

		public void ReadByte(out byte value, byte minimum, byte maximum)
		{
			ReadUInt(out var value2, minimum, maximum);
			value = (byte)value2;
		}

		public void ReadUShort(out ushort value, ushort minimum, ushort maximum)
		{
			ReadUInt(out var value2, minimum, maximum);
			value = (ushort)value2;
		}

		public void ReadUInt(out uint value, uint minimum, uint maximum)
		{
			int bits = RequiredBits(maximum - minimum);
			uint num = ReadBits(bits);
			value = num + minimum;
		}

		public void WriteFloat(float value, float minimum, float maximum, int bits)
		{
			uint num = MaxValue(bits);
			uint num2 = (uint)Math.Floor((value - minimum) / (maximum - minimum) * (float)num + 0.5f);
			num2 &= num;
			WriteBits(num2, bits);
		}

		public void ReadFloat(out float value, float minimum, float maximum, int bits)
		{
			uint num = MaxValue(bits);
			float num2 = (float)ReadBits(bits) / (float)num;
			value = minimum + (maximum - minimum) * num2;
		}

		public void WriteUncompressedFloat(float value)
		{
			intFloatConverter.AsFloat = value;
			WriteBits(intFloatConverter.AsUInt, 32);
		}

		public void ReadUncompressedFloat(out float value)
		{
			intFloatConverter.AsUInt = ReadBits(32);
			value = intFloatConverter.AsFloat;
		}

		private void WriteBits(uint value, int bits)
		{
			uint num = MaxValue(bits);
			value &= num;
			ulong num2 = ((scratchBitIndex != 0) ? (((ulong)value << scratchBitIndex) | scratchBuffer[scratchByteIndex]) : value);
			scratchBitIndex += bits;
			while (scratchBitIndex >= 8)
			{
				scratchBuffer[scratchByteIndex] = (byte)(num2 & 0xFF);
				scratchByteIndex++;
				scratchBitIndex -= 8;
				num2 >>= 8;
				if (scratchByteIndex == scratchBuffer.Length)
				{
					FlushScratchBuffer();
				}
			}
			if (scratchBitIndex > 0)
			{
				scratchBuffer[scratchByteIndex] = (byte)(num2 & 0xFF);
			}
		}

		private uint ReadBits(int bits)
		{
			uint num = 0u;
			int i = 0;
			if (scratchBitIndex > 0)
			{
				num = (uint)(scratchBuffer[scratchByteIndex] >> scratchBitIndex);
				if (scratchBitIndex + bits >= 8)
				{
					i += 8 - scratchBitIndex;
					scratchBitIndex = 0;
					scratchByteIndex++;
				}
				else
				{
					num &= MaxValue(bits);
					i += bits;
					scratchBitIndex += bits;
				}
			}
			for (; bits - i >= 8; i += 8)
			{
				if (scratchByteIndex == scratchByteLength)
				{
					RefillScratchBuffer();
				}
				num |= (uint)(scratchBuffer[scratchByteIndex] << i);
				scratchByteIndex++;
			}
			if (bits - i > 0)
			{
				if (scratchByteIndex == scratchByteLength)
				{
					RefillScratchBuffer();
				}
				num |= (scratchBuffer[scratchByteIndex] & MaxValue(bits - i)) << i;
				scratchBitIndex = bits - i;
			}
			return num;
		}

		private void FlushScratchBuffer()
		{
			if (scratchByteIndex > 0)
			{
				stream.Write(scratchBuffer, 0, scratchByteIndex);
				totalLength += scratchByteIndex;
				scratchByteIndex = 0;
			}
		}

		private void RefillScratchBuffer()
		{
			if (totalLength > 0)
			{
				scratchByteLength = Math.Min(totalLength, scratchBuffer.Length);
				stream.Read(scratchBuffer, 0, scratchByteLength);
				totalLength -= scratchByteLength;
				scratchByteIndex = 0;
			}
			else
			{
				scratchByteLength = 0;
				scratchByteIndex = 0;
			}
		}
	}
	public class CircuitLink
	{
		public readonly LinkTypes LinkType;

		public readonly CircuitNode SourceNode;

		public readonly CircuitNode DestNode;

		public readonly InputSlot InputSlot;

		public readonly OutputSlot OutputSlot;

		public IEnumerable<CircuitNode> TrueDests
		{
			get
			{
				if (DestNode.IsVirtual)
				{
					OutputSlot key = IOSlots.InputSlotToOutputSlot[InputSlot];
					if (DestNode.Outputs.TryGetValue(key, out var value))
					{
						return value.Select((CircuitLink _) => _.DestNode);
					}
					return null;
				}
				return new CircuitNode[1] { DestNode };
			}
		}

		public CircuitLink(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			RuntimeAssert.Assert(sourceNode != null, "Source node of CircuitLink cannot be null!");
			RuntimeAssert.Assert(destNode != null, "Dest node of CircuitLink cannot be null!");
			SourceNode = sourceNode;
			DestNode = destNode;
			InputSlot = inputSlot;
			OutputSlot = outputSlot;
			LinkType = GraphTraversal.FindLinkType(sourceNode, destNode);
		}

		public CircuitLinkData Serialize()
		{
			return new CircuitLinkData
			{
				SourceNodeId = SourceNode.NodeId,
				DestNodeId = DestNode.NodeId,
				InputSlot = (int)InputSlot,
				OutputSlot = (int)OutputSlot
			};
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			CircuitLink circuitLink = (CircuitLink)obj;
			if (InputSlot == circuitLink.InputSlot && OutputSlot == circuitLink.OutputSlot && SourceNode.NodeId == circuitLink.SourceNode.NodeId)
			{
				return DestNode.NodeId == circuitLink.DestNode.NodeId;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return (((17 * 23 + InputSlot.GetHashCode()) * 23 + OutputSlot.GetHashCode()) * 23 + SourceNode.NodeId.GetHashCode()) * 23 + DestNode.NodeId.GetHashCode();
		}

		public override string ToString()
		{
			return $"Source:{SourceNode.NodeId} [{OutputSlot}] => Dest:{DestNode.NodeId} [{InputSlot}]";
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class CircuitNodeUuidAttribute : Attribute
	{
		public readonly Guid Id;

		public bool InternalOnly { get; set; }

		public CircuitNodeUuidAttribute(Guid id)
		{
			Id = id;
		}

		public CircuitNodeUuidAttribute(string id)
		{
			Id = new Guid(id);
		}

		public static CircuitNodeUuidAttribute GetFromType(Type type)
		{
			return type.GetCustomAttributes(inherit: false).OfType<CircuitNodeUuidAttribute>().FirstOrDefault();
		}
	}
	public static class EqualityComparers
	{
		public static InputSlotComparer InputSlotComparer = new InputSlotComparer();

		public static OutputSlotComparer OutputSlotComparer = new OutputSlotComparer();
	}
	public class InputSlotComparer : IEqualityComparer<InputSlot>
	{
		public bool Equals(InputSlot x, InputSlot y)
		{
			int num = (int)x;
			return num.Equals((int)y);
		}

		public int GetHashCode(InputSlot obj)
		{
			int num = (int)obj;
			return num.GetHashCode();
		}
	}
	public class OutputSlotComparer : IEqualityComparer<OutputSlot>
	{
		public bool Equals(OutputSlot x, OutputSlot y)
		{
			int num = (int)x;
			return num.Equals((int)y);
		}

		public int GetHashCode(OutputSlot obj)
		{
			int num = (int)obj;
			return num.GetHashCode();
		}
	}
	public abstract class CircuitNode
	{
		public delegate void LogMessage(int nodeId, string message);

		private struct OutputSignal
		{
			public int Value;

			public bool IsMomentary;
		}

		public delegate void NodeMetadataChanged(NodeMetadata newNodeMetadata);

		public delegate void NodeConnectionChanged(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot);

		public delegate void NodeLifecycleEvent(CircuitNode node);

		public const int NULL_CIRCUIT_NODE_ID = 0;

		private static long globalMaxCircuitNodeId = 0L;

		private static object circuitIdLockObj = new object();

		public static LogMessage LogEvent = null;

		public const int ON_TRUE = 1;

		public const int OFF_FALSE = 0;

		public int ExecutionOrder = -1;

		public NodeTransformData NodeTransformData = new NodeTransformData
		{
			Position = new Vector3Data
			{
				X = 0f,
				Y = 0f,
				Z = 0f
			},
			Rotation = new Vector3Data
			{
				X = 0f,
				Y = 0f,
				Z = 0f
			}
		};

		private OutputSignal[] OutputSignals = new OutputSignal[8];

		public Dictionary<InputSlot, CircuitLink> Inputs = new Dictionary<InputSlot, CircuitLink>(EqualityComparers.InputSlotComparer);

		public Dictionary<OutputSlot, HashSet<CircuitLink>> Outputs = new Dictionary<OutputSlot, HashSet<CircuitLink>>(EqualityComparers.OutputSlotComparer);

		public NodeMetadataChanged NodeMetadataChangedEvent;

		private CircuitNodeGraph _nodeGraph;

		private OutputSignal[] outputValuesDeserializationBuffer = new OutputSignal[8];

		public static NodeConnectionChanged OnNodesConnectedEvent = null;

		public static NodeConnectionChanged OnNodesDisconnectedEvent = null;

		public static NodeLifecycleEvent OnNodeDestroyedEvent = null;

		public static NodeLifecycleEvent OnNodeInstantiatedEvent = null;

		private static Dictionary<int, CircuitNode> AllNodes = new Dictionary<int, CircuitNode>();

		private static InputMetadata[] allSlotsInputMetadata = null;

		private static OutputMetadata[] allSlotsOutputMetadata = null;

		public virtual bool IsVirtual => false;

		internal virtual bool IsRootNode => false;

		internal virtual bool IsStateful => false;

		internal bool IsMerging { get; set; }

		public CircuitNode PairedNode { get; set; }

		public bool HasConnectedInputs
		{
			get
			{
				for (int i = 0; i < IOSlots.AllInputSlots.Length; i++)
				{
					if (Inputs.ContainsKey(IOSlots.AllInputSlots[i]))
					{
						return true;
					}
				}
				return false;
			}
		}

		public bool HasConnectedOutputs => Outputs.Count > 0;

		public int NodeId { get; private set; }

		public string NodeName { get; private set; }

		public NodeMetadata NodeMetadata { get; private set; }

		public CircuitNodeGraph NodeGraph => _nodeGraph;

		internal bool Destroyed { get; private set; }

		protected string OutputSignalString
		{
			get
			{
				if (NodeMetadata.OutputMetadata == null || !NodeMetadata.OutputMetadata.Any())
				{
					return string.Empty;
				}
				return NodeMetadata.OutputMetadata.Select(delegate(OutputMetadata om)
				{
					string text = om.OutputSlot.ToString();
					string text2 = text.Substring(0, Math.Min(3, text.Length));
					string text3 = OutputSignals[(int)om.OutputSlot].Value.ToString();
					return text2 + ":" + text3;
				}).Aggregate((string s, string s1) => s + "," + s1);
			}
		}

		protected string InputSignalString
		{
			get
			{
				if (Inputs.Count == 1 && Inputs.ContainsKey(InputSlot.VIRTUAL))
				{
					return string.Empty;
				}
				List<KeyValuePair<InputSlot, CircuitLink>> list = Inputs.ToList();
				list.Sort((KeyValuePair<InputSlot, CircuitLink> kvp1, KeyValuePair<InputSlot, CircuitLink> kvp2) => kvp1.Key.ToString().CompareTo(kvp2.Key.ToString()));
				return list.Where((KeyValuePair<InputSlot, CircuitLink> _) => _.Key != InputSlot.VIRTUAL).Select(delegate(KeyValuePair<InputSlot, CircuitLink> _)
				{
					string text = _.Key.ToString();
					string text2 = text.Substring(0, Math.Min(3, text.Length));
					int num = 0;
					if (Inputs.TryGetValue(_.Key, out var value))
					{
						num = value.SourceNode.GetOutputSignal(value.OutputSlot);
					}
					return text2 + ":" + num;
				}).Aggregate((string s, string s1) => s + "," + s1);
			}
		}

		public virtual string NodeVisualizationLabel
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder(GetType().Name + " " + NodeName + "\\n" + NodeId);
				stringBuilder.Append("\\n").Append("Order: ").Append(ExecutionOrder);
				stringBuilder.Append("\\n").Append("Inputs: [");
				if (Inputs.Count > 0)
				{
					stringBuilder.Append(InputSignalString);
				}
				stringBuilder.Append("]");
				stringBuilder.Append("\\n").Append("Outputs: [");
				if (NodeMetadata.OutputMetadata.Any())
				{
					stringBuilder.Append(OutputSignalString);
				}
				stringBuilder.Append("]");
				return stringBuilder.ToString();
			}
		}

		public static int NodeCount => AllNodes.Count;

		public static InputMetadata[] AllSlotsInputMetadata
		{
			get
			{
				if (allSlotsInputMetadata == null)
				{
					List<InputMetadata> list = new List<InputMetadata>();
					InputSlot[] allInputSlots = IOSlots.AllInputSlots;
					foreach (InputSlot inputSlot in allInputSlots)
					{
						list.Add(new InputMetadata
						{
							InputSlot = inputSlot
						});
					}
					allSlotsInputMetadata = list.ToArray();
				}
				return allSlotsInputMetadata;
			}
		}

		public static OutputMetadata[] AllSlotsOutputMetadata
		{
			get
			{
				if (allSlotsOutputMetadata == null)
				{
					List<OutputMetadata> list = new List<OutputMetadata>();
					OutputSlot[] allOutputSlots = IOSlots.AllOutputSlots;
					foreach (OutputSlot outputSlot in allOutputSlots)
					{
						list.Add(new OutputMetadata
						{
							OutputSlot = outputSlot
						});
					}
					allSlotsOutputMetadata = list.ToArray();
				}
				return allSlotsOutputMetadata;
			}
		}

		public static int NewNodeId()
		{
			lock (circuitIdLockObj)
			{
				globalMaxCircuitNodeId++;
				return (int)globalMaxCircuitNodeId;
			}
		}

		internal static int SetPossibleMaxId(int newPossibleMax)
		{
			lock (circuitIdLockObj)
			{
				if (newPossibleMax > globalMaxCircuitNodeId)
				{
					globalMaxCircuitNodeId = newPossibleMax;
				}
				return (int)globalMaxCircuitNodeId;
			}
		}

		public static void ResetMaxNodeId()
		{
			lock (circuitIdLockObj)
			{
				globalMaxCircuitNodeId = 0L;
			}
		}

		public static long GetMaxNodeId()
		{
			lock (circuitIdLockObj)
			{
				return globalMaxCircuitNodeId;
			}
		}

		protected static void GlobalLog(CircuitNode node, string message)
		{
			if (LogEvent != null)
			{
				LogEvent(node.NodeId, message);
			}
		}

		public void Log(string message)
		{
			GlobalLog(this, message);
		}

		public void SetLocalPosition(float x, float y, float z)
		{
			NodeTransformData.Position.X = x;
			NodeTransformData.Position.Y = y;
			NodeTransformData.Position.Z = z;
		}

		protected abstract InputMetadata[] GetInputMetadata();

		protected abstract OutputMetadata[] GetOutputMetadata();

		protected virtual string GetNodeDescription()
		{
			return NodeName;
		}

		public CircuitNode(string name, int nodeId, CircuitNodeGraph graph)
		{
			NodeName = name;
			NodeId = nodeId;
			AllNodes.Add(NodeId, this);
			if (graph == null)
			{
				graph = new CircuitNodeGraph();
			}
			SetNodeGraph(graph);
			ReconstructNodeMetadata();
			SendNodeInstantiatedEvent(this);
		}

		protected void ReconstructNodeMetadata()
		{
			NodeMetadata nodeMetadata = new NodeMetadata
			{
				InputMetadata = GetInputMetadata(),
				OutputMetadata = GetOutputMetadata(),
				NodeDescription = GetNodeDescription()
			};
			NodeMetadata = nodeMetadata;
			if (NodeMetadataChangedEvent != null)
			{
				NodeMetadataChangedEvent(NodeMetadata);
			}
		}

		public virtual CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = new CircuitNodeData
			{
				NodeId = NodeId,
				PairedNodeId = ((PairedNode != null) ? PairedNode.NodeId : 0),
				NodeType = Serialization.GetNodeTypeGuid(this).ToByteString()
			};
			circuitNodeData.CircuitLinks.AddRange(Inputs.Values.Select((CircuitLink _) => _.Serialize()));
			foreach (HashSet<CircuitLink> value in Outputs.Values)
			{
				foreach (CircuitLink item in value)
				{
					circuitNodeData.CircuitLinks.Add(item.Serialize());
				}
			}
			return circuitNodeData;
		}

		public virtual void Init(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			if (data.PairedNodeId != 0)
			{
				int num = nodeIdMap[data.PairedNodeId];
				PairedNode = Find(num);
				RuntimeAssert.AssertFormat(PairedNode != null, "PairedNode with ID {0}=>{1} can't be null!", data.PairedNodeId, num);
			}
		}

		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
			RepeatedField<CircuitLinkData> circuitLinks = data.CircuitLinks;
			new HashSet<CircuitLink>();
			foreach (CircuitLinkData item in circuitLinks)
			{
				int num = nodeIdMap[item.SourceNodeId];
				int num2 = nodeIdMap[item.DestNodeId];
				CircuitNode circuitNode = Find(num);
				CircuitNode circuitNode2 = Find(num2);
				InputSlot inputSlot = (InputSlot)item.InputSlot;
				OutputSlot outputSlot = (OutputSlot)item.OutputSlot;
				if (circuitNode != null && circuitNode2 != null)
				{
					AddLinks(new CircuitLink(circuitNode, circuitNode2, inputSlot, outputSlot));
					if (circuitNode2 == this)
					{
						if (circuitNode is LoopNode && !circuitNode2.IsVirtual)
						{
							SendNodesConnectedEvent(circuitNode.PairedNode, circuitNode2, inputSlot, outputSlot);
						}
						else if (!circuitNode.IsVirtual && !circuitNode2.IsVirtual)
						{
							SendNodesConnectedEvent(circuitNode, circuitNode2, inputSlot, outputSlot);
						}
					}
					continue;
				}
				throw new InvalidOperationException($"Found null node in deserialized link!\nSource {item.SourceNodeId}[{num}] {circuitNode}\nDest {item.DestNodeId}[{num2}] {circuitNode2}");
			}
		}

		public virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
			SerializeOutputValues(bitPacker);
		}

		public virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
			DeserializeOutputValues(bitPacker);
		}

		private void SerializeOutputValues(BitPacker bitPacker)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < NodeMetadata.OutputMetadata.Length; i++)
			{
				OutputSlot outputSlot = NodeMetadata.OutputMetadata[i].OutputSlot;
				if (Outputs.ContainsKey(outputSlot))
				{
					num2++;
					if (OutputSignals[(int)outputSlot].Value != 0)
					{
						num++;
					}
				}
			}
			bitPacker.WriteInt(num, 0, num2);
			for (int j = 0; j < NodeMetadata.OutputMetadata.Length; j++)
			{
				OutputSlot outputSlot2 = NodeMetadata.OutputMetadata[j].OutputSlot;
				if (Outputs.ContainsKey(outputSlot2))
				{
					int num3 = (int)outputSlot2;
					int value = OutputSignals[num3].Value;
					if (value != 0)
					{
						bool isMomentary = OutputSignals[num3].IsMomentary;
						bitPacker.WriteInt(num3, 0, 7);
						bitPacker.WriteInt(value, int.MinValue, int.MaxValue);
						bitPacker.WriteBool(isMomentary);
					}
				}
			}
		}

		private void DeserializeOutputValues(BitPacker bitPacker)
		{
			Array.Clear(outputValuesDeserializationBuffer, 0, 8);
			int value = 0;
			int num = 0;
			for (int i = 0; i < NodeMetadata.OutputMetadata.Length; i++)
			{
				OutputSlot outputSlot = NodeMetadata.OutputMetadata[i].OutputSlot;
				if (Outputs.ContainsKey(outputSlot))
				{
					num++;
				}
			}
			bitPacker.ReadInt(out value, 0, num);
			for (int j = 0; j < value; j++)
			{
				bitPacker.ReadInt(out var value2, 0, 7);
				bitPacker.ReadInt(out var value3, int.MinValue, int.MaxValue);
				bitPacker.ReadBool(out var value4);
				outputValuesDeserializationBuffer[value2].Value = value3;
				outputValuesDeserializationBuffer[value2].IsMomentary = value4;
			}
			for (int k = 0; k < NodeMetadata.OutputMetadata.Length; k++)
			{
				OutputSlot outputSlot2 = NodeMetadata.OutputMetadata[k].OutputSlot;
				if (Outputs.ContainsKey(outputSlot2))
				{
					int num2 = (int)outputSlot2;
					SetOutput(outputSlot2, outputValuesDeserializationBuffer[num2].Value, outputValuesDeserializationBuffer[num2].IsMomentary);
				}
			}
		}

		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
			if (_nodeGraph != newNodeGraph)
			{
				RuntimeAssert.Assert(newNodeGraph != null || Destroyed, "Can't set newNodeGraph to null unless we're destroying!");
				if (_nodeGraph != null)
				{
					_nodeGraph.RemoveNode(this);
				}
				_nodeGraph = newNodeGraph;
				if (_nodeGraph != null)
				{
					_nodeGraph.AddNode(this, skipMerge);
				}
			}
		}

		internal static bool ConnectNodes(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			RuntimeAssert.Assert(sourceNode != null, "SourceNode cannot be null");
			RuntimeAssert.Assert(!sourceNode.Destroyed, "SourceNode cannot be connected while destroyed");
			RuntimeAssert.Assert(destNode != null, "DestNode cannot be null");
			RuntimeAssert.Assert(!destNode.Destroyed, "DestNode cannot be connected while destroyed");
			if (destNode.CanConnectInput(sourceNode, inputSlot, outputSlot) && sourceNode.CanConnectOutput(inputSlot, outputSlot, destNode))
			{
				_ = DateTime.UtcNow;
				if (FormsLoop(sourceNode, destNode))
				{
					LoopNode loopNode = sourceNode.PairedNode as LoopNode;
					if (loopNode == null)
					{
						loopNode = new LoopNode(NewNodeId(), sourceNode.NodeGraph);
						loopNode.PairedNode = sourceNode;
						sourceNode.PairedNode = loopNode;
					}
					InputSlot inputSlot2 = IOSlots.OutputSlotToInputSlot[outputSlot];
					ConnectNodes(loopNode, destNode, inputSlot, outputSlot);
					ConnectNodes(sourceNode, loopNode, inputSlot2, outputSlot);
					SendNodesConnectedEvent(sourceNode, destNode, inputSlot, outputSlot);
					return true;
				}
				CircuitLink circuitLink = new CircuitLink(sourceNode, destNode, inputSlot, outputSlot);
				AddLinks(circuitLink);
				if (circuitLink.LinkType == LinkTypes.NormalToNormal)
				{
					SendNodesConnectedEvent(circuitLink.SourceNode, circuitLink.DestNode, inputSlot, outputSlot);
				}
				if (circuitLink.SourceNode.NodeGraph == null && circuitLink.DestNode.NodeGraph == null)
				{
					CircuitNodeGraph circuitNodeGraph = new CircuitNodeGraph();
					circuitNodeGraph.AddNode(circuitLink.SourceNode, skipMerge: true);
					circuitNodeGraph.AddNode(circuitLink.DestNode, skipMerge: true);
				}
				if (!skipMerge && circuitLink.SourceNode.NodeGraph != circuitLink.DestNode.NodeGraph)
				{
					CircuitNodeGraph.MergeGraphs(circuitLink.SourceNode, circuitLink.DestNode);
				}
				circuitLink.SourceNode.NodeGraph.NodeGraphDirty = true;
				circuitLink.DestNode.NodeGraph.NodeGraphDirty = true;
				circuitLink.SourceNode.NodeGraph.GraphRequiresSort = true;
				circuitLink.DestNode.NodeGraph.GraphRequiresSort = true;
				return true;
			}
			return false;
		}

		private static void SendNodesConnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			if (OnNodesConnectedEvent != null)
			{
				OnNodesConnectedEvent(sourceNode, destNode, inputSlot, outputSlot);
			}
		}

		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			if (OnNodesDisconnectedEvent != null)
			{
				OnNodesDisconnectedEvent(sourceNode, destNode, inputSlot, outputSlot);
			}
		}

		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
			if (OnNodeDestroyedEvent != null)
			{
				OnNodeDestroyedEvent(node);
			}
		}

		private static void SendNodeInstantiatedEvent(CircuitNode node)
		{
			if (OnNodeInstantiatedEvent != null)
			{
				OnNodeInstantiatedEvent(node);
			}
		}

		private static void AddLinks(CircuitLink link)
		{
			CircuitLink value = null;
			if (link.DestNode.Inputs.TryGetValue(link.InputSlot, out value))
			{
				link.Equals(value);
			}
			link.DestNode.Inputs[link.InputSlot] = link;
			link.SourceNode.Outputs.GetOrCreate(link.OutputSlot).Add(link);
		}

		internal static bool FormsLoop(CircuitNode sourceNode, CircuitNode destNode)
		{
			if (sourceNode.IsRootNode || sourceNode.IsVirtual)
			{
				return false;
			}
			return new HashSet<CircuitNode>(GraphTraversal.DFS(sourceNode, DFSType.DirectedBackward)).Contains(destNode);
		}

		public bool ConnectToMyInput(CircuitNode sourceNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			if (CanConnectInput(sourceNode, inputSlot, outputSlot))
			{
				return ConnectNodes(sourceNode, this, inputSlot, outputSlot, skipMerge);
			}
			return false;
		}

		protected bool CanConnectInput(CircuitNode newSourceNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			if (!SlotsCanConnect(inputSlot, outputSlot))
			{
				return false;
			}
			CircuitLink value = null;
			if (!Inputs.TryGetValue(inputSlot, out value))
			{
				return true;
			}
			return value.SourceNode.NodeId == value.DestNode.NodeId;
		}

		public bool ConnectToMyOutput(CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			if (CanConnectOutput(inputSlot, outputSlot, destNode))
			{
				return ConnectNodes(this, destNode, inputSlot, outputSlot, skipMerge);
			}
			return false;
		}

		protected bool CanConnectOutput(InputSlot inputSlot, OutputSlot outputSlot, CircuitNode destNode)
		{
			if (!SlotsCanConnect(inputSlot, outputSlot))
			{
				return false;
			}
			if (Outputs.ContainsKey(outputSlot))
			{
				foreach (CircuitLink item in Outputs[outputSlot])
				{
					if (item.InputSlot == inputSlot && item.OutputSlot == outputSlot && item.DestNode.NodeId == destNode.NodeId)
					{
						return false;
					}
				}
			}
			return true;
		}

		protected bool SlotsCanConnect(InputSlot inputSlot, OutputSlot outputSlot)
		{
			if (inputSlot != InputSlot.VIRTUAL || outputSlot != OutputSlot.VIRTUAL)
			{
				if (inputSlot != InputSlot.VIRTUAL)
				{
					return outputSlot != OutputSlot.VIRTUAL;
				}
				return false;
			}
			return true;
		}

		public void DisconnectInput(InputSlot slot)
		{
			if (Inputs.TryGetValue(slot, out var value))
			{
				DisconnectNodeLink(value);
			}
		}

		public virtual void Destroy(bool disconnectLinks = true)
		{
			if (Destroyed)
			{
				return;
			}
			Destroyed = true;
			if (disconnectLinks)
			{
				foreach (CircuitLink item in new HashSet<CircuitLink>(Outputs.SelectMany((KeyValuePair<OutputSlot, HashSet<CircuitLink>> _) => _.Value).Union(Inputs.Select((KeyValuePair<InputSlot, CircuitLink> _) => _.Value))))
				{
					DisconnectNodeLink(item);
				}
			}
			AllNodes.Remove(NodeId);
			SetNodeGraph(null);
			SendNodeDestroyedEvent(this);
		}

		public void DisconnectOutput(OutputSlot slot)
		{
			if (!Outputs.TryGetValue(slot, out var value))
			{
				return;
			}
			foreach (CircuitLink item in new HashSet<CircuitLink>(value))
			{
				DisconnectNodeLink(item);
			}
		}

		public void DisconnectOutputLink(CircuitLink linkToRemove)
		{
			if (Outputs.TryGetValue(linkToRemove.OutputSlot, out var value) && value.Contains(linkToRemove))
			{
				DisconnectNodeLink(linkToRemove);
			}
		}

		protected static void DisconnectNodeLink(CircuitLink link)
		{
			CircuitNode sourceNode = link.SourceNode;
			OutputSlot outputSlot = link.OutputSlot;
			HashSet<CircuitLink> hashSet = new HashSet<CircuitLink>();
			switch (link.LinkType)
			{
			case LinkTypes.NormalToVirtual:
				if (link.DestNode.Outputs.ContainsKey(link.OutputSlot))
				{
					foreach (CircuitLink item in new HashSet<CircuitLink>(link.DestNode.Outputs[link.OutputSlot]))
					{
						_ = item.DestNode;
						hashSet.Add(item);
						RemoveLinks(item);
					}
				}
				RemoveLinks(link);
				break;
			case LinkTypes.VirtualToNormal:
			case LinkTypes.RootToNormal:
			{
				hashSet.Add(link);
				CircuitLink circuitLink = null;
				InputSlot key = IOSlots.OutputSlotToInputSlot[link.OutputSlot];
				if (link.SourceNode.Inputs.ContainsKey(key))
				{
					circuitLink = link.SourceNode.Inputs[key];
					sourceNode = circuitLink.SourceNode;
					outputSlot = circuitLink.OutputSlot;
				}
				RemoveLinks(link);
				if (circuitLink != null && !link.SourceNode.Outputs.ContainsKey(link.OutputSlot))
				{
					RemoveLinks(circuitLink);
				}
				break;
			}
			case LinkTypes.NormalToNormal:
			case LinkTypes.RootToVirtual:
				RemoveLinks(link);
				if (!link.DestNode.IsVirtual)
				{
					hashSet.Add(link);
				}
				break;
			}
			if (!sourceNode.Destroyed)
			{
				sourceNode.NodeGraph.NodeGraphDirty = true;
			}
			if (!link.SourceNode.Destroyed)
			{
				link.SourceNode.NodeGraph.GraphRequiresSort = true;
			}
			if (!link.DestNode.Destroyed)
			{
				link.DestNode.NodeGraph.GraphRequiresSort = true;
			}
			foreach (CircuitLink item2 in hashSet)
			{
				CircuitNode destNode = item2.DestNode;
				if (!sourceNode.IsRootNode)
				{
					CheckForDisconnectedGraph(sourceNode, destNode);
				}
				if (!destNode.Destroyed)
				{
					destNode.NodeGraph.NodeGraphDirty = true;
				}
				SendNodesDisconnectedEvent(sourceNode, destNode, item2.InputSlot, outputSlot);
			}
		}

		private static void RemoveLinks(CircuitLink link)
		{
			RemoveInputSlot(link.DestNode, link.InputSlot);
			RemoveOutputLink(link.SourceNode, link);
		}

		private static bool RemoveOutputLink(CircuitNode node, CircuitLink link)
		{
			bool flag = false;
			if (node.Outputs.ContainsKey(link.OutputSlot))
			{
				HashSet<CircuitLink> hashSet = node.Outputs[link.OutputSlot];
				flag = hashSet.Remove(link);
				if (hashSet.Count == 0)
				{
					node.Outputs.Remove(link.OutputSlot);
				}
				else
				{
					node.Outputs[link.OutputSlot] = hashSet;
				}
			}
			if (flag && node.IsVirtual && !node.IsRootNode && node.Outputs.Count == 0)
			{
				node.Destroy();
				return true;
			}
			return false;
		}

		private static bool RemoveInputSlot(CircuitNode node, InputSlot inputSlot)
		{
			if (node.Inputs.Remove(inputSlot) && node.IsVirtual && node.Inputs.Count == 1 && inputSlot != InputSlot.VIRTUAL)
			{
				node.Destroy();
				return true;
			}
			return false;
		}

		private static bool CheckForDisconnectedGraph(CircuitNode sourceNode, CircuitNode destNode)
		{
			if (sourceNode.NodeGraph != destNode.NodeGraph)
			{
				return false;
			}
			IEnumerable<CircuitNode> other = GraphTraversal.DFS(sourceNode, DFSType.Undirected, ~(LinkTypes.RootToVirtual | LinkTypes.RootToNormal));
			HashSet<CircuitNode> hashSet = GraphTraversal.DFSCopy(destNode, DFSType.Undirected, ~(LinkTypes.RootToVirtual | LinkTypes.RootToNormal));
			HashSet<CircuitNode> hashSet2 = new HashSet<CircuitNode>(hashSet);
			hashSet2.IntersectWith(other);
			if (hashSet2.Count == 0)
			{
				CircuitNodeGraph circuitNodeGraph = new CircuitNodeGraph();
				foreach (CircuitNode item in hashSet)
				{
					item.SetNodeGraph(circuitNodeGraph);
				}
				sourceNode.NodeGraph.GraphRequiresSort = true;
				circuitNodeGraph.GraphRequiresSort = true;
				return true;
			}
			return false;
		}

		internal void EvaluateNode(bool isMasterClient)
		{
			int inputSignal = GetInputSignal(InputSlot.RESET);
			if (!SignalToBool(inputSignal))
			{
				_EvaluateNode(isMasterClient);
			}
			else
			{
				_ResetNode(isMasterClient);
			}
			SetContinuousOutput(OutputSlot.RESET, inputSignal);
		}

		public bool HasMomentaryOutputs()
		{
			for (int i = 0; i < OutputSignals.Length; i++)
			{
				if (OutputSignals[i].IsMomentary)
				{
					return true;
				}
			}
			return false;
		}

		public void ClearMomentaryOutputs()
		{
			for (int i = 0; i < OutputSignals.Length; i++)
			{
				if (OutputSignals[i].IsMomentary)
				{
					SetContinuousOutput((OutputSlot)i, 0);
				}
			}
		}

		protected virtual void _EvaluateNode(bool isMasterClient)
		{
		}

		protected virtual void _ResetNode(bool isMasterClient)
		{
			ClearOutputs();
		}

		protected void ClearOutputs()
		{
			Array.Clear(OutputSignals, 0, 8);
			if (!IsVirtual && PairedNode != null)
			{
				PairedNode.ClearOutputs();
			}
		}

		public int GetInputSignal(InputSlot inputSlot)
		{
			if (Inputs.TryGetValue(inputSlot, out var value))
			{
				return value.SourceNode.GetOutputSignal(value.OutputSlot);
			}
			return 0;
		}

		public int GetOutputSignal(OutputSlot outputSlot)
		{
			return OutputSignals[(int)outputSlot].Value;
		}

		protected void SetContinuousOutput(OutputSlot outputSlot, int val)
		{
			SetOutput(outputSlot, val, isMomentary: false);
		}

		protected void SetMomentaryOutput(OutputSlot outputSlot, int val)
		{
			SetOutput(outputSlot, val, isMomentary: true);
		}

		private void SetOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
			if (IsStateful && (OutputSignals[(int)outputSlot].Value != val || OutputSignals[(int)outputSlot].IsMomentary != isMomentary))
			{
				NodeGraph.NodeGraphDirty = true;
			}
			OutputSignals[(int)outputSlot].Value = val;
			OutputSignals[(int)outputSlot].IsMomentary = isMomentary;
			if (PairedNode != null && PairedNode.IsVirtual)
			{
				PairedNode.SetOutput(outputSlot, val, isMomentary);
			}
		}

		public virtual void ModifyNode(Dictionary<object, object> modifyArgs)
		{
			NodeGraph.NodeGraphDirty = true;
		}

		internal static void ClearAllNodes()
		{
			ResetMaxNodeId();
			foreach (CircuitNode item in AllNodes.Values.ToList())
			{
				item.Destroy(disconnectLinks: false);
			}
			AllNodes.Clear();
		}

		public static CircuitNode Find(ByteString guidByteString)
		{
			return Find(guidByteString.ToGuid().GetHashCode());
		}

		public static CircuitNode Find(int id)
		{
			CircuitNode value = null;
			AllNodes.TryGetValue(id, out value);
			return value;
		}

		public static int BoolToSignal(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		public static bool SignalToBool(int value)
		{
			return value != 0;
		}
	}
	public static class DictionaryExtensions
	{
		public static TValue GetOrCreate<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			if (!dict.TryGetValue(key, out var value))
			{
				value = new TValue();
				dict.Add(key, value);
			}
			return value;
		}
	}
	public delegate void UpdateGraph(int networkTimeMilliseconds, bool isMasterClient);
	public class CircuitNodeGraph : IComparable<CircuitNodeGraph>
	{
		public static List<CircuitNodeGraph> AllGraphs = new List<CircuitNodeGraph>();

		public readonly Guid GraphGuid;

		public readonly bool IsInternalGraph;

		private RootNode _rootNode;

		public bool GraphRequiresSort = true;

		internal readonly HashSet<CircuitNode> Nodes = new HashSet<CircuitNode>();

		private readonly List<CircuitNode> StatefulNodes = new List<CircuitNode>();

		private List<CircuitNode> ReverseTopologicNodes;

		private bool destroyed;

		private HashSet<CircuitNode> needsReset = new HashSet<CircuitNode>();

		private static BitPacker bitPacker;

		public RootNode RootNode
		{
			get
			{
				return _rootNode;
			}
			private set
			{
				_rootNode = value;
			}
		}

		public bool NodeGraphDirty { get; internal set; }

		public static event UpdateGraph TimeUpdate;

		internal CircuitNodeGraph(bool isInternalGraph = false)
			: this(Guid.NewGuid(), isInternalGraph)
		{
		}

		public CircuitNodeGraph(Guid guid, bool isInternalGraph = false)
			: this(guid, isInternalGraph, createRootNode: true)
		{
		}

		private CircuitNodeGraph(Guid guid, bool isInternalGraph, bool createRootNode)
		{
			GraphGuid = guid;
			IsInternalGraph = isInternalGraph;
			AllGraphs.Add(this);
			if (createRootNode)
			{
				RootNode = new RootNode(CircuitNode.NewNodeId(), this);
			}
		}

		public static void Update(int networkTimeMilliseconds, bool isMasterClient)
		{
			if (CircuitNodeGraph.TimeUpdate != null)
			{
				CircuitNodeGraph.TimeUpdate(networkTimeMilliseconds, isMasterClient);
			}
		}

		private void Destroy()
		{
			if (!destroyed)
			{
				destroyed = true;
				AllGraphs.Remove(this);
			}
		}

		public void AddNode(CircuitNode circuitNode, bool skipMerge = false)
		{
			Nodes.Add(circuitNode);
			if (circuitNode.IsStateful)
			{
				circuitNode.ConnectToMyInput(RootNode, InputSlot.VIRTUAL, OutputSlot.VIRTUAL, skipMerge);
				StatefulNodes.Add(circuitNode);
				StatefulNodes.Sort((CircuitNode a, CircuitNode b) => a.NodeId.CompareTo(b.NodeId));
			}
			else if (circuitNode.IsRootNode)
			{
				RuntimeAssert.Assert(RootNode == null, "Cannot add 2 RootNodes to the same Graph!");
				RootNode = (RootNode)circuitNode;
			}
		}

		public bool RemoveNode(CircuitNode circuitNode)
		{
			Nodes.Remove(circuitNode);
			if (circuitNode.IsStateful)
			{
				circuitNode.DisconnectInput(InputSlot.VIRTUAL);
				StatefulNodes.Remove(circuitNode);
			}
			if (Nodes.Count == 1)
			{
				Destroy();
			}
			return true;
		}

		public List<CircuitNode> Evaluate(bool isMasterClient)
		{
			NodeGraphDirty = false;
			if (GraphRequiresSort)
			{
				ReverseTopologicNodes = GraphTraversal.TopologicSort(RootNode);
				GraphRequiresSort = false;
			}
			needsReset.Clear();
			for (int num = ReverseTopologicNodes.Count - 1; num >= 0; num--)
			{
				int executionOrder = ReverseTopologicNodes.Count - num;
				ReverseTopologicNodes[num].ExecutionOrder = executionOrder;
				ReverseTopologicNodes[num].EvaluateNode(isMasterClient);
				if (ReverseTopologicNodes[num].HasMomentaryOutputs())
				{
					needsReset.Add(ReverseTopologicNodes[num]);
				}
			}
			foreach (CircuitNode item in needsReset)
			{
				item.ClearMomentaryOutputs();
			}
			return ReverseTopologicNodes;
		}

		public int CompareTo(CircuitNodeGraph other)
		{
			return GraphGuid.CompareTo(other.GraphGuid);
		}

		public static byte[] SerializeRuntimeState()
		{
			using MemoryStream memoryStream = new MemoryStream();
			bitPacker.StartWriting(memoryStream);
			foreach (CircuitNodeGraph allGraph in AllGraphs)
			{
				foreach (CircuitNode statefulNode in allGraph.StatefulNodes)
				{
					statefulNode.SerializeRuntimeState(bitPacker);
				}
			}
			bitPacker.FinishWriting();
			return memoryStream.ToArray();
		}

		public static void DeserializeRuntimeState(byte[] data)
		{
			using MemoryStream stream = new MemoryStream(data);
			bitPacker.StartReading(stream, data.Length);
			foreach (CircuitNodeGraph allGraph in AllGraphs)
			{
				foreach (CircuitNode statefulNode in allGraph.StatefulNodes)
				{
					statefulNode.DeserializeRuntimeState(bitPacker);
				}
			}
			bitPacker.FinishReading();
		}

		public static CircuitNodeGraphCollectionData PersistAll()
		{
			CircuitNodeGraphCollectionData circuitNodeGraphCollectionData = new CircuitNodeGraphCollectionData();
			IEnumerable<CircuitNodeGraphData> values = from g in AllGraphs
				where !g.IsInternalGraph
				select g.Persist();
			circuitNodeGraphCollectionData.Graphs.AddRange(values);
			return circuitNodeGraphCollectionData;
		}

		public static void DestroyAll()
		{
			AllGraphs.Clear();
			CircuitNode.ClearAllNodes();
		}

		public static void DeserializeAll(CircuitNodeGraphCollectionData data, out Dictionary<int, int> nodeIdMappings)
		{
			DestroyAll();
			nodeIdMappings = new Dictionary<int, int>();
			foreach (CircuitNodeGraphData graph in data.Graphs)
			{
				Deserialize(graph, reassignNodeIds: false, out var nodeIdMap);
				foreach (KeyValuePair<int, int> item in nodeIdMap)
				{
					nodeIdMappings.Add(item.Key, item.Value);
				}
			}
		}

		public CircuitNodeGraphData Persist()
		{
			RuntimeAssert.Assert(!destroyed, "Should not be persisting destroyed graph!");
			CircuitNodeGraphData obj = new CircuitNodeGraphData
			{
				NodeGraphGuid = GraphGuid.ToByteString(),
				RootNodeData = RootNode.Serialize()
			};
			List<CircuitNode> list = Nodes.ToList();
			list.Remove(RootNode);
			list.Sort((CircuitNode n, CircuitNode n2) => n.NodeId.CompareTo(n2.NodeId));
			RuntimeAssert.Assert(list.Count > 0, "Should not be persisting empty graph!");
			obj.CircuitNodes.AddRange(list.Select((CircuitNode n) => n.Serialize()));
			return obj;
		}

		public static CircuitNodeGraph Deserialize(CircuitNodeGraphData data, bool reassignNodeIds, out Dictionary<int, int> nodeIdMap)
		{
			CircuitNodeGraph circuitNodeGraph = new CircuitNodeGraph(data.NodeGraphGuid.ToGuid(), data.IsInternalGraph, createRootNode: false);
			nodeIdMap = new Dictionary<int, int>();
			Dictionary<CircuitNode, CircuitNodeData> dictionary = new Dictionary<CircuitNode, CircuitNodeData>();
			CircuitNode key = Serialization.InstantiateNode(data.RootNodeData, circuitNodeGraph, reassignNodeIds, nodeIdMap);
			dictionary[key] = data.RootNodeData;
			RuntimeAssert.Assert(circuitNodeGraph.RootNode != null, "No root node for graph!");
			foreach (CircuitNodeData circuitNode in data.CircuitNodes)
			{
				CircuitNode key2 = Serialization.InstantiateNode(circuitNode, circuitNodeGraph, reassignNodeIds, nodeIdMap);
				dictionary[key2] = circuitNode;
			}
			foreach (KeyValuePair<CircuitNode, CircuitNodeData> item in dictionary)
			{
				item.Key.Init(item.Value, reassignNodeIds, nodeIdMap);
			}
			foreach (KeyValuePair<CircuitNode, CircuitNodeData> item2 in dictionary)
			{
				item2.Key.DeserializeLinks(item2.Value, nodeIdMap);
			}
			RuntimeAssert.Assert(circuitNodeGraph.Nodes.Count > 1, "Deserialized graph had no nodes!");
			return circuitNodeGraph;
		}

		public static CircuitNodeGraph MergeGraphs(CircuitNode nodeA, CircuitNode nodeB)
		{
			RuntimeAssert.Assert(nodeA.NodeGraph != null, "NodeA Node Graph was null!");
			RuntimeAssert.Assert(nodeB.NodeGraph != null, "NodeB Node Graph was null!");
			int count = nodeA.NodeGraph.Nodes.Count;
			int count2 = nodeB.NodeGraph.Nodes.Count;
			CircuitNodeGraph nodeGraph;
			CircuitNodeGraph nodeGraph2;
			if (count > count2)
			{
				nodeGraph = nodeA.NodeGraph;
				nodeGraph2 = nodeB.NodeGraph;
			}
			else if (count2 > count)
			{
				nodeGraph = nodeB.NodeGraph;
				nodeGraph2 = nodeA.NodeGraph;
			}
			else
			{
				switch (nodeA.NodeGraph.CompareTo(nodeB.NodeGraph))
				{
				case -1:
					nodeGraph = nodeA.NodeGraph;
					nodeGraph2 = nodeB.NodeGraph;
					break;
				case 1:
					nodeGraph = nodeB.NodeGraph;
					nodeGraph2 = nodeA.NodeGraph;
					break;
				default:
					return nodeA.NodeGraph;
				}
			}
			return MergeInto(nodeGraph, nodeGraph2, nodeA, nodeB);
		}

		private static CircuitNodeGraph MergeInto(CircuitNodeGraph toGraph, CircuitNodeGraph fromGraph, params CircuitNode[] nodes)
		{
			HashSet<CircuitNode> hashSet = new HashSet<CircuitNode>(nodes);
			if (fromGraph != null)
			{
				foreach (CircuitNode node in fromGraph.Nodes)
				{
					if (!node.IsRootNode)
					{
						hashSet.Add(node);
					}
				}
				fromGraph.RootNode.DisconnectOutput(OutputSlot.VIRTUAL);
			}
			foreach (CircuitNode item in hashSet)
			{
				if (!item.IsRootNode)
				{
					item.SetNodeGraph(toGraph, skipMerge: true);
				}
			}
			return toGraph;
		}

		public void Visualize(string fileName, bool useDFS = false, bool showRootConnections = false)
		{
			Visualize("C:\\RecRoom\\Circuits\\CircuitsApp\\HTML.txt", fileName, useDFS, showRootConnections);
		}

		public void VisualizeWithFormatString(string htmlString, string outputFileName, bool useDFS = false, bool showRootConnections = false)
		{
			string htmlString2 = htmlString;
			IEnumerable<CircuitNode> enumerable = ((!useDFS) ? ((ICollection<CircuitNode>)RootNode.NodeGraph.Nodes) : ((ICollection<CircuitNode>)GraphTraversal.DFS(RootNode, DFSType.Undirected, (LinkTypes)(-1)).ToList()));
			if (enumerable.Count() > 100)
			{
				Console.WriteLine("Too big to visualize");
				return;
			}
			string tempPath = Path.GetTempPath();
			if (!Directory.Exists(tempPath))
			{
				Directory.CreateDirectory(tempPath);
			}
			string text = outputFileName;
			if (!outputFileName.StartsWith(tempPath))
			{
				text = tempPath + outputFileName;
			}
			if (!text.EndsWith(".html"))
			{
				text += ".html";
			}
			HashSet<NodeGraphNode> hashSet = new HashSet<NodeGraphNode>();
			List<string> list = new List<string>();
			foreach (CircuitNode item in enumerable)
			{
				if (item is NodeGraphNode)
				{
					hashSet.Add(item as NodeGraphNode);
				}
				string nodeVisualizationLabel = item.NodeVisualizationLabel;
				list.Add($"{{ id: '{item.NodeId}', label: '{nodeVisualizationLabel}', shape: 'box', shapeProperties: {{ borderDashes:{item.IsVirtual.ToString().ToLower()} }} }}");
			}
			List<string> list2 = new List<string>();
			foreach (CircuitNode item2 in enumerable)
			{
				foreach (KeyValuePair<OutputSlot, HashSet<CircuitLink>> output in item2.Outputs)
				{
					OutputSlot key = output.Key;
					foreach (CircuitLink item3 in output.Value)
					{
						if (showRootConnections || !item3.SourceNode.IsRootNode)
						{
							string text2 = SlotToStringColor(key);
							string text3 = LinkLabel(item3);
							bool flag = item3.SourceNode.IsVirtual || item3.DestNode.IsVirtual;
							list2.Add($"{{ from: '{item3.SourceNode.NodeId}', to: '{item3.DestNode.NodeId}', arrows: 'to', color:{{color:'{text2}'}}, dashes:{flag.ToString().ToLower()}, label:'{text3}' }}");
						}
					}
				}
			}
			string arg = ((list.Count > 0) ? ("\t" + list.Aggregate((string s, string s1) => s + ",\n\t" + s1)) : string.Empty);
			string arg2 = ((list2.Count > 0) ? ("\t" + list2.Aggregate((string s, string s1) => s + ",\n\t" + s1)) : string.Empty);
			htmlString = string.Format(htmlString, arg, arg2);
			File.WriteAllText(text, htmlString);
			Process process = new Process();
			try
			{
				process.StartInfo.UseShellExecute = true;
				process.StartInfo.FileName = text;
				process.Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			foreach (NodeGraphNode item4 in hashSet)
			{
				item4.InternalNodeGraph.VisualizeWithFormatString(htmlString2, text.Replace(".html", "_internal" + item4.NodeName + ".html"));
			}
		}

		public void Visualize(string formatStringFilePath, string outputFileName, bool useDFS = false, bool showRootConnections = false)
		{
			string htmlString = File.ReadAllText(formatStringFilePath);
			VisualizeWithFormatString(htmlString, outputFileName, useDFS, showRootConnections);
		}

		private string LinkLabel(CircuitLink link)
		{
			string text = Regex.Replace(link.LinkType.ToString(), "[a-z]", "");
			string text2 = link.OutputSlot.ToString();
			string text3 = link.InputSlot.ToString();
			return text2.Substring(0, Math.Min(3, text2.Length)) + "->" + text3.Substring(0, Math.Min(3, text3.Length)) + "\\n" + text;
		}

		private static string SlotToStringColor(OutputSlot slot)
		{
			return slot switch
			{
				OutputSlot.G => "green", 
				OutputSlot.B => "blue", 
				OutputSlot.R => "red", 
				OutputSlot.C => "#00FFFF", 
				OutputSlot.M => "#FF00FF", 
				OutputSlot.Y => "#FFFF00", 
				OutputSlot.K => "#000000", 
				OutputSlot.RESET => "#bcbcbc", 
				OutputSlot.VIRTUAL => "#FFA500", 
				_ => "black", 
			};
		}

		static CircuitNodeGraph()
		{
			CircuitNodeGraph.TimeUpdate = null;
			bitPacker = new BitPacker();
		}
	}
	public enum InputSlot
	{
		R,
		G,
		B,
		C,
		M,
		Y,
		K,
		RESET,
		VIRTUAL
	}
	public enum OutputSlot
	{
		R,
		G,
		B,
		C,
		M,
		Y,
		K,
		RESET,
		VIRTUAL
	}
	public static class IOSlots
	{
		public static InputSlot[] AllInputSlots = ((InputSlot[])Enum.GetValues(typeof(InputSlot))).Where((InputSlot t) => t != InputSlot.VIRTUAL).ToArray();

		public static OutputSlot[] AllOutputSlots = ((OutputSlot[])Enum.GetValues(typeof(OutputSlot))).Where((OutputSlot t) => t != OutputSlot.VIRTUAL).ToArray();

		public const int SlotCount = 8;

		public static Dictionary<InputSlot, OutputSlot> InputSlotToOutputSlot = new Dictionary<InputSlot, OutputSlot>
		{
			{
				InputSlot.R,
				OutputSlot.R
			},
			{
				InputSlot.G,
				OutputSlot.G
			},
			{
				InputSlot.B,
				OutputSlot.B
			},
			{
				InputSlot.C,
				OutputSlot.C
			},
			{
				InputSlot.M,
				OutputSlot.M
			},
			{
				InputSlot.Y,
				OutputSlot.Y
			},
			{
				InputSlot.K,
				OutputSlot.K
			},
			{
				InputSlot.RESET,
				OutputSlot.RESET
			},
			{
				InputSlot.VIRTUAL,
				OutputSlot.VIRTUAL
			}
		};

		public static Dictionary<OutputSlot, InputSlot> OutputSlotToInputSlot = new Dictionary<OutputSlot, InputSlot>
		{
			{
				OutputSlot.R,
				InputSlot.R
			},
			{
				OutputSlot.G,
				InputSlot.G
			},
			{
				OutputSlot.B,
				InputSlot.B
			},
			{
				OutputSlot.C,
				InputSlot.C
			},
			{
				OutputSlot.M,
				InputSlot.M
			},
			{
				OutputSlot.Y,
				InputSlot.Y
			},
			{
				OutputSlot.K,
				InputSlot.K
			},
			{
				OutputSlot.RESET,
				InputSlot.RESET
			},
			{
				OutputSlot.VIRTUAL,
				InputSlot.VIRTUAL
			}
		};
	}
	[CircuitNodeUuid("2385E75E-E0DA-45BF-8D66-17DC9FFB9FC7")]
	public class BooleanNode : CircuitNode
	{
		public enum BooleanModes
		{
			And,
			Or,
			Not
		}

		public const string MODE_ARG = "mode";

		private static readonly InputMetadata[] NotInputMeta = new InputMetadata[2]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly OutputMetadata[] OutputMeta = new OutputMetadata[2]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly Dictionary<BooleanModes, string> ModeSymbols = new Dictionary<BooleanModes, string>
		{
			{
				BooleanModes.And,
				"And"
			},
			{
				BooleanModes.Or,
				"Or"
			},
			{
				BooleanModes.Not,
				"Not"
			}
		};

		private BooleanModes booleanMode;

		private List<int> inputs = new List<int>();

		public BooleanModes BooleanMode
		{
			get
			{
				return booleanMode;
			}
			internal set
			{
				if (booleanMode != value)
				{
					booleanMode = value;
					ReconstructNodeMetadata();
				}
			}
		}

		public static string GetModeSymbol(BooleanModes mode)
		{
			return ModeSymbols[mode];
		}

		public BooleanNode(int nodeId, CircuitNodeGraph graph)
			: base("BooleanNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			int val = CalcOutput();
			SetContinuousOutput(OutputSlot.R, val);
		}

		private int CalcOutput()
		{
			return BooleanMode switch
			{
				BooleanModes.And => CalcAndOutput(), 
				BooleanModes.Or => CalcOrOutput(), 
				BooleanModes.Not => CircuitNode.BoolToSignal(!CircuitNode.SignalToBool(GetInputSignal(InputSlot.R))), 
				_ => 0, 
			};
		}

		private int CalcAndOutput()
		{
			FetchInputs();
			bool flag = true;
			for (int i = 0; i < inputs.Count; i++)
			{
				flag = flag && CircuitNode.SignalToBool(inputs[i]);
			}
			return CircuitNode.BoolToSignal(inputs.Count > 0 && flag);
		}

		private int CalcOrOutput()
		{
			FetchInputs();
			bool flag = false;
			for (int i = 0; i < inputs.Count; i++)
			{
				flag = flag || CircuitNode.SignalToBool(inputs[i]);
			}
			return CircuitNode.BoolToSignal(inputs.Count > 0 && flag);
		}

		private void FetchInputs()
		{
			inputs.Clear();
			InputMetadata[] inputMetadata = GetInputMetadata();
			for (int i = 0; i < inputMetadata.Length; i++)
			{
				InputMetadata inputMetadata2 = inputMetadata[i];
				if (Inputs.ContainsKey(inputMetadata2.InputSlot) && inputMetadata2.InputSlot != InputSlot.RESET)
				{
					inputs.Add(GetInputSignal(inputMetadata2.InputSlot));
				}
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			BooleanModes booleanModes = BooleanMode;
			if ((uint)booleanModes <= 1u)
			{
				return CircuitNode.AllSlotsInputMetadata;
			}
			return NotInputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMeta;
		}

		protected override string GetNodeDescription()
		{
			return GetModeSymbol(BooleanMode);
		}

		public override void Init(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			base.Init(data, reassignNodeIds, nodeIdMap);
			BooleanMode = (BooleanModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)BooleanMode;
			return circuitNodeData;
		}

		public override void ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base.ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				BooleanMode = (BooleanModes)value;
			}
		}
	}
	[CircuitNodeUuid("B7BA1A4B-EA04-496F-B8B6-A2FB7C4A42B9")]
	public class ContinuousSourceNode : SourceNode
	{
		internal override bool IsStateful => true;

		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
			: base("ContinuousSourceNode", nodeId, graph)
		{
		}

		public override void SetOutput(OutputSlot outputSlot, int value)
		{
			SetContinuousOutput(outputSlot, value);
		}
	}
	[CircuitNodeUuid("B71B05C0-D6FD-4C49-A70C-085C14E95317")]
	public class RandomNode : CircuitNode
	{
		private const InputSlot MIN_SLOT = InputSlot.G;

		private const InputSlot MAX_SLOT = InputSlot.B;

		private const string nodeDescription = "RAND [Green, Blue)";

		private Random random;

		private int seed;

		private static readonly InputMetadata[] inputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Generate Signal"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Min"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.B,
				Description = "Max"
			}
		};

		private static readonly OutputMetadata[] outputMeta = new OutputMetadata[1]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "RAND [Green, Blue)"
			}
		};

		private bool lastCalcShouldGenerate;

		internal override bool IsStateful => true;

		public int RandomSeed
		{
			get
			{
				return seed;
			}
			set
			{
				if (seed != value)
				{
					seed = value;
					random = new Random(seed);
				}
			}
		}

		public RandomNode(int nodeId, CircuitNodeGraph graph)
			: base("RandomNode", nodeId, graph)
		{
			random = new Random();
		}

		protected override string GetNodeDescription()
		{
			return "RAND [Green, Blue)";
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return outputMeta;
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			if (isMasterClient)
			{
				bool flag = CircuitNode.SignalToBool(GetInputSignal(InputSlot.R)) && !lastCalcShouldGenerate;
				if (flag)
				{
					int val = CalcOutput();
					SetContinuousOutput(OutputSlot.R, val);
				}
				lastCalcShouldGenerate = flag;
			}
		}

		private int CalcOutput()
		{
			int inputSignal = GetInputSignal(InputSlot.G);
			int inputSignal2 = GetInputSignal(InputSlot.B);
			if (inputSignal > inputSignal2)
			{
				return 0;
			}
			if (inputSignal == inputSignal2)
			{
				return inputSignal;
			}
			return random.Next(inputSignal, inputSignal2);
		}
	}
	public abstract class SourceNode : CircuitNode
	{
		protected OutputMetadata[] OutputMeta = new OutputMetadata[0];

		private static readonly InputMetadata[] InputMeta = new InputMetadata[0];

		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
			OutputMeta = outputMetadata;
			ReconstructNodeMetadata();
		}

		public SourceNode(string name, int nodeId, CircuitNodeGraph graph)
			: base(name, nodeId, graph)
		{
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMeta;
		}

		public abstract void SetOutput(OutputSlot outputSlot, int value);
	}
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169B82")]
	public class ComparerNode : CircuitNode
	{
		public enum ComparerModes
		{
			Equals,
			NotEquals,
			GreaterThan,
			GreaterThanEqualTo,
			LessThan,
			LessThanEqualTo
		}

		public const string MODE_ARG = "mode";

		private static readonly InputMetadata[] InputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly Dictionary<ComparerModes, string> ModeSymbols = new Dictionary<ComparerModes, string>
		{
			{
				ComparerModes.Equals,
				"=="
			},
			{
				ComparerModes.NotEquals,
				"!="
			},
			{
				ComparerModes.GreaterThan,
				">"
			},
			{
				ComparerModes.GreaterThanEqualTo,
				">="
			},
			{
				ComparerModes.LessThan,
				"<"
			},
			{
				ComparerModes.LessThanEqualTo,
				"<="
			}
		};

		private ComparerModes comparerMode;

		public ComparerModes ComparerMode
		{
			get
			{
				return comparerMode;
			}
			internal set
			{
				if (comparerMode != value)
				{
					comparerMode = value;
					ReconstructNodeMetadata();
				}
			}
		}

		public override string NodeVisualizationLabel => GetNodeDescription() + "\\n" + base.NodeVisualizationLabel;

		public static string GetModeSymbol(ComparerModes mode)
		{
			return ModeSymbols[mode];
		}

		public ComparerNode(int nodeId, CircuitNodeGraph graph)
			: base("ComparerNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			int val = CircuitNode.BoolToSignal(CalcOutput());
			SetContinuousOutput(OutputSlot.R, val);
		}

		private bool CalcOutput()
		{
			int inputSignal = GetInputSignal(InputSlot.R);
			int inputSignal2 = GetInputSignal(InputSlot.G);
			return ComparerMode switch
			{
				ComparerModes.Equals => inputSignal == inputSignal2, 
				ComparerModes.NotEquals => inputSignal != inputSignal2, 
				ComparerModes.GreaterThan => inputSignal > inputSignal2, 
				ComparerModes.GreaterThanEqualTo => inputSignal >= inputSignal2, 
				ComparerModes.LessThan => inputSignal < inputSignal2, 
				ComparerModes.LessThanEqualTo => inputSignal <= inputSignal2, 
				_ => false, 
			};
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return new OutputMetadata[2]
			{
				new OutputMetadata
				{
					OutputSlot = OutputSlot.R,
					Description = GetNodeDescription()
				},
				new OutputMetadata
				{
					OutputSlot = OutputSlot.RESET,
					Description = "Reset"
				}
			};
		}

		protected override string GetNodeDescription()
		{
			return $"Red {GetModeSymbol(ComparerMode)} Green";
		}

		public override void Init(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			base.Init(data, reassignNodeIds, nodeIdMap);
			ComparerMode = (ComparerModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)ComparerMode;
			return circuitNodeData;
		}

		public override void ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base.ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				ComparerMode = (ComparerModes)value;
			}
		}
	}
	[CircuitNodeUuid("17B72DE0-4116-41DB-A99D-1523625F7EF1")]
	public class CombinatorNode : CircuitNode
	{
		public enum CombinatorModes
		{
			Add,
			Subtract,
			Multiply,
			Divide,
			Modulo
		}

		public const string MODE_ARG = "mode";

		private static readonly InputMetadata[] InputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly Dictionary<CombinatorModes, string> ModeSymbols = new Dictionary<CombinatorModes, string>
		{
			{
				CombinatorModes.Add,
				"+"
			},
			{
				CombinatorModes.Subtract,
				"-"
			},
			{
				CombinatorModes.Multiply,
				"*"
			},
			{
				CombinatorModes.Divide,
				"/"
			},
			{
				CombinatorModes.Modulo,
				"%"
			}
		};

		private CombinatorModes combinatorMode;

		public CombinatorModes CombinatorMode
		{
			get
			{
				return combinatorMode;
			}
			internal set
			{
				if (combinatorMode != value)
				{
					combinatorMode = value;
					ReconstructNodeMetadata();
				}
			}
		}

		public override string NodeVisualizationLabel => GetNodeDescription() + "\\n" + base.NodeVisualizationLabel;

		public static string GetModeSymbol(CombinatorModes mode)
		{
			return ModeSymbols[mode];
		}

		public CombinatorNode(int nodeId, CircuitNodeGraph graph)
			: base("CombinatorNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			int val = CalcOutput();
			SetContinuousOutput(OutputSlot.R, val);
		}

		private int CalcOutput()
		{
			int inputSignal = GetInputSignal(InputSlot.R);
			int inputSignal2 = GetInputSignal(InputSlot.G);
			switch (CombinatorMode)
			{
			case CombinatorModes.Add:
				return inputSignal + inputSignal2;
			case CombinatorModes.Subtract:
				return inputSignal - inputSignal2;
			case CombinatorModes.Multiply:
				return inputSignal * inputSignal2;
			case CombinatorModes.Divide:
				if (inputSignal2 != 0)
				{
					if (inputSignal == int.MinValue && inputSignal2 == -1)
					{
						return int.MaxValue;
					}
					return inputSignal / inputSignal2;
				}
				return 0;
			case CombinatorModes.Modulo:
				if (inputSignal2 > 0)
				{
					return inputSignal % inputSignal2;
				}
				return 0;
			default:
				return -1;
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return new OutputMetadata[2]
			{
				new OutputMetadata
				{
					OutputSlot = OutputSlot.R,
					Description = GetNodeDescription()
				},
				new OutputMetadata
				{
					OutputSlot = OutputSlot.RESET,
					Description = "Reset"
				}
			};
		}

		protected override string GetNodeDescription()
		{
			return $"Red {GetModeSymbol(CombinatorMode)} Green";
		}

		public override void Init(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			base.Init(data, reassignNodeIds, nodeIdMap);
			CombinatorMode = (CombinatorModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)CombinatorMode;
			return circuitNodeData;
		}

		public override void ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base.ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				CombinatorMode = (CombinatorModes)value;
			}
		}
	}
	[CircuitNodeUuid("34452A12-AFB3-4A4D-97B0-9D25F7E777C5")]
	public class DelayNode : CircuitNode
	{
		private struct DelaySignal
		{
			public int timeRemaining;

			public int value;
		}

		public const int MAX_QUEUE_SIZE = 20;

		private const int DELAY_COMPRESSION_QUANTIZATION = 100;

		private const int MAX_TIME_IN_SECONDS = 3600;

		private const int MAX_TIME_IN_MILLISECONDS = 3600000;

		private const int MAX_TIME_QUANTIZED = 36000;

		private const InputSlot SignalInputSlot = InputSlot.R;

		private const InputSlot DelayInputSlot = InputSlot.G;

		private const OutputSlot ValueOutputSlot = OutputSlot.R;

		private static InputMetadata[] InputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Signal"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Delay"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET
			}
		};

		private static OutputMetadata[] OutputMeta = new OutputMetadata[2]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET
			}
		};

		private List<DelaySignal> QueuedSignals = new List<DelaySignal>(20);

		private int lastInputSignal;

		private int? lastNetworkTime;

		internal override bool IsStateful => true;

		public int QueueSize => QueuedSignals.Count;

		public DelayNode(int nodeId, CircuitNodeGraph graph)
			: base("DelayNode", nodeId, graph)
		{
			CircuitNodeGraph.TimeUpdate += OnTimerUpdate;
		}

		public override void Destroy(bool destroyLinks = true)
		{
			base.Destroy(destroyLinks);
			CircuitNodeGraph.TimeUpdate -= OnTimerUpdate;
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMeta;
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			if (isMasterClient)
			{
				int inputSignal = GetInputSignal(InputSlot.R);
				if (inputSignal != 0 && inputSignal != lastInputSignal)
				{
					int inputSignal2 = GetInputSignal(InputSlot.G);
					inputSignal2 = 1000 * Math.Max(0, Math.Min(3600, inputSignal2));
					QueueSignal(inputSignal2, inputSignal);
				}
				lastInputSignal = inputSignal;
			}
		}

		protected override void _ResetNode(bool isMasterClient)
		{
			base._ResetNode(isMasterClient);
			QueuedSignals.Clear();
		}

		private void QueueSignal(int delay, int signal)
		{
			DelaySignal item = new DelaySignal
			{
				timeRemaining = delay,
				value = signal
			};
			int num = -1;
			for (int i = 0; i < QueuedSignals.Count; i++)
			{
				if (QueuedSignals[i].timeRemaining > delay)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				QueuedSignals.Add(item);
			}
			else
			{
				QueuedSignals.Insert(num, item);
			}
			if (QueuedSignals.Count > 20)
			{
				QueuedSignals.RemoveRange(0, QueuedSignals.Count - 20);
			}
		}

		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
			int num = (lastNetworkTime.HasValue ? (networkTime - lastNetworkTime.Value) : 0);
			lastNetworkTime = networkTime;
			if (isMasterClient && QueuedSignals.Count > 0)
			{
				for (int i = 0; i < QueuedSignals.Count; i++)
				{
					DelaySignal value = QueuedSignals[i];
					value.timeRemaining -= num;
					value.timeRemaining = Math.Max(0, value.timeRemaining);
					QueuedSignals[i] = value;
				}
				DelaySignal delaySignal = QueuedSignals[0];
				if (delaySignal.timeRemaining <= 0)
				{
					QueuedSignals.RemoveAt(0);
					SetMomentaryOutput(OutputSlot.R, delaySignal.value);
				}
			}
		}

		public override void SerializeRuntimeState(BitPacker bitPacker)
		{
			base.SerializeRuntimeState(bitPacker);
			bitPacker.WriteInt(QueuedSignals.Count, 0, 20);
			for (int i = 0; i < QueuedSignals.Count; i++)
			{
				int value = QueuedSignals[i].timeRemaining / 100;
				bitPacker.WriteInt(value, 0, 36000);
				bitPacker.WriteInt(QueuedSignals[i].value, int.MinValue, int.MaxValue);
			}
		}

		public override void DeserializeRuntimeState(BitPacker bitPacker)
		{
			base.DeserializeRuntimeState(bitPacker);
			bitPacker.ReadInt(out var value, 0, 20);
			QueuedSignals.Clear();
			for (int i = 0; i < value; i++)
			{
				bitPacker.ReadInt(out var value2, 0, 36000);
				bitPacker.ReadInt(out var value3, int.MinValue, int.MaxValue);
				QueuedSignals.Add(new DelaySignal
				{
					timeRemaining = value2 * 100,
					value = value3
				});
			}
		}
	}
	[CircuitNodeUuid("C9A59F26-0A72-4C2E-B239-6A83998E0839", InternalOnly = true)]
	public class LoopNode : VirtualNode
	{
		internal override bool IsStateful => true;

		public LoopNode(int nodeId, CircuitNodeGraph graph)
			: base("LoopNode", nodeId, graph)
		{
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return CircuitNode.AllSlotsInputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return CircuitNode.AllSlotsOutputMetadata;
		}
	}
	[CircuitNodeUuid("E7EFD8CA-92FE-4A37-9E7C-ABBE9E4DE336")]
	public class MomentarySourceNode : SourceNode
	{
		internal override bool IsStateful => true;

		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
			: base("MomentarySourceNode", nodeId, graph)
		{
		}

		public override void SetOutput(OutputSlot outputSlot, int value)
		{
			SetMomentaryOutput(outputSlot, value);
		}
	}
	[CircuitNodeUuid("6402C773-5838-4495-BC54-BC36EDE4AB0F")]
	public class ConstantSourceNode : CircuitNode
	{
		private static readonly InputMetadata[] InputMeta = new InputMetadata[0];

		private static readonly OutputMetadata[] OutputMeta = new OutputMetadata[3]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "R"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.G,
				Description = "G"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.B,
				Description = "B"
			}
		};

		internal override bool IsStateful => true;

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMeta;
		}

		public ConstantSourceNode(int nodeId, CircuitNodeGraph graph)
			: base("ConstantSourceNode", nodeId, graph)
		{
		}

		public override void Init(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			base.Init(data, reassignNodeIds, nodeIdMap);
			foreach (SlotData slotDatum in data.SlotData)
			{
				SetContinuousOutput((OutputSlot)slotDatum.Slot, slotDatum.Signal);
			}
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			OutputMetadata[] outputMeta = OutputMeta;
			for (int i = 0; i < outputMeta.Length; i++)
			{
				OutputMetadata outputMetadata = outputMeta[i];
				circuitNodeData.SlotData.Add(new SlotData
				{
					Slot = (int)outputMetadata.OutputSlot,
					Signal = GetOutputSignal(outputMetadata.OutputSlot)
				});
			}
			return circuitNodeData;
		}

		public override void ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base.ModifyNode(modifyArgs);
			OutputMetadata[] outputMeta = OutputMeta;
			for (int i = 0; i < outputMeta.Length; i++)
			{
				OutputMetadata outputMetadata = outputMeta[i];
				if (modifyArgs.TryGetValue((int)outputMetadata.OutputSlot, out var value))
				{
					SetContinuousOutput(outputMetadata.OutputSlot, (int)value);
				}
			}
		}

		public override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		public override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[CircuitNodeUuid("738B2AF2-EEBD-4316-82A9-2FBEC9B50D8B", InternalOnly = true)]
	public class NodeGraphNode : CircuitNode
	{
		[CircuitNodeUuid("86B6FD1C-4668-4BA9-8ACB-FB91E25DBFB6", InternalOnly = true)]
		public class GraphInputNode : VirtualNode
		{
			public GraphInputNode(int nodeId, CircuitNodeGraph graph)
				: base("GraphInput", nodeId, graph)
			{
			}

			public void SetOutputSignal(OutputSlot slot, int val)
			{
				SetContinuousOutput(slot, val);
			}
		}

		[CircuitNodeUuid("F8A998DB-0354-4BCD-B0E4-6BBA7CC24B89", InternalOnly = true)]
		public class GraphOutputNode : VirtualNode
		{
			public GraphOutputNode(int nodeId, CircuitNodeGraph graph)
				: base("GraphOutput", nodeId, graph)
			{
			}

			protected override void _EvaluateNode(bool isMasterClient)
			{
				foreach (KeyValuePair<InputSlot, CircuitLink> input in Inputs)
				{
					InputSlot key = input.Key;
					OutputSlot outputSlot = IOSlots.InputSlotToOutputSlot[key];
					SetContinuousOutput(outputSlot, GetInputSignal(key));
				}
			}
		}

		private GraphInputNode virtualSourceNode;

		private GraphOutputNode virtualDestNode;

		public CircuitNodeGraph InternalNodeGraph { get; private set; }

		public NodeGraphNode(int nodeId, CircuitNodeGraph graph)
			: base("NodeGraphNode", nodeId, graph)
		{
			InternalNodeGraph = new CircuitNodeGraph(isInternalGraph: true);
			virtualSourceNode = new GraphInputNode(CircuitNode.NewNodeId(), InternalNodeGraph);
			virtualDestNode = new GraphOutputNode(CircuitNode.NewNodeId(), InternalNodeGraph);
		}

		public static NodeGraphNode FromNodes(params CircuitNode[] newInternalNodes)
		{
			NodeGraphNode nodeGraphNode = new NodeGraphNode(CircuitNode.NewNodeId(), newInternalNodes[0].NodeGraph);
			nodeGraphNode.AddNode(newInternalNodes);
			return nodeGraphNode;
		}

		public void AddNode(params CircuitNode[] newInternalNodes)
		{
			for (int i = 0; i < newInternalNodes.Length; i++)
			{
				newInternalNodes[i].SetNodeGraph(InternalNodeGraph, skipMerge: true);
			}
			for (int j = 0; j < newInternalNodes.Length; j++)
			{
				HashSet<CircuitLink> hashSet = new HashSet<CircuitLink>();
				HashSet<CircuitLink> hashSet2 = new HashSet<CircuitLink>();
				foreach (CircuitLink item in new HashSet<CircuitLink>(newInternalNodes[j].Inputs.Values))
				{
					if (item.SourceNode.NodeGraph != InternalNodeGraph)
					{
						CircuitNode.DisconnectNodeLink(item);
						hashSet.Add(item);
					}
				}
				_ = newInternalNodes[j].Outputs;
				foreach (KeyValuePair<OutputSlot, HashSet<CircuitLink>> item2 in newInternalNodes[j].Outputs.ToList())
				{
					foreach (CircuitLink item3 in new HashSet<CircuitLink>(item2.Value))
					{
						if (item3.DestNode.NodeGraph != InternalNodeGraph)
						{
							CircuitNode.DisconnectNodeLink(item3);
							hashSet2.Add(item3);
						}
					}
				}
				foreach (CircuitLink item4 in hashSet)
				{
					OutputSlot? outputSlot = FindAvailableInputSlot();
					if (!outputSlot.HasValue)
					{
						break;
					}
					InputSlot inputSlot = IOSlots.OutputSlotToInputSlot[outputSlot.Value];
					item4.SourceNode.ConnectToMyOutput(this, inputSlot, item4.OutputSlot);
					newInternalNodes[j].ConnectToMyInput(virtualSourceNode, item4.InputSlot, outputSlot.Value);
				}
				foreach (CircuitLink item5 in hashSet2)
				{
					InputSlot? inputSlot2 = FindAvailableOutputSlot();
					if (!inputSlot2.HasValue)
					{
						break;
					}
					_ = IOSlots.InputSlotToOutputSlot[inputSlot2.Value];
					item5.DestNode.ConnectToMyInput(this, item5.InputSlot, IOSlots.InputSlotToOutputSlot[inputSlot2.Value]);
					newInternalNodes[j].ConnectToMyOutput(virtualDestNode, inputSlot2.Value, item5.OutputSlot);
				}
			}
			base.NodeGraph.GraphRequiresSort = true;
			InternalNodeGraph.GraphRequiresSort = true;
		}

		public OutputSlot? FindAvailableInputSlot()
		{
			for (int i = 0; i < IOSlots.AllOutputSlots.Length; i++)
			{
				OutputSlot outputSlot = IOSlots.AllOutputSlots[i];
				if (!virtualSourceNode.Outputs.ContainsKey(outputSlot))
				{
					return outputSlot;
				}
			}
			return null;
		}

		public InputSlot? FindAvailableOutputSlot()
		{
			for (int i = 0; i < IOSlots.AllInputSlots.Length; i++)
			{
				InputSlot inputSlot = IOSlots.AllInputSlots[i];
				if (!virtualDestNode.Inputs.ContainsKey(inputSlot))
				{
					return inputSlot;
				}
			}
			return null;
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			foreach (KeyValuePair<InputSlot, CircuitLink> input in Inputs)
			{
				InputSlot key = input.Key;
				virtualSourceNode.SetOutputSignal(IOSlots.InputSlotToOutputSlot[key], GetInputSignal(key));
			}
			InternalNodeGraph.Evaluate(isMasterClient);
			foreach (KeyValuePair<InputSlot, CircuitLink> input2 in virtualDestNode.Inputs)
			{
				OutputSlot outputSlot = IOSlots.InputSlotToOutputSlot[input2.Key];
				SetContinuousOutput(outputSlot, virtualDestNode.GetInputSignal(input2.Key));
			}
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			InternalGraphData internalGraphData = new InternalGraphData
			{
				InternalNodeGraph = InternalNodeGraph.Persist(),
				InputNodeId = virtualSourceNode.NodeId,
				OutputNodeId = virtualDestNode.NodeId
			};
			circuitNodeData.InternalGraphData = internalGraphData;
			return circuitNodeData;
		}

		public override void Init(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			base.Init(data, reassignNodeIds, nodeIdMap);
			InternalGraphData internalGraphData = data.InternalGraphData;
			InternalNodeGraph = CircuitNodeGraph.Deserialize(internalGraphData.InternalNodeGraph, reassignNodeIds, out var nodeIdMap2);
			foreach (KeyValuePair<int, int> item in nodeIdMap2)
			{
				nodeIdMap.Add(item.Key, item.Value);
			}
			virtualSourceNode = (GraphInputNode)CircuitNode.Find(internalGraphData.InputNodeId);
			virtualDestNode = (GraphOutputNode)CircuitNode.Find(internalGraphData.OutputNodeId);
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return CircuitNode.AllSlotsInputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return CircuitNode.AllSlotsOutputMetadata;
		}
	}
	[Serializable]
	public struct NodeMetadata
	{
		public bool NeedsSerialization;

		public InputMetadata[] InputMetadata;

		public OutputMetadata[] OutputMetadata;

		public string NodeDescription;
	}
	[Serializable]
	public struct InputMetadata
	{
		public InputSlot InputSlot;

		public string Description;
	}
	[Serializable]
	public struct OutputMetadata
	{
		public OutputSlot OutputSlot;

		public string Description;
	}
	[CircuitNodeUuid("C6AB70A0-C752-466A-8070-029742655556")]
	public class OutputNode : CircuitNode
	{
		public struct SlotUpdate
		{
			public InputSlot Slot;

			public int Value;
		}

		public delegate void OutputNodeUpdated(List<SlotUpdate> slotUpdates);

		protected InputMetadata[] InputMeta = new InputMetadata[0];

		private List<SlotUpdate> slotUpdates = new List<SlotUpdate>();

		private static readonly OutputMetadata[] OutputMeta = new OutputMetadata[0];

		public OutputNodeUpdated OutputNodeUpdatedEvent;

		private int[] lastSignals = new int[IOSlots.AllInputSlots.Length];

		public void SetInputMeta(InputMetadata[] inputMeta)
		{
			InputMeta = inputMeta;
			ReconstructNodeMetadata();
		}

		public OutputNode(int nodeId, CircuitNodeGraph graph)
			: base("OutputNode", nodeId, graph)
		{
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMeta;
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			slotUpdates.Clear();
			for (int i = 0; i < InputMeta.Length; i++)
			{
				InputMetadata inputMetadata = InputMeta[i];
				int num = lastSignals[(int)inputMetadata.InputSlot];
				int inputSignal = GetInputSignal(inputMetadata.InputSlot);
				if (inputSignal != num)
				{
					slotUpdates.Add(new SlotUpdate
					{
						Slot = inputMetadata.InputSlot,
						Value = inputSignal
					});
				}
			}
			if (slotUpdates.Count > 0 && OutputNodeUpdatedEvent != null)
			{
				OutputNodeUpdatedEvent(slotUpdates);
			}
		}
	}
	[CircuitNodeUuid("A77191F7-792B-4590-AAB3-A3B71C440DD1")]
	public class TimerNode : CircuitNode
	{
		public enum TimerModes
		{
			Looping,
			CountDown
		}

		public const string MODE_ARG = "mode";

		private const int DELAY_COMPRESSION_QUANTIZATION = 100;

		private const int MAX_TIME_IN_SECONDS = 3600;

		private const int MAX_TIME_IN_MILLISECONDS = 3600000;

		private const int MAX_TIME_QUANTIZED = 36000;

		internal const InputSlot OnOffSlotInputSlot = InputSlot.R;

		internal const InputSlot TimeInputSlot = InputSlot.G;

		internal const OutputSlot TimerExpiredPingOutputSlot = OutputSlot.R;

		internal const OutputSlot TimeRemainingOutputSlot = OutputSlot.G;

		private static readonly InputMetadata[] InputMetadata = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "ON/OFF"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Time"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly OutputMetadata[] OutputMetadata = new OutputMetadata[3]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Timer expired ping"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.G,
				Description = "Time remaining"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET,
				Description = "Reset"
			}
		};

		private TimerModes timerMode;

		private int timeRemaining;

		private bool timerExpired = true;

		private bool isOn;

		private int? lastNetworkTime;

		private int _inputTime;

		internal override bool IsStateful => true;

		public TimerModes TimerMode
		{
			get
			{
				return timerMode;
			}
			private set
			{
				if (timerMode != value)
				{
					timerMode = value;
					ReconstructNodeMetadata();
				}
			}
		}

		private int inputTime
		{
			get
			{
				return _inputTime;
			}
			set
			{
				if (_inputTime != value)
				{
					_inputTime = value;
					ResetTimeRemaining();
				}
			}
		}

		public TimerNode(int nodeId, CircuitNodeGraph graph)
			: base("TimerNode", nodeId, graph)
		{
			CircuitNodeGraph.TimeUpdate += OnTimerUpdate;
		}

		public override void Destroy(bool destroyLinks = true)
		{
			base.Destroy(destroyLinks);
			CircuitNodeGraph.TimeUpdate -= OnTimerUpdate;
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			if (isMasterClient)
			{
				isOn = GetInputSignal(InputSlot.R) != 0;
				inputTime = GetInputSignal(InputSlot.G);
				UpdateOutputs();
			}
		}

		protected override void _ResetNode(bool isMasterClient)
		{
			base._ResetNode(isMasterClient);
			if (isMasterClient)
			{
				ResetTimeRemaining();
				UpdateOutputs();
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMetadata;
		}

		protected override string GetNodeDescription()
		{
			if (TimerMode == TimerModes.Looping)
			{
				return "Looping Timer Node";
			}
			return "Count Down Node";
		}

		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
			int num = (lastNetworkTime.HasValue ? (networkTime - lastNetworkTime.Value) : 0);
			lastNetworkTime = networkTime;
			if (isMasterClient)
			{
				if (isOn)
				{
					timeRemaining -= num;
					timeRemaining = Math.Max(timeRemaining, 0);
				}
				UpdateOutputs();
			}
		}

		private void UpdateOutputs()
		{
			SetContinuousOutput(OutputSlot.G, (timeRemaining + 999) / 1000);
			if (isOn && !timerExpired && timeRemaining <= 0)
			{
				timerExpired = true;
				SetMomentaryOutput(OutputSlot.R, 1);
				if (TimerMode == TimerModes.Looping)
				{
					ResetTimeRemaining();
				}
			}
		}

		private void ResetTimeRemaining()
		{
			timeRemaining = 1000 * Math.Max(0, Math.Min(3600, inputTime));
			timerExpired = timeRemaining == 0;
		}

		public override void Init(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			base.Init(data, reassignNodeIds, nodeIdMap);
			TimerMode = (TimerModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)TimerMode;
			return circuitNodeData;
		}

		public override void ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base.ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				TimerMode = (TimerModes)value;
			}
		}

		public override void SerializeRuntimeState(BitPacker bitPacker)
		{
			base.SerializeRuntimeState(bitPacker);
			int value = timeRemaining / 100;
			bitPacker.WriteInt(value, 0, 36000);
			bitPacker.WriteBool(timerExpired);
		}

		public override void DeserializeRuntimeState(BitPacker bitPacker)
		{
			base.DeserializeRuntimeState(bitPacker);
			bitPacker.ReadInt(out var value, 0, 36000);
			bitPacker.ReadBool(out timerExpired);
			timeRemaining = value * 100;
		}
	}
	[CircuitNodeUuid("A4160690-4C68-40C2-BD51-B665F71FCEBD", InternalOnly = true)]
	public class RootNode : VirtualNode
	{
		internal override bool IsRootNode => true;

		public RootNode(int nodeId, CircuitNodeGraph graph)
			: base("RootNode", nodeId, graph)
		{
		}
	}
	public abstract class VirtualNode : CircuitNode
	{
		private static readonly InputMetadata[] InputMeta = new InputMetadata[0];

		private static readonly OutputMetadata[] OutputMeta = new OutputMetadata[0];

		public override bool IsVirtual => true;

		public VirtualNode(int nodeId, CircuitNodeGraph graph)
			: this("VirtualNode", nodeId, graph)
		{
		}

		protected VirtualNode(string nodeName, int nodeId, CircuitNodeGraph graph)
			: base(nodeName, nodeId, graph)
		{
		}

		public override void Destroy(bool disconnectLinks = true)
		{
			base.Destroy(disconnectLinks);
			if (base.PairedNode != null)
			{
				base.PairedNode.PairedNode = null;
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMeta;
		}
	}
	public static class Serialization
	{
		public static IEnumerable<Type> GetRegisteredTypes()
		{
			return SerializationLookup.TypeToGuidLookup.Keys;
		}

		internal static void RegisterType(Type type, CircuitNodeConstructor constructor)
		{
			if (!typeof(CircuitNode).IsAssignableFrom(type))
			{
				throw new ArgumentException("Only types derived from CircuitNode can be registered for serialization");
			}
			if (SerializationLookup.TypeToGuidLookup.Keys.Contains(type))
			{
				throw new ArgumentException($"Type {type.FullName} is already registered");
			}
			Guid id = (CircuitNodeUuidAttribute.GetFromType(type) ?? throw new ArgumentException("Registered CircuitNode types must have a CircuitNodeUuid attribute defining their unique serialization ID")).Id;
			if (SerializationLookup.GuidToNodeConstructor.Keys.Contains(id))
			{
				throw new ArgumentException($"Guid {id} already maps to constructor");
			}
			SerializationLookup.TypeToGuidLookup[type] = id;
			SerializationLookup.GuidToNodeConstructor[id] = constructor;
		}

		internal static void UnregisterType(Type type)
		{
			if (!SerializationLookup.TypeToGuidLookup.TryGetValue(type, out var value))
			{
				throw new ArgumentException($"Type {type.FullName} is not registered");
			}
			SerializationLookup.TypeToGuidLookup.Remove(type);
			SerializationLookup.GuidToNodeConstructor.Remove(value);
		}

		public static CircuitNode InstantiateNode(Guid nodeType, int nodeId, Guid graphGuid)
		{
			if (!SerializationLookup.GuidToNodeConstructor.TryGetValue(nodeType, out var value))
			{
				throw new ArgumentException($"Guid {nodeType} is not registered");
			}
			CircuitNode.SetPossibleMaxId(nodeId);
			return value(nodeId, new CircuitNodeGraph(graphGuid));
		}

		internal static CircuitNode InstantiateNode(CircuitNodeData nodeData, CircuitNodeGraph nodeGraph, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			Guid guid = nodeData.NodeType.ToGuid();
			int nodeId = nodeData.NodeId;
			int num = (reassignNodeIds ? CircuitNode.NewNodeId() : nodeId);
			nodeIdMap.Add(nodeId, num);
			if (!SerializationLookup.GuidToNodeConstructor.TryGetValue(guid, out var value))
			{
				throw new ArgumentException($"Guid {guid} is not registered");
			}
			CircuitNode.SetPossibleMaxId(num);
			return value(num, nodeGraph);
		}

		public static Guid GetNodeTypeGuid(CircuitNode node)
		{
			if (!SerializationLookup.TypeToGuidLookup.TryGetValue(node.GetType(), out var value))
			{
				throw new ArgumentException($"CircuitNode type {node.GetType().FullName} is not registered");
			}
			return value;
		}

		public static bool TryGetNodeTypeByGuid(Guid guid, out Type t)
		{
			return SerializationLookup.GuidToTypeLookup.TryGetValue(guid, out t);
		}
	}
	public delegate CircuitNode CircuitNodeConstructor(int nodeId, CircuitNodeGraph graph);
	internal static class SerializationLookup
	{
		private static Guid RECROOM_CIRCUITS_BOOLEANNODE_ID = new Guid("2385e75e-e0da-45bf-8d66-17dc9ffb9fc7");

		private static Guid RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID = new Guid("b7ba1a4b-ea04-496f-b8b6-a2fb7c4a42b9");

		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID = new Guid("b71b05c0-d6fd-4c49-a70c-085c14e95317");

		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID = new Guid("92bd57fa-d68e-4a6e-9ecf-d82985169b82");

		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID = new Guid("17b72de0-4116-41db-a99d-1523625f7ef1");

		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID = new Guid("34452a12-afb3-4a4d-97b0-9d25f7e777c5");

		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID = new Guid("c9a59f26-0a72-4c2e-b239-6a83998e0839");

		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID = new Guid("e7efd8ca-92fe-4a37-9e7c-abbe9e4de336");

		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID = new Guid("6402c773-5838-4495-bc54-bc36ede4ab0f");

		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID = new Guid("738b2af2-eebd-4316-82a9-2fbec9b50d8b");

		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID = new Guid("c6ab70a0-c752-466a-8070-029742655556");

		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID = new Guid("a77191f7-792b-4590-aab3-a3b71c440dd1");

		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID = new Guid("a4160690-4c68-40c2-bd51-b665f71fcebd");

		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID = new Guid("86b6fd1c-4668-4ba9-8acb-fb91e25dbfb6");

		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID = new Guid("f8a998db-0354-4bcd-b0e4-6bba7cc24b89");

		internal static Dictionary<Type, Guid> TypeToGuidLookup = new Dictionary<Type, Guid>
		{
			{
				typeof(BooleanNode),
				RECROOM_CIRCUITS_BOOLEANNODE_ID
			},
			{
				typeof(ContinuousSourceNode),
				RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID
			},
			{
				typeof(RandomNode),
				RECROOM_CIRCUITS_RANDOMNODE_ID
			},
			{
				typeof(ComparerNode),
				RECROOM_CIRCUITS_COMPARERNODE_ID
			},
			{
				typeof(CombinatorNode),
				RECROOM_CIRCUITS_COMBINATORNODE_ID
			},
			{
				typeof(DelayNode),
				RECROOM_CIRCUITS_DELAYNODE_ID
			},
			{
				typeof(LoopNode),
				RECROOM_CIRCUITS_LOOPNODE_ID
			},
			{
				typeof(MomentarySourceNode),
				RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID
			},
			{
				typeof(ConstantSourceNode),
				RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID
			},
			{
				typeof(NodeGraphNode),
				RECROOM_CIRCUITS_NODEGRAPHNODE_ID
			},
			{
				typeof(OutputNode),
				RECROOM_CIRCUITS_OUTPUTNODE_ID
			},
			{
				typeof(TimerNode),
				RECROOM_CIRCUITS_TIMERNODE_ID
			},
			{
				typeof(RootNode),
				RECROOM_CIRCUITS_ROOTNODE_ID
			},
			{
				typeof(NodeGraphNode.GraphInputNode),
				RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID
			},
			{
				typeof(NodeGraphNode.GraphOutputNode),
				RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID
			}
		};

		internal static Dictionary<Guid, Type> GuidToTypeLookup = new Dictionary<Guid, Type>
		{
			{
				RECROOM_CIRCUITS_BOOLEANNODE_ID,
				typeof(BooleanNode)
			},
			{
				RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID,
				typeof(ContinuousSourceNode)
			},
			{
				RECROOM_CIRCUITS_RANDOMNODE_ID,
				typeof(RandomNode)
			},
			{
				RECROOM_CIRCUITS_COMPARERNODE_ID,
				typeof(ComparerNode)
			},
			{
				RECROOM_CIRCUITS_COMBINATORNODE_ID,
				typeof(CombinatorNode)
			},
			{
				RECROOM_CIRCUITS_DELAYNODE_ID,
				typeof(DelayNode)
			},
			{
				RECROOM_CIRCUITS_LOOPNODE_ID,
				typeof(LoopNode)
			},
			{
				RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID,
				typeof(MomentarySourceNode)
			},
			{
				RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID,
				typeof(ConstantSourceNode)
			},
			{
				RECROOM_CIRCUITS_NODEGRAPHNODE_ID,
				typeof(NodeGraphNode)
			},
			{
				RECROOM_CIRCUITS_OUTPUTNODE_ID,
				typeof(OutputNode)
			},
			{
				RECROOM_CIRCUITS_TIMERNODE_ID,
				typeof(TimerNode)
			},
			{
				RECROOM_CIRCUITS_ROOTNODE_ID,
				typeof(RootNode)
			},
			{
				RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID,
				typeof(NodeGraphNode.GraphInputNode)
			},
			{
				RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID,
				typeof(NodeGraphNode.GraphOutputNode)
			}
		};

		internal static Dictionary<Guid, CircuitNodeConstructor> GuidToNodeConstructor = new Dictionary<Guid, CircuitNodeConstructor>
		{
			{
				RECROOM_CIRCUITS_BOOLEANNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new BooleanNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new ContinuousSourceNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_RANDOMNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new RandomNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_COMPARERNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new ComparerNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_COMBINATORNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new CombinatorNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_DELAYNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new DelayNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_LOOPNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new LoopNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new MomentarySourceNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new ConstantSourceNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_NODEGRAPHNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new NodeGraphNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_OUTPUTNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new OutputNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_TIMERNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new TimerNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_ROOTNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new RootNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new NodeGraphNode.GraphInputNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new NodeGraphNode.GraphOutputNode(nodeId, graph)
			}
		};
	}
}
namespace RecRoom.Circuits.Protobuf
{
	public static class CircuitLinkDataReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static CircuitLinkDataReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdjaXJjdWl0X2xpbmtfZGF0YS5wcm90bxIIY2lyY3VpdHMiewoPQ2lyY3Vp" + "dExpbmtEYXRhEhYKDnNvdXJjZV9ub2RlX2lkGAEgASgFEhQKDGRlc3Rfbm9k" + "ZV9pZBgCIAEoBRISCgppbnB1dF9zbG90GAMgASgFEhMKC291dHB1dF9zbG90" + "GAQgASgFEhEKCWxpbmtfdHlwZRgFIAEoBUIcqgIZUmVjUm9vbS5DaXJjdWl0" + "cy5Qcm90b2J1ZmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(CircuitLinkData), CircuitLinkData.Parser, new string[5] { "SourceNodeId", "DestNodeId", "InputSlot", "OutputSlot", "LinkType" }, null, null, null)
			}));
		}
	}
	public sealed class CircuitLinkData : IMessage<CircuitLinkData>, IMessage, IEquatable<CircuitLinkData>, IDeepCloneable<CircuitLinkData>
	{
		private static readonly MessageParser<CircuitLinkData> _parser = new MessageParser<CircuitLinkData>(() => new CircuitLinkData());

		public const int SourceNodeIdFieldNumber = 1;

		private int sourceNodeId_;

		public const int DestNodeIdFieldNumber = 2;

		private int destNodeId_;

		public const int InputSlotFieldNumber = 3;

		private int inputSlot_;

		public const int OutputSlotFieldNumber = 4;

		private int outputSlot_;

		public const int LinkTypeFieldNumber = 5;

		private int linkType_;

		[DebuggerNonUserCode]
		public static MessageParser<CircuitLinkData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitLinkDataReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public int SourceNodeId
		{
			get
			{
				return sourceNodeId_;
			}
			set
			{
				sourceNodeId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DestNodeId
		{
			get
			{
				return destNodeId_;
			}
			set
			{
				destNodeId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int InputSlot
		{
			get
			{
				return inputSlot_;
			}
			set
			{
				inputSlot_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OutputSlot
		{
			get
			{
				return outputSlot_;
			}
			set
			{
				outputSlot_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LinkType
		{
			get
			{
				return linkType_;
			}
			set
			{
				linkType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public CircuitLinkData()
		{
		}

		[DebuggerNonUserCode]
		public CircuitLinkData(CircuitLinkData other)
			: this()
		{
			sourceNodeId_ = other.sourceNodeId_;
			destNodeId_ = other.destNodeId_;
			inputSlot_ = other.inputSlot_;
			outputSlot_ = other.outputSlot_;
			linkType_ = other.linkType_;
		}

		[DebuggerNonUserCode]
		public CircuitLinkData Clone()
		{
			return new CircuitLinkData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as CircuitLinkData);
		}

		[DebuggerNonUserCode]
		public bool Equals(CircuitLinkData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (SourceNodeId != other.SourceNodeId)
			{
				return false;
			}
			if (DestNodeId != other.DestNodeId)
			{
				return false;
			}
			if (InputSlot != other.InputSlot)
			{
				return false;
			}
			if (OutputSlot != other.OutputSlot)
			{
				return false;
			}
			if (LinkType != other.LinkType)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (SourceNodeId != 0)
			{
				num ^= SourceNodeId.GetHashCode();
			}
			if (DestNodeId != 0)
			{
				num ^= DestNodeId.GetHashCode();
			}
			if (InputSlot != 0)
			{
				num ^= InputSlot.GetHashCode();
			}
			if (OutputSlot != 0)
			{
				num ^= OutputSlot.GetHashCode();
			}
			if (LinkType != 0)
			{
				num ^= LinkType.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (SourceNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(SourceNodeId);
			}
			if (DestNodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(DestNodeId);
			}
			if (InputSlot != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(InputSlot);
			}
			if (OutputSlot != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(OutputSlot);
			}
			if (LinkType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(LinkType);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (SourceNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(SourceNodeId);
			}
			if (DestNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(DestNodeId);
			}
			if (InputSlot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(InputSlot);
			}
			if (OutputSlot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(OutputSlot);
			}
			if (LinkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(LinkType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CircuitLinkData other)
		{
			if (other != null)
			{
				if (other.SourceNodeId != 0)
				{
					SourceNodeId = other.SourceNodeId;
				}
				if (other.DestNodeId != 0)
				{
					DestNodeId = other.DestNodeId;
				}
				if (other.InputSlot != 0)
				{
					InputSlot = other.InputSlot;
				}
				if (other.OutputSlot != 0)
				{
					OutputSlot = other.OutputSlot;
				}
				if (other.LinkType != 0)
				{
					LinkType = other.LinkType;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					SourceNodeId = input.ReadInt32();
					break;
				case 16u:
					DestNodeId = input.ReadInt32();
					break;
				case 24u:
					InputSlot = input.ReadInt32();
					break;
				case 32u:
					OutputSlot = input.ReadInt32();
					break;
				case 40u:
					LinkType = input.ReadInt32();
					break;
				}
			}
		}
	}
	public static class CircuitNodeDataReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static CircuitNodeDataReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdjaXJjdWl0X25vZGVfZGF0YS5wcm90bxIIY2lyY3VpdHMaF2NpcmN1aXRf" + "bGlua19kYXRhLnByb3RvGhlub2RlX3RyYW5zZm9ybV9kYXRhLnByb3RvIrUC" + "Cg9DaXJjdWl0Tm9kZURhdGESEQoJbm9kZV9uYW1lGAEgASgJEg8KB25vZGVf" + "aWQYAiABKAUSFgoOcGFpcmVkX25vZGVfaWQYAyABKAUSEQoJbm9kZV90eXBl" + "GAQgASgMEjAKDWNpcmN1aXRfbGlua3MYBiADKAsyGS5jaXJjdWl0cy5DaXJj" + "dWl0TGlua0RhdGESMwoOdHJhbnNmb3JtX2RhdGEYByABKAsyGy5jaXJjdWl0" + "cy5Ob2RlVHJhbnNmb3JtRGF0YRI4ChNpbnRlcm5hbF9ncmFwaF9kYXRhGAgg" + "ASgLMhsuY2lyY3VpdHMuSW50ZXJuYWxHcmFwaERhdGESJAoIc2xvdERhdGEY" + "CSADKAsyEi5jaXJjdWl0cy5TbG90RGF0YRIMCgRtb2RlGAogASgFIn8KEUlu" + "dGVybmFsR3JhcGhEYXRhEhUKDWlucHV0X25vZGVfaWQYASABKAUSFgoOb3V0" + "cHV0X25vZGVfaWQYAiABKAUSOwoTaW50ZXJuYWxfbm9kZV9ncmFwaBgDIAEo" + "CzIeLmNpcmN1aXRzLkNpcmN1aXROb2RlR3JhcGhEYXRhIq8BChRDaXJjdWl0" + "Tm9kZUdyYXBoRGF0YRIXCg9ub2RlX2dyYXBoX2d1aWQYASABKAwSGQoRaXNf" + "aW50ZXJuYWxfZ3JhcGgYAiABKAgSMQoOcm9vdF9ub2RlX2RhdGEYAyABKAsy" + "GS5jaXJjdWl0cy5DaXJjdWl0Tm9kZURhdGESMAoNY2lyY3VpdF9ub2RlcxgE" + "IAMoCzIZLmNpcmN1aXRzLkNpcmN1aXROb2RlRGF0YSJQCh5DaXJjdWl0Tm9k" + "ZUdyYXBoQ29sbGVjdGlvbkRhdGESLgoGZ3JhcGhzGAEgAygLMh4uY2lyY3Vp" + "dHMuQ2lyY3VpdE5vZGVHcmFwaERhdGEiKAoIU2xvdERhdGESDAoEc2xvdBgB" + "IAEoBRIOCgZzaWduYWwYAiABKAVCHKoCGVJlY1Jvb20uQ2lyY3VpdHMuUHJv" + "dG9idWZiBnByb3RvMw=="), new FileDescriptor[2]
			{
				CircuitLinkDataReflection.Descriptor,
				NodeTransformDataReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[5]
			{
				new GeneratedClrTypeInfo(typeof(CircuitNodeData), CircuitNodeData.Parser, new string[9] { "NodeName", "NodeId", "PairedNodeId", "NodeType", "CircuitLinks", "TransformData", "InternalGraphData", "SlotData", "Mode" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(InternalGraphData), InternalGraphData.Parser, new string[3] { "InputNodeId", "OutputNodeId", "InternalNodeGraph" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(CircuitNodeGraphData), CircuitNodeGraphData.Parser, new string[4] { "NodeGraphGuid", "IsInternalGraph", "RootNodeData", "CircuitNodes" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(CircuitNodeGraphCollectionData), CircuitNodeGraphCollectionData.Parser, new string[1] { "Graphs" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(SlotData), SlotData.Parser, new string[2] { "Slot", "Signal" }, null, null, null)
			}));
		}
	}
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		private static readonly MessageParser<CircuitNodeData> _parser = new MessageParser<CircuitNodeData>(() => new CircuitNodeData());

		public const int NodeNameFieldNumber = 1;

		private string nodeName_ = "";

		public const int NodeIdFieldNumber = 2;

		private int nodeId_;

		public const int PairedNodeIdFieldNumber = 3;

		private int pairedNodeId_;

		public const int NodeTypeFieldNumber = 4;

		private ByteString nodeType_ = ByteString.Empty;

		public const int CircuitLinksFieldNumber = 6;

		private static readonly FieldCodec<CircuitLinkData> _repeated_circuitLinks_codec = FieldCodec.ForMessage(50u, CircuitLinkData.Parser);

		private readonly RepeatedField<CircuitLinkData> circuitLinks_ = new RepeatedField<CircuitLinkData>();

		public const int TransformDataFieldNumber = 7;

		private NodeTransformData transformData_;

		public const int InternalGraphDataFieldNumber = 8;

		private InternalGraphData internalGraphData_;

		public const int SlotDataFieldNumber = 9;

		private static readonly FieldCodec<SlotData> _repeated_slotData_codec = FieldCodec.ForMessage(74u, RecRoom.Circuits.Protobuf.SlotData.Parser);

		private readonly RepeatedField<SlotData> slotData_ = new RepeatedField<SlotData>();

		public const int ModeFieldNumber = 10;

		private int mode_;

		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string NodeName
		{
			get
			{
				return nodeName_;
			}
			set
			{
				nodeName_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int NodeId
		{
			get
			{
				return nodeId_;
			}
			set
			{
				nodeId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int PairedNodeId
		{
			get
			{
				return pairedNodeId_;
			}
			set
			{
				pairedNodeId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			get
			{
				return nodeType_;
			}
			set
			{
				nodeType_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<CircuitLinkData> CircuitLinks => circuitLinks_;

		[DebuggerNonUserCode]
		public NodeTransformData TransformData
		{
			get
			{
				return transformData_;
			}
			set
			{
				transformData_ = value;
			}
		}

		[DebuggerNonUserCode]
		public InternalGraphData InternalGraphData
		{
			get
			{
				return internalGraphData_;
			}
			set
			{
				internalGraphData_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<SlotData> SlotData => slotData_;

		[DebuggerNonUserCode]
		public int Mode
		{
			get
			{
				return mode_;
			}
			set
			{
				mode_ = value;
			}
		}

		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
			: this()
		{
			nodeName_ = other.nodeName_;
			nodeId_ = other.nodeId_;
			pairedNodeId_ = other.pairedNodeId_;
			nodeType_ = other.nodeType_;
			circuitLinks_ = other.circuitLinks_.Clone();
			TransformData = ((other.transformData_ != null) ? other.TransformData.Clone() : null);
			InternalGraphData = ((other.internalGraphData_ != null) ? other.InternalGraphData.Clone() : null);
			slotData_ = other.slotData_.Clone();
			mode_ = other.mode_;
		}

		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return new CircuitNodeData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as CircuitNodeData);
		}

		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (NodeName != other.NodeName)
			{
				return false;
			}
			if (NodeId != other.NodeId)
			{
				return false;
			}
			if (PairedNodeId != other.PairedNodeId)
			{
				return false;
			}
			if (NodeType != other.NodeType)
			{
				return false;
			}
			if (!circuitLinks_.Equals(other.circuitLinks_))
			{
				return false;
			}
			if (!object.Equals(TransformData, other.TransformData))
			{
				return false;
			}
			if (!object.Equals(InternalGraphData, other.InternalGraphData))
			{
				return false;
			}
			if (!slotData_.Equals(other.slotData_))
			{
				return false;
			}
			if (Mode != other.Mode)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (NodeName.Length != 0)
			{
				num ^= NodeName.GetHashCode();
			}
			if (NodeId != 0)
			{
				num ^= NodeId.GetHashCode();
			}
			if (PairedNodeId != 0)
			{
				num ^= PairedNodeId.GetHashCode();
			}
			if (NodeType.Length != 0)
			{
				num ^= NodeType.GetHashCode();
			}
			num ^= circuitLinks_.GetHashCode();
			if (transformData_ != null)
			{
				num ^= TransformData.GetHashCode();
			}
			if (internalGraphData_ != null)
			{
				num ^= InternalGraphData.GetHashCode();
			}
			num ^= slotData_.GetHashCode();
			if (Mode != 0)
			{
				num ^= Mode.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (NodeName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(NodeName);
			}
			if (NodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(NodeId);
			}
			if (PairedNodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(PairedNodeId);
			}
			if (NodeType.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(NodeType);
			}
			circuitLinks_.WriteTo(output, _repeated_circuitLinks_codec);
			if (transformData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(TransformData);
			}
			if (internalGraphData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(InternalGraphData);
			}
			slotData_.WriteTo(output, _repeated_slotData_codec);
			if (Mode != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(Mode);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (NodeName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(NodeName);
			}
			if (NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(NodeId);
			}
			if (PairedNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(PairedNodeId);
			}
			if (NodeType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(NodeType);
			}
			num += circuitLinks_.CalculateSize(_repeated_circuitLinks_codec);
			if (transformData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(TransformData);
			}
			if (internalGraphData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(InternalGraphData);
			}
			num += slotData_.CalculateSize(_repeated_slotData_codec);
			if (Mode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Mode);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CircuitNodeData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NodeName.Length != 0)
			{
				NodeName = other.NodeName;
			}
			if (other.NodeId != 0)
			{
				NodeId = other.NodeId;
			}
			if (other.PairedNodeId != 0)
			{
				PairedNodeId = other.PairedNodeId;
			}
			if (other.NodeType.Length != 0)
			{
				NodeType = other.NodeType;
			}
			circuitLinks_.Add(other.circuitLinks_);
			if (other.transformData_ != null)
			{
				if (transformData_ == null)
				{
					transformData_ = new NodeTransformData();
				}
				TransformData.MergeFrom(other.TransformData);
			}
			if (other.internalGraphData_ != null)
			{
				if (internalGraphData_ == null)
				{
					internalGraphData_ = new InternalGraphData();
				}
				InternalGraphData.MergeFrom(other.InternalGraphData);
			}
			slotData_.Add(other.slotData_);
			if (other.Mode != 0)
			{
				Mode = other.Mode;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					NodeName = input.ReadString();
					break;
				case 16u:
					NodeId = input.ReadInt32();
					break;
				case 24u:
					PairedNodeId = input.ReadInt32();
					break;
				case 34u:
					NodeType = input.ReadBytes();
					break;
				case 50u:
					circuitLinks_.AddEntriesFrom(input, _repeated_circuitLinks_codec);
					break;
				case 58u:
					if (transformData_ == null)
					{
						transformData_ = new NodeTransformData();
					}
					input.ReadMessage(transformData_);
					break;
				case 66u:
					if (internalGraphData_ == null)
					{
						internalGraphData_ = new InternalGraphData();
					}
					input.ReadMessage(internalGraphData_);
					break;
				case 74u:
					slotData_.AddEntriesFrom(input, _repeated_slotData_codec);
					break;
				case 80u:
					Mode = input.ReadInt32();
					break;
				}
			}
		}
	}
	public sealed class InternalGraphData : IMessage<InternalGraphData>, IMessage, IEquatable<InternalGraphData>, IDeepCloneable<InternalGraphData>
	{
		private static readonly MessageParser<InternalGraphData> _parser = new MessageParser<InternalGraphData>(() => new InternalGraphData());

		public const int InputNodeIdFieldNumber = 1;

		private int inputNodeId_;

		public const int OutputNodeIdFieldNumber = 2;

		private int outputNodeId_;

		public const int InternalNodeGraphFieldNumber = 3;

		private CircuitNodeGraphData internalNodeGraph_;

		[DebuggerNonUserCode]
		public static MessageParser<InternalGraphData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public int InputNodeId
		{
			get
			{
				return inputNodeId_;
			}
			set
			{
				inputNodeId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OutputNodeId
		{
			get
			{
				return outputNodeId_;
			}
			set
			{
				outputNodeId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public CircuitNodeGraphData InternalNodeGraph
		{
			get
			{
				return internalNodeGraph_;
			}
			set
			{
				internalNodeGraph_ = value;
			}
		}

		[DebuggerNonUserCode]
		public InternalGraphData()
		{
		}

		[DebuggerNonUserCode]
		public InternalGraphData(InternalGraphData other)
			: this()
		{
			inputNodeId_ = other.inputNodeId_;
			outputNodeId_ = other.outputNodeId_;
			InternalNodeGraph = ((other.internalNodeGraph_ != null) ? other.InternalNodeGraph.Clone() : null);
		}

		[DebuggerNonUserCode]
		public InternalGraphData Clone()
		{
			return new InternalGraphData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as InternalGraphData);
		}

		[DebuggerNonUserCode]
		public bool Equals(InternalGraphData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (InputNodeId != other.InputNodeId)
			{
				return false;
			}
			if (OutputNodeId != other.OutputNodeId)
			{
				return false;
			}
			if (!object.Equals(InternalNodeGraph, other.InternalNodeGraph))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (InputNodeId != 0)
			{
				num ^= InputNodeId.GetHashCode();
			}
			if (OutputNodeId != 0)
			{
				num ^= OutputNodeId.GetHashCode();
			}
			if (internalNodeGraph_ != null)
			{
				num ^= InternalNodeGraph.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (InputNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(InputNodeId);
			}
			if (OutputNodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(OutputNodeId);
			}
			if (internalNodeGraph_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(InternalNodeGraph);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (InputNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(InputNodeId);
			}
			if (OutputNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(OutputNodeId);
			}
			if (internalNodeGraph_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(InternalNodeGraph);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(InternalGraphData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InputNodeId != 0)
			{
				InputNodeId = other.InputNodeId;
			}
			if (other.OutputNodeId != 0)
			{
				OutputNodeId = other.OutputNodeId;
			}
			if (other.internalNodeGraph_ != null)
			{
				if (internalNodeGraph_ == null)
				{
					internalNodeGraph_ = new CircuitNodeGraphData();
				}
				InternalNodeGraph.MergeFrom(other.InternalNodeGraph);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					InputNodeId = input.ReadInt32();
					break;
				case 16u:
					OutputNodeId = input.ReadInt32();
					break;
				case 26u:
					if (internalNodeGraph_ == null)
					{
						internalNodeGraph_ = new CircuitNodeGraphData();
					}
					input.ReadMessage(internalNodeGraph_);
					break;
				}
			}
		}
	}
	public sealed class CircuitNodeGraphData : IMessage<CircuitNodeGraphData>, IMessage, IEquatable<CircuitNodeGraphData>, IDeepCloneable<CircuitNodeGraphData>
	{
		private static readonly MessageParser<CircuitNodeGraphData> _parser = new MessageParser<CircuitNodeGraphData>(() => new CircuitNodeGraphData());

		public const int NodeGraphGuidFieldNumber = 1;

		private ByteString nodeGraphGuid_ = ByteString.Empty;

		public const int IsInternalGraphFieldNumber = 2;

		private bool isInternalGraph_;

		public const int RootNodeDataFieldNumber = 3;

		private CircuitNodeData rootNodeData_;

		public const int CircuitNodesFieldNumber = 4;

		private static readonly FieldCodec<CircuitNodeData> _repeated_circuitNodes_codec = FieldCodec.ForMessage(34u, CircuitNodeData.Parser);

		private readonly RepeatedField<CircuitNodeData> circuitNodes_ = new RepeatedField<CircuitNodeData>();

		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[2];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public ByteString NodeGraphGuid
		{
			get
			{
				return nodeGraphGuid_;
			}
			set
			{
				nodeGraphGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public bool IsInternalGraph
		{
			get
			{
				return isInternalGraph_;
			}
			set
			{
				isInternalGraph_ = value;
			}
		}

		[DebuggerNonUserCode]
		public CircuitNodeData RootNodeData
		{
			get
			{
				return rootNodeData_;
			}
			set
			{
				rootNodeData_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> CircuitNodes => circuitNodes_;

		[DebuggerNonUserCode]
		public CircuitNodeGraphData()
		{
		}

		[DebuggerNonUserCode]
		public CircuitNodeGraphData(CircuitNodeGraphData other)
			: this()
		{
			nodeGraphGuid_ = other.nodeGraphGuid_;
			isInternalGraph_ = other.isInternalGraph_;
			RootNodeData = ((other.rootNodeData_ != null) ? other.RootNodeData.Clone() : null);
			circuitNodes_ = other.circuitNodes_.Clone();
		}

		[DebuggerNonUserCode]
		public CircuitNodeGraphData Clone()
		{
			return new CircuitNodeGraphData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as CircuitNodeGraphData);
		}

		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (NodeGraphGuid != other.NodeGraphGuid)
			{
				return false;
			}
			if (IsInternalGraph != other.IsInternalGraph)
			{
				return false;
			}
			if (!object.Equals(RootNodeData, other.RootNodeData))
			{
				return false;
			}
			if (!circuitNodes_.Equals(other.circuitNodes_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (NodeGraphGuid.Length != 0)
			{
				num ^= NodeGraphGuid.GetHashCode();
			}
			if (IsInternalGraph)
			{
				num ^= IsInternalGraph.GetHashCode();
			}
			if (rootNodeData_ != null)
			{
				num ^= RootNodeData.GetHashCode();
			}
			return num ^ circuitNodes_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (NodeGraphGuid.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(NodeGraphGuid);
			}
			if (IsInternalGraph)
			{
				output.WriteRawTag(16);
				output.WriteBool(IsInternalGraph);
			}
			if (rootNodeData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(RootNodeData);
			}
			circuitNodes_.WriteTo(output, _repeated_circuitNodes_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (NodeGraphGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(NodeGraphGuid);
			}
			if (IsInternalGraph)
			{
				num += 2;
			}
			if (rootNodeData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(RootNodeData);
			}
			return num + circuitNodes_.CalculateSize(_repeated_circuitNodes_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CircuitNodeGraphData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NodeGraphGuid.Length != 0)
			{
				NodeGraphGuid = other.NodeGraphGuid;
			}
			if (other.IsInternalGraph)
			{
				IsInternalGraph = other.IsInternalGraph;
			}
			if (other.rootNodeData_ != null)
			{
				if (rootNodeData_ == null)
				{
					rootNodeData_ = new CircuitNodeData();
				}
				RootNodeData.MergeFrom(other.RootNodeData);
			}
			circuitNodes_.Add(other.circuitNodes_);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					NodeGraphGuid = input.ReadBytes();
					break;
				case 16u:
					IsInternalGraph = input.ReadBool();
					break;
				case 26u:
					if (rootNodeData_ == null)
					{
						rootNodeData_ = new CircuitNodeData();
					}
					input.ReadMessage(rootNodeData_);
					break;
				case 34u:
					circuitNodes_.AddEntriesFrom(input, _repeated_circuitNodes_codec);
					break;
				}
			}
		}
	}
	public sealed class CircuitNodeGraphCollectionData : IMessage<CircuitNodeGraphCollectionData>, IMessage, IEquatable<CircuitNodeGraphCollectionData>, IDeepCloneable<CircuitNodeGraphCollectionData>
	{
		private static readonly MessageParser<CircuitNodeGraphCollectionData> _parser = new MessageParser<CircuitNodeGraphCollectionData>(() => new CircuitNodeGraphCollectionData());

		public const int GraphsFieldNumber = 1;

		private static readonly FieldCodec<CircuitNodeGraphData> _repeated_graphs_codec = FieldCodec.ForMessage(10u, CircuitNodeGraphData.Parser);

		private readonly RepeatedField<CircuitNodeGraphData> graphs_ = new RepeatedField<CircuitNodeGraphData>();

		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphCollectionData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[3];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeGraphData> Graphs => graphs_;

		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData()
		{
		}

		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData(CircuitNodeGraphCollectionData other)
			: this()
		{
			graphs_ = other.graphs_.Clone();
		}

		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData Clone()
		{
			return new CircuitNodeGraphCollectionData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as CircuitNodeGraphCollectionData);
		}

		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphCollectionData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!graphs_.Equals(other.graphs_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ graphs_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			graphs_.WriteTo(output, _repeated_graphs_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + graphs_.CalculateSize(_repeated_graphs_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CircuitNodeGraphCollectionData other)
		{
			if (other != null)
			{
				graphs_.Add(other.graphs_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					graphs_.AddEntriesFrom(input, _repeated_graphs_codec);
				}
			}
		}
	}
	public sealed class SlotData : IMessage<SlotData>, IMessage, IEquatable<SlotData>, IDeepCloneable<SlotData>
	{
		private static readonly MessageParser<SlotData> _parser = new MessageParser<SlotData>(() => new SlotData());

		public const int SlotFieldNumber = 1;

		private int slot_;

		public const int SignalFieldNumber = 2;

		private int signal_;

		[DebuggerNonUserCode]
		public static MessageParser<SlotData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[4];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public int Slot
		{
			get
			{
				return slot_;
			}
			set
			{
				slot_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Signal
		{
			get
			{
				return signal_;
			}
			set
			{
				signal_ = value;
			}
		}

		[DebuggerNonUserCode]
		public SlotData()
		{
		}

		[DebuggerNonUserCode]
		public SlotData(SlotData other)
			: this()
		{
			slot_ = other.slot_;
			signal_ = other.signal_;
		}

		[DebuggerNonUserCode]
		public SlotData Clone()
		{
			return new SlotData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as SlotData);
		}

		[DebuggerNonUserCode]
		public bool Equals(SlotData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Slot != other.Slot)
			{
				return false;
			}
			if (Signal != other.Signal)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Slot != 0)
			{
				num ^= Slot.GetHashCode();
			}
			if (Signal != 0)
			{
				num ^= Signal.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Slot != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(Slot);
			}
			if (Signal != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Signal);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Slot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Slot);
			}
			if (Signal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Signal);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(SlotData other)
		{
			if (other != null)
			{
				if (other.Slot != 0)
				{
					Slot = other.Slot;
				}
				if (other.Signal != 0)
				{
					Signal = other.Signal;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					Slot = input.ReadInt32();
					break;
				case 16u:
					Signal = input.ReadInt32();
					break;
				}
			}
		}
	}
	public static class NodeTransformDataReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static NodeTransformDataReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chlub2RlX3RyYW5zZm9ybV9kYXRhLnByb3RvEghjaXJjdWl0cxoSdmVjdG9y" + "M19kYXRhLnByb3RvImUKEU5vZGVUcmFuc2Zvcm1EYXRhEicKCHBvc2l0aW9u" + "GAEgASgLMhUuY2lyY3VpdHMuVmVjdG9yM0RhdGESJwoIcm90YXRpb24YAiAB" + "KAsyFS5jaXJjdWl0cy5WZWN0b3IzRGF0YUIcqgIZUmVjUm9vbS5DaXJjdWl0" + "cy5Qcm90b2J1ZmIGcHJvdG8z"), new FileDescriptor[1] { Vector3DataReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(NodeTransformData), NodeTransformData.Parser, new string[2] { "Position", "Rotation" }, null, null, null)
			}));
		}
	}
	public sealed class NodeTransformData : IMessage<NodeTransformData>, IMessage, IEquatable<NodeTransformData>, IDeepCloneable<NodeTransformData>
	{
		private static readonly MessageParser<NodeTransformData> _parser = new MessageParser<NodeTransformData>(() => new NodeTransformData());

		public const int PositionFieldNumber = 1;

		private Vector3Data position_;

		public const int RotationFieldNumber = 2;

		private Vector3Data rotation_;

		[DebuggerNonUserCode]
		public static MessageParser<NodeTransformData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NodeTransformDataReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public Vector3Data Position
		{
			get
			{
				return position_;
			}
			set
			{
				position_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Vector3Data Rotation
		{
			get
			{
				return rotation_;
			}
			set
			{
				rotation_ = value;
			}
		}

		[DebuggerNonUserCode]
		public NodeTransformData()
		{
		}

		[DebuggerNonUserCode]
		public NodeTransformData(NodeTransformData other)
			: this()
		{
			Position = ((other.position_ != null) ? other.Position.Clone() : null);
			Rotation = ((other.rotation_ != null) ? other.Rotation.Clone() : null);
		}

		[DebuggerNonUserCode]
		public NodeTransformData Clone()
		{
			return new NodeTransformData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as NodeTransformData);
		}

		[DebuggerNonUserCode]
		public bool Equals(NodeTransformData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!object.Equals(Position, other.Position))
			{
				return false;
			}
			if (!object.Equals(Rotation, other.Rotation))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (position_ != null)
			{
				num ^= Position.GetHashCode();
			}
			if (rotation_ != null)
			{
				num ^= Rotation.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (position_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(Position);
			}
			if (rotation_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(Rotation);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (position_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Position);
			}
			if (rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Rotation);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(NodeTransformData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.position_ != null)
			{
				if (position_ == null)
				{
					position_ = new Vector3Data();
				}
				Position.MergeFrom(other.Position);
			}
			if (other.rotation_ != null)
			{
				if (rotation_ == null)
				{
					rotation_ = new Vector3Data();
				}
				Rotation.MergeFrom(other.Rotation);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					if (position_ == null)
					{
						position_ = new Vector3Data();
					}
					input.ReadMessage(position_);
					break;
				case 18u:
					if (rotation_ == null)
					{
						rotation_ = new Vector3Data();
					}
					input.ReadMessage(rotation_);
					break;
				}
			}
		}
	}
	public static class Vector3DataReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static Vector3DataReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJ2ZWN0b3IzX2RhdGEucHJvdG8SCGNpcmN1aXRzIi4KC1ZlY3RvcjNEYXRh" + "EgkKAXgYASABKAISCQoBeRgCIAEoAhIJCgF6GAMgASgCQhyqAhlSZWNSb29t" + "LkNpcmN1aXRzLlByb3RvYnVmYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Vector3Data), Vector3Data.Parser, new string[3] { "X", "Y", "Z" }, null, null, null)
			}));
		}
	}
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		private static readonly MessageParser<Vector3Data> _parser = new MessageParser<Vector3Data>(() => new Vector3Data());

		public const int XFieldNumber = 1;

		private float x_;

		public const int YFieldNumber = 2;

		private float y_;

		public const int ZFieldNumber = 3;

		private float z_;

		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => Vector3DataReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public float X
		{
			get
			{
				return x_;
			}
			set
			{
				x_ = value;
			}
		}

		[DebuggerNonUserCode]
		public float Y
		{
			get
			{
				return y_;
			}
			set
			{
				y_ = value;
			}
		}

		[DebuggerNonUserCode]
		public float Z
		{
			get
			{
				return z_;
			}
			set
			{
				z_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
			: this()
		{
			x_ = other.x_;
			y_ = other.y_;
			z_ = other.z_;
		}

		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return new Vector3Data(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Vector3Data);
		}

		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (X != other.X)
			{
				return false;
			}
			if (Y != other.Y)
			{
				return false;
			}
			if (Z != other.Z)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (X != 0f)
			{
				num ^= X.GetHashCode();
			}
			if (Y != 0f)
			{
				num ^= Y.GetHashCode();
			}
			if (Z != 0f)
			{
				num ^= Z.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (X != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(X);
			}
			if (Y != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(Y);
			}
			if (Z != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(Z);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (X != 0f)
			{
				num += 5;
			}
			if (Y != 0f)
			{
				num += 5;
			}
			if (Z != 0f)
			{
				num += 5;
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Vector3Data other)
		{
			if (other != null)
			{
				if (other.X != 0f)
				{
					X = other.X;
				}
				if (other.Y != 0f)
				{
					Y = other.Y;
				}
				if (other.Z != 0f)
				{
					Z = other.Z;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 13u:
					X = input.ReadFloat();
					break;
				case 21u:
					Y = input.ReadFloat();
					break;
				case 29u:
					Z = input.ReadFloat();
					break;
				}
			}
		}
	}
}
namespace RecRoom.Circuits.Traversal
{
	[Flags]
	public enum DFSType
	{
		None = 0,
		DirectedForward = 1,
		DirectedBackward = 2,
		Undirected = 3
	}
	[Flags]
	public enum LinkTypes
	{
		NormalToNormal = 1,
		NormalToVirtual = 2,
		VirtualToNormal = 4,
		RootToVirtual = 8,
		RootToNormal = 0x10
	}
	internal struct TopologicStackEntry
	{
		public CircuitNode Node;

		public bool IsParent;
	}
	public static class GraphTraversal
	{
		public const LinkTypes ALL_LINKS = (LinkTypes)(-1);

		public const LinkTypes TopologicLinkTypes = ~LinkTypes.NormalToVirtual;

		public const LinkTypes ALL_LINKS_EXCEPT_ROOT = ~(LinkTypes.RootToVirtual | LinkTypes.RootToNormal);

		public static HashSet<CircuitNode> DFSCopy(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return new HashSet<CircuitNode>(DFS(root, dfsType, linkTypesToFollow));
		}

		public static IEnumerable<CircuitNode> DFS(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			Stack<CircuitNode> stack = new Stack<CircuitNode>();
			HashSet<CircuitNode> visited = new HashSet<CircuitNode>();
			stack.Push(root);
			while (stack.Count != 0)
			{
				CircuitNode current = stack.Pop();
				if (!visited.Add(current))
				{
					continue;
				}
				yield return current;
				if ((dfsType & DFSType.DirectedBackward) == DFSType.DirectedBackward)
				{
					foreach (CircuitLink value in current.Inputs.Values)
					{
						if (ShouldFollowLink(value, linkTypesToFollow) && !visited.Contains(value.SourceNode))
						{
							stack.Push(value.SourceNode);
						}
					}
				}
				if ((dfsType & DFSType.DirectedForward) != DFSType.DirectedForward)
				{
					continue;
				}
				foreach (HashSet<CircuitLink> value2 in current.Outputs.Values)
				{
					foreach (CircuitLink item in value2)
					{
						if (ShouldFollowLink(item, linkTypesToFollow) && !visited.Contains(item.DestNode))
						{
							stack.Push(item.DestNode);
						}
					}
				}
			}
		}

		public static List<CircuitNode> TopologicSort(CircuitNode root)
		{
			Stack<TopologicStackEntry> stack = new Stack<TopologicStackEntry>();
			HashSet<CircuitNode> hashSet = new HashSet<CircuitNode>();
			List<CircuitLink> list = new List<CircuitLink>();
			List<CircuitNode> list2 = new List<CircuitNode>();
			stack.Push(new TopologicStackEntry
			{
				Node = root,
				IsParent = false
			});
			while (stack.Count > 0)
			{
				TopologicStackEntry topologicStackEntry = stack.Pop();
				CircuitNode node = topologicStackEntry.Node;
				if (topologicStackEntry.IsParent)
				{
					list2.Add(node);
					continue;
				}
				if (hashSet.Add(node))
				{
					stack.Push(new TopologicStackEntry
					{
						Node = node,
						IsParent = true
					});
				}
				list.Clear();
				foreach (HashSet<CircuitLink> value in node.Outputs.Values)
				{
					list.AddRange(value);
				}
				list.Sort((CircuitLink l1, CircuitLink l2) => l1.DestNode.NodeId.CompareTo(l2.DestNode.NodeId));
				foreach (CircuitLink item in list)
				{
					if (ShouldFollowLink(item, ~LinkTypes.NormalToVirtual) && !hashSet.Contains(item.DestNode))
					{
						stack.Push(new TopologicStackEntry
						{
							Node = item.DestNode,
							IsParent = false
						});
					}
				}
			}
			return list2;
		}

		private static bool ShouldFollowLink(CircuitLink link, LinkTypes linkTypesToFollow)
		{
			return (link.LinkType & linkTypesToFollow) == link.LinkType;
		}

		public static LinkTypes FindLinkType(CircuitNode sourceNode, CircuitNode destNode)
		{
			if (sourceNode.IsRootNode && destNode.IsVirtual)
			{
				return LinkTypes.RootToVirtual;
			}
			if (sourceNode.IsRootNode && !destNode.IsVirtual)
			{
				return LinkTypes.RootToNormal;
			}
			if (sourceNode.IsVirtual && !destNode.IsVirtual)
			{
				return LinkTypes.VirtualToNormal;
			}
			if (!sourceNode.IsVirtual && destNode.IsVirtual)
			{
				return LinkTypes.NormalToVirtual;
			}
			if (!sourceNode.IsVirtual && !destNode.IsVirtual)
			{
				return LinkTypes.NormalToNormal;
			}
			throw new InvalidOperationException($"Unknown link type between src:{sourceNode.NodeName}{sourceNode.NodeId} dst: {destNode.NodeName}{destNode.NodeId}");
		}
	}
}
namespace RecRoom.Circuits.Utils
{
	public static class ByteStringExtensions
	{
		public static Guid ToGuid(this ByteString bytes)
		{
			if (bytes.IsEmpty)
			{
				return Guid.Empty;
			}
			if (bytes.Length != 16)
			{
				return Guid.Empty;
			}
			return new Guid(bytes.ToByteArray());
		}

		public static ByteString ToByteString(this Guid guid)
		{
			return ByteString.CopyFrom(guid.ToByteArray());
		}
	}
	internal static class RuntimeAssert
	{
		public static void Assert(bool condition, string message)
		{
			if (!condition)
			{
				throw new InvalidOperationException(message);
			}
		}

		public static void AssertFormat(bool condition, string format, params object[] args)
		{
			if (!condition)
			{
				throw new InvalidOperationException(string.Format(format, args));
			}
		}
	}
}
