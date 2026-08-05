using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using RecRoom.Circuits.Protobuf;
using RecRoom.Circuits.Traversal;
using RecRoom.Networking;

[assembly: AssemblyVersion("1.0.0.0")]
namespace RecRoom.Circuits
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CircuitLink
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly LinkTypes LinkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly CircuitNode SourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly CircuitNode DestNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly OutputSlot OutputSlot;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IEnumerable<CircuitNode> TrueDests
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x171C440", Offset = "0x171AE40", VA = "0x18171C440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x171C390", Offset = "0x171AD90", VA = "0x18171C390")]
		public CircuitLink(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x171C0A0", Offset = "0x171AAA0", VA = "0x18171C0A0")]
		public CircuitLinkData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x171BEA0", Offset = "0x171A8A0", VA = "0x18171BEA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x171BFF0", Offset = "0x171A9F0", VA = "0x18171BFF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x171C150", Offset = "0x171AB50", VA = "0x18171C150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class CircuitNodeUuidAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Guid Id;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool InternalOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x361360", Offset = "0x35FD60", VA = "0x180361360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1721610", Offset = "0x1720010", VA = "0x181721610")]
		public CircuitNodeUuidAttribute(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x17215A0", Offset = "0x171FFA0", VA = "0x1817215A0")]
		public static CircuitNodeUuidAttribute GetFromType(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class EqualityComparers
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static InputSlotComparer InputSlotComparer;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static OutputSlotComparer OutputSlotComparer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class InputSlotComparer : IEqualityComparer<InputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x172BA80", Offset = "0x172A480", VA = "0x18172BA80", Slot = "4")]
		public bool Equals(InputSlot x, InputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x172BAA0", Offset = "0x172A4A0", VA = "0x18172BAA0", Slot = "5")]
		public int GetHashCode(InputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		public InputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class OutputSlotComparer : IEqualityComparer<OutputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x172BA80", Offset = "0x172A480", VA = "0x18172BA80", Slot = "4")]
		public bool Equals(OutputSlot x, OutputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x172BAA0", Offset = "0x172A4A0", VA = "0x18172BAA0", Slot = "5")]
		public int GetHashCode(OutputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		public OutputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate void NodeLifecycleEvent(CircuitNode node);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct OutputSignal
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public bool IsMomentary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int LastSignalTimeStamp;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate void NodeMetadataChanged(NodeMetadata newNodeMetadata);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public delegate void ThisNodeConnectionChanged(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot);

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate void NodeConnectionChanged(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot);

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public const int NULL_CIRCUIT_NODE_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static long globalMaxCircuitNodeId;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static object circuitIdLockObj;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static NodeLifecycleEvent OnNodeDestroyedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static NodeLifecycleEvent OnNodeInstantiatedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const int ON_TRUE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int OFF_FALSE = 0;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string DEFAULT_VALUE_ARG = "default";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int ExecutionOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private OutputSignal[] OutputSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private OutputSignal[] outputValuesDeserializationBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<InputSlot, int> defaultInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public Dictionary<InputSlot, CircuitLink> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Dictionary<OutputSlot, HashSet<CircuitLink>> Outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NodeMetadataChanged NodeMetadataChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CircuitNodeGraph _nodeGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ThisNodeConnectionChanged OnConnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static NodeConnectionChanged OnNodesConnectedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ThisNodeConnectionChanged OnDisconnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static NodeConnectionChanged OnNodesDisconnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static Dictionary<int, CircuitNode> AllNodes;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static InputMetadata[] allSlotsInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static OutputMetadata[] allSlotsOutputMetadata;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x30EA60", Offset = "0x30D460", VA = "0x18030EA60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal virtual bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x30EA60", Offset = "0x30D460", VA = "0x18030EA60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal virtual bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x30EA60", Offset = "0x30D460", VA = "0x18030EA60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal virtual bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x30EA60", Offset = "0x30D460", VA = "0x18030EA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal virtual bool RequiresConnectionToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x17273D0", Offset = "0x1725DD0", VA = "0x1817273D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal virtual bool IsConnectedToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x17272B0", Offset = "0x1725CB0", VA = "0x1817272B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		internal virtual bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x30EA60", Offset = "0x30D460", VA = "0x18030EA60", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CircuitNode PairedNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3059E0", Offset = "0x3043E0", VA = "0x1803059E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HasConnectedInputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1727150", Offset = "0x1725B50", VA = "0x181727150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal bool UsesAnyDefaultInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1727580", Offset = "0x1725F80", VA = "0x181727580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HasConnectedOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1727260", Offset = "0x1725C60", VA = "0x181727260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x33A080", Offset = "0x338A80", VA = "0x18033A080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public virtual int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83B870", Offset = "0x83A270", VA = "0x18083B870", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1727520", Offset = "0x1725F20", VA = "0x181727520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NodeMetadata NodeMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x17273B0", Offset = "0x1725DB0", VA = "0x1817273B0")]
			[CompilerGenerated]
			get
			{
				return default(NodeMetadata);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x17277F0", Offset = "0x17261F0", VA = "0x1817277F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public CircuitNodeGraph NodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x48F6E0", Offset = "0x48E0E0", VA = "0x18048F6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA40", Offset = "0x3DC440", VA = "0x1803DDA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3DDB30", Offset = "0x3DC530", VA = "0x1803DDB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static int NodeCount
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1727340", Offset = "0x1725D40", VA = "0x181727340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static InputMetadata[] AllSlotsInputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1726DC0", Offset = "0x17257C0", VA = "0x181726DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static OutputMetadata[] AllSlotsOutputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1726F80", Offset = "0x1725980", VA = "0x181726F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NodeModifiedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1726D20", Offset = "0x1725720", VA = "0x181726D20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1727750", Offset = "0x1726150", VA = "0x181727750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NodeDeserializedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1726C80", Offset = "0x1725680", VA = "0x181726C80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x17276B0", Offset = "0x17260B0", VA = "0x1817276B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1724BE0", Offset = "0x17235E0", VA = "0x181724BE0")]
		public static int NewNodeId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1726620", Offset = "0x1725020", VA = "0x181726620")]
		internal static int SetPossibleMaxId(int newPossibleMax)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1725210", Offset = "0x1723C10", VA = "0x181725210")]
		public static void ResetMaxNodeId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1724620", Offset = "0x1723020", VA = "0x181724620")]
		public static long GetMaxNodeId()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1724D10", Offset = "0x1723710", VA = "0x181724D10")]
		internal static void OverrideMaxNodeId(long overrideValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1725310", Offset = "0x1723D10", VA = "0x181725310")]
		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1725380", Offset = "0x1723D80", VA = "0x181725380")]
		private static void SendNodeInstantiatedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract InputMetadata[] GetInputMetadata();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract OutputMetadata[] GetOutputMetadata();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10", Slot = "15")]
		protected virtual string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x17269F0", Offset = "0x17253F0", VA = "0x1817269F0")]
		public CircuitNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1724E30", Offset = "0x1723830", VA = "0x181724E30")]
		protected void ReconstructNodeMetadata()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1725890", Offset = "0x1724290", VA = "0x181725890", Slot = "16")]
		public virtual CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x17247E0", Offset = "0x17231E0", VA = "0x1817247E0", Slot = "17")]
		internal virtual void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1722AC0", Offset = "0x17214C0", VA = "0x181722AC0")]
		public void CopySettings(CircuitNodeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1722B50", Offset = "0x1721550", VA = "0x181722B50")]
		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1725880", Offset = "0x1724280", VA = "0x181725880", Slot = "18")]
		internal virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1723590", Offset = "0x1721F90", VA = "0x181723590", Slot = "19")]
		internal virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "20")]
		internal virtual void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "21")]
		internal virtual void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1725690", Offset = "0x1724090", VA = "0x181725690")]
		private void SerializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1723360", Offset = "0x1721D60", VA = "0x181723360")]
		private void DeserializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1726340", Offset = "0x1724D40", VA = "0x181726340")]
		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x17222F0", Offset = "0x1720CF0", VA = "0x1817222F0")]
		internal static bool ConnectNodes(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x17253F0", Offset = "0x1723DF0", VA = "0x1817253F0")]
		private static void SendNodesConnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1725540", Offset = "0x1723F40", VA = "0x181725540")]
		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1721660", Offset = "0x1720060", VA = "0x181721660")]
		private static void AddLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1724420", Offset = "0x1722E20", VA = "0x181724420")]
		internal static bool FormsLoop(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1722950", Offset = "0x1721350", VA = "0x181722950")]
		public bool ConnectToMyInput(CircuitNode sourceNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1721750", Offset = "0x1720150", VA = "0x181721750")]
		protected bool CanConnectInput(CircuitNode newSourceNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1722A10", Offset = "0x1721410", VA = "0x181722A10")]
		public bool ConnectToMyOutput(CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1721820", Offset = "0x1720220", VA = "0x181721820")]
		protected bool CanConnectOutput(InputSlot inputSlot, OutputSlot outputSlot, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x17267B0", Offset = "0x17251B0", VA = "0x1817267B0")]
		protected bool SlotsCanConnect(InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1723960", Offset = "0x1722360", VA = "0x181723960")]
		public void DisconnectInput(InputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x17235A0", Offset = "0x1721FA0", VA = "0x1817235A0", Slot = "22")]
		public virtual void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1724140", Offset = "0x1722B40", VA = "0x181724140")]
		public void DisconnectOutput(OutputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1723A00", Offset = "0x1722400", VA = "0x181723A00")]
		protected static void DisconnectNodeLink(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1724F80", Offset = "0x1723980", VA = "0x181724F80")]
		private static void RemoveLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1725090", Offset = "0x1723A90", VA = "0x181725090")]
		private static bool RemoveOutputLink(CircuitNode node, CircuitLink link)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1724EC0", Offset = "0x17238C0", VA = "0x181724EC0")]
		private static bool RemoveInputSlot(CircuitNode node, InputSlot inputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1721C10", Offset = "0x1720610", VA = "0x181721C10")]
		private static bool CheckForDisconnectedGraph(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x17242D0", Offset = "0x1722CD0", VA = "0x1817242D0")]
		internal void EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "23")]
		internal virtual void PostEvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1724780", Offset = "0x1723180", VA = "0x181724780")]
		public bool HasMomentaryOutputs()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1722150", Offset = "0x1720B50", VA = "0x181722150")]
		public void ClearMomentaryOutputs(int currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "24")]
		protected virtual void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x17268D0", Offset = "0x17252D0", VA = "0x1817268D0", Slot = "25")]
		protected virtual void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1722240", Offset = "0x1720C40", VA = "0x181722240")]
		protected void ClearOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1724500", Offset = "0x1722F00", VA = "0x181724500")]
		public int GetInputSignal(InputSlot inputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x17245E0", Offset = "0x1722FE0", VA = "0x1817245E0")]
		public int GetLastOutputSignalTimeStamp(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1724740", Offset = "0x1723140", VA = "0x181724740")]
		public int GetOutputSignal(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1726300", Offset = "0x1724D00", VA = "0x181726300")]
		protected void SetContinuousOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1726320", Offset = "0x1724D20", VA = "0x181726320")]
		protected void SetMomentaryOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x17264F0", Offset = "0x1724EF0", VA = "0x1817264F0")]
		private void SetOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1721A20", Offset = "0x1720420", VA = "0x181721A20")]
		private void ChangeDefaultInputValue(SlotData slotData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1724B90", Offset = "0x1723590", VA = "0x181724B90")]
		public void ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3C02F0", Offset = "0x3BECF0", VA = "0x1803C02F0")]
		public void SendDeserializedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x17267D0", Offset = "0x17251D0", VA = "0x1817267D0", Slot = "26")]
		protected virtual void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1721F80", Offset = "0x1720980", VA = "0x181721F80")]
		internal static void ClearAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1724390", Offset = "0x1722D90", VA = "0x181724390")]
		public static CircuitNode Find(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x11410F0", Offset = "0x113FAF0", VA = "0x1811410F0")]
		public static int BoolToSignal(bool value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1686840", Offset = "0x1685240", VA = "0x181686840")]
		public static bool SignalToBool(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1721F00", Offset = "0x1720900", VA = "0x181721F00")]
		public static int ClampSignal(int value, int min, int max)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class DictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC9B530", Offset = "0xC99F30", VA = "0x180C9B530")]
		public static TValue GetOrCreate<TValue, TKey>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			return (TValue)null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal delegate void UpdateGraph(int networkTimeMilliseconds, bool isMasterClient);
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CircuitNodeGraph : IComparable<CircuitNodeGraph>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class SerializedCircuitNodeGraphCopy
		{
			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public CircuitNodeGraphCollectionData GraphCollectionData
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x3058E0", Offset = "0x3042E0", VA = "0x1803058E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x3059D0", Offset = "0x3043D0", VA = "0x1803059D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x3059E0", Offset = "0x3043E0", VA = "0x1803059E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
			public SerializedCircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class CircuitNodeGraphCopy
		{
			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public List<CircuitNodeGraph> CopiedGraphs
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x3058E0", Offset = "0x3042E0", VA = "0x1803058E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x3059D0", Offset = "0x3043D0", VA = "0x1803059D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x3059E0", Offset = "0x3043E0", VA = "0x1803059E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
			public CircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static List<CircuitNodeGraph> AllGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly Guid GraphGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly bool IsInternalGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private RootNode _rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public bool GraphRequiresSort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly HashSet<CircuitNode> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly List<CircuitNode> StatefulNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private List<CircuitNode> ReverseTopologicNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<CircuitNode> NodesToConnectForSingleEvaluate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool destroyed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private HashSet<CircuitNode> needsPostEval;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static BitPacker bitPacker;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RootNode RootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x33A080", Offset = "0x338A80", VA = "0x18033A080")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NodeGraphDirty
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3FB7F0", Offset = "0x3FA1F0", VA = "0x1803FB7F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4E5690", Offset = "0x4E4090", VA = "0x1804E5690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x52C970", Offset = "0x52B370", VA = "0x18052C970")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x67C2C0", Offset = "0x67ACC0", VA = "0x18067C2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		internal static event UpdateGraph TimeUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x17213A0", Offset = "0x171FDA0", VA = "0x1817213A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x17214A0", Offset = "0x171FEA0", VA = "0x1817214A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1721310", Offset = "0x171FD10", VA = "0x181721310")]
		internal CircuitNodeGraph(bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x17212E0", Offset = "0x171FCE0", VA = "0x1817212E0")]
		public CircuitNodeGraph(Guid guid, bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1721140", Offset = "0x171FB40", VA = "0x181721140")]
		private CircuitNodeGraph(Guid guid, bool isInternalGraph, bool createRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1720EB0", Offset = "0x171F8B0", VA = "0x181720EB0")]
		public static void Update(int networkTimeMilliseconds, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x171F140", Offset = "0x171DB40", VA = "0x18171F140")]
		private void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x171EFF0", Offset = "0x171D9F0", VA = "0x18171EFF0")]
		public void DestroySelfAndNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x171C9B0", Offset = "0x171B3B0", VA = "0x18171C9B0")]
		internal void AddNode(CircuitNode circuitNode, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1720230", Offset = "0x171EC30", VA = "0x181720230")]
		internal bool RemoveNode(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x171CC10", Offset = "0x171B610", VA = "0x18171CC10")]
		internal bool ConnectToRootForSingleEvaluate(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x171F1D0", Offset = "0x171DBD0", VA = "0x18171F1D0")]
		public List<CircuitNode> Evaluate(bool isMasterClient)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x171CBD0", Offset = "0x171B5D0", VA = "0x18171CBD0", Slot = "4")]
		public int CompareTo(CircuitNodeGraph other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1720B80", Offset = "0x171F580", VA = "0x181720B80")]
		public static byte[] SerializeRuntimeState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x171E530", Offset = "0x171CF30", VA = "0x18171E530")]
		public static void DeserializeRuntimeState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1720850", Offset = "0x171F250", VA = "0x181720850")]
		public static byte[] SerializePostEvaluateState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x171E200", Offset = "0x171CC00", VA = "0x18171E200")]
		public static void DeserializePostEvaluateState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x171FDA0", Offset = "0x171E7A0", VA = "0x18171FDA0")]
		public static CircuitNodeGraphCollectionData PersistAll([Optional] IList<int> inactiveIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x171EF50", Offset = "0x171D950", VA = "0x18171EF50")]
		public static void DestroyAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x171DE00", Offset = "0x171C800", VA = "0x18171DE00")]
		public static void DeserializeAll(CircuitNodeGraphCollectionData data, out Dictionary<int, int> nodeIdMappings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x171FF80", Offset = "0x171E980", VA = "0x18171FF80")]
		public CircuitNodeGraphData Persist()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x171E860", Offset = "0x171D260", VA = "0x18171E860")]
		public static CircuitNodeGraph Deserialize(CircuitNodeGraphData data, bool reassignNodeIds, out Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x171CCA0", Offset = "0x171B6A0", VA = "0x18171CCA0")]
		public static CircuitNodeGraphCopy CopyNodesToNewGraphs(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1720330", Offset = "0x171ED30", VA = "0x181720330")]
		public static SerializedCircuitNodeGraphCopy SerializeNodesAsNewGraph(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x171F860", Offset = "0x171E260", VA = "0x18171F860")]
		public static CircuitNodeGraph MergeGraphs(CircuitNode nodeA, CircuitNode nodeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x171FAC0", Offset = "0x171E4C0", VA = "0x18171FAC0")]
		private static CircuitNodeGraph MergeInto(CircuitNodeGraph toGraph, CircuitNodeGraph fromGraph, params CircuitNode[] nodes)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum InputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		R,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		G,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		B,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		C,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		M,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		K,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		VIRTUAL,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		H00,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		H01,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		H02,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		H03,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		H04,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		H05,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		H06,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		H07,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		H08,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		H09,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		H10,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		H11,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		H12,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		H13,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		H14,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		H15,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		H16,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		H17,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		H18,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		H19,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		H20,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		H21,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		H22,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		H23,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		H24,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		H25,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		H26,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		H27,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		H28,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		H29,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		H30,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		H31,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		H32,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		H33,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		H34,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		H35,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		H36,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		H37,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		H38,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		H39,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		H40,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		H41,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		H42,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		H43,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		H44,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		H45,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		H46,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		H47,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		H48,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		H49,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		H50,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		H51,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		H52,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		H53,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		H54,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		H55,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		H56,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		H57,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		H58,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		H59,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		H60,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		H61,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		H62,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		H63,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		H64,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		H65,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		H66,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		H67,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		H68,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		H69,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		H70,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		H71,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		H72,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		H73,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		H74,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		H75,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		H76,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		H77,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		H78,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		H79,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		H80,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		H81,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		H82,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		H83,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		H84,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		H85,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		H86,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		H87,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		H88,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		H89,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		H90,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		H91,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		H92,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		H93,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		H94,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		H95,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		H96,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		H97,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		H98,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		H99
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum OutputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		R,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		G,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		B,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		C,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		M,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		K,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		VIRTUAL,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		H00,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		H01,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		H02,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		H03,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		H04,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		H05,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		H06,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		H07,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		H08,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		H09,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		H10,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		H11,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		H12,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		H13,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		H14,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		H15,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		H16,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		H17,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		H18,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		H19,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		H20,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		H21,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		H22,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		H23,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		H24,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		H25,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		H26,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		H27,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		H28,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		H29,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		H30,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		H31,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		H32,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		H33,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		H34,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		H35,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		H36,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		H37,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		H38,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		H39,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		H40,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		H41,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		H42,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		H43,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		H44,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		H45,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		H46,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		H47,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		H48,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		H49,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		H50,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		H51,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		H52,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		H53,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		H54,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		H55,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		H56,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		H57,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		H58,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		H59,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		H60,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		H61,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		H62,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		H63,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		H64,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		H65,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		H66,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		H67,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		H68,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		H69,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		H70,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		H71,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		H72,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		H73,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		H74,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		H75,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		H76,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		H77,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		H78,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		H79,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		H80,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		H81,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		H82,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		H83,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		H84,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		H85,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		H86,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		H87,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		H88,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		H89,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		H90,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		H91,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		H92,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		H93,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		H94,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		H95,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		H96,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		H97,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		H98,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		H99
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class IOSlots
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static InputSlot[] AllInputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static InputSlot[] AllStandardInputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static OutputSlot[] AllOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static OutputSlot[] AllStandardOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xCAF020", Offset = "0xCADA20", VA = "0x180CAF020")]
		public static OutputSlot InputSlotToOutputSlot(InputSlot input)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xCAF020", Offset = "0xCADA20", VA = "0x180CAF020")]
		public static InputSlot OutputSlotToInputSlot(OutputSlot output)
		{
			return default(InputSlot);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CircuitNodeUuid("2385E75E-E0DA-45BF-8D66-17DC9FFB9FC7")]
	public class BooleanNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum BooleanModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			And,
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			Or,
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			Not
		}

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly InputMetadata[] NotInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly OutputMetadata[] NotOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly Dictionary<BooleanModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private BooleanModes booleanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private List<int> inputs;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public BooleanModes BooleanMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(BooleanModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x144E170", Offset = "0x144CB70", VA = "0x18144E170")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x171B680", Offset = "0x171A080", VA = "0x18171B680")]
		public static string GetModeSymbol(BooleanModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x171BD70", Offset = "0x171A770", VA = "0x18171BD70")]
		public BooleanNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x171B920", Offset = "0x171A320", VA = "0x18171B920", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x171B270", Offset = "0x1719C70", VA = "0x18171B270")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x171B030", Offset = "0x1719A30", VA = "0x18171B030")]
		private bool CalcAndOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x171B150", Offset = "0x1719B50", VA = "0x18171B150")]
		private bool CalcOrOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x171B4D0", Offset = "0x1719ED0", VA = "0x18171B4D0")]
		private void FetchInputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x171B5F0", Offset = "0x1719FF0", VA = "0x18171B5F0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x171B7C0", Offset = "0x171A1C0", VA = "0x18171B7C0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x171B700", Offset = "0x171A100", VA = "0x18171B700", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x171B860", Offset = "0x171A260", VA = "0x18171B860", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x171B8D0", Offset = "0x171A2D0", VA = "0x18171B8D0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x171B9F0", Offset = "0x171A3F0", VA = "0x18171B9F0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CircuitNodeUuid("B7BA1A4B-EA04-496F-B8B6-A2FB7C4A42B9")]
	public class ContinuousSourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x17291F0", Offset = "0x1727BF0", VA = "0x1817291F0")]
		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1726300", Offset = "0x1724D00", VA = "0x181726300")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CircuitNodeUuid("53219714-E7BB-4950-BBB3-852A7EF196F8")]
	public class GameSetStateNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private static InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action StartGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x172B100", Offset = "0x1729B00", VA = "0x18172B100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x172B240", Offset = "0x1729C40", VA = "0x18172B240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action EndGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x172B060", Offset = "0x1729A60", VA = "0x18172B060")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x172B1A0", Offset = "0x1729BA0", VA = "0x18172B1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x172AD40", Offset = "0x1729740", VA = "0x18172AD40", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x172ADA0", Offset = "0x17297A0", VA = "0x18172ADA0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x172B000", Offset = "0x1729A00", VA = "0x18172B000")]
		public GameSetStateNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x172AE00", Offset = "0x1729800", VA = "0x18172AE00", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CircuitNodeUuid("20C6AC2E-1116-4C93-8CDF-40FE161CC796")]
	public class ObjectSetTagsNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum ChangeModes
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			Defaults
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public delegate void ChangeTagsForObjectFunc(int objectId);

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public const string MODE_ARG = "mode";

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private const string nodeDescription = "Change Tags on Object";

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private ChangeModes changeMode;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ChangeModes ChangeMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(ChangeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x144E170", Offset = "0x144CB70", VA = "0x18144E170")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ChangeTagsForObjectFunc ChangeTagsForObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x172D7E0", Offset = "0x172C1E0", VA = "0x18172D7E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x172D880", Offset = "0x172C280", VA = "0x18172D880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x172D760", Offset = "0x172C160", VA = "0x18172D760")]
		public ObjectSetTagsNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x172D3B0", Offset = "0x172BDB0", VA = "0x18172D3B0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x172D350", Offset = "0x172BD50", VA = "0x18172D350", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x172D420", Offset = "0x172BE20", VA = "0x18172D420", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x172D570", Offset = "0x172BF70", VA = "0x18172D570", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x172D480", Offset = "0x172BE80", VA = "0x18172D480", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x171B860", Offset = "0x171A260", VA = "0x18171B860", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x171B8D0", Offset = "0x171A2D0", VA = "0x18171B8D0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CircuitNodeUuid("0D0D8EA8-2816-4B3B-8F1D-19C74B056DA6")]
	public class PlayerRoleMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum PlayerRoleMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			AddPlayerRole,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			RemovePlayerRole,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			PlayerHasRole,
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			PlayerRoleChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public delegate void PlayerModifyRoleFunc(int playerId, int roleId);

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool PlayerHasRoleFunc(int playerId, int roleId);

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly OutputMetadata[] PlayerHasRoleOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static readonly OutputMetadata[] PlayerRoleChangedOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static readonly InputMetadata[] PlayerHasRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static readonly InputMetadata[] ModifyPlayerRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly OutputMetadata[] ModifyPlayerRoleOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private PlayerRoleMapModes playerRoleMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private int modificationRoleId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool masterLastPlayerHasRoleSignal;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public PlayerRoleMapModes PlayerRoleMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1220AA0", Offset = "0x121F4A0", VA = "0x181220AA0")]
			get
			{
				return default(PlayerRoleMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x17302C0", Offset = "0x172ECC0", VA = "0x1817302C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int ModificationRoleId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5D73A0", Offset = "0x5D5DA0", VA = "0x1805D73A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x17302A0", Offset = "0x172ECA0", VA = "0x1817302A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PlayerModifyRoleFunc PlayerAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x172FC60", Offset = "0x172E660", VA = "0x18172FC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x172FF80", Offset = "0x172E980", VA = "0x18172FF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PlayerModifyRoleFunc TeamAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x172FE40", Offset = "0x172E840", VA = "0x18172FE40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1730160", Offset = "0x172EB60", VA = "0x181730160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PlayerModifyRoleFunc PlayerRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x172FDA0", Offset = "0x172E7A0", VA = "0x18172FDA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x17300C0", Offset = "0x172EAC0", VA = "0x1817300C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event PlayerModifyRoleFunc TeamRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x172FEE0", Offset = "0x172E8E0", VA = "0x18172FEE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1730200", Offset = "0x172EC00", VA = "0x181730200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event PlayerHasRoleFunc PlayerHasRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x172FD00", Offset = "0x172E700", VA = "0x18172FD00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1730020", Offset = "0x172EA20", VA = "0x181730020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x172F400", Offset = "0x172DE00", VA = "0x18172F400")]
		public void MarkDirtyForRoleChange(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x172FBF0", Offset = "0x172E5F0", VA = "0x18172FBF0")]
		public PlayerRoleMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x172F4D0", Offset = "0x172DED0", VA = "0x18172F4D0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x172EDD0", Offset = "0x172D7D0", VA = "0x18172EDD0")]
		private void EvaluatePlayerHasRole(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x172F290", Offset = "0x172DC90", VA = "0x18172F290")]
		private bool GetPlayerHasRoleSignal(bool isMasterClient, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x172ECC0", Offset = "0x172D6C0", VA = "0x18172ECC0")]
		private void EvaluateAddPlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x172EEA0", Offset = "0x172D8A0", VA = "0x18172EEA0")]
		private void EvaluateRemovePlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x172F440", Offset = "0x172DE40", VA = "0x18172F440", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x172EC90", Offset = "0x172D690", VA = "0x18172EC90", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x172EFB0", Offset = "0x172D9B0", VA = "0x18172EFB0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x172F160", Offset = "0x172DB60", VA = "0x18172F160", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x172F0B0", Offset = "0x172DAB0", VA = "0x18172F0B0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x172F370", Offset = "0x172DD70", VA = "0x18172F370", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x172F470", Offset = "0x172DE70", VA = "0x18172F470", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x172F780", Offset = "0x172E180", VA = "0x18172F780", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CircuitNodeUuid("CEE29EB9-61AE-42D4-8DC6-3A62D7096781")]
	public class PlayerTeamMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum PlayerIdMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			PlayerToTeam,
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			TeamToPlayer,
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			SetPlayerTeam,
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			GetTeamPlayerCount
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public delegate void PlayerToTeamIndexFunc(int playerId, out int teamId, out int teamIndex);

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public delegate void PlayerSetTeamFunc(int playerId, int teamId);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public delegate void TeamIndexToPlayerFunc(int teamId, int teamIndex, out int playerId);

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public delegate void GetTeamPlayerCountFunc(int teamId, out int teamPlayerCount);

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly InputMetadata[] PlayerToTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly OutputMetadata[] PlayerToTeamOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly InputMetadata[] TeamToPlayerInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly OutputMetadata[] TeamToPlayerOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly InputMetadata[] SetPlayerTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly InputMetadata[] GetTeamPlayerCountInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly OutputMetadata[] GetTeamPlayerCountOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly OutputMetadata[] SetPlayerTeamOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private PlayerIdMapModes playerIdMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int lastMasterPlayerToTeamId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int lastMasterPlayerToTeamIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int lastMasterTeamIndexToPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int lastMasterTeamPlayerCount;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PlayerIdMapModes PlayerIdMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x1220AA0", Offset = "0x121F4A0", VA = "0x181220AA0")]
			get
			{
				return default(PlayerIdMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x17302C0", Offset = "0x172ECC0", VA = "0x1817302C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event PlayerToTeamIndexFunc PlayerToTeamIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x1731F30", Offset = "0x1730930", VA = "0x181731F30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x1730BB0", VA = "0x1817321B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event PlayerSetTeamFunc PlayerSetTeam
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x1731E90", Offset = "0x1730890", VA = "0x181731E90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1732110", Offset = "0x1730B10", VA = "0x181732110")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event TeamIndexToPlayerFunc TeamIndexToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x1731FD0", Offset = "0x17309D0", VA = "0x181731FD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x1732250", Offset = "0x1730C50", VA = "0x181732250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event GetTeamPlayerCountFunc GetTeamPlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x1731DF0", Offset = "0x17307F0", VA = "0x181731DF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x1732070", Offset = "0x1730A70", VA = "0x181732070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x17313A0", Offset = "0x172FDA0", VA = "0x1817313A0")]
		public void MarkDirtyForTeamChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1731D90", Offset = "0x1730790", VA = "0x181731D90")]
		public PlayerTeamMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1731520", Offset = "0x172FF20", VA = "0x181731520", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1730B40", Offset = "0x172F540", VA = "0x181730B40")]
		private void EvaluatePlayerToTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1731080", Offset = "0x172FA80", VA = "0x181731080")]
		private void GetPlayerToTeamSignals(bool isMasterClient, int playerId, out int masterTeamId, out int masterTeamIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1730CC0", Offset = "0x172F6C0", VA = "0x181730CC0")]
		private void EvaluateTeamToPlayer(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1731160", Offset = "0x172FB60", VA = "0x181731160")]
		private int GetTeamIndexToPlayerSignal(bool isMasterClient, int teamId, int teamIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1730A50", Offset = "0x172F450", VA = "0x181730A50")]
		private void EvaluateGetTeamPlayerCount(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1731240", Offset = "0x172FC40", VA = "0x181731240")]
		private int GetTeamPlayerCountSignal(bool isMasterClient, int teamId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1730BE0", Offset = "0x172F5E0", VA = "0x181730BE0")]
		private void EvaluateSetPlayerTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x17313D0", Offset = "0x172FDD0", VA = "0x1817313D0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1730910", Offset = "0x172F310", VA = "0x181730910", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1730D40", Offset = "0x172F740", VA = "0x181730D40", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1730F20", Offset = "0x172F920", VA = "0x181730F20", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1730EA0", Offset = "0x172F8A0", VA = "0x181730EA0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1731330", Offset = "0x172FD30", VA = "0x181731330", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x172E470", Offset = "0x172CE70", VA = "0x18172E470", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1731840", Offset = "0x1730240", VA = "0x181731840", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class PostEvalActionNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private List<Action> PostEvalActions;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal sealed override bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x1444400", Offset = "0x1442E00", VA = "0x181444400", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1444340", Offset = "0x1442D40", VA = "0x181444340")]
		public PostEvalActionNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x14442E0", Offset = "0x1442CE0", VA = "0x1814442E0")]
		protected void QueuePostEvalAction(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1444130", Offset = "0x1442B30", VA = "0x181444130", Slot = "23")]
		internal sealed override void PostEvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CircuitNodeUuid("3079A591-0E82-41B5-8BEC-00AC26F8E6C4")]
	public class QueuedMomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public struct Output
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public OutputSlot outputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public int outputValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		internal List<Output[]> QueuedSignals;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1444A30", Offset = "0x1443430", VA = "0x181444A30")]
		public QueuedMomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1444870", Offset = "0x1443270", VA = "0x181444870")]
		public new void SetContinuousOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1444880", Offset = "0x1443280", VA = "0x181444880")]
		public new void SetMomentaryOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1444920", Offset = "0x1443320", VA = "0x181444920")]
		public void SetMomentaryOutputs(params Output[] outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1444930", Offset = "0x1443330", VA = "0x181444930", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x14446C0", Offset = "0x14430C0", VA = "0x1814446C0", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1444470", Offset = "0x1442E70", VA = "0x181444470", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x14445F0", Offset = "0x1442FF0", VA = "0x1814445F0")]
		private void QueueSignal(Output[] outputs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CircuitNodeUuid("AA5DC0B1-AC22-4075-AB13-E8376AA0FC39")]
	public class ObjectPlayerMappingNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate void ObjectToHoldingPlayerIdFunc(int objectId, out int lastHeldPlayer, out int currentHoldingPlayer);

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event ObjectToHoldingPlayerIdFunc ObjectToHoldingPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x172D210", Offset = "0x172BC10", VA = "0x18172D210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x172D2B0", Offset = "0x172BCB0", VA = "0x18172D2B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x172D190", Offset = "0x172BB90", VA = "0x18172D190")]
		public ObjectPlayerMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x172CD70", Offset = "0x172B770", VA = "0x18172CD70", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x172CD10", Offset = "0x172B710", VA = "0x18172CD10", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x172CDA0", Offset = "0x172B7A0", VA = "0x18172CDA0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x172CF90", Offset = "0x172B990", VA = "0x18172CF90", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x172CE00", Offset = "0x172B800", VA = "0x18172CE00")]
		private void MasterCalcOutput(int objectId, out int lastHeldPlayerId, out int currentHoldingPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CircuitNodeUuid("B71B05C0-D6FD-4C49-A70C-085C14E95317")]
	public class RandomNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum RandomModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			Continuous,
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			Pulse
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private RandomModes randomMode;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static Random random;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int masterLastRandomNumber;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public RandomModes RandomMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(RandomModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x1445260", Offset = "0x1443C60", VA = "0x181445260")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x14451E0", Offset = "0x1443BE0", VA = "0x1814451E0")]
		public RandomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1444C90", Offset = "0x1443690", VA = "0x181444C90", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1444C30", Offset = "0x1443630", VA = "0x181444C30", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1444CC0", Offset = "0x14436C0", VA = "0x181444CC0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x1444E00", Offset = "0x1443800", VA = "0x181444E00", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1444D70", Offset = "0x1443770", VA = "0x181444D70", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1444BE0", Offset = "0x14435E0", VA = "0x181444BE0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1444AF0", Offset = "0x14434F0", VA = "0x181444AF0")]
		private int CalcOutput(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1444D20", Offset = "0x1443720", VA = "0x181444D20", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1444DD0", Offset = "0x14437D0", VA = "0x181444DD0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1444F80", Offset = "0x1443980", VA = "0x181444F80", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class SourceNodeBase : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1449E60", Offset = "0x1448860", VA = "0x181449E60")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1449EC0", Offset = "0x14488C0", VA = "0x181449EC0")]
		public SourceNodeBase(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1449E00", Offset = "0x1448800", VA = "0x181449E00", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x34E580", Offset = "0x34CF80", VA = "0x18034E580", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CircuitNodeUuid("6AD5D963-2357-4A09-BDA6-C99A917655B1")]
	public class SelectorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum EvalModes
		{
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			First,
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct SelectorConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public SignalComparisonHelper.ComparerModes CompareMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public int CompareValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private EvalModes _evalMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public SelectorConfig[] SelectorConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private InputMetadata[] inputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int lastSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int lastSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private bool modifiedSinceLastEval;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public EvalModes EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(EvalModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x1446E10", Offset = "0x1445810", VA = "0x181446E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x1446C50", Offset = "0x1445650", VA = "0x181446C50")]
		public SelectorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1446790", Offset = "0x1445190", VA = "0x181446790", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1446390", Offset = "0x1444D90", VA = "0x181446390", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4B99A0", Offset = "0x4B83A0", VA = "0x1804B99A0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x14463D0", Offset = "0x1444DD0", VA = "0x1814463D0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1446420", Offset = "0x1444E20", VA = "0x181446420", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x14465E0", Offset = "0x1444FE0", VA = "0x1814465E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x14469A0", Offset = "0x14453A0", VA = "0x1814469A0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CircuitNodeUuid("B58C2FAB-3F1A-15F4-6D31-4E3BE09A71A9")]
	public class SourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1449F70", Offset = "0x1448970", VA = "0x181449F70")]
		public SourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1449F60", Offset = "0x1448960", VA = "0x181449F60")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1444870", Offset = "0x1443270", VA = "0x181444870")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169B82")]
	public class ComparerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly InputMetadata[] AdvancedInputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private SignalComparisonHelper.ComparerModes comparerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private bool advancedMode;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public SignalComparisonHelper.ComparerModes ComparerMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(SignalComparisonHelper.ComparerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x144E170", Offset = "0x144CB70", VA = "0x18144E170")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5DC750", Offset = "0x5DB150", VA = "0x1805DC750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x17289F0", Offset = "0x17273F0", VA = "0x1817289F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1728970", Offset = "0x1727370", VA = "0x181728970")]
		public ComparerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1728490", Offset = "0x1726E90", VA = "0x181728490", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x17280E0", Offset = "0x1726AE0", VA = "0x1817280E0")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1728170", Offset = "0x1726B70", VA = "0x181728170", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1728280", Offset = "0x1726C80", VA = "0x181728280", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1728210", Offset = "0x1726C10", VA = "0x181728210", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x17283B0", Offset = "0x1726DB0", VA = "0x1817283B0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1728430", Offset = "0x1726E30", VA = "0x181728430", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x17285F0", Offset = "0x1726FF0", VA = "0x1817285F0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CircuitNodeUuid("17B72DE0-4116-41DB-A99D-1523625F7EF1")]
	public class CombinatorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum CombinatorModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			Subtract,
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			Multiply,
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			Divide,
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			Modulo
		}

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private static readonly InputMetadata[] TwoInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private static readonly InputMetadata[] ThreeInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private static readonly Dictionary<CombinatorModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private CombinatorModes combinatorMode;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public CombinatorModes CombinatorMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(CombinatorModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x144E170", Offset = "0x144CB70", VA = "0x18144E170")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x17279D0", Offset = "0x17263D0", VA = "0x1817279D0")]
		public static string GetModeSymbol(CombinatorModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1728060", Offset = "0x1726A60", VA = "0x181728060")]
		public CombinatorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1727C00", Offset = "0x1726600", VA = "0x181727C00", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1727800", Offset = "0x1726200", VA = "0x181727800")]
		private int CalcOutput()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1727930", Offset = "0x1726330", VA = "0x181727930", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1727B20", Offset = "0x1726520", VA = "0x181727B20", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1727A50", Offset = "0x1726450", VA = "0x181727A50", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x171B860", Offset = "0x171A260", VA = "0x18171B860", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x171B8D0", Offset = "0x171A2D0", VA = "0x18171B8D0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1727CE0", Offset = "0x17266E0", VA = "0x181727CE0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CircuitNodeUuid("34452A12-AFB3-4A4D-97B0-9D25F7E777C5")]
	public class DelayNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct DelaySignal
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public int timeRemaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public int value;
		}

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private List<DelaySignal> QueuedSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int lastInputSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1729E60", Offset = "0x1728860", VA = "0x181729E60")]
		public DelayNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1729380", Offset = "0x1727D80", VA = "0x181729380", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x17294F0", Offset = "0x1727EF0", VA = "0x1817294F0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1729550", Offset = "0x1727F50", VA = "0x181729550", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1729A70", Offset = "0x1728470", VA = "0x181729A70", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1729C70", Offset = "0x1728670", VA = "0x181729C70", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x17297A0", Offset = "0x17281A0", VA = "0x1817297A0")]
		private void QueueSignal(int delay, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x17295B0", Offset = "0x1727FB0", VA = "0x1817295B0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1729900", Offset = "0x1728300", VA = "0x181729900", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1729270", Offset = "0x1727C70", VA = "0x181729270", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CircuitNodeUuid("C9A59F26-0A72-4C2E-B239-6A83998E0839", InternalOnly = true)]
	public class LoopNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		internal override bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x172BBE0", Offset = "0x172A5E0", VA = "0x18172BBE0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x172BB60", Offset = "0x172A560", VA = "0x18172BB60")]
		public LoopNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x172BAC0", Offset = "0x172A4C0", VA = "0x18172BAC0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x172BB10", Offset = "0x172A510", VA = "0x18172BB10", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CircuitNodeUuid("E7EFD8CA-92FE-4A37-9E7C-ABBE9E4DE336")]
	public class MomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x172BBF0", Offset = "0x172A5F0", VA = "0x18172BBF0")]
		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1726320", Offset = "0x1724D20", VA = "0x181726320")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CircuitNodeUuid("6402C773-5838-4495-BC54-BC36EDE4AB0F")]
	public class ConstantSourceNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1728AA0", Offset = "0x17274A0", VA = "0x181728AA0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1728B00", Offset = "0x1727500", VA = "0x181728B00", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1729170", Offset = "0x1727B70", VA = "0x181729170")]
		public ConstantSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1728B60", Offset = "0x1727560", VA = "0x181728B60", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1728D50", Offset = "0x1727750", VA = "0x181728D50", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1728EE0", Offset = "0x17278E0", VA = "0x181728EE0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CircuitNodeUuid("738B2AF2-EEBD-4316-82A9-2FBEC9B50D8B", InternalOnly = true)]
	public class NodeGraphNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CircuitNodeUuid("86B6FD1C-4668-4BA9-8ACB-FB91E25DBFB6", InternalOnly = true)]
		public class GraphInputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x172B6D0", Offset = "0x172A0D0", VA = "0x18172B6D0")]
			public GraphInputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1726300", Offset = "0x1724D00", VA = "0x181726300")]
			public void SetOutputSignal(OutputSlot slot, int val)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CircuitNodeUuid("F8A998DB-0354-4BCD-B0E4-6BBA7CC24B89", InternalOnly = true)]
		public class GraphOutputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x172B8F0", Offset = "0x172A2F0", VA = "0x18172B8F0")]
			public GraphOutputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x172B750", Offset = "0x172A150", VA = "0x18172B750", Slot = "24")]
			protected override void _EvaluateNode(bool isMasterClient)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private GraphInputNode virtualSourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private GraphOutputNode virtualDestNode;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public CircuitNodeGraph InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x34E580", Offset = "0x34CF80", VA = "0x18034E580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x34E950", Offset = "0x34D350", VA = "0x18034E950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x172C6A0", Offset = "0x172B0A0", VA = "0x18172C6A0")]
		public NodeGraphNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x172C310", Offset = "0x172AD10", VA = "0x18172C310", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x172C230", Offset = "0x172AC30", VA = "0x18172C230", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x172BDC0", Offset = "0x172A7C0", VA = "0x18172BDC0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x172BD20", Offset = "0x172A720", VA = "0x18172BD20", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x172BD70", Offset = "0x172A770", VA = "0x18172BD70", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct NodeMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public bool NeedsSerialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public InputMetadata[] InputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string NodeDescription;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct InputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public string Description;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct OutputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public OutputSlot OutputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public string Description;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CircuitNodeUuid("C6AB70A0-C752-466A-8070-029742655556")]
	public class OutputNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public delegate void OutputNodeUpdated(Dictionary<InputSlot, int> slotUpdates);

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int[] lastSignals;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1449E60", Offset = "0x1448860", VA = "0x181449E60")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x172DF30", Offset = "0x172C930", VA = "0x18172DF30")]
		public OutputNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x172D9E0", Offset = "0x172C3E0", VA = "0x18172D9E0", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x172DDD0", Offset = "0x172C7D0", VA = "0x18172DDD0")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x34E580", Offset = "0x34CF80", VA = "0x18034E580", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x172DD70", Offset = "0x172C770", VA = "0x18172DD70", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x172DED0", Offset = "0x172C8D0", VA = "0x18172DED0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x172DAA0", Offset = "0x172C4A0", VA = "0x18172DAA0")]
		private void FireEventIfNeeded()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169BAD")]
	public class StateMachineNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct StateTransition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public InputSlot inputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public byte stateIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public int val1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public int val2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public int val3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int minTimeInStateMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public bool removed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public StateTransition[] transitions;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public enum ModifyCommands
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			DefaultState = 1,
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			MaxStateIndex,
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			StateVal1,
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			StateVal2,
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			StateVal3,
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			MinTimeInStateMS,
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			NumTransitions,
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			TransitionInputSlot,
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			TransitionStateTarget,
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			RemovedState
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private State[] states;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private byte maxStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private OutputSlot[] _serializableOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public byte CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F50", Offset = "0x8D3950", VA = "0x1808D4F50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x91E270", Offset = "0x91CC70", VA = "0x18091E270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte DefaultState
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x9D0700", Offset = "0x9CF100", VA = "0x1809D0700")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9D0B80", Offset = "0x9CF580", VA = "0x1809D0B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x4B99A0", Offset = "0x4B83A0", VA = "0x1804B99A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6C7510", Offset = "0x6C5F10", VA = "0x1806C7510", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int TimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x478160", Offset = "0x476B60", VA = "0x180478160")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x478750", Offset = "0x477150", VA = "0x180478750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x144C1C0", Offset = "0x144ABC0", VA = "0x18144C1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		private bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x144C130", Offset = "0x144AB30", VA = "0x18144C130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x144A850", Offset = "0x1449250", VA = "0x18144A850")]
		public State? GetState(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x144BF90", Offset = "0x144A990", VA = "0x18144BF90")]
		public StateMachineNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x144A060", Offset = "0x1448A60", VA = "0x18144A060", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x144ADF0", Offset = "0x14497F0", VA = "0x18144ADF0")]
		private void OnTimerUpdate(int networkTimeMS, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x144B260", Offset = "0x1449C60", VA = "0x18144B260", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x144BF60", Offset = "0x144A960", VA = "0x18144BF60", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x144A5B0", Offset = "0x1448FB0", VA = "0x18144A5B0")]
		public static OutputSlot GetOnEnterOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x144A310", Offset = "0x1448D10", VA = "0x18144A310")]
		public static OutputSlot GetInStateOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x144A5C0", Offset = "0x1448FC0", VA = "0x18144A5C0")]
		public static OutputSlot GetOnExitOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x144A0F0", Offset = "0x1448AF0", VA = "0x18144A0F0")]
		private void EnterState(byte newStateIndex, bool forceIfCurrent = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x144A320", Offset = "0x1448D20", VA = "0x18144A320", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x144A5D0", Offset = "0x1448FD0", VA = "0x18144A5D0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x144A560", Offset = "0x1448F60", VA = "0x18144A560", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x144AF90", Offset = "0x1449990", VA = "0x18144AF90", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1449FF0", Offset = "0x14489F0", VA = "0x181449FF0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x144A950", Offset = "0x1449350", VA = "0x18144A950", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x144B010", Offset = "0x1449A10", VA = "0x18144B010", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x144A540", Offset = "0x1448F40", VA = "0x18144A540")]
		public static int GetModifyArg(ModifyCommands cmd, byte stateIdx = 0, byte transitionIdx = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x144B240", Offset = "0x1449C40", VA = "0x18144B240")]
		private static void UnpackModifyArg(int arg, out ModifyCommands cmd, out byte stateIdx, out byte transitionIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x144B410", Offset = "0x1449E10", VA = "0x18144B410", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x144A300", Offset = "0x1448D00", VA = "0x18144A300")]
		public void ForceReconstructNodeMetaData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CircuitNodeUuid("A77191F7-792B-4590-AAB3-A3B71C440DD1")]
	public class TimerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public enum TimerModes
		{
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			Looping,
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			Countdown
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public enum TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			Second,
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			TenthOfSecond
		}

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly InputMetadata[] InputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private TimerModes timerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private int timeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private bool timerExpired;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int _inputTimeTenths;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TimerModes TimerMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(TimerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x144E170", Offset = "0x144CB70", VA = "0x18144E170")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private int inputTimeTenths
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x144E160", Offset = "0x144CB60", VA = "0x18144E160")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x144E190", Offset = "0x144CB90", VA = "0x18144E190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x144E080", Offset = "0x144CA80", VA = "0x18144E080")]
		public TimerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x144D860", Offset = "0x144C260", VA = "0x18144D860", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x144DD30", Offset = "0x144C730", VA = "0x18144DD30", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x144DE60", Offset = "0x144C860", VA = "0x18144DE60", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x144D8F0", Offset = "0x144C2F0", VA = "0x18144D8F0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x144D990", Offset = "0x144C390", VA = "0x18144D990", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x144D950", Offset = "0x144C350", VA = "0x18144D950", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x144DA50", Offset = "0x144C450", VA = "0x18144DA50")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x144DCA0", Offset = "0x144C6A0", VA = "0x18144DCA0")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x144DB60", Offset = "0x144C560", VA = "0x18144DB60")]
		private void ResetTimeRemaining()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x144D9F0", Offset = "0x144C3F0", VA = "0x18144D9F0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1444DD0", Offset = "0x14437D0", VA = "0x181444DD0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x144DDA0", Offset = "0x144C7A0", VA = "0x18144DDA0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x144DC40", Offset = "0x144C640", VA = "0x18144DC40", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x144D810", Offset = "0x144C210", VA = "0x18144D810", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x144DBF0", Offset = "0x144C5F0", VA = "0x18144DBF0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x144D7D0", Offset = "0x144C1D0", VA = "0x18144D7D0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CircuitNodeUuid("9B664D6A-1B61-4D4E-9AA8-B17B0DC02DA3")]
	public class UnityTransformationNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private Dictionary<InputSlot, int> inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private Dictionary<OutputSlot, int> outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private Func<Dictionary<InputSlot, int>, Dictionary<OutputSlot, int>> transformationFunction;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x34E580", Offset = "0x34CF80", VA = "0x18034E580", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4B9B50", Offset = "0x4B8550", VA = "0x1804B9B50", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x14509E0", Offset = "0x144F3E0", VA = "0x1814509E0")]
		public UnityTransformationNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1450670", Offset = "0x144F070", VA = "0x181450670", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1450570", Offset = "0x144EF70", VA = "0x181450570")]
		private void PassthroughValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CircuitNodeUuid("34200A8F-370E-4240-B034-66252D44BE88")]
	public class WaveNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum WaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Sine,
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			Cosine,
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			Square,
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			Sawtooth
		}

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly InputMetadata[] SecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static readonly InputMetadata[] ThenthOfSecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private WaveMode currentWaveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private TimerNode.TimeUnit currentTimeUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private int runningTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private int _inputPeriod;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private int inputAmplitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private double functionPeriodInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private double millisecondTimeToAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private int loopTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private int relevantDecimalPlaces;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public WaveMode CurrentWaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x673520", Offset = "0x671F20", VA = "0x180673520")]
			get
			{
				return default(WaveMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x144E170", Offset = "0x144CB70", VA = "0x18144E170")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TimerNode.TimeUnit CurrentTimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1220A30", Offset = "0x121F430", VA = "0x181220A30")]
			get
			{
				return default(TimerNode.TimeUnit);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1452560", Offset = "0x1450F60", VA = "0x181452560")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private double InputTimeUnitInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1452530", Offset = "0x1450F30", VA = "0x181452530")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private int InputPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x56A670", Offset = "0x569070", VA = "0x18056A670")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x14525A0", Offset = "0x1450FA0", VA = "0x1814525A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1452450", Offset = "0x1450E50", VA = "0x181452450")]
		public WaveNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1451610", Offset = "0x1450010", VA = "0x181451610", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1451F00", Offset = "0x1450900", VA = "0x181451F00", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1452100", Offset = "0x1450B00", VA = "0x181452100", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1451980", Offset = "0x1450380", VA = "0x181451980", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1451AB0", Offset = "0x14504B0", VA = "0x181451AB0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1451A20", Offset = "0x1450420", VA = "0x181451A20", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1451BA0", Offset = "0x14505A0", VA = "0x181451BA0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1451EC0", Offset = "0x14508C0", VA = "0x181451EC0")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1451CA0", Offset = "0x14506A0", VA = "0x181451CA0")]
		private void ResetRunningTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x14516A0", Offset = "0x14500A0", VA = "0x1814516A0")]
		private int EvaluateWaveFunction()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1451D50", Offset = "0x1450750", VA = "0x181451D50")]
		private void UpdateCachedFunctionParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1451B10", Offset = "0x1450510", VA = "0x181451B10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1451D10", Offset = "0x1450710", VA = "0x181451D10", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1451FB0", Offset = "0x14509B0", VA = "0x181451FB0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1451CB0", Offset = "0x14506B0", VA = "0x181451CB0", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x14515C0", Offset = "0x144FFC0", VA = "0x1814515C0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CircuitNodeUuid("A4160690-4C68-40C2-BD51-B665F71FCEBD", InternalOnly = true)]
	public class RootNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal override bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1445270", Offset = "0x1443C70", VA = "0x181445270")]
		public RootNode(int nodeId, CircuitNodeGraph graph)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class VirtualNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x312060", Offset = "0x310A60", VA = "0x180312060", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1451530", Offset = "0x144FF30", VA = "0x181451530")]
		protected VirtualNode(string nodeName, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x14513B0", Offset = "0x144FDB0", VA = "0x1814513B0", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1451400", Offset = "0x144FE00", VA = "0x181451400", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1451460", Offset = "0x144FE60", VA = "0x181451460", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class Serialization
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x14494B0", Offset = "0x1447EB0", VA = "0x1814494B0")]
		public static CircuitNode InstantiateNode(Guid nodeType, int nodeId, Guid graphGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1449250", Offset = "0x1447C50", VA = "0x181449250")]
		internal static CircuitNode InstantiateNode(CircuitNodeData nodeData, CircuitNodeGraph nodeGraph, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1449110", Offset = "0x1447B10", VA = "0x181449110")]
		public static Guid GetNodeTypeGuid(CircuitNode node)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1449640", Offset = "0x1448040", VA = "0x181449640")]
		public static bool TryGetNodeTypeByGuid(Guid guid, out Type t)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public delegate CircuitNode CircuitNodeConstructor(int nodeId, CircuitNodeGraph graph);
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal static class SerializationLookup
	{
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private static Guid RECROOM_CIRCUITS_BOOLEANNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static Guid RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private static Guid RECROOM_CIRCUITS_GAMESETSTATENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private static Guid RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private static Guid RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private static Guid RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private static Guid RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static Guid RECROOM_CIRCUITS_SELECTORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static Guid RECROOM_CIRCUITS_SOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static Guid RECROOM_CIRCUITS_STATEMACHINENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static Guid RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static Guid RECROOM_CIRCUITS_WAVENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000217")]
		internal static Dictionary<Type, Guid> TypeToGuidLookup;

		[Cpp2IlInjected.Token(Token = "0x4000218")]
		internal static Dictionary<Guid, Type> GuidToTypeLookup;

		[Cpp2IlInjected.Token(Token = "0x4000219")]
		internal static Dictionary<Guid, CircuitNodeConstructor> GuidToNodeConstructor;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class SignalComparisonHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum ComparerModes
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			Equals,
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			NotEquals,
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			GreaterThan,
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			GreaterThanEqualTo,
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			LessThan,
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			LessThanEqualTo
		}

		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private static readonly Dictionary<ComparerModes, string> ModeSymbols;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1449750", Offset = "0x1448150", VA = "0x181449750")]
		public static string GetModeSymbol(ComparerModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x14496E0", Offset = "0x14480E0", VA = "0x1814496E0")]
		internal static bool Compare(ComparerModes comparerMode, int leftSide, int rightSide)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Circuits.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class CircuitLinkDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x143B3F0", Offset = "0x1439DF0", VA = "0x18143B3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x143ADA0", Offset = "0x14397A0", VA = "0x18143ADA0")]
		static CircuitLinkDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class CircuitLinkData : IMessage<CircuitLinkData>, IMessage, IEquatable<CircuitLinkData>, IDeepCloneable<CircuitLinkData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private static readonly MessageParser<CircuitLinkData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private int sourceNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private int destNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private int inputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private int outputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private int linkType_;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitLinkData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x143BBA0", Offset = "0x143A5A0", VA = "0x18143BBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x143BAD0", Offset = "0x143A4D0", VA = "0x18143BAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x143BC00", Offset = "0x143A600", VA = "0x18143BC00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[DebuggerNonUserCode]
		public int SourceNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x339EC0", Offset = "0x3388C0", VA = "0x180339EC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x33A090", Offset = "0x338A90", VA = "0x18033A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[DebuggerNonUserCode]
		public int DestNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x4D7D80", Offset = "0x4D6780", VA = "0x1804D7D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x39D380", Offset = "0x39BD80", VA = "0x18039D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[DebuggerNonUserCode]
		public int InputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x393780", Offset = "0x392180", VA = "0x180393780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x3937A0", Offset = "0x3921A0", VA = "0x1803937A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[DebuggerNonUserCode]
		public int OutputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x393770", Offset = "0x392170", VA = "0x180393770")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x393790", Offset = "0x392190", VA = "0x180393790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[DebuggerNonUserCode]
		public int LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		[DebuggerNonUserCode]
		public CircuitLinkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x143BA80", Offset = "0x143A480", VA = "0x18143BA80")]
		[DebuggerNonUserCode]
		public CircuitLinkData(CircuitLinkData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x143B5A0", Offset = "0x1439FA0", VA = "0x18143B5A0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitLinkData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x143B620", Offset = "0x143A020", VA = "0x18143B620", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x143B6C0", Offset = "0x143A0C0", VA = "0x18143B6C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitLinkData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x143B700", Offset = "0x143A100", VA = "0x18143B700", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x143B870", Offset = "0x143A270", VA = "0x18143B870", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x143B8D0", Offset = "0x143A2D0", VA = "0x18143B8D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x143B450", Offset = "0x1439E50", VA = "0x18143B450", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x143B7B0", Offset = "0x143A1B0", VA = "0x18143B7B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class CircuitNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x143E5F0", Offset = "0x143CFF0", VA = "0x18143E5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x143BD00", Offset = "0x143A700", VA = "0x18143BD00")]
		static CircuitNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private static readonly MessageParser<CircuitNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private string nodeName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private int nodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private int pairedNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private ByteString nodeType_;

		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private static readonly FieldCodec<CircuitLinkData> _repeated_circuitLinks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private readonly RepeatedField<CircuitLinkData> circuitLinks_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private NodeTransformData transformData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private InternalGraphData internalGraphData_;

		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private static readonly FieldCodec<SlotData> _repeated_slotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private readonly RepeatedField<SlotData> slotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int mode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private SelectorNodeData selectorNodeData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private bool advancedMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int timeUnit_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int roleId_;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly FieldCodec<StateMachineStateData> _repeated_stateMachineData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private readonly RepeatedField<StateMachineStateData> stateMachineData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private int defaultIndex_;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly FieldCodec<SlotData> _repeated_defaultInputSlotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private readonly RepeatedField<SlotData> defaultInputSlotData_;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x143FF70", Offset = "0x143E970", VA = "0x18143FF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x143FEA0", Offset = "0x143E8A0", VA = "0x18143FEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x143FFD0", Offset = "0x143E9D0", VA = "0x18143FFD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x3058E0", Offset = "0x3042E0", VA = "0x1803058E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x14400D0", Offset = "0x143EAD0", VA = "0x1814400D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x393780", Offset = "0x392180", VA = "0x180393780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x3937A0", Offset = "0x3921A0", VA = "0x1803937A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		public int PairedNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x393770", Offset = "0x392170", VA = "0x180393770")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x393790", Offset = "0x392190", VA = "0x180393790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x3170C0", Offset = "0x315AC0", VA = "0x1803170C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x1440120", Offset = "0x143EB20", VA = "0x181440120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitLinkData> CircuitLinks
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[DebuggerNonUserCode]
		public NodeTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x339EB0", Offset = "0x3388B0", VA = "0x180339EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x3A1980", Offset = "0x3A0380", VA = "0x1803A1980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public InternalGraphData InternalGraphData
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x34A4F0", Offset = "0x348EF0", VA = "0x18034A4F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x34A620", Offset = "0x349020", VA = "0x18034A620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> SlotData
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x362F80", Offset = "0x361980", VA = "0x180362F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		public int Mode
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x395A40", Offset = "0x394440", VA = "0x180395A40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x3CEC80", Offset = "0x3CD680", VA = "0x1803CEC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public SelectorNodeData SelectorNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x30EB30", Offset = "0x30D530", VA = "0x18030EB30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x364D60", Offset = "0x363760", VA = "0x180364D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x3690B0", Offset = "0x367AB0", VA = "0x1803690B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x39D3B0", Offset = "0x39BDB0", VA = "0x18039D3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[DebuggerNonUserCode]
		public int TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x57FC10", Offset = "0x57E610", VA = "0x18057FC10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x39D370", Offset = "0x39BD70", VA = "0x18039D370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public int RoleId
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x4563C0", Offset = "0x454DC0", VA = "0x1804563C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x4560C0", Offset = "0x454AC0", VA = "0x1804560C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineStateData> StateMachineData
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x364CA0", Offset = "0x3636A0", VA = "0x180364CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		public int DefaultIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x58D3E0", Offset = "0x58BDE0", VA = "0x18058D3E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xBF3CA0", Offset = "0xBF26A0", VA = "0x180BF3CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> DefaultInputSlotData
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x385EC0", Offset = "0x3848C0", VA = "0x180385EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x143F9F0", Offset = "0x143E3F0", VA = "0x18143F9F0")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x143FAF0", Offset = "0x143E4F0", VA = "0x18143FAF0")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x143EA40", Offset = "0x143D440", VA = "0x18143EA40", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x143EAA0", Offset = "0x143D4A0", VA = "0x18143EAA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x143EB00", Offset = "0x143D500", VA = "0x18143EB00", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x143ECD0", Offset = "0x143D6D0", VA = "0x18143ECD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x143F2D0", Offset = "0x143DCD0", VA = "0x18143F2D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x143F330", Offset = "0x143DD30", VA = "0x18143F330", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x143E650", Offset = "0x143D050", VA = "0x18143E650", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x143EEF0", Offset = "0x143D8F0", VA = "0x18143EEF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class SelectorNodeData : IMessage<SelectorNodeData>, IMessage, IEquatable<SelectorNodeData>, IDeepCloneable<SelectorNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly MessageParser<SelectorNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private int evalMode_;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly FieldCodec<SelectorConfigData> _repeated_selectorConfigData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private readonly RepeatedField<SelectorConfigData> selectorConfigData_;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1446220", Offset = "0x1444C20", VA = "0x181446220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1446150", Offset = "0x1444B50", VA = "0x181446150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1446280", Offset = "0x1444C80", VA = "0x181446280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public int EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x339EC0", Offset = "0x3388C0", VA = "0x180339EC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x33A090", Offset = "0x338A90", VA = "0x18033A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public RepeatedField<SelectorConfigData> SelectorConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x14460F0", Offset = "0x1444AF0", VA = "0x1814460F0")]
		[DebuggerNonUserCode]
		public SelectorNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1446030", Offset = "0x1444A30", VA = "0x181446030")]
		[DebuggerNonUserCode]
		public SelectorNodeData(SelectorNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1445A30", Offset = "0x1444430", VA = "0x181445A30", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1445B90", Offset = "0x1444590", VA = "0x181445B90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1445B10", Offset = "0x1444510", VA = "0x181445B10", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x1445C60", Offset = "0x1444660", VA = "0x181445C60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1445DB0", Offset = "0x14447B0", VA = "0x181445DB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1445E10", Offset = "0x1444810", VA = "0x181445E10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1445960", Offset = "0x1444360", VA = "0x181445960", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1445CD0", Offset = "0x14446D0", VA = "0x181445CD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class InternalGraphData : IMessage<InternalGraphData>, IMessage, IEquatable<InternalGraphData>, IDeepCloneable<InternalGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly MessageParser<InternalGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private int inputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private int outputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private CircuitNodeGraphData internalNodeGraph_;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		public static MessageParser<InternalGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1442AF0", Offset = "0x14414F0", VA = "0x181442AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1442A20", Offset = "0x1441420", VA = "0x181442A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1442B50", Offset = "0x1441550", VA = "0x181442B50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public int InputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x339EC0", Offset = "0x3388C0", VA = "0x180339EC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x33A090", Offset = "0x338A90", VA = "0x18033A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public int OutputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x4D7D80", Offset = "0x4D6780", VA = "0x1804D7D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x39D380", Offset = "0x39BD80", VA = "0x18039D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3059E0", Offset = "0x3043E0", VA = "0x1803059E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		[DebuggerNonUserCode]
		public InternalGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x14428E0", Offset = "0x14412E0", VA = "0x1814428E0")]
		[DebuggerNonUserCode]
		public InternalGraphData(InternalGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1442360", Offset = "0x1440D60", VA = "0x181442360", Slot = "9")]
		[DebuggerNonUserCode]
		public InternalGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x14424D0", Offset = "0x1440ED0", VA = "0x1814424D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1442570", Offset = "0x1440F70", VA = "0x181442570", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InternalGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x14425B0", Offset = "0x1440FB0", VA = "0x1814425B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1442720", Offset = "0x1441120", VA = "0x181442720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1442780", Offset = "0x1441180", VA = "0x181442780", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1442270", Offset = "0x1440C70", VA = "0x181442270", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1442640", Offset = "0x1441040", VA = "0x181442640", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class CircuitNodeGraphData : IMessage<CircuitNodeGraphData>, IMessage, IEquatable<CircuitNodeGraphData>, IDeepCloneable<CircuitNodeGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly MessageParser<CircuitNodeGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private ByteString nodeGraphGuid_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool isInternalGraph_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private CircuitNodeData rootNodeData_;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static readonly FieldCodec<CircuitNodeData> _repeated_circuitNodes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private readonly RepeatedField<CircuitNodeData> circuitNodes_;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x14415F0", Offset = "0x143FFF0", VA = "0x1814415F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x1441520", Offset = "0x143FF20", VA = "0x181441520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x1441650", Offset = "0x1440050", VA = "0x181441650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public ByteString NodeGraphGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x3058E0", Offset = "0x3042E0", VA = "0x1803058E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x1441760", Offset = "0x1440160", VA = "0x181441760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public bool IsInternalGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x3355F0", Offset = "0x333FF0", VA = "0x1803355F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x3356B0", Offset = "0x3340B0", VA = "0x1803356B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		public CircuitNodeData RootNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x3170C0", Offset = "0x315AC0", VA = "0x1803170C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x338A20", Offset = "0x337420", VA = "0x180338A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> CircuitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x14413B0", Offset = "0x143FDB0", VA = "0x1814413B0")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1441440", Offset = "0x143FE40", VA = "0x181441440")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData(CircuitNodeGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1440BA0", Offset = "0x143F5A0", VA = "0x181440BA0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1440CA0", Offset = "0x143F6A0", VA = "0x181440CA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1440DD0", Offset = "0x143F7D0", VA = "0x181440DD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x1440EC0", Offset = "0x143F8C0", VA = "0x181440EC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x14410D0", Offset = "0x143FAD0", VA = "0x1814410D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1441130", Offset = "0x143FB30", VA = "0x181441130", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1440A80", Offset = "0x143F480", VA = "0x181440A80", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1440F70", Offset = "0x143F970", VA = "0x181440F70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class CircuitNodeGraphCollectionData : IMessage<CircuitNodeGraphCollectionData>, IMessage, IEquatable<CircuitNodeGraphCollectionData>, IDeepCloneable<CircuitNodeGraphCollectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly MessageParser<CircuitNodeGraphCollectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly FieldCodec<CircuitNodeGraphData> _repeated_graphs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private readonly RepeatedField<CircuitNodeGraphData> graphs_;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphCollectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1440910", Offset = "0x143F310", VA = "0x181440910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1440840", Offset = "0x143F240", VA = "0x181440840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1440970", Offset = "0x143F370", VA = "0x181440970", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeGraphData> Graphs
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x3058E0", Offset = "0x3042E0", VA = "0x1803058E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x14407E0", Offset = "0x143F1E0", VA = "0x1814407E0")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1440730", Offset = "0x143F130", VA = "0x181440730")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData(CircuitNodeGraphCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x14401F0", Offset = "0x143EBF0", VA = "0x1814401F0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1440350", Offset = "0x143ED50", VA = "0x181440350", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x14402D0", Offset = "0x143ECD0", VA = "0x1814402D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x607AF0", Offset = "0x6064F0", VA = "0x180607AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x14404E0", Offset = "0x143EEE0", VA = "0x1814404E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1440540", Offset = "0x143EF40", VA = "0x181440540", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1440170", Offset = "0x143EB70", VA = "0x181440170", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1440420", Offset = "0x143EE20", VA = "0x181440420", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class SlotData : IMessage<SlotData>, IMessage, IEquatable<SlotData>, IDeepCloneable<SlotData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private static readonly MessageParser<SlotData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private int slot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private int signal_;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public static MessageParser<SlotData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x1449C90", Offset = "0x1448690", VA = "0x181449C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x1449BC0", Offset = "0x14485C0", VA = "0x181449BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1449CF0", Offset = "0x14486F0", VA = "0x181449CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x339EC0", Offset = "0x3388C0", VA = "0x180339EC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x33A090", Offset = "0x338A90", VA = "0x18033A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		public int Signal
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x4D7D80", Offset = "0x4D6780", VA = "0x1804D7D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x39D380", Offset = "0x39BD80", VA = "0x18039D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		[DebuggerNonUserCode]
		public SlotData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x601FA0", Offset = "0x6009A0", VA = "0x180601FA0")]
		[DebuggerNonUserCode]
		public SlotData(SlotData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x14499A0", Offset = "0x14483A0", VA = "0x1814499A0", Slot = "9")]
		[DebuggerNonUserCode]
		public SlotData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1449A10", Offset = "0x1448410", VA = "0x181449A10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x601D10", Offset = "0x600710", VA = "0x180601D10", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SlotData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x601D30", Offset = "0x600730", VA = "0x180601D30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1449AA0", Offset = "0x14484A0", VA = "0x181449AA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x601E70", Offset = "0x600870", VA = "0x180601E70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x14498E0", Offset = "0x14482E0", VA = "0x1814498E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x601DB0", Offset = "0x6007B0", VA = "0x180601DB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class SelectorConfigData : IMessage<SelectorConfigData>, IMessage, IEquatable<SelectorConfigData>, IDeepCloneable<SelectorConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private static readonly MessageParser<SelectorConfigData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private int compareMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private int compareValue_;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorConfigData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x14457F0", Offset = "0x14441F0", VA = "0x1814457F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x1445720", Offset = "0x1444120", VA = "0x181445720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x1445850", Offset = "0x1444250", VA = "0x181445850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public int CompareMode
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x339EC0", Offset = "0x3388C0", VA = "0x180339EC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x33A090", Offset = "0x338A90", VA = "0x18033A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public int CompareValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x4D7D80", Offset = "0x4D6780", VA = "0x1804D7D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x39D380", Offset = "0x39BD80", VA = "0x18039D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		[DebuggerNonUserCode]
		public SelectorConfigData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x601FA0", Offset = "0x6009A0", VA = "0x180601FA0")]
		[DebuggerNonUserCode]
		public SelectorConfigData(SelectorConfigData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1445500", Offset = "0x1443F00", VA = "0x181445500", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorConfigData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1445570", Offset = "0x1443F70", VA = "0x181445570", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x601D10", Offset = "0x600710", VA = "0x180601D10", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorConfigData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x601D30", Offset = "0x600730", VA = "0x180601D30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1445600", Offset = "0x1444000", VA = "0x181445600", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x601E70", Offset = "0x600870", VA = "0x180601E70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1445440", Offset = "0x1443E40", VA = "0x181445440", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x601DB0", Offset = "0x6007B0", VA = "0x180601DB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class StateMachineStateData : IMessage<StateMachineStateData>, IMessage, IEquatable<StateMachineStateData>, IDeepCloneable<StateMachineStateData>
	{
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private static readonly MessageParser<StateMachineStateData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private int val1_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private int val2_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private int val3_;

		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private static readonly FieldCodec<StateMachineTransitionData> _repeated_stateTransitionData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private readonly RepeatedField<StateMachineTransitionData> stateTransitionData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int minTimeInState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private int removed_;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineStateData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x144CD90", Offset = "0x144B790", VA = "0x18144CD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x144CCC0", Offset = "0x144B6C0", VA = "0x18144CCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x144CDF0", Offset = "0x144B7F0", VA = "0x18144CDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public int Val1
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x339EC0", Offset = "0x3388C0", VA = "0x180339EC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x33A090", Offset = "0x338A90", VA = "0x18033A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public int Val2
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x4D7D80", Offset = "0x4D6780", VA = "0x1804D7D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x39D380", Offset = "0x39BD80", VA = "0x18039D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public int Val3
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x393780", Offset = "0x392180", VA = "0x180393780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x3937A0", Offset = "0x3921A0", VA = "0x1803937A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineTransitionData> StateTransitionData
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x3170C0", Offset = "0x315AC0", VA = "0x1803170C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5180B0", Offset = "0x516AB0", VA = "0x1805180B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x521B10", Offset = "0x520510", VA = "0x180521B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[DebuggerNonUserCode]
		public int Removed
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x4CBE00", Offset = "0x4CA800", VA = "0x1804CBE00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4CBE10", Offset = "0x4CA810", VA = "0x1804CBE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x144CB90", Offset = "0x144B590", VA = "0x18144CB90")]
		[DebuggerNonUserCode]
		public StateMachineStateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x144CBF0", Offset = "0x144B5F0", VA = "0x18144CBF0")]
		[DebuggerNonUserCode]
		public StateMachineStateData(StateMachineStateData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x144C3B0", Offset = "0x144ADB0", VA = "0x18144C3B0", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineStateData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x144C550", Offset = "0x144AF50", VA = "0x18144C550", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x144C4B0", Offset = "0x144AEB0", VA = "0x18144C4B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineStateData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x144C640", Offset = "0x144B040", VA = "0x18144C640", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x144C860", Offset = "0x144B260", VA = "0x18144C860", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x144C8C0", Offset = "0x144B2C0", VA = "0x18144C8C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x144C210", Offset = "0x144AC10", VA = "0x18144C210", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x144C710", Offset = "0x144B110", VA = "0x18144C710", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class StateMachineTransitionData : IMessage<StateMachineTransitionData>, IMessage, IEquatable<StateMachineTransitionData>, IDeepCloneable<StateMachineTransitionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private static readonly MessageParser<StateMachineTransitionData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private int inputIndex_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int stateIndex_;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineTransitionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x144D2B0", Offset = "0x144BCB0", VA = "0x18144D2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x144D1E0", Offset = "0x144BBE0", VA = "0x18144D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x144D310", Offset = "0x144BD10", VA = "0x18144D310", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public int InputIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x339EC0", Offset = "0x3388C0", VA = "0x180339EC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x33A090", Offset = "0x338A90", VA = "0x18033A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public int StateIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x4D7D80", Offset = "0x4D6780", VA = "0x1804D7D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x39D380", Offset = "0x39BD80", VA = "0x18039D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x601FA0", Offset = "0x6009A0", VA = "0x180601FA0")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData(StateMachineTransitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x144CFC0", Offset = "0x144B9C0", VA = "0x18144CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x144D030", Offset = "0x144BA30", VA = "0x18144D030", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x601D10", Offset = "0x600710", VA = "0x180601D10", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineTransitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x601D30", Offset = "0x600730", VA = "0x180601D30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x144D0C0", Offset = "0x144BAC0", VA = "0x18144D0C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x601E70", Offset = "0x600870", VA = "0x180601E70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x144CF00", Offset = "0x144B900", VA = "0x18144CF00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x601DB0", Offset = "0x6007B0", VA = "0x180601DB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class NodeTransformDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x1443450", Offset = "0x1441E50", VA = "0x181443450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1442E40", Offset = "0x1441840", VA = "0x181442E40")]
		static NodeTransformDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NodeTransformData : IMessage<NodeTransformData>, IMessage, IEquatable<NodeTransformData>, IDeepCloneable<NodeTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private static readonly MessageParser<NodeTransformData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private Vector3Data position_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private Vector3Data rotation_;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		[DebuggerNonUserCode]
		public static MessageParser<NodeTransformData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x1443B70", Offset = "0x1442570", VA = "0x181443B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x1443AA0", Offset = "0x14424A0", VA = "0x181443AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x1443BD0", Offset = "0x14425D0", VA = "0x181443BD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		[DebuggerNonUserCode]
		public Vector3Data Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x3058E0", Offset = "0x3042E0", VA = "0x1803058E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3059D0", Offset = "0x3043D0", VA = "0x1803059D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		public Vector3Data Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x3059E0", Offset = "0x3043E0", VA = "0x1803059E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		[DebuggerNonUserCode]
		public NodeTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1443A30", Offset = "0x1442430", VA = "0x181443A30")]
		[DebuggerNonUserCode]
		public NodeTransformData(NodeTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1443570", Offset = "0x1441F70", VA = "0x181443570", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1443610", Offset = "0x1442010", VA = "0x181443610", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x14436C0", Offset = "0x14420C0", VA = "0x1814436C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1443720", Offset = "0x1442120", VA = "0x181443720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1443890", Offset = "0x1442290", VA = "0x181443890", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x14438F0", Offset = "0x14422F0", VA = "0x1814438F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x14434B0", Offset = "0x1441EB0", VA = "0x1814434B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1443790", Offset = "0x1442190", VA = "0x181443790", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class Vector3DataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x1450F00", Offset = "0x144F900", VA = "0x181450F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1450B60", Offset = "0x144F560", VA = "0x181450B60")]
		static Vector3DataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private static readonly MessageParser<Vector3Data> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private float x_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private float y_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x1451250", Offset = "0x144FC50", VA = "0x181451250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x1451180", Offset = "0x144FB80", VA = "0x181451180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x14512B0", Offset = "0x144FCB0", VA = "0x1814512B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x33DA60", Offset = "0x33C460", VA = "0x18033DA60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x33DB90", Offset = "0x33C590", VA = "0x18033DB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x33DA70", Offset = "0x33C470", VA = "0x18033DA70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x33DBA0", Offset = "0x33C5A0", VA = "0x18033DBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x33DA80", Offset = "0x33C480", VA = "0x18033DA80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x33DBB0", Offset = "0x33C5B0", VA = "0x18033DBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x33D8E0", Offset = "0x33C2E0", VA = "0x18033D8E0")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1450F60", Offset = "0x144F960", VA = "0x181450F60", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1450FD0", Offset = "0x144F9D0", VA = "0x181450FD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x33D560", Offset = "0x33BF60", VA = "0x18033D560", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x33D5A0", Offset = "0x33BFA0", VA = "0x18033D5A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1451060", Offset = "0x144FA60", VA = "0x181451060", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x33D760", Offset = "0x33C160", VA = "0x18033D760", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x33D420", Offset = "0x33BE20", VA = "0x18033D420", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x33D680", Offset = "0x33C080", VA = "0x18033D680", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
namespace RecRoom.Circuits.PlayerStats
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum CircuitPlayerStat
	{
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		Player_Health = 0,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		Player_Shield = 1,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		PlayerStat_1 = 1000,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		PlayerStat_2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		PlayerStat_3 = 1002,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		PlayerStat_4 = 1003,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		PlayerStat_5 = 1004,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		PlayerStat_6 = 1005
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class FriendlyCircuitPlayerStats
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static Dictionary<string, int> friendlyCircuitPlayerStatsDict;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public static Dictionary<string, int> FriendlyCircuitPlayerStatsDict
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x172A0B0", Offset = "0x1728AB0", VA = "0x18172A0B0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CircuitNodeUuid("FC94A1CD-DD7E-4229-92DF-95991A9E6369")]
	public class PlayerGetStatNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public delegate int GetPlayerStatFunction(CircuitPlayerStat stat, int playerId);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private int masterLastPlayerStatSignal;

		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x1220AA0", Offset = "0x121F4A0", VA = "0x181220AA0")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x172E870", Offset = "0x172D270", VA = "0x18172E870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event GetPlayerStatFunction GetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x172E730", Offset = "0x172D130", VA = "0x18172E730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x172E7D0", Offset = "0x172D1D0", VA = "0x18172E7D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x172E6B0", Offset = "0x172D0B0", VA = "0x18172E6B0")]
		public PlayerGetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x172E4C0", Offset = "0x172CEC0", VA = "0x18172E4C0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x172E2D0", Offset = "0x172CCD0", VA = "0x18172E2D0")]
		private int GetStatSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x172E400", Offset = "0x172CE00", VA = "0x18172E400", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x172E0C0", Offset = "0x172CAC0", VA = "0x18172E0C0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x172E130", Offset = "0x172CB30", VA = "0x18172E130", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x172E270", Offset = "0x172CC70", VA = "0x18172E270", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x172E190", Offset = "0x172CB90", VA = "0x18172E190", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x172E3A0", Offset = "0x172CDA0", VA = "0x18172E3A0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x172E470", Offset = "0x172CE70", VA = "0x18172E470", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x172E500", Offset = "0x172CF00", VA = "0x18172E500", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CircuitNodeUuid("5A15E563-2F73-41B6-9CDF-6C9FB065A034")]
	public class PlayerSetStatNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate void SetPlayerStatFunction(CircuitPlayerStat stat, int playerId, int signal);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x1220AA0", Offset = "0x121F4A0", VA = "0x181220AA0")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x172E870", Offset = "0x172D270", VA = "0x18172E870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event SetPlayerStatFunction SetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x17307D0", Offset = "0x172F1D0", VA = "0x1817307D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x1730870", Offset = "0x172F270", VA = "0x181730870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1730770", Offset = "0x172F170", VA = "0x181730770")]
		public PlayerSetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1730480", Offset = "0x172EE80", VA = "0x181730480", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1730460", Offset = "0x172EE60", VA = "0x181730460")]
		private void PostEvalSetPlayerStat(CircuitPlayerStat stat, int playerId, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x17302E0", Offset = "0x172ECE0", VA = "0x1817302E0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1730420", Offset = "0x172EE20", VA = "0x181730420", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1730340", Offset = "0x172ED40", VA = "0x181730340", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x172E3A0", Offset = "0x172CDA0", VA = "0x18172E3A0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x172E470", Offset = "0x172CE70", VA = "0x18172E470", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x17305B0", Offset = "0x172EFB0", VA = "0x1817305B0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
}
namespace RecRoom.Circuits.GameStats
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CircuitNodeUuid("2F4A96DA-842F-4F41-84BB-1F283DADB769")]
	public class GameGetScoreNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public delegate int GetTeamScoreFunction(int teamId);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private int masterLastScoreSignal;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event GetTeamScoreFunction GetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x172A700", Offset = "0x1729100", VA = "0x18172A700")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x172A7A0", Offset = "0x17291A0", VA = "0x18172A7A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x172A680", Offset = "0x1729080", VA = "0x18172A680")]
		public GameGetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x172A550", Offset = "0x1728F50", VA = "0x18172A550", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x172A420", Offset = "0x1728E20", VA = "0x18172A420")]
		private int GetScoreSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x172A4E0", Offset = "0x1728EE0", VA = "0x18172A4E0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x172A2F0", Offset = "0x1728CF0", VA = "0x18172A2F0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x172A360", Offset = "0x1728D60", VA = "0x18172A360", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x172A3C0", Offset = "0x1728DC0", VA = "0x18172A3C0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CircuitNodeUuid("B79A6285-498A-4748-B960-FA33F4C5CB02")]
	public class GameSetScoreNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate void SetTeamScoreFunction(int teamId, int signal, bool isWinner);

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event SetTeamScoreFunction SetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x172AC00", Offset = "0x1729600", VA = "0x18172AC00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x172ACA0", Offset = "0x17296A0", VA = "0x18172ACA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x172ABA0", Offset = "0x17295A0", VA = "0x18172ABA0")]
		public GameSetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x172A900", Offset = "0x1729300", VA = "0x18172A900", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x172A8E0", Offset = "0x17292E0", VA = "0x18172A8E0")]
		private void PostEvalSetGameScoreStat(int teamId, int score, bool isWinner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x172A840", Offset = "0x1729240", VA = "0x18172A840", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x172A8A0", Offset = "0x17292A0", VA = "0x18172A8A0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
}
namespace RecRoom.Circuits.Traversal
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Flags]
	public enum DFSType
	{
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		DirectedForward = 1,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		DirectedBackward = 2,
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		Undirected = 3
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[Flags]
	public enum LinkTypes
	{
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		NormalToNormal = 1,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		NormalToVirtual = 2,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		VirtualToNormal = 4,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		RootToVirtual = 8,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		RootToNormal = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	internal struct TopologicStackEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public CircuitNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public bool IsParent;
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public static class GraphTraversal
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class <DFS>d__4 : IEnumerable<CircuitNode>, IEnumerable, IEnumerator<CircuitNode>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			private CircuitNode <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			private CircuitNode root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public CircuitNode <>3__root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			private DFSType dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public DFSType <>3__dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private LinkTypes linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public LinkTypes <>3__linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			private Stack<CircuitNode> <stack>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			private HashSet<CircuitNode> <visited>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			private CircuitNode <current>5__4;

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			CircuitNode IEnumerator<CircuitNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x996800", Offset = "0x995200", VA = "0x180996800")]
			[DebuggerHidden]
			public <DFS>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x144E1B0", Offset = "0x144CBB0", VA = "0x18144E1B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x144E7B0", Offset = "0x144D1B0", VA = "0x18144E7B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x144E700", Offset = "0x144D100", VA = "0x18144E700", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<CircuitNode> IEnumerable<CircuitNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x144E700", Offset = "0x144D100", VA = "0x18144E700", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1441850", Offset = "0x1440250", VA = "0x181441850")]
		public static HashSet<CircuitNode> DFSCopy(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1441910", Offset = "0x1440310", VA = "0x181441910")]
		[IteratorStateMachine(typeof(<DFS>d__4))]
		public static IEnumerable<CircuitNode> DFS(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1441CC0", Offset = "0x14406C0", VA = "0x181441CC0")]
		public static List<CircuitNode> TopologicSort(CircuitNode root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1441CA0", Offset = "0x14406A0", VA = "0x181441CA0")]
		private static bool ShouldFollowLink(CircuitLink link, LinkTypes linkTypesToFollow)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x14419A0", Offset = "0x14403A0", VA = "0x1814419A0")]
		public static LinkTypes FindLinkType(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(LinkTypes);
		}
	}
}
namespace RecRoom.Circuits.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public static class ByteStringExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x143A510", Offset = "0x1438F10", VA = "0x18143A510")]
		public static Guid ToGuid(this ByteString bytes)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x143A4B0", Offset = "0x1438EB0", VA = "0x18143A4B0")]
		public static ByteString ToByteString(this Guid guid)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum CircuitLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		Error
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public static class CircuitDebug
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public delegate void LogEvent(CircuitLogLevel level, string message);

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public delegate void LogExceptionEvent(Exception e, string message);

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event LogEvent OnLogEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x143A9C0", Offset = "0x14393C0", VA = "0x18143A9C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x143ABB0", Offset = "0x14395B0", VA = "0x18143ABB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public static event LogExceptionEvent OnLogExceptionEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x143AAB0", Offset = "0x14394B0", VA = "0x18143AAB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x143ACA0", Offset = "0x14396A0", VA = "0x18143ACA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x143A690", Offset = "0x1439090", VA = "0x18143A690")]
		public static void LogException(Exception e, [Optional] string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x143A760", Offset = "0x1439160", VA = "0x18143A760")]
		public static void Log(CircuitLogLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x143A920", Offset = "0x1439320", VA = "0x18143A920")]
		public static void NodeLog(int nodeId, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x143A830", Offset = "0x1439230", VA = "0x18143A830")]
		public static void NodeLogFormat(int nodeId, CircuitLogLevel CircuitLogLevel, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x143A5F0", Offset = "0x1438FF0", VA = "0x18143A5F0")]
		public static void GraphLog(Guid graphGuid, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal static class NodeEventUtil
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1442DB0", Offset = "0x14417B0", VA = "0x181442DB0")]
		internal static void SafeInvoke(this CircuitNode.NodeLifecycleEvent nodeLifecycleEvent, CircuitNode nodeArg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1442CF0", Offset = "0x14416F0", VA = "0x181442CF0")]
		internal static void SafeInvoke(this CircuitNode.NodeConnectionChanged nodeConnectionEvent, CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal static class RuntimeAssert
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x14453D0", Offset = "0x1443DD0", VA = "0x1814453D0")]
		public static void Assert(bool condition, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1445340", Offset = "0x1443D40", VA = "0x181445340")]
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
