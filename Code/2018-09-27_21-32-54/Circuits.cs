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
using RecRoom.Circuits.GameStats;
using RecRoom.Circuits.PlayerStats;
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
			if (obj == null || (object)GetType() != obj.GetType())
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
		public delegate void NodeLifecycleEvent(CircuitNode node);

		private struct OutputSignal
		{
			public int Value;

			public bool IsMomentary;
		}

		public delegate void NodeMetadataChanged(NodeMetadata newNodeMetadata);

		public delegate void ThisNodeConnectionChanged(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot);

		public delegate void NodeConnectionChanged(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot);

		public const int NULL_CIRCUIT_NODE_ID = 0;

		private static long globalMaxCircuitNodeId = 0L;

		private static object circuitIdLockObj = new object();

		public static NodeLifecycleEvent OnNodeDestroyedEvent = null;

		public static NodeLifecycleEvent OnNodeInstantiatedEvent = null;

		public const int ON_TRUE = 1;

		public const int OFF_FALSE = 0;

		public int ExecutionOrder = -1;

		private OutputSignal[] OutputSignals = new OutputSignal[8];

		public Dictionary<InputSlot, CircuitLink> Inputs = new Dictionary<InputSlot, CircuitLink>(EqualityComparers.InputSlotComparer);

		public Dictionary<OutputSlot, HashSet<CircuitLink>> Outputs = new Dictionary<OutputSlot, HashSet<CircuitLink>>(EqualityComparers.OutputSlotComparer);

		public NodeMetadataChanged NodeMetadataChangedEvent;

		private CircuitNodeGraph _nodeGraph;

		private OutputSignal[] outputValuesDeserializationBuffer = new OutputSignal[8];

		public ThisNodeConnectionChanged OnConnectedEvent;

		public static NodeConnectionChanged OnNodesConnectedEvent = null;

		public ThisNodeConnectionChanged OnDisconnectedEvent;

		public static NodeConnectionChanged OnNodesDisconnectedEvent = null;

		private static Dictionary<int, CircuitNode> AllNodes = new Dictionary<int, CircuitNode>();

		private static InputMetadata[] allSlotsInputMetadata = null;

		private static OutputMetadata[] allSlotsOutputMetadata = null;

		public virtual bool IsVirtual => false;

		internal virtual bool IsRootNode => false;

		internal virtual bool IsStateful => false;

		internal virtual bool RequiresPostEval => false;

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

		public event Action NodeModifiedEvent;

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

		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
			OnNodeDestroyedEvent.SafeInvoke(node);
		}

		private static void SendNodeInstantiatedEvent(CircuitNode node)
		{
			OnNodeInstantiatedEvent.SafeInvoke(node);
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
			foreach (KeyValuePair<InputSlot, CircuitLink> input in Inputs)
			{
				CircuitLink value = input.Value;
				RuntimeAssert.AssertFormat(value.SourceNode.NodeGraph.GraphGuid == value.DestNode.NodeGraph.GraphGuid, "Node {0} Input Link {1}=>{2} had source and dest in different graphs", NodeId, value.SourceNode.NodeId, value.DestNode.NodeId);
				circuitNodeData.CircuitLinks.Add(value.Serialize());
			}
			foreach (HashSet<CircuitLink> value2 in Outputs.Values)
			{
				foreach (CircuitLink item in value2)
				{
					RuntimeAssert.AssertFormat(item.SourceNode.NodeGraph.GraphGuid == item.DestNode.NodeGraph.GraphGuid, "Node {0} OutputLink Link {1}=>{2} had source and dest in different graphs", NodeId, item.SourceNode.NodeId, item.DestNode.NodeId);
					circuitNodeData.CircuitLinks.Add(item.Serialize());
				}
			}
			return circuitNodeData;
		}

		internal virtual void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			if (data.PairedNodeId != 0 && !copyingSettings)
			{
				int num = nodeIdMap[data.PairedNodeId];
				PairedNode = Find(num);
				RuntimeAssert.AssertFormat(PairedNode != null, "PairedNode with ID {0}=>{1} can't be null!", data.PairedNodeId, num);
			}
		}

		public void CopySettings(CircuitNodeData data)
		{
			InitializeInnerData(data, reassignNodeIds: false, new Dictionary<int, int>(), copyingSettings: true);
		}

		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
			RepeatedField<CircuitLinkData> circuitLinks = data.CircuitLinks;
			new HashSet<CircuitLink>();
			foreach (CircuitLinkData item in circuitLinks)
			{
				RuntimeAssert.AssertFormat(nodeIdMap.ContainsKey(item.SourceNodeId), "Bad link found during deserialization {0}=>{1}. Source Node Id wasn't mapped", item.SourceNodeId, item.DestNodeId);
				RuntimeAssert.AssertFormat(nodeIdMap.ContainsKey(item.DestNodeId), "Bad link found during deserialization {0}=>{1}. Dest Node Id wasn't mapped", item.SourceNodeId, item.DestNodeId);
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

		internal virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
			SerializeOutputValues(bitPacker);
		}

		internal virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
			DeserializeOutputValues(bitPacker);
		}

		internal virtual void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		internal virtual void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		private void SerializeOutputValues(BitPacker bitPacker)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < IOSlots.AllOutputSlots.Length; i++)
			{
				OutputSlot outputSlot = IOSlots.AllOutputSlots[i];
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
			for (int j = 0; j < IOSlots.AllOutputSlots.Length; j++)
			{
				OutputSlot outputSlot2 = IOSlots.AllOutputSlots[j];
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
			for (int i = 0; i < IOSlots.AllOutputSlots.Length; i++)
			{
				OutputSlot key = IOSlots.AllOutputSlots[i];
				if (Outputs.ContainsKey(key))
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
			for (int k = 0; k < IOSlots.AllOutputSlots.Length; k++)
			{
				OutputSlot outputSlot = IOSlots.AllOutputSlots[k];
				if (Outputs.ContainsKey(outputSlot))
				{
					int num2 = (int)outputSlot;
					SetOutput(outputSlot, outputValuesDeserializationBuffer[num2].Value, outputValuesDeserializationBuffer[num2].IsMomentary);
				}
			}
		}

		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
			if (_nodeGraph != newNodeGraph)
			{
				RuntimeAssert.Assert(newNodeGraph != null || Destroyed, "Can't set newNodeGraph to null unless we're destroying!");
				RuntimeAssert.Assert(newNodeGraph == null || !Destroyed, "Can't set newNodeGraph to null unless we're destroying!");
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
					CircuitNodeGraph newNodeGraph = new CircuitNodeGraph();
					circuitLink.SourceNode.SetNodeGraph(newNodeGraph);
					circuitLink.DestNode.SetNodeGraph(newNodeGraph);
				}
				if (!skipMerge && circuitLink.SourceNode.NodeGraph != circuitLink.DestNode.NodeGraph)
				{
					CircuitNodeGraph.MergeGraphs(circuitLink.SourceNode, circuitLink.DestNode);
				}
				if (!skipMerge)
				{
					RuntimeAssert.AssertFormat(circuitLink.SourceNode.NodeGraph == circuitLink.DestNode.NodeGraph, "Graph mismatch after NL connect {0}=>{1}", circuitLink.SourceNode.NodeId, circuitLink.DestNode.NodeId);
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
			try
			{
				if (sourceNode != null && sourceNode.OnConnectedEvent != null)
				{
					sourceNode.OnConnectedEvent(destNode, inputSlot, outputSlot);
				}
				if (destNode != null && destNode.OnConnectedEvent != null)
				{
					destNode.OnConnectedEvent(sourceNode, inputSlot, outputSlot);
				}
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e);
			}
			OnNodesConnectedEvent.SafeInvoke(sourceNode, destNode, inputSlot, outputSlot);
		}

		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			try
			{
				if (sourceNode != null && sourceNode.OnDisconnectedEvent != null)
				{
					sourceNode.OnDisconnectedEvent(destNode, inputSlot, outputSlot);
				}
				if (destNode != null && destNode.OnDisconnectedEvent != null)
				{
					destNode.OnDisconnectedEvent(sourceNode, inputSlot, outputSlot);
				}
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e);
			}
			OnNodesDisconnectedEvent.SafeInvoke(sourceNode, destNode, inputSlot, outputSlot);
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
			if (destNode.Destroyed)
			{
				CircuitNode circuitNode = sourceNode;
				sourceNode = destNode;
				destNode = circuitNode;
			}
			IEnumerable<CircuitNode> other = GraphTraversal.DFS(sourceNode, DFSType.Undirected, ~(LinkTypes.RootToVirtual | LinkTypes.RootToNormal));
			HashSet<CircuitNode> hashSet = GraphTraversal.DFSCopy(destNode, DFSType.Undirected, ~(LinkTypes.RootToVirtual | LinkTypes.RootToNormal));
			HashSet<CircuitNode> hashSet2 = new HashSet<CircuitNode>(hashSet);
			hashSet2.IntersectWith(other);
			if (hashSet.Count == 0)
			{
				CircuitDebug.Log(CircuitLogLevel.Error, "Attempting to check for disconnect with empty destNode Graph!");
				return false;
			}
			if (hashSet2.Count == 0 && hashSet.Count > 0)
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

		internal virtual void PostEvaluateNode(bool isMasterClient)
		{
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

		public void ModifyNode(Dictionary<object, object> modifyArgs)
		{
			_ModifyNode(modifyArgs);
			NodeGraph.NodeGraphDirty = true;
			if (this.NodeModifiedEvent != null)
			{
				this.NodeModifiedEvent();
			}
		}

		protected virtual void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
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

		public static int ClampSignal(int value, int min, int max)
		{
			return Math.Max(min, Math.Min(max, value));
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
	internal delegate void UpdateGraph(int networkTimeMilliseconds, bool isMasterClient);
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

		private HashSet<CircuitNode> needsPostEval = new HashSet<CircuitNode>();

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

		public bool NodeGraphDirty { get; set; }

		internal static event UpdateGraph TimeUpdate;

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

		internal void AddNode(CircuitNode circuitNode, bool skipMerge = false)
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

		internal bool RemoveNode(CircuitNode circuitNode)
		{
			Nodes.Remove(circuitNode);
			if (circuitNode.IsStateful)
			{
				circuitNode.DisconnectInput(InputSlot.VIRTUAL);
				StatefulNodes.Remove(circuitNode);
			}
			if (Nodes.Count == 1)
			{
				RootNode.Destroy(disconnectLinks: false);
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
			needsPostEval.Clear();
			for (int num = ReverseTopologicNodes.Count - 1; num >= 0; num--)
			{
				int executionOrder = ReverseTopologicNodes.Count - num;
				CircuitNode circuitNode = ReverseTopologicNodes[num];
				circuitNode.ExecutionOrder = executionOrder;
				circuitNode.EvaluateNode(isMasterClient);
				if (circuitNode.HasMomentaryOutputs() || circuitNode.RequiresPostEval)
				{
					needsPostEval.Add(circuitNode);
				}
			}
			foreach (CircuitNode item in needsPostEval)
			{
				item.ClearMomentaryOutputs();
				item.PostEvaluateNode(isMasterClient);
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

		public static byte[] SerializePostEvaluateState()
		{
			using MemoryStream memoryStream = new MemoryStream();
			bitPacker.StartWriting(memoryStream);
			foreach (CircuitNodeGraph allGraph in AllGraphs)
			{
				foreach (CircuitNode statefulNode in allGraph.StatefulNodes)
				{
					statefulNode.SerializePostEvaluateState(bitPacker);
				}
			}
			bitPacker.FinishWriting();
			return memoryStream.ToArray();
		}

		public static void DeserializePostEvaluateState(byte[] data)
		{
			using MemoryStream stream = new MemoryStream(data);
			bitPacker.StartReading(stream, data.Length);
			foreach (CircuitNodeGraph allGraph in AllGraphs)
			{
				foreach (CircuitNode statefulNode in allGraph.StatefulNodes)
				{
					statefulNode.DeserializePostEvaluateState(bitPacker);
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
				item.Key.InitializeInnerData(item.Value, reassignNodeIds, nodeIdMap, copyingSettings: false);
			}
			foreach (KeyValuePair<CircuitNode, CircuitNodeData> item2 in dictionary)
			{
				item2.Key.DeserializeLinks(item2.Value, nodeIdMap);
			}
			if (circuitNodeGraph.Nodes.Count <= 1)
			{
				CircuitDebug.GraphLog(circuitNodeGraph.GraphGuid, "Cleaning up empty graph in Deserialize");
				circuitNodeGraph.Destroy();
				return null;
			}
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
			IEnumerable<CircuitNode> enumerable = ((!useDFS) ? ((IEnumerable<CircuitNode>)RootNode.NodeGraph.Nodes) : ((IEnumerable<CircuitNode>)GraphTraversal.DFS(RootNode, DFSType.Undirected, (LinkTypes)(-1)).ToList()));
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

		public static InputSlot[] AllStandardInputSlots = ((InputSlot[])Enum.GetValues(typeof(InputSlot))).Where((InputSlot t) => t != InputSlot.VIRTUAL && t != InputSlot.RESET).ToArray();

		public static OutputSlot[] AllOutputSlots = ((OutputSlot[])Enum.GetValues(typeof(OutputSlot))).Where((OutputSlot t) => t != OutputSlot.VIRTUAL).ToArray();

		public static OutputSlot[] AllStandardOutputSlots = ((OutputSlot[])Enum.GetValues(typeof(OutputSlot))).Where((OutputSlot t) => t != OutputSlot.VIRTUAL && t != OutputSlot.RESET).ToArray();

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

		private static readonly OutputMetadata[] NotOutputMeta = new OutputMetadata[2]
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

		private static readonly OutputMetadata[] OutputMeta = new OutputMetadata[3]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.G
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
			bool flag = CalcOutput();
			int val = CircuitNode.BoolToSignal(flag);
			SetContinuousOutput(OutputSlot.R, val);
			if (BooleanMode != BooleanModes.Not)
			{
				int val2 = CircuitNode.BoolToSignal(!flag);
				SetContinuousOutput(OutputSlot.G, val2);
			}
		}

		private bool CalcOutput()
		{
			return BooleanMode switch
			{
				BooleanModes.And => CalcAndOutput(), 
				BooleanModes.Or => CalcOrOutput(), 
				BooleanModes.Not => !CircuitNode.SignalToBool(GetInputSignal(InputSlot.R)), 
				_ => false, 
			};
		}

		private bool CalcAndOutput()
		{
			FetchInputs();
			bool flag = true;
			for (int i = 0; i < inputs.Count; i++)
			{
				flag = flag && CircuitNode.SignalToBool(inputs[i]);
			}
			return inputs.Count > 0 && flag;
		}

		private bool CalcOrOutput()
		{
			FetchInputs();
			bool flag = false;
			for (int i = 0; i < inputs.Count; i++)
			{
				flag = flag || CircuitNode.SignalToBool(inputs[i]);
			}
			return inputs.Count > 0 && flag;
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
			BooleanModes booleanModes = BooleanMode;
			if ((uint)booleanModes <= 1u)
			{
				return OutputMeta;
			}
			return NotOutputMeta;
		}

		protected override string GetNodeDescription()
		{
			return GetModeSymbol(BooleanMode);
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			BooleanMode = (BooleanModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)BooleanMode;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				BooleanMode = (BooleanModes)value;
			}
		}
	}
	[CircuitNodeUuid("B7BA1A4B-EA04-496F-B8B6-A2FB7C4A42B9")]
	public class ContinuousSourceNode : SourceNodeBase
	{
		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
			: base("ContinuousSourceNode", nodeId, graph)
		{
		}

		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
			base.SetContinuousOutput(outputSlot, value);
		}
	}
	[CircuitNodeUuid("53219714-E7BB-4950-BBB3-852A7EF196F8")]
	public class GameSetStateNode : PostEvalActionNode
	{
		private static InputMetadata[] inputMeta = new InputMetadata[2]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Start Game"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "End Game"
			}
		};

		private static OutputMetadata[] outputMeta = new OutputMetadata[0];

		public event Action StartGame;

		public event Action EndGame;

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return outputMeta;
		}

		public GameSetStateNode(int nodeId, CircuitNodeGraph graph)
			: base("GameSetStateNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			int inputSignal = GetInputSignal(InputSlot.R);
			int inputSignal2 = GetInputSignal(InputSlot.G);
			if (CircuitNode.SignalToBool(inputSignal))
			{
				QueuePostEvalAction(delegate
				{
					if (this.StartGame != null)
					{
						this.StartGame();
					}
				});
			}
			if (!CircuitNode.SignalToBool(inputSignal2))
			{
				return;
			}
			QueuePostEvalAction(delegate
			{
				if (this.EndGame != null)
				{
					this.EndGame();
				}
			});
		}
	}
	[CircuitNodeUuid("20C6AC2E-1116-4C93-8CDF-40FE161CC796")]
	public class ObjectSetTagsNode : CircuitNode
	{
		public enum ChangeModes
		{
			Add,
			Remove,
			Defaults
		}

		public delegate void ChangeTagsForObjectFunc(int objectId);

		public const string MODE_ARG = "mode";

		private const string nodeDescription = "Change Tags on Object";

		private static readonly InputMetadata[] inputMeta = new InputMetadata[2]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Object ID"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset Signal"
			}
		};

		private static readonly OutputMetadata[] outputMeta = new OutputMetadata[1]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Object ID"
			}
		};

		private ChangeModes changeMode;

		public ChangeModes ChangeMode
		{
			get
			{
				return changeMode;
			}
			internal set
			{
				if (changeMode != value)
				{
					changeMode = value;
				}
			}
		}

		public event ChangeTagsForObjectFunc ChangeTagsForObject;

		public ObjectSetTagsNode(int nodeId, CircuitNodeGraph graph)
			: base("ObjectSetTagsNode", nodeId, graph)
		{
		}

		protected override string GetNodeDescription()
		{
			return "Change Tags on Object";
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return outputMeta;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				ChangeMode = (ChangeModes)value;
			}
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			int inputSignal = GetInputSignal(InputSlot.R);
			if (!isMasterClient)
			{
				return;
			}
			try
			{
				if (CircuitNode.SignalToBool(inputSignal))
				{
					this.ChangeTagsForObject(inputSignal);
					SetContinuousOutput(OutputSlot.R, inputSignal);
				}
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e);
			}
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			ChangeMode = (ChangeModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)ChangeMode;
			return circuitNodeData;
		}
	}
	[CircuitNodeUuid("0D0D8EA8-2816-4B3B-8F1D-19C74B056DA6")]
	public class PlayerRoleMappingNode : PostEvalActionNode
	{
		public enum PlayerRoleMapModes
		{
			AddPlayerRole,
			RemovePlayerRole,
			PlayerHasRole,
			PlayerRoleChanged
		}

		public delegate void PlayerModifyRoleFunc(int playerId, int roleId);

		public delegate bool PlayerHasRoleFunc(int playerId, int roleId);

		private const InputSlot IN_PLAYER_SLOT = InputSlot.R;

		private const InputSlot IN_TEAM_SLOT = InputSlot.G;

		private const OutputSlot OUT_PLAYER_SLOT = OutputSlot.R;

		private const OutputSlot OUT_HAS_ROLE_SLOT = OutputSlot.G;

		public const string MODE_ARG = "mode";

		public const string MODIFICATION_ROLE_ID_ARG = "roleId";

		private static readonly OutputMetadata[] PlayerHasRoleOutputMeta = new OutputMetadata[3]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Player"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.G,
				Description = "Has Role"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly OutputMetadata[] PlayerRoleChangedOutputMeta = new OutputMetadata[2]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Player"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly InputMetadata[] PlayerHasRoleInputMeta = new InputMetadata[2]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Player"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly InputMetadata[] ModifyPlayerRoleInputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Player"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Team"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly OutputMetadata[] ModifyPlayerRoleOutputMeta = new OutputMetadata[0];

		public static Dictionary<string, int> FriendlyModes = new Dictionary<string, int>
		{
			{ "Add Player Role", 0 },
			{ "Remove Player Role", 1 },
			{ "Player has Role", 2 },
			{ "Player Role Changed", 3 }
		};

		private PlayerRoleMapModes playerRoleMapMode = PlayerRoleMapModes.PlayerHasRole;

		private int modificationRoleId;

		private bool masterLastPlayerHasRoleSignal;

		internal override bool IsStateful => true;

		public PlayerRoleMapModes PlayerRoleMapMode
		{
			get
			{
				return playerRoleMapMode;
			}
			internal set
			{
				if (playerRoleMapMode != value)
				{
					playerRoleMapMode = value;
					ReconstructNodeMetadata();
				}
			}
		}

		public int ModificationRoleId
		{
			get
			{
				return modificationRoleId;
			}
			internal set
			{
				if (modificationRoleId != value)
				{
					modificationRoleId = value;
					ReconstructNodeMetadata();
				}
			}
		}

		public override string NodeVisualizationLabel => GetNodeDescription() + "\\n" + base.NodeVisualizationLabel;

		public event PlayerModifyRoleFunc PlayerAddRole;

		public event PlayerModifyRoleFunc TeamAddRole;

		public event PlayerModifyRoleFunc PlayerRemoveRole;

		public event PlayerModifyRoleFunc TeamRemoveRole;

		public event PlayerHasRoleFunc PlayerHasRole;

		public void MarkDirtyForRoleChange(int playerId)
		{
			base.NodeGraph.NodeGraphDirty = true;
			if (PlayerRoleMapMode == PlayerRoleMapModes.PlayerRoleChanged)
			{
				SetMomentaryOutput(OutputSlot.R, playerId);
			}
		}

		public PlayerRoleMappingNode(int nodeId, CircuitNodeGraph graph)
			: base("PlayerRoleMappingNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			switch (PlayerRoleMapMode)
			{
			case PlayerRoleMapModes.AddPlayerRole:
				EvaluateAddPlayerRole();
				break;
			case PlayerRoleMapModes.RemovePlayerRole:
				EvaluateRemovePlayerRole();
				break;
			case PlayerRoleMapModes.PlayerHasRole:
				EvaluatePlayerHasRole(isMasterClient);
				break;
			}
		}

		private void EvaluatePlayerHasRole(bool isMasterClient)
		{
			int inputSignal = GetInputSignal(InputSlot.R);
			masterLastPlayerHasRoleSignal = GetPlayerHasRoleSignal(isMasterClient, inputSignal);
			SetContinuousOutput(OutputSlot.R, masterLastPlayerHasRoleSignal ? inputSignal : 0);
			SetContinuousOutput(OutputSlot.G, CircuitNode.BoolToSignal(masterLastPlayerHasRoleSignal));
		}

		private bool GetPlayerHasRoleSignal(bool isMasterClient, int playerId)
		{
			if (!isMasterClient)
			{
				return masterLastPlayerHasRoleSignal;
			}
			if (playerId != 0)
			{
				try
				{
					return this.PlayerHasRole(playerId, ModificationRoleId);
				}
				catch (Exception e)
				{
					CircuitDebug.LogException(e);
				}
			}
			return false;
		}

		private void EvaluateAddPlayerRole()
		{
			int playerId = GetInputSignal(InputSlot.R);
			int teamId = GetInputSignal(InputSlot.G);
			if (ModificationRoleId != 0 && playerId != 0 && this.PlayerAddRole != null)
			{
				QueuePostEvalAction(delegate
				{
					this.PlayerAddRole(playerId, ModificationRoleId);
				});
			}
			else if (ModificationRoleId != 0 && teamId != 0 && this.PlayerAddRole != null)
			{
				QueuePostEvalAction(delegate
				{
					this.TeamAddRole(teamId, ModificationRoleId);
				});
			}
		}

		private void EvaluateRemovePlayerRole()
		{
			int playerId = GetInputSignal(InputSlot.R);
			int teamId = GetInputSignal(InputSlot.G);
			if (ModificationRoleId != 0 && playerId != 0 && this.PlayerRemoveRole != null)
			{
				QueuePostEvalAction(delegate
				{
					this.PlayerRemoveRole(playerId, ModificationRoleId);
				});
			}
			else if (ModificationRoleId != 0 && teamId != 0 && this.PlayerAddRole != null)
			{
				QueuePostEvalAction(delegate
				{
					this.TeamRemoveRole(teamId, ModificationRoleId);
				});
			}
		}

		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
			base.SerializePostEvaluateState(bitPacker);
			bitPacker.WriteBool(masterLastPlayerHasRoleSignal);
		}

		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
			base.DeserializePostEvaluateState(bitPacker);
			bitPacker.ReadBool(out masterLastPlayerHasRoleSignal);
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			switch (PlayerRoleMapMode)
			{
			case PlayerRoleMapModes.PlayerHasRole:
				return PlayerHasRoleInputMeta;
			case PlayerRoleMapModes.PlayerRoleChanged:
				return new InputMetadata[0];
			case PlayerRoleMapModes.AddPlayerRole:
			case PlayerRoleMapModes.RemovePlayerRole:
				return ModifyPlayerRoleInputMeta;
			default:
				throw new InvalidOperationException("Unsupported mode");
			}
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			switch (PlayerRoleMapMode)
			{
			case PlayerRoleMapModes.PlayerHasRole:
				return PlayerHasRoleOutputMeta;
			case PlayerRoleMapModes.PlayerRoleChanged:
				return PlayerRoleChangedOutputMeta;
			case PlayerRoleMapModes.AddPlayerRole:
			case PlayerRoleMapModes.RemovePlayerRole:
				return ModifyPlayerRoleOutputMeta;
			default:
				throw new InvalidOperationException("Unsupported mode");
			}
		}

		protected override string GetNodeDescription()
		{
			return PlayerRoleMapMode switch
			{
				PlayerRoleMapModes.PlayerHasRole => "Player Has Role?", 
				PlayerRoleMapModes.PlayerRoleChanged => "Player Role Changed", 
				PlayerRoleMapModes.AddPlayerRole => "Add Player Role", 
				PlayerRoleMapModes.RemovePlayerRole => "Remove Player Role", 
				_ => throw new InvalidOperationException("Unsupported mode"), 
			};
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			PlayerRoleMapMode = (PlayerRoleMapModes)data.Mode;
			ModificationRoleId = data.RoleId;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)PlayerRoleMapMode;
			circuitNodeData.RoleId = ModificationRoleId;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				PlayerRoleMapMode = (PlayerRoleMapModes)value;
			}
			if (modifyArgs.TryGetValue("roleId", out var value2))
			{
				ModificationRoleId = (int)value2;
			}
		}
	}
	[CircuitNodeUuid("CEE29EB9-61AE-42D4-8DC6-3A62D7096781")]
	public class PlayerTeamMappingNode : PostEvalActionNode
	{
		public enum PlayerIdMapModes
		{
			PlayerToTeam,
			TeamToPlayer,
			SetPlayerTeam,
			GetTeamPlayerCount
		}

		public delegate void PlayerToTeamIndexFunc(int playerId, out int teamId, out int teamIndex);

		public delegate void PlayerSetTeamFunc(int playerId, int teamId);

		public delegate void TeamIndexToPlayerFunc(int teamId, int teamIndex, out int playerId);

		public delegate void GetTeamPlayerCountFunc(int teamId, out int teamPlayerCount);

		private const InputSlot IN_PLAYER_SLOT = InputSlot.R;

		private const InputSlot IN_TEAM_SLOT = InputSlot.G;

		private const InputSlot IN_TEAM_INDEX_SLOT = InputSlot.B;

		private const OutputSlot OUT_PLAYER_SLOT = OutputSlot.R;

		private const OutputSlot OUT_TEAM_SLOT = OutputSlot.G;

		private const OutputSlot OUT_TEAM_INDEX_SLOT = OutputSlot.B;

		public const string MODE_ARG = "mode";

		private static readonly InputMetadata[] PlayerToTeamInputMeta = new InputMetadata[2]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Player"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly OutputMetadata[] PlayerToTeamOutputMeta = new OutputMetadata[3]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.G,
				Description = "Team"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.B,
				Description = "Index"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly InputMetadata[] TeamToPlayerInputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Team"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.B,
				Description = "Index"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly OutputMetadata[] TeamToPlayerOutputMeta = new OutputMetadata[2]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Player"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly InputMetadata[] SetPlayerTeamInputMeta = new InputMetadata[2]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Player"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Team"
			}
		};

		private static readonly InputMetadata[] GetTeamPlayerCountInputMeta = new InputMetadata[1]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Team"
			}
		};

		private static readonly OutputMetadata[] GetTeamPlayerCountOutputMeta = new OutputMetadata[1]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Player Count"
			}
		};

		private static readonly OutputMetadata[] SetPlayerTeamOutputMeta = new OutputMetadata[0];

		public static Dictionary<string, int> FriendlyModes = new Dictionary<string, int>
		{
			{ "Player to Team", 0 },
			{ "Team to Player", 1 },
			{ "Set Player Team", 2 },
			{ "Get Team Player Count", 3 }
		};

		private PlayerIdMapModes playerIdMapMode;

		private int lastMasterPlayerToTeamId;

		private int lastMasterPlayerToTeamIndex;

		private int lastMasterTeamIndexToPlayer;

		private int lastMasterTeamPlayerCount;

		internal override bool IsStateful => true;

		public PlayerIdMapModes PlayerIdMapMode
		{
			get
			{
				return playerIdMapMode;
			}
			internal set
			{
				if (playerIdMapMode != value)
				{
					playerIdMapMode = value;
					ReconstructNodeMetadata();
				}
			}
		}

		public override string NodeVisualizationLabel => GetNodeDescription() + "\\n" + base.NodeVisualizationLabel;

		public event PlayerToTeamIndexFunc PlayerToTeamIndex;

		public event PlayerSetTeamFunc PlayerSetTeam;

		public event TeamIndexToPlayerFunc TeamIndexToPlayer;

		public event GetTeamPlayerCountFunc GetTeamPlayerCount;

		public void MarkDirtyForTeamChange()
		{
			base.NodeGraph.NodeGraphDirty = true;
		}

		public PlayerTeamMappingNode(int nodeId, CircuitNodeGraph graph)
			: base("PlayerIdMapNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			switch (PlayerIdMapMode)
			{
			case PlayerIdMapModes.PlayerToTeam:
				EvaluatePlayerToTeam(isMasterClient);
				break;
			case PlayerIdMapModes.TeamToPlayer:
				EvaluateTeamToPlayer(isMasterClient);
				break;
			case PlayerIdMapModes.GetTeamPlayerCount:
				EvaluateGetTeamPlayerCount(isMasterClient);
				break;
			case PlayerIdMapModes.SetPlayerTeam:
				EvaluateSetPlayerTeam(isMasterClient);
				break;
			default:
				CircuitDebug.NodeLog(base.NodeId, "Unknown PlayerIdMapMode:" + PlayerIdMapMode, CircuitLogLevel.Error);
				break;
			}
		}

		private void EvaluatePlayerToTeam(bool isMasterClient)
		{
			int inputSignal = GetInputSignal(InputSlot.R);
			GetPlayerToTeamSignals(isMasterClient, inputSignal, out lastMasterPlayerToTeamId, out lastMasterPlayerToTeamIndex);
			SetContinuousOutput(OutputSlot.G, lastMasterPlayerToTeamId);
			SetContinuousOutput(OutputSlot.B, lastMasterPlayerToTeamIndex);
		}

		private void GetPlayerToTeamSignals(bool isMasterClient, int playerId, out int masterTeamId, out int masterTeamIndex)
		{
			if (!isMasterClient)
			{
				masterTeamId = lastMasterPlayerToTeamId;
				masterTeamIndex = lastMasterPlayerToTeamIndex;
				return;
			}
			masterTeamId = 0;
			masterTeamIndex = 0;
			if (playerId == 0)
			{
				return;
			}
			try
			{
				this.PlayerToTeamIndex(playerId, out masterTeamId, out masterTeamIndex);
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e);
			}
		}

		private void EvaluateTeamToPlayer(bool isMasterClient)
		{
			int inputSignal = GetInputSignal(InputSlot.G);
			int inputSignal2 = GetInputSignal(InputSlot.B);
			lastMasterTeamIndexToPlayer = GetTeamIndexToPlayerSignal(isMasterClient, inputSignal, inputSignal2);
			SetContinuousOutput(OutputSlot.R, lastMasterTeamIndexToPlayer);
		}

		private int GetTeamIndexToPlayerSignal(bool isMasterClient, int teamId, int teamIndex)
		{
			if (!isMasterClient)
			{
				return lastMasterTeamIndexToPlayer;
			}
			if (teamId != 0 && teamIndex != 0 && this.TeamIndexToPlayer != null)
			{
				int playerId = 0;
				try
				{
					this.TeamIndexToPlayer(teamId, teamIndex, out playerId);
					return playerId;
				}
				catch (Exception e)
				{
					CircuitDebug.LogException(e);
				}
			}
			return 0;
		}

		private void EvaluateGetTeamPlayerCount(bool isMasterClient)
		{
			int inputSignal = GetInputSignal(InputSlot.G);
			lastMasterTeamPlayerCount = CircuitNode.ClampSignal(GetTeamPlayerCountSignal(isMasterClient, inputSignal), 0, 255);
			SetContinuousOutput(OutputSlot.R, lastMasterTeamPlayerCount);
		}

		private int GetTeamPlayerCountSignal(bool isMasterClient, int teamId)
		{
			if (!isMasterClient)
			{
				return lastMasterTeamPlayerCount;
			}
			int teamPlayerCount = 0;
			if (teamId != 0 && this.GetTeamPlayerCount != null)
			{
				try
				{
					this.GetTeamPlayerCount(teamId, out teamPlayerCount);
					return teamPlayerCount;
				}
				catch (Exception e)
				{
					CircuitDebug.LogException(e);
				}
			}
			return 0;
		}

		private void EvaluateSetPlayerTeam(bool isMasterClient)
		{
			if (!isMasterClient)
			{
				return;
			}
			int playerId = GetInputSignal(InputSlot.R);
			int teamId = GetInputSignal(InputSlot.G);
			if (teamId != 0 && playerId != 0 && this.PlayerSetTeam != null)
			{
				QueuePostEvalAction(delegate
				{
					this.PlayerSetTeam(playerId, teamId);
				});
			}
		}

		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
			base.SerializePostEvaluateState(bitPacker);
			bool flag = false;
			switch (PlayerIdMapMode)
			{
			case PlayerIdMapModes.PlayerToTeam:
				flag = lastMasterPlayerToTeamId != 0 || lastMasterPlayerToTeamIndex != 0;
				bitPacker.WriteBool(flag);
				if (flag)
				{
					bitPacker.WriteInt(lastMasterPlayerToTeamId, int.MinValue, int.MaxValue);
					bitPacker.WriteInt(lastMasterPlayerToTeamIndex, int.MinValue, int.MaxValue);
				}
				break;
			case PlayerIdMapModes.TeamToPlayer:
				flag = lastMasterTeamIndexToPlayer != 0;
				bitPacker.WriteBool(flag);
				if (flag)
				{
					bitPacker.WriteInt(lastMasterTeamIndexToPlayer, int.MinValue, int.MaxValue);
				}
				break;
			case PlayerIdMapModes.GetTeamPlayerCount:
				flag = lastMasterTeamPlayerCount != 0;
				bitPacker.WriteBool(flag);
				if (flag)
				{
					bitPacker.WriteInt(lastMasterTeamPlayerCount, 0, 256);
				}
				break;
			case PlayerIdMapModes.SetPlayerTeam:
				break;
			}
		}

		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
			base.DeserializePostEvaluateState(bitPacker);
			bool value = false;
			switch (PlayerIdMapMode)
			{
			case PlayerIdMapModes.PlayerToTeam:
				bitPacker.ReadBool(out value);
				if (value)
				{
					bitPacker.ReadInt(out lastMasterPlayerToTeamId, int.MinValue, int.MaxValue);
					bitPacker.ReadInt(out lastMasterPlayerToTeamIndex, int.MinValue, int.MaxValue);
				}
				else
				{
					lastMasterPlayerToTeamId = 0;
					lastMasterPlayerToTeamIndex = 0;
				}
				break;
			case PlayerIdMapModes.TeamToPlayer:
				bitPacker.ReadBool(out value);
				if (value)
				{
					bitPacker.ReadInt(out lastMasterTeamIndexToPlayer, int.MinValue, int.MaxValue);
				}
				else
				{
					lastMasterTeamIndexToPlayer = 0;
				}
				break;
			case PlayerIdMapModes.GetTeamPlayerCount:
				bitPacker.ReadBool(out value);
				if (value)
				{
					bitPacker.ReadInt(out lastMasterTeamPlayerCount, 0, 256);
				}
				else
				{
					lastMasterTeamPlayerCount = 0;
				}
				break;
			case PlayerIdMapModes.SetPlayerTeam:
				break;
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return PlayerIdMapMode switch
			{
				PlayerIdMapModes.PlayerToTeam => PlayerToTeamInputMeta, 
				PlayerIdMapModes.TeamToPlayer => TeamToPlayerInputMeta, 
				PlayerIdMapModes.SetPlayerTeam => SetPlayerTeamInputMeta, 
				PlayerIdMapModes.GetTeamPlayerCount => GetTeamPlayerCountInputMeta, 
				_ => throw new InvalidOperationException("Unsupported mode"), 
			};
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return PlayerIdMapMode switch
			{
				PlayerIdMapModes.PlayerToTeam => PlayerToTeamOutputMeta, 
				PlayerIdMapModes.TeamToPlayer => TeamToPlayerOutputMeta, 
				PlayerIdMapModes.SetPlayerTeam => SetPlayerTeamOutputMeta, 
				PlayerIdMapModes.GetTeamPlayerCount => GetTeamPlayerCountOutputMeta, 
				_ => throw new InvalidOperationException("Unsupported mode"), 
			};
		}

		protected override string GetNodeDescription()
		{
			if (PlayerIdMapMode != PlayerIdMapModes.PlayerToTeam)
			{
				return "Team to Player";
			}
			return "Player to Team";
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			PlayerIdMapMode = (PlayerIdMapModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)PlayerIdMapMode;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				PlayerIdMapMode = (PlayerIdMapModes)value;
			}
		}
	}
	public abstract class PostEvalActionNode : CircuitNode
	{
		private List<Action> PostEvalActions = new List<Action>();

		internal sealed override bool RequiresPostEval
		{
			get
			{
				if (!base.RequiresPostEval)
				{
					return PostEvalActions.Count > 0;
				}
				return true;
			}
		}

		public PostEvalActionNode(string name, int nodeId, CircuitNodeGraph graph)
			: base(name, nodeId, graph)
		{
		}

		protected void QueuePostEvalAction(Action a)
		{
			PostEvalActions.Add(a);
		}

		internal sealed override void PostEvaluateNode(bool isMasterClient)
		{
			base.PostEvaluateNode(isMasterClient);
			int i = 0;
			try
			{
				for (; i < PostEvalActions.Count; i++)
				{
					PostEvalActions[i]();
				}
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e, "Error firing post evaluate action " + i);
			}
			finally
			{
				PostEvalActions.Clear();
			}
		}
	}
	[CircuitNodeUuid("3079A591-0E82-41B5-8BEC-00AC26F8E6C4")]
	public class QueuedMomentarySourceNode : SourceNodeBase
	{
		public struct Output
		{
			public OutputSlot outputSlot;

			public int outputValue;
		}

		public const int MAX_QUEUE_SIZE = 20;

		internal List<Output[]> QueuedSignals = new List<Output[]>(20);

		private bool OutputSetThisEval;

		public QueuedMomentarySourceNode(int nodeId, CircuitNodeGraph graph)
			: base("QueuedMomentarySourceNode", nodeId, graph)
		{
		}

		public new void SetContinuousOutput(OutputSlot slot, int signal)
		{
			base.SetContinuousOutput(slot, signal);
		}

		public new void SetMomentaryOutput(OutputSlot slot, int signal)
		{
			SetMomentaryOutputs(new Output
			{
				outputSlot = slot,
				outputValue = signal
			});
		}

		public void SetMomentaryOutputs(params Output[] outputs)
		{
			QueueSignal(outputs);
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			if (QueuedSignals.Count > 0)
			{
				Output[] array = QueuedSignals[0];
				QueuedSignals.RemoveAt(0);
				for (int i = 0; i < array.Length; i++)
				{
					OutputSlot outputSlot = array[i].outputSlot;
					int outputValue = array[i].outputValue;
					base.SetMomentaryOutput(outputSlot, outputValue);
				}
			}
		}

		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
			base.SerializeRuntimeState(bitPacker);
			int count = QueuedSignals.Count;
			bitPacker.WriteInt(count, 0, 20);
			for (int i = 0; i < count; i++)
			{
				Output[] array = QueuedSignals[i];
				int num = array.Length;
				bitPacker.WriteInt(num, 0, 8);
				for (int j = 0; j < num; j++)
				{
					Output output = array[j];
					int outputSlot = (int)output.outputSlot;
					bitPacker.WriteInt(outputSlot, 0, 7);
					bitPacker.WriteInt(output.outputValue, int.MinValue, int.MaxValue);
				}
			}
		}

		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
			base.DeserializeRuntimeState(bitPacker);
			bitPacker.ReadInt(out var value, 0, 20);
			QueuedSignals.Clear();
			for (int i = 0; i < value; i++)
			{
				bitPacker.ReadInt(out var value2, 0, 8);
				Output[] array = new Output[value2];
				for (int j = 0; j < value2; j++)
				{
					bitPacker.ReadInt(out var value3, 0, 7);
					bitPacker.ReadInt(out var value4, int.MinValue, int.MaxValue);
					array[j] = new Output
					{
						outputSlot = (OutputSlot)value3,
						outputValue = value4
					};
				}
				QueueSignal(array);
			}
		}

		private void QueueSignal(Output[] outputs)
		{
			QueuedSignals.Add(outputs);
			if (QueuedSignals.Count > 20)
			{
				QueuedSignals.RemoveRange(0, QueuedSignals.Count - 20);
			}
			base.NodeGraph.NodeGraphDirty = true;
		}
	}
	[CircuitNodeUuid("AA5DC0B1-AC22-4075-AB13-E8376AA0FC39")]
	public class ObjectPlayerMappingNode : CircuitNode
	{
		public delegate void ObjectToLastHeldPlayerIdFunc(int objectId, out int playerId);

		private const string nodeDescription = "Object to Player";

		private static readonly InputMetadata[] inputMeta = new InputMetadata[1]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Object ID"
			}
		};

		private static readonly OutputMetadata[] outputMeta = new OutputMetadata[1]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Last Held Player"
			}
		};

		private int lastMasterPlayerId;

		internal override bool IsStateful => true;

		public event ObjectToLastHeldPlayerIdFunc ObjectToLastHeldPlayer;

		public ObjectPlayerMappingNode(int nodeId, CircuitNodeGraph graph)
			: base("ObjectPlayerMappingNode", nodeId, graph)
		{
		}

		protected override string GetNodeDescription()
		{
			return "Object to Player";
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
			int inputSignal = GetInputSignal(InputSlot.R);
			if (CircuitNode.SignalToBool(inputSignal))
			{
				lastMasterPlayerId = CalcOutput(inputSignal, isMasterClient);
				SetContinuousOutput(OutputSlot.R, lastMasterPlayerId);
			}
		}

		private int CalcOutput(int objectId, bool isMasterClient)
		{
			if (!isMasterClient)
			{
				return lastMasterPlayerId;
			}
			int playerId = 0;
			try
			{
				this.ObjectToLastHeldPlayer(objectId, out playerId);
				playerId = CircuitNode.ClampSignal(playerId, 0, int.MaxValue);
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e);
			}
			return playerId;
		}

		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
			base.SerializePostEvaluateState(bitPacker);
			bool flag = lastMasterPlayerId > 0;
			bitPacker.WriteBool(flag);
			if (flag)
			{
				bitPacker.WriteInt(lastMasterPlayerId, 0, int.MaxValue);
			}
		}

		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
			base.DeserializePostEvaluateState(bitPacker);
			bool value = false;
			bitPacker.ReadBool(out value);
			if (value)
			{
				bitPacker.ReadInt(out lastMasterPlayerId, 0, int.MaxValue);
			}
			else
			{
				lastMasterPlayerId = 0;
			}
		}
	}
	[CircuitNodeUuid("B71B05C0-D6FD-4C49-A70C-085C14E95317")]
	public class RandomNode : CircuitNode
	{
		public enum RandomModes
		{
			Continuous,
			Pulse
		}

		public const string MODE_ARG = "mode";

		private const InputSlot MIN_SLOT = InputSlot.G;

		private const InputSlot MAX_SLOT = InputSlot.B;

		private const string nodeDescription = "RAND [Green, Blue)";

		private RandomModes randomMode;

		private static Random random = new Random();

		private static int seed;

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

		private int masterLastRandomNumber;

		internal override bool IsStateful => true;

		public RandomModes RandomMode
		{
			get
			{
				return randomMode;
			}
			internal set
			{
				if (randomMode != value)
				{
					randomMode = value;
				}
			}
		}

		public static int RandomSeed
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
			if (CircuitNode.SignalToBool(GetInputSignal(InputSlot.R)))
			{
				masterLastRandomNumber = CalcOutput(isMasterClient);
				if (RandomMode == RandomModes.Continuous)
				{
					SetContinuousOutput(OutputSlot.R, masterLastRandomNumber);
				}
				else
				{
					SetMomentaryOutput(OutputSlot.R, masterLastRandomNumber);
				}
				base.NodeGraph.NodeGraphDirty = true;
			}
		}

		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
			base.SerializePostEvaluateState(bitPacker);
			bitPacker.WriteInt(masterLastRandomNumber, int.MinValue, int.MaxValue);
		}

		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
			base.DeserializePostEvaluateState(bitPacker);
			bitPacker.ReadInt(out masterLastRandomNumber, int.MinValue, int.MaxValue);
		}

		private int CalcOutput(bool isMasterClient)
		{
			if (!isMasterClient)
			{
				return masterLastRandomNumber;
			}
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

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			RandomMode = (RandomModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)RandomMode;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				RandomMode = (RandomModes)value;
			}
		}
	}
	public abstract class SourceNodeBase : CircuitNode
	{
		protected OutputMetadata[] OutputMeta = new OutputMetadata[0];

		private static readonly InputMetadata[] InputMeta = new InputMetadata[0];

		internal sealed override bool IsStateful => true;

		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
			OutputMeta = outputMetadata;
			ReconstructNodeMetadata();
		}

		public SourceNodeBase(string name, int nodeId, CircuitNodeGraph graph)
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
	}
	[CircuitNodeUuid("6AD5D963-2357-4A09-BDA6-C99A917655B1")]
	public class SelectorNode : CircuitNode
	{
		public enum EvalModes
		{
			First,
			All
		}

		public struct SelectorConfig
		{
			public SignalComparisonHelper.ComparerModes CompareMode;

			public int CompareValue;
		}

		internal const InputSlot SELECTOR_SLOT = InputSlot.R;

		internal const InputSlot SIGNAL_SLOT = InputSlot.G;

		private EvalModes _evalMode;

		public SelectorConfig[] SelectorConfigs = new SelectorConfig[IOSlots.AllStandardOutputSlots.Length];

		private InputMetadata[] inputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Selector"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Signal"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private int lastSignal;

		private int lastSelector;

		private bool modifiedSinceLastEval = true;

		public const string SELECTOR_CONFIG_INDEX_ARG = "index";

		public const string SELECTOR_CONFIG_COMPARE_MODE_ARG = "comp_mode";

		public const string SELECTOR_CONFIG_COMPARE_VALUE_ARG = "comp_val";

		public const string SELECTOR_EVAL_MODE_ARG = "eval_mode";

		public EvalModes EvalMode
		{
			get
			{
				return _evalMode;
			}
			set
			{
				if (value != _evalMode)
				{
					_evalMode = value;
					modifiedSinceLastEval = true;
				}
			}
		}

		public SelectorNode(int nodeId, CircuitNodeGraph graph)
			: base("SelectorNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			int inputSignal = GetInputSignal(InputSlot.G);
			int inputSignal2 = GetInputSignal(InputSlot.R);
			if (inputSignal == lastSignal && inputSignal2 == lastSelector && !modifiedSinceLastEval)
			{
				return;
			}
			lastSignal = inputSignal;
			lastSelector = inputSignal2;
			modifiedSinceLastEval = false;
			bool flag = false;
			for (int i = 0; i < SelectorConfigs.Length; i++)
			{
				SelectorConfig selectorConfig = SelectorConfigs[i];
				OutputSlot outputSlot = IOSlots.AllStandardOutputSlots[i];
				SetContinuousOutput(outputSlot, 0);
				if (!flag && SignalComparisonHelper.Compare(selectorConfig.CompareMode, inputSignal2, selectorConfig.CompareValue))
				{
					SetContinuousOutput(outputSlot, inputSignal);
					if (EvalMode == EvalModes.First)
					{
						flag = true;
					}
				}
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return CircuitNode.AllSlotsOutputMetadata;
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			if (data.SelectorNodeData == null)
			{
				return;
			}
			EvalMode = (EvalModes)data.SelectorNodeData.EvalMode;
			if (data.SelectorNodeData.SelectorConfigData == null)
			{
				return;
			}
			for (int i = 0; i < SelectorConfigs.Length; i++)
			{
				if (i < data.SelectorNodeData.SelectorConfigData.Count)
				{
					SelectorConfigs[i] = new SelectorConfig
					{
						CompareMode = (SignalComparisonHelper.ComparerModes)data.SelectorNodeData.SelectorConfigData[i].CompareMode,
						CompareValue = data.SelectorNodeData.SelectorConfigData[i].CompareValue
					};
				}
			}
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.SelectorNodeData = new SelectorNodeData();
			circuitNodeData.SelectorNodeData.EvalMode = (int)EvalMode;
			for (int i = 0; i < SelectorConfigs.Length; i++)
			{
				circuitNodeData.SelectorNodeData.SelectorConfigData.Add(new SelectorConfigData
				{
					CompareMode = (int)SelectorConfigs[i].CompareMode,
					CompareValue = SelectorConfigs[i].CompareValue
				});
			}
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.ContainsKey("index") && modifyArgs.ContainsKey("comp_mode") && modifyArgs.ContainsKey("comp_val"))
			{
				int num = (int)modifyArgs["index"];
				if (num < 0 || num >= SelectorConfigs.Length)
				{
					return;
				}
				SignalComparisonHelper.ComparerModes compareMode = (SignalComparisonHelper.ComparerModes)modifyArgs["comp_mode"];
				int compareValue = (int)modifyArgs["comp_val"];
				SelectorConfigs[num].CompareMode = compareMode;
				SelectorConfigs[num].CompareValue = compareValue;
				modifiedSinceLastEval = true;
			}
			if (modifyArgs.ContainsKey("eval_mode"))
			{
				EvalMode = (EvalModes)modifyArgs["eval_mode"];
			}
		}
	}
	[CircuitNodeUuid("B58C2FAB-3F1A-15F4-6D31-4E3BE09A71A9")]
	public class SourceNode : SourceNodeBase
	{
		public SourceNode(int nodeId, CircuitNodeGraph graph)
			: base("SourceNode", nodeId, graph)
		{
		}

		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
			base.SetMomentaryOutput(outputSlot, value);
		}

		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
			base.SetContinuousOutput(outputSlot, value);
		}
	}
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169B82")]
	public class ComparerNode : CircuitNode
	{
		public const string MODE_ARG = "mode";

		public const string ADVANCED_MODE_ARG = "adv";

		private static readonly InputMetadata[] InputMeta = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Left Side"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Right Side"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly InputMetadata[] AdvancedInputMeta = new InputMetadata[5]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Left Side"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Right Side"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.C,
				Description = "If Signal"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.M,
				Description = "Else Signal"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private SignalComparisonHelper.ComparerModes comparerMode;

		private bool advancedMode;

		public SignalComparisonHelper.ComparerModes ComparerMode
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

		public bool AdvancedMode
		{
			get
			{
				return advancedMode;
			}
			set
			{
				if (advancedMode != value)
				{
					advancedMode = value;
					ReconstructNodeMetadata();
					CircuitDebug.NodeLog(base.NodeId, "AdvancedMode changed to:" + advancedMode);
				}
			}
		}

		public override string NodeVisualizationLabel => GetNodeDescription() + "\\n" + base.NodeVisualizationLabel;

		public ComparerNode(int nodeId, CircuitNodeGraph graph)
			: base("ComparerNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			bool flag = CalcOutput();
			bool flag2 = !flag;
			int num = 0;
			int num2 = 0;
			if (AdvancedMode)
			{
				num = (flag ? GetInputSignal(InputSlot.C) : 0);
				num2 = (flag2 ? GetInputSignal(InputSlot.M) : 0);
			}
			else
			{
				num = CircuitNode.BoolToSignal(flag);
				num2 = CircuitNode.BoolToSignal(flag2);
			}
			SetContinuousOutput(OutputSlot.R, num);
			SetContinuousOutput(OutputSlot.G, num2);
		}

		private bool CalcOutput()
		{
			int inputSignal = GetInputSignal(InputSlot.R);
			int inputSignal2 = GetInputSignal(InputSlot.G);
			return SignalComparisonHelper.Compare(ComparerMode, inputSignal, inputSignal2);
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			if (!AdvancedMode)
			{
				return InputMeta;
			}
			return AdvancedInputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			string nodeDescription = GetNodeDescription();
			return new OutputMetadata[3]
			{
				new OutputMetadata
				{
					OutputSlot = OutputSlot.R,
					Description = "If " + nodeDescription
				},
				new OutputMetadata
				{
					OutputSlot = OutputSlot.G,
					Description = "Else"
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
			return $"Red {SignalComparisonHelper.GetModeSymbol(ComparerMode)} Green";
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			ComparerMode = (SignalComparisonHelper.ComparerModes)data.Mode;
			AdvancedMode = data.AdvancedMode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)ComparerMode;
			circuitNodeData.AdvancedMode = AdvancedMode;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				ComparerMode = (SignalComparisonHelper.ComparerModes)value;
			}
			if (modifyArgs.TryGetValue("adv", out var value2))
			{
				AdvancedMode = (bool)value2;
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

		private static readonly InputMetadata[] AddInputMeta = new InputMetadata[4]
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
				InputSlot = InputSlot.B
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
			{
				int inputSignal3 = GetInputSignal(InputSlot.B);
				return inputSignal + inputSignal2 + inputSignal3;
			}
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
			if (CombinatorMode != CombinatorModes.Add)
			{
				return InputMeta;
			}
			return AddInputMeta;
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

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			CombinatorMode = (CombinatorModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)CombinatorMode;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
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
					int delay = 100 * Math.Max(0, Math.Min(36000, inputSignal2));
					QueueSignal(delay, inputSignal);
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

		internal override void SerializeRuntimeState(BitPacker bitPacker)
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

		internal override void DeserializeRuntimeState(BitPacker bitPacker)
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
	public class MomentarySourceNode : SourceNodeBase
	{
		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
			: base("MomentarySourceNode", nodeId, graph)
		{
		}

		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
			base.SetMomentaryOutput(outputSlot, value);
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

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
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

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
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

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			InternalGraphData internalGraphData = data.InternalGraphData;
			InternalNodeGraph = CircuitNodeGraph.Deserialize(internalGraphData.InternalNodeGraph, reassignNodeIds, out var nodeIdMap2);
			RuntimeAssert.Assert(InternalNodeGraph != null, "Internal node graph cannot be null!");
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
		public delegate void OutputNodeUpdated(Dictionary<InputSlot, int> slotUpdates);

		protected InputMetadata[] InputMeta = new InputMetadata[0];

		private Dictionary<InputSlot, int> inputValues = new Dictionary<InputSlot, int>();

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
			OnDisconnectedEvent = (ThisNodeConnectionChanged)Delegate.Combine(OnDisconnectedEvent, new ThisNodeConnectionChanged(OnDisconnected));
		}

		public override void Destroy(bool disconnectLinks = true)
		{
			base.Destroy(disconnectLinks);
			OnDisconnectedEvent = (ThisNodeConnectionChanged)Delegate.Remove(OnDisconnectedEvent, new ThisNodeConnectionChanged(OnDisconnected));
		}

		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			if (!base.HasConnectedInputs)
			{
				FireEventIfNeeded();
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

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			FireEventIfNeeded();
		}

		private void FireEventIfNeeded()
		{
			inputValues.Clear();
			for (int i = 0; i < InputMeta.Length; i++)
			{
				InputMetadata inputMetadata = InputMeta[i];
				int num = lastSignals[(int)inputMetadata.InputSlot];
				int inputSignal = GetInputSignal(inputMetadata.InputSlot);
				if (inputSignal != num)
				{
					lastSignals[(int)inputMetadata.InputSlot] = inputSignal;
					inputValues[inputMetadata.InputSlot] = inputSignal;
				}
			}
			if (inputValues.Count > 0 && OutputNodeUpdatedEvent != null)
			{
				try
				{
					OutputNodeUpdatedEvent(inputValues);
				}
				catch (Exception ex)
				{
					CircuitDebug.NodeLogFormat(base.NodeId, CircuitLogLevel.Error, "Error in OutputNodeUpdate callback: {0}", ex.ToString());
				}
			}
		}
	}
	public abstract class SwappedCircuitNode : CircuitNode
	{
		protected struct SwappedSignal
		{
			public OutputSlot OutputSlot;

			public int Value;

			public bool IsMomentary;
		}

		private List<SwappedSignal> swappedSignals = new List<SwappedSignal>();

		internal override bool RequiresPostEval
		{
			get
			{
				if (!base.RequiresPostEval)
				{
					return swappedSignals.Count > 0;
				}
				return true;
			}
		}

		public SwappedCircuitNode(string name, int nodeId, CircuitNodeGraph graph)
			: base(name, nodeId, graph)
		{
		}

		protected void SetSwappedContinuousOutput(OutputSlot outputSlot, int val)
		{
			SetSwappedOutput(outputSlot, val, isMomentary: false);
		}

		protected void SetSwappedMomentaryOutput(OutputSlot outputSlot, int val)
		{
			SetSwappedOutput(outputSlot, val, isMomentary: true);
		}

		private void SetSwappedOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
			swappedSignals.Add(new SwappedSignal
			{
				OutputSlot = outputSlot,
				Value = val,
				IsMomentary = isMomentary
			});
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			swappedSignals.Clear();
			base._EvaluateNode(isMasterClient);
		}

		internal override void PostEvaluateNode(bool isMasterClient)
		{
			base.PostEvaluateNode(isMasterClient);
			for (int i = 0; i < swappedSignals.Count; i++)
			{
				OutputSlot outputSlot = swappedSignals[i].OutputSlot;
				bool isMomentary = swappedSignals[i].IsMomentary;
				int value = swappedSignals[i].Value;
				if (isMomentary)
				{
					SetMomentaryOutput(outputSlot, value);
				}
				else
				{
					SetContinuousOutput(outputSlot, value);
				}
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

		public enum TimeUnit
		{
			Second,
			TenthOfSecond
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

		private int _inputTimeTenths;

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

		private int inputTimeTenths
		{
			get
			{
				return _inputTimeTenths;
			}
			set
			{
				if (_inputTimeTenths != value)
				{
					_inputTimeTenths = value;
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
				inputTimeTenths = GetInputSignal(InputSlot.G);
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
			timeRemaining = 100 * Math.Max(0, Math.Min(36000, inputTimeTenths));
			timerExpired = timeRemaining == 0;
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			TimerMode = (TimerModes)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)TimerMode;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				TimerMode = (TimerModes)value;
			}
		}

		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
			base.SerializeRuntimeState(bitPacker);
			int value = timeRemaining / 100;
			bitPacker.WriteInt(value, 0, 36000);
			bitPacker.WriteBool(timerExpired);
		}

		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
			base.DeserializeRuntimeState(bitPacker);
			bitPacker.ReadInt(out var value, 0, 36000);
			bitPacker.ReadBool(out timerExpired);
			timeRemaining = value * 100;
		}
	}
	[CircuitNodeUuid("9B664D6A-1B61-4D4E-9AA8-B17B0DC02DA3")]
	public class UnityTransformationNode : CircuitNode
	{
		protected InputMetadata[] InputMeta = new InputMetadata[0];

		protected OutputMetadata[] OutputMeta = new OutputMetadata[0];

		private Dictionary<InputSlot, int> inputs = new Dictionary<InputSlot, int>();

		private Dictionary<OutputSlot, int> outputs;

		private Func<Dictionary<InputSlot, int>, Dictionary<OutputSlot, int>> transformationFunction;

		public void SetMetadata(InputMetadata[] inputMetadata, OutputMetadata[] outputMetadata)
		{
			InputMeta = inputMetadata;
			OutputMeta = outputMetadata;
			ReconstructNodeMetadata();
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return InputMeta;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMeta;
		}

		public UnityTransformationNode(int nodeId, CircuitNodeGraph graph)
			: base("UnityTransformationNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			if (transformationFunction == null)
			{
				PassthroughValues();
				return;
			}
			inputs.Clear();
			for (int i = 0; i < InputMeta.Length; i++)
			{
				InputSlot inputSlot = InputMeta[i].InputSlot;
				int inputSignal = GetInputSignal(inputSlot);
				inputs[inputSlot] = inputSignal;
			}
			outputs = transformationFunction(inputs);
			foreach (KeyValuePair<OutputSlot, int> output in outputs)
			{
				SetContinuousOutput(output.Key, output.Value);
			}
		}

		private void PassthroughValues()
		{
			for (int i = 0; i < InputMeta.Length; i++)
			{
				InputSlot inputSlot = InputMeta[i].InputSlot;
				OutputSlot outputSlot = IOSlots.InputSlotToOutputSlot[inputSlot];
				int inputSignal = GetInputSignal(inputSlot);
				SetContinuousOutput(outputSlot, inputSignal);
			}
		}
	}
	[CircuitNodeUuid("34200A8F-370E-4240-B034-66252D44BE88")]
	public class WaveNode : CircuitNode
	{
		public enum WaveMode
		{
			Sine,
			Cosine,
			Square,
			Triangle,
			Sawtooth
		}

		public const string MODE_ARG = "mode";

		public const string TIME_UNIT_ARG = "timeUnit";

		private const int DELAY_COMPRESSION_QUANTIZATION = 100;

		private const int MAX_PERIOD_IN_SECONDS = 3600;

		private const int MAX_PERIOD_IN_MILLISECONDS = 3600000;

		private const int MAX_PERIOD_QUANTIZED = 36000;

		private const int TICK_DURATION_IN_MILLISECONDS = 100;

		internal const InputSlot OnOffSlotInputSlot = InputSlot.R;

		internal const InputSlot PeriodInputSlot = InputSlot.G;

		internal const InputSlot AmplitudeInputSlot = InputSlot.B;

		internal const OutputSlot SignalOutputSlot = OutputSlot.R;

		private static readonly InputMetadata[] SecondInputMetadata = new InputMetadata[4]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "ON/OFF"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Cycle duration (sec)"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.B,
				Description = "Amplitude"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly InputMetadata[] ThenthOfSecondInputMetadata = new InputMetadata[4]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "ON/OFF"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Cycle duration (0.1sec)"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.B,
				Description = "Amplitude"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.RESET,
				Description = "Reset"
			}
		};

		private static readonly OutputMetadata[] OutputMetadata = new OutputMetadata[2]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Signal value"
			},
			new OutputMetadata
			{
				OutputSlot = OutputSlot.RESET,
				Description = "Reset"
			}
		};

		private WaveMode currentWaveMode;

		private TimerNode.TimeUnit currentTimeUnit;

		private int runningTimeInMilliseconds;

		private bool isOn;

		private int? lastNetworkTime;

		private int _inputPeriod;

		private int inputAmplitude;

		private double functionPeriodInSeconds;

		private double millisecondTimeToAngle;

		private int loopTimeInMilliseconds = 36000;

		private int relevantDecimalPlaces;

		internal override bool IsStateful => true;

		public WaveMode CurrentWaveMode
		{
			get
			{
				return currentWaveMode;
			}
			private set
			{
				if (currentWaveMode != value)
				{
					currentWaveMode = value;
					ReconstructNodeMetadata();
				}
			}
		}

		public TimerNode.TimeUnit CurrentTimeUnit
		{
			get
			{
				return currentTimeUnit;
			}
			private set
			{
				if (currentTimeUnit != value)
				{
					currentTimeUnit = value;
					ReconstructNodeMetadata();
					ResetRunningTime();
					UpdateCachedFunctionParameters();
				}
			}
		}

		private double InputTimeUnitInSeconds => CurrentTimeUnit switch
		{
			TimerNode.TimeUnit.Second => 1.0, 
			TimerNode.TimeUnit.TenthOfSecond => 0.1, 
			_ => 0.0, 
		};

		private int InputPeriod
		{
			get
			{
				return _inputPeriod;
			}
			set
			{
				if (_inputPeriod != value)
				{
					_inputPeriod = ((value >= 0) ? value : (-value));
					UpdateCachedFunctionParameters();
				}
			}
		}

		public WaveNode(int nodeId, CircuitNodeGraph graph)
			: base("WaveNode", nodeId, graph)
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
				InputPeriod = GetInputSignal(InputSlot.G);
				inputAmplitude = GetInputSignal(InputSlot.B);
				UpdateOutputs();
			}
		}

		protected override void _ResetNode(bool isMasterClient)
		{
			base._ResetNode(isMasterClient);
			if (isMasterClient)
			{
				ResetRunningTime();
				UpdateOutputs();
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			if (CurrentTimeUnit != TimerNode.TimeUnit.Second)
			{
				return ThenthOfSecondInputMetadata;
			}
			return SecondInputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return OutputMetadata;
		}

		protected override string GetNodeDescription()
		{
			return CurrentWaveMode switch
			{
				WaveMode.Sine => "Sine Wave Node", 
				WaveMode.Cosine => "Cosine Wave Node", 
				WaveMode.Square => "Square Wave Node", 
				WaveMode.Triangle => "Triangle Wave Node", 
				WaveMode.Sawtooth => "Sawtooth Wave Node", 
				_ => "Wave Function Node", 
			};
		}

		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
			int num = (lastNetworkTime.HasValue ? (networkTime - lastNetworkTime.Value) : 0);
			lastNetworkTime = networkTime;
			if (isMasterClient)
			{
				if (isOn)
				{
					runningTimeInMilliseconds += num;
					runningTimeInMilliseconds %= loopTimeInMilliseconds;
				}
				UpdateOutputs();
			}
		}

		private void UpdateOutputs()
		{
			SetContinuousOutput(OutputSlot.R, isOn ? EvaluateWaveFunction() : 0);
		}

		private void ResetRunningTime()
		{
			runningTimeInMilliseconds = 0;
		}

		private int EvaluateWaveFunction()
		{
			double num = 0.0;
			double value = 0.0;
			if (functionPeriodInSeconds > 1.401298464324817E-45)
			{
				switch (CurrentWaveMode)
				{
				case WaveMode.Sine:
					num = (double)runningTimeInMilliseconds * millisecondTimeToAngle;
					value = Math.Sin(num);
					break;
				case WaveMode.Cosine:
					num = (double)runningTimeInMilliseconds * millisecondTimeToAngle;
					value = Math.Cos(num);
					break;
				case WaveMode.Square:
					num = (double)runningTimeInMilliseconds / 1000.0;
					value = Math.Pow(-1.0, Math.Floor(num / functionPeriodInSeconds));
					break;
				case WaveMode.Triangle:
					num = (double)runningTimeInMilliseconds / 1000.0;
					value = 4.0 / functionPeriodInSeconds * (Math.Abs(num % functionPeriodInSeconds - functionPeriodInSeconds / 2.0) - functionPeriodInSeconds / 4.0);
					break;
				case WaveMode.Sawtooth:
					num = Math.Round((double)runningTimeInMilliseconds / 1000.0, 1);
					value = -1.0 + 2.0 * (num % functionPeriodInSeconds) / functionPeriodInSeconds;
					break;
				}
			}
			double num2 = Math.Round(value, relevantDecimalPlaces);
			return (int)Math.Round((double)inputAmplitude * num2);
		}

		private void UpdateCachedFunctionParameters()
		{
			functionPeriodInSeconds = ((InputPeriod > 0) ? Math.Round(Math.Min(InputTimeUnitInSeconds * (double)InputPeriod, 3600.0), 1) : 0.0);
			if (functionPeriodInSeconds > 1.401298464324817E-45)
			{
				millisecondTimeToAngle = 0.0062831854820251465 / functionPeriodInSeconds;
				relevantDecimalPlaces = (int)Math.Round(Math.Log10(functionPeriodInSeconds)) + 3;
				double val = functionPeriodInSeconds * Math.Floor(3600.0 / functionPeriodInSeconds);
				loopTimeInMilliseconds = (int)Math.Round(Math.Min(3600.0, val) * 1000.0);
			}
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			CurrentWaveMode = (WaveMode)data.Mode;
			CurrentTimeUnit = (TimerNode.TimeUnit)data.TimeUnit;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)CurrentWaveMode;
			circuitNodeData.TimeUnit = (int)CurrentTimeUnit;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				CurrentWaveMode = (WaveMode)value;
			}
			if (modifyArgs.TryGetValue("timeUnit", out var value2))
			{
				CurrentTimeUnit = (TimerNode.TimeUnit)value2;
			}
		}

		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
			base.SerializeRuntimeState(bitPacker);
			int value = runningTimeInMilliseconds / 100;
			bitPacker.WriteInt(value, 0, 36000);
		}

		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
			base.DeserializeRuntimeState(bitPacker);
			bitPacker.ReadInt(out var value, 0, 36000);
			runningTimeInMilliseconds = value * 100;
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

		private static Guid RECROOM_CIRCUITS_GAMESETSTATENODE_ID = new Guid("53219714-e7bb-4950-bbb3-852a7ef196f8");

		private static Guid RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID = new Guid("20c6ac2e-1116-4c93-8cdf-40fe161cc796");

		private static Guid RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID = new Guid("0d0d8ea8-2816-4b3b-8f1d-19c74b056da6");

		private static Guid RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID = new Guid("cee29eb9-61ae-42d4-8dc6-3a62d7096781");

		private static Guid RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID = new Guid("3079a591-0e82-41b5-8bec-00ac26f8e6c4");

		private static Guid RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID = new Guid("aa5dc0b1-ac22-4075-ab13-e8376aa0fc39");

		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID = new Guid("b71b05c0-d6fd-4c49-a70c-085c14e95317");

		private static Guid RECROOM_CIRCUITS_SELECTORNODE_ID = new Guid("6ad5d963-2357-4a09-bda6-c99a917655b1");

		private static Guid RECROOM_CIRCUITS_SOURCENODE_ID = new Guid("b58c2fab-3f1a-15f4-6d31-4e3be09a71a9");

		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID = new Guid("92bd57fa-d68e-4a6e-9ecf-d82985169b82");

		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID = new Guid("17b72de0-4116-41db-a99d-1523625f7ef1");

		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID = new Guid("34452a12-afb3-4a4d-97b0-9d25f7e777c5");

		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID = new Guid("c9a59f26-0a72-4c2e-b239-6a83998e0839");

		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID = new Guid("e7efd8ca-92fe-4a37-9e7c-abbe9e4de336");

		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID = new Guid("6402c773-5838-4495-bc54-bc36ede4ab0f");

		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID = new Guid("738b2af2-eebd-4316-82a9-2fbec9b50d8b");

		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID = new Guid("c6ab70a0-c752-466a-8070-029742655556");

		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID = new Guid("a77191f7-792b-4590-aab3-a3b71c440dd1");

		private static Guid RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID = new Guid("9b664d6a-1b61-4d4e-9aa8-b17b0dc02da3");

		private static Guid RECROOM_CIRCUITS_WAVENODE_ID = new Guid("34200a8f-370e-4240-b034-66252d44be88");

		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID = new Guid("a4160690-4c68-40c2-bd51-b665f71fcebd");

		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID = new Guid("fc94a1cd-dd7e-4229-92df-95991a9e6369");

		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID = new Guid("5a15e563-2f73-41b6-9cdf-6c9fb065a034");

		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID = new Guid("2f4a96da-842f-4f41-84bb-1f283dadb769");

		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID = new Guid("b79a6285-498a-4748-b960-fa33f4c5cb02");

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
				typeof(GameSetStateNode),
				RECROOM_CIRCUITS_GAMESETSTATENODE_ID
			},
			{
				typeof(ObjectSetTagsNode),
				RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID
			},
			{
				typeof(PlayerRoleMappingNode),
				RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID
			},
			{
				typeof(PlayerTeamMappingNode),
				RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID
			},
			{
				typeof(QueuedMomentarySourceNode),
				RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID
			},
			{
				typeof(ObjectPlayerMappingNode),
				RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID
			},
			{
				typeof(RandomNode),
				RECROOM_CIRCUITS_RANDOMNODE_ID
			},
			{
				typeof(SelectorNode),
				RECROOM_CIRCUITS_SELECTORNODE_ID
			},
			{
				typeof(SourceNode),
				RECROOM_CIRCUITS_SOURCENODE_ID
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
				typeof(UnityTransformationNode),
				RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID
			},
			{
				typeof(WaveNode),
				RECROOM_CIRCUITS_WAVENODE_ID
			},
			{
				typeof(RootNode),
				RECROOM_CIRCUITS_ROOTNODE_ID
			},
			{
				typeof(PlayerGetStatNode),
				RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID
			},
			{
				typeof(PlayerSetStatNode),
				RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID
			},
			{
				typeof(GameGetScoreNode),
				RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID
			},
			{
				typeof(GameSetScoreNode),
				RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID
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
				RECROOM_CIRCUITS_GAMESETSTATENODE_ID,
				typeof(GameSetStateNode)
			},
			{
				RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID,
				typeof(ObjectSetTagsNode)
			},
			{
				RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID,
				typeof(PlayerRoleMappingNode)
			},
			{
				RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID,
				typeof(PlayerTeamMappingNode)
			},
			{
				RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID,
				typeof(QueuedMomentarySourceNode)
			},
			{
				RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID,
				typeof(ObjectPlayerMappingNode)
			},
			{
				RECROOM_CIRCUITS_RANDOMNODE_ID,
				typeof(RandomNode)
			},
			{
				RECROOM_CIRCUITS_SELECTORNODE_ID,
				typeof(SelectorNode)
			},
			{
				RECROOM_CIRCUITS_SOURCENODE_ID,
				typeof(SourceNode)
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
				RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID,
				typeof(UnityTransformationNode)
			},
			{
				RECROOM_CIRCUITS_WAVENODE_ID,
				typeof(WaveNode)
			},
			{
				RECROOM_CIRCUITS_ROOTNODE_ID,
				typeof(RootNode)
			},
			{
				RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID,
				typeof(PlayerGetStatNode)
			},
			{
				RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID,
				typeof(PlayerSetStatNode)
			},
			{
				RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID,
				typeof(GameGetScoreNode)
			},
			{
				RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID,
				typeof(GameSetScoreNode)
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
				RECROOM_CIRCUITS_GAMESETSTATENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new GameSetStateNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new ObjectSetTagsNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new PlayerRoleMappingNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new PlayerTeamMappingNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new QueuedMomentarySourceNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new ObjectPlayerMappingNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_RANDOMNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new RandomNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_SELECTORNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new SelectorNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_SOURCENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new SourceNode(nodeId, graph)
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
				RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new UnityTransformationNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_WAVENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new WaveNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_ROOTNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new RootNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new PlayerGetStatNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new PlayerSetStatNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new GameGetScoreNode(nodeId, graph)
			},
			{
				RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID,
				(int nodeId, CircuitNodeGraph graph) => new GameSetScoreNode(nodeId, graph)
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
	public static class SignalComparisonHelper
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

		private static readonly Dictionary<ComparerModes, string> ModeSymbols = new Dictionary<ComparerModes, string>
		{
			{
				ComparerModes.Equals,
				"="
			},
			{
				ComparerModes.NotEquals,
				"≠"
			},
			{
				ComparerModes.GreaterThan,
				">"
			},
			{
				ComparerModes.GreaterThanEqualTo,
				"≥"
			},
			{
				ComparerModes.LessThan,
				"<"
			},
			{
				ComparerModes.LessThanEqualTo,
				"≤"
			}
		};

		public static string GetModeSymbol(ComparerModes mode)
		{
			return ModeSymbols[mode];
		}

		internal static bool Compare(ComparerModes comparerMode, int leftSide, int rightSide)
		{
			return comparerMode switch
			{
				ComparerModes.Equals => leftSide == rightSide, 
				ComparerModes.NotEquals => leftSide != rightSide, 
				ComparerModes.GreaterThan => leftSide > rightSide, 
				ComparerModes.GreaterThanEqualTo => leftSide >= rightSide, 
				ComparerModes.LessThan => leftSide < rightSide, 
				ComparerModes.LessThanEqualTo => leftSide <= rightSide, 
				_ => false, 
			};
		}

		internal static string DebugString(ComparerModes comparerMode, int leftSide, int rightSide)
		{
			return $"{leftSide} {GetModeSymbol(comparerMode)} {rightSide}";
		}
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
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdjaXJjdWl0X25vZGVfZGF0YS5wcm90bxIIY2lyY3VpdHMaF2NpcmN1aXRf" + "bGlua19kYXRhLnByb3RvGhlub2RlX3RyYW5zZm9ybV9kYXRhLnByb3RvIqgD" + "Cg9DaXJjdWl0Tm9kZURhdGESEQoJbm9kZV9uYW1lGAEgASgJEg8KB25vZGVf" + "aWQYAiABKAUSFgoOcGFpcmVkX25vZGVfaWQYAyABKAUSEQoJbm9kZV90eXBl" + "GAQgASgMEjAKDWNpcmN1aXRfbGlua3MYBiADKAsyGS5jaXJjdWl0cy5DaXJj" + "dWl0TGlua0RhdGESMwoOdHJhbnNmb3JtX2RhdGEYByABKAsyGy5jaXJjdWl0" + "cy5Ob2RlVHJhbnNmb3JtRGF0YRI4ChNpbnRlcm5hbF9ncmFwaF9kYXRhGAgg" + "ASgLMhsuY2lyY3VpdHMuSW50ZXJuYWxHcmFwaERhdGESJAoIc2xvdERhdGEY" + "CSADKAsyEi5jaXJjdWl0cy5TbG90RGF0YRIMCgRtb2RlGAogASgFEjYKEnNl" + "bGVjdG9yX25vZGVfZGF0YRgLIAEoCzIaLmNpcmN1aXRzLlNlbGVjdG9yTm9k" + "ZURhdGESFQoNYWR2YW5jZWRfbW9kZRgMIAEoCBIRCgl0aW1lX3VuaXQYDSAB" + "KAUSDwoHcm9sZV9pZBgOIAEoBSJhChBTZWxlY3Rvck5vZGVEYXRhEhEKCWV2" + "YWxfbW9kZRgBIAEoBRI6ChRzZWxlY3Rvcl9jb25maWdfZGF0YRgCIAMoCzIc" + "LmNpcmN1aXRzLlNlbGVjdG9yQ29uZmlnRGF0YSJ/ChFJbnRlcm5hbEdyYXBo" + "RGF0YRIVCg1pbnB1dF9ub2RlX2lkGAEgASgFEhYKDm91dHB1dF9ub2RlX2lk" + "GAIgASgFEjsKE2ludGVybmFsX25vZGVfZ3JhcGgYAyABKAsyHi5jaXJjdWl0" + "cy5DaXJjdWl0Tm9kZUdyYXBoRGF0YSKvAQoUQ2lyY3VpdE5vZGVHcmFwaERh" + "dGESFwoPbm9kZV9ncmFwaF9ndWlkGAEgASgMEhkKEWlzX2ludGVybmFsX2dy" + "YXBoGAIgASgIEjEKDnJvb3Rfbm9kZV9kYXRhGAMgASgLMhkuY2lyY3VpdHMu" + "Q2lyY3VpdE5vZGVEYXRhEjAKDWNpcmN1aXRfbm9kZXMYBCADKAsyGS5jaXJj" + "dWl0cy5DaXJjdWl0Tm9kZURhdGEiUAoeQ2lyY3VpdE5vZGVHcmFwaENvbGxl" + "Y3Rpb25EYXRhEi4KBmdyYXBocxgBIAMoCzIeLmNpcmN1aXRzLkNpcmN1aXRO" + "b2RlR3JhcGhEYXRhIigKCFNsb3REYXRhEgwKBHNsb3QYASABKAUSDgoGc2ln" + "bmFsGAIgASgFIkEKElNlbGVjdG9yQ29uZmlnRGF0YRIUCgxjb21wYXJlX21v" + "ZGUYASABKAUSFQoNY29tcGFyZV92YWx1ZRgCIAEoBUIcqgIZUmVjUm9vbS5D" + "aXJjdWl0cy5Qcm90b2J1ZmIGcHJvdG8z"), new FileDescriptor[2]
			{
				CircuitLinkDataReflection.Descriptor,
				NodeTransformDataReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[7]
			{
				new GeneratedClrTypeInfo(typeof(CircuitNodeData), CircuitNodeData.Parser, new string[13]
				{
					"NodeName", "NodeId", "PairedNodeId", "NodeType", "CircuitLinks", "TransformData", "InternalGraphData", "SlotData", "Mode", "SelectorNodeData",
					"AdvancedMode", "TimeUnit", "RoleId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(SelectorNodeData), SelectorNodeData.Parser, new string[2] { "EvalMode", "SelectorConfigData" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(InternalGraphData), InternalGraphData.Parser, new string[3] { "InputNodeId", "OutputNodeId", "InternalNodeGraph" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(CircuitNodeGraphData), CircuitNodeGraphData.Parser, new string[4] { "NodeGraphGuid", "IsInternalGraph", "RootNodeData", "CircuitNodes" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(CircuitNodeGraphCollectionData), CircuitNodeGraphCollectionData.Parser, new string[1] { "Graphs" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(SlotData), SlotData.Parser, new string[2] { "Slot", "Signal" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(SelectorConfigData), SelectorConfigData.Parser, new string[2] { "CompareMode", "CompareValue" }, null, null, null)
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

		public const int SelectorNodeDataFieldNumber = 11;

		private SelectorNodeData selectorNodeData_;

		public const int AdvancedModeFieldNumber = 12;

		private bool advancedMode_;

		public const int TimeUnitFieldNumber = 13;

		private int timeUnit_;

		public const int RoleIdFieldNumber = 14;

		private int roleId_;

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
		public SelectorNodeData SelectorNodeData
		{
			get
			{
				return selectorNodeData_;
			}
			set
			{
				selectorNodeData_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool AdvancedMode
		{
			get
			{
				return advancedMode_;
			}
			set
			{
				advancedMode_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TimeUnit
		{
			get
			{
				return timeUnit_;
			}
			set
			{
				timeUnit_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int RoleId
		{
			get
			{
				return roleId_;
			}
			set
			{
				roleId_ = value;
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
			SelectorNodeData = ((other.selectorNodeData_ != null) ? other.SelectorNodeData.Clone() : null);
			advancedMode_ = other.advancedMode_;
			timeUnit_ = other.timeUnit_;
			roleId_ = other.roleId_;
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
			if (!object.Equals(SelectorNodeData, other.SelectorNodeData))
			{
				return false;
			}
			if (AdvancedMode != other.AdvancedMode)
			{
				return false;
			}
			if (TimeUnit != other.TimeUnit)
			{
				return false;
			}
			if (RoleId != other.RoleId)
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
			if (selectorNodeData_ != null)
			{
				num ^= SelectorNodeData.GetHashCode();
			}
			if (AdvancedMode)
			{
				num ^= AdvancedMode.GetHashCode();
			}
			if (TimeUnit != 0)
			{
				num ^= TimeUnit.GetHashCode();
			}
			if (RoleId != 0)
			{
				num ^= RoleId.GetHashCode();
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
			if (selectorNodeData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(SelectorNodeData);
			}
			if (AdvancedMode)
			{
				output.WriteRawTag(96);
				output.WriteBool(AdvancedMode);
			}
			if (TimeUnit != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(TimeUnit);
			}
			if (RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(RoleId);
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
			if (selectorNodeData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(SelectorNodeData);
			}
			if (AdvancedMode)
			{
				num += 2;
			}
			if (TimeUnit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(TimeUnit);
			}
			if (RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(RoleId);
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
			if (other.selectorNodeData_ != null)
			{
				if (selectorNodeData_ == null)
				{
					selectorNodeData_ = new SelectorNodeData();
				}
				SelectorNodeData.MergeFrom(other.SelectorNodeData);
			}
			if (other.AdvancedMode)
			{
				AdvancedMode = other.AdvancedMode;
			}
			if (other.TimeUnit != 0)
			{
				TimeUnit = other.TimeUnit;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
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
				case 90u:
					if (selectorNodeData_ == null)
					{
						selectorNodeData_ = new SelectorNodeData();
					}
					input.ReadMessage(selectorNodeData_);
					break;
				case 96u:
					AdvancedMode = input.ReadBool();
					break;
				case 104u:
					TimeUnit = input.ReadInt32();
					break;
				case 112u:
					RoleId = input.ReadInt32();
					break;
				}
			}
		}
	}
	public sealed class SelectorNodeData : IMessage<SelectorNodeData>, IMessage, IEquatable<SelectorNodeData>, IDeepCloneable<SelectorNodeData>
	{
		private static readonly MessageParser<SelectorNodeData> _parser = new MessageParser<SelectorNodeData>(() => new SelectorNodeData());

		public const int EvalModeFieldNumber = 1;

		private int evalMode_;

		public const int SelectorConfigDataFieldNumber = 2;

		private static readonly FieldCodec<SelectorConfigData> _repeated_selectorConfigData_codec = FieldCodec.ForMessage(18u, RecRoom.Circuits.Protobuf.SelectorConfigData.Parser);

		private readonly RepeatedField<SelectorConfigData> selectorConfigData_ = new RepeatedField<SelectorConfigData>();

		[DebuggerNonUserCode]
		public static MessageParser<SelectorNodeData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public int EvalMode
		{
			get
			{
				return evalMode_;
			}
			set
			{
				evalMode_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<SelectorConfigData> SelectorConfigData => selectorConfigData_;

		[DebuggerNonUserCode]
		public SelectorNodeData()
		{
		}

		[DebuggerNonUserCode]
		public SelectorNodeData(SelectorNodeData other)
			: this()
		{
			evalMode_ = other.evalMode_;
			selectorConfigData_ = other.selectorConfigData_.Clone();
		}

		[DebuggerNonUserCode]
		public SelectorNodeData Clone()
		{
			return new SelectorNodeData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as SelectorNodeData);
		}

		[DebuggerNonUserCode]
		public bool Equals(SelectorNodeData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (EvalMode != other.EvalMode)
			{
				return false;
			}
			if (!selectorConfigData_.Equals(other.selectorConfigData_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (EvalMode != 0)
			{
				num ^= EvalMode.GetHashCode();
			}
			return num ^ selectorConfigData_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (EvalMode != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(EvalMode);
			}
			selectorConfigData_.WriteTo(output, _repeated_selectorConfigData_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (EvalMode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(EvalMode);
			}
			return num + selectorConfigData_.CalculateSize(_repeated_selectorConfigData_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(SelectorNodeData other)
		{
			if (other != null)
			{
				if (other.EvalMode != 0)
				{
					EvalMode = other.EvalMode;
				}
				selectorConfigData_.Add(other.selectorConfigData_);
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
					EvalMode = input.ReadInt32();
					break;
				case 18u:
					selectorConfigData_.AddEntriesFrom(input, _repeated_selectorConfigData_codec);
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
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[2];

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
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[3];

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
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[4];

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
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[5];

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
	public sealed class SelectorConfigData : IMessage<SelectorConfigData>, IMessage, IEquatable<SelectorConfigData>, IDeepCloneable<SelectorConfigData>
	{
		private static readonly MessageParser<SelectorConfigData> _parser = new MessageParser<SelectorConfigData>(() => new SelectorConfigData());

		public const int CompareModeFieldNumber = 1;

		private int compareMode_;

		public const int CompareValueFieldNumber = 2;

		private int compareValue_;

		[DebuggerNonUserCode]
		public static MessageParser<SelectorConfigData> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => CircuitNodeDataReflection.Descriptor.MessageTypes[6];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public int CompareMode
		{
			get
			{
				return compareMode_;
			}
			set
			{
				compareMode_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CompareValue
		{
			get
			{
				return compareValue_;
			}
			set
			{
				compareValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public SelectorConfigData()
		{
		}

		[DebuggerNonUserCode]
		public SelectorConfigData(SelectorConfigData other)
			: this()
		{
			compareMode_ = other.compareMode_;
			compareValue_ = other.compareValue_;
		}

		[DebuggerNonUserCode]
		public SelectorConfigData Clone()
		{
			return new SelectorConfigData(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as SelectorConfigData);
		}

		[DebuggerNonUserCode]
		public bool Equals(SelectorConfigData other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (CompareMode != other.CompareMode)
			{
				return false;
			}
			if (CompareValue != other.CompareValue)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (CompareMode != 0)
			{
				num ^= CompareMode.GetHashCode();
			}
			if (CompareValue != 0)
			{
				num ^= CompareValue.GetHashCode();
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
			if (CompareMode != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(CompareMode);
			}
			if (CompareValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(CompareValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (CompareMode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(CompareMode);
			}
			if (CompareValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(CompareValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(SelectorConfigData other)
		{
			if (other != null)
			{
				if (other.CompareMode != 0)
				{
					CompareMode = other.CompareMode;
				}
				if (other.CompareValue != 0)
				{
					CompareValue = other.CompareValue;
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
					CompareMode = input.ReadInt32();
					break;
				case 16u:
					CompareValue = input.ReadInt32();
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
namespace RecRoom.Circuits.PlayerStats
{
	public enum CircuitPlayerStat
	{
		Player_Health = 0,
		PlayerStat_1 = 1000,
		PlayerStat_2 = 1001,
		PlayerStat_3 = 1002,
		PlayerStat_4 = 1003,
		PlayerStat_5 = 1004,
		PlayerStat_6 = 1005
	}
	public static class FriendlyCircuitPlayerStats
	{
		public const int STAT_OFFSET = 1000;

		private static Dictionary<string, int> friendlyCircuitPlayerStatsDict;

		public static Dictionary<string, int> FriendlyCircuitPlayerStatsDict
		{
			get
			{
				friendlyCircuitPlayerStatsDict = new Dictionary<string, int>();
				CircuitPlayerStat[] array = (CircuitPlayerStat[])Enum.GetValues(typeof(CircuitPlayerStat));
				foreach (CircuitPlayerStat circuitPlayerStat in array)
				{
					string key = ((circuitPlayerStat != CircuitPlayerStat.Player_Health) ? $"Stat {(int)(circuitPlayerStat - 1000 + 1)}" : "Health");
					friendlyCircuitPlayerStatsDict[key] = (int)circuitPlayerStat;
				}
				return friendlyCircuitPlayerStatsDict;
			}
		}
	}
	[CircuitNodeUuid("FC94A1CD-DD7E-4229-92DF-95991A9E6369")]
	public class PlayerGetStatNode : SourceNodeBase
	{
		public delegate int GetPlayerStatFunction(CircuitPlayerStat stat, int playerId);

		public const string MODE_ARG = "mode";

		private int masterLastPlayerStatSignal;

		private static InputMetadata[] inputMetadata = new InputMetadata[1]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Player"
			}
		};

		private static OutputMetadata[] outputMetadata = new OutputMetadata[1]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Value"
			}
		};

		public CircuitPlayerStat PlayerStat { get; set; }

		public event GetPlayerStatFunction GetPlayerStat;

		public PlayerGetStatNode(int nodeId, CircuitNodeGraph graph)
			: base("PlayerGetStatNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			masterLastPlayerStatSignal = GetStatSignal(isMasterClient);
			SetContinuousOutput(OutputSlot.R, masterLastPlayerStatSignal);
		}

		private int GetStatSignal(bool isMasterClient)
		{
			if (!isMasterClient)
			{
				return masterLastPlayerStatSignal;
			}
			int inputSignal = GetInputSignal(InputSlot.R);
			if (inputSignal > 0)
			{
				try
				{
					return this.GetPlayerStat(PlayerStat, inputSignal);
				}
				catch (Exception e)
				{
					CircuitDebug.LogException(e);
				}
			}
			return 0;
		}

		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
			base.SerializePostEvaluateState(bitPacker);
			bool flag = masterLastPlayerStatSignal != 0;
			bitPacker.WriteBool(flag);
			if (flag)
			{
				bitPacker.WriteInt(masterLastPlayerStatSignal, int.MinValue, int.MaxValue);
			}
		}

		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
			base.DeserializePostEvaluateState(bitPacker);
			bool value = false;
			bitPacker.ReadBool(out value);
			if (value)
			{
				bitPacker.ReadInt(out masterLastPlayerStatSignal, int.MinValue, int.MaxValue);
			}
			else
			{
				masterLastPlayerStatSignal = 0;
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return outputMetadata;
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			PlayerStat = (CircuitPlayerStat)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)PlayerStat;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				PlayerStat = (CircuitPlayerStat)value;
			}
		}
	}
	[CircuitNodeUuid("5A15E563-2F73-41B6-9CDF-6C9FB065A034")]
	public class PlayerSetStatNode : PostEvalActionNode
	{
		public delegate void SetPlayerStatFunction(CircuitPlayerStat stat, int playerId, int signal);

		public const string MODE_ARG = "mode";

		private static InputMetadata[] inputMetadata = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Player"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Set"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.B,
				Description = "Value"
			}
		};

		public CircuitPlayerStat PlayerStat { get; set; }

		public event SetPlayerStatFunction SetPlayerStat;

		public PlayerSetStatNode(int nodeId, CircuitNodeGraph graph)
			: base("PlayerSetStatNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			CircuitPlayerStat stat = PlayerStat;
			int playerId = GetInputSignal(InputSlot.R);
			if (CircuitNode.SignalToBool(GetInputSignal(InputSlot.G)) && playerId != 0)
			{
				int signal = GetInputSignal(InputSlot.B);
				QueuePostEvalAction(delegate
				{
					PostEvalSetPlayerStat(stat, playerId, signal);
				});
			}
		}

		private void PostEvalSetPlayerStat(CircuitPlayerStat stat, int playerId, int signal)
		{
			if (this.SetPlayerStat != null)
			{
				this.SetPlayerStat(stat, playerId, signal);
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return new OutputMetadata[0];
		}

		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
			base.InitializeInnerData(data, reassignNodeIds, nodeIdMap, copyingSettings);
			PlayerStat = (CircuitPlayerStat)data.Mode;
		}

		public override CircuitNodeData Serialize()
		{
			CircuitNodeData circuitNodeData = base.Serialize();
			circuitNodeData.Mode = (int)PlayerStat;
			return circuitNodeData;
		}

		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
			base._ModifyNode(modifyArgs);
			if (modifyArgs.TryGetValue("mode", out var value))
			{
				PlayerStat = (CircuitPlayerStat)value;
			}
		}
	}
}
namespace RecRoom.Circuits.GameStats
{
	[CircuitNodeUuid("2F4A96DA-842F-4F41-84BB-1F283DADB769")]
	public class GameGetScoreNode : SourceNodeBase
	{
		public delegate int GetTeamScoreFunction(int teamId);

		private int masterLastScoreSignal;

		private static InputMetadata[] inputMetadata = new InputMetadata[1]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Team"
			}
		};

		private static OutputMetadata[] outputMetadata = new OutputMetadata[1]
		{
			new OutputMetadata
			{
				OutputSlot = OutputSlot.R,
				Description = "Score"
			}
		};

		public event GetTeamScoreFunction GetTeamScore;

		public GameGetScoreNode(int nodeId, CircuitNodeGraph graph)
			: base("GameGetScoreNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			masterLastScoreSignal = GetScoreSignal(isMasterClient);
			SetContinuousOutput(OutputSlot.R, masterLastScoreSignal);
		}

		private int GetScoreSignal(bool isMasterClient)
		{
			if (!isMasterClient)
			{
				return masterLastScoreSignal;
			}
			int inputSignal = GetInputSignal(InputSlot.R);
			if (inputSignal > 0)
			{
				try
				{
					return this.GetTeamScore(inputSignal);
				}
				catch (Exception e)
				{
					CircuitDebug.LogException(e);
				}
			}
			return 0;
		}

		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
			base.SerializePostEvaluateState(bitPacker);
			bool flag = masterLastScoreSignal != 0;
			bitPacker.WriteBool(flag);
			if (flag)
			{
				bitPacker.WriteInt(masterLastScoreSignal, int.MinValue, int.MaxValue);
			}
		}

		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
			base.DeserializePostEvaluateState(bitPacker);
			bool value = false;
			bitPacker.ReadBool(out value);
			if (value)
			{
				bitPacker.ReadInt(out masterLastScoreSignal, int.MinValue, int.MaxValue);
			}
			else
			{
				masterLastScoreSignal = 0;
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return outputMetadata;
		}
	}
	[CircuitNodeUuid("B79A6285-498A-4748-B960-FA33F4C5CB02")]
	public class GameSetScoreNode : PostEvalActionNode
	{
		public delegate void SetTeamScoreFunction(int teamId, int signal);

		private static InputMetadata[] inputMetadata = new InputMetadata[3]
		{
			new InputMetadata
			{
				InputSlot = InputSlot.R,
				Description = "Team"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.G,
				Description = "Set"
			},
			new InputMetadata
			{
				InputSlot = InputSlot.B,
				Description = "Score"
			}
		};

		public event SetTeamScoreFunction SetTeamScore;

		public GameSetScoreNode(int nodeId, CircuitNodeGraph graph)
			: base("GameSetScoreNode", nodeId, graph)
		{
		}

		protected override void _EvaluateNode(bool isMasterClient)
		{
			base._EvaluateNode(isMasterClient);
			int teamId = GetInputSignal(InputSlot.R);
			if (CircuitNode.SignalToBool(GetInputSignal(InputSlot.G)) && teamId > 0)
			{
				int signal = GetInputSignal(InputSlot.B);
				QueuePostEvalAction(delegate
				{
					PostEvalSetPlayerStat(teamId, signal);
				});
			}
		}

		private void PostEvalSetPlayerStat(int teamId, int signal)
		{
			if (this.SetTeamScore != null)
			{
				this.SetTeamScore(teamId, signal);
			}
		}

		protected override InputMetadata[] GetInputMetadata()
		{
			return inputMetadata;
		}

		protected override OutputMetadata[] GetOutputMetadata()
		{
			return new OutputMetadata[0];
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
	public enum CircuitLogLevel
	{
		Info,
		Warning,
		Error
	}
	public static class CircuitDebug
	{
		public delegate void LogEvent(CircuitLogLevel level, string message);

		public delegate void LogExceptionEvent(Exception e, string message);

		public const string NODE_LOG_FORMAT = "N[{0}]: {1}";

		public const string GRAPH_LOG_FORMAT = "G[{0}]: {1}";

		public static event LogEvent OnLogEvent;

		public static event LogExceptionEvent OnLogExceptionEvent;

		public static void LogException(Exception e, string message = null)
		{
			if (CircuitDebug.OnLogExceptionEvent != null)
			{
				try
				{
					CircuitDebug.OnLogExceptionEvent(e, message);
				}
				catch
				{
				}
			}
		}

		public static void Log(CircuitLogLevel level, string message)
		{
			if (CircuitDebug.OnLogEvent != null)
			{
				try
				{
					CircuitDebug.OnLogEvent(level, message);
				}
				catch
				{
				}
			}
		}

		public static void NodeLog(int nodeId, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
			string message2 = $"N[{nodeId}]: {message}";
			Log(CircuitLogLevel, message2);
		}

		public static void NodeLogFormat(int nodeId, CircuitLogLevel CircuitLogLevel, string format, params object[] args)
		{
			NodeLog(nodeId, string.Format(format, args));
		}

		public static void GraphLog(Guid graphGuid, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
			string message2 = $"G[{graphGuid}]: {message}";
			Log(CircuitLogLevel, message2);
		}

		public static void GraphLog(Guid graphGuid, string format, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning, params object[] args)
		{
			GraphLog(graphGuid, string.Format(format, args));
		}

		public static bool IsReleaseBuild()
		{
			return true;
		}
	}
	internal static class NodeEventUtil
	{
		internal static void SafeInvoke(this CircuitNode.NodeLifecycleEvent nodeLifecycleEvent, CircuitNode nodeArg)
		{
			if (nodeLifecycleEvent == null)
			{
				return;
			}
			try
			{
				nodeLifecycleEvent(nodeArg);
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e);
			}
		}

		internal static void SafeInvoke(this CircuitNode.NodeConnectionChanged nodeConnectionEvent, CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			if (nodeConnectionEvent == null)
			{
				return;
			}
			try
			{
				nodeConnectionEvent(sourceNode, destNode, inputSlot, outputSlot);
			}
			catch (Exception e)
			{
				CircuitDebug.LogException(e);
			}
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
