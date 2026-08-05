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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B503A0", Offset = "0x2B4EDA0", VA = "0x182B503A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B50080", Offset = "0x2B4EA80", VA = "0x182B50080", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class WVKEVWTACCJ : IDisposable, FPJQQVBJGJY, OVPOWTRSBTJ, PDLCNGTQCDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class TOSGPLXPKRG : EDIRCJTODTF
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int PHNYNSBVTEQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B530F0", Offset = "0x2B51AF0", VA = "0x182B530F0", Slot = "5")]
			public ZXAQAILBSDB YVCCCRSVEYM(XMAUPUIQGZI.EDIRCJTODTF a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void WBXDMQCSMTS();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void FUUXJSJVIMH();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2B40580", Offset = "0x2B3EF80", VA = "0x182B40580", Slot = "13")]
			public virtual void PUQWPIKFXQV(WVKEVWTACCJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2B53070", Offset = "0x2B51A70", VA = "0x182B53070", Slot = "14")]
			public virtual void TWRSIEQBTJQ(WVKEVWTACCJ a, PZJVNVFLVDC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			protected TOSGPLXPKRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface EDIRCJTODTF
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int PHNYNSBVTEQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			ZXAQAILBSDB YVCCCRSVEYM(XMAUPUIQGZI.EDIRCJTODTF a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void WBXDMQCSMTS();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void FUUXJSJVIMH();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void PUQWPIKFXQV(WVKEVWTACCJ a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void TWRSIEQBTJQ(WVKEVWTACCJ a, PZJVNVFLVDC b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
			internal Reducer(Reducer<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class QGRMNVKMAQE : TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly QGRMNVKMAQE UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private QGRMNVKMAQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15643B0", Offset = "0x1562DB0", VA = "0x1815643B0", Slot = "4")]
			public ActionKind UTIQTDSCBKI(PZJVNVFLVDC a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2B51E80", Offset = "0x2B50880", VA = "0x182B51E80", Slot = "5")]
			public void PUQWPIKFXQV(WVKEVWTACCJ a, PZJVNVFLVDC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2B51F80", Offset = "0x2B50980", VA = "0x182B51F80", Slot = "6")]
			public void TWRSIEQBTJQ(WVKEVWTACCJ a, PZJVNVFLVDC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2B528F0", Offset = "0x2B512F0", VA = "0x182B528F0")]
			internal ReducerFactory(ReducerFactory<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B528A0", Offset = "0x2B512A0", VA = "0x182B528A0")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : OPEKJLKYGKI.FYJFWLXEJPG<PZJVNVFLVDC, WVKEVWTACCJ>
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
				public AsyncTaskMethodBuilder<Result<object?, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public WVKEVWTACCJ receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public PZJVNVFLVDC action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B53C70", Offset = "0x2B52670", VA = "0x182B53C70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B53E50", Offset = "0x2B52850", VA = "0x182B53E50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD77000", Offset = "0xD75A00", VA = "0x180D77000", Slot = "4")]
			public Id32<HGRDVVOSLAK> PNHSFNDCQRJ(WVKEVWTACCJ a)
			{
				return default(Id32<HGRDVVOSLAK>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B52BD0", Offset = "0x2B515D0", VA = "0x182B52BD0", Slot = "5")]
			public void SJTXTDPNTDC(WVKEVWTACCJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B52A80", Offset = "0x2B51480", VA = "0x182B52A80", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, LSNRXVKTUTI>> QIQIZJQHZIN(WVKEVWTACCJ a, PZJVNVFLVDC b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B52BB0", Offset = "0x2B515B0", VA = "0x182B52BB0", Slot = "7")]
			public PZJVNVFLVDC[] SCDWNOWOISZ(WVKEVWTACCJ a)
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
			public AsyncTaskMethodBuilder<Result<object?, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public WVKEVWTACCJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public PZJVNVFLVDC action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B53EC0", Offset = "0x2B528C0", VA = "0x182B53EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2B540B0", Offset = "0x2B52AB0", VA = "0x182B540B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public WVKEVWTACCJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2B555E0", Offset = "0x2B53FE0", VA = "0x182B555E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2B55860", Offset = "0x2B54260", VA = "0x182B55860", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public WVKEVWTACCJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2B558D0", Offset = "0x2B542D0", VA = "0x182B558D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2B55AB0", Offset = "0x2B544B0", VA = "0x182B55AB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<HGRDVVOSLAK> MZIHHZXHHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer BPTPQCJZEZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 FOZZBHTXGWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly KGZAGFPSONW AKEKSPRGEPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly HVIEREJNYRS.CreationArgs IALKORNHFYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly OXXLVKMOKKB TNNUPNHDEEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly LXKSZMFCJNW KDEJUHVLICZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly IJIJKKOKDTB KCWFTUSHFHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly BRHZVFSAZBG QKSZVEDMRVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly IPSDSBEJJJW UFBLJRFRFRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly SBRYYKENNXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly APCPGPMJTVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest YXLKWYDAJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended ONRQFSBTMMP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal EDIRCJTODTF KJNCCYLCOGK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B675D0", Offset = "0x2B65FD0", VA = "0x182B675D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal ZXAQAILBSDB TKRDIMJTJTY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B66530", Offset = "0x2B64F30", VA = "0x182B66530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B677E0", Offset = "0x2B661E0", VA = "0x182B677E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool KEKPZHOSXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2B669A0", Offset = "0x2B653A0", VA = "0x182B669A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B66FB0", Offset = "0x2B659B0", VA = "0x182B66FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ZJPITFYRNSE OXXLVKMOKKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B67AF0", Offset = "0x2B664F0", VA = "0x182B67AF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RVNDFUOAHGM IJIJKKOKDTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B67B00", Offset = "0x2B66500", VA = "0x182B67B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ZLCREPABUWP IPSDSBEJJJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B67B20", Offset = "0x2B66520", VA = "0x182B67B20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HKSUIQJZABZ LXKSZMFCJNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B671C0", Offset = "0x2B65BC0", VA = "0x182B671C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NZEXPRIDSRH BRHZVFSAZBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2B67B10", Offset = "0x2B66510", VA = "0x182B67B10", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HVIEREJNYRS? HVIEREJNYRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B66540", Offset = "0x2B64F40", VA = "0x182B66540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B67800", Offset = "0x2B66200", VA = "0x182B67800")]
		private WVKEVWTACCJ(KGZAGFPSONW a, Id32<HGRDVVOSLAK> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, ZXAQAILBSDB b, [In] HVIEREJNYRS.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B66C20", Offset = "0x2B65620", VA = "0x182B66C20")]
		public static WVKEVWTACCJ New(KGZAGFPSONW deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<HGRDVVOSLAK> actorId, Id32<TBNPHTPCKFD> rootNetworkObjectId, WNWYUXAFTQH staticNetSys, BBNEQAUDUTJ dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B66CF0", Offset = "0x2B656F0", VA = "0x182B66CF0")]
		public static WVKEVWTACCJ New(KGZAGFPSONW dependencies, [In] RegistryV2 registryV2, Id32<HGRDVVOSLAK> actorId, Id32<TBNPHTPCKFD> rootNetworkObjectId, WNWYUXAFTQH staticNetSys, BBNEQAUDUTJ dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B66630", Offset = "0x2B65030", VA = "0x182B66630", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B676F0", Offset = "0x2B660F0", VA = "0x182B676F0")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, LSNRXVKTUTI>> XYGMZUWSBTS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B66FC0", Offset = "0x2B659C0", VA = "0x182B66FC0")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, LSNRXVKTUTI>> RCQJSXMNYUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B669B0", Offset = "0x2B653B0", VA = "0x182B669B0")]
		internal void NATVDDMHMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B67670", Offset = "0x2B66070", VA = "0x182B67670")]
		internal Option<PZJVNVFLVDC> VMPZAFLSFJG([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<PZJVNVFLVDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B66BB0", Offset = "0x2B655B0", VA = "0x182B66BB0")]
		internal bool NMPGWYICQLZ([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B66810", Offset = "0x2B65210", VA = "0x182B66810")]
		internal Result<PZJVNVFLVDC, LSNRXVKTUTI> EAYLMOZHKMA([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<PZJVNVFLVDC, LSNRXVKTUTI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B67620", Offset = "0x2B66020", VA = "0x182B67620")]
		private void SJTXTDPNTDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B670B0", Offset = "0x2B65AB0", VA = "0x182B670B0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, LSNRXVKTUTI>> RMOOFWPUEOM(PZJVNVFLVDC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B671D0", Offset = "0x2B65BD0", VA = "0x182B671D0")]
		private PZJVNVFLVDC[] SCDWNOWOISZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class IGJCHPAFDWJ<a> : XZBQMYIZLTP, TDSQTQMUFMV, CBUCXYTAOGI where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<CEDSPQRYDBL>? XYTRPZEHMBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a IONDNHXDBLE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<CEDSPQRYDBL>? IPOIPWCDTRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E40B60", Offset = "0x2E3F560", VA = "0x182E40B60", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x65FB8A0", Offset = "0x65FA2A0", VA = "0x1865FB8A0")]
		internal IGJCHPAFDWJ([In] Id128<CEDSPQRYDBL>? lastNode, Id32<KSZBOHEYNRE>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ODVSSMSIQKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B50420", Offset = "0x2B4EE20", VA = "0x182B50420")]
		public static Result<DebugExecutionResult, TDSQTQMUFMV> PPMINXOXHOG([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, TDSQTQMUFMV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FF00", Offset = "0x3D8E900", VA = "0x183D8FF00")]
		public static Result<TOk, TDSQTQMUFMV> KDOBGFLDUWS<TOk>([In] this Result<TOk, TDSQTQMUFMV> self, [In] Id128<CEDSPQRYDBL>? lastNode, Id32<KSZBOHEYNRE>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, TDSQTQMUFMV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KGZAGFPSONW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		XMAUPUIQGZI.EDIRCJTODTF QQSGIYSOZPS
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		WVKEVWTACCJ.EDIRCJTODTF CKHCKHISSXB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		SSKFXZAJUJK.EDIRCJTODTF WPPKKHSNBIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ> QGRMNVKMAQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.EDIRCJTODTF MQTYZCVAYDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		FAUMPQIMSBQ KMJQRCLCRZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ZIVHGNLPODZ CEPSAYZQRJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		DNRVFIQUYRJ WGWXVQLTCSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		GPWQFBHBUSL ZZIBOIJSCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		KXKYWNBNZAB KGXWIDEYNYA
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
	public static class JRAGQZQPGXB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FAB0", Offset = "0x2B4E4B0", VA = "0x182B4FAB0")]
		public static PZJVNVFLVDC VTTFQVGVQMW(this PZJVNVFLVDC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F9E0", Offset = "0x2B4E3E0", VA = "0x182B4F9E0")]
		public static PZJVNVFLVDC DKKPZCKLEEB(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public WVKEVWTACCJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B54120", Offset = "0x2B52B20", VA = "0x182B54120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B54840", Offset = "0x2B53240", VA = "0x182B54840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B6E0", Offset = "0x2B4A0E0", VA = "0x182B4B6E0")]
		public static PZJVNVFLVDC VHCGKWFWTEO(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B7A0", Offset = "0x2B4A1A0", VA = "0x182B4B7A0")]
		public static ReduceAction<ActionKind, CompressedPayload> WRDJHELJLVB(PZJVNVFLVDC actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B5D0", Offset = "0x2B49FD0", VA = "0x182B4B5D0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, LSNRXVKTUTI>> RMOOFWPUEOM(WVKEVWTACCJ a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BE40", Offset = "0x2B4A840", VA = "0x182B4BE40")]
		public static PZJVNVFLVDC VHCGKWFWTEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BEE0", Offset = "0x2B4A8E0", VA = "0x182B4BEE0")]
		public static ReduceAction<ActionKind, DestroyPayload> WRDJHELJLVB(PZJVNVFLVDC actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BDC0", Offset = "0x2B4A7C0", VA = "0x182B4BDC0")]
		public static Result<None, SZAJLKSAEQL> LVNNLDHLSLW(WVKEVWTACCJ a, [In] DestroyPayload self)
		{
			return default(Result<None, SZAJLKSAEQL>);
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
			public AsyncTaskMethodBuilder<Result<None, SZAJLKSAEQL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public WVKEVWTACCJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, SZAJLKSAEQL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B54920", Offset = "0x2B53320", VA = "0x182B54920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B54EC0", Offset = "0x2B538C0", VA = "0x182B54EC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EBE0", Offset = "0x2B4D5E0", VA = "0x182B4EBE0")]
		public static PZJVNVFLVDC? VHCGKWFWTEO(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ECE0", Offset = "0x2B4D6E0", VA = "0x182B4ECE0")]
		public static ReduceAction<ActionKind, FullInitializePayload> WRDJHELJLVB(PZJVNVFLVDC actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EAA0", Offset = "0x2B4D4A0", VA = "0x182B4EAA0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, SZAJLKSAEQL>> RMOOFWPUEOM(WVKEVWTACCJ a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public WVKEVWTACCJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, LSNRXVKTUTI> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, CBUCXYTAOGI>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, CBUCXYTAOGI> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, CBUCXYTAOGI>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B543E0", Offset = "0x2B52DE0", VA = "0x182B543E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B548B0", Offset = "0x2B532B0", VA = "0x182B548B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<PZJVNVFLVDC> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		private MultiPayload(IReadOnlyList<PZJVNVFLVDC> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B50240", Offset = "0x2B4EC40", VA = "0x182B50240")]
		public static PZJVNVFLVDC VHCGKWFWTEO(IReadOnlyList<PZJVNVFLVDC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B50300", Offset = "0x2B4ED00", VA = "0x182B50300")]
		public static ReduceAction<ActionKind, MultiPayload> WRDJHELJLVB(PZJVNVFLVDC actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B50100", Offset = "0x2B4EB00", VA = "0x182B50100")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, LSNRXVKTUTI>> RMOOFWPUEOM(WVKEVWTACCJ a, MultiPayload b)
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
		private sealed class ACWIPAVUBWN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> GJNZCZGEAVH;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ACWIPAVUBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A480", Offset = "0x2B48E80", VA = "0x182B4A480")]
			internal PZJVNVFLVDC NKDFSYSNRLL(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2B51970", Offset = "0x2B50370", VA = "0x182B51970")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B51610", Offset = "0x2B50010", VA = "0x182B51610")]
		public static PZJVNVFLVDC VHCGKWFWTEO(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B51870", Offset = "0x2B50270", VA = "0x182B51870")]
		public static PZJVNVFLVDC[] XDADLOOPHCF(PZJVNVFLVDC a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B51720", Offset = "0x2B50120", VA = "0x182B51720")]
		public static ReduceAction<ActionKind, PartialActionPayload> WRDJHELJLVB(PZJVNVFLVDC actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B51470", Offset = "0x2B4FE70", VA = "0x182B51470")]
		public static Result<PZJVNVFLVDC, LSNRXVKTUTI> LVNNLDHLSLW(WVKEVWTACCJ a, [In] PartialActionPayload self)
		{
			return default(Result<PZJVNVFLVDC, LSNRXVKTUTI>);
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
			public AsyncTaskMethodBuilder<Result<bool, SZAJLKSAEQL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public WVKEVWTACCJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, SZAJLKSAEQL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, SZAJLKSAEQL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B54F30", Offset = "0x2B53930", VA = "0x182B54F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B55570", Offset = "0x2B53F70", VA = "0x182B55570", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xDBB760", Offset = "0xDBA160", VA = "0x180DBB760")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B51CC0", Offset = "0x2B506C0", VA = "0x182B51CC0")]
		public static PZJVNVFLVDC VHCGKWFWTEO(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B51990", Offset = "0x2B50390", VA = "0x182B51990")]
		public static PZJVNVFLVDC?[]? AMEQWVHNJNX(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B51DA0", Offset = "0x2B507A0", VA = "0x182B51DA0")]
		public static ReduceAction<ActionKind, PartialInitializePayload> WRDJHELJLVB(PZJVNVFLVDC actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B51B90", Offset = "0x2B50590", VA = "0x182B51B90")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, SZAJLKSAEQL>> RMOOFWPUEOM(WVKEVWTACCJ a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class OXXLVKMOKKB : ZJPITFYRNSE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public XKNPMSZWBSX? UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B50E30", Offset = "0x2B4F830", VA = "0x182B50E30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		internal OXXLVKMOKKB(WVKEVWTACCJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class EWGOXCXULYO : XKNPMSZWBSX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly HVIEREJNYRS UQGEAXTBTEI;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		public EWGOXCXULYO(WVKEVWTACCJ a, HVIEREJNYRS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DCC0", Offset = "0x2B4C6C0", VA = "0x182B4DCC0", Slot = "4")]
		public Result<DebugExecutionResult, TDSQTQMUFMV> HFDZCVVLYOI(Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<ZJIVHHLEHRT> inputId)
		{
			return default(Result<DebugExecutionResult, TDSQTQMUFMV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E270", Offset = "0x2B4CC70", VA = "0x182B4E270", Slot = "5")]
		public Result<DebugExecutionResult, TDSQTQMUFMV> RPFCNXEEJGP(Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<HEUBCRFOLEU> outputId)
		{
			return default(Result<DebugExecutionResult, TDSQTQMUFMV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class XMAUPUIQGZI : ZXAQAILBSDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface EDIRCJTODTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<IXGBGWAFRHJ> JXAYLNMNNNM(WVKEVWTACCJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void NPAUFLDLWVE(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class TOSGPLXPKRG : EDIRCJTODTF
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
				public AsyncTaskMethodBuilder<IXGBGWAFRHJ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public WVKEVWTACCJ circuitsManager;

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
				private TaskAwaiter<SSKFXZAJUJK> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2B53220", Offset = "0x2B51C20", VA = "0x182B53220", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2B533F0", Offset = "0x2B51DF0", VA = "0x182B533F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B52F10", Offset = "0x2B51910", VA = "0x182B52F10", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<IXGBGWAFRHJ> JXAYLNMNNNM(WVKEVWTACCJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void NPAUFLDLWVE(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			protected TOSGPLXPKRG()
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
			public AsyncTaskMethodBuilder<IXGBGWAFRHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public XMAUPUIQGZI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B53460", Offset = "0x2B51E60", VA = "0x182B53460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B53660", Offset = "0x2B52060", VA = "0x182B53660", Slot = "5")]
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
			public XMAUPUIQGZI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public WVKEVWTACCJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<IXGBGWAFRHJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B536D0", Offset = "0x2B520D0", VA = "0x182B536D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B53C10", Offset = "0x2B52610", VA = "0x182B53C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly EDIRCJTODTF FHQCWCTTOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> NASIXZZAOSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> WMWVYZUPGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource CXKUKBNNSGN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool KEKPZHOSXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD70630", Offset = "0xD6F030", VA = "0x180D70630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF88D10", Offset = "0xF87710", VA = "0x180F88D10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xFC4750", Offset = "0xFC3150", VA = "0x180FC4750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool NTQTKIUPJMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1AED930", Offset = "0x1AEC330", VA = "0x181AED930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1B42350", Offset = "0x1B40D50", VA = "0x181B42350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IXGBGWAFRHJ? UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B67E40", Offset = "0x2B66840", VA = "0x182B67E40", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<IXGBGWAFRHJ> MKPIHAMKQPZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B67F30", Offset = "0x2B66930", VA = "0x182B67F30")]
		public XMAUPUIQGZI(EDIRCJTODTF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B67B90", Offset = "0x2B66590", VA = "0x182B67B90", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task CIERCNDZLYE(WVKEVWTACCJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B67CD0", Offset = "0x2B666D0", VA = "0x182B67CD0", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class WKZNUQPQOKP : ASJSFOXYQJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly AMJPMKEJKQH ZUMEVLWEGDA;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public WKZNUQPQOKP(AMJPMKEJKQH a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class SQFMAKTSTVS
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class HIYTZJWVLXQ<a> : PHLWUXYOEFH where a : UEJGFSAMNOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a ORHKDDGKPCR;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? TBOHOFZKMKD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xF27E80", Offset = "0xF26880", VA = "0x180F27E80", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<CEDSPQRYDBL>? EYMUNTXOKHJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x65199E0", Offset = "0x65183E0", VA = "0x1865199E0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<JNHEPOTZQDV> RYMNSBEUIGP
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2E4B010", Offset = "0x2E49A10", VA = "0x182E4B010", Slot = "5")]
				get
				{
					return default(Id32<JNHEPOTZQDV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<JNHEPOTZQDV>? DJGYFWAVSVJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6519960", Offset = "0x6518360", VA = "0x186519960", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
			public HIYTZJWVLXQ(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class YUIVVVQZMXS : HIYTZJWVLXQ<KJNFEDJOSMK>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? TBOHOFZKMKD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x1077AE0", Offset = "0x10764E0", VA = "0x181077AE0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B68620", Offset = "0x2B67020", VA = "0x182B68620")]
			public YUIVVVQZMXS(KJNFEDJOSMK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B52900", Offset = "0x2B51300", VA = "0x182B52900")]
		public static PHLWUXYOEFH New(UEJGFSAMNOD graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class ZRCWHHAAVNK : BWLKBSEDFQH, ZYTONKDQJVT, OYFUCBVVEZS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class GAHZWIDGSKG
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
				public GAHZWIDGSKG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public FAUMPQIMSBQ errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B56CC0", Offset = "0x2B556C0", VA = "0x182B56CC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B56F30", Offset = "0x2B55930", VA = "0x182B56F30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public ZRCWHHAAVNK TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool LRHGTXAQZPF;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GAHZWIDGSKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EDF0", Offset = "0x2B4D7F0", VA = "0x182B4EDF0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task UXSGIZFDKOS(FAUMPQIMSBQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class XYEKQIUPMDI
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
				public XYEKQIUPMDI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x2B56F90", Offset = "0x2B55990", VA = "0x182B56F90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x2B57270", Offset = "0x2B55C70", VA = "0x182B57270", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public ZRCWHHAAVNK TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int LRHGTXAQZPF;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XYEKQIUPMDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B68030", Offset = "0x2B66A30", VA = "0x182B68030")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task RFOZBMAAVDO(FAUMPQIMSBQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class CRLCKBCPMKT
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
				public CRLCKBCPMKT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x2B577E0", Offset = "0x2B561E0", VA = "0x182B577E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B57C90", Offset = "0x2B56690", VA = "0x182B57C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string LRHGTXAQZPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public ZRCWHHAAVNK TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int TFERXTSGYAF;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CRLCKBCPMKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B500", Offset = "0x2B49F00", VA = "0x182B4B500")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task GNBZVVGBCPY(FAUMPQIMSBQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class GKDQTSDTQBS
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
				public GKDQTSDTQBS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B572D0", Offset = "0x2B55CD0", VA = "0x182B572D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B57780", Offset = "0x2B56180", VA = "0x182B57780", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string LRHGTXAQZPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public ZRCWHHAAVNK TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int TFERXTSGYAF;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GKDQTSDTQBS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EEE0", Offset = "0x2B4D8E0", VA = "0x182B4EEE0")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task KYDLDDJNQJM(FAUMPQIMSBQ a)
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
			public ZRCWHHAAVNK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2B55B20", Offset = "0x2B54520", VA = "0x182B55B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B56030", Offset = "0x2B54A30", VA = "0x182B56030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly RYNZYDWHOFL YCUGIKFSQWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<JZDPAJDHTHD> PRIWMHRATLY;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KGZAGFPSONW TOSGPLXPKRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B6C1A0", Offset = "0x2B6ABA0", VA = "0x182B6C1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<ZJIVHHLEHRT> DFUZABHQYGU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE3D3A0", Offset = "0xE3BDA0", VA = "0x180E3D3A0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<ZJIVHHLEHRT>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xF39D20", Offset = "0xF38720", VA = "0x180F39D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<TQQQOXOZIAW> IJSXWBMXBNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AE64B0", Offset = "0x2AE4EB0", VA = "0x182AE64B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<QHFBBKDJWVN> DDSFVFRDOSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x12AA490", Offset = "0x12A8E90", VA = "0x1812AA490", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QHFBBKDJWVN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<KSZBOHEYNRE> NRJLNJAXMBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B6B850", Offset = "0x2B6A250", VA = "0x182B6B850", Slot = "22")]
			get
			{
				return default(Id32<KSZBOHEYNRE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool IOOVRRREEJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B6C1C0", Offset = "0x2B6ABC0", VA = "0x182B6C1C0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C590", Offset = "0x2B6AF90", VA = "0x182B6C590")]
		private ZRCWHHAAVNK(WVKEVWTACCJ a, QQDUHQODGUC b, RYNZYDWHOFL c, Id32<SLVANOSNYVT> portGroupId, Id32<ZJIVHHLEHRT> inputId, Id32<TQQQOXOZIAW> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B4A0", Offset = "0x2B69EA0", VA = "0x182B6B4A0")]
		public static ZRCWHHAAVNK New(WVKEVWTACCJ circuitsManager, QQDUHQODGUC node, RYNZYDWHOFL input, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId, Id32<ZJIVHHLEHRT> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AA60", Offset = "0x2B69460", VA = "0x182B6AA60", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A200", Offset = "0x2B68C00", VA = "0x182B6A200", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BE40", Offset = "0x2B6A840", VA = "0x182B6BE40", Slot = "32")]
		public void RUFHMRAQFYT(JZDPAJDHTHD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B69A10", Offset = "0x2B68410", VA = "0x182B69A10", Slot = "29")]
		public void DJXDWKSTVEY(FEDPZVIHXCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B68A70", Offset = "0x2B67470", VA = "0x182B68A70", Slot = "30")]
		public void CYXCDQYXTAT(SQLANVOTPXH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C240", Offset = "0x2B6AC40", VA = "0x182B6C240", Slot = "25")]
		protected override void XRAWJYICFAX(YOBVMUZZIOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A2A0", Offset = "0x2B68CA0", VA = "0x182B6A2A0", Slot = "34")]
		public string FTUTOBSJPPS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AF40", Offset = "0x2B69940", VA = "0x182B6AF40", Slot = "31")]
		public string KVLOPWSQCZG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A410", Offset = "0x2B68E10", VA = "0x182B6A410")]
		private void GVKWERPYJRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B68860", Offset = "0x2B67260", VA = "0x182B68860", Slot = "33")]
		public void BVLPRDBLEHY(JZDPAJDHTHD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B2E0", Offset = "0x2B69CE0", VA = "0x182B6B2E0")]
		private void LBQYOIFFWLN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AB00", Offset = "0x2B69500", VA = "0x182B6AB00", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task JIWZQDSUWTV(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B68920", Offset = "0x2B67320", VA = "0x182B68920")]
		public void CQAHAIVAJPQ(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C3F0", Offset = "0x2B6ADF0", VA = "0x182B6C3F0")]
		private void ZZVSKFWFRZO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BFE0", Offset = "0x2B6A9E0", VA = "0x182B6BFE0")]
		private void TJYQDHWKEGW(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B8A0", Offset = "0x2B6A2A0", VA = "0x182B6B8A0")]
		private void OWVRBNOCSOZ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BEA0", Offset = "0x2B6A8A0", VA = "0x182B6BEA0")]
		private string SPGJPRHJVQC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B686F0", Offset = "0x2B670F0", VA = "0x182B686F0")]
		private string ANNSHRSNDDZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF39D20", Offset = "0xF38720", VA = "0x180F39D20")]
		internal void QIJFOTZGJQE(Id32<ZJIVHHLEHRT> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A700", Offset = "0x2B69100", VA = "0x182B6A700")]
		[CompilerGenerated]
		private void HCRRACAIDIH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A640", Offset = "0x2B69040", VA = "0x182B6A640")]
		[CompilerGenerated]
		private bool HCMKCVGKTWY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A710", Offset = "0x2B69110", VA = "0x182B6A710")]
		[CompilerGenerated]
		private bool HCWXXIUFMTQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A860", Offset = "0x2B69260", VA = "0x182B6A860")]
		[CompilerGenerated]
		private int HDMSPDBXPBR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A7D0", Offset = "0x2B691D0", VA = "0x182B6A7D0")]
		[CompilerGenerated]
		private bool HDHLRWIAFQI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A970", Offset = "0x2B69370", VA = "0x182B6A970")]
		[CompilerGenerated]
		private void HDXGJQPSHYJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A8B0", Offset = "0x2B692B0", VA = "0x182B6A8B0")]
		[CompilerGenerated]
		private bool HDRZMJVUYNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AA10", Offset = "0x2B69410", VA = "0x182B6AA10")]
		[CompilerGenerated]
		private bool HEHUEEDNAVB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A980", Offset = "0x2B69380", VA = "0x182B6A980")]
		[CompilerGenerated]
		private bool HECNGXJPRJS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A860", Offset = "0x2B69260", VA = "0x182B6A860")]
		[CompilerGenerated]
		private int QSKOUCEBBZK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BA60", Offset = "0x2B6A460", VA = "0x182B6BA60")]
		[CompilerGenerated]
		private bool QSPVRIXYLKT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BB30", Offset = "0x2B6A530", VA = "0x182B6BB30")]
		[CompilerGenerated]
		private object QSVCOPRVUWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A1A0", Offset = "0x2B68BA0", VA = "0x182B6A1A0")]
		[CompilerGenerated]
		private void QTAJLWLTEHL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BB90", Offset = "0x2B6A590", VA = "0x182B6BB90")]
		[CompilerGenerated]
		private bool QTKXGJZNXED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BC60", Offset = "0x2B6A660", VA = "0x182B6BC60")]
		[CompilerGenerated]
		private string QTQEDQTLGPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BCE0", Offset = "0x2B6A6E0", VA = "0x182B6BCE0")]
		[CompilerGenerated]
		private void QTVLAXNIQAV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BCF0", Offset = "0x2B6A6F0", VA = "0x182B6BCF0")]
		[CompilerGenerated]
		private bool QUARYEHFZME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BDC0", Offset = "0x2B6A7C0", VA = "0x182B6BDC0")]
		[CompilerGenerated]
		private string QUFYVLBDIXN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD60", Offset = "0x2B69760", VA = "0x182B6AD60")]
		[CompilerGenerated]
		private void KUMFCXDILGD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC90", Offset = "0x2B69690", VA = "0x182B6AC90")]
		[CompilerGenerated]
		private bool KUGYFQJLBUU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD80", Offset = "0x2B69780", VA = "0x182B6AD80")]
		[CompilerGenerated]
		private string KUWSXKRDECV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD70", Offset = "0x2B69770", VA = "0x182B6AD70")]
		[CompilerGenerated]
		private void KURMADXFURM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AE70", Offset = "0x2B69870", VA = "0x182B6AE70")]
		[CompilerGenerated]
		private bool KVHGRYEXWZN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AE00", Offset = "0x2B69800", VA = "0x182B6AE00")]
		[CompilerGenerated]
		private string KVBZURLANOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B2D0", Offset = "0x2B69CD0", VA = "0x182B6B2D0")]
		[CompilerGenerated]
		private void KVRUMLSSPWF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B200", Offset = "0x2B69C00", VA = "0x182B6B200")]
		[CompilerGenerated]
		private bool KVMNPEYVGKW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC20", Offset = "0x2B69620", VA = "0x182B6AC20")]
		[CompilerGenerated]
		private string KSWBYVADNTJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC10", Offset = "0x2B69610", VA = "0x182B6AC10")]
		[CompilerGenerated]
		private void KSQVBOGGEIA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A060", Offset = "0x2B68A60", VA = "0x182B6A060")]
		[CompilerGenerated]
		private bool DTVAEEVFVNU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A130", Offset = "0x2B68B30", VA = "0x182B6A130")]
		[CompilerGenerated]
		private string DUAHBLPDEZD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B69F80", Offset = "0x2B68980", VA = "0x182B69F80")]
		[CompilerGenerated]
		private void DTKMJRHLCRC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B69F90", Offset = "0x2B68990", VA = "0x182B69F90")]
		[CompilerGenerated]
		private bool DTPTGYBIMCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B69F00", Offset = "0x2B68900", VA = "0x182B69F00")]
		[CompilerGenerated]
		private string DSZYPDTQJUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B69F70", Offset = "0x2B68970", VA = "0x182B69F70")]
		[CompilerGenerated]
		private void DTFFMKNNTFT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B69DD0", Offset = "0x2B687D0", VA = "0x182B69DD0")]
		[CompilerGenerated]
		private bool DSPKUQFVQXS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B69EA0", Offset = "0x2B688A0", VA = "0x182B69EA0")]
		[CompilerGenerated]
		private object DSURRWZTAJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A1A0", Offset = "0x2B68BA0", VA = "0x182B6A1A0")]
		[CompilerGenerated]
		private void DVLDIGYKTAO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C320", Offset = "0x2B6AD20", VA = "0x182B6C320")]
		[CompilerGenerated]
		private bool YVUPAHTNQQV()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class WINRYUUOHBU
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class TBUMISEQXSC : DJHXDSZWRBQ<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public TBUMISEQXSC TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AA40", Offset = "0x2B49440", VA = "0x182B4AA40")]
				internal object DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AE20", Offset = "0x2B49820", VA = "0x182B4AE20")]
				internal void DAXDMWYHHED(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2B52EA0", Offset = "0x2B518A0", VA = "0x182B52EA0")]
			public TBUMISEQXSC(WVKEVWTACCJ a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x2B52C30", Offset = "0x2B51630", VA = "0x182B52C30", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class KACIDYFDUYX : QCNAPQKROEB<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType FGUOEPSMTLU
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FBC0", Offset = "0x2B4E5C0", VA = "0x182B4FBC0")]
			public KACIDYFDUYX(WVKEVWTACCJ a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class OPCLVDAQQTZ : DJHXDSZWRBQ<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2B50BA0", Offset = "0x2B4F5A0", VA = "0x182B50BA0")]
			public OPCLVDAQQTZ(WVKEVWTACCJ a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2B50A40", Offset = "0x2B4F440", VA = "0x182B50A40", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2B508C0", Offset = "0x2B4F2C0", VA = "0x182B508C0")]
			[CompilerGenerated]
			private bool HTJRYKWAUWE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2B50910", Offset = "0x2B4F310", VA = "0x182B50910")]
			[CompilerGenerated]
			private void HTOYVRPYEHN(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class LXQGEURSCJN : DJHXDSZWRBQ<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public LXQGEURSCJN TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A9A0", Offset = "0x2B493A0", VA = "0x182B4A9A0")]
				internal void DARWPQEJXSU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AEF0", Offset = "0x2B498F0", VA = "0x182B4AEF0")]
				internal bool DAXDMWYHHED()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AF40", Offset = "0x2B49940", VA = "0x182B4AF40")]
				internal bool DBCKKDSEQPM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B130", Offset = "0x2B49B30", VA = "0x182B4B130")]
				internal void DBHRHKMCAAV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A660", Offset = "0x2B49060", VA = "0x182B4A660")]
				internal bool CZWVAPCULZK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2B50010", Offset = "0x2B4EA10", VA = "0x182B50010")]
			public LXQGEURSCJN(WVKEVWTACCJ a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FD00", Offset = "0x2B4E700", VA = "0x182B4FD00", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class JFHDOJBQNJN : DJHXDSZWRBQ<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public JFHDOJBQNJN TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> YADCNWBVSFA;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A8B0", Offset = "0x2B492B0", VA = "0x182B4A8B0")]
				internal object? DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A830", Offset = "0x2B49230", VA = "0x182B4A830")]
				internal bool DAMPSJKMOHL(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AAA0", Offset = "0x2B494A0", VA = "0x182B4AAA0")]
				internal void DAXDMWYHHED(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AFE0", Offset = "0x2B499E0", VA = "0x182B4AFE0")]
				internal string DBCKKDSEQPM(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B260", Offset = "0x2B49C60", VA = "0x182B4B260")]
				internal IReadOnlyList<object> DBHRHKMCAAV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A5F0", Offset = "0x2B48FF0", VA = "0x182B4A5F0")]
				internal bool CZWVAPCULZK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A6B0", Offset = "0x2B490B0", VA = "0x182B4A6B0")]
				internal bool DACBXVWRVKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A700", Offset = "0x2B49100", VA = "0x182B4A700")]
				internal void DAHIVCQPEWC(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F700", Offset = "0x2B4E100", VA = "0x182B4F700")]
			public JFHDOJBQNJN(WVKEVWTACCJ a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F010", Offset = "0x2B4DA10", VA = "0x182B4F010", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class FKLPFUHOAYC : DJHXDSZWRBQ<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public FKLPFUHOAYC TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A9F0", Offset = "0x2B493F0", VA = "0x182B4A9F0")]
				internal bool DARWPQEJXSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x2B4ACF0", Offset = "0x2B496F0", VA = "0x182B4ACF0")]
				internal void DAXDMWYHHED(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AF90", Offset = "0x2B49990", VA = "0x182B4AF90")]
				internal bool DBCKKDSEQPM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EA30", Offset = "0x2B4D430", VA = "0x182B4EA30")]
			public FKLPFUHOAYC(WVKEVWTACCJ a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E820", Offset = "0x2B4D220", VA = "0x182B4E820", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class VNFEURCUAUH : DJHXDSZWRBQ<JVOUGJCBLDW>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class PKPAGNSVYSD
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
					public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public PKPAGNSVYSD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<XKJFYYKFODF>, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2B56470", Offset = "0x2B54E70", VA = "0x182B56470", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2B56850", Offset = "0x2B55250", VA = "0x182B56850", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public PKPAGNSVYSD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x2B568C0", Offset = "0x2B552C0", VA = "0x182B568C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x2B56C50", Offset = "0x2B55650", VA = "0x182B56C50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task OWGMVRWGULP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string XMAUWZHTEGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public BBYVCMSUUDJ.QJKWEUUZVRH VOIWZKOAOHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool DQDIHOWETIS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public VNFEURCUAUH TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public BBYVCMSUUDJ JWJDDGYRILI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action BMPONTRNTEU;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public PKPAGNSVYSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2B50F30", Offset = "0x2B4F930", VA = "0x182B50F30")]
				internal bool BBRZQKDAXTY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				internal string GMYUKQHWVDZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x2B50F60", Offset = "0x2B4F960", VA = "0x182B50F60")]
				internal void GNEBHXBUEPI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2B50FE0", Offset = "0x2B4F9E0", VA = "0x182B50FE0")]
				internal void GNJIFDVROAR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x16479E0", Offset = "0x16463E0", VA = "0x1816479E0")]
				internal bool GNOPCKPOXMA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2B51030", Offset = "0x2B4FA30", VA = "0x182B51030")]
				internal void GNTVZRJMGXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2B51250", Offset = "0x2B4FC50", VA = "0x182B51250")]
				internal bool GNZCWYDJQIS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x2B51290", Offset = "0x2B4FC90", VA = "0x182B51290")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, LSNRXVKTUTI>> IFCMBTVLXAE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x2B51380", Offset = "0x2B4FD80", VA = "0x182B51380")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, LSNRXVKTUTI>> VEIUOEXGCBP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class RPQRTZAZVHF
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
					public AsyncTaskMethodBuilder<Result<Id32<XKJFYYKFODF>, LSNRXVKTUTI>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<XKJFYYKFODF>, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x2B56090", Offset = "0x2B54A90", VA = "0x182B56090", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x2B56400", Offset = "0x2B54E00", VA = "0x182B56400", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public VNFEURCUAUH TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public LGEKONOLGQZ HWLWUWRJDZC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool WPKPRZKYALG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public BBYVCMSUUDJ JWJDDGYRILI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public SCJHQENLOSH OBCKFIZRGPU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action YASXFQJNUNB;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public RPQRTZAZVHF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2B52490", Offset = "0x2B50E90", VA = "0x182B52490")]
				internal object? DAXDMWYHHED()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2B52500", Offset = "0x2B50F00", VA = "0x182B52500")]
				internal void DBCKKDSEQPM(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2B525F0", Offset = "0x2B50FF0", VA = "0x182B525F0")]
				internal string DBHRHKMCAAV(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2B52160", Offset = "0x2B50B60", VA = "0x182B52160")]
				internal IReadOnlyList<object> CZWVAPCULZK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2B52200", Offset = "0x2B50C00", VA = "0x182B52200")]
				internal void DACBXVWRVKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2B52360", Offset = "0x2B50D60", VA = "0x182B52360")]
				internal bool DAHIVCQPEWC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2B523D0", Offset = "0x2B50DD0", VA = "0x182B523D0")]
				internal void DAMPSJKMOHL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2B526E0", Offset = "0x2B510E0", VA = "0x182B526E0")]
				internal void DCHZTSHOVFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2B52730", Offset = "0x2B51130", VA = "0x182B52730")]
				internal void DCNGQZBMEQX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x2B52100", Offset = "0x2B50B00", VA = "0x182B52100")]
				internal bool ATLRZAXGNKF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x2B527B0", Offset = "0x2B511B0", VA = "0x182B527B0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<XKJFYYKFODF>, LSNRXVKTUTI>> WFJHGGBWVIN()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<JNHEPOTZQDV>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x2B59E10", Offset = "0x2B58810", VA = "0x182B59E10", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2B59DA0", Offset = "0x2B587A0", VA = "0x182B59DA0")]
			public VNFEURCUAUH(WVKEVWTACCJ a, JVOUGJCBLDW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2B58D80", Offset = "0x2B57780", VA = "0x182B58D80", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2B59710", Offset = "0x2B58110", VA = "0x182B59710")]
			private void VYECKMMDUYC(BBYVCMSUUDJ a, Id32<XKJFYYKFODF>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class HVKLTQDWKRE : GVLKCNAFYYF<VJLWYYSSKMP>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1F73CC0", Offset = "0x1F726C0", VA = "0x181F73CC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool KKZRPNMSPYF
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool FLQXZCNJUJO
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool OOIJTLLZSDP
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EFB0", Offset = "0x2B4D9B0", VA = "0x182B4EFB0")]
			public HVKLTQDWKRE(WVKEVWTACCJ a, VJLWYYSSKMP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class XZGCCFHKIWU<a> : DJHXDSZWRBQ<a> where a : notnull, QBRDYUMMRCM
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
				public AsyncTaskMethodBuilder<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public XZGCCFHKIWU<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x65604A0", Offset = "0x655EEA0", VA = "0x1865604A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x65607F0", Offset = "0x655F1F0", VA = "0x1865607F0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public XZGCCFHKIWU<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<SLVANOSNYVT> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6B3F450", Offset = "0x6B3DE50", VA = "0x186B3F450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x6B3F7A0", Offset = "0x6B3E1A0", VA = "0x186B3F7A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<SLVANOSNYVT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x5143740", Offset = "0x5142140", VA = "0x185143740", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5143710", Offset = "0x5142110", VA = "0x185143710")]
			protected XZGCCFHKIWU(WVKEVWTACCJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5143550", Offset = "0x5141F50", VA = "0x185143550", Slot = "122")]
			[AsyncStateMachine(typeof(XZGCCFHKIWU<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> UUMJVVRWSQJ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x51433A0", Offset = "0x5141DA0", VA = "0x1851433A0", Slot = "149")]
			public sealed override bool IJOBGNQMGKI(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x5143300", Offset = "0x5141D00", VA = "0x185143300", Slot = "134")]
			protected sealed override bool HFWDYMOQWEK(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5143670", Offset = "0x5142070", VA = "0x185143670", Slot = "135")]
			protected override bool WAGMZRFONHL(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5143440", Offset = "0x5141E40", VA = "0x185143440", Slot = "123")]
			[AsyncStateMachine(typeof(XZGCCFHKIWU<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, LSNRXVKTUTI>> SRTSVRNFSGQ(Id32<SLVANOSNYVT> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class YBXQAZICTYB : XEUMHMCOXDA<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public YBXQAZICTYB TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B480", Offset = "0x2B49E80", VA = "0x182B4B480")]
				internal bool RQHRHALQWTP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B2B0", Offset = "0x2B49CB0", VA = "0x182B4B2B0")]
				internal void RQCKJTRTNIG(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2B68340", Offset = "0x2B66D40", VA = "0x182B68340")]
			public YBXQAZICTYB(WVKEVWTACCJ a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2B68100", Offset = "0x2B66B00", VA = "0x182B68100", Slot = "151")]
			protected override void POIMKMHGSIV(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class DOVSIDWNHJU : DJHXDSZWRBQ<SDDWZFHOMPF>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class WKDUFJUPYFO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int DMTVGWYQNOF;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WKDUFJUPYFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BA10", Offset = "0x2B5A410", VA = "0x182B5BA10")]
				internal bool GBPCYKXFKAF(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class JJCJYPIOSDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public DOVSIDWNHJU TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> UQDSGIXIHVX;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public JJCJYPIOSDN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F770", Offset = "0x2B4E170", VA = "0x182B4F770")]
				internal int DARWPQEJXSU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F810", Offset = "0x2B4E210", VA = "0x182B4F810")]
				internal void DAXDMWYHHED(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F930", Offset = "0x2B4E330", VA = "0x182B4F930")]
				internal string? DBCKKDSEQPM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BD50", Offset = "0x2B4A750", VA = "0x182B4BD50")]
			public DOVSIDWNHJU(WVKEVWTACCJ a, SDDWZFHOMPF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B850", Offset = "0x2B4A250", VA = "0x182B4B850")]
			private int EFFQBFAARSR(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B8E0", Offset = "0x2B4A2E0", VA = "0x182B4B8E0")]
			private void SAYQMLBLQWJ(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BA00", Offset = "0x2B4A400", VA = "0x182B4BA00", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class XKTNWLYKANU : GVLKCNAFYYF<UCUCEXOPNRJ>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2B67B30", Offset = "0x2B66530", VA = "0x182B67B30")]
			public XKTNWLYKANU(WVKEVWTACCJ a, UCUCEXOPNRJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class GVLKCNAFYYF<a> : DJHXDSZWRBQ<a> where a : notnull, XXSLNBEMNJV
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class OZJKSJQLPGR
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
					public OZJKSJQLPGR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x4203720", Offset = "0x4202120", VA = "0x184203720", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public BBYVCMSUUDJ JWJDDGYRILI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public GVLKCNAFYYF<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action YAIJLCVTBQJ;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public OZJKSJQLPGR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x72F2DB0", Offset = "0x72F17B0", VA = "0x1872F2DB0")]
				internal void DARWPQEJXSU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x72F2D10", Offset = "0x72F1710", VA = "0x1872F2D10")]
				[AsyncStateMachine(typeof(GVLKCNAFYYF<>.OZJKSJQLPGR.<<BuildConfigMenuInternal>b__6>d))]
				internal void DAHIVCQPEWC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x72F3090", Offset = "0x72F1A90", VA = "0x1872F3090")]
				internal bool DAXDMWYHHED()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class OZEDVCWOFVI
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
					public OZEDVCWOFVI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x4202F40", Offset = "0x4201940", VA = "0x184202F40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string ROBLMRVXKPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public OZJKSJQLPGR UZNLTVLUBPB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> XZIAYVAGGLQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> XZXVQPHYITR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action XZSOTIOAZII;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public OZEDVCWOFVI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x72F28A0", Offset = "0x72F12A0", VA = "0x1872F28A0")]
				internal void DBCKKDSEQPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				internal string DBHRHKMCAAV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				internal void CZWVAPCULZK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x72F2800", Offset = "0x72F1200", VA = "0x1872F2800")]
				[AsyncStateMachine(typeof(GVLKCNAFYYF<>.OZEDVCWOFVI.<<BuildConfigMenuInternal>b__5>d))]
				internal void DACBXVWRVKT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class LGQWISPHLPS
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
					public LGQWISPHLPS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<MMHQXLWOJFR>, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x42005B0", Offset = "0x41FEFB0", VA = "0x1842005B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public LGQWISPHLPS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x4200D00", Offset = "0x41FF700", VA = "0x184200D00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public LGQWISPHLPS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<TQQQOXOZIAW>, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x4200EE0", Offset = "0x41FF8E0", VA = "0x184200EE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public GVLKCNAFYYF<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<SLVANOSNYVT> UKXAYYKVKSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public BBYVCMSUUDJ JWJDDGYRILI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public IODGEOJDMSL ZBAYZDUPYSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int OICCVRKHWBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int FJMCBUGESCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public EECTNTBWABE ZUCBLDFNETH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string GHLSODGTUSS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<GSOEDYAARUW> DWYVKJIIUOX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public EECTNTBWABE QHMEWKIIHMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string XLDNQNVIZVZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<GSOEDYAARUW> XBSYEDLWPIQ;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public LGQWISPHLPS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x68C03C0", Offset = "0x68BEDC0", VA = "0x1868C03C0")]
				internal bool GQTCKVGHYQD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x68C0350", Offset = "0x68BED50", VA = "0x1868C0350")]
				internal void GQNVNOMKPEU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x68C0A40", Offset = "0x68BF440", VA = "0x1868C0A40")]
				internal bool TIUKWUIRPSJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x68C0470", Offset = "0x68BEE70", VA = "0x1868C0470")]
				[AsyncStateMachine(typeof(GVLKCNAFYYF<>.LGQWISPHLPS.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void GRDQFIUCRMV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x68C0430", Offset = "0x68BEE30", VA = "0x1868C0430")]
				internal bool GQYJICAFIBM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x68C0A80", Offset = "0x68BF480", VA = "0x1868C0A80")]
				internal void TJPMLVKHBLT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x68C07A0", Offset = "0x68BF1A0", VA = "0x1868C07A0")]
				internal bool TGONAXXUPXO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x68C0850", Offset = "0x68BF250", VA = "0x1868C0850")]
				internal void TGTTYERRZIX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x68C06F0", Offset = "0x68BF0F0", VA = "0x1868C06F0")]
				internal bool ODRSKUMNSOH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x68C0580", Offset = "0x68BEF80", VA = "0x1868C0580")]
				internal bool GRODZWHXKJN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x68C0510", Offset = "0x68BEF10", VA = "0x1868C0510")]
				internal void GRIXCPOAAYE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x68C0650", Offset = "0x68BF050", VA = "0x1868C0650")]
				[AsyncStateMachine(typeof(GVLKCNAFYYF<>.LGQWISPHLPS.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void GRYRUJVSDGF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x68C05F0", Offset = "0x68BEFF0", VA = "0x1868C05F0")]
				internal bool GRTKXDBUTUW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x68C02E0", Offset = "0x68BECE0", VA = "0x1868C02E0")]
				internal bool GPCZGTDDBDJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x68C0270", Offset = "0x68BEC70", VA = "0x1868C0270")]
				internal void GOXSJMJFRSA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x68C0930", Offset = "0x68BF330", VA = "0x1868C0930")]
				[AsyncStateMachine(typeof(GVLKCNAFYYF<>.LGQWISPHLPS.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void TIEQFAAZNKI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x68C09E0", Offset = "0x68BF3E0", VA = "0x1868C09E0")]
				internal bool TIJXCGUWWVR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class LGWDFZJEVBB
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
					public LGWDFZJEVBB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x42008A0", Offset = "0x41FF2A0", VA = "0x1842008A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string KRWACQCEQVZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public LGQWISPHLPS UZNLTVLUBPB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> BWDMQDOEASY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> BWITNKIBKEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action BWOAKRBYTPQ;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public LGWDFZJEVBB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x68C0B60", Offset = "0x68BF560", VA = "0x1868C0B60")]
				internal void TIPDZNOUGHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				internal string TIZRUBCOZDS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				internal void TJEYRHWMIPB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x68C0ED0", Offset = "0x68BF8D0", VA = "0x1868C0ED0")]
				[AsyncStateMachine(typeof(GVLKCNAFYYF<>.LGWDFZJEVBB.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void TJKFOOQJSAK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class FTTOFOLMJTV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool DWYVKJIIUOX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public IODGEOJDMSL ZBAYZDUPYSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<GSOEDYAARUW> IELNCXLXUBM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public GVLKCNAFYYF<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<SLVANOSNYVT> UKXAYYKVKSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int RONYRJOKPBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> XYXNEHMLNOY;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public FTTOFOLMJTV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x6348FC0", Offset = "0x63479C0", VA = "0x186348FC0")]
				internal bool UNXHSLRQAJP()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class FTOHIHRPAIM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public OYFUCBVVEZS WIAVCETPBRD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public FTTOFOLMJTV UZNLTVLUBPB;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public FTOHIHRPAIM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x6348910", Offset = "0x6347310", VA = "0x186348910")]
				internal void UNHNARJXYBO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x6348A80", Offset = "0x6347480", VA = "0x186348A80")]
				internal bool UNMTXYDVHMX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x6348AD0", Offset = "0x63474D0", VA = "0x186348AD0")]
				internal void UONCKFZICRQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x6348C60", Offset = "0x6347660", VA = "0x186348C60")]
				internal bool UOSJHMTFMCZ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class FUECABZHCQN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public GSOEDYAARUW YWRESMZMQUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public FTOHIHRPAIM UZSSRCFRLAK;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public FUECABZHCQN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x634D6C0", Offset = "0x634C0C0", VA = "0x18634D6C0")]
				internal void UNSAVEXSQYG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class QWWABNIWEVQ
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
					public QWWABNIWEVQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x42041F0", Offset = "0x4202BF0", VA = "0x1842041F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> ODRZMRACBAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public EECTNTBWABE CWZMHGXVJZJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool DWYVKJIIUOX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public IODGEOJDMSL ZBAYZDUPYSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public OYFUCBVVEZS WIAVCETPBRD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string KRWACQCEQVZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public QWWABNIWEVQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x760FC60", Offset = "0x760E660", VA = "0x18760FC60")]
				internal int CFXIXQOFZNW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x760FCA0", Offset = "0x760E6A0", VA = "0x18760FCA0")]
				internal void CGCPUXIDIZF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
				internal string CGHWSECASKO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x760FF10", Offset = "0x760E910", VA = "0x18760FF10")]
				[AsyncStateMachine(typeof(GVLKCNAFYYF<>.QWWABNIWEVQ.<<CreatePortItemV2>b__3>d))]
				internal void CGNDPKVYBVX(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public GVLKCNAFYYF<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x6560080", Offset = "0x655EA80", VA = "0x186560080", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x6560430", Offset = "0x655EE30", VA = "0x186560430", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public GVLKCNAFYYF<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<SLVANOSNYVT> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x6B3F810", Offset = "0x6B3E210", VA = "0x186B3F810", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x6B3FBC0", Offset = "0x6B3E5C0", VA = "0x186B3FBC0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public GVLKCNAFYYF<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x6BC9BF0", Offset = "0x6BC85F0", VA = "0x186BC9BF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x6BCA1A0", Offset = "0x6BC8BA0", VA = "0x186BCA1A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<SLVANOSNYVT>, bool> KNCHNLQMIMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<SLVANOSNYVT>, bool> LWPOUYXOHJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<SLVANOSNYVT>, bool> XNJVHCDUHPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<SLVANOSNYVT>, bool> ZDJLFXMUIHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<SLVANOSNYVT>, bool> GFZDMXBIKMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<SLVANOSNYVT>, bool> DOJSKLXIRTA;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool KKZRPNMSPYF
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool FLQXZCNJUJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool OOIJTLLZSDP
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<JNHEPOTZQDV>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x64758F0", Offset = "0x64742F0", VA = "0x1864758F0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<SLVANOSNYVT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x6475B70", Offset = "0x6474570", VA = "0x186475B70", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<CEDSPQRYDBL>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x6475970", Offset = "0x6474370", VA = "0x186475970", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x6475720", Offset = "0x6474120", VA = "0x186475720")]
			public GVLKCNAFYYF(WVKEVWTACCJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "154")]
			protected virtual bool RHQRZULXQAQ(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "155")]
			protected virtual bool RNNMEXRVFTV(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "156")]
			protected virtual bool TBGSWFUEBQG(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "157")]
			protected virtual void SSUSVIOCCCY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x6472680", Offset = "0x6471080", VA = "0x186472680", Slot = "149")]
			public override bool IJOBGNQMGKI(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x64754A0", Offset = "0x6473EA0", VA = "0x1864754A0", Slot = "122")]
			[AsyncStateMachine(typeof(GVLKCNAFYYF<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> UUMJVVRWSQJ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x6474780", Offset = "0x6473180", VA = "0x186474780", Slot = "123")]
			[AsyncStateMachine(typeof(GVLKCNAFYYF<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, LSNRXVKTUTI>> SRTSVRNFSGQ(Id32<SLVANOSNYVT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x64737C0", Offset = "0x64721C0", VA = "0x1864737C0", Slot = "124")]
			public override void JRNOYSVCAOI(Id32<SLVANOSNYVT> index, Id32<SLVANOSNYVT> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6474890", Offset = "0x6473290", VA = "0x186474890", Slot = "125")]
			public override IEnumerable<PZJVNVFLVDC> UKLXJOFGGFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x64755C0", Offset = "0x6473FC0", VA = "0x1864755C0")]
			[AsyncStateMachine(typeof(GVLKCNAFYYF<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, LSNRXVKTUTI>> VOLNXAVSHZI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "158")]
			protected virtual bool MXCLGORWXDR(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "159")]
			protected virtual bool OOTXIBFENPF(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "160")]
			protected virtual bool TAJOBMZDBFY(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "161")]
			protected virtual bool QWOIGXSDDVC(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "162")]
			protected virtual bool UHJEPYTPXMC(Id32<SLVANOSNYVT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "163")]
			protected virtual bool BKYQTWHCKTN(Id32<SLVANOSNYVT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "164")]
			protected virtual bool TOJPIVTNALH(Id32<SLVANOSNYVT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "165")]
			protected virtual bool SJGVTQGXGNI(Id32<SLVANOSNYVT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "166")]
			protected virtual bool MPRXZPYEQJM(Id32<SLVANOSNYVT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "167")]
			protected virtual bool QXMUYSQZXEJ(Id32<SLVANOSNYVT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6473960", Offset = "0x6472360", VA = "0x186473960", Slot = "168")]
			protected virtual List<EECTNTBWABE> JVFNUKPKHQV(Id32<SLVANOSNYVT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "169")]
			protected virtual void AJRSFRPHGCG(BBYVCMSUUDJ a, NOEMDSCOVZL b, IODGEOJDMSL c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6474AF0", Offset = "0x64734F0", VA = "0x186474AF0", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6470ED0", Offset = "0x646F8D0", VA = "0x186470ED0")]
			private NOEMDSCOVZL FXCYTTBNNOX(BBYVCMSUUDJ a, IODGEOJDMSL b, Id32<SLVANOSNYVT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6472720", Offset = "0x6471120", VA = "0x186472720")]
			private List<GSOEDYAARUW> IXXUXSVLLTC(BBYVCMSUUDJ a, IODGEOJDMSL b, NOEMDSCOVZL c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6473BE0", Offset = "0x64725E0", VA = "0x186473BE0")]
			private List<GSOEDYAARUW> PBOUAYNKDMC(BBYVCMSUUDJ a, IODGEOJDMSL b, OYFUCBVVEZS c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x6474590", Offset = "0x6472F90", VA = "0x186474590")]
			private EECTNTBWABE RCXWAOOOUBK(List<EECTNTBWABE> a, OYFUCBVVEZS b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x64756C0", Offset = "0x64740C0", VA = "0x1864756C0")]
			[CompilerGenerated]
			private PZJVNVFLVDC VSAZCTAMKKO(QQDUHQODGUC a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class OVINGKWPAZO : DJHXDSZWRBQ<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public OVINGKWPAZO TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B4FC20", Offset = "0x2B4E620", VA = "0x182B4FC20")]
				internal int DARWPQEJXSU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B4FC70", Offset = "0x2B4E670", VA = "0x182B4FC70")]
				internal Task<bool> DAXDMWYHHED(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2B50DC0", Offset = "0x2B4F7C0", VA = "0x182B50DC0")]
			public OVINGKWPAZO(WVKEVWTACCJ a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2B50C10", Offset = "0x2B4F610", VA = "0x182B50C10", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class YLZCGNSFRWA : XEUMHMCOXDA<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public YLZCGNSFRWA TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B400", Offset = "0x2B49E00", VA = "0x182B4B400")]
				internal int RQHRHALQWTP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B360", Offset = "0x2B49D60", VA = "0x182B4B360")]
				internal Task<bool> RQCKJTRTNIG(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2B685C0", Offset = "0x2B66FC0", VA = "0x182B685C0")]
			public YLZCGNSFRWA(WVKEVWTACCJ a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B683A0", Offset = "0x2B66DA0", VA = "0x182B683A0", Slot = "151")]
			protected override void POIMKMHGSIV(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class WJHDXEVZCMS : DJHXDSZWRBQ<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xF3C9D0", Offset = "0xF3B3D0", VA = "0x180F3C9D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B9A0", Offset = "0x2B5A3A0", VA = "0x182B5B9A0")]
			public WJHDXEVZCMS(WVKEVWTACCJ a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class EKNNNSNNOYC : DJHXDSZWRBQ<HOEJSIAIMRR>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class WNSCYXRXLPE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public EKNNNSNNOYC TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public BBYVCMSUUDJ JWJDDGYRILI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> JISXYYWRZTW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> JJISQTEKCBX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> JJNZNZYHLNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> JKDUFUFZNVH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> JJYNINMCEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> JKOIAHTUGRZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> JKJBDAZWXGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> COTMNVVGJLY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> COYTLCPDSXH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> COIYTIHLQPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> COOFQPBJAAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> CNYKYUTQXSO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> CODRWBNOHDX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> CNNXEHFWEVW;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WNSCYXRXLPE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C0B0", Offset = "0x2B5AAB0", VA = "0x182B5C0B0")]
				internal bool DARWPQEJXSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C100", Offset = "0x2B5AB00", VA = "0x182B5C100")]
				internal void DAXDMWYHHED(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BFB0", Offset = "0x2B5A9B0", VA = "0x182B5BFB0")]
				internal bool CZWVAPCULZK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C000", Offset = "0x2B5AA00", VA = "0x182B5C000")]
				internal bool DACBXVWRVKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C050", Offset = "0x2B5AA50", VA = "0x182B5C050")]
				internal void DAHIVCQPEWC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C160", Offset = "0x2B5AB60", VA = "0x182B5C160")]
				internal bool DCNGQZBMEQX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BC00", Offset = "0x2B5A600", VA = "0x182B5BC00")]
				internal bool ATLRZAXGNKF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BBA0", Offset = "0x2B5A5A0", VA = "0x182B5BBA0")]
				internal void ATGLBUDJDYW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BB50", Offset = "0x2B5A550", VA = "0x182B5BB50")]
				internal bool ASQQJZVRBQV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BB00", Offset = "0x2B5A500", VA = "0x182B5BB00")]
				internal bool ASLJMTBTSFM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BAA0", Offset = "0x2B5A4A0", VA = "0x182B5BAA0")]
				internal void ASGCPMHWIUD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BA50", Offset = "0x2B5A450", VA = "0x182B5BA50")]
				internal bool ARQHXSAEGMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2B646C0", Offset = "0x2B630C0", VA = "0x182B646C0")]
				internal bool ONMNRBZCRCL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2B64670", Offset = "0x2B63070", VA = "0x182B64670")]
				internal bool ONHGTVFFHRC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2B64710", Offset = "0x2B63110", VA = "0x182B64710")]
				internal bool ONXBLPMXJZD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2B64860", Offset = "0x2B63260", VA = "0x182B64860")]
				internal bool OPXSKFDXAIP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2B64810", Offset = "0x2B63210", VA = "0x182B64810")]
				internal bool OPSLMYJZQXG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D7F0", Offset = "0x2B5C1F0", VA = "0x182B5D7F0")]
				internal bool HNQKHKSPNDM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D840", Offset = "0x2B5C240", VA = "0x182B5D840")]
				internal bool HNVRERMMWOV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D740", Offset = "0x2B5C140", VA = "0x182B5D740")]
				internal void HNFWMXEUUGU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2B65190", Offset = "0x2B63B90", VA = "0x182B65190")]
				internal bool TQEXDKARUAL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2B651E0", Offset = "0x2B63BE0", VA = "0x182B651E0")]
				internal bool TQKEAQUPDLU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2B65230", Offset = "0x2B63C30", VA = "0x182B65230")]
				internal bool TQPKXXOMMXD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2B65280", Offset = "0x2B63C80", VA = "0x182B65280")]
				internal bool TQZYSLCHFTV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2B652D0", Offset = "0x2B63CD0", VA = "0x182B652D0")]
				internal bool TRFFPRWEPFE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D7A0", Offset = "0x2B5C1A0", VA = "0x182B5D7A0")]
				internal bool HNLDKDYSDSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D930", Offset = "0x2B5C330", VA = "0x182B5D930")]
				internal bool HOLLWLUEYWW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D980", Offset = "0x2B5C380", VA = "0x182B5D980")]
				internal void HOQSTSOCIIF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D890", Offset = "0x2B5C290", VA = "0x182B5D890")]
				internal bool HOAYBYGKGAE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D8E0", Offset = "0x2B5C2E0", VA = "0x182B5D8E0")]
				internal bool HOGEZFAHPLN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D9E0", Offset = "0x2B5C3E0", VA = "0x182B5D9E0")]
				internal void HPGNLMVUKQG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DA40", Offset = "0x2B5C440", VA = "0x182B5DA40")]
				internal bool HPLUITPRUBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2B647C0", Offset = "0x2B631C0", VA = "0x182B647C0")]
				internal bool OOHPGDASCVV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2B64760", Offset = "0x2B63160", VA = "0x182B64760")]
				internal void OOCIIWGUTKM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E440", Offset = "0x2B5CE40", VA = "0x182B5E440")]
				internal List<GSOEDYAARUW> NNUSETOOWYV(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2B65320", Offset = "0x2B63D20", VA = "0x182B65320")]
				internal bool TRKMMYQBYQN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2B65370", Offset = "0x2B63D70", VA = "0x182B65370")]
				internal int TRPTKFJZIBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2B653C0", Offset = "0x2B63DC0", VA = "0x182B653C0")]
				internal Task<bool> TRVAHMDWRNF(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2B66310", Offset = "0x2B64D10", VA = "0x182B66310")]
				internal bool ZQSWRNPWOLD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2B662C0", Offset = "0x2B64CC0", VA = "0x182B662C0")]
				internal bool ZQNPUGVZEZU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2B66270", Offset = "0x2B64C70", VA = "0x182B66270")]
				internal bool ZQIIXACBVOL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2B66220", Offset = "0x2B64C20", VA = "0x182B66220")]
				internal int ZQDBZTIEMDC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2B66450", Offset = "0x2B64E50", VA = "0x182B66450")]
				internal Task<bool> ZRNYGORMAEN(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2B66400", Offset = "0x2B64E00", VA = "0x182B66400")]
				internal bool ZRIRJHXOQTE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2B663B0", Offset = "0x2B64DB0", VA = "0x182B663B0")]
				internal bool ZRDKMBDRHHV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2B66360", Offset = "0x2B64D60", VA = "0x182B66360")]
				internal bool ZQYDOUJTXWM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2B664E0", Offset = "0x2B64EE0", VA = "0x182B664E0")]
				internal bool ZSDSYIZECMO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D140", Offset = "0x2B5BB40", VA = "0x182B5D140")]
				internal bool GRKBQFXZEDM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2B64F30", Offset = "0x2B63930", VA = "0x182B64F30")]
				internal string THPGPIEUPMP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2B64F80", Offset = "0x2B63980", VA = "0x182B64F80")]
				internal void THUNMOYRYXY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2B64FF0", Offset = "0x2B639F0", VA = "0x182B64FF0")]
				internal int TIKIEJGKBFZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2B65040", Offset = "0x2B63A40", VA = "0x182B65040")]
				internal void TIPPBQAHKRI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2B650A0", Offset = "0x2B63AA0", VA = "0x182B650A0")]
				internal bool TIUVYWUEUCR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2B650F0", Offset = "0x2B63AF0", VA = "0x182B650F0")]
				internal bool TJACWDOCDOA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2B65140", Offset = "0x2B63B40", VA = "0x182B65140")]
				internal bool TJFJTKHZMZJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2B660C0", Offset = "0x2B64AC0", VA = "0x182B660C0")]
				internal float ZIDGDLTZJXH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2B66060", Offset = "0x2B64A60", VA = "0x182B66060")]
				internal void ZHXZGFACALY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2B66010", Offset = "0x2B64A10", VA = "0x182B66010")]
				internal bool ZHSSIYGERAP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2B65FC0", Offset = "0x2B649C0", VA = "0x182B65FC0")]
				internal bool ZHNLLRMHHPG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2B661D0", Offset = "0x2B64BD0", VA = "0x182B661D0")]
				internal bool ZIYHSMVOVQR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D0A0", Offset = "0x2B5BAA0", VA = "0x182B5D0A0")]
				internal bool GQZNVSKELGU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D0F0", Offset = "0x2B5BAF0", VA = "0x182B5D0F0")]
				internal bool GREUSZEBUSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CC50", Offset = "0x2B5B650", VA = "0x182B5CC50")]
				internal bool GQPABEWJSKC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CCA0", Offset = "0x2B5B6A0", VA = "0x182B5CCA0")]
				internal void GQUGYLQHBVL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2B66180", Offset = "0x2B64B80", VA = "0x182B66180")]
				internal string ZITAVGBRMFI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2B66110", Offset = "0x2B64B10", VA = "0x182B66110")]
				internal void ZINTXZHUCTZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CBB0", Offset = "0x2B5B5B0", VA = "0x182B5CBB0")]
				internal bool GQEMGRIOZNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CC00", Offset = "0x2B5B600", VA = "0x182B5CC00")]
				internal bool GQJTDYCMIYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D190", Offset = "0x2B5BB90", VA = "0x182B5D190")]
				internal bool GTAEUIBEBQG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D1E0", Offset = "0x2B5BBE0", VA = "0x182B5D1E0")]
				internal void GTFLROVBLBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2B64390", Offset = "0x2B62D90", VA = "0x182B64390")]
				internal bool NSBGOYGBTVV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2B64340", Offset = "0x2B62D40", VA = "0x182B64340")]
				internal bool NRVZRRMEKKM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2B64430", Offset = "0x2B62E30", VA = "0x182B64430")]
				internal bool NSLUJLTWMSN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2B643E0", Offset = "0x2B62DE0", VA = "0x182B643E0")]
				internal bool NSGNMEZZDHE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2B644D0", Offset = "0x2B62ED0", VA = "0x182B644D0")]
				internal void NSWIDZHRFPF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2B64480", Offset = "0x2B62E80", VA = "0x182B64480")]
				internal bool NSRBGSNTWDW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2B64580", Offset = "0x2B62F80", VA = "0x182B64580")]
				internal bool NTGVYMVLYLX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2B64530", Offset = "0x2B62F30", VA = "0x182B64530")]
				internal bool NTBPBGBOPAO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2B642F0", Offset = "0x2B62CF0", VA = "0x182B642F0")]
				internal bool NQLDKWCWWJB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2B64290", Offset = "0x2B62C90", VA = "0x182B64290")]
				internal void NQFWNPIZMXS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2B65890", Offset = "0x2B64290", VA = "0x182B65890")]
				internal bool WLFCWADLBOE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2B658E0", Offset = "0x2B642E0", VA = "0x182B658E0")]
				internal bool WLKJTGXIKZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2B65930", Offset = "0x2B64330", VA = "0x182B65930")]
				internal bool WLPQQNRFUKW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2B65980", Offset = "0x2B64380", VA = "0x182B65980")]
				internal bool WLUXNULDDWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2B65790", Offset = "0x2B64190", VA = "0x182B65790")]
				internal object WKUPBMPQIRM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2B65800", Offset = "0x2B64200", VA = "0x182B65800")]
				internal void WKZVYTJNSCV(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2B659D0", Offset = "0x2B643D0", VA = "0x182B659D0")]
				internal bool WMVGACGPZAY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2B65A20", Offset = "0x2B64420", VA = "0x182B65A20")]
				internal bool WNAMXJANIMH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C2B0", Offset = "0x2B5ACB0", VA = "0x182B5C2B0")]
				internal int DLRAXLRQHVE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C250", Offset = "0x2B5AC50", VA = "0x182B5C250")]
				internal void DLLUAEXSYJV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C200", Offset = "0x2B5AC00", VA = "0x182B5C200")]
				internal bool DKVZIKQAWBU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C1B0", Offset = "0x2B5ABB0", VA = "0x182B5C1B0")]
				internal bool DKQSLDWDMQL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C300", Offset = "0x2B5AD00", VA = "0x182B5C300")]
				internal int DNHEBNUVFHY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C7A0", Offset = "0x2B5B1A0", VA = "0x182B5C7A0")]
				internal void EQGDFMWGZWH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C750", Offset = "0x2B5B150", VA = "0x182B5C750")]
				internal bool EQAWIGCJQKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C850", Offset = "0x2B5B250", VA = "0x182B5C850")]
				internal bool EQQRAAKBSSZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C800", Offset = "0x2B5B200", VA = "0x182B5C800")]
				internal bool EQLKCTQEJHQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C700", Offset = "0x2B5B100", VA = "0x182B5C700")]
				internal int EPVPKZIMGZP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C6A0", Offset = "0x2B5B0A0", VA = "0x182B5C6A0")]
				internal void EPQINSOOXOG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C650", Offset = "0x2B5B050", VA = "0x182B5C650")]
				internal bool EOQABKTCCJN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C600", Offset = "0x2B5B000", VA = "0x182B5C600")]
				internal bool EOKTEDZESYE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2B65E70", Offset = "0x2B64870", VA = "0x182B65E70")]
				internal bool YPMWUCNEWAG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2B65F50", Offset = "0x2B64950", VA = "0x182B65F50")]
				internal object YQNFGKIRREZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2B65EC0", Offset = "0x2B648C0", VA = "0x182B65EC0")]
				internal void YPXKOQAZOWY(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2B65DD0", Offset = "0x2B647D0", VA = "0x182B65DD0")]
				internal bool YNWTQAJZYNM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2B65E20", Offset = "0x2B64820", VA = "0x182B65E20")]
				internal bool YOCANHDXHYV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2B64DD0", Offset = "0x2B637D0", VA = "0x182B64DD0")]
				internal object? ROVRVKFCGHX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2B64D40", Offset = "0x2B63740", VA = "0x182B64D40")]
				internal void ROQKYDLEWWO(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2B64CF0", Offset = "0x2B636F0", VA = "0x182B64CF0")]
				internal bool ROAQGJDMUON()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2B64CA0", Offset = "0x2B636A0", VA = "0x182B64CA0")]
				internal int RNVJJCJPLDE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2B64C40", Offset = "0x2B63640", VA = "0x182B64C40")]
				internal void RNQCLVPSBRV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2B64BF0", Offset = "0x2B635F0", VA = "0x182B64BF0")]
				internal bool RNKVOOVUSGM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2B64E90", Offset = "0x2B63890", VA = "0x182B64E90")]
				internal bool RQLUZMIHDUR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2B64E40", Offset = "0x2B63840", VA = "0x182B64E40")]
				internal bool RQGOCFOJUJI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DF40", Offset = "0x2B5C940", VA = "0x182B5DF40")]
				internal int KOEMWRWZQPO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DF90", Offset = "0x2B5C990", VA = "0x182B5DF90")]
				internal void KOJTTYQXAAX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DFF0", Offset = "0x2B5C9F0", VA = "0x182B5DFF0")]
				internal bool KOPARFKUJMG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E040", Offset = "0x2B5CA40", VA = "0x182B5E040")]
				internal bool KOUHOMERSXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DDF0", Offset = "0x2B5C7F0", VA = "0x182B5DDF0")]
				internal bool KNJLHQVKEWE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DE40", Offset = "0x2B5C840", VA = "0x182B5DE40")]
				internal float KNOSEXPHOHN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DE90", Offset = "0x2B5C890", VA = "0x182B5DE90")]
				internal void KNTZCEJEXSW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DEF0", Offset = "0x2B5C8F0", VA = "0x182B5DEF0")]
				internal bool KNZFZLDCHEF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E090", Offset = "0x2B5CA90", VA = "0x182B5E090")]
				internal bool KPUQAUAEOCI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E0E0", Offset = "0x2B5CAE0", VA = "0x182B5E0E0")]
				internal bool KPZWYAUBXNR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C3B0", Offset = "0x2B5ADB0", VA = "0x182B5C3B0")]
				internal float DNNHXZOXAXF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C350", Offset = "0x2B5AD50", VA = "0x182B5C350")]
				internal void DNIBASUZRLW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C400", Offset = "0x2B5AE00", VA = "0x182B5C400")]
				internal bool DNXVSNCRTTX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C450", Offset = "0x2B5AE50", VA = "0x182B5C450")]
				internal bool DODCPTWPDFG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C510", Offset = "0x2B5AF10", VA = "0x182B5C510")]
				internal string DOSXHOEHFNH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C4A0", Offset = "0x2B5AEA0", VA = "0x182B5C4A0")]
				internal void DONQKHKJWBY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C5B0", Offset = "0x2B5AFB0", VA = "0x182B5C5B0")]
				internal bool DPDLCBSBYJZ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C560", Offset = "0x2B5AF60", VA = "0x182B5C560")]
				internal bool DOYEEUYEOYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2B65D30", Offset = "0x2B64730", VA = "0x182B65D30")]
				internal bool WTIPPPTOBDY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2B65D80", Offset = "0x2B64780", VA = "0x182B65D80")]
				internal bool WTNWMWNLKPH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2B65C70", Offset = "0x2B64670", VA = "0x182B65C70")]
				internal string WSYBVCFTIHG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2B65CC0", Offset = "0x2B646C0", VA = "0x182B65CC0")]
				internal void WTDISIZQRSP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2B65BD0", Offset = "0x2B645D0", VA = "0x182B65BD0")]
				internal bool WSNOAORYPKO(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2B65C20", Offset = "0x2B64620", VA = "0x182B65C20")]
				internal bool WSSUXVLVYVX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2B65B30", Offset = "0x2B64530", VA = "0x182B65B30")]
				internal bool WSDAGBEDWNW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2B65B80", Offset = "0x2B64580", VA = "0x182B65B80")]
				internal bool WSIHDHYBFZF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B65A70", Offset = "0x2B64470", VA = "0x182B65A70")]
				internal string WRSMLNQJDRE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B65AC0", Offset = "0x2B644C0", VA = "0x182B65AC0")]
				internal void WRXTIUKGNCN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B64A40", Offset = "0x2B63440", VA = "0x182B64A40")]
				internal bool QSPJEFKLXHX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B649F0", Offset = "0x2B633F0", VA = "0x182B649F0")]
				internal bool QSKCGYQONWO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2B649A0", Offset = "0x2B633A0", VA = "0x182B649A0")]
				internal bool QSEVJRWRELF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2B64950", Offset = "0x2B63350", VA = "0x182B64950")]
				internal bool QRZOMLCTUZW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2B64BA0", Offset = "0x2B635A0", VA = "0x182B64BA0")]
				internal string QTKKTGMBJBH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2B64B30", Offset = "0x2B63530", VA = "0x182B64B30")]
				internal void QTFDVZSDZPY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B64AE0", Offset = "0x2B634E0", VA = "0x182B64AE0")]
				internal bool QSZWYSYGQEP(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B64A90", Offset = "0x2B63490", VA = "0x182B64A90")]
				internal bool QSUQBMEJGTG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2B64900", Offset = "0x2B63300", VA = "0x182B64900")]
				internal bool QQZGADHGZVD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2B648B0", Offset = "0x2B632B0", VA = "0x182B648B0")]
				internal bool QQTZCWNJQJU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DB30", Offset = "0x2B5C530", VA = "0x182B5DB30")]
				internal string JRYEFNCJHPO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DB80", Offset = "0x2B5C580", VA = "0x182B5DB80")]
				internal void JSDLCTWGRAX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DBF0", Offset = "0x2B5C5F0", VA = "0x182B5DBF0")]
				internal bool JSISAAQEAMG(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DC40", Offset = "0x2B5C640", VA = "0x182B5DC40")]
				internal bool JSNYXHKBJXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DC90", Offset = "0x2B5C690", VA = "0x182B5DC90")]
				internal bool JSTFUODYTIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DCE0", Offset = "0x2B5C6E0", VA = "0x182B5DCE0")]
				internal bool JSYMRUXWCUH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DD30", Offset = "0x2B5C730", VA = "0x182B5DD30")]
				internal string JTDTPBRTMFQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DD80", Offset = "0x2B5C780", VA = "0x182B5DD80")]
				internal void JTJAMILQVQZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DA90", Offset = "0x2B5C490", VA = "0x182B5DA90")]
				internal bool JQIBBKZEKCU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2B5DAE0", Offset = "0x2B5C4E0", VA = "0x182B5DAE0")]
				internal bool JQNHYRTBTOD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BDE0", Offset = "0x2B5A7E0", VA = "0x182B5BDE0")]
				internal bool CRGZGUUGRXF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BD90", Offset = "0x2B5A790", VA = "0x182B5BD90")]
				internal bool CRBSJOAJILW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BEA0", Offset = "0x2B5A8A0", VA = "0x182B5BEA0")]
				internal string CRRNBIIBKTX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BE30", Offset = "0x2B5A830", VA = "0x182B5BE30")]
				internal void CRMGEBOEBIO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BCA0", Offset = "0x2B5A6A0", VA = "0x182B5BCA0")]
				internal bool CQLXRTSRGDV(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BC50", Offset = "0x2B5A650", VA = "0x182B5BC50")]
				internal bool CQGQUMYTWSM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BD40", Offset = "0x2B5A740", VA = "0x182B5BD40")]
				internal bool CQWLMHGLZAN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BCF0", Offset = "0x2B5A6F0", VA = "0x182B5BCF0")]
				internal bool CQREPAMOPPE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BF60", Offset = "0x2B5A960", VA = "0x182B5BF60")]
				internal string CSXCKWXLPJZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BEF0", Offset = "0x2B5A8F0", VA = "0x182B5BEF0")]
				internal void CSRVNQDOFYQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B654F0", Offset = "0x2B63EF0", VA = "0x182B654F0")]
				internal bool VQPUICMECEW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2B65540", Offset = "0x2B63F40", VA = "0x182B65540")]
				internal bool VQVBFJGBLQF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B65450", Offset = "0x2B63E50", VA = "0x182B65450")]
				internal bool VQFGNOYJJIE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2B654A0", Offset = "0x2B63EA0", VA = "0x182B654A0")]
				internal bool VQKNKVSGSTN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B65630", Offset = "0x2B64030", VA = "0x182B65630")]
				internal string VRKVXDNTNYG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B65680", Offset = "0x2B64080", VA = "0x182B65680")]
				internal void VRQCUKHQXJP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2B65590", Offset = "0x2B63F90", VA = "0x182B65590")]
				internal bool VRAICPZYVBO(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B655E0", Offset = "0x2B63FE0", VA = "0x182B655E0")]
				internal bool VRFOZWTWEMX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B656F0", Offset = "0x2B640F0", VA = "0x182B656F0")]
				internal bool VSFXMEPIZRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B65740", Offset = "0x2B64140", VA = "0x182B65740")]
				internal bool VSLEJLJGJCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CA50", Offset = "0x2B5B450", VA = "0x182B5CA50")]
				internal string GIULCECBZPQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CAA0", Offset = "0x2B5B4A0", VA = "0x182B5CAA0")]
				internal void GIZRZKVZJAZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CA00", Offset = "0x2B5B400", VA = "0x182B5CA00")]
				internal bool GIPEEXIEQEH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C960", Offset = "0x2B5B360", VA = "0x182B5C960")]
				internal bool GHZJNDAMNWG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C9B0", Offset = "0x2B5B3B0", VA = "0x182B5C9B0")]
				internal bool GIEQKJUJXHP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C8A0", Offset = "0x2B5B2A0", VA = "0x182B5C8A0")]
				internal string GHOVSPMRUZO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C8F0", Offset = "0x2B5B2F0", VA = "0x182B5C8F0")]
				internal void GHUCPWGPEKX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CB10", Offset = "0x2B5B510", VA = "0x182B5CB10")]
				internal bool GKKOGGFGXCK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B5CB60", Offset = "0x2B5B560", VA = "0x182B5CB60")]
				internal bool GKPVDMZEGNT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E1D0", Offset = "0x2B5CBD0", VA = "0x182B5E1D0")]
				internal bool NJLQAWKEPHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E180", Offset = "0x2B5CB80", VA = "0x182B5E180")]
				internal string NJGJDPQHFWQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E270", Offset = "0x2B5CC70", VA = "0x182B5E270")]
				internal void NJWDVJXZIER(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E220", Offset = "0x2B5CC20", VA = "0x182B5E220")]
				internal bool NJQWYDEBYTI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E330", Offset = "0x2B5CD30", VA = "0x182B5E330")]
				internal bool NKGRPXLUBBJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E2E0", Offset = "0x2B5CCE0", VA = "0x182B5E2E0")]
				internal bool NKBKSQRWRQA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E3F0", Offset = "0x2B5CDF0", VA = "0x182B5E3F0")]
				internal string NKRFKKZOTYB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E380", Offset = "0x2B5CD80", VA = "0x182B5E380")]
				internal void NKLYNEFRKMS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B5E130", Offset = "0x2B5CB30", VA = "0x182B5E130")]
				internal bool NHQFZNNCIJW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B64EE0", Offset = "0x2B638E0", VA = "0x182B64EE0")]
				internal bool THJZSBKXGBG(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D4A0", Offset = "0x2B5BEA0", VA = "0x182B5D4A0")]
				internal float HEQFYVIXPSY()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D4F0", Offset = "0x2B5BEF0", VA = "0x182B5D4F0")]
				internal void HEVMWCCUZEH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D5F0", Offset = "0x2B5BFF0", VA = "0x182B5D5F0")]
				internal bool HFVVIJYHUJA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D640", Offset = "0x2B5C040", VA = "0x182B5D640")]
				internal bool HGBCFQSFDUJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D550", Offset = "0x2B5BF50", VA = "0x182B5D550")]
				internal bool HFLHNWKNBMI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D5A0", Offset = "0x2B5BFA0", VA = "0x182B5D5A0")]
				internal int HFQOLDEKKXR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D690", Offset = "0x2B5C090", VA = "0x182B5D690")]
				internal void HGQWXKZXGCK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B5D6F0", Offset = "0x2B5C0F0", VA = "0x182B5D6F0")]
				internal bool HGWDURTUPNT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B64620", Offset = "0x2B63020", VA = "0x182B64620")]
				internal bool OFRYSBEUYHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B645D0", Offset = "0x2B62FD0", VA = "0x182B645D0")]
				internal bool OFMRUUKXOWQ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class WNXJWELUVAN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string ISOQROFVSWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public WNSCYXRXLPE UZNLTVLUBPB;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WNXJWELUVAN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B85390", Offset = "0x2B83D90", VA = "0x182B85390")]
				internal void GRPINMRWNOV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class WNHPEKECSSM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] JBNEMOMALAR;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WNHPEKECSSM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B85020", Offset = "0x2B83A20", VA = "0x182B85020")]
				internal bool HFGAQPQPSAZ(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers IKMILFSNKYE;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DB60", Offset = "0x2B4C560", VA = "0x182B4DB60")]
			public EKNNNSNNOYC(WVKEVWTACCJ a, HOEJSIAIMRR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BF50", Offset = "0x2B4A950", VA = "0x182B4BF50", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class XFVESPZBXSH : DJHXDSZWRBQ<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B86DD0", Offset = "0x2B857D0", VA = "0x182B86DD0")]
			public XFVESPZBXSH(WVKEVWTACCJ a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B86620", Offset = "0x2B85020", VA = "0x182B86620", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B86520", Offset = "0x2B84F20", VA = "0x182B86520")]
			private static string UGCJUVXKTQD(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B86970", Offset = "0x2B85370", VA = "0x182B86970")]
			[CompilerGenerated]
			private object? ZRGCSLNJOPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B86A10", Offset = "0x2B85410", VA = "0x182B86A10")]
			[CompilerGenerated]
			private void ZRLJPSHGYAP(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B86B20", Offset = "0x2B85520", VA = "0x182B86B20")]
			[CompilerGenerated]
			private string ZRQQMZBEHLY(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B86D30", Offset = "0x2B85730", VA = "0x182B86D30")]
			[CompilerGenerated]
			private IReadOnlyList<object> ZRVXKFVBQXH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B868D0", Offset = "0x2B852D0", VA = "0x182B868D0")]
			[CompilerGenerated]
			private string? ZQLBDKLUCVW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B86930", Offset = "0x2B85330", VA = "0x182B86930")]
			[CompilerGenerated]
			private bool ZQQIARFRMHF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class SCHRKISEOJH : DJHXDSZWRBQ<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
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
					public KMORFLEWRJL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x2B831D0", Offset = "0x2B81BD0", VA = "0x182B831D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public SCHRKISEOJH TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2B78A50", Offset = "0x2B77450", VA = "0x182B78A50")]
				internal string DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B78E20", Offset = "0x2B77820", VA = "0x182B78E20")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void DAXDMWYHHED(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B791B0", Offset = "0x2B77BB0", VA = "0x182B791B0")]
				internal int DBCKKDSEQPM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B79480", Offset = "0x2B77E80", VA = "0x182B79480")]
				internal void DBHRHKMCAAV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B7CF50", Offset = "0x2B7B950", VA = "0x182B7CF50")]
			public SCHRKISEOJH(WVKEVWTACCJ a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B7CC20", Offset = "0x2B7B620", VA = "0x182B7CC20", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class DNLDAENZBTI : DJHXDSZWRBQ<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class WKDUFJUPYFO
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
					public WKDUFJUPYFO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2B82E90", Offset = "0x2B81890", VA = "0x182B82E90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public WKDUFJUPYFO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x2B83780", Offset = "0x2B82180", VA = "0x182B83780", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public DNLDAENZBTI TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WKDUFJUPYFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2B84D00", Offset = "0x2B83700", VA = "0x182B84D00")]
				internal string DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2B84D50", Offset = "0x2B83750", VA = "0x182B84D50")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void DAXDMWYHHED(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2B84E20", Offset = "0x2B83820", VA = "0x182B84E20")]
				internal int DBCKKDSEQPM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2B84E70", Offset = "0x2B83870", VA = "0x182B84E70")]
				internal Task<bool> DBHRHKMCAAV(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2B84B00", Offset = "0x2B83500", VA = "0x182B84B00")]
				internal string CZWVAPCULZK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2B84B50", Offset = "0x2B83550", VA = "0x182B84B50")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void DACBXVWRVKT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2B84C20", Offset = "0x2B83620", VA = "0x182B84C20")]
				internal bool DAHIVCQPEWC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2B84C70", Offset = "0x2B83670", VA = "0x182B84C70")]
				internal void DAMPSJKMOHL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2B84F00", Offset = "0x2B83900", VA = "0x182B84F00")]
				internal bool DCHZTSHOVFO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2B84F50", Offset = "0x2B83950", VA = "0x182B84F50")]
				internal void DCNGQZBMEQX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2B84AB0", Offset = "0x2B834B0", VA = "0x182B84AB0")]
				internal float ATLRZAXGNKF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2B84A20", Offset = "0x2B83420", VA = "0x182B84A20")]
				internal void ATGLBUDJDYW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2B849C0", Offset = "0x2B833C0", VA = "0x182B849C0")]
				internal int ATBEENJLUNN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x2B84920", Offset = "0x2B83320", VA = "0x182B84920")]
				internal void ASVXHGPOLCE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x2B848B0", Offset = "0x2B832B0", VA = "0x182B848B0")]
				internal bool ASQQJZVRBQV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2B71660", Offset = "0x2B70060", VA = "0x182B71660")]
			public DNLDAENZBTI(WVKEVWTACCJ a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x2B70D00", Offset = "0x2B6F700", VA = "0x182B70D00", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class WZSJTMBMBAN : DJHXDSZWRBQ<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public WZSJTMBMBAN TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2B78AA0", Offset = "0x2B774A0", VA = "0x182B78AA0")]
				internal Dictionary<string, EnumChoiceData> DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2B78EF0", Offset = "0x2B778F0", VA = "0x182B78EF0")]
				internal int DAXDMWYHHED()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x2B78F40", Offset = "0x2B77940", VA = "0x182B78F40")]
				internal void DBCKKDSEQPM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x2B79510", Offset = "0x2B77F10", VA = "0x182B79510")]
				internal bool DBHRHKMCAAV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2B861E0", Offset = "0x2B84BE0", VA = "0x182B861E0")]
			public WZSJTMBMBAN(WVKEVWTACCJ a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2B85F30", Offset = "0x2B84930", VA = "0x182B85F30", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class KCJFZUZZMEQ : DJHXDSZWRBQ<HBCICINHXKZ>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public KCJFZUZZMEQ TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x2B78940", Offset = "0x2B77340", VA = "0x182B78940")]
				internal void DARWPQEJXSU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2B781F0", Offset = "0x2B76BF0", VA = "0x182B781F0")]
			public KCJFZUZZMEQ(WVKEVWTACCJ a, HBCICINHXKZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x2B78070", Offset = "0x2B76A70", VA = "0x182B78070", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class ZTVUFFKPMCK<a> : GVLKCNAFYYF<a> where a : notnull, GGHTVUSHMKK
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override YEDZHZZAPGR? VAAMIKOTQQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x5165790", Offset = "0x5164190", VA = "0x185165790", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x51657F0", Offset = "0x51641F0", VA = "0x1851657F0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xF56DA0", Offset = "0xF557A0", VA = "0x180F56DA0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x51657D0", Offset = "0x51641D0", VA = "0x1851657D0")]
			public ZTVUFFKPMCK(WVKEVWTACCJ a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class REQKHPKWSJA : ZTVUFFKPMCK<SRIHQTGPZUH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class WNSCYXRXLPE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public REQKHPKWSJA TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WNSCYXRXLPE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2B85090", Offset = "0x2B83A90", VA = "0x182B85090")]
				internal object DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x2B850F0", Offset = "0x2B83AF0", VA = "0x182B850F0")]
				internal void DAXDMWYHHED(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x2B852A0", Offset = "0x2B83CA0", VA = "0x182B852A0")]
				internal void DBCKKDSEQPM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? WKSXQUYHQTW;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2B7BB90", Offset = "0x2B7A590", VA = "0x182B7BB90")]
			public REQKHPKWSJA(WVKEVWTACCJ a, SRIHQTGPZUH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2B7B610", Offset = "0x2B7A010", VA = "0x182B7B610", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class PDOYDPEPWZT : DJHXDSZWRBQ<QDZPZLCRFHM>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public PDOYDPEPWZT TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<JCARNWHFFIV>> TFSBHAPEDGP;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D7D0", Offset = "0x2B6C1D0", VA = "0x182B6D7D0")]
				internal int DAXDMWYHHED()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D9A0", Offset = "0x2B6C3A0", VA = "0x182B6D9A0")]
				internal void DBCKKDSEQPM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class BGTNVJGACLG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<JCARNWHFFIV> WPRMMXDVNSJ;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGTNVJGACLG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CBE0", Offset = "0x2B6B5E0", VA = "0x182B6CBE0")]
				internal bool CZWVAPCULZK(Id32<JCARNWHFFIV> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2B7B440", Offset = "0x2B79E40", VA = "0x182B7B440")]
			public PDOYDPEPWZT(WVKEVWTACCJ a, QDZPZLCRFHM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x2B7AF10", Offset = "0x2B79910", VA = "0x182B7AF10", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class IAIIJTGACIV : DJHXDSZWRBQ<EACYOWRGXZY>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xD43240", Offset = "0xD41C40", VA = "0x180D43240", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x2B727D0", Offset = "0x2B711D0", VA = "0x182B727D0")]
			public IAIIJTGACIV(WVKEVWTACCJ a, EACYOWRGXZY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class GXAVJRXQUNQ : DJHXDSZWRBQ<CLLFJYEQSEL>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xD80A40", Offset = "0xD7F440", VA = "0x180D80A40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x2B71FB0", Offset = "0x2B709B0", VA = "0x182B71FB0")]
			public GXAVJRXQUNQ(WVKEVWTACCJ a, CLLFJYEQSEL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "134")]
			protected override bool HFWDYMOQWEK(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class XNDTNTAPYDY : DJHXDSZWRBQ<YWRAWNZSEKT>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xD95C00", Offset = "0xD94600", VA = "0x180D95C00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x2B86F80", Offset = "0x2B85980", VA = "0x182B86F80", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2B86F10", Offset = "0x2B85910", VA = "0x182B86F10")]
			public XNDTNTAPYDY(WVKEVWTACCJ a, YWRAWNZSEKT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class HREDHHDXWQW : DJHXDSZWRBQ<CPYTJZLXVYD>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x2B72780", Offset = "0x2B71180", VA = "0x182B72780", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2B72710", Offset = "0x2B71110", VA = "0x182B72710")]
			public HREDHHDXWQW(WVKEVWTACCJ a, CPYTJZLXVYD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class TUUJAGRPERV : XEUMHMCOXDA<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public TUUJAGRPERV TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x2B6DF40", Offset = "0x2B6C940", VA = "0x182B6DF40")]
				internal float RQHRHALQWTP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x2B6DE00", Offset = "0x2B6C800", VA = "0x182B6DE00")]
				internal void RQCKJTRTNIG(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2B7DA20", Offset = "0x2B7C420", VA = "0x182B7DA20")]
			public TUUJAGRPERV(WVKEVWTACCJ a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2B7D7B0", Offset = "0x2B7C1B0", VA = "0x182B7D7B0", Slot = "151")]
			protected override void POIMKMHGSIV(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class MIOIFVOEMRW : DJHXDSZWRBQ<IAGHPPIRLXX>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A680", Offset = "0x2B79080", VA = "0x182B7A680")]
			public MIOIFVOEMRW(WVKEVWTACCJ a, IAGHPPIRLXX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class XMJFXVCEMXO : DJHXDSZWRBQ<WRNDVBSAOLP>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2B86EA0", Offset = "0x2B858A0", VA = "0x182B86EA0")]
			public XMJFXVCEMXO(WVKEVWTACCJ a, WRNDVBSAOLP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class TAIGXSIOCCJ : DJHXDSZWRBQ<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public TAIGXSIOCCJ TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D070", Offset = "0x2B6BA70", VA = "0x182B6D070")]
				internal bool DARWPQEJXSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D1F0", Offset = "0x2B6BBF0", VA = "0x182B6D1F0")]
				internal void DAXDMWYHHED(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2B7D740", Offset = "0x2B7C140", VA = "0x182B7D740")]
			public TAIGXSIOCCJ(WVKEVWTACCJ a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2B7D4B0", Offset = "0x2B7BEB0", VA = "0x182B7D4B0", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class RIJQTYFUZPP : DJHXDSZWRBQ<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public RIJQTYFUZPP TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> YADCNWBVSFA;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CF40", Offset = "0x2B6B940", VA = "0x182B6CF40")]
				internal object? DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CE20", Offset = "0x2B6B820", VA = "0x182B6CE20")]
				internal bool DAMPSJKMOHL(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D580", Offset = "0x2B6BF80", VA = "0x182B6D580")]
				internal void DAXDMWYHHED(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2B6DC60", Offset = "0x2B6C660", VA = "0x182B6DC60")]
				internal string DBCKKDSEQPM(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2B6DDB0", Offset = "0x2B6C7B0", VA = "0x182B6DDB0")]
				internal IReadOnlyList<object> DBHRHKMCAAV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CC30", Offset = "0x2B6B630", VA = "0x182B6CC30")]
				internal bool CZWVAPCULZK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CCA0", Offset = "0x2B6B6A0", VA = "0x182B6CCA0")]
				internal bool DACBXVWRVKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CCF0", Offset = "0x2B6B6F0", VA = "0x182B6CCF0")]
				internal void DAHIVCQPEWC(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2B7C2D0", Offset = "0x2B7ACD0", VA = "0x182B7C2D0")]
			public RIJQTYFUZPP(WVKEVWTACCJ a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2B7BBF0", Offset = "0x2B7A5F0", VA = "0x182B7BBF0", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class NXWUQCSSHBF : DJHXDSZWRBQ<BRPKTYCLEAM>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class WKDUFJUPYFO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int DMTVGWYQNOF;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WKDUFJUPYFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2B84FE0", Offset = "0x2B839E0", VA = "0x182B84FE0")]
				internal bool GBPCYKXFKAF(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class JJCJYPIOSDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public NXWUQCSSHBF TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> UQDSGIXIHVX;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public JJCJYPIOSDN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2B77BC0", Offset = "0x2B765C0", VA = "0x182B77BC0")]
				internal int DARWPQEJXSU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x2B77C60", Offset = "0x2B76660", VA = "0x182B77C60")]
				internal void DAXDMWYHHED(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x2B77D80", Offset = "0x2B76780", VA = "0x182B77D80")]
				internal string? DBCKKDSEQPM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2B7AE30", Offset = "0x2B79830", VA = "0x182B7AE30")]
			public NXWUQCSSHBF(WVKEVWTACCJ a, BRPKTYCLEAM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A930", Offset = "0x2B79330", VA = "0x182B7A930")]
			private int EFFQBFAARSR(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A9C0", Offset = "0x2B793C0", VA = "0x182B7A9C0")]
			private void SAYQMLBLQWJ(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2B7AAE0", Offset = "0x2B794E0", VA = "0x182B7AAE0", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class GKPDGLTGQKI : XZGCCFHKIWU<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xF3F580", Offset = "0xF3DF80", VA = "0x180F3F580", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2B71A50", Offset = "0x2B70450", VA = "0x182B71A50")]
			public GKPDGLTGQKI(WVKEVWTACCJ a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class XEBEKFUUPQK : XEUMHMCOXDA<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public XEBEKFUUPQK TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2B6DFC0", Offset = "0x2B6C9C0", VA = "0x182B6DFC0")]
				internal int RQHRHALQWTP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x2B6DEA0", Offset = "0x2B6C8A0", VA = "0x182B6DEA0")]
				internal void RQCKJTRTNIG(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2B864C0", Offset = "0x2B84EC0", VA = "0x182B864C0")]
			public XEBEKFUUPQK(WVKEVWTACCJ a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2B86250", Offset = "0x2B84C50", VA = "0x182B86250", Slot = "151")]
			protected override void POIMKMHGSIV(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class MHCVFRQBESQ : DJHXDSZWRBQ<ZXWLULIILRX>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public MHCVFRQBESQ TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<JCARNWHFFIV>> TFSBHAPEDGP;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D3B0", Offset = "0x2B6BDB0", VA = "0x182B6D3B0")]
				internal int DAXDMWYHHED()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2B6DB00", Offset = "0x2B6C500", VA = "0x182B6DB00")]
				internal void DBCKKDSEQPM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class BGTNVJGACLG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<JCARNWHFFIV> WPRMMXDVNSJ;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGTNVJGACLG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CB90", Offset = "0x2B6B590", VA = "0x182B6CB90")]
				internal bool CZWVAPCULZK(Id32<JCARNWHFFIV> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A610", Offset = "0x2B79010", VA = "0x182B7A610")]
			public MHCVFRQBESQ(WVKEVWTACCJ a, ZXWLULIILRX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A0E0", Offset = "0x2B78AE0", VA = "0x182B7A0E0", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class MIXSLFGPBOG : DJHXDSZWRBQ<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public MIXSLFGPBOG TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CEF0", Offset = "0x2B6B8F0", VA = "0x182B6CEF0")]
				internal bool DARWPQEJXSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D320", Offset = "0x2B6BD20", VA = "0x182B6D320")]
				internal void DAXDMWYHHED(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A8C0", Offset = "0x2B792C0", VA = "0x182B7A8C0")]
			public MIXSLFGPBOG(WVKEVWTACCJ a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A6F0", Offset = "0x2B790F0", VA = "0x182B7A6F0", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class JPFYBCEIUPY : DJHXDSZWRBQ<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public JPFYBCEIUPY TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D0C0", Offset = "0x2B6BAC0", VA = "0x182B6D0C0")]
				internal bool DARWPQEJXSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D910", Offset = "0x2B6C310", VA = "0x182B6D910")]
				internal void DAXDMWYHHED(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2B78000", Offset = "0x2B76A00", VA = "0x182B78000")]
			public JPFYBCEIUPY(WVKEVWTACCJ a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2B77E30", Offset = "0x2B76830", VA = "0x182B77E30", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class HKFAONFWXPK : DJHXDSZWRBQ<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public HKFAONFWXPK TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x2B6CEA0", Offset = "0x2B6B8A0", VA = "0x182B6CEA0")]
				internal int DARWPQEJXSU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D160", Offset = "0x2B6BB60", VA = "0x182B6D160")]
				internal void DAXDMWYHHED(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2B726A0", Offset = "0x2B710A0", VA = "0x182B726A0")]
			public HKFAONFWXPK(WVKEVWTACCJ a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2B72450", Offset = "0x2B70E50", VA = "0x182B72450", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class TXJDCWRINNJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log WVPIFBCBMJC;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class GGZCGWHFCPO<a> : DJHXDSZWRBQ<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class CAKVKJDIRQL
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
					public CAKVKJDIRQL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x42011D0", Offset = "0x41FFBD0", VA = "0x1842011D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x4201510", Offset = "0x41FFF10", VA = "0x184201510", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload XNDJVEIFYAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public GGZCGWHFCPO<a> TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public CAKVKJDIRQL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x505F890", Offset = "0x505E290", VA = "0x18505F890")]
				[AsyncStateMachine(typeof(GGZCGWHFCPO<>.CAKVKJDIRQL.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task WCMSWLSHAVG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x505F770", Offset = "0x505E170", VA = "0x18505F770")]
				internal void LPZQKZCZOFR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class BNIQGLYMCKR
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
					public BNIQGLYMCKR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x4216810", Offset = "0x4215210", VA = "0x184216810", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public BNIQGLYMCKR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x4218000", Offset = "0x4216A00", VA = "0x184218000", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x4218710", Offset = "0x4217110", VA = "0x184218710", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public BBYVCMSUUDJ.QJKWEUUZVRH VOIWZKOAOHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string WRCJCDFYYWT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string JFSPAXJVUCV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public GGZCGWHFCPO<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper KNFUSIEADIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool PEZQHJIPNNR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action VCGQGXAMRBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool IPASBFVPHBX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string TQEPSAFGPAT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action BXDVCLJQVXR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action WXHZXFKWKCP;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BNIQGLYMCKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x4F36FB0", Offset = "0x4F359B0", VA = "0x184F36FB0")]
				internal void DFQBSCDZHZW(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x4F37000", Offset = "0x4F35A00", VA = "0x184F37000")]
				internal void DFVIPIXWRLF(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
				internal string PBNOIHXQWDJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x4F37240", Offset = "0x4F35C40", VA = "0x184F37240")]
				internal void PBIHLBDTMSA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x4F37170", Offset = "0x4F35B70", VA = "0x184F37170")]
				internal bool PBYCCVLLPAB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x4F37420", Offset = "0x4F35E20", VA = "0x184F37420")]
				internal char PBSVFOROFOS((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				internal string? PASMTGWBKJZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xF5A4C0", Offset = "0xF58EC0", VA = "0x180F5A4C0")]
				internal bool PANFWACEAYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x4F37180", Offset = "0x4F35B80", VA = "0x184F37180")]
				internal void PBDANUJWDGR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x4F37170", Offset = "0x4F35B70", VA = "0x184F37170")]
				internal bool PAXTQNPYTVI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x4F37500", Offset = "0x4F35F00", VA = "0x184F37500")]
				[AsyncStateMachine(typeof(GGZCGWHFCPO<>.BNIQGLYMCKR.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void PDDRMKAVTQD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x4F37070", Offset = "0x4F35A70", VA = "0x184F37070")]
				internal void NXQXAJGJXPX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x4F36DC0", Offset = "0x4F357C0", VA = "0x184F36DC0")]
				[AsyncStateMachine(typeof(GGZCGWHFCPO<>.BNIQGLYMCKR.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task DDLVMNXVDUS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x4F36E90", Offset = "0x4F35890", VA = "0x184F36E90")]
				internal void DEFFLGURTYL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x4F375A0", Offset = "0x4F35FA0", VA = "0x184F375A0")]
				internal void XBFFKOQNBHN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x4F374C0", Offset = "0x4F35EC0", VA = "0x184F374C0")]
				internal bool PCYKPDGYKEU()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class XUQBWUXHYTS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter GZOLSDDXKER;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public GGZCGWHFCPO<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<BBYVCMSUUDJ.QAJNFKPBSIJ> BVILBCMOOZO;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public XUQBWUXHYTS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x5140B50", Offset = "0x513F550", VA = "0x185140B50")]
				internal bool BYAVACHPNNW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x5140E30", Offset = "0x513F830", VA = "0x185140E30")]
				internal void XOFVQPYTSOM(BBYVCMSUUDJ.QAJNFKPBSIJ a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class XUVIUBRFIFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool OCMUAZXLDEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public GSOEDYAARUW ZHCGUCYMXVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public GSOEDYAARUW BDSYSQIGKRI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public GSOEDYAARUW NLYGQJLJJAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string QGSIQRNNLVM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public XUQBWUXHYTS UZNLTVLUBPB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action YANQIJPQLBS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action BVYFSWUGRHP;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public XUVIUBRFIFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xF69BF0", Offset = "0xF685F0", VA = "0x180F69BF0")]
				internal bool EGEOSUDRQVS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x5141FD0", Offset = "0x51409D0", VA = "0x185141FD0")]
				internal void SLNDGLMIWFD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x5141960", Offset = "0x5140360", VA = "0x185141960")]
				internal void BYQPRWPHPVX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x5140F00", Offset = "0x513F900", VA = "0x185140F00")]
				internal void BVPQGZCVEHS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x5140F20", Offset = "0x513F920", VA = "0x185140F20")]
				internal void BXQHFOTUURE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x5141310", Offset = "0x513FD10", VA = "0x185141310")]
				internal void BYGBXJBMWZF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x5140F00", Offset = "0x513F900", VA = "0x185140F00")]
				internal void XOVQIKGLUWN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class XVAPRILCRQK
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
					public XVAPRILCRQK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x422D820", Offset = "0x422C220", VA = "0x18422D820", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x422DE60", Offset = "0x422C860", VA = "0x18422DE60", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool LRHGTXAQZPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public XUVIUBRFIFB UZSSRCFRLAK;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public XVAPRILCRQK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x5142140", Offset = "0x5140B40", VA = "0x185142140")]
				[AsyncStateMachine(typeof(GGZCGWHFCPO<>.XVAPRILCRQK.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task IQSNXRNFQFN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x51420D0", Offset = "0x5140AD0", VA = "0x1851420D0")]
				internal void BVUXEFWSNTB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class XVFWOPFABBT
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
					public XVFWOPFABBT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x422D210", Offset = "0x422BC10", VA = "0x18422D210", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x422D7C0", Offset = "0x422C1C0", VA = "0x18422D7C0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload OIEPHMEXWBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public XUVIUBRFIFB UZXZOIZOULT;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public XVFWOPFABBT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x5142280", Offset = "0x5140C80", VA = "0x185142280")]
				[AsyncStateMachine(typeof(GGZCGWHFCPO<>.XVFWOPFABBT.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task ZDUUFGRRVLM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x5142210", Offset = "0x5140C10", VA = "0x185142210")]
				internal void XOQJLDMOLLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class LXAYWWHORXP
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
					public LXAYWWHORXP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x422CD30", Offset = "0x422B730", VA = "0x18422CD30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x422D1B0", Offset = "0x422BBB0", VA = "0x18422D1B0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public GGZCGWHFCPO<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload MVHYBWNJRBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public BBYVCMSUUDJ.QAJNFKPBSIJ VOIWZKOAOHQ;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public LXAYWWHORXP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x68F2380", Offset = "0x68F0D80", VA = "0x1868F2380")]
				[AsyncStateMachine(typeof(GGZCGWHFCPO<>.LXAYWWHORXP.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task GTDCPIEBISI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x68F25C0", Offset = "0x68F0FC0", VA = "0x1868F25C0")]
				internal bool NVNQNCKJFGS(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x68F24A0", Offset = "0x68F0EA0", VA = "0x1868F24A0")]
				internal void NVIJPVQLVVJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x68F2450", Offset = "0x68F0E50", VA = "0x1868F2450")]
				internal void NVDCSOWOMKA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class XYEKQIUPMDI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string ZSYSCWFLEXD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public GSOEDYAARUW CZAHJHJBVUM;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public XYEKQIUPMDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x5142DA0", Offset = "0x51417A0", VA = "0x185142DA0")]
				internal string? HJVAGIQKGPB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xEAE870", Offset = "0xEAD270", VA = "0x180EAE870")]
				internal bool HJPTJBWMXDS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x5142DC0", Offset = "0x51417C0", VA = "0x185142DC0")]
				internal void HKFOAWEEZLT(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool WXZXXFOWYMO;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log WVPIFBCBMJC
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x6462030", Offset = "0x6460A30", VA = "0x186462030")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x64625D0", Offset = "0x6460FD0", VA = "0x1864625D0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected BBYVCMSUUDJ JWJDDGYRILI
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xD20180", Offset = "0xD1EB80", VA = "0x180D20180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xD20140", Offset = "0xD1EB40", VA = "0x180D20140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> ZQEJBOJUJYV
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xDD8030", Offset = "0xDD6A30", VA = "0x180DD8030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x1128E30", Offset = "0x1127830", VA = "0x181128E30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected SCJHQENLOSH ZGUBOVHRXEI
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x174BBB0", Offset = "0x174A5B0", VA = "0x18174BBB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected NOEMDSCOVZL IBLBYHXASGO
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xF86CE0", Offset = "0xF856E0", VA = "0x180F86CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x174EA20", Offset = "0x174D420", VA = "0x18174EA20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x64625A0", Offset = "0x6460FA0", VA = "0x1864625A0")]
			protected GGZCGWHFCPO(WVKEVWTACCJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x645F270", Offset = "0x645DC70", VA = "0x18645F270", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x645F210", Offset = "0x645DC10", VA = "0x18645F210", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x645F9C0", Offset = "0x645E3C0", VA = "0x18645F9C0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x645FA20", Offset = "0x645E420", VA = "0x18645FA20")]
			private void ECLRLATNYWX(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x6462080", Offset = "0x6460A80", VA = "0x186462080", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x645F2D0", Offset = "0x645DCD0", VA = "0x18645F2D0")]
			private void DSNVRVNQQRD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x6460120", Offset = "0x645EB20", VA = "0x186460120")]
			private void NMEKRAKSXPR(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "151")]
			protected virtual void CJRIEVAZOIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x645FF10", Offset = "0x645E910", VA = "0x18645FF10")]
			private void IVCBJRMWXMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x6460C30", Offset = "0x645F630", VA = "0x186460C30")]
			private void NUWMIBEPMHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x645E430", Offset = "0x645CE30", VA = "0x18645E430")]
			private void CKJMVTHIYDX(BBYVCMSUUDJ.QAJNFKPBSIJ a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x645FD00", Offset = "0x645E700", VA = "0x18645FD00")]
			private void HCTIDAKCCWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x645E0D0", Offset = "0x645CAD0", VA = "0x18645E0D0")]
			protected void AZKPFQDTIIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x645F1A0", Offset = "0x645DBA0", VA = "0x18645F1A0")]
			private void CPASPEDUNFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x6460020", Offset = "0x645EA20", VA = "0x186460020")]
			private void JQXLHXCXGSJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6460040", Offset = "0x645EA40", VA = "0x186460040")]
			private void LPCVSXPOHWI(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x6462200", Offset = "0x6460C00", VA = "0x186462200")]
			private string XVOQTPVBQPA((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x6462510", Offset = "0x6460F10", VA = "0x186462510")]
			private string YEOQNOKKSER(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x6461FB0", Offset = "0x64609B0", VA = "0x186461FB0")]
			[CompilerGenerated]
			private object? ODGZNQFQDLL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x6461800", Offset = "0x6460200", VA = "0x186461800")]
			[CompilerGenerated]
			private void ODBSQJLSUAC(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x6461780", Offset = "0x6460180", VA = "0x186461780")]
			[CompilerGenerated]
			private IReadOnlyList<object> OCREVVXYBDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x64616F0", Offset = "0x64600F0", VA = "0x1864616F0")]
			[CompilerGenerated]
			private void OCLXYPEARSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x6461FE0", Offset = "0x64609E0", VA = "0x186461FE0")]
			[CompilerGenerated]
			private void OERVULOXRMW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x64600E0", Offset = "0x645EAE0", VA = "0x1864600E0")]
			[CompilerGenerated]
			private void MUQTWDNNCVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x645E100", Offset = "0x645CB00", VA = "0x18645E100")]
			[CompilerGenerated]
			private void CBWMRQHVBJS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x64600A0", Offset = "0x645EAA0", VA = "0x1864600A0")]
			[CompilerGenerated]
			private void LRTNRSVFUSR(BBYVCMSUUDJ.QAJNFKPBSIJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class JACCYAJMOBJ : GGZCGWHFCPO<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xD95C00", Offset = "0xD94600", VA = "0x180D95C00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2B728A0", Offset = "0x2B712A0", VA = "0x182B728A0")]
			public JACCYAJMOBJ(WVKEVWTACCJ a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class YVIIOPDCEGD : GGZCGWHFCPO<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type TLYFHVVDMAY
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x2B7CA10", Offset = "0x2B7B410", VA = "0x182B7CA10", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope FLHTJRBLJEN
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string XNOXUCKMZXB
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x1452CA0", Offset = "0x14516A0", VA = "0x181452CA0")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2B7CA60", Offset = "0x2B7B460", VA = "0x182B7CA60", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2B7CB50", Offset = "0x2B7B550", VA = "0x182B7CB50", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool YSECTKZZBZG(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2B7C900", Offset = "0x2B7B300", VA = "0x182B7C900", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x2B7C870", Offset = "0x2B7B270", VA = "0x182B7C870", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x2B7C720", Offset = "0x2B7B120", VA = "0x182B7C720", Slot = "7")]
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
				protected virtual Type TLYFHVVDMAY
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x2B7E0A0", Offset = "0x2B7CAA0", VA = "0x182B7E0A0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers ENFFMPKNAQP
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string XNOXUCKMZXB
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x1452CA0", Offset = "0x14516A0", VA = "0x181452CA0")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2B7E0F0", Offset = "0x2B7CAF0", VA = "0x182B7E0F0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2B7E1E0", Offset = "0x2B7CBE0", VA = "0x182B7E1E0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool YSECTKZZBZG(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2B7DF90", Offset = "0x2B7C990", VA = "0x182B7DF90", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x2B7DDB0", Offset = "0x2B7C7B0", VA = "0x182B7DDB0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x2B7DE40", Offset = "0x2B7C840", VA = "0x182B7DE40", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
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
					public KMORFLEWRJL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2B82180", Offset = "0x2B80B80", VA = "0x182B82180", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public KMORFLEWRJL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x2B82590", Offset = "0x2B80F90", VA = "0x182B82590", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public YVIIOPDCEGD TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public SCJHQENLOSH IQGVQQOROIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> YASXFQJNUNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> YANQIJPQLBS;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2B79C70", Offset = "0x2B78670", VA = "0x182B79C70")]
				internal object? NDCZIYBBXIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2B79E20", Offset = "0x2B78820", VA = "0x182B79E20")]
				internal bool NETCNAEGUVS(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2B79D50", Offset = "0x2B78750", VA = "0x182B79D50")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void NDIGGEUZGUH(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2B799A0", Offset = "0x2B783A0", VA = "0x182B799A0")]
				internal IReadOnlyList<TargetPlayersSelection> JTBFMYKJLUW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2B79A50", Offset = "0x2B78450", VA = "0x182B79A50")]
				internal object? NCNERDTJVAX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x2B79E80", Offset = "0x2B78880", VA = "0x182B79E80")]
				internal bool NEYJKGYEEHB(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x2B79BA0", Offset = "0x2B785A0", VA = "0x182B79BA0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void NCSLOKNHEMG(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> VGEPJMOKOJM;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> TPMHKKYABUA;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> ADDYWZKEHCY;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2B88100", Offset = "0x2B86B00", VA = "0x182B88100")]
			public YVIIOPDCEGD(WVKEVWTACCJ a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x2B87560", Offset = "0x2B85F60", VA = "0x182B87560", Slot = "151")]
			protected override void CJRIEVAZOIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2B87AE0", Offset = "0x2B864E0", VA = "0x182B87AE0")]
			private static IReadOnlyList<TargetPlayersSelection> ZVBJPJDUXOF(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class XIWVNHSPFBK : QCNAPQKROEB<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType FGUOEPSMTLU
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2B86E40", Offset = "0x2B85840", VA = "0x182B86E40")]
			public XIWVNHSPFBK(WVKEVWTACCJ a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class POLLFTLQJPP : DJHXDSZWRBQ<QQDUHQODGUC>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2B7B4B0", Offset = "0x2B79EB0", VA = "0x182B7B4B0")]
			public POLLFTLQJPP(WVKEVWTACCJ a, QQDUHQODGUC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class DJHXDSZWRBQ<a> : JBOFPJQGWHN, IDisposable where a : notnull, QQDUHQODGUC
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class PKPAGNSVYSD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public DJHXDSZWRBQ<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public WVKEVWTACCJ CWBZGVHVUXX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a KLDKEUKXHIW;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public PKPAGNSVYSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x73E8B50", Offset = "0x73E7550", VA = "0x1873E8B50")]
				internal JGUOVUXHOPA QNVEWOBEVJR(NEPWNPKCEJD a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class UZZADFUBMHT
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
					public UZZADFUBMHT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x4203DD0", Offset = "0x42027D0", VA = "0x184203DD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string KRWACQCEQVZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, LSNRXVKTUTI>> HNYGWMWFHJS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public DJHXDSZWRBQ<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> GCHCNRWYYXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public BBYVCMSUUDJ JWJDDGYRILI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> SDTCWIQBLBK;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public UZZADFUBMHT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				internal string SFFTXEFMBYR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				internal void SFAMZXLOSNI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x7D2E490", Offset = "0x7D2CE90", VA = "0x187D2E490")]
				[AsyncStateMachine(typeof(DJHXDSZWRBQ<>.UZZADFUBMHT.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void SEVGCQRRJBZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class GYEHZXRQDYA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public GYEHZXRQDYA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x647C930", Offset = "0x647B330", VA = "0x18647C930")]
				internal Result<string, LSNRXVKTUTI> QAJQSGQWKIT(string a)
				{
					return default(Result<string, LSNRXVKTUTI>);
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
				public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public DJHXDSZWRBQ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x6BCA210", Offset = "0x6BC8C10", VA = "0x186BCA210", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x6BCA460", Offset = "0x6BC8E60", VA = "0x186BCA460", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public DJHXDSZWRBQ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x6BCA4D0", Offset = "0x6BC8ED0", VA = "0x186BCA4D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x6BCA7D0", Offset = "0x6BC91D0", VA = "0x186BCA7D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly WVKEVWTACCJ VPGKPQMXGZQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool OXNQACMZHES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<SLVANOSNYVT, JGUOVUXHOPA> SMWFWRVUIYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<SLVANOSNYVT, IODGEOJDMSL> UFEEDVLMMCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> KVKZOLQTHEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<SLVANOSNYVT>>? TKKMWVDELLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<SLVANOSNYVT>, IODGEOJDMSL>? JREAWMPDJDL;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected BSRXIMSMGHS AMJPMKEJKQH
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x53B4C70", Offset = "0x53B3670", VA = "0x1853B4C70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected VQEUHQUVGGC VQEUHQUVGGC
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x53B3BA0", Offset = "0x53B25A0", VA = "0x1853B3BA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected LGEKONOLGQZ KKSLSDURURC
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x53B3DD0", Offset = "0x53B27D0", VA = "0x1853B3DD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a QQDUHQODGUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<SZWXGBXMTIF> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x16B0DC0", Offset = "0x16AF7C0", VA = "0x1816B0DC0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<SZWXGBXMTIF>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<MXFPFCGZOVW> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x53B5F90", Offset = "0x53B4990", VA = "0x1853B5F90", Slot = "6")]
				get
				{
					return default(Id32<MXFPFCGZOVW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x53B5E00", Offset = "0x53B4800", VA = "0x1853B5E00", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x53B5DE0", Offset = "0x53B47E0", VA = "0x1853B5DE0", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x53B60F0", Offset = "0x53B4AF0", VA = "0x1853B60F0", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<JNMNERPAZHW> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD88F60", Offset = "0xD87960", VA = "0x180D88F60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<JNMNERPAZHW>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD8A750", Offset = "0xD89150", VA = "0x180D8A750")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xD62010", Offset = "0xD60A10", VA = "0x180D62010", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x53B5CB0", Offset = "0x53B46B0", VA = "0x1853B5CB0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x53B5CE0", Offset = "0x53B46E0", VA = "0x1853B5CE0", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x53B5D10", Offset = "0x53B4710", VA = "0x1853B5D10", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x53B5F70", Offset = "0x53B4970", VA = "0x1853B5F70", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x53B5EA0", Offset = "0x53B48A0", VA = "0x1853B5EA0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x53B5D80", Offset = "0x53B4780", VA = "0x1853B5D80", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x53B5D50", Offset = "0x53B4750", VA = "0x1853B5D50", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x10F8F60", Offset = "0x10F7960", VA = "0x1810F8F60", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x1837F90", Offset = "0x1836990", VA = "0x181837F90")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x53B5D40", Offset = "0x53B4740", VA = "0x1853B5D40", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x53B5E50", Offset = "0x53B4850", VA = "0x1853B5E50", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x53B5F10", Offset = "0x53B4910", VA = "0x1853B5F10", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x53B5F40", Offset = "0x53B4940", VA = "0x1853B5F40", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x53B5E80", Offset = "0x53B4880", VA = "0x1853B5E80", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual FNRFQENIPMQ? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual YEDZHZZAPGR? VAAMIKOTQQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<CEDSPQRYDBL>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x53B5DB0", Offset = "0x53B47B0", VA = "0x1853B5DB0", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<JNHEPOTZQDV> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x53B5EC0", Offset = "0x53B48C0", VA = "0x1853B5EC0", Slot = "68")]
				get
				{
					return default(Id128<JNHEPOTZQDV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<JNHEPOTZQDV> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x53B5E20", Offset = "0x53B4820", VA = "0x1853B5E20", Slot = "59")]
				get
				{
					return default(Id32<JNHEPOTZQDV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<JNHEPOTZQDV>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<JNHEPOTZQDV>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x53B27C0", Offset = "0x53B11C0", VA = "0x1853B27C0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xD1DDA0", Offset = "0xD1C7A0", VA = "0x180D1DDA0", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xD1E3E0", Offset = "0xD1CDE0", VA = "0x180D1E3E0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xD1DC90", Offset = "0xD1C690", VA = "0x180D1DC90", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xD1DD00", Offset = "0xD1C700", VA = "0x180D1DD00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<CEDSPQRYDBL> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x53B5FD0", Offset = "0x53B49D0", VA = "0x1853B5FD0", Slot = "69")]
				get
				{
					return default(Id32<CEDSPQRYDBL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<CEDSPQRYDBL> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x53B5EF0", Offset = "0x53B48F0", VA = "0x1853B5EF0", Slot = "70")]
				get
				{
					return default(Id128<CEDSPQRYDBL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<CEDSPQRYDBL>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x53B5FF0", Offset = "0x53B49F0", VA = "0x1853B5FF0", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<SLVANOSNYVT, IODGEOJDMSL> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x53B60B0", Offset = "0x53B4AB0", VA = "0x1853B60B0", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<SLVANOSNYVT, IODGEOJDMSL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<SLVANOSNYVT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action UZZEWHPQXVX
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x53B5620", Offset = "0x53B4020", VA = "0x1853B5620", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x53B4F90", Offset = "0x53B3990", VA = "0x1853B4F90", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate MXJISJJQTYU
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x53B4D90", Offset = "0x53B3790", VA = "0x1853B4D90", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x53B3540", Offset = "0x53B1F40", VA = "0x1853B3540", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate JBAVHJHKNFB
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x53B2660", Offset = "0x53B1060", VA = "0x1853B2660", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x53B3A40", Offset = "0x53B2440", VA = "0x1853B3A40", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action VTCZULEBXWD
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x53B46E0", Offset = "0x53B30E0", VA = "0x1853B46E0", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x53B4680", Offset = "0x53B3080", VA = "0x1853B4680", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action HHYMXBUXBTM
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x53B56C0", Offset = "0x53B40C0", VA = "0x1853B56C0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x53B3D30", Offset = "0x53B2730", VA = "0x1853B3D30", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<SLVANOSNYVT>, IODGEOJDMSL> XQVDZQDSFEH
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x53B3710", Offset = "0x53B2110", VA = "0x1853B3710", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x53B35E0", Offset = "0x53B1FE0", VA = "0x1853B35E0", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<SLVANOSNYVT>, IODGEOJDMSL> YNBEFKFSXMO
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x53B1770", Offset = "0x53B0170", VA = "0x1853B1770", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x53B29E0", Offset = "0x53B13E0", VA = "0x1853B29E0", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<SLVANOSNYVT>> RSLWLHLOGFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x53B3AE0", Offset = "0x53B24E0", VA = "0x1853B3AE0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x53B4AF0", Offset = "0x53B34F0", VA = "0x1853B4AF0", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<SLVANOSNYVT>, Id32<SLVANOSNYVT>> MWOQQOWVNEX
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x53B1880", Offset = "0x53B0280", VA = "0x1853B1880", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x53B2920", Offset = "0x53B1320", VA = "0x1853B2920", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<SLVANOSNYVT>, IODGEOJDMSL> VKLSWYPKDAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x53B2C10", Offset = "0x53B1610", VA = "0x1853B2C10", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x53B40B0", Offset = "0x53B2AB0", VA = "0x1853B40B0", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<SLVANOSNYVT>, Id32<SLVANOSNYVT>> NGKSQIOHQFE
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x53B2700", Offset = "0x53B1100", VA = "0x1853B2700", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x53B3FF0", Offset = "0x53B29F0", VA = "0x1853B3FF0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> OWKPYPTOVIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x53B2580", Offset = "0x53B0F80", VA = "0x1853B2580", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x53B5780", Offset = "0x53B4180", VA = "0x1853B5780", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x53B5840", Offset = "0x53B4240", VA = "0x1853B5840")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected DJHXDSZWRBQ(WVKEVWTACCJ a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x53B2CD0", Offset = "0x53B16D0", VA = "0x1853B2CD0", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x53B20F0", Offset = "0x53B0AF0", VA = "0x1853B20F0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x53B36A0", Offset = "0x53B20A0", VA = "0x1853B36A0", Slot = "9")]
			public Task<Result<None, LSNRXVKTUTI>> KACFKBCGQWK(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x53B1740", Offset = "0x53B0140", VA = "0x1853B1740")]
			public bool YDIAQKXFKPM([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x53B1830", Offset = "0x53B0230", VA = "0x1853B1830")]
			public bool AMCAOVPRDGX([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x53B5580", Offset = "0x53B3F80", VA = "0x1853B5580", Slot = "34")]
			public void XQEHULFUTFB(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x53B37D0", Offset = "0x53B21D0", VA = "0x1853B37D0", Slot = "35")]
			public Task KIDXBOZSFUP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x53B2430", Offset = "0x53B0E30", VA = "0x1853B2430", Slot = "36")]
			[AsyncStateMachine(typeof(DJHXDSZWRBQ<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, LSNRXVKTUTI>> EPSKWZTNYVU(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "119")]
			public virtual void ASHZBQGIXNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x10BB5A0", Offset = "0x10B9FA0", VA = "0x1810BB5A0")]
			protected void RHXKTEAVBLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x217E520", Offset = "0x217CF20", VA = "0x18217E520")]
			protected void UINLEDLESAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x215BB70", Offset = "0x215A570", VA = "0x18215BB70")]
			private void GNIBHHJUZBY([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x53B4BB0", Offset = "0x53B35B0", VA = "0x1853B4BB0", Slot = "122")]
			public virtual Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> UUMJVVRWSQJ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x53B4790", Offset = "0x53B3190", VA = "0x1853B4790", Slot = "123")]
			public virtual Task<Result<None, LSNRXVKTUTI>> SRTSVRNFSGQ(Id32<SLVANOSNYVT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "124")]
			public virtual void JRNOYSVCAOI(Id32<SLVANOSNYVT> sourceId, Id32<SLVANOSNYVT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x53B4850", Offset = "0x53B3250", VA = "0x1853B4850", Slot = "125")]
			public virtual IEnumerable<PZJVNVFLVDC> UKLXJOFGGFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x53B4E30", Offset = "0x53B3830", VA = "0x1853B4E30", Slot = "126")]
			public Result<None, LSNRXVKTUTI> WWRPNLLBVXI(string a)
			{
				return default(Result<None, LSNRXVKTUTI>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x53B4E70", Offset = "0x53B3870", VA = "0x1853B4E70", Slot = "50")]
			public bool XEKHCMPBWDY([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x53B2EA0", Offset = "0x53B18A0", VA = "0x1853B2EA0")]
			public bool JIEDFZDBEMX([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "128")]
			public virtual void PVTPBUYKQFH(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "129")]
			public virtual IEQIKXVEANC BOFYTAVDGZP([In] OAFGGXPPURN audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x53B2AA0", Offset = "0x53B14A0", VA = "0x1853B2AA0")]
			protected void IIALCXPWVLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x53B27C0", Offset = "0x53B11C0", VA = "0x1853B27C0", Slot = "134")]
			protected virtual bool HFWDYMOQWEK(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x53B4D60", Offset = "0x53B3760", VA = "0x1853B4D60", Slot = "96")]
			public bool VLRXKNGFTPK(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "135")]
			protected virtual bool WAGMZRFONHL(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected virtual void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x53B19D0", Offset = "0x53B03D0", VA = "0x1853B19D0")]
			protected void CWEHVNMYHWF(BBYVCMSUUDJ a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, LSNRXVKTUTI>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x53B48F0", Offset = "0x53B32F0", VA = "0x1853B48F0")]
			protected void ULHZWQBRKHZ(BBYVCMSUUDJ a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x53B1DD0", Offset = "0x53B07D0", VA = "0x1853B1DD0", Slot = "146")]
			protected virtual void DFRVLKDQVZU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x53B1D80", Offset = "0x53B0780", VA = "0x1853B1D80", Slot = "90")]
			public void CYXCDQYXTAT(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x53B4CF0", Offset = "0x53B36F0", VA = "0x1853B4CF0", Slot = "91")]
			public CircuitsRigidTransform VICEHOZIEAC()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "149")]
			public virtual bool IJOBGNQMGKI(Id32<SLVANOSNYVT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x53B2640", Offset = "0x53B1040", VA = "0x1853B2640")]
			private void GTVRKJQLVJP([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x53B3EC0", Offset = "0x53B28C0", VA = "0x1853B3EC0")]
			private void PBXDBJQFXPU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x10BB5A0", Offset = "0x10B9FA0", VA = "0x1810BB5A0", Slot = "97")]
			private void IQOBRDACLJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x53B5030", Offset = "0x53B3A30", VA = "0x1853B5030", Slot = "99")]
			private void XJNCKFQOGDU(Id32<SLVANOSNYVT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F5BB10", Offset = "0x4F5A510", VA = "0x184F5BB10", Slot = "101")]
			private void FCCNQZQAVWD(Id32<SLVANOSNYVT> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x53B4170", Offset = "0x53B2B70", VA = "0x1853B4170", Slot = "103")]
			private void QSPJBBNZIBT(Id32<SLVANOSNYVT> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x53B42B0", Offset = "0x53B2CB0", VA = "0x1853B42B0", Slot = "104")]
			private void RWTPHOCFEAZ(Id32<SLVANOSNYVT> sourceId, Id32<SLVANOSNYVT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x53B1860", Offset = "0x53B0260", VA = "0x1853B1860", Slot = "105")]
			private void AVVFNQDUSAG(Id32<SLVANOSNYVT> sourceId, Id32<SLVANOSNYVT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x176D6E0", Offset = "0x176C0E0", VA = "0x18176D6E0", Slot = "98")]
			private void HADTVTSODWR(Id32<SLVANOSNYVT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x53B3120", Offset = "0x53B1B20", VA = "0x1853B3120", Slot = "100")]
			private void JMOPQSFJLRY(Id32<SLVANOSNYVT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x53B3F80", Offset = "0x53B2980", VA = "0x1853B3F80", Slot = "102")]
			private void PDDGCCYCEKY(Id32<SLVANOSNYVT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x53B4CD0", Offset = "0x53B36D0", VA = "0x1853B4CD0", Slot = "106")]
			private void VFWNFZKOQFE(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x53B2800", Offset = "0x53B1200", VA = "0x1853B2800", Slot = "150")]
			[AsyncStateMachine(typeof(DJHXDSZWRBQ<>.<RequestNameChange>d__224))]
			public Task<Result<None, LSNRXVKTUTI>> HLAULJUPTSI(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x53B1940", Offset = "0x53B0340", VA = "0x1853B1940", Slot = "57")]
			private void CVIMNVTWGZI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x53B3CA0", Offset = "0x53B26A0", VA = "0x1853B3CA0", Slot = "58")]
			private void MWEGJOALLHD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x53B1740", Offset = "0x53B0140", VA = "0x1853B1740", Slot = "30")]
			private bool AHNELGKWFKP([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x53B1830", Offset = "0x53B0230", VA = "0x1853B1830", Slot = "32")]
			private bool ZLVQXBKEWFI([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x53B5760", Offset = "0x53B4160", VA = "0x1853B5760", Slot = "51")]
			private bool ZCRPCYSBLTE([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xD1DDA0", Offset = "0xD1C7A0", VA = "0x180D1DDA0")]
			[CompilerGenerated]
			private string LAIFNSTJEKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x53B38D0", Offset = "0x53B22D0", VA = "0x1853B38D0")]
			[CompilerGenerated]
			private void LANMKZNGNVJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class RJGXUMUMTHF : XZGCCFHKIWU<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xF4F9B0", Offset = "0xF4E3B0", VA = "0x180F4F9B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2B7C340", Offset = "0x2B7AD40", VA = "0x182B7C340")]
			public RJGXUMUMTHF(WVKEVWTACCJ a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class GLGXESRKRSX : DJHXDSZWRBQ<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GTSNPDTJHHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public GLGXESRKRSX TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> WMVHFMKGAMW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> DHUTGWSXNEW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B78D10", Offset = "0x2B77710", VA = "0x182B78D10")]
				internal int DAXDMWYHHED()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B79070", Offset = "0x2B77A70", VA = "0x182B79070")]
				internal void DBCKKDSEQPM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B71D90", Offset = "0x2B70790", VA = "0x182B71D90")]
			public GLGXESRKRSX(WVKEVWTACCJ a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B71AB0", Offset = "0x2B704B0", VA = "0x182B71AB0", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class YFFDCDTRSVX : GVLKCNAFYYF<ZEQQZNTFFEW>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B86FD0", Offset = "0x2B859D0", VA = "0x182B86FD0")]
			public YFFDCDTRSVX(WVKEVWTACCJ a, ZEQQZNTFFEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class TXATXDAPSGD : DJHXDSZWRBQ<NIMNCDQSNFC>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public TXATXDAPSGD TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D110", Offset = "0x2B6BB10", VA = "0x182B6D110")]
				internal bool DARWPQEJXSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B6D4F0", Offset = "0x2B6BEF0", VA = "0x182B6D4F0")]
				internal void DAXDMWYHHED(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B7DC50", Offset = "0x2B7C650", VA = "0x182B7DC50")]
			public TXATXDAPSGD(WVKEVWTACCJ a, NIMNCDQSNFC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B7DA80", Offset = "0x2B7C480", VA = "0x182B7DA80", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class BIGEIQOSRKM : DJHXDSZWRBQ<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
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
					public KMORFLEWRJL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x2B834E0", Offset = "0x2B81EE0", VA = "0x182B834E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x2B83710", Offset = "0x2B82110", VA = "0x182B83710", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NBAVWHMPXBY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public BIGEIQOSRKM TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> DDFDYAHSSVG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> WLKHWXRWLFG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B78BE0", Offset = "0x2B775E0", VA = "0x182B78BE0")]
				internal int DAXDMWYHHED()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B79250", Offset = "0x2B77C50", VA = "0x182B79250")]
				internal void DBCKKDSEQPM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B79430", Offset = "0x2B77E30", VA = "0x182B79430")]
				internal int DBHRHKMCAAV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B786C0", Offset = "0x2B770C0", VA = "0x182B786C0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> CZWVAPCULZK(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B78260", Offset = "0x2B76C60", VA = "0x182B78260")]
				internal int ARQHXSAEGMC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B79750", Offset = "0x2B78150", VA = "0x182B79750")]
				internal void HNQKHKSPNDM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B797E0", Offset = "0x2B781E0", VA = "0x182B797E0")]
				internal int HNVRERMMWOV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B79670", Offset = "0x2B78070", VA = "0x182B79670")]
				internal void HNFWMXEUUGU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B79700", Offset = "0x2B78100", VA = "0x182B79700")]
				internal int HNLDKDYSDSD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B798C0", Offset = "0x2B782C0", VA = "0x182B798C0")]
				internal void HOLLWLUEYWW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B79950", Offset = "0x2B78350", VA = "0x182B79950")]
				internal int HOQSTSOCIIF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B79830", Offset = "0x2B78230", VA = "0x182B79830")]
				internal void HOAYBYGKGAE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B787C0", Offset = "0x2B771C0", VA = "0x182B787C0")]
				internal float DACBXVWRVKT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B78810", Offset = "0x2B77210", VA = "0x182B78810")]
				internal void DAHIVCQPEWC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B788A0", Offset = "0x2B772A0", VA = "0x182B788A0")]
				internal float DAMPSJKMOHL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B79590", Offset = "0x2B77F90", VA = "0x182B79590")]
				internal void DCHZTSHOVFO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2B79620", Offset = "0x2B78020", VA = "0x182B79620")]
				internal bool DCNGQZBMEQX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B78630", Offset = "0x2B77030", VA = "0x182B78630")]
				internal void ATLRZAXGNKF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2B785E0", Offset = "0x2B76FE0", VA = "0x182B785E0")]
				internal int ATGLBUDJDYW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2B78550", Offset = "0x2B76F50", VA = "0x182B78550")]
				internal void ATBEENJLUNN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2B78500", Offset = "0x2B76F00", VA = "0x182B78500")]
				internal float ASVXHGPOLCE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B78470", Offset = "0x2B76E70", VA = "0x182B78470")]
				internal void ASQQJZVRBQV(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B78420", Offset = "0x2B76E20", VA = "0x182B78420")]
				internal float ASLJMTBTSFM()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B78390", Offset = "0x2B76D90", VA = "0x182B78390")]
				internal void ASGCPMHWIUD(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B78340", Offset = "0x2B76D40", VA = "0x182B78340")]
				internal bool ASAVSFNYZIU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x2B782B0", Offset = "0x2B76CB0", VA = "0x182B782B0")]
				internal void ARVOUYUBPXL(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B6F210", Offset = "0x2B6DC10", VA = "0x182B6F210")]
			public BIGEIQOSRKM(WVKEVWTACCJ a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B6E110", Offset = "0x2B6CB10", VA = "0x182B6E110", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class YTBCLVUOZQP : XEUMHMCOXDA<RecNetImageNode>
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
				public YTBCLVUOZQP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B82D10", Offset = "0x2B81710", VA = "0x182B82D10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B87500", Offset = "0x2B85F00", VA = "0x182B87500")]
			public YTBCLVUOZQP(WVKEVWTACCJ a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B87030", Offset = "0x2B85A30", VA = "0x182B87030", Slot = "151")]
			protected override void POIMKMHGSIV(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B87430", Offset = "0x2B85E30", VA = "0x182B87430")]
			[CompilerGenerated]
			private string? QZZEFOXOPPD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B87360", Offset = "0x2B85D60", VA = "0x182B87360")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void QZTXIIDRGDU(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class QCNAPQKROEB<a> : DJHXDSZWRBQ<a> where a : notnull, TFTQDZBATID
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class JJCJYPIOSDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NBAVWHMPXBY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public QCNAPQKROEB<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> DDFDYAHSSVG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> WLKHWXRWLFG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType JHWBACRDSSM;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public JJCJYPIOSDN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> DARWPQEJXSU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x66D6780", Offset = "0x66D5180", VA = "0x1866D6780")]
				internal int DAXDMWYHHED()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x66D68A0", Offset = "0x66D52A0", VA = "0x1866D68A0")]
				internal void DBCKKDSEQPM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x66D6A90", Offset = "0x66D5490", VA = "0x1866D6A90")]
				internal void DBHRHKMCAAV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x66D65C0", Offset = "0x66D4FC0", VA = "0x1866D65C0")]
				internal void CZWVAPCULZK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x66D66D0", Offset = "0x66D50D0", VA = "0x1866D66D0")]
				internal bool DACBXVWRVKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x66D6730", Offset = "0x66D5130", VA = "0x1866D6730")]
				internal void DAHIVCQPEWC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x66D66D0", Offset = "0x66D50D0", VA = "0x1866D66D0")]
				internal bool DAMPSJKMOHL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x66D6AE0", Offset = "0x66D54E0", VA = "0x1866D6AE0")]
				internal float DCHZTSHOVFO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x66D6B10", Offset = "0x66D5510", VA = "0x1866D6B10")]
				internal void DCNGQZBMEQX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x66D6590", Offset = "0x66D4F90", VA = "0x1866D6590")]
				internal float ATLRZAXGNKF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x66D6500", Offset = "0x66D4F00", VA = "0x1866D6500")]
				internal void ATGLBUDJDYW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x66D64D0", Offset = "0x66D4ED0", VA = "0x1866D64D0")]
				internal float ATBEENJLUNN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x66D6440", Offset = "0x66D4E40", VA = "0x1866D6440")]
				internal void ASVXHGPOLCE(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType FGUOEPSMTLU
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x64625A0", Offset = "0x6460FA0", VA = "0x1864625A0")]
			public QCNAPQKROEB(WVKEVWTACCJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x75FE260", Offset = "0x75FCC60", VA = "0x1875FE260", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class PAIRRKVVXMX : DJHXDSZWRBQ<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xF42290", Offset = "0xF40C90", VA = "0x180F42290", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2B7AEA0", Offset = "0x2B798A0", VA = "0x182B7AEA0")]
			public PAIRRKVVXMX(WVKEVWTACCJ a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class IRQAWKRVYMA : HNDRUPKOTHK<RMBBMDEROPU>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x2B72840", Offset = "0x2B71240", VA = "0x182B72840")]
			public IRQAWKRVYMA(WVKEVWTACCJ a, RMBBMDEROPU b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class WCSSRPDIHVO : HNDRUPKOTHK<GYNWREYARZF>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x2B847E0", Offset = "0x2B831E0", VA = "0x182B847E0")]
			public WCSSRPDIHVO(WVKEVWTACCJ a, GYNWREYARZF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class HNDRUPKOTHK<a> : DJHXDSZWRBQ<a> where a : notnull, BHSCRLTSUGU
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
				public HNDRUPKOTHK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x4203BD0", Offset = "0x42025D0", VA = "0x184203BD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class DKHQXDBGZNW
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
					public DKHQXDBGZNW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x42028A0", Offset = "0x42012A0", VA = "0x1842028A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public DKHQXDBGZNW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x4202C80", Offset = "0x4201680", VA = "0x184202C80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public DKHQXDBGZNW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x4203340", Offset = "0x4201D40", VA = "0x184203340", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public DKHQXDBGZNW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x42038E0", Offset = "0x42022E0", VA = "0x1842038E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int SCOEDYFFAIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry OTIUJDUJPAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public HNDRUPKOTHK<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<HZZYFIUKWAB, bool> BVYFSWUGRHP;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public DKHQXDBGZNW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x53B6540", Offset = "0x53B4F40", VA = "0x1853B6540")]
				internal bool DBHRHKMCAAV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x53B6300", Offset = "0x53B4D00", VA = "0x1853B6300")]
				internal void CZWVAPCULZK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				internal string DACBXVWRVKT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x53B6370", Offset = "0x53B4D70", VA = "0x1853B6370")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.DKHQXDBGZNW.<<BuildConfigMenuInternal>b__6>d))]
				internal void DAHIVCQPEWC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x53B6430", Offset = "0x53B4E30", VA = "0x1853B6430")]
				internal int DAMPSJKMOHL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x53B6180", Offset = "0x53B4B80", VA = "0x1853B6180")]
				internal bool ASVXHGPOLCE(HZZYFIUKWAB a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x53B65A0", Offset = "0x53B4FA0", VA = "0x1853B65A0")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.DKHQXDBGZNW.<<BuildConfigMenuInternal>b__8>d))]
				internal void DCHZTSHOVFO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
				internal string ATLRZAXGNKF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x53B6240", Offset = "0x53B4C40", VA = "0x1853B6240")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.DKHQXDBGZNW.<<BuildConfigMenuInternal>b__11>d))]
				internal void ATGLBUDJDYW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x53B61A0", Offset = "0x53B4BA0", VA = "0x1853B61A0")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.DKHQXDBGZNW.<<BuildConfigMenuInternal>b__12>d))]
				internal void ATBEENJLUNN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class RPQRTZAZVHF
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x41FCB90", Offset = "0x41FB590", VA = "0x1841FCB90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x41FCF20", Offset = "0x41FB920", VA = "0x1841FCF20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x41FD2F0", Offset = "0x41FBCF0", VA = "0x1841FD2F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x41FD8D0", Offset = "0x41FC2D0", VA = "0x1841FD8D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x41FDB60", Offset = "0x41FC560", VA = "0x1841FDB60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x41FDEF0", Offset = "0x41FC8F0", VA = "0x1841FDEF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x41FE280", Offset = "0x41FCC80", VA = "0x1841FE280", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x41FE510", Offset = "0x41FCF10", VA = "0x1841FE510", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x41FE8A0", Offset = "0x41FD2A0", VA = "0x1841FE8A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x41FEC30", Offset = "0x41FD630", VA = "0x1841FEC30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x41FEFC0", Offset = "0x41FD9C0", VA = "0x1841FEFC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x41FF250", Offset = "0x41FDC50", VA = "0x1841FF250", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x41FF5E0", Offset = "0x41FDFE0", VA = "0x1841FF5E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x41FF870", Offset = "0x41FE270", VA = "0x1841FF870", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x41FFC00", Offset = "0x41FE600", VA = "0x1841FFC00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x41FFF90", Offset = "0x41FE990", VA = "0x1841FFF90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
					public RPQRTZAZVHF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x4200320", Offset = "0x41FED20", VA = "0x184200320", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public HNDRUPKOTHK<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int SCOEDYFFAIK;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public RPQRTZAZVHF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x7654BE0", Offset = "0x76535E0", VA = "0x187654BE0")]
				internal bool RTYZFTYGPHM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x7654C40", Offset = "0x7653640", VA = "0x187654C40")]
				internal void RUEGDASDYSV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x7653E90", Offset = "0x7652890", VA = "0x187653E90")]
				internal object KCBAPWMIMAZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x7653DD0", Offset = "0x76527D0", VA = "0x187653DD0")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__13>d))]
				internal void KBVTSPSLCPQ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x7653FF0", Offset = "0x76529F0", VA = "0x187653FF0")]
				internal string KCLOKKADEXR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x7653F30", Offset = "0x7652930", VA = "0x187653F30")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__15>d))]
				internal void KCGHNDGFVMI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x7654120", Offset = "0x7652B20", VA = "0x187654120")]
				internal bool KCWCEXNXXUJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x7654090", Offset = "0x7652A90", VA = "0x187654090")]
				internal bool KCQVHQUAOJA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x7654250", Offset = "0x7652C50", VA = "0x187654250")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__18>d))]
				internal void KDGPZLBSQRB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x76541A0", Offset = "0x7652BA0", VA = "0x1876541A0")]
				internal int KDBJCEHVHFS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x7654440", Offset = "0x7652E40", VA = "0x187654440")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__20>d))]
				internal void QGBJCWLZZWQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x76544F0", Offset = "0x7652EF0", VA = "0x1876544F0")]
				internal bool QGGQADFXJHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x7654580", Offset = "0x7652F80", VA = "0x187654580")]
				internal float QGLWXJZUSTI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x7654630", Offset = "0x7653030", VA = "0x187654630")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__23>d))]
				internal void QGRDUQTSCER(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x76546F0", Offset = "0x76530F0", VA = "0x1876546F0")]
				internal bool QGWKRXNPLQA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x7654780", Offset = "0x7653180", VA = "0x187654780")]
				internal bool QHBRPEHMVBJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x7654810", Offset = "0x7653210", VA = "0x187654810")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__26>d))]
				internal void QHGYMLBKEMS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x76548C0", Offset = "0x76532C0", VA = "0x1876548C0")]
				internal int QHMFJRVHNYB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x7654300", Offset = "0x7652D00", VA = "0x187654300")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__28>d))]
				internal void QELFYUIVCJW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x76543B0", Offset = "0x7652DB0", VA = "0x1876543B0")]
				internal bool QEQMWBCSLVF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x7655270", Offset = "0x7653C70", VA = "0x187655270")]
				internal float WGUPOGVCDSR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x76551B0", Offset = "0x7653BB0", VA = "0x1876551B0")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__31>d))]
				internal void WGPIRABEUHI(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x7655120", Offset = "0x7653B20", VA = "0x187655120")]
				internal bool WGKBTTHHKVZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x76550A0", Offset = "0x7653AA0", VA = "0x1876550A0")]
				internal bool WGEUWMNKBKQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x76554D0", Offset = "0x7653ED0", VA = "0x1876554D0")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__34>d))]
				internal void WHPRDHWRPMB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x7655440", Offset = "0x7653E40", VA = "0x187655440")]
				internal bool WHKKGBCUGAS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x76553B0", Offset = "0x7653DB0", VA = "0x1876553B0")]
				internal bool WHFDIUIWWPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x7655300", Offset = "0x7653D00", VA = "0x187655300")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__37>d))]
				internal void WGZWLNOZNEA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x7655010", Offset = "0x7653A10", VA = "0x187655010")]
				internal int WFEMKERXGFX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x7654F60", Offset = "0x7653960", VA = "0x187654F60")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__39>d))]
				internal void WEZFMXXZWUO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x76539B0", Offset = "0x76523B0", VA = "0x1876539B0")]
				internal bool EDSDEDXVCLA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x7653A40", Offset = "0x7652440", VA = "0x187653A40")]
				internal float EDXKBKRSLWJ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x7653860", Offset = "0x7652260", VA = "0x187653860")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__42>d))]
				internal void EDHPJQKAJOI(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x7653920", Offset = "0x7652320", VA = "0x187653920")]
				internal bool EDMWGXDXSZR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x7653B60", Offset = "0x7652560", VA = "0x187653B60")]
				internal bool EENETEZKOEK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x7653BE0", Offset = "0x76525E0", VA = "0x187653BE0")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__45>d))]
				internal void EESLQLTHXPT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x7653AD0", Offset = "0x76524D0", VA = "0x187653AD0")]
				internal bool EECQYRLPVHS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x7654AA0", Offset = "0x76534A0", VA = "0x187654AA0")]
				internal bool RTOLLGKLWKU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x7654B30", Offset = "0x7653530", VA = "0x187654B30")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__3>d))]
				internal void RTTSINEJFWD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x7654DD0", Offset = "0x76537D0", VA = "0x187654DD0")]
				internal int RUUAUUZWBAW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x7654E60", Offset = "0x7653860", VA = "0x187654E60")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__5>d))]
				internal void RUZHSBTTKMF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x7654CB0", Offset = "0x76536B0", VA = "0x187654CB0")]
				internal bool RUJNAHMBIEE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x7654D40", Offset = "0x7653740", VA = "0x187654D40")]
				internal bool RUOTXOFYRPN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x7654950", Offset = "0x7653350", VA = "0x187654950")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__8>d))]
				internal void RSIWBRVBRUS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x7654A00", Offset = "0x7653400", VA = "0x187654A00")]
				internal int RSOCYYOZBGB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x7653D20", Offset = "0x7652720", VA = "0x187653D20")]
				[AsyncStateMachine(typeof(HNDRUPKOTHK<>.RPQRTZAZVHF.<<AddConstraintOptions>b__10>d))]
				internal void KBQMVIYNTEH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x7653C90", Offset = "0x7652690", VA = "0x187653C90")]
				internal bool KBLFYCEQJSY()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> ZPHLRDFHIQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> OEQWKUCFYPF;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<HZZYFIUKWAB> HOOUYZFPFVP
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x651C2F0", Offset = "0x651ACF0", VA = "0x18651C2F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x651EC50", Offset = "0x651D650", VA = "0x18651EC50")]
			public HNDRUPKOTHK(WVKEVWTACCJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x651C240", Offset = "0x651AC40", VA = "0x18651C240", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x651DBC0", Offset = "0x651C5C0", VA = "0x18651DBC0", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x651C450", Offset = "0x651AE50", VA = "0x18651C450")]
			private NOEMDSCOVZL UOMDNWCXVIQ(BBYVCMSUUDJ a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x651C340", Offset = "0x651AD40", VA = "0x18651C340")]
			[AsyncStateMachine(typeof(HNDRUPKOTHK<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void UKKEKONRTVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x651C3F0", Offset = "0x651ADF0", VA = "0x18651C3F0")]
			[CompilerGenerated]
			private bool UKZZCIVJWDL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class AKVTMVGSAKQ : DJHXDSZWRBQ<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class WNSCYXRXLPE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public AKVTMVGSAKQ TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public WNSCYXRXLPE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x2B851C0", Offset = "0x2B83BC0", VA = "0x182B851C0")]
				internal int DAXDMWYHHED()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x2B85210", Offset = "0x2B83C10", VA = "0x182B85210")]
				internal void DBCKKDSEQPM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? IFGCCXFJPDT;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x2B6CB20", Offset = "0x2B6B520", VA = "0x182B6CB20")]
			public AKVTMVGSAKQ(WVKEVWTACCJ a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x2B6C7C0", Offset = "0x2B6B1C0", VA = "0x182B6C7C0", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class VEBTMOYDNEI : QCNAPQKROEB<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType FGUOEPSMTLU
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x2B84780", Offset = "0x2B83180", VA = "0x182B84780")]
			public VEBTMOYDNEI(WVKEVWTACCJ a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class TYIQMSNTYPV : GVLKCNAFYYF<JMDPHAPONXS>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x2B7DD50", Offset = "0x2B7C750", VA = "0x182B7DD50")]
			public TYIQMSNTYPV(WVKEVWTACCJ a, JMDPHAPONXS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class MBJJTDYUQES : GVLKCNAFYYF<BZZIWXJKIML>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A080", Offset = "0x2B78A80", VA = "0x182B7A080")]
			public MBJJTDYUQES(WVKEVWTACCJ a, BZZIWXJKIML b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class SKEXUHKBJJQ : XEUMHMCOXDA<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
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
					public BGYUSPZXLWP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x2B82A00", Offset = "0x2B81400", VA = "0x182B82A00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public SKEXUHKBJJQ TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x2B6E040", Offset = "0x2B6CA40", VA = "0x182B6E040")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void RQHRHALQWTP(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x2B7D2C0", Offset = "0x2B7BCC0", VA = "0x182B7D2C0")]
			public SKEXUHKBJJQ(WVKEVWTACCJ a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x2B7CFC0", Offset = "0x2B7B9C0", VA = "0x182B7CFC0", Slot = "151")]
			protected override void POIMKMHGSIV(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class CKTJEYRLKOV : QCNAPQKROEB<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType FGUOEPSMTLU
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xD95C00", Offset = "0xD94600", VA = "0x180D95C00", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x2B70C40", Offset = "0x2B6F640", VA = "0x182B70C40")]
			public CKTJEYRLKOV(WVKEVWTACCJ a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class WDXPMVCBEKY : DJHXDSZWRBQ<MMPEAKNXUNG>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xF3CBC0", Offset = "0xF3B5C0", VA = "0x180F3CBC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B84840", Offset = "0x2B83240", VA = "0x182B84840")]
			public WDXPMVCBEKY(WVKEVWTACCJ a, MMPEAKNXUNG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class HCUBNDJGKGD : DJHXDSZWRBQ<RYXRHQQZQXC>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool YAOMKUOAKOK
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B723E0", Offset = "0x2B70DE0", VA = "0x182B723E0")]
			public HCUBNDJGKGD(WVKEVWTACCJ a, RYXRHQQZQXC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B72090", Offset = "0x2B70A90", VA = "0x182B72090", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B723A0", Offset = "0x2B70DA0", VA = "0x182B723A0")]
			private int VZOCCBLDIAL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B72020", Offset = "0x2B70A20", VA = "0x182B72020")]
			private void NTGMEPRHPFR(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class PLYXVZHWELU : POLLFTLQJPP
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B7B4B0", Offset = "0x2B79EB0", VA = "0x182B7B4B0")]
			public PLYXVZHWELU(WVKEVWTACCJ a, QQDUHQODGUC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class RLCORDDBXZS : DJHXDSZWRBQ<WLLRODZLHFL>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class KMORFLEWRJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public RLCORDDBXZS TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public KMORFLEWRJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B788F0", Offset = "0x2B772F0", VA = "0x182B788F0")]
				internal int DARWPQEJXSU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B78B40", Offset = "0x2B77540", VA = "0x182B78B40")]
				internal void DAXDMWYHHED(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B79200", Offset = "0x2B77C00", VA = "0x182B79200")]
				internal int DBCKKDSEQPM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B79390", Offset = "0x2B77D90", VA = "0x182B79390")]
				internal void DBHRHKMCAAV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xD4A040", Offset = "0xD48A40", VA = "0x180D4A040", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B7C6B0", Offset = "0x2B7B0B0", VA = "0x182B7C6B0")]
			public RLCORDDBXZS(WVKEVWTACCJ a, WLLRODZLHFL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B7C3A0", Offset = "0x2B7ADA0", VA = "0x182B7C3A0", Slot = "145")]
			protected sealed override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class DLMTANDAKSJ : XEUMHMCOXDA<GUHQKSTECGC>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B70CA0", Offset = "0x2B6F6A0", VA = "0x182B70CA0")]
			public DLMTANDAKSJ(WVKEVWTACCJ a, GUHQKSTECGC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class XEUMHMCOXDA<a> : DJHXDSZWRBQ<a> where a : notnull, GUHQKSTECGC
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class EPVSEXAORWC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public XEUMHMCOXDA<a> TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public EPVSEXAORWC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x5B4F4C0", Offset = "0x5B4DEC0", VA = "0x185B4F4C0")]
				internal bool DARWPQEJXSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x5B4F4F0", Offset = "0x5B4DEF0", VA = "0x185B4F4F0")]
				internal void DAXDMWYHHED(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x5B4F580", Offset = "0x5B4DF80", VA = "0x185B4F580")]
				internal bool DBCKKDSEQPM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x5B4F5B0", Offset = "0x5B4DFB0", VA = "0x185B4F5B0")]
				internal void DBHRHKMCAAV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x5B4F450", Offset = "0x5B4DE50", VA = "0x185B4F450")]
				internal bool CZWVAPCULZK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class ACWIPAVUBWN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public LGEKONOLGQZ GDMAJGVZIPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public XEUMHMCOXDA<a> TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public ACWIPAVUBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x7212210", Offset = "0x7210C10", VA = "0x187212210")]
				internal void RQHRHALQWTP(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xD7C920", Offset = "0xD7B320", VA = "0x180D7C920", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x5118D00", Offset = "0x5117700", VA = "0x185118D00", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x5118BF0", Offset = "0x51175F0", VA = "0x185118BF0")]
			protected XEUMHMCOXDA(WVKEVWTACCJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x5118440", Offset = "0x5116E40", VA = "0x185118440", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x5118870", Offset = "0x5117270", VA = "0x185118870", Slot = "145")]
			protected override void USGHEZZYPTU(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x5118540", Offset = "0x5116F40", VA = "0x185118540", Slot = "151")]
			protected virtual void POIMKMHGSIV(BBYVCMSUUDJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x5118830", Offset = "0x5117230", VA = "0x185118830", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B59E50", Offset = "0x2B58850", VA = "0x182B59E50")]
		public static JBOFPJQGWHN New(WVKEVWTACCJ circuitsManager, QQDUHQODGUC node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class UYEGHDBJEEN : BWLKBSEDFQH, RVVOEOTHFNY, OYFUCBVVEZS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<SYPXNPTSRKI> LXZBZPPPUDK
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xF39480", Offset = "0xF37E80", VA = "0x180F39480", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<SYPXNPTSRKI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<HEUBCRFOLEU> UPIIKKDMCET
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x154D290", Offset = "0x154BC90", VA = "0x18154D290", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<HEUBCRFOLEU>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2402FD0", Offset = "0x24019D0", VA = "0x182402FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<MMHQXLWOJFR> OQEGVIOKIHF
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x1486010", Offset = "0x1484A10", VA = "0x181486010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<KSZBOHEYNRE> NRJLNJAXMBP
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B84490", Offset = "0x2B82E90", VA = "0x182B84490", Slot = "22")]
			get
			{
				return default(Id32<KSZBOHEYNRE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B844E0", Offset = "0x2B82EE0", VA = "0x182B844E0")]
		private UYEGHDBJEEN(WVKEVWTACCJ a, QQDUHQODGUC b, IEKLVVISKNW c, Id32<SLVANOSNYVT> portGroupId, Id32<HEUBCRFOLEU> outputId, Id32<MMHQXLWOJFR> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B84140", Offset = "0x2B82B40", VA = "0x182B84140")]
		public static UYEGHDBJEEN New(WVKEVWTACCJ circuitsManager, QQDUHQODGUC node, IEKLVVISKNW output, Id32<SLVANOSNYVT> portGroupId, Id32<MMHQXLWOJFR> outputDefId, Id32<HEUBCRFOLEU> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x2402FD0", Offset = "0x24019D0", VA = "0x182402FD0")]
		internal void VCKRFGSZBEH(Id32<HEUBCRFOLEU> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class BWLKBSEDFQH : OYFUCBVVEZS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private ETXENMGZMRL? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B79FE0", Offset = "0x2B789E0", VA = "0x182B79FE0")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B79FF0", Offset = "0x2B789F0", VA = "0x182B79FF0")]
			public ETXENMGZMRL UIAWYKZOAQJ(BWLKBSEDFQH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly QQDUHQODGUC INMMKRYBCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter AQPWNHDUGEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly SOZBDKZHXIA MASRUGISXWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<ZHRYWQMAYDW> WXFNLIGTGSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<SBKNEEHEBNY> GKZZORHHPHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool UGVCVFGEOUN;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> ZPZLEYQFONJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B70390", Offset = "0x2B6ED90", VA = "0x182B70390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind FUDMJCXWCHA
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED50", Offset = "0xD2D750", VA = "0x180D2ED50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<JNHEPOTZQDV> RYMNSBEUIGP
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B705C0", Offset = "0x2B6EFC0", VA = "0x182B705C0", Slot = "6")]
			get
			{
				return default(Id32<JNHEPOTZQDV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<JNHEPOTZQDV> ZHHVBXZBZCS
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2B6F5C0", Offset = "0x2B6DFC0", VA = "0x182B6F5C0", Slot = "7")]
			get
			{
				return default(Id128<JNHEPOTZQDV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public HZZYFIUKWAB WWTLBXWUQDW
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B70920", Offset = "0x2B6F320", VA = "0x182B70920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public QPNCTETKRGD WOADRHKBNRP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2B704D0", Offset = "0x2B6EED0", VA = "0x182B704D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected ETXENMGZMRL QUWWXOQPAYM
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B704D0", Offset = "0x2B6EED0", VA = "0x182B704D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage DHRLNYUTZTE
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B705F0", Offset = "0x2B6EFF0", VA = "0x182B705F0", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<CEDSPQRYDBL> ISUHRYTLBHO
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B6F5F0", Offset = "0x2B6DFF0", VA = "0x182B6F5F0", Slot = "9")]
			get
			{
				return default(Id128<CEDSPQRYDBL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<SLVANOSNYVT> DLUZLNPMNKV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xEE94F0", Offset = "0xEE7EF0", VA = "0x180EE94F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<SLVANOSNYVT>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1AD9140", Offset = "0x1AD7B40", VA = "0x181AD9140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<KSZBOHEYNRE> NRJLNJAXMBP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool YIMMFBKFJVY
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xF8B000", Offset = "0xF89A00", VA = "0x180F8B000", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B70AF0", Offset = "0x2B6F4F0", VA = "0x182B70AF0")]
		protected BWLKBSEDFQH(WVKEVWTACCJ a, QQDUHQODGUC b, SOZBDKZHXIA c, Id32<SLVANOSNYVT> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F610", Offset = "0x2B6E010", VA = "0x182B6F610", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F330", Offset = "0x2B6DD30", VA = "0x182B6F330", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F280", Offset = "0x2B6DC80", VA = "0x182B6F280", Slot = "14")]
		public void DIMDQBIRTDP(ZHRYWQMAYDW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B70260", Offset = "0x2B6EC60", VA = "0x182B70260", Slot = "15")]
		public void MWTLGMTUGVR(SBKNEEHEBNY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FF40", Offset = "0x2B6E940", VA = "0x182B6FF40")]
		private bool LOWTRZFYMGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F6F0", Offset = "0x2B6E0F0", VA = "0x182B6F6F0", Slot = "17")]
		public void JZEEQPZFBYV(YOBVMUZZIOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B708C0", Offset = "0x2B6F2C0", VA = "0x182B708C0", Slot = "25")]
		protected virtual void XRAWJYICFAX(YOBVMUZZIOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B70730", Offset = "0x2B6F130", VA = "0x182B70730", Slot = "20")]
		private void WEIYULGTSZK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F410", Offset = "0x2B6DE10", VA = "0x182B6F410")]
		private void EGFUBXIXNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B70940", Offset = "0x2B6F340", VA = "0x182B70940")]
		private void ZZATIBMFKJN([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B70330", Offset = "0x2B6ED30", VA = "0x182B70330", Slot = "18")]
		public void NTWCXTDQZOC(ZHRYWQMAYDW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B70560", Offset = "0x2B6EF60", VA = "0x182B70560", Slot = "19")]
		public void QTUWQRBUWNG(SBKNEEHEBNY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
		internal void WUYEXUYJIRT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B70310", Offset = "0x2B6ED10", VA = "0x182B70310")]
		internal void NBSDENJCWEG(VQEUHQUVGGC a, HZZYFIUKWAB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AD9140", Offset = "0x1AD7B40", VA = "0x181AD9140")]
		internal void KLHCOAPKQNT(Id32<SLVANOSNYVT> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class JGUOVUXHOPA : IODGEOJDMSL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class GRGIBKNDOCW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public WVKEVWTACCJ CWBZGVHVUXX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public QQDUHQODGUC KLDKEUKXHIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<SLVANOSNYVT> UKXAYYKVKSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool QSDFJGCRNQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool EECRFZCXONL;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GRGIBKNDOCW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2B71E00", Offset = "0x2B70800", VA = "0x182B71E00")]
			internal ZRCWHHAAVNK LPSNUTSFROS((int PortDescIndex, int PortIndex, RYNZYDWHOFL InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2B71EE0", Offset = "0x2B708E0", VA = "0x182B71EE0")]
			internal UYEGHDBJEEN LPXUSAMDBAB(IEKLVVISKNW a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2B7E2B0", Offset = "0x2B7CCB0", VA = "0x182B7E2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2B7E720", Offset = "0x2B7D120", VA = "0x182B7E720", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<TQQQOXOZIAW> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F9D0", Offset = "0x2B7E3D0", VA = "0x182B7F9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FD20", Offset = "0x2B7E720", VA = "0x182B7FD20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FD90", Offset = "0x2B7E790", VA = "0x182B7FD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2B80210", Offset = "0x2B7EC10", VA = "0x182B80210", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<MMHQXLWOJFR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2B80280", Offset = "0x2B7EC80", VA = "0x182B80280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2B805D0", Offset = "0x2B7EFD0", VA = "0x182B805D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2B80E00", Offset = "0x2B7F800", VA = "0x182B80E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2B81150", Offset = "0x2B7FB50", VA = "0x182B81150", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<TQQQOXOZIAW> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2B80640", Offset = "0x2B7F040", VA = "0x182B80640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2B809B0", Offset = "0x2B7F3B0", VA = "0x182B809B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<MMHQXLWOJFR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2B80A20", Offset = "0x2B7F420", VA = "0x182B80A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2B80D90", Offset = "0x2B7F790", VA = "0x182B80D90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public EECTNTBWABE type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<TQQQOXOZIAW> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2B811C0", Offset = "0x2B7FBC0", VA = "0x182B811C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2B81560", Offset = "0x2B7FF60", VA = "0x182B81560", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public EECTNTBWABE type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<MMHQXLWOJFR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2B815D0", Offset = "0x2B7FFD0", VA = "0x182B815D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2B81970", Offset = "0x2B80370", VA = "0x182B81970", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<TQQQOXOZIAW> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<TQQQOXOZIAW> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2B819E0", Offset = "0x2B803E0", VA = "0x182B819E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2B81D40", Offset = "0x2B80740", VA = "0x182B81D40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public JGUOVUXHOPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<MMHQXLWOJFR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<MMHQXLWOJFR> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private FAUMPQIMSBQ <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x2B81DB0", Offset = "0x2B807B0", VA = "0x182B81DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x2B82110", Offset = "0x2B80B10", VA = "0x182B82110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool IJZOUGBBQHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool NXZPYWQKYCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<ZJIVHHLEHRT, ZRCWHHAAVNK> YEVFHKRYHCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<ZJIVHHLEHRT, ZYTONKDQJVT> NCTWYSUHDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly QQDUHQODGUC INMMKRYBCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<HEUBCRFOLEU, UYEGHDBJEEN> JCOTGPWBDRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<HEUBCRFOLEU, RVVOEOTHFNY> DYEODKYBYIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? AVMAXVURUTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly NEPWNPKCEJD PYQWVRDUMVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<SLVANOSNYVT> DPQIWCBWDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool OXNQACMZHES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? UZJXPBXATOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? INRXLKNGFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<ZJIVHHLEHRT>>? VMWLCKEIBCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<HEUBCRFOLEU>>? RUAWGOCJAXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private IODGEOJDMSL.PortGroupIdChangeDelegate? ILVUUUUJQYC;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool KAHKINNAZBM
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B75230", Offset = "0x2B73C30", VA = "0x182B75230", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool MEWRAYZWBYL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B77790", Offset = "0x2B76190", VA = "0x182B77790", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool RYJDCWNHCZX
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B762E0", Offset = "0x2B74CE0", VA = "0x182B762E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<JNHEPOTZQDV> ZHHVBXZBZCS
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B73930", Offset = "0x2B72330", VA = "0x182B73930", Slot = "7")]
			get
			{
				return default(Id128<JNHEPOTZQDV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool AJWQTLDGEPF
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B72AB0", Offset = "0x2B714B0", VA = "0x182B72AB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<ZJIVHHLEHRT, ZYTONKDQJVT> AHNQPCHOHYH
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<ZJIVHHLEHRT, ZYTONKDQJVT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B763A0", Offset = "0x2B74DA0", VA = "0x182B763A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<CEDSPQRYDBL> ISUHRYTLBHO
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B73E10", Offset = "0x2B72810", VA = "0x182B73E10", Slot = "11")]
			get
			{
				return default(Id128<CEDSPQRYDBL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<HEUBCRFOLEU, RVVOEOTHFNY> WJRAALCBJEI
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<HEUBCRFOLEU, RVVOEOTHFNY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<SLVANOSNYVT> DLUZLNPMNKV
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x103E5C0", Offset = "0x103CFC0", VA = "0x18103E5C0", Slot = "13")]
			get
			{
				return default(Id32<SLVANOSNYVT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? CAKFBYCKMLD
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B74790", Offset = "0x2B73190", VA = "0x182B74790", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B777F0", Offset = "0x2B761F0", VA = "0x182B777F0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? JOCKUYIVTHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B76E00", Offset = "0x2B75800", VA = "0x182B76E00", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B734A0", Offset = "0x2B71EA0", VA = "0x182B734A0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<ZJIVHHLEHRT?>, Id32<ZJIVHHLEHRT?>>? MAODWLRMCMV
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B72F80", Offset = "0x2B71980", VA = "0x182B72F80", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B76C10", Offset = "0x2B75610", VA = "0x182B76C10", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<ZJIVHHLEHRT?>, Id32<ZJIVHHLEHRT?>>? KIMWFWMMHIW
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B73C70", Offset = "0x2B72670", VA = "0x182B73C70", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2B77610", Offset = "0x2B76010", VA = "0x182B77610", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<HEUBCRFOLEU?>, Id32<HEUBCRFOLEU?>>? IMMWMOQRRNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2B77320", Offset = "0x2B75D20", VA = "0x182B77320", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2B764F0", Offset = "0x2B74EF0", VA = "0x182B764F0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<HEUBCRFOLEU?>, Id32<HEUBCRFOLEU?>>? NOEMGLBRSGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2B73960", Offset = "0x2B72360", VA = "0x182B73960", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2B73040", Offset = "0x2B71A40", VA = "0x182B73040", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<ZJIVHHLEHRT?>, ZYTONKDQJVT?>? NPTPAZQHKLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2B73570", Offset = "0x2B71F70", VA = "0x182B73570", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2B76220", Offset = "0x2B74C20", VA = "0x182B76220", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<ZJIVHHLEHRT?>>? GXLEIXDFABV
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2B77890", Offset = "0x2B76290", VA = "0x182B77890", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2B73D50", Offset = "0x2B72750", VA = "0x182B73D50", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<ZJIVHHLEHRT?>, ZYTONKDQJVT?>? HQKIPTQAHUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2B76B50", Offset = "0x2B75550", VA = "0x182B76B50", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2B75A60", Offset = "0x2B74460", VA = "0x182B75A60", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<HEUBCRFOLEU?>, RVVOEOTHFNY?>? QOXUQTHDEDX
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2B75B20", Offset = "0x2B74520", VA = "0x182B75B20", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2B776D0", Offset = "0x2B760D0", VA = "0x182B776D0", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<HEUBCRFOLEU?>>? PAERFSBCRDI
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2B73870", Offset = "0x2B72270", VA = "0x182B73870", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2B77550", Offset = "0x2B75F50", VA = "0x182B77550", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<HEUBCRFOLEU?>, RVVOEOTHFNY?>? TQKJENFKTCF
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x2B755D0", Offset = "0x2B73FD0", VA = "0x182B755D0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x2B752F0", Offset = "0x2B73CF0", VA = "0x182B752F0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2B77AC0", Offset = "0x2B764C0", VA = "0x182B77AC0")]
		private JGUOVUXHOPA(bool a, WVKEVWTACCJ b, bool c, ReadOnlyIdArray<ZJIVHHLEHRT, ZRCWHHAAVNK> inputs, ReadOnlyIdArray<ZJIVHHLEHRT, ZYTONKDQJVT> inputsAsStaticInputs, QQDUHQODGUC d, ReadOnlyIdArray<HEUBCRFOLEU, UYEGHDBJEEN> outputs, ReadOnlyIdArray<HEUBCRFOLEU, RVVOEOTHFNY> outputsAsStaticOutputs, string? overrideName, NEPWNPKCEJD e, Id32<SLVANOSNYVT> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2B75BE0", Offset = "0x2B745E0", VA = "0x182B75BE0")]
		public static JGUOVUXHOPA New(bool canInteract, WVKEVWTACCJ circuitsManager, bool hasFunctionHeader, QQDUHQODGUC node, NEPWNPKCEJD portGroup, Id32<SLVANOSNYVT> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2B73100", Offset = "0x2B71B00", VA = "0x182B73100", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2B76130", Offset = "0x2B74B30", VA = "0x182B76130", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, LSNRXVKTUTI?>>? PDJQSTUFRRG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2B73F40", Offset = "0x2B72940", VA = "0x182B73F40")]
		private (UCEFSYRAUID?, int)? IQDEEQLJLVW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2B754C0", Offset = "0x2B73EC0", VA = "0x182B754C0", Slot = "58")]
		private void NDGXNQXFGWA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x23D4990", Offset = "0x23D3390", VA = "0x1823D4990", Slot = "57")]
		private void DJAEDOGRCOD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2B75690", Offset = "0x2B74090", VA = "0x182B75690", Slot = "61")]
		private void NKHSTABSXGJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2B72900", Offset = "0x2B71300", VA = "0x182B72900", Slot = "63")]
		private void BDKIJDZZGBS(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2B74830", Offset = "0x2B73230", VA = "0x182B74830", Slot = "50")]
		private void JUXEVHUGRSD(int a, Id32<ZJIVHHLEHRT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2B73D30", Offset = "0x2B72730", VA = "0x182B73D30", Slot = "54")]
		private void GYKQWYTFWQQ(int a, Id32<ZJIVHHLEHRT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2B777D0", Offset = "0x2B761D0", VA = "0x182B777D0", Slot = "49")]
		private void XZQSOGNMVRE(int a, Id32<ZJIVHHLEHRT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2B72B30", Offset = "0x2B71530", VA = "0x182B72B30", Slot = "53")]
		private void CNMZMVFNXGL(int a, Id32<ZJIVHHLEHRT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2B77950", Offset = "0x2B76350", VA = "0x182B77950", Slot = "66")]
		private void YKZTDRJLAKL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x11263D0", Offset = "0x1124DD0", VA = "0x1811263D0", Slot = "65")]
		private void XBDIIOMAFPS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2B73630", Offset = "0x2B72030", VA = "0x182B73630", Slot = "60")]
		private void EXNNAZZCIGX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x23D4990", Offset = "0x23D3390", VA = "0x1823D4990", Slot = "59")]
		private void YDCGFBFHVHA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2B74180", Offset = "0x2B72B80", VA = "0x182B74180", Slot = "62")]
		private void JFVUYRUQEQY(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2B751A0", Offset = "0x2B73BA0", VA = "0x182B751A0", Slot = "64")]
		private void LQMRVZARCIL(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2B765B0", Offset = "0x2B74FB0", VA = "0x182B765B0", Slot = "52")]
		private void QLPYGAINVZU(int a, Id32<HEUBCRFOLEU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2B73550", Offset = "0x2B71F50", VA = "0x182B73550", Slot = "56")]
		private void EHOJTYBGQWH(int a, Id32<HEUBCRFOLEU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2B74770", Offset = "0x2B73170", VA = "0x182B74770", Slot = "51")]
		private void JPZQTURGCEJ(int a, Id32<HEUBCRFOLEU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2B76EB0", Offset = "0x2B758B0", VA = "0x182B76EB0", Slot = "55")]
		private void TQKIZKRXFVI(int a, Id32<HEUBCRFOLEU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2B773E0", Offset = "0x2B75DE0", VA = "0x182B773E0", Slot = "68")]
		private void TXWBHVORPUM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x11263D0", Offset = "0x1124DD0", VA = "0x1811263D0", Slot = "67")]
		private void RORSFKMEEUZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B753B0", Offset = "0x2B73DB0", VA = "0x182B753B0", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, LSNRXVKTUTI?>>? MTMEHCITSJL(Id32<TQQQOXOZIAW> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2B73E30", Offset = "0x2B72830", VA = "0x182B73E30", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, LSNRXVKTUTI?>>? IKHUBNTUHGS(Id32<MMHQXLWOJFR> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2B73B50", Offset = "0x2B72550", VA = "0x182B73B50", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, LSNRXVKTUTI?>>? GPAOPLNIWPJ(Id32<TQQQOXOZIAW> inputDefId, Id32<TQQQOXOZIAW> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2B72990", Offset = "0x2B71390", VA = "0x182B72990", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, LSNRXVKTUTI?>>? BTSGGLZSQJY(Id32<MMHQXLWOJFR> outputDefId, Id32<MMHQXLWOJFR> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2B74680", Offset = "0x2B73080", VA = "0x182B74680", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, LSNRXVKTUTI?>>? JODBHENPKBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2B763D0", Offset = "0x2B74DD0", VA = "0x182B763D0", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, LSNRXVKTUTI>> QBMBYCMZIXK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2B74550", Offset = "0x2B72F50", VA = "0x182B74550", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, LSNRXVKTUTI>> JMTPYBWXQBR(Id32<TQQQOXOZIAW> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2B73A20", Offset = "0x2B72420", VA = "0x182B73A20", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, LSNRXVKTUTI>> GOLXUWQYKQE(Id32<MMHQXLWOJFR> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2B76CD0", Offset = "0x2B756D0", VA = "0x182B76CD0", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, LSNRXVKTUTI>> SLVBTTAXUNW(Id32<TQQQOXOZIAW> inputDefId, EECTNTBWABE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2B73740", Offset = "0x2B72140", VA = "0x182B73740", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, LSNRXVKTUTI>> FCKWJLSMJEB(Id32<MMHQXLWOJFR> outputDefId, EECTNTBWABE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2B74DE0", Offset = "0x2B737E0", VA = "0x182B74DE0")]
		internal void KLHCOAPKQNT(Id32<SLVANOSNYVT> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class SSKFXZAJUJK : IXGBGWAFRHJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface EDIRCJTODTF
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<JNHEPOTZQDV>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<JNHEPOTZQDV>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			VQEUHQUVGGC VQEUHQUVGGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> RFGVKSPIKYL(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> XUMABOWBPMO(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<KUEIBMPATGS> RVCHJSGQBMF(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<MFIDGFMFPEG> HHLBTDSPWMK(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> KCXBQXUCSZZ(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> NNYOLVZAGDE(CancellationToken a);
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
			public AsyncTaskMethodBuilder<SSKFXZAJUJK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public WVKEVWTACCJ circuitsManager;

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
			private EDIRCJTODTF <selfDeps>5__2;

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
			private KUEIBMPATGS <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private MFIDGFMFPEG <playerSaveData>5__8;

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
			private TaskAwaiter<KUEIBMPATGS> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<MFIDGFMFPEG> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<EDIRCJTODTF.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<HVIEREJNYRS> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2B7E790", Offset = "0x2B7D190", VA = "0x182B7E790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F960", Offset = "0x2B7E360", VA = "0x182B7F960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public HVIEREJNYRS HVIEREJNYRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public EWGOXCXULYO EWGOXCXULYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public QKMNXAUDNBR QKMNXAUDNBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public AMJPMKEJKQH AMJPMKEJKQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x111E6D0", Offset = "0x111D0D0", VA = "0x18111E6D0")]
		private SSKFXZAJUJK(HVIEREJNYRS a, EWGOXCXULYO b, QKMNXAUDNBR c, AMJPMKEJKQH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D340", Offset = "0x2B7BD40", VA = "0x182B7D340")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<SSKFXZAJUJK> HXZWNCDAHBR(WVKEVWTACCJ a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D320", Offset = "0x2B7BD20", VA = "0x182B7D320", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class LXKSZMFCJNW : HKSUIQJZABZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public LARFXRVRZOQ? UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x2B79EE0", Offset = "0x2B788E0", VA = "0x182B79EE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		internal LXKSZMFCJNW(WVKEVWTACCJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class QKMNXAUDNBR : LARFXRVRZOQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly HVIEREJNYRS UQGEAXTBTEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly LXKSZMFCJNW KXLAZGCQASJ;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> DKAHQVMCBFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x2B7B580", Offset = "0x2B79F80", VA = "0x182B7B580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE09060", Offset = "0xE07A60", VA = "0x180E09060")]
		public QKMNXAUDNBR(WVKEVWTACCJ a, HVIEREJNYRS b, LXKSZMFCJNW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B5C0", Offset = "0x2B79FC0", VA = "0x182B7B5C0", Slot = "5")]
		public string UOFYVULFWYF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B520", Offset = "0x2B79F20", VA = "0x182B7B520", Slot = "6")]
		public void AFRRIUNMAOY(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2B97060", Offset = "0x2B95A60", VA = "0x182B97060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2B972A0", Offset = "0x2B95CA0", VA = "0x182B972A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, LSNRXVKTUTI>> <>t__builder;

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
			private PZJVNVFLVDC[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2B97AB0", Offset = "0x2B964B0", VA = "0x182B97AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2B97E80", Offset = "0x2B96880", VA = "0x182B97E80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public PZJVNVFLVDC action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C1B0", Offset = "0x2B9ABB0", VA = "0x182B9C1B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C630", Offset = "0x2B9B030", VA = "0x182B9C630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly WNWYUXAFTQH _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		public EVRequestExtended(WNWYUXAFTQH staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2B71920", Offset = "0x2B70320", VA = "0x182B71920")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, LSNRXVKTUTI>> LUTHBMROVWT(PZJVNVFLVDC a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2B716D0", Offset = "0x2B700D0", VA = "0x182B716D0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, LSNRXVKTUTI?>>? ALKEYADFHJS(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2B71830", Offset = "0x2B70230", VA = "0x182B71830")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, LSNRXVKTUTI>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface ZXAQAILBSDB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		IXGBGWAFRHJ? UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool KEKPZHOSXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<IXGBGWAFRHJ?>? MKPIHAMKQPZ();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task CIERCNDZLYE(WVKEVWTACCJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface IXGBGWAFRHJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		HVIEREJNYRS HVIEREJNYRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		EWGOXCXULYO EWGOXCXULYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		QKMNXAUDNBR QKMNXAUDNBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		AMJPMKEJKQH AMJPMKEJKQH
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class KJOJBTWPKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95F90", Offset = "0x2B94990", VA = "0x182B95F90")]
		public static ReducerFactory<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>> OPLMILXGYNP([In] this ReducerFactory<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class IJIJKKOKDTB : RVNDFUOAHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool KEKPZHOSXCC
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x2B95010", Offset = "0x2B93A10", VA = "0x182B95010", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		internal IJIJKKOKDTB(WVKEVWTACCJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class BRHZVFSAZBG : NZEXPRIDSRH
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2B92610", Offset = "0x2B91010", VA = "0x182B92610", Slot = "4")]
		public FIIUKAXPFYT? EDABYEPQJLG(string? a, string? b, string? c, RoomDoorData.HDTPLDNTADR.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2B926A0", Offset = "0x2B910A0", VA = "0x182B926A0", Slot = "5")]
		public AWYFSBMOHUD GAEIJPNIXQS(string a, string b, List<string> c, int d, int e, int f, int g, RTFWJCKJVZZ h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x2B92770", Offset = "0x2B91170", VA = "0x182B92770", Slot = "6")]
		public RTFWJCKJVZZ SBUQBALGXII(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public BRHZVFSAZBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class IPSDSBEJJJW : ZLCREPABUWP
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
			public AsyncTaskMethodBuilder<BSRXIMSMGHS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public IPSDSBEJJJW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<IXGBGWAFRHJ?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2B97310", Offset = "0x2B95D10", VA = "0x182B97310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2B975B0", Offset = "0x2B95FB0", VA = "0x182B975B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public BSRXIMSMGHS? UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2B95960", Offset = "0x2B94360", VA = "0x182B95960", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public AMJPMKEJKQH? YVBOTFDPGWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2B951B0", Offset = "0x2B93BB0", VA = "0x182B951B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool QIGYLHUAXEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2B95580", Offset = "0x2B93F80", VA = "0x182B95580", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool DPTEPOEQTWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2B95520", Offset = "0x2B93F20", VA = "0x182B95520", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2B959E0", Offset = "0x2B943E0", VA = "0x182B959E0")]
		internal IPSDSBEJJJW(WVKEVWTACCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2B95260", Offset = "0x2B93C60", VA = "0x182B95260", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<BSRXIMSMGHS> MKPIHAMKQPZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2B955E0", Offset = "0x2B93FE0", VA = "0x182B955E0", Slot = "9")]
		public IReadOnlyDictionary<Id128<JNHEPOTZQDV>, Guid> VOVYYNFXULF(IEnumerable<FKWMEATAMCU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2B95030", Offset = "0x2B93A30", VA = "0x182B95030", Slot = "10")]
		public CircuitGraphToolMappingRegistryData DYAHVEBVFFJ(IEnumerable<FKWMEATAMCU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x2B95350", Offset = "0x2B93D50", VA = "0x182B95350")]
		public Result<CircuitsRoomData, CBUCXYTAOGI> PPZZJCTMNVB([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, CBUCXYTAOGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95230", Offset = "0x2B93C30", VA = "0x182B95230", Slot = "8")]
		private Result<CircuitsRoomData, CBUCXYTAOGI> KVWJDUCGKMW([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, CBUCXYTAOGI>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class AMJPMKEJKQH : BSRXIMSMGHS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class AGODQYMGIWG
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class BGYUSPZXLWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int TMJCCTQZAXH;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public BGYUSPZXLWP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2B925F0", Offset = "0x2B90FF0", VA = "0x182B925F0")]
				internal void LFLECCXGNNW(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2B89F20", Offset = "0x2B88920", VA = "0x182B89F20")]
			public static Result<BSRXIMSMGHS.PrepareTemplateForCloneResult, ZBHZKEAZREZ> RAMOSTMOAVV(AMJPMKEJKQH a, [In] BSRXIMSMGHS.PrepareTemplateForCloneArgs args)
			{
				return default(Result<BSRXIMSMGHS.PrepareTemplateForCloneResult, ZBHZKEAZREZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2B888B0", Offset = "0x2B872B0", VA = "0x182B888B0")]
			internal static Result<(IYTMBAFWYLS, CircuitTemplateRootData), ZBHZKEAZREZ> FIBBBUMAPNP(AMJPMKEJKQH a, CircuitTemplateRootData b, bool c, [In] Id128<JNHEPOTZQDV> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(IYTMBAFWYLS, CircuitTemplateRootData), ZBHZKEAZREZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2B89A50", Offset = "0x2B88450", VA = "0x182B89A50")]
			private static void LWMXPOKXOJF(bool a, FKWMEATAMCU b, IYTMBAFWYLS c, [In] Id128<JNHEPOTZQDV> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2B89650", Offset = "0x2B88050", VA = "0x182B89650")]
			public static void JUKMRGGQQEI(OSFDDQIVFJF a, [In] BSRXIMSMGHS.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A430", Offset = "0x2B88E30", VA = "0x182B8A430")]
			[CompilerGenerated]
			internal static bool RLYZXNBAQSZ(HVIEREJNYRS a, UEJGFSAMNOD b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x2B89EF0", Offset = "0x2B888F0", VA = "0x182B89EF0")]
			[CompilerGenerated]
			internal static bool OGTWYLVNZUM(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class HYPXLGQXXLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public AMJPMKEJKQH TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<JNHEPOTZQDV> NTFSAWYLHTC;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public HYPXLGQXXLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2B94FD0", Offset = "0x2B939D0", VA = "0x182B94FD0")]
			internal Id128<CEDSPQRYDBL> CZMNIRSUJLV(Id32<CEDSPQRYDBL> a)
			{
				return default(Id128<CEDSPQRYDBL>);
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<SYPXNPTSRKI> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<QHFBBKDJWVN> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2B97EF0", Offset = "0x2B968F0", VA = "0x182B97EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2B984C0", Offset = "0x2B96EC0", VA = "0x182B984C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<SLVANOSNYVT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<TQQQOXOZIAW> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2B98530", Offset = "0x2B96F30", VA = "0x182B98530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2B98880", Offset = "0x2B97280", VA = "0x182B98880", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<CEDSPQRYDBL>, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<MXFPFCGZOVW> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private HVIEREJNYRS <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2B98BD0", Offset = "0x2B975D0", VA = "0x182B98BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2B99000", Offset = "0x2B97A00", VA = "0x182B99000", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2B988F0", Offset = "0x2B972F0", VA = "0x182B988F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2B98B60", Offset = "0x2B97560", VA = "0x182B98B60", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2B99070", Offset = "0x2B97A70", VA = "0x182B99070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2B99260", Offset = "0x2B97C60", VA = "0x182B99260", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<JNHEPOTZQDV> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<CEDSPQRYDBL> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<CEDSPQRYDBL>> nodeIds;

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
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2B992D0", Offset = "0x2B97CD0", VA = "0x182B992D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2B99570", Offset = "0x2B97F70", VA = "0x182B99570", Slot = "5")]
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
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<JNHEPOTZQDV> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<CEDSPQRYDBL> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<CEDSPQRYDBL>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<SLVANOSNYVT>, Id32<ZJIVHHLEHRT>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<SLVANOSNYVT>, Id32<HEUBCRFOLEU>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2B995E0", Offset = "0x2B97FE0", VA = "0x182B995E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2B99BB0", Offset = "0x2B985B0", VA = "0x182B99BB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<JNHEPOTZQDV> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<CEDSPQRYDBL> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<CEDSPQRYDBL>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2B99C10", Offset = "0x2B98610", VA = "0x182B99C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2B99E20", Offset = "0x2B98820", VA = "0x182B99E20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<CEDSPQRYDBL> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<SLVANOSNYVT> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<ZJIVHHLEHRT> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2B99E90", Offset = "0x2B98890", VA = "0x182B99E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2B9A1E0", Offset = "0x2B98BE0", VA = "0x182B9A1E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<SLVANOSNYVT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<TQQQOXOZIAW> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2B9A250", Offset = "0x2B98C50", VA = "0x182B9A250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2B9A630", Offset = "0x2B99030", VA = "0x182B9A630", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2B9A6A0", Offset = "0x2B990A0", VA = "0x182B9A6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2B9A920", Offset = "0x2B99320", VA = "0x182B9A920", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<CEDSPQRYDBL> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<SLVANOSNYVT> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<HEUBCRFOLEU> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B9A990", Offset = "0x2B99390", VA = "0x182B9A990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2B9ACE0", Offset = "0x2B996E0", VA = "0x182B9ACE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2B9AD50", Offset = "0x2B99750", VA = "0x182B9AD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B090", Offset = "0x2B99A90", VA = "0x182B9B090", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B100", Offset = "0x2B99B00", VA = "0x182B9B100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B390", Offset = "0x2B99D90", VA = "0x182B9B390", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B400", Offset = "0x2B99E00", VA = "0x182B9B400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B690", Offset = "0x2B9A090", VA = "0x182B9B690", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<CEDSPQRYDBL>>, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<JNHEPOTZQDV> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<FKWMEATAMCU> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<QQDUHQODGUC>, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B700", Offset = "0x2B9A100", VA = "0x182B9B700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2B9BEB0", Offset = "0x2B9A8B0", VA = "0x182B9BEB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<JNHEPOTZQDV> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<CEDSPQRYDBL> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<CEDSPQRYDBL>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2B9BF20", Offset = "0x2B9A920", VA = "0x182B9BF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C140", Offset = "0x2B9AB40", VA = "0x182B9C140", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public AMJPMKEJKQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<JNHEPOTZQDV> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<CEDSPQRYDBL> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C6A0", Offset = "0x2B9B0A0", VA = "0x182B9C6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C8C0", Offset = "0x2B9B2C0", VA = "0x182B9C8C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly WVKEVWTACCJ VPGKPQMXGZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly HVIEREJNYRS UQGEAXTBTEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers IKMILFSNKYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly IPSDSBEJJJW UFYMFWCSYNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<CEDSPQRYDBL>, JBOFPJQGWHN> ZMPXGKIRDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<CEDSPQRYDBL>>? VTCZULEBXWD;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<JNHEPOTZQDV> FGJFEUWFBZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x2B8E520", Offset = "0x2B8CF20", VA = "0x182B8E520", Slot = "4")]
			get
			{
				return default(Id128<JNHEPOTZQDV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers GUSHPHEGUTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2B8E6E0", Offset = "0x2B8D0E0", VA = "0x182B8E6E0", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> BJJUUGYGUUC
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B91CE0", Offset = "0x2B906E0", VA = "0x182B91CE0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action TVYSBGJGSWB
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B8C9A0", Offset = "0x2B8B3A0", VA = "0x182B8C9A0", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B90100", Offset = "0x2B8EB00", VA = "0x182B90100", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> AGPTOVIGABF
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B8E900", Offset = "0x2B8D300", VA = "0x182B8E900", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B8C480", Offset = "0x2B8AE80", VA = "0x182B8C480", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2B92030", Offset = "0x2B90A30", VA = "0x182B92030")]
		public AMJPMKEJKQH(WVKEVWTACCJ a, HVIEREJNYRS b, IPSDSBEJJJW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B140", Offset = "0x2B89B40", VA = "0x182B8B140", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C460", Offset = "0x2B8AE60", VA = "0x182B8C460", Slot = "100")]
		public Id32<ZWLKOZHLTZH> JIUTJUJOSYG(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId)
		{
			return default(Id32<ZWLKOZHLTZH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3D0", Offset = "0x2B8CDD0", VA = "0x182B8E3D0", Slot = "101")]
		public Id32<YCFCZDWBOEE> OMCAAMVUZUJ(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId)
		{
			return default(Id32<YCFCZDWBOEE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B2F0", Offset = "0x2B89CF0", VA = "0x182B8B2F0", Slot = "6")]
		public (bool, bool) EOIWADKYOJY(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2B917D0", Offset = "0x2B901D0", VA = "0x182B917D0")]
		public bool XEYEEWQEAGL(Id32<JNHEPOTZQDV> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E420", Offset = "0x2B8CE20", VA = "0x182B8E420", Slot = "8")]
		public bool ORDLNGPDVFV(ZYTONKDQJVT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EAB0", Offset = "0x2B8D4B0", VA = "0x182B8EAB0", Slot = "9")]
		public bool SKOBZIBWDVM(RVVOEOTHFNY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E6F0", Offset = "0x2B8D0F0", VA = "0x182B8E6F0", Slot = "10")]
		public AbsoluteLegacyInputId? RADGBDIQYNT(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F790", Offset = "0x2B8E190", VA = "0x182B8F790", Slot = "11")]
		public AbsoluteLegacyOutputId? THCZEBUBXNG(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA30", Offset = "0x2B8E430", VA = "0x182B8FA30", Slot = "12")]
		public Id32<SYPXNPTSRKI>? UBWEQYCYJMK(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<HEUBCRFOLEU> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E680", Offset = "0x2B8D080", VA = "0x182B8E680", Slot = "13")]
		public Id32<QHFBBKDJWVN>? PYUNQXBUSUT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<ZJIVHHLEHRT> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B91340", Offset = "0x2B8FD40", VA = "0x182B91340", Slot = "14")]
		public IEnumerable<Id32<JNHEPOTZQDV>> WFFWSOFTHGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B91AE0", Offset = "0x2B904E0", VA = "0x182B91AE0", Slot = "15")]
		public IEnumerable<Id32<VESIVXUOWMV>> XJLNGTOBDNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCE0", Offset = "0x2B8C6E0", VA = "0x182B8DCE0", Slot = "22")]
		public string NWTHZHCHJWI(Id32<VESIVXUOWMV> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DD10", Offset = "0x2B8C710", VA = "0x182B8DD10", Slot = "16")]
		public Id32<VESIVXUOWMV>? NXVXVAWVUJS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B91DC0", Offset = "0x2B907C0", VA = "0x182B91DC0", Slot = "17")]
		public int YOLYHPHLHXP(Id32<VESIVXUOWMV> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ADF0", Offset = "0x2B897F0", VA = "0x182B8ADF0", Slot = "18")]
		public int BZTDQYYJEFU(Id32<VESIVXUOWMV> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D9A0", Offset = "0x2B8C3A0", VA = "0x182B8D9A0", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] MXOKAPKDQQL(Id32<VESIVXUOWMV> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FBD0", Offset = "0x2B8E5D0", VA = "0x182B8FBD0", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] UCIDBFSBICQ(Id32<VESIVXUOWMV> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x33A53C0", Offset = "0x33A3DC0", VA = "0x1833A53C0")]
		private static (CircuitTypeIdWrapper, string?)[]? JUWNVGUABMJ<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE80", Offset = "0x2B8E880", VA = "0x182B8FE80", Slot = "21")]
		public string UHIBMYVBSDK(Id32<VESIVXUOWMV> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B840", Offset = "0x2B8A240", VA = "0x182B8B840", Slot = "23")]
		public string FKXXNMXBYHP(Id32<VESIVXUOWMV> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B90160", Offset = "0x2B8EB60", VA = "0x182B90160")]
		public JBOFPJQGWHN? VHZVCWWQUSS([In] Id128<CEDSPQRYDBL> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AEC0", Offset = "0x2B898C0", VA = "0x182B8AEC0", Slot = "30")]
		public Id32<MXFPFCGZOVW> DDTCMPATSCU(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId)
		{
			return default(Id32<MXFPFCGZOVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE30", Offset = "0x2B89830", VA = "0x182B8AE30")]
		public Id32<CEDSPQRYDBL> CVNZDXPADUH(Id32<JNHEPOTZQDV> graphId, [In] Id128<CEDSPQRYDBL> legacyNodeId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E20", Offset = "0x2B8F820", VA = "0x182B90E20", Slot = "40")]
		public Id32<CEDSPQRYDBL> VTTSOEBHBUM(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BDC0", Offset = "0x2B8A7C0", VA = "0x182B8BDC0", Slot = "41")]
		public Id32<CEDSPQRYDBL> HSSCNDMJRFZ(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B9E0", Offset = "0x2B8A3E0", VA = "0x182B8B9E0")]
		public Id32<CEDSPQRYDBL>? FYGETQHVXVV(Id32<JNHEPOTZQDV> graphId, [In] Id128<CEDSPQRYDBL> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AB30", Offset = "0x2B89530", VA = "0x182B8AB30", Slot = "32")]
		public AbsoluteNodeId? ATNAERDHRCR(Id32<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA70", Offset = "0x2B8D470", VA = "0x182B8EA70", Slot = "33")]
		public long SHKIEOICXFI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BB50", Offset = "0x2B8A550", VA = "0x182B8BB50")]
		private void GOWOYMODJRM(Id128<CEDSPQRYDBL> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B90350", Offset = "0x2B8ED50", VA = "0x182B90350", Slot = "38")]
		public IEnumerable<(Id32<JNHEPOTZQDV>, Id32<CEDSPQRYDBL>)> VKWZTPDKDJW(Id32<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E6B0", Offset = "0x2B8D0B0", VA = "0x182B8E6B0", Slot = "39")]
		public Id32<QHFBBKDJWVN> PYUNQXBUSUT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<ZWLKOZHLTZH> inputIndex)
		{
			return default(Id32<QHFBBKDJWVN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA60", Offset = "0x2B8E460", VA = "0x182B8FA60", Slot = "42")]
		public Id32<SYPXNPTSRKI> UBWEQYCYJMK(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<YCFCZDWBOEE> outputIndex)
		{
			return default(Id32<SYPXNPTSRKI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD50", Offset = "0x2B8A750", VA = "0x182B8BD50")]
		private JBOFPJQGWHN? HRDTALBWYGN([In] Id128<CEDSPQRYDBL> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B90120", Offset = "0x2B8EB20", VA = "0x182B90120")]
		public QQDUHQODGUC? VFGRCCFQQBV([In] Id128<CEDSPQRYDBL> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4A0", Offset = "0x2B8CEA0", VA = "0x182B8E4A0")]
		public PHLWUXYOEFH? PCJQMTGWFHY([In] Id128<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4D0", Offset = "0x2B8CED0", VA = "0x182B8E4D0", Slot = "25")]
		public PHLWUXYOEFH? PCJQMTGWFHY(Id32<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F990", Offset = "0x2B8E390", VA = "0x182B8F990", Slot = "34")]
		public IEnumerable<NewStaticEdge> UAQHHTRKRJE(Id32<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C940", Offset = "0x2B8B340", VA = "0x182B8C940", Slot = "35")]
		public bool KRFBNOXHWKG(Id32<VESIVXUOWMV> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FEB0", Offset = "0x2B8E8B0", VA = "0x182B8FEB0", Slot = "36")]
		public IEnumerable<StableStaticEdge> UIUQRBVVVDM(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC30", Offset = "0x2B8E630", VA = "0x182B8FC30", Slot = "37")]
		public IEnumerable<StableStaticEdge> UCKGPWZDSEN(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3F0", Offset = "0x2B8CDF0", VA = "0x182B8E3F0")]
		public Id32<JNHEPOTZQDV> OQXGFYRKSQX([In] Id128<JNHEPOTZQDV> graphId)
		{
			return default(Id32<JNHEPOTZQDV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A9C0", Offset = "0x2B893C0", VA = "0x182B8A9C0")]
		public Id32<JNHEPOTZQDV>? LMPPSDPKUKD([In] Id128<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B913B0", Offset = "0x2B8FDB0", VA = "0x182B913B0")]
		private UEJGFSAMNOD? WIBIQCGIQGR([In] Id128<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4A0", Offset = "0x2B8CEA0", VA = "0x182B8E4A0")]
		private PHLWUXYOEFH? PZQZWJLCKKA([In] Id128<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AEE0", Offset = "0x2B898E0", VA = "0x182B8AEE0", Slot = "28")]
		public Id32<JNHEPOTZQDV>? DPBWHQWOWPY(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B800", Offset = "0x2B8A200", VA = "0x182B8B800", Slot = "46")]
		public Id128<JNHEPOTZQDV> EUVHWTCBUQG(Id32<JNHEPOTZQDV> graphId)
		{
			return default(Id128<JNHEPOTZQDV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B91AC0", Offset = "0x2B904C0", VA = "0x182B91AC0", Slot = "47")]
		public Id128<CEDSPQRYDBL> XFTTKQKPFJG(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId)
		{
			return default(Id128<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EA0", Offset = "0x2B908A0", VA = "0x182B91EA0", Slot = "43")]
		public IEnumerable<EECTNTBWABE> YYNDBGXHWCG(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C160", Offset = "0x2B8AB60", VA = "0x182B8C160", Slot = "44")]
		public EECTNTBWABE JITRHGQHJXB(RoomVersion a, OYFUCBVVEZS b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C4A0", Offset = "0x2B8AEA0", VA = "0x182B8C4A0")]
		public NewStaticEdge JVCDIAWAGYV(Id32<JNHEPOTZQDV> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CAF0", Offset = "0x2B8B4F0", VA = "0x182B8CAF0", Slot = "48")]
		public StableStaticEdge LBWQWCQHLGE(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C590", Offset = "0x2B8AF90", VA = "0x182B8C590", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, LSNRXVKTUTI>> JZZUOECNHVP(Id32<JNHEPOTZQDV> parentGraphId, Id32<CEDSPQRYDBL> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BDE0", Offset = "0x2B8A7E0", VA = "0x182B8BDE0", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, LSNRXVKTUTI>> HUCFLBXFOBK(Id32<JNHEPOTZQDV> parentGraphId, Id128<CEDSPQRYDBL> boardNodeId, List<Id32<CEDSPQRYDBL>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E920", Offset = "0x2B8D320", VA = "0x182B8E920", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, LSNRXVKTUTI>> SGFGMBFBXZP(Id32<JNHEPOTZQDV> parentGraphId, Id128<CEDSPQRYDBL> boardNodeId, List<Id32<CEDSPQRYDBL>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AC30", Offset = "0x2B89630", VA = "0x182B8AC30", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, LSNRXVKTUTI>> AWDPWUKRQIH(Id32<JNHEPOTZQDV> parentGraphId, Id128<CEDSPQRYDBL> boardNodeId, Id32<JNHEPOTZQDV> graphId, List<Id32<CEDSPQRYDBL>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B91B70", Offset = "0x2B90570", VA = "0x182B91B70", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<SLVANOSNYVT>, Id32<ZJIVHHLEHRT>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<SLVANOSNYVT>, Id32<HEUBCRFOLEU>)>) XZISCSYGELC(Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<SLVANOSNYVT>, Id32<ZJIVHHLEHRT>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<SLVANOSNYVT>, Id32<HEUBCRFOLEU>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BBD0", Offset = "0x2B8A5D0", VA = "0x182B8BBD0", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task HEUHRQDIWBA(Id128<JNHEPOTZQDV> legacyGraphId, Id128<CEDSPQRYDBL> boardNodeId, IReadOnlyList<Id128<CEDSPQRYDBL>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<SLVANOSNYVT>, Id32<ZJIVHHLEHRT>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<SLVANOSNYVT>, Id32<HEUBCRFOLEU>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B820", Offset = "0x2B8A220", VA = "0x182B8B820", Slot = "55")]
		public bool FCBBGKZZHLE(Id32<JNHEPOTZQDV> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE10", Offset = "0x2B89810", VA = "0x182B8AE10", Slot = "56")]
		public bool CMHBRWBFPPY(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA90", Offset = "0x2B8D490", VA = "0x182B8EA90", Slot = "57")]
		public bool SIATNERJUTR(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD20", Offset = "0x2B8A720", VA = "0x182B8BD20")]
		public Result<BSRXIMSMGHS.PrepareTemplateForCloneResult, ZBHZKEAZREZ> UKVYQCIETTJ([In] BSRXIMSMGHS.PrepareTemplateForCloneArgs args)
		{
			return default(Result<BSRXIMSMGHS.PrepareTemplateForCloneResult, ZBHZKEAZREZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C9C0", Offset = "0x2B8B3C0", VA = "0x182B8C9C0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, LSNRXVKTUTI>> KSZGZREYLPN(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DB60", Offset = "0x2B8C560", VA = "0x182B8DB60", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<CEDSPQRYDBL>, LSNRXVKTUTI>> NPJKUIMGDCC(Id32<JNHEPOTZQDV> graphId, Id32<MXFPFCGZOVW> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F650", Offset = "0x2B8E050", VA = "0x182B8F650", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> TBRJAYIKSZR(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B91450", Offset = "0x2B8FE50", VA = "0x182B91450", Slot = "62")]
		public Result<ControlPanelRootData, CBUCXYTAOGI> WXZDCPAKFQD(Id128<JNHEPOTZQDV> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, CBUCXYTAOGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA00", Offset = "0x2B8C400", VA = "0x182B8DA00", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, LSNRXVKTUTI>> NFCQJJUAJYH(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> inputNodeId, Id32<SLVANOSNYVT> inputPortGroupId, Id32<ZJIVHHLEHRT> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AFE0", Offset = "0x2B899E0", VA = "0x182B8AFE0", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, LSNRXVKTUTI>> DRSYLYYTJRA(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> outputNodeId, Id32<SLVANOSNYVT> outputPortGroupId, Id32<HEUBCRFOLEU> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B1E0", Offset = "0x2B89BE0", VA = "0x182B8B1E0", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, LSNRXVKTUTI>> EGGATNLWEPZ(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B860", Offset = "0x2B8A260", VA = "0x182B8B860", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<CEDSPQRYDBL>>, LSNRXVKTUTI>> FPQSDMGPVAM(Id128<JNHEPOTZQDV> intoGraphId, CircuitTemplateRootData a, IEnumerable<FKWMEATAMCU> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B903E0", Offset = "0x2B8EDE0", VA = "0x182B903E0", Slot = "67")]
		public CircuitsData VPHJRZKZXNI()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E870", Offset = "0x2B8D270", VA = "0x182B8E870", Slot = "68")]
		public CircuitsData SCVFMERYXVV()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F7F0", Offset = "0x2B8E1F0", VA = "0x182B8F7F0", Slot = "71")]
		public CircuitsTemplateData THUWIZSHEKY(TemplateSerializationReason a, Id32<JNHEPOTZQDV> sourceGraphId, IEnumerable<Id128<JNHEPOTZQDV>> graphIds, IEnumerable<Id128<CEDSPQRYDBL>> nodeIds, ISet<Id128<MVCTDZBQWKN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C6E0", Offset = "0x2B8B0E0", VA = "0x182B8C6E0")]
		private CircuitsTemplateData KBHCCJGROGJ(TemplateSerializationReason a, Id32<JNHEPOTZQDV> sourceGraphId, IEnumerable<Id128<JNHEPOTZQDV>> graphIds, IEnumerable<Id128<CEDSPQRYDBL>> nodeIds, ISet<Id128<MVCTDZBQWKN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E0E0", Offset = "0x2B8CAE0", VA = "0x182B8E0E0", Slot = "69")]
		public CircuitsTemplateData OANBRCLBWMD(TemplateSerializationReason a, Id32<JNHEPOTZQDV> sourceGraphId, IEnumerable<Id128<CEDSPQRYDBL>> nodeIds, IEnumerable<FKWMEATAMCU> b, ISet<Id128<MVCTDZBQWKN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DFD0", Offset = "0x2B8C9D0", VA = "0x182B8DFD0", Slot = "70")]
		public CircuitsTemplateData OANBRCLBWMD(TemplateSerializationReason a, Id32<JNHEPOTZQDV> sourceGraphId, IEnumerable<Id32<CEDSPQRYDBL>> nodeIds, IEnumerable<FKWMEATAMCU> b, ISet<Id128<MVCTDZBQWKN>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CCC0", Offset = "0x2B8B6C0", VA = "0x182B8CCC0")]
		private static IEnumerable<Id128<JNHEPOTZQDV>> LQMMUPEBOMR(IEnumerable<FKWMEATAMCU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E40", Offset = "0x2B8F840", VA = "0x182B90E40")]
		private IEnumerable<Id128<CEDSPQRYDBL>> VXFIVAPQACR(IEnumerable<FKWMEATAMCU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BA30", Offset = "0x2B8A430", VA = "0x182B8BA30", Slot = "72")]
		public List<YTJEOBZMNSE> GITXGASFSFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D1D0", Offset = "0x2B8BBD0", VA = "0x182B8D1D0")]
		public (List<YTJEOBZMNSE>, bool) MFXUMGOBXFR([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, HFOGEYCEIIA b, HCKWIMUSVHK c)
		{
			return default((List<YTJEOBZMNSE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B91FA0", Offset = "0x2B909A0", VA = "0x182B91FA0", Slot = "74")]
		public bool ZBCSDUDNMVU(Id32<JNHEPOTZQDV> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E340", Offset = "0x2B8CD40", VA = "0x182B8E340", Slot = "75")]
		public bool OIMAFFUSAMA(Id32<JNHEPOTZQDV> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B9C0", Offset = "0x2B8A3C0", VA = "0x182B8B9C0")]
		internal void FSISWKMCSWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BA10", Offset = "0x2B8A410", VA = "0x182B8BA10")]
		internal Task GACKIHIMFZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EB30", Offset = "0x2B8D530", VA = "0x182B8EB30", Slot = "76")]
		public Result<Id32<SYPXNPTSRKI>?, LSNRXVKTUTI> SPQURDYNOZV(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<QHFBBKDJWVN> inputId)
		{
			return default(Result<Id32<SYPXNPTSRKI>?, LSNRXVKTUTI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B90470", Offset = "0x2B8EE70", VA = "0x182B90470", Slot = "77")]
		public Result<Id32<QHFBBKDJWVN>?, LSNRXVKTUTI> VRYLEJRTJSP(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SYPXNPTSRKI> outputId)
		{
			return default(Result<Id32<QHFBBKDJWVN>?, LSNRXVKTUTI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BF60", Offset = "0x2B8A960", VA = "0x182B8BF60", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, LSNRXVKTUTI>> HUEIJIJMNKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E540", Offset = "0x2B8CF40", VA = "0x182B8E540", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, LSNRXVKTUTI>> PTAXJNCONIO(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B91DE0", Offset = "0x2B907E0", VA = "0x182B91DE0", Slot = "80")]
		public Id32<CEDSPQRYDBL>? YTGMUCEQFHS(Id32<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B90290", Offset = "0x2B8EC90", VA = "0x182B90290", Slot = "81")]
		public Id32<CEDSPQRYDBL>? VINGIUYAZEB(Id32<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CC30", Offset = "0x2B8B630", VA = "0x182B8CC30", Slot = "82")]
		public int LJXLYPBBTLT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C870", Offset = "0x2B8B270", VA = "0x182B8C870", Slot = "83")]
		public int KEDUQOUHWRA(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BA70", Offset = "0x2B8A470", VA = "0x182B8BA70", Slot = "84")]
		public int GLCZOOWQSTB(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C050", Offset = "0x2B8AA50", VA = "0x182B8C050", Slot = "85")]
		public int IJRPSTKWHVL(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D090", Offset = "0x2B8BA90", VA = "0x182B8D090", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, LSNRXVKTUTI>> MAVELFKJLDT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A9F0", Offset = "0x2B893F0", VA = "0x182B8A9F0", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, LSNRXVKTUTI>> APGVEIHHDNI(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B91D00", Offset = "0x2B90700", VA = "0x182B91D00", Slot = "88")]
		public int YMJMAZOWXDH(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA90", Offset = "0x2B8E490", VA = "0x182B8FA90", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, LSNRXVKTUTI>> UCFBKLGUVUH(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D840", Offset = "0x2B8C240", VA = "0x182B8D840", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, LSNRXVKTUTI>> MOLSKGUVEVO(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F4E0", Offset = "0x2B8DEE0", VA = "0x182B8F4E0", Slot = "91")]
		public bool SYVHNEQNMND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C130", Offset = "0x2B8AB30", VA = "0x182B8C130", Slot = "97")]
		public IEnumerable<Id32<XKJFYYKFODF>> JGWYDHFSZVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCC0", Offset = "0x2B8C6C0", VA = "0x182B8DCC0", Slot = "98")]
		public string? NWNLRAEFZED(Id32<XKJFYYKFODF> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C150", Offset = "0x2B8AB50", VA = "0x182B8C150", Slot = "7")]
		private bool JIADQWKKBJJ(Id32<JNHEPOTZQDV> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4A0", Offset = "0x2B8CEA0", VA = "0x182B8E4A0", Slot = "24")]
		private PHLWUXYOEFH RLZKNBSHMEC([In] Id128<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3F0", Offset = "0x2B8CDF0", VA = "0x182B8E3F0", Slot = "26")]
		private Id32<JNHEPOTZQDV> QLWFZXQCQXZ([In] Id128<JNHEPOTZQDV> graphId)
		{
			return default(Id32<JNHEPOTZQDV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A9C0", Offset = "0x2B893C0", VA = "0x182B8A9C0", Slot = "27")]
		private Id32<JNHEPOTZQDV>? AMSCGKKWIWL([In] Id128<JNHEPOTZQDV> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E750", Offset = "0x2B8D150", VA = "0x182B8E750", Slot = "29")]
		private JBOFPJQGWHN SCAPQHNKEPA([In] Id128<CEDSPQRYDBL> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE30", Offset = "0x2B89830", VA = "0x182B8AE30", Slot = "31")]
		private Id32<CEDSPQRYDBL> GRADYGWEGOH(Id32<JNHEPOTZQDV> graphId, [In] Id128<CEDSPQRYDBL> legacyNodeId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C4A0", Offset = "0x2B8AEA0", VA = "0x182B8C4A0", Slot = "45")]
		private NewStaticEdge UGUXYQMDVZH(Id32<JNHEPOTZQDV> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD20", Offset = "0x2B8A720", VA = "0x182B8BD20", Slot = "58")]
		private Result<BSRXIMSMGHS.PrepareTemplateForCloneResult, ZBHZKEAZREZ> HPWGPYSPXKL([In] BSRXIMSMGHS.PrepareTemplateForCloneArgs args)
		{
			return default(Result<BSRXIMSMGHS.PrepareTemplateForCloneResult, ZBHZKEAZREZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AD90", Offset = "0x2B89790", VA = "0x182B8AD90", Slot = "73")]
		private (List<YTJEOBZMNSE>, bool) BNDNEVZJETB([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, HFOGEYCEIIA b, HCKWIMUSVHK c)
		{
			return default((List<YTJEOBZMNSE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B790", Offset = "0x2B8A190", VA = "0x182B8B790")]
		[CompilerGenerated]
		private KJDRTCVNWEL EQSEWXQOHRK(HZZYFIUKWAB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE60", Offset = "0x2B89860", VA = "0x182B8AE60")]
		[CompilerGenerated]
		private QQDUHQODGUC IXRNTHWCNHG(Id128<CEDSPQRYDBL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE90", Offset = "0x2B89890", VA = "0x182B8AE90")]
		[CompilerGenerated]
		private UEJGFSAMNOD IXWUQOPZWSP(Id128<JNHEPOTZQDV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE60", Offset = "0x2B89860", VA = "0x182B8AE60")]
		[CompilerGenerated]
		private QQDUHQODGUC DBZZRTHHSUA(Id128<CEDSPQRYDBL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE90", Offset = "0x2B89890", VA = "0x182B8AE90")]
		[CompilerGenerated]
		private UEJGFSAMNOD DCFGPABFCFJ(Id128<JNHEPOTZQDV> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class KJDRTCVNWEL : EECTNTBWABE
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
			public AsyncTaskMethodBuilder<Result<Id32<TQQQOXOZIAW>, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public KJDRTCVNWEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<SLVANOSNYVT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<TQQQOXOZIAW>, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2B96AE0", Offset = "0x2B954E0", VA = "0x182B96AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2B96D30", Offset = "0x2B95730", VA = "0x182B96D30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<MMHQXLWOJFR>, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public KJDRTCVNWEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<JNHEPOTZQDV> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<CEDSPQRYDBL> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<SLVANOSNYVT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<MMHQXLWOJFR>, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2B96DA0", Offset = "0x2B957A0", VA = "0x182B96DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2B96FF0", Offset = "0x2B959F0", VA = "0x182B96FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly HZZYFIUKWAB BHHLMDDHFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly HVIEREJNYRS UQGEAXTBTEI;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey CGMZLBFJJSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string ZMMWBEPTIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x2B92AA0", Offset = "0x2B914A0", VA = "0x182B92AA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public HZZYFIUKWAB HZZYFIUKWAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2B95EF0", Offset = "0x2B948F0", VA = "0x182B95EF0")]
		public KJDRTCVNWEL(HZZYFIUKWAB a, HVIEREJNYRS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2B95C10", Offset = "0x2B94610", VA = "0x182B95C10", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<TQQQOXOZIAW>, LSNRXVKTUTI>> DGPHOLUEWMS(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2B95D80", Offset = "0x2B94780", VA = "0x182B95D80", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<MMHQXLWOJFR>, LSNRXVKTUTI>> SYFXHEONCAT(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class ETXENMGZMRL : QPNCTETKRGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly HZZYFIUKWAB TXYAKHNYNUJ;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<HZZYFIUKWAB> PKMMKDZHQSN;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<HZZYFIUKWAB> PLFPZVKASOW;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<HZZYFIUKWAB> XGPNSNHEFBN;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public HZZYFIUKWAB AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2B94720", Offset = "0x2B93120", VA = "0x182B94720", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2B94710", Offset = "0x2B93110", VA = "0x182B94710", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2B94770", Offset = "0x2B93170", VA = "0x182B94770", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2B94690", Offset = "0x2B93090", VA = "0x182B94690", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2B92AD0", Offset = "0x2B914D0", VA = "0x182B92AD0")]
		public bool YMUWMWJPKES(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public ETXENMGZMRL(HZZYFIUKWAB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2B92910", Offset = "0x2B91310", VA = "0x182B92910")]
		internal static TypeKey BKWYCFUXOWL(HZZYFIUKWAB a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2B92AA0", Offset = "0x2B914A0", VA = "0x182B92AA0", Slot = "3")]
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
	public readonly struct ActionDeps : OPEKJLKYGKI.RQFIBGQSQPB<PZJVNVFLVDC, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2B925A0", Offset = "0x2B90FA0", VA = "0x182B925A0", Slot = "4")]
		public int ORJHEJPRMUB(None a, PZJVNVFLVDC b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2B925C0", Offset = "0x2B90FC0", VA = "0x182B925C0", Slot = "5")]
		public PZJVNVFLVDC RCAIQKSIHBC(None a, PZJVNVFLVDC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2B924A0", Offset = "0x2B90EA0", VA = "0x182B924A0", Slot = "6")]
		public PZJVNVFLVDC AGENSBAQXGD(None a, PZJVNVFLVDC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2B924D0", Offset = "0x2B90ED0", VA = "0x182B924D0", Slot = "7")]
		public IReadOnlyList<PZJVNVFLVDC> CVAUYRTPOPP(None a, PZJVNVFLVDC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2B92550", Offset = "0x2B90F50", VA = "0x182B92550", Slot = "8")]
		public PZJVNVFLVDC[] KXCYAVZHQFS(None a, PZJVNVFLVDC b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2B92530", Offset = "0x2B90F30", VA = "0x182B92530", Slot = "9")]
		public bool JBWCYHJCXTX(None a, PZJVNVFLVDC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2B92510", Offset = "0x2B90F10", VA = "0x182B92510", Slot = "10")]
		public bool FRYZBBXVQAB(None a, PZJVNVFLVDC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B92560", Offset = "0x2B90F60", VA = "0x182B92560", Slot = "11")]
		public bool KZPXBMNGTXP(None a, PZJVNVFLVDC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2B924F0", Offset = "0x2B90EF0", VA = "0x182B924F0", Slot = "12")]
		public bool FGPJAMVQWJT(None a, PZJVNVFLVDC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2B925D0", Offset = "0x2B90FD0", VA = "0x182B925D0", Slot = "13")]
		public bool YTVTVYEHSVV(None a, PZJVNVFLVDC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2B92580", Offset = "0x2B90F80", VA = "0x182B92580", Slot = "14")]
		public bool OQGEMTHVUCS(None a, PZJVNVFLVDC b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class JUBDUCBMOQO : KGZAGFPSONW
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract XMAUPUIQGZI.EDIRCJTODTF QQSGIYSOZPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract WVKEVWTACCJ.EDIRCJTODTF CKHCKHISSXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract SSKFXZAJUJK.EDIRCJTODTF WPPKKHSNBIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ> QGRMNVKMAQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2B95BC0", Offset = "0x2B945C0", VA = "0x182B95BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.EDIRCJTODTF MQTYZCVAYDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract FAUMPQIMSBQ KMJQRCLCRZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract ZIVHGNLPODZ CEPSAYZQRJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract DNRVFIQUYRJ WGWXVQLTCSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract GPWQFBHBUSL ZZIBOIJSCGK
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract KXKYWNBNZAB KGXWIDEYNYA
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected JUBDUCBMOQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class RSQPEOYMSOS : ZBWOIOBWAFE
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
			public AsyncTaskMethodBuilder<Result<MultiResult, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<PZJVNVFLVDC> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public RSQPEOYMSOS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2B97620", Offset = "0x2B96020", VA = "0x182B97620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2B97A40", Offset = "0x2B96440", VA = "0x182B97A40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public RSQPEOYMSOS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PZJVNVFLVDC action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C3B0", Offset = "0x2B9ADB0", VA = "0x182B9C3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C5C0", Offset = "0x2B9AFC0", VA = "0x182B9C5C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly WNWYUXAFTQH ZMRHDTICSDH;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public RSQPEOYMSOS(WNWYUXAFTQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96760", Offset = "0x2B95160", VA = "0x182B96760")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, LSNRXVKTUTI>> LUTHBMROVWT(PZJVNVFLVDC a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2B96630", Offset = "0x2B95030", VA = "0x182B96630", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, LSNRXVKTUTI>> LSJOABZWVGH(IReadOnlyList<PZJVNVFLVDC> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PZJVNVFLVDC, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PZJVNVFLVDC, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2B965D0", Offset = "0x2B94FD0", VA = "0x182B965D0")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class YXCSORKAJVB
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PZJVNVFLVDC, PartialActionReassemblyDeps> TBLSZXWCOGY(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PZJVNVFLVDC, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : SOHIADOUYSY.SWYTVHETLJM<PartialActionPayload, Id128<PartialActionPayload.M>, PZJVNVFLVDC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2B963E0", Offset = "0x2B94DE0", VA = "0x182B963E0", Slot = "7")]
		public PZJVNVFLVDC MCTRWUCCJGU(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x12E34F0", Offset = "0x12E1EF0", VA = "0x1812E34F0")]
		public Id128<PartialActionPayload.M> IWDDSJYGIMK([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x10697A0", Offset = "0x10681A0", VA = "0x1810697A0")]
		public int RNNGGTNBPTE([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2B963D0", Offset = "0x2B94DD0", VA = "0x182B963D0")]
		public int KOLDNOBVLDT([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x10697A0", Offset = "0x10681A0", VA = "0x1810697A0", Slot = "4")]
		private int SODPXVESNDE([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2B963D0", Offset = "0x2B94DD0", VA = "0x182B963D0", Slot = "5")]
		private int OYQOBQRWAZL([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x12E34F0", Offset = "0x12E1EF0", VA = "0x1812E34F0", Slot = "6")]
		private Id128<PartialActionPayload.M> NZTAXUXAGTM([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, PZJVNVFLVDC, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, PZJVNVFLVDC, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B96A80", Offset = "0x2B95480", VA = "0x182B96A80")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class JLYCKJIIYOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static SnapshotReassembly<PartialInitializePayload, PZJVNVFLVDC, SnapshotReassemblyDeps> TBLSZXWCOGY(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, PZJVNVFLVDC, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : BDUODFSVHRV.SXEASNYQUUV<PartialInitializePayload, PZJVNVFLVDC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x10697B0", Offset = "0x10681B0", VA = "0x1810697B0")]
		public int MATQUHGABZS([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B96890", Offset = "0x2B95290", VA = "0x182B96890", Slot = "5")]
		public PZJVNVFLVDC WTXXBKIZDEK(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x10697B0", Offset = "0x10681B0", VA = "0x1810697B0", Slot = "4")]
		private int CYCRSVIHRCI([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class UQYCJCGXDIC : XZBQMYIZLTP, ZBHZKEAZREZ, LSNRXVKTUTI, CBUCXYTAOGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly CBUCXYTAOGI? FQJMRYMWJME;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind QZFCEIPKDTG
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xD1B430", Offset = "0xD19E30", VA = "0x180D1B430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override CBUCXYTAOGI? IIJQJNYTFQB
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CE00", Offset = "0x2B9B800", VA = "0x182B9CE00", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D030", Offset = "0x2B9BA30", VA = "0x182B9D030")]
		private UQYCJCGXDIC(PrepareTemplateForCloneErrKind a, CBUCXYTAOGI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CF00", Offset = "0x2B9B900", VA = "0x182B9CF00")]
		public static UQYCJCGXDIC TDNLZXLUKOK(CBUCXYTAOGI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CF70", Offset = "0x2B9B970", VA = "0x182B9CF70")]
		public static UQYCJCGXDIC UGLOSTWYYYE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CFD0", Offset = "0x2B9B9D0", VA = "0x182B9CFD0")]
		public static UQYCJCGXDIC XMOTHARFRGW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class UVZSFHRNPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x40A47A0", Offset = "0x40A31A0", VA = "0x1840A47A0")]
		public static Result<TOk, ZBHZKEAZREZ> HNAYFKXCYOP<TOk>([In] this Result<TOk, ZBHZKEAZREZ> self, CBUCXYTAOGI a) where TOk : notnull
		{
			return default(Result<TOk, ZBHZKEAZREZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x40A49E0", Offset = "0x40A33E0", VA = "0x1840A49E0")]
		public static Result<a?, ZBHZKEAZREZ?> MACQPLZTFJZ<a>([In] this Result<a, ZBHZKEAZREZ> self)
		{
			return default(Result<a, ZBHZKEAZREZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x40A4B30", Offset = "0x40A3530", VA = "0x1840A4B30")]
		public static Result<b?, ZBHZKEAZREZ?> UUYIDISPGDD<b>([In] this Result<b, ZBHZKEAZREZ> self)
		{
			return default(Result<b, ZBHZKEAZREZ>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface FAUMPQIMSBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YDZRUFWJMFM([In] Result<None, CBUCXYTAOGI> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class XFGOIPFKHYE
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x4123910", Offset = "0x4122310", VA = "0x184123910")]
		public static bool YDZRUFWJMFM<TOk, TErr>(this FAUMPQIMSBQ a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, CBUCXYTAOGI
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface ZIVHGNLPODZ
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		MHFTIKCGLDX PTDDOYEWTUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface DNRVFIQUYRJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor MGUQZKDZTJA(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface WSYRMSHEQZU
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface ZAMWBUKOEFT
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UYYWVAEGRFT? YWDUKCQQAUO(Id32<SLVANOSNYVT> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface RSCFJCAEDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface UYYWVAEGRFT
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RSCFJCAEDJJ? ODOWMSBNXEI(Id32<TQQQOXOZIAW> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WSYRMSHEQZU? XWTAJRMFDUT(Id32<MMHQXLWOJFR> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface GPWQFBHBUSL
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> QGQWSSTVEXJ(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface KXKYWNBNZAB
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZAMWBUKOEFT? HGRTZDYBDQI([In] Id128<SZWXGBXMTIF> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class GSUVLDGULWA
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
			public readonly List<PZJVNVFLVDC> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B928C0", Offset = "0x2B912C0", VA = "0x182B928C0")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<PZJVNVFLVDC> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2B92810", Offset = "0x2B91210", VA = "0x182B92810")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly VCLQTYTWOER<Diagnostic> SDXLXRHMXKW;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static GSUVLDGULWA UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2B94D30", Offset = "0x2B93730", VA = "0x182B94D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool VGETBZULCNC
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xE28730", Offset = "0xE27130", VA = "0x180E28730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B94D80", Offset = "0x2B93780", VA = "0x182B94D80")]
		public void YVQOPHDDPTF(HVIEREJNYRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B94A50", Offset = "0x2B93450", VA = "0x182B94A50")]
		public void UZXQOJXNJGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B94890", Offset = "0x2B93290", VA = "0x182B94890")]
		private static string? PHWPDBBUKSM([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B94F30", Offset = "0x2B93930", VA = "0x182B94F30")]
		public GSUVLDGULWA()
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
