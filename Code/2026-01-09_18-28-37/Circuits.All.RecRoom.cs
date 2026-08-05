using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Circuits.All.Api;
using Circuits.All.RecRoom.Dependencies;
using Circuits.All.RecRoom.Injection;
using Circuits.All.RecRoom.Integration;
using Circuits.All.RecRoom.Payload;
using Circuits.Dynamic.Api;
using Circuits.Dynamic.RecRoom.Api;
using Circuits.Shared.Api;
using Circuits.Shared.RecRoom.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.NetSystem;
using Circuits.Static.Core.RequestReduce;
using Circuits.Static.Core.TypeSystem;
using Circuits.Static.RecRoom;
using Circuits.Static.RecRoom.Api;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.GraphDefs;
using Circuits.Static.RecRoom.Protobuf;
using Circuits.Static.Utilities;
using CircuitsV2;
using CircuitsV2.Dependencies;
using CircuitsV2.DynamicNetSystem;
using CircuitsV2.Lang;
using CircuitsV2.Lang.Graphs;
using CircuitsV2.Lang.Messages;
using CircuitsV2.Lang.Nodes;
using CircuitsV2.Lang.Nodes.Audio;
using CircuitsV2.Lang.Nodes.ChatAI;
using CircuitsV2.Lang.Nodes.CreationObject;
using CircuitsV2.Lang.Nodes.DataTable;
using CircuitsV2.Lang.Nodes.Econ;
using CircuitsV2.Lang.Nodes.GameAI;
using CircuitsV2.Lang.Nodes.Locomotion;
using CircuitsV2.Lang.Nodes.Messages;
using CircuitsV2.Lang.Nodes.StudioNodes;
using CircuitsV2.Lang.Nodes.Variable;
using CircuitsV2.LegacyError;
using CircuitsV2.Persistence;
using CircuitsV2.Persistence.Payload;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x285FFA0", Offset = "0x285F3A0", VA = "0x18285FFA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.Circuits_All_RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x285FC80", Offset = "0x285F080", VA = "0x18285FC80", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PRNNMMJSLKB : IDisposable, MTMJQAOABEK, CSAMAQNOZMD, RJKJHWEEBQO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class AVQHDSVSHCE : VUJTJJOWWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int JDNZSTPTAOU
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x285B130", Offset = "0x285A530", VA = "0x18285B130", Slot = "5")]
			public XIJKTMWBCMT FWWTKMEWUAY(RWYGVNVPHCG.VUJTJJOWWBJ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void RXAKJAEQJTC();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void GPDIJLEPXST();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x284BBC0", Offset = "0x284AFC0", VA = "0x18284BBC0", Slot = "13")]
			public virtual void QPBTPYHSXXL(PRNNMMJSLKB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x285B260", Offset = "0x285A660", VA = "0x18285B260", Slot = "14")]
			public virtual void SPOVZIGKTQG(PRNNMMJSLKB a, HJODGUBVAZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			protected AVQHDSVSHCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface VUJTJJOWWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int JDNZSTPTAOU
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			XIJKTMWBCMT FWWTKMEWUAY(RWYGVNVPHCG.VUJTJJOWWBJ a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void RXAKJAEQJTC();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void GPDIJLEPXST();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void QPBTPYHSXXL(PRNNMMJSLKB a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void SPOVZIGKTQG(PRNNMMJSLKB a, HJODGUBVAZG b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, HJODGUBVAZG, PRNNMMJSLKB, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xFF1B60", Offset = "0xFF0F60", VA = "0x180FF1B60")]
			internal Reducer(Reducer<ActionKind, HJODGUBVAZG, PRNNMMJSLKB, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class CONYTBARIYI : BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly CONYTBARIYI ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private CONYTBARIYI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1255670", Offset = "0x1254A70", VA = "0x181255670", Slot = "4")]
			public ActionKind XMWLIBMRVOE(HJODGUBVAZG a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x285C6E0", Offset = "0x285BAE0", VA = "0x18285C6E0", Slot = "5")]
			public void QPBTPYHSXXL(PRNNMMJSLKB a, HJODGUBVAZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x285C7F0", Offset = "0x285BBF0", VA = "0x18285C7F0", Slot = "6")]
			public void SPOVZIGKTQG(PRNNMMJSLKB a, HJODGUBVAZG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, HJODGUBVAZG, PRNNMMJSLKB, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x28635B0", Offset = "0x28629B0", VA = "0x1828635B0")]
			internal ReducerFactory(ReducerFactory<ActionKind, HJODGUBVAZG, PRNNMMJSLKB, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2863560", Offset = "0x2862960", VA = "0x182863560")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : NTEFXKGQILC.OVQMTXOPMEM<HJODGUBVAZG, PRNNMMJSLKB>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private struct <ReceiveAction>d__2 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public AsyncTaskMethodBuilder<Result<object?, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public PRNNMMJSLKB receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public HJODGUBVAZG action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2864DB0", Offset = "0x28641B0", VA = "0x182864DB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2864F90", Offset = "0x2864390", VA = "0x182864F90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB04E50", Offset = "0xB04250", VA = "0x180B04E50", Slot = "4")]
			public Id32<GPNZGVDAJTA> NEHBWNDMWAP(PRNNMMJSLKB a)
			{
				return default(Id32<GPNZGVDAJTA>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28637C0", Offset = "0x2862BC0", VA = "0x1828637C0", Slot = "5")]
			public void HSEFKNZFZNS(PRNNMMJSLKB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2863690", Offset = "0x2862A90", VA = "0x182863690", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, ZEEUKBHYSTE>> BSDHRXLMENL(PRNNMMJSLKB a, HJODGUBVAZG b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2863820", Offset = "0x2862C20", VA = "0x182863820", Slot = "7")]
			public HJODGUBVAZG[] SOUSUFYBQWV(PRNNMMJSLKB a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Result<object?, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public PRNNMMJSLKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public HJODGUBVAZG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2865000", Offset = "0x2864400", VA = "0x182865000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x28651F0", Offset = "0x28645F0", VA = "0x1828651F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <RequestInitializeFromSave>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<Result<bool, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PRNNMMJSLKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2866730", Offset = "0x2865B30", VA = "0x182866730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x28669B0", Offset = "0x2865DB0", VA = "0x1828669B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <RequestRefreshLifecycle>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public PRNNMMJSLKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2866A20", Offset = "0x2865E20", VA = "0x182866A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2866C00", Offset = "0x2866000", VA = "0x182866C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<GPNZGVDAJTA> DRIXQANIXZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer XRGAKCEBWCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 GYYHPUPPFOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly KVKSDIRUDBG NXTWELHBIDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly NOBNTZOERHO.CreationArgs CHVSJIPVJSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly XRSMZRJFJSJ HMWTEOQBCXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly WFEKSCUWCSM TUUDPYVYBIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly RXRLIJBPBFB OIHMOUNJDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly LFDFMHMNPPW LWRTKYPOSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly VNAMYEJVJKQ RWZBLKDYMVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly VPKJFNXGYKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly HWNHCBXSJJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest YVTUHMEQYZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended GQMATUNCWHF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal VUJTJJOWWBJ BKLFYVAIMFY
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2861C40", Offset = "0x2861040", VA = "0x182861C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal XIJKTMWBCMT TGSEOOIHQMG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2861CA0", Offset = "0x28610A0", VA = "0x182861CA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2861F30", Offset = "0x2861330", VA = "0x182861F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool QLVINBOWQUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2861C30", Offset = "0x2861030", VA = "0x182861C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2861C90", Offset = "0x2861090", VA = "0x182861C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public SBLAATCLHFC XRSMZRJFJSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2862410", Offset = "0x2861810", VA = "0x182862410", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AXULGHPKOHS RXRLIJBPBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2862420", Offset = "0x2861820", VA = "0x182862420", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public VNEDWOBTPPV VNAMYEJVJKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2862440", Offset = "0x2861840", VA = "0x182862440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public DMJVSSJKJXV WFEKSCUWCSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2861200", Offset = "0x2860600", VA = "0x182861200", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ILWWVLKQYQV LFDFMHMNPPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2862430", Offset = "0x2861830", VA = "0x182862430", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NOBNTZOERHO? NOBNTZOERHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2861F50", Offset = "0x2861350", VA = "0x182861F50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2862120", Offset = "0x2861520", VA = "0x182862120")]
		private PRNNMMJSLKB(KVKSDIRUDBG a, Id32<GPNZGVDAJTA> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, XIJKTMWBCMT b, [In] NOBNTZOERHO.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2861320", Offset = "0x2860720", VA = "0x182861320")]
		public static PRNNMMJSLKB New(KVKSDIRUDBG deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<GPNZGVDAJTA> actorId, Id32<JDQQUBYOTBT> rootNetworkObjectId, AEMOPZBEDBJ staticNetSys, FZUHJKMKOUD dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28613F0", Offset = "0x28607F0", VA = "0x1828613F0")]
		public static PRNNMMJSLKB New(KVKSDIRUDBG dependencies, [In] RegistryV2 registryV2, Id32<GPNZGVDAJTA> actorId, Id32<JDQQUBYOTBT> rootNetworkObjectId, AEMOPZBEDBJ staticNetSys, FZUHJKMKOUD dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2860E70", Offset = "0x2860270", VA = "0x182860E70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2862030", Offset = "0x2861430", VA = "0x182862030")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, ZEEUKBHYSTE>> ZWJMVWIPZJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2861110", Offset = "0x2860510", VA = "0x182861110")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, ZEEUKBHYSTE>> IHXTVORHMTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2861D30", Offset = "0x2861130", VA = "0x182861D30")]
		internal void WRREJPYQUFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2861CB0", Offset = "0x28610B0", VA = "0x182861CB0")]
		internal Option<HJODGUBVAZG> WHSHVLCFJQM([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<HJODGUBVAZG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2861050", Offset = "0x2860450", VA = "0x182861050")]
		internal bool FSOHWYYBGYL([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28616B0", Offset = "0x2860AB0", VA = "0x1828616B0")]
		internal Result<HJODGUBVAZG, ZEEUKBHYSTE> QPYAJWWZKDG([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<HJODGUBVAZG, ZEEUKBHYSTE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28610C0", Offset = "0x28604C0", VA = "0x1828610C0")]
		private void HSEFKNZFZNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2861210", Offset = "0x2860610", VA = "0x182861210")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, ZEEUKBHYSTE>> LGZKAEEKAZS(HJODGUBVAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2861830", Offset = "0x2860C30", VA = "0x182861830")]
		private HJODGUBVAZG[] SOUSUFYBQWV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class NLMQEEXWKFL<a> : NBILMTLEEJL, UJRKYRKHPFX, AFOSPUXIYKE where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<YAEGQIMTQZT>? RSZXAAUDARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a OEEWMRVQBKK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<YAEGQIMTQZT>? AZRTSPQEBKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2B48B20", Offset = "0x2B47F20", VA = "0x182B48B20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5845040", Offset = "0x5844440", VA = "0x185845040")]
		internal NLMQEEXWKFL([In] Id128<YAEGQIMTQZT>? lastNode, Id32<AROUVFEABTU>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ZBFABUTCFFT
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2877A20", Offset = "0x2876E20", VA = "0x182877A20")]
		public static Result<DebugExecutionResult, UJRKYRKHPFX> CDMNGNIQDCC([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, UJRKYRKHPFX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C08080", Offset = "0x3C07480", VA = "0x183C08080")]
		public static Result<TOk, UJRKYRKHPFX> ZFNSBULCTJM<TOk>([In] this Result<TOk, UJRKYRKHPFX> self, [In] Id128<YAEGQIMTQZT>? lastNode, Id32<AROUVFEABTU>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, UJRKYRKHPFX>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KVKSDIRUDBG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		RWYGVNVPHCG.VUJTJJOWWBJ HRMPBGJJHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PRNNMMJSLKB.VUJTJJOWWBJ FCUMHKWXNVN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		HCCGTESCYEY.VUJTJJOWWBJ FJRKQLYYQTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB> CONYTBARIYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.VUJTJJOWWBJ HRGRZLXHLSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		DEPMCWKOSXQ QBMVFWJVZGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		HWWVWTNKRNF BDSKFJNURTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		JZZMFKCCSQP SKITHEBMTAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		DSKKGSMHSDN RFGQBINISEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		OJKJTUFQHTH TCIMFANLPRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}
	}
}
namespace Circuits.All.RecRoom.Payload
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class HMSPGSEDVSL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x285F100", Offset = "0x285E500", VA = "0x18285F100")]
		public static HJODGUBVAZG SGDNKXEOGXU(this HJODGUBVAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x285F030", Offset = "0x285E430", VA = "0x18285F030")]
		public static HJODGUBVAZG HBJOKOQZHIZ(this CompressedPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct CompressedPayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AsyncTaskMethodBuilder<Result<object?, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public PRNNMMJSLKB root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2865260", Offset = "0x2864660", VA = "0x182865260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2865990", Offset = "0x2864D90", VA = "0x182865990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x285C970", Offset = "0x285BD70", VA = "0x18285C970")]
		public static HJODGUBVAZG DBXQWQPDKUW(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x285CB40", Offset = "0x285BF40", VA = "0x18285CB40")]
		public static ReduceAction<ActionKind, CompressedPayload> OFDEMJDVVHR(HJODGUBVAZG actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x285CA30", Offset = "0x285BE30", VA = "0x18285CA30")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, ZEEUKBHYSTE>> LGZKAEEKAZS(PRNNMMJSLKB a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x285E7C0", Offset = "0x285DBC0", VA = "0x18285E7C0")]
		public static HJODGUBVAZG DBXQWQPDKUW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x285E860", Offset = "0x285DC60", VA = "0x18285E860")]
		public static ReduceAction<ActionKind, DestroyPayload> OFDEMJDVVHR(HJODGUBVAZG actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x285E740", Offset = "0x285DB40", VA = "0x18285E740")]
		public static Result<None, PBNWFANOBHV> BZEAZZBWNWI(PRNNMMJSLKB a, [In] DestroyPayload self)
		{
			return default(Result<None, PBNWFANOBHV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct FullInitializePayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder<Result<None, PBNWFANOBHV>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public PRNNMMJSLKB root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, PBNWFANOBHV> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2865A70", Offset = "0x2864E70", VA = "0x182865A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2866010", Offset = "0x2865410", VA = "0x182866010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly CircuitRootData? CircuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly SuperRoomData? SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly CircuitStudioUnitySubAssetUsageData? StudioUnitySubAssetUsageData;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1BB53E0", Offset = "0x1BB47E0", VA = "0x181BB53E0")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x285EA00", Offset = "0x285DE00", VA = "0x18285EA00")]
		public static HJODGUBVAZG? DBXQWQPDKUW(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x285EC40", Offset = "0x285E040", VA = "0x18285EC40")]
		public static ReduceAction<ActionKind, FullInitializePayload> OFDEMJDVVHR(HJODGUBVAZG actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x285EB00", Offset = "0x285DF00", VA = "0x18285EB00")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, PBNWFANOBHV>> LGZKAEEKAZS(PRNNMMJSLKB a, FullInitializePayload b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct MultiPayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public AsyncTaskMethodBuilder<Result<MultiResult, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PRNNMMJSLKB root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, ZEEUKBHYSTE> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, AFOSPUXIYKE>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, AFOSPUXIYKE> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, AFOSPUXIYKE>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2865520", Offset = "0x2864920", VA = "0x182865520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2865A00", Offset = "0x2864E00", VA = "0x182865A00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<HJODGUBVAZG> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		private MultiPayload(IReadOnlyList<HJODGUBVAZG> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x285FD00", Offset = "0x285F100", VA = "0x18285FD00")]
		public static HJODGUBVAZG DBXQWQPDKUW(IReadOnlyList<HJODGUBVAZG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x285FF00", Offset = "0x285F300", VA = "0x18285FF00")]
		public static ReduceAction<ActionKind, MultiPayload> OFDEMJDVVHR(HJODGUBVAZG actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x285FDC0", Offset = "0x285F1C0", VA = "0x18285FDC0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, ZEEUKBHYSTE>> LGZKAEEKAZS(PRNNMMJSLKB a, MultiPayload b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct PartialActionPayload
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class BHFVTANVIEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> FAPQXCUPKYN;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public BHFVTANVIEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x285C3B0", Offset = "0x285B7B0", VA = "0x18285C3B0")]
			internal HJODGUBVAZG LXUFSHDVYSV(int a, int b, [In] ReadOnlySpan<byte> span)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly Id128<M> ActionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly int Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly byte[] Data;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2862940", Offset = "0x2861D40", VA = "0x182862940")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28625E0", Offset = "0x28619E0", VA = "0x1828625E0")]
		public static HJODGUBVAZG DBXQWQPDKUW(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2862840", Offset = "0x2861C40", VA = "0x182862840")]
		public static HJODGUBVAZG[] QITYFJVUMZP(HJODGUBVAZG a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28626F0", Offset = "0x2861AF0", VA = "0x1828626F0")]
		public static ReduceAction<ActionKind, PartialActionPayload> OFDEMJDVVHR(HJODGUBVAZG actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2862450", Offset = "0x2861850", VA = "0x182862450")]
		public static Result<HJODGUBVAZG, ZEEUKBHYSTE> BZEAZZBWNWI(PRNNMMJSLKB a, [In] PartialActionPayload self)
		{
			return default(Result<HJODGUBVAZG, ZEEUKBHYSTE>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public readonly struct PartialInitializePayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AsyncTaskMethodBuilder<Result<bool, PBNWFANOBHV>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PRNNMMJSLKB root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, PBNWFANOBHV> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, PBNWFANOBHV>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2866080", Offset = "0x2865480", VA = "0x182866080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28666C0", Offset = "0x2865AC0", VA = "0x1828666C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly int Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly byte[] Data;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x114F4A0", Offset = "0x114E8A0", VA = "0x18114F4A0")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2862960", Offset = "0x2861D60", VA = "0x182862960")]
		public static HJODGUBVAZG DBXQWQPDKUW(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2862C50", Offset = "0x2862050", VA = "0x182862C50")]
		public static HJODGUBVAZG?[]? YHWTMDHUSGF(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2862B70", Offset = "0x2861F70", VA = "0x182862B70")]
		public static ReduceAction<ActionKind, PartialInitializePayload> OFDEMJDVVHR(HJODGUBVAZG actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2862A40", Offset = "0x2861E40", VA = "0x182862A40")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, PBNWFANOBHV>> LGZKAEEKAZS(PRNNMMJSLKB a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class XRSMZRJFJSJ : SBLAATCLHFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CKIGYYROEAT? ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2877910", Offset = "0x2876D10", VA = "0x182877910", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		internal XRSMZRJFJSJ(PRNNMMJSLKB a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class VDNGABLXTFQ : CKIGYYROEAT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly NOBNTZOERHO PBRLOMSZHZK;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAAC040", Offset = "0xAAB440", VA = "0x180AAC040")]
		public VDNGABLXTFQ(PRNNMMJSLKB a, NOBNTZOERHO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x286A1D0", Offset = "0x28695D0", VA = "0x18286A1D0", Slot = "4")]
		public Result<DebugExecutionResult, UJRKYRKHPFX> BTJUAZZOXIU(Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<BFZTWCPUJVX> inputId)
		{
			return default(Result<DebugExecutionResult, UJRKYRKHPFX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x286A780", Offset = "0x2869B80", VA = "0x18286A780", Slot = "5")]
		public Result<DebugExecutionResult, UJRKYRKHPFX> CNKFWSAYAVJ(Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<AESTKKZGRLS> outputId)
		{
			return default(Result<DebugExecutionResult, UJRKYRKHPFX>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class RWYGVNVPHCG : XIJKTMWBCMT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface VUJTJJOWWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<HVVQBWJJBSH> EXTAVPMTNTE(PRNNMMJSLKB a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void POCBSLXSWTE(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class AVQHDSVSHCE : VUJTJJOWWBJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000029")]
			[CompilerGenerated]
			private struct <DeserializeInstance>d__0 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public AsyncTaskMethodBuilder<HVVQBWJJBSH> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public PRNNMMJSLKB circuitsManager;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				public CircuitRootData cv2RoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				public SuperRoomData cv2SuperRoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400006D")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400006E")]
				private TaskAwaiter<HCCGTESCYEY> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2864360", Offset = "0x2863760", VA = "0x182864360", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2864530", Offset = "0x2863930", VA = "0x182864530", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x285AFD0", Offset = "0x285A3D0", VA = "0x18285AFD0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<HVVQBWJJBSH> EXTAVPMTNTE(PRNNMMJSLKB a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void POCBSLXSWTE(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			protected AVQHDSVSHCE()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <GetInstanceAsync>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<HVVQBWJJBSH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public RWYGVNVPHCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28645A0", Offset = "0x28639A0", VA = "0x1828645A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28647A0", Offset = "0x2863BA0", VA = "0x1828647A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <InitializeAsync>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RWYGVNVPHCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public PRNNMMJSLKB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<HVVQBWJJBSH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2864810", Offset = "0x2863C10", VA = "0x182864810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2864D50", Offset = "0x2864150", VA = "0x182864D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly VUJTJJOWWBJ GOSNOUTRNRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> RRAZJQUWLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> KFBOTWQDIJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource EFMCTAAFEPP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool QLVINBOWQUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xAF9ED0", Offset = "0xAF92D0", VA = "0x180AF9ED0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F40", Offset = "0xAF9340", VA = "0x180AF9F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xC99BC0", Offset = "0xC98FC0", VA = "0x180C99BC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCD6FD0", Offset = "0xCD63D0", VA = "0x180CD6FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool RJZBDLPSLVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x17E0D40", Offset = "0x17E0140", VA = "0x1817E0D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1834860", Offset = "0x1833C60", VA = "0x181834860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public HVVQBWJJBSH? ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAAF000", Offset = "0xAAE400", VA = "0x180AAF000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2863370", Offset = "0x2862770", VA = "0x182863370", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<HVVQBWJJBSH> ZAUWWIDESKX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2863460", Offset = "0x2862860", VA = "0x182863460")]
		public RWYGVNVPHCG(VUJTJJOWWBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2863230", Offset = "0x2862630", VA = "0x182863230", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task ICWXRWVOPJW(PRNNMMJSLKB a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28630C0", Offset = "0x28624C0", VA = "0x1828630C0", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class AJOGDGHNKJF : LJQEZEDYKPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NCWHIAXLMKP GGDYWYXZGJA;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public AJOGDGHNKJF(NCWHIAXLMKP a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class HOCMLTCLFOM
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class UWUPUOBLSUG<a> : CFVHDLAXNSV where a : OYFQEZYOSVF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a AVGGAYNOJRH;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? QBBBMRLSIZB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xC2AFD0", Offset = "0xC2A3D0", VA = "0x180C2AFD0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<YAEGQIMTQZT>? GFPIFZEERHB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x6109AB0", Offset = "0x6108EB0", VA = "0x186109AB0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<LVEMYDMRMXB> MTEMAKEQUCD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B558A0", Offset = "0x2B54CA0", VA = "0x182B558A0", Slot = "5")]
				get
				{
					return default(Id32<LVEMYDMRMXB>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<LVEMYDMRMXB>? HEAIILJUNBR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6109A30", Offset = "0x6108E30", VA = "0x186109A30", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
			public UWUPUOBLSUG(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class FDDWELHBCZK : UWUPUOBLSUG<RBBJHBRUUNU>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? QBBBMRLSIZB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xD5CDE0", Offset = "0xD5C1E0", VA = "0x180D5CDE0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x285E8D0", Offset = "0x285DCD0", VA = "0x18285E8D0")]
			public FDDWELHBCZK(RBBJHBRUUNU a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x285F210", Offset = "0x285E610", VA = "0x18285F210")]
		public static CFVHDLAXNSV New(OYFQEZYOSVF graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class ALWVHYGZCSQ : GOMCQTNAHBB, KRJCTQRUQIF, NDOQTORKZIM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class COMRVCIDYUO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000033")]
			private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public COMRVCIDYUO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public DEPMCWKOSXQ errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x2867E00", Offset = "0x2867200", VA = "0x182867E00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x2868070", Offset = "0x2867470", VA = "0x182868070", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public ALWVHYGZCSQ ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool CFCICDXVGJB;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public COMRVCIDYUO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x285C5F0", Offset = "0x285B9F0", VA = "0x18285C5F0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task RYOVBFWIAGW(DEPMCWKOSXQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class SYFVBRLIFEW
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public SYFVBRLIFEW <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x28680D0", Offset = "0x28674D0", VA = "0x1828680D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x28683B0", Offset = "0x28677B0", VA = "0x1828683B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public ALWVHYGZCSQ ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int CFCICDXVGJB;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public SYFVBRLIFEW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x28635C0", Offset = "0x28629C0", VA = "0x1828635C0")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task MWMJDQSQIGY(DEPMCWKOSXQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class PJBPLOHLOXN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private struct <<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public PJBPLOHLOXN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x2868920", Offset = "0x2867D20", VA = "0x182868920", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x2868DD0", Offset = "0x28681D0", VA = "0x182868DD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string CFCICDXVGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public ALWVHYGZCSQ ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int JZZSKWADKDD;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public PJBPLOHLOXN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2860DA0", Offset = "0x28601A0", VA = "0x182860DA0")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task AZGDZNDVSNQ(DEPMCWKOSXQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class CKYJBOKWLKY
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private struct <<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400009D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400009E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				public CKYJBOKWLKY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x2868410", Offset = "0x2867810", VA = "0x182868410", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x28688C0", Offset = "0x2867CC0", VA = "0x1828688C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string CFCICDXVGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public ALWVHYGZCSQ ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int JZZSKWADKDD;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public CKYJBOKWLKY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x285C520", Offset = "0x285B920", VA = "0x18285C520")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task AQKAIDCNCPM(DEPMCWKOSXQ a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <RequestSetDefaultValue>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool checkStringPurity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ALWVHYGZCSQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2866C70", Offset = "0x2866070", VA = "0x182866C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2867170", Offset = "0x2866570", VA = "0x182867170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly QZOTSQKJWCN TMZUZBUHCQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<EHZDVSQUQJP> AHDHUBFGZKG;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KVKSDIRUDBG AVQHDSVSHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x285A250", Offset = "0x2859650", VA = "0x18285A250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<BFZTWCPUJVX> WKRFWUAKTRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB66200", Offset = "0xB65600", VA = "0x180B66200", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BFZTWCPUJVX>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xC23880", Offset = "0xC22C80", VA = "0x180C23880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<GAODAGDLSAS> DVWWXUKARHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x27F2D90", Offset = "0x27F2190", VA = "0x1827F2D90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<MSJVWGLYDQX> ZCSWPETDZEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xFC8D60", Offset = "0xFC8160", VA = "0x180FC8D60", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<MSJVWGLYDQX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<AROUVFEABTU> VMCZMTXNQZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x28573B0", Offset = "0x28567B0", VA = "0x1828573B0", Slot = "22")]
			get
			{
				return default(Id32<AROUVFEABTU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool CCMGSAPJFKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2857120", Offset = "0x2856520", VA = "0x182857120", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x285ADB0", Offset = "0x285A1B0", VA = "0x18285ADB0")]
		private ALWVHYGZCSQ(PRNNMMJSLKB a, TDRUPTSJFYC b, QZOTSQKJWCN c, Id32<PBWXKRRVJJL> portGroupId, Id32<BFZTWCPUJVX> inputId, Id32<GAODAGDLSAS> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x28588F0", Offset = "0x2857CF0", VA = "0x1828588F0")]
		public static ALWVHYGZCSQ New(PRNNMMJSLKB circuitsManager, TDRUPTSJFYC node, QZOTSQKJWCN input, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId, Id32<BFZTWCPUJVX> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2857B10", Offset = "0x2856F10", VA = "0x182857B10", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2857310", Offset = "0x2856710", VA = "0x182857310", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x28586D0", Offset = "0x2857AD0", VA = "0x1828586D0", Slot = "32")]
		public void NUAHEKCILST(EHZDVSQUQJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2857D70", Offset = "0x2857170", VA = "0x182857D70", Slot = "29")]
		public void JPPBEMXMAGE(VQEQEVYYOAL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2858CA0", Offset = "0x28580A0", VA = "0x182858CA0", Slot = "30")]
		public void OWGURTPVRBF(BRFXEWUEBHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2857A30", Offset = "0x2856E30", VA = "0x182857A30", Slot = "25")]
		protected override void HSUZVJGZXLN(XXILZHJLUVO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28571A0", Offset = "0x28565A0", VA = "0x1828571A0", Slot = "34")]
		public string DINORDLPBSA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x285A270", Offset = "0x2859670", VA = "0x18285A270", Slot = "31")]
		public string TDGZXSBMAOA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x285A030", Offset = "0x2859430", VA = "0x18285A030")]
		private void RJCIDFYAMQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2857970", Offset = "0x2856D70", VA = "0x182857970", Slot = "33")]
		public void HCWKZFVMJWS(EHZDVSQUQJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x285AAB0", Offset = "0x2859EB0", VA = "0x18285AAB0")]
		private void WFWDPMWILHV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2856F40", Offset = "0x2856340", VA = "0x182856F40", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task AAYKNLMLLTN(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x28577D0", Offset = "0x2856BD0", VA = "0x1828577D0")]
		public void GSNJNXLACJU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x285A910", Offset = "0x2859D10", VA = "0x18285A910")]
		private void WFEUCIUQQCM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2857BB0", Offset = "0x2856FB0", VA = "0x182857BB0")]
		private void JDXSKYFURZQ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2858730", Offset = "0x2857B30", VA = "0x182858730")]
		private void NVXFDWVHYTD(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x285AC70", Offset = "0x285A070", VA = "0x18285AC70")]
		private string XIGGIMSUUOW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2858560", Offset = "0x2857960", VA = "0x182858560")]
		private string LOPDWKOYJVJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xC23880", Offset = "0xC22C80", VA = "0x180C23880")]
		internal void HRSPMVCCGZC(Id32<BFZTWCPUJVX> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2857670", Offset = "0x2856A70", VA = "0x182857670")]
		[CompilerGenerated]
		private void GRCASDQYGEP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28575B0", Offset = "0x28569B0", VA = "0x1828575B0")]
		[CompilerGenerated]
		private bool GQWTUWXAWTG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2857680", Offset = "0x2856A80", VA = "0x182857680")]
		[CompilerGenerated]
		private bool GRHHPKKVPPY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2857490", Offset = "0x2856890", VA = "0x182857490")]
		[CompilerGenerated]
		private int GQGZDCPIULF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2857400", Offset = "0x2856800", VA = "0x182857400")]
		[CompilerGenerated]
		private bool GQBSFVVLKZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28575A0", Offset = "0x28569A0", VA = "0x1828575A0")]
		[CompilerGenerated]
		private void GQRMXQDDNHX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28574E0", Offset = "0x28568E0", VA = "0x1828574E0")]
		[CompilerGenerated]
		private bool GQMGAJJGDWO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2857920", Offset = "0x2856D20", VA = "0x182857920")]
		[CompilerGenerated]
		private bool GSSDWFUDDRJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2857740", Offset = "0x2856B40", VA = "0x182857740")]
		[CompilerGenerated]
		private bool GSMWYZAFUGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2857490", Offset = "0x2856890", VA = "0x182857490")]
		[CompilerGenerated]
		private int WBOWILDJDTS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x285A7E0", Offset = "0x2859BE0", VA = "0x18285A7E0")]
		[CompilerGenerated]
		private bool WBUDFRXGNFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x285A8B0", Offset = "0x2859CB0", VA = "0x18285A8B0")]
		[CompilerGenerated]
		private object WBZKCYRDWQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2858500", Offset = "0x2857900", VA = "0x182858500")]
		[CompilerGenerated]
		private void WCERAFLBGBT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x285A680", Offset = "0x2859A80", VA = "0x18285A680")]
		[CompilerGenerated]
		private bool WAZBQQVRBLR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x285A750", Offset = "0x2859B50", VA = "0x18285A750")]
		[CompilerGenerated]
		private string WBEINXPOKXA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x285A7D0", Offset = "0x2859BD0", VA = "0x18285A7D0")]
		[CompilerGenerated]
		private void WBJPLEJLUIJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x285A530", Offset = "0x2859930", VA = "0x18285A530")]
		[CompilerGenerated]
		private bool VZYTEJAEGGY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x285A600", Offset = "0x2859A00", VA = "0x18285A600")]
		[CompilerGenerated]
		private string WAEABPUBPSH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2859F10", Offset = "0x2859310", VA = "0x182859F10")]
		[CompilerGenerated]
		private void QXBYOFOXIXR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2859E40", Offset = "0x2859240", VA = "0x182859E40")]
		[CompilerGenerated]
		private bool QWWRQYUZZMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2859F30", Offset = "0x2859330", VA = "0x182859F30")]
		[CompilerGenerated]
		private string QXMMITCSBUJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2859F20", Offset = "0x2859320", VA = "0x182859F20")]
		[CompilerGenerated]
		private void QXHFLMIUSJA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2859C90", Offset = "0x2859090", VA = "0x182859C90")]
		[CompilerGenerated]
		private bool QWGWZENHXEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2859C20", Offset = "0x2859020", VA = "0x182859C20")]
		[CompilerGenerated]
		private string QWBQBXTKNSY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2859E30", Offset = "0x2859230", VA = "0x182859E30")]
		[CompilerGenerated]
		private void QWRKTSBCQAZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2859D60", Offset = "0x2859160", VA = "0x182859D60")]
		[CompilerGenerated]
		private bool QWMDWLHFGPQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2859FC0", Offset = "0x28593C0", VA = "0x182859FC0")]
		[CompilerGenerated]
		private string QYSBSHSCGKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2859FB0", Offset = "0x28593B0", VA = "0x182859FB0")]
		[CompilerGenerated]
		private void QYMUVAYEWZC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2858210", Offset = "0x2857610", VA = "0x182858210")]
		[CompilerGenerated]
		private bool JWKTPNGUTFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28582E0", Offset = "0x28576E0", VA = "0x1828582E0")]
		[CompilerGenerated]
		private string JWQAMUASCQR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2858130", Offset = "0x2857530", VA = "0x182858130")]
		[CompilerGenerated]
		private void JWAFUZTAAIQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2858140", Offset = "0x2857540", VA = "0x182858140")]
		[CompilerGenerated]
		private bool JWFMSGMXJTZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2858480", Offset = "0x2857880", VA = "0x182858480")]
		[CompilerGenerated]
		private string JXFVEOIKEYS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28584F0", Offset = "0x28578F0", VA = "0x1828584F0")]
		[CompilerGenerated]
		private void JXLCBVCHOKB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2858350", Offset = "0x2857750", VA = "0x182858350")]
		[CompilerGenerated]
		private bool JWVHKAUPMCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2858420", Offset = "0x2857820", VA = "0x182858420")]
		[CompilerGenerated]
		private object JXAOHHOMVNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2858500", Offset = "0x2857900", VA = "0x182858500")]
		[CompilerGenerated]
		private void JYAWTPJZQSC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2857050", Offset = "0x2856450", VA = "0x182857050")]
		[CompilerGenerated]
		private bool BZNFZQEBUMZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class DTCZCZOWJSW
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class HIFTKWAYKSC : SCTDMGVWOLM<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public HIFTKWAYKSC ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x2855F40", Offset = "0x2855340", VA = "0x182855F40")]
				internal object NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x2856370", Offset = "0x2855770", VA = "0x182856370")]
				internal void NDYKJSAVZUH(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x285EFC0", Offset = "0x285E3C0", VA = "0x18285EFC0")]
			public HIFTKWAYKSC(PRNNMMJSLKB a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x285ED50", Offset = "0x285E150", VA = "0x18285ED50", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class HQUGAYYSHFN : UINWNQRHETP<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType HNZSDXWJLRM
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x285F390", Offset = "0x285E790", VA = "0x18285F390")]
			public HQUGAYYSHFN(PRNNMMJSLKB a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class WUVESNTBCOH : SCTDMGVWOLM<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2877680", Offset = "0x2876A80", VA = "0x182877680")]
			public WUVESNTBCOH(PRNNMMJSLKB a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x28773A0", Offset = "0x28767A0", VA = "0x1828773A0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2877500", Offset = "0x2876900", VA = "0x182877500")]
			[CompilerGenerated]
			private bool RAMDDURBCOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2877550", Offset = "0x2876950", VA = "0x182877550")]
			[CompilerGenerated]
			private void RARKBBKYLZR(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class TCRLNLIZQJB : SCTDMGVWOLM<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public TCRLNLIZQJB ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2855EA0", Offset = "0x28552A0", VA = "0x182855EA0")]
				internal void NDTDMLGYQIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x28560D0", Offset = "0x28554D0", VA = "0x1828560D0")]
				internal bool NDYKJSAVZUH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2856440", Offset = "0x2855840", VA = "0x182856440")]
				internal bool NEDRGYUTJFQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2856630", Offset = "0x2855A30", VA = "0x182856630")]
				internal void NEIYEFOQSQZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x28567B0", Offset = "0x2855BB0", VA = "0x1828567B0")]
				internal bool NEOFBMIOCCI()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2863B50", Offset = "0x2862F50", VA = "0x182863B50")]
			public TCRLNLIZQJB(PRNNMMJSLKB a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2863840", Offset = "0x2862C40", VA = "0x182863840", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class OCMVOFWQLEL : SCTDMGVWOLM<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public OCMVOFWQLEL ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> LVCDVHASFNY;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2855DB0", Offset = "0x28551B0", VA = "0x182855DB0")]
				internal object? NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x28569F0", Offset = "0x2855DF0", VA = "0x1828569F0")]
				internal bool NFDZTGQGEKJ(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2856120", Offset = "0x2855520", VA = "0x182856120")]
				internal void NDYKJSAVZUH(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x28564E0", Offset = "0x28558E0", VA = "0x1828564E0")]
				internal string NEDRGYUTJFQ(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2856760", Offset = "0x2855B60", VA = "0x182856760")]
				internal IReadOnlyList<object> NEIYEFOQSQZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2856800", Offset = "0x2855C00", VA = "0x182856800")]
				internal bool NEOFBMIOCCI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x2856870", Offset = "0x2855C70", VA = "0x182856870")]
				internal bool NETLYTCLLNR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x28568C0", Offset = "0x2855CC0", VA = "0x1828568C0")]
				internal void NEYSVZWIUZA(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2860720", Offset = "0x285FB20", VA = "0x182860720")]
			public OCMVOFWQLEL(PRNNMMJSLKB a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2860020", Offset = "0x285F420", VA = "0x182860020", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class RCYZKVTVLTU : SCTDMGVWOLM<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public RCYZKVTVLTU ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2855EF0", Offset = "0x28552F0", VA = "0x182855EF0")]
				internal bool NDTDMLGYQIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x2855FA0", Offset = "0x28553A0", VA = "0x182855FA0")]
				internal void NDYKJSAVZUH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x2856490", Offset = "0x2855890", VA = "0x182856490")]
				internal bool NEDRGYUTJFQ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2863050", Offset = "0x2862450", VA = "0x182863050")]
			public RCYZKVTVLTU(PRNNMMJSLKB a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2862E40", Offset = "0x2862240", VA = "0x182862E40", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class BGKTZCTYTIH : SCTDMGVWOLM<HCPWAQDIOVC>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class LYTSFHXTFCL
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000048")]
				private struct <<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public LYTSFHXTFCL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<UMLOGIGCAWT>, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x28675B0", Offset = "0x28669B0", VA = "0x1828675B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2867990", Offset = "0x2866D90", VA = "0x182867990", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000049")]
				private struct <<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000BD")]
					public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public LYTSFHXTFCL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x2867A00", Offset = "0x2866E00", VA = "0x182867A00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x2867D90", Offset = "0x2867190", VA = "0x182867D90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task DLMSQHZOGYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string DEYAOMUMGRN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public TOJVLYFLUBJ.ARQBUDBPAYR KIPETZXHODE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool XXIPKFJNPIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public BGKTZCTYTIH ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public TOJVLYFLUBJ IJFXJYAHIXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action DUZJFPNEUSA;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public LYTSFHXTFCL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x285F920", Offset = "0x285ED20", VA = "0x18285F920")]
				internal bool XAQCMZQISTY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
				internal string ZVJPKOTWBAT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x285FBB0", Offset = "0x285EFB0", VA = "0x18285FBB0")]
				internal void ZVOWHVNTKMC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x285FC30", Offset = "0x285F030", VA = "0x18285FC30")]
				internal void ZVUDFCHQTXL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x12FD8E0", Offset = "0x12FCCE0", VA = "0x1812FD8E0")]
				internal bool ZUJGYGYJFWA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x285F950", Offset = "0x285ED50", VA = "0x18285F950")]
				internal void ZUONVNSGPHJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x285FB70", Offset = "0x285EF70", VA = "0x18285FB70")]
				internal bool ZUTUSUMDYSS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x285F740", Offset = "0x285EB40", VA = "0x18285F740")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, ZEEUKBHYSTE>> MAYPFXQEAPO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x285F830", Offset = "0x285EC30", VA = "0x18285F830")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, ZEEUKBHYSTE>> OHDPQUUUFRH()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class TJLYPUTVFSL
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200004B")]
				private struct <<BuildConfigMenuInternal>g__CreateNewVersion|0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000C6")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000C7")]
					public AsyncTaskMethodBuilder<Result<Id32<UMLOGIGCAWT>, ZEEUKBHYSTE>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<UMLOGIGCAWT>, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x28671D0", Offset = "0x28665D0", VA = "0x1828671D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x2867540", Offset = "0x2866940", VA = "0x182867540", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public BGKTZCTYTIH ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public OKJTZHVBSRL PKXEAPDEBDS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool OHIBFFKWNSY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public TOJVLYFLUBJ IJFXJYAHIXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public AWMKXQKLHED GLIQWXPFBYC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action LUBVIZFFKJF;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public TJLYPUTVFSL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2863DE0", Offset = "0x28631E0", VA = "0x182863DE0")]
				internal object? NDYKJSAVZUH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2863E50", Offset = "0x2863250", VA = "0x182863E50")]
				internal void NEDRGYUTJFQ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2863F40", Offset = "0x2863340", VA = "0x182863F40")]
				internal string NEIYEFOQSQZ(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2864030", Offset = "0x2863430", VA = "0x182864030")]
				internal IReadOnlyList<object> NEOFBMIOCCI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x28640D0", Offset = "0x28634D0", VA = "0x1828640D0")]
				internal void NETLYTCLLNR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2864230", Offset = "0x2863630", VA = "0x182864230")]
				internal bool NEYSVZWIUZA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x28642A0", Offset = "0x28636A0", VA = "0x1828642A0")]
				internal void NFDZTGQGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2863D10", Offset = "0x2863110", VA = "0x182863D10")]
				internal void NCDAIJDTSWE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2863D60", Offset = "0x2863160", VA = "0x182863D60")]
				internal void NCIHFPXRCHN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x2863BC0", Offset = "0x2862FC0", VA = "0x182863BC0")]
				internal bool DNOZJHYXEFH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x2863C20", Offset = "0x2863020", VA = "0x182863C20")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<UMLOGIGCAWT>, ZEEUKBHYSTE>> ERZMNFTIWJT()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<LVEMYDMRMXB>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x285C370", Offset = "0x285B770", VA = "0x18285C370", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x285C300", Offset = "0x285B700", VA = "0x18285C300")]
			public BGKTZCTYTIH(PRNNMMJSLKB a, HCPWAQDIOVC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x285B970", Offset = "0x285AD70", VA = "0x18285B970", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x285B2E0", Offset = "0x285A6E0", VA = "0x18285B2E0")]
			private void CHZLTWPJGYW(TOJVLYFLUBJ a, Id32<UMLOGIGCAWT>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class FRYQTNKDWYS : ESEJJXNBDSB<ASFEGEQESNR>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1BE4990", Offset = "0x1BE3D90", VA = "0x181BE4990", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool NWIKEAQBOWB
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool EPZTCROSIVS
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool XMSBEBCFKGF
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x285E9A0", Offset = "0x285DDA0", VA = "0x18285E9A0")]
			public FRYQTNKDWYS(PRNNMMJSLKB a, ASFEGEQESNR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class ZEUTKKGJTFG<a> : SCTDMGVWOLM<a> where a : notnull, FTWTPJJQKBO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004E")]
			[CompilerGenerated]
			private struct <AddPortGroup>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public AsyncTaskMethodBuilder<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public ZEUTKKGJTFG<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x4E0C330", Offset = "0x4E0B730", VA = "0x184E0C330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x4E0C680", Offset = "0x4E0BA80", VA = "0x184E0C680", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004F")]
			[CompilerGenerated]
			private struct <RemovePortGroup>d__11 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public ZEUTKKGJTFG<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<PBWXKRRVJJL> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x50C1CC0", Offset = "0x50C10C0", VA = "0x1850C1CC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x50C2010", Offset = "0x50C1410", VA = "0x1850C2010", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<PBWXKRRVJJL>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x3EAB240", Offset = "0x3EAA640", VA = "0x183EAB240", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3EAB210", Offset = "0x3EAA610", VA = "0x183EAB210")]
			protected ZEUTKKGJTFG(PRNNMMJSLKB a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x3EAB050", Offset = "0x3EAA450", VA = "0x183EAB050", Slot = "122")]
			[AsyncStateMachine(typeof(ZEUTKKGJTFG<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> TDRQEUYCKJL(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3EAAFB0", Offset = "0x3EAA3B0", VA = "0x183EAAFB0", Slot = "149")]
			public sealed override bool QORRDELGGAQ(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3EAB170", Offset = "0x3EAA570", VA = "0x183EAB170", Slot = "134")]
			protected sealed override bool XUQAAMBCTEC(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3EAAE00", Offset = "0x3EAA200", VA = "0x183EAAE00", Slot = "135")]
			protected override bool ESLRMOMPICN(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3EAAEA0", Offset = "0x3EAA2A0", VA = "0x183EAAEA0", Slot = "123")]
			[AsyncStateMachine(typeof(ZEUTKKGJTFG<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, ZEEUKBHYSTE>> NGFOEGUZUOU(Id32<PBWXKRRVJJL> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class UCSINBBGMEB : ROEHRBXDITQ<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public UCSINBBGMEB ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x2856C40", Offset = "0x2856040", VA = "0x182856C40")]
				internal bool QIUARLCYWPD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x2856B10", Offset = "0x2855F10", VA = "0x182856B10")]
				internal void QIOTUEJBNDU(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x286A100", Offset = "0x2869500", VA = "0x18286A100")]
			public UCSINBBGMEB(PRNNMMJSLKB a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2869EC0", Offset = "0x28692C0", VA = "0x182869EC0", Slot = "151")]
			protected override void KPFEYUPAJFT(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class PHHQKFBJQTI : SCTDMGVWOLM<XEXZFRCFTWH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class OMQYCOONSBK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int BJCYWAQHLZL;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public OMQYCOONSBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2860790", Offset = "0x285FB90", VA = "0x182860790")]
				internal bool IHFQZMYUNYV(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class KTYJSXNJOKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public PHHQKFBJQTI ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> KSKDMIAIQJX;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public KTYJSXNJOKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x285F4D0", Offset = "0x285E8D0", VA = "0x18285F4D0")]
				internal int NDTDMLGYQIY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x285F570", Offset = "0x285E970", VA = "0x18285F570")]
				internal void NDYKJSAVZUH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x285F690", Offset = "0x285EA90", VA = "0x18285F690")]
				internal string? NEDRGYUTJFQ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2860D30", Offset = "0x2860130", VA = "0x182860D30")]
			public PHHQKFBJQTI(PRNNMMJSLKB a, XEXZFRCFTWH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2860CA0", Offset = "0x28600A0", VA = "0x182860CA0")]
			private int NSFMYVMPAUN(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2860B80", Offset = "0x285FF80", VA = "0x182860B80")]
			private void JUOBJIVVECF(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2860830", Offset = "0x285FC30", VA = "0x182860830", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class OSAZBHQBVXY : ESEJJXNBDSB<HHDZOHEXVLZ>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x28607D0", Offset = "0x285FBD0", VA = "0x1828607D0")]
			public OSAZBHQBVXY(PRNNMMJSLKB a, HHDZOHEXVLZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class ESEJJXNBDSB<a> : SCTDMGVWOLM<a> where a : notnull, UIAMHOHUUGD
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class HZLLTHFHYMN
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000059")]
				private struct <<BuildConfigMenuInternal>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000E7")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000E8")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000E9")]
					public HZLLTHFHYMN <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x3C92350", Offset = "0x3C91750", VA = "0x183C92350", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public TOJVLYFLUBJ IJFXJYAHIXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public ESEJJXNBDSB<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action LVHKSNUPOZH;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public HZLLTHFHYMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x4F537A0", Offset = "0x4F52BA0", VA = "0x184F537A0")]
				internal void NDTDMLGYQIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x4F53EC0", Offset = "0x4F532C0", VA = "0x184F53EC0")]
				[AsyncStateMachine(typeof(ESEJJXNBDSB<>.HZLLTHFHYMN.<<BuildConfigMenuInternal>b__6>d))]
				internal void NEYSVZWIUZA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x4F53A60", Offset = "0x4F52E60", VA = "0x184F53A60")]
				internal bool NDYKJSAVZUH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class HZGEWALKPBE
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005B")]
				private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F0")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F1")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F2")]
					public HZGEWALKPBE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x3C91F50", Offset = "0x3C91350", VA = "0x183C91F50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string JITFLYPNWWT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public HZLLTHFHYMN VHOTALYTHEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> LVXFKICHRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> LUWWYAGUWCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action LURQATMXMRG;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public HZGEWALKPBE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x4F533A0", Offset = "0x4F527A0", VA = "0x184F533A0")]
				internal void NEDRGYUTJFQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				internal string NEIYEFOQSQZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
				internal void NEOFBMIOCCI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x4F53700", Offset = "0x4F52B00", VA = "0x184F53700")]
				[AsyncStateMachine(typeof(ESEJJXNBDSB<>.HZGEWALKPBE.<<BuildConfigMenuInternal>b__5>d))]
				internal void NETLYTCLLNR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class VYHZZUSHEGU
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005D")]
				private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000102")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000103")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000104")]
					public VYHZZUSHEGU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<KBHHKAZFCJZ>, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3C8F6F0", Offset = "0x3C8EAF0", VA = "0x183C8F6F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005E")]
				private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000106")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000107")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000108")]
					public VYHZZUSHEGU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3C8FE30", Offset = "0x3C8F230", VA = "0x183C8FE30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005F")]
				private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010A")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010B")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010C")]
					public VYHZZUSHEGU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<GAODAGDLSAS>, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x3C90010", Offset = "0x3C8F410", VA = "0x183C90010", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public ESEJJXNBDSB<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<PBWXKRRVJJL> WRQHTJGBKON;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public TOJVLYFLUBJ IJFXJYAHIXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public ERLKPDQGBMX DSPDTIZOFVK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int CSXCKTHURNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int BEJKPWLEPXL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public BMPZHICKVBE XMIHXOUXIYZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string YEKCICYKGXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<UQZARTWUWXI> KPDKVIBVEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public BMPZHICKVBE UNUCWRRBWGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string STVZYEBXTOT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<UQZARTWUWXI> NFRIAOAYWBO;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VYHZZUSHEGU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x626BE80", Offset = "0x626B280", VA = "0x18626BE80")]
				internal bool FMALAFZIDDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x626BE10", Offset = "0x626B210", VA = "0x18626BE10")]
				internal void FLVECZFKTSM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x626C4D0", Offset = "0x626B8D0", VA = "0x18626C4D0")]
				internal bool UGGQCEAVBQB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x626BF30", Offset = "0x626B330", VA = "0x18626BF30")]
				[AsyncStateMachine(typeof(ESEJJXNBDSB<>.VYHZZUSHEGU.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void FMKYUTNCWAN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x626BEF0", Offset = "0x626B2F0", VA = "0x18626BEF0")]
				internal bool FMFRXMTFMPE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x626C2F0", Offset = "0x626B6F0", VA = "0x18626C2F0")]
				internal void UFLONCZFPWR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x626C160", Offset = "0x626B560", VA = "0x18626C160")]
				internal bool UEASGHPYBVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x626C210", Offset = "0x626B610", VA = "0x18626C210")]
				internal void UEFZDOJVLGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x626C0B0", Offset = "0x626B4B0", VA = "0x18626C0B0")]
				internal bool OBFZCWFQSPR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x626BCA0", Offset = "0x626B0A0", VA = "0x18626BCA0")]
				internal bool FLFJLEXSRKL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x626BC30", Offset = "0x626B030", VA = "0x18626BC30")]
				internal void FLACNYDVHZC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x626BD70", Offset = "0x626B170", VA = "0x18626BD70")]
				[AsyncStateMachine(typeof(ESEJJXNBDSB<>.VYHZZUSHEGU.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void FLPXFSLNKHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x626BD10", Offset = "0x626B110", VA = "0x18626BD10")]
				internal bool FLKQILRQAVU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x626C040", Offset = "0x626B440", VA = "0x18626C040")]
				internal bool FNQOEICNAQP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x626BFD0", Offset = "0x626B3D0", VA = "0x18626BFD0")]
				internal void FNLHHBIPRFG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x626C3D0", Offset = "0x626B7D0", VA = "0x18626C3D0")]
				[AsyncStateMachine(typeof(ESEJJXNBDSB<>.VYHZZUSHEGU.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void UFQVKJTCZIA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x626C470", Offset = "0x626B870", VA = "0x18626C470")]
				internal bool UFWCHQNAITJ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class VYNGXBMENSD
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000061")]
				private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000113")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000114")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000115")]
					public VYNGXBMENSD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x3C8F9E0", Offset = "0x3C8EDE0", VA = "0x183C8F9E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string QICGPEJCINF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public VYHZZUSHEGU VHOTALYTHEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> SDJZJPFMMCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> SDPGGVZJVNV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action SDUNECTHEZE;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VYNGXBMENSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x626C5B0", Offset = "0x626B9B0", VA = "0x18626C5B0")]
				internal void UGBJEXGXSES()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				internal string UEVTVIRNNOQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
				internal void UFBASPLKWZZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x626C510", Offset = "0x626B910", VA = "0x18626C510")]
				[AsyncStateMachine(typeof(ESEJJXNBDSB<>.VYNGXBMENSD.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void UFGHPWFIGLI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class IWLGJUOWHTJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool KPDKVIBVEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public ERLKPDQGBMX DSPDTIZOFVK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<UQZARTWUWXI> CWQUQWQQPLY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public ESEJJXNBDSB<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<PBWXKRRVJJL> WRQHTJGBKON;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int UATMQQQINBO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> LVMRPUOMYKQ;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public IWLGJUOWHTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x5021510", Offset = "0x5020910", VA = "0x185021510")]
				internal bool OGWWRZYAQWR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class IWFZMNUYYIA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public NDOQTORKZIM SYRZNFMEGVD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public IWLGJUOWHTJ VHOTALYTHEL;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public IWFZMNUYYIA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x5021350", Offset = "0x5020750", VA = "0x185021350")]
				internal void OGHCAFQIOOQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x50214C0", Offset = "0x50208C0", VA = "0x1850214C0")]
				internal bool OGMIXMKFXZZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x5021160", Offset = "0x5020560", VA = "0x185021160")]
				internal void OFWOFSCNVRY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x50212F0", Offset = "0x50206F0", VA = "0x1850212F0")]
				internal bool OGBVCYWLFDH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class IWVUEICRAQB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public UQZARTWUWXI YMHXCPWLSLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public IWFZMNUYYIA VHTZXSSQQPU;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public IWVUEICRAQB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x5021570", Offset = "0x5020970", VA = "0x185021570")]
				internal void OGRPUTEDHLI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class FRYBAHCWFOW
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000066")]
				private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012A")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012B")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012C")]
					public FRYBAHCWFOW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x3C931D0", Offset = "0x3C925D0", VA = "0x183C931D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> QNFDTCKASBV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public BMPZHICKVBE CGMWPHDPCEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool KPDKVIBVEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public ERLKPDQGBMX DSPDTIZOFVK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public NDOQTORKZIM SYRZNFMEGVD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string QICGPEJCINF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public FRYBAHCWFOW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x4D6B910", Offset = "0x4D6AD10", VA = "0x184D6B910")]
				internal int OVECRLZLYNG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x4D6B950", Offset = "0x4D6AD50", VA = "0x184D6B950")]
				internal void OVJJOSTJHYP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0")]
				internal string OVOQLZNGRJY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x4D6BBA0", Offset = "0x4D6AFA0", VA = "0x184D6BBA0")]
				[AsyncStateMachine(typeof(ESEJJXNBDSB<>.FRYBAHCWFOW.<<CreatePortItemV2>b__3>d))]
				internal void OVTXJGHEAVH(string a)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000067")]
			[CompilerGenerated]
			private struct <AddPortGroup>d__20 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public AsyncTaskMethodBuilder<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public ESEJJXNBDSB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x4E0BF10", Offset = "0x4E0B310", VA = "0x184E0BF10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x4E0C2C0", Offset = "0x4E0B6C0", VA = "0x184E0C2C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000068")]
			[CompilerGenerated]
			private struct <RemovePortGroup>d__21 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public ESEJJXNBDSB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<PBWXKRRVJJL> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x50C2080", Offset = "0x50C1480", VA = "0x1850C2080", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x50C23B0", Offset = "0x50C17B0", VA = "0x1850C23B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000069")]
			[CompilerGenerated]
			private struct <RequestDeleteAllBoardContent>d__26 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public AsyncTaskMethodBuilder<Result<MultiResult, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public ESEJJXNBDSB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x50C79A0", Offset = "0x50C6DA0", VA = "0x1850C79A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x50C7F40", Offset = "0x50C7340", VA = "0x1850C7F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<PBWXKRRVJJL>, bool> ZDTXCMZQXCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<PBWXKRRVJJL>, bool> YVOXISGWYHR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<PBWXKRRVJJL>, bool> KCCNFCENIAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<PBWXKRRVJJL>, bool> SLOWTZCLSTZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<PBWXKRRVJJL>, bool> KPBPXJVSBWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<PBWXKRRVJJL>, bool> OBFAJYXKUPQ;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool NWIKEAQBOWB
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool EPZTCROSIVS
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool XMSBEBCFKGF
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<LVEMYDMRMXB>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x4754840", Offset = "0x4753C40", VA = "0x184754840", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<PBWXKRRVJJL>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x4754AA0", Offset = "0x4753EA0", VA = "0x184754AA0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<YAEGQIMTQZT>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x47548C0", Offset = "0x4753CC0", VA = "0x1847548C0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4754670", Offset = "0x4753A70", VA = "0x184754670")]
			public ESEJJXNBDSB(PRNNMMJSLKB a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "154")]
			protected virtual bool FQJNKSSKJKE(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "155")]
			protected virtual bool QZFAHSNOGQD(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "156")]
			protected virtual bool ROEEWQKUUWC(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "157")]
			protected virtual void LMFPSTGQXVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4752FD0", Offset = "0x47523D0", VA = "0x184752FD0", Slot = "149")]
			public override bool QORRDELGGAQ(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4753070", Offset = "0x4752470", VA = "0x184753070", Slot = "122")]
			[AsyncStateMachine(typeof(ESEJJXNBDSB<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> TDRQEUYCKJL(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4751230", Offset = "0x4750630", VA = "0x184751230", Slot = "123")]
			[AsyncStateMachine(typeof(ESEJJXNBDSB<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, ZEEUKBHYSTE>> NGFOEGUZUOU(Id32<PBWXKRRVJJL> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4751090", Offset = "0x4750490", VA = "0x184751090", Slot = "124")]
			public override void MXZQISLVKIA(Id32<PBWXKRRVJJL> index, Id32<PBWXKRRVJJL> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4751340", Offset = "0x4750740", VA = "0x184751340", Slot = "125")]
			public override IEnumerable<HJODGUBVAZG> POLCJZDNQOT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4751580", Offset = "0x4750980", VA = "0x184751580")]
			[AsyncStateMachine(typeof(ESEJJXNBDSB<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, ZEEUKBHYSTE>> QACNPXEVQES()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "158")]
			protected virtual bool KVLYCFOLNDV(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "159")]
			protected virtual bool QRFSTUZWUPV(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "160")]
			protected virtual bool HBPULBGQEFY(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "161")]
			protected virtual bool OLNSYVVJZJW(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "162")]
			protected virtual bool BVONUZAIRBM(Id32<PBWXKRRVJJL> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "163")]
			protected virtual bool YPVFLGKLILZ(Id32<PBWXKRRVJJL> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "164")]
			protected virtual bool BJWICPJWWPD(Id32<PBWXKRRVJJL> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "165")]
			protected virtual bool PNRFQKGQNXU(Id32<PBWXKRRVJJL> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "166")]
			protected virtual bool AGPANXWVHJM(Id32<PBWXKRRVJJL> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "167")]
			protected virtual bool EMSOSQIJZCR(Id32<PBWXKRRVJJL> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x47543E0", Offset = "0x47537E0", VA = "0x1847543E0", Slot = "168")]
			protected virtual List<BMPZHICKVBE> ZNLICHIEKUN(Id32<PBWXKRRVJJL> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "169")]
			protected virtual void CHOXYLTGDIS(TOJVLYFLUBJ a, XCUMKTIUMHX b, ERLKPDQGBMX c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x474FD00", Offset = "0x474F100", VA = "0x18474FD00", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4751680", Offset = "0x4750A80", VA = "0x184751680")]
			private XCUMKTIUMHX QKBHNFWJVKT(TOJVLYFLUBJ a, ERLKPDQGBMX b, Id32<PBWXKRRVJJL> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4753380", Offset = "0x4752780", VA = "0x184753380")]
			private List<UQZARTWUWXI> XXKAXFLFGEQ(TOJVLYFLUBJ a, ERLKPDQGBMX b, XCUMKTIUMHX c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4750700", Offset = "0x474FB00", VA = "0x184750700")]
			private List<UQZARTWUWXI> JLWLNUHGRXY(TOJVLYFLUBJ a, ERLKPDQGBMX b, NDOQTORKZIM c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x4753190", Offset = "0x4752590", VA = "0x184753190")]
			private BMPZHICKVBE UJQPHRFLYHS(List<BMPZHICKVBE> a, NDOQTORKZIM b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x47506A0", Offset = "0x474FAA0", VA = "0x1847506A0")]
			[CompilerGenerated]
			private HJODGUBVAZG FGUUAJALYEG(TDRUPTSJFYC a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class XKFABJEGUHW : SCTDMGVWOLM<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public XKFABJEGUHW ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x285F3F0", Offset = "0x285E7F0", VA = "0x18285F3F0")]
				internal int NDTDMLGYQIY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x285F440", Offset = "0x285E840", VA = "0x18285F440")]
				internal Task<bool> NDYKJSAVZUH(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x28778A0", Offset = "0x2876CA0", VA = "0x1828778A0")]
			public XKFABJEGUHW(PRNNMMJSLKB a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x28776F0", Offset = "0x2876AF0", VA = "0x1828776F0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class AGBIKVZRXVW : ROEHRBXDITQ<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public AGBIKVZRXVW ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x2856BC0", Offset = "0x2855FC0", VA = "0x182856BC0")]
				internal int QIUARLCYWPD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x2856A70", Offset = "0x2855E70", VA = "0x182856A70")]
				internal Task<bool> QIOTUEJBNDU(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2856EE0", Offset = "0x28562E0", VA = "0x182856EE0")]
			public AGBIKVZRXVW(PRNNMMJSLKB a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2856CC0", Offset = "0x28560C0", VA = "0x182856CC0", Slot = "151")]
			protected override void KPFEYUPAJFT(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class VCEWTAROOBE : SCTDMGVWOLM<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xC52740", Offset = "0xC51B40", VA = "0x180C52740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x286A160", Offset = "0x2869560", VA = "0x18286A160")]
			public VCEWTAROOBE(PRNNMMJSLKB a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class VVDJFZLDPKO : SCTDMGVWOLM<MUWNCTQMVSH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class VKMWSMJNIRA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public VVDJFZLDPKO ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public TOJVLYFLUBJ IJFXJYAHIXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> MDQHEXXGIFS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> MEGBWSEYKNT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> MCVFPWVQWMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> MDLAHRDIYUJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> MDFTKKJLPJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> MCFKYCNYUEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> MCAEAVUBKSY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> FDEJDMJBBYS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> FDJQATCYLKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> FCTVIYVGJCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> FCZCGFPDSNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> FDZKSNKQNSC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> FEERPUENXDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> FDOWXZWVUVK;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VKMWSMJNIRA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2873270", Offset = "0x2872670", VA = "0x182873270")]
				internal bool NDTDMLGYQIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x28732C0", Offset = "0x28726C0", VA = "0x1828732C0")]
				internal void NDYKJSAVZUH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2873320", Offset = "0x2872720", VA = "0x182873320")]
				internal bool NEOFBMIOCCI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2873370", Offset = "0x2872770", VA = "0x182873370")]
				internal bool NETLYTCLLNR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x28733C0", Offset = "0x28727C0", VA = "0x1828733C0")]
				internal void NEYSVZWIUZA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2873220", Offset = "0x2872620", VA = "0x182873220")]
				internal bool NCIHFPXRCHN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x286B020", Offset = "0x286A420", VA = "0x18286B020")]
				internal bool DNOZJHYXEFH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x286AFC0", Offset = "0x286A3C0", VA = "0x18286AFC0")]
				internal void DNJSMBEZUTY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x286B120", Offset = "0x286A520", VA = "0x18286B120")]
				internal bool DOKAYJAMPYR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x286B0D0", Offset = "0x286A4D0", VA = "0x18286B0D0")]
				internal bool DOEUBCGPGNI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x286B070", Offset = "0x286A470", VA = "0x18286B070")]
				internal void DNZNDVMRXBZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x286AF70", Offset = "0x286A370", VA = "0x18286AF70")]
				internal bool DLTPHZBUXHE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2873A30", Offset = "0x2872E30", VA = "0x182873A30")]
				internal bool RJFYFLDYFKH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x28739E0", Offset = "0x2872DE0", VA = "0x1828739E0")]
				internal bool RJARIEKAVYY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2873A80", Offset = "0x2872E80", VA = "0x182873A80")]
				internal bool RJQLZYRSYGZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2873B20", Offset = "0x2872F20", VA = "0x182873B20")]
				internal bool RKAZUMFNRDR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2873AD0", Offset = "0x2872ED0", VA = "0x182873AD0")]
				internal bool RJVSXFLQHSI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x286C8E0", Offset = "0x286BCE0", VA = "0x18286C8E0")]
				internal bool KOGEIAGZTXQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x286C930", Offset = "0x286BD30", VA = "0x18286C930")]
				internal bool KOLLFHAXDIZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x286C830", Offset = "0x286BC30", VA = "0x18286C830")]
				internal void KNVQNMTFBAY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2874ED0", Offset = "0x28742D0", VA = "0x182874ED0")]
				internal bool XJJJZBFIGYH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2874F20", Offset = "0x2874320", VA = "0x182874F20")]
				internal bool XJOQWHZFQJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2874F70", Offset = "0x2874370", VA = "0x182874F70")]
				internal bool XJTXTOTCZUZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2874DE0", Offset = "0x28741E0", VA = "0x182874DE0")]
				internal bool XIOIKADSVEX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2874E30", Offset = "0x2874230", VA = "0x182874E30")]
				internal bool XITPHGXQEQG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x286C890", Offset = "0x286BC90", VA = "0x18286C890")]
				internal bool KOAXKTNCKMH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x286C780", Offset = "0x286BB80", VA = "0x18286C780")]
				internal bool KNLCSZFKIEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x286C7D0", Offset = "0x286BBD0", VA = "0x18286C7D0")]
				internal void KNQJQFZHRPP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x286C6E0", Offset = "0x286BAE0", VA = "0x18286C6E0")]
				internal bool KNAOYLRPPHO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x286C730", Offset = "0x286BB30", VA = "0x18286C730")]
				internal bool KNFVVSLMYSX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x286C630", Offset = "0x286BA30", VA = "0x18286C630")]
				internal void KMQBDYDUWKW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x286C690", Offset = "0x286BA90", VA = "0x18286C690")]
				internal bool KMVIBEXSFWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2873990", Offset = "0x2872D90", VA = "0x182873990")]
				internal bool RIKWQKCITQX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2873930", Offset = "0x2872D30", VA = "0x182873930")]
				internal void RIFPTDILKFO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x286D240", Offset = "0x286C640", VA = "0x18286D240")]
				internal List<UQZARTWUWXI> MNZRNSMUZEF(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2874E80", Offset = "0x2874280", VA = "0x182874E80")]
				internal bool XIYWENRNOBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2874FC0", Offset = "0x28743C0", VA = "0x182874FC0")]
				internal int XKUGFWOPUZS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2875010", Offset = "0x2874410", VA = "0x182875010")]
				internal Task<bool> XKZNDDINELB(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x286BA30", Offset = "0x286AE30", VA = "0x18286BA30")]
				internal bool EJVIAMTNNFH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x286B9E0", Offset = "0x286ADE0", VA = "0x18286B9E0")]
				internal bool EJQBDFZQDTY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x286B990", Offset = "0x286AD90", VA = "0x18286B990")]
				internal bool EJKUFZFSUIP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x286B940", Offset = "0x286AD40", VA = "0x18286B940")]
				internal int EJFNISLVKXG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x286B8B0", Offset = "0x286ACB0", VA = "0x18286B8B0")]
				internal Task<bool> EJAGLLRYBLX(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x286B860", Offset = "0x286AC60", VA = "0x18286B860")]
				internal bool EIUZOEYASAO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x286B810", Offset = "0x286AC10", VA = "0x18286B810")]
				internal bool EIPSQYEDIPF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x286B7C0", Offset = "0x286ABC0", VA = "0x18286B7C0")]
				internal bool EIKLTRKFZDW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x286BA80", Offset = "0x286AE80", VA = "0x18286BA80")]
				internal bool ELGEHICVBGS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x286CD10", Offset = "0x286C110", VA = "0x18286CD10")]
				internal bool LKMMZFBQCXQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x286C170", Offset = "0x286B570", VA = "0x18286C170")]
				internal string IZJMGQWSRLN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x286C1C0", Offset = "0x286B5C0", VA = "0x18286C1C0")]
				internal void IZOTDXQQAWW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x286C020", Offset = "0x286B420", VA = "0x18286C020")]
				internal int IYOKRPVDFSD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x286C070", Offset = "0x286B470", VA = "0x18286C070")]
				internal void IYTROWPAPDM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x286C0D0", Offset = "0x286B4D0", VA = "0x18286C0D0")]
				internal bool IYYYMDIXYOV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x286C230", Offset = "0x286B630", VA = "0x18286C230")]
				internal bool JAUINMGAFMY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x286C280", Offset = "0x286B680", VA = "0x18286C280")]
				internal bool JAZPKSZXOYH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x28738E0", Offset = "0x2872CE0", VA = "0x1828738E0")]
				internal float PZVKICKXXSN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2873880", Offset = "0x2872C80", VA = "0x182873880")]
				internal void PZQDKVRAOHE(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2873830", Offset = "0x2872C30", VA = "0x182873830")]
				internal bool PZKWNOXDEVV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x28737E0", Offset = "0x2872BE0", VA = "0x1828737E0")]
				internal bool PZFPQIDFVKM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2873790", Offset = "0x2872B90", VA = "0x182873790")]
				internal bool PZAITBJILZD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x286CC70", Offset = "0x286C070", VA = "0x18286CC70")]
				internal bool LKBZERNVKAY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x286CCC0", Offset = "0x286C0C0", VA = "0x18286CCC0")]
				internal bool LKHGBYHSTMH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x286CE00", Offset = "0x286C200", VA = "0x18286CE00")]
				internal bool LLHOOGDFORA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x286CE50", Offset = "0x286C250", VA = "0x18286CE50")]
				internal void LLMVLMXCYCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2873740", Offset = "0x2872B40", VA = "0x182873740")]
				internal string PYVBVUPLCNU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x28736D0", Offset = "0x2872AD0", VA = "0x1828736D0")]
				internal void PYPUYNVNTCL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x286CD60", Offset = "0x286C160", VA = "0x18286CD60")]
				internal bool LKXATSPKVUI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x286CDB0", Offset = "0x286C1B0", VA = "0x18286CDB0")]
				internal bool LLCHQZJIFFR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x286C980", Offset = "0x286BD80", VA = "0x18286C980")]
				internal bool LIWJVCYLFKW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x286C9D0", Offset = "0x286BDD0", VA = "0x18286C9D0")]
				internal void LJBQSJSIOWF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2874100", Offset = "0x2873500", VA = "0x182874100")]
				internal bool SLDRXXJSSPZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x28740B0", Offset = "0x28734B0", VA = "0x1828740B0")]
				internal bool SKYLAQPVJEQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x28741A0", Offset = "0x28735A0", VA = "0x1828741A0")]
				internal bool SLOFSKXNLMR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2874150", Offset = "0x2873550", VA = "0x182874150")]
				internal bool SLIYVEDQCBI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2873FB0", Offset = "0x28733B0", VA = "0x182873FB0")]
				internal void SKIQIWIDGWP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2873F60", Offset = "0x2873360", VA = "0x182873F60")]
				internal bool SKDJLPOFXLG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2874060", Offset = "0x2873460", VA = "0x182874060")]
				internal bool SKTEDJVXZTH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2874010", Offset = "0x2873410", VA = "0x182874010")]
				internal bool SKNXGDCAQHY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2873F10", Offset = "0x2873310", VA = "0x182873F10")]
				internal bool SJNOTVGNVDF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2873EB0", Offset = "0x28732B0", VA = "0x182873EB0")]
				internal void SJIHWOMQLRW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2874550", Offset = "0x2873950", VA = "0x182874550")]
				internal bool UNYQLXOUGNW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x28745A0", Offset = "0x28739A0", VA = "0x1828745A0")]
				internal bool UODXJEIRPZF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x28745F0", Offset = "0x28739F0", VA = "0x1828745F0")]
				internal bool UOJEGLCOZKO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2874640", Offset = "0x2873A40", VA = "0x182874640")]
				internal bool UOOLDRWMIVX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2874690", Offset = "0x2873A90", VA = "0x182874690")]
				internal object UPEFVMEELDY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2874700", Offset = "0x2873B00", VA = "0x182874700")]
				internal void UPJMSSYBUPH(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2874790", Offset = "0x2873B90", VA = "0x182874790")]
				internal bool UPOTPZRZEAQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x28747E0", Offset = "0x2873BE0", VA = "0x1828747E0")]
				internal bool UPUANGLWNLZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x286AD90", Offset = "0x286A190", VA = "0x18286AD90")]
				internal int BOKONJCZMUW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x286AD30", Offset = "0x286A130", VA = "0x18286AD30")]
				internal void BOFHQCJCDJN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x286AE30", Offset = "0x286A230", VA = "0x18286AE30")]
				internal bool BPFQCKEOYOG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x286ADE0", Offset = "0x286A1E0", VA = "0x18286ADE0")]
				internal bool BPAJFDKRPCX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x286AE80", Offset = "0x286A280", VA = "0x18286AE80")]
				internal int BQARRLGEKHQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2872FD0", Offset = "0x28723D0", VA = "0x182872FD0")]
				internal void MSQFSJSXLXZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2872F80", Offset = "0x2872380", VA = "0x182872F80")]
				internal bool MSKYVCZACMQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2873080", Offset = "0x2872480", VA = "0x182873080")]
				internal bool MTATMXGSEUR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2873030", Offset = "0x2872430", VA = "0x182873030")]
				internal bool MSVMPQMUVJI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2873130", Offset = "0x2872530", VA = "0x182873130")]
				internal int MTVVBYIHQOB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x28730D0", Offset = "0x28724D0", VA = "0x1828730D0")]
				internal void MTQOEROKHCS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x28731D0", Offset = "0x28725D0", VA = "0x1828731D0")]
				internal bool MUGIWLWCJKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2873180", Offset = "0x2872580", VA = "0x182873180")]
				internal bool MUBBZFCEZZK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x286BC70", Offset = "0x286B070", VA = "0x18286BC70")]
				internal bool FYLNJZXOMES()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x286BC00", Offset = "0x286B000", VA = "0x18286BC00")]
				internal object FXVSSFPWJWR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x286BB70", Offset = "0x286AF70", VA = "0x18286BB70")]
				internal void FXFYALIEHOQ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x286BAD0", Offset = "0x286AED0", VA = "0x18286BAD0")]
				internal bool FWVKFXUJORY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x286BB20", Offset = "0x286AF20", VA = "0x18286BB20")]
				internal bool FXARDEOGYDH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x28751D0", Offset = "0x28745D0", VA = "0x1828751D0")]
				internal object? YXUILHPLWMJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2875140", Offset = "0x2874540", VA = "0x182875140")]
				internal void YXPBOAVONBA(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2875340", Offset = "0x2874740", VA = "0x182875340")]
				internal bool YYPKAIRBIFT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x28752F0", Offset = "0x28746F0", VA = "0x1828752F0")]
				internal int YYKDDBXDYUK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2875290", Offset = "0x2874690", VA = "0x182875290")]
				internal void YYEWFVDGPJB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2875240", Offset = "0x2874640", VA = "0x182875240")]
				internal bool YXZPIOJJFXS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x28750F0", Offset = "0x28744F0", VA = "0x1828750F0")]
				internal bool YWEFHFMGYZP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x28750A0", Offset = "0x28744A0", VA = "0x1828750A0")]
				internal bool YVYYJYSJPOG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2873C10", Offset = "0x2873010", VA = "0x182873C10")]
				internal int RXDDMPHJGUA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2873C60", Offset = "0x2873060", VA = "0x182873C60")]
				internal void RXIKJWBGQFJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2873CC0", Offset = "0x28730C0", VA = "0x182873CC0")]
				internal bool RXNRHCVDZQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2873D10", Offset = "0x2873110", VA = "0x182873D10")]
				internal bool RXSYEJPBJCB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2873D60", Offset = "0x2873160", VA = "0x182873D60")]
				internal bool RXYFBQIYSNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2873DB0", Offset = "0x28731B0", VA = "0x182873DB0")]
				internal float RYDLYXCWBYT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2873E00", Offset = "0x2873200", VA = "0x182873E00")]
				internal void RYISWDWTLKC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2873E60", Offset = "0x2873260", VA = "0x182873E60")]
				internal bool RYNZTKQQUVL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2873B70", Offset = "0x2872F70", VA = "0x182873B70")]
				internal bool RVNAINEEJHG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2873BC0", Offset = "0x2872FC0", VA = "0x182873BC0")]
				internal bool RVSHFTYBSSP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2873630", Offset = "0x2872A30", VA = "0x182873630")]
				internal float NVJAZXAHKXB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x28735D0", Offset = "0x28729D0", VA = "0x1828735D0")]
				internal void NVDUCQGKBLS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2873680", Offset = "0x2872A80", VA = "0x182873680")]
				internal bool NVTOUKOCDTT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x28734C0", Offset = "0x28728C0", VA = "0x1828734C0")]
				internal bool NUISNPEUPSI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2873580", Offset = "0x2872980", VA = "0x182873580")]
				internal string NUYNFJMMSAJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2873510", Offset = "0x2872910", VA = "0x182873510")]
				internal void NUTGICSPIPA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2873470", Offset = "0x2872870", VA = "0x182873470")]
				internal bool NTSXVUXCNKH(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2873420", Offset = "0x2872820", VA = "0x182873420")]
				internal bool NTNQYODFDYY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x286BE40", Offset = "0x286B240", VA = "0x18286BE40")]
				internal bool GURWBESEVES()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x286BE90", Offset = "0x286B290", VA = "0x18286BE90")]
				internal bool GUXCYLMCEQB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x286BD80", Offset = "0x286B180", VA = "0x18286BD80")]
				internal string GUHIGREKCIA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x286BDD0", Offset = "0x286B1D0", VA = "0x18286BDD0")]
				internal void GUMPDXYHLTJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x286BF80", Offset = "0x286B380", VA = "0x18286BF80")]
				internal bool GVMXQFTUGYC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x286BFD0", Offset = "0x286B3D0", VA = "0x18286BFD0")]
				internal bool GVSENMNRQJL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x286BEE0", Offset = "0x286B2E0", VA = "0x18286BEE0")]
				internal bool GVCJVSFZOBK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x286BF30", Offset = "0x286B330", VA = "0x18286BF30")]
				internal bool GVHQSYZWXMT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x286BCC0", Offset = "0x286B0C0", VA = "0x18286BCC0")]
				internal string GTBSXCOZXRY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x286BD10", Offset = "0x286B110", VA = "0x18286BD10")]
				internal void GTGZUJIXHDH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x28755E0", Offset = "0x28749E0", VA = "0x1828755E0")]
				internal bool ZUARCMKCFMJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2875590", Offset = "0x2874990", VA = "0x182875590")]
				internal bool ZTVKFFQEWBA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2875540", Offset = "0x2874940", VA = "0x182875540")]
				internal bool ZTQDHYWHMPR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x28754F0", Offset = "0x28748F0", VA = "0x1828754F0")]
				internal bool ZTKWKSCKDEI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x28754A0", Offset = "0x28748A0", VA = "0x1828754A0")]
				internal string ZTFPNLIMTSZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2875430", Offset = "0x2874830", VA = "0x182875430")]
				internal void ZTAIQEOPKHQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x28753E0", Offset = "0x28747E0", VA = "0x1828753E0")]
				internal bool ZSVBSXUSAWH(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2875390", Offset = "0x2874790", VA = "0x182875390")]
				internal bool ZSPUVRAURKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2875680", Offset = "0x2874A80", VA = "0x182875680")]
				internal bool ZVQUGONHCZD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2875630", Offset = "0x2874A30", VA = "0x182875630")]
				internal bool ZVLNJHTJTNU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2874350", Offset = "0x2873750", VA = "0x182874350")]
				internal string TTHKRCBABQI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x28743A0", Offset = "0x28737A0", VA = "0x1828743A0")]
				internal void TTMROIUXLBR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2874410", Offset = "0x2873810", VA = "0x182874410")]
				internal bool TTRYLPOUUNA(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2874460", Offset = "0x2873860", VA = "0x182874460")]
				internal bool TTXFIWISDYJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x28741F0", Offset = "0x28735F0", VA = "0x1828741F0")]
				internal bool TSMJCAZKPWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2874240", Offset = "0x2873640", VA = "0x182874240")]
				internal bool TSRPZHTHZIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2874290", Offset = "0x2873690", VA = "0x182874290")]
				internal string TSWWWONFITQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x28742E0", Offset = "0x28736E0", VA = "0x1828742E0")]
				internal void TTCDTVHCSEZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x28744B0", Offset = "0x28738B0", VA = "0x1828744B0")]
				internal bool TUXNVEEEZDC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2874500", Offset = "0x2873900", VA = "0x182874500")]
				internal bool TVCUSKYCIOL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x286C3E0", Offset = "0x286B7E0", VA = "0x18286C3E0")]
				internal bool KAFPWSEQIBR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x286C390", Offset = "0x286B790", VA = "0x18286C390")]
				internal bool KAAIZLKSYQI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x286C4A0", Offset = "0x286B8A0", VA = "0x18286C4A0")]
				internal string KAQDRFSLAYJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x286C430", Offset = "0x286B830", VA = "0x18286C430")]
				internal void KAKWTYYNRNA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x286C540", Offset = "0x286B940", VA = "0x18286C540")]
				internal bool KBARLTGFTVB(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x286C4F0", Offset = "0x286B8F0", VA = "0x18286C4F0")]
				internal bool KAVKOMMIKJS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x286C5E0", Offset = "0x286B9E0", VA = "0x18286C5E0")]
				internal bool KBLFGGUAMRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x286C590", Offset = "0x286B990", VA = "0x18286C590")]
				internal bool KBFYJAADDGK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x286C340", Offset = "0x286B740", VA = "0x18286C340")]
				internal string JYPMSQBLKOX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x286C2D0", Offset = "0x286B6D0", VA = "0x18286C2D0")]
				internal void JYKFVJHOBDO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x286B3C0", Offset = "0x286A7C0", VA = "0x18286B3C0")]
				internal bool DZMJLHVOEFQ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x286B410", Offset = "0x286A810", VA = "0x18286B410")]
				internal bool DZRQIOPLNQZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x286B2D0", Offset = "0x286A6D0", VA = "0x18286B2D0")]
				internal bool DZBVQUHTLIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x286B320", Offset = "0x286A720", VA = "0x18286B320")]
				internal bool DZHCOBBQUUH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x286B210", Offset = "0x286A610", VA = "0x18286B210")]
				internal string DYRHWGTYSMG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x286B260", Offset = "0x286A660", VA = "0x18286B260")]
				internal void DYWOTNNWBXP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x286B170", Offset = "0x286A570", VA = "0x18286B170")]
				internal bool DYGUBTGDZPO(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x286B1C0", Offset = "0x286A5C0", VA = "0x18286B1C0")]
				internal bool DYMAZAABJAX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x286B610", Offset = "0x286AA10", VA = "0x18286B610")]
				internal bool EBCMPJYTBSK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x286B6B0", Offset = "0x286AAB0", VA = "0x18286B6B0")]
				internal bool EBHTMQSQLDT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2874BC0", Offset = "0x2873FC0", VA = "0x182874BC0")]
				internal string XAMPGUTANKW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2874C10", Offset = "0x2874010", VA = "0x182874C10")]
				internal void XARWEBMXWWF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2874B70", Offset = "0x2873F70", VA = "0x182874B70")]
				internal bool XAHIJNZDDZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2874D40", Offset = "0x2874140", VA = "0x182874D40")]
				internal bool XBHQVVUPZEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2874D90", Offset = "0x2874190", VA = "0x182874D90")]
				internal bool XBMXTCONIPP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2874C80", Offset = "0x2874080", VA = "0x182874C80")]
				internal string XAXDBIGVGHO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2874CD0", Offset = "0x28740D0", VA = "0x182874CD0")]
				internal void XBCJYPASPSX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2874AD0", Offset = "0x2873ED0", VA = "0x182874AD0")]
				internal bool WYWMCSPVPYC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2874B20", Offset = "0x2873F20", VA = "0x182874B20")]
				internal bool WZBSZZJSZJL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x286B660", Offset = "0x286AA60", VA = "0x18286B660")]
				internal bool EBDUFNBDDDF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x286B5C0", Offset = "0x286A9C0", VA = "0x18286B5C0")]
				internal string EAYNIGHFTRW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x286B750", Offset = "0x286AB50", VA = "0x18286B750")]
				internal void EBOIAAOXVZX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x286B700", Offset = "0x286AB00", VA = "0x18286B700")]
				internal bool EBJBCTVAMOO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x286B4B0", Offset = "0x286A8B0", VA = "0x18286B4B0")]
				internal bool EAISQLZNRJV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x286B460", Offset = "0x286A860", VA = "0x18286B460")]
				internal bool EADLTFFQHYM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x286B570", Offset = "0x286A970", VA = "0x18286B570")]
				internal string EATGKZNIKGN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x286B500", Offset = "0x286A900", VA = "0x18286B500")]
				internal void EANZNSTLAVE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x286B370", Offset = "0x286A770", VA = "0x18286B370")]
				internal bool DZIKEEEAWFC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x286C120", Offset = "0x286B520", VA = "0x18286C120")]
				internal bool IZEFJKCVIAE(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2874A20", Offset = "0x2873E20", VA = "0x182874A20")]
				internal float WDVSVCKPLOE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2874A70", Offset = "0x2873E70", VA = "0x182874A70")]
				internal void WEAZSJEMUZN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2874980", Offset = "0x2873D80", VA = "0x182874980")]
				internal bool WDLFAOWUSRM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x28749D0", Offset = "0x2873DD0", VA = "0x1828749D0")]
				internal bool WDQLXVQSCCV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x28748E0", Offset = "0x2873CE0", VA = "0x1828748E0")]
				internal bool WDARGBIZZUU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2874930", Offset = "0x2873D30", VA = "0x182874930")]
				internal int WDFYDICXJGD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2874830", Offset = "0x2873C30", VA = "0x182874830")]
				internal void WCQDLNVFGYC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2874890", Offset = "0x2873C90", VA = "0x182874890")]
				internal bool WCVKIUPCQJL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x286AF20", Offset = "0x286A320", VA = "0x18286AF20")]
				internal bool CYKYXZTTEED()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x286AED0", Offset = "0x286A2D0", VA = "0x18286AED0")]
				internal bool CYFSASZVUSU()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class VKSDPTDKSCJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string VUTPNSCHTYW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public VKMWSMJNIRA VHOTALYTHEL;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VKSDPTDKSCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x28910B0", Offset = "0x28904B0", VA = "0x1828910B0")]
				internal void LKRTWLVNMIZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class VKCIXYVSPUI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] MYYLQIRSYQZ;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VKCIXYVSPUI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x2890D40", Offset = "0x2890140", VA = "0x182890D40")]
				internal bool WELNMWSHNWF(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers GOBATHHAKII;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2877240", Offset = "0x2876640", VA = "0x182877240")]
			public VVDJFZLDPKO(PRNNMMJSLKB a, MUWNCTQMVSH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x28756D0", Offset = "0x2874AD0", VA = "0x1828756D0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class RLFSQWBWCJZ : SCTDMGVWOLM<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2884C50", Offset = "0x2884050", VA = "0x182884C50")]
			public RLFSQWBWCJZ(PRNNMMJSLKB a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x28843A0", Offset = "0x28837A0", VA = "0x1828843A0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2884B50", Offset = "0x2883F50", VA = "0x182884B50")]
			private static string VBXOSJVDHXZ(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2884650", Offset = "0x2883A50", VA = "0x182884650")]
			[CompilerGenerated]
			private object? QUEUZYNVSGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x28846F0", Offset = "0x2883AF0", VA = "0x1828846F0")]
			[CompilerGenerated]
			private void QUKBXFHTBRV(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2884800", Offset = "0x2883C00", VA = "0x182884800")]
			[CompilerGenerated]
			private string QUPIUMBQLDE(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2884A10", Offset = "0x2883E10", VA = "0x182884A10")]
			[CompilerGenerated]
			private IReadOnlyList<object> QUUPRSVNUON()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2884AB0", Offset = "0x2883EB0", VA = "0x182884AB0")]
			[CompilerGenerated]
			private string? QUZWOZPLDZW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2884B10", Offset = "0x2883F10", VA = "0x182884B10")]
			[CompilerGenerated]
			private bool QVFDMGJINLF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class QKJUGASYKCB : SCTDMGVWOLM<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000077")]
				private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000180")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000181")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000182")]
					public JPVXPIJGEKJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x288F770", Offset = "0x288EB70", VA = "0x18288F770", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public QKJUGASYKCB ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x287D3D0", Offset = "0x287C7D0", VA = "0x18287D3D0")]
				internal string NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x287D620", Offset = "0x287CA20", VA = "0x18287D620")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void NDYKJSAVZUH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x287DCA0", Offset = "0x287D0A0", VA = "0x18287DCA0")]
				internal int NEDRGYUTJFQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x287DEE0", Offset = "0x287D2E0", VA = "0x18287DEE0")]
				internal void NEIYEFOQSQZ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2884090", Offset = "0x2883490", VA = "0x182884090")]
			public QKJUGASYKCB(PRNNMMJSLKB a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2883D60", Offset = "0x2883160", VA = "0x182883D60", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class MIVLZBOORHE : SCTDMGVWOLM<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class OMQYCOONSBK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200007A")]
				private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000188")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000189")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400018A")]
					public OMQYCOONSBK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x288FA80", Offset = "0x288EE80", VA = "0x18288FA80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200007B")]
				private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400018E")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400018F")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000190")]
					public OMQYCOONSBK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x2890060", Offset = "0x288F460", VA = "0x182890060", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public MIVLZBOORHE ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public OMQYCOONSBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2883360", Offset = "0x2882760", VA = "0x182883360")]
				internal string NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x28833B0", Offset = "0x28827B0", VA = "0x1828833B0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void NDYKJSAVZUH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2883480", Offset = "0x2882880", VA = "0x182883480")]
				internal int NEDRGYUTJFQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x28834D0", Offset = "0x28828D0", VA = "0x1828834D0")]
				internal Task<bool> NEIYEFOQSQZ(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2883560", Offset = "0x2882960", VA = "0x182883560")]
				internal string NEOFBMIOCCI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x28835B0", Offset = "0x28829B0", VA = "0x1828835B0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void NETLYTCLLNR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2883680", Offset = "0x2882A80", VA = "0x182883680")]
				internal bool NEYSVZWIUZA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x28836D0", Offset = "0x2882AD0", VA = "0x1828836D0")]
				internal void NFDZTGQGEKJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2883280", Offset = "0x2882680", VA = "0x182883280")]
				internal bool NCDAIJDTSWE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x28832D0", Offset = "0x28826D0", VA = "0x1828832D0")]
				internal void NCIHFPXRCHN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2883180", Offset = "0x2882580", VA = "0x182883180")]
				internal float DNOZJHYXEFH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x28830F0", Offset = "0x28824F0", VA = "0x1828830F0")]
				internal void DNJSMBEZUTY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2883090", Offset = "0x2882490", VA = "0x182883090")]
				internal int DNELOULCLIP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x2882FF0", Offset = "0x28823F0", VA = "0x182882FF0")]
				internal void DMZERNRFBXG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x28831D0", Offset = "0x28825D0", VA = "0x1828831D0")]
				internal bool DOKAYJAMPYR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2882810", Offset = "0x2881C10", VA = "0x182882810")]
			public MIVLZBOORHE(PRNNMMJSLKB a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x2881EB0", Offset = "0x28812B0", VA = "0x182881EB0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class USURHHUDWOZ : SCTDMGVWOLM<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public USURHHUDWOZ ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x287D580", Offset = "0x287C980", VA = "0x18287D580")]
				internal Dictionary<string, EnumChoiceData> NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x287D9D0", Offset = "0x287CDD0", VA = "0x18287D9D0")]
				internal int NDYKJSAVZUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x287DA20", Offset = "0x287CE20", VA = "0x18287DA20")]
				internal void NEDRGYUTJFQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x287DF70", Offset = "0x287D370", VA = "0x18287DF70")]
				internal bool NEIYEFOQSQZ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2890CD0", Offset = "0x28900D0", VA = "0x182890CD0")]
			public USURHHUDWOZ(PRNNMMJSLKB a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2890A20", Offset = "0x288FE20", VA = "0x182890A20", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class ROSTJYRYXUA : SCTDMGVWOLM<PYJFNBAQWKJ>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public ROSTJYRYXUA ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x287D470", Offset = "0x287C870", VA = "0x18287D470")]
				internal void NDTDMLGYQIY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2884E40", Offset = "0x2884240", VA = "0x182884E40")]
			public ROSTJYRYXUA(PRNNMMJSLKB a, PYJFNBAQWKJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x2884CC0", Offset = "0x28840C0", VA = "0x182884CC0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class JYNPVJNMOXU<a> : ESEJJXNBDSB<a> where a : notnull, VBGZYDCTDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override TWEXDEECSVL? UDFLTOYKZEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x5133570", Offset = "0x5132970", VA = "0x185133570", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x51335D0", Offset = "0x51329D0", VA = "0x1851335D0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xC6F640", Offset = "0xC6EA40", VA = "0x180C6F640", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x51335B0", Offset = "0x51329B0", VA = "0x1851335B0")]
			public JYNPVJNMOXU(PRNNMMJSLKB a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class LJGXKOSAEZM : JYNPVJNMOXU<PYUVBLAJANF>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class VKMWSMJNIRA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public LJGXKOSAEZM ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VKMWSMJNIRA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2890DB0", Offset = "0x28901B0", VA = "0x182890DB0")]
				internal object NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x2890E10", Offset = "0x2890210", VA = "0x182890E10")]
				internal void NDYKJSAVZUH(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x2890F30", Offset = "0x2890330", VA = "0x182890F30")]
				internal void NEDRGYUTJFQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? CRZCNEBWMVW;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2880850", Offset = "0x287FC50", VA = "0x182880850")]
			public LJGXKOSAEZM(PRNNMMJSLKB a, PYUVBLAJANF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x28802E0", Offset = "0x287F6E0", VA = "0x1828802E0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class YYDTWUSPNWR : SCTDMGVWOLM<UTISNFGZQJY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public YYDTWUSPNWR ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<UWVMSGKSREJ>> ICGVCTAJYXF;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x28786D0", Offset = "0x2877AD0", VA = "0x1828786D0")]
				internal int NDYKJSAVZUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2878BC0", Offset = "0x2877FC0", VA = "0x182878BC0")]
				internal void NEDRGYUTJFQ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class ADOHOXXPZNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<UWVMSGKSREJ> BKKDAQCGQCR;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADOHOXXPZNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x2877EC0", Offset = "0x28772C0", VA = "0x182877EC0")]
				internal bool NEOFBMIOCCI(Id32<UWVMSGKSREJ> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2892FD0", Offset = "0x28923D0", VA = "0x182892FD0")]
			public YYDTWUSPNWR(PRNNMMJSLKB a, UTISNFGZQJY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x2892AC0", Offset = "0x2891EC0", VA = "0x182892AC0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class EINLSHWCOTL : SCTDMGVWOLM<MGAXJACNFWK>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xB46690", Offset = "0xB45A90", VA = "0x180B46690", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x287A470", Offset = "0x2879870", VA = "0x18287A470")]
			public EINLSHWCOTL(PRNNMMJSLKB a, MGAXJACNFWK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class ANGEVWFJZSO : SCTDMGVWOLM<ZTUPEWUEJSP>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xB78A10", Offset = "0xB77E10", VA = "0x180B78A10", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x2879AF0", Offset = "0x2878EF0", VA = "0x182879AF0")]
			public ANGEVWFJZSO(PRNNMMJSLKB a, ZTUPEWUEJSP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "134")]
			protected override bool XUQAAMBCTEC(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class JZGKGZRFDZU : SCTDMGVWOLM<NIBRADWPQBJ>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xB6EB50", Offset = "0xB6DF50", VA = "0x180B6EB50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x287E7B0", Offset = "0x287DBB0", VA = "0x18287E7B0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x287E740", Offset = "0x287DB40", VA = "0x18287E740")]
			public JZGKGZRFDZU(PRNNMMJSLKB a, NIBRADWPQBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class OJYLKUURDJM : SCTDMGVWOLM<NAOVBPHBFFF>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x2882FA0", Offset = "0x28823A0", VA = "0x182882FA0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2882F30", Offset = "0x2882330", VA = "0x182882F30")]
			public OJYLKUURDJM(PRNNMMJSLKB a, NAOVBPHBFFF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class CSYTGKRQCXV : ROEHRBXDITQ<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public CSYTGKRQCXV ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x28793C0", Offset = "0x28787C0", VA = "0x1828793C0")]
				internal float QIUARLCYWPD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x28791D0", Offset = "0x28785D0", VA = "0x1828791D0")]
				internal void QIOTUEJBNDU(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x287A170", Offset = "0x2879570", VA = "0x18287A170")]
			public CSYTGKRQCXV(PRNNMMJSLKB a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2879F00", Offset = "0x2879300", VA = "0x182879F00", Slot = "151")]
			protected override void KPFEYUPAJFT(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class AHPVXEXVXHC : SCTDMGVWOLM<NLDJVXDTOBT>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2879440", Offset = "0x2878840", VA = "0x182879440")]
			public AHPVXEXVXHC(PRNNMMJSLKB a, NLDJVXDTOBT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class QAXTCVZHFCI : SCTDMGVWOLM<MVVIBZHMXYN>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2883CF0", Offset = "0x28830F0", VA = "0x182883CF0")]
			public QAXTCVZHFCI(PRNNMMJSLKB a, MVVIBZHMXYN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class LQIZHTOYCYR : SCTDMGVWOLM<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public LQIZHTOYCYR ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x28780A0", Offset = "0x28774A0", VA = "0x1828780A0")]
				internal bool NDTDMLGYQIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x28782B0", Offset = "0x28776B0", VA = "0x1828782B0")]
				internal void NDYKJSAVZUH(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2880F70", Offset = "0x2880370", VA = "0x182880F70")]
			public LQIZHTOYCYR(PRNNMMJSLKB a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2880CE0", Offset = "0x28800E0", VA = "0x182880CE0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class ZWTOOTSIMCZ : SCTDMGVWOLM<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public ZWTOOTSIMCZ ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> LVCDVHASFNY;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x28780F0", Offset = "0x28774F0", VA = "0x1828780F0")]
				internal object? NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x28790B0", Offset = "0x28784B0", VA = "0x1828790B0")]
				internal bool NFDZTGQGEKJ(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2878810", Offset = "0x2877C10", VA = "0x182878810")]
				internal void NDYKJSAVZUH(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2878D20", Offset = "0x2878120", VA = "0x182878D20")]
				internal string NEDRGYUTJFQ(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2878E70", Offset = "0x2878270", VA = "0x182878E70")]
				internal IReadOnlyList<object> NEIYEFOQSQZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2878EC0", Offset = "0x28782C0", VA = "0x182878EC0")]
				internal bool NEOFBMIOCCI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2878F30", Offset = "0x2878330", VA = "0x182878F30")]
				internal bool NETLYTCLLNR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x2878F80", Offset = "0x2878380", VA = "0x182878F80")]
				internal void NEYSVZWIUZA(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2893730", Offset = "0x2892B30", VA = "0x182893730")]
			public ZWTOOTSIMCZ(PRNNMMJSLKB a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2893040", Offset = "0x2892440", VA = "0x182893040", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class HCFUKCHDJHF : SCTDMGVWOLM<HUQOBTAXLOQ>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class OMQYCOONSBK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int BJCYWAQHLZL;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public OMQYCOONSBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2883240", Offset = "0x2882640", VA = "0x182883240")]
				internal bool IHFQZMYUNYV(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class KTYJSXNJOKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public HCFUKCHDJHF ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> KSKDMIAIQJX;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public KTYJSXNJOKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x287FCC0", Offset = "0x287F0C0", VA = "0x18287FCC0")]
				internal int NDTDMLGYQIY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x287FD60", Offset = "0x287F160", VA = "0x18287FD60")]
				internal void NDYKJSAVZUH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x287FE80", Offset = "0x287F280", VA = "0x18287FE80")]
				internal string? NEDRGYUTJFQ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x287C9E0", Offset = "0x287BDE0", VA = "0x18287C9E0")]
			public HCFUKCHDJHF(PRNNMMJSLKB a, HUQOBTAXLOQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x287C950", Offset = "0x287BD50", VA = "0x18287C950")]
			private int NSFMYVMPAUN(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x287C830", Offset = "0x287BC30", VA = "0x18287C830")]
			private void JUOBJIVVECF(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x287C4E0", Offset = "0x287B8E0", VA = "0x18287C4E0", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class VVPCOGJKYJO : ZEUTKKGJTFG<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xC55D00", Offset = "0xC55100", VA = "0x180C55D00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2891C30", Offset = "0x2891030", VA = "0x182891C30")]
			public VVPCOGJKYJO(PRNNMMJSLKB a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class BRKEQTRDUFI : ROEHRBXDITQ<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public BRKEQTRDUFI ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2879340", Offset = "0x2878740", VA = "0x182879340")]
				internal int QIUARLCYWPD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x2879130", Offset = "0x2878530", VA = "0x182879130")]
				internal void QIOTUEJBNDU(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2879EA0", Offset = "0x28792A0", VA = "0x182879EA0")]
			public BRKEQTRDUFI(PRNNMMJSLKB a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2879C30", Offset = "0x2879030", VA = "0x182879C30", Slot = "151")]
			protected override void KPFEYUPAJFT(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class YAJTUDPFAVW : SCTDMGVWOLM<SOUBSCGSXKB>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public YAJTUDPFAVW ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<UWVMSGKSREJ>> ICGVCTAJYXF;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x2878590", Offset = "0x2877990", VA = "0x182878590")]
				internal int NDYKJSAVZUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2878A60", Offset = "0x2877E60", VA = "0x182878A60")]
				internal void NEDRGYUTJFQ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class ADOHOXXPZNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<UWVMSGKSREJ> BKKDAQCGQCR;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADOHOXXPZNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2877310", VA = "0x182877F10")]
				internal bool NEOFBMIOCCI(Id32<UWVMSGKSREJ> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x28929F0", Offset = "0x2891DF0", VA = "0x1828929F0")]
			public YAJTUDPFAVW(PRNNMMJSLKB a, SOUBSCGSXKB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x28924E0", Offset = "0x28918E0", VA = "0x1828924E0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class OCCPOXZGNHI : SCTDMGVWOLM<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public OCCPOXZGNHI ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x2878050", Offset = "0x2877450", VA = "0x182878050")]
				internal bool NDTDMLGYQIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x2878500", Offset = "0x2877900", VA = "0x182878500")]
				internal void NDYKJSAVZUH(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2882DF0", Offset = "0x28821F0", VA = "0x182882DF0")]
			public OCCPOXZGNHI(PRNNMMJSLKB a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2882C20", Offset = "0x2882020", VA = "0x182882C20", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class QRPBGVMSUEK : SCTDMGVWOLM<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public QRPBGVMSUEK ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x2877FB0", Offset = "0x28773B0", VA = "0x182877FB0")]
				internal bool NDTDMLGYQIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x28783E0", Offset = "0x28777E0", VA = "0x1828783E0")]
				internal void NDYKJSAVZUH(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x28842D0", Offset = "0x28836D0", VA = "0x1828842D0")]
			public QRPBGVMSUEK(PRNNMMJSLKB a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2884100", Offset = "0x2883500", VA = "0x182884100", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class NHBUZZHYDKY : SCTDMGVWOLM<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public NHBUZZHYDKY ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x2877F60", Offset = "0x2877360", VA = "0x182877F60")]
				internal int NDTDMLGYQIY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x2878470", Offset = "0x2877870", VA = "0x182878470")]
				internal void NDYKJSAVZUH(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2882BB0", Offset = "0x2881FB0", VA = "0x182882BB0")]
			public NHBUZZHYDKY(PRNNMMJSLKB a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2882960", Offset = "0x2881D60", VA = "0x182882960", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class NAGNBEMXWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log UMMIJRFVMAQ;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class ZILVBRMHMIQ<a> : SCTDMGVWOLM<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class PHNCDSIYYGP
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000A7")]
				private struct <<AddMessageNamePicker>g__TryCommitMessageSelection|5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CA")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CB")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CC")]
					public PHNCDSIYYGP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x3C90300", Offset = "0x3C8F700", VA = "0x183C90300", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x3C90640", Offset = "0x3C8FA40", VA = "0x183C90640", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload LPZFUXLJIOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public ZILVBRMHMIQ<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public PHNCDSIYYGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x5A45930", Offset = "0x5A44D30", VA = "0x185A45930")]
				[AsyncStateMachine(typeof(ZILVBRMHMIQ<>.PHNCDSIYYGP.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task VVPLTNEDTGU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x5A45A00", Offset = "0x5A44E00", VA = "0x185A45A00")]
				internal void WBVKETHODGX()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class XVAVOXQPSVX
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000A9")]
				private struct <<OnAddOrEditMessageButtonClicked>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001D9")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DA")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DB")]
					public XVAVOXQPSVX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3CA2790", Offset = "0x3CA1B90", VA = "0x183CA2790", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000AA")]
				private struct <<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DD")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DE")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DF")]
					public XVAVOXQPSVX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x3CA3EB0", Offset = "0x3CA32B0", VA = "0x183CA3EB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x3CA45B0", Offset = "0x3CA39B0", VA = "0x183CA45B0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public TOJVLYFLUBJ.ARQBUDBPAYR KIPETZXHODE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string MJKVUADMECP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string WQGMJINTMZD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public ZILVBRMHMIQ<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper OQMYUPDVVCV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool FKKMQGMXHEX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action GVWBYYDDYYR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool JOQDCQOPWHL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string FEGQUFVQSDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action SGAKZZEEETZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action NGEPUTFJSYX;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public XVAVOXQPSVX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3B20", Offset = "0x3DB2F20", VA = "0x183DB3B20")]
				internal void VQYDGEZWLSY(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3B70", Offset = "0x3DB2F70", VA = "0x183DB3B70")]
				internal void VRDKDLTTVEH(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
				internal string APEGYEXSURB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3420", Offset = "0x3DB2820", VA = "0x183DB3420")]
				internal void AOZAAYDVLFS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x3DB36A0", Offset = "0x3DB2AA0", VA = "0x183DB36A0")]
				internal bool APOUSSLNNNT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3600", Offset = "0x3DB2A00", VA = "0x183DB3600")]
				internal char APJNVLRQECK((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
				internal string? APZINFZIGKL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xC512C0", Offset = "0xC506C0", VA = "0x180C512C0")]
				internal bool APUBPZFKWZC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x3DB36B0", Offset = "0x3DB2AB0", VA = "0x183DB36B0")]
				internal void AQJWHTNCZHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x3DB36A0", Offset = "0x3DB2AA0", VA = "0x183DB36A0")]
				internal bool AQEPKMTFPVU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3380", Offset = "0x3DB2780", VA = "0x183DB3380")]
				[AsyncStateMachine(typeof(ZILVBRMHMIQ<>.XVAVOXQPSVX.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void ANODUCUNXEH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3840", Offset = "0x3DB2C40", VA = "0x183DB3840")]
				internal void CBGBWSJSTTD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3770", Offset = "0x3DB2B70", VA = "0x183DB3770")]
				[AsyncStateMachine(typeof(ZILVBRMHMIQ<>.XVAVOXQPSVX.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task BHRZHGNLALM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3A00", Offset = "0x3DB2E00", VA = "0x183DB3A00")]
				internal void VPNGZJQOXRN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3940", Offset = "0x3DB2D40", VA = "0x183DB3940")]
				internal void PMNGYRMKFAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x3DB3340", Offset = "0x3DB2740", VA = "0x183DB3340")]
				internal bool ANIWWWAQNSY()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class TIWVIHDETHS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter KMMATHFNMNL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public ZILVBRMHMIQ<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<TOJVLYFLUBJ.HSUUSLIGQOJ> SEFAYQHBXVW;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public TIWVIHDETHS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0390", Offset = "0x5E9F790", VA = "0x185EA0390")]
				internal bool MGCFJFXVHSQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x5EA03D0", Offset = "0x5E9F7D0", VA = "0x185EA03D0")]
				internal void RCOWZSLRXKE(TOJVLYFLUBJ.HSUUSLIGQOJ a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class TJCCFNXCCTB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool MRQPIRFQKBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public UQZARTWUWXI GLYTPIYFUEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public UQZARTWUWXI COSNKJGAILA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public UQZARTWUWXI QWOUNAEODPX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string AHNJHMXEAZU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public TIWVIHDETHS VHOTALYTHEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action LTWOLSLIAXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action SEUVQKOUADX;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public TJCCFNXCCTB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xC8C930", Offset = "0xC8BD30", VA = "0x180C8C930")]
				internal bool LVPYSOWLKCU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1330", Offset = "0x5EA0730", VA = "0x185EA1330")]
				internal void ZEZOZTXCVQF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0AF0", Offset = "0x5E9FEF0", VA = "0x185EA0AF0")]
				internal void MGSABAFNKAR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0490", Offset = "0x5E9F890", VA = "0x185EA0490")]
				internal void MFHDUEWFVZG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0F40", Offset = "0x5EA0340", VA = "0x185EA0F40")]
				internal void MHHUSUNFMIS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x5EA04B0", Offset = "0x5E9F8B0", VA = "0x185EA04B0")]
				internal void MGHMGMRSRDZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0490", Offset = "0x5E9F890", VA = "0x185EA0490")]
				internal void RDERRMTJZSF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class TJHJCUQZMEK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000AE")]
				private struct <<UpdateParameterFoldout>g__TryCommitToggle|7>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001EE")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001EF")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F0")]
					public TJHJCUQZMEK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2660", Offset = "0x3CB1A60", VA = "0x183CB2660", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2C90", Offset = "0x3CB2090", VA = "0x183CB2C90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool CFCICDXVGJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public TJCCFNXCCTB VHTZXSSQQPU;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public TJHJCUQZMEK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x5EA14A0", Offset = "0x5EA08A0", VA = "0x185EA14A0")]
				[AsyncStateMachine(typeof(ZILVBRMHMIQ<>.TJHJCUQZMEK.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task NRUPBDEYVBF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1430", Offset = "0x5EA0830", VA = "0x185EA1430")]
				internal void MFMKRLQDFKP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class TJMQABKWVPT
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000B0")]
				private struct <<UpdateParameterFoldout>g__TryCommitDeletion|11>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F4")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F5")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F6")]
					public TJMQABKWVPT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2060", Offset = "0x3CB1460", VA = "0x183CB2060", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2600", Offset = "0x3CB1A00", VA = "0x183CB2600", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload RIMNTPXGKLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public TJCCFNXCCTB VHZGUZMOABD;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public TJMQABKWVPT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4DC0", Offset = "0x5EA41C0", VA = "0x185EA4DC0")]
				[AsyncStateMachine(typeof(ZILVBRMHMIQ<>.TJMQABKWVPT.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task SMXIEFJJHTI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4D50", Offset = "0x5EA4150", VA = "0x185EA4D50")]
				internal void RCZKUFZMQGW()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class OMBUVAXXFQR
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000B2")]
				private struct <<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FB")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FC")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FD")]
					public OMBUVAXXFQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x3CB1B80", Offset = "0x3CB0F80", VA = "0x183CB1B80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2000", Offset = "0x3CB1400", VA = "0x183CB2000", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public ZILVBRMHMIQ<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload NSUJRIEQKZA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public TOJVLYFLUBJ.HSUUSLIGQOJ KIPETZXHODE;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public OMBUVAXXFQR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5984B40", Offset = "0x5983F40", VA = "0x185984B40")]
				[AsyncStateMachine(typeof(ZILVBRMHMIQ<>.OMBUVAXXFQR.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task YHESJIVOIQI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5984A60", Offset = "0x5983E60", VA = "0x185984A60")]
				internal bool DLJDOQWLEVE(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x5984940", Offset = "0x5983D40", VA = "0x185984940")]
				internal void DLDWRKCNVJV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x59848F0", Offset = "0x5983CF0", VA = "0x1859848F0")]
				internal void DKYPUDIQLYM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class SYFVBRLIFEW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string NMWRPNAVBNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public UQZARTWUWXI LNAMNCOYBUY;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public SYFVBRLIFEW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x5DBC1B0", Offset = "0x5DBB5B0", VA = "0x185DBC1B0")]
				internal string? ZQJJPEWQBHB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xC31940", Offset = "0xC30D40", VA = "0x180C31940")]
				internal bool ZQECRYCSRVS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x5DBC1D0", Offset = "0x5DBB5D0", VA = "0x185DBC1D0")]
				internal void ZQTXJSKKUDT(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool CJJDFHZKAES;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log UMMIJRFVMAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x3EAE0B0", Offset = "0x3EAD4B0", VA = "0x183EAE0B0")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x3EB01D0", Offset = "0x3EAF5D0", VA = "0x183EB01D0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected TOJVLYFLUBJ IJFXJYAHIXM
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xAA4700", Offset = "0xAA3B00", VA = "0x180AA4700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xAA4730", Offset = "0xAA3B30", VA = "0x180AA4730")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> IIUQGMXQYXP
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xC97B90", Offset = "0xC96F90", VA = "0x180C97B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xE28CA0", Offset = "0xE280A0", VA = "0x180E28CA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected AWMKXQKLHED ZOTDMSDOREU
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xC97B70", Offset = "0xC96F70", VA = "0x180C97B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x144F890", Offset = "0x144EC90", VA = "0x18144F890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected XCUMKTIUMHX JJGQJPVTKDA
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xC97B80", Offset = "0xC96F80", VA = "0x180C97B80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x144F0B0", Offset = "0x144E4B0", VA = "0x18144F0B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x3EB01A0", Offset = "0x3EAF5A0", VA = "0x183EB01A0")]
			protected ZILVBRMHMIQ(PRNNMMJSLKB a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x3EACCE0", Offset = "0x3EAC0E0", VA = "0x183EACCE0", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x3EACC90", Offset = "0x3EAC090", VA = "0x183EACC90", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3EADB30", Offset = "0x3EACF30", VA = "0x183EADB30", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x3EAFE10", Offset = "0x3EAF210", VA = "0x183EAFE10")]
			private void YGPIWCVZCFV(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x3EADBB0", Offset = "0x3EACFB0", VA = "0x183EADBB0", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3EAE100", Offset = "0x3EAD500", VA = "0x183EAE100")]
			private void UKICVDVKWAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x3EABD10", Offset = "0x3EAB110", VA = "0x183EABD10")]
			private void AKLCYVIODJJ(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "151")]
			protected virtual void AKWZHBXQCZA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x3EACAF0", Offset = "0x3EABEF0", VA = "0x183EACAF0")]
			private void BYJVCNRUBVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x3EAE760", Offset = "0x3EADB60", VA = "0x183EAE760")]
			private void XCROWBFTEQD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x3EACD30", Offset = "0x3EAC130", VA = "0x183EACD30")]
			private void DKVCBQTJKYJ(TOJVLYFLUBJ.HSUUSLIGQOJ a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x3EADEB0", Offset = "0x3EAD2B0", VA = "0x183EADEB0")]
			private void ORCFSITEICL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x3EADB80", Offset = "0x3EACF80", VA = "0x183EADB80")]
			protected void EICLJFLEQYF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x3EB00D0", Offset = "0x3EAF4D0", VA = "0x183EB00D0")]
			private void YIGRNXOQCFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0140", Offset = "0x3EAF540", VA = "0x183EB0140")]
			private void YRFLGJZHAYZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x3EADDC0", Offset = "0x3EAD1C0", VA = "0x183EADDC0")]
			private void FSIYRTCJPYQ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x3EAC7F0", Offset = "0x3EABBF0", VA = "0x183EAC7F0")]
			private string ALOLBTTJZJE((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x3EADE20", Offset = "0x3EAD220", VA = "0x183EADE20")]
			private string LMHQCLCRRBX(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x3EAFD00", Offset = "0x3EAF100", VA = "0x183EAFD00")]
			[CompilerGenerated]
			private object? YEGJLBEPGKF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF5A0", Offset = "0x3EAE9A0", VA = "0x183EAF5A0")]
			[CompilerGenerated]
			private void YEBCNUKRWYW(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF530", Offset = "0x3EAE930", VA = "0x183EAF530")]
			[CompilerGenerated]
			private IReadOnlyList<object> YDQOTGWXECE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x3EAFD30", Offset = "0x3EAF130", VA = "0x183EAFD30")]
			[CompilerGenerated]
			private void YFBLACGESDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x3EAFDC0", Offset = "0x3EAF1C0", VA = "0x183EAFDC0")]
			[CompilerGenerated]
			private void YFRFRWNWULQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0160", Offset = "0x3EAF560", VA = "0x183EB0160")]
			[CompilerGenerated]
			private void ZZAXICLKZXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF200", Offset = "0x3EAE600", VA = "0x183EAF200")]
			[CompilerGenerated]
			private void YDOCXQDOXMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x3EADAF0", Offset = "0x3EACEF0", VA = "0x183EADAF0")]
			[CompilerGenerated]
			private void DQMAPOYJHFD(TOJVLYFLUBJ.HSUUSLIGQOJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class YKJVPGWLBHV : ZILVBRMHMIQ<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xB6EB50", Offset = "0xB6DF50", VA = "0x180B6EB50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2892A60", Offset = "0x2891E60", VA = "0x182892A60")]
			public YKJVPGWLBHV(PRNNMMJSLKB a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class LSRBWPYZSUD : ZILVBRMHMIQ<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type DGZTNXENXMY
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x2885270", Offset = "0x2884670", VA = "0x182885270", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope IXXDMVVXSEV
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string ZKQTFPXOJDN
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x11614E0", Offset = "0x11608E0", VA = "0x1811614E0")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x28852C0", Offset = "0x28846C0", VA = "0x1828852C0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2884EB0", Offset = "0x28842B0", VA = "0x182884EB0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool ANVHGNUJOYA(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2885160", Offset = "0x2884560", VA = "0x182885160", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x2884F80", Offset = "0x2884380", VA = "0x182884F80", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x2885010", Offset = "0x2884410", VA = "0x182885010", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(ReceiverScopeSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B7")]
			private class TargetPlayersSelection : IEquatable<TargetPlayersSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000064")]
				[CompilerGenerated]
				protected virtual Type DGZTNXENXMY
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x288AA50", Offset = "0x2889E50", VA = "0x18288AA50", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers XSENSMNVEET
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string ZKQTFPXOJDN
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x11614E0", Offset = "0x11608E0", VA = "0x1811614E0")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x288AAA0", Offset = "0x2889EA0", VA = "0x18288AAA0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x288A690", Offset = "0x2889A90", VA = "0x18288A690", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool ANVHGNUJOYA(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x288A940", Offset = "0x2889D40", VA = "0x18288A940", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x288A760", Offset = "0x2889B60", VA = "0x18288A760", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x288A7F0", Offset = "0x2889BF0", VA = "0x18288A7F0", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000BA")]
				private struct <<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000210")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000211")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000212")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000213")]
					public JPVXPIJGEKJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x288EA60", Offset = "0x288DE60", VA = "0x18288EA60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000BB")]
				private struct <<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000215")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000216")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000217")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000218")]
					public JPVXPIJGEKJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x288EE70", Offset = "0x288E270", VA = "0x18288EE70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public LSRBWPYZSUD ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public AWMKXQKLHED BITKRCPMIWG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> LUBVIZFFKJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> LTWOLSLIAXW;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x287E2C0", Offset = "0x287D6C0", VA = "0x18287E2C0")]
				internal object? PTHPPFAKJEE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x287E680", Offset = "0x287DA80", VA = "0x18287E680")]
				internal bool PUXSTHDPGQY(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x287E3A0", Offset = "0x287D7A0", VA = "0x18287E3A0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void PTMWMLUHSPN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x287CF10", Offset = "0x287C310", VA = "0x18287CF10")]
				internal IReadOnlyList<TargetPlayersSelection> JEMWZKOVWTY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x287E470", Offset = "0x287D870", VA = "0x18287E470")]
				internal object? PUHYBMVXEIX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x287E6E0", Offset = "0x287DAE0", VA = "0x18287E6E0")]
				internal bool PVCZQNXMQCH(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x287E5B0", Offset = "0x287D9B0", VA = "0x18287E5B0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void PUNEYTPUNUG(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> JMSHMTIRCKG;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> JRSYMTMSTIU;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> CCDJIKOKBKU;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2881BA0", Offset = "0x2880FA0", VA = "0x182881BA0")]
			public LSRBWPYZSUD(PRNNMMJSLKB a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x2880FE0", Offset = "0x28803E0", VA = "0x182880FE0", Slot = "151")]
			protected override void AKWZHBXQCZA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2881540", Offset = "0x2880940", VA = "0x182881540")]
			private static IReadOnlyList<TargetPlayersSelection> JTPCWBFLGYJ(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class BQFJXUZYUWQ : UINWNQRHETP<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType HNZSDXWJLRM
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2879BD0", Offset = "0x2878FD0", VA = "0x182879BD0")]
			public BQFJXUZYUWQ(PRNNMMJSLKB a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class AVUPDFRDZQR : SCTDMGVWOLM<TDRUPTSJFYC>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2879B60", Offset = "0x2878F60", VA = "0x182879B60")]
			public AVUPDFRDZQR(PRNNMMJSLKB a, TDRUPTSJFYC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class SCTDMGVWOLM<a> : HDGORUDUZAT, IDisposable where a : notnull, TDRUPTSJFYC
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class LYTSFHXTFCL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public SCTDMGVWOLM<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public PRNNMMJSLKB YRVAFRAHBEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a ZISESPVPFJI;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public LYTSFHXTFCL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x5336B40", Offset = "0x5335F40", VA = "0x185336B40")]
				internal TZUPQZSHOVI MMWFCDADDHB(XRGMJJNTTCZ a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class YPGCONUTQZT
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000C1")]
				private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023C")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023D")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023E")]
					public YPGCONUTQZT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x3C92DC0", Offset = "0x3C921C0", VA = "0x183C92DC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string QICGPEJCINF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, ZEEUKBHYSTE>> RYDVTTKPKGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public SCTDMGVWOLM<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> ZIPDALFZUYI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public TOJVLYFLUBJ IJFXJYAHIXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> AOLETZTKOXG;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public YPGCONUTQZT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				internal string AUGZTHKGMYB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
				internal void AUBSWAQJDMS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x3E3A950", Offset = "0x3E39D50", VA = "0x183E3A950")]
				[AsyncStateMachine(typeof(SCTDMGVWOLM<>.YPGCONUTQZT.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void ATWLYTWLUBJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class LOESHTISKXS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public LOESHTISKXS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x5324B30", Offset = "0x5323F30", VA = "0x185324B30")]
				internal Result<string, ZEEUKBHYSTE> VWZCLMSFTQT(string a)
				{
					return default(Result<string, ZEEUKBHYSTE>);
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000C3")]
			[CompilerGenerated]
			private struct <RequestLocalTransformChange>d__82 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000241")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000242")]
				public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public SCTDMGVWOLM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x50C7FB0", Offset = "0x50C73B0", VA = "0x1850C7FB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x50C8200", Offset = "0x50C7600", VA = "0x1850C8200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			[CompilerGenerated]
			private struct <RequestNameChange>d__224 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000247")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000248")]
				public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public SCTDMGVWOLM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x50C8270", Offset = "0x50C7670", VA = "0x1850C8270", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x50C84F0", Offset = "0x50C78F0", VA = "0x1850C84F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly PRNNMMJSLKB XWJWHOEXNTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool KTXORWCMVNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<PBWXKRRVJJL, TZUPQZSHOVI> VAWKCVNZKIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<PBWXKRRVJJL, ERLKPDQGBMX> UQTJXOHFXOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> DSDQGSSAWUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<PBWXKRRVJJL>>? XHYXTHHSKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<PBWXKRRVJJL>, ERLKPDQGBMX>? HHGZBYSGFPH;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected ZIFYNAHDVNO NCWHIAXLMKP
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x5DAA880", Offset = "0x5DA9C80", VA = "0x185DAA880")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected VTCCODAZOLE VTCCODAZOLE
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x5DAC310", Offset = "0x5DAB710", VA = "0x185DAC310")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected OKJTZHVBSRL PXAMHGZZDGI
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x5DAB6D0", Offset = "0x5DAAAD0", VA = "0x185DAB6D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a TDRUPTSJFYC
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<XNNOENVVCYV> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x13A6780", Offset = "0x13A5B80", VA = "0x1813A6780", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<XNNOENVVCYV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<KKPQBRSEYJS> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x5DACD10", Offset = "0x5DAC110", VA = "0x185DACD10", Slot = "6")]
				get
				{
					return default(Id32<KKPQBRSEYJS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x5DACB80", Offset = "0x5DABF80", VA = "0x185DACB80", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x5DACB60", Offset = "0x5DABF60", VA = "0x185DACB60", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x5DACE70", Offset = "0x5DAC270", VA = "0x185DACE70", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<QEMJZGJSIYE> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD14640", Offset = "0xD13A40", VA = "0x180D14640", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<QEMJZGJSIYE>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD143D0", Offset = "0xD137D0", VA = "0x180D143D0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xAF2380", Offset = "0xAF1780", VA = "0x180AF2380", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x5DACA30", Offset = "0x5DABE30", VA = "0x185DACA30", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x5DACA60", Offset = "0x5DABE60", VA = "0x185DACA60", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x5DACA90", Offset = "0x5DABE90", VA = "0x185DACA90", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x5DACCF0", Offset = "0x5DAC0F0", VA = "0x185DACCF0", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x5DACC20", Offset = "0x5DAC020", VA = "0x185DACC20", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x5DACB00", Offset = "0x5DABF00", VA = "0x185DACB00", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x5DACAD0", Offset = "0x5DABED0", VA = "0x185DACAD0", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xDE7470", Offset = "0xDE6870", VA = "0x180DE7470", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x152ED80", Offset = "0x152E180", VA = "0x18152ED80")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x5DACAC0", Offset = "0x5DABEC0", VA = "0x185DACAC0", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x5DACBD0", Offset = "0x5DABFD0", VA = "0x185DACBD0", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x5DACC90", Offset = "0x5DAC090", VA = "0x185DACC90", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x5DACCC0", Offset = "0x5DAC0C0", VA = "0x185DACCC0", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x5DACC00", Offset = "0x5DAC000", VA = "0x185DACC00", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual OZIBEMWHDXO? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual TWEXDEECSVL? UDFLTOYKZEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<YAEGQIMTQZT>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x5DACB30", Offset = "0x5DABF30", VA = "0x185DACB30", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<LVEMYDMRMXB> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x5DACC40", Offset = "0x5DAC040", VA = "0x185DACC40", Slot = "68")]
				get
				{
					return default(Id128<LVEMYDMRMXB>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<LVEMYDMRMXB> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x5DACBA0", Offset = "0x5DABFA0", VA = "0x185DACBA0", Slot = "59")]
				get
				{
					return default(Id32<LVEMYDMRMXB>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<LVEMYDMRMXB>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<LVEMYDMRMXB>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x5DAC400", Offset = "0x5DAB800", VA = "0x185DAC400", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xAAFA60", Offset = "0xAAEE60", VA = "0x180AAFA60", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xAAFA50", Offset = "0xAAEE50", VA = "0x180AAFA50")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xAAFB50", Offset = "0xAAEF50", VA = "0x180AAFB50", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xAAFAB0", Offset = "0xAAEEB0", VA = "0x180AAFAB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<YAEGQIMTQZT> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x5DACD50", Offset = "0x5DAC150", VA = "0x185DACD50", Slot = "69")]
				get
				{
					return default(Id32<YAEGQIMTQZT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<YAEGQIMTQZT> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x5DACC70", Offset = "0x5DAC070", VA = "0x185DACC70", Slot = "70")]
				get
				{
					return default(Id128<YAEGQIMTQZT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<YAEGQIMTQZT>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x5DACD70", Offset = "0x5DAC170", VA = "0x185DACD70", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<PBWXKRRVJJL, ERLKPDQGBMX> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x5DACE30", Offset = "0x5DAC230", VA = "0x185DACE30", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<PBWXKRRVJJL, ERLKPDQGBMX>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<PBWXKRRVJJL>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action VLRVGGJQLTH
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x5DAC060", Offset = "0x5DAB460", VA = "0x185DAC060", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x5DA9050", Offset = "0x5DA8450", VA = "0x185DA9050", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate WHKAKRFCXDC
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x5DAC4A0", Offset = "0x5DAB8A0", VA = "0x185DAC4A0", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x5DAA7C0", Offset = "0x5DA9BC0", VA = "0x185DAA7C0", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate AWGQOZZKOML
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x5DAAE40", Offset = "0x5DAA240", VA = "0x185DAAE40", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x5DA8FB0", Offset = "0x5DA83B0", VA = "0x185DA8FB0", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action TBHBDRMNQTB
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x5DA90F0", Offset = "0x5DA84F0", VA = "0x185DA90F0", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x5DAAD90", Offset = "0x5DAA190", VA = "0x185DAAD90", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action OCTYZOSOQIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x5DAACF0", Offset = "0x5DAA0F0", VA = "0x185DAACF0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x5DABA80", Offset = "0x5DAAE80", VA = "0x185DABA80", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<PBWXKRRVJJL>, ERLKPDQGBMX> PZKTIXYLHAT
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x5DABBE0", Offset = "0x5DAAFE0", VA = "0x185DABBE0", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x5DAA640", Offset = "0x5DA9A40", VA = "0x185DAA640", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<PBWXKRRVJJL>, ERLKPDQGBMX> FJRWLQWGRKG
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x5DA9400", Offset = "0x5DA8800", VA = "0x185DA9400", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x5DAAB70", Offset = "0x5DA9F70", VA = "0x185DAAB70", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<PBWXKRRVJJL>> OQDWMFLPIRK
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x5DA88B0", Offset = "0x5DA7CB0", VA = "0x185DA88B0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x5DAC1C0", Offset = "0x5DAB5C0", VA = "0x185DAC1C0", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<PBWXKRRVJJL>, Id32<PBWXKRRVJJL>> KBEMPTQRDHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x5DA8D10", Offset = "0x5DA8110", VA = "0x185DA8D10", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x5DAAC30", Offset = "0x5DAA030", VA = "0x185DAAC30", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<PBWXKRRVJJL>, ERLKPDQGBMX> ASWVLFKCQTJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x5DA8690", Offset = "0x5DA7A90", VA = "0x185DA8690", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x5DAA700", Offset = "0x5DA9B00", VA = "0x185DAA700", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<PBWXKRRVJJL>, Id32<PBWXKRRVJJL>> DVVUMBEHAKG
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x5DA8EF0", Offset = "0x5DA82F0", VA = "0x185DA8EF0", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x5DABCA0", Offset = "0x5DAB0A0", VA = "0x185DABCA0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> PCWDILSOCAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x5DA9D90", Offset = "0x5DA9190", VA = "0x185DA9D90", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x5DA9310", Offset = "0x5DA8710", VA = "0x185DA9310", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC5D0", Offset = "0x5DAB9D0", VA = "0x185DAC5D0")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected SCTDMGVWOLM(PRNNMMJSLKB a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x5DA9B10", Offset = "0x5DA8F10", VA = "0x185DA9B10", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x5DA89D0", Offset = "0x5DA7DD0", VA = "0x185DA89D0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x5DA8970", Offset = "0x5DA7D70", VA = "0x185DA8970", Slot = "9")]
			public Task<Result<None, ZEEUKBHYSTE>> DENCMYXURLI(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x5DA9AE0", Offset = "0x5DA8EE0", VA = "0x185DA9AE0")]
			public bool IXCULJRQAMG([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x5DA93D0", Offset = "0x5DA87D0", VA = "0x185DA93D0")]
			public bool HKCLXLRKAZR([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC120", Offset = "0x5DAB520", VA = "0x185DAC120", Slot = "34")]
			public void VGWWGEIKZMH(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x5DA91A0", Offset = "0x5DA85A0", VA = "0x185DA91A0", Slot = "35")]
			public Task GKRVVACTEXR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x5DA8540", Offset = "0x5DA7940", VA = "0x185DA8540", Slot = "36")]
			[AsyncStateMachine(typeof(SCTDMGVWOLM<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, ZEEUKBHYSTE>> BSEYTRFVJIW(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "119")]
			public virtual void RALLTLDCIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xDC5660", Offset = "0xDC4A60", VA = "0x180DC5660")]
			protected void EUMSICHZWOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x1E4F160", Offset = "0x1E4E560", VA = "0x181E4F160")]
			protected void MYCZUTKUOVI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E770", Offset = "0x1E2DB70", VA = "0x181E2E770")]
			private void VSYFKKVNTKC([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x5DABB20", Offset = "0x5DAAF20", VA = "0x185DABB20", Slot = "122")]
			public virtual Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> TDRQEUYCKJL(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x5DAAAB0", Offset = "0x5DA9EB0", VA = "0x185DAAAB0", Slot = "123")]
			public virtual Task<Result<None, ZEEUKBHYSTE>> NGFOEGUZUOU(Id32<PBWXKRRVJJL> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "124")]
			public virtual void MXZQISLVKIA(Id32<PBWXKRRVJJL> sourceId, Id32<PBWXKRRVJJL> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x5DAB270", Offset = "0x5DAA670", VA = "0x185DAB270", Slot = "125")]
			public virtual IEnumerable<HJODGUBVAZG> POLCJZDNQOT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC440", Offset = "0x5DAB840", VA = "0x185DAC440", Slot = "126")]
			public Result<None, ZEEUKBHYSTE> YFWAEWIQXFA(string a)
			{
				return default(Result<None, ZEEUKBHYSTE>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x5DAB960", Offset = "0x5DAAD60", VA = "0x185DAB960", Slot = "50")]
			public bool RSWJJJQDMNA([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x5DA9E50", Offset = "0x5DA9250", VA = "0x185DA9E50")]
			public bool KXEEQGYZILV([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "128")]
			public virtual void XOPRSMUVYVD(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "129")]
			public virtual RFGLQFFUGOM QFANFOMYJAB([In] GNWVAUEMOHN audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x5DA8750", Offset = "0x5DA7B50", VA = "0x185DA8750")]
			protected void BYRYGGNUYMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC400", Offset = "0x5DAB800", VA = "0x185DAC400", Slot = "134")]
			protected virtual bool XUQAAMBCTEC(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x5DAB930", Offset = "0x5DAAD30", VA = "0x185DAB930", Slot = "96")]
			public bool RLLWXELZWUY(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "135")]
			protected virtual bool ESLRMOMPICN(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected virtual void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x5DAAEE0", Offset = "0x5DAA2E0", VA = "0x185DAAEE0")]
			protected void PCITUWKFJXX(TOJVLYFLUBJ a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, ZEEUKBHYSTE>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x5DA94C0", Offset = "0x5DA88C0", VA = "0x185DA94C0")]
			protected void IALWLBKPWJB(TOJVLYFLUBJ a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x5DABD60", Offset = "0x5DAB160", VA = "0x185DABD60", Slot = "146")]
			protected virtual void UIECWOPEYQW(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x5DAADF0", Offset = "0x5DAA1F0", VA = "0x185DAADF0", Slot = "90")]
			public void OWGURTPVRBF(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x5DA92A0", Offset = "0x5DA86A0", VA = "0x185DA92A0", Slot = "91")]
			public CircuitsRigidTransform GOXXRRMHZRY()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "149")]
			public virtual bool QORRDELGGAQ(Id32<PBWXKRRVJJL> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC5B0", Offset = "0x5DAB9B0", VA = "0x185DAC5B0")]
			private void ZDSJICHQQHL([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x5DA9CD0", Offset = "0x5DA90D0", VA = "0x185DA9CD0")]
			private void JUHTSLHESMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xDC5660", Offset = "0xDC4A60", VA = "0x180DC5660", Slot = "97")]
			private void ZXCUJYDHZRZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5DAA0D0", Offset = "0x5DA94D0", VA = "0x185DAA0D0", Slot = "99")]
			private void LJSLFNXLFEK(Id32<PBWXKRRVJJL> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC480", Offset = "0x5DAB880", VA = "0x185DAC480", Slot = "101")]
			private void YJGLSWGYLYL(Id32<PBWXKRRVJJL> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x5DAA8E0", Offset = "0x5DA9CE0", VA = "0x185DAA8E0", Slot = "103")]
			private void MVRULTOILGJ(Id32<PBWXKRRVJJL> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x5DAB310", Offset = "0x5DAA710", VA = "0x185DAB310", Slot = "104")]
			private void QJHSTDZGKHH(Id32<PBWXKRRVJJL> sourceId, Id32<PBWXKRRVJJL> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC100", Offset = "0x5DAB500", VA = "0x185DAC100", Slot = "105")]
			private void UZSIVSXTUGO(Id32<PBWXKRRVJJL> sourceId, Id32<PBWXKRRVJJL> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x14DC930", Offset = "0x14DBD30", VA = "0x1814DC930", Slot = "98")]
			private void PUOQGZAFCSJ(Id32<PBWXKRRVJJL> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x5DA96C0", Offset = "0x5DA8AC0", VA = "0x185DA96C0", Slot = "100")]
			private void IVRAJPHNOTM(Id32<PBWXKRRVJJL> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC540", Offset = "0x5DAB940", VA = "0x185DAC540", Slot = "102")]
			private void YNXEZVNLXMM(Id32<PBWXKRRVJJL> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x5DAA860", Offset = "0x5DA9C60", VA = "0x185DAA860", Slot = "106")]
			private void MQKNYBIKQZI(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x5DA8DD0", Offset = "0x5DA81D0", VA = "0x185DA8DD0", Slot = "150")]
			[AsyncStateMachine(typeof(SCTDMGVWOLM<>.<RequestNameChange>d__224))]
			public Task<Result<None, ZEEUKBHYSTE>> FHSLSFKJBUY(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC280", Offset = "0x5DAB680", VA = "0x185DAC280", Slot = "57")]
			private void WYVTSMWFNEK(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x5DAAA20", Offset = "0x5DA9E20", VA = "0x185DAAA20", Slot = "58")]
			private void MWROKIHVJVD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x5DA9AE0", Offset = "0x5DA8EE0", VA = "0x185DA9AE0", Slot = "30")]
			private bool XFHSNJYNGHN([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x5DA93D0", Offset = "0x5DA87D0", VA = "0x185DA93D0", Slot = "32")]
			private bool YJHJLAANFZA([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x5DAA620", Offset = "0x5DA9A20", VA = "0x185DAA620", Slot = "51")]
			private bool LRKFAACYAAK([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAFA60", Offset = "0xAAEE60", VA = "0x180AAFA60")]
			[CompilerGenerated]
			private string RIFLXDKOFVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x5DAB7C0", Offset = "0x5DAABC0", VA = "0x185DAB7C0")]
			[CompilerGenerated]
			private void RIKSUKELPGL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class LFFNUKQOQHV : ZEUTKKGJTFG<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xC592E0", Offset = "0xC586E0", VA = "0x180C592E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2880280", Offset = "0x287F680", VA = "0x182880280")]
			public LFFNUKQOQHV(PRNNMMJSLKB a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class LDCRWIHRKGX : SCTDMGVWOLM<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BJBOBQXSIDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public LDCRWIHRKGX ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> VRHHCZVJZYW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> QXUGTRBOPGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x287D6F0", Offset = "0x287CAF0", VA = "0x18287D6F0")]
				internal int NDYKJSAVZUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x287DD40", Offset = "0x287D140", VA = "0x18287DD40")]
				internal void NEDRGYUTJFQ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2880210", Offset = "0x287F610", VA = "0x182880210")]
			public LDCRWIHRKGX(PRNNMMJSLKB a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x287FF30", Offset = "0x287F330", VA = "0x18287FF30", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class MNYSWITJQGZ : ESEJJXNBDSB<ZXTZCPACNVY>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2882880", Offset = "0x2881C80", VA = "0x182882880")]
			public MNYSWITJQGZ(PRNNMMJSLKB a, ZXTZCPACNVY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class CXGWPFXNSRZ : SCTDMGVWOLM<HRYJMZVOFJO>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public CXGWPFXNSRZ ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x2878000", Offset = "0x2877400", VA = "0x182878000")]
				internal bool NDTDMLGYQIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x2878220", Offset = "0x2877620", VA = "0x182878220")]
				internal void NDYKJSAVZUH(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x287A3A0", Offset = "0x28797A0", VA = "0x18287A3A0")]
			public CXGWPFXNSRZ(PRNNMMJSLKB a, HRYJMZVOFJO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x287A1D0", Offset = "0x28795D0", VA = "0x18287A1D0", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class KIINRPQBLPG : SCTDMGVWOLM<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000CD")]
				private struct <<BuildConfigMenuInternal>b__4>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000258")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000259")]
					public AsyncTaskMethodBuilder<bool> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x400025A")]
					public JPVXPIJGEKJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x288FDC0", Offset = "0x288F1C0", VA = "0x18288FDC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x288FFF0", Offset = "0x288F3F0", VA = "0x18288FFF0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MCBUJTYSOAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public KIINRPQBLPG ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> DXKWISMZFPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> QSEERVULNVK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x287D810", Offset = "0x287CC10", VA = "0x18287D810")]
				internal int NDYKJSAVZUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x287DB50", Offset = "0x287CF50", VA = "0x18287DB50")]
				internal void NEDRGYUTJFQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x287DE90", Offset = "0x287D290", VA = "0x18287DE90")]
				internal int NEIYEFOQSQZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x287E090", Offset = "0x287D490", VA = "0x18287E090")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> NEOFBMIOCCI(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x287CAB0", Offset = "0x287BEB0", VA = "0x18287CAB0")]
				internal int DLTPHZBUXHE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x287D210", Offset = "0x287C610", VA = "0x18287D210")]
				internal void KOGEIAGZTXQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x287D2A0", Offset = "0x287C6A0", VA = "0x18287D2A0")]
				internal int KOLLFHAXDIZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x287D130", Offset = "0x287C530", VA = "0x18287D130")]
				internal void KNVQNMTFBAY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x287D1C0", Offset = "0x287C5C0", VA = "0x18287D1C0")]
				internal int KOAXKTNCKMH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x287D050", Offset = "0x287C450", VA = "0x18287D050")]
				internal void KNLCSZFKIEG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x287D0E0", Offset = "0x287C4E0", VA = "0x18287D0E0")]
				internal int KNQJQFZHRPP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x287CFC0", Offset = "0x287C3C0", VA = "0x18287CFC0")]
				internal void KNAOYLRPPHO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x287E190", Offset = "0x287D590", VA = "0x18287E190")]
				internal float NETLYTCLLNR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x287E1E0", Offset = "0x287D5E0", VA = "0x18287E1E0")]
				internal void NEYSVZWIUZA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x287E270", Offset = "0x287D670", VA = "0x18287E270")]
				internal float NFDZTGQGEKJ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x287D2F0", Offset = "0x287C6F0", VA = "0x18287D2F0")]
				internal void NCDAIJDTSWE(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x287D380", Offset = "0x287C780", VA = "0x18287D380")]
				internal bool NCIHFPXRCHN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x287CCC0", Offset = "0x287C0C0", VA = "0x18287CCC0")]
				internal void DNOZJHYXEFH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x287CC70", Offset = "0x287C070", VA = "0x18287CC70")]
				internal int DNJSMBEZUTY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x287CBE0", Offset = "0x287BFE0", VA = "0x18287CBE0")]
				internal void DNELOULCLIP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x287CB90", Offset = "0x287BF90", VA = "0x18287CB90")]
				internal float DMZERNRFBXG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x287CE80", Offset = "0x287C280", VA = "0x18287CE80")]
				internal void DOKAYJAMPYR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x287CE30", Offset = "0x287C230", VA = "0x18287CE30")]
				internal float DOEUBCGPGNI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x287CDA0", Offset = "0x287C1A0", VA = "0x18287CDA0")]
				internal void DNZNDVMRXBZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x287CD50", Offset = "0x287C150", VA = "0x18287CD50")]
				internal bool DNUGGOSUNQQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x287CB00", Offset = "0x287BF00", VA = "0x18287CB00")]
				internal void DLYWFFVSGSN(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x287F8F0", Offset = "0x287ECF0", VA = "0x18287F8F0")]
			public KIINRPQBLPG(PRNNMMJSLKB a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x287E800", Offset = "0x287DC00", VA = "0x18287E800", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class QARGBMNESFN : ROEHRBXDITQ<RecNetImageNode>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000CF")]
			[CompilerGenerated]
			private struct <<AddHomeValueSetting>b__1_1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400025E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400025F")]
				public QARGBMNESFN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x288F5F0", Offset = "0x288E9F0", VA = "0x18288F5F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2883C90", Offset = "0x2883090", VA = "0x182883C90")]
			public QARGBMNESFN(PRNNMMJSLKB a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x28837C0", Offset = "0x2882BC0", VA = "0x1828837C0", Slot = "151")]
			protected override void KPFEYUPAJFT(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x2883BC0", Offset = "0x2882FC0", VA = "0x182883BC0")]
			[CompilerGenerated]
			private string? OSFWNDXCHPH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2883AF0", Offset = "0x2882EF0", VA = "0x182883AF0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void OSAPPXDEYDY(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class UINWNQRHETP<a> : SCTDMGVWOLM<a> where a : notnull, ZKSCCVWHZSL
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class KTYJSXNJOKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MCBUJTYSOAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public UINWNQRHETP<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> DXKWISMZFPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> QSEERVULNVK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType TLVSNPDKQCY;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public KTYJSXNJOKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NDTDMLGYQIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x5274960", Offset = "0x5273D60", VA = "0x185274960")]
				internal int NDYKJSAVZUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x5274A80", Offset = "0x5273E80", VA = "0x185274A80")]
				internal void NEDRGYUTJFQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x5274C70", Offset = "0x5274070", VA = "0x185274C70")]
				internal void NEIYEFOQSQZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x5274CC0", Offset = "0x52740C0", VA = "0x185274CC0")]
				internal void NEOFBMIOCCI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x5274DD0", Offset = "0x52741D0", VA = "0x185274DD0")]
				internal bool NETLYTCLLNR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x5274E30", Offset = "0x5274230", VA = "0x185274E30")]
				internal void NEYSVZWIUZA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x5274DD0", Offset = "0x52741D0", VA = "0x185274DD0")]
				internal bool NFDZTGQGEKJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x52748A0", Offset = "0x5273CA0", VA = "0x1852748A0")]
				internal float NCDAIJDTSWE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x52748D0", Offset = "0x5273CD0", VA = "0x1852748D0")]
				internal void NCIHFPXRCHN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x5273E30", Offset = "0x5273230", VA = "0x185273E30")]
				internal float DNOZJHYXEFH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x5273DA0", Offset = "0x52731A0", VA = "0x185273DA0")]
				internal void DNJSMBEZUTY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x5273D70", Offset = "0x5273170", VA = "0x185273D70")]
				internal float DNELOULCLIP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x5273CE0", Offset = "0x52730E0", VA = "0x185273CE0")]
				internal void DMZERNRFBXG(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType HNZSDXWJLRM
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x3EB01A0", Offset = "0x3EAF5A0", VA = "0x183EB01A0")]
			public UINWNQRHETP(PRNNMMJSLKB a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x60F8760", Offset = "0x60F7B60", VA = "0x1860F8760", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class GLPLETDCKPZ : SCTDMGVWOLM<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xC66A30", Offset = "0xC65E30", VA = "0x180C66A30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x287A950", Offset = "0x2879D50", VA = "0x18287A950")]
			public GLPLETDCKPZ(PRNNMMJSLKB a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class TRFXBPESFIY : NNAGQPDGQQI<IKEMJJJMGVM>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x28853B0", Offset = "0x28847B0", VA = "0x1828853B0")]
			public TRFXBPESFIY(PRNNMMJSLKB a, IKEMJJJMGVM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class OHWADGMMNDG : NNAGQPDGQQI<CIJULZMNLRZ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x2882ED0", Offset = "0x28822D0", VA = "0x182882ED0")]
			public OHWADGMMNDG(PRNNMMJSLKB a, CIJULZMNLRZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class NNAGQPDGQQI<a> : SCTDMGVWOLM<a> where a : notnull, MTHNSQNIJQY
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000D6")]
			[CompilerGenerated]
			private struct <<BuildConfigMenuInternal>b__8_1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				public NNAGQPDGQQI<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x3C92BD0", Offset = "0x3C91FD0", VA = "0x183C92BD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class GEAWGGTCVVK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000D9")]
				private struct <<BuildConfigMenuInternal>b__11>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000275")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000276")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000277")]
					public GEAWGGTCVVK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3C918D0", Offset = "0x3C90CD0", VA = "0x183C918D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DA")]
				private struct <<BuildConfigMenuInternal>b__12>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027B")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027C")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027D")]
					public GEAWGGTCVVK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3C91CA0", Offset = "0x3C910A0", VA = "0x183C91CA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DB")]
				private struct <<BuildConfigMenuInternal>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027F")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000280")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000281")]
					public GEAWGGTCVVK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3C92510", Offset = "0x3C91910", VA = "0x183C92510", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DC")]
				private struct <<BuildConfigMenuInternal>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000285")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000286")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000287")]
					public GEAWGGTCVVK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x3C928E0", Offset = "0x3C91CE0", VA = "0x183C928E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int RAJNLHVHZCG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry HZOYQCTGEBQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public NNAGQPDGQQI<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<QNRWKFGEPMB, bool> SEUVQKOUADX;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public GEAWGGTCVVK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x4E8BA10", Offset = "0x4E8AE10", VA = "0x184E8BA10")]
				internal bool NEIYEFOQSQZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x4E8BA70", Offset = "0x4E8AE70", VA = "0x184E8BA70")]
				internal void NEOFBMIOCCI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
				internal string NETLYTCLLNR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x4E8BAE0", Offset = "0x4E8AEE0", VA = "0x184E8BAE0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.GEAWGGTCVVK.<<BuildConfigMenuInternal>b__6>d))]
				internal void NEYSVZWIUZA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x4E8BBA0", Offset = "0x4E8AFA0", VA = "0x184E8BBA0")]
				internal int NFDZTGQGEKJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x4E8B730", Offset = "0x4E8AB30", VA = "0x184E8B730")]
				internal bool DMZERNRFBXG(QNRWKFGEPMB a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x4E8B960", Offset = "0x4E8AD60", VA = "0x184E8B960")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.GEAWGGTCVVK.<<BuildConfigMenuInternal>b__8>d))]
				internal void NCDAIJDTSWE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
				internal string DNOZJHYXEFH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x4E8B7F0", Offset = "0x4E8ABF0", VA = "0x184E8B7F0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.GEAWGGTCVVK.<<BuildConfigMenuInternal>b__11>d))]
				internal void DNJSMBEZUTY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x4E8B750", Offset = "0x4E8AB50", VA = "0x184E8B750")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.GEAWGGTCVVK.<<BuildConfigMenuInternal>b__12>d))]
				internal void DNELOULCLIP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class TJLYPUTVFSL
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DE")]
				private struct <<AddConstraintOptions>b__10>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028C")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028D")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028E")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3C8BD20", Offset = "0x3C8B120", VA = "0x183C8BD20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DF")]
				private struct <<AddConstraintOptions>b__13>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000291")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000292")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000293")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3C8C0A0", Offset = "0x3C8B4A0", VA = "0x183C8C0A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E0")]
				private struct <<AddConstraintOptions>b__15>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000296")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000297")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000298")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000299")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3C8C470", Offset = "0x3C8B870", VA = "0x183C8C470", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E1")]
				private struct <<AddConstraintOptions>b__18>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029B")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029C")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029D")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3C8CA40", Offset = "0x3C8BE40", VA = "0x183C8CA40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E2")]
				private struct <<AddConstraintOptions>b__20>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A0")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A1")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A2")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3C8CCD0", Offset = "0x3C8C0D0", VA = "0x183C8CCD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				private struct <<AddConstraintOptions>b__23>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A5")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A6")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A7")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3C8D060", Offset = "0x3C8C460", VA = "0x183C8D060", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E4")]
				private struct <<AddConstraintOptions>b__26>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AA")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AB")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AC")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3C8D3F0", Offset = "0x3C8C7F0", VA = "0x183C8D3F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E5")]
				private struct <<AddConstraintOptions>b__28>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AF")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B0")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B1")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3C8D680", Offset = "0x3C8CA80", VA = "0x183C8D680", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				private struct <<AddConstraintOptions>b__31>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B4")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B5")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B6")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3C8DA10", Offset = "0x3C8CE10", VA = "0x183C8DA10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E7")]
				private struct <<AddConstraintOptions>b__34>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B9")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BA")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BB")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3C8DDA0", Offset = "0x3C8D1A0", VA = "0x183C8DDA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E8")]
				private struct <<AddConstraintOptions>b__37>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3C8E120", Offset = "0x3C8D520", VA = "0x183C8E120", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				private struct <<AddConstraintOptions>b__39>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C3")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C4")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C5")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3C8E3B0", Offset = "0x3C8D7B0", VA = "0x183C8E3B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EA")]
				private struct <<AddConstraintOptions>b__3>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C8")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C9")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CA")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3C8E740", Offset = "0x3C8DB40", VA = "0x183C8E740", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EB")]
				private struct <<AddConstraintOptions>b__42>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CD")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3C8E9D0", Offset = "0x3C8DDD0", VA = "0x183C8E9D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				private struct <<AddConstraintOptions>b__45>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D4")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3C8ED60", Offset = "0x3C8E160", VA = "0x183C8ED60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000ED")]
				private struct <<AddConstraintOptions>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D7")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D8")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3C8F0E0", Offset = "0x3C8E4E0", VA = "0x183C8F0E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EE")]
				private struct <<AddConstraintOptions>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DC")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DD")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DE")]
					public TJLYPUTVFSL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x3C8F460", Offset = "0x3C8E860", VA = "0x183C8F460", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public NNAGQPDGQQI<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int RAJNLHVHZCG;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public TJLYPUTVFSL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4610", Offset = "0x5EA3A10", VA = "0x185EA4610")]
				internal bool YJYMXGYLHFU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4670", Offset = "0x5EA3A70", VA = "0x185EA4670")]
				internal void YKDTUNSIQRD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4CB0", Offset = "0x5EA40B0", VA = "0x185EA4CB0")]
				internal object YXLAMXTYCLH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4BF0", Offset = "0x5EA3FF0", VA = "0x185EA4BF0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__13>d))]
				internal void YXFTPRAASZY(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4900", Offset = "0x5EA3D00", VA = "0x185EA4900")]
				internal string YWFLDJENXVF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4840", Offset = "0x5EA3C40", VA = "0x185EA4840")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__15>d))]
				internal void YWAEGCKQOJW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4A30", Offset = "0x5EA3E30", VA = "0x185EA4A30")]
				internal bool YWPYXWSIQRX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x5EA49A0", Offset = "0x5EA3DA0", VA = "0x185EA49A0")]
				internal bool YWKSAPYLHGO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4790", Offset = "0x5EA3B90", VA = "0x185EA4790")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__18>d))]
				internal void YVKJOICYMBV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x5EA46E0", Offset = "0x5EA3AE0", VA = "0x185EA46E0")]
				internal int YVFCRBJBCQM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1820", Offset = "0x5EA0C20", VA = "0x185EA1820")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__20>d))]
				internal void EUYWJPGWAHW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x5EA18D0", Offset = "0x5EA0CD0", VA = "0x185EA18D0")]
				internal bool EVEDGWATJTF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1960", Offset = "0x5EA0D60", VA = "0x185EA1960")]
				internal float EVJKECUQTEO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1A10", Offset = "0x5EA0E10", VA = "0x185EA1A10")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__23>d))]
				internal void EVORBJOOCPX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x5EA15C0", Offset = "0x5EA09C0", VA = "0x185EA15C0")]
				internal bool EUDUUOFGOOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1650", Offset = "0x5EA0A50", VA = "0x185EA1650")]
				internal bool EUJBRUZDXZV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x5EA16E0", Offset = "0x5EA0AE0", VA = "0x185EA16E0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__26>d))]
				internal void EUOIPBTBHLE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1790", Offset = "0x5EA0B90", VA = "0x185EA1790")]
				internal int EUTPMIMYQWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1AC0", Offset = "0x5EA0EC0", VA = "0x185EA1AC0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__28>d))]
				internal void EWOZNRKAXUQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1B70", Offset = "0x5EA0F70", VA = "0x185EA1B70")]
				internal bool EWUGKYDYHFZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3B30", Offset = "0x5EA2F30", VA = "0x185EA3B30")]
				internal float LVQBIHOYQAF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3A80", Offset = "0x5EA2E80", VA = "0x185EA3A80")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__31>d))]
				internal void LVKULAVBGOW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x5EA39F0", Offset = "0x5EA2DF0", VA = "0x185EA39F0")]
				internal bool LVFNNUBDXDN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3970", Offset = "0x5EA2D70", VA = "0x185EA3970")]
				internal bool LVAGQNHGNSE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x5EA38C0", Offset = "0x5EA2CC0", VA = "0x185EA38C0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__34>d))]
				internal void LUUZTGNJEGV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3830", Offset = "0x5EA2C30", VA = "0x185EA3830")]
				internal bool LUPSVZTLUVM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x5EA37A0", Offset = "0x5EA2BA0", VA = "0x185EA37A0")]
				internal bool LUKLYSZOLKD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x5EA36F0", Offset = "0x5EA2AF0", VA = "0x185EA36F0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__37>d))]
				internal void LUFFBMFRBYU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3C70", Offset = "0x5EA3070", VA = "0x185EA3C70")]
				internal int LXGEMJSDNMZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3BC0", Offset = "0x5EA2FC0", VA = "0x185EA3BC0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__39>d))]
				internal void LXAXPCYGEBQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4000", Offset = "0x5EA3400", VA = "0x185EA4000")]
				internal bool RACZCNDKKWG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4090", Offset = "0x5EA3490", VA = "0x185EA4090")]
				internal float RAIFZTXHUHP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3EC0", Offset = "0x5EA32C0", VA = "0x185EA3EC0")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__42>d))]
				internal void QZSLHZPPRZO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3F70", Offset = "0x5EA3370", VA = "0x185EA3F70")]
				internal bool QZXSFGJNBKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3D90", Offset = "0x5EA3190", VA = "0x185EA3D90")]
				internal bool QZHXNMBUZCW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3E10", Offset = "0x5EA3210", VA = "0x185EA3E10")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__45>d))]
				internal void QZNEKSVSIOF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x5EA3D00", Offset = "0x5EA3100", VA = "0x185EA3D00")]
				internal bool QYXJSYOAGGE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x5EA44D0", Offset = "0x5EA38D0", VA = "0x185EA44D0")]
				internal bool YJNZCTKQOJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4560", Offset = "0x5EA3960", VA = "0x185EA4560")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__3>d))]
				internal void YJTGAAENXUL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4390", Offset = "0x5EA3790", VA = "0x185EA4390")]
				internal int YJDLIFWVVMK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4420", Offset = "0x5EA3820", VA = "0x185EA4420")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__5>d))]
				internal void YJISFMQTEXT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4270", Offset = "0x5EA3670", VA = "0x185EA4270")]
				internal bool YISXNSJBCPS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4300", Offset = "0x5EA3700", VA = "0x185EA4300")]
				internal bool YIYEKZCYMBB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4120", Offset = "0x5EA3520", VA = "0x185EA4120")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__8>d))]
				internal void YIIJTEVGJTA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x5EA41D0", Offset = "0x5EA35D0", VA = "0x185EA41D0")]
				internal int YINQQLPDTEJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4B40", Offset = "0x5EA3F40", VA = "0x185EA4B40")]
				[AsyncStateMachine(typeof(NNAGQPDGQQI<>.TJLYPUTVFSL.<<AddConstraintOptions>b__10>d))]
				internal void YXAMSKGDJOP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x5EA4AB0", Offset = "0x5EA3EB0", VA = "0x185EA4AB0")]
				internal bool YWVFVDMGADG()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> BVERYLHKYPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> CXHUQBSCSWT;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<QNRWKFGEPMB> TQJTEQHEFYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x585A610", Offset = "0x5859A10", VA = "0x18585A610")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x585BD20", Offset = "0x585B120", VA = "0x18585BD20")]
			public NNAGQPDGQQI(PRNNMMJSLKB a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x5859450", Offset = "0x5858850", VA = "0x185859450", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x5859500", Offset = "0x5858900", VA = "0x185859500", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x585A660", Offset = "0x5859A60", VA = "0x18585A660")]
			private XCUMKTIUMHX TECSKXVHUEI(TOJVLYFLUBJ a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x585A510", Offset = "0x5859910", VA = "0x18585A510")]
			[AsyncStateMachine(typeof(NNAGQPDGQQI<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void FNITNEZHAJS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x585A5B0", Offset = "0x58599B0", VA = "0x18585A5B0")]
			[CompilerGenerated]
			private bool FNYOEZGZCRT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class XWDLSFNHLTG : SCTDMGVWOLM<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class VKMWSMJNIRA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public XWDLSFNHLTG ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VKMWSMJNIRA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x2890EE0", Offset = "0x28902E0", VA = "0x182890EE0")]
				internal int NDYKJSAVZUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x2891020", Offset = "0x2890420", VA = "0x182891020")]
				internal void NEDRGYUTJFQ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? FQARYKXQFWZ;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x2892470", Offset = "0x2891870", VA = "0x182892470")]
			public XWDLSFNHLTG(PRNNMMJSLKB a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x2892120", Offset = "0x2891520", VA = "0x182892120", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class HYLEWUWMDYU : UINWNQRHETP<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType HNZSDXWJLRM
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x287CA50", Offset = "0x287BE50", VA = "0x18287CA50")]
			public HYLEWUWMDYU(PRNNMMJSLKB a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class PEUGUYLLGVV : ESEJJXNBDSB<DLDCADTQHYU>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x2883760", Offset = "0x2882B60", VA = "0x182883760")]
			public PEUGUYLLGVV(PRNNMMJSLKB a, DLDCADTQHYU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class RAJTPYKVIKC : ESEJJXNBDSB<OPJKYBNEQIX>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2884340", Offset = "0x2883740", VA = "0x182884340")]
			public RAJTPYKVIKC(PRNNMMJSLKB a, OPJKYBNEQIX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class KSZRDTPXCAS : ROEHRBXDITQ<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000F7")]
				private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E8")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E9")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40002EA")]
					public ADTOMERNIYL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x288F2E0", Offset = "0x288E6E0", VA = "0x18288F2E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public KSZRDTPXCAS ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x2879270", Offset = "0x2878670", VA = "0x182879270")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void QIUARLCYWPD(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x287FC60", Offset = "0x287F060", VA = "0x18287FC60")]
			public KSZRDTPXCAS(PRNNMMJSLKB a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x287F960", Offset = "0x287ED60", VA = "0x18287F960", Slot = "151")]
			protected override void KPFEYUPAJFT(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class EDDWWABWPQZ : UINWNQRHETP<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType HNZSDXWJLRM
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xB6EB50", Offset = "0xB6DF50", VA = "0x180B6EB50", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x287A410", Offset = "0x2879810", VA = "0x18287A410")]
			public EDDWWABWPQZ(PRNNMMJSLKB a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class OHIINQMJMZG : SCTDMGVWOLM<HQVHDGHNTSE>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xC66600", Offset = "0xC65A00", VA = "0x180C66600", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2882E60", Offset = "0x2882260", VA = "0x182882E60")]
			public OHIINQMJMZG(PRNNMMJSLKB a, HQVHDGHNTSE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class LQIZAUBEHRF : SCTDMGVWOLM<TOAUAHPSEXO>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool VQULGDPFGYS
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2880C70", Offset = "0x2880070", VA = "0x182880C70")]
			public LQIZAUBEHRF(PRNNMMJSLKB a, TOAUAHPSEXO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x28808B0", Offset = "0x287FCB0", VA = "0x1828808B0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2880BC0", Offset = "0x287FFC0", VA = "0x182880BC0")]
			private int MZUQKSHCZNZ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x2880C00", Offset = "0x2880000", VA = "0x182880C00")]
			private void ZRLWGXPBIVR(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class IULEAEPAPCG : AVUPDFRDZQR
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2879B60", Offset = "0x2878F60", VA = "0x182879B60")]
			public IULEAEPAPCG(PRNNMMJSLKB a, TDRUPTSJFYC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class WBNDQPTTEVS : SCTDMGVWOLM<XQGZJRUUZCV>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class JPVXPIJGEKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public WBNDQPTTEVS ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public JPVXPIJGEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x287D420", Offset = "0x287C820", VA = "0x18287D420")]
				internal int NDTDMLGYQIY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x287D930", Offset = "0x287CD30", VA = "0x18287D930")]
				internal void NDYKJSAVZUH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x287DCF0", Offset = "0x287D0F0", VA = "0x18287DCF0")]
				internal int NEDRGYUTJFQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x287DFF0", Offset = "0x287D3F0", VA = "0x18287DFF0")]
				internal void NEIYEFOQSQZ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0x10021D0", Offset = "0x10015D0", VA = "0x1810021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2891FA0", Offset = "0x28913A0", VA = "0x182891FA0")]
			public WBNDQPTTEVS(PRNNMMJSLKB a, XQGZJRUUZCV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x2891C90", Offset = "0x2891090", VA = "0x182891C90", Slot = "145")]
			protected sealed override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class LUNJSBLIXAV : ROEHRBXDITQ<BUDXCOXBPKK>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x2881C00", Offset = "0x2881000", VA = "0x182881C00")]
			public LUNJSBLIXAV(PRNNMMJSLKB a, BUDXCOXBPKK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class ROEHRBXDITQ<a> : SCTDMGVWOLM<a> where a : notnull, BUDXCOXBPKK
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class GARRZFFJODA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public ROEHRBXDITQ<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public GARRZFFJODA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x4E8AFC0", Offset = "0x4E8A3C0", VA = "0x184E8AFC0")]
				internal bool NDTDMLGYQIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x4E8AFF0", Offset = "0x4E8A3F0", VA = "0x184E8AFF0")]
				internal void NDYKJSAVZUH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x4E8B080", Offset = "0x4E8A480", VA = "0x184E8B080")]
				internal bool NEDRGYUTJFQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x4E8B0B0", Offset = "0x4E8A4B0", VA = "0x184E8B0B0")]
				internal void NEIYEFOQSQZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4E8B140", Offset = "0x4E8A540", VA = "0x184E8B140")]
				internal bool NEOFBMIOCCI()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class BHFVTANVIEJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public OKJTZHVBSRL HPFIVTSISGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public ROEHRBXDITQ<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public BHFVTANVIEJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x6DAC740", Offset = "0x6DABB40", VA = "0x186DAC740")]
				internal void QIUARLCYWPD(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xB87E50", Offset = "0xB87250", VA = "0x180B87E50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x5B66890", Offset = "0x5B65C90", VA = "0x185B66890", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x5B66780", Offset = "0x5B65B80", VA = "0x185B66780")]
			protected ROEHRBXDITQ(PRNNMMJSLKB a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x5B66000", Offset = "0x5B65400", VA = "0x185B66000", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x5B660F0", Offset = "0x5B654F0", VA = "0x185B660F0", Slot = "145")]
			protected override void EQKASJDCNFU(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x5B66460", Offset = "0x5B65860", VA = "0x185B66460", Slot = "151")]
			protected virtual void KPFEYUPAJFT(TOJVLYFLUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x5B66740", Offset = "0x5B65B40", VA = "0x185B66740", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x285CBF0", Offset = "0x285BFF0", VA = "0x18285CBF0")]
		public static HDGORUDUZAT New(PRNNMMJSLKB circuitsManager, TDRUPTSJFYC node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class AHRUZHJSYER : GOMCQTNAHBB, CIYWIECEORY, NDOQTORKZIM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<ICQMRPVUNHC> GLNCFOJFKKA
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xC29E90", Offset = "0xC29290", VA = "0x180C29E90", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<ICQMRPVUNHC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<AESTKKZGRLS> NRRHAOLHWYP
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x1244F80", Offset = "0x1244380", VA = "0x181244F80", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<AESTKKZGRLS>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x20A0210", Offset = "0x209F610", VA = "0x1820A0210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<KBHHKAZFCJZ> BGDSCHMGWRN
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x117F150", Offset = "0x117E550", VA = "0x18117F150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<AROUVFEABTU> VMCZMTXNQZT
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x28794B0", Offset = "0x28788B0", VA = "0x1828794B0", Slot = "22")]
			get
			{
				return default(Id32<AROUVFEABTU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2879850", Offset = "0x2878C50", VA = "0x182879850")]
		private AHRUZHJSYER(PRNNMMJSLKB a, TDRUPTSJFYC b, XWNPNEUHMIU c, Id32<PBWXKRRVJJL> portGroupId, Id32<AESTKKZGRLS> outputId, Id32<KBHHKAZFCJZ> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2879500", Offset = "0x2878900", VA = "0x182879500")]
		public static AHRUZHJSYER New(PRNNMMJSLKB circuitsManager, TDRUPTSJFYC node, XWNPNEUHMIU output, Id32<PBWXKRRVJJL> portGroupId, Id32<KBHHKAZFCJZ> outputDefId, Id32<AESTKKZGRLS> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x20A0210", Offset = "0x209F610", VA = "0x1820A0210")]
		internal void GPHSJRQWRVZ(Id32<AESTKKZGRLS> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class GOMCQTNAHBB : NDOQTORKZIM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private OSQCOFXXGRH? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x2881CF0", Offset = "0x28810F0", VA = "0x182881CF0")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x2881C60", Offset = "0x2881060", VA = "0x182881C60")]
			public OSQCOFXXGRH AWAGEUSDEMN(GOMCQTNAHBB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly TDRUPTSJFYC BZURKFUOJRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter VIBXVCLXGJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly QXWTDYPRGXK BEZOQZGKIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<UXFTBJKROLC> QGDPEIIGGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<DQWKOJSPSJI> MZWQSITCBXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool YXHAZTQPDCB;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> XMTVQYOPIKD
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x287A9C0", Offset = "0x2879DC0", VA = "0x18287A9C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind VKDZZANKJGK
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0E40", Offset = "0xAC0240", VA = "0x180AC0E40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<LVEMYDMRMXB> MTEMAKEQUCD
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x287B630", Offset = "0x287AA30", VA = "0x18287B630", Slot = "6")]
			get
			{
				return default(Id32<LVEMYDMRMXB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<LVEMYDMRMXB> PTYKFJGEUJM
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x287BC70", Offset = "0x287B070", VA = "0x18287BC70", Slot = "7")]
			get
			{
				return default(Id128<LVEMYDMRMXB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public QNRWKFGEPMB AVYNAKTKGVO
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x287BE50", Offset = "0x287B250", VA = "0x18287BE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public DKTEVXCIGNV SYDDCMSQJJD
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x287ABE0", Offset = "0x2879FE0", VA = "0x18287ABE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected OSQCOFXXGRH IIOQIQOIMXK
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x287ABE0", Offset = "0x2879FE0", VA = "0x18287ABE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage ZZKIJDNKMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x287BE70", Offset = "0x287B270", VA = "0x18287BE70", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<YAEGQIMTQZT> ZHVOECCJAWA
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x287AC70", Offset = "0x287A070", VA = "0x18287AC70", Slot = "9")]
			get
			{
				return default(Id128<YAEGQIMTQZT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<PBWXKRRVJJL> UBMZXKOBBMF
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xBEB260", Offset = "0xBEA660", VA = "0x180BEB260", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<PBWXKRRVJJL>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x17CA0A0", Offset = "0x17C94A0", VA = "0x1817CA0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<AROUVFEABTU> VMCZMTXNQZT
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool IHWKEJRATJM
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xC9D9E0", Offset = "0xC9CDE0", VA = "0x180C9D9E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x287C200", Offset = "0x287B600", VA = "0x18287C200")]
		protected GOMCQTNAHBB(PRNNMMJSLKB a, TDRUPTSJFYC b, QXWTDYPRGXK c, Id32<PBWXKRRVJJL> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x287B550", Offset = "0x287A950", VA = "0x18287B550", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x287AB00", Offset = "0x2879F00", VA = "0x18287AB00", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x287BFB0", Offset = "0x287B3B0", VA = "0x18287BFB0", Slot = "14")]
		public void WMCXCGVAAIN(UXFTBJKROLC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x287BBC0", Offset = "0x287AFC0", VA = "0x18287BBC0", Slot = "15")]
		public void QNIJQGMPRWH(DQWKOJSPSJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x287B840", Offset = "0x287AC40", VA = "0x18287B840")]
		private bool PTOTDXXMMJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x287AD10", Offset = "0x287A110", VA = "0x18287AD10", Slot = "17")]
		public void IZQRHYRTJCF(XXILZHJLUVO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x287ACB0", Offset = "0x287A0B0", VA = "0x18287ACB0", Slot = "25")]
		protected virtual void HSUZVJGZXLN(XXILZHJLUVO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x287B660", Offset = "0x287AA60", VA = "0x18287B660", Slot = "20")]
		private void LVVSAQIGJBS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x287BCA0", Offset = "0x287B0A0", VA = "0x18287BCA0")]
		private void UWDGXFEXXKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x287C060", Offset = "0x287B460", VA = "0x18287C060")]
		private void ZTXCHUZZFOT([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x287BB60", Offset = "0x287AF60", VA = "0x18287BB60", Slot = "18")]
		public void QLGEBOCIPQS(UXFTBJKROLC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x287B7E0", Offset = "0x287ABE0", VA = "0x18287B7E0", Slot = "19")]
		public void OMVTPRUZHIA(DQWKOJSPSJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0")]
		internal void VIWCICKFQQB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x287AC90", Offset = "0x287A090", VA = "0x18287AC90")]
		internal void GMCGWLJSCMS(VTCCODAZOLE a, QNRWKFGEPMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x17CA0A0", Offset = "0x17C94A0", VA = "0x1817CA0A0")]
		internal void LBIPXVBYRFD(Id32<PBWXKRRVJJL> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class TZUPQZSHOVI : ERLKPDQGBMX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class MCLQHIIDEZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public PRNNMMJSLKB YRVAFRAHBEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public TDRUPTSJFYC ZISESPVPFJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<PBWXKRRVJJL> WRQHTJGBKON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool MYDZUEBEVVY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool SLXDIEODMQJ;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MCLQHIIDEZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2881D00", Offset = "0x2881100", VA = "0x182881D00")]
			internal ALWVHYGZCSQ QHSZQEUJMXA((int PortDescIndex, int PortIndex, QZOTSQKJWCN InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2881DE0", Offset = "0x28811E0", VA = "0x182881DE0")]
			internal AHRUZHJSYER QHYGNLOGWIJ(XWNPNEUHMIU a, int b)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[CompilerGenerated]
		private struct <AddInputPort>d__86 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x288AB90", Offset = "0x2889F90", VA = "0x18288AB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x288B000", Offset = "0x288A400", VA = "0x18288B000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[CompilerGenerated]
		private struct <RemoveInputDef>d__108 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<GAODAGDLSAS> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x288C2B0", Offset = "0x288B6B0", VA = "0x18288C2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x288C600", Offset = "0x288BA00", VA = "0x18288C600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[CompilerGenerated]
		private struct <RemoveInputPort>d__112 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x288C670", Offset = "0x288BA70", VA = "0x18288C670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x288CAF0", Offset = "0x288BEF0", VA = "0x18288CAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[CompilerGenerated]
		private struct <RemoveOutputDef>d__109 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<KBHHKAZFCJZ> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x288CB60", Offset = "0x288BF60", VA = "0x18288CB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x288CEB0", Offset = "0x288C2B0", VA = "0x18288CEB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[CompilerGenerated]
		private struct <Rename>d__113 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x288D6E0", Offset = "0x288CAE0", VA = "0x18288D6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x288DA30", Offset = "0x288CE30", VA = "0x18288DA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[CompilerGenerated]
		private struct <RenameInputDef>d__114 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<GAODAGDLSAS> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x288CF20", Offset = "0x288C320", VA = "0x18288CF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x288D290", Offset = "0x288C690", VA = "0x18288D290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[CompilerGenerated]
		private struct <RenameOutputDef>d__115 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<KBHHKAZFCJZ> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x288D300", Offset = "0x288C700", VA = "0x18288D300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x288D670", Offset = "0x288CA70", VA = "0x18288D670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private struct <RetypeInputDef>d__116 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public BMPZHICKVBE type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<GAODAGDLSAS> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x288DAA0", Offset = "0x288CEA0", VA = "0x18288DAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x288DE40", Offset = "0x288D240", VA = "0x18288DE40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private struct <RetypeOutputDef>d__117 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public BMPZHICKVBE type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<KBHHKAZFCJZ> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x288DEB0", Offset = "0x288D2B0", VA = "0x18288DEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x288E250", Offset = "0x288D650", VA = "0x18288E250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private struct <SetInputDefIndex>d__110 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<GAODAGDLSAS> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<GAODAGDLSAS> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x288E2C0", Offset = "0x288D6C0", VA = "0x18288E2C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x288E620", Offset = "0x288DA20", VA = "0x18288E620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private struct <SetOutputDefIndex>d__111 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public TZUPQZSHOVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<KBHHKAZFCJZ> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<KBHHKAZFCJZ> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private DEPMCWKOSXQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x288E690", Offset = "0x288DA90", VA = "0x18288E690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x288E9F0", Offset = "0x288DDF0", VA = "0x18288E9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool IFPDAHXQBXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool ZUYANHWMTJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<BFZTWCPUJVX, ALWVHYGZCSQ> MCGRPGDALLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<BFZTWCPUJVX, KRJCTQRUQIF> TUFYFIINHVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly TDRUPTSJFYC BZURKFUOJRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<AESTKKZGRLS, AHRUZHJSYER> DFKLETXFKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<AESTKKZGRLS, CIYWIECEORY> CNHPWQZTMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? TILDMZSUVFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly XRGMJJNTTCZ VWRHHNSWHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<PBWXKRRVJJL> UORQIIXRAIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool KTXORWCMVNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? NDNAXESMKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? RRNLKZWUGVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<BFZTWCPUJVX>>? YXNKFVZTJFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<AESTKKZGRLS>>? AJLWSMLIFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private ERLKPDQGBMX.PortGroupIdChangeDelegate? TTUAFCILXPU;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool EXGRSMQGMXI
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2886F60", Offset = "0x2886360", VA = "0x182886F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool DXNZPUOKLVN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2885640", Offset = "0x2884A40", VA = "0x182885640", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool SRVMHMHMPGN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x28869D0", Offset = "0x2885DD0", VA = "0x1828869D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<LVEMYDMRMXB> PTYKFJGEUJM
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x28890D0", Offset = "0x28884D0", VA = "0x1828890D0", Slot = "7")]
			get
			{
				return default(Id128<LVEMYDMRMXB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool WSYGSIPNAYH
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2886EE0", Offset = "0x28862E0", VA = "0x182886EE0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<BFZTWCPUJVX, KRJCTQRUQIF> RRYSHSHPAOL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<BFZTWCPUJVX, KRJCTQRUQIF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x2889990", Offset = "0x2888D90", VA = "0x182889990", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<YAEGQIMTQZT> ZHVOECCJAWA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x2886D60", Offset = "0x2886160", VA = "0x182886D60", Slot = "11")]
			get
			{
				return default(Id128<YAEGQIMTQZT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<AESTKKZGRLS, CIYWIECEORY> QUTTGNLZPPG
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<AESTKKZGRLS, CIYWIECEORY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<PBWXKRRVJJL> UBMZXKOBBMF
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0xD3CBC0", Offset = "0xD3BFC0", VA = "0x180D3CBC0", Slot = "13")]
			get
			{
				return default(Id32<PBWXKRRVJJL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? DYIHTFCMMRT
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2889030", Offset = "0x2888430", VA = "0x182889030", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2886150", Offset = "0x2885550", VA = "0x182886150", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? ALGYREQZZWW
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x28863C0", Offset = "0x28857C0", VA = "0x1828863C0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2887BB0", Offset = "0x2886FB0", VA = "0x182887BB0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<BFZTWCPUJVX?>, Id32<BFZTWCPUJVX?>>? JHPYDBNJOFH
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2886C10", Offset = "0x2886010", VA = "0x182886C10", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2888400", Offset = "0x2887800", VA = "0x182888400", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<BFZTWCPUJVX?>, Id32<BFZTWCPUJVX?>>? BYBYQCDMKRE
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x288A390", Offset = "0x2889790", VA = "0x18288A390", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2887020", Offset = "0x2886420", VA = "0x182887020", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<AESTKKZGRLS?>, Id32<AESTKKZGRLS?>>? AEXIPJIREGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2887AF0", Offset = "0x2886EF0", VA = "0x182887AF0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2888340", Offset = "0x2887740", VA = "0x182888340", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<AESTKKZGRLS?>, Id32<AESTKKZGRLS?>>? MYCGMGHQYDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x28875C0", Offset = "0x28869C0", VA = "0x1828875C0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2889550", Offset = "0x2888950", VA = "0x182889550", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<BFZTWCPUJVX?>, KRJCTQRUQIF?>? SOICQWZHMSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2888E80", Offset = "0x2888280", VA = "0x182888E80", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2889AF0", Offset = "0x2888EF0", VA = "0x182889AF0", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<BFZTWCPUJVX?>>? WMFWZRUDAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x288A1A0", Offset = "0x28895A0", VA = "0x18288A1A0", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2886090", Offset = "0x2885490", VA = "0x182886090", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<BFZTWCPUJVX?>, KRJCTQRUQIF?>? KWDJSQUDRYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2886A90", Offset = "0x2885E90", VA = "0x182886A90", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2885A30", Offset = "0x2884E30", VA = "0x182885A30", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<AESTKKZGRLS?>, CIYWIECEORY?>? HSTJIWEKKKN
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2887680", Offset = "0x2886A80", VA = "0x182887680", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2886910", Offset = "0x2885D10", VA = "0x182886910", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<AESTKKZGRLS?>>? SYDVRHZARVA
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x28861F0", Offset = "0x28855F0", VA = "0x1828861F0", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2889610", Offset = "0x2888A10", VA = "0x182889610", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<AESTKKZGRLS?>, CIYWIECEORY?>? NLDAGKOTBAF
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x28896D0", Offset = "0x2888AD0", VA = "0x1828896D0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x2886B50", Offset = "0x2885F50", VA = "0x182886B50", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x288A590", Offset = "0x2889990", VA = "0x18288A590")]
		private TZUPQZSHOVI(bool a, PRNNMMJSLKB b, bool c, ReadOnlyIdArray<BFZTWCPUJVX, ALWVHYGZCSQ> inputs, ReadOnlyIdArray<BFZTWCPUJVX, KRJCTQRUQIF> inputsAsStaticInputs, TDRUPTSJFYC d, ReadOnlyIdArray<AESTKKZGRLS, AHRUZHJSYER> outputs, ReadOnlyIdArray<AESTKKZGRLS, CIYWIECEORY> outputsAsStaticOutputs, string? overrideName, XRGMJJNTTCZ e, Id32<PBWXKRRVJJL> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x28884C0", Offset = "0x28878C0", VA = "0x1828884C0")]
		public static TZUPQZSHOVI New(bool canInteract, PRNNMMJSLKB circuitsManager, bool hasFunctionHeader, TDRUPTSJFYC node, XRGMJJNTTCZ portGroup, Id32<PBWXKRRVJJL> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2886590", Offset = "0x2885990", VA = "0x182886590", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2888F40", Offset = "0x2888340", VA = "0x182888F40", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, ZEEUKBHYSTE?>>? QIHXZDZEPHW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2885410", Offset = "0x2884810", VA = "0x182885410")]
		private (FLMTBHXWZOH?, int)? AKOCSVECWZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x28874B0", Offset = "0x28868B0", VA = "0x1828874B0", Slot = "58")]
		private void KBNYDQBELEU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2087240", Offset = "0x2086640", VA = "0x182087240", Slot = "57")]
		private void GSDGEDKZVYP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x28870E0", Offset = "0x28864E0", VA = "0x1828870E0", Slot = "61")]
		private void JKCRESPMCZT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2889900", Offset = "0x2888D00", VA = "0x182889900", Slot = "63")]
		private void UVTOJHTIDSA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2887C60", Offset = "0x2887060", VA = "0x182887C60", Slot = "50")]
		private void MGVJTNIKEBF(int a, Id32<BFZTWCPUJVX> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x288A570", Offset = "0x2889970", VA = "0x18288A570", Slot = "54")]
		private void ZKYEVOLYUIE(int a, Id32<BFZTWCPUJVX> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2886EC0", Offset = "0x28862C0", VA = "0x182886EC0", Slot = "49")]
		private void HVYWWVEJTOW(int a, Id32<BFZTWCPUJVX> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2889100", Offset = "0x2888500", VA = "0x182889100", Slot = "53")]
		private void SLYDMLGULQT(int a, Id32<BFZTWCPUJVX> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2889790", Offset = "0x2888B90", VA = "0x182889790", Slot = "66")]
		private void USVKXRQEJTZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE26830", Offset = "0xE25C30", VA = "0x180E26830", Slot = "65")]
		private void EVFSYAWQPTG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x28862B0", Offset = "0x28856B0", VA = "0x1828862B0", Slot = "60")]
		private void DIBTKZBAGWD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2087240", Offset = "0x2086640", VA = "0x182087240", Slot = "59")]
		private void DKTFYBIGUQG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2889DD0", Offset = "0x28891D0", VA = "0x182889DD0", Slot = "62")]
		private void YSUVIJZJPGU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2886CD0", Offset = "0x28860D0", VA = "0x182886CD0", Slot = "64")]
		private void FFZROPDYYRN(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2885AF0", Offset = "0x2884EF0", VA = "0x182885AF0", Slot = "52")]
		private void DCBYUQTBSXA(int a, Id32<AESTKKZGRLS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2886D80", Offset = "0x2886180", VA = "0x182886D80", Slot = "56")]
		private void FXCFWVFVJSP(int a, Id32<AESTKKZGRLS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2885A10", Offset = "0x2884E10", VA = "0x182885A10", Slot = "51")]
		private void COYNVLJUQND(int a, Id32<AESTKKZGRLS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2888A10", Offset = "0x2887E10", VA = "0x182888A10", Slot = "55")]
		private void PHQQMBZVZEO(int a, Id32<AESTKKZGRLS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2885790", Offset = "0x2884B90", VA = "0x182885790", Slot = "68")]
		private void BTQELCHIIQU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE26830", Offset = "0xE25C30", VA = "0x180E26830", Slot = "67")]
		private void RYMASXKYFMB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2885900", Offset = "0x2884D00", VA = "0x182885900", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, ZEEUKBHYSTE?>>? CHMUYXILOKN(Id32<GAODAGDLSAS> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2885680", Offset = "0x2884A80", VA = "0x182885680", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, ZEEUKBHYSTE?>>? BTMQFSTLAXA(Id32<KBHHKAZFCJZ> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2886DA0", Offset = "0x28861A0", VA = "0x182886DA0", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, ZEEUKBHYSTE?>>? GLHVZLTRIDN(Id32<GAODAGDLSAS> inputDefId, Id32<GAODAGDLSAS> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2886470", Offset = "0x2885870", VA = "0x182886470", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, ZEEUKBHYSTE?>>? DSPYJSVAWHI(Id32<KBHHKAZFCJZ> outputDefId, Id32<KBHHKAZFCJZ> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2889BB0", Offset = "0x2888FB0", VA = "0x182889BB0", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, ZEEUKBHYSTE?>>? XJNRCWEESDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x288A450", Offset = "0x2889850", VA = "0x18288A450", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, ZEEUKBHYSTE>> ZJPREZEKPDC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x288A260", Offset = "0x2889660", VA = "0x18288A260", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, ZEEUKBHYSTE>> YWHDCTXWBSP(Id32<GAODAGDLSAS> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x28899C0", Offset = "0x2888DC0", VA = "0x1828899C0", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, ZEEUKBHYSTE>> WSALIYBQORG(Id32<KBHHKAZFCJZ> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2888210", Offset = "0x2887610", VA = "0x182888210", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, ZEEUKBHYSTE>> MIKWQEQIAVK(Id32<GAODAGDLSAS> inputDefId, BMPZHICKVBE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2889CA0", Offset = "0x28890A0", VA = "0x182889CA0", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, ZEEUKBHYSTE>> XJQZVZYBXNL(Id32<KBHHKAZFCJZ> outputDefId, BMPZHICKVBE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2887740", Offset = "0x2886B40", VA = "0x182887740")]
		internal void LBIPXVBYRFD(Id32<PBWXKRRVJJL> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class HCCGTESCYEY : HVVQBWJJBSH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface VUJTJJOWWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<LVEMYDMRMXB>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<LVEMYDMRMXB>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			VTCCODAZOLE VTCCODAZOLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> PQBWLQREKRN(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> GRGVXBGLPQK(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<ROZSWMJLVUC> VOTWRZQIDLL(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<ZBEHYKVOKWC> JPGKJGBFQBE(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> TCECNGPKPPV(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> ZMSAOGIURGO(CancellationToken a);
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private struct <DeserializeAsync>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public AsyncTaskMethodBuilder<HCCGTESCYEY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public PRNNMMJSLKB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public CircuitRootData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public SuperRoomData superRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			private VUJTJJOWWBJ <selfDeps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			private CircuitRootData <downloadedRoomData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private CircuitRootData <actualRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			private StaticCircuitsConfig <actualStaticConfig>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private SuperRoomData <finalSuperRoomData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private ROZSWMJLVUC <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private ZBEHYKVOKWC <playerSaveData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			private CircuitRootData <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			private TaskAwaiter<SuperRoomData> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			private TaskAwaiter<ROZSWMJLVUC> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<ZBEHYKVOKWC> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<VUJTJJOWWBJ.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<NOBNTZOERHO> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x288B070", Offset = "0x288A470", VA = "0x18288B070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x288C240", Offset = "0x288B640", VA = "0x18288C240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public NOBNTZOERHO NOBNTZOERHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public VDNGABLXTFQ VDNGABLXTFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public FHQGPBWFSJJ FHQGPBWFSJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public NCWHIAXLMKP NCWHIAXLMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE5D190", Offset = "0xE5C590", VA = "0x180E5D190")]
		private HCCGTESCYEY(NOBNTZOERHO a, VDNGABLXTFQ b, FHQGPBWFSJJ c, NCWHIAXLMKP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x287C370", Offset = "0x287B770", VA = "0x18287C370")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<HCCGTESCYEY> XUGGLGFOOCP(PRNNMMJSLKB a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x287C350", Offset = "0x287B750", VA = "0x18287C350", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class WFEKSCUWCSM : DMJVSSJKJXV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public BQBCXRSRTHC? ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x2892010", Offset = "0x2891410", VA = "0x182892010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		internal WFEKSCUWCSM(PRNNMMJSLKB a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class FHQGPBWFSJJ : BQBCXRSRTHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly NOBNTZOERHO PBRLOMSZHZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly WFEKSCUWCSM QSKOWCJMYQZ;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> TWBRIEVWBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x287A860", Offset = "0x2879C60", VA = "0x18287A860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xB2DA60", Offset = "0xB2CE60", VA = "0x180B2DA60")]
		public FHQGPBWFSJJ(PRNNMMJSLKB a, NOBNTZOERHO b, WFEKSCUWCSM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x287A8A0", Offset = "0x2879CA0", VA = "0x18287A8A0", Slot = "5")]
		public string PMPZXIAVFQN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x287A8F0", Offset = "0x2879CF0", VA = "0x18287A8F0", Slot = "6")]
		public void YCGQYBPMDMU(string a, string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	public readonly struct EVRequestExtended
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private struct <Destroy>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x28A18F0", Offset = "0x28A0CF0", VA = "0x1828A18F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x28A1B30", Offset = "0x28A0F30", VA = "0x1828A1B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		[CompilerGenerated]
		private struct <MultipartInitialize>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public AsyncTaskMethodBuilder<Result<bool, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public int splitSizeBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public CircuitRootData circuitRootData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public SuperRoomData superRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			private HJODGUBVAZG[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x28A2340", Offset = "0x28A1740", VA = "0x1828A2340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x28A2710", Offset = "0x28A1B10", VA = "0x1828A2710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		[CompilerGenerated]
		private struct <Request>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public AsyncTaskMethodBuilder<Result<object, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public HJODGUBVAZG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x28A6A40", Offset = "0x28A5E40", VA = "0x1828A6A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x28A6E50", Offset = "0x28A6250", VA = "0x1828A6E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly AEMOPZBEDBJ _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		public EVRequestExtended(AEMOPZBEDBJ staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x287A730", Offset = "0x2879B30", VA = "0x18287A730")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, ZEEUKBHYSTE>> TEYHKDCMZMD(HJODGUBVAZG a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x287A5D0", Offset = "0x28799D0", VA = "0x18287A5D0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, ZEEUKBHYSTE?>>? PYBRXOQOQWY(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x287A4E0", Offset = "0x28798E0", VA = "0x18287A4E0")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, ZEEUKBHYSTE>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface XIJKTMWBCMT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		HVVQBWJJBSH? ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool QLVINBOWQUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<HVVQBWJJBSH?>? ZAUWWIDESKX();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task ICWXRWVOPJW(PRNNMMJSLKB a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface HVVQBWJJBSH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		NOBNTZOERHO NOBNTZOERHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		VDNGABLXTFQ VDNGABLXTFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		FHQGPBWFSJJ FHQGPBWFSJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		NCWHIAXLMKP NCWHIAXLMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class BPIVRFSKVJK
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2893FC0", Offset = "0x28933C0", VA = "0x182893FC0")]
		public static ReducerFactory<ActionKind, HJODGUBVAZG, PRNNMMJSLKB, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>> WMGXKKBHMTH([In] this ReducerFactory<ActionKind, HJODGUBVAZG, PRNNMMJSLKB, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, HJODGUBVAZG, PRNNMMJSLKB, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class RXRLIJBPBFB : AXULGHPKOHS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool QLVINBOWQUO
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x28A0EB0", Offset = "0x28A02B0", VA = "0x1828A0EB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		internal RXRLIJBPBFB(PRNNMMJSLKB a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class LFDFMHMNPPW : ILWWVLKQYQV
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2896740", Offset = "0x2895B40", VA = "0x182896740", Slot = "4")]
		public CPTDCJUIPRV? ZVRVOTHETDS(string? a, string? b, string? c, RoomDoorData.SEJJYADUEHN.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2896680", Offset = "0x2895A80", VA = "0x182896680", Slot = "5")]
		public RNLQTRRTRMH RLJOFSEPMZI(string a, string b, List<string> c, int d, int e, int f, int g, UQEMGKQCTTJ h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x28965E0", Offset = "0x28959E0", VA = "0x1828965E0", Slot = "6")]
		public UQEMGKQCTTJ KECTGZEMCUQ(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public LFDFMHMNPPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class VNAMYEJVJKQ : VNEDWOBTPPV
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		[CompilerGenerated]
		private struct <GetInstanceAsync>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public AsyncTaskMethodBuilder<ZIFYNAHDVNO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public VNAMYEJVJKQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<HVVQBWJJBSH?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x28A1BA0", Offset = "0x28A0FA0", VA = "0x1828A1BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x28A1E40", Offset = "0x28A1240", VA = "0x1828A1E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public ZIFYNAHDVNO? ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x28A7870", Offset = "0x28A6C70", VA = "0x1828A7870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public NCWHIAXLMKP? YNJTKZQYDCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x28A78F0", Offset = "0x28A6CF0", VA = "0x1828A78F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool PYLICWNDVLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x28A7970", Offset = "0x28A6D70", VA = "0x1828A7970", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool QWCBUKZHGNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x28A7810", Offset = "0x28A6C10", VA = "0x1828A7810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x28A8040", Offset = "0x28A7440", VA = "0x1828A8040")]
		internal VNAMYEJVJKQ(PRNNMMJSLKB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x28A7D80", Offset = "0x28A7180", VA = "0x1828A7D80", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<ZIFYNAHDVNO> ZAUWWIDESKX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x28A79D0", Offset = "0x28A6DD0", VA = "0x1828A79D0", Slot = "9")]
		public IReadOnlyDictionary<Id128<LVEMYDMRMXB>, Guid> VFSPNBOGKBF(IEnumerable<PJGKUFHRWDW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x28A7690", Offset = "0x28A6A90", VA = "0x1828A7690", Slot = "10")]
		public CircuitGraphToolMappingRegistryData CBSKGVWWOKH(IEnumerable<PJGKUFHRWDW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x28A7E70", Offset = "0x28A7270", VA = "0x1828A7E70")]
		public Result<CircuitsRoomData, AFOSPUXIYKE> ZVQNNKIQJLR([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, AFOSPUXIYKE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x28A7D50", Offset = "0x28A7150", VA = "0x1828A7D50", Slot = "8")]
		private Result<CircuitsRoomData, AFOSPUXIYKE> YOVIHGPWTSC([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, AFOSPUXIYKE>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class NCWHIAXLMKP : ZIFYNAHDVNO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class DIDHLPMXYFM
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class ADTOMERNIYL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int YLBBEXQAXHH;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ADTOMERNIYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2893E00", Offset = "0x2893200", VA = "0x182893E00")]
				internal void XPAPHYZBPKI(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x28956C0", Offset = "0x2894AC0", VA = "0x1828956C0")]
			public static Result<ZIFYNAHDVNO.PrepareTemplateForCloneResult, NIBBSNHBBHP> EKQJYIVBPEX(NCWHIAXLMKP a, [In] ZIFYNAHDVNO.PrepareTemplateForCloneArgs args)
			{
				return default(Result<ZIFYNAHDVNO.PrepareTemplateForCloneResult, NIBBSNHBBHP>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2894990", Offset = "0x2893D90", VA = "0x182894990")]
			internal static Result<(RCZZKSPOLMY, CircuitTemplateRootData), NIBBSNHBBHP> DCLSKCWAIDT(NCWHIAXLMKP a, CircuitTemplateRootData b, bool c, [In] Id128<LVEMYDMRMXB> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(RCZZKSPOLMY, CircuitTemplateRootData), NIBBSNHBBHP>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2895FE0", Offset = "0x28953E0", VA = "0x182895FE0")]
			private static void RBHFGIDYLDZ(bool a, PJGKUFHRWDW b, RCZZKSPOLMY c, [In] Id128<LVEMYDMRMXB> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2895BD0", Offset = "0x2894FD0", VA = "0x182895BD0")]
			public static void MFOYDTBNJHC(EQKDAXAXTVB a, [In] ZIFYNAHDVNO.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2894400", Offset = "0x2893800", VA = "0x182894400")]
			[CompilerGenerated]
			internal static bool AFYEEPBRQBH(NOBNTZOERHO a, OYFQEZYOSVF b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x2896470", Offset = "0x2895870", VA = "0x182896470")]
			[CompilerGenerated]
			internal static bool UOOBLMOOVQA(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class EYZLWZBKPJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public NCWHIAXLMKP ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<LVEMYDMRMXB> SOAUVAHTGRO;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public EYZLWZBKPJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x28965A0", Offset = "0x28959A0", VA = "0x1828965A0")]
			internal Id128<YAEGQIMTQZT> UXRQRROXIBJ(Id32<YAEGQIMTQZT> a)
			{
				return default(Id128<YAEGQIMTQZT>);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		[CompilerGenerated]
		private struct <RequestAddEdge>d__101 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<ICQMRPVUNHC> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<MSJVWGLYDQX> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x28A2780", Offset = "0x28A1B80", VA = "0x1828A2780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x28A2D50", Offset = "0x28A2150", VA = "0x1828A2D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[CompilerGenerated]
		private struct <RequestAddInputPort>d__150 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<PBWXKRRVJJL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<GAODAGDLSAS> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x28A2DC0", Offset = "0x28A21C0", VA = "0x1828A2DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x28A3110", Offset = "0x28A2510", VA = "0x1828A3110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[CompilerGenerated]
		private struct <RequestAddNode>d__103 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public AsyncTaskMethodBuilder<Result<Id32<YAEGQIMTQZT>, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<KKPQBRSEYJS> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private NOBNTZOERHO <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x28A3460", Offset = "0x28A2860", VA = "0x1828A3460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x28A3890", Offset = "0x28A2C90", VA = "0x1828A3890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[CompilerGenerated]
		private struct <RequestAddNodeDesc>d__104 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AsyncTaskMethodBuilder<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x28A3180", Offset = "0x28A2580", VA = "0x1828A3180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x28A33F0", Offset = "0x28A27F0", VA = "0x1828A33F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[CompilerGenerated]
		private struct <RequestDeleteAllNodes>d__141 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x28A3900", Offset = "0x28A2D00", VA = "0x1828A3900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x28A3AF0", Offset = "0x28A2EF0", VA = "0x1828A3AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[CompilerGenerated]
		private struct <RequestGroupNodesIntoCircuitBoard>d__83 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<LVEMYDMRMXB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<YAEGQIMTQZT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<YAEGQIMTQZT>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public CircuitsVec3 localBoardPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public CircuitsQuat localBoardRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x28A3B60", Offset = "0x28A2F60", VA = "0x1828A3B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x28A3E00", Offset = "0x28A3200", VA = "0x1828A3E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[CompilerGenerated]
		private struct <RequestGroupNodesIntoObjectBoard>d__87 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<LVEMYDMRMXB> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<YAEGQIMTQZT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<YAEGQIMTQZT>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<PBWXKRRVJJL>, Id32<BFZTWCPUJVX>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<PBWXKRRVJJL>, Id32<AESTKKZGRLS>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x28A3E70", Offset = "0x28A3270", VA = "0x1828A3E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x28A4450", Offset = "0x28A3850", VA = "0x1828A4450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		[CompilerGenerated]
		private struct <RequestMoveToBoard>d__84 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<LVEMYDMRMXB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<YAEGQIMTQZT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<YAEGQIMTQZT>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x28A44B0", Offset = "0x28A38B0", VA = "0x1828A44B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x28A46C0", Offset = "0x28A3AC0", VA = "0x1828A46C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		[CompilerGenerated]
		private struct <RequestRemoveInputPortConnections>d__112 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<YAEGQIMTQZT> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<PBWXKRRVJJL> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<BFZTWCPUJVX> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x28A4730", Offset = "0x28A3B30", VA = "0x1828A4730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x28A4A80", Offset = "0x28A3E80", VA = "0x1828A4A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000135")]
		[CompilerGenerated]
		private struct <RequestRemoveLastInputPort>d__151 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<PBWXKRRVJJL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<GAODAGDLSAS> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x28A4AF0", Offset = "0x28A3EF0", VA = "0x1828A4AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x28A4ED0", Offset = "0x28A42D0", VA = "0x1828A4ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000136")]
		[CompilerGenerated]
		private struct <RequestRemoveNode>d__115 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x28A4F40", Offset = "0x28A4340", VA = "0x1828A4F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x28A51C0", Offset = "0x28A45C0", VA = "0x1828A51C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		[CompilerGenerated]
		private struct <RequestRemoveOutputPortConnections>d__113 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<YAEGQIMTQZT> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<PBWXKRRVJJL> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<AESTKKZGRLS> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x28A5230", Offset = "0x28A4630", VA = "0x1828A5230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x28A5580", Offset = "0x28A4980", VA = "0x1828A5580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		[CompilerGenerated]
		private struct <RequestSetNodeLocalTransform>d__155 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x28A55F0", Offset = "0x28A49F0", VA = "0x1828A55F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x28A5930", Offset = "0x28A4D30", VA = "0x1828A5930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		[CompilerGenerated]
		private struct <RequestSetNodeName>d__142 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x28A59A0", Offset = "0x28A4DA0", VA = "0x1828A59A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x28A5C30", Offset = "0x28A5030", VA = "0x1828A5C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013A")]
		[CompilerGenerated]
		private struct <RequestSetVariableHomeValue>d__154 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x28A5CA0", Offset = "0x28A50A0", VA = "0x1828A5CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x28A5F30", Offset = "0x28A5330", VA = "0x1828A5F30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013B")]
		[CompilerGenerated]
		private struct <RequestSpawnTemplate>d__121 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<YAEGQIMTQZT>>, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<LVEMYDMRMXB> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<PJGKUFHRWDW> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<TDRUPTSJFYC>, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x28A5FA0", Offset = "0x28A53A0", VA = "0x1828A5FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x28A6740", Offset = "0x28A5B40", VA = "0x1828A6740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013C")]
		[CompilerGenerated]
		private struct <RequestSplitFromBoard>d__85 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<LVEMYDMRMXB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<YAEGQIMTQZT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<YAEGQIMTQZT>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x28A67B0", Offset = "0x28A5BB0", VA = "0x1828A67B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x28A69D0", Offset = "0x28A5DD0", VA = "0x1828A69D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013D")]
		[CompilerGenerated]
		private struct <RequestUngroupBoard>d__82 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public NCWHIAXLMKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<LVEMYDMRMXB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<YAEGQIMTQZT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x28A6F30", Offset = "0x28A6330", VA = "0x1828A6F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x28A7150", Offset = "0x28A6550", VA = "0x1828A7150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly PRNNMMJSLKB XWJWHOEXNTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly NOBNTZOERHO PBRLOMSZHZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers GOBATHHAKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly VNAMYEJVJKQ ZCCPCFFUMKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<YAEGQIMTQZT>, HDGORUDUZAT> FZKFMADXHYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<YAEGQIMTQZT>>? TBHBDRMNQTB;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<LVEMYDMRMXB> VGWPVSVCOXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x2898BB0", Offset = "0x2897FB0", VA = "0x182898BB0", Slot = "4")]
			get
			{
				return default(Id128<LVEMYDMRMXB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers AIBZNEVDWLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x289D740", Offset = "0x289CB40", VA = "0x18289D740", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> PMWZAEVOXBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x289CBC0", Offset = "0x289BFC0", VA = "0x18289CBC0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action ZTPCSCTPOBP
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x289D720", Offset = "0x289CB20", VA = "0x18289D720", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2898740", Offset = "0x2897B40", VA = "0x182898740", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> QIJEKQYFMPF
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x289AA10", Offset = "0x2899E10", VA = "0x18289AA10", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x2898820", Offset = "0x2897C20", VA = "0x182898820", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x289DE40", Offset = "0x289D240", VA = "0x18289DE40")]
		public NCWHIAXLMKP(PRNNMMJSLKB a, NOBNTZOERHO b, VNAMYEJVJKQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2898780", Offset = "0x2897B80", VA = "0x182898780", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x28967D0", Offset = "0x2895BD0", VA = "0x1828967D0", Slot = "100")]
		public Id32<CZOCRCUORFT> ALDNGSTDUCW(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId)
		{
			return default(Id32<CZOCRCUORFT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x289CB30", Offset = "0x289BF30", VA = "0x18289CB30", Slot = "101")]
		public Id32<TLQUCYRORFS> TSHUHHKODJL(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId)
		{
			return default(Id32<TLQUCYRORFS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2897840", Offset = "0x2896C40", VA = "0x182897840", Slot = "6")]
		public (bool, bool) BKSCDPMCDJI(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x289C830", Offset = "0x289BC30", VA = "0x18289C830")]
		public bool TQAUQBFLHCD(Id32<LVEMYDMRMXB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x28986C0", Offset = "0x2897AC0", VA = "0x1828986C0", Slot = "8")]
		public bool DGQAPRZMVZJ(KRJCTQRUQIF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x289ABF0", Offset = "0x2899FF0", VA = "0x18289ABF0", Slot = "9")]
		public bool OLEJCOHXRZQ(CIYWIECEORY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x28998D0", Offset = "0x2898CD0", VA = "0x1828998D0", Slot = "10")]
		public AbsoluteLegacyInputId? HMNUCAKYULT(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x28977E0", Offset = "0x2896BE0", VA = "0x1828977E0", Slot = "11")]
		public AbsoluteLegacyOutputId? AYGZOZIIECM(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2899C30", Offset = "0x2899030", VA = "0x182899C30", Slot = "12")]
		public Id32<ICQMRPVUNHC>? IGKVBIUYDBU(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<AESTKKZGRLS> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x28967F0", Offset = "0x2895BF0", VA = "0x1828967F0", Slot = "13")]
		public Id32<MSJVWGLYDQX>? AOLQXGJAKFV(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<BFZTWCPUJVX> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x289D4B0", Offset = "0x289C8B0", VA = "0x18289D4B0", Slot = "14")]
		public IEnumerable<Id32<LVEMYDMRMXB>> WVNTNGRMWHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x289D390", Offset = "0x289C790", VA = "0x18289D390", Slot = "15")]
		public IEnumerable<Id32<WHHYRTPYAMJ>> VFSZHOOAWGY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2899B10", Offset = "0x2898F10", VA = "0x182899B10", Slot = "22")]
		public string HWFOIMZQNSE(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x289B610", Offset = "0x289AA10", VA = "0x18289B610", Slot = "16")]
		public Id32<WHHYRTPYAMJ>? QHPKLHRALWQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2898B90", Offset = "0x2897F90", VA = "0x182898B90", Slot = "17")]
		public int ERMXYEHNPCV(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x289CDB0", Offset = "0x289C1B0", VA = "0x18289CDB0", Slot = "18")]
		public int UCRWQZHFCVI(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x289BB80", Offset = "0x289AF80", VA = "0x18289BB80", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] RHEJLPEXXPN(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x289A040", Offset = "0x2899440", VA = "0x18289A040", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] LPGNYHCMPHW(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3873600", Offset = "0x3872A00", VA = "0x183873600")]
		private static (CircuitTypeIdWrapper, string?)[]? AMZLBYSJIVP<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2898BD0", Offset = "0x2897FD0", VA = "0x182898BD0", Slot = "21")]
		public string EYOUJIVIDHC(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2899E20", Offset = "0x2899220", VA = "0x182899E20", Slot = "23")]
		public string JFDEREXPEFH(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x289BA50", Offset = "0x289AE50", VA = "0x18289BA50")]
		public HDGORUDUZAT? RDQFVVTAZLY([In] Id128<YAEGQIMTQZT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2898760", Offset = "0x2897B60", VA = "0x182898760", Slot = "30")]
		public Id32<KKPQBRSEYJS> DPQVBBIFSFC(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId)
		{
			return default(Id32<KKPQBRSEYJS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x289BBE0", Offset = "0x289AFE0", VA = "0x18289BBE0")]
		public Id32<YAEGQIMTQZT> RIJQFRAHULB(Id32<LVEMYDMRMXB> graphId, [In] Id128<YAEGQIMTQZT> legacyNodeId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x289D210", Offset = "0x289C610", VA = "0x18289D210", Slot = "40")]
		public Id32<YAEGQIMTQZT> URNLBUHIMVK(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2899710", Offset = "0x2898B10", VA = "0x182899710", Slot = "41")]
		public Id32<YAEGQIMTQZT> GSKFIIPIUIL(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x289D1E0", Offset = "0x289C5E0", VA = "0x18289D1E0")]
		public Id32<YAEGQIMTQZT>? UPEYZCHGSAX(Id32<LVEMYDMRMXB> graphId, [In] Id128<YAEGQIMTQZT> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x289CBE0", Offset = "0x289BFE0", VA = "0x18289CBE0", Slot = "32")]
		public AbsoluteNodeId? TYTRBPSAYFL(Id32<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x289B8D0", Offset = "0x289ACD0", VA = "0x18289B8D0", Slot = "33")]
		public long QMKBPAGBWVI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x289DC70", Offset = "0x289D070", VA = "0x18289DC70")]
		private void ZUKEYRUQEKK(Id128<YAEGQIMTQZT> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2899E70", Offset = "0x2899270", VA = "0x182899E70", Slot = "38")]
		public IEnumerable<(Id32<LVEMYDMRMXB>, Id32<YAEGQIMTQZT>)> JVYBKNSWOEQ(Id32<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2896820", Offset = "0x2895C20", VA = "0x182896820", Slot = "39")]
		public Id32<MSJVWGLYDQX> AOLQXGJAKFV(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<CZOCRCUORFT> inputIndex)
		{
			return default(Id32<MSJVWGLYDQX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2899C60", Offset = "0x2899060", VA = "0x182899C60", Slot = "42")]
		public Id32<ICQMRPVUNHC> IGKVBIUYDBU(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<TLQUCYRORFS> outputIndex)
		{
			return default(Id32<ICQMRPVUNHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2898440", Offset = "0x2897840", VA = "0x182898440")]
		private HDGORUDUZAT? CSYPFLQYEQN([In] Id128<YAEGQIMTQZT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x289A680", Offset = "0x2899A80", VA = "0x18289A680")]
		public TDRUPTSJFYC? MTKZPMHDIVJ([In] Id128<YAEGQIMTQZT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2897CE0", Offset = "0x28970E0", VA = "0x182897CE0")]
		public CFVHDLAXNSV? JETVTPTJPOG([In] Id128<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2899DD0", Offset = "0x28991D0", VA = "0x182899DD0", Slot = "25")]
		public CFVHDLAXNSV? JETVTPTJPOG(Id32<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x28984B0", Offset = "0x28978B0", VA = "0x1828984B0", Slot = "34")]
		public IEnumerable<NewStaticEdge> CVBNGJKVTWG(Id32<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2899930", Offset = "0x2898D30", VA = "0x182899930", Slot = "35")]
		public bool HQPVRJYAOIG(Id32<WHHYRTPYAMJ> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x289A3A0", Offset = "0x28997A0", VA = "0x18289A3A0", Slot = "36")]
		public IEnumerable<StableStaticEdge> MIFKWCOEHTA(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2898940", Offset = "0x2897D40", VA = "0x182898940", Slot = "37")]
		public IEnumerable<StableStaticEdge> EOVAHKYORJD(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2898C00", Offset = "0x2898000", VA = "0x182898C00")]
		public Id32<LVEMYDMRMXB> EYQJWOQUYHF([In] Id128<LVEMYDMRMXB> graphId)
		{
			return default(Id32<LVEMYDMRMXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2899B40", Offset = "0x2898F40", VA = "0x182899B40")]
		public Id32<LVEMYDMRMXB>? XNTYUJCHDXB([In] Id128<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2899000", Offset = "0x2898400", VA = "0x182899000")]
		private OYFQEZYOSVF? FDNWLJDHOQR([In] Id128<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2897CE0", Offset = "0x28970E0", VA = "0x182897CE0")]
		private CFVHDLAXNSV? PVIMOJLEEVO([In] Id128<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2898840", Offset = "0x2897C40", VA = "0x182898840", Slot = "28")]
		public Id32<LVEMYDMRMXB>? EMFKKKTZAKO(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x28998B0", Offset = "0x2898CB0", VA = "0x1828998B0", Slot = "46")]
		public Id128<LVEMYDMRMXB> HGYTJXHUHPA(Id32<LVEMYDMRMXB> graphId)
		{
			return default(Id128<LVEMYDMRMXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2899AF0", Offset = "0x2898EF0", VA = "0x182899AF0", Slot = "47")]
		public Id128<YAEGQIMTQZT> HVYRZIOMNEE(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId)
		{
			return default(Id128<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x289BD80", Offset = "0x289B180", VA = "0x18289BD80", Slot = "43")]
		public IEnumerable<BMPZHICKVBE> SLEKRTJLIEO(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x289A0A0", Offset = "0x28994A0", VA = "0x18289A0A0", Slot = "44")]
		public BMPZHICKVBE MHTJKNTHNWP(RoomVersion a, NDOQTORKZIM b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x289D520", Offset = "0x289C920", VA = "0x18289D520")]
		public NewStaticEdge ZAQOSCDQFKJ(Id32<LVEMYDMRMXB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x289D830", Offset = "0x289CC30", VA = "0x18289D830", Slot = "48")]
		public StableStaticEdge YYLHMQVCEKM(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2899750", Offset = "0x2898B50", VA = "0x182899750", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, ZEEUKBHYSTE>> HEVRSTKCVIV(Id32<LVEMYDMRMXB> parentGraphId, Id32<YAEGQIMTQZT> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x289B3E0", Offset = "0x289A7E0", VA = "0x18289B3E0", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, ZEEUKBHYSTE>> PKTYHIZVERO(Id32<LVEMYDMRMXB> parentGraphId, Id128<YAEGQIMTQZT> boardNodeId, List<Id32<YAEGQIMTQZT>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x289A6C0", Offset = "0x2899AC0", VA = "0x18289A6C0", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, ZEEUKBHYSTE>> NBPDEZSQSHD(Id32<LVEMYDMRMXB> parentGraphId, Id128<YAEGQIMTQZT> boardNodeId, List<Id32<YAEGQIMTQZT>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x28982E0", Offset = "0x28976E0", VA = "0x1828982E0", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, ZEEUKBHYSTE>> CPKPILUXNKD(Id32<LVEMYDMRMXB> parentGraphId, Id128<YAEGQIMTQZT> boardNodeId, Id32<LVEMYDMRMXB> graphId, List<Id32<YAEGQIMTQZT>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x289A810", Offset = "0x2899C10", VA = "0x18289A810", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<PBWXKRRVJJL>, Id32<BFZTWCPUJVX>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<PBWXKRRVJJL>, Id32<AESTKKZGRLS>)>) NKPUQCMIWCY(Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<PBWXKRRVJJL>, Id32<BFZTWCPUJVX>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<PBWXKRRVJJL>, Id32<AESTKKZGRLS>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x289BC30", Offset = "0x289B030", VA = "0x18289BC30", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task RUKKRUGDCJU(Id128<LVEMYDMRMXB> legacyGraphId, Id128<YAEGQIMTQZT> boardNodeId, IReadOnlyList<Id128<YAEGQIMTQZT>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<PBWXKRRVJJL>, Id32<BFZTWCPUJVX>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<PBWXKRRVJJL>, Id32<AESTKKZGRLS>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x289DE20", Offset = "0x289D220", VA = "0x18289DE20", Slot = "55")]
		public bool ZYYIKFBXRFU(Id32<LVEMYDMRMXB> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x289BC10", Offset = "0x289B010", VA = "0x18289BC10", Slot = "56")]
		public bool RJVHNKPFYIW(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x289D700", Offset = "0x289CB00", VA = "0x18289D700", Slot = "57")]
		public bool XQRVMPSBJTB(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2899E40", Offset = "0x2899240", VA = "0x182899E40")]
		public Result<ZIFYNAHDVNO.PrepareTemplateForCloneResult, NIBBSNHBBHP> SMUFRVAUTYT([In] ZIFYNAHDVNO.PrepareTemplateForCloneArgs args)
		{
			return default(Result<ZIFYNAHDVNO.PrepareTemplateForCloneResult, NIBBSNHBBHP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x289DCF0", Offset = "0x289D0F0", VA = "0x18289DCF0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, ZEEUKBHYSTE>> ZUYCOGPGGJR(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x289B8F0", Offset = "0x289ACF0", VA = "0x18289B8F0", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<YAEGQIMTQZT>, ZEEUKBHYSTE>> QUNMXKKLLNA(Id32<LVEMYDMRMXB> graphId, Id32<KKPQBRSEYJS> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2899990", Offset = "0x2898D90", VA = "0x182899990", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> HTSFDEXMPCX(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x289CDD0", Offset = "0x289C1D0", VA = "0x18289CDD0", Slot = "62")]
		public Result<ControlPanelRootData, AFOSPUXIYKE> UDXQSBQJZFF(Id128<LVEMYDMRMXB> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, AFOSPUXIYKE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x28990C0", Offset = "0x28984C0", VA = "0x1828990C0", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, ZEEUKBHYSTE>> FMLEOZYJSSL(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> inputNodeId, Id32<PBWXKRRVJJL> inputPortGroupId, Id32<BFZTWCPUJVX> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x289AA90", Offset = "0x2899E90", VA = "0x18289AA90", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, ZEEUKBHYSTE>> OFRPHRBBLRU(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> outputNodeId, Id32<PBWXKRRVJJL> outputPortGroupId, Id32<AESTKKZGRLS> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x289AC70", Offset = "0x289A070", VA = "0x18289AC70", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, ZEEUKBHYSTE>> OOIKXFIYCGP(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2899360", Offset = "0x2898760", VA = "0x182899360", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<YAEGQIMTQZT>>, ZEEUKBHYSTE>> FTWYWSUYLLS(Id128<LVEMYDMRMXB> intoGraphId, CircuitTemplateRootData a, IEnumerable<PJGKUFHRWDW> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x289D420", Offset = "0x289C820", VA = "0x18289D420", Slot = "67")]
		public CircuitsData VGUWGLZJYBI()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x289B580", Offset = "0x289A980", VA = "0x18289B580", Slot = "68")]
		public CircuitsData QEBKMUWEINF()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x289DAD0", Offset = "0x289CED0", VA = "0x18289DAD0", Slot = "71")]
		public CircuitsTemplateData ZTPJZPRLROA(TemplateSerializationReason a, Id32<LVEMYDMRMXB> sourceGraphId, IEnumerable<Id128<LVEMYDMRMXB>> graphIds, IEnumerable<Id128<YAEGQIMTQZT>> nodeIds, ISet<Id128<SMGNNBTWEUN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2899580", Offset = "0x2898980", VA = "0x182899580")]
		private CircuitsTemplateData FVXJOKWVDCR(TemplateSerializationReason a, Id32<LVEMYDMRMXB> sourceGraphId, IEnumerable<Id128<LVEMYDMRMXB>> graphIds, IEnumerable<Id128<YAEGQIMTQZT>> nodeIds, ISet<Id128<SMGNNBTWEUN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2897F70", Offset = "0x2897370", VA = "0x182897F70", Slot = "69")]
		public CircuitsTemplateData CNSCSJGGIOT(TemplateSerializationReason a, Id32<LVEMYDMRMXB> sourceGraphId, IEnumerable<Id128<YAEGQIMTQZT>> nodeIds, IEnumerable<PJGKUFHRWDW> b, ISet<Id128<SMGNNBTWEUN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x28981D0", Offset = "0x28975D0", VA = "0x1828981D0", Slot = "70")]
		public CircuitsTemplateData CNSCSJGGIOT(TemplateSerializationReason a, Id32<LVEMYDMRMXB> sourceGraphId, IEnumerable<Id32<YAEGQIMTQZT>> nodeIds, IEnumerable<PJGKUFHRWDW> b, ISet<Id128<SMGNNBTWEUN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2898C30", Offset = "0x2898030", VA = "0x182898C30")]
		private static IEnumerable<Id128<LVEMYDMRMXB>> EYWFEOSBEVL(IEnumerable<PJGKUFHRWDW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x28972E0", Offset = "0x28966E0", VA = "0x1828972E0")]
		private IEnumerable<Id128<YAEGQIMTQZT>> AVXFVXWYTSB(IEnumerable<PJGKUFHRWDW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x289D2F0", Offset = "0x289C6F0", VA = "0x18289D2F0", Slot = "72")]
		public List<TOGLIDTFJOI> UUJQWGJGRGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x289AD80", Offset = "0x289A180", VA = "0x18289AD80")]
		public (List<TOGLIDTFJOI>, bool) OUGSGARKSDN([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, OSFRBXMQTKU b, RILPKECODQM c)
		{
			return default((List<TOGLIDTFJOI>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x289A5F0", Offset = "0x28999F0", VA = "0x18289A5F0", Slot = "74")]
		public bool MPEFIBRGJBE(Id32<LVEMYDMRMXB> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x289A980", Offset = "0x2899D80", VA = "0x18289A980", Slot = "75")]
		public bool NLKTUTYNTOU(Id32<LVEMYDMRMXB> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2899AD0", Offset = "0x2898ED0", VA = "0x182899AD0")]
		internal void HVENKOQRKRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x289B560", Offset = "0x289A960", VA = "0x18289B560")]
		internal Task PYNVEDTWSKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x289BE80", Offset = "0x289B280", VA = "0x18289BE80", Slot = "76")]
		public Result<Id32<ICQMRPVUNHC>?, ZEEUKBHYSTE> SXFMQFDDSOP(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<MSJVWGLYDQX> inputId)
		{
			return default(Result<Id32<ICQMRPVUNHC>?, ZEEUKBHYSTE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2896930", Offset = "0x2895D30", VA = "0x182896930", Slot = "77")]
		public Result<Id32<MSJVWGLYDQX>?, ZEEUKBHYSTE> ASVSFOGUKQT(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<ICQMRPVUNHC> outputId)
		{
			return default(Result<Id32<MSJVWGLYDQX>?, ZEEUKBHYSTE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x289D610", Offset = "0x289CA10", VA = "0x18289D610", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, ZEEUKBHYSTE>> XCSRQGVPECQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2897D10", Offset = "0x2897110", VA = "0x182897D10", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, ZEEUKBHYSTE>> CCIKSCFKLTU(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2899B70", Offset = "0x2898F70", VA = "0x182899B70", Slot = "80")]
		public Id32<YAEGQIMTQZT>? IEWABAGRDZS(Id32<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x289D230", Offset = "0x289C630", VA = "0x18289D230", Slot = "81")]
		public Id32<YAEGQIMTQZT>? USXPIOCBOPT(Id32<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x289D150", Offset = "0x289C550", VA = "0x18289D150", Slot = "82")]
		public int UJLZGDYHWXL(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x289CCE0", Offset = "0x289C0E0", VA = "0x18289CCE0", Slot = "83")]
		public int UCNPLGFGGHI(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x289D750", Offset = "0x289CB50", VA = "0x18289D750", Slot = "84")]
		public int YVSQVDLIYNB(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2896850", Offset = "0x2895C50", VA = "0x182896850", Slot = "85")]
		public int APKXNBPZVDD(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2899C90", Offset = "0x2899090", VA = "0x182899C90", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, ZEEUKBHYSTE>> JALIZLBUMUB(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2899220", Offset = "0x2898620", VA = "0x182899220", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, ZEEUKBHYSTE>> FMSJMPRUPKS(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x28994C0", Offset = "0x28988C0", VA = "0x1828994C0", Slot = "88")]
		public int FVKKHSGYXGV(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2899F00", Offset = "0x2899300", VA = "0x182899F00", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, ZEEUKBHYSTE>> LCMXRXJQXYT(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x289D970", Offset = "0x289CD70", VA = "0x18289D970", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, ZEEUKBHYSTE>> ZFLHFOFJNLS(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2898550", Offset = "0x2897950", VA = "0x182898550", Slot = "91")]
		public bool CWENAMRFIFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x28990A0", Offset = "0x28984A0", VA = "0x1828990A0", Slot = "97")]
		public IEnumerable<Id32<UMLOGIGCAWT>> FGZQNLUKAJZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2899730", Offset = "0x2898B30", VA = "0x182899730", Slot = "98")]
		public string? GTVBHHMOYET(Id32<UMLOGIGCAWT> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x28998A0", Offset = "0x2898CA0", VA = "0x1828998A0", Slot = "7")]
		private bool HFXAZETJWDN(Id32<LVEMYDMRMXB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2897CE0", Offset = "0x28970E0", VA = "0x182897CE0", Slot = "24")]
		private CFVHDLAXNSV CBJLMBBWSXY([In] Id128<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2898C00", Offset = "0x2898000", VA = "0x182898C00", Slot = "26")]
		private Id32<LVEMYDMRMXB> XZJBNXHBQDF([In] Id128<LVEMYDMRMXB> graphId)
		{
			return default(Id32<LVEMYDMRMXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2899B40", Offset = "0x2898F40", VA = "0x182899B40", Slot = "27")]
		private Id32<LVEMYDMRMXB>? IAESSTWMKBJ([In] Id128<LVEMYDMRMXB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2897E50", Offset = "0x2897250", VA = "0x182897E50", Slot = "29")]
		private HDGORUDUZAT CGSLMAPWDQO([In] Id128<YAEGQIMTQZT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x289BBE0", Offset = "0x289AFE0", VA = "0x18289BBE0", Slot = "31")]
		private Id32<YAEGQIMTQZT> WPDIBIVYTSH(Id32<LVEMYDMRMXB> graphId, [In] Id128<YAEGQIMTQZT> legacyNodeId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x289D520", Offset = "0x289C920", VA = "0x18289D520", Slot = "45")]
		private NewStaticEdge WWZUUHGMGAJ(Id32<LVEMYDMRMXB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2899E40", Offset = "0x2899240", VA = "0x182899E40", Slot = "58")]
		private Result<ZIFYNAHDVNO.PrepareTemplateForCloneResult, NIBBSNHBBHP> JRMCMZRRIHR([In] ZIFYNAHDVNO.PrepareTemplateForCloneArgs args)
		{
			return default(Result<ZIFYNAHDVNO.PrepareTemplateForCloneResult, NIBBSNHBBHP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x289D330", Offset = "0x289C730", VA = "0x18289D330", Slot = "73")]
		private (List<TOGLIDTFJOI>, bool) UWUUXXOREDN([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, OSFRBXMQTKU b, RILPKECODQM c)
		{
			return default((List<TOGLIDTFJOI>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x289CB50", Offset = "0x289BF50", VA = "0x18289CB50")]
		[CompilerGenerated]
		private PSAAIOVGZTN TWKNYMBBVJW(QNRWKFGEPMB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x289AA30", Offset = "0x2899E30", VA = "0x18289AA30")]
		[CompilerGenerated]
		private TDRUPTSJFYC QBMIPOFHOOY(Id128<YAEGQIMTQZT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x289AA60", Offset = "0x2899E60", VA = "0x18289AA60")]
		[CompilerGenerated]
		private OYFQEZYOSVF QBRPMUZEYAH(Id128<LVEMYDMRMXB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x289AA30", Offset = "0x2899E30", VA = "0x18289AA30")]
		[CompilerGenerated]
		private TDRUPTSJFYC NVYMFWUBGTO(Id128<YAEGQIMTQZT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x289AA60", Offset = "0x2899E60", VA = "0x18289AA60")]
		[CompilerGenerated]
		private OYFQEZYOSVF NWDTDDNYQEX(Id128<LVEMYDMRMXB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class PSAAIOVGZTN : BMPZHICKVBE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		[CompilerGenerated]
		private struct <AddInputDef>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public AsyncTaskMethodBuilder<Result<Id32<GAODAGDLSAS>, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public PSAAIOVGZTN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<PBWXKRRVJJL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<GAODAGDLSAS>, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x28A1370", Offset = "0x28A0770", VA = "0x1828A1370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x28A15C0", Offset = "0x28A09C0", VA = "0x1828A15C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		[CompilerGenerated]
		private struct <AddOutputDef>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public AsyncTaskMethodBuilder<Result<Id32<KBHHKAZFCJZ>, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public PSAAIOVGZTN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<LVEMYDMRMXB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<YAEGQIMTQZT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<PBWXKRRVJJL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<KBHHKAZFCJZ>, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x28A1630", Offset = "0x28A0A30", VA = "0x1828A1630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x28A1880", Offset = "0x28A0C80", VA = "0x1828A1880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly QNRWKFGEPMB UEVEPLXUUOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly NOBNTZOERHO PBRLOMSZHZK;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey AMXBUJILFZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string WEXRBMNYLBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x289E430", Offset = "0x289D830", VA = "0x18289E430", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public QNRWKFGEPMB QNRWKFGEPMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x28A0480", Offset = "0x289F880", VA = "0x1828A0480")]
		public PSAAIOVGZTN(QNRWKFGEPMB a, NOBNTZOERHO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x28A01A0", Offset = "0x289F5A0", VA = "0x1828A01A0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<GAODAGDLSAS>, ZEEUKBHYSTE>> SDSUYHESKOK(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x28A0310", Offset = "0x289F710", VA = "0x1828A0310", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<KBHHKAZFCJZ>, ZEEUKBHYSTE>> UOHIMKNTNTN(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class OSQCOFXXGRH : DKTEVXCIGNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly QNRWKFGEPMB STJJAEGTVHH;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<QNRWKFGEPMB> IRTQHAPIZDD;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<QNRWKFGEPMB> TDNIUPKCZBI;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<QNRWKFGEPMB> KQEIMPHIAQH;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public QNRWKFGEPMB FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x28A0030", Offset = "0x289F430", VA = "0x1828A0030", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x28A0020", Offset = "0x289F420", VA = "0x1828A0020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x28A0080", Offset = "0x289F480", VA = "0x1828A0080", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x289FFA0", Offset = "0x289F3A0", VA = "0x18289FFA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x289E460", Offset = "0x289D860", VA = "0x18289E460")]
		public bool WSHLCSULDZQ(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public OSQCOFXXGRH(QNRWKFGEPMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x289E2A0", Offset = "0x289D6A0", VA = "0x18289E2A0")]
		internal static TypeKey KGOTPBURLAH(QNRWKFGEPMB a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x289E430", Offset = "0x289D830", VA = "0x18289E430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Injection
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public readonly struct ActionDeps : NTEFXKGQILC.SZFTQFUJAID<HJODGUBVAZG, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2893E90", Offset = "0x2893290", VA = "0x182893E90", Slot = "4")]
		public int NLGMTGMRTEZ(None a, HJODGUBVAZG b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2893E30", Offset = "0x2893230", VA = "0x182893E30", Slot = "5")]
		public HJODGUBVAZG DYZWVBJFLFW(None a, HJODGUBVAZG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2893E40", Offset = "0x2893240", VA = "0x182893E40", Slot = "6")]
		public HJODGUBVAZG ETPCSPYMWKT(None a, HJODGUBVAZG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2893EB0", Offset = "0x28932B0", VA = "0x182893EB0", Slot = "7")]
		public IReadOnlyList<HJODGUBVAZG> PWWXOHSHUYR(None a, HJODGUBVAZG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2893E20", Offset = "0x2893220", VA = "0x182893E20", Slot = "8")]
		public HJODGUBVAZG[] AOBVYUROJZS(None a, HJODGUBVAZG b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2893F30", Offset = "0x2893330", VA = "0x182893F30", Slot = "9")]
		public bool SYQZWFVFSWZ(None a, HJODGUBVAZG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2893E70", Offset = "0x2893270", VA = "0x182893E70", Slot = "10")]
		public bool IQAYKTXLGSJ(None a, HJODGUBVAZG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2893ED0", Offset = "0x28932D0", VA = "0x182893ED0", Slot = "11")]
		public bool RJFOGCLQMQF(None a, HJODGUBVAZG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2893F10", Offset = "0x2893310", VA = "0x182893F10", Slot = "12")]
		public bool RPZKLUDGEIR(None a, HJODGUBVAZG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2893F50", Offset = "0x2893350", VA = "0x182893F50", Slot = "13")]
		public bool WUQCJCSHCVB(None a, HJODGUBVAZG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2893EF0", Offset = "0x28932F0", VA = "0x182893EF0", Slot = "14")]
		public bool RMDLHXBQIWG(None a, HJODGUBVAZG b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class BJFVTXWWZBU : KVKSDIRUDBG
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract RWYGVNVPHCG.VUJTJJOWWBJ HRMPBGJJHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract PRNNMMJSLKB.VUJTJJOWWBJ FCUMHKWXNVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract HCCGTESCYEY.VUJTJJOWWBJ FJRKQLYYQTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB> CONYTBARIYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2893F70", Offset = "0x2893370", VA = "0x182893F70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.VUJTJJOWWBJ HRGRZLXHLSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract DEPMCWKOSXQ QBMVFWJVZGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract HWWVWTNKRNF BDSKFJNURTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract JZZMFKCCSQP SKITHEBMTAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract DSKKGSMHSDN RFGQBINISEK
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract OJKJTUFQHTH TCIMFANLPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected BJFVTXWWZBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class SYTWACJIHBU : AEBCGLCQHHQ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		[CompilerGenerated]
		private struct <Multi>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public AsyncTaskMethodBuilder<Result<MultiResult, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<HJODGUBVAZG> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public SYTWACJIHBU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x28A1EB0", Offset = "0x28A12B0", VA = "0x1828A1EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x28A22D0", Offset = "0x28A16D0", VA = "0x1828A22D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000146")]
		[CompilerGenerated]
		private struct <Request>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public AsyncTaskMethodBuilder<Result<object, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public SYTWACJIHBU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public HJODGUBVAZG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x28A6C40", Offset = "0x28A6040", VA = "0x1828A6C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x28A6EC0", Offset = "0x28A62C0", VA = "0x1828A6EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly AEMOPZBEDBJ IGTQXOYOZKR;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public SYTWACJIHBU(AEMOPZBEDBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x28A1000", Offset = "0x28A0400", VA = "0x1828A1000")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, ZEEUKBHYSTE>> TEYHKDCMZMD(HJODGUBVAZG a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x28A0ED0", Offset = "0x28A02D0", VA = "0x1828A0ED0", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, ZEEUKBHYSTE>> EHJZTUQXBPR(IReadOnlyList<HJODGUBVAZG> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, HJODGUBVAZG, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xFF1B60", Offset = "0xFF0F60", VA = "0x180FF1B60")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, HJODGUBVAZG, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x28A0710", Offset = "0x289FB10", VA = "0x1828A0710")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class SFRDTJAIJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, HJODGUBVAZG, PartialActionReassemblyDeps> QNECGDCLYAI(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, HJODGUBVAZG, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : YHERQOACPWY.UCTXXJIHGPQ<PartialActionPayload, Id128<PartialActionPayload.M>, HJODGUBVAZG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x28A0530", Offset = "0x289F930", VA = "0x1828A0530", Slot = "7")]
		public HJODGUBVAZG UDWQMKMRLKY(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0xFE3F40", Offset = "0xFE3340", VA = "0x180FE3F40")]
		public Id128<PartialActionPayload.M> BVHYROTZCTA([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x101E990", Offset = "0x101DD90", VA = "0x18101E990")]
		public int XXMTSTZAEHM([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x28A0520", Offset = "0x289F920", VA = "0x1828A0520")]
		public int UYVYNGTXRWR([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x101E990", Offset = "0x101DD90", VA = "0x18101E990", Slot = "4")]
		private int RXNOOKKQBMG([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x28A0520", Offset = "0x289F920", VA = "0x1828A0520", Slot = "5")]
		private int OYWTIXFNPBL([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xFE3F40", Offset = "0xFE3340", VA = "0x180FE3F40", Slot = "6")]
		private Id128<PartialActionPayload.M> CQDHHMUQERE([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, HJODGUBVAZG, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xFF1B60", Offset = "0xFF0F60", VA = "0x180FF1B60")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, HJODGUBVAZG, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x28A1310", Offset = "0x28A0710", VA = "0x1828A1310")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class FBYZZXESSHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840")]
		public static SnapshotReassembly<PartialInitializePayload, HJODGUBVAZG, SnapshotReassemblyDeps> QNECGDCLYAI(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, HJODGUBVAZG, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : ISRERWWKWCT.UCZEUQCEQAZ<PartialInitializePayload, HJODGUBVAZG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xE15630", Offset = "0xE14A30", VA = "0x180E15630")]
		public int WSRKZNMXUAE([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x28A1130", Offset = "0x28A0530", VA = "0x1828A1130", Slot = "5")]
		public HJODGUBVAZG OSQJMCHOHDI(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xE15630", Offset = "0xE14A30", VA = "0x180E15630", Slot = "4")]
		private int QOWKGDPHQIE([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class WJVZZORFQEC : NBILMTLEEJL, NIBBSNHBBHP, ZEEUKBHYSTE, AFOSPUXIYKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly AFOSPUXIYKE? ZNQBZGAZMIM;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind DKWEGDBOTPS
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xAA8B20", Offset = "0xAA7F20", VA = "0x180AA8B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override AFOSPUXIYKE? EFZWNFDHPGR
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x28A8270", Offset = "0x28A7670", VA = "0x1828A8270", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x28A8440", Offset = "0x28A7840", VA = "0x1828A8440")]
		private WJVZZORFQEC(PrepareTemplateForCloneErrKind a, AFOSPUXIYKE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x28A8370", Offset = "0x28A7770", VA = "0x1828A8370")]
		public static WJVZZORFQEC FZJCGDOPCIC(AFOSPUXIYKE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x28A83E0", Offset = "0x28A77E0", VA = "0x1828A83E0")]
		public static WJVZZORFQEC KFBYTXLRPQE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x28A8210", Offset = "0x28A7610", VA = "0x1828A8210")]
		public static WJVZZORFQEC BVQKJKMBIRA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class XRQLDNSNQUZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0980", Offset = "0x3BEFD80", VA = "0x183BF0980")]
		public static Result<TOk, NIBBSNHBBHP> WEBREATOZGX<TOk>([In] this Result<TOk, NIBBSNHBBHP> self, AFOSPUXIYKE a) where TOk : notnull
		{
			return default(Result<TOk, NIBBSNHBBHP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0900", Offset = "0x3BEFD00", VA = "0x183BF0900")]
		public static Result<a?, NIBBSNHBBHP?> NEFWNLCECKP<a>([In] this Result<a, NIBBSNHBBHP> self)
		{
			return default(Result<a, NIBBSNHBBHP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0BC0", Offset = "0x3BEFFC0", VA = "0x183BF0BC0")]
		public static Result<b?, NIBBSNHBBHP?> YVSMBBFIOLX<b>([In] this Result<b, NIBBSNHBBHP> self)
		{
			return default(Result<b, NIBBSNHBBHP>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface DEPMCWKOSXQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CCZUGUEGOGO([In] Result<None, AFOSPUXIYKE> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class WKFWQMVQGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE580", Offset = "0x3BDD980", VA = "0x183BDE580")]
		public static bool CCZUGUEGOGO<TOk, TErr>(this DEPMCWKOSXQ a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, AFOSPUXIYKE
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface HWWVWTNKRNF
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		VUYLGSMGCXP IMGPIXLWBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface JZZMFKCCSQP
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor QSLJDBWJOYK(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface OYBMJXLONTI
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface PDQNYXYUBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JLECLJJXMGZ? RXOZAKKCSLM(Id32<PBWXKRRVJJL> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface XGQWUSWDRHB
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface JLECLJJXMGZ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XGQWUSWDRHB? PYMAKXOLGIQ(Id32<GAODAGDLSAS> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OYBMJXLONTI? NGRYITFJPBF(Id32<KBHHKAZFCJZ> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface DSKKGSMHSDN
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> FKZRLPDXQPF(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface OJKJTUFQHTH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PDQNYXYUBDH? DWKMYFJVGMA([In] Id128<XNNOENVVCYV> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class QMUHBVNXONK
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		private struct Diagnostic
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public int Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public CircuitRootData? BaseState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public CircuitRootData? FinalState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public readonly List<HJODGUBVAZG> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2896550", Offset = "0x2895950", VA = "0x182896550")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<HJODGUBVAZG> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x28964A0", Offset = "0x28958A0", VA = "0x1828964A0")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly WTJERDZAMVT<Diagnostic> SRWYQHLCVHQ;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static QMUHBVNXONK ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x28A0830", Offset = "0x289FC30", VA = "0x1828A0830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool QBPQFASIOUY
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xAF68E0", Offset = "0xAF5CE0", VA = "0x180AF68E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xB49690", Offset = "0xB48A90", VA = "0x180B49690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x28A0770", Offset = "0x289FB70", VA = "0x1828A0770")]
		public void JOUVPHHQPIH(NOBNTZOERHO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x28A0880", Offset = "0x289FC80", VA = "0x1828A0880")]
		public void RCVVZLXIRAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x28A0B60", Offset = "0x289FF60", VA = "0x1828A0B60")]
		private static string? ZUWNNBFTPGE([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E10", Offset = "0x28A0210", VA = "0x1828A0E10")]
		public QMUHBVNXONK()
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
