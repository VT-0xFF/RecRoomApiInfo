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
			[Cpp2IlInjected.Address(RVA = "0x1E217F0", Offset = "0x1E1FDF0", VA = "0x181E217F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E21740", Offset = "0x1E1FD40", VA = "0x181E21740")]
		public CircuitLink(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1E21450", Offset = "0x1E1FA50", VA = "0x181E21450")]
		public CircuitLinkData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E21250", Offset = "0x1E1F850", VA = "0x181E21250", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E213A0", Offset = "0x1E1F9A0", VA = "0x181E213A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E21500", Offset = "0x1E1FB00", VA = "0x181E21500", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CF2E0", Offset = "0x3CD8E0", VA = "0x1803CF2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E269C0", Offset = "0x1E24FC0", VA = "0x181E269C0")]
		public CircuitNodeUuidAttribute(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E26950", Offset = "0x1E24F50", VA = "0x181E26950")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E316D0", Offset = "0x1E2FCD0", VA = "0x181E316D0", Slot = "4")]
		public bool Equals(InputSlot x, InputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E316F0", Offset = "0x1E2FCF0", VA = "0x181E316F0", Slot = "5")]
		public int GetHashCode(InputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		public InputSlotComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class OutputSlotComparer : IEqualityComparer<OutputSlot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1E316D0", Offset = "0x1E2FCD0", VA = "0x181E316D0", Slot = "4")]
		public bool Equals(OutputSlot x, OutputSlot y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E316F0", Offset = "0x1E2FCF0", VA = "0x181E316F0", Slot = "5")]
		public int GetHashCode(OutputSlot obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x3386E0", Offset = "0x336CE0", VA = "0x1803386E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal virtual bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3386E0", Offset = "0x336CE0", VA = "0x1803386E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal virtual bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3386E0", Offset = "0x336CE0", VA = "0x1803386E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal virtual bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3386E0", Offset = "0x336CE0", VA = "0x1803386E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal virtual bool RequiresConnectionToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C890", Offset = "0x1E2AE90", VA = "0x181E2C890", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal virtual bool IsConnectedToRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C790", Offset = "0x1E2AD90", VA = "0x181E2C790", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		internal virtual bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3386E0", Offset = "0x336CE0", VA = "0x1803386E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CircuitNode PairedNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3C0B60", Offset = "0x3BF160", VA = "0x1803C0B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HasConnectedInputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C630", Offset = "0x1E2AC30", VA = "0x181E2C630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal bool UsesAnyDefaultInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CA40", Offset = "0x1E2B040", VA = "0x181E2CA40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HasConnectedOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C740", Offset = "0x1E2AD40", VA = "0x181E2C740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D40", Offset = "0x3CF340", VA = "0x1803D0D40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D50", Offset = "0x3CF350", VA = "0x1803D0D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x33A970", Offset = "0x338F70", VA = "0x18033A970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x33A990", Offset = "0x338F90", VA = "0x18033A990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public virtual int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x802F20", Offset = "0x801520", VA = "0x180802F20", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C9E0", Offset = "0x1E2AFE0", VA = "0x181E2C9E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NodeMetadata NodeMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xFF7320", Offset = "0xFF5920", VA = "0x180FF7320")]
			[CompilerGenerated]
			get
			{
				return default(NodeMetadata);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xFF7340", Offset = "0xFF5940", VA = "0x180FF7340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public CircuitNodeGraph NodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x374EF0", Offset = "0x3734F0", VA = "0x180374EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA34840", Offset = "0xA32E40", VA = "0x180A34840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xD6A4E0", Offset = "0xD68AE0", VA = "0x180D6A4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static int NodeCount
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C820", Offset = "0x1E2AE20", VA = "0x181E2C820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static InputMetadata[] AllSlotsInputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C2A0", Offset = "0x1E2A8A0", VA = "0x181E2C2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static OutputMetadata[] AllSlotsOutputMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C460", Offset = "0x1E2AA60", VA = "0x181E2C460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NodeModifiedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C200", Offset = "0x1E2A800", VA = "0x181E2C200")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CC10", Offset = "0x1E2B210", VA = "0x181E2CC10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NodeDeserializedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C160", Offset = "0x1E2A760", VA = "0x181E2C160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CB70", Offset = "0x1E2B170", VA = "0x181E2CB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E29F90", Offset = "0x1E28590", VA = "0x181E29F90")]
		public static int NewNodeId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BA40", Offset = "0x1E2A040", VA = "0x181E2BA40")]
		internal static int SetPossibleMaxId(int newPossibleMax)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A5C0", Offset = "0x1E28BC0", VA = "0x181E2A5C0")]
		public static void ResetMaxNodeId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E299D0", Offset = "0x1E27FD0", VA = "0x181E299D0")]
		public static long GetMaxNodeId()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A0C0", Offset = "0x1E286C0", VA = "0x181E2A0C0")]
		internal static void OverrideMaxNodeId(long overrideValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A6C0", Offset = "0x1E28CC0", VA = "0x181E2A6C0")]
		private static void SendNodeDestroyedEvent(CircuitNode node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A730", Offset = "0x1E28D30", VA = "0x181E2A730")]
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
		[Cpp2IlInjected.Address(RVA = "0x33A970", Offset = "0x338F70", VA = "0x18033A970", Slot = "15")]
		protected virtual string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BED0", Offset = "0x1E2A4D0", VA = "0x181E2BED0")]
		public CircuitNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A1E0", Offset = "0x1E287E0", VA = "0x181E2A1E0")]
		protected void ReconstructNodeMetadata()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AC40", Offset = "0x1E29240", VA = "0x181E2AC40", Slot = "16")]
		public virtual CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E29B90", Offset = "0x1E28190", VA = "0x181E29B90", Slot = "17")]
		internal virtual void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E27E70", Offset = "0x1E26470", VA = "0x181E27E70")]
		public void CopySettings(CircuitNodeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1E27F00", Offset = "0x1E26500", VA = "0x181E27F00")]
		public void DeserializeLinks(CircuitNodeData data, Dictionary<int, int> nodeIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AC30", Offset = "0x1E29230", VA = "0x181E2AC30", Slot = "18")]
		internal virtual void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E28940", Offset = "0x1E26F40", VA = "0x181E28940", Slot = "19")]
		internal virtual void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "20")]
		internal virtual void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "21")]
		internal virtual void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AA40", Offset = "0x1E29040", VA = "0x181E2AA40")]
		private void SerializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1E28710", Offset = "0x1E26D10", VA = "0x181E28710")]
		private void DeserializeOutputValues(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B6F0", Offset = "0x1E29CF0", VA = "0x181E2B6F0")]
		internal void SetNodeGraph(CircuitNodeGraph newNodeGraph, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E276A0", Offset = "0x1E25CA0", VA = "0x181E276A0")]
		internal static bool ConnectNodes(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A7A0", Offset = "0x1E28DA0", VA = "0x181E2A7A0")]
		private static void SendNodesConnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A8F0", Offset = "0x1E28EF0", VA = "0x181E2A8F0")]
		private static void SendNodesDisconnectedEvent(CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E26A10", Offset = "0x1E25010", VA = "0x181E26A10")]
		private static void AddLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E297D0", Offset = "0x1E27DD0", VA = "0x181E297D0")]
		internal static bool FormsLoop(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1E27D00", Offset = "0x1E26300", VA = "0x181E27D00")]
		public bool ConnectToMyInput(CircuitNode sourceNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1E26B00", Offset = "0x1E25100", VA = "0x181E26B00")]
		protected bool CanConnectInput(CircuitNode newSourceNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1E27DC0", Offset = "0x1E263C0", VA = "0x181E27DC0")]
		public bool ConnectToMyOutput(CircuitNode destNode, InputSlot inputSlot = InputSlot.R, OutputSlot outputSlot = OutputSlot.R, bool skipMerge = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1E26BD0", Offset = "0x1E251D0", VA = "0x181E26BD0")]
		protected bool CanConnectOutput(InputSlot inputSlot, OutputSlot outputSlot, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BC90", Offset = "0x1E2A290", VA = "0x181E2BC90")]
		protected bool SlotsCanConnect(InputSlot inputSlot, OutputSlot outputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1E28D10", Offset = "0x1E27310", VA = "0x181E28D10")]
		public void DisconnectInput(InputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1E28950", Offset = "0x1E26F50", VA = "0x181E28950", Slot = "22")]
		public virtual void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1E294F0", Offset = "0x1E27AF0", VA = "0x181E294F0")]
		public void DisconnectOutput(OutputSlot slot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1E28DB0", Offset = "0x1E273B0", VA = "0x181E28DB0")]
		protected static void DisconnectNodeLink(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A330", Offset = "0x1E28930", VA = "0x181E2A330")]
		private static void RemoveLinks(CircuitLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A440", Offset = "0x1E28A40", VA = "0x181E2A440")]
		private static bool RemoveOutputLink(CircuitNode node, CircuitLink link)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A270", Offset = "0x1E28870", VA = "0x181E2A270")]
		private static bool RemoveInputSlot(CircuitNode node, InputSlot inputSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1E26FC0", Offset = "0x1E255C0", VA = "0x181E26FC0")]
		private static bool CheckForDisconnectedGraph(CircuitNode sourceNode, CircuitNode destNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1E29680", Offset = "0x1E27C80", VA = "0x181E29680")]
		internal void EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "23")]
		internal virtual void PostEvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1E29B30", Offset = "0x1E28130", VA = "0x181E29B30")]
		public bool HasMomentaryOutputs()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1E27500", Offset = "0x1E25B00", VA = "0x181E27500")]
		public void ClearMomentaryOutputs(int currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "24")]
		protected virtual void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BDB0", Offset = "0x1E2A3B0", VA = "0x181E2BDB0", Slot = "25")]
		protected virtual void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1E275F0", Offset = "0x1E25BF0", VA = "0x181E275F0")]
		protected void ClearOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E298B0", Offset = "0x1E27EB0", VA = "0x181E298B0")]
		public int GetInputSignal(InputSlot inputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E29990", Offset = "0x1E27F90", VA = "0x181E29990")]
		public int GetLastOutputSignalTimeStamp(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E29AF0", Offset = "0x1E280F0", VA = "0x181E29AF0")]
		public int GetOutputSignal(OutputSlot outputSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B6B0", Offset = "0x1E29CB0", VA = "0x181E2B6B0")]
		protected void SetContinuousOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B6D0", Offset = "0x1E29CD0", VA = "0x181E2B6D0")]
		protected void SetMomentaryOutput(OutputSlot outputSlot, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B8A0", Offset = "0x1E29EA0", VA = "0x181E2B8A0")]
		private void SetOutput(OutputSlot outputSlot, int val, bool isMomentary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BBD0", Offset = "0x1E2A1D0", VA = "0x181E2BBD0")]
		private bool SlotDirtiesGraph(OutputSlot outputSlot, int val, bool isMomentary)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E26DD0", Offset = "0x1E253D0", VA = "0x181E26DD0")]
		private void ChangeDefaultInputValue(SlotData slotData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E29F40", Offset = "0x1E28540", VA = "0x181E29F40")]
		public void ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x44D1A0", Offset = "0x44B7A0", VA = "0x18044D1A0")]
		public void SendDeserializedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BCB0", Offset = "0x1E2A2B0", VA = "0x181E2BCB0", Slot = "26")]
		protected virtual void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E27330", Offset = "0x1E25930", VA = "0x181E27330")]
		internal static void ClearAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E29740", Offset = "0x1E27D40", VA = "0x181E29740")]
		public static CircuitNode Find(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7013D0", Offset = "0x6FF9D0", VA = "0x1807013D0")]
		public static int BoolToSignal(bool value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xF3D080", Offset = "0xF3B680", VA = "0x180F3D080")]
		public static bool SignalToBool(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E272B0", Offset = "0x1E258B0", VA = "0x181E272B0")]
		public static int ClampSignal(int value, int min, int max)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class DictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1990520", Offset = "0x198EB20", VA = "0x181990520")]
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
				[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x3C0B50", Offset = "0x3BF150", VA = "0x1803C0B50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x3C0B60", Offset = "0x3BF160", VA = "0x1803C0B60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
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
				[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x3C0B50", Offset = "0x3BF150", VA = "0x1803C0B50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public Dictionary<int, int> NodeMapping
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x3C0B60", Offset = "0x3BF160", VA = "0x1803C0B60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x33A970", Offset = "0x338F70", VA = "0x18033A970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x33A990", Offset = "0x338F90", VA = "0x18033A990")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NodeGraphDirty
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4BBD30", Offset = "0x4BA330", VA = "0x1804BBD30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x4BBD50", Offset = "0x4BA350", VA = "0x1804BBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x32CF10", Offset = "0x32B510", VA = "0x18032CF10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3D3F70", Offset = "0x3D2570", VA = "0x1803D3F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		internal static event UpdateGraph TimeUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1E26750", Offset = "0x1E24D50", VA = "0x181E26750")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1E26850", Offset = "0x1E24E50", VA = "0x181E26850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E266C0", Offset = "0x1E24CC0", VA = "0x181E266C0")]
		internal CircuitNodeGraph(bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E26690", Offset = "0x1E24C90", VA = "0x181E26690")]
		public CircuitNodeGraph(Guid guid, bool isInternalGraph = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E264F0", Offset = "0x1E24AF0", VA = "0x181E264F0")]
		private CircuitNodeGraph(Guid guid, bool isInternalGraph, bool createRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1E26260", Offset = "0x1E24860", VA = "0x181E26260")]
		public static void Update(int networkTimeMilliseconds, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E244F0", Offset = "0x1E22AF0", VA = "0x181E244F0")]
		private void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1E243A0", Offset = "0x1E229A0", VA = "0x181E243A0")]
		public void DestroySelfAndNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E21D60", Offset = "0x1E20360", VA = "0x181E21D60")]
		internal void AddNode(CircuitNode circuitNode, bool skipMerge = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E255E0", Offset = "0x1E23BE0", VA = "0x181E255E0")]
		internal bool RemoveNode(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E21FC0", Offset = "0x1E205C0", VA = "0x181E21FC0")]
		internal bool ConnectToRootForSingleEvaluate(CircuitNode circuitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E24580", Offset = "0x1E22B80", VA = "0x181E24580")]
		public List<CircuitNode> Evaluate(bool isMasterClient)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1E21F80", Offset = "0x1E20580", VA = "0x181E21F80", Slot = "4")]
		public int CompareTo(CircuitNodeGraph other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E25F30", Offset = "0x1E24530", VA = "0x181E25F30")]
		public static byte[] SerializeRuntimeState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E238E0", Offset = "0x1E21EE0", VA = "0x181E238E0")]
		public static void DeserializeRuntimeState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E25C00", Offset = "0x1E24200", VA = "0x181E25C00")]
		public static byte[] SerializePostEvaluateState()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E235B0", Offset = "0x1E21BB0", VA = "0x181E235B0")]
		public static void DeserializePostEvaluateState(byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E25150", Offset = "0x1E23750", VA = "0x181E25150")]
		public static CircuitNodeGraphCollectionData PersistAll([Optional] IList<int> inactiveIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E24300", Offset = "0x1E22900", VA = "0x181E24300")]
		public static void DestroyAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1E231B0", Offset = "0x1E217B0", VA = "0x181E231B0")]
		public static void DeserializeAll(CircuitNodeGraphCollectionData data, out Dictionary<int, int> nodeIdMappings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E25330", Offset = "0x1E23930", VA = "0x181E25330")]
		public CircuitNodeGraphData Persist()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1E23C10", Offset = "0x1E22210", VA = "0x181E23C10")]
		public static CircuitNodeGraph Deserialize(CircuitNodeGraphData data, bool reassignNodeIds, out Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1E22050", Offset = "0x1E20650", VA = "0x181E22050")]
		public static CircuitNodeGraphCopy CopyNodesToNewGraphs(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E256E0", Offset = "0x1E23CE0", VA = "0x181E256E0")]
		public static SerializedCircuitNodeGraphCopy SerializeNodesAsNewGraph(List<CircuitNode> nodesToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E24C10", Offset = "0x1E23210", VA = "0x181E24C10")]
		public static CircuitNodeGraph MergeGraphs(CircuitNode nodeA, CircuitNode nodeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E24E70", Offset = "0x1E23470", VA = "0x181E24E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1859E10", Offset = "0x1858410", VA = "0x181859E10")]
		public static OutputSlot InputSlotToOutputSlot(InputSlot input)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1859E10", Offset = "0x1858410", VA = "0x181859E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(BooleanModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F260", Offset = "0x1C3D860", VA = "0x181C3F260")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E20A30", Offset = "0x1E1F030", VA = "0x181E20A30")]
		public static string GetModeSymbol(BooleanModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1E21120", Offset = "0x1E1F720", VA = "0x181E21120")]
		public BooleanNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E20CD0", Offset = "0x1E1F2D0", VA = "0x181E20CD0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E20620", Offset = "0x1E1EC20", VA = "0x181E20620")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E203E0", Offset = "0x1E1E9E0", VA = "0x181E203E0")]
		private bool CalcAndOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E20500", Offset = "0x1E1EB00", VA = "0x181E20500")]
		private bool CalcOrOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E20880", Offset = "0x1E1EE80", VA = "0x181E20880")]
		private void FetchInputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E209A0", Offset = "0x1E1EFA0", VA = "0x181E209A0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E20B70", Offset = "0x1E1F170", VA = "0x181E20B70", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E20AB0", Offset = "0x1E1F0B0", VA = "0x181E20AB0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E20C10", Offset = "0x1E1F210", VA = "0x181E20C10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1E20C80", Offset = "0x1E1F280", VA = "0x181E20C80", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1E20DA0", Offset = "0x1E1F3A0", VA = "0x181E20DA0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CircuitNodeUuid("B7BA1A4B-EA04-496F-B8B6-A2FB7C4A42B9")]
	public class ContinuousSourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E740", Offset = "0x1E2CD40", VA = "0x181E2E740")]
		public ContinuousSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B6B0", Offset = "0x1E29CB0", VA = "0x181E2B6B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E2ED20", Offset = "0x1E2D320", VA = "0x181E2ED20")]
		public CustomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E850", Offset = "0x1E2CE50", VA = "0x181E2E850", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EC10", Offset = "0x1E2D210", VA = "0x181E2EC10")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B6D0", Offset = "0x1E29CD0", VA = "0x181E2B6D0", Slot = "27")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AF50", Offset = "0x1C39550", VA = "0x181C3AF50", Slot = "28")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x379E00", Offset = "0x378400", VA = "0x180379E00", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E2ECD0", Offset = "0x1E2D2D0", VA = "0x181E2ECD0", Slot = "31")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x340FD0", Offset = "0x33F5D0", VA = "0x180340FD0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E7C0", Offset = "0x1E2CDC0", VA = "0x181E2E7C0", Slot = "29")]
		public void AddUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EC40", Offset = "0x1E2D240", VA = "0x181E2EC40", Slot = "30")]
		public void RemoveUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E2ECE0", Offset = "0x1E2D2E0", VA = "0x181E2ECE0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E2ECF0", Offset = "0x1E2D2F0", VA = "0x181E2ECF0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E910", Offset = "0x1E2CF10", VA = "0x181E2E910")]
		private void FireEventIfNeeded(bool addReset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CircuitNodeUuid("53219714-E7BB-4950-BBB3-852A7EF196F8")]
	public class GameSetStateNode : PostEvalActionNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private static InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action StartGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1E30D50", Offset = "0x1E2F350", VA = "0x181E30D50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1E30E90", Offset = "0x1E2F490", VA = "0x181E30E90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action EndGame
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1E30CB0", Offset = "0x1E2F2B0", VA = "0x181E30CB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1E30DF0", Offset = "0x1E2F3F0", VA = "0x181E30DF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1E30990", Offset = "0x1E2EF90", VA = "0x181E30990", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E309F0", Offset = "0x1E2EFF0", VA = "0x181E309F0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E30C50", Offset = "0x1E2F250", VA = "0x181E30C50")]
		public GameSetStateNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E30A50", Offset = "0x1E2F050", VA = "0x181E30A50", Slot = "24")]
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
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			Defaults
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate void ChangeTagsForObjectFunc(int objectId);

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public const string MODE_ARG = "mode";

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private const string nodeDescription = "Change Tags on Object";

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private ChangeModes changeMode;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ChangeModes ChangeMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(ChangeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F260", Offset = "0x1C3D860", VA = "0x181C3F260")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ChangeTagsForObjectFunc ChangeTagsForObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E33000", Offset = "0x1E31600", VA = "0x181E33000")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1E330A0", Offset = "0x1E316A0", VA = "0x181E330A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E32F80", Offset = "0x1E31580", VA = "0x181E32F80")]
		public ObjectSetTagsNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E32BD0", Offset = "0x1E311D0", VA = "0x181E32BD0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E32B70", Offset = "0x1E31170", VA = "0x181E32B70", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1E32C40", Offset = "0x1E31240", VA = "0x181E32C40", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1E32D90", Offset = "0x1E31390", VA = "0x181E32D90", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1E32CA0", Offset = "0x1E312A0", VA = "0x181E32CA0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E20C10", Offset = "0x1E1F210", VA = "0x181E20C10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E20C80", Offset = "0x1E1F280", VA = "0x181E20C80", Slot = "16")]
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
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			AddPlayerRole,
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			RemovePlayerRole,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			PlayerHasRole,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			PlayerRoleChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate void PlayerModifyRoleFunc(int playerId, Guid roleGuid);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool PlayerHasRoleFunc(int playerId, Guid roleGuid);

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly OutputMetadata[] PlayerHasRoleOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly OutputMetadata[] PlayerRoleChangedOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static readonly InputMetadata[] PlayerHasRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly InputMetadata[] ModifyPlayerRoleInputMeta;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly OutputMetadata[] ModifyPlayerRoleOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private PlayerRoleMapModes playerRoleMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Guid modificationRoleGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool masterLastPlayerHasRoleSignal;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public PlayerRoleMapModes PlayerRoleMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6A2BD0", Offset = "0x6A11D0", VA = "0x1806A2BD0")]
			get
			{
				return default(PlayerRoleMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1C34990", Offset = "0x1C32F90", VA = "0x181C34990")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Guid ModificationRoleGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1E360B0", Offset = "0x1E346B0", VA = "0x181E360B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1E363E0", Offset = "0x1E349E0", VA = "0x181E363E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PlayerModifyRoleFunc PlayerAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x1E35D90", Offset = "0x1E34390", VA = "0x181E35D90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x1E360C0", Offset = "0x1E346C0", VA = "0x181E360C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PlayerModifyRoleFunc TeamAddRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1E35F70", Offset = "0x1E34570", VA = "0x181E35F70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1E362A0", Offset = "0x1E348A0", VA = "0x181E362A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PlayerModifyRoleFunc PlayerRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1E35ED0", Offset = "0x1E344D0", VA = "0x181E35ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1E36200", Offset = "0x1E34800", VA = "0x181E36200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event PlayerModifyRoleFunc TeamRemoveRole
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1E36010", Offset = "0x1E34610", VA = "0x181E36010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1E36340", Offset = "0x1E34940", VA = "0x181E36340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event PlayerHasRoleFunc PlayerHasRole
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1E35E30", Offset = "0x1E34430", VA = "0x181E35E30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1E36160", Offset = "0x1E34760", VA = "0x181E36160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1E355D0", Offset = "0x1E33BD0", VA = "0x181E355D0")]
		public void MarkDirtyForRoleChange(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1E35CE0", Offset = "0x1E342E0", VA = "0x181E35CE0")]
		public PlayerRoleMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1E356C0", Offset = "0x1E33CC0", VA = "0x181E356C0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1E34D80", Offset = "0x1E33380", VA = "0x181E34D80")]
		private void EvaluatePlayerHasRole(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1E352F0", Offset = "0x1E338F0", VA = "0x181E352F0")]
		private bool GetPlayerHasRoleSignal(bool isMasterClient, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1E34BC0", Offset = "0x1E331C0", VA = "0x181E34BC0")]
		private void EvaluateAddPlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1E34E50", Offset = "0x1E33450", VA = "0x181E34E50")]
		private void EvaluateRemovePlayerRole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1E35610", Offset = "0x1E33C10", VA = "0x181E35610", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1E34B90", Offset = "0x1E33190", VA = "0x181E34B90", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1E35010", Offset = "0x1E33610", VA = "0x181E35010", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1E351C0", Offset = "0x1E337C0", VA = "0x181E351C0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1E35110", Offset = "0x1E33710", VA = "0x181E35110", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1E353D0", Offset = "0x1E339D0", VA = "0x181E353D0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1E35640", Offset = "0x1E33C40", VA = "0x181E35640", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1E357D0", Offset = "0x1E33DD0", VA = "0x181E357D0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CircuitNodeUuid("B81209CD-0D42-4FC7-A7A4-9AF3E78499B6")]
	public class PlayerRoleNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1E36500", Offset = "0x1E34B00", VA = "0x181E36500")]
		public PlayerRoleNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1E36480", Offset = "0x1E34A80", VA = "0x181E36480", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1E364C0", Offset = "0x1E34AC0", VA = "0x181E364C0", Slot = "14")]
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
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			PlayerToTeam,
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			TeamToPlayer,
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			SetPlayerTeam,
			[Cpp2IlInjected.Token(Token = "0x4000174")]
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

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly InputMetadata[] PlayerToTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly OutputMetadata[] PlayerToTeamOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly InputMetadata[] TeamToPlayerInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly OutputMetadata[] TeamToPlayerOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly InputMetadata[] SetPlayerTeamInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly InputMetadata[] GetTeamPlayerCountInputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly OutputMetadata[] GetTeamPlayerCountOutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly OutputMetadata[] SetPlayerTeamOutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private PlayerIdMapModes playerIdMapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int lastMasterPlayerToTeamId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int lastMasterPlayerToTeamIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int lastMasterTeamIndexToPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int lastMasterTeamPlayerCount;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public PlayerIdMapModes PlayerIdMapMode
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x6A2BD0", Offset = "0x6A11D0", VA = "0x1806A2BD0")]
			get
			{
				return default(PlayerIdMapModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1C34990", Offset = "0x1C32F90", VA = "0x181C34990")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event PlayerToTeamIndexFunc PlayerToTeamIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1C345D0", Offset = "0x1C32BD0", VA = "0x181C345D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1C34850", Offset = "0x1C32E50", VA = "0x181C34850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event PlayerSetTeamFunc PlayerSetTeam
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1C34530", Offset = "0x1C32B30", VA = "0x181C34530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1C347B0", Offset = "0x1C32DB0", VA = "0x181C347B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event TeamIndexToPlayerFunc TeamIndexToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x1C34670", Offset = "0x1C32C70", VA = "0x181C34670")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1C348F0", Offset = "0x1C32EF0", VA = "0x181C348F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event GetTeamPlayerCountFunc GetTeamPlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1C34490", Offset = "0x1C32A90", VA = "0x181C34490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x1C34710", Offset = "0x1C32D10", VA = "0x181C34710")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1C339B0", Offset = "0x1C31FB0", VA = "0x181C339B0")]
		public void MarkDirtyForTeamChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1C343B0", Offset = "0x1C329B0", VA = "0x181C343B0")]
		public PlayerTeamMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1C33B60", Offset = "0x1C32160", VA = "0x181C33B60", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1C33140", Offset = "0x1C31740", VA = "0x181C33140")]
		private void EvaluatePlayerToTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1C336A0", Offset = "0x1C31CA0", VA = "0x181C336A0")]
		private void GetPlayerToTeamSignals(bool isMasterClient, int playerId, out int masterTeamId, out int masterTeamIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1C332E0", Offset = "0x1C318E0", VA = "0x181C332E0")]
		private void EvaluateTeamToPlayer(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1C33780", Offset = "0x1C31D80", VA = "0x181C33780")]
		private int GetTeamIndexToPlayerSignal(bool isMasterClient, int teamId, int teamIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1C330A0", Offset = "0x1C316A0", VA = "0x181C330A0")]
		private void EvaluateGetTeamPlayerCount(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1C33860", Offset = "0x1C31E60", VA = "0x181C33860")]
		private int GetTeamPlayerCountSignal(bool isMasterClient, int teamId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1C331D0", Offset = "0x1C317D0", VA = "0x181C331D0")]
		private void EvaluateSetPlayerTeam(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1C339E0", Offset = "0x1C31FE0", VA = "0x181C339E0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1C32F50", Offset = "0x1C31550", VA = "0x181C32F50", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1C33360", Offset = "0x1C31960", VA = "0x181C33360", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1C33540", Offset = "0x1C31B40", VA = "0x181C33540", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1C334C0", Offset = "0x1C31AC0", VA = "0x181C334C0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1C33950", Offset = "0x1C31F50", VA = "0x181C33950", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1C33B30", Offset = "0x1C32130", VA = "0x181C33B30", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1C33E60", Offset = "0x1C32460", VA = "0x181C33E60", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class PostEvalActionNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private List<Action> PostEvalActions;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal sealed override bool RequiresPostEval
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x1C35040", Offset = "0x1C33640", VA = "0x181C35040", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1C34F80", Offset = "0x1C33580", VA = "0x181C34F80")]
		public PostEvalActionNode(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1C34F20", Offset = "0x1C33520", VA = "0x181C34F20")]
		protected void QueuePostEvalAction(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x1C34D70", Offset = "0x1C33370", VA = "0x181C34D70", Slot = "23")]
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
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public OutputSlot outputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int outputValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		internal List<Output[]> QueuedSignals;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x1C35670", Offset = "0x1C33C70", VA = "0x181C35670")]
		public QueuedMomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1C354B0", Offset = "0x1C33AB0", VA = "0x181C354B0")]
		public new void SetContinuousOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x1C354C0", Offset = "0x1C33AC0", VA = "0x181C354C0")]
		public new void SetMomentaryOutput(OutputSlot slot, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1C35560", Offset = "0x1C33B60", VA = "0x181C35560")]
		public void SetMomentaryOutputs(params Output[] outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1C35570", Offset = "0x1C33B70", VA = "0x181C35570", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x1C35300", Offset = "0x1C33900", VA = "0x181C35300", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1C350B0", Offset = "0x1C336B0", VA = "0x181C350B0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1C35230", Offset = "0x1C33830", VA = "0x181C35230")]
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

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event ObjectToHoldingPlayerIdFunc ObjectToHoldingPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1E32A30", Offset = "0x1E31030", VA = "0x181E32A30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1E32AD0", Offset = "0x1E310D0", VA = "0x181E32AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1E329B0", Offset = "0x1E30FB0", VA = "0x181E329B0")]
		public ObjectPlayerMappingNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1E32590", Offset = "0x1E30B90", VA = "0x181E32590", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x1E32530", Offset = "0x1E30B30", VA = "0x181E32530", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1E325C0", Offset = "0x1E30BC0", VA = "0x181E325C0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1E327B0", Offset = "0x1E30DB0", VA = "0x181E327B0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1E32620", Offset = "0x1E30C20", VA = "0x181E32620")]
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
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			Continuous,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			Pulse
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private RandomModes randomMode;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static Random random;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly InputMetadata[] inputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly OutputMetadata[] outputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int masterLastRandomNumber;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public RandomModes RandomMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(RandomModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1C35EA0", Offset = "0x1C344A0", VA = "0x181C35EA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1C35E20", Offset = "0x1C34420", VA = "0x181C35E20")]
		public RandomNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1C358D0", Offset = "0x1C33ED0", VA = "0x181C358D0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x1C35870", Offset = "0x1C33E70", VA = "0x181C35870", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1C35900", Offset = "0x1C33F00", VA = "0x181C35900", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1C35A40", Offset = "0x1C34040", VA = "0x181C35A40", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1C359B0", Offset = "0x1C33FB0", VA = "0x181C359B0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1C35820", Offset = "0x1C33E20", VA = "0x181C35820", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1C35730", Offset = "0x1C33D30", VA = "0x181C35730")]
		private int CalcOutput(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1C35960", Offset = "0x1C33F60", VA = "0x181C35960", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1C35A10", Offset = "0x1C34010", VA = "0x181C35A10", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1C35BC0", Offset = "0x1C341C0", VA = "0x181C35BC0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class SourceNodeBase : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		internal sealed override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AF50", Offset = "0x1C39550", VA = "0x181C3AF50", Slot = "27")]
		public void SetOutputMeta(OutputMetadata[] outputMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AFB0", Offset = "0x1C395B0", VA = "0x181C3AFB0")]
		public SourceNodeBase(string name, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AEF0", Offset = "0x1C394F0", VA = "0x181C3AEF0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x379E00", Offset = "0x378400", VA = "0x180379E00", Slot = "14")]
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
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			First,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct SelectorConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public SignalComparisonHelper.ComparerModes CompareMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public int CompareValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private EvalModes _evalMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public SelectorConfig[] SelectorConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private InputMetadata[] inputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int lastSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private int lastSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private bool modifiedSinceLastEval;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public EvalModes EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(EvalModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1C37900", Offset = "0x1C35F00", VA = "0x181C37900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1C37740", Offset = "0x1C35D40", VA = "0x181C37740")]
		public SelectorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1C37280", Offset = "0x1C35880", VA = "0x181C37280", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1C36E80", Offset = "0x1C35480", VA = "0x181C36E80", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x340F90", Offset = "0x33F590", VA = "0x180340F90", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1C36EC0", Offset = "0x1C354C0", VA = "0x181C36EC0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1C36F10", Offset = "0x1C35510", VA = "0x181C36F10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1C370D0", Offset = "0x1C356D0", VA = "0x181C370D0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1C37490", Offset = "0x1C35A90", VA = "0x181C37490", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface ISourceNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMomentaryOutput(OutputSlot outputSlot, int value);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetOutputMeta(OutputMetadata[] outputMetadata);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CircuitNodeUuid("B58C2FAB-3F1A-15F4-6D31-4E3BE09A71A9")]
	public class SourceNode : SourceNodeBase, ISourceNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B060", Offset = "0x1C39660", VA = "0x181C3B060")]
		public SourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B050", Offset = "0x1C39650", VA = "0x181C3B050", Slot = "28")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1C354B0", Offset = "0x1C33AB0", VA = "0x181C354B0", Slot = "30")]
		public new void SetContinuousOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CircuitNodeUuid("92BD57FA-D68E-4A6E-9ECF-D82985169B82")]
	public class ComparerNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private static readonly InputMetadata[] AdvancedInputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private SignalComparisonHelper.ComparerModes comparerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private bool advancedMode;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public SignalComparisonHelper.ComparerModes ComparerMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(SignalComparisonHelper.ComparerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F260", Offset = "0x1C3D860", VA = "0x181C3F260")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x10170A0", Offset = "0x10156A0", VA = "0x1810170A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1E2DF40", Offset = "0x1E2C540", VA = "0x181E2DF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DEC0", Offset = "0x1E2C4C0", VA = "0x181E2DEC0")]
		public ComparerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D9E0", Offset = "0x1E2BFE0", VA = "0x181E2D9E0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D630", Offset = "0x1E2BC30", VA = "0x181E2D630")]
		private bool CalcOutput()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D6C0", Offset = "0x1E2BCC0", VA = "0x181E2D6C0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D7D0", Offset = "0x1E2BDD0", VA = "0x181E2D7D0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D760", Offset = "0x1E2BD60", VA = "0x181E2D760", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D900", Offset = "0x1E2BF00", VA = "0x181E2D900", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D980", Offset = "0x1E2BF80", VA = "0x181E2D980", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DB40", Offset = "0x1E2C140", VA = "0x181E2DB40", Slot = "26")]
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
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			Subtract,
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			Multiply,
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			Divide,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Modulo
		}

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private static readonly InputMetadata[] TwoInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private static readonly InputMetadata[] ThreeInputsMeta;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private static readonly Dictionary<CombinatorModes, string> ModeSymbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private CombinatorModes combinatorMode;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public CombinatorModes CombinatorMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(CombinatorModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F260", Offset = "0x1C3D860", VA = "0x181C3F260")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CF20", Offset = "0x1E2B520", VA = "0x181E2CF20")]
		public static string GetModeSymbol(CombinatorModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D5B0", Offset = "0x1E2BBB0", VA = "0x181E2D5B0")]
		public CombinatorNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D150", Offset = "0x1E2B750", VA = "0x181E2D150", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CD50", Offset = "0x1E2B350", VA = "0x181E2CD50")]
		private int CalcOutput()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CE80", Offset = "0x1E2B480", VA = "0x181E2CE80", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D070", Offset = "0x1E2B670", VA = "0x181E2D070", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CFA0", Offset = "0x1E2B5A0", VA = "0x181E2CFA0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E20C10", Offset = "0x1E1F210", VA = "0x181E20C10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E20C80", Offset = "0x1E1F280", VA = "0x181E20C80", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D230", Offset = "0x1E2B830", VA = "0x181E2D230", Slot = "26")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public int timeRemaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public int value;
		}

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private List<DelaySignal> QueuedSignals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private int lastInputSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FAB0", Offset = "0x1E2E0B0", VA = "0x181E2FAB0")]
		public DelayNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EFD0", Offset = "0x1E2D5D0", VA = "0x181E2EFD0", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F140", Offset = "0x1E2D740", VA = "0x181E2F140", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F1A0", Offset = "0x1E2D7A0", VA = "0x181E2F1A0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F6C0", Offset = "0x1E2DCC0", VA = "0x181E2F6C0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F8C0", Offset = "0x1E2DEC0", VA = "0x181E2F8C0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F3F0", Offset = "0x1E2D9F0", VA = "0x181E2F3F0")]
		private void QueueSignal(int delay, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F200", Offset = "0x1E2D800", VA = "0x181E2F200")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F550", Offset = "0x1E2DB50", VA = "0x181E2F550", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EEC0", Offset = "0x1E2D4C0", VA = "0x181E2EEC0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CircuitNodeUuid("C9A59F26-0A72-4C2E-B239-6A83998E0839", InternalOnly = true)]
	public class LoopNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		internal override bool IsLoopNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1E31830", Offset = "0x1E2FE30", VA = "0x181E31830", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1E317B0", Offset = "0x1E2FDB0", VA = "0x181E317B0")]
		public LoopNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E31710", Offset = "0x1E2FD10", VA = "0x181E31710", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E31760", Offset = "0x1E2FD60", VA = "0x181E31760", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CircuitNodeUuid("E7EFD8CA-92FE-4A37-9E7C-ABBE9E4DE336")]
	public class MomentarySourceNode : SourceNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E31840", Offset = "0x1E2FE40", VA = "0x181E31840")]
		public MomentarySourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B6D0", Offset = "0x1E29CD0", VA = "0x181E2B6D0")]
		public new void SetMomentaryOutput(OutputSlot outputSlot, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CircuitNodeUuid("6402C773-5838-4495-BC54-BC36EDE4AB0F")]
	public class ConstantSourceNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DFF0", Offset = "0x1E2C5F0", VA = "0x181E2DFF0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E050", Offset = "0x1E2C650", VA = "0x181E2E050", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E6C0", Offset = "0x1E2CCC0", VA = "0x181E2E6C0")]
		public ConstantSourceNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E0B0", Offset = "0x1E2C6B0", VA = "0x181E2E0B0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E2A0", Offset = "0x1E2C8A0", VA = "0x181E2E2A0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E430", Offset = "0x1E2CA30", VA = "0x181E2E430", Slot = "26")]
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
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1E31320", Offset = "0x1E2F920", VA = "0x181E31320")]
			public GraphInputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1E2B6B0", Offset = "0x1E29CB0", VA = "0x181E2B6B0")]
			public void SetOutputSignal(OutputSlot slot, int val)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CircuitNodeUuid("F8A998DB-0354-4BCD-B0E4-6BBA7CC24B89", InternalOnly = true)]
		public class GraphOutputNode : VirtualNode
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1E31540", Offset = "0x1E2FB40", VA = "0x181E31540")]
			public GraphOutputNode(int nodeId, CircuitNodeGraph graph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1E313A0", Offset = "0x1E2F9A0", VA = "0x181E313A0", Slot = "24")]
			protected override void _EvaluateNode(bool isMasterClient)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private GraphInputNode virtualSourceNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private GraphOutputNode virtualDestNode;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public CircuitNodeGraph InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x379E00", Offset = "0x378400", VA = "0x180379E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x384BA0", Offset = "0x3831A0", VA = "0x180384BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E322F0", Offset = "0x1E308F0", VA = "0x181E322F0")]
		public NodeGraphNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E31F60", Offset = "0x1E30560", VA = "0x181E31F60", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E31E80", Offset = "0x1E30480", VA = "0x181E31E80", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E31A10", Offset = "0x1E30010", VA = "0x181E31A10", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E31970", Offset = "0x1E2FF70", VA = "0x181E31970", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E319C0", Offset = "0x1E2FFC0", VA = "0x181E319C0", Slot = "14")]
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
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public bool NeedsSerialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public InputMetadata[] InputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string NodeDescription;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct InputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public InputSlot InputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public string Description;
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OutputMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public OutputSlot OutputSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public string Description;
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate void OutputNodeUpdated(Dictionary<InputSlot, int> slotUpdates);
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public interface IOutputNode
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AddUpdatedEvent(OutputNodeUpdated updateEvent);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveUpdatedEvent(OutputNodeUpdated updateEvent);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInputMeta(InputMetadata[] inputMeta);
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CircuitNodeUuid("C6AB70A0-C752-466A-8070-029742655556")]
	public class OutputNode : CircuitNode, IOutputNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private Dictionary<InputSlot, int> inputValues;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private OutputNodeUpdated OutputNodeUpdatedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private int[] lastSignals;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AF50", Offset = "0x1C39550", VA = "0x181C3AF50", Slot = "29")]
		public void SetInputMeta(InputMetadata[] inputMeta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E33200", Offset = "0x1E31800", VA = "0x181E33200", Slot = "27")]
		public void AddUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E336B0", Offset = "0x1E31CB0", VA = "0x181E336B0", Slot = "28")]
		public void RemoveUpdatedEvent(OutputNodeUpdated updateEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E33930", Offset = "0x1E31F30", VA = "0x181E33930")]
		public OutputNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E33290", Offset = "0x1E31890", VA = "0x181E33290", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E33680", Offset = "0x1E31C80", VA = "0x181E33680")]
		private void OnDisconnected(CircuitNode otherNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x379E00", Offset = "0x378400", VA = "0x180379E00", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E33620", Offset = "0x1E31C20", VA = "0x181E33620", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E33740", Offset = "0x1E31D40", VA = "0x181E33740", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E33750", Offset = "0x1E31D50", VA = "0x181E33750", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E33350", Offset = "0x1E31950", VA = "0x181E33350")]
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
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public InputSlot inputSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public byte stateIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public int val1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public int val2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public int val3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int minTimeInStateMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public bool removed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public StateTransition[] transitions;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public enum ModifyCommands
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			DefaultState = 1,
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			MaxStateIndex,
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			StateVal1,
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			StateVal2,
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			StateVal3,
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			MinTimeInStateMS,
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			NumTransitions,
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			TransitionInputSlot,
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			TransitionStateTarget,
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			RemovedState
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private State[] states;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private byte maxStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private OutputSlot[] _serializableOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1399A60", Offset = "0x1398060", VA = "0x181399A60")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B10", Offset = "0x6F6110", VA = "0x1806F7B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public byte DefaultState
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x15B70F0", Offset = "0x15B56F0", VA = "0x1815B70F0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x15B75F0", Offset = "0x15B5BF0", VA = "0x1815B75F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override OutputSlot[] SerializableOutputs
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x340F90", Offset = "0x33F590", VA = "0x180340F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override int OutputSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x173BCB0", Offset = "0x173A2B0", VA = "0x18173BCB0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x115F870", Offset = "0x115DE70", VA = "0x18115F870")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x115FCC0", Offset = "0x115E2C0", VA = "0x18115FCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1C3D2B0", Offset = "0x1C3B8B0", VA = "0x181C3D2B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1C3D220", Offset = "0x1C3B820", VA = "0x181C3D220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B940", Offset = "0x1C39F40", VA = "0x181C3B940")]
		public State? GetState(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D080", Offset = "0x1C3B680", VA = "0x181C3D080")]
		public StateMachineNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B150", Offset = "0x1C39750", VA = "0x181C3B150", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1C3BEE0", Offset = "0x1C3A4E0", VA = "0x181C3BEE0")]
		private void OnTimerUpdate(int networkTimeMS, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1C3C330", Offset = "0x1C3A930", VA = "0x181C3C330", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D050", Offset = "0x1C3B650", VA = "0x181C3D050", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B6A0", Offset = "0x1C39CA0", VA = "0x181C3B6A0")]
		public static OutputSlot GetOnEnterOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B400", Offset = "0x1C39A00", VA = "0x181C3B400")]
		public static OutputSlot GetInStateOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B6B0", Offset = "0x1C39CB0", VA = "0x181C3B6B0")]
		public static OutputSlot GetOnExitOutputSlotForState(byte stateIdx)
		{
			return default(OutputSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B1E0", Offset = "0x1C397E0", VA = "0x181C3B1E0")]
		private void EnterState(byte newStateIndex, bool forceIfCurrent = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B410", Offset = "0x1C39A10", VA = "0x181C3B410", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B6C0", Offset = "0x1C39CC0", VA = "0x181C3B6C0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B650", Offset = "0x1C39C50", VA = "0x181C3B650", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1C3C060", Offset = "0x1C3A660", VA = "0x181C3C060", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B0E0", Offset = "0x1C396E0", VA = "0x181C3B0E0", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1C3BA40", Offset = "0x1C3A040", VA = "0x181C3BA40", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1C3C0E0", Offset = "0x1C3A6E0", VA = "0x181C3C0E0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B630", Offset = "0x1C39C30", VA = "0x181C3B630")]
		public static int GetModifyArg(ModifyCommands cmd, byte stateIdx = 0, byte transitionIdx = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1C3C310", Offset = "0x1C3A910", VA = "0x181C3C310")]
		private static void UnpackModifyArg(int arg, out ModifyCommands cmd, out byte stateIdx, out byte transitionIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1C3C4E0", Offset = "0x1C3AAE0", VA = "0x181C3C4E0", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B3F0", Offset = "0x1C399F0", VA = "0x181C3B3F0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			Looping,
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			Countdown
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			Second,
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			TenthOfSecond
		}

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private static readonly InputMetadata[] InputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TimerModes timerMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private int timeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private bool timerExpired;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private int _inputTimeTenths;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TimerModes TimerMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(TimerModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F260", Offset = "0x1C3D860", VA = "0x181C3F260")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private int inputTimeTenths
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F250", Offset = "0x1C3D850", VA = "0x181C3F250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F280", Offset = "0x1C3D880", VA = "0x181C3F280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1C3F170", Offset = "0x1C3D770", VA = "0x181C3F170")]
		public TimerNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E950", Offset = "0x1C3CF50", VA = "0x181C3E950", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EE20", Offset = "0x1C3D420", VA = "0x181C3EE20", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EF50", Offset = "0x1C3D550", VA = "0x181C3EF50", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E9E0", Offset = "0x1C3CFE0", VA = "0x181C3E9E0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EA80", Offset = "0x1C3D080", VA = "0x181C3EA80", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EA40", Offset = "0x1C3D040", VA = "0x181C3EA40", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EB40", Offset = "0x1C3D140", VA = "0x181C3EB40")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1C3ED90", Offset = "0x1C3D390", VA = "0x181C3ED90")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EC50", Offset = "0x1C3D250", VA = "0x181C3EC50")]
		private void ResetTimeRemaining()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EAE0", Offset = "0x1C3D0E0", VA = "0x181C3EAE0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1C35A10", Offset = "0x1C34010", VA = "0x181C35A10", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EE90", Offset = "0x1C3D490", VA = "0x181C3EE90", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1C3ED30", Offset = "0x1C3D330", VA = "0x181C3ED30", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E900", Offset = "0x1C3CF00", VA = "0x181C3E900", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1C3ECE0", Offset = "0x1C3D2E0", VA = "0x181C3ECE0", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E8C0", Offset = "0x1C3CEC0", VA = "0x181C3E8C0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CircuitNodeUuid("9B664D6A-1B61-4D4E-9AA8-B17B0DC02DA3")]
	public class UnityTransformationNode : CircuitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		protected InputMetadata[] InputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		protected OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private Dictionary<InputSlot, int> inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private Dictionary<OutputSlot, int> outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private Func<Dictionary<InputSlot, int>, Dictionary<OutputSlot, int>> transformationFunction;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x379E00", Offset = "0x378400", VA = "0x180379E00", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x340FD0", Offset = "0x33F5D0", VA = "0x180340FD0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1C41BC0", Offset = "0x1C401C0", VA = "0x181C41BC0")]
		public UnityTransformationNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1C41850", Offset = "0x1C3FE50", VA = "0x181C41850", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1C41750", Offset = "0x1C3FD50", VA = "0x181C41750")]
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
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			Sine,
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			Cosine,
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			Square,
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			Sawtooth
		}

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static readonly InputMetadata[] SecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private static readonly InputMetadata[] ThenthOfSecondInputMetadata;

		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private static readonly OutputMetadata[] OutputMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private WaveMode currentWaveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TimerNode.TimeUnit currentTimeUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private int runningTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private int? lastNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private int _inputPeriod;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private int inputAmplitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private double functionPeriodInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private double millisecondTimeToAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int loopTimeInMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private int relevantDecimalPlaces;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal override bool IsStateful
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public WaveMode CurrentWaveMode
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x3CB120", Offset = "0x3C9720", VA = "0x1803CB120")]
			get
			{
				return default(WaveMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F260", Offset = "0x1C3D860", VA = "0x181C3F260")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TimerNode.TimeUnit CurrentTimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x79E200", Offset = "0x79C800", VA = "0x18079E200")]
			get
			{
				return default(TimerNode.TimeUnit);
			}
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x2633230", Offset = "0x2631830", VA = "0x182633230")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private double InputTimeUnitInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2633200", Offset = "0x2631800", VA = "0x182633200")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private int InputPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x26331F0", Offset = "0x26317F0", VA = "0x1826331F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x2633270", Offset = "0x2631870", VA = "0x182633270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2633110", Offset = "0x2631710", VA = "0x182633110")]
		public WaveNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x26322A0", Offset = "0x26308A0", VA = "0x1826322A0", Slot = "22")]
		public override void Destroy(bool destroyLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2632BC0", Offset = "0x26311C0", VA = "0x182632BC0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2632DC0", Offset = "0x26313C0", VA = "0x182632DC0", Slot = "25")]
		protected override void _ResetNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2632610", Offset = "0x2630C10", VA = "0x182632610", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2632740", Offset = "0x2630D40", VA = "0x182632740", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x26326B0", Offset = "0x2630CB0", VA = "0x1826326B0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2632840", Offset = "0x2630E40", VA = "0x182632840")]
		private void OnTimerUpdate(int networkTime, bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2632B80", Offset = "0x2631180", VA = "0x182632B80")]
		private void UpdateOutputs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2632940", Offset = "0x2630F40", VA = "0x182632940")]
		private void ResetRunningTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2632330", Offset = "0x2630930", VA = "0x182632330")]
		private int EvaluateWaveFunction()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2632A10", Offset = "0x2631010", VA = "0x182632A10")]
		private void UpdateCachedFunctionParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x26327A0", Offset = "0x2630DA0", VA = "0x1826327A0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x26329B0", Offset = "0x2630FB0", VA = "0x1826329B0", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2632C70", Offset = "0x2631270", VA = "0x182632C70", Slot = "26")]
		protected override void _ModifyNode(Dictionary<object, object> modifyArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2632950", Offset = "0x2630F50", VA = "0x182632950", Slot = "18")]
		internal override void SerializeRuntimeState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2632250", Offset = "0x2630850", VA = "0x182632250", Slot = "19")]
		internal override void DeserializeRuntimeState(BitPacker bitPacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CircuitNodeUuid("A4160690-4C68-40C2-BD51-B665F71FCEBD", InternalOnly = true)]
	public class RootNode : VirtualNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		internal override bool IsRootNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1C35EB0", Offset = "0x1C344B0", VA = "0x181C35EB0")]
		public RootNode(int nodeId, CircuitNodeGraph graph)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class VirtualNode : CircuitNode
	{
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private static readonly InputMetadata[] InputMeta;

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private static readonly OutputMetadata[] OutputMeta;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool IsVirtual
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x349210", Offset = "0x347810", VA = "0x180349210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x26321C0", Offset = "0x26307C0", VA = "0x1826321C0")]
		protected VirtualNode(string nodeName, int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2632040", Offset = "0x2630640", VA = "0x182632040", Slot = "22")]
		public override void Destroy(bool disconnectLinks = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2632090", Offset = "0x2630690", VA = "0x182632090", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x26320F0", Offset = "0x26306F0", VA = "0x1826320F0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class Serialization
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1C3A1F0", Offset = "0x1C387F0", VA = "0x181C3A1F0")]
		public static CircuitNode InstantiateNode(Guid nodeType, int nodeId, Guid graphGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1C39F90", Offset = "0x1C38590", VA = "0x181C39F90")]
		internal static CircuitNode InstantiateNode(CircuitNodeData nodeData, CircuitNodeGraph nodeGraph, bool reassignNodeIds, Dictionary<int, int> nodeIdMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1C39E50", Offset = "0x1C38450", VA = "0x181C39E50")]
		public static Guid GetNodeTypeGuid(CircuitNode node)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1C3A380", Offset = "0x1C38980", VA = "0x181C3A380")]
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
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CCB0", Offset = "0x1E2B2B0", VA = "0x181E2CCB0")]
		public static bool TryGetCircuitTypeFromGuid(Guid guid, out Type nodeType)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class SerializationLookup
	{
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private static Guid RECROOM_CIRCUITS_BOOLEANNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private static Guid RECROOM_CIRCUITS_CONTINUOUSSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private static Guid RECROOM_CIRCUITS_CUSTOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static Guid RECROOM_CIRCUITS_GAMESETSTATENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static Guid RECROOM_CIRCUITS_OBJECTSETTAGSNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLEMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static Guid RECROOM_CIRCUITS_PLAYERROLENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static Guid RECROOM_CIRCUITS_PLAYERTEAMMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static Guid RECROOM_CIRCUITS_QUEUEDMOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static Guid RECROOM_CIRCUITS_OBJECTPLAYERMAPPINGNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static Guid RECROOM_CIRCUITS_RANDOMNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static Guid RECROOM_CIRCUITS_SELECTORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static Guid RECROOM_CIRCUITS_SOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static Guid RECROOM_CIRCUITS_COMPARERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static Guid RECROOM_CIRCUITS_COMBINATORNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static Guid RECROOM_CIRCUITS_DELAYNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static Guid RECROOM_CIRCUITS_LOOPNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static Guid RECROOM_CIRCUITS_MOMENTARYSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static Guid RECROOM_CIRCUITS_CONSTANTSOURCENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static Guid RECROOM_CIRCUITS_OUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static Guid RECROOM_CIRCUITS_STATEMACHINENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static Guid RECROOM_CIRCUITS_TIMERNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private static Guid RECROOM_CIRCUITS_UNITYTRANSFORMATIONNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private static Guid RECROOM_CIRCUITS_WAVENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private static Guid RECROOM_CIRCUITS_ROOTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERGETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private static Guid RECROOM_CIRCUITS_PLAYERSTATS_PLAYERSETSTATNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMEGETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private static Guid RECROOM_CIRCUITS_GAMESTATS_GAMESETSCORENODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHINPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static Guid RECROOM_CIRCUITS_NODEGRAPHNODE_GRAPHOUTPUTNODE_ID;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		internal static Dictionary<Type, Guid> TypeToGuidLookup;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		internal static Dictionary<Guid, Type> GuidToTypeLookup;

		[Cpp2IlInjected.Token(Token = "0x4000220")]
		internal static Dictionary<Guid, CircuitNodeConstructor> GuidToNodeConstructor;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class SignalComparisonHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum ComparerModes
		{
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			Equals,
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			NotEquals,
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			GreaterThan,
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			GreaterThanEqualTo,
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			LessThan,
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			LessThanEqualTo
		}

		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private static readonly Dictionary<ComparerModes, string> ModeSymbols;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1C3A840", Offset = "0x1C38E40", VA = "0x181C3A840")]
		public static string GetModeSymbol(ComparerModes mode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1C3A7D0", Offset = "0x1C38DD0", VA = "0x181C3A7D0")]
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
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A590", Offset = "0x1C28B90", VA = "0x181C2A590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1C29F40", Offset = "0x1C28540", VA = "0x181C29F40")]
		static CircuitLinkDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class CircuitLinkData : IMessage<CircuitLinkData>, IMessage, IEquatable<CircuitLinkData>, IDeepCloneable<CircuitLinkData>
	{
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private static readonly MessageParser<CircuitLinkData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private int sourceNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private int destNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private int inputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private int outputSlot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private int linkType_;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitLinkData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x1C2AD40", Offset = "0x1C29340", VA = "0x181C2AD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x1C2AC70", Offset = "0x1C29270", VA = "0x181C2AC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x1C2ADA0", Offset = "0x1C293A0", VA = "0x181C2ADA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[DebuggerNonUserCode]
		public int SourceNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x3B4CE0", Offset = "0x3B32E0", VA = "0x1803B4CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x3CC720", Offset = "0x3CAD20", VA = "0x1803CC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[DebuggerNonUserCode]
		public int DestNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x34D1F0", Offset = "0x34B7F0", VA = "0x18034D1F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x34D210", Offset = "0x34B810", VA = "0x18034D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[DebuggerNonUserCode]
		public int InputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x32A820", Offset = "0x328E20", VA = "0x18032A820")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AF0", Offset = "0x3C70F0", VA = "0x1803C8AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[DebuggerNonUserCode]
		public int OutputSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AD0", Offset = "0x3C70D0", VA = "0x1803C8AD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AE0", Offset = "0x3C70E0", VA = "0x1803C8AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[DebuggerNonUserCode]
		public int LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D40", Offset = "0x3CF340", VA = "0x1803D0D40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D50", Offset = "0x3CF350", VA = "0x1803D0D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		[DebuggerNonUserCode]
		public CircuitLinkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AC20", Offset = "0x1C29220", VA = "0x181C2AC20")]
		[DebuggerNonUserCode]
		public CircuitLinkData(CircuitLinkData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A740", Offset = "0x1C28D40", VA = "0x181C2A740", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitLinkData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A7C0", Offset = "0x1C28DC0", VA = "0x181C2A7C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A860", Offset = "0x1C28E60", VA = "0x181C2A860", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitLinkData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A8A0", Offset = "0x1C28EA0", VA = "0x181C2A8A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AA10", Offset = "0x1C29010", VA = "0x181C2AA10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AA70", Offset = "0x1C29070", VA = "0x181C2AA70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A5F0", Offset = "0x1C28BF0", VA = "0x181C2A5F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A950", Offset = "0x1C28F50", VA = "0x181C2A950", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class CircuitNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x1C2D800", Offset = "0x1C2BE00", VA = "0x181C2D800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AEA0", Offset = "0x1C294A0", VA = "0x181C2AEA0")]
		static CircuitNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private static readonly MessageParser<CircuitNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private string nodeName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private int nodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private int pairedNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private ByteString nodeType_;

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly FieldCodec<CircuitLinkData> _repeated_circuitLinks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private readonly RepeatedField<CircuitLinkData> circuitLinks_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private NodeTransformData transformData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private InternalGraphData internalGraphData_;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly FieldCodec<SlotData> _repeated_slotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private readonly RepeatedField<SlotData> slotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private int mode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private SelectorNodeData selectorNodeData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private bool advancedMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private int timeUnit_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private int roleId_;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly FieldCodec<StateMachineStateData> _repeated_stateMachineData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private readonly RepeatedField<StateMachineStateData> stateMachineData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private int defaultIndex_;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly FieldCodec<SlotData> _repeated_defaultInputSlotData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private readonly RepeatedField<SlotData> defaultInputSlotData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private string roleGuid_;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F2D0", Offset = "0x1C2D8D0", VA = "0x181C2F2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F200", Offset = "0x1C2D800", VA = "0x181C2F200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F330", Offset = "0x1C2D930", VA = "0x181C2F330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F430", Offset = "0x1C2DA30", VA = "0x181C2F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		public int NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x32A820", Offset = "0x328E20", VA = "0x18032A820")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AF0", Offset = "0x3C70F0", VA = "0x1803C8AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public int PairedNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AD0", Offset = "0x3C70D0", VA = "0x1803C8AD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AE0", Offset = "0x3C70E0", VA = "0x1803C8AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x32A410", Offset = "0x328A10", VA = "0x18032A410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F480", Offset = "0x1C2DA80", VA = "0x181C2F480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitLinkData> CircuitLinks
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x33A970", Offset = "0x338F70", VA = "0x18033A970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public NodeTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x32DC80", Offset = "0x32C280", VA = "0x18032DC80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x3CB890", Offset = "0x3C9E90", VA = "0x1803CB890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[DebuggerNonUserCode]
		public InternalGraphData InternalGraphData
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x32CE40", Offset = "0x32B440", VA = "0x18032CE40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x32DDF0", Offset = "0x32C3F0", VA = "0x18032DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> SlotData
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x3326A0", Offset = "0x330CA0", VA = "0x1803326A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public int Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x3D3280", Offset = "0x3D1880", VA = "0x1803D3280")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x3D32B0", Offset = "0x3D18B0", VA = "0x1803D32B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		public SelectorNodeData SelectorNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x332620", Offset = "0x330C20", VA = "0x180332620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x376A40", Offset = "0x375040", VA = "0x180376A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[DebuggerNonUserCode]
		public bool AdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x3BA460", Offset = "0x3B8A60", VA = "0x1803BA460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x3F7AB0", Offset = "0x3F60B0", VA = "0x1803F7AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public int TimeUnit
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x32CF00", Offset = "0x32B500", VA = "0x18032CF00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x3D3F80", Offset = "0x3D2580", VA = "0x1803D3F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public int RoleId
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x3F7960", Offset = "0x3F5F60", VA = "0x1803F7960")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x3F7BE0", Offset = "0x3F61E0", VA = "0x1803F7BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineStateData> StateMachineData
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x3D42A0", Offset = "0x3D28A0", VA = "0x1803D42A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public int DefaultIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x33A980", Offset = "0x338F80", VA = "0x18033A980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x625780", Offset = "0x623D80", VA = "0x180625780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[DebuggerNonUserCode]
		public RepeatedField<SlotData> DefaultInputSlotData
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x384C70", Offset = "0x383270", VA = "0x180384C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		public string RoleGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x332AE0", Offset = "0x3310E0", VA = "0x180332AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F4D0", Offset = "0x1C2DAD0", VA = "0x181C2F4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1C2ED30", Offset = "0x1C2D330", VA = "0x181C2ED30")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1C2EE40", Offset = "0x1C2D440", VA = "0x181C2EE40")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DCA0", Offset = "0x1C2C2A0", VA = "0x181C2DCA0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DD00", Offset = "0x1C2C300", VA = "0x181C2DD00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DD60", Offset = "0x1C2C360", VA = "0x181C2DD60", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DF60", Offset = "0x1C2C560", VA = "0x181C2DF60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E5D0", Offset = "0x1C2CBD0", VA = "0x181C2E5D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E630", Offset = "0x1C2CC30", VA = "0x181C2E630", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1C2D860", Offset = "0x1C2BE60", VA = "0x181C2D860", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E1C0", Offset = "0x1C2C7C0", VA = "0x181C2E1C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class SelectorNodeData : IMessage<SelectorNodeData>, IMessage, IEquatable<SelectorNodeData>, IDeepCloneable<SelectorNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly MessageParser<SelectorNodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int evalMode_;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly FieldCodec<SelectorConfigData> _repeated_selectorConfigData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private readonly RepeatedField<SelectorConfigData> selectorConfigData_;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x1C36D10", Offset = "0x1C35310", VA = "0x181C36D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x1C36C40", Offset = "0x1C35240", VA = "0x181C36C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x1C36D70", Offset = "0x1C35370", VA = "0x181C36D70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		public int EvalMode
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x3B4CE0", Offset = "0x3B32E0", VA = "0x1803B4CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x3CC720", Offset = "0x3CAD20", VA = "0x1803CC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public RepeatedField<SelectorConfigData> SelectorConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1C36BE0", Offset = "0x1C351E0", VA = "0x181C36BE0")]
		[DebuggerNonUserCode]
		public SelectorNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1C36B20", Offset = "0x1C35120", VA = "0x181C36B20")]
		[DebuggerNonUserCode]
		public SelectorNodeData(SelectorNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1C36520", Offset = "0x1C34B20", VA = "0x181C36520", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1C36680", Offset = "0x1C34C80", VA = "0x181C36680", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1C36600", Offset = "0x1C34C00", VA = "0x181C36600", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1C36750", Offset = "0x1C34D50", VA = "0x181C36750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1C368A0", Offset = "0x1C34EA0", VA = "0x181C368A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1C36900", Offset = "0x1C34F00", VA = "0x181C36900", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1C36450", Offset = "0x1C34A50", VA = "0x181C36450", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1C367C0", Offset = "0x1C34DC0", VA = "0x181C367C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class InternalGraphData : IMessage<InternalGraphData>, IMessage, IEquatable<InternalGraphData>, IDeepCloneable<InternalGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly MessageParser<InternalGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private int inputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int outputNodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private CircuitNodeGraphData internalNodeGraph_;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public static MessageParser<InternalGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x1C31EB0", Offset = "0x1C304B0", VA = "0x181C31EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x1C31DE0", Offset = "0x1C303E0", VA = "0x181C31DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1C31F10", Offset = "0x1C30510", VA = "0x181C31F10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public int InputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x3B4CE0", Offset = "0x3B32E0", VA = "0x1803B4CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x3CC720", Offset = "0x3CAD20", VA = "0x1803CC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public int OutputNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x34D1F0", Offset = "0x34B7F0", VA = "0x18034D1F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x34D210", Offset = "0x34B810", VA = "0x18034D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData InternalNodeGraph
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x3C0B60", Offset = "0x3BF160", VA = "0x1803C0B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		[DebuggerNonUserCode]
		public InternalGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1C31CA0", Offset = "0x1C302A0", VA = "0x181C31CA0")]
		[DebuggerNonUserCode]
		public InternalGraphData(InternalGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1C31720", Offset = "0x1C2FD20", VA = "0x181C31720", Slot = "9")]
		[DebuggerNonUserCode]
		public InternalGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x1C31890", Offset = "0x1C2FE90", VA = "0x181C31890", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x1C31930", Offset = "0x1C2FF30", VA = "0x181C31930", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InternalGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1C31970", Offset = "0x1C2FF70", VA = "0x181C31970", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1C31AE0", Offset = "0x1C300E0", VA = "0x181C31AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1C31B40", Offset = "0x1C30140", VA = "0x181C31B40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1C31630", Offset = "0x1C2FC30", VA = "0x181C31630", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x1C31A00", Offset = "0x1C30000", VA = "0x181C31A00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class CircuitNodeGraphData : IMessage<CircuitNodeGraphData>, IMessage, IEquatable<CircuitNodeGraphData>, IDeepCloneable<CircuitNodeGraphData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly MessageParser<CircuitNodeGraphData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private ByteString nodeGraphGuid_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private bool isInternalGraph_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private CircuitNodeData rootNodeData_;

		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private static readonly FieldCodec<CircuitNodeData> _repeated_circuitNodes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly RepeatedField<CircuitNodeData> circuitNodes_;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x1C309B0", Offset = "0x1C2EFB0", VA = "0x181C309B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x1C308E0", Offset = "0x1C2EEE0", VA = "0x181C308E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1C30A10", Offset = "0x1C2F010", VA = "0x181C30A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		public ByteString NodeGraphGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1C30B20", Offset = "0x1C2F120", VA = "0x181C30B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public bool IsInternalGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x34D1E0", Offset = "0x34B7E0", VA = "0x18034D1E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x34D200", Offset = "0x34B800", VA = "0x18034D200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public CircuitNodeData RootNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x32A410", Offset = "0x328A10", VA = "0x18032A410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x33A9A0", Offset = "0x338FA0", VA = "0x18033A9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> CircuitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x33A970", Offset = "0x338F70", VA = "0x18033A970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C30770", Offset = "0x1C2ED70", VA = "0x181C30770")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1C30800", Offset = "0x1C2EE00", VA = "0x181C30800")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData(CircuitNodeGraphData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1C2FF60", Offset = "0x1C2E560", VA = "0x181C2FF60", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x1C30060", Offset = "0x1C2E660", VA = "0x181C30060", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1C30190", Offset = "0x1C2E790", VA = "0x181C30190", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1C30280", Offset = "0x1C2E880", VA = "0x181C30280", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1C30490", Offset = "0x1C2EA90", VA = "0x181C30490", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1C304F0", Offset = "0x1C2EAF0", VA = "0x181C304F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1C2FE40", Offset = "0x1C2E440", VA = "0x181C2FE40", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1C30330", Offset = "0x1C2E930", VA = "0x181C30330", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class CircuitNodeGraphCollectionData : IMessage<CircuitNodeGraphCollectionData>, IMessage, IEquatable<CircuitNodeGraphCollectionData>, IDeepCloneable<CircuitNodeGraphCollectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private static readonly MessageParser<CircuitNodeGraphCollectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private static readonly FieldCodec<CircuitNodeGraphData> _repeated_graphs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly RepeatedField<CircuitNodeGraphData> graphs_;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeGraphCollectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1C2FCD0", Offset = "0x1C2E2D0", VA = "0x181C2FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x1C2FC00", Offset = "0x1C2E200", VA = "0x181C2FC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x1C2FD30", Offset = "0x1C2E330", VA = "0x181C2FD30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeGraphData> Graphs
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1C2FBA0", Offset = "0x1C2E1A0", VA = "0x181C2FBA0")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x1C2FAF0", Offset = "0x1C2E0F0", VA = "0x181C2FAF0")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData(CircuitNodeGraphCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F5B0", Offset = "0x1C2DBB0", VA = "0x181C2F5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeGraphCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F710", Offset = "0x1C2DD10", VA = "0x181C2F710", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F690", Offset = "0x1C2DC90", VA = "0x181C2F690", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeGraphCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1553AB0", Offset = "0x15520B0", VA = "0x181553AB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F8A0", Offset = "0x1C2DEA0", VA = "0x181C2F8A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F900", Offset = "0x1C2DF00", VA = "0x181C2F900", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F530", Offset = "0x1C2DB30", VA = "0x181C2F530", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F7E0", Offset = "0x1C2DDE0", VA = "0x181C2F7E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class SlotData : IMessage<SlotData>, IMessage, IEquatable<SlotData>, IDeepCloneable<SlotData>
	{
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private static readonly MessageParser<SlotData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private int slot_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private int signal_;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public static MessageParser<SlotData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x1C3AD80", Offset = "0x1C39380", VA = "0x181C3AD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x1C3ACB0", Offset = "0x1C392B0", VA = "0x181C3ACB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x1C3ADE0", Offset = "0x1C393E0", VA = "0x181C3ADE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x3B4CE0", Offset = "0x3B32E0", VA = "0x1803B4CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x3CC720", Offset = "0x3CAD20", VA = "0x1803CC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[DebuggerNonUserCode]
		public int Signal
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x34D1F0", Offset = "0x34B7F0", VA = "0x18034D1F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x34D210", Offset = "0x34B810", VA = "0x18034D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		[DebuggerNonUserCode]
		public SlotData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x15D0260", Offset = "0x15CE860", VA = "0x1815D0260")]
		[DebuggerNonUserCode]
		public SlotData(SlotData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AA90", Offset = "0x1C39090", VA = "0x181C3AA90", Slot = "9")]
		[DebuggerNonUserCode]
		public SlotData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AB00", Offset = "0x1C39100", VA = "0x181C3AB00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x15CFFD0", Offset = "0x15CE5D0", VA = "0x1815CFFD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SlotData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x15CFFF0", Offset = "0x15CE5F0", VA = "0x1815CFFF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1C3AB90", Offset = "0x1C39190", VA = "0x181C3AB90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x15D0130", Offset = "0x15CE730", VA = "0x1815D0130", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x1C3A9D0", Offset = "0x1C38FD0", VA = "0x181C3A9D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x15D0070", Offset = "0x15CE670", VA = "0x1815D0070", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class SelectorConfigData : IMessage<SelectorConfigData>, IMessage, IEquatable<SelectorConfigData>, IDeepCloneable<SelectorConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private static readonly MessageParser<SelectorConfigData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private int compareMode_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int compareValue_;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public static MessageParser<SelectorConfigData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x1C362E0", Offset = "0x1C348E0", VA = "0x181C362E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x1C36210", Offset = "0x1C34810", VA = "0x181C36210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x1C36340", Offset = "0x1C34940", VA = "0x181C36340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public int CompareMode
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3B4CE0", Offset = "0x3B32E0", VA = "0x1803B4CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x3CC720", Offset = "0x3CAD20", VA = "0x1803CC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		public int CompareValue
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x34D1F0", Offset = "0x34B7F0", VA = "0x18034D1F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x34D210", Offset = "0x34B810", VA = "0x18034D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		[DebuggerNonUserCode]
		public SelectorConfigData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x15D0260", Offset = "0x15CE860", VA = "0x1815D0260")]
		[DebuggerNonUserCode]
		public SelectorConfigData(SelectorConfigData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1C35FF0", Offset = "0x1C345F0", VA = "0x181C35FF0", Slot = "9")]
		[DebuggerNonUserCode]
		public SelectorConfigData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1C36060", Offset = "0x1C34660", VA = "0x181C36060", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x15CFFD0", Offset = "0x15CE5D0", VA = "0x1815CFFD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SelectorConfigData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x15CFFF0", Offset = "0x15CE5F0", VA = "0x1815CFFF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1C360F0", Offset = "0x1C346F0", VA = "0x181C360F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x15D0130", Offset = "0x15CE730", VA = "0x1815D0130", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x1C35F30", Offset = "0x1C34530", VA = "0x181C35F30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x15D0070", Offset = "0x15CE670", VA = "0x1815D0070", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class StateMachineStateData : IMessage<StateMachineStateData>, IMessage, IEquatable<StateMachineStateData>, IDeepCloneable<StateMachineStateData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private static readonly MessageParser<StateMachineStateData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private int val1_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private int val2_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int val3_;

		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private static readonly FieldCodec<StateMachineTransitionData> _repeated_stateTransitionData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private readonly RepeatedField<StateMachineTransitionData> stateTransitionData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private int minTimeInState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private int removed_;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineStateData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x1C3DE80", Offset = "0x1C3C480", VA = "0x181C3DE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x1C3DDB0", Offset = "0x1C3C3B0", VA = "0x181C3DDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x1C3DEE0", Offset = "0x1C3C4E0", VA = "0x181C3DEE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public int Val1
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x3B4CE0", Offset = "0x3B32E0", VA = "0x1803B4CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x3CC720", Offset = "0x3CAD20", VA = "0x1803CC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[DebuggerNonUserCode]
		public int Val2
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x34D1F0", Offset = "0x34B7F0", VA = "0x18034D1F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x34D210", Offset = "0x34B810", VA = "0x18034D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		public int Val3
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x32A820", Offset = "0x328E20", VA = "0x18032A820")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AF0", Offset = "0x3C70F0", VA = "0x1803C8AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[DebuggerNonUserCode]
		public RepeatedField<StateMachineTransitionData> StateTransitionData
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x32A410", Offset = "0x328A10", VA = "0x18032A410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[DebuggerNonUserCode]
		public int MinTimeInState
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x388770", Offset = "0x386D70", VA = "0x180388770")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x388780", Offset = "0x386D80", VA = "0x180388780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		[DebuggerNonUserCode]
		public int Removed
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x41C0A0", Offset = "0x41A6A0", VA = "0x18041C0A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x623EF0", Offset = "0x6224F0", VA = "0x180623EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1C3DC80", Offset = "0x1C3C280", VA = "0x181C3DC80")]
		[DebuggerNonUserCode]
		public StateMachineStateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1C3DCE0", Offset = "0x1C3C2E0", VA = "0x181C3DCE0")]
		[DebuggerNonUserCode]
		public StateMachineStateData(StateMachineStateData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D4A0", Offset = "0x1C3BAA0", VA = "0x181C3D4A0", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineStateData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D640", Offset = "0x1C3BC40", VA = "0x181C3D640", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D5A0", Offset = "0x1C3BBA0", VA = "0x181C3D5A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineStateData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D730", Offset = "0x1C3BD30", VA = "0x181C3D730", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D950", Offset = "0x1C3BF50", VA = "0x181C3D950", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D9B0", Offset = "0x1C3BFB0", VA = "0x181C3D9B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D300", Offset = "0x1C3B900", VA = "0x181C3D300", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x1C3D800", Offset = "0x1C3BE00", VA = "0x181C3D800", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class StateMachineTransitionData : IMessage<StateMachineTransitionData>, IMessage, IEquatable<StateMachineTransitionData>, IDeepCloneable<StateMachineTransitionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private static readonly MessageParser<StateMachineTransitionData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private int inputIndex_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int stateIndex_;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public static MessageParser<StateMachineTransitionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x1C3E3A0", Offset = "0x1C3C9A0", VA = "0x181C3E3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x1C3E2D0", Offset = "0x1C3C8D0", VA = "0x181C3E2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x1C3E400", Offset = "0x1C3CA00", VA = "0x181C3E400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public int InputIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x3B4CE0", Offset = "0x3B32E0", VA = "0x1803B4CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x3CC720", Offset = "0x3CAD20", VA = "0x1803CC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		[DebuggerNonUserCode]
		public int StateIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x34D1F0", Offset = "0x34B7F0", VA = "0x18034D1F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x34D210", Offset = "0x34B810", VA = "0x18034D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x15D0260", Offset = "0x15CE860", VA = "0x1815D0260")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData(StateMachineTransitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E0B0", Offset = "0x1C3C6B0", VA = "0x181C3E0B0", Slot = "9")]
		[DebuggerNonUserCode]
		public StateMachineTransitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E120", Offset = "0x1C3C720", VA = "0x181C3E120", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x15CFFD0", Offset = "0x15CE5D0", VA = "0x1815CFFD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(StateMachineTransitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x15CFFF0", Offset = "0x15CE5F0", VA = "0x1815CFFF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E1B0", Offset = "0x1C3C7B0", VA = "0x181C3E1B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x15D0130", Offset = "0x15CE730", VA = "0x1815D0130", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1C3DFF0", Offset = "0x1C3C5F0", VA = "0x181C3DFF0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x15D0070", Offset = "0x15CE670", VA = "0x1815D0070", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class NodeTransformDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x1C32630", Offset = "0x1C30C30", VA = "0x181C32630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1C32020", Offset = "0x1C30620", VA = "0x181C32020")]
		static NodeTransformDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeTransformData : IMessage<NodeTransformData>, IMessage, IEquatable<NodeTransformData>, IDeepCloneable<NodeTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private static readonly MessageParser<NodeTransformData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private Vector3Data position_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private Vector3Data rotation_;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		public static MessageParser<NodeTransformData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x1C32D50", Offset = "0x1C31350", VA = "0x181C32D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x1C32C80", Offset = "0x1C31280", VA = "0x181C32C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x1C32DB0", Offset = "0x1C313B0", VA = "0x181C32DB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public Vector3Data Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x3C0B50", Offset = "0x3BF150", VA = "0x1803C0B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public Vector3Data Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x3C0B60", Offset = "0x3BF160", VA = "0x1803C0B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		[DebuggerNonUserCode]
		public NodeTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1C32C10", Offset = "0x1C31210", VA = "0x181C32C10")]
		[DebuggerNonUserCode]
		public NodeTransformData(NodeTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1C32750", Offset = "0x1C30D50", VA = "0x181C32750", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1C327F0", Offset = "0x1C30DF0", VA = "0x181C327F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1C328A0", Offset = "0x1C30EA0", VA = "0x181C328A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1C32900", Offset = "0x1C30F00", VA = "0x181C32900", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1C32A70", Offset = "0x1C31070", VA = "0x181C32A70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1C32AD0", Offset = "0x1C310D0", VA = "0x181C32AD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1C32690", Offset = "0x1C30C90", VA = "0x181C32690", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x1C32970", Offset = "0x1C30F70", VA = "0x181C32970", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class Vector3DataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x1C420E0", Offset = "0x1C406E0", VA = "0x181C420E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1C41D40", Offset = "0x1C40340", VA = "0x181C41D40")]
		static Vector3DataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private static readonly MessageParser<Vector3Data> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private float x_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private float y_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x1C42430", Offset = "0x1C40A30", VA = "0x181C42430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x1C42360", Offset = "0x1C40960", VA = "0x181C42360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x1C42490", Offset = "0x1C40A90", VA = "0x181C42490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x50BA70", Offset = "0x50A070", VA = "0x18050BA70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x50BAC0", Offset = "0x50A0C0", VA = "0x18050BAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x50BA80", Offset = "0x50A080", VA = "0x18050BA80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x50BAD0", Offset = "0x50A0D0", VA = "0x18050BAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x50BA90", Offset = "0x50A090", VA = "0x18050BA90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x50BAE0", Offset = "0x50A0E0", VA = "0x18050BAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x155CF80", Offset = "0x155B580", VA = "0x18155CF80")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x1C42140", Offset = "0x1C40740", VA = "0x181C42140", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1C421B0", Offset = "0x1C407B0", VA = "0x181C421B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x155CC00", Offset = "0x155B200", VA = "0x18155CC00", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x155CC40", Offset = "0x155B240", VA = "0x18155CC40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C42240", Offset = "0x1C40840", VA = "0x181C42240", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x155CE00", Offset = "0x155B400", VA = "0x18155CE00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x155CAC0", Offset = "0x155B0C0", VA = "0x18155CAC0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x155CD20", Offset = "0x155B320", VA = "0x18155CD20", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		Player_Health = 0,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		Player_Shield = 1,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		PlayerStat_1 = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		PlayerStat_2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		PlayerStat_3 = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		PlayerStat_4 = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		PlayerStat_5 = 1004,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		PlayerStat_6 = 1005
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public static class FriendlyCircuitPlayerStats
	{
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private static Dictionary<string, int> friendlyCircuitPlayerStatsDict;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public static Dictionary<string, int> FriendlyCircuitPlayerStatsDict
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x1E2FD00", Offset = "0x1E2E300", VA = "0x181E2FD00")]
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
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private int masterLastPlayerStatSignal;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x6A2BD0", Offset = "0x6A11D0", VA = "0x1806A2BD0")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x1E34270", Offset = "0x1E32870", VA = "0x181E34270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event GetPlayerStatFunction GetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x1E34130", Offset = "0x1E32730", VA = "0x181E34130")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x1E341D0", Offset = "0x1E327D0", VA = "0x181E341D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E340B0", Offset = "0x1E326B0", VA = "0x181E340B0")]
		public PlayerGetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E33EC0", Offset = "0x1E324C0", VA = "0x181E33EC0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E33CD0", Offset = "0x1E322D0", VA = "0x181E33CD0")]
		private int GetStatSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E33E00", Offset = "0x1E32400", VA = "0x181E33E00", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1E33AC0", Offset = "0x1E320C0", VA = "0x181E33AC0", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E33B30", Offset = "0x1E32130", VA = "0x181E33B30", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E33C70", Offset = "0x1E32270", VA = "0x181E33C70", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E33B90", Offset = "0x1E32190", VA = "0x181E33B90", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E33DA0", Offset = "0x1E323A0", VA = "0x181E33DA0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E33E70", Offset = "0x1E32470", VA = "0x181E33E70", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E33F00", Offset = "0x1E32500", VA = "0x181E33F00", Slot = "26")]
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
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private CircuitPlayerStat playerStat;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public CircuitPlayerStat PlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x6A2BD0", Offset = "0x6A11D0", VA = "0x1806A2BD0")]
			get
			{
				return default(CircuitPlayerStat);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x1E34270", Offset = "0x1E32870", VA = "0x181E34270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event SetPlayerStatFunction SetPlayerStat
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x1E36A70", Offset = "0x1E35070", VA = "0x181E36A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x1E36B10", Offset = "0x1E35110", VA = "0x181E36B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E36A10", Offset = "0x1E35010", VA = "0x181E36A10")]
		public PlayerSetStatNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E36720", Offset = "0x1E34D20", VA = "0x181E36720", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E36700", Offset = "0x1E34D00", VA = "0x181E36700")]
		private void PostEvalSetPlayerStat(CircuitPlayerStat stat, int playerId, int signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E36580", Offset = "0x1E34B80", VA = "0x181E36580", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E366C0", Offset = "0x1E34CC0", VA = "0x181E366C0", Slot = "14")]
		protected override OutputMetadata[] GetOutputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E365E0", Offset = "0x1E34BE0", VA = "0x181E365E0", Slot = "15")]
		protected override string GetNodeDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E33DA0", Offset = "0x1E323A0", VA = "0x181E33DA0", Slot = "17")]
		internal override void InitializeInnerData(CircuitNodeData data, bool reassignNodeIds, Dictionary<int, int> nodeIdMap, bool copyingSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E33E70", Offset = "0x1E32470", VA = "0x181E33E70", Slot = "16")]
		public override CircuitNodeData Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1E36850", Offset = "0x1E34E50", VA = "0x181E36850", Slot = "26")]
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
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private int masterLastScoreSignal;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private static OutputMetadata[] outputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event GetTeamScoreFunction GetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x1E30350", Offset = "0x1E2E950", VA = "0x181E30350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x1E303F0", Offset = "0x1E2E9F0", VA = "0x181E303F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E302D0", Offset = "0x1E2E8D0", VA = "0x181E302D0")]
		public GameGetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E301A0", Offset = "0x1E2E7A0", VA = "0x181E301A0", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1E30070", Offset = "0x1E2E670", VA = "0x181E30070")]
		private int GetScoreSignal(bool isMasterClient)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E30130", Offset = "0x1E2E730", VA = "0x181E30130", Slot = "20")]
		internal override void SerializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FF40", Offset = "0x1E2E540", VA = "0x181E2FF40", Slot = "21")]
		internal override void DeserializePostEvaluateState(BitPacker bitPacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FFB0", Offset = "0x1E2E5B0", VA = "0x181E2FFB0", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E30010", Offset = "0x1E2E610", VA = "0x181E30010", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private static InputMetadata[] inputMetadata;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event SetTeamScoreFunction SetTeamScore
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x1E30850", Offset = "0x1E2EE50", VA = "0x181E30850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x1E308F0", Offset = "0x1E2EEF0", VA = "0x181E308F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E307F0", Offset = "0x1E2EDF0", VA = "0x181E307F0")]
		public GameSetScoreNode(int nodeId, CircuitNodeGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E30550", Offset = "0x1E2EB50", VA = "0x181E30550", Slot = "24")]
		protected override void _EvaluateNode(bool isMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E30530", Offset = "0x1E2EB30", VA = "0x181E30530")]
		private void PostEvalSetGameScoreStat(int teamId, int score, bool isWinner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E30490", Offset = "0x1E2EA90", VA = "0x181E30490", Slot = "13")]
		protected override InputMetadata[] GetInputMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E304F0", Offset = "0x1E2EAF0", VA = "0x181E304F0", Slot = "14")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		DirectedForward = 1,
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		DirectedBackward = 2,
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		Undirected = 3
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Flags]
	public enum LinkTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		NormalToNormal = 1,
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		NormalToVirtual = 2,
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		VirtualToNormal = 4,
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		RootToVirtual = 8,
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		RootToNormal = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal struct TopologicStackEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CircuitNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
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
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			private CircuitNode <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			private CircuitNode root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public CircuitNode <>3__root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private DFSType dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public DFSType <>3__dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private LinkTypes linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public LinkTypes <>3__linkTypesToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			private Stack<CircuitNode> <stack>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private HashSet<CircuitNode> <visited>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			private CircuitNode <current>5__4;

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			CircuitNode IEnumerator<CircuitNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x478F60", Offset = "0x477560", VA = "0x180478F60")]
			[DebuggerHidden]
			public <DFS>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F2A0", Offset = "0x1C3D8A0", VA = "0x181C3F2A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F8A0", Offset = "0x1C3DEA0", VA = "0x181C3F8A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F7F0", Offset = "0x1C3DDF0", VA = "0x181C3F7F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<CircuitNode> IEnumerable<CircuitNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F7F0", Offset = "0x1C3DDF0", VA = "0x181C3F7F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1C30C10", Offset = "0x1C2F210", VA = "0x181C30C10")]
		public static HashSet<CircuitNode> DFSCopy(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1C30CD0", Offset = "0x1C2F2D0", VA = "0x181C30CD0")]
		[IteratorStateMachine(typeof(<DFS>d__4))]
		public static IEnumerable<CircuitNode> DFS(CircuitNode root, DFSType dfsType, LinkTypes linkTypesToFollow = LinkTypes.NormalToNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1C31080", Offset = "0x1C2F680", VA = "0x181C31080")]
		public static List<CircuitNode> TopologicSort(CircuitNode root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C31060", Offset = "0x1C2F660", VA = "0x181C31060")]
		private static bool ShouldFollowLink(CircuitLink link, LinkTypes linkTypesToFollow)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1C30D60", Offset = "0x1C2F360", VA = "0x181C30D60")]
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
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1C29710", Offset = "0x1C27D10", VA = "0x181C29710")]
		public static Guid ToGuid(this ByteString bytes)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1C296B0", Offset = "0x1C27CB0", VA = "0x181C296B0")]
		public static ByteString ToByteString(this Guid guid)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum CircuitLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
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
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x1C29B60", Offset = "0x1C28160", VA = "0x181C29B60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x1C29D50", Offset = "0x1C28350", VA = "0x181C29D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public static event LogExceptionEvent OnLogExceptionEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x1C29C50", Offset = "0x1C28250", VA = "0x181C29C50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x1C29E40", Offset = "0x1C28440", VA = "0x181C29E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1C29890", Offset = "0x1C27E90", VA = "0x181C29890")]
		public static void LogException(Exception e, [Optional] string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1C29960", Offset = "0x1C27F60", VA = "0x181C29960")]
		public static void Log(CircuitLogLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1C29AC0", Offset = "0x1C280C0", VA = "0x181C29AC0")]
		public static void NodeLog(int nodeId, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1C29A30", Offset = "0x1C28030", VA = "0x181C29A30")]
		public static void NodeLogFormat(int nodeId, CircuitLogLevel CircuitLogLevel, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1C297F0", Offset = "0x1C27DF0", VA = "0x181C297F0")]
		public static void GraphLog(Guid graphGuid, string message, CircuitLogLevel CircuitLogLevel = CircuitLogLevel.Warning)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal static class NodeEventUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2631EB0", Offset = "0x26304B0", VA = "0x182631EB0")]
		internal static void SafeInvoke(this CircuitNode.NodeLifecycleEvent nodeLifecycleEvent, CircuitNode nodeArg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2631DF0", Offset = "0x26303F0", VA = "0x182631DF0")]
		internal static void SafeInvoke(this CircuitNode.NodeConnectionChanged nodeConnectionEvent, CircuitNode sourceNode, CircuitNode destNode, InputSlot inputSlot, OutputSlot outputSlot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal static class RuntimeAssert
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2631FD0", Offset = "0x26305D0", VA = "0x182631FD0")]
		public static void Assert(bool condition, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2631F40", Offset = "0x2630540", VA = "0x182631F40")]
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
