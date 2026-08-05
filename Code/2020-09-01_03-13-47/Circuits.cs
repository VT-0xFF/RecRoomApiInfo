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
			[Cpp2IlInjected.Address(RVA = "0x1E62930", Offset = "0x1E61930", VA = "0x181E62930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E62880", Offset = "0x1E61880", VA = "0x181E62880")]
		public CircuitLink(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1E625D0", Offset = "0x1E615D0", VA = "0x181E625D0")]
		public CircuitLinkData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E623E0", Offset = "0x1E613E0", VA = "0x181E623E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E62520", Offset = "0x1E61520", VA = "0x181E62520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E62660", Offset = "0x1E61660", VA = "0x181E62660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class CircuitNodeUuidAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Guid Id;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool InternalOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x39FA60", Offset = "0x39EA60", VA = "0x18039FA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E678D0", Offset = "0x1E668D0", VA = "0x181E678D0")]
		public CircuitNodeUuidAttribute(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E67860", Offset = "0x1E66860", VA = "0x181E67860")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E723D0", Offset = "0x1E713D0", VA = "0x181E723D0", Slot = "4")]
		public bool Equals(InputSlot x, InputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E723F0", Offset = "0x1E713F0", VA = "0x181E723F0", Slot = "5")]
		public int GetHashCode(InputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		public InputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class OutputSlotComparer : IEqualityComparer<OutputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1E723D0", Offset = "0x1E713D0", VA = "0x181E723D0", Slot = "4")]
		public bool Equals(OutputSlot x, OutputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E723F0", Offset = "0x1E713F0", VA = "0x181E723F0", Slot = "5")]
		public int GetHashCode(OutputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
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
			[Cpp2IlInjected.Address(RVA = "0x39B3C0", Offset = "0x39A3C0", VA = "0x18039B3C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal virtual bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x39B3C0", Offset = "0x39A3C0", VA = "0x18039B3C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal virtual bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x39B3C0", Offset = "0x39A3C0", VA = "0x18039B3C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal virtual bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x39B3C0", Offset = "0x39A3C0", VA = "0x18039B3C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal virtual bool RequiresConnectionToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D770", Offset = "0x1E6C770", VA = "0x181E6D770", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal virtual bool IsConnectedToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D650", Offset = "0x1E6C650", VA = "0x181E6D650", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		internal virtual bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x39B3C0", Offset = "0x39A3C0", VA = "0x18039B3C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CircuitNode PairedNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x40F850", Offset = "0x40E850", VA = "0x18040F850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HasConnectedInputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D4F0", Offset = "0x1E6C4F0", VA = "0x181E6D4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal bool UsesAnyDefaultInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D920", Offset = "0x1E6C920", VA = "0x181E6D920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HasConnectedOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D600", Offset = "0x1E6C600", VA = "0x181E6D600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x455D30", Offset = "0x454D30", VA = "0x180455D30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4562B0", Offset = "0x4552B0", VA = "0x1804562B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3A09C0", Offset = "0x39F9C0", VA = "0x1803A09C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x43C500", Offset = "0x43B500", VA = "0x18043C500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public virtual int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x637BC0", Offset = "0x636BC0", VA = "0x180637BC0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D8C0", Offset = "0x1E6C8C0", VA = "0x181E6D8C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NodeMetadata NodeMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D750", Offset = "0x1E6C750", VA = "0x181E6D750")]
			[CompilerGenerated]
			get
			{
				return default(NodeMetadata);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1E6DB90", Offset = "0x1E6CB90", VA = "0x181E6DB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public CircuitNodeGraph NodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3C5470", Offset = "0x3C4470", VA = "0x1803C5470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6AC260", Offset = "0x6AB260", VA = "0x1806AC260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAB6010", Offset = "0xAB5010", VA = "0x180AB6010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static int NodeCount
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D6E0", Offset = "0x1E6C6E0", VA = "0x181E6D6E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static InputMetadata[] AllSlotsInputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D170", Offset = "0x1E6C170", VA = "0x181E6D170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static OutputMetadata[] AllSlotsOutputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D330", Offset = "0x1E6C330", VA = "0x181E6D330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NodeModifiedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D0D0", Offset = "0x1E6C0D0", VA = "0x181E6D0D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1E6DAF0", Offset = "0x1E6CAF0", VA = "0x181E6DAF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NodeDeserializedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D030", Offset = "0x1E6C030", VA = "0x181E6D030")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1E6DA50", Offset = "0x1E6CA50", VA = "0x181E6DA50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E6ADA0", Offset = "0x1E69DA0", VA = "0x181E6ADA0")]
		public static int NewNodeId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C8C0", Offset = "0x1E6B8C0", VA = "0x181E6C8C0")]
		internal static int SetPossibleMaxId(int newPossibleMax)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B520", Offset = "0x1E6A520", VA = "0x181E6B520")]
		public static void ResetMaxNodeId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A800", Offset = "0x1E69800", VA = "0x181E6A800")]
		public static long GetMaxNodeId()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1E6AEF0", Offset = "0x1E69EF0", VA = "0x181E6AEF0")]
		internal static void OverrideMaxNodeId(long overrideValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B660", Offset = "0x1E6A660", VA = "0x181E6B660")]
		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B6D0", Offset = "0x1E6A6D0", VA = "0x181E6B6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A09C0", Offset = "0x39F9C0", VA = "0x1803A09C0", Slot = "15")]
		protected virtual string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CDA0", Offset = "0x1E6BDA0", VA = "0x181E6CDA0")]
		public CircuitNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B020", Offset = "0x1E6A020", VA = "0x181E6B020")]
		protected void ReconstructNodeMetadata()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1E6BB90", Offset = "0x1E6AB90", VA = "0x181E6BB90", Slot = "16")]
		public virtual CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A9E0", Offset = "0x1E699E0", VA = "0x181E6A9E0", Slot = "17")]
		internal virtual void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E68D20", Offset = "0x1E67D20", VA = "0x181E68D20")]
		public void CopySettings(CircuitNodeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1E68DB0", Offset = "0x1E67DB0", VA = "0x181E68DB0")]
		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1E6BB80", Offset = "0x1E6AB80", VA = "0x181E6BB80", Slot = "18")]
		internal virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E69760", Offset = "0x1E68760", VA = "0x181E69760", Slot = "19")]
		internal virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x39B3A0", Offset = "0x39A3A0", VA = "0x18039B3A0", Slot = "20")]
		internal virtual void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x39B3A0", Offset = "0x39A3A0", VA = "0x18039B3A0", Slot = "21")]
		internal virtual void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B9A0", Offset = "0x1E6A9A0", VA = "0x181E6B9A0")]
		private void SerializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1E69530", Offset = "0x1E68530", VA = "0x181E69530")]
		private void DeserializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C590", Offset = "0x1E6B590", VA = "0x181E6C590")]
		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E68560", Offset = "0x1E67560", VA = "0x181E68560")]
		internal static bool ConnectNodes(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B740", Offset = "0x1E6A740", VA = "0x181E6B740")]
		private static void SendNodesConnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B870", Offset = "0x1E6A870", VA = "0x181E6B870")]
		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E67920", Offset = "0x1E66920", VA = "0x181E67920")]
		private static void AddLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A610", Offset = "0x1E69610", VA = "0x181E6A610")]
		internal static bool FormsLoop(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1E68BB0", Offset = "0x1E67BB0", VA = "0x181E68BB0")]
		public bool ConnectToMyInput(CircuitNode sourceNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1E67A10", Offset = "0x1E66A10", VA = "0x181E67A10")]
		protected bool CanConnectInput(CircuitNode newSourceNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1E68C70", Offset = "0x1E67C70", VA = "0x181E68C70")]
		public bool ConnectToMyOutput(CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1E67AE0", Offset = "0x1E66AE0", VA = "0x181E67AE0")]
		protected bool CanConnectOutput(InputSlot inputSlot, OutputSlot outputSlot, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CB10", Offset = "0x1E6BB10", VA = "0x181E6CB10")]
		protected bool SlotsCanConnect(InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1E69B50", Offset = "0x1E68B50", VA = "0x181E69B50")]
		public void DisconnectInput(InputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1E69770", Offset = "0x1E68770", VA = "0x181E69770", Slot = "22")]
		public virtual void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A320", Offset = "0x1E69320", VA = "0x181E6A320")]
		public void DisconnectOutput(OutputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1E69BF0", Offset = "0x1E68BF0", VA = "0x181E69BF0")]
		protected static void DisconnectNodeLink(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B170", Offset = "0x1E6A170", VA = "0x181E6B170")]
		private static void RemoveLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B3B0", Offset = "0x1E6A3B0", VA = "0x181E6B3B0")]
		private static bool RemoveOutputLink(CircuitNode node, CircuitLink link)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B0B0", Offset = "0x1E6A0B0", VA = "0x181E6B0B0")]
		private static bool RemoveInputSlot(CircuitNode node, InputSlot inputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1E67EC0", Offset = "0x1E66EC0", VA = "0x181E67EC0")]
		private static bool CheckForDisconnectedGraph(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A4C0", Offset = "0x1E694C0", VA = "0x181E6A4C0")]
		internal void EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x39B3A0", Offset = "0x39A3A0", VA = "0x18039B3A0", Slot = "23")]
		internal virtual void PostEvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A980", Offset = "0x1E69980", VA = "0x181E6A980")]
		public bool HasMomentaryOutputs()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1E683C0", Offset = "0x1E673C0", VA = "0x181E683C0")]
		public void ClearMomentaryOutputs(int currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x39B3A0", Offset = "0x39A3A0", VA = "0x18039B3A0", Slot = "24")]
		protected virtual void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CC80", Offset = "0x1E6BC80", VA = "0x181E6CC80", Slot = "25")]
		protected virtual void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1E684B0", Offset = "0x1E674B0", VA = "0x181E684B0")]
		protected void ClearOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A6F0", Offset = "0x1E696F0", VA = "0x181E6A6F0")]
		public int GetInputSignal(InputSlot inputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A7C0", Offset = "0x1E697C0", VA = "0x181E6A7C0")]
		public int GetLastOutputSignalTimeStamp(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A940", Offset = "0x1E69940", VA = "0x181E6A940")]
		public int GetOutputSignal(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C550", Offset = "0x1E6B550", VA = "0x181E6C550")]
		protected void SetContinuousOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C570", Offset = "0x1E6B570", VA = "0x181E6C570")]
		protected void SetMomentaryOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C730", Offset = "0x1E6B730", VA = "0x181E6C730")]
		private void SetOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CA50", Offset = "0x1E6BA50", VA = "0x181E6CA50")]
		private bool SlotDirtiesGraph(OutputSlot outputSlot, int val, bool isMomentary)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E67D00", Offset = "0x1E66D00", VA = "0x181E67D00")]
		private void ChangeDefaultInputValue(SlotData slotData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E6AD50", Offset = "0x1E69D50", VA = "0x181E6AD50")]
		public void ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B640", Offset = "0x1E6A640", VA = "0x181E6B640")]
		public void SendDeserializedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CB30", Offset = "0x1E6BB30", VA = "0x181E6CB30", Slot = "26")]
		protected virtual void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E681E0", Offset = "0x1E671E0", VA = "0x181E681E0")]
		internal static void ClearAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E6A580", Offset = "0x1E69580", VA = "0x181E6A580")]
		public static CircuitNode Find(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1A835C0", Offset = "0x1A825C0", VA = "0x181A835C0")]
		public static int BoolToSignal(bool value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE62B0", Offset = "0x1CE52B0", VA = "0x181CE62B0")]
		public static bool SignalToBool(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E68160", Offset = "0x1E67160", VA = "0x181E68160")]
		public static int ClampSignal(int value, int min, int max)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class DictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x13E3890", Offset = "0x13E2890", VA = "0x1813E3890")]
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
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x39A550", Offset = "0x399550", VA = "0x18039A550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x3C0890", Offset = "0x3BF890", VA = "0x1803C0890")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x40F850", Offset = "0x40E850", VA = "0x18040F850")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
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
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x39A550", Offset = "0x399550", VA = "0x18039A550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x3C0890", Offset = "0x3BF890", VA = "0x1803C0890")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x40F850", Offset = "0x40E850", VA = "0x18040F850")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
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
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3A09C0", Offset = "0x39F9C0", VA = "0x1803A09C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x43C500", Offset = "0x43B500", VA = "0x18043C500")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NodeGraphDirty
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3EFB20", Offset = "0x3EEB20", VA = "0x1803EFB20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3EF940", Offset = "0x3EE940", VA = "0x1803EF940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x476FE0", Offset = "0x475FE0", VA = "0x180476FE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4758D0", Offset = "0x4748D0", VA = "0x1804758D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		internal static event UpdateGraph TimeUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1E67660", Offset = "0x1E66660", VA = "0x181E67660")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1E67760", Offset = "0x1E66760", VA = "0x181E67760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E675D0", Offset = "0x1E665D0", VA = "0x181E675D0")]
		internal CircuitNodeGraph(bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E675A0", Offset = "0x1E665A0", VA = "0x181E675A0")]
		public CircuitNodeGraph(Guid guid, bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E67400", Offset = "0x1E66400", VA = "0x181E67400")]
		private CircuitNodeGraph(Guid guid, bool isInternalGraph, bool createRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1E67170", Offset = "0x1E66170", VA = "0x181E67170")]
		public static void Update(int networkTimeMilliseconds, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E65470", Offset = "0x1E64470", VA = "0x181E65470")]
		private void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1E65310", Offset = "0x1E64310", VA = "0x181E65310")]
		public void DestroySelfAndNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E62EF0", Offset = "0x1E61EF0", VA = "0x181E62EF0")]
		internal void AddNode(CircuitNode circuitNode, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E66510", Offset = "0x1E65510", VA = "0x181E66510")]
		internal bool RemoveNode(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E63150", Offset = "0x1E62150", VA = "0x181E63150")]
		internal bool ConnectToRootForSingleEvaluate(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E65500", Offset = "0x1E64500", VA = "0x181E65500")]
		public List<CircuitNode> Evaluate(bool isMasterClient)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1E63110", Offset = "0x1E62110", VA = "0x181E63110", Slot = "4")]
		public int CompareTo(CircuitNodeGraph other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E66E30", Offset = "0x1E65E30", VA = "0x181E66E30")]
		public static byte[] SerializeRuntimeState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E64950", Offset = "0x1E63950", VA = "0x181E64950")]
		public static void DeserializeRuntimeState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E66AF0", Offset = "0x1E65AF0", VA = "0x181E66AF0")]
		public static byte[] SerializePostEvaluateState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E64610", Offset = "0x1E63610", VA = "0x181E64610")]
		public static void DeserializePostEvaluateState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E660B0", Offset = "0x1E650B0", VA = "0x181E660B0")]
		public static CircuitNodeGraphCollectionData PersistAll([Optional] IList<int> inactiveIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E65270", Offset = "0x1E64270", VA = "0x181E65270")]
		public static void DestroyAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1E64240", Offset = "0x1E63240", VA = "0x181E64240")]
		public static void DeserializeAll(CircuitNodeGraphCollectionData data, out Dictionary<int, int> nodeIdMappings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E66280", Offset = "0x1E65280", VA = "0x181E66280")]
		public CircuitNodeGraphData Persist()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1E64C90", Offset = "0x1E63C90", VA = "0x181E64C90")]
		public static CircuitNodeGraph Deserialize(CircuitNodeGraphData data, bool reassignNodeIds, out Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1E631E0", Offset = "0x1E621E0", VA = "0x181E631E0")]
		public static CircuitNodeGraphCopy CopyNodesToNewGraphs(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E66600", Offset = "0x1E65600", VA = "0x181E66600")]
		public static SerializedCircuitNodeGraphCopy SerializeNodesAsNewGraph(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E65B80", Offset = "0x1E64B80", VA = "0x181E65B80")]
		public static CircuitNodeGraph MergeGraphs(CircuitNode nodeA, CircuitNode nodeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E65DB0", Offset = "0x1E64DB0", VA = "0x181E65DB0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x10D9B90", Offset = "0x10D8B90", VA = "0x1810D9B90")]
		public static OutputSlot InputSlotToOutputSlot(InputSlot input)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x10D9B90", Offset = "0x10D8B90", VA = "0x1810D9B90")]
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
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(BooleanModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA10", Offset = "0x19BAA10", VA = "0x1819BBA10")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E61CA0", Offset = "0x1E60CA0", VA = "0x181E61CA0")]
		public static string GetModeSymbol(BooleanModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1E622B0", Offset = "0x1E612B0", VA = "0x181E622B0")]
		public BooleanNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E61E80", Offset = "0x1E60E80", VA = "0x181E61E80", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E618D0", Offset = "0x1E608D0", VA = "0x181E618D0")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E616F0", Offset = "0x1E606F0", VA = "0x181E616F0")]
		private bool CalcAndOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E617E0", Offset = "0x1E607E0", VA = "0x181E617E0")]
		private bool CalcOrOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E61AF0", Offset = "0x1E60AF0", VA = "0x181E61AF0")]
		private void FetchInputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E61C10", Offset = "0x1E60C10", VA = "0x181E61C10", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E61DE0", Offset = "0x1E60DE0", VA = "0x181E61DE0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E61D20", Offset = "0x1E60D20", VA = "0x181E61D20", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x19BB2E0", Offset = "0x19BA2E0", VA = "0x1819BB2E0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x19B21E0", Offset = "0x19B11E0", VA = "0x1819B21E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1E61F50", Offset = "0x1E60F50", VA = "0x181E61F50", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CircuitNodeUuid("B7BA1A4B-EA04-496F-B8B6-A2FB7C4A42B9")]
	public class ContinuousSourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F560", Offset = "0x1E6E560", VA = "0x181E6F560")]
		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C550", Offset = "0x1E6B550", VA = "0x181E6C550")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CircuitNodeUuid("B58C2FAB-4F1A-15F5-6D32-4E3BE18B62B8")]
	public class CustomNode : CircuitNode, ISourceNode, IOutputNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private int[] lastSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FB10", Offset = "0x1E6EB10", VA = "0x181E6FB10")]
		public CustomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F670", Offset = "0x1E6E670", VA = "0x181E6F670", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FA00", Offset = "0x1E6EA00", VA = "0x181E6FA00")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C570", Offset = "0x1E6B570", VA = "0x181E6C570", Slot = "27")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C550", Offset = "0x1E6B550", VA = "0x181E6C550", Slot = "28")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x19B77D0", Offset = "0x19B67D0", VA = "0x1819B77D0", Slot = "29")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x463880", Offset = "0x462880", VA = "0x180463880", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FAC0", Offset = "0x1E6EAC0", VA = "0x181E6FAC0", Slot = "32")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C9480", Offset = "0x3C8480", VA = "0x1803C9480", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F5E0", Offset = "0x1E6E5E0", VA = "0x181E6F5E0", Slot = "30")]
		public void AddUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FA30", Offset = "0x1E6EA30", VA = "0x181E6FA30", Slot = "31")]
		public void RemoveUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FAD0", Offset = "0x1E6EAD0", VA = "0x181E6FAD0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FAE0", Offset = "0x1E6EAE0", VA = "0x181E6FAE0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F730", Offset = "0x1E6E730", VA = "0x181E6F730")]
		private void FireEventIfNeeded(bool addReset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CircuitNodeUuid("E13B62CC-99F8-401D-94D2-E77B70C097A6")]
	public class LockableSourceNode : CircuitNode, ISourceNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private bool? lastLockState;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1E72750", Offset = "0x1E71750", VA = "0x181E72750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action LockStateChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1E726B0", Offset = "0x1E716B0", VA = "0x181E726B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1E72770", Offset = "0x1E71770", VA = "0x181E72770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E725B0", Offset = "0x1E715B0", VA = "0x181E725B0")]
		public LockableSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E72460", Offset = "0x1E71460", VA = "0x181E72460")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E724C0", Offset = "0x1E714C0", VA = "0x181E724C0", Slot = "29")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x466130", Offset = "0x465130", VA = "0x180466130", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x468DB0", Offset = "0x467DB0", VA = "0x180468DB0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E72470", Offset = "0x1E71470", VA = "0x181E72470", Slot = "27")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E72410", Offset = "0x1E71410", VA = "0x181E72410", Slot = "28")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E724D0", Offset = "0x1E714D0", VA = "0x181E724D0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CircuitNodeUuid("53219714-E7BB-4950-BBB3-852A7EF196F8")]
	public class GameSetStateNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private static OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action StartGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1E71A20", Offset = "0x1E70A20", VA = "0x181E71A20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E71B60", Offset = "0x1E70B60", VA = "0x181E71B60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action EndGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E71980", Offset = "0x1E70980", VA = "0x181E71980")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E71AC0", Offset = "0x1E70AC0", VA = "0x181E71AC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E71650", Offset = "0x1E70650", VA = "0x181E71650", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E716B0", Offset = "0x1E706B0", VA = "0x181E716B0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E71920", Offset = "0x1E70920", VA = "0x181E71920")]
		public GameSetStateNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E71730", Offset = "0x1E70730", VA = "0x181E71730", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CircuitNodeUuid("20C6AC2E-1116-4C93-8CDF-40FE161CC796")]
	public class ObjectSetTagsNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public enum ChangeModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			Defaults
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate void ChangeTagsForObjectFunc(int objectId);

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public const string MODE_ARG = "mode";

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private const string nodeDescription = "Change Tags on Object";

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private ChangeModes changeMode;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ChangeModes ChangeMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(ChangeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA10", Offset = "0x19BAA10", VA = "0x1819BBA10")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ChangeTagsForObjectFunc ChangeTagsForObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x1E747D0", Offset = "0x1E737D0", VA = "0x181E747D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1E74870", Offset = "0x1E73870", VA = "0x181E74870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E74750", Offset = "0x1E73750", VA = "0x181E74750")]
		public ObjectSetTagsNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E743C0", Offset = "0x1E733C0", VA = "0x181E743C0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1E74360", Offset = "0x1E73360", VA = "0x181E74360", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1E74430", Offset = "0x1E73430", VA = "0x181E74430", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1E74570", Offset = "0x1E73570", VA = "0x181E74570", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1E74490", Offset = "0x1E73490", VA = "0x181E74490", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x19BB2E0", Offset = "0x19BA2E0", VA = "0x1819BB2E0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x19B21E0", Offset = "0x19B11E0", VA = "0x1819B21E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CircuitNodeUuid("0D0D8EA8-2816-4B3B-8F1D-19C74B056DA6")]
	public class PlayerRoleMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum PlayerRoleMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			AddPlayerRole,
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			RemovePlayerRole,
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			PlayerHasRole,
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			PlayerRoleChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate void PlayerModifyRoleFunc(int playerId, Guid roleGuid);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool PlayerHasRoleFunc(int playerId, Guid roleGuid);

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly OutputMetadata[] PlayerHasRoleOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly OutputMetadata[] PlayerRoleChangedOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly InputMetadata[] PlayerHasRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly InputMetadata[] ModifyPlayerRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly OutputMetadata[] ModifyPlayerRoleOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private PlayerRoleMapModes playerRoleMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Guid modificationRoleGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool masterLastPlayerHasRoleSignal;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PlayerRoleMapModes PlayerRoleMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x897F80", Offset = "0x896F80", VA = "0x180897F80")]
			get
			{
				return default(PlayerRoleMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x19B1150", Offset = "0x19B0150", VA = "0x1819B1150")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Guid ModificationRoleGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1E77640", Offset = "0x1E76640", VA = "0x181E77640")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1E77970", Offset = "0x1E76970", VA = "0x181E77970")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PlayerModifyRoleFunc PlayerAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1E77320", Offset = "0x1E76320", VA = "0x181E77320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x1E77650", Offset = "0x1E76650", VA = "0x181E77650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PlayerModifyRoleFunc TeamAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1E77500", Offset = "0x1E76500", VA = "0x181E77500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1E77830", Offset = "0x1E76830", VA = "0x181E77830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event PlayerModifyRoleFunc PlayerRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1E77460", Offset = "0x1E76460", VA = "0x181E77460")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x1E77790", Offset = "0x1E76790", VA = "0x181E77790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event PlayerModifyRoleFunc TeamRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1E775A0", Offset = "0x1E765A0", VA = "0x181E775A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1E778D0", Offset = "0x1E768D0", VA = "0x181E778D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event PlayerHasRoleFunc PlayerHasRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1E773C0", Offset = "0x1E763C0", VA = "0x181E773C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1E776F0", Offset = "0x1E766F0", VA = "0x181E776F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1E76B90", Offset = "0x1E75B90", VA = "0x181E76B90")]
		public void MarkDirtyForRoleChange(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1E77270", Offset = "0x1E76270", VA = "0x181E77270")]
		public PlayerRoleMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1E76C70", Offset = "0x1E75C70", VA = "0x181E76C70", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1E76390", Offset = "0x1E75390", VA = "0x181E76390")]
		private void EvaluatePlayerHasRole(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1E768F0", Offset = "0x1E758F0", VA = "0x181E768F0")]
		private bool GetPlayerHasRoleSignal(bool isMasterClient, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1E761D0", Offset = "0x1E751D0", VA = "0x181E761D0")]
		private void EvaluateAddPlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1E76460", Offset = "0x1E75460", VA = "0x181E76460")]
		private void EvaluateRemovePlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1E76BD0", Offset = "0x1E75BD0", VA = "0x181E76BD0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1E761A0", Offset = "0x1E751A0", VA = "0x181E761A0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E76620", Offset = "0x1E75620", VA = "0x181E76620", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1E767D0", Offset = "0x1E757D0", VA = "0x181E767D0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1E76720", Offset = "0x1E75720", VA = "0x181E76720", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1E769C0", Offset = "0x1E759C0", VA = "0x181E769C0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1E76C00", Offset = "0x1E75C00", VA = "0x181E76C00", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1E76D80", Offset = "0x1E75D80", VA = "0x181E76D80", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CircuitNodeUuid("B81209CD-0D42-4FC7-A7A4-9AF3E78499B6")]
	public class PlayerRoleNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E77A90", Offset = "0x1E76A90", VA = "0x181E77A90")]
		public PlayerRoleNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1E77A10", Offset = "0x1E76A10", VA = "0x181E77A10", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1E77A50", Offset = "0x1E76A50", VA = "0x181E77A50", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CircuitNodeUuid("CEE29EB9-61AE-42D4-8DC6-3A62D7096781")]
	public class PlayerTeamMappingNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum PlayerIdMapModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			PlayerToTeam,
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			TeamToPlayer,
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			SetPlayerTeam,
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			GetTeamPlayerCount
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public delegate void PlayerToTeamIndexFunc(int playerId, out int teamId, out int teamIndex);

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public delegate void PlayerSetTeamFunc(int playerId, int teamId);

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public delegate void TeamIndexToPlayerFunc(int teamId, int teamIndex, out int playerId);

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public delegate void GetTeamPlayerCountFunc(int teamId, out int teamPlayerCount);

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly InputMetadata[] PlayerToTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly OutputMetadata[] PlayerToTeamOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly InputMetadata[] TeamToPlayerInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly OutputMetadata[] TeamToPlayerOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly InputMetadata[] SetPlayerTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly InputMetadata[] GetTeamPlayerCountInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly OutputMetadata[] GetTeamPlayerCountOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly OutputMetadata[] SetPlayerTeamOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private PlayerIdMapModes playerIdMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int lastMasterPlayerToTeamId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int lastMasterPlayerToTeamIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int lastMasterTeamIndexToPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int lastMasterTeamPlayerCount;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PlayerIdMapModes PlayerIdMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x897F80", Offset = "0x896F80", VA = "0x180897F80")]
			get
			{
				return default(PlayerIdMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x19B1150", Offset = "0x19B0150", VA = "0x1819B1150")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event PlayerToTeamIndexFunc PlayerToTeamIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x19B0D90", Offset = "0x19AFD90", VA = "0x1819B0D90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x19B1010", Offset = "0x19B0010", VA = "0x1819B1010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event PlayerSetTeamFunc PlayerSetTeam
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x19B0CF0", Offset = "0x19AFCF0", VA = "0x1819B0CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x19B0F70", Offset = "0x19AFF70", VA = "0x1819B0F70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event TeamIndexToPlayerFunc TeamIndexToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x19B0E30", Offset = "0x19AFE30", VA = "0x1819B0E30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x19B10B0", Offset = "0x19B00B0", VA = "0x1819B10B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event GetTeamPlayerCountFunc GetTeamPlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x19B0C50", Offset = "0x19AFC50", VA = "0x1819B0C50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x19B0ED0", Offset = "0x19AFED0", VA = "0x1819B0ED0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x19B0190", Offset = "0x19AF190", VA = "0x1819B0190")]
		public void MarkDirtyForTeamChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x19B0B70", Offset = "0x19AFB70", VA = "0x1819B0B70")]
		public PlayerTeamMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x19B0330", Offset = "0x19AF330", VA = "0x1819B0330", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x19AF940", Offset = "0x19AE940", VA = "0x1819AF940")]
		private void EvaluatePlayerToTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x19AFEA0", Offset = "0x19AEEA0", VA = "0x1819AFEA0")]
		private void GetPlayerToTeamSignals(bool isMasterClient, int playerId, out int masterTeamId, out int masterTeamIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x19AFAE0", Offset = "0x19AEAE0", VA = "0x1819AFAE0")]
		private void EvaluateTeamToPlayer(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x19AFF70", Offset = "0x19AEF70", VA = "0x1819AFF70")]
		private int GetTeamIndexToPlayerSignal(bool isMasterClient, int teamId, int teamIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x19AF8A0", Offset = "0x19AE8A0", VA = "0x1819AF8A0")]
		private void EvaluateGetTeamPlayerCount(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x19B0050", Offset = "0x19AF050", VA = "0x1819B0050")]
		private int GetTeamPlayerCountSignal(bool isMasterClient, int teamId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x19AF9D0", Offset = "0x19AE9D0", VA = "0x1819AF9D0")]
		private void EvaluateSetPlayerTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x19B01B0", Offset = "0x19AF1B0", VA = "0x1819B01B0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x19AF750", Offset = "0x19AE750", VA = "0x1819AF750", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x19AFB60", Offset = "0x19AEB60", VA = "0x1819AFB60", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x19AFD40", Offset = "0x19AED40", VA = "0x1819AFD40", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x19AFCC0", Offset = "0x19AECC0", VA = "0x1819AFCC0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x19B0130", Offset = "0x19AF130", VA = "0x1819B0130", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x19B0300", Offset = "0x19AF300", VA = "0x1819B0300", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x19B0640", Offset = "0x19AF640", VA = "0x1819B0640", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class PostEvalActionNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private List<Action> PostEvalActions;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal sealed override bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x19B1860", Offset = "0x19B0860", VA = "0x1819B1860", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x19B17A0", Offset = "0x19B07A0", VA = "0x1819B17A0")]
		public PostEvalActionNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x19B1740", Offset = "0x19B0740", VA = "0x1819B1740")]
		protected void QueuePostEvalAction(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x19B1590", Offset = "0x19B0590", VA = "0x1819B1590", Slot = "23")]
		internal sealed override void PostEvaluateNode(bool isMasterClient)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CircuitNodeUuid("3079A591-0E82-41B5-8BEC-00AC26F8E6C4")]
	public class QueuedMomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct Output
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public OutputSlot outputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public int outputValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		internal List<Output[]> QueuedSignals;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x19B1E40", Offset = "0x19B0E40", VA = "0x1819B1E40")]
		public QueuedMomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x19B1C90", Offset = "0x19B0C90", VA = "0x1819B1C90")]
		public new void SetContinuousOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x19B1CA0", Offset = "0x19B0CA0", VA = "0x1819B1CA0")]
		public new void SetMomentaryOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x19B1D40", Offset = "0x19B0D40", VA = "0x1819B1D40")]
		public void SetMomentaryOutputs(params Output[] outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x19B1D50", Offset = "0x19B0D50", VA = "0x1819B1D50", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x19B1AD0", Offset = "0x19B0AD0", VA = "0x1819B1AD0", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x19B18C0", Offset = "0x19B08C0", VA = "0x1819B18C0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x19B1A30", Offset = "0x19B0A30", VA = "0x1819B1A30")]
		private void QueueSignal(Output[] outputs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CircuitNodeUuid("AA5DC0B1-AC22-4075-AB13-E8376AA0FC39")]
	public class ObjectPlayerMappingNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate void ObjectToHoldingPlayerIdFunc(int objectId, out int lastHeldPlayer, out int currentHoldingPlayer);

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event ObjectToHoldingPlayerIdFunc ObjectToHoldingPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1E74220", Offset = "0x1E73220", VA = "0x181E74220")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1E742C0", Offset = "0x1E732C0", VA = "0x181E742C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1E741A0", Offset = "0x1E731A0", VA = "0x181E741A0")]
		public ObjectPlayerMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1E73DB0", Offset = "0x1E72DB0", VA = "0x181E73DB0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1E73D50", Offset = "0x1E72D50", VA = "0x181E73D50", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1E73DE0", Offset = "0x1E72DE0", VA = "0x181E73DE0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1E73FB0", Offset = "0x1E72FB0", VA = "0x181E73FB0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x1E73E40", Offset = "0x1E72E40", VA = "0x181E73E40")]
		private void MasterCalcOutput(int objectId, out int lastHeldPlayerId, out int currentHoldingPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CircuitNodeUuid("B71B05C0-D6FD-4C49-A70C-085C14E95317")]
	public class RandomNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum RandomModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			Continuous,
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			Pulse
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private RandomModes randomMode;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static Random random;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int masterLastRandomNumber;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RandomModes RandomMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(RandomModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x19B2650", Offset = "0x19B1650", VA = "0x1819B2650")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x19B25D0", Offset = "0x19B15D0", VA = "0x1819B25D0")]
		public RandomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x19B20A0", Offset = "0x19B10A0", VA = "0x1819B20A0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x19B2040", Offset = "0x19B1040", VA = "0x1819B2040", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x19B20D0", Offset = "0x19B10D0", VA = "0x1819B20D0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x19B2210", Offset = "0x19B1210", VA = "0x1819B2210", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x19B2180", Offset = "0x19B1180", VA = "0x1819B2180", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x19B1FF0", Offset = "0x19B0FF0", VA = "0x1819B1FF0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x19B1F00", Offset = "0x19B0F00", VA = "0x1819B1F00")]
		private int CalcOutput(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x19B2130", Offset = "0x19B1130", VA = "0x1819B2130", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x19B21E0", Offset = "0x19B11E0", VA = "0x1819B21E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x19B2380", Offset = "0x19B1380", VA = "0x1819B2380", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class SourceNodeBase : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x19B77D0", Offset = "0x19B67D0", VA = "0x1819B77D0", Slot = "27")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x19B7830", Offset = "0x19B6830", VA = "0x1819B7830")]
		public SourceNodeBase(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x19B7770", Offset = "0x19B6770", VA = "0x1819B7770", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x463880", Offset = "0x462880", VA = "0x180463880", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CircuitNodeUuid("6AD5D963-2357-4A09-BDA6-C99A917655B1")]
	public class SelectorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum EvalModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			First,
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct SelectorConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public SignalComparisonHelper.ComparerModes CompareMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public int CompareValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private EvalModes _evalMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public SelectorConfig[] SelectorConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private InputMetadata[] inputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private int lastSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int lastSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private bool modifiedSinceLastEval;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public EvalModes EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(EvalModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x19B4020", Offset = "0x19B3020", VA = "0x1819B4020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x19B3E70", Offset = "0x19B2E70", VA = "0x1819B3E70")]
		public SelectorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x19B39D0", Offset = "0x19B29D0", VA = "0x1819B39D0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x19B35F0", Offset = "0x19B25F0", VA = "0x1819B35F0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x466130", Offset = "0x465130", VA = "0x180466130", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x19B3630", Offset = "0x19B2630", VA = "0x1819B3630", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x19B3680", Offset = "0x19B2680", VA = "0x1819B3680", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x19B3820", Offset = "0x19B2820", VA = "0x1819B3820", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x19B3BD0", Offset = "0x19B2BD0", VA = "0x1819B3BD0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface ISourceNode
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMomentaryOutput(OutputSlot outputSlot, int value);

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetContinuousOutput(OutputSlot outputSlot, int value);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetOutputMeta(OutputMetadata[] outputMetadata);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CircuitNodeUuid("B58C2FAB-3F1A-15F4-6D31-4E3BE09A71A9")]
	public class SourceNode : SourceNodeBase, ISourceNode
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x19B78E0", Offset = "0x19B68E0", VA = "0x1819B78E0")]
		public SourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x19B78D0", Offset = "0x19B68D0", VA = "0x1819B78D0", Slot = "28")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x19B1C90", Offset = "0x19B0C90", VA = "0x1819B1C90", Slot = "29")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169B82")]
	public class ComparerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private static readonly InputMetadata[] AdvancedInputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private SignalComparisonHelper.ComparerModes comparerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private bool advancedMode;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public SignalComparisonHelper.ComparerModes ComparerMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(SignalComparisonHelper.ComparerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA10", Offset = "0x19BAA10", VA = "0x1819BBA10")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x16FF120", Offset = "0x16FE120", VA = "0x1816FF120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1E6EDC0", Offset = "0x1E6DDC0", VA = "0x181E6EDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1E6ED40", Offset = "0x1E6DD40", VA = "0x181E6ED40")]
		public ComparerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E870", Offset = "0x1E6D870", VA = "0x181E6E870", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E500", Offset = "0x1E6D500", VA = "0x181E6E500")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E590", Offset = "0x1E6D590", VA = "0x181E6E590", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E6A0", Offset = "0x1E6D6A0", VA = "0x181E6E6A0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E630", Offset = "0x1E6D630", VA = "0x181E6E630", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E7C0", Offset = "0x1E6D7C0", VA = "0x181E6E7C0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E830", Offset = "0x1E6D830", VA = "0x181E6E830", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E9D0", Offset = "0x1E6D9D0", VA = "0x181E6E9D0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CircuitNodeUuid("17B72DE0-4116-41DB-A99D-1523625F7EF1")]
	public class CombinatorNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public enum CombinatorModes
		{
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			Subtract,
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Multiply,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Divide,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Modulo
		}

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static readonly InputMetadata[] TwoInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static readonly InputMetadata[] ThreeInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static readonly Dictionary<CombinatorModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private CombinatorModes combinatorMode;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public CombinatorModes CombinatorMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(CombinatorModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA10", Offset = "0x19BAA10", VA = "0x1819BBA10")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DE10", Offset = "0x1E6CE10", VA = "0x181E6DE10")]
		public static string GetModeSymbol(CombinatorModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E480", Offset = "0x1E6D480", VA = "0x181E6E480")]
		public CombinatorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E030", Offset = "0x1E6D030", VA = "0x181E6E030", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DC40", Offset = "0x1E6CC40", VA = "0x181E6DC40")]
		private int CalcOutput()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DD70", Offset = "0x1E6CD70", VA = "0x181E6DD70", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DF60", Offset = "0x1E6CF60", VA = "0x181E6DF60", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DE90", Offset = "0x1E6CE90", VA = "0x181E6DE90", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x19BB2E0", Offset = "0x19BA2E0", VA = "0x1819BB2E0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x19B21E0", Offset = "0x19B11E0", VA = "0x1819B21E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E110", Offset = "0x1E6D110", VA = "0x181E6E110", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CircuitNodeUuid("34452A12-AFB3-4A4D-97B0-9D25F7E777C5")]
	public class DelayNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private struct DelaySignal
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public int timeRemaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public int value;
		}

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private static OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private List<DelaySignal> QueuedSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private int lastInputSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E70830", Offset = "0x1E6F830", VA = "0x181E70830")]
		public DelayNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FDC0", Offset = "0x1E6EDC0", VA = "0x181E6FDC0", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FF30", Offset = "0x1E6EF30", VA = "0x181E6FF30", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FF90", Offset = "0x1E6EF90", VA = "0x181E6FF90", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E70470", Offset = "0x1E6F470", VA = "0x181E70470", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E70650", Offset = "0x1E6F650", VA = "0x181E70650", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E701C0", Offset = "0x1E6F1C0", VA = "0x181E701C0")]
		private void QueueSignal(int delay, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FFF0", Offset = "0x1E6EFF0", VA = "0x181E6FFF0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E70300", Offset = "0x1E6F300", VA = "0x181E70300", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FCB0", Offset = "0x1E6ECB0", VA = "0x181E6FCB0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CircuitNodeUuid("C9A59F26-0A72-4C2E-B239-6A83998E0839")]
	public class LoopNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		internal override bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E72930", Offset = "0x1E71930", VA = "0x181E72930", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E728B0", Offset = "0x1E718B0", VA = "0x181E728B0")]
		public LoopNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E72810", Offset = "0x1E71810", VA = "0x181E72810", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E72860", Offset = "0x1E71860", VA = "0x181E72860", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CircuitNodeUuid("E7EFD8CA-92FE-4A37-9E7C-ABBE9E4DE336")]
	public class MomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E72940", Offset = "0x1E71940", VA = "0x181E72940")]
		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C570", Offset = "0x1E6B570", VA = "0x181E6C570")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CircuitNodeUuid("6402C773-5838-4495-BC54-BC36EDE4AB0F")]
	public class ConstantSourceNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E6EE50", Offset = "0x1E6DE50", VA = "0x181E6EE50", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E6EEB0", Offset = "0x1E6DEB0", VA = "0x181E6EEB0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F4E0", Offset = "0x1E6E4E0", VA = "0x181E6F4E0")]
		public ConstantSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E6EF10", Offset = "0x1E6DF10", VA = "0x181E6EF10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F100", Offset = "0x1E6E100", VA = "0x181E6F100", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F260", Offset = "0x1E6E260", VA = "0x181E6F260", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CircuitNodeUuid("738B2AF2-EEBD-4316-82A9-2FBEC9B50D8B")]
	public class NodeGraphNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CircuitNodeUuid("86B6FD1C-4668-4BA9-8ACB-FB91E25DBFB6")]
		public class GraphInputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1E72040", Offset = "0x1E71040", VA = "0x181E72040")]
			public GraphInputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1E6C550", Offset = "0x1E6B550", VA = "0x181E6C550")]
			public void SetOutputSignal(OutputSlot slot, int val)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CircuitNodeUuid("F8A998DB-0354-4BCD-B0E4-6BBA7CC24B89")]
		public class GraphOutputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1E72240", Offset = "0x1E71240", VA = "0x181E72240")]
			public GraphOutputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1E720C0", Offset = "0x1E710C0", VA = "0x181E720C0", Slot = "24")]
			protected override void _EvaluateNode(bool isMasterClient)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private GraphInputNode virtualSourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private GraphOutputNode virtualDestNode;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public CircuitNodeGraph InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x463880", Offset = "0x462880", VA = "0x180463880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x4638E0", Offset = "0x4628E0", VA = "0x1804638E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E73760", Offset = "0x1E72760", VA = "0x181E73760")]
		public NodeGraphNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E73450", Offset = "0x1E72450", VA = "0x181E73450", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1E73390", Offset = "0x1E72390", VA = "0x181E73390", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E72F80", Offset = "0x1E71F80", VA = "0x181E72F80", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E72EE0", Offset = "0x1E71EE0", VA = "0x181E72EE0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E72F30", Offset = "0x1E71F30", VA = "0x181E72F30", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 32)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct NodeMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool NeedsSerialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public InputMetadata[] InputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public string NodeDescription;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct InputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public string Description;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct OutputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public OutputSlot OutputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string Description;
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate void OutputNodeUpdated(Dictionary<InputSlot, int> slotUpdates);
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface IOutputNode
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AddUpdatedEvent(OutputNodeUpdated updateEvent);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveUpdatedEvent(OutputNodeUpdated updateEvent);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInputMeta(InputMetadata[] inputMeta);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CircuitNodeUuid("C6AB70A0-C752-466A-8070-029742655556")]
	public class OutputNode : CircuitNode, IOutputNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private int[] lastSignals;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x19B77D0", Offset = "0x19B67D0", VA = "0x1819B77D0", Slot = "29")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E749D0", Offset = "0x1E739D0", VA = "0x181E749D0", Slot = "27")]
		public void AddUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E74E50", Offset = "0x1E73E50", VA = "0x181E74E50", Slot = "28")]
		public void RemoveUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E750B0", Offset = "0x1E740B0", VA = "0x181E750B0")]
		public OutputNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E74A60", Offset = "0x1E73A60", VA = "0x181E74A60", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E74E20", Offset = "0x1E73E20", VA = "0x181E74E20")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x463880", Offset = "0x462880", VA = "0x180463880", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1E74DC0", Offset = "0x1E73DC0", VA = "0x181E74DC0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E74EE0", Offset = "0x1E73EE0", VA = "0x181E74EE0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E74EF0", Offset = "0x1E73EF0", VA = "0x181E74EF0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1E74B20", Offset = "0x1E73B20", VA = "0x181E74B20")]
		private void FireEventIfNeeded()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169BAD")]
	public class StateMachineNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct StateTransition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public InputSlot inputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public byte stateIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public struct State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public int val1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public int val2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public int val3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int minTimeInStateMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public bool removed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public StateTransition[] transitions;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum ModifyCommands
		{
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			DefaultState = 1,
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			MaxStateIndex,
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			StateVal1,
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			StateVal2,
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			StateVal3,
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			MinTimeInStateMS,
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			NumTransitions,
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			TransitionInputSlot,
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			TransitionStateTarget,
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			RemovedState
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private State[] states;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private byte maxStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private OutputSlot[] _serializableOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public byte CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x19B9A10", Offset = "0x19B8A10", VA = "0x1819B9A10")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x19B9AF0", Offset = "0x19B8AF0", VA = "0x1819B9AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public byte DefaultState
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x198E0D0", Offset = "0x198D0D0", VA = "0x18198E0D0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x198E3E0", Offset = "0x198D3E0", VA = "0x18198E3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected override OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x466130", Offset = "0x465130", VA = "0x180466130", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x56A250", Offset = "0x569250", VA = "0x18056A250", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int TimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xB13680", Offset = "0xB12680", VA = "0x180B13680")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xB11D50", Offset = "0xB10D50", VA = "0x180B11D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x19B9AB0", Offset = "0x19B8AB0", VA = "0x1819B9AB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x19B9A20", Offset = "0x19B8A20", VA = "0x1819B9A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x19B8210", Offset = "0x19B7210", VA = "0x1819B8210")]
		public State? GetState(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x19B9870", Offset = "0x19B8870", VA = "0x1819B9870")]
		public StateMachineNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x19B79C0", Offset = "0x19B69C0", VA = "0x1819B79C0", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x19B8770", Offset = "0x19B7770", VA = "0x1819B8770")]
		private void OnTimerUpdate(int networkTimeMS, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x19B8B80", Offset = "0x19B7B80", VA = "0x1819B8B80", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x19B9840", Offset = "0x19B8840", VA = "0x1819B9840", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x19B7F70", Offset = "0x19B6F70", VA = "0x1819B7F70")]
		public static OutputSlot GetOnEnterOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x19B7C60", Offset = "0x19B6C60", VA = "0x1819B7C60")]
		public static OutputSlot GetInStateOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x19B7F80", Offset = "0x19B6F80", VA = "0x1819B7F80")]
		public static OutputSlot GetOnExitOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x19B7A50", Offset = "0x19B6A50", VA = "0x1819B7A50")]
		private void EnterState(byte newStateIndex, bool forceIfCurrent = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x19B7C70", Offset = "0x19B6C70", VA = "0x1819B7C70", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x19B7F90", Offset = "0x19B6F90", VA = "0x1819B7F90", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x19B7EA0", Offset = "0x19B6EA0", VA = "0x1819B7EA0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x19B88C0", Offset = "0x19B78C0", VA = "0x1819B88C0", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x19B7960", Offset = "0x19B6960", VA = "0x1819B7960", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x19B8320", Offset = "0x19B7320", VA = "0x1819B8320", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x19B8940", Offset = "0x19B7940", VA = "0x1819B8940", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x19B7E80", Offset = "0x19B6E80", VA = "0x1819B7E80")]
		public static int GetModifyArg(ModifyCommands cmd, byte stateIdx = 0, byte transitionIdx = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x19B8B60", Offset = "0x19B7B60", VA = "0x1819B8B60")]
		private static void UnpackModifyArg(int arg, out ModifyCommands cmd, out byte stateIdx, out byte transitionIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x19B8D30", Offset = "0x19B7D30", VA = "0x1819B8D30", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x19B7C50", Offset = "0x19B6C50", VA = "0x1819B7C50")]
		public void ForceReconstructNodeMetaData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CircuitNodeUuid("A77191F7-792B-4590-AAB3-A3B71C440DD1")]
	public class TimerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum TimerModes
		{
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			Looping,
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			Countdown
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public enum TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			Second,
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			TenthOfSecond
		}

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private static readonly InputMetadata[] InputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private TimerModes timerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private int timeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool timerExpired;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private int _inputTimeTenths;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TimerModes TimerMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(TimerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA10", Offset = "0x19BAA10", VA = "0x1819BBA10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private int inputTimeTenths
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x16FEC40", Offset = "0x16FDC40", VA = "0x1816FEC40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA30", Offset = "0x19BAA30", VA = "0x1819BBA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x19BB930", Offset = "0x19BA930", VA = "0x1819BB930")]
		public TimerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x19BB150", Offset = "0x19BA150", VA = "0x1819BB150", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x19BB5F0", Offset = "0x19BA5F0", VA = "0x1819BB5F0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x19BB720", Offset = "0x19BA720", VA = "0x1819BB720", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x19BB1E0", Offset = "0x19BA1E0", VA = "0x1819BB1E0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x19BB280", Offset = "0x19BA280", VA = "0x1819BB280", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x19BB240", Offset = "0x19BA240", VA = "0x1819BB240", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x19BB340", Offset = "0x19BA340", VA = "0x1819BB340")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x19BB560", Offset = "0x19BA560", VA = "0x1819BB560")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x19BB430", Offset = "0x19BA430", VA = "0x1819BB430")]
		private void ResetTimeRemaining()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x19BB2E0", Offset = "0x19BA2E0", VA = "0x1819BB2E0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x19B21E0", Offset = "0x19B11E0", VA = "0x1819B21E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x19BB660", Offset = "0x19BA660", VA = "0x1819BB660", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x19BB500", Offset = "0x19BA500", VA = "0x1819BB500", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x19BB100", Offset = "0x19BA100", VA = "0x1819BB100", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x19BB4C0", Offset = "0x19BA4C0", VA = "0x1819BB4C0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x19BB0C0", Offset = "0x19BA0C0", VA = "0x1819BB0C0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CircuitNodeUuid("9B664D6A-1B61-4D4E-9AA8-B17B0DC02DA3")]
	public class UnityTransformationNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private Dictionary<InputSlot, int> inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private Dictionary<OutputSlot, int> outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private Func<Dictionary<InputSlot, int>, Dictionary<OutputSlot, int>> transformationFunction;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x463880", Offset = "0x462880", VA = "0x180463880", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3C9480", Offset = "0x3C8480", VA = "0x1803C9480", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x19BE340", Offset = "0x19BD340", VA = "0x1819BE340")]
		public UnityTransformationNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x19BE000", Offset = "0x19BD000", VA = "0x1819BE000", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x19BDF00", Offset = "0x19BCF00", VA = "0x1819BDF00")]
		private void PassthroughValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CircuitNodeUuid("34200A8F-370E-4240-B034-66252D44BE88")]
	public class WaveNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum WaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			Sine,
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			Cosine,
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			Square,
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			Sawtooth
		}

		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private static readonly InputMetadata[] SecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private static readonly InputMetadata[] ThenthOfSecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private WaveMode currentWaveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TimerNode.TimeUnit currentTimeUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private int runningTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int _inputPeriod;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private int inputAmplitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private double functionPeriodInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private double millisecondTimeToAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private int loopTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private int relevantDecimalPlaces;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public WaveMode CurrentWaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x900680", Offset = "0x8FF680", VA = "0x180900680")]
			get
			{
				return default(WaveMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA10", Offset = "0x19BAA10", VA = "0x1819BBA10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TimerNode.TimeUnit CurrentTimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB9BE00", Offset = "0xB9AE00", VA = "0x180B9BE00")]
			get
			{
				return default(TimerNode.TimeUnit);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2F80050", Offset = "0x2F7F050", VA = "0x182F80050")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private double InputTimeUnitInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2F80020", Offset = "0x2F7F020", VA = "0x182F80020")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private int InputPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BA0", Offset = "0xAA2BA0", VA = "0x180AA3BA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2F80090", Offset = "0x2F7F090", VA = "0x182F80090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FF40", Offset = "0x2F7EF40", VA = "0x182F7FF40")]
		public WaveNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F140", Offset = "0x2F7E140", VA = "0x182F7F140", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FA10", Offset = "0x2F7EA10", VA = "0x182F7FA10", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FC10", Offset = "0x2F7EC10", VA = "0x182F7FC10", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F4B0", Offset = "0x2F7E4B0", VA = "0x182F7F4B0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F5E0", Offset = "0x2F7E5E0", VA = "0x182F7F5E0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F550", Offset = "0x2F7E550", VA = "0x182F7F550", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F6D0", Offset = "0x2F7E6D0", VA = "0x182F7F6D0")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F9D0", Offset = "0x2F7E9D0", VA = "0x182F7F9D0")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F7B0", Offset = "0x2F7E7B0", VA = "0x182F7F7B0")]
		private void ResetRunningTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F1D0", Offset = "0x2F7E1D0", VA = "0x182F7F1D0")]
		private int EvaluateWaveFunction()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F860", Offset = "0x2F7E860", VA = "0x182F7F860")]
		private void UpdateCachedFunctionParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F640", Offset = "0x2F7E640", VA = "0x182F7F640", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F820", Offset = "0x2F7E820", VA = "0x182F7F820", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2F7FAC0", Offset = "0x2F7EAC0", VA = "0x182F7FAC0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F7C0", Offset = "0x2F7E7C0", VA = "0x182F7F7C0", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F0F0", Offset = "0x2F7E0F0", VA = "0x182F7F0F0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CircuitNodeUuid("A4160690-4C68-40C2-BD51-B665F71FCEBD")]
	public class RootNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal override bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x19B2660", Offset = "0x19B1660", VA = "0x1819B2660")]
		public RootNode(int nodeId, CircuitNodeGraph graph)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class VirtualNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x39B3D0", Offset = "0x39A3D0", VA = "0x18039B3D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F060", Offset = "0x2F7E060", VA = "0x182F7F060")]
		protected VirtualNode(string nodeName, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EF00", Offset = "0x2F7DF00", VA = "0x182F7EF00", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EF30", Offset = "0x2F7DF30", VA = "0x182F7EF30", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EF90", Offset = "0x2F7DF90", VA = "0x182F7EF90", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class Serialization
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x19B6A30", Offset = "0x19B5A30", VA = "0x1819B6A30")]
		public static CircuitNode InstantiateNode(Guid nodeType, int nodeId, Guid graphGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x19B67D0", Offset = "0x19B57D0", VA = "0x1819B67D0")]
		internal static CircuitNode InstantiateNode(CircuitNodeData nodeData, CircuitNodeGraph nodeGraph, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x19B66A0", Offset = "0x19B56A0", VA = "0x1819B66A0")]
		public static Guid GetNodeTypeGuid(CircuitNode node)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x19B6BC0", Offset = "0x19B5BC0", VA = "0x1819B6BC0")]
		public static bool TryGetNodeTypeByGuid(Guid guid, out Type t)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate CircuitNode CircuitNodeConstructor(int nodeId, CircuitNodeGraph graph);
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class CircuitSerializedTypeLookup
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DBA0", Offset = "0x1E6CBA0", VA = "0x181E6DBA0")]
		public static bool TryGetCircuitTypeFromGuid(Guid guid, out Type nodeType)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	internal static class SerializationLookup
	{
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static Guid RECROOM_CIRCUITS_BOOLEANNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static Guid RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static Guid RECROOM_CIRCUITS_CUSTOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static Guid RECROOM_CIRCUITS_LOCKABLESOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static Guid RECROOM_CIRCUITS_GAMESETSTATENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static Guid RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static Guid RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static Guid RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static Guid RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static Guid RECROOM_CIRCUITS_SELECTORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static Guid RECROOM_CIRCUITS_SOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private static Guid RECROOM_CIRCUITS_STATEMACHINENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private static Guid RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private static Guid RECROOM_CIRCUITS_WAVENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000223")]
		internal static Dictionary<Type, Guid> TypeToGuidLookup;

		[Cpp2IlInjected.Token(Token = "0x4000224")]
		internal static Dictionary<Guid, Type> GuidToTypeLookup;

		[Cpp2IlInjected.Token(Token = "0x4000225")]
		internal static Dictionary<Guid, CircuitNodeConstructor> GuidToNodeConstructor;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class SignalComparisonHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum ComparerModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			Equals,
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			NotEquals,
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			GreaterThan,
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			GreaterThanEqualTo,
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			LessThan,
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			LessThanEqualTo
		}

		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private static readonly Dictionary<ComparerModes, string> ModeSymbols;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x19B70E0", Offset = "0x19B60E0", VA = "0x1819B70E0")]
		public static string GetModeSymbol(ComparerModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x19B7070", Offset = "0x19B6070", VA = "0x1819B7070")]
		internal static bool Compare(ComparerModes comparerMode, int leftSide, int rightSide)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Circuits.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class CircuitLinkDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x19A7340", Offset = "0x19A6340", VA = "0x1819A7340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x19A6D30", Offset = "0x19A5D30", VA = "0x1819A6D30")]
		static CircuitLinkDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class CircuitLinkData : IMessage<CircuitLinkData>, IMessage, IEquatable<CircuitLinkData>, IDeepCloneable<CircuitLinkData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private static readonly MessageParser<CircuitLinkData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private int sourceNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private int destNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private int inputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private int outputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private int linkType_;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitLinkData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x19A7A90", Offset = "0x19A6A90", VA = "0x1819A7A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x19A79D0", Offset = "0x19A69D0", VA = "0x1819A79D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x19A7AF0", Offset = "0x19A6AF0", VA = "0x1819A7AF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[DebuggerNonUserCode]
		public int SourceNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x3C0880", Offset = "0x3BF880", VA = "0x1803C0880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x44F430", Offset = "0x44E430", VA = "0x18044F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[DebuggerNonUserCode]
		public int DestNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB50", Offset = "0x3EBB50", VA = "0x1803ECB50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x4604B0", Offset = "0x45F4B0", VA = "0x1804604B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[DebuggerNonUserCode]
		public int InputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x405FC0", Offset = "0x404FC0", VA = "0x180405FC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x406100", Offset = "0x405100", VA = "0x180406100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[DebuggerNonUserCode]
		public int OutputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x455F60", Offset = "0x454F60", VA = "0x180455F60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x4562A0", Offset = "0x4552A0", VA = "0x1804562A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[DebuggerNonUserCode]
		public int LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x455D30", Offset = "0x454D30", VA = "0x180455D30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x4562B0", Offset = "0x4552B0", VA = "0x1804562B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		[DebuggerNonUserCode]
		public CircuitLinkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xB736A0", Offset = "0xB726A0", VA = "0x180B736A0")]
		[DebuggerNonUserCode]
		public CircuitLinkData(CircuitLinkData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x19A74F0", Offset = "0x19A64F0", VA = "0x1819A74F0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitLinkData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x19A7570", Offset = "0x19A6570", VA = "0x1819A7570", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x19A7610", Offset = "0x19A6610", VA = "0x1819A7610", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitLinkData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x19A7650", Offset = "0x19A6650", VA = "0x1819A7650", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x19A77C0", Offset = "0x19A67C0", VA = "0x1819A77C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x19A7820", Offset = "0x19A6820", VA = "0x1819A7820", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x19A73A0", Offset = "0x19A63A0", VA = "0x1819A73A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x19A7700", Offset = "0x19A6700", VA = "0x1819A7700", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class CircuitNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x19AA350", Offset = "0x19A9350", VA = "0x1819AA350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x19A7BF0", Offset = "0x19A6BF0", VA = "0x1819A7BF0")]
		static CircuitNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly MessageParser<CircuitNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private string nodeName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int nodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int pairedNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private ByteString nodeType_;

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly FieldCodec<CircuitLinkData> _repeated_circuitLinks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private readonly RepeatedField<CircuitLinkData> circuitLinks_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private NodeTransformData transformData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private InternalGraphData internalGraphData_;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly FieldCodec<SlotData> _repeated_slotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private readonly RepeatedField<SlotData> slotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private int mode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private SelectorNodeData selectorNodeData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private bool advancedMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private int timeUnit_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private int roleId_;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly FieldCodec<StateMachineStateData> _repeated_stateMachineData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private readonly RepeatedField<StateMachineStateData> stateMachineData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int defaultIndex_;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly FieldCodec<SlotData> _repeated_defaultInputSlotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly RepeatedField<SlotData> defaultInputSlotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private string roleGuid_;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x19ABE00", Offset = "0x19AAE00", VA = "0x1819ABE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x19ABD40", Offset = "0x19AAD40", VA = "0x1819ABD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x19ABE60", Offset = "0x19AAE60", VA = "0x1819ABE60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x39A550", Offset = "0x399550", VA = "0x18039A550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x19ABF60", Offset = "0x19AAF60", VA = "0x1819ABF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x405FC0", Offset = "0x404FC0", VA = "0x180405FC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x406100", Offset = "0x405100", VA = "0x180406100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[DebuggerNonUserCode]
		public int PairedNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x455F60", Offset = "0x454F60", VA = "0x180455F60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x4562A0", Offset = "0x4552A0", VA = "0x1804562A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x3A09B0", Offset = "0x39F9B0", VA = "0x1803A09B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x19ABFB0", Offset = "0x19AAFB0", VA = "0x1819ABFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitLinkData> CircuitLinks
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x3A09C0", Offset = "0x39F9C0", VA = "0x1803A09C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		public NodeTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x3A09A0", Offset = "0x39F9A0", VA = "0x1803A09A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x3C9C60", Offset = "0x3C8C60", VA = "0x1803C9C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public InternalGraphData InternalGraphData
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x3A0870", Offset = "0x39F870", VA = "0x1803A0870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x3CDD10", Offset = "0x3CCD10", VA = "0x1803CDD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> SlotData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x3C74F0", Offset = "0x3C64F0", VA = "0x1803C74F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[DebuggerNonUserCode]
		public int Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x721FD0", Offset = "0x720FD0", VA = "0x180721FD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x722620", Offset = "0x721620", VA = "0x180722620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public SelectorNodeData SelectorNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x3E4FE0", Offset = "0x3E3FE0", VA = "0x1803E4FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x455D00", Offset = "0x454D00", VA = "0x180455D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x3F17E0", Offset = "0x3F07E0", VA = "0x1803F17E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x3F9A80", Offset = "0x3F8A80", VA = "0x1803F9A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		public int TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x45EF70", Offset = "0x45DF70", VA = "0x18045EF70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x61EE40", Offset = "0x61DE40", VA = "0x18061EE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public int RoleId
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x4AAC20", Offset = "0x4A9C20", VA = "0x1804AAC20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xD06200", Offset = "0xD05200", VA = "0x180D06200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineStateData> StateMachineData
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x3E2430", Offset = "0x3E1430", VA = "0x1803E2430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		public int DefaultIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x504040", Offset = "0x503040", VA = "0x180504040")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x6477C0", Offset = "0x6467C0", VA = "0x1806477C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> DefaultInputSlotData
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x3D4E90", Offset = "0x3D3E90", VA = "0x1803D4E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public string RoleGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x466120", Offset = "0x465120", VA = "0x180466120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x19AC000", Offset = "0x19AB000", VA = "0x1819AC000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x19AB820", Offset = "0x19AA820", VA = "0x1819AB820")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x19AB980", Offset = "0x19AA980", VA = "0x1819AB980")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x19AA7D0", Offset = "0x19A97D0", VA = "0x1819AA7D0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x19AA830", Offset = "0x19A9830", VA = "0x1819AA830", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x19AA890", Offset = "0x19A9890", VA = "0x1819AA890", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x19AAA80", Offset = "0x19A9A80", VA = "0x1819AAA80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x19AB0D0", Offset = "0x19AA0D0", VA = "0x1819AB0D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x19AB130", Offset = "0x19AA130", VA = "0x1819AB130", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x19AA3B0", Offset = "0x19A93B0", VA = "0x1819AA3B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x19AACC0", Offset = "0x19A9CC0", VA = "0x1819AACC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class SelectorNodeData : IMessage<SelectorNodeData>, IMessage, IEquatable<SelectorNodeData>, IDeepCloneable<SelectorNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly MessageParser<SelectorNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private int evalMode_;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly FieldCodec<SelectorConfigData> _repeated_selectorConfigData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private readonly RepeatedField<SelectorConfigData> selectorConfigData_;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x19B3490", Offset = "0x19B2490", VA = "0x1819B3490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x19B33D0", Offset = "0x19B23D0", VA = "0x1819B33D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x19B34F0", Offset = "0x19B24F0", VA = "0x1819B34F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public int EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x3C0880", Offset = "0x3BF880", VA = "0x1803C0880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x44F430", Offset = "0x44E430", VA = "0x18044F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public RepeatedField<SelectorConfigData> SelectorConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x19B3370", Offset = "0x19B2370", VA = "0x1819B3370")]
		[DebuggerNonUserCode]
		public SelectorNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x19B32B0", Offset = "0x19B22B0", VA = "0x1819B32B0")]
		[DebuggerNonUserCode]
		public SelectorNodeData(SelectorNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x19B2CB0", Offset = "0x19B1CB0", VA = "0x1819B2CB0", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x19B2E10", Offset = "0x19B1E10", VA = "0x1819B2E10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x19B2D90", Offset = "0x19B1D90", VA = "0x1819B2D90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x19B2EE0", Offset = "0x19B1EE0", VA = "0x1819B2EE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x19B3030", Offset = "0x19B2030", VA = "0x1819B3030", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x19B3090", Offset = "0x19B2090", VA = "0x1819B3090", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x19B2BE0", Offset = "0x19B1BE0", VA = "0x1819B2BE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x19B2F50", Offset = "0x19B1F50", VA = "0x1819B2F50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class InternalGraphData : IMessage<InternalGraphData>, IMessage, IEquatable<InternalGraphData>, IDeepCloneable<InternalGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly MessageParser<InternalGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private int inputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private int outputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private CircuitNodeGraphData internalNodeGraph_;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public static MessageParser<InternalGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x19AE870", Offset = "0x19AD870", VA = "0x1819AE870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x19AE7B0", Offset = "0x19AD7B0", VA = "0x1819AE7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x19AE8D0", Offset = "0x19AD8D0", VA = "0x1819AE8D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public int InputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x3C0880", Offset = "0x3BF880", VA = "0x1803C0880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x44F430", Offset = "0x44E430", VA = "0x18044F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public int OutputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB50", Offset = "0x3EBB50", VA = "0x1803ECB50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x4604B0", Offset = "0x45F4B0", VA = "0x1804604B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x40F850", Offset = "0x40E850", VA = "0x18040F850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		[DebuggerNonUserCode]
		public InternalGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x19AE670", Offset = "0x19AD670", VA = "0x1819AE670")]
		[DebuggerNonUserCode]
		public InternalGraphData(InternalGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x19AE270", Offset = "0x19AD270", VA = "0x1819AE270", Slot = "9")]
		[DebuggerNonUserCode]
		public InternalGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x19AE3D0", Offset = "0x19AD3D0", VA = "0x1819AE3D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xDA6080", Offset = "0xDA5080", VA = "0x180DA6080", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InternalGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xDA61C0", Offset = "0xDA51C0", VA = "0x180DA61C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x19AE550", Offset = "0x19AD550", VA = "0x1819AE550", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xDA64F0", Offset = "0xDA54F0", VA = "0x180DA64F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x19AE180", Offset = "0x19AD180", VA = "0x1819AE180", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x19AE470", Offset = "0x19AD470", VA = "0x1819AE470", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class CircuitNodeGraphData : IMessage<CircuitNodeGraphData>, IMessage, IEquatable<CircuitNodeGraphData>, IDeepCloneable<CircuitNodeGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly MessageParser<CircuitNodeGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private ByteString nodeGraphGuid_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private bool isInternalGraph_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private CircuitNodeData rootNodeData_;

		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private static readonly FieldCodec<CircuitNodeData> _repeated_circuitNodes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly RepeatedField<CircuitNodeData> circuitNodes_;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x19AD500", Offset = "0x19AC500", VA = "0x1819AD500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x19AD440", Offset = "0x19AC440", VA = "0x1819AD440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x19AD560", Offset = "0x19AC560", VA = "0x1819AD560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public ByteString NodeGraphGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x39A550", Offset = "0x399550", VA = "0x18039A550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x19AD660", Offset = "0x19AC660", VA = "0x1819AD660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public bool IsInternalGraph
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x45E310", Offset = "0x45D310", VA = "0x18045E310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x45E320", Offset = "0x45D320", VA = "0x18045E320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public CircuitNodeData RootNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x3A09B0", Offset = "0x39F9B0", VA = "0x1803A09B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x40A270", Offset = "0x409270", VA = "0x18040A270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> CircuitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x3A09C0", Offset = "0x39F9C0", VA = "0x1803A09C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x19AD280", Offset = "0x19AC280", VA = "0x1819AD280")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x19AD360", Offset = "0x19AC360", VA = "0x1819AD360")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData(CircuitNodeGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x19ACA70", Offset = "0x19ABA70", VA = "0x1819ACA70", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x19ACB70", Offset = "0x19ABB70", VA = "0x1819ACB70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x19ACCA0", Offset = "0x19ABCA0", VA = "0x1819ACCA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x19ACD90", Offset = "0x19ABD90", VA = "0x1819ACD90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x19ACFA0", Offset = "0x19ABFA0", VA = "0x1819ACFA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x19AD000", Offset = "0x19AC000", VA = "0x1819AD000", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x19AC950", Offset = "0x19AB950", VA = "0x1819AC950", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x19ACE40", Offset = "0x19ABE40", VA = "0x1819ACE40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class CircuitNodeGraphCollectionData : IMessage<CircuitNodeGraphCollectionData>, IMessage, IEquatable<CircuitNodeGraphCollectionData>, IDeepCloneable<CircuitNodeGraphCollectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private static readonly MessageParser<CircuitNodeGraphCollectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private static readonly FieldCodec<CircuitNodeGraphData> _repeated_graphs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private readonly RepeatedField<CircuitNodeGraphData> graphs_;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphCollectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x19AC7F0", Offset = "0x19AB7F0", VA = "0x1819AC7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x19AC730", Offset = "0x19AB730", VA = "0x1819AC730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x19AC850", Offset = "0x19AB850", VA = "0x1819AC850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeGraphData> Graphs
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x39A550", Offset = "0x399550", VA = "0x18039A550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x19AC6D0", Offset = "0x19AB6D0", VA = "0x1819AC6D0")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x19AC620", Offset = "0x19AB620", VA = "0x1819AC620")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData(CircuitNodeGraphCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x19AC0E0", Offset = "0x19AB0E0", VA = "0x1819AC0E0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x19AC240", Offset = "0x19AB240", VA = "0x1819AC240", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x19AC1C0", Offset = "0x19AB1C0", VA = "0x1819AC1C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DF0", Offset = "0x3A4DF0", VA = "0x1803A5DF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x19AC3D0", Offset = "0x19AB3D0", VA = "0x1819AC3D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x19AC430", Offset = "0x19AB430", VA = "0x1819AC430", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x19AC060", Offset = "0x19AB060", VA = "0x1819AC060", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x19AC310", Offset = "0x19AB310", VA = "0x1819AC310", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class SlotData : IMessage<SlotData>, IMessage, IEquatable<SlotData>, IDeepCloneable<SlotData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private static readonly MessageParser<SlotData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int slot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private int signal_;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		public static MessageParser<SlotData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x19B7610", Offset = "0x19B6610", VA = "0x1819B7610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x19B7550", Offset = "0x19B6550", VA = "0x1819B7550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x19B7670", Offset = "0x19B6670", VA = "0x1819B7670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x3C0880", Offset = "0x3BF880", VA = "0x1803C0880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x44F430", Offset = "0x44E430", VA = "0x18044F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public int Signal
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB50", Offset = "0x3EBB50", VA = "0x1803ECB50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4604B0", Offset = "0x45F4B0", VA = "0x1804604B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		[DebuggerNonUserCode]
		public SlotData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x61E2E0", Offset = "0x61D2E0", VA = "0x18061E2E0")]
		[DebuggerNonUserCode]
		public SlotData(SlotData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x19B7330", Offset = "0x19B6330", VA = "0x1819B7330", Slot = "9")]
		[DebuggerNonUserCode]
		public SlotData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x19B73A0", Offset = "0x19B63A0", VA = "0x1819B73A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x61DEA0", Offset = "0x61CEA0", VA = "0x18061DEA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SlotData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x61DFB0", Offset = "0x61CFB0", VA = "0x18061DFB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x19B7430", Offset = "0x19B6430", VA = "0x1819B7430", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x61E1B0", Offset = "0x61D1B0", VA = "0x18061E1B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x19B7270", Offset = "0x19B6270", VA = "0x1819B7270", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x61E0F0", Offset = "0x61D0F0", VA = "0x18061E0F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class SelectorConfigData : IMessage<SelectorConfigData>, IMessage, IEquatable<SelectorConfigData>, IDeepCloneable<SelectorConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private static readonly MessageParser<SelectorConfigData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private int compareMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int compareValue_;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorConfigData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x19B2A80", Offset = "0x19B1A80", VA = "0x1819B2A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x19B29C0", Offset = "0x19B19C0", VA = "0x1819B29C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x19B2AE0", Offset = "0x19B1AE0", VA = "0x1819B2AE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		public int CompareMode
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x3C0880", Offset = "0x3BF880", VA = "0x1803C0880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x44F430", Offset = "0x44E430", VA = "0x18044F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public int CompareValue
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB50", Offset = "0x3EBB50", VA = "0x1803ECB50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x4604B0", Offset = "0x45F4B0", VA = "0x1804604B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		[DebuggerNonUserCode]
		public SelectorConfigData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x61E2E0", Offset = "0x61D2E0", VA = "0x18061E2E0")]
		[DebuggerNonUserCode]
		public SelectorConfigData(SelectorConfigData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x19B27A0", Offset = "0x19B17A0", VA = "0x1819B27A0", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorConfigData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x19B2810", Offset = "0x19B1810", VA = "0x1819B2810", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x61DEA0", Offset = "0x61CEA0", VA = "0x18061DEA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorConfigData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x61DFB0", Offset = "0x61CFB0", VA = "0x18061DFB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x19B28A0", Offset = "0x19B18A0", VA = "0x1819B28A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x61E1B0", Offset = "0x61D1B0", VA = "0x18061E1B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x19B26E0", Offset = "0x19B16E0", VA = "0x1819B26E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x61E0F0", Offset = "0x61D0F0", VA = "0x18061E0F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class StateMachineStateData : IMessage<StateMachineStateData>, IMessage, IEquatable<StateMachineStateData>, IDeepCloneable<StateMachineStateData>
	{
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private static readonly MessageParser<StateMachineStateData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private int val1_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private int val2_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int val3_;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private static readonly FieldCodec<StateMachineTransitionData> _repeated_stateTransitionData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private readonly RepeatedField<StateMachineTransitionData> stateTransitionData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int minTimeInState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private int removed_;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineStateData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x19BA650", Offset = "0x19B9650", VA = "0x1819BA650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x19BA590", Offset = "0x19B9590", VA = "0x1819BA590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x19BA6B0", Offset = "0x19B96B0", VA = "0x1819BA6B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		public int Val1
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x3C0880", Offset = "0x3BF880", VA = "0x1803C0880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x44F430", Offset = "0x44E430", VA = "0x18044F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[DebuggerNonUserCode]
		public int Val2
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB50", Offset = "0x3EBB50", VA = "0x1803ECB50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x4604B0", Offset = "0x45F4B0", VA = "0x1804604B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[DebuggerNonUserCode]
		public int Val3
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x405FC0", Offset = "0x404FC0", VA = "0x180405FC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x406100", Offset = "0x405100", VA = "0x180406100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineTransitionData> StateTransitionData
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3A09B0", Offset = "0x39F9B0", VA = "0x1803A09B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3E4FF0", Offset = "0x3E3FF0", VA = "0x1803E4FF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x409FD0", Offset = "0x408FD0", VA = "0x180409FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public int Removed
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x3BFF40", Offset = "0x3BEF40", VA = "0x1803BFF40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x3BFED0", Offset = "0x3BEED0", VA = "0x1803BFED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x19BA460", Offset = "0x19B9460", VA = "0x1819BA460")]
		[DebuggerNonUserCode]
		public StateMachineStateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x19BA4C0", Offset = "0x19B94C0", VA = "0x1819BA4C0")]
		[DebuggerNonUserCode]
		public StateMachineStateData(StateMachineStateData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x19B9C90", Offset = "0x19B8C90", VA = "0x1819B9C90", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineStateData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x19B9E30", Offset = "0x19B8E30", VA = "0x1819B9E30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x19B9D90", Offset = "0x19B8D90", VA = "0x1819B9D90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineStateData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x19B9F20", Offset = "0x19B8F20", VA = "0x1819B9F20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x19BA140", Offset = "0x19B9140", VA = "0x1819BA140", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x19BA1A0", Offset = "0x19B91A0", VA = "0x1819BA1A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x19B9B00", Offset = "0x19B8B00", VA = "0x1819B9B00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x19B9FF0", Offset = "0x19B8FF0", VA = "0x1819B9FF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class StateMachineTransitionData : IMessage<StateMachineTransitionData>, IMessage, IEquatable<StateMachineTransitionData>, IDeepCloneable<StateMachineTransitionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private static readonly MessageParser<StateMachineTransitionData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private int inputIndex_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private int stateIndex_;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineTransitionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x19BAB50", Offset = "0x19B9B50", VA = "0x1819BAB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x19BAA90", Offset = "0x19B9A90", VA = "0x1819BAA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x19BABB0", Offset = "0x19B9BB0", VA = "0x1819BABB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		[DebuggerNonUserCode]
		public int InputIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x3C0880", Offset = "0x3BF880", VA = "0x1803C0880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x44F430", Offset = "0x44E430", VA = "0x18044F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		public int StateIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB50", Offset = "0x3EBB50", VA = "0x1803ECB50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x4604B0", Offset = "0x45F4B0", VA = "0x1804604B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x61E2E0", Offset = "0x61D2E0", VA = "0x18061E2E0")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData(StateMachineTransitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x19BA870", Offset = "0x19B9870", VA = "0x1819BA870", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x19BA8E0", Offset = "0x19B98E0", VA = "0x1819BA8E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x61DEA0", Offset = "0x61CEA0", VA = "0x18061DEA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineTransitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x61DFB0", Offset = "0x61CFB0", VA = "0x18061DFB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x19BA970", Offset = "0x19B9970", VA = "0x1819BA970", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x61E1B0", Offset = "0x61D1B0", VA = "0x18061E1B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x19BA7B0", Offset = "0x19B97B0", VA = "0x1819BA7B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x61E0F0", Offset = "0x61D0F0", VA = "0x18061E0F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class NodeTransformDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x19AEFA0", Offset = "0x19ADFA0", VA = "0x1819AEFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x19AE9D0", Offset = "0x19AD9D0", VA = "0x1819AE9D0")]
		static NodeTransformDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class NodeTransformData : IMessage<NodeTransformData>, IMessage, IEquatable<NodeTransformData>, IDeepCloneable<NodeTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private static readonly MessageParser<NodeTransformData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private Vector3Data position_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private Vector3Data rotation_;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		public static MessageParser<NodeTransformData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x19AF550", Offset = "0x19AE550", VA = "0x1819AF550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x19AF490", Offset = "0x19AE490", VA = "0x1819AF490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x19AF5B0", Offset = "0x19AE5B0", VA = "0x1819AF5B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public Vector3Data Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x39A550", Offset = "0x399550", VA = "0x18039A550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x3C0890", Offset = "0x3BF890", VA = "0x1803C0890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public Vector3Data Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x40F850", Offset = "0x40E850", VA = "0x18040F850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		[DebuggerNonUserCode]
		public NodeTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x19AF420", Offset = "0x19AE420", VA = "0x1819AF420")]
		[DebuggerNonUserCode]
		public NodeTransformData(NodeTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x19AF0C0", Offset = "0x19AE0C0", VA = "0x1819AF0C0", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x19AF160", Offset = "0x19AE160", VA = "0x1819AF160", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xCECC40", Offset = "0xCEBC40", VA = "0x180CECC40", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xCECD00", Offset = "0xCEBD00", VA = "0x180CECD00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x19AF300", Offset = "0x19AE300", VA = "0x1819AF300", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xCED010", Offset = "0xCEC010", VA = "0x180CED010", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x19AF000", Offset = "0x19AE000", VA = "0x1819AF000", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x19AF210", Offset = "0x19AE210", VA = "0x1819AF210", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public static class Vector3DataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x19BE850", Offset = "0x19BD850", VA = "0x1819BE850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x19BE4C0", Offset = "0x19BD4C0", VA = "0x1819BE4C0")]
		static Vector3DataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private static readonly MessageParser<Vector3Data> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private float x_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private float y_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x19BEB90", Offset = "0x19BDB90", VA = "0x1819BEB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x19BEAD0", Offset = "0x19BDAD0", VA = "0x1819BEAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x19BEBF0", Offset = "0x19BDBF0", VA = "0x1819BEBF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x542EE0", Offset = "0x541EE0", VA = "0x180542EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x543170", Offset = "0x542170", VA = "0x180543170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x53DBC0", Offset = "0x53CBC0", VA = "0x18053DBC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x53DBB0", Offset = "0x53CBB0", VA = "0x18053DBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x3CD8C0", Offset = "0x3CC8C0", VA = "0x1803CD8C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x53DB00", Offset = "0x53CB00", VA = "0x18053DB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x63CFF0", Offset = "0x63BFF0", VA = "0x18063CFF0")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x19BE8B0", Offset = "0x19BD8B0", VA = "0x1819BE8B0", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x19BE920", Offset = "0x19BD920", VA = "0x1819BE920", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x63CAC0", Offset = "0x63BAC0", VA = "0x18063CAC0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x63CBF0", Offset = "0x63BBF0", VA = "0x18063CBF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x19BE9B0", Offset = "0x19BD9B0", VA = "0x1819BE9B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x63CE70", Offset = "0x63BE70", VA = "0x18063CE70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x63CA10", Offset = "0x63BA10", VA = "0x18063CA10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x63CD90", Offset = "0x63BD90", VA = "0x18063CD90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
namespace RecRoom.Circuits.PlayerStats
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public enum CircuitPlayerStat
	{
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		Player_Health = 0,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		Player_Shield = 1,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		PlayerStat_1 = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		PlayerStat_2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		PlayerStat_3 = 1002,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		PlayerStat_4 = 1003,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		PlayerStat_5 = 1004,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		PlayerStat_6 = 1005
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public static class FriendlyCircuitPlayerStats
	{
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private static Dictionary<string, int> friendlyCircuitPlayerStatsDict;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public static Dictionary<string, int> FriendlyCircuitPlayerStatsDict
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x1E70A80", Offset = "0x1E6FA80", VA = "0x181E70A80")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CircuitNodeUuid("FC94A1CD-DD7E-4229-92DF-95991A9E6369")]
	public class PlayerGetStatNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public delegate int GetPlayerStatFunction(CircuitPlayerStat stat, int playerId);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private int masterLastPlayerStatSignal;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x897F80", Offset = "0x896F80", VA = "0x180897F80")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x1E75980", Offset = "0x1E74980", VA = "0x181E75980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event GetPlayerStatFunction GetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x1E75840", Offset = "0x1E74840", VA = "0x181E75840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x1E758E0", Offset = "0x1E748E0", VA = "0x181E758E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1E757C0", Offset = "0x1E747C0", VA = "0x181E757C0")]
		public PlayerGetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E755E0", Offset = "0x1E745E0", VA = "0x181E755E0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1E75450", Offset = "0x1E74450", VA = "0x181E75450")]
		private int GetStatSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1E75570", Offset = "0x1E74570", VA = "0x181E75570", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1E75240", Offset = "0x1E74240", VA = "0x181E75240", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E752B0", Offset = "0x1E742B0", VA = "0x181E752B0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E753F0", Offset = "0x1E743F0", VA = "0x181E753F0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E75310", Offset = "0x1E74310", VA = "0x181E75310", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E75520", Offset = "0x1E74520", VA = "0x181E75520", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x19B0300", Offset = "0x19AF300", VA = "0x1819B0300", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E75620", Offset = "0x1E74620", VA = "0x181E75620", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CircuitNodeUuid("5A15E563-2F73-41B6-9CDF-6C9FB065A034")]
	public class PlayerSetStatNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate void SetPlayerStatFunction(CircuitPlayerStat stat, int playerId, int signal);

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x897F80", Offset = "0x896F80", VA = "0x180897F80")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E75980", Offset = "0x1E74980", VA = "0x181E75980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event SetPlayerStatFunction SetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x1E77FC0", Offset = "0x1E76FC0", VA = "0x181E77FC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E78060", Offset = "0x1E77060", VA = "0x181E78060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E77F60", Offset = "0x1E76F60", VA = "0x181E77F60")]
		public PlayerSetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E77CB0", Offset = "0x1E76CB0", VA = "0x181E77CB0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E77C90", Offset = "0x1E76C90", VA = "0x181E77C90")]
		private void PostEvalSetPlayerStat(CircuitPlayerStat stat, int playerId, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E77B10", Offset = "0x1E76B10", VA = "0x181E77B10", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E77C50", Offset = "0x1E76C50", VA = "0x181E77C50", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E77B70", Offset = "0x1E76B70", VA = "0x181E77B70", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E75520", Offset = "0x1E74520", VA = "0x181E75520", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x19B0300", Offset = "0x19AF300", VA = "0x1819B0300", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E77DB0", Offset = "0x1E76DB0", VA = "0x181E77DB0", Slot = "26")]
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
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private int masterLastScoreSignal;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event GetTeamScoreFunction GetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x1E71040", Offset = "0x1E70040", VA = "0x181E71040")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x1E710E0", Offset = "0x1E700E0", VA = "0x181E710E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E70FC0", Offset = "0x1E6FFC0", VA = "0x181E70FC0")]
		public GameGetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E70EA0", Offset = "0x1E6FEA0", VA = "0x181E70EA0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E70D70", Offset = "0x1E6FD70", VA = "0x181E70D70")]
		private int GetScoreSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E70E30", Offset = "0x1E6FE30", VA = "0x181E70E30", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E70C40", Offset = "0x1E6FC40", VA = "0x181E70C40", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E70CB0", Offset = "0x1E6FCB0", VA = "0x181E70CB0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E70D10", Offset = "0x1E6FD10", VA = "0x181E70D10", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event SetTeamScoreFunction SetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E71510", Offset = "0x1E70510", VA = "0x181E71510")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E715B0", Offset = "0x1E705B0", VA = "0x181E715B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E714B0", Offset = "0x1E704B0", VA = "0x181E714B0")]
		public GameSetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E71240", Offset = "0x1E70240", VA = "0x181E71240", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E71220", Offset = "0x1E70220", VA = "0x181E71220")]
		private void PostEvalSetGameScoreStat(int teamId, int score, bool isWinner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E71180", Offset = "0x1E70180", VA = "0x181E71180", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E711E0", Offset = "0x1E701E0", VA = "0x181E711E0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
}
namespace RecRoom.Circuits.Traversal
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Flags]
	public enum DFSType
	{
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		DirectedForward = 1,
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		DirectedBackward = 2,
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		Undirected = 3
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Flags]
	public enum LinkTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		NormalToNormal = 1,
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		NormalToVirtual = 2,
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		VirtualToNormal = 4,
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		RootToVirtual = 8,
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		RootToNormal = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	internal struct TopologicStackEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CircuitNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public bool IsParent;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public static class GraphTraversal
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class <DFS>d__4 : IEnumerable<CircuitNode>, IEnumerable, IEnumerator<CircuitNode>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			private CircuitNode <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			private CircuitNode root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public CircuitNode <>3__root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			private DFSType dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public DFSType <>3__dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private LinkTypes linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public LinkTypes <>3__linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private Stack<CircuitNode> <stack>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			private HashSet<CircuitNode> <visited>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			private CircuitNode <current>5__4;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			CircuitNode IEnumerator<CircuitNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x39F980", Offset = "0x39E980", VA = "0x18039F980", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x6700D0", Offset = "0x66F0D0", VA = "0x1806700D0")]
			[DebuggerHidden]
			public <DFS>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x39B3A0", Offset = "0x39A3A0", VA = "0x18039B3A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x19BBA50", Offset = "0x19BAA50", VA = "0x1819BBA50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x19BC030", Offset = "0x19BB030", VA = "0x1819BC030", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x19BBF90", Offset = "0x19BAF90", VA = "0x1819BBF90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<CircuitNode> IEnumerable<CircuitNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x19BBF90", Offset = "0x19BAF90", VA = "0x1819BBF90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x19AD750", Offset = "0x19AC750", VA = "0x1819AD750")]
		public static HashSet<CircuitNode> DFSCopy(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x19AD810", Offset = "0x19AC810", VA = "0x1819AD810")]
		[IteratorStateMachine(typeof(<DFS>d__4))]
		public static IEnumerable<CircuitNode> DFS(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x19ADBC0", Offset = "0x19ACBC0", VA = "0x1819ADBC0")]
		public static List<CircuitNode> TopologicSort(CircuitNode root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x19ADBA0", Offset = "0x19ACBA0", VA = "0x1819ADBA0")]
		private static bool ShouldFollowLink(CircuitLink link, LinkTypes linkTypesToFollow)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x19AD8A0", Offset = "0x19AC8A0", VA = "0x1819AD8A0")]
		public static LinkTypes FindLinkType(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(LinkTypes);
		}
	}
}
namespace RecRoom.Circuits.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public static class ByteStringExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x19A66D0", Offset = "0x19A56D0", VA = "0x1819A66D0")]
		public static Guid ToGuid(this ByteString bytes)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x19A6670", Offset = "0x19A5670", VA = "0x1819A6670")]
		public static ByteString ToByteString(this Guid guid)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum CircuitLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		Error
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public static class CircuitDebug
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public delegate void LogEvent(CircuitLogLevel level, string message);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public delegate void LogExceptionEvent(Exception e, string message);

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public static event LogEvent OnLogEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x19A6A70", Offset = "0x19A5A70", VA = "0x1819A6A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x19A6BD0", Offset = "0x19A5BD0", VA = "0x1819A6BD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public static event LogExceptionEvent OnLogExceptionEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x19A6B20", Offset = "0x19A5B20", VA = "0x1819A6B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x19A6C80", Offset = "0x19A5C80", VA = "0x1819A6C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x19A6830", Offset = "0x19A5830", VA = "0x1819A6830")]
		public static void LogException(Exception e, [Optional] string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x19A68D0", Offset = "0x19A58D0", VA = "0x1819A68D0")]
		public static void Log(CircuitLogLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x19A69F0", Offset = "0x19A59F0", VA = "0x1819A69F0")]
		public static void NodeLog(int nodeId, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x19A6970", Offset = "0x19A5970", VA = "0x1819A6970")]
		public static void NodeLogFormat(int nodeId, CircuitLogLevel CircuitLogLevel, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x19A67B0", Offset = "0x19A57B0", VA = "0x1819A67B0")]
		public static void GraphLog(Guid graphGuid, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal static class NodeEventUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2F7ED80", Offset = "0x2F7DD80", VA = "0x182F7ED80")]
		internal static void SafeInvoke(this CircuitNode.NodeLifecycleEvent nodeLifecycleEvent, CircuitNode nodeArg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2F7ECE0", Offset = "0x2F7DCE0", VA = "0x182F7ECE0")]
		internal static void SafeInvoke(this CircuitNode.NodeConnectionChanged nodeConnectionEvent, CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal static class RuntimeAssert
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EE90", Offset = "0x2F7DE90", VA = "0x182F7EE90")]
		public static void Assert(bool condition, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EE00", Offset = "0x2F7DE00", VA = "0x182F7EE00")]
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
