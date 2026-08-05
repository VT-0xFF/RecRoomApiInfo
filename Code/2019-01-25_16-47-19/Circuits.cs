using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using RecRoom.Circuits.Protobuf;
using RecRoom.Circuits.Traversal;

[assembly: AssemblyVersion("1.0.0.0")]
namespace RecRoom.Circuits
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class BitPacker
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct IntFloatType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public float AsFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const int DEFAULT_SCRATCH_BUFFER_SIZE = 128;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float SQRT_ONE_HALF = 0.70710677f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly int[] REQUIRED_BITS_LOOKUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly byte[] scratchBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Stream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool isWriting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int totalLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int scratchByteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int scratchBitIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int scratchByteLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IntFloatType intFloatConverter;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x14AD020", Offset = "0x14AC420", VA = "0x1814AD020")]
		public static int RequiredBits(uint maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA3360", Offset = "0xA2760", VA = "0x1800A3360")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x14AD420", Offset = "0x14AC820", VA = "0x1814AD420")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14AD110", Offset = "0x14AC510", VA = "0x1814AD110")]
		public void StartWriting(Stream stream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x14ACAE0", Offset = "0x14ABEE0", VA = "0x1814ACAE0")]
		public int FinishWriting()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x14AD0F0", Offset = "0x14AC4F0", VA = "0x1814AD0F0")]
		public void StartReading(Stream stream, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x14ACAD0", Offset = "0x14ABED0", VA = "0x1814ACAD0")]
		public void FinishReading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x14AD2D0", Offset = "0x14AC6D0", VA = "0x1814AD2D0")]
		public void WriteBool(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14ACE90", Offset = "0x14AC290", VA = "0x1814ACE90")]
		public void ReadBool(out bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x14AD300", Offset = "0x14AC700", VA = "0x1814AD300")]
		public void WriteInt(int value, int minimum, int maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x14ACEC0", Offset = "0x14AC2C0", VA = "0x1814ACEC0")]
		public void ReadInt(out int value, int minimum, int maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x14AD150", Offset = "0x14AC550", VA = "0x1814AD150")]
		private void WriteBits(uint value, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14ACBB0", Offset = "0x14ABFB0", VA = "0x1814ACBB0")]
		private uint ReadBits(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x14ACB50", Offset = "0x14ABF50", VA = "0x1814ACB50")]
		private void FlushScratchBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14ACF50", Offset = "0x14AC350", VA = "0x1814ACF50")]
		private void RefillScratchBuffer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CircuitLink
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly LinkTypes LinkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly CircuitNode SourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly CircuitNode DestNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly OutputSlot OutputSlot;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x14AF810", Offset = "0x14AEC10", VA = "0x1814AF810")]
		public CircuitLink(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x14AF530", Offset = "0x14AE930", VA = "0x1814AF530")]
		public CircuitLinkData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x14AF2E0", Offset = "0x14AE6E0", VA = "0x1814AF2E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x14AF3F0", Offset = "0x14AE7F0", VA = "0x1814AF3F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x14AF5C0", Offset = "0x14AE9C0", VA = "0x1814AF5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CircuitNodeUuidAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly Guid Id;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool InternalOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x95950", Offset = "0x94D50", VA = "0x180095950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x14B9200", Offset = "0x14B8600", VA = "0x1814B9200")]
		public CircuitNodeUuidAttribute(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14B9190", Offset = "0x14B8590", VA = "0x1814B9190")]
		public static CircuitNodeUuidAttribute GetFromType(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EqualityComparers
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static InputSlotComparer InputSlotComparer;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static OutputSlotComparer OutputSlotComparer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class InputSlotComparer : IEqualityComparer<InputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x14C3920", Offset = "0x14C2D20", VA = "0x1814C3920", Slot = "4")]
		public bool Equals(InputSlot x, InputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x14C3940", Offset = "0x14C2D40", VA = "0x1814C3940", Slot = "5")]
		public int GetHashCode(InputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		public InputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OutputSlotComparer : IEqualityComparer<OutputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14C3920", Offset = "0x14C2D20", VA = "0x1814C3920", Slot = "4")]
		public bool Equals(OutputSlot x, OutputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x14C3940", Offset = "0x14C2D40", VA = "0x1814C3940", Slot = "5")]
		public int GetHashCode(OutputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		public OutputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate void NodeLifecycleEvent(CircuitNode node);

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private struct OutputSignal
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool IsMomentary;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public delegate void NodeMetadataChanged(NodeMetadata newNodeMetadata);

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate void ThisNodeConnectionChanged(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate void NodeConnectionChanged(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot);

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public const int NULL_CIRCUIT_NODE_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static long globalMaxCircuitNodeId;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static object circuitIdLockObj;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static NodeLifecycleEvent OnNodeDestroyedEvent;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static NodeLifecycleEvent OnNodeInstantiatedEvent;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public const int ON_TRUE = 1;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int OFF_FALSE = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int ExecutionOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private OutputSignal[] OutputSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Dictionary<InputSlot, CircuitLink> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Dictionary<OutputSlot, HashSet<CircuitLink>> Outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NodeMetadataChanged NodeMetadataChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private CircuitNodeGraph _nodeGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private OutputSignal[] outputValuesDeserializationBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public ThisNodeConnectionChanged OnConnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static NodeConnectionChanged OnNodesConnectedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ThisNodeConnectionChanged OnDisconnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static NodeConnectionChanged OnNodesDisconnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static Dictionary<int, CircuitNode> AllNodes;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static InputMetadata[] allSlotsInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static OutputMetadata[] allSlotsOutputMetadata;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA0", Offset = "0x6C1A0", VA = "0x18006CDA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal virtual bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA0", Offset = "0x6C1A0", VA = "0x18006CDA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal virtual bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA0", Offset = "0x6C1A0", VA = "0x18006CDA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal virtual bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA0", Offset = "0x6C1A0", VA = "0x18006CDA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal virtual bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA0", Offset = "0x6C1A0", VA = "0x18006CDA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CircuitNode PairedNode
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x64390", Offset = "0x63790", VA = "0x180064390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x643C0", Offset = "0x637C0", VA = "0x1800643C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HasConnectedInputs
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x14BE9C0", Offset = "0x14BDDC0", VA = "0x1814BE9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HasConnectedOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x14BEAD0", Offset = "0x14BDED0", VA = "0x1814BEAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD6090", Offset = "0xD5490", VA = "0x1800D6090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3A7300", Offset = "0x3A6700", VA = "0x1803A7300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x958C0", Offset = "0x94CC0", VA = "0x1800958C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x97C30", Offset = "0x97030", VA = "0x180097C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NodeMetadata NodeMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x14BEB90", Offset = "0x14BDF90", VA = "0x1814BEB90")]
			[CompilerGenerated]
			get
			{
				return default(NodeMetadata);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x14BEC60", Offset = "0x14BE060", VA = "0x1814BEC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CircuitNodeGraph NodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x108760", Offset = "0x107B60", VA = "0x180108760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		internal bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x621FF0", Offset = "0x6213F0", VA = "0x180621FF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6223B0", Offset = "0x6217B0", VA = "0x1806223B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int NodeCount
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x14BEB20", Offset = "0x14BDF20", VA = "0x1814BEB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static InputMetadata[] AllSlotsInputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x14BE630", Offset = "0x14BDA30", VA = "0x1814BE630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static OutputMetadata[] AllSlotsOutputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x14BE7F0", Offset = "0x14BDBF0", VA = "0x1814BE7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NodeModifiedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x14BE580", Offset = "0x14BD980", VA = "0x1814BE580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x14BEBB0", Offset = "0x14BDFB0", VA = "0x1814BEBB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14BC570", Offset = "0x14BB970", VA = "0x1814BC570")]
		public static int NewNodeId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x14BE070", Offset = "0x14BD470", VA = "0x1814BE070")]
		internal static int SetPossibleMaxId(int newPossibleMax)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x14BCCC0", Offset = "0x14BC0C0", VA = "0x1814BCCC0")]
		public static void ResetMaxNodeId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x14BC190", Offset = "0x14BB590", VA = "0x1814BC190")]
		public static long GetMaxNodeId()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14BC690", Offset = "0x14BBA90", VA = "0x1814BC690")]
		internal static void OverrideMaxNodeId(long overrideValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x14BCDC0", Offset = "0x14BC1C0", VA = "0x1814BCDC0")]
		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x14BCE30", Offset = "0x14BC230", VA = "0x1814BCE30")]
		private static void SendNodeInstantiatedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract InputMetadata[] GetInputMetadata();

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract OutputMetadata[] GetOutputMetadata();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x958C0", Offset = "0x94CC0", VA = "0x1800958C0", Slot = "11")]
		protected virtual string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x14BE320", Offset = "0x14BD720", VA = "0x1814BE320")]
		public CircuitNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x14BC7A0", Offset = "0x14BBBA0", VA = "0x1814BC7A0")]
		protected void ReconstructNodeMetadata()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x14BD410", Offset = "0x14BC810", VA = "0x1814BD410", Slot = "12")]
		public virtual CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x14BC340", Offset = "0x14BB740", VA = "0x1814BC340", Slot = "13")]
		internal virtual void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x14BA4D0", Offset = "0x14B98D0", VA = "0x1814BA4D0")]
		public void CopySettings(CircuitNodeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x14BA560", Offset = "0x14B9960", VA = "0x1814BA560")]
		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x14BD400", Offset = "0x14BC800", VA = "0x1814BD400", Slot = "14")]
		internal virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x14BB100", Offset = "0x14BA500", VA = "0x1814BB100", Slot = "15")]
		internal virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63980", Offset = "0x62D80", VA = "0x180063980", Slot = "16")]
		internal virtual void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63980", Offset = "0x62D80", VA = "0x180063980", Slot = "17")]
		internal virtual void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x14BD160", Offset = "0x14BC560", VA = "0x1814BD160")]
		private void SerializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x14BAD40", Offset = "0x14BA140", VA = "0x1814BAD40")]
		private void DeserializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x14BDD50", Offset = "0x14BD150", VA = "0x1814BDD50")]
		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x14B9C90", Offset = "0x14B9090", VA = "0x1814B9C90")]
		internal static bool ConnectNodes(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x14BCEA0", Offset = "0x14BC2A0", VA = "0x1814BCEA0")]
		private static void SendNodesConnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x14BD000", Offset = "0x14BC400", VA = "0x1814BD000")]
		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x14B9250", Offset = "0x14B8650", VA = "0x1814B9250")]
		private static void AddLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x14BBFF0", Offset = "0x14BB3F0", VA = "0x1814BBFF0")]
		internal static bool FormsLoop(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x14BA350", Offset = "0x14B9750", VA = "0x1814BA350")]
		public bool ConnectToMyInput(CircuitNode sourceNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x14B9340", Offset = "0x14B8740", VA = "0x1814B9340")]
		protected bool CanConnectInput(CircuitNode newSourceNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x14BA410", Offset = "0x14B9810", VA = "0x1814BA410")]
		public bool ConnectToMyOutput(CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x14B9410", Offset = "0x14B8810", VA = "0x1814B9410")]
		protected bool CanConnectOutput(InputSlot inputSlot, OutputSlot outputSlot, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x14BE1E0", Offset = "0x14BD5E0", VA = "0x1814BE1E0")]
		protected bool SlotsCanConnect(InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x14BB4F0", Offset = "0x14BA8F0", VA = "0x1814BB4F0")]
		public void DisconnectInput(InputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x14BB110", Offset = "0x14BA510", VA = "0x1814BB110", Slot = "18")]
		public virtual void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x14BBD00", Offset = "0x14BB100", VA = "0x1814BBD00")]
		public void DisconnectOutput(OutputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x14BB590", Offset = "0x14BA990", VA = "0x1814BB590")]
		protected static void DisconnectNodeLink(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x14BC8F0", Offset = "0x14BBCF0", VA = "0x1814BC8F0")]
		private static void RemoveLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x14BCB40", Offset = "0x14BBF40", VA = "0x1814BCB40")]
		private static bool RemoveOutputLink(CircuitNode node, CircuitLink link)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x14BC830", Offset = "0x14BBC30", VA = "0x1814BC830")]
		private static bool RemoveInputSlot(CircuitNode node, InputSlot inputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x14B9610", Offset = "0x14B8A10", VA = "0x1814B9610")]
		private static bool CheckForDisconnectedGraph(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x14BBEA0", Offset = "0x14BB2A0", VA = "0x1814BBEA0")]
		internal void EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63980", Offset = "0x62D80", VA = "0x180063980", Slot = "19")]
		internal virtual void PostEvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x14BC2E0", Offset = "0x14BB6E0", VA = "0x1814BC2E0")]
		public bool HasMomentaryOutputs()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x14B9B60", Offset = "0x14B8F60", VA = "0x1814B9B60")]
		public void ClearMomentaryOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63980", Offset = "0x62D80", VA = "0x180063980", Slot = "20")]
		protected virtual void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14BE200", Offset = "0x14BD600", VA = "0x1814BE200", Slot = "21")]
		protected virtual void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x14B9C00", Offset = "0x14B9000", VA = "0x1814B9C00")]
		protected void ClearOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x14BC0E0", Offset = "0x14BB4E0", VA = "0x1814BC0E0")]
		public int GetInputSignal(InputSlot inputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14BC2A0", Offset = "0x14BB6A0", VA = "0x1814BC2A0")]
		public int GetOutputSignal(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x14BDD10", Offset = "0x14BD110", VA = "0x1814BDD10")]
		protected void SetContinuousOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x14BDD30", Offset = "0x14BD130", VA = "0x1814BDD30")]
		protected void SetMomentaryOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x14BDF50", Offset = "0x14BD350", VA = "0x1814BDF50")]
		private void SetOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x14BC520", Offset = "0x14BB920", VA = "0x1814BC520")]
		public void ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63980", Offset = "0x62D80", VA = "0x180063980", Slot = "22")]
		protected virtual void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x14B9980", Offset = "0x14B8D80", VA = "0x1814B9980")]
		internal static void ClearAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF60", Offset = "0x14BB360", VA = "0x1814BBF60")]
		public static CircuitNode Find(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x11A6AC0", Offset = "0x11A5EC0", VA = "0x1811A6AC0")]
		public static int BoolToSignal(bool value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x11A6AB0", Offset = "0x11A5EB0", VA = "0x1811A6AB0")]
		public static bool SignalToBool(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x14B9900", Offset = "0x14B8D00", VA = "0x1814B9900")]
		public static int ClampSignal(int value, int min, int max)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class DictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD453E0", Offset = "0xD447E0", VA = "0x180D453E0")]
		public static TValue GetOrCreate<TValue, TKey>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			return (TValue)null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate void UpdateGraph(int networkTimeMilliseconds, bool isMasterClient);
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CircuitNodeGraph : IComparable<CircuitNodeGraph>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class SerializedCircuitNodeGraphCopy
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public CircuitNodeGraphCollectionData GraphCollectionData
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0x64380", Offset = "0x63780", VA = "0x180064380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x643B0", Offset = "0x637B0", VA = "0x1800643B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x64390", Offset = "0x63790", VA = "0x180064390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x643C0", Offset = "0x637C0", VA = "0x1800643C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
			public SerializedCircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public class CircuitNodeGraphCopy
		{
			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public List<CircuitNodeGraph> CopiedGraphs
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x64380", Offset = "0x63780", VA = "0x180064380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x643B0", Offset = "0x637B0", VA = "0x1800643B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x64390", Offset = "0x63790", VA = "0x180064390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x643C0", Offset = "0x637C0", VA = "0x1800643C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
			public CircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static List<CircuitNodeGraph> AllGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly Guid GraphGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly bool IsInternalGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private RootNode _rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public bool GraphRequiresSort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		internal readonly HashSet<CircuitNode> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly List<CircuitNode> StatefulNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private List<CircuitNode> ReverseTopologicNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool destroyed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private HashSet<CircuitNode> needsPostEval;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static BitPacker bitPacker;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public RootNode RootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x958C0", Offset = "0x94CC0", VA = "0x1800958C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x97C30", Offset = "0x97030", VA = "0x180097C30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NodeGraphDirty
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x958D0", Offset = "0x94CD0", VA = "0x1800958D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x959C0", Offset = "0x94DC0", VA = "0x1800959C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		internal static event UpdateGraph TimeUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x14B8F90", Offset = "0x14B8390", VA = "0x1814B8F90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x14B9090", Offset = "0x14B8490", VA = "0x1814B9090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x14B8ED0", Offset = "0x14B82D0", VA = "0x1814B8ED0")]
		internal CircuitNodeGraph(bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x14B8F60", Offset = "0x14B8360", VA = "0x1814B8F60")]
		public CircuitNodeGraph(Guid guid, bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x14B8D50", Offset = "0x14B8150", VA = "0x1814B8D50")]
		private CircuitNodeGraph(Guid guid, bool isInternalGraph, bool createRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x14B8BC0", Offset = "0x14B7FC0", VA = "0x1814B8BC0")]
		public static void Update(int networkTimeMilliseconds, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x14B6F00", Offset = "0x14B6300", VA = "0x1814B6F00")]
		private void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x14B6DB0", Offset = "0x14B61B0", VA = "0x1814B6DB0")]
		public void DestroySelfAndNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x14B4770", Offset = "0x14B3B70", VA = "0x1814B4770")]
		internal void AddNode(CircuitNode circuitNode, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x14B7D90", Offset = "0x14B7190", VA = "0x1814B7D90")]
		internal bool RemoveNode(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x14B6F90", Offset = "0x14B6390", VA = "0x1814B6F90")]
		public List<CircuitNode> Evaluate(bool isMasterClient)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x14B49F0", Offset = "0x14B3DF0", VA = "0x1814B49F0", Slot = "4")]
		public int CompareTo(CircuitNodeGraph other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x14B87E0", Offset = "0x14B7BE0", VA = "0x1814B87E0")]
		public static byte[] SerializeRuntimeState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x14B62C0", Offset = "0x14B56C0", VA = "0x1814B62C0")]
		public static void DeserializeRuntimeState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x14B8400", Offset = "0x14B7800", VA = "0x1814B8400")]
		public static byte[] SerializePostEvaluateState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x14B5F20", Offset = "0x14B5320", VA = "0x1814B5F20")]
		public static void DeserializePostEvaluateState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x14B78A0", Offset = "0x14B6CA0", VA = "0x1814B78A0")]
		public static CircuitNodeGraphCollectionData PersistAll([Optional] IList<int> inactiveIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x14B6D10", Offset = "0x14B6110", VA = "0x1814B6D10")]
		public static void DestroyAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x14B5B40", Offset = "0x14B4F40", VA = "0x1814B5B40")]
		public static void DeserializeAll(CircuitNodeGraphCollectionData data, out Dictionary<int, int> nodeIdMappings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x14B7AC0", Offset = "0x14B6EC0", VA = "0x1814B7AC0")]
		public CircuitNodeGraphData Persist()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x14B6660", Offset = "0x14B5A60", VA = "0x1814B6660")]
		public static CircuitNodeGraph Deserialize(CircuitNodeGraphData data, bool reassignNodeIds, out Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x14B4A30", Offset = "0x14B3E30", VA = "0x1814B4A30")]
		public static CircuitNodeGraphCopy CopyNodesToNewGraphs(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x14B7F00", Offset = "0x14B7300", VA = "0x1814B7F00")]
		public static SerializedCircuitNodeGraphCopy SerializeNodesAsNewGraph(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x14B7360", Offset = "0x14B6760", VA = "0x1814B7360")]
		public static CircuitNodeGraph MergeGraphs(CircuitNode nodeA, CircuitNode nodeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x14B75C0", Offset = "0x14B69C0", VA = "0x1814B75C0")]
		private static CircuitNodeGraph MergeInto(CircuitNodeGraph toGraph, CircuitNodeGraph fromGraph, params CircuitNode[] nodes)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum InputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		R,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		G,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		B,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		C,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		M,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		K,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		VIRTUAL
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum OutputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		R,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		G,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		B,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		C,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		M,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		K,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		VIRTUAL
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class IOSlots
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static InputSlot[] AllInputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static InputSlot[] AllStandardInputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static OutputSlot[] AllOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static OutputSlot[] AllStandardOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static Dictionary<InputSlot, OutputSlot> InputSlotToOutputSlot;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static Dictionary<OutputSlot, InputSlot> OutputSlotToInputSlot;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class BooleanNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum BooleanModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			And,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Or,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Not
		}

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly InputMetadata[] NotInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly OutputMetadata[] NotOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly Dictionary<BooleanModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private BooleanModes booleanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private List<int> inputs;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BooleanModes BooleanMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(BooleanModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x14AE280", Offset = "0x14AD680", VA = "0x1814AE280")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x14ADAF0", Offset = "0x14ACEF0", VA = "0x1814ADAF0")]
		public static string GetModeSymbol(BooleanModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x14AE1D0", Offset = "0x14AD5D0", VA = "0x1814AE1D0")]
		public BooleanNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x14ADD60", Offset = "0x14AD160", VA = "0x1814ADD60", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x14AD6D0", Offset = "0x14ACAD0", VA = "0x1814AD6D0")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x14AD490", Offset = "0x14AC890", VA = "0x1814AD490")]
		private bool CalcAndOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x14AD5B0", Offset = "0x14AC9B0", VA = "0x1814AD5B0")]
		private bool CalcOrOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x14AD930", Offset = "0x14ACD30", VA = "0x1814AD930")]
		private void FetchInputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x14ADA50", Offset = "0x14ACE50", VA = "0x1814ADA50", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x14ADC30", Offset = "0x14AD030", VA = "0x1814ADC30", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x14ADB70", Offset = "0x14ACF70", VA = "0x1814ADB70", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x14ADCD0", Offset = "0x14AD0D0", VA = "0x1814ADCD0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x14ADD30", Offset = "0x14AD130", VA = "0x1814ADD30", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x14ADE30", Offset = "0x14AD230", VA = "0x1814ADE30", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class ContinuousSourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x14C0700", Offset = "0x14BFB00", VA = "0x1814C0700")]
		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x14BDD10", Offset = "0x14BD110", VA = "0x1814BDD10")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class GameSetStateNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action StartGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x14C2A20", Offset = "0x14C1E20", VA = "0x1814C2A20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x14C2B80", Offset = "0x14C1F80", VA = "0x1814C2B80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action EndGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x14C2970", Offset = "0x14C1D70", VA = "0x1814C2970")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x14C2AD0", Offset = "0x14C1ED0", VA = "0x1814C2AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x14C25B0", Offset = "0x14C19B0", VA = "0x1814C25B0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x14C2610", Offset = "0x14C1A10", VA = "0x1814C2610", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x14C2910", Offset = "0x14C1D10", VA = "0x1814C2910")]
		public GameSetStateNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x14C2690", Offset = "0x14C1A90", VA = "0x1814C2690", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class ObjectSetTagsNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public enum ChangeModes
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Defaults
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate void ChangeTagsForObjectFunc(int objectId);

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public const string MODE_ARG = "mode";

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private const string nodeDescription = "Change Tags on Object";

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private ChangeModes changeMode;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ChangeModes ChangeMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(ChangeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x14AE280", Offset = "0x14AD680", VA = "0x1814AE280")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ChangeTagsForObjectFunc ChangeTagsForObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x14C56D0", Offset = "0x14C4AD0", VA = "0x1814C56D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x14C5780", Offset = "0x14C4B80", VA = "0x1814C5780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x14C5650", Offset = "0x14C4A50", VA = "0x1814C5650")]
		public ObjectSetTagsNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x14C5280", Offset = "0x14C4680", VA = "0x1814C5280", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x14C5220", Offset = "0x14C4620", VA = "0x1814C5220", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x14C52F0", Offset = "0x14C46F0", VA = "0x1814C52F0", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x14C5440", Offset = "0x14C4840", VA = "0x1814C5440", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x14C5350", Offset = "0x14C4750", VA = "0x1814C5350", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x14ADCD0", Offset = "0x14AD0D0", VA = "0x1814ADCD0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x14ADD30", Offset = "0x14AD130", VA = "0x1814ADD30", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class PlayerRoleMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum PlayerRoleMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			AddPlayerRole,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			RemovePlayerRole,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			PlayerHasRole,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			PlayerRoleChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate void PlayerModifyRoleFunc(int playerId, int roleId);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool PlayerHasRoleFunc(int playerId, int roleId);

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static readonly OutputMetadata[] PlayerHasRoleOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static readonly OutputMetadata[] PlayerRoleChangedOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly InputMetadata[] PlayerHasRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static readonly InputMetadata[] ModifyPlayerRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static readonly OutputMetadata[] ModifyPlayerRoleOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private PlayerRoleMapModes playerRoleMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int modificationRoleId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool masterLastPlayerHasRoleSignal;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public PlayerRoleMapModes PlayerRoleMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x117490", Offset = "0x116890", VA = "0x180117490")]
			get
			{
				return default(PlayerRoleMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x14C8510", Offset = "0x14C7910", VA = "0x1814C8510")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int ModificationRoleId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x117480", Offset = "0x116880", VA = "0x180117480")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x14C84F0", Offset = "0x14C78F0", VA = "0x1814C84F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PlayerModifyRoleFunc PlayerAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x14C7E10", Offset = "0x14C7210", VA = "0x1814C7E10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x14C8180", Offset = "0x14C7580", VA = "0x1814C8180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PlayerModifyRoleFunc TeamAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x14C8020", Offset = "0x14C7420", VA = "0x1814C8020")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x14C8390", Offset = "0x14C7790", VA = "0x1814C8390")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PlayerModifyRoleFunc PlayerRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x14C7F70", Offset = "0x14C7370", VA = "0x1814C7F70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x14C82E0", Offset = "0x14C76E0", VA = "0x1814C82E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PlayerModifyRoleFunc TeamRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x14C80D0", Offset = "0x14C74D0", VA = "0x1814C80D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x14C8440", Offset = "0x14C7840", VA = "0x1814C8440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event PlayerHasRoleFunc PlayerHasRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x14C7EC0", Offset = "0x14C72C0", VA = "0x1814C7EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x14C8230", Offset = "0x14C7630", VA = "0x1814C8230")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x14C75C0", Offset = "0x14C69C0", VA = "0x1814C75C0")]
		public void MarkDirtyForRoleChange(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x14C7DA0", Offset = "0x14C71A0", VA = "0x1814C7DA0")]
		public PlayerRoleMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x14C7680", Offset = "0x14C6A80", VA = "0x1814C7680", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x14C6FA0", Offset = "0x14C63A0", VA = "0x1814C6FA0")]
		private void EvaluatePlayerHasRole(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x14C7460", Offset = "0x14C6860", VA = "0x1814C7460")]
		private bool GetPlayerHasRoleSignal(bool isMasterClient, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x14C6EA0", Offset = "0x14C62A0", VA = "0x1814C6EA0")]
		private void EvaluateAddPlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x14C7070", Offset = "0x14C6470", VA = "0x1814C7070")]
		private void EvaluateRemovePlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x14C7600", Offset = "0x14C6A00", VA = "0x1814C7600", Slot = "16")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x14C6E60", Offset = "0x14C6260", VA = "0x1814C6E60", Slot = "17")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x14C7170", Offset = "0x14C6570", VA = "0x1814C7170", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x14C7330", Offset = "0x14C6730", VA = "0x1814C7330", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x14C7280", Offset = "0x14C6680", VA = "0x1814C7280", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x14C7540", Offset = "0x14C6940", VA = "0x1814C7540", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x14C7640", Offset = "0x14C6A40", VA = "0x1814C7640", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x14C7900", Offset = "0x14C6D00", VA = "0x1814C7900", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class PlayerTeamMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum PlayerIdMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			PlayerToTeam,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			TeamToPlayer,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			SetPlayerTeam,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			GetTeamPlayerCount
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public delegate void PlayerToTeamIndexFunc(int playerId, out int teamId, out int teamIndex);

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public delegate void PlayerSetTeamFunc(int playerId, int teamId);

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public delegate void TeamIndexToPlayerFunc(int teamId, int teamIndex, out int playerId);

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public delegate void GetTeamPlayerCountFunc(int teamId, out int teamPlayerCount);

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly InputMetadata[] PlayerToTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly OutputMetadata[] PlayerToTeamOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly InputMetadata[] TeamToPlayerInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly OutputMetadata[] TeamToPlayerOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly InputMetadata[] SetPlayerTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly InputMetadata[] GetTeamPlayerCountInputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly OutputMetadata[] GetTeamPlayerCountOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly OutputMetadata[] SetPlayerTeamOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private PlayerIdMapModes playerIdMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int lastMasterPlayerToTeamId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int lastMasterPlayerToTeamIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int lastMasterTeamIndexToPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int lastMasterTeamPlayerCount;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public PlayerIdMapModes PlayerIdMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x117490", Offset = "0x116890", VA = "0x180117490")]
			get
			{
				return default(PlayerIdMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x14C8510", Offset = "0x14C7910", VA = "0x1814C8510")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event PlayerToTeamIndexFunc PlayerToTeamIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x14CA360", Offset = "0x14C9760", VA = "0x1814CA360")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x14CA620", Offset = "0x14C9A20", VA = "0x1814CA620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event PlayerSetTeamFunc PlayerSetTeam
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x14CA2B0", Offset = "0x14C96B0", VA = "0x1814CA2B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x14CA570", Offset = "0x14C9970", VA = "0x1814CA570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event TeamIndexToPlayerFunc TeamIndexToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x14CA410", Offset = "0x14C9810", VA = "0x1814CA410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x14CA6D0", Offset = "0x14C9AD0", VA = "0x1814CA6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event GetTeamPlayerCountFunc GetTeamPlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x14CA200", Offset = "0x14C9600", VA = "0x1814CA200")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x14CA4C0", Offset = "0x14C98C0", VA = "0x1814CA4C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x14C9740", Offset = "0x14C8B40", VA = "0x1814C9740")]
		public void MarkDirtyForTeamChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x14CA1A0", Offset = "0x14C95A0", VA = "0x1814CA1A0")]
		public PlayerTeamMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x14C98C0", Offset = "0x14C8CC0", VA = "0x1814C98C0", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x14C8EC0", Offset = "0x14C82C0", VA = "0x1814C8EC0")]
		private void EvaluatePlayerToTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x14C9410", Offset = "0x14C8810", VA = "0x1814C9410")]
		private void GetPlayerToTeamSignals(bool isMasterClient, int playerId, out int masterTeamId, out int masterTeamIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x14C9050", Offset = "0x14C8450", VA = "0x1814C9050")]
		private void EvaluateTeamToPlayer(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x14C9500", Offset = "0x14C8900", VA = "0x1814C9500")]
		private int GetTeamIndexToPlayerSignal(bool isMasterClient, int teamId, int teamIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x14C8DD0", Offset = "0x14C81D0", VA = "0x1814C8DD0")]
		private void EvaluateGetTeamPlayerCount(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x14C95F0", Offset = "0x14C89F0", VA = "0x1814C95F0")]
		private int GetTeamPlayerCountSignal(bool isMasterClient, int teamId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x14C8F60", Offset = "0x14C8360", VA = "0x1814C8F60")]
		private void EvaluateSetPlayerTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x14C9760", Offset = "0x14C8B60", VA = "0x1814C9760", Slot = "16")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x14C8C40", Offset = "0x14C8040", VA = "0x1814C8C40", Slot = "17")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x14C90D0", Offset = "0x14C84D0", VA = "0x1814C90D0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x14C92B0", Offset = "0x14C86B0", VA = "0x1814C92B0", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x14C9230", Offset = "0x14C8630", VA = "0x1814C9230", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x14C96E0", Offset = "0x14C8AE0", VA = "0x1814C96E0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x14C6690", Offset = "0x14C5A90", VA = "0x1814C6690", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x14C9BF0", Offset = "0x14C8FF0", VA = "0x1814C9BF0", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class PostEvalActionNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private List<Action> PostEvalActions;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal sealed override bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x14CAB00", Offset = "0x14C9F00", VA = "0x1814CAB00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x14CAA40", Offset = "0x14C9E40", VA = "0x1814CAA40")]
		public PostEvalActionNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x14CA9E0", Offset = "0x14C9DE0", VA = "0x1814CA9E0")]
		protected void QueuePostEvalAction(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x14CA840", Offset = "0x14C9C40", VA = "0x1814CA840", Slot = "19")]
		internal sealed override void PostEvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class QueuedMomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public struct Output
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public OutputSlot outputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int outputValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		internal List<Output[]> QueuedSignals;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x21E3830", Offset = "0x21E2C30", VA = "0x1821E3830")]
		public QueuedMomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x21E3660", Offset = "0x21E2A60", VA = "0x1821E3660")]
		public new void SetContinuousOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x21E3670", Offset = "0x21E2A70", VA = "0x1821E3670")]
		public new void SetMomentaryOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x21E3720", Offset = "0x21E2B20", VA = "0x1821E3720")]
		public void SetMomentaryOutputs(params Output[] outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x21E3730", Offset = "0x21E2B30", VA = "0x1821E3730", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x21E34B0", Offset = "0x21E28B0", VA = "0x1821E34B0", Slot = "14")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x21E3210", Offset = "0x21E2610", VA = "0x1821E3210", Slot = "15")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x21E33E0", Offset = "0x21E27E0", VA = "0x1821E33E0")]
		private void QueueSignal(Output[] outputs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class ObjectPlayerMappingNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void ObjectToHoldingPlayerIdFunc(int objectId, out int lastHeldPlayer, out int currentHoldingPlayer);

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event ObjectToHoldingPlayerIdFunc ObjectToHoldingPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x14C50C0", Offset = "0x14C44C0", VA = "0x1814C50C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x14C5170", Offset = "0x14C4570", VA = "0x1814C5170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x14C5040", Offset = "0x14C4440", VA = "0x1814C5040")]
		public ObjectPlayerMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x14C4BF0", Offset = "0x14C3FF0", VA = "0x1814C4BF0", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x14C4B90", Offset = "0x14C3F90", VA = "0x1814C4B90", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x14C4C20", Offset = "0x14C4020", VA = "0x1814C4C20", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x14C4E20", Offset = "0x14C4220", VA = "0x1814C4E20", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x14C4C80", Offset = "0x14C4080", VA = "0x1814C4C80")]
		private void MasterCalcOutput(int objectId, out int lastHeldPlayerId, out int currentHoldingPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class RandomNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public enum RandomModes
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			Continuous,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			Pulse
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private RandomModes randomMode;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static Random random;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int masterLastRandomNumber;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public RandomModes RandomMode
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(RandomModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x21E40B0", Offset = "0x21E34B0", VA = "0x1821E40B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x21E4030", Offset = "0x21E3430", VA = "0x1821E4030")]
		public RandomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x21E3AA0", Offset = "0x21E2EA0", VA = "0x1821E3AA0", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x21E3A40", Offset = "0x21E2E40", VA = "0x1821E3A40", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x21E3AD0", Offset = "0x21E2ED0", VA = "0x1821E3AD0", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x21E3C40", Offset = "0x21E3040", VA = "0x1821E3C40", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x21E3B90", Offset = "0x21E2F90", VA = "0x1821E3B90", Slot = "16")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x21E39E0", Offset = "0x21E2DE0", VA = "0x1821E39E0", Slot = "17")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x21E38F0", Offset = "0x21E2CF0", VA = "0x1821E38F0")]
		private int CalcOutput(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x21E3B30", Offset = "0x21E2F30", VA = "0x1821E3B30", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x21E3BF0", Offset = "0x21E2FF0", VA = "0x1821E3BF0", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x21E3DC0", Offset = "0x21E31C0", VA = "0x1821E3DC0", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class SourceNodeBase : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x14C60C0", Offset = "0x14C54C0", VA = "0x1814C60C0")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x21E8C40", Offset = "0x21E8040", VA = "0x1821E8C40")]
		public SourceNodeBase(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x21E8B80", Offset = "0x21E7F80", VA = "0x1821E8B80", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x169A80", Offset = "0x168E80", VA = "0x180169A80", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class SelectorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public enum EvalModes
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			First,
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct SelectorConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public SignalComparisonHelper.ComparerModes CompareMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int CompareValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private EvalModes _evalMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public SelectorConfig[] SelectorConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private InputMetadata[] inputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int lastSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int lastSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private bool modifiedSinceLastEval;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EvalModes EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(EvalModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x21E5C10", Offset = "0x21E5010", VA = "0x1821E5C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x21E5A30", Offset = "0x21E4E30", VA = "0x1821E5A30")]
		public SelectorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x21E5570", Offset = "0x21E4970", VA = "0x1821E5570", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x21E5120", Offset = "0x21E4520", VA = "0x1821E5120", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x63880", Offset = "0x62C80", VA = "0x180063880", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x21E5160", Offset = "0x21E4560", VA = "0x1821E5160", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x21E51B0", Offset = "0x21E45B0", VA = "0x1821E51B0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x21E53A0", Offset = "0x21E47A0", VA = "0x1821E53A0", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x21E5780", Offset = "0x21E4B80", VA = "0x1821E5780", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class SourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x21E8D10", Offset = "0x21E8110", VA = "0x1821E8D10")]
		public SourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x21E8D00", Offset = "0x21E8100", VA = "0x1821E8D00")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x21E3660", Offset = "0x21E2A60", VA = "0x1821E3660")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class ComparerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly InputMetadata[] AdvancedInputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private SignalComparisonHelper.ComparerModes comparerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool advancedMode;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public SignalComparisonHelper.ComparerModes ComparerMode
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(SignalComparisonHelper.ComparerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x14AE280", Offset = "0x14AD680", VA = "0x1814AE280")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1F9750", Offset = "0x1F8B50", VA = "0x1801F9750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x14BFF00", Offset = "0x14BF300", VA = "0x1814BFF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x14BFE80", Offset = "0x14BF280", VA = "0x1814BFE80")]
		public ComparerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x14BF980", Offset = "0x14BED80", VA = "0x1814BF980", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x14BF5E0", Offset = "0x14BE9E0", VA = "0x1814BF5E0")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x14BF680", Offset = "0x14BEA80", VA = "0x1814BF680", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x14BF790", Offset = "0x14BEB90", VA = "0x1814BF790", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x14BF720", Offset = "0x14BEB20", VA = "0x1814BF720", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x14BF8D0", Offset = "0x14BECD0", VA = "0x1814BF8D0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x14BF940", Offset = "0x14BED40", VA = "0x1814BF940", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x14BFAF0", Offset = "0x14BEEF0", VA = "0x1814BFAF0", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class CombinatorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum CombinatorModes
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			Subtract,
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			Multiply,
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			Divide,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			Modulo
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly InputMetadata[] TwoInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly InputMetadata[] ThreeInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly Dictionary<CombinatorModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private CombinatorModes combinatorMode;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public CombinatorModes CombinatorMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(CombinatorModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x14AE280", Offset = "0x14AD680", VA = "0x1814AE280")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x14BEE40", Offset = "0x14BE240", VA = "0x1814BEE40")]
		public static string GetModeSymbol(CombinatorModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x14BF560", Offset = "0x14BE960", VA = "0x1814BF560")]
		public CombinatorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x14BF0F0", Offset = "0x14BE4F0", VA = "0x1814BF0F0", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x14BEC70", Offset = "0x14BE070", VA = "0x1814BEC70")]
		private int CalcOutput()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x14BEDA0", Offset = "0x14BE1A0", VA = "0x1814BEDA0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x14BF010", Offset = "0x14BE410", VA = "0x1814BF010", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x14BEEC0", Offset = "0x14BE2C0", VA = "0x1814BEEC0", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x14ADCD0", Offset = "0x14AD0D0", VA = "0x1814ADCD0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x14ADD30", Offset = "0x14AD130", VA = "0x1814ADD30", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x14BF1D0", Offset = "0x14BE5D0", VA = "0x1814BF1D0", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class DelayNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private struct DelaySignal
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int timeRemaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public int value;
		}

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<DelaySignal> QueuedSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private int lastInputSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x14C1530", Offset = "0x14C0930", VA = "0x1814C1530")]
		public DelayNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x14C0960", Offset = "0x14BFD60", VA = "0x1814C0960", Slot = "18")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x14C0AE0", Offset = "0x14BFEE0", VA = "0x1814C0AE0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x14C0B40", Offset = "0x14BFF40", VA = "0x1814C0B40", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x14C1110", Offset = "0x14C0510", VA = "0x1814C1110", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x14C1320", Offset = "0x14C0720", VA = "0x1814C1320", Slot = "21")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x14C0D90", Offset = "0x14C0190", VA = "0x1814C0D90")]
		private void QueueSignal(int delay, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x14C0BA0", Offset = "0x14BFFA0", VA = "0x1814C0BA0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x14C0EF0", Offset = "0x14C02F0", VA = "0x1814C0EF0", Slot = "14")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x14C0780", Offset = "0x14BFB80", VA = "0x1814C0780", Slot = "15")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class LoopNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal override bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A00", Offset = "0x14C2E00", VA = "0x1814C3A00")]
		public LoopNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x14C3960", Offset = "0x14C2D60", VA = "0x1814C3960", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x14C39B0", Offset = "0x14C2DB0", VA = "0x1814C39B0", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class MomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A80", Offset = "0x14C2E80", VA = "0x1814C3A80")]
		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x14BDD30", Offset = "0x14BD130", VA = "0x1814BDD30")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class ConstantSourceNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x14BFFC0", Offset = "0x14BF3C0", VA = "0x1814BFFC0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x14C0020", Offset = "0x14BF420", VA = "0x1814C0020", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x14C0680", Offset = "0x14BFA80", VA = "0x1814C0680")]
		public ConstantSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x14C0080", Offset = "0x14BF480", VA = "0x1814C0080", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x14C0260", Offset = "0x14BF660", VA = "0x1814C0260", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x14C03E0", Offset = "0x14BF7E0", VA = "0x1814C03E0", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class NodeGraphNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public class GraphInputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x14C3060", Offset = "0x14C2460", VA = "0x1814C3060")]
			public GraphInputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x14BDD10", Offset = "0x14BD110", VA = "0x1814BDD10")]
			public void SetOutputSignal(OutputSlot slot, int val)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public class GraphOutputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x14C32C0", Offset = "0x14C26C0", VA = "0x1814C32C0")]
			public GraphOutputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x14C30E0", Offset = "0x14C24E0", VA = "0x1814C30E0", Slot = "20")]
			protected override void _EvaluateNode(bool isMasterClient)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private GraphInputNode virtualSourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private GraphOutputNode virtualDestNode;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public CircuitNodeGraph InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x169A80", Offset = "0x168E80", VA = "0x180169A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x230B20", Offset = "0x22FF20", VA = "0x180230B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x14C4580", Offset = "0x14C3980", VA = "0x1814C4580")]
		public NodeGraphNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x14C4190", Offset = "0x14C3590", VA = "0x1814C4190", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x14C40B0", Offset = "0x14C34B0", VA = "0x1814C40B0", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x14C3C50", Offset = "0x14C3050", VA = "0x1814C3C50", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x14C3BB0", Offset = "0x14C2FB0", VA = "0x1814C3BB0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x14C3C00", Offset = "0x14C3000", VA = "0x1814C3C00", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct NodeMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public bool NeedsSerialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public InputMetadata[] InputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public string NodeDescription;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct InputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string Description;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct OutputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public OutputSlot OutputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string Description;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class OutputNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public delegate void OutputNodeUpdated(Dictionary<InputSlot, int> slotUpdates);

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int[] lastSignals;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x14C60C0", Offset = "0x14C54C0", VA = "0x1814C60C0")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x14C6140", Offset = "0x14C5540", VA = "0x1814C6140")]
		public OutputNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x14C5BB0", Offset = "0x14C4FB0", VA = "0x1814C5BB0", Slot = "18")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x14C5FB0", Offset = "0x14C53B0", VA = "0x1814C5FB0")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x169A80", Offset = "0x168E80", VA = "0x180169A80", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x14C5F50", Offset = "0x14C5350", VA = "0x1814C5F50", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x14C60D0", Offset = "0x14C54D0", VA = "0x1814C60D0", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x14C5C70", Offset = "0x14C5070", VA = "0x1814C5C70")]
		private void FireEventIfNeeded()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class TimerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public enum TimerModes
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Looping,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Countdown
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public enum TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			Second,
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			TenthOfSecond
		}

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static readonly InputMetadata[] InputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TimerModes timerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int timeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private bool timerExpired;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int _inputTimeTenths;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TimerModes TimerMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(TimerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x14AE280", Offset = "0x14AD680", VA = "0x1814AE280")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private int inputTimeTenths
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E90", Offset = "0x8F7290", VA = "0x1808F7E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x21E9710", Offset = "0x21E8B10", VA = "0x1821E9710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x21E9630", Offset = "0x21E8A30", VA = "0x1821E9630")]
		public TimerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x21E8E10", Offset = "0x21E8210", VA = "0x1821E8E10", Slot = "18")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x21E92C0", Offset = "0x21E86C0", VA = "0x1821E92C0", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x21E93F0", Offset = "0x21E87F0", VA = "0x1821E93F0", Slot = "21")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x21E8EB0", Offset = "0x21E82B0", VA = "0x1821E8EB0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x21E8F50", Offset = "0x21E8350", VA = "0x1821E8F50", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x21E8F10", Offset = "0x21E8310", VA = "0x1821E8F10", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x21E9020", Offset = "0x21E8420", VA = "0x1821E9020")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x21E9230", Offset = "0x21E8630", VA = "0x1821E9230")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x21E9130", Offset = "0x21E8530", VA = "0x1821E9130")]
		private void ResetTimeRemaining()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x21E8FB0", Offset = "0x21E83B0", VA = "0x1821E8FB0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x21E3BF0", Offset = "0x21E2FF0", VA = "0x1821E3BF0", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x21E9330", Offset = "0x21E8730", VA = "0x1821E9330", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x21E91C0", Offset = "0x21E85C0", VA = "0x1821E91C0", Slot = "14")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x21E8D90", Offset = "0x21E8190", VA = "0x1821E8D90", Slot = "15")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class UnityTransformationNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<InputSlot, int> inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private Dictionary<OutputSlot, int> outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Func<Dictionary<InputSlot, int>, Dictionary<OutputSlot, int>> transformationFunction;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x169A80", Offset = "0x168E80", VA = "0x180169A80", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x108A00", Offset = "0x107E00", VA = "0x180108A00", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x21EBAA0", Offset = "0x21EAEA0", VA = "0x1821EBAA0")]
		public UnityTransformationNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x21EB710", Offset = "0x21EAB10", VA = "0x1821EB710", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x21EB5E0", Offset = "0x21EA9E0", VA = "0x1821EB5E0")]
		private void PassthroughValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class WaveNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public enum WaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			Sine,
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			Cosine,
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			Square,
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			Sawtooth
		}

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly InputMetadata[] SecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly InputMetadata[] ThenthOfSecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private WaveMode currentWaveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TimerNode.TimeUnit currentTimeUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private int runningTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private int _inputPeriod;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int inputAmplitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private double functionPeriodInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private double millisecondTimeToAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int loopTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private int relevantDecimalPlaces;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public WaveMode CurrentWaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1547D0", Offset = "0x153BD0", VA = "0x1801547D0")]
			get
			{
				return default(WaveMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x14AE280", Offset = "0x14AD680", VA = "0x1814AE280")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public TimerNode.TimeUnit CurrentTimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x100B2F0", Offset = "0x100A6F0", VA = "0x18100B2F0")]
			get
			{
				return default(TimerNode.TimeUnit);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x21ED7B0", Offset = "0x21ECBB0", VA = "0x1821ED7B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private double InputTimeUnitInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x21ED780", Offset = "0x21ECB80", VA = "0x1821ED780")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private int InputPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x494E00", Offset = "0x494200", VA = "0x180494E00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x21ED7F0", Offset = "0x21ECBF0", VA = "0x1821ED7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x21ED6A0", Offset = "0x21ECAA0", VA = "0x1821ED6A0")]
		public WaveNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x21EC7F0", Offset = "0x21EBBF0", VA = "0x1821EC7F0", Slot = "18")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x21ED130", Offset = "0x21EC530", VA = "0x1821ED130", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x21ED330", Offset = "0x21EC730", VA = "0x1821ED330", Slot = "21")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x21ECB80", Offset = "0x21EBF80", VA = "0x1821ECB80", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x21ECCB0", Offset = "0x21EC0B0", VA = "0x1821ECCB0", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x21ECC20", Offset = "0x21EC020", VA = "0x1821ECC20", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x21ECDB0", Offset = "0x21EC1B0", VA = "0x1821ECDB0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x21ED0F0", Offset = "0x21EC4F0", VA = "0x1821ED0F0")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x21ECEB0", Offset = "0x21EC2B0", VA = "0x1821ECEB0")]
		private void ResetRunningTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x21EC890", Offset = "0x21EBC90", VA = "0x1821EC890")]
		private int EvaluateWaveFunction()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x21ECF80", Offset = "0x21EC380", VA = "0x1821ECF80")]
		private void UpdateCachedFunctionParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x21ECD10", Offset = "0x21EC110", VA = "0x1821ECD10", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x21ECF20", Offset = "0x21EC320", VA = "0x1821ECF20", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x21ED1E0", Offset = "0x21EC5E0", VA = "0x1821ED1E0", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x21ECEC0", Offset = "0x21EC2C0", VA = "0x1821ECEC0", Slot = "14")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x21EC780", Offset = "0x21EBB80", VA = "0x1821EC780", Slot = "15")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class RootNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		internal override bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x21E40C0", Offset = "0x21E34C0", VA = "0x1821E40C0")]
		public RootNode(int nodeId, CircuitNodeGraph graph)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class VirtualNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x70310", Offset = "0x6F710", VA = "0x180070310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x21EC6F0", Offset = "0x21EBAF0", VA = "0x1821EC6F0")]
		protected VirtualNode(string nodeName, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x21EC560", Offset = "0x21EB960", VA = "0x1821EC560", Slot = "18")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x21EC5B0", Offset = "0x21EB9B0", VA = "0x1821EC5B0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x21EC610", Offset = "0x21EBA10", VA = "0x1821EC610", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class Serialization
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x21E82C0", Offset = "0x21E76C0", VA = "0x1821E82C0")]
		public static CircuitNode InstantiateNode(Guid nodeType, int nodeId, Guid graphGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x21E8040", Offset = "0x21E7440", VA = "0x1821E8040")]
		internal static CircuitNode InstantiateNode(CircuitNodeData nodeData, CircuitNodeGraph nodeGraph, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x21E7F00", Offset = "0x21E7300", VA = "0x1821E7F00")]
		public static Guid GetNodeTypeGuid(CircuitNode node)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x21E8460", Offset = "0x21E7860", VA = "0x1821E8460")]
		public static bool TryGetNodeTypeByGuid(Guid guid, out Type t)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public delegate CircuitNode CircuitNodeConstructor(int nodeId, CircuitNodeGraph graph);
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal static class SerializationLookup
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static Guid RECROOM_CIRCUITS_BOOLEANNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static Guid RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static Guid RECROOM_CIRCUITS_GAMESETSTATENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static Guid RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static Guid RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Guid RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static Guid RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private static Guid RECROOM_CIRCUITS_SELECTORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static Guid RECROOM_CIRCUITS_SOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static Guid RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private static Guid RECROOM_CIRCUITS_WAVENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		internal static Dictionary<Type, Guid> TypeToGuidLookup;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		internal static Dictionary<Guid, Type> GuidToTypeLookup;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		internal static Dictionary<Guid, CircuitNodeConstructor> GuidToNodeConstructor;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class SignalComparisonHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum ComparerModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			Equals,
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			NotEquals,
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			GreaterThan,
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			GreaterThanEqualTo,
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			LessThan,
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			LessThanEqualTo
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly Dictionary<ComparerModes, string> ModeSymbols;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x21E8560", Offset = "0x21E7960", VA = "0x1821E8560")]
		public static string GetModeSymbol(ComparerModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x21E8500", Offset = "0x21E7900", VA = "0x1821E8500")]
		internal static bool Compare(ComparerModes comparerMode, int leftSide, int rightSide)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Circuits.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class CircuitLinkDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x14AE9B0", Offset = "0x14ADDB0", VA = "0x1814AE9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x14AE320", Offset = "0x14AD720", VA = "0x1814AE320")]
		static CircuitLinkDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class CircuitLinkData : IMessage<CircuitLinkData>, IMessage, IEquatable<CircuitLinkData>, IDeepCloneable<CircuitLinkData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static readonly MessageParser<CircuitLinkData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int sourceNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int destNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int inputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private int outputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int linkType_;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitLinkData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x14AF180", Offset = "0x14AE580", VA = "0x1814AF180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x14AF0B0", Offset = "0x14AE4B0", VA = "0x1814AF0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x14AF1E0", Offset = "0x14AE5E0", VA = "0x1814AF1E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		[DebuggerNonUserCode]
		public int SourceNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x958E0", Offset = "0x94CE0", VA = "0x1800958E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x959D0", Offset = "0x94DD0", VA = "0x1800959D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		[DebuggerNonUserCode]
		public int DestNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x165C00", Offset = "0x165000", VA = "0x180165C00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x165C10", Offset = "0x165010", VA = "0x180165C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		[DebuggerNonUserCode]
		public int InputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x169A90", Offset = "0x168E90", VA = "0x180169A90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x169AB0", Offset = "0x168EB0", VA = "0x180169AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[DebuggerNonUserCode]
		public int OutputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x26DB30", Offset = "0x26CF30", VA = "0x18026DB30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x3BCAB0", Offset = "0x3BBEB0", VA = "0x1803BCAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[DebuggerNonUserCode]
		public int LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xD6090", Offset = "0xD5490", VA = "0x1800D6090")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x3A7300", Offset = "0x3A6700", VA = "0x1803A7300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		[DebuggerNonUserCode]
		public CircuitLinkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x14AF060", Offset = "0x14AE460", VA = "0x1814AF060")]
		[DebuggerNonUserCode]
		public CircuitLinkData(CircuitLinkData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x14AEB70", Offset = "0x14ADF70", VA = "0x1814AEB70", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitLinkData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x14AEBF0", Offset = "0x14ADFF0", VA = "0x1814AEBF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x14AEC90", Offset = "0x14AE090", VA = "0x1814AEC90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitLinkData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x14AECD0", Offset = "0x14AE0D0", VA = "0x1814AECD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x14AEE40", Offset = "0x14AE240", VA = "0x1814AEE40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x14AEEA0", Offset = "0x14AE2A0", VA = "0x1814AEEA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x14AEA10", Offset = "0x14ADE10", VA = "0x1814AEA10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x14AED80", Offset = "0x14AE180", VA = "0x1814AED80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class CircuitNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x14B19E0", Offset = "0x14B0DE0", VA = "0x1814B19E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x14AFBC0", Offset = "0x14AEFC0", VA = "0x1814AFBC0")]
		static CircuitNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly MessageParser<CircuitNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private string nodeName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int nodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int pairedNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private ByteString nodeType_;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private static readonly FieldCodec<CircuitLinkData> _repeated_circuitLinks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly RepeatedField<CircuitLinkData> circuitLinks_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NodeTransformData transformData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private InternalGraphData internalGraphData_;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly FieldCodec<SlotData> _repeated_slotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly RepeatedField<SlotData> slotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private int mode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private SelectorNodeData selectorNodeData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool advancedMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int timeUnit_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private int roleId_;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x14B2EA0", Offset = "0x14B22A0", VA = "0x1814B2EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x14B2DD0", Offset = "0x14B21D0", VA = "0x1814B2DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x14B2F00", Offset = "0x14B2300", VA = "0x1814B2F00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		[DebuggerNonUserCode]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x64380", Offset = "0x63780", VA = "0x180064380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x14B3000", Offset = "0x14B2400", VA = "0x1814B3000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[DebuggerNonUserCode]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x169A90", Offset = "0x168E90", VA = "0x180169A90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x169AB0", Offset = "0x168EB0", VA = "0x180169AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[DebuggerNonUserCode]
		public int PairedNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x26DB30", Offset = "0x26CF30", VA = "0x18026DB30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x3BCAB0", Offset = "0x3BBEB0", VA = "0x1803BCAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x74990", Offset = "0x73D90", VA = "0x180074990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x14B3060", Offset = "0x14B2460", VA = "0x1814B3060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitLinkData> CircuitLinks
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x958C0", Offset = "0x94CC0", VA = "0x1800958C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[DebuggerNonUserCode]
		public NodeTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x9EFA0", Offset = "0x9E3A0", VA = "0x18009EFA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xB6980", Offset = "0xB5D80", VA = "0x1800B6980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[DebuggerNonUserCode]
		public InternalGraphData InternalGraphData
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xABB30", Offset = "0xAAF30", VA = "0x1800ABB30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0xCC910", Offset = "0xCBD10", VA = "0x1800CC910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> SlotData
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xA05A0", Offset = "0x9F9A0", VA = "0x1800A05A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[DebuggerNonUserCode]
		public int Mode
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xC5F00", Offset = "0xC5300", VA = "0x1800C5F00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xC6600", Offset = "0xC5A00", VA = "0x1800C6600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[DebuggerNonUserCode]
		public SelectorNodeData SelectorNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x6CE80", Offset = "0x6C280", VA = "0x18006CE80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x10B410", Offset = "0x10A810", VA = "0x18010B410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[DebuggerNonUserCode]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xF4E40", Offset = "0xF4240", VA = "0x1800F4E40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xF4E50", Offset = "0xF4250", VA = "0x1800F4E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[DebuggerNonUserCode]
		public int TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x228760", Offset = "0x227B60", VA = "0x180228760")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x54FB10", Offset = "0x54EF10", VA = "0x18054FB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[DebuggerNonUserCode]
		public int RoleId
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x3D64E0", Offset = "0x3D58E0", VA = "0x1803D64E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x40BDC0", Offset = "0x40B1C0", VA = "0x18040BDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x14B2D10", Offset = "0x14B2110", VA = "0x1814B2D10")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x14B2BF0", Offset = "0x14B1FF0", VA = "0x1814B2BF0")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x14B1D80", Offset = "0x14B1180", VA = "0x1814B1D80", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x14B2050", Offset = "0x14B1450", VA = "0x1814B2050", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x14B1EC0", Offset = "0x14B12C0", VA = "0x1814B1EC0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x14B2230", Offset = "0x14B1630", VA = "0x1814B2230", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x14B26F0", Offset = "0x14B1AF0", VA = "0x1814B26F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x14B2750", Offset = "0x14B1B50", VA = "0x1814B2750", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x14B1A40", Offset = "0x14B0E40", VA = "0x1814B1A40", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x14B2400", Offset = "0x14B1800", VA = "0x1814B2400", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class SelectorNodeData : IMessage<SelectorNodeData>, IMessage, IEquatable<SelectorNodeData>, IDeepCloneable<SelectorNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly MessageParser<SelectorNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private int evalMode_;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly FieldCodec<SelectorConfigData> _repeated_selectorConfigData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private readonly RepeatedField<SelectorConfigData> selectorConfigData_;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x21E5000", Offset = "0x21E4400", VA = "0x1821E5000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x21E4F80", Offset = "0x21E4380", VA = "0x1821E4F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x21E5060", Offset = "0x21E4460", VA = "0x1821E5060", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		public int EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x958E0", Offset = "0x94CE0", VA = "0x1800958E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x959D0", Offset = "0x94DD0", VA = "0x1800959D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		public RepeatedField<SelectorConfigData> SelectorConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x64390", Offset = "0x63790", VA = "0x180064390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x21E4E60", Offset = "0x21E4260", VA = "0x1821E4E60")]
		[DebuggerNonUserCode]
		public SelectorNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x21E4EC0", Offset = "0x21E42C0", VA = "0x1821E4EC0")]
		[DebuggerNonUserCode]
		public SelectorNodeData(SelectorNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x21E4850", Offset = "0x21E3C50", VA = "0x1821E4850", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x21E49B0", Offset = "0x21E3DB0", VA = "0x1821E49B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x21E4930", Offset = "0x21E3D30", VA = "0x1821E4930", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x21E4A80", Offset = "0x21E3E80", VA = "0x1821E4A80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x21E4BD0", Offset = "0x21E3FD0", VA = "0x1821E4BD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x21E4C30", Offset = "0x21E4030", VA = "0x1821E4C30", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x21E4780", Offset = "0x21E3B80", VA = "0x1821E4780", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x21E4AF0", Offset = "0x21E3EF0", VA = "0x1821E4AF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class InternalGraphData : IMessage<InternalGraphData>, IMessage, IEquatable<InternalGraphData>, IDeepCloneable<InternalGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly MessageParser<InternalGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int inputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int outputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private CircuitNodeGraphData internalNodeGraph_;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		public static MessageParser<InternalGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x21E2190", Offset = "0x21E1590", VA = "0x1821E2190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x21E2110", Offset = "0x21E1510", VA = "0x1821E2110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x21E21F0", Offset = "0x21E15F0", VA = "0x1821E21F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[DebuggerNonUserCode]
		public int InputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x958E0", Offset = "0x94CE0", VA = "0x1800958E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x959D0", Offset = "0x94DD0", VA = "0x1800959D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public int OutputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x165C00", Offset = "0x165000", VA = "0x180165C00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x165C10", Offset = "0x165010", VA = "0x180165C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x64390", Offset = "0x63790", VA = "0x180064390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x643C0", Offset = "0x637C0", VA = "0x1800643C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		[DebuggerNonUserCode]
		public InternalGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x21E20B0", Offset = "0x21E14B0", VA = "0x1821E20B0")]
		[DebuggerNonUserCode]
		public InternalGraphData(InternalGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x21E1BF0", Offset = "0x21E0FF0", VA = "0x1821E1BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public InternalGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x21E1CD0", Offset = "0x21E10D0", VA = "0x1821E1CD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x21E1C80", Offset = "0x21E1080", VA = "0x1821E1C80", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InternalGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x21E1D70", Offset = "0x21E1170", VA = "0x1821E1D70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x21E1EE0", Offset = "0x21E12E0", VA = "0x1821E1EE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x21E1F40", Offset = "0x21E1340", VA = "0x1821E1F40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x21E1AF0", Offset = "0x21E0EF0", VA = "0x1821E1AF0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x21E1E00", Offset = "0x21E1200", VA = "0x1821E1E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class CircuitNodeGraphData : IMessage<CircuitNodeGraphData>, IMessage, IEquatable<CircuitNodeGraphData>, IDeepCloneable<CircuitNodeGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static readonly MessageParser<CircuitNodeGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private ByteString nodeGraphGuid_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private bool isInternalGraph_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private CircuitNodeData rootNodeData_;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly FieldCodec<CircuitNodeData> _repeated_circuitNodes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly RepeatedField<CircuitNodeData> circuitNodes_;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x14B45A0", Offset = "0x14B39A0", VA = "0x1814B45A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x14B44D0", Offset = "0x14B38D0", VA = "0x1814B44D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x14B4600", Offset = "0x14B3A00", VA = "0x1814B4600", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[DebuggerNonUserCode]
		public ByteString NodeGraphGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x64380", Offset = "0x63780", VA = "0x180064380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x14B4710", Offset = "0x14B3B10", VA = "0x1814B4710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public bool IsInternalGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x1597D0", Offset = "0x158BD0", VA = "0x1801597D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1D6850", Offset = "0x1D5C50", VA = "0x1801D6850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public CircuitNodeData RootNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x74990", Offset = "0x73D90", VA = "0x180074990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x97C20", Offset = "0x97020", VA = "0x180097C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> CircuitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x958C0", Offset = "0x94CC0", VA = "0x1800958C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x14B4440", Offset = "0x14B3840", VA = "0x1814B4440")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x14B4280", Offset = "0x14B3680", VA = "0x1814B4280")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData(CircuitNodeGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x14B3B00", Offset = "0x14B2F00", VA = "0x1814B3B00", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x14B3B60", Offset = "0x14B2F60", VA = "0x1814B3B60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x14B3C90", Offset = "0x14B3090", VA = "0x1814B3C90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x14B3D80", Offset = "0x14B3180", VA = "0x1814B3D80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x14B3F90", Offset = "0x14B3390", VA = "0x1814B3F90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x14B3FF0", Offset = "0x14B33F0", VA = "0x1814B3FF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x14B39E0", Offset = "0x14B2DE0", VA = "0x1814B39E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x14B3E30", Offset = "0x14B3230", VA = "0x1814B3E30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class CircuitNodeGraphCollectionData : IMessage<CircuitNodeGraphCollectionData>, IMessage, IEquatable<CircuitNodeGraphCollectionData>, IDeepCloneable<CircuitNodeGraphCollectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly MessageParser<CircuitNodeGraphCollectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly FieldCodec<CircuitNodeGraphData> _repeated_graphs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly RepeatedField<CircuitNodeGraphData> graphs_;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphCollectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x14B3870", Offset = "0x14B2C70", VA = "0x1814B3870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x14B37A0", Offset = "0x14B2BA0", VA = "0x1814B37A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x14B38D0", Offset = "0x14B2CD0", VA = "0x1814B38D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeGraphData> Graphs
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x64380", Offset = "0x63780", VA = "0x180064380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x14B3740", Offset = "0x14B2B40", VA = "0x1814B3740")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x14B3690", Offset = "0x14B2A90", VA = "0x1814B3690")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData(CircuitNodeGraphCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x14B3140", Offset = "0x14B2540", VA = "0x1814B3140", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x14B32A0", Offset = "0x14B26A0", VA = "0x1814B32A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x14B3220", Offset = "0x14B2620", VA = "0x1814B3220", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x982D0", Offset = "0x976D0", VA = "0x1800982D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x14B3430", Offset = "0x14B2830", VA = "0x1814B3430", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x14B3490", Offset = "0x14B2890", VA = "0x1814B3490", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x14B30C0", Offset = "0x14B24C0", VA = "0x1814B30C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x14B3370", Offset = "0x14B2770", VA = "0x1814B3370", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class SlotData : IMessage<SlotData>, IMessage, IEquatable<SlotData>, IDeepCloneable<SlotData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly MessageParser<SlotData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private int slot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private int signal_;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public static MessageParser<SlotData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x21E8A60", Offset = "0x21E7E60", VA = "0x1821E8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x21E89E0", Offset = "0x21E7DE0", VA = "0x1821E89E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x21E8AC0", Offset = "0x21E7EC0", VA = "0x1821E8AC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x958E0", Offset = "0x94CE0", VA = "0x1800958E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x959D0", Offset = "0x94DD0", VA = "0x1800959D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public int Signal
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x165C00", Offset = "0x165000", VA = "0x180165C00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x165C10", Offset = "0x165010", VA = "0x180165C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		[DebuggerNonUserCode]
		public SlotData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x883A40", Offset = "0x882E40", VA = "0x180883A40")]
		[DebuggerNonUserCode]
		public SlotData(SlotData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x21E87B0", Offset = "0x21E7BB0", VA = "0x1821E87B0", Slot = "9")]
		[DebuggerNonUserCode]
		public SlotData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x21E8820", Offset = "0x21E7C20", VA = "0x1821E8820", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x883680", Offset = "0x882A80", VA = "0x180883680", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SlotData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x21E4450", Offset = "0x21E3850", VA = "0x1821E4450", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x21E88B0", Offset = "0x21E7CB0", VA = "0x1821E88B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x883940", Offset = "0x882D40", VA = "0x180883940", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x21E86F0", Offset = "0x21E7AF0", VA = "0x1821E86F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x883830", Offset = "0x882C30", VA = "0x180883830", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class SelectorConfigData : IMessage<SelectorConfigData>, IMessage, IEquatable<SelectorConfigData>, IDeepCloneable<SelectorConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly MessageParser<SelectorConfigData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private int compareMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int compareValue_;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorConfigData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x21E4660", Offset = "0x21E3A60", VA = "0x1821E4660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x21E45E0", Offset = "0x21E39E0", VA = "0x1821E45E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x21E46C0", Offset = "0x21E3AC0", VA = "0x1821E46C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public int CompareMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x958E0", Offset = "0x94CE0", VA = "0x1800958E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x959D0", Offset = "0x94DD0", VA = "0x1800959D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public int CompareValue
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x165C00", Offset = "0x165000", VA = "0x180165C00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x165C10", Offset = "0x165010", VA = "0x180165C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		[DebuggerNonUserCode]
		public SelectorConfigData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x883A40", Offset = "0x882E40", VA = "0x180883A40")]
		[DebuggerNonUserCode]
		public SelectorConfigData(SelectorConfigData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x21E4350", Offset = "0x21E3750", VA = "0x1821E4350", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorConfigData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x21E43C0", Offset = "0x21E37C0", VA = "0x1821E43C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x883680", Offset = "0x882A80", VA = "0x180883680", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorConfigData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x21E4450", Offset = "0x21E3850", VA = "0x1821E4450", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x21E44B0", Offset = "0x21E38B0", VA = "0x1821E44B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x883940", Offset = "0x882D40", VA = "0x180883940", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x21E4290", Offset = "0x21E3690", VA = "0x1821E4290", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x883830", Offset = "0x882C30", VA = "0x180883830", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class NodeTransformDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x21E2AD0", Offset = "0x21E1ED0", VA = "0x1821E2AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x21E2480", Offset = "0x21E1880", VA = "0x1821E2480")]
		static NodeTransformDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class NodeTransformData : IMessage<NodeTransformData>, IMessage, IEquatable<NodeTransformData>, IDeepCloneable<NodeTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly MessageParser<NodeTransformData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Vector3Data position_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Vector3Data rotation_;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public static MessageParser<NodeTransformData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x21E30B0", Offset = "0x21E24B0", VA = "0x1821E30B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x21E2FE0", Offset = "0x21E23E0", VA = "0x1821E2FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x21E3110", Offset = "0x21E2510", VA = "0x1821E3110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public Vector3Data Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x64380", Offset = "0x63780", VA = "0x180064380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x643B0", Offset = "0x637B0", VA = "0x1800643B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public Vector3Data Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x64390", Offset = "0x63790", VA = "0x180064390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x643C0", Offset = "0x637C0", VA = "0x1800643C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		[DebuggerNonUserCode]
		public NodeTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x21E2F70", Offset = "0x21E2370", VA = "0x1821E2F70")]
		[DebuggerNonUserCode]
		public NodeTransformData(NodeTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x21E2BF0", Offset = "0x21E1FF0", VA = "0x1821E2BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x21E2C90", Offset = "0x21E2090", VA = "0x1821E2C90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x168EC10", Offset = "0x168E010", VA = "0x18168EC10", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x168ED20", Offset = "0x168E120", VA = "0x18168ED20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x21E2E40", Offset = "0x21E2240", VA = "0x1821E2E40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x168F0E0", Offset = "0x168E4E0", VA = "0x18168F0E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x21E2B30", Offset = "0x21E1F30", VA = "0x1821E2B30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x21E2D40", Offset = "0x21E2140", VA = "0x1821E2D40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class Vector3DataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x21EC000", Offset = "0x21EB400", VA = "0x1821EC000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x21EBC30", Offset = "0x21EB030", VA = "0x1821EBC30")]
		static Vector3DataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly MessageParser<Vector3Data> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private float x_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private float y_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x21EC400", Offset = "0x21EB800", VA = "0x1821EC400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x21EC330", Offset = "0x21EB730", VA = "0x1821EC330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x21EC460", Offset = "0x21EB860", VA = "0x1821EC460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xA1BC0", Offset = "0xA0FC0", VA = "0x1800A1BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xA1BF0", Offset = "0xA0FF0", VA = "0x1800A1BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xA1BD0", Offset = "0xA0FD0", VA = "0x1800A1BD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xA1C00", Offset = "0xA1000", VA = "0x1800A1C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA1BE0", Offset = "0xA0FE0", VA = "0x1800A1BE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C10", Offset = "0xA1010", VA = "0x1800A1C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x64280", Offset = "0x63680", VA = "0x180064280")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA1A40", Offset = "0xA0E40", VA = "0x1800A1A40")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x21EC060", Offset = "0x21EB460", VA = "0x1821EC060", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x21EC0D0", Offset = "0x21EB4D0", VA = "0x1821EC0D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA1590", Offset = "0xA0990", VA = "0x1800A1590", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x21EC160", Offset = "0x21EB560", VA = "0x1821EC160", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x21EC200", Offset = "0x21EB600", VA = "0x1821EC200", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA18F0", Offset = "0xA0CF0", VA = "0x1800A18F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA1450", Offset = "0xA0850", VA = "0x1800A1450", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA1780", Offset = "0xA0B80", VA = "0x1800A1780", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
namespace RecRoom.Circuits.PlayerStats
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum CircuitPlayerStat
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		Player_Health = 0,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		PlayerStat_1 = 1000,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		PlayerStat_2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		PlayerStat_3 = 1002,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		PlayerStat_4 = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		PlayerStat_5 = 1004,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		PlayerStat_6 = 1005
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class FriendlyCircuitPlayerStats
	{
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static Dictionary<string, int> friendlyCircuitPlayerStatsDict;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public static Dictionary<string, int> FriendlyCircuitPlayerStatsDict
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x14C18D0", Offset = "0x14C0CD0", VA = "0x1814C18D0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class PlayerGetStatNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate int GetPlayerStatFunction(CircuitPlayerStat stat, int playerId);

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private int masterLastPlayerStatSignal;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x117490", Offset = "0x116890", VA = "0x180117490")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x14C6AA0", Offset = "0x14C5EA0", VA = "0x1814C6AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event GetPlayerStatFunction GetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x14C6940", Offset = "0x14C5D40", VA = "0x1814C6940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x14C69F0", Offset = "0x14C5DF0", VA = "0x1814C69F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x14C68C0", Offset = "0x14C5CC0", VA = "0x1814C68C0")]
		public PlayerGetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x14C66C0", Offset = "0x14C5AC0", VA = "0x1814C66C0", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x14C64E0", Offset = "0x14C58E0", VA = "0x1814C64E0")]
		private int GetStatSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x14C6610", Offset = "0x14C5A10", VA = "0x1814C6610", Slot = "16")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x14C62E0", Offset = "0x14C56E0", VA = "0x1814C62E0", Slot = "17")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x14C6360", Offset = "0x14C5760", VA = "0x1814C6360", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x14C6480", Offset = "0x14C5880", VA = "0x1814C6480", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x14C63C0", Offset = "0x14C57C0", VA = "0x1814C63C0", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x14C65B0", Offset = "0x14C59B0", VA = "0x1814C65B0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x14C6690", Offset = "0x14C5A90", VA = "0x1814C6690", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x14C6700", Offset = "0x14C5B00", VA = "0x1814C6700", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class PlayerSetStatNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate void SetPlayerStatFunction(CircuitPlayerStat stat, int playerId, int signal);

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x117490", Offset = "0x116890", VA = "0x180117490")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x14C6AA0", Offset = "0x14C5EA0", VA = "0x1814C6AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event SetPlayerStatFunction SetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x14C8A40", Offset = "0x14C7E40", VA = "0x1814C8A40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x14C8AF0", Offset = "0x14C7EF0", VA = "0x1814C8AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x14C89E0", Offset = "0x14C7DE0", VA = "0x1814C89E0")]
		public PlayerSetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x14C86B0", Offset = "0x14C7AB0", VA = "0x1814C86B0", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x14C8690", Offset = "0x14C7A90", VA = "0x1814C8690")]
		private void PostEvalSetPlayerStat(CircuitPlayerStat stat, int playerId, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x14C8530", Offset = "0x14C7930", VA = "0x1814C8530", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x14C8650", Offset = "0x14C7A50", VA = "0x1814C8650", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x14C8590", Offset = "0x14C7990", VA = "0x1814C8590", Slot = "11")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x14C65B0", Offset = "0x14C59B0", VA = "0x1814C65B0", Slot = "13")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x14C6690", Offset = "0x14C5A90", VA = "0x1814C6690", Slot = "12")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x14C8820", Offset = "0x14C7C20", VA = "0x1814C8820", Slot = "22")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
}
namespace RecRoom.Circuits.GameStats
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class GameGetScoreNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public delegate int GetTeamScoreFunction(int teamId);

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private int masterLastScoreSignal;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event GetTeamScoreFunction GetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x14C1F60", Offset = "0x14C1360", VA = "0x1814C1F60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x14C2010", Offset = "0x14C1410", VA = "0x1814C2010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x14C1EE0", Offset = "0x14C12E0", VA = "0x1814C1EE0")]
		public GameGetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x14C1D90", Offset = "0x14C1190", VA = "0x1814C1D90", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x14C1C40", Offset = "0x14C1040", VA = "0x1814C1C40")]
		private int GetScoreSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x14C1D10", Offset = "0x14C1110", VA = "0x1814C1D10", Slot = "16")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x14C1B00", Offset = "0x14C0F00", VA = "0x1814C1B00", Slot = "17")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x14C1B80", Offset = "0x14C0F80", VA = "0x1814C1B80", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x14C1BE0", Offset = "0x14C0FE0", VA = "0x1814C1BE0", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[Cpp2IlInjected.Attribute(Name = "CircuitNodeUuidAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class GameSetScoreNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate void SetTeamScoreFunction(int teamId, int signal);

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event SetTeamScoreFunction SetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x14C2450", Offset = "0x14C1850", VA = "0x1814C2450")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x14C2500", Offset = "0x14C1900", VA = "0x1814C2500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x14C23F0", Offset = "0x14C17F0", VA = "0x1814C23F0")]
		public GameSetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x14C2180", Offset = "0x14C1580", VA = "0x1814C2180", Slot = "20")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x14C2160", Offset = "0x14C1560", VA = "0x1814C2160")]
		private void PostEvalSetPlayerStat(int teamId, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x14C20C0", Offset = "0x14C14C0", VA = "0x1814C20C0", Slot = "9")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x14C2120", Offset = "0x14C1520", VA = "0x1814C2120", Slot = "10")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
}
namespace RecRoom.Circuits.Traversal
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[Flags]
	public enum DFSType
	{
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		DirectedForward = 1,
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		DirectedBackward = 2,
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		Undirected = 3
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Flags]
	public enum LinkTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		NormalToNormal = 1,
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		NormalToVirtual = 2,
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		VirtualToNormal = 4,
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		RootToVirtual = 8,
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		RootToNormal = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	internal struct TopologicStackEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public CircuitNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public bool IsParent;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public static class GraphTraversal
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x21E1050", Offset = "0x21E0450", VA = "0x1821E1050")]
		public static HashSet<CircuitNode> DFSCopy(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x21E1130", Offset = "0x21E0530", VA = "0x1821E1130")]
		public static IEnumerable<CircuitNode> DFS(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x21E1530", Offset = "0x21E0930", VA = "0x1821E1530")]
		public static List<CircuitNode> TopologicSort(CircuitNode root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x21E1500", Offset = "0x21E0900", VA = "0x1821E1500")]
		private static bool ShouldFollowLink(CircuitLink link, LinkTypes linkTypesToFollow)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x21E11D0", Offset = "0x21E05D0", VA = "0x1821E11D0")]
		public static LinkTypes FindLinkType(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(LinkTypes);
		}
	}
}
namespace RecRoom.Circuits.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public static class ByteStringExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x21E0730", Offset = "0x21DFB30", VA = "0x1821E0730")]
		public static Guid ToGuid(this ByteString bytes)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x21E06C0", Offset = "0x21DFAC0", VA = "0x1821E06C0")]
		public static ByteString ToByteString(this Guid guid)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum CircuitLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		Error
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public static class CircuitDebug
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public delegate void LogEvent(CircuitLogLevel level, string message);

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public delegate void LogExceptionEvent(Exception e, string message);

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event LogEvent OnLogEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x21E0C00", Offset = "0x21E0000", VA = "0x1821E0C00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x21E0E00", Offset = "0x21E0200", VA = "0x1821E0E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event LogExceptionEvent OnLogExceptionEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x21E0D00", Offset = "0x21E0100", VA = "0x1821E0D00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x21E0F00", Offset = "0x21E0300", VA = "0x1821E0F00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x21E08C0", Offset = "0x21DFCC0", VA = "0x1821E08C0")]
		public static void LogException(Exception e, [Optional] string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x21E0990", Offset = "0x21DFD90", VA = "0x1821E0990")]
		public static void Log(CircuitLogLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x21E0B50", Offset = "0x21DFF50", VA = "0x1821E0B50")]
		public static void NodeLog(int nodeId, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x21E0A60", Offset = "0x21DFE60", VA = "0x1821E0A60")]
		public static void NodeLogFormat(int nodeId, CircuitLogLevel CircuitLogLevel, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x21E0810", Offset = "0x21DFC10", VA = "0x1821E0810")]
		public static void GraphLog(Guid graphGuid, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	internal static class NodeEventUtil
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x21E23F0", Offset = "0x21E17F0", VA = "0x1821E23F0")]
		internal static void SafeInvoke(this CircuitNode.NodeLifecycleEvent nodeLifecycleEvent, CircuitNode nodeArg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x21E2340", Offset = "0x21E1740", VA = "0x1821E2340")]
		internal static void SafeInvoke(this CircuitNode.NodeConnectionChanged nodeConnectionEvent, CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	internal static class RuntimeAssert
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x21E4220", Offset = "0x21E3620", VA = "0x1821E4220")]
		public static void Assert(bool condition, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x21E4190", Offset = "0x21E3590", VA = "0x1821E4190")]
		public static void AssertFormat(bool condition, string format, params object[] args)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
