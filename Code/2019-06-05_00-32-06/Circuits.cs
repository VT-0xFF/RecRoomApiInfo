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
			[Cpp2IlInjected.Address(RVA = "0x1661040", Offset = "0x165F640", VA = "0x181661040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1660F90", Offset = "0x165F590", VA = "0x181660F90")]
		public CircuitLink(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1660CA0", Offset = "0x165F2A0", VA = "0x181660CA0")]
		public CircuitLinkData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1660AA0", Offset = "0x165F0A0", VA = "0x181660AA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1660BF0", Offset = "0x165F1F0", VA = "0x181660BF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1660D50", Offset = "0x165F350", VA = "0x181660D50", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x30C610", Offset = "0x30AC10", VA = "0x18030C610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1665F90", Offset = "0x1664590", VA = "0x181665F90")]
		public CircuitNodeUuidAttribute(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1665F20", Offset = "0x1664520", VA = "0x181665F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x166FD40", Offset = "0x166E340", VA = "0x18166FD40", Slot = "4")]
		public bool Equals(InputSlot x, InputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x166FD60", Offset = "0x166E360", VA = "0x18166FD60", Slot = "5")]
		public int GetHashCode(InputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public InputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class OutputSlotComparer : IEqualityComparer<OutputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x166FD40", Offset = "0x166E340", VA = "0x18166FD40", Slot = "4")]
		public bool Equals(OutputSlot x, OutputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x166FD60", Offset = "0x166E360", VA = "0x18166FD60", Slot = "5")]
		public int GetHashCode(OutputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
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
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public bool IsMomentary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int ExecutionOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private OutputSignal[] OutputSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private OutputSignal[] outputValuesDeserializationBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Dictionary<InputSlot, CircuitLink> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Dictionary<OutputSlot, HashSet<CircuitLink>> Outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NodeMetadataChanged NodeMetadataChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private CircuitNodeGraph _nodeGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ThisNodeConnectionChanged OnConnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static NodeConnectionChanged OnNodesConnectedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ThisNodeConnectionChanged OnDisconnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static NodeConnectionChanged OnNodesDisconnectedEvent;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static Dictionary<int, CircuitNode> AllNodes;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static InputMetadata[] allSlotsInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static OutputMetadata[] allSlotsOutputMetadata;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal virtual bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal virtual bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal virtual bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal virtual bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CircuitNode PairedNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HasConnectedInputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x166B460", Offset = "0x1669A60", VA = "0x18166B460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HasConnectedOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x166B570", Offset = "0x1669B70", VA = "0x18166B570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2F4B50", Offset = "0x2F3150", VA = "0x1802F4B50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x303810", Offset = "0x301E10", VA = "0x180303810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAA0", Offset = "0x2EA0A0", VA = "0x1802EBAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public virtual int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x31B510", Offset = "0x319B10", VA = "0x18031B510", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected virtual OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x166B650", Offset = "0x1669C50", VA = "0x18166B650", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NodeMetadata NodeMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x166B630", Offset = "0x1669C30", VA = "0x18166B630")]
			[CompilerGenerated]
			get
			{
				return default(NodeMetadata);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x166B7F0", Offset = "0x1669DF0", VA = "0x18166B7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CircuitNodeGraph NodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3AF4C0", Offset = "0x3ADAC0", VA = "0x1803AF4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8F0BB0", Offset = "0x8EF1B0", VA = "0x1808F0BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8F0BC0", Offset = "0x8EF1C0", VA = "0x1808F0BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int NodeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x166B5C0", Offset = "0x1669BC0", VA = "0x18166B5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static InputMetadata[] AllSlotsInputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x166B0D0", Offset = "0x16696D0", VA = "0x18166B0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static OutputMetadata[] AllSlotsOutputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x166B290", Offset = "0x1669890", VA = "0x18166B290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NodeModifiedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x166B030", Offset = "0x1669630", VA = "0x18166B030")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x166B750", Offset = "0x1669D50", VA = "0x18166B750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NodeDeserializedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x166AF90", Offset = "0x1669590", VA = "0x18166AF90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x166B6B0", Offset = "0x1669CB0", VA = "0x18166B6B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1669180", Offset = "0x1667780", VA = "0x181669180")]
		public static int NewNodeId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x166AA60", Offset = "0x1669060", VA = "0x18166AA60")]
		internal static int SetPossibleMaxId(int newPossibleMax)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16697B0", Offset = "0x1667DB0", VA = "0x1816697B0")]
		public static void ResetMaxNodeId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1668D90", Offset = "0x1667390", VA = "0x181668D90")]
		public static long GetMaxNodeId()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x16692B0", Offset = "0x16678B0", VA = "0x1816692B0")]
		internal static void OverrideMaxNodeId(long overrideValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x16698B0", Offset = "0x1667EB0", VA = "0x1816698B0")]
		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1669920", Offset = "0x1667F20", VA = "0x181669920")]
		private static void SendNodeInstantiatedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract InputMetadata[] GetInputMetadata();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract OutputMetadata[] GetOutputMetadata();

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0", Slot = "13")]
		protected virtual string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x166AD30", Offset = "0x1669330", VA = "0x18166AD30")]
		public CircuitNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x16693D0", Offset = "0x16679D0", VA = "0x1816693D0")]
		protected void ReconstructNodeMetadata()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1669E30", Offset = "0x1668430", VA = "0x181669E30", Slot = "14")]
		public virtual CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1668F50", Offset = "0x1667550", VA = "0x181668F50", Slot = "15")]
		internal virtual void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1667250", Offset = "0x1665850", VA = "0x181667250")]
		public void CopySettings(CircuitNodeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x16672E0", Offset = "0x16658E0", VA = "0x1816672E0")]
		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1669E20", Offset = "0x1668420", VA = "0x181669E20", Slot = "16")]
		internal virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1667D20", Offset = "0x1666320", VA = "0x181667D20", Slot = "17")]
		internal virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "18")]
		internal virtual void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "19")]
		internal virtual void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1669C30", Offset = "0x1668230", VA = "0x181669C30")]
		private void SerializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1667AF0", Offset = "0x16660F0", VA = "0x181667AF0")]
		private void DeserializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x166A720", Offset = "0x1668D20", VA = "0x18166A720")]
		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1666A80", Offset = "0x1665080", VA = "0x181666A80")]
		internal static bool ConnectNodes(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1669990", Offset = "0x1667F90", VA = "0x181669990")]
		private static void SendNodesConnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1669AE0", Offset = "0x16680E0", VA = "0x181669AE0")]
		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1665FE0", Offset = "0x16645E0", VA = "0x181665FE0")]
		private static void AddLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1668BB0", Offset = "0x16671B0", VA = "0x181668BB0")]
		internal static bool FormsLoop(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x16670E0", Offset = "0x16656E0", VA = "0x1816670E0")]
		public bool ConnectToMyInput(CircuitNode sourceNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x16660D0", Offset = "0x16646D0", VA = "0x1816660D0")]
		protected bool CanConnectInput(CircuitNode newSourceNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x16671A0", Offset = "0x16657A0", VA = "0x1816671A0")]
		public bool ConnectToMyOutput(CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x16661A0", Offset = "0x16647A0", VA = "0x1816661A0")]
		protected bool CanConnectOutput(InputSlot inputSlot, OutputSlot outputSlot, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x166ABF0", Offset = "0x16691F0", VA = "0x18166ABF0")]
		protected bool SlotsCanConnect(InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x16680F0", Offset = "0x16666F0", VA = "0x1816680F0")]
		public void DisconnectInput(InputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1667D30", Offset = "0x1666330", VA = "0x181667D30", Slot = "20")]
		public virtual void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x16688D0", Offset = "0x1666ED0", VA = "0x1816688D0")]
		public void DisconnectOutput(OutputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1668190", Offset = "0x1666790", VA = "0x181668190")]
		protected static void DisconnectNodeLink(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1669520", Offset = "0x1667B20", VA = "0x181669520")]
		private static void RemoveLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1669630", Offset = "0x1667C30", VA = "0x181669630")]
		private static bool RemoveOutputLink(CircuitNode node, CircuitLink link)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1669460", Offset = "0x1667A60", VA = "0x181669460")]
		private static bool RemoveInputSlot(CircuitNode node, InputSlot inputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x16663A0", Offset = "0x16649A0", VA = "0x1816663A0")]
		private static bool CheckForDisconnectedGraph(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1668A60", Offset = "0x1667060", VA = "0x181668A60")]
		internal void EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "21")]
		internal virtual void PostEvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1668EF0", Offset = "0x16674F0", VA = "0x181668EF0")]
		public bool HasMomentaryOutputs()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x16668E0", Offset = "0x1664EE0", VA = "0x1816668E0")]
		public void ClearMomentaryOutputs(int currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "22")]
		protected virtual void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x166AC10", Offset = "0x1669210", VA = "0x18166AC10", Slot = "23")]
		protected virtual void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x16669D0", Offset = "0x1664FD0", VA = "0x1816669D0")]
		protected void ClearOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1668C90", Offset = "0x1667290", VA = "0x181668C90")]
		public int GetInputSignal(InputSlot inputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1668D50", Offset = "0x1667350", VA = "0x181668D50")]
		public int GetLastOutputSignalTimeStamp(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1668EB0", Offset = "0x16674B0", VA = "0x181668EB0")]
		public int GetOutputSignal(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x166A6E0", Offset = "0x1668CE0", VA = "0x18166A6E0")]
		protected void SetContinuousOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x166A700", Offset = "0x1668D00", VA = "0x18166A700")]
		protected void SetMomentaryOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x166A930", Offset = "0x1668F30", VA = "0x18166A930")]
		private void SetOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1669130", Offset = "0x1667730", VA = "0x181669130")]
		public void ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60C6D0", Offset = "0x60ACD0", VA = "0x18060C6D0")]
		public void SendDeserializedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "24")]
		protected virtual void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1666710", Offset = "0x1664D10", VA = "0x181666710")]
		internal static void ClearAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1668B20", Offset = "0x1667120", VA = "0x181668B20")]
		public static CircuitNode Find(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x10EE8D0", Offset = "0x10ECED0", VA = "0x1810EE8D0")]
		public static int BoolToSignal(bool value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x12A5990", Offset = "0x12A3F90", VA = "0x1812A5990")]
		public static bool SignalToBool(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1666690", Offset = "0x1664C90", VA = "0x181666690")]
		public static int ClampSignal(int value, int min, int max)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class DictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1624BC0", Offset = "0x16231C0", VA = "0x181624BC0")]
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
			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public CircuitNodeGraphCollectionData GraphCollectionData
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
			public SerializedCircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class CircuitNodeGraphCopy
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public List<CircuitNodeGraph> CopiedGraphs
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
			public CircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static List<CircuitNodeGraph> AllGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly Guid GraphGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly bool IsInternalGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private RootNode _rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool GraphRequiresSort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal readonly HashSet<CircuitNode> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly List<CircuitNode> StatefulNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private List<CircuitNode> ReverseTopologicNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool destroyed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private HashSet<CircuitNode> needsPostEval;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static BitPacker bitPacker;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public RootNode RootNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAA0", Offset = "0x2EA0A0", VA = "0x1802EBAA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool NodeGraphDirty
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2E61D0", Offset = "0x2E47D0", VA = "0x1802E61D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x308F40", Offset = "0x307540", VA = "0x180308F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2FA790", Offset = "0x2F8D90", VA = "0x1802FA790")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2FA7E0", Offset = "0x2F8DE0", VA = "0x1802FA7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		internal static event UpdateGraph TimeUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1665D20", Offset = "0x1664320", VA = "0x181665D20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1665E20", Offset = "0x1664420", VA = "0x181665E20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1665C90", Offset = "0x1664290", VA = "0x181665C90")]
		internal CircuitNodeGraph(bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1665C60", Offset = "0x1664260", VA = "0x181665C60")]
		public CircuitNodeGraph(Guid guid, bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1665AE0", Offset = "0x16640E0", VA = "0x181665AE0")]
		private CircuitNodeGraph(Guid guid, bool isInternalGraph, bool createRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1665850", Offset = "0x1663E50", VA = "0x181665850")]
		public static void Update(int networkTimeMilliseconds, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1663D00", Offset = "0x1662300", VA = "0x181663D00")]
		private void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1663BB0", Offset = "0x16621B0", VA = "0x181663BB0")]
		public void DestroySelfAndNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x16615B0", Offset = "0x165FBB0", VA = "0x1816615B0")]
		internal void AddNode(CircuitNode circuitNode, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1664B70", Offset = "0x1663170", VA = "0x181664B70")]
		internal bool RemoveNode(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1663D90", Offset = "0x1662390", VA = "0x181663D90")]
		public List<CircuitNode> Evaluate(bool isMasterClient)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1661820", Offset = "0x165FE20", VA = "0x181661820", Slot = "4")]
		public int CompareTo(CircuitNodeGraph other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1665520", Offset = "0x1663B20", VA = "0x181665520")]
		public static byte[] SerializeRuntimeState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x16630F0", Offset = "0x16616F0", VA = "0x1816630F0")]
		public static void DeserializeRuntimeState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x16651F0", Offset = "0x16637F0", VA = "0x1816651F0")]
		public static byte[] SerializePostEvaluateState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1662DC0", Offset = "0x16613C0", VA = "0x181662DC0")]
		public static void DeserializePostEvaluateState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x16646E0", Offset = "0x1662CE0", VA = "0x1816646E0")]
		public static CircuitNodeGraphCollectionData PersistAll([Optional] IList<int> inactiveIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1663B10", Offset = "0x1662110", VA = "0x181663B10")]
		public static void DestroyAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x16629C0", Offset = "0x1660FC0", VA = "0x1816629C0")]
		public static void DeserializeAll(CircuitNodeGraphCollectionData data, out Dictionary<int, int> nodeIdMappings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x16648C0", Offset = "0x1662EC0", VA = "0x1816648C0")]
		public CircuitNodeGraphData Persist()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1663420", Offset = "0x1661A20", VA = "0x181663420")]
		public static CircuitNodeGraph Deserialize(CircuitNodeGraphData data, bool reassignNodeIds, out Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1661860", Offset = "0x165FE60", VA = "0x181661860")]
		public static CircuitNodeGraphCopy CopyNodesToNewGraphs(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1664CD0", Offset = "0x16632D0", VA = "0x181664CD0")]
		public static SerializedCircuitNodeGraphCopy SerializeNodesAsNewGraph(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x16641A0", Offset = "0x16627A0", VA = "0x1816641A0")]
		public static CircuitNodeGraph MergeGraphs(CircuitNode nodeA, CircuitNode nodeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1664400", Offset = "0x1662A00", VA = "0x181664400")]
		private static CircuitNodeGraph MergeInto(CircuitNodeGraph toGraph, CircuitNodeGraph fromGraph, params CircuitNode[] nodes)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum InputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		R,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		G,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		B,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		C,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		M,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		K,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		VIRTUAL,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		H00,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		H01,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		H02,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		H03,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		H04,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		H05,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		H06,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		H07,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		H08,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		H09,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		H10,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		H11,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		H12,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		H13,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		H14,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		H15,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		H16,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		H17,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		H18,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		H19,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		H20,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		H21,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		H22,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		H23,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		H24,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		H25,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		H26,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		H27,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		H28,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		H29,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		H30,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		H31,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		H32,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		H33,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		H34,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		H35,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		H36,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		H37,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		H38,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		H39,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		H40,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		H41,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		H42,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		H43,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		H44,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		H45,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		H46,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		H47,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		H48,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		H49,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		H50,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		H51,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		H52,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		H53,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		H54,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		H55,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		H56,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		H57,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		H58,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		H59,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		H60,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		H61,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		H62,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		H63,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		H64,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		H65,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		H66,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		H67,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		H68,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		H69,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		H70,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		H71,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		H72,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		H73,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		H74,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		H75,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		H76,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		H77,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		H78,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		H79,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		H80,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		H81,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		H82,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		H83,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		H84,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		H85,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		H86,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		H87,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		H88,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		H89,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		H90,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		H91,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		H92,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		H93,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		H94,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		H95,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		H96,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		H97,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		H98,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		H99
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum OutputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		R,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		G,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		B,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		C,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		M,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		K,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		VIRTUAL,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		H00,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		H01,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		H02,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		H03,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		H04,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		H05,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		H06,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		H07,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		H08,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		H09,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		H10,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		H11,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		H12,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		H13,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		H14,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		H15,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		H16,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		H17,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		H18,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		H19,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		H20,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		H21,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		H22,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		H23,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		H24,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		H25,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		H26,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		H27,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		H28,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		H29,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		H30,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		H31,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		H32,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		H33,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		H34,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		H35,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		H36,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		H37,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		H38,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		H39,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		H40,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		H41,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		H42,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		H43,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		H44,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		H45,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		H46,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		H47,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		H48,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		H49,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		H50,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		H51,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		H52,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		H53,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		H54,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		H55,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		H56,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		H57,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		H58,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		H59,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		H60,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		H61,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		H62,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		H63,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		H64,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		H65,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		H66,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		H67,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		H68,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		H69,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		H70,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		H71,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		H72,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		H73,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		H74,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		H75,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		H76,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		H77,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		H78,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		H79,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		H80,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		H81,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		H82,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		H83,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		H84,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		H85,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		H86,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		H87,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		H88,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		H89,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		H90,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		H91,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		H92,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		H93,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		H94,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		H95,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		H96,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		H97,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		H98,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		H99
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class IOSlots
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static InputSlot[] AllInputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static InputSlot[] AllStandardInputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static OutputSlot[] AllOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static OutputSlot[] AllStandardOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xE4EC50", Offset = "0xE4D250", VA = "0x180E4EC50")]
		public static OutputSlot InputSlotToOutputSlot(InputSlot input)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE4EC50", Offset = "0xE4D250", VA = "0x180E4EC50")]
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
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			And,
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			Or,
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			Not
		}

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private static readonly InputMetadata[] NotInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private static readonly OutputMetadata[] NotOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly Dictionary<BooleanModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private BooleanModes booleanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private List<int> inputs;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BooleanModes BooleanMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(BooleanModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x13437A0", Offset = "0x1341DA0", VA = "0x1813437A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1660280", Offset = "0x165E880", VA = "0x181660280")]
		public static string GetModeSymbol(BooleanModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1660970", Offset = "0x165EF70", VA = "0x181660970")]
		public BooleanNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1660520", Offset = "0x165EB20", VA = "0x181660520", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x165FE70", Offset = "0x165E470", VA = "0x18165FE70")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x165FC30", Offset = "0x165E230", VA = "0x18165FC30")]
		private bool CalcAndOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x165FD50", Offset = "0x165E350", VA = "0x18165FD50")]
		private bool CalcOrOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x16600D0", Offset = "0x165E6D0", VA = "0x1816600D0")]
		private void FetchInputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x16601F0", Offset = "0x165E7F0", VA = "0x1816601F0", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x16603C0", Offset = "0x165E9C0", VA = "0x1816603C0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1660300", Offset = "0x165E900", VA = "0x181660300", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1660460", Offset = "0x165EA60", VA = "0x181660460", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x16604D0", Offset = "0x165EAD0", VA = "0x1816604D0", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x16605F0", Offset = "0x165EBF0", VA = "0x1816605F0", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CircuitNodeUuid("B7BA1A4B-EA04-496F-B8B6-A2FB7C4A42B9")]
	public class ContinuousSourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x166D1D0", Offset = "0x166B7D0", VA = "0x18166D1D0")]
		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x166A6E0", Offset = "0x1668CE0", VA = "0x18166A6E0")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CircuitNodeUuid("53219714-E7BB-4950-BBB3-852A7EF196F8")]
	public class GameSetStateNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action StartGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x166F100", Offset = "0x166D700", VA = "0x18166F100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x166F240", Offset = "0x166D840", VA = "0x18166F240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action EndGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x166F060", Offset = "0x166D660", VA = "0x18166F060")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x166F1A0", Offset = "0x166D7A0", VA = "0x18166F1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x166ED20", Offset = "0x166D320", VA = "0x18166ED20", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x166ED80", Offset = "0x166D380", VA = "0x18166ED80", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x166F000", Offset = "0x166D600", VA = "0x18166F000")]
		public GameSetStateNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x166EE00", Offset = "0x166D400", VA = "0x18166EE00", Slot = "22")]
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
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			Defaults
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public delegate void ChangeTagsForObjectFunc(int objectId);

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public const string MODE_ARG = "mode";

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private const string nodeDescription = "Change Tags on Object";

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private ChangeModes changeMode;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ChangeModes ChangeMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(ChangeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x13437A0", Offset = "0x1341DA0", VA = "0x1813437A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ChangeTagsForObjectFunc ChangeTagsForObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1671AA0", Offset = "0x16700A0", VA = "0x181671AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1671B40", Offset = "0x1670140", VA = "0x181671B40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1671A20", Offset = "0x1670020", VA = "0x181671A20")]
		public ObjectSetTagsNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1671670", Offset = "0x166FC70", VA = "0x181671670", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1671610", Offset = "0x166FC10", VA = "0x181671610", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x16716E0", Offset = "0x166FCE0", VA = "0x1816716E0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1671830", Offset = "0x166FE30", VA = "0x181671830", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1671740", Offset = "0x166FD40", VA = "0x181671740", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1660460", Offset = "0x165EA60", VA = "0x181660460", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x16604D0", Offset = "0x165EAD0", VA = "0x1816604D0", Slot = "14")]
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
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			AddPlayerRole,
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			RemovePlayerRole,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			PlayerHasRole,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			PlayerRoleChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public delegate void PlayerModifyRoleFunc(int playerId, int roleId);

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool PlayerHasRoleFunc(int playerId, int roleId);

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private static readonly OutputMetadata[] PlayerHasRoleOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly OutputMetadata[] PlayerRoleChangedOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly InputMetadata[] PlayerHasRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly InputMetadata[] ModifyPlayerRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static readonly OutputMetadata[] ModifyPlayerRoleOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private PlayerRoleMapModes playerRoleMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private int modificationRoleId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private bool masterLastPlayerHasRoleSignal;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public PlayerRoleMapModes PlayerRoleMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x484430", Offset = "0x482A30", VA = "0x180484430")]
			get
			{
				return default(PlayerRoleMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1674560", Offset = "0x1672B60", VA = "0x181674560")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int ModificationRoleId
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x5A0280", Offset = "0x59E880", VA = "0x1805A0280")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1674540", Offset = "0x1672B40", VA = "0x181674540")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PlayerModifyRoleFunc PlayerAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1673F00", Offset = "0x1672500", VA = "0x181673F00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1674220", Offset = "0x1672820", VA = "0x181674220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PlayerModifyRoleFunc TeamAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x16740E0", Offset = "0x16726E0", VA = "0x1816740E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1674400", Offset = "0x1672A00", VA = "0x181674400")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PlayerModifyRoleFunc PlayerRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1674040", Offset = "0x1672640", VA = "0x181674040")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1674360", Offset = "0x1672960", VA = "0x181674360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event PlayerModifyRoleFunc TeamRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1674180", Offset = "0x1672780", VA = "0x181674180")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x16744A0", Offset = "0x1672AA0", VA = "0x1816744A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event PlayerHasRoleFunc PlayerHasRole
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1673FA0", Offset = "0x16725A0", VA = "0x181673FA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x16742C0", Offset = "0x16728C0", VA = "0x1816742C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x16736B0", Offset = "0x1671CB0", VA = "0x1816736B0")]
		public void MarkDirtyForRoleChange(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1673E90", Offset = "0x1672490", VA = "0x181673E90")]
		public PlayerRoleMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1673780", Offset = "0x1671D80", VA = "0x181673780", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1673080", Offset = "0x1671680", VA = "0x181673080")]
		private void EvaluatePlayerHasRole(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1673540", Offset = "0x1671B40", VA = "0x181673540")]
		private bool GetPlayerHasRoleSignal(bool isMasterClient, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1672F70", Offset = "0x1671570", VA = "0x181672F70")]
		private void EvaluateAddPlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1673150", Offset = "0x1671750", VA = "0x181673150")]
		private void EvaluateRemovePlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x16736F0", Offset = "0x1671CF0", VA = "0x1816736F0", Slot = "18")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1672F40", Offset = "0x1671540", VA = "0x181672F40", Slot = "19")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1673260", Offset = "0x1671860", VA = "0x181673260", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1673410", Offset = "0x1671A10", VA = "0x181673410", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1673360", Offset = "0x1671960", VA = "0x181673360", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1673620", Offset = "0x1671C20", VA = "0x181673620", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1673720", Offset = "0x1671D20", VA = "0x181673720", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1673A30", Offset = "0x1672030", VA = "0x181673A30", Slot = "24")]
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
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			PlayerToTeam,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			TeamToPlayer,
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			SetPlayerTeam,
			[Cpp2IlInjected.Token(Token = "0x400016C")]
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

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly InputMetadata[] PlayerToTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly OutputMetadata[] PlayerToTeamOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly InputMetadata[] TeamToPlayerInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly OutputMetadata[] TeamToPlayerOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly InputMetadata[] SetPlayerTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly InputMetadata[] GetTeamPlayerCountInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly OutputMetadata[] GetTeamPlayerCountOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly OutputMetadata[] SetPlayerTeamOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private PlayerIdMapModes playerIdMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int lastMasterPlayerToTeamId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int lastMasterPlayerToTeamIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private int lastMasterTeamIndexToPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int lastMasterTeamPlayerCount;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public PlayerIdMapModes PlayerIdMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x484430", Offset = "0x482A30", VA = "0x180484430")]
			get
			{
				return default(PlayerIdMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1674560", Offset = "0x1672B60", VA = "0x181674560")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event PlayerToTeamIndexFunc PlayerToTeamIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x16761C0", Offset = "0x16747C0", VA = "0x1816761C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x1676440", Offset = "0x1674A40", VA = "0x181676440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event PlayerSetTeamFunc PlayerSetTeam
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x1676120", Offset = "0x1674720", VA = "0x181676120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x16763A0", Offset = "0x16749A0", VA = "0x1816763A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event TeamIndexToPlayerFunc TeamIndexToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1676260", Offset = "0x1674860", VA = "0x181676260")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x16764E0", Offset = "0x1674AE0", VA = "0x1816764E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event GetTeamPlayerCountFunc GetTeamPlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1676080", Offset = "0x1674680", VA = "0x181676080")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x1676300", Offset = "0x1674900", VA = "0x181676300")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1675630", Offset = "0x1673C30", VA = "0x181675630")]
		public void MarkDirtyForTeamChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1676020", Offset = "0x1674620", VA = "0x181676020")]
		public PlayerTeamMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x16757B0", Offset = "0x1673DB0", VA = "0x1816757B0", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1674DD0", Offset = "0x16733D0", VA = "0x181674DD0")]
		private void EvaluatePlayerToTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1675310", Offset = "0x1673910", VA = "0x181675310")]
		private void GetPlayerToTeamSignals(bool isMasterClient, int playerId, out int masterTeamId, out int masterTeamIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1674F50", Offset = "0x1673550", VA = "0x181674F50")]
		private void EvaluateTeamToPlayer(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x16753F0", Offset = "0x16739F0", VA = "0x1816753F0")]
		private int GetTeamIndexToPlayerSignal(bool isMasterClient, int teamId, int teamIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1674CE0", Offset = "0x16732E0", VA = "0x181674CE0")]
		private void EvaluateGetTeamPlayerCount(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x16754D0", Offset = "0x1673AD0", VA = "0x1816754D0")]
		private int GetTeamPlayerCountSignal(bool isMasterClient, int teamId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1674E70", Offset = "0x1673470", VA = "0x181674E70")]
		private void EvaluateSetPlayerTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1675660", Offset = "0x1673C60", VA = "0x181675660", Slot = "18")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1674BA0", Offset = "0x16731A0", VA = "0x181674BA0", Slot = "19")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1674FD0", Offset = "0x16735D0", VA = "0x181674FD0", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x16751B0", Offset = "0x16737B0", VA = "0x1816751B0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1675130", Offset = "0x1673730", VA = "0x181675130", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x16755C0", Offset = "0x1673BC0", VA = "0x1816755C0", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1672730", Offset = "0x1670D30", VA = "0x181672730", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1675AD0", Offset = "0x16740D0", VA = "0x181675AD0", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class PostEvalActionNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private List<Action> PostEvalActions;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal sealed override bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1339A30", Offset = "0x1338030", VA = "0x181339A30", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1339970", Offset = "0x1337F70", VA = "0x181339970")]
		public PostEvalActionNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1339910", Offset = "0x1337F10", VA = "0x181339910")]
		protected void QueuePostEvalAction(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1339760", Offset = "0x1337D60", VA = "0x181339760", Slot = "21")]
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
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public OutputSlot outputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public int outputValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		internal List<Output[]> QueuedSignals;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x133A060", Offset = "0x1338660", VA = "0x18133A060")]
		public QueuedMomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1339EA0", Offset = "0x13384A0", VA = "0x181339EA0")]
		public new void SetContinuousOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1339EB0", Offset = "0x13384B0", VA = "0x181339EB0")]
		public new void SetMomentaryOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1339F50", Offset = "0x1338550", VA = "0x181339F50")]
		public void SetMomentaryOutputs(params Output[] outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1339F60", Offset = "0x1338560", VA = "0x181339F60", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1339CF0", Offset = "0x13382F0", VA = "0x181339CF0", Slot = "16")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1339AA0", Offset = "0x13380A0", VA = "0x181339AA0", Slot = "17")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1339C20", Offset = "0x1338220", VA = "0x181339C20")]
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

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event ObjectToHoldingPlayerIdFunc ObjectToHoldingPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x16714D0", Offset = "0x166FAD0", VA = "0x1816714D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x1671570", Offset = "0x166FB70", VA = "0x181671570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1671450", Offset = "0x166FA50", VA = "0x181671450")]
		public ObjectPlayerMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1671030", Offset = "0x166F630", VA = "0x181671030", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1670FD0", Offset = "0x166F5D0", VA = "0x181670FD0", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1671060", Offset = "0x166F660", VA = "0x181671060", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1671250", Offset = "0x166F850", VA = "0x181671250", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x16710C0", Offset = "0x166F6C0", VA = "0x1816710C0")]
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
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			Continuous,
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			Pulse
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private RandomModes randomMode;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static Random random;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int masterLastRandomNumber;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RandomModes RandomMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(RandomModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x133A890", Offset = "0x1338E90", VA = "0x18133A890")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x133A810", Offset = "0x1338E10", VA = "0x18133A810")]
		public RandomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x133A2C0", Offset = "0x13388C0", VA = "0x18133A2C0", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x133A260", Offset = "0x1338860", VA = "0x18133A260", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x133A2F0", Offset = "0x13388F0", VA = "0x18133A2F0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x133A430", Offset = "0x1338A30", VA = "0x18133A430", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x133A3A0", Offset = "0x13389A0", VA = "0x18133A3A0", Slot = "18")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x133A210", Offset = "0x1338810", VA = "0x18133A210", Slot = "19")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x133A120", Offset = "0x1338720", VA = "0x18133A120")]
		private int CalcOutput(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x133A350", Offset = "0x1338950", VA = "0x18133A350", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x133A400", Offset = "0x1338A00", VA = "0x18133A400", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x133A5B0", Offset = "0x1338BB0", VA = "0x18133A5B0", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class SourceNodeBase : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x133F490", Offset = "0x133DA90", VA = "0x18133F490")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x133F4F0", Offset = "0x133DAF0", VA = "0x18133F4F0")]
		public SourceNodeBase(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x133F430", Offset = "0x133DA30", VA = "0x18133F430", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x484400", Offset = "0x482A00", VA = "0x180484400", Slot = "12")]
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
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			First,
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct SelectorConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public SignalComparisonHelper.ComparerModes CompareMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public int CompareValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private EvalModes _evalMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public SelectorConfig[] SelectorConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private InputMetadata[] inputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int lastSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int lastSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private bool modifiedSinceLastEval;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public EvalModes EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(EvalModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x133C440", Offset = "0x133AA40", VA = "0x18133C440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x133C280", Offset = "0x133A880", VA = "0x18133C280")]
		public SelectorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x133BDC0", Offset = "0x133A3C0", VA = "0x18133BDC0", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x133B9C0", Offset = "0x1339FC0", VA = "0x18133B9C0", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x484420", Offset = "0x482A20", VA = "0x180484420", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x133BA00", Offset = "0x133A000", VA = "0x18133BA00", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x133BA50", Offset = "0x133A050", VA = "0x18133BA50", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x133BC10", Offset = "0x133A210", VA = "0x18133BC10", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x133BFD0", Offset = "0x133A5D0", VA = "0x18133BFD0", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CircuitNodeUuid("B58C2FAB-3F1A-15F4-6D31-4E3BE09A71A9")]
	public class SourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x133F5A0", Offset = "0x133DBA0", VA = "0x18133F5A0")]
		public SourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x133F590", Offset = "0x133DB90", VA = "0x18133F590")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1339EA0", Offset = "0x13384A0", VA = "0x181339EA0")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169B82")]
	public class ComparerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly InputMetadata[] AdvancedInputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private SignalComparisonHelper.ComparerModes comparerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private bool advancedMode;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public SignalComparisonHelper.ComparerModes ComparerMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(SignalComparisonHelper.ComparerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x13437A0", Offset = "0x1341DA0", VA = "0x1813437A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x835BA0", Offset = "0x8341A0", VA = "0x180835BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x166C9E0", Offset = "0x166AFE0", VA = "0x18166C9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x166C960", Offset = "0x166AF60", VA = "0x18166C960")]
		public ComparerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x166C490", Offset = "0x166AA90", VA = "0x18166C490", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x166C0E0", Offset = "0x166A6E0", VA = "0x18166C0E0")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x166C170", Offset = "0x166A770", VA = "0x18166C170", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x166C280", Offset = "0x166A880", VA = "0x18166C280", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x166C210", Offset = "0x166A810", VA = "0x18166C210", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x166C3B0", Offset = "0x166A9B0", VA = "0x18166C3B0", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x166C430", Offset = "0x166AA30", VA = "0x18166C430", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x166C5F0", Offset = "0x166ABF0", VA = "0x18166C5F0", Slot = "24")]
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
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			Subtract,
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			Multiply,
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			Divide,
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			Modulo
		}

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly InputMetadata[] TwoInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly InputMetadata[] ThreeInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly Dictionary<CombinatorModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private CombinatorModes combinatorMode;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public CombinatorModes CombinatorMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(CombinatorModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x13437A0", Offset = "0x1341DA0", VA = "0x1813437A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x166B9D0", Offset = "0x1669FD0", VA = "0x18166B9D0")]
		public static string GetModeSymbol(CombinatorModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x166C060", Offset = "0x166A660", VA = "0x18166C060")]
		public CombinatorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x166BC00", Offset = "0x166A200", VA = "0x18166BC00", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x166B800", Offset = "0x1669E00", VA = "0x18166B800")]
		private int CalcOutput()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x166B930", Offset = "0x1669F30", VA = "0x18166B930", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x166BB20", Offset = "0x166A120", VA = "0x18166BB20", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x166BA50", Offset = "0x166A050", VA = "0x18166BA50", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1660460", Offset = "0x165EA60", VA = "0x181660460", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x16604D0", Offset = "0x165EAD0", VA = "0x1816604D0", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x166BCE0", Offset = "0x166A2E0", VA = "0x18166BCE0", Slot = "24")]
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
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public int timeRemaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public int value;
		}

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private static InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private static OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private List<DelaySignal> QueuedSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private int lastInputSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x166DE40", Offset = "0x166C440", VA = "0x18166DE40")]
		public DelayNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x166D360", Offset = "0x166B960", VA = "0x18166D360", Slot = "20")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x166D4D0", Offset = "0x166BAD0", VA = "0x18166D4D0", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x166D530", Offset = "0x166BB30", VA = "0x18166D530", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x166DA50", Offset = "0x166C050", VA = "0x18166DA50", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x166DC50", Offset = "0x166C250", VA = "0x18166DC50", Slot = "23")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x166D780", Offset = "0x166BD80", VA = "0x18166D780")]
		private void QueueSignal(int delay, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x166D590", Offset = "0x166BB90", VA = "0x18166D590")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x166D8E0", Offset = "0x166BEE0", VA = "0x18166D8E0", Slot = "16")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x166D250", Offset = "0x166B850", VA = "0x18166D250", Slot = "17")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CircuitNodeUuid("C9A59F26-0A72-4C2E-B239-6A83998E0839", InternalOnly = true)]
	public class LoopNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		internal override bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x166FEA0", Offset = "0x166E4A0", VA = "0x18166FEA0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x166FE20", Offset = "0x166E420", VA = "0x18166FE20")]
		public LoopNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x166FD80", Offset = "0x166E380", VA = "0x18166FD80", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x166FDD0", Offset = "0x166E3D0", VA = "0x18166FDD0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CircuitNodeUuid("E7EFD8CA-92FE-4A37-9E7C-ABBE9E4DE336")]
	public class MomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x166FEB0", Offset = "0x166E4B0", VA = "0x18166FEB0")]
		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x166A700", Offset = "0x1668D00", VA = "0x18166A700")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CircuitNodeUuid("6402C773-5838-4495-BC54-BC36EDE4AB0F")]
	public class ConstantSourceNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x166CA90", Offset = "0x166B090", VA = "0x18166CA90", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x166CAF0", Offset = "0x166B0F0", VA = "0x18166CAF0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x166D150", Offset = "0x166B750", VA = "0x18166D150")]
		public ConstantSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x166CB50", Offset = "0x166B150", VA = "0x18166CB50", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x166CD40", Offset = "0x166B340", VA = "0x18166CD40", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x166CED0", Offset = "0x166B4D0", VA = "0x18166CED0", Slot = "24")]
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
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x166F990", Offset = "0x166DF90", VA = "0x18166F990")]
			public GraphInputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x166A6E0", Offset = "0x1668CE0", VA = "0x18166A6E0")]
			public void SetOutputSignal(OutputSlot slot, int val)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CircuitNodeUuid("F8A998DB-0354-4BCD-B0E4-6BBA7CC24B89", InternalOnly = true)]
		public class GraphOutputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x166FBB0", Offset = "0x166E1B0", VA = "0x18166FBB0")]
			public GraphOutputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x166FA10", Offset = "0x166E010", VA = "0x18166FA10", Slot = "22")]
			protected override void _EvaluateNode(bool isMasterClient)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private GraphInputNode virtualSourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private GraphOutputNode virtualDestNode;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public CircuitNodeGraph InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x484400", Offset = "0x482A00", VA = "0x180484400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x484470", Offset = "0x482A70", VA = "0x180484470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1670960", Offset = "0x166EF60", VA = "0x181670960")]
		public NodeGraphNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x16705D0", Offset = "0x166EBD0", VA = "0x1816705D0", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x16704F0", Offset = "0x166EAF0", VA = "0x1816704F0", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1670080", Offset = "0x166E680", VA = "0x181670080", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x166FFE0", Offset = "0x166E5E0", VA = "0x18166FFE0", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1670030", Offset = "0x166E630", VA = "0x181670030", Slot = "12")]
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
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public bool NeedsSerialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public InputMetadata[] InputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public string NodeDescription;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct InputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public string Description;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct OutputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public OutputSlot OutputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public string Description;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CircuitNodeUuid("C6AB70A0-C752-466A-8070-029742655556")]
	public class OutputNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public delegate void OutputNodeUpdated(Dictionary<InputSlot, int> slotUpdates);

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int[] lastSignals;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x133F490", Offset = "0x133DA90", VA = "0x18133F490")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x16721F0", Offset = "0x16707F0", VA = "0x1816721F0")]
		public OutputNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1671CA0", Offset = "0x16702A0", VA = "0x181671CA0", Slot = "20")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1672090", Offset = "0x1670690", VA = "0x181672090")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x484400", Offset = "0x482A00", VA = "0x180484400", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1672030", Offset = "0x1670630", VA = "0x181672030", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1672190", Offset = "0x1670790", VA = "0x181672190", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1671D60", Offset = "0x1670360", VA = "0x181671D60")]
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
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public InputSlot inputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public byte stateIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public int val1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int val2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public int val3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public int minTimeInStateMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public bool removed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public StateTransition[] transitions;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public enum ModifyCommands
		{
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			DefaultState = 1,
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			MaxStateIndex,
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			StateVal1,
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			StateVal2,
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			StateVal3,
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			MinTimeInStateMS,
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			NumTransitions,
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			TransitionInputSlot,
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			TransitionStateTarget,
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			RemovedState
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private State[] states;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private byte maxStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private OutputSlot[] _serializableOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public byte CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1341730", Offset = "0x133FD30", VA = "0x181341730")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1341820", Offset = "0x133FE20", VA = "0x181341820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public byte DefaultState
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x11BEE90", Offset = "0x11BD490", VA = "0x1811BEE90")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1341830", Offset = "0x133FE30", VA = "0x181341830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected override OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x484420", Offset = "0x482A20", VA = "0x180484420", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xE40550", Offset = "0xE3EB50", VA = "0x180E40550", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int TimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9653F0", Offset = "0x9639F0", VA = "0x1809653F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1341840", Offset = "0x133FE40", VA = "0x181341840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x13417D0", Offset = "0x133FDD0", VA = "0x1813417D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1341740", Offset = "0x133FD40", VA = "0x181341740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x133FE80", Offset = "0x133E480", VA = "0x18133FE80")]
		public State? GetState(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1341590", Offset = "0x133FB90", VA = "0x181341590")]
		public StateMachineNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x133F690", Offset = "0x133DC90", VA = "0x18133F690", Slot = "20")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1340420", Offset = "0x133EA20", VA = "0x181340420")]
		private void OnTimerUpdate(int networkTimeMS, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1340890", Offset = "0x133EE90", VA = "0x181340890", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1341560", Offset = "0x133FB60", VA = "0x181341560", Slot = "23")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x133FBE0", Offset = "0x133E1E0", VA = "0x18133FBE0")]
		public static OutputSlot GetOnEnterOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x133F940", Offset = "0x133DF40", VA = "0x18133F940")]
		public static OutputSlot GetInStateOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x133FBF0", Offset = "0x133E1F0", VA = "0x18133FBF0")]
		public static OutputSlot GetOnExitOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x133F720", Offset = "0x133DD20", VA = "0x18133F720")]
		private void EnterState(byte newStateIndex, bool forceIfCurrent = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x133F950", Offset = "0x133DF50", VA = "0x18133F950", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x133FC00", Offset = "0x133E200", VA = "0x18133FC00", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x133FB90", Offset = "0x133E190", VA = "0x18133FB90", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x13405C0", Offset = "0x133EBC0", VA = "0x1813405C0", Slot = "16")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x133F620", Offset = "0x133DC20", VA = "0x18133F620", Slot = "17")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x133FF80", Offset = "0x133E580", VA = "0x18133FF80", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1340640", Offset = "0x133EC40", VA = "0x181340640", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x133FB70", Offset = "0x133E170", VA = "0x18133FB70")]
		public static int GetModifyArg(ModifyCommands cmd, byte stateIdx = 0, byte transitionIdx = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1340870", Offset = "0x133EE70", VA = "0x181340870")]
		private static void UnpackModifyArg(int arg, out ModifyCommands cmd, out byte stateIdx, out byte transitionIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1340A40", Offset = "0x133F040", VA = "0x181340A40", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x133F930", Offset = "0x133DF30", VA = "0x18133F930")]
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
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			Looping,
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			Countdown
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public enum TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			Second,
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			TenthOfSecond
		}

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly InputMetadata[] InputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TimerModes timerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private int timeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private bool timerExpired;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int _inputTimeTenths;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TimerModes TimerMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(TimerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x13437A0", Offset = "0x1341DA0", VA = "0x1813437A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		private int inputTimeTenths
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x762BE0", Offset = "0x7611E0", VA = "0x180762BE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x13437C0", Offset = "0x1341DC0", VA = "0x1813437C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x13436C0", Offset = "0x1341CC0", VA = "0x1813436C0")]
		public TimerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1342EA0", Offset = "0x13414A0", VA = "0x181342EA0", Slot = "20")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1343370", Offset = "0x1341970", VA = "0x181343370", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x13434A0", Offset = "0x1341AA0", VA = "0x1813434A0", Slot = "23")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1342F30", Offset = "0x1341530", VA = "0x181342F30", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1342FD0", Offset = "0x13415D0", VA = "0x181342FD0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1342F90", Offset = "0x1341590", VA = "0x181342F90", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1343090", Offset = "0x1341690", VA = "0x181343090")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x13432E0", Offset = "0x13418E0", VA = "0x1813432E0")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x13431A0", Offset = "0x13417A0", VA = "0x1813431A0")]
		private void ResetTimeRemaining()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1343030", Offset = "0x1341630", VA = "0x181343030", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x133A400", Offset = "0x1338A00", VA = "0x18133A400", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x13433E0", Offset = "0x13419E0", VA = "0x1813433E0", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1343280", Offset = "0x1341880", VA = "0x181343280", Slot = "16")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1342E50", Offset = "0x1341450", VA = "0x181342E50", Slot = "17")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1343230", Offset = "0x1341830", VA = "0x181343230", Slot = "18")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1342E10", Offset = "0x1341410", VA = "0x181342E10", Slot = "19")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CircuitNodeUuid("9B664D6A-1B61-4D4E-9AA8-B17B0DC02DA3")]
	public class UnityTransformationNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private Dictionary<InputSlot, int> inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private Dictionary<OutputSlot, int> outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private Func<Dictionary<InputSlot, int>, Dictionary<OutputSlot, int>> transformationFunction;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x484400", Offset = "0x482A00", VA = "0x180484400", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x545ED0", Offset = "0x5444D0", VA = "0x180545ED0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1346010", Offset = "0x1344610", VA = "0x181346010")]
		public UnityTransformationNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1345CA0", Offset = "0x13442A0", VA = "0x181345CA0", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1345BA0", Offset = "0x13441A0", VA = "0x181345BA0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			Sine,
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			Cosine,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			Square,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			Sawtooth
		}

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static readonly InputMetadata[] SecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private static readonly InputMetadata[] ThenthOfSecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private WaveMode currentWaveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private TimerNode.TimeUnit currentTimeUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private int runningTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private int _inputPeriod;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private int inputAmplitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private double functionPeriodInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private double millisecondTimeToAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private int loopTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private int relevantDecimalPlaces;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public WaveMode CurrentWaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59E860", VA = "0x1805A0260")]
			get
			{
				return default(WaveMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x13437A0", Offset = "0x1341DA0", VA = "0x1813437A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TimerNode.TimeUnit CurrentTimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x5A0250", Offset = "0x59E850", VA = "0x1805A0250")]
			get
			{
				return default(TimerNode.TimeUnit);
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1347B90", Offset = "0x1346190", VA = "0x181347B90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private double InputTimeUnitInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1347B60", Offset = "0x1346160", VA = "0x181347B60")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private int InputPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4843D0", Offset = "0x4829D0", VA = "0x1804843D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1347BD0", Offset = "0x13461D0", VA = "0x181347BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1347A80", Offset = "0x1346080", VA = "0x181347A80")]
		public WaveNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1346C40", Offset = "0x1345240", VA = "0x181346C40", Slot = "20")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1347530", Offset = "0x1345B30", VA = "0x181347530", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1347730", Offset = "0x1345D30", VA = "0x181347730", Slot = "23")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1346FB0", Offset = "0x13455B0", VA = "0x181346FB0", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x13470E0", Offset = "0x13456E0", VA = "0x1813470E0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1347050", Offset = "0x1345650", VA = "0x181347050", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x13471D0", Offset = "0x13457D0", VA = "0x1813471D0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x13474F0", Offset = "0x1345AF0", VA = "0x1813474F0")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x13472D0", Offset = "0x13458D0", VA = "0x1813472D0")]
		private void ResetRunningTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1346CD0", Offset = "0x13452D0", VA = "0x181346CD0")]
		private int EvaluateWaveFunction()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1347380", Offset = "0x1345980", VA = "0x181347380")]
		private void UpdateCachedFunctionParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1347140", Offset = "0x1345740", VA = "0x181347140", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1347340", Offset = "0x1345940", VA = "0x181347340", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x13475E0", Offset = "0x1345BE0", VA = "0x1813475E0", Slot = "24")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x13472E0", Offset = "0x13458E0", VA = "0x1813472E0", Slot = "16")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1346BF0", Offset = "0x13451F0", VA = "0x181346BF0", Slot = "17")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CircuitNodeUuid("A4160690-4C68-40C2-BD51-B665F71FCEBD", InternalOnly = true)]
	public class RootNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		internal override bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x133A8A0", Offset = "0x1338EA0", VA = "0x18133A8A0")]
		public RootNode(int nodeId, CircuitNodeGraph graph)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class VirtualNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1346B60", Offset = "0x1345160", VA = "0x181346B60")]
		protected VirtualNode(string nodeName, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x13469E0", Offset = "0x1344FE0", VA = "0x1813469E0", Slot = "20")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1346A30", Offset = "0x1345030", VA = "0x181346A30", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1346A90", Offset = "0x1345090", VA = "0x181346A90", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class Serialization
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x133EAE0", Offset = "0x133D0E0", VA = "0x18133EAE0")]
		public static CircuitNode InstantiateNode(Guid nodeType, int nodeId, Guid graphGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x133E880", Offset = "0x133CE80", VA = "0x18133E880")]
		internal static CircuitNode InstantiateNode(CircuitNodeData nodeData, CircuitNodeGraph nodeGraph, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x133E740", Offset = "0x133CD40", VA = "0x18133E740")]
		public static Guid GetNodeTypeGuid(CircuitNode node)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x133EC70", Offset = "0x133D270", VA = "0x18133EC70")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static Guid RECROOM_CIRCUITS_BOOLEANNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private static Guid RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private static Guid RECROOM_CIRCUITS_GAMESETSTATENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private static Guid RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private static Guid RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private static Guid RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private static Guid RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private static Guid RECROOM_CIRCUITS_SELECTORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private static Guid RECROOM_CIRCUITS_SOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static Guid RECROOM_CIRCUITS_STATEMACHINENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static Guid RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static Guid RECROOM_CIRCUITS_WAVENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		internal static Dictionary<Type, Guid> TypeToGuidLookup;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal static Dictionary<Guid, Type> GuidToTypeLookup;

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		internal static Dictionary<Guid, CircuitNodeConstructor> GuidToNodeConstructor;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class SignalComparisonHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum ComparerModes
		{
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			Equals,
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			NotEquals,
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			GreaterThan,
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			GreaterThanEqualTo,
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			LessThan,
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			LessThanEqualTo
		}

		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private static readonly Dictionary<ComparerModes, string> ModeSymbols;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x133ED80", Offset = "0x133D380", VA = "0x18133ED80")]
		public static string GetModeSymbol(ComparerModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x133ED10", Offset = "0x133D310", VA = "0x18133ED10")]
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
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1330CC0", Offset = "0x132F2C0", VA = "0x181330CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1330670", Offset = "0x132EC70", VA = "0x181330670")]
		static CircuitLinkDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class CircuitLinkData : IMessage<CircuitLinkData>, IMessage, IEquatable<CircuitLinkData>, IDeepCloneable<CircuitLinkData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private static readonly MessageParser<CircuitLinkData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private int sourceNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private int destNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private int inputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private int outputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private int linkType_;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitLinkData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1331470", Offset = "0x132FA70", VA = "0x181331470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x13313A0", Offset = "0x132F9A0", VA = "0x1813313A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x13314D0", Offset = "0x132FAD0", VA = "0x1813314D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[DebuggerNonUserCode]
		public int SourceNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[DebuggerNonUserCode]
		public int DestNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[DebuggerNonUserCode]
		public int InputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x32A5A0", Offset = "0x328BA0", VA = "0x18032A5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[DebuggerNonUserCode]
		public int OutputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2F4C60", Offset = "0x2F3260", VA = "0x1802F4C60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x32A590", Offset = "0x328B90", VA = "0x18032A590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[DebuggerNonUserCode]
		public int LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x2F4B50", Offset = "0x2F3150", VA = "0x1802F4B50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x303810", Offset = "0x301E10", VA = "0x180303810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		[DebuggerNonUserCode]
		public CircuitLinkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1331350", Offset = "0x132F950", VA = "0x181331350")]
		[DebuggerNonUserCode]
		public CircuitLinkData(CircuitLinkData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1330E70", Offset = "0x132F470", VA = "0x181330E70", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitLinkData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1330EF0", Offset = "0x132F4F0", VA = "0x181330EF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1330F90", Offset = "0x132F590", VA = "0x181330F90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitLinkData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1330FD0", Offset = "0x132F5D0", VA = "0x181330FD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1331140", Offset = "0x132F740", VA = "0x181331140", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x13311A0", Offset = "0x132F7A0", VA = "0x1813311A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1330D20", Offset = "0x132F320", VA = "0x181330D20", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1331080", Offset = "0x132F680", VA = "0x181331080", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class CircuitNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x1333E00", Offset = "0x1332400", VA = "0x181333E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x13315D0", Offset = "0x132FBD0", VA = "0x1813315D0")]
		static CircuitNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private static readonly MessageParser<CircuitNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private string nodeName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private int nodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private int pairedNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private ByteString nodeType_;

		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private static readonly FieldCodec<CircuitLinkData> _repeated_circuitLinks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private readonly RepeatedField<CircuitLinkData> circuitLinks_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private NodeTransformData transformData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private InternalGraphData internalGraphData_;

		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private static readonly FieldCodec<SlotData> _repeated_slotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private readonly RepeatedField<SlotData> slotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private int mode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private SelectorNodeData selectorNodeData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private bool advancedMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int timeUnit_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int roleId_;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly FieldCodec<StateMachineStateData> _repeated_stateMachineData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private readonly RepeatedField<StateMachineStateData> stateMachineData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int defaultIndex_;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x13355A0", Offset = "0x1333BA0", VA = "0x1813355A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x13354D0", Offset = "0x1333AD0", VA = "0x1813354D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x1335600", Offset = "0x1333C00", VA = "0x181335600", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[DebuggerNonUserCode]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x1335700", Offset = "0x1333D00", VA = "0x181335700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[DebuggerNonUserCode]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x32A5A0", Offset = "0x328BA0", VA = "0x18032A5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerNonUserCode]
		public int PairedNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x2F4C60", Offset = "0x2F3260", VA = "0x1802F4C60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x32A590", Offset = "0x328B90", VA = "0x18032A590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x1335750", Offset = "0x1333D50", VA = "0x181335750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitLinkData> CircuitLinks
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		public NodeTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA40", Offset = "0x2FA040", VA = "0x1802FBA40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA50", Offset = "0x2FA050", VA = "0x1802FBA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public InternalGraphData InternalGraphData
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x2E98B0", Offset = "0x2E7EB0", VA = "0x1802E98B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x2E9160", Offset = "0x2E7760", VA = "0x1802E9160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> SlotData
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x2F6F10", Offset = "0x2F5510", VA = "0x1802F6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[DebuggerNonUserCode]
		public int Mode
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x3035B0", Offset = "0x301BB0", VA = "0x1803035B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x303820", Offset = "0x301E20", VA = "0x180303820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public SelectorNodeData SelectorNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x303590", Offset = "0x301B90", VA = "0x180303590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x3F76A0", Offset = "0x3F5CA0", VA = "0x1803F76A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[DebuggerNonUserCode]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x31B2E0", Offset = "0x3198E0", VA = "0x18031B2E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x2E99E0", Offset = "0x2E7FE0", VA = "0x1802E99E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		public int TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x6D9470", Offset = "0x6D7A70", VA = "0x1806D9470")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x6D94E0", Offset = "0x6D7AE0", VA = "0x1806D94E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public int RoleId
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x668830", Offset = "0x666E30", VA = "0x180668830")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x668530", Offset = "0x666B30", VA = "0x180668530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineStateData> StateMachineData
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x305DB0", Offset = "0x3043B0", VA = "0x180305DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[DebuggerNonUserCode]
		public int DefaultIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x646130", Offset = "0x644730", VA = "0x180646130")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xFDF6E0", Offset = "0xFDDCE0", VA = "0x180FDF6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1335050", Offset = "0x1333650", VA = "0x181335050")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1335130", Offset = "0x1333730", VA = "0x181335130")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1334200", Offset = "0x1332800", VA = "0x181334200", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1334260", Offset = "0x1332860", VA = "0x181334260", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x13342C0", Offset = "0x13328C0", VA = "0x1813342C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1334470", Offset = "0x1332A70", VA = "0x181334470", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x13349F0", Offset = "0x1332FF0", VA = "0x1813349F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1334A50", Offset = "0x1333050", VA = "0x181334A50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1333E60", Offset = "0x1332460", VA = "0x181333E60", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1334670", Offset = "0x1332C70", VA = "0x181334670", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class SelectorNodeData : IMessage<SelectorNodeData>, IMessage, IEquatable<SelectorNodeData>, IDeepCloneable<SelectorNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly MessageParser<SelectorNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private int evalMode_;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly FieldCodec<SelectorConfigData> _repeated_selectorConfigData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private readonly RepeatedField<SelectorConfigData> selectorConfigData_;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x133B850", Offset = "0x1339E50", VA = "0x18133B850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x133B780", Offset = "0x1339D80", VA = "0x18133B780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x133B8B0", Offset = "0x1339EB0", VA = "0x18133B8B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public int EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[DebuggerNonUserCode]
		public RepeatedField<SelectorConfigData> SelectorConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x133B720", Offset = "0x1339D20", VA = "0x18133B720")]
		[DebuggerNonUserCode]
		public SelectorNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x133B660", Offset = "0x1339C60", VA = "0x18133B660")]
		[DebuggerNonUserCode]
		public SelectorNodeData(SelectorNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x133B060", Offset = "0x1339660", VA = "0x18133B060", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x133B1C0", Offset = "0x13397C0", VA = "0x18133B1C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x133B140", Offset = "0x1339740", VA = "0x18133B140", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x133B290", Offset = "0x1339890", VA = "0x18133B290", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x133B3E0", Offset = "0x13399E0", VA = "0x18133B3E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x133B440", Offset = "0x1339A40", VA = "0x18133B440", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x133AF90", Offset = "0x1339590", VA = "0x18133AF90", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x133B300", Offset = "0x1339900", VA = "0x18133B300", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class InternalGraphData : IMessage<InternalGraphData>, IMessage, IEquatable<InternalGraphData>, IDeepCloneable<InternalGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly MessageParser<InternalGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private int inputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private int outputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private CircuitNodeGraphData internalNodeGraph_;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		public static MessageParser<InternalGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x1338120", Offset = "0x1336720", VA = "0x181338120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1338050", Offset = "0x1336650", VA = "0x181338050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x1338180", Offset = "0x1336780", VA = "0x181338180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public int InputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		public int OutputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		[DebuggerNonUserCode]
		public InternalGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1337F10", Offset = "0x1336510", VA = "0x181337F10")]
		[DebuggerNonUserCode]
		public InternalGraphData(InternalGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1337990", Offset = "0x1335F90", VA = "0x181337990", Slot = "9")]
		[DebuggerNonUserCode]
		public InternalGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1337B00", Offset = "0x1336100", VA = "0x181337B00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1337BA0", Offset = "0x13361A0", VA = "0x181337BA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InternalGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1337BE0", Offset = "0x13361E0", VA = "0x181337BE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1337D50", Offset = "0x1336350", VA = "0x181337D50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1337DB0", Offset = "0x13363B0", VA = "0x181337DB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x13378A0", Offset = "0x1335EA0", VA = "0x1813378A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1337C70", Offset = "0x1336270", VA = "0x181337C70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class CircuitNodeGraphData : IMessage<CircuitNodeGraphData>, IMessage, IEquatable<CircuitNodeGraphData>, IDeepCloneable<CircuitNodeGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly MessageParser<CircuitNodeGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private ByteString nodeGraphGuid_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private bool isInternalGraph_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private CircuitNodeData rootNodeData_;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly FieldCodec<CircuitNodeData> _repeated_circuitNodes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly RepeatedField<CircuitNodeData> circuitNodes_;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x1336C20", Offset = "0x1335220", VA = "0x181336C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x1336B50", Offset = "0x1335150", VA = "0x181336B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x1336C80", Offset = "0x1335280", VA = "0x181336C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public ByteString NodeGraphGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x1336D90", Offset = "0x1335390", VA = "0x181336D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public bool IsInternalGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x2EA6B0", Offset = "0x2E8CB0", VA = "0x1802EA6B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x2F77D0", Offset = "0x2F5DD0", VA = "0x1802F77D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public CircuitNodeData RootNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> CircuitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x13369E0", Offset = "0x1334FE0", VA = "0x1813369E0")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1336A70", Offset = "0x1335070", VA = "0x181336A70")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData(CircuitNodeGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x13361D0", Offset = "0x13347D0", VA = "0x1813361D0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x13362D0", Offset = "0x13348D0", VA = "0x1813362D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1336400", Offset = "0x1334A00", VA = "0x181336400", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x13364F0", Offset = "0x1334AF0", VA = "0x1813364F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1336700", Offset = "0x1334D00", VA = "0x181336700", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1336760", Offset = "0x1334D60", VA = "0x181336760", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x13360B0", Offset = "0x13346B0", VA = "0x1813360B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x13365A0", Offset = "0x1334BA0", VA = "0x1813365A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class CircuitNodeGraphCollectionData : IMessage<CircuitNodeGraphCollectionData>, IMessage, IEquatable<CircuitNodeGraphCollectionData>, IDeepCloneable<CircuitNodeGraphCollectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private static readonly MessageParser<CircuitNodeGraphCollectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly FieldCodec<CircuitNodeGraphData> _repeated_graphs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private readonly RepeatedField<CircuitNodeGraphData> graphs_;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphCollectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x1335F40", Offset = "0x1334540", VA = "0x181335F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x1335E70", Offset = "0x1334470", VA = "0x181335E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x1335FA0", Offset = "0x13345A0", VA = "0x181335FA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeGraphData> Graphs
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x1335E10", Offset = "0x1334410", VA = "0x181335E10")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1335D60", Offset = "0x1334360", VA = "0x181335D60")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData(CircuitNodeGraphCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1335820", Offset = "0x1333E20", VA = "0x181335820", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1335980", Offset = "0x1333F80", VA = "0x181335980", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x1335900", Offset = "0x1333F00", VA = "0x181335900", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xB8B770", Offset = "0xB89D70", VA = "0x180B8B770", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1335B10", Offset = "0x1334110", VA = "0x181335B10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1335B70", Offset = "0x1334170", VA = "0x181335B70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x13357A0", Offset = "0x1333DA0", VA = "0x1813357A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1335A50", Offset = "0x1334050", VA = "0x181335A50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class SlotData : IMessage<SlotData>, IMessage, IEquatable<SlotData>, IDeepCloneable<SlotData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly MessageParser<SlotData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private int slot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private int signal_;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public static MessageParser<SlotData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x133F2C0", Offset = "0x133D8C0", VA = "0x18133F2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x133F1F0", Offset = "0x133D7F0", VA = "0x18133F1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x133F320", Offset = "0x133D920", VA = "0x18133F320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public int Signal
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		[DebuggerNonUserCode]
		public SlotData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xB85C40", Offset = "0xB84240", VA = "0x180B85C40")]
		[DebuggerNonUserCode]
		public SlotData(SlotData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x133EFD0", Offset = "0x133D5D0", VA = "0x18133EFD0", Slot = "9")]
		[DebuggerNonUserCode]
		public SlotData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x133F040", Offset = "0x133D640", VA = "0x18133F040", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xB859B0", Offset = "0xB83FB0", VA = "0x180B859B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SlotData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xB859D0", Offset = "0xB83FD0", VA = "0x180B859D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x133F0D0", Offset = "0x133D6D0", VA = "0x18133F0D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xB85B10", Offset = "0xB84110", VA = "0x180B85B10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x133EF10", Offset = "0x133D510", VA = "0x18133EF10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xB85A50", Offset = "0xB84050", VA = "0x180B85A50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class SelectorConfigData : IMessage<SelectorConfigData>, IMessage, IEquatable<SelectorConfigData>, IDeepCloneable<SelectorConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private static readonly MessageParser<SelectorConfigData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private int compareMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private int compareValue_;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorConfigData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x133AE20", Offset = "0x1339420", VA = "0x18133AE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x133AD50", Offset = "0x1339350", VA = "0x18133AD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x133AE80", Offset = "0x1339480", VA = "0x18133AE80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		public int CompareMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		public int CompareValue
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		[DebuggerNonUserCode]
		public SelectorConfigData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xB85C40", Offset = "0xB84240", VA = "0x180B85C40")]
		[DebuggerNonUserCode]
		public SelectorConfigData(SelectorConfigData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x133AB30", Offset = "0x1339130", VA = "0x18133AB30", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorConfigData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x133ABA0", Offset = "0x13391A0", VA = "0x18133ABA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xB859B0", Offset = "0xB83FB0", VA = "0x180B859B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorConfigData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xB859D0", Offset = "0xB83FD0", VA = "0x180B859D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x133AC30", Offset = "0x1339230", VA = "0x18133AC30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xB85B10", Offset = "0xB84110", VA = "0x180B85B10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x133AA70", Offset = "0x1339070", VA = "0x18133AA70", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xB85A50", Offset = "0xB84050", VA = "0x180B85A50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class StateMachineStateData : IMessage<StateMachineStateData>, IMessage, IEquatable<StateMachineStateData>, IDeepCloneable<StateMachineStateData>
	{
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private static readonly MessageParser<StateMachineStateData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private int val1_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private int val2_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private int val3_;

		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private static readonly FieldCodec<StateMachineTransitionData> _repeated_stateTransitionData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly RepeatedField<StateMachineTransitionData> stateTransitionData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private int minTimeInState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private int removed_;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineStateData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x13423D0", Offset = "0x13409D0", VA = "0x1813423D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x1342300", Offset = "0x1340900", VA = "0x181342300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x1342430", Offset = "0x1340A30", VA = "0x181342430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public int Val1
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public int Val2
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		public int Val3
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x32A5A0", Offset = "0x328BA0", VA = "0x18032A5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineTransitionData> StateTransitionData
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x3017E0", Offset = "0x2FFDE0", VA = "0x1803017E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x301990", Offset = "0x2FFF90", VA = "0x180301990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public int Removed
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x301860", Offset = "0x2FFE60", VA = "0x180301860")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x3019A0", Offset = "0x2FFFA0", VA = "0x1803019A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x13421D0", Offset = "0x13407D0", VA = "0x1813421D0")]
		[DebuggerNonUserCode]
		public StateMachineStateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1342230", Offset = "0x1340830", VA = "0x181342230")]
		[DebuggerNonUserCode]
		public StateMachineStateData(StateMachineStateData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x13419F0", Offset = "0x133FFF0", VA = "0x1813419F0", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineStateData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1341B90", Offset = "0x1340190", VA = "0x181341B90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x1341AF0", Offset = "0x13400F0", VA = "0x181341AF0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineStateData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1341C80", Offset = "0x1340280", VA = "0x181341C80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1341EA0", Offset = "0x13404A0", VA = "0x181341EA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1341F00", Offset = "0x1340500", VA = "0x181341F00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1341850", Offset = "0x133FE50", VA = "0x181341850", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1341D50", Offset = "0x1340350", VA = "0x181341D50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class StateMachineTransitionData : IMessage<StateMachineTransitionData>, IMessage, IEquatable<StateMachineTransitionData>, IDeepCloneable<StateMachineTransitionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private static readonly MessageParser<StateMachineTransitionData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private int inputIndex_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int stateIndex_;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineTransitionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x13428F0", Offset = "0x1340EF0", VA = "0x1813428F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x1342820", Offset = "0x1340E20", VA = "0x181342820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x1342950", Offset = "0x1340F50", VA = "0x181342950", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[DebuggerNonUserCode]
		public int InputIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[DebuggerNonUserCode]
		public int StateIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xB85C40", Offset = "0xB84240", VA = "0x180B85C40")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData(StateMachineTransitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1342600", Offset = "0x1340C00", VA = "0x181342600", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1342670", Offset = "0x1340C70", VA = "0x181342670", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xB859B0", Offset = "0xB83FB0", VA = "0x180B859B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineTransitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xB859D0", Offset = "0xB83FD0", VA = "0x180B859D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1342700", Offset = "0x1340D00", VA = "0x181342700", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xB85B10", Offset = "0xB84110", VA = "0x180B85B10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1342540", Offset = "0x1340B40", VA = "0x181342540", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xB85A50", Offset = "0xB84050", VA = "0x180B85A50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class NodeTransformDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x1338A80", Offset = "0x1337080", VA = "0x181338A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1338470", Offset = "0x1336A70", VA = "0x181338470")]
		static NodeTransformDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NodeTransformData : IMessage<NodeTransformData>, IMessage, IEquatable<NodeTransformData>, IDeepCloneable<NodeTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private static readonly MessageParser<NodeTransformData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private Vector3Data position_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private Vector3Data rotation_;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public static MessageParser<NodeTransformData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x13391A0", Offset = "0x13377A0", VA = "0x1813391A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x13390D0", Offset = "0x13376D0", VA = "0x1813390D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1339200", Offset = "0x1337800", VA = "0x181339200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public Vector3Data Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		[DebuggerNonUserCode]
		public Vector3Data Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		[DebuggerNonUserCode]
		public NodeTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1339060", Offset = "0x1337660", VA = "0x181339060")]
		[DebuggerNonUserCode]
		public NodeTransformData(NodeTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1338BA0", Offset = "0x13371A0", VA = "0x181338BA0", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1338C40", Offset = "0x1337240", VA = "0x181338C40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1338CF0", Offset = "0x13372F0", VA = "0x181338CF0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1338D50", Offset = "0x1337350", VA = "0x181338D50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1338EC0", Offset = "0x13374C0", VA = "0x181338EC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1338F20", Offset = "0x1337520", VA = "0x181338F20", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1338AE0", Offset = "0x13370E0", VA = "0x181338AE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1338DC0", Offset = "0x13373C0", VA = "0x181338DC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class Vector3DataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x1346530", Offset = "0x1344B30", VA = "0x181346530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1346190", Offset = "0x1344790", VA = "0x181346190")]
		static Vector3DataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private static readonly MessageParser<Vector3Data> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private float x_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private float y_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x1346880", Offset = "0x1344E80", VA = "0x181346880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x13467B0", Offset = "0x1344DB0", VA = "0x1813467B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x13468E0", Offset = "0x1344EE0", VA = "0x1813468E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x6D51B0", Offset = "0x6D37B0", VA = "0x1806D51B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4A9920", Offset = "0x4A7F20", VA = "0x1804A9920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x6D51C0", Offset = "0x6D37C0", VA = "0x1806D51C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x6D51E0", Offset = "0x6D37E0", VA = "0x1806D51E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x56B9B0", Offset = "0x569FB0", VA = "0x18056B9B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BE790", VA = "0x1804C0190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xB90750", Offset = "0xB8ED50", VA = "0x180B90750")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1346590", Offset = "0x1344B90", VA = "0x181346590", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1346600", Offset = "0x1344C00", VA = "0x181346600", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x10CDE80", Offset = "0x10CC480", VA = "0x1810CDE80", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x10CDEC0", Offset = "0x10CC4C0", VA = "0x1810CDEC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1346690", Offset = "0x1344C90", VA = "0x181346690", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x10CE080", Offset = "0x10CC680", VA = "0x1810CE080", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x10CDD40", Offset = "0x10CC340", VA = "0x1810CDD40", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x10CDFA0", Offset = "0x10CC5A0", VA = "0x1810CDFA0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		Player_Health = 0,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		Player_Shield = 1,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		PlayerStat_1 = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		PlayerStat_2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		PlayerStat_3 = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		PlayerStat_4 = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		PlayerStat_5 = 1004,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		PlayerStat_6 = 1005
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class FriendlyCircuitPlayerStats
	{
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private static Dictionary<string, int> friendlyCircuitPlayerStatsDict;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public static Dictionary<string, int> FriendlyCircuitPlayerStatsDict
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x166E090", Offset = "0x166C690", VA = "0x18166E090")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int masterLastPlayerStatSignal;

		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x484430", Offset = "0x482A30", VA = "0x180484430")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x1672B20", Offset = "0x1671120", VA = "0x181672B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event GetPlayerStatFunction GetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x16729E0", Offset = "0x1670FE0", VA = "0x1816729E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x1672A80", Offset = "0x1671080", VA = "0x181672A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1672960", Offset = "0x1670F60", VA = "0x181672960")]
		public PlayerGetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x1672780", Offset = "0x1670D80", VA = "0x181672780", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1672590", Offset = "0x1670B90", VA = "0x181672590")]
		private int GetStatSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x16726C0", Offset = "0x1670CC0", VA = "0x1816726C0", Slot = "18")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1672380", Offset = "0x1670980", VA = "0x181672380", Slot = "19")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x16723F0", Offset = "0x16709F0", VA = "0x1816723F0", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1672530", Offset = "0x1670B30", VA = "0x181672530", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1672450", Offset = "0x1670A50", VA = "0x181672450", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1672660", Offset = "0x1670C60", VA = "0x181672660", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1672730", Offset = "0x1670D30", VA = "0x181672730", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x16727C0", Offset = "0x1670DC0", VA = "0x1816727C0", Slot = "24")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x484430", Offset = "0x482A30", VA = "0x180484430")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x1672B20", Offset = "0x1671120", VA = "0x181672B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event SetPlayerStatFunction SetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x1674A60", Offset = "0x1673060", VA = "0x181674A60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x1674B00", Offset = "0x1673100", VA = "0x181674B00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1674A00", Offset = "0x1673000", VA = "0x181674A00")]
		public PlayerSetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x1674720", Offset = "0x1672D20", VA = "0x181674720", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x1674700", Offset = "0x1672D00", VA = "0x181674700")]
		private void PostEvalSetPlayerStat(CircuitPlayerStat stat, int playerId, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x1674580", Offset = "0x1672B80", VA = "0x181674580", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x16746C0", Offset = "0x1672CC0", VA = "0x1816746C0", Slot = "12")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x16745E0", Offset = "0x1672BE0", VA = "0x1816745E0", Slot = "13")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1672660", Offset = "0x1670C60", VA = "0x181672660", Slot = "15")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1672730", Offset = "0x1670D30", VA = "0x181672730", Slot = "14")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1674850", Offset = "0x1672E50", VA = "0x181674850", Slot = "24")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private int masterLastScoreSignal;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event GetTeamScoreFunction GetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x166E6E0", Offset = "0x166CCE0", VA = "0x18166E6E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x166E780", Offset = "0x166CD80", VA = "0x18166E780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x166E660", Offset = "0x166CC60", VA = "0x18166E660")]
		public GameGetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x166E530", Offset = "0x166CB30", VA = "0x18166E530", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x166E400", Offset = "0x166CA00", VA = "0x18166E400")]
		private int GetScoreSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x166E4C0", Offset = "0x166CAC0", VA = "0x18166E4C0", Slot = "18")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x166E2D0", Offset = "0x166C8D0", VA = "0x18166E2D0", Slot = "19")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x166E340", Offset = "0x166C940", VA = "0x18166E340", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x166E3A0", Offset = "0x166C9A0", VA = "0x18166E3A0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event SetTeamScoreFunction SetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x166EBE0", Offset = "0x166D1E0", VA = "0x18166EBE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x166EC80", Offset = "0x166D280", VA = "0x18166EC80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x166EB80", Offset = "0x166D180", VA = "0x18166EB80")]
		public GameSetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x166E8E0", Offset = "0x166CEE0", VA = "0x18166E8E0", Slot = "22")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x166E8C0", Offset = "0x166CEC0", VA = "0x18166E8C0")]
		private void PostEvalSetGameScoreStat(int teamId, int score, bool isWinner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x166E820", Offset = "0x166CE20", VA = "0x18166E820", Slot = "11")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x166E880", Offset = "0x166CE80", VA = "0x18166E880", Slot = "12")]
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
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		DirectedForward = 1,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		DirectedBackward = 2,
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		Undirected = 3
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[Flags]
	public enum LinkTypes
	{
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		NormalToNormal = 1,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		NormalToVirtual = 2,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		VirtualToNormal = 4,
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		RootToVirtual = 8,
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		RootToNormal = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	internal struct TopologicStackEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public CircuitNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
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
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private CircuitNode <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			private CircuitNode root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			public CircuitNode <>3__root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			private DFSType dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public DFSType <>3__dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			private LinkTypes linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public LinkTypes <>3__linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			private Stack<CircuitNode> <stack>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			private HashSet<CircuitNode> <visited>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private CircuitNode <current>5__4;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			CircuitNode IEnumerator<CircuitNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xB187D0", Offset = "0xB16DD0", VA = "0x180B187D0")]
			[DebuggerHidden]
			public <DFS>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x13437E0", Offset = "0x1341DE0", VA = "0x1813437E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x1343DE0", Offset = "0x13423E0", VA = "0x181343DE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x1343D30", Offset = "0x1342330", VA = "0x181343D30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<CircuitNode> IEnumerable<CircuitNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x1343D30", Offset = "0x1342330", VA = "0x181343D30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1336E80", Offset = "0x1335480", VA = "0x181336E80")]
		public static HashSet<CircuitNode> DFSCopy(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1336F40", Offset = "0x1335540", VA = "0x181336F40")]
		[IteratorStateMachine(typeof(<DFS>d__4))]
		public static IEnumerable<CircuitNode> DFS(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x13372F0", Offset = "0x13358F0", VA = "0x1813372F0")]
		public static List<CircuitNode> TopologicSort(CircuitNode root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x13372D0", Offset = "0x13358D0", VA = "0x1813372D0")]
		private static bool ShouldFollowLink(CircuitLink link, LinkTypes linkTypesToFollow)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1336FD0", Offset = "0x13355D0", VA = "0x181336FD0")]
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
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x132FDE0", Offset = "0x132E3E0", VA = "0x18132FDE0")]
		public static Guid ToGuid(this ByteString bytes)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x132FD80", Offset = "0x132E380", VA = "0x18132FD80")]
		public static ByteString ToByteString(this Guid guid)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum CircuitLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
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
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x1330290", Offset = "0x132E890", VA = "0x181330290")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x1330480", Offset = "0x132EA80", VA = "0x181330480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public static event LogExceptionEvent OnLogExceptionEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x1330380", Offset = "0x132E980", VA = "0x181330380")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x1330570", Offset = "0x132EB70", VA = "0x181330570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x132FF60", Offset = "0x132E560", VA = "0x18132FF60")]
		public static void LogException(Exception e, [Optional] string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1330030", Offset = "0x132E630", VA = "0x181330030")]
		public static void Log(CircuitLogLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x13301F0", Offset = "0x132E7F0", VA = "0x1813301F0")]
		public static void NodeLog(int nodeId, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1330100", Offset = "0x132E700", VA = "0x181330100")]
		public static void NodeLogFormat(int nodeId, CircuitLogLevel CircuitLogLevel, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x132FEC0", Offset = "0x132E4C0", VA = "0x18132FEC0")]
		public static void GraphLog(Guid graphGuid, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal static class NodeEventUtil
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x13383E0", Offset = "0x13369E0", VA = "0x1813383E0")]
		internal static void SafeInvoke(this CircuitNode.NodeLifecycleEvent nodeLifecycleEvent, CircuitNode nodeArg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1338320", Offset = "0x1336920", VA = "0x181338320")]
		internal static void SafeInvoke(this CircuitNode.NodeConnectionChanged nodeConnectionEvent, CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal static class RuntimeAssert
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x133AA00", Offset = "0x1339000", VA = "0x18133AA00")]
		public static void Assert(bool condition, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x133A970", Offset = "0x1338F70", VA = "0x18133A970")]
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
