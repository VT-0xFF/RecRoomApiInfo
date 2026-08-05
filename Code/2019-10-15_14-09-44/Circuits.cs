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
			[Cpp2IlInjected.Address(RVA = "0x1669190", Offset = "0x1667F90", VA = "0x181669190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x16690E0", Offset = "0x1667EE0", VA = "0x1816690E0")]
		public CircuitLink(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1668DF0", Offset = "0x1667BF0", VA = "0x181668DF0")]
		public CircuitLinkData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1668BF0", Offset = "0x16679F0", VA = "0x181668BF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1668D40", Offset = "0x1667B40", VA = "0x181668D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1668EA0", Offset = "0x1667CA0", VA = "0x181668EA0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x39C150", Offset = "0x39AF50", VA = "0x18039C150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x166F7A0", Offset = "0x166E5A0", VA = "0x18166F7A0")]
		public CircuitNodeUuidAttribute(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x166F730", Offset = "0x166E530", VA = "0x18166F730")]
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
		[Cpp2IlInjected.Address(RVA = "0x167ACF0", Offset = "0x1679AF0", VA = "0x18167ACF0", Slot = "4")]
		public bool Equals(InputSlot x, InputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x167AD10", Offset = "0x1679B10", VA = "0x18167AD10", Slot = "5")]
		public int GetHashCode(InputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		public InputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class OutputSlotComparer : IEqualityComparer<OutputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x167ACF0", Offset = "0x1679AF0", VA = "0x18167ACF0", Slot = "4")]
		public bool Equals(OutputSlot x, OutputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x167AD10", Offset = "0x1679B10", VA = "0x18167AD10", Slot = "5")]
		public int GetHashCode(OutputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x321AB0", Offset = "0x3208B0", VA = "0x180321AB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal virtual bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x321AB0", Offset = "0x3208B0", VA = "0x180321AB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal virtual bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x321AB0", Offset = "0x3208B0", VA = "0x180321AB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal virtual bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x321AB0", Offset = "0x3208B0", VA = "0x180321AB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal virtual bool RequiresConnectionToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1676370", Offset = "0x1675170", VA = "0x181676370", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal virtual bool IsConnectedToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1675B80", Offset = "0x1674980", VA = "0x181675B80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		internal virtual bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x321AB0", Offset = "0x3208B0", VA = "0x180321AB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CircuitNode PairedNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x358690", Offset = "0x357490", VA = "0x180358690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HasConnectedInputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1675710", Offset = "0x1674510", VA = "0x181675710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal bool UsesAnyDefaultInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1676520", Offset = "0x1675320", VA = "0x181676520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HasConnectedOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1675820", Offset = "0x1674620", VA = "0x181675820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x411620", Offset = "0x410420", VA = "0x180411620")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x576F30", Offset = "0x575D30", VA = "0x180576F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x31B670", Offset = "0x31A470", VA = "0x18031B670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x31B6F0", Offset = "0x31A4F0", VA = "0x18031B6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public virtual int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83CCA0", Offset = "0x83BAA0", VA = "0x18083CCA0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x16764C0", Offset = "0x16752C0", VA = "0x1816764C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NodeMetadata NodeMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1675C80", Offset = "0x1674A80", VA = "0x181675C80")]
			[CompilerGenerated]
			get
			{
				return default(NodeMetadata);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1676790", Offset = "0x1675590", VA = "0x181676790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public CircuitNodeGraph NodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x334A00", Offset = "0x333800", VA = "0x180334A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x466170", Offset = "0x464F70", VA = "0x180466170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x466250", Offset = "0x465050", VA = "0x180466250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected string OutputSignalString
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x16761E0", Offset = "0x1674FE0", VA = "0x1816761E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected string InputSignalString
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1675870", Offset = "0x1674670", VA = "0x181675870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public virtual string NodeVisualizationLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1675CA0", Offset = "0x1674AA0", VA = "0x181675CA0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static int NodeCount
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1675C10", Offset = "0x1674A10", VA = "0x181675C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static InputMetadata[] AllSlotsInputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1675380", Offset = "0x1674180", VA = "0x181675380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static OutputMetadata[] AllSlotsOutputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1675540", Offset = "0x1674340", VA = "0x181675540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NodeModifiedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x16752E0", Offset = "0x16740E0", VA = "0x1816752E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x16766F0", Offset = "0x16754F0", VA = "0x1816766F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NodeDeserializedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1675240", Offset = "0x1674040", VA = "0x181675240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1676650", Offset = "0x1675450", VA = "0x181676650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1672D70", Offset = "0x1671B70", VA = "0x181672D70")]
		public static int NewNodeId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1674820", Offset = "0x1673620", VA = "0x181674820")]
		internal static int SetPossibleMaxId(int newPossibleMax)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16733A0", Offset = "0x16721A0", VA = "0x1816733A0")]
		public static void ResetMaxNodeId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16727B0", Offset = "0x16715B0", VA = "0x1816727B0")]
		public static long GetMaxNodeId()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1672EA0", Offset = "0x1671CA0", VA = "0x181672EA0")]
		internal static void OverrideMaxNodeId(long overrideValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x16734A0", Offset = "0x16722A0", VA = "0x1816734A0")]
		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1673510", Offset = "0x1672310", VA = "0x181673510")]
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
		[Cpp2IlInjected.Address(RVA = "0x31B670", Offset = "0x31A470", VA = "0x18031B670", Slot = "15")]
		protected virtual string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1674FB0", Offset = "0x1673DB0", VA = "0x181674FB0")]
		public CircuitNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1672FC0", Offset = "0x1671DC0", VA = "0x181672FC0")]
		protected void ReconstructNodeMetadata()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1673A20", Offset = "0x1672820", VA = "0x181673A20", Slot = "16")]
		public virtual CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1672970", Offset = "0x1671770", VA = "0x181672970", Slot = "17")]
		internal virtual void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1670C50", Offset = "0x166FA50", VA = "0x181670C50")]
		public void CopySettings(CircuitNodeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1670CE0", Offset = "0x166FAE0", VA = "0x181670CE0")]
		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1673A10", Offset = "0x1672810", VA = "0x181673A10", Slot = "18")]
		internal virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1671720", Offset = "0x1670520", VA = "0x181671720", Slot = "19")]
		internal virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x31B730", Offset = "0x31A530", VA = "0x18031B730", Slot = "20")]
		internal virtual void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x31B730", Offset = "0x31A530", VA = "0x18031B730", Slot = "21")]
		internal virtual void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1673820", Offset = "0x1672620", VA = "0x181673820")]
		private void SerializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x16714F0", Offset = "0x16702F0", VA = "0x1816714F0")]
		private void DeserializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x16744D0", Offset = "0x16732D0", VA = "0x1816744D0")]
		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1670480", Offset = "0x166F280", VA = "0x181670480")]
		internal static bool ConnectNodes(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1673580", Offset = "0x1672380", VA = "0x181673580")]
		private static void SendNodesConnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x16736D0", Offset = "0x16724D0", VA = "0x1816736D0")]
		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x166F7F0", Offset = "0x166E5F0", VA = "0x18166F7F0")]
		private static void AddLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x16725B0", Offset = "0x16713B0", VA = "0x1816725B0")]
		internal static bool FormsLoop(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1670AE0", Offset = "0x166F8E0", VA = "0x181670AE0")]
		public bool ConnectToMyInput(CircuitNode sourceNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x166F8E0", Offset = "0x166E6E0", VA = "0x18166F8E0")]
		protected bool CanConnectInput(CircuitNode newSourceNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1670BA0", Offset = "0x166F9A0", VA = "0x181670BA0")]
		public bool ConnectToMyOutput(CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x166F9B0", Offset = "0x166E7B0", VA = "0x18166F9B0")]
		protected bool CanConnectOutput(InputSlot inputSlot, OutputSlot outputSlot, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1674A80", Offset = "0x1673880", VA = "0x181674A80")]
		protected bool SlotsCanConnect(InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1671AF0", Offset = "0x16708F0", VA = "0x181671AF0")]
		public void DisconnectInput(InputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1671730", Offset = "0x1670530", VA = "0x181671730", Slot = "22")]
		public virtual void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x16722D0", Offset = "0x16710D0", VA = "0x1816722D0")]
		public void DisconnectOutput(OutputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1671B90", Offset = "0x1670990", VA = "0x181671B90")]
		protected static void DisconnectNodeLink(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1673110", Offset = "0x1671F10", VA = "0x181673110")]
		private static void RemoveLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1673220", Offset = "0x1672020", VA = "0x181673220")]
		private static bool RemoveOutputLink(CircuitNode node, CircuitLink link)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1673050", Offset = "0x1671E50", VA = "0x181673050")]
		private static bool RemoveInputSlot(CircuitNode node, InputSlot inputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x166FDA0", Offset = "0x166EBA0", VA = "0x18166FDA0")]
		private static bool CheckForDisconnectedGraph(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1672460", Offset = "0x1671260", VA = "0x181672460")]
		internal void EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x31B730", Offset = "0x31A530", VA = "0x18031B730", Slot = "23")]
		internal virtual void PostEvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1672910", Offset = "0x1671710", VA = "0x181672910")]
		public bool HasMomentaryOutputs()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x16702E0", Offset = "0x166F0E0", VA = "0x1816702E0")]
		public void ClearMomentaryOutputs(int currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x31B730", Offset = "0x31A530", VA = "0x18031B730", Slot = "24")]
		protected virtual void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1674E90", Offset = "0x1673C90", VA = "0x181674E90", Slot = "25")]
		protected virtual void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x16703D0", Offset = "0x166F1D0", VA = "0x1816703D0")]
		protected void ClearOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1672690", Offset = "0x1671490", VA = "0x181672690")]
		public int GetInputSignal(InputSlot inputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1672770", Offset = "0x1671570", VA = "0x181672770")]
		public int GetLastOutputSignalTimeStamp(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x16728D0", Offset = "0x16716D0", VA = "0x1816728D0")]
		public int GetOutputSignal(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1674490", Offset = "0x1673290", VA = "0x181674490")]
		protected void SetContinuousOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x16744B0", Offset = "0x16732B0", VA = "0x1816744B0")]
		protected void SetMomentaryOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1674680", Offset = "0x1673480", VA = "0x181674680")]
		private void SetOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x16749C0", Offset = "0x16737C0", VA = "0x1816749C0")]
		private bool SlotDirtiesGraph(OutputSlot outputSlot, int val, bool isMomentary)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x166FBB0", Offset = "0x166E9B0", VA = "0x18166FBB0")]
		private void ChangeDefaultInputValue(SlotData slotData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1672D20", Offset = "0x1671B20", VA = "0x181672D20")]
		public void ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2C0", Offset = "0x3FE0C0", VA = "0x1803FF2C0")]
		public void SendDeserializedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1674D90", Offset = "0x1673B90", VA = "0x181674D90", Slot = "26")]
		protected virtual void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1670110", Offset = "0x166EF10", VA = "0x181670110")]
		internal static void ClearAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1672520", Offset = "0x1671320", VA = "0x181672520")]
		public static CircuitNode Find(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x11E3CA0", Offset = "0x11E2AA0", VA = "0x1811E3CA0")]
		public static int BoolToSignal(bool value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x16749B0", Offset = "0x16737B0", VA = "0x1816749B0")]
		public static bool SignalToBool(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1670090", Offset = "0x166EE90", VA = "0x181670090")]
		public static int ClampSignal(int value, int min, int max)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class DictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xF8C700", Offset = "0xF8B500", VA = "0x180F8C700")]
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
			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public CircuitNodeGraphCollectionData GraphCollectionData
			{
				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x362AD0", Offset = "0x3618D0", VA = "0x180362AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x362AF0", Offset = "0x3618F0", VA = "0x180362AF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x358690", Offset = "0x357490", VA = "0x180358690")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
			public SerializedCircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class CircuitNodeGraphCopy
		{
			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public List<CircuitNodeGraph> CopiedGraphs
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x362AD0", Offset = "0x3618D0", VA = "0x180362AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x362AF0", Offset = "0x3618F0", VA = "0x180362AF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0x358690", Offset = "0x357490", VA = "0x180358690")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
			public CircuitNodeGraphCopy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static List<CircuitNodeGraph> AllGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly Guid GraphGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly bool IsInternalGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private RootNode _rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool GraphRequiresSort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		internal readonly HashSet<CircuitNode> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly List<CircuitNode> StatefulNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private List<CircuitNode> ReverseTopologicNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private List<CircuitNode> NodesToConnectForSingleEvaluate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool destroyed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private HashSet<CircuitNode> needsPostEval;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static BitPacker bitPacker;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RootNode RootNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x31B670", Offset = "0x31A470", VA = "0x18031B670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x31B6F0", Offset = "0x31A4F0", VA = "0x18031B6F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool NodeGraphDirty
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x589B00", Offset = "0x588900", VA = "0x180589B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x58CF40", Offset = "0x58BD40", VA = "0x18058CF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x557930", Offset = "0x556730", VA = "0x180557930")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x82B800", Offset = "0x82A600", VA = "0x18082B800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		internal static event UpdateGraph TimeUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x166F530", Offset = "0x166E330", VA = "0x18166F530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x166F630", Offset = "0x166E430", VA = "0x18166F630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x166F4A0", Offset = "0x166E2A0", VA = "0x18166F4A0")]
		internal CircuitNodeGraph(bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x166F470", Offset = "0x166E270", VA = "0x18166F470")]
		public CircuitNodeGraph(Guid guid, bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x166F2D0", Offset = "0x166E0D0", VA = "0x18166F2D0")]
		private CircuitNodeGraph(Guid guid, bool isInternalGraph, bool createRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x166E0B0", Offset = "0x166CEB0", VA = "0x18166E0B0")]
		public static void Update(int networkTimeMilliseconds, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x166BE90", Offset = "0x166AC90", VA = "0x18166BE90")]
		private void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x166BD40", Offset = "0x166AB40", VA = "0x18166BD40")]
		public void DestroySelfAndNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1669700", Offset = "0x1668500", VA = "0x181669700")]
		internal void AddNode(CircuitNode circuitNode, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x166D340", Offset = "0x166C140", VA = "0x18166D340")]
		internal bool RemoveNode(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1669960", Offset = "0x1668760", VA = "0x181669960")]
		internal bool ConnectToRootForSingleEvaluate(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x166BF20", Offset = "0x166AD20", VA = "0x18166BF20")]
		public List<CircuitNode> Evaluate(bool isMasterClient)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1669920", Offset = "0x1668720", VA = "0x181669920", Slot = "4")]
		public int CompareTo(CircuitNodeGraph other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x166DC90", Offset = "0x166CA90", VA = "0x18166DC90")]
		public static byte[] SerializeRuntimeState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x166B280", Offset = "0x166A080", VA = "0x18166B280")]
		public static void DeserializeRuntimeState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x166D960", Offset = "0x166C760", VA = "0x18166D960")]
		public static byte[] SerializePostEvaluateState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x166AF50", Offset = "0x1669D50", VA = "0x18166AF50")]
		public static void DeserializePostEvaluateState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x166CEB0", Offset = "0x166BCB0", VA = "0x18166CEB0")]
		public static CircuitNodeGraphCollectionData PersistAll([Optional] IList<int> inactiveIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x166BCA0", Offset = "0x166AAA0", VA = "0x18166BCA0")]
		public static void DestroyAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x166AB50", Offset = "0x1669950", VA = "0x18166AB50")]
		public static void DeserializeAll(CircuitNodeGraphCollectionData data, out Dictionary<int, int> nodeIdMappings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x166D090", Offset = "0x166BE90", VA = "0x18166D090")]
		public CircuitNodeGraphData Persist()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x166B5B0", Offset = "0x166A3B0", VA = "0x18166B5B0")]
		public static CircuitNodeGraph Deserialize(CircuitNodeGraphData data, bool reassignNodeIds, out Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x16699F0", Offset = "0x16687F0", VA = "0x1816699F0")]
		public static CircuitNodeGraphCopy CopyNodesToNewGraphs(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x166D440", Offset = "0x166C240", VA = "0x18166D440")]
		public static SerializedCircuitNodeGraphCopy SerializeNodesAsNewGraph(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x166C970", Offset = "0x166B770", VA = "0x18166C970")]
		public static CircuitNodeGraph MergeGraphs(CircuitNode nodeA, CircuitNode nodeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x166CBD0", Offset = "0x166B9D0", VA = "0x18166CBD0")]
		private static CircuitNodeGraph MergeInto(CircuitNodeGraph toGraph, CircuitNodeGraph fromGraph, params CircuitNode[] nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x166E2A0", Offset = "0x166D0A0", VA = "0x18166E2A0")]
		public void VisualizeWithFormatString(string htmlString, string outputFileName, bool useDFS = false, bool showRootConnections = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x166C5B0", Offset = "0x166B3B0", VA = "0x18166C5B0")]
		private string LinkLabel(CircuitLink link)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x166DFC0", Offset = "0x166CDC0", VA = "0x18166DFC0")]
		private static string SlotToStringColor(OutputSlot slot)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum InputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		R,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		G,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		B,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		C,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		M,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		K,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		VIRTUAL,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		H00,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		H01,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		H02,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		H03,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		H04,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		H05,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		H06,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		H07,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		H08,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		H09,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		H10,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		H11,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		H12,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		H13,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		H14,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		H15,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		H16,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		H17,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		H18,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		H19,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		H20,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		H21,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		H22,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		H23,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		H24,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		H25,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		H26,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		H27,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		H28,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		H29,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		H30,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		H31,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		H32,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		H33,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		H34,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		H35,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		H36,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		H37,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		H38,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		H39,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		H40,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		H41,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		H42,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		H43,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		H44,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		H45,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		H46,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		H47,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		H48,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		H49,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		H50,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		H51,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		H52,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		H53,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		H54,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		H55,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		H56,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		H57,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		H58,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		H59,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		H60,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		H61,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		H62,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		H63,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		H64,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		H65,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		H66,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		H67,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		H68,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		H69,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		H70,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		H71,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		H72,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		H73,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		H74,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		H75,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		H76,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		H77,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		H78,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		H79,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		H80,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		H81,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		H82,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		H83,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		H84,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		H85,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		H86,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		H87,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		H88,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		H89,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		H90,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		H91,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		H92,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		H93,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		H94,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		H95,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		H96,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		H97,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		H98,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		H99
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum OutputSlot
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		R,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		G,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		B,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		C,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		M,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		K,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		RESET,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		VIRTUAL,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		H00,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		H01,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		H02,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		H03,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		H04,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		H05,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		H06,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		H07,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		H08,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		H09,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		H10,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		H11,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		H12,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		H13,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		H14,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		H15,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		H16,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		H17,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		H18,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		H19,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		H20,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		H21,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		H22,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		H23,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		H24,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		H25,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		H26,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		H27,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		H28,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		H29,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		H30,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		H31,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		H32,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		H33,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		H34,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		H35,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		H36,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		H37,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		H38,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		H39,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		H40,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		H41,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		H42,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		H43,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		H44,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		H45,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		H46,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		H47,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		H48,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		H49,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		H50,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		H51,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		H52,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		H53,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		H54,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		H55,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		H56,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		H57,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		H58,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		H59,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		H60,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		H61,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		H62,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		H63,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		H64,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		H65,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		H66,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		H67,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		H68,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		H69,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		H70,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		H71,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		H72,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		H73,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		H74,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		H75,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		H76,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		H77,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		H78,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		H79,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		H80,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		H81,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		H82,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		H83,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		H84,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		H85,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		H86,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		H87,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		H88,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		H89,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		H90,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		H91,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		H92,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		H93,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		H94,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		H95,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		H96,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		H97,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		H98,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		H99
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class IOSlots
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static InputSlot[] AllInputSlots;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static InputSlot[] AllStandardInputSlots;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static OutputSlot[] AllOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static OutputSlot[] AllStandardOutputSlots;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xD89700", Offset = "0xD88500", VA = "0x180D89700")]
		public static OutputSlot InputSlotToOutputSlot(InputSlot input)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xD89700", Offset = "0xD88500", VA = "0x180D89700")]
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
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			And,
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			Or,
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			Not
		}

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly InputMetadata[] NotInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly OutputMetadata[] NotOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly Dictionary<BooleanModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private BooleanModes booleanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private List<int> inputs;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public BooleanModes BooleanMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(BooleanModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x151D230", Offset = "0x151C030", VA = "0x18151D230")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x16683D0", Offset = "0x16671D0", VA = "0x1816683D0")]
		public static string GetModeSymbol(BooleanModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1668AC0", Offset = "0x16678C0", VA = "0x181668AC0")]
		public BooleanNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1668670", Offset = "0x1667470", VA = "0x181668670", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1667FC0", Offset = "0x1666DC0", VA = "0x181667FC0")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1667D80", Offset = "0x1666B80", VA = "0x181667D80")]
		private bool CalcAndOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1667EA0", Offset = "0x1666CA0", VA = "0x181667EA0")]
		private bool CalcOrOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1668220", Offset = "0x1667020", VA = "0x181668220")]
		private void FetchInputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1668340", Offset = "0x1667140", VA = "0x181668340", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1668510", Offset = "0x1667310", VA = "0x181668510", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1668450", Offset = "0x1667250", VA = "0x181668450", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x16685B0", Offset = "0x16673B0", VA = "0x1816685B0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1668620", Offset = "0x1667420", VA = "0x181668620", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1668740", Offset = "0x1667540", VA = "0x181668740", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CircuitNodeUuid("B7BA1A4B-EA04-496F-B8B6-A2FB7C4A42B9")]
	public class ContinuousSourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1678310", Offset = "0x1677110", VA = "0x181678310")]
		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1674490", Offset = "0x1673290", VA = "0x181674490")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CircuitNodeUuid("B58C2FAB-4F1A-15F5-6D32-4E3BE18B62B8")]
	public class CustomNode : CircuitNode, ISourceNode, IOutputNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int[] lastSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x16788F0", Offset = "0x16776F0", VA = "0x1816788F0")]
		public CustomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1678420", Offset = "0x1677220", VA = "0x181678420", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x16787E0", Offset = "0x16775E0", VA = "0x1816787E0")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x16744B0", Offset = "0x16732B0", VA = "0x1816744B0", Slot = "28")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1518EC0", Offset = "0x1517CC0", VA = "0x181518EC0", Slot = "29")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x347A70", Offset = "0x346870", VA = "0x180347A70", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x16788A0", Offset = "0x16776A0", VA = "0x1816788A0", Slot = "32")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x511ED0", Offset = "0x510CD0", VA = "0x180511ED0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1678390", Offset = "0x1677190", VA = "0x181678390", Slot = "30")]
		public void AddUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1678810", Offset = "0x1677610", VA = "0x181678810", Slot = "31")]
		public void RemoveUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x16788B0", Offset = "0x16776B0", VA = "0x1816788B0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x16788C0", Offset = "0x16776C0", VA = "0x1816788C0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x16784E0", Offset = "0x16772E0", VA = "0x1816784E0")]
		private void FireEventIfNeeded(bool addReset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CircuitNodeUuid("53219714-E7BB-4950-BBB3-852A7EF196F8")]
	public class GameSetStateNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private static InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action StartGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x167A6E0", Offset = "0x16794E0", VA = "0x18167A6E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x167A820", Offset = "0x1679620", VA = "0x18167A820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action EndGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x167A640", Offset = "0x1679440", VA = "0x18167A640")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x167A780", Offset = "0x1679580", VA = "0x18167A780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x167A320", Offset = "0x1679120", VA = "0x18167A320", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x167A380", Offset = "0x1679180", VA = "0x18167A380", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x167A5E0", Offset = "0x16793E0", VA = "0x18167A5E0")]
		public GameSetStateNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x167A3E0", Offset = "0x16791E0", VA = "0x18167A3E0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CircuitNodeUuid("20C6AC2E-1116-4C93-8CDF-40FE161CC796")]
	public class ObjectSetTagsNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum ChangeModes
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			Defaults
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate void ChangeTagsForObjectFunc(int objectId);

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public const string MODE_ARG = "mode";

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private const string nodeDescription = "Change Tags on Object";

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private ChangeModes changeMode;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ChangeModes ChangeMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(ChangeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x151D230", Offset = "0x151C030", VA = "0x18151D230")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ChangeTagsForObjectFunc ChangeTagsForObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x167CA50", Offset = "0x167B850", VA = "0x18167CA50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x167CAF0", Offset = "0x167B8F0", VA = "0x18167CAF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x167C9D0", Offset = "0x167B7D0", VA = "0x18167C9D0")]
		public ObjectSetTagsNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x167C620", Offset = "0x167B420", VA = "0x18167C620", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x167C5C0", Offset = "0x167B3C0", VA = "0x18167C5C0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x167C690", Offset = "0x167B490", VA = "0x18167C690", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x167C7E0", Offset = "0x167B5E0", VA = "0x18167C7E0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x167C6F0", Offset = "0x167B4F0", VA = "0x18167C6F0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x16685B0", Offset = "0x16673B0", VA = "0x1816685B0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1668620", Offset = "0x1667420", VA = "0x181668620", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CircuitNodeUuid("0D0D8EA8-2816-4B3B-8F1D-19C74B056DA6")]
	public class PlayerRoleMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public enum PlayerRoleMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			AddPlayerRole,
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			RemovePlayerRole,
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			PlayerHasRole,
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			PlayerRoleChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate void PlayerModifyRoleFunc(int playerId, Guid roleGuid);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool PlayerHasRoleFunc(int playerId, Guid roleGuid);

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly OutputMetadata[] PlayerHasRoleOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly OutputMetadata[] PlayerRoleChangedOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly InputMetadata[] PlayerHasRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private static readonly InputMetadata[] ModifyPlayerRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly OutputMetadata[] ModifyPlayerRoleOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private PlayerRoleMapModes playerRoleMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Guid modificationRoleGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private bool masterLastPlayerHasRoleSignal;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public PlayerRoleMapModes PlayerRoleMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x10AB3D0", Offset = "0x10AA1D0", VA = "0x1810AB3D0")]
			get
			{
				return default(PlayerRoleMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1512990", Offset = "0x1511790", VA = "0x181512990")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid ModificationRoleGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x167EEC0", Offset = "0x167DCC0", VA = "0x18167EEC0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x167F260", Offset = "0x167E060", VA = "0x18167F260")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string NodeVisualizationLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x167EED0", Offset = "0x167DCD0", VA = "0x18167EED0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PlayerModifyRoleFunc PlayerAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x167EBA0", Offset = "0x167D9A0", VA = "0x18167EBA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x167EF40", Offset = "0x167DD40", VA = "0x18167EF40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PlayerModifyRoleFunc TeamAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x167ED80", Offset = "0x167DB80", VA = "0x18167ED80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x167F120", Offset = "0x167DF20", VA = "0x18167F120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PlayerModifyRoleFunc PlayerRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x167ECE0", Offset = "0x167DAE0", VA = "0x18167ECE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x167F080", Offset = "0x167DE80", VA = "0x18167F080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event PlayerModifyRoleFunc TeamRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x167EE20", Offset = "0x167DC20", VA = "0x18167EE20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x167F1C0", Offset = "0x167DFC0", VA = "0x18167F1C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event PlayerHasRoleFunc PlayerHasRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x167EC40", Offset = "0x167DA40", VA = "0x18167EC40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x167EFE0", Offset = "0x167DDE0", VA = "0x18167EFE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x167E3E0", Offset = "0x167D1E0", VA = "0x18167E3E0")]
		public void MarkDirtyForRoleChange(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x167EAF0", Offset = "0x167D8F0", VA = "0x18167EAF0")]
		public PlayerRoleMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x167E4D0", Offset = "0x167D2D0", VA = "0x18167E4D0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x167DB90", Offset = "0x167C990", VA = "0x18167DB90")]
		private void EvaluatePlayerHasRole(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x167E100", Offset = "0x167CF00", VA = "0x18167E100")]
		private bool GetPlayerHasRoleSignal(bool isMasterClient, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x167D9D0", Offset = "0x167C7D0", VA = "0x18167D9D0")]
		private void EvaluateAddPlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x167DC60", Offset = "0x167CA60", VA = "0x18167DC60")]
		private void EvaluateRemovePlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x167E420", Offset = "0x167D220", VA = "0x18167E420", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x167D9A0", Offset = "0x167C7A0", VA = "0x18167D9A0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x167DE20", Offset = "0x167CC20", VA = "0x18167DE20", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x167DFD0", Offset = "0x167CDD0", VA = "0x18167DFD0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x167DF20", Offset = "0x167CD20", VA = "0x18167DF20", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x167E1E0", Offset = "0x167CFE0", VA = "0x18167E1E0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x167E450", Offset = "0x167D250", VA = "0x18167E450", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x167E5E0", Offset = "0x167D3E0", VA = "0x18167E5E0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CircuitNodeUuid("B81209CD-0D42-4FC7-A7A4-9AF3E78499B6")]
	public class PlayerRoleNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1510840", Offset = "0x150F640", VA = "0x181510840")]
		public PlayerRoleNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x15107C0", Offset = "0x150F5C0", VA = "0x1815107C0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1510800", Offset = "0x150F600", VA = "0x181510800", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CircuitNodeUuid("CEE29EB9-61AE-42D4-8DC6-3A62D7096781")]
	public class PlayerTeamMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum PlayerIdMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			PlayerToTeam,
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			TeamToPlayer,
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			SetPlayerTeam,
			[Cpp2IlInjected.Token(Token = "0x400017A")]
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

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly InputMetadata[] PlayerToTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly OutputMetadata[] PlayerToTeamOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly InputMetadata[] TeamToPlayerInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly OutputMetadata[] TeamToPlayerOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly InputMetadata[] SetPlayerTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly InputMetadata[] GetTeamPlayerCountInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly OutputMetadata[] GetTeamPlayerCountOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static readonly OutputMetadata[] SetPlayerTeamOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private PlayerIdMapModes playerIdMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int lastMasterPlayerToTeamId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int lastMasterPlayerToTeamIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int lastMasterTeamIndexToPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int lastMasterTeamPlayerCount;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public PlayerIdMapModes PlayerIdMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x10AB3D0", Offset = "0x10AA1D0", VA = "0x1810AB3D0")]
			get
			{
				return default(PlayerIdMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1512990", Offset = "0x1511790", VA = "0x181512990")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string NodeVisualizationLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x15126A0", Offset = "0x15114A0", VA = "0x1815126A0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event PlayerToTeamIndexFunc PlayerToTeamIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1512560", Offset = "0x1511360", VA = "0x181512560")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x1512850", Offset = "0x1511650", VA = "0x181512850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event PlayerSetTeamFunc PlayerSetTeam
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x15124C0", Offset = "0x15112C0", VA = "0x1815124C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x15127B0", Offset = "0x15115B0", VA = "0x1815127B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event TeamIndexToPlayerFunc TeamIndexToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1512600", Offset = "0x1511400", VA = "0x181512600")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x15128F0", Offset = "0x15116F0", VA = "0x1815128F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event GetTeamPlayerCountFunc GetTeamPlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x1512420", Offset = "0x1511220", VA = "0x181512420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1512710", Offset = "0x1511510", VA = "0x181512710")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1511A10", Offset = "0x1510810", VA = "0x181511A10")]
		public void MarkDirtyForTeamChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x15123C0", Offset = "0x15111C0", VA = "0x1815123C0")]
		public PlayerTeamMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1511B90", Offset = "0x1510990", VA = "0x181511B90", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x15111D0", Offset = "0x150FFD0", VA = "0x1815111D0")]
		private void EvaluatePlayerToTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1511700", Offset = "0x1510500", VA = "0x181511700")]
		private void GetPlayerToTeamSignals(bool isMasterClient, int playerId, out int masterTeamId, out int masterTeamIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1511340", Offset = "0x1510140", VA = "0x181511340")]
		private void EvaluateTeamToPlayer(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x15117E0", Offset = "0x15105E0", VA = "0x1815117E0")]
		private int GetTeamIndexToPlayerSignal(bool isMasterClient, int teamId, int teamIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1511130", Offset = "0x150FF30", VA = "0x181511130")]
		private void EvaluateGetTeamPlayerCount(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x15118C0", Offset = "0x15106C0", VA = "0x1815118C0")]
		private int GetTeamPlayerCountSignal(bool isMasterClient, int teamId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1511260", Offset = "0x1510060", VA = "0x181511260")]
		private void EvaluateSetPlayerTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1511A40", Offset = "0x1510840", VA = "0x181511A40", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1510FE0", Offset = "0x150FDE0", VA = "0x181510FE0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x15113C0", Offset = "0x15101C0", VA = "0x1815113C0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x15115A0", Offset = "0x15103A0", VA = "0x1815115A0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1511520", Offset = "0x1510320", VA = "0x181511520", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x15119B0", Offset = "0x15107B0", VA = "0x1815119B0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x150FF40", Offset = "0x150ED40", VA = "0x18150FF40", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1511E70", Offset = "0x1510C70", VA = "0x181511E70", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class PostEvalActionNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private List<Action> PostEvalActions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		internal sealed override bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1513040", Offset = "0x1511E40", VA = "0x181513040", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1512F80", Offset = "0x1511D80", VA = "0x181512F80")]
		public PostEvalActionNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1512F20", Offset = "0x1511D20", VA = "0x181512F20")]
		protected void QueuePostEvalAction(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1512D70", Offset = "0x1511B70", VA = "0x181512D70", Slot = "23")]
		internal sealed override void PostEvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CircuitNodeUuid("3079A591-0E82-41B5-8BEC-00AC26F8E6C4")]
	public class QueuedMomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public struct Output
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public OutputSlot outputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public int outputValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		internal List<Output[]> QueuedSignals;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1513670", Offset = "0x1512470", VA = "0x181513670")]
		public QueuedMomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x15134B0", Offset = "0x15122B0", VA = "0x1815134B0")]
		public new void SetContinuousOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x15134C0", Offset = "0x15122C0", VA = "0x1815134C0")]
		public new void SetMomentaryOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1513560", Offset = "0x1512360", VA = "0x181513560")]
		public void SetMomentaryOutputs(params Output[] outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1513570", Offset = "0x1512370", VA = "0x181513570", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1513300", Offset = "0x1512100", VA = "0x181513300", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x15130B0", Offset = "0x1511EB0", VA = "0x1815130B0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1513230", Offset = "0x1512030", VA = "0x181513230")]
		private void QueueSignal(Output[] outputs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CircuitNodeUuid("AA5DC0B1-AC22-4075-AB13-E8376AA0FC39")]
	public class ObjectPlayerMappingNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void ObjectToHoldingPlayerIdFunc(int objectId, out int lastHeldPlayer, out int currentHoldingPlayer);

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event ObjectToHoldingPlayerIdFunc ObjectToHoldingPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x167C480", Offset = "0x167B280", VA = "0x18167C480")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x167C520", Offset = "0x167B320", VA = "0x18167C520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x167C400", Offset = "0x167B200", VA = "0x18167C400")]
		public ObjectPlayerMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x167BFE0", Offset = "0x167ADE0", VA = "0x18167BFE0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x167BF80", Offset = "0x167AD80", VA = "0x18167BF80", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x167C010", Offset = "0x167AE10", VA = "0x18167C010", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x167C200", Offset = "0x167B000", VA = "0x18167C200", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x167C070", Offset = "0x167AE70", VA = "0x18167C070")]
		private void MasterCalcOutput(int objectId, out int lastHeldPlayerId, out int currentHoldingPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CircuitNodeUuid("B71B05C0-D6FD-4C49-A70C-085C14E95317")]
	public class RandomNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public enum RandomModes
		{
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			Continuous,
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			Pulse
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private RandomModes randomMode;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static Random random;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int masterLastRandomNumber;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RandomModes RandomMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(RandomModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x1513EA0", Offset = "0x1512CA0", VA = "0x181513EA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1513E20", Offset = "0x1512C20", VA = "0x181513E20")]
		public RandomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x15138D0", Offset = "0x15126D0", VA = "0x1815138D0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1513870", Offset = "0x1512670", VA = "0x181513870", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1513900", Offset = "0x1512700", VA = "0x181513900", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1513A40", Offset = "0x1512840", VA = "0x181513A40", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x15139B0", Offset = "0x15127B0", VA = "0x1815139B0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1513820", Offset = "0x1512620", VA = "0x181513820", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1513730", Offset = "0x1512530", VA = "0x181513730")]
		private int CalcOutput(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1513960", Offset = "0x1512760", VA = "0x181513960", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1513A10", Offset = "0x1512810", VA = "0x181513A10", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1513BC0", Offset = "0x15129C0", VA = "0x181513BC0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class SourceNodeBase : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1518EC0", Offset = "0x1517CC0", VA = "0x181518EC0", Slot = "28")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1518F20", Offset = "0x1517D20", VA = "0x181518F20")]
		public SourceNodeBase(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1518E60", Offset = "0x1517C60", VA = "0x181518E60", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x347A70", Offset = "0x346870", VA = "0x180347A70", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CircuitNodeUuid("6AD5D963-2357-4A09-BDA6-C99A917655B1")]
	public class SelectorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public enum EvalModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			First,
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct SelectorConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public SignalComparisonHelper.ComparerModes CompareMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public int CompareValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private EvalModes _evalMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public SelectorConfig[] SelectorConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private InputMetadata[] inputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int lastSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private int lastSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private bool modifiedSinceLastEval;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public EvalModes EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(EvalModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1515900", Offset = "0x1514700", VA = "0x181515900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1515740", Offset = "0x1514540", VA = "0x181515740")]
		public SelectorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1515280", Offset = "0x1514080", VA = "0x181515280", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1514E80", Offset = "0x1513C80", VA = "0x181514E80", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x511EC0", Offset = "0x510CC0", VA = "0x180511EC0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1514EC0", Offset = "0x1513CC0", VA = "0x181514EC0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1514F10", Offset = "0x1513D10", VA = "0x181514F10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x15150D0", Offset = "0x1513ED0", VA = "0x1815150D0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1515490", Offset = "0x1514290", VA = "0x181515490", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface ISourceNode
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMomentaryOutput(OutputSlot outputSlot, int value);

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetOutputMeta(OutputMetadata[] outputMetadata);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CircuitNodeUuid("B58C2FAB-3F1A-15F4-6D31-4E3BE09A71A9")]
	public class SourceNode : SourceNodeBase, ISourceNode
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1518FD0", Offset = "0x1517DD0", VA = "0x181518FD0")]
		public SourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1518FC0", Offset = "0x1517DC0", VA = "0x181518FC0", Slot = "29")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x15134B0", Offset = "0x15122B0", VA = "0x1815134B0", Slot = "31")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169B82")]
	public class ComparerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private static readonly InputMetadata[] AdvancedInputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private SignalComparisonHelper.ComparerModes comparerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private bool advancedMode;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public SignalComparisonHelper.ComparerModes ComparerMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(SignalComparisonHelper.ComparerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x151D230", Offset = "0x151C030", VA = "0x18151D230")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x318330", Offset = "0x317130", VA = "0x180318330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1677B10", Offset = "0x1676910", VA = "0x181677B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string NodeVisualizationLabel
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1677AA0", Offset = "0x16768A0", VA = "0x181677AA0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1677A20", Offset = "0x1676820", VA = "0x181677A20")]
		public ComparerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1677540", Offset = "0x1676340", VA = "0x181677540", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1677190", Offset = "0x1675F90", VA = "0x181677190")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1677220", Offset = "0x1676020", VA = "0x181677220", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1677330", Offset = "0x1676130", VA = "0x181677330", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x16772C0", Offset = "0x16760C0", VA = "0x1816772C0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1677460", Offset = "0x1676260", VA = "0x181677460", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x16774E0", Offset = "0x16762E0", VA = "0x1816774E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x16776A0", Offset = "0x16764A0", VA = "0x1816776A0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CircuitNodeUuid("17B72DE0-4116-41DB-A99D-1523625F7EF1")]
	public class CombinatorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum CombinatorModes
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Subtract,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Multiply,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Divide,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			Modulo
		}

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static readonly InputMetadata[] TwoInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private static readonly InputMetadata[] ThreeInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly Dictionary<CombinatorModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private CombinatorModes combinatorMode;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public CombinatorModes CombinatorMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(CombinatorModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x151D230", Offset = "0x151C030", VA = "0x18151D230")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string NodeVisualizationLabel
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1677120", Offset = "0x1675F20", VA = "0x181677120", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1676A10", Offset = "0x1675810", VA = "0x181676A10")]
		public static string GetModeSymbol(CombinatorModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x16770A0", Offset = "0x1675EA0", VA = "0x1816770A0")]
		public CombinatorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1676C40", Offset = "0x1675A40", VA = "0x181676C40", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1676840", Offset = "0x1675640", VA = "0x181676840")]
		private int CalcOutput()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1676970", Offset = "0x1675770", VA = "0x181676970", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1676B60", Offset = "0x1675960", VA = "0x181676B60", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1676A90", Offset = "0x1675890", VA = "0x181676A90", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x16685B0", Offset = "0x16673B0", VA = "0x1816685B0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1668620", Offset = "0x1667420", VA = "0x181668620", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1676D20", Offset = "0x1675B20", VA = "0x181676D20", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CircuitNodeUuid("34452A12-AFB3-4A4D-97B0-9D25F7E777C5")]
	public class DelayNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private struct DelaySignal
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public int timeRemaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public int value;
		}

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private static InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private static OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private List<DelaySignal> QueuedSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private int lastInputSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1679680", Offset = "0x1678480", VA = "0x181679680")]
		public DelayNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1678BA0", Offset = "0x16779A0", VA = "0x181678BA0", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1678D10", Offset = "0x1677B10", VA = "0x181678D10", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1678D70", Offset = "0x1677B70", VA = "0x181678D70", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1679290", Offset = "0x1678090", VA = "0x181679290", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1679490", Offset = "0x1678290", VA = "0x181679490", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1678FC0", Offset = "0x1677DC0", VA = "0x181678FC0")]
		private void QueueSignal(int delay, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1678DD0", Offset = "0x1677BD0", VA = "0x181678DD0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1679120", Offset = "0x1677F20", VA = "0x181679120", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1678A90", Offset = "0x1677890", VA = "0x181678A90", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CircuitNodeUuid("C9A59F26-0A72-4C2E-B239-6A83998E0839", InternalOnly = true)]
	public class LoopNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		internal override bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x167AE50", Offset = "0x1679C50", VA = "0x18167AE50", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x167ADD0", Offset = "0x1679BD0", VA = "0x18167ADD0")]
		public LoopNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x167AD30", Offset = "0x1679B30", VA = "0x18167AD30", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x167AD80", Offset = "0x1679B80", VA = "0x18167AD80", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CircuitNodeUuid("E7EFD8CA-92FE-4A37-9E7C-ABBE9E4DE336")]
	public class MomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x167AE60", Offset = "0x1679C60", VA = "0x18167AE60")]
		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x16744B0", Offset = "0x16732B0", VA = "0x1816744B0")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CircuitNodeUuid("6402C773-5838-4495-BC54-BC36EDE4AB0F")]
	public class ConstantSourceNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1677BC0", Offset = "0x16769C0", VA = "0x181677BC0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1677C20", Offset = "0x1676A20", VA = "0x181677C20", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1678290", Offset = "0x1677090", VA = "0x181678290")]
		public ConstantSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1677C80", Offset = "0x1676A80", VA = "0x181677C80", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1677E70", Offset = "0x1676C70", VA = "0x181677E70", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1678000", Offset = "0x1676E00", VA = "0x181678000", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CircuitNodeUuid("738B2AF2-EEBD-4316-82A9-2FBEC9B50D8B", InternalOnly = true)]
	public class NodeGraphNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CircuitNodeUuid("86B6FD1C-4668-4BA9-8ACB-FB91E25DBFB6", InternalOnly = true)]
		public class GraphInputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x167A940", Offset = "0x1679740", VA = "0x18167A940")]
			public GraphInputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1674490", Offset = "0x1673290", VA = "0x181674490")]
			public void SetOutputSignal(OutputSlot slot, int val)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CircuitNodeUuid("F8A998DB-0354-4BCD-B0E4-6BBA7CC24B89", InternalOnly = true)]
		public class GraphOutputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x167AB60", Offset = "0x1679960", VA = "0x18167AB60")]
			public GraphOutputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x167A9C0", Offset = "0x16797C0", VA = "0x18167A9C0", Slot = "24")]
			protected override void _EvaluateNode(bool isMasterClient)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private GraphInputNode virtualSourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private GraphOutputNode virtualDestNode;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public CircuitNodeGraph InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x347A70", Offset = "0x346870", VA = "0x180347A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x347E20", Offset = "0x346C20", VA = "0x180347E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x167B910", Offset = "0x167A710", VA = "0x18167B910")]
		public NodeGraphNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x167B580", Offset = "0x167A380", VA = "0x18167B580", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x167B4A0", Offset = "0x167A2A0", VA = "0x18167B4A0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x167B030", Offset = "0x1679E30", VA = "0x18167B030", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x167AF90", Offset = "0x1679D90", VA = "0x18167AF90", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x167AFE0", Offset = "0x1679DE0", VA = "0x18167AFE0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct NodeMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public bool NeedsSerialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public InputMetadata[] InputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public string NodeDescription;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct InputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string Description;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OutputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public OutputSlot OutputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public string Description;
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate void OutputNodeUpdated(Dictionary<InputSlot, int> slotUpdates);
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public interface IOutputNode
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AddUpdatedEvent(OutputNodeUpdated updateEvent);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveUpdatedEvent(OutputNodeUpdated updateEvent);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInputMeta(InputMetadata[] inputMeta);
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CircuitNodeUuid("C6AB70A0-C752-466A-8070-029742655556")]
	public class OutputNode : CircuitNode, IOutputNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int[] lastSignals;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1518EC0", Offset = "0x1517CC0", VA = "0x181518EC0", Slot = "30")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x167CC50", Offset = "0x167BA50", VA = "0x18167CC50", Slot = "28")]
		public void AddUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x167D100", Offset = "0x167BF00", VA = "0x18167D100", Slot = "29")]
		public void RemoveUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x167D380", Offset = "0x167C180", VA = "0x18167D380")]
		public OutputNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x167CCE0", Offset = "0x167BAE0", VA = "0x18167CCE0", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x167D0D0", Offset = "0x167BED0", VA = "0x18167D0D0")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x347A70", Offset = "0x346870", VA = "0x180347A70", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x167D070", Offset = "0x167BE70", VA = "0x18167D070", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x167D190", Offset = "0x167BF90", VA = "0x18167D190", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x167D1A0", Offset = "0x167BFA0", VA = "0x18167D1A0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x167CDA0", Offset = "0x167BBA0", VA = "0x18167CDA0")]
		private void FireEventIfNeeded()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169BAD")]
	public class StateMachineNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct StateTransition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public InputSlot inputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public byte stateIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public int val1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int val2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public int val3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int minTimeInStateMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public bool removed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public StateTransition[] transitions;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public enum ModifyCommands
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			DefaultState = 1,
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			MaxStateIndex,
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			StateVal1,
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			StateVal2,
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			StateVal3,
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			MinTimeInStateMS,
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			NumTransitions,
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			TransitionInputSlot,
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			TransitionStateTarget,
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			RemovedState
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private State[] states;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private byte maxStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private OutputSlot[] _serializableOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public byte CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x612BA0", Offset = "0x6119A0", VA = "0x180612BA0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x613180", Offset = "0x611F80", VA = "0x180613180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public byte DefaultState
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x612B90", Offset = "0x611990", VA = "0x180612B90")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x613170", Offset = "0x611F70", VA = "0x180613170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x511EC0", Offset = "0x510CC0", VA = "0x180511EC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x473660", Offset = "0x472460", VA = "0x180473660", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override string NodeVisualizationLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x151B270", Offset = "0x151A070", VA = "0x18151B270", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int TimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x49C210", Offset = "0x49B010", VA = "0x18049C210")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x49C7F0", Offset = "0x49B5F0", VA = "0x18049C7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x151B220", Offset = "0x151A020", VA = "0x18151B220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x151B190", Offset = "0x1519F90", VA = "0x18151B190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x15198B0", Offset = "0x15186B0", VA = "0x1815198B0")]
		public State? GetState(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x151AFF0", Offset = "0x1519DF0", VA = "0x18151AFF0")]
		public StateMachineNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x15190C0", Offset = "0x1517EC0", VA = "0x1815190C0", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1519E50", Offset = "0x1518C50", VA = "0x181519E50")]
		private void OnTimerUpdate(int networkTimeMS, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x151A2A0", Offset = "0x15190A0", VA = "0x18151A2A0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x151AFC0", Offset = "0x1519DC0", VA = "0x18151AFC0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1519610", Offset = "0x1518410", VA = "0x181519610")]
		public static OutputSlot GetOnEnterOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1519370", Offset = "0x1518170", VA = "0x181519370")]
		public static OutputSlot GetInStateOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1519620", Offset = "0x1518420", VA = "0x181519620")]
		public static OutputSlot GetOnExitOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1519150", Offset = "0x1517F50", VA = "0x181519150")]
		private void EnterState(byte newStateIndex, bool forceIfCurrent = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1519380", Offset = "0x1518180", VA = "0x181519380", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1519630", Offset = "0x1518430", VA = "0x181519630", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x15195C0", Offset = "0x15183C0", VA = "0x1815195C0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1519FD0", Offset = "0x1518DD0", VA = "0x181519FD0", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1519050", Offset = "0x1517E50", VA = "0x181519050", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x15199B0", Offset = "0x15187B0", VA = "0x1815199B0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x151A050", Offset = "0x1518E50", VA = "0x18151A050", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x15195A0", Offset = "0x15183A0", VA = "0x1815195A0")]
		public static int GetModifyArg(ModifyCommands cmd, byte stateIdx = 0, byte transitionIdx = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x151A280", Offset = "0x1519080", VA = "0x18151A280")]
		private static void UnpackModifyArg(int arg, out ModifyCommands cmd, out byte stateIdx, out byte transitionIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x151A450", Offset = "0x1519250", VA = "0x18151A450", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1519360", Offset = "0x1518160", VA = "0x181519360")]
		public void ForceReconstructNodeMetaData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CircuitNodeUuid("A77191F7-792B-4590-AAB3-A3B71C440DD1")]
	public class TimerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum TimerModes
		{
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			Looping,
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			Countdown
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			Second,
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			TenthOfSecond
		}

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly InputMetadata[] InputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private TimerModes timerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private int timeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private bool timerExpired;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private int _inputTimeTenths;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public TimerModes TimerMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(TimerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x151D230", Offset = "0x151C030", VA = "0x18151D230")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private int inputTimeTenths
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x151D220", Offset = "0x151C020", VA = "0x18151D220")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x151D250", Offset = "0x151C050", VA = "0x18151D250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x151D150", Offset = "0x151BF50", VA = "0x18151D150")]
		public TimerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x151C930", Offset = "0x151B730", VA = "0x18151C930", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x151CE00", Offset = "0x151BC00", VA = "0x18151CE00", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x151CF30", Offset = "0x151BD30", VA = "0x18151CF30", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x151C9C0", Offset = "0x151B7C0", VA = "0x18151C9C0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x151CA60", Offset = "0x151B860", VA = "0x18151CA60", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x151CA20", Offset = "0x151B820", VA = "0x18151CA20", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x151CB20", Offset = "0x151B920", VA = "0x18151CB20")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x151CD70", Offset = "0x151BB70", VA = "0x18151CD70")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x151CC30", Offset = "0x151BA30", VA = "0x18151CC30")]
		private void ResetTimeRemaining()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x151CAC0", Offset = "0x151B8C0", VA = "0x18151CAC0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1513A10", Offset = "0x1512810", VA = "0x181513A10", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x151CE70", Offset = "0x151BC70", VA = "0x18151CE70", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x151CD10", Offset = "0x151BB10", VA = "0x18151CD10", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x151C8E0", Offset = "0x151B6E0", VA = "0x18151C8E0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x151CCC0", Offset = "0x151BAC0", VA = "0x18151CCC0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x151C8A0", Offset = "0x151B6A0", VA = "0x18151C8A0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CircuitNodeUuid("9B664D6A-1B61-4D4E-9AA8-B17B0DC02DA3")]
	public class UnityTransformationNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private Dictionary<InputSlot, int> inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private Dictionary<OutputSlot, int> outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Func<Dictionary<InputSlot, int>, Dictionary<OutputSlot, int>> transformationFunction;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x347A70", Offset = "0x346870", VA = "0x180347A70", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x511ED0", Offset = "0x510CD0", VA = "0x180511ED0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x24B37A0", Offset = "0x24B25A0", VA = "0x1824B37A0")]
		public UnityTransformationNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x24B3430", Offset = "0x24B2230", VA = "0x1824B3430", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x24B3330", Offset = "0x24B2130", VA = "0x1824B3330")]
		private void PassthroughValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CircuitNodeUuid("34200A8F-370E-4240-B034-66252D44BE88")]
	public class WaveNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum WaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			Sine,
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			Cosine,
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			Square,
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			Sawtooth
		}

		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private static readonly InputMetadata[] SecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private static readonly InputMetadata[] ThenthOfSecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private WaveMode currentWaveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TimerNode.TimeUnit currentTimeUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private int runningTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private int _inputPeriod;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private int inputAmplitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private double functionPeriodInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private double millisecondTimeToAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private int loopTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private int relevantDecimalPlaces;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public WaveMode CurrentWaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8E96F0", Offset = "0x8E84F0", VA = "0x1808E96F0")]
			get
			{
				return default(WaveMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x151D230", Offset = "0x151C030", VA = "0x18151D230")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TimerNode.TimeUnit CurrentTimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x133D3A0", Offset = "0x133C1A0", VA = "0x18133D3A0")]
			get
			{
				return default(TimerNode.TimeUnit);
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x24B4B10", Offset = "0x24B3910", VA = "0x1824B4B10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private double InputTimeUnitInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x24B4AE0", Offset = "0x24B38E0", VA = "0x1824B4AE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private int InputPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x24B4AD0", Offset = "0x24B38D0", VA = "0x1824B4AD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x24B4B50", Offset = "0x24B3950", VA = "0x1824B4B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x24B49F0", Offset = "0x24B37F0", VA = "0x1824B49F0")]
		public WaveNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x24B3B80", Offset = "0x24B2980", VA = "0x1824B3B80", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x24B44A0", Offset = "0x24B32A0", VA = "0x1824B44A0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x24B46A0", Offset = "0x24B34A0", VA = "0x1824B46A0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x24B3EF0", Offset = "0x24B2CF0", VA = "0x1824B3EF0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x24B4020", Offset = "0x24B2E20", VA = "0x1824B4020", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x24B3F90", Offset = "0x24B2D90", VA = "0x1824B3F90", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x24B4120", Offset = "0x24B2F20", VA = "0x1824B4120")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x24B4460", Offset = "0x24B3260", VA = "0x1824B4460")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x24B4220", Offset = "0x24B3020", VA = "0x1824B4220")]
		private void ResetRunningTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x24B3C10", Offset = "0x24B2A10", VA = "0x1824B3C10")]
		private int EvaluateWaveFunction()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x24B42F0", Offset = "0x24B30F0", VA = "0x1824B42F0")]
		private void UpdateCachedFunctionParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x24B4080", Offset = "0x24B2E80", VA = "0x1824B4080", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x24B4290", Offset = "0x24B3090", VA = "0x1824B4290", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x24B4550", Offset = "0x24B3350", VA = "0x1824B4550", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x24B4230", Offset = "0x24B3030", VA = "0x1824B4230", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x24B3B30", Offset = "0x24B2930", VA = "0x1824B3B30", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CircuitNodeUuid("A4160690-4C68-40C2-BD51-B665F71FCEBD", InternalOnly = true)]
	public class RootNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal override bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1513EB0", Offset = "0x1512CB0", VA = "0x181513EB0")]
		public RootNode(int nodeId, CircuitNodeGraph graph)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class VirtualNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x339380", Offset = "0x338180", VA = "0x180339380", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x24B3AA0", Offset = "0x24B28A0", VA = "0x1824B3AA0")]
		protected VirtualNode(string nodeName, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x24B3920", Offset = "0x24B2720", VA = "0x1824B3920", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x24B3970", Offset = "0x24B2770", VA = "0x1824B3970", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x24B39D0", Offset = "0x24B27D0", VA = "0x1824B39D0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class Serialization
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1518160", Offset = "0x1516F60", VA = "0x181518160")]
		public static CircuitNode InstantiateNode(Guid nodeType, int nodeId, Guid graphGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1517F90", Offset = "0x1516D90", VA = "0x181517F90")]
		internal static CircuitNode InstantiateNode(CircuitNodeData nodeData, CircuitNodeGraph nodeGraph, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x1517E50", Offset = "0x1516C50", VA = "0x181517E50")]
		public static Guid GetNodeTypeGuid(CircuitNode node)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x15182F0", Offset = "0x15170F0", VA = "0x1815182F0")]
		public static bool TryGetNodeTypeByGuid(Guid guid, out Type t)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate CircuitNode CircuitNodeConstructor(int nodeId, CircuitNodeGraph graph);
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class CircuitSerializedTypeLookup
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x16767A0", Offset = "0x16755A0", VA = "0x1816767A0")]
		public static bool TryGetCircuitTypeFromGuid(Guid guid, out Type nodeType)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class SerializationLookup
	{
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static Guid RECROOM_CIRCUITS_BOOLEANNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static Guid RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static Guid RECROOM_CIRCUITS_CUSTOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static Guid RECROOM_CIRCUITS_GAMESETSTATENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static Guid RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static Guid RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static Guid RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static Guid RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static Guid RECROOM_CIRCUITS_SELECTORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static Guid RECROOM_CIRCUITS_SOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private static Guid RECROOM_CIRCUITS_STATEMACHINENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private static Guid RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private static Guid RECROOM_CIRCUITS_WAVENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000224")]
		internal static Dictionary<Type, Guid> TypeToGuidLookup;

		[Cpp2IlInjected.Token(Token = "0x4000225")]
		internal static Dictionary<Guid, Type> GuidToTypeLookup;

		[Cpp2IlInjected.Token(Token = "0x4000226")]
		internal static Dictionary<Guid, CircuitNodeConstructor> GuidToNodeConstructor;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class SignalComparisonHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum ComparerModes
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			Equals,
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			NotEquals,
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			GreaterThan,
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			GreaterThanEqualTo,
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			LessThan,
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			LessThanEqualTo
		}

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static readonly Dictionary<ComparerModes, string> ModeSymbols;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x15187B0", Offset = "0x15175B0", VA = "0x1815187B0")]
		public static string GetModeSymbol(ComparerModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1518740", Offset = "0x1517540", VA = "0x181518740")]
		internal static bool Compare(ComparerModes comparerMode, int leftSide, int rightSide)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Circuits.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class CircuitLinkDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x1506CB0", Offset = "0x1505AB0", VA = "0x181506CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1506660", Offset = "0x1505460", VA = "0x181506660")]
		static CircuitLinkDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class CircuitLinkData : IMessage<CircuitLinkData>, IMessage, IEquatable<CircuitLinkData>, IDeepCloneable<CircuitLinkData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private static readonly MessageParser<CircuitLinkData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private int sourceNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private int destNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private int inputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private int outputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private int linkType_;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitLinkData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x1507460", Offset = "0x1506260", VA = "0x181507460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x1507390", Offset = "0x1506190", VA = "0x181507390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x15074C0", Offset = "0x15062C0", VA = "0x1815074C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		public int SourceNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x358650", Offset = "0x357450", VA = "0x180358650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x358680", Offset = "0x357480", VA = "0x180358680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		public int DestNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x50B6E0", Offset = "0x50A4E0", VA = "0x18050B6E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x50B6F0", Offset = "0x50A4F0", VA = "0x18050B6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		public int InputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x338D80", Offset = "0x337B80", VA = "0x180338D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x378C10", Offset = "0x377A10", VA = "0x180378C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public int OutputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x338D70", Offset = "0x337B70", VA = "0x180338D70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x5FC440", Offset = "0x5FB240", VA = "0x1805FC440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		public int LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x411620", Offset = "0x410420", VA = "0x180411620")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x576F30", Offset = "0x575D30", VA = "0x180576F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		[DebuggerNonUserCode]
		public CircuitLinkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1507340", Offset = "0x1506140", VA = "0x181507340")]
		[DebuggerNonUserCode]
		public CircuitLinkData(CircuitLinkData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1506E60", Offset = "0x1505C60", VA = "0x181506E60", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitLinkData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1506EE0", Offset = "0x1505CE0", VA = "0x181506EE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1506F80", Offset = "0x1505D80", VA = "0x181506F80", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitLinkData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1506FC0", Offset = "0x1505DC0", VA = "0x181506FC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1507130", Offset = "0x1505F30", VA = "0x181507130", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1507190", Offset = "0x1505F90", VA = "0x181507190", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1506D10", Offset = "0x1505B10", VA = "0x181506D10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1507070", Offset = "0x1505E70", VA = "0x181507070", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class CircuitNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1509F20", Offset = "0x1508D20", VA = "0x181509F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x15075C0", Offset = "0x15063C0", VA = "0x1815075C0")]
		static CircuitNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly MessageParser<CircuitNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private string nodeName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int nodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private int pairedNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private ByteString nodeType_;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private static readonly FieldCodec<CircuitLinkData> _repeated_circuitLinks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private readonly RepeatedField<CircuitLinkData> circuitLinks_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private NodeTransformData transformData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private InternalGraphData internalGraphData_;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly FieldCodec<SlotData> _repeated_slotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private readonly RepeatedField<SlotData> slotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private int mode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private SelectorNodeData selectorNodeData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private bool advancedMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private int timeUnit_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private int roleId_;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly FieldCodec<StateMachineStateData> _repeated_stateMachineData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private readonly RepeatedField<StateMachineStateData> stateMachineData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int defaultIndex_;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly FieldCodec<SlotData> _repeated_defaultInputSlotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private readonly RepeatedField<SlotData> defaultInputSlotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private string roleGuid_;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x150B9F0", Offset = "0x150A7F0", VA = "0x18150B9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x150B920", Offset = "0x150A720", VA = "0x18150B920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x150BA50", Offset = "0x150A850", VA = "0x18150BA50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x362AD0", Offset = "0x3618D0", VA = "0x180362AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x150BB50", Offset = "0x150A950", VA = "0x18150BB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x338D80", Offset = "0x337B80", VA = "0x180338D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x378C10", Offset = "0x377A10", VA = "0x180378C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[DebuggerNonUserCode]
		public int PairedNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x338D70", Offset = "0x337B70", VA = "0x180338D70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x5FC440", Offset = "0x5FB240", VA = "0x1805FC440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x18031B680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x150BBA0", Offset = "0x150A9A0", VA = "0x18150BBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitLinkData> CircuitLinks
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x31B670", Offset = "0x31A470", VA = "0x18031B670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		public NodeTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x31B6A0", Offset = "0x31A4A0", VA = "0x18031B6A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x31B720", Offset = "0x31A520", VA = "0x18031B720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public InternalGraphData InternalGraphData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x323B90", Offset = "0x322990", VA = "0x180323B90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x323BA0", Offset = "0x3229A0", VA = "0x180323BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> SlotData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x31B540", Offset = "0x31A340", VA = "0x18031B540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		public int Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x31D6F0", Offset = "0x31C4F0", VA = "0x18031D6F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x31DC70", Offset = "0x31CA70", VA = "0x18031DC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public SelectorNodeData SelectorNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x352790", Offset = "0x351590", VA = "0x180352790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x3528F0", Offset = "0x3516F0", VA = "0x1803528F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x3527A0", Offset = "0x3515A0", VA = "0x1803527A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x352900", Offset = "0x351700", VA = "0x180352900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public int TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x616230", Offset = "0x615030", VA = "0x180616230")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x606760", Offset = "0x605560", VA = "0x180606760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		public int RoleId
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3DCAB0", Offset = "0x3DB8B0", VA = "0x1803DCAB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x6D7800", Offset = "0x6D6600", VA = "0x1806D7800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineStateData> StateMachineData
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x39FAA0", Offset = "0x39E8A0", VA = "0x18039FAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public int DefaultIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5A6450", Offset = "0x5A5250", VA = "0x1805A6450")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCD8ED0", Offset = "0xCD7CD0", VA = "0x180CD8ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> DefaultInputSlotData
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x325F60", Offset = "0x324D60", VA = "0x180325F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public string RoleGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x335160", Offset = "0x333F60", VA = "0x180335160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x150BBF0", Offset = "0x150A9F0", VA = "0x18150BBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x150B450", Offset = "0x150A250", VA = "0x18150B450")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x150B560", Offset = "0x150A360", VA = "0x18150B560")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x150A3C0", Offset = "0x15091C0", VA = "0x18150A3C0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x150A420", Offset = "0x1509220", VA = "0x18150A420", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x150A480", Offset = "0x1509280", VA = "0x18150A480", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x150A680", Offset = "0x1509480", VA = "0x18150A680", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x150ACF0", Offset = "0x1509AF0", VA = "0x18150ACF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x150AD50", Offset = "0x1509B50", VA = "0x18150AD50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1509F80", Offset = "0x1508D80", VA = "0x181509F80", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x150A8E0", Offset = "0x15096E0", VA = "0x18150A8E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class SelectorNodeData : IMessage<SelectorNodeData>, IMessage, IEquatable<SelectorNodeData>, IDeepCloneable<SelectorNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static readonly MessageParser<SelectorNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int evalMode_;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly FieldCodec<SelectorConfigData> _repeated_selectorConfigData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private readonly RepeatedField<SelectorConfigData> selectorConfigData_;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x1514D10", Offset = "0x1513B10", VA = "0x181514D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x1514C40", Offset = "0x1513A40", VA = "0x181514C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x1514D70", Offset = "0x1513B70", VA = "0x181514D70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public int EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x358650", Offset = "0x357450", VA = "0x180358650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x358680", Offset = "0x357480", VA = "0x180358680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public RepeatedField<SelectorConfigData> SelectorConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1514BE0", Offset = "0x15139E0", VA = "0x181514BE0")]
		[DebuggerNonUserCode]
		public SelectorNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1514B20", Offset = "0x1513920", VA = "0x181514B20")]
		[DebuggerNonUserCode]
		public SelectorNodeData(SelectorNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1514520", Offset = "0x1513320", VA = "0x181514520", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x1514680", Offset = "0x1513480", VA = "0x181514680", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1514600", Offset = "0x1513400", VA = "0x181514600", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1514750", Offset = "0x1513550", VA = "0x181514750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x15148A0", Offset = "0x15136A0", VA = "0x1815148A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x1514900", Offset = "0x1513700", VA = "0x181514900", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x1514450", Offset = "0x1513250", VA = "0x181514450", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x15147C0", Offset = "0x15135C0", VA = "0x1815147C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class InternalGraphData : IMessage<InternalGraphData>, IMessage, IEquatable<InternalGraphData>, IDeepCloneable<InternalGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private static readonly MessageParser<InternalGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private int inputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private int outputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private CircuitNodeGraphData internalNodeGraph_;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public static MessageParser<InternalGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x150EB80", Offset = "0x150D980", VA = "0x18150EB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x150EAB0", Offset = "0x150D8B0", VA = "0x18150EAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x150EBE0", Offset = "0x150D9E0", VA = "0x18150EBE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public int InputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x358650", Offset = "0x357450", VA = "0x180358650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x358680", Offset = "0x357480", VA = "0x180358680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public int OutputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x50B6E0", Offset = "0x50A4E0", VA = "0x18050B6E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x50B6F0", Offset = "0x50A4F0", VA = "0x18050B6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x358690", Offset = "0x357490", VA = "0x180358690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		[DebuggerNonUserCode]
		public InternalGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x150E970", Offset = "0x150D770", VA = "0x18150E970")]
		[DebuggerNonUserCode]
		public InternalGraphData(InternalGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x150E3F0", Offset = "0x150D1F0", VA = "0x18150E3F0", Slot = "9")]
		[DebuggerNonUserCode]
		public InternalGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x150E560", Offset = "0x150D360", VA = "0x18150E560", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x150E600", Offset = "0x150D400", VA = "0x18150E600", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InternalGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x150E640", Offset = "0x150D440", VA = "0x18150E640", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x150E7B0", Offset = "0x150D5B0", VA = "0x18150E7B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x150E810", Offset = "0x150D610", VA = "0x18150E810", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x150E300", Offset = "0x150D100", VA = "0x18150E300", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x150E6D0", Offset = "0x150D4D0", VA = "0x18150E6D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class CircuitNodeGraphData : IMessage<CircuitNodeGraphData>, IMessage, IEquatable<CircuitNodeGraphData>, IDeepCloneable<CircuitNodeGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private static readonly MessageParser<CircuitNodeGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private ByteString nodeGraphGuid_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool isInternalGraph_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private CircuitNodeData rootNodeData_;

		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private static readonly FieldCodec<CircuitNodeData> _repeated_circuitNodes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly RepeatedField<CircuitNodeData> circuitNodes_;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x150D0D0", Offset = "0x150BED0", VA = "0x18150D0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x150D000", Offset = "0x150BE00", VA = "0x18150D000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x150D130", Offset = "0x150BF30", VA = "0x18150D130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public ByteString NodeGraphGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x362AD0", Offset = "0x3618D0", VA = "0x180362AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x150D240", Offset = "0x150C040", VA = "0x18150D240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public bool IsInternalGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x362AC0", Offset = "0x3618C0", VA = "0x180362AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x362AE0", Offset = "0x3618E0", VA = "0x180362AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		public CircuitNodeData RootNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x18031B680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x31B700", Offset = "0x31A500", VA = "0x18031B700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> CircuitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x31B670", Offset = "0x31A470", VA = "0x18031B670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x150CE90", Offset = "0x150BC90", VA = "0x18150CE90")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x150CF20", Offset = "0x150BD20", VA = "0x18150CF20")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData(CircuitNodeGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x150C680", Offset = "0x150B480", VA = "0x18150C680", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x150C780", Offset = "0x150B580", VA = "0x18150C780", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x150C8B0", Offset = "0x150B6B0", VA = "0x18150C8B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x150C9A0", Offset = "0x150B7A0", VA = "0x18150C9A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x150CBB0", Offset = "0x150B9B0", VA = "0x18150CBB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x150CC10", Offset = "0x150BA10", VA = "0x18150CC10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x150C560", Offset = "0x150B360", VA = "0x18150C560", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x150CA50", Offset = "0x150B850", VA = "0x18150CA50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class CircuitNodeGraphCollectionData : IMessage<CircuitNodeGraphCollectionData>, IMessage, IEquatable<CircuitNodeGraphCollectionData>, IDeepCloneable<CircuitNodeGraphCollectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private static readonly MessageParser<CircuitNodeGraphCollectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private static readonly FieldCodec<CircuitNodeGraphData> _repeated_graphs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private readonly RepeatedField<CircuitNodeGraphData> graphs_;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphCollectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x150C3F0", Offset = "0x150B1F0", VA = "0x18150C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x150C320", Offset = "0x150B120", VA = "0x18150C320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x150C450", Offset = "0x150B250", VA = "0x18150C450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeGraphData> Graphs
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x362AD0", Offset = "0x3618D0", VA = "0x180362AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x150C2C0", Offset = "0x150B0C0", VA = "0x18150C2C0")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x150C210", Offset = "0x150B010", VA = "0x18150C210")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData(CircuitNodeGraphCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x150BCD0", Offset = "0x150AAD0", VA = "0x18150BCD0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x150BE30", Offset = "0x150AC30", VA = "0x18150BE30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x150BDB0", Offset = "0x150ABB0", VA = "0x18150BDB0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x11413A0", Offset = "0x11401A0", VA = "0x1811413A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x150BFC0", Offset = "0x150ADC0", VA = "0x18150BFC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x150C020", Offset = "0x150AE20", VA = "0x18150C020", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x150BC50", Offset = "0x150AA50", VA = "0x18150BC50", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x150BF00", Offset = "0x150AD00", VA = "0x18150BF00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class SlotData : IMessage<SlotData>, IMessage, IEquatable<SlotData>, IDeepCloneable<SlotData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private static readonly MessageParser<SlotData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private int slot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private int signal_;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public static MessageParser<SlotData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x1518CF0", Offset = "0x1517AF0", VA = "0x181518CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x1518C20", Offset = "0x1517A20", VA = "0x181518C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x1518D50", Offset = "0x1517B50", VA = "0x181518D50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x358650", Offset = "0x357450", VA = "0x180358650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x358680", Offset = "0x357480", VA = "0x180358680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public int Signal
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x50B6E0", Offset = "0x50A4E0", VA = "0x18050B6E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x50B6F0", Offset = "0x50A4F0", VA = "0x18050B6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		[DebuggerNonUserCode]
		public SlotData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x113AD60", Offset = "0x1139B60", VA = "0x18113AD60")]
		[DebuggerNonUserCode]
		public SlotData(SlotData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1518A00", Offset = "0x1517800", VA = "0x181518A00", Slot = "9")]
		[DebuggerNonUserCode]
		public SlotData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1518A70", Offset = "0x1517870", VA = "0x181518A70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x113AAD0", Offset = "0x11398D0", VA = "0x18113AAD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SlotData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x113AAF0", Offset = "0x11398F0", VA = "0x18113AAF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1518B00", Offset = "0x1517900", VA = "0x181518B00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x113AC30", Offset = "0x1139A30", VA = "0x18113AC30", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1518940", Offset = "0x1517740", VA = "0x181518940", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x113AB70", Offset = "0x1139970", VA = "0x18113AB70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class SelectorConfigData : IMessage<SelectorConfigData>, IMessage, IEquatable<SelectorConfigData>, IDeepCloneable<SelectorConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private static readonly MessageParser<SelectorConfigData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int compareMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private int compareValue_;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorConfigData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x15142E0", Offset = "0x15130E0", VA = "0x1815142E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x1514210", Offset = "0x1513010", VA = "0x181514210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x1514340", Offset = "0x1513140", VA = "0x181514340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[DebuggerNonUserCode]
		public int CompareMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x358650", Offset = "0x357450", VA = "0x180358650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x358680", Offset = "0x357480", VA = "0x180358680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[DebuggerNonUserCode]
		public int CompareValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x50B6E0", Offset = "0x50A4E0", VA = "0x18050B6E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x50B6F0", Offset = "0x50A4F0", VA = "0x18050B6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		[DebuggerNonUserCode]
		public SelectorConfigData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x113AD60", Offset = "0x1139B60", VA = "0x18113AD60")]
		[DebuggerNonUserCode]
		public SelectorConfigData(SelectorConfigData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1513FF0", Offset = "0x1512DF0", VA = "0x181513FF0", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorConfigData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1514060", Offset = "0x1512E60", VA = "0x181514060", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x113AAD0", Offset = "0x11398D0", VA = "0x18113AAD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorConfigData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x113AAF0", Offset = "0x11398F0", VA = "0x18113AAF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x15140F0", Offset = "0x1512EF0", VA = "0x1815140F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x113AC30", Offset = "0x1139A30", VA = "0x18113AC30", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1513F30", Offset = "0x1512D30", VA = "0x181513F30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x113AB70", Offset = "0x1139970", VA = "0x18113AB70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class StateMachineStateData : IMessage<StateMachineStateData>, IMessage, IEquatable<StateMachineStateData>, IDeepCloneable<StateMachineStateData>
	{
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private static readonly MessageParser<StateMachineStateData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private int val1_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int val2_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private int val3_;

		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private static readonly FieldCodec<StateMachineTransitionData> _repeated_stateTransitionData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private readonly RepeatedField<StateMachineTransitionData> stateTransitionData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private int minTimeInState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private int removed_;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineStateData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x151BE60", Offset = "0x151AC60", VA = "0x18151BE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x151BD90", Offset = "0x151AB90", VA = "0x18151BD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x151BEC0", Offset = "0x151ACC0", VA = "0x18151BEC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public int Val1
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x358650", Offset = "0x357450", VA = "0x180358650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x358680", Offset = "0x357480", VA = "0x180358680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public int Val2
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x50B6E0", Offset = "0x50A4E0", VA = "0x18050B6E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x50B6F0", Offset = "0x50A4F0", VA = "0x18050B6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		[DebuggerNonUserCode]
		public int Val3
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x338D80", Offset = "0x337B80", VA = "0x180338D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x378C10", Offset = "0x377A10", VA = "0x180378C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineTransitionData> StateTransitionData
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x18031B680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x31D790", Offset = "0x31C590", VA = "0x18031D790")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x54C960", Offset = "0x54B760", VA = "0x18054C960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		[DebuggerNonUserCode]
		public int Removed
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x487350", Offset = "0x486150", VA = "0x180487350")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x487360", Offset = "0x486160", VA = "0x180487360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x151BC60", Offset = "0x151AA60", VA = "0x18151BC60")]
		[DebuggerNonUserCode]
		public StateMachineStateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x151BCC0", Offset = "0x151AAC0", VA = "0x18151BCC0")]
		[DebuggerNonUserCode]
		public StateMachineStateData(StateMachineStateData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x151B480", Offset = "0x151A280", VA = "0x18151B480", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineStateData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x151B620", Offset = "0x151A420", VA = "0x18151B620", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x151B580", Offset = "0x151A380", VA = "0x18151B580", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineStateData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x151B710", Offset = "0x151A510", VA = "0x18151B710", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x151B930", Offset = "0x151A730", VA = "0x18151B930", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x151B990", Offset = "0x151A790", VA = "0x18151B990", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x151B2E0", Offset = "0x151A0E0", VA = "0x18151B2E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x151B7E0", Offset = "0x151A5E0", VA = "0x18151B7E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class StateMachineTransitionData : IMessage<StateMachineTransitionData>, IMessage, IEquatable<StateMachineTransitionData>, IDeepCloneable<StateMachineTransitionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private static readonly MessageParser<StateMachineTransitionData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private int inputIndex_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int stateIndex_;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineTransitionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x151C380", Offset = "0x151B180", VA = "0x18151C380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x151C2B0", Offset = "0x151B0B0", VA = "0x18151C2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x151C3E0", Offset = "0x151B1E0", VA = "0x18151C3E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public int InputIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x358650", Offset = "0x357450", VA = "0x180358650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x358680", Offset = "0x357480", VA = "0x180358680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public int StateIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x50B6E0", Offset = "0x50A4E0", VA = "0x18050B6E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x50B6F0", Offset = "0x50A4F0", VA = "0x18050B6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x113AD60", Offset = "0x1139B60", VA = "0x18113AD60")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData(StateMachineTransitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x151C090", Offset = "0x151AE90", VA = "0x18151C090", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x151C100", Offset = "0x151AF00", VA = "0x18151C100", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x113AAD0", Offset = "0x11398D0", VA = "0x18113AAD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineTransitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x113AAF0", Offset = "0x11398F0", VA = "0x18113AAF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x151C190", Offset = "0x151AF90", VA = "0x18151C190", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x113AC30", Offset = "0x1139A30", VA = "0x18113AC30", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x151BFD0", Offset = "0x151ADD0", VA = "0x18151BFD0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x113AB70", Offset = "0x1139970", VA = "0x18113AB70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class NodeTransformDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x150F300", Offset = "0x150E100", VA = "0x18150F300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x150ECF0", Offset = "0x150DAF0", VA = "0x18150ECF0")]
		static NodeTransformDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeTransformData : IMessage<NodeTransformData>, IMessage, IEquatable<NodeTransformData>, IDeepCloneable<NodeTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private static readonly MessageParser<NodeTransformData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private Vector3Data position_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private Vector3Data rotation_;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[DebuggerNonUserCode]
		public static MessageParser<NodeTransformData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x150FA20", Offset = "0x150E820", VA = "0x18150FA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x150F950", Offset = "0x150E750", VA = "0x18150F950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x150FA80", Offset = "0x150E880", VA = "0x18150FA80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[DebuggerNonUserCode]
		public Vector3Data Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x362AD0", Offset = "0x3618D0", VA = "0x180362AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x362AF0", Offset = "0x3618F0", VA = "0x180362AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		[DebuggerNonUserCode]
		public Vector3Data Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x358690", Offset = "0x357490", VA = "0x180358690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		[DebuggerNonUserCode]
		public NodeTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x150F8E0", Offset = "0x150E6E0", VA = "0x18150F8E0")]
		[DebuggerNonUserCode]
		public NodeTransformData(NodeTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x150F420", Offset = "0x150E220", VA = "0x18150F420", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x150F4C0", Offset = "0x150E2C0", VA = "0x18150F4C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x150F570", Offset = "0x150E370", VA = "0x18150F570", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x150F5D0", Offset = "0x150E3D0", VA = "0x18150F5D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x150F740", Offset = "0x150E540", VA = "0x18150F740", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x150F7A0", Offset = "0x150E5A0", VA = "0x18150F7A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x150F360", Offset = "0x150E160", VA = "0x18150F360", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x150F640", Offset = "0x150E440", VA = "0x18150F640", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class Vector3DataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x151F340", Offset = "0x151E140", VA = "0x18151F340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x151EFA0", Offset = "0x151DDA0", VA = "0x18151EFA0")]
		static Vector3DataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly MessageParser<Vector3Data> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private float x_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private float y_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x151F690", Offset = "0x151E490", VA = "0x18151F690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x151F5C0", Offset = "0x151E3C0", VA = "0x18151F5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x151F6F0", Offset = "0x151E4F0", VA = "0x18151F6F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x566380", Offset = "0x565180", VA = "0x180566380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6CD390", Offset = "0x6CC190", VA = "0x1806CD390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x5286F0", Offset = "0x5274F0", VA = "0x1805286F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x528710", Offset = "0x527510", VA = "0x180528710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x323560", Offset = "0x322360", VA = "0x180323560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x528700", Offset = "0x527500", VA = "0x180528700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x1803160E0")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5760", Offset = "0x7B4560", VA = "0x1807B5760")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x151F3A0", Offset = "0x151E1A0", VA = "0x18151F3A0", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x151F410", Offset = "0x151E210", VA = "0x18151F410", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B53E0", Offset = "0x7B41E0", VA = "0x1807B53E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5420", Offset = "0x7B4220", VA = "0x1807B5420", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x151F4A0", Offset = "0x151E2A0", VA = "0x18151F4A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B55E0", Offset = "0x7B43E0", VA = "0x1807B55E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B52A0", Offset = "0x7B40A0", VA = "0x1807B52A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5500", Offset = "0x7B4300", VA = "0x1807B5500", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
namespace RecRoom.Circuits.PlayerStats
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum CircuitPlayerStat
	{
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		Player_Health = 0,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		Player_Shield = 1,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		PlayerStat_1 = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		PlayerStat_2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		PlayerStat_3 = 1002,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		PlayerStat_4 = 1003,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		PlayerStat_5 = 1004,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		PlayerStat_6 = 1005
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public static class FriendlyCircuitPlayerStats
	{
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private static Dictionary<string, int> friendlyCircuitPlayerStatsDict;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public static Dictionary<string, int> FriendlyCircuitPlayerStatsDict
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x150D290", Offset = "0x150C090", VA = "0x18150D290")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CircuitNodeUuid("FC94A1CD-DD7E-4229-92DF-95991A9E6369")]
	public class PlayerGetStatNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public delegate int GetPlayerStatFunction(CircuitPlayerStat stat, int playerId);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private int masterLastPlayerStatSignal;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x10AB3D0", Offset = "0x10AA1D0", VA = "0x1810AB3D0")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x1510330", Offset = "0x150F130", VA = "0x181510330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event GetPlayerStatFunction GetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x15101F0", Offset = "0x150EFF0", VA = "0x1815101F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x1510290", Offset = "0x150F090", VA = "0x181510290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1510170", Offset = "0x150EF70", VA = "0x181510170")]
		public PlayerGetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x150FF70", Offset = "0x150ED70", VA = "0x18150FF70", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x150FD90", Offset = "0x150EB90", VA = "0x18150FD90")]
		private int GetStatSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x150FEC0", Offset = "0x150ECC0", VA = "0x18150FEC0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x150FB80", Offset = "0x150E980", VA = "0x18150FB80", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x150FBF0", Offset = "0x150E9F0", VA = "0x18150FBF0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x150FD30", Offset = "0x150EB30", VA = "0x18150FD30", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x150FC50", Offset = "0x150EA50", VA = "0x18150FC50", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x150FE60", Offset = "0x150EC60", VA = "0x18150FE60", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x150FF40", Offset = "0x150ED40", VA = "0x18150FF40", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x150FFC0", Offset = "0x150EDC0", VA = "0x18150FFC0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CircuitNodeUuid("5A15E563-2F73-41B6-9CDF-6C9FB065A034")]
	public class PlayerSetStatNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public delegate void SetPlayerStatFunction(CircuitPlayerStat stat, int playerId, int signal);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x10AB3D0", Offset = "0x10AA1D0", VA = "0x1810AB3D0")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x1510330", Offset = "0x150F130", VA = "0x181510330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event SetPlayerStatFunction SetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x1510E00", Offset = "0x150FC00", VA = "0x181510E00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x1510EA0", Offset = "0x150FCA0", VA = "0x181510EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1510DA0", Offset = "0x150FBA0", VA = "0x181510DA0")]
		public PlayerSetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1510A60", Offset = "0x150F860", VA = "0x181510A60", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1510A40", Offset = "0x150F840", VA = "0x181510A40")]
		private void PostEvalSetPlayerStat(CircuitPlayerStat stat, int playerId, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x15108C0", Offset = "0x150F6C0", VA = "0x1815108C0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1510A00", Offset = "0x150F800", VA = "0x181510A00", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1510920", Offset = "0x150F720", VA = "0x181510920", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x150FE60", Offset = "0x150EC60", VA = "0x18150FE60", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x150FF40", Offset = "0x150ED40", VA = "0x18150FF40", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1510BE0", Offset = "0x150F9E0", VA = "0x181510BE0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
}
namespace RecRoom.Circuits.GameStats
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CircuitNodeUuid("2F4A96DA-842F-4F41-84BB-1F283DADB769")]
	public class GameGetScoreNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate int GetTeamScoreFunction(int teamId);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private int masterLastScoreSignal;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event GetTeamScoreFunction GetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x1679CE0", Offset = "0x1678AE0", VA = "0x181679CE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x1679D80", Offset = "0x1678B80", VA = "0x181679D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1679C60", Offset = "0x1678A60", VA = "0x181679C60")]
		public GameGetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1679B30", Offset = "0x1678930", VA = "0x181679B30", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1679A00", Offset = "0x1678800", VA = "0x181679A00")]
		private int GetScoreSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x1679AC0", Offset = "0x16788C0", VA = "0x181679AC0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x16798D0", Offset = "0x16786D0", VA = "0x1816798D0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1679940", Offset = "0x1678740", VA = "0x181679940", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x16799A0", Offset = "0x16787A0", VA = "0x1816799A0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CircuitNodeUuid("B79A6285-498A-4748-B960-FA33F4C5CB02")]
	public class GameSetScoreNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		public delegate void SetTeamScoreFunction(int teamId, int signal, bool isWinner);

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event SetTeamScoreFunction SetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x167A1E0", Offset = "0x1678FE0", VA = "0x18167A1E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x167A280", Offset = "0x1679080", VA = "0x18167A280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x167A180", Offset = "0x1678F80", VA = "0x18167A180")]
		public GameSetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1679EE0", Offset = "0x1678CE0", VA = "0x181679EE0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1679EC0", Offset = "0x1678CC0", VA = "0x181679EC0")]
		private void PostEvalSetGameScoreStat(int teamId, int score, bool isWinner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1679E20", Offset = "0x1678C20", VA = "0x181679E20", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1679E80", Offset = "0x1678C80", VA = "0x181679E80", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
}
namespace RecRoom.Circuits.Traversal
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Flags]
	public enum DFSType
	{
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		DirectedForward = 1,
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		DirectedBackward = 2,
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		Undirected = 3
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Flags]
	public enum LinkTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		NormalToNormal = 1,
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		NormalToVirtual = 2,
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		VirtualToNormal = 4,
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		RootToVirtual = 8,
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		RootToNormal = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal struct TopologicStackEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CircuitNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public bool IsParent;
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public static class GraphTraversal
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class <DFS>d__4 : IEnumerable<CircuitNode>, IEnumerable, IEnumerator<CircuitNode>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private CircuitNode <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			private CircuitNode root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public CircuitNode <>3__root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			private DFSType dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public DFSType <>3__dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			private LinkTypes linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public LinkTypes <>3__linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			private Stack<CircuitNode> <stack>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			private HashSet<CircuitNode> <visited>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			private CircuitNode <current>5__4;

			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			CircuitNode IEnumerator<CircuitNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000410")]
				[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000412")]
				[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A2F0", VA = "0x18031B4F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xA78C90", Offset = "0xA77A90", VA = "0x180A78C90")]
			[DebuggerHidden]
			public <DFS>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x31B730", Offset = "0x31A530", VA = "0x18031B730", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x24B2C00", Offset = "0x24B1A00", VA = "0x1824B2C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x24B3220", Offset = "0x24B2020", VA = "0x1824B3220", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x24B3170", Offset = "0x24B1F70", VA = "0x1824B3170", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<CircuitNode> IEnumerable<CircuitNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x24B3170", Offset = "0x24B1F70", VA = "0x1824B3170", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x150D8E0", Offset = "0x150C6E0", VA = "0x18150D8E0")]
		public static HashSet<CircuitNode> DFSCopy(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x150D9A0", Offset = "0x150C7A0", VA = "0x18150D9A0")]
		[IteratorStateMachine(typeof(<DFS>d__4))]
		public static IEnumerable<CircuitNode> DFS(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x150DD50", Offset = "0x150CB50", VA = "0x18150DD50")]
		public static List<CircuitNode> TopologicSort(CircuitNode root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x150DD30", Offset = "0x150CB30", VA = "0x18150DD30")]
		private static bool ShouldFollowLink(CircuitLink link, LinkTypes linkTypesToFollow)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x150DA30", Offset = "0x150C830", VA = "0x18150DA30")]
		public static LinkTypes FindLinkType(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(LinkTypes);
		}
	}
}
namespace RecRoom.Circuits.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public static class ByteStringExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x24B2090", Offset = "0x24B0E90", VA = "0x1824B2090")]
		public static Guid ToGuid(this ByteString bytes)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x24B2030", Offset = "0x24B0E30", VA = "0x1824B2030")]
		public static ByteString ToByteString(this Guid guid)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum CircuitLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		Error
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public static class CircuitDebug
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public delegate void LogEvent(CircuitLogLevel level, string message);

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public delegate void LogExceptionEvent(Exception e, string message);

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event LogEvent OnLogEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x24B2540", Offset = "0x24B1340", VA = "0x1824B2540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x24B2730", Offset = "0x24B1530", VA = "0x1824B2730")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public static event LogExceptionEvent OnLogExceptionEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x24B2630", Offset = "0x24B1430", VA = "0x1824B2630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x24B2820", Offset = "0x24B1620", VA = "0x1824B2820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x24B2210", Offset = "0x24B1010", VA = "0x1824B2210")]
		public static void LogException(Exception e, [Optional] string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x24B22E0", Offset = "0x24B10E0", VA = "0x1824B22E0")]
		public static void Log(CircuitLogLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x24B24A0", Offset = "0x24B12A0", VA = "0x1824B24A0")]
		public static void NodeLog(int nodeId, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x24B23B0", Offset = "0x24B11B0", VA = "0x1824B23B0")]
		public static void NodeLogFormat(int nodeId, CircuitLogLevel CircuitLogLevel, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x24B2170", Offset = "0x24B0F70", VA = "0x1824B2170")]
		public static void GraphLog(Guid graphGuid, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal static class NodeEventUtil
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x24B2A70", Offset = "0x24B1870", VA = "0x1824B2A70")]
		internal static void SafeInvoke(this CircuitNode.NodeLifecycleEvent nodeLifecycleEvent, CircuitNode nodeArg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x24B29B0", Offset = "0x24B17B0", VA = "0x1824B29B0")]
		internal static void SafeInvoke(this CircuitNode.NodeConnectionChanged nodeConnectionEvent, CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal static class RuntimeAssert
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x24B2B90", Offset = "0x24B1990", VA = "0x1824B2B90")]
		public static void Assert(bool condition, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x24B2B00", Offset = "0x24B1900", VA = "0x1824B2B00")]
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
