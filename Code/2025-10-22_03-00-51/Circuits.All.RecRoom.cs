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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AB1C10", Offset = "0x2AB0210", VA = "0x182AB1C10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AB0470", Offset = "0x2AAEA70", VA = "0x182AB0470", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GCFTXZUHCVV : IDisposable, AQEGGSYDLVC, QVORLNYJFRD, WURYQYXOXPW
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class IPDZSQUTCXI : ETPODEKPKCV
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int VZVRXWXIHFQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFA00", Offset = "0x2AAE000", VA = "0x182AAFA00", Slot = "5")]
			public UHKYITKHAZL RXGNKYXJKIC(NSYQZFEHSAE.ETPODEKPKCV a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void SKOXYMLXRLM();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void FSGFCDYIJJH();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F350", Offset = "0x2A8D950", VA = "0x182A8F350", Slot = "13")]
			public virtual void HUSHVTDZFPR(GCFTXZUHCVV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFB30", Offset = "0x2AAE130", VA = "0x182AAFB30", Slot = "14")]
			public virtual void TFOEHDFCOGU(GCFTXZUHCVV a, LOHJEAGYXDY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			protected IPDZSQUTCXI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ETPODEKPKCV
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int VZVRXWXIHFQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			UHKYITKHAZL RXGNKYXJKIC(NSYQZFEHSAE.ETPODEKPKCV a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SKOXYMLXRLM();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void FSGFCDYIJJH();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void HUSHVTDZFPR(GCFTXZUHCVV a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void TFOEHDFCOGU(GCFTXZUHCVV a, LOHJEAGYXDY b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1317F40", Offset = "0x1316540", VA = "0x181317F40")]
			internal Reducer(Reducer<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class HNQJNNXCKPE : WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly HNQJNNXCKPE ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private HNQJNNXCKPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCB3EB0", Offset = "0xCB24B0", VA = "0x180CB3EB0", Slot = "4")]
			public ActionKind GCPWWWFYVDQ(LOHJEAGYXDY a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEF00", Offset = "0x2AAD500", VA = "0x182AAEF00", Slot = "5")]
			public void HUSHVTDZFPR(GCFTXZUHCVV a, LOHJEAGYXDY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF000", Offset = "0x2AAD600", VA = "0x182AAF000", Slot = "6")]
			public void TFOEHDFCOGU(GCFTXZUHCVV a, LOHJEAGYXDY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6600", Offset = "0x2AB4C00", VA = "0x182AB6600")]
			internal ReducerFactory(ReducerFactory<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2AB65B0", Offset = "0x2AB4BB0", VA = "0x182AB65B0")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : ZHESUVALAPM.TOPZKOTQWBM<LOHJEAGYXDY, GCFTXZUHCVV>
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
				public AsyncTaskMethodBuilder<Result<object?, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public GCFTXZUHCVV receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public LOHJEAGYXDY action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB7780", Offset = "0x2AB5D80", VA = "0x182AB7780", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB7960", Offset = "0x2AB5F60", VA = "0x182AB7960", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB07D60", Offset = "0xB06360", VA = "0x180B07D60", Slot = "4")]
			public Id32<CYNSIGMASWI> QTLIKVJEPND(GCFTXZUHCVV a)
			{
				return default(Id32<CYNSIGMASWI>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6670", Offset = "0x2AB4C70", VA = "0x182AB6670", Slot = "5")]
			public void GEITMXSXMKS(GCFTXZUHCVV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB66D0", Offset = "0x2AB4CD0", VA = "0x182AB66D0", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, IQRQYBTPXGA>> LGRLWYAUJJR(GCFTXZUHCVV a, LOHJEAGYXDY b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6800", Offset = "0x2AB4E00", VA = "0x182AB6800", Slot = "7")]
			public LOHJEAGYXDY[] SLNYPSMJZCL(GCFTXZUHCVV a)
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
			public AsyncTaskMethodBuilder<Result<object?, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public GCFTXZUHCVV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public LOHJEAGYXDY action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2AB79D0", Offset = "0x2AB5FD0", VA = "0x182AB79D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7BC0", Offset = "0x2AB61C0", VA = "0x182AB7BC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public GCFTXZUHCVV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2AB90F0", Offset = "0x2AB76F0", VA = "0x182AB90F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9370", Offset = "0x2AB7970", VA = "0x182AB9370", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GCFTXZUHCVV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2AB93E0", Offset = "0x2AB79E0", VA = "0x182AB93E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2AB95C0", Offset = "0x2AB7BC0", VA = "0x182AB95C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<CYNSIGMASWI> VKKLZBHXFSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer SBLGPXPBAXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 ZHCXLVXLHSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly SVUOYNNHAFU CMLBPXWYNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly QFPJTZRYEHQ.CreationArgs HMAXZCMTNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly ISSSHXRLLNN PDBRDYYKXFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly XNQVTLZGKGG SITKUJRXLVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly FZCLWMBWFCN SSOZOMADOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly SLZZBETKHFQ IRZACQDJDTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly LMWIOMDWWZE ATXAUXCEWCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly QZMNLDBHZOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly OJERRMGNAYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest JSFGOIOZVJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended KPXMRFCLWZL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal ETPODEKPKCV VLQUPKFUQCQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2AADD10", Offset = "0x2AAC310", VA = "0x182AADD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal UHKYITKHAZL AZELNYFNGCA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD920", Offset = "0x2AABF20", VA = "0x182AAD920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE040", Offset = "0x2AAC640", VA = "0x182AAE040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool DXOXKCLZKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE5D0", Offset = "0x2AACBD0", VA = "0x182AAE5D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEBC0", Offset = "0x2AAD1C0", VA = "0x182AAEBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public FUCNVLLMCPQ ISSSHXRLLNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEEC0", Offset = "0x2AAD4C0", VA = "0x182AAEEC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LHWEZEBZRXQ FZCLWMBWFCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEED0", Offset = "0x2AAD4D0", VA = "0x182AAEED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OINRVFWZVZD LMWIOMDWWZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEEF0", Offset = "0x2AAD4F0", VA = "0x182AAEEF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NKWZSYOTSHX XNQVTLZGKGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEBB0", Offset = "0x2AAD1B0", VA = "0x182AAEBB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FVXNCDDGQUX SLZZBETKHFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEEE0", Offset = "0x2AAD4E0", VA = "0x182AAEEE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public QFPJTZRYEHQ? QFPJTZRYEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEAD0", Offset = "0x2AAD0D0", VA = "0x182AAEAD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEBD0", Offset = "0x2AAD1D0", VA = "0x182AAEBD0")]
		private GCFTXZUHCVV(SVUOYNNHAFU a, Id32<CYNSIGMASWI> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, UHKYITKHAZL b, [In] QFPJTZRYEHQ.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE500", Offset = "0x2AACB00", VA = "0x182AAE500")]
		public static GCFTXZUHCVV New(SVUOYNNHAFU deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<CYNSIGMASWI> actorId, Id32<VFXBTZQLZOD> rootNetworkObjectId, MPBKAGBRDNH staticNetSys, BPLYXASFEBT dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE240", Offset = "0x2AAC840", VA = "0x182AAE240")]
		public static GCFTXZUHCVV New(SVUOYNNHAFU dependencies, [In] RegistryV2 registryV2, Id32<CYNSIGMASWI> actorId, Id32<VFXBTZQLZOD> rootNetworkObjectId, MPBKAGBRDNH staticNetSys, BPLYXASFEBT dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2AADB30", Offset = "0x2AAC130", VA = "0x182AADB30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE5E0", Offset = "0x2AACBE0", VA = "0x182AAE5E0")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, IQRQYBTPXGA>> RKZWEITOCAW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE0D0", Offset = "0x2AAC6D0", VA = "0x182AAE0D0")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, IQRQYBTPXGA>> LSQDMVJPSEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD930", Offset = "0x2AABF30", VA = "0x182AAD930")]
		internal void DMCTVCFTDXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE1C0", Offset = "0x2AAC7C0", VA = "0x182AAE1C0")]
		internal Option<LOHJEAGYXDY> MTNMAWWDUVE([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<LOHJEAGYXDY>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE060", Offset = "0x2AAC660", VA = "0x182AAE060")]
		internal bool KABLHHONSTL([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2AADEC0", Offset = "0x2AAC4C0", VA = "0x182AADEC0")]
		internal Result<LOHJEAGYXDY, IQRQYBTPXGA> IKQQZVKZZPU([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<LOHJEAGYXDY, IQRQYBTPXGA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2AADD60", Offset = "0x2AAC360", VA = "0x182AADD60")]
		private void GEITMXSXMKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AADDB0", Offset = "0x2AAC3B0", VA = "0x182AADDB0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, IQRQYBTPXGA>> HXQDHRDOLJU(LOHJEAGYXDY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE6D0", Offset = "0x2AACCD0", VA = "0x182AAE6D0")]
		private LOHJEAGYXDY[] SLNYPSMJZCL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class MSCDOKIWNIL<a> : VMQHICPCFYT, RNJMJJJPABV, OYBEQJHIRPM where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<BZFRCGZKOVF>? SDKQNYOSHRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string URFBNSFHEVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a EPIXYLBKGFW;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<BZFRCGZKOVF>? ZXJRKCACYKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2D9DFC0", Offset = "0x2D9C5C0", VA = "0x182D9DFC0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x59D7630", Offset = "0x59D5C30", VA = "0x1859D7630")]
		internal MSCDOKIWNIL([In] Id128<BZFRCGZKOVF>? lastNode, Id32<VZKYGFGMPQU>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class HOTHUIHZHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF180", Offset = "0x2AAD780", VA = "0x182AAF180")]
		public static Result<DebugExecutionResult, RNJMJJJPABV> FCNSTIFNVJO([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, RNJMJJJPABV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x38FFA40", Offset = "0x38FE040", VA = "0x1838FFA40")]
		public static Result<TOk, RNJMJJJPABV> AKJAHNSKNZO<TOk>([In] this Result<TOk, RNJMJJJPABV> self, [In] Id128<BZFRCGZKOVF>? lastNode, Id32<VZKYGFGMPQU>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, RNJMJJJPABV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface SVUOYNNHAFU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		NSYQZFEHSAE.ETPODEKPKCV AJJBGENQMJA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		GCFTXZUHCVV.ETPODEKPKCV TAMVWCNWDPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		IXJRKHRRWZM.ETPODEKPKCV KKWGCFWANYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV> HNQJNNXCKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.ETPODEKPKCV KKRRWLHBOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		GNHUSEXYYOY BVEQRGODZUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		XKMIIYNPIFP VOIUHUXOAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		WBTIGOWHAUR XVOEQIEJWDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AATAVYXKSWN KTBLMYHBMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		OYLYGLUJTWX DMLXLIZEOHM
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
	public static class UGYDWNOSWHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC880", Offset = "0x2ABAE80", VA = "0x182ABC880")]
		public static LOHJEAGYXDY DQAAQQXLKYE(this LOHJEAGYXDY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC990", Offset = "0x2ABAF90", VA = "0x182ABC990")]
		public static LOHJEAGYXDY UHCNGNQPGFF(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public GCFTXZUHCVV root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7C30", Offset = "0x2AB6230", VA = "0x182AB7C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8350", Offset = "0x2AB6950", VA = "0x182AB8350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6250", Offset = "0x2AA4850", VA = "0x182AA6250")]
		public static LOHJEAGYXDY JRSFFGJUHYQ(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6310", Offset = "0x2AA4910", VA = "0x182AA6310")]
		public static ReduceAction<ActionKind, CompressedPayload> KWEOMFIYYGJ(LOHJEAGYXDY actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6140", Offset = "0x2AA4740", VA = "0x182AA6140")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, IQRQYBTPXGA>> HXQDHRDOLJU(GCFTXZUHCVV a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7010", Offset = "0x2AA5610", VA = "0x182AA7010")]
		public static LOHJEAGYXDY JRSFFGJUHYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2AA70B0", Offset = "0x2AA56B0", VA = "0x182AA70B0")]
		public static ReduceAction<ActionKind, DestroyPayload> KWEOMFIYYGJ(LOHJEAGYXDY actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6F90", Offset = "0x2AA5590", VA = "0x182AA6F90")]
		public static Result<None, AYCQJPFKAZX> BSUKQQMCKCK(GCFTXZUHCVV a, [In] DestroyPayload self)
		{
			return default(Result<None, AYCQJPFKAZX>);
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
			public AsyncTaskMethodBuilder<Result<None, AYCQJPFKAZX>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public GCFTXZUHCVV root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, AYCQJPFKAZX> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8430", Offset = "0x2AB6A30", VA = "0x182AB8430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2AB89D0", Offset = "0x2AB6FD0", VA = "0x182AB89D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EAA2A0", Offset = "0x1EA88A0", VA = "0x181EAA2A0")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD710", Offset = "0x2AABD10", VA = "0x182AAD710")]
		public static LOHJEAGYXDY? JRSFFGJUHYQ(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD810", Offset = "0x2AABE10", VA = "0x182AAD810")]
		public static ReduceAction<ActionKind, FullInitializePayload> KWEOMFIYYGJ(LOHJEAGYXDY actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD5D0", Offset = "0x2AABBD0", VA = "0x182AAD5D0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, AYCQJPFKAZX>> HXQDHRDOLJU(GCFTXZUHCVV a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public GCFTXZUHCVV root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, IQRQYBTPXGA> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, OYBEQJHIRPM>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, OYBEQJHIRPM> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, OYBEQJHIRPM>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7EF0", Offset = "0x2AB64F0", VA = "0x182AB7EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB83C0", Offset = "0x2AB69C0", VA = "0x182AB83C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<LOHJEAGYXDY> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		private MultiPayload(IReadOnlyList<LOHJEAGYXDY> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1540", Offset = "0x2AAFB40", VA = "0x182AB1540")]
		public static LOHJEAGYXDY JRSFFGJUHYQ(IReadOnlyList<LOHJEAGYXDY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1600", Offset = "0x2AAFC00", VA = "0x182AB1600")]
		public static ReduceAction<ActionKind, MultiPayload> KWEOMFIYYGJ(LOHJEAGYXDY actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1400", Offset = "0x2AAFA00", VA = "0x182AB1400")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, IQRQYBTPXGA>> HXQDHRDOLJU(GCFTXZUHCVV a, MultiPayload b)
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
		private sealed class OGOKSBBDBET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> QRHNXLSXHJB;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGOKSBBDBET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1C90", Offset = "0x2AB0290", VA = "0x182AB1C90")]
			internal LOHJEAGYXDY IRRKEYAKXFB(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2AB2EB0", Offset = "0x2AB14B0", VA = "0x182AB2EB0")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2B50", Offset = "0x2AB1150", VA = "0x182AB2B50")]
		public static LOHJEAGYXDY JRSFFGJUHYQ(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2DB0", Offset = "0x2AB13B0", VA = "0x182AB2DB0")]
		public static LOHJEAGYXDY[] MOSZKDRYYMX(LOHJEAGYXDY a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2C60", Offset = "0x2AB1260", VA = "0x182AB2C60")]
		public static ReduceAction<ActionKind, PartialActionPayload> KWEOMFIYYGJ(LOHJEAGYXDY actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AB29C0", Offset = "0x2AB0FC0", VA = "0x182AB29C0")]
		public static Result<LOHJEAGYXDY, IQRQYBTPXGA> BSUKQQMCKCK(GCFTXZUHCVV a, [In] PartialActionPayload self)
		{
			return default(Result<LOHJEAGYXDY, IQRQYBTPXGA>);
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
			public AsyncTaskMethodBuilder<Result<bool, AYCQJPFKAZX>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public GCFTXZUHCVV root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, AYCQJPFKAZX> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, AYCQJPFKAZX>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8A40", Offset = "0x2AB7040", VA = "0x182AB8A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9080", Offset = "0x2AB7680", VA = "0x182AB9080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xE10330", Offset = "0xE0E930", VA = "0x180E10330")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2AB31F0", Offset = "0x2AB17F0", VA = "0x182AB31F0")]
		public static LOHJEAGYXDY JRSFFGJUHYQ(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2ED0", Offset = "0x2AB14D0", VA = "0x182AB2ED0")]
		public static LOHJEAGYXDY?[]? AMQQHDWIUGP(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2AB32D0", Offset = "0x2AB18D0", VA = "0x182AB32D0")]
		public static ReduceAction<ActionKind, PartialInitializePayload> KWEOMFIYYGJ(LOHJEAGYXDY actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB30C0", Offset = "0x2AB16C0", VA = "0x182AB30C0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, AYCQJPFKAZX>> HXQDHRDOLJU(GCFTXZUHCVV a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class ISSSHXRLLNN : FUCNVLLMCPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public FQWDVUUVPYF? ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFBB0", Offset = "0x2AAE1B0", VA = "0x182AAFBB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		internal ISSSHXRLLNN(GCFTXZUHCVV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class DDSRGNTUTGY : FQWDVUUVPYF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly QFPJTZRYEHQ FJIOLEKUBZY;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public DDSRGNTUTGY(GCFTXZUHCVV a, QFPJTZRYEHQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6430", Offset = "0x2AA4A30", VA = "0x182AA6430", Slot = "4")]
		public Result<DebugExecutionResult, RNJMJJJPABV> KWZLXZSSWIC(Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<RSMVXMQQIAP> inputId)
		{
			return default(Result<DebugExecutionResult, RNJMJJJPABV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2AA69E0", Offset = "0x2AA4FE0", VA = "0x182AA69E0", Slot = "5")]
		public Result<DebugExecutionResult, RNJMJJJPABV> OULZXHJNGCV(Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<EKZRYTEBJRU> outputId)
		{
			return default(Result<DebugExecutionResult, RNJMJJJPABV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class NSYQZFEHSAE : UHKYITKHAZL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface ETPODEKPKCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<IJTKDTMSILD> OBRSYXGIIPW(GCFTXZUHCVV a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class IPDZSQUTCXI : ETPODEKPKCV
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
				public AsyncTaskMethodBuilder<IJTKDTMSILD> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public GCFTXZUHCVV circuitsManager;

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
				private TaskAwaiter<IXJRKHRRWZM> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6D60", Offset = "0x2AB5360", VA = "0x182AB6D60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6F30", Offset = "0x2AB5530", VA = "0x182AB6F30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF8A0", Offset = "0x2AADEA0", VA = "0x182AAF8A0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<IJTKDTMSILD> OBRSYXGIIPW(GCFTXZUHCVV a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			protected IPDZSQUTCXI()
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
			public AsyncTaskMethodBuilder<IJTKDTMSILD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public NSYQZFEHSAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6FA0", Offset = "0x2AB55A0", VA = "0x182AB6FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB71A0", Offset = "0x2AB57A0", VA = "0x182AB71A0", Slot = "5")]
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
			public NSYQZFEHSAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public GCFTXZUHCVV circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<IJTKDTMSILD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7210", Offset = "0x2AB5810", VA = "0x182AB7210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7720", Offset = "0x2AB5D20", VA = "0x182AB7720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ETPODEKPKCV KUPOYFERZJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> IMAHAZACHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> MXKJKYHYSHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource SMOPIZOTHVV;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool DXOXKCLZKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAFD1B0", Offset = "0xAFB7B0", VA = "0x180AFD1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xFC1340", Offset = "0xFBF940", VA = "0x180FC1340", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x100E010", Offset = "0x100C610", VA = "0x18100E010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool BKDDQOIKQEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1B3AAD0", Offset = "0x1B390D0", VA = "0x181B3AAD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1B3AAE0", Offset = "0x1B390E0", VA = "0x181B3AAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IJTKDTMSILD? ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F10", Offset = "0xAAF510", VA = "0x180AB0F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB18E0", Offset = "0x2AAFEE0", VA = "0x182AB18E0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<IJTKDTMSILD> GXMEQRTYTSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1B10", Offset = "0x2AB0110", VA = "0x182AB1B10")]
		public NSYQZFEHSAE(ETPODEKPKCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB19D0", Offset = "0x2AAFFD0", VA = "0x182AB19D0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task OKLFFNMVTBU(GCFTXZUHCVV a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1770", Offset = "0x2AAFD70", VA = "0x182AB1770", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class JFZNTNLKDQV : TQDYMYBXCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly ILTKTHFNKWF BNYSTQSGZXG;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public JFZNTNLKDQV(ILTKTHFNKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class ZCHKGGOUDMK
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class APEMMZFEKVO<a> : MHPSHNFTXZN where a : HYNHSLIJNYN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a ZQKAMISYZOH;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? WGYVTXQPTIV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xF75C90", Offset = "0xF74290", VA = "0x180F75C90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<BZFRCGZKOVF>? JNLDXAKOSQR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x5617DD0", Offset = "0x56163D0", VA = "0x185617DD0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<YRJDGOUPWNL> WUDVPFIHASV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2D946C0", Offset = "0x2D92CC0", VA = "0x182D946C0", Slot = "5")]
				get
				{
					return default(Id32<YRJDGOUPWNL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<YRJDGOUPWNL>? DYWUQQHBMFH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x5617D50", Offset = "0x5616350", VA = "0x185617D50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
			public APEMMZFEKVO(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class OVOAALNSMNE : APEMMZFEKVO<KZSBGXOKPQU>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? WGYVTXQPTIV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x10A2A20", Offset = "0x10A1020", VA = "0x1810A2A20", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1E00", Offset = "0x2AB0400", VA = "0x182AB1E00")]
			public OVOAALNSMNE(KZSBGXOKPQU a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCE10", Offset = "0x2ABB410", VA = "0x182ABCE10")]
		public static MHPSHNFTXZN New(HYNHSLIJNYN graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class EHTVPVUBDIO : KFAIYKGEPER, HELHZBNXFBJ, TKNLLBEJAZY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class IXHWNYXIIJO
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
				public IXHWNYXIIJO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public GNHUSEXYYOY errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA7C0", Offset = "0x2AB8DC0", VA = "0x182ABA7C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAA30", Offset = "0x2AB9030", VA = "0x182ABAA30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public EHTVPVUBDIO CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool ZXQVAYEVMSN;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IXHWNYXIIJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFCB0", Offset = "0x2AAE2B0", VA = "0x182AAFCB0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task XWGDNSQAZMU(GNHUSEXYYOY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class JDPERVANSRK
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
				public JDPERVANSRK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAA90", Offset = "0x2AB9090", VA = "0x182ABAA90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAD70", Offset = "0x2AB9370", VA = "0x182ABAD70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public EHTVPVUBDIO CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int ZXQVAYEVMSN;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public JDPERVANSRK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFDA0", Offset = "0x2AAE3A0", VA = "0x182AAFDA0")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task LQXHMHAJPEG(GNHUSEXYYOY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class NQOOHRFIIQZ
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
				public NQOOHRFIIQZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB2E0", Offset = "0x2AB98E0", VA = "0x182ABB2E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB790", Offset = "0x2AB9D90", VA = "0x182ABB790", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string ZXQVAYEVMSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public EHTVPVUBDIO CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int RZVVUDYRCLB;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NQOOHRFIIQZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2AB16A0", Offset = "0x2AAFCA0", VA = "0x182AB16A0")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task HKUTROQUYZG(GNHUSEXYYOY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class ZRSABDSJCWS
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
				public ZRSABDSJCWS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x2ABADD0", Offset = "0x2AB93D0", VA = "0x182ABADD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB280", Offset = "0x2AB9880", VA = "0x182ABB280", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string ZXQVAYEVMSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public EHTVPVUBDIO CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int RZVVUDYRCLB;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZRSABDSJCWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2ABCF90", Offset = "0x2ABB590", VA = "0x182ABCF90")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task XWCKJSOYWPC(GNHUSEXYYOY a)
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
			public EHTVPVUBDIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9630", Offset = "0x2AB7C30", VA = "0x182AB9630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9B30", Offset = "0x2AB8130", VA = "0x182AB9B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly EBEBGUBYIAH ONFUNSZASVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<TCCETLNKNAP> RKNECVPNUPW;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private SVUOYNNHAFU IPDZSQUTCXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AAB6C0", Offset = "0x2AA9CC0", VA = "0x182AAB6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<RSMVXMQQIAP> IUWKTSZNVNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE77270", Offset = "0xE75870", VA = "0x180E77270", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<RSMVXMQQIAP>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xF6D7D0", Offset = "0xF6BDD0", VA = "0x180F6D7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<OVRKYFBGDJO> FLPMXBMBTPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A380A0", Offset = "0x2A366A0", VA = "0x182A380A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<XYCEOHQMMOR> JUJBKACTDPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x12D5420", Offset = "0x12D3A20", VA = "0x1812D5420", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<XYCEOHQMMOR>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<VZKYGFGMPQU> LKPAHBDVPEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AAA480", Offset = "0x2AA8A80", VA = "0x182AAA480", Slot = "22")]
			get
			{
				return default(Id32<VZKYGFGMPQU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool TEBGXSQZLYX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8530", Offset = "0x2AA6B30", VA = "0x182AA8530", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB6E0", Offset = "0x2AA9CE0", VA = "0x182AAB6E0")]
		private EHTVPVUBDIO(GCFTXZUHCVV a, QPBKESVYPXS b, EBEBGUBYIAH c, Id32<QKZKTYBWUBB> portGroupId, Id32<RSMVXMQQIAP> inputId, Id32<OVRKYFBGDJO> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9F40", Offset = "0x2AA8540", VA = "0x182AA9F40")]
		public static EHTVPVUBDIO New(GCFTXZUHCVV circuitsManager, QPBKESVYPXS node, EBEBGUBYIAH input, Id32<QKZKTYBWUBB> portGroupId, Id32<OVRKYFBGDJO> inputDefId, Id32<RSMVXMQQIAP> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8490", Offset = "0x2AA6A90", VA = "0x182AA8490", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7E10", Offset = "0x2AA6410", VA = "0x182AA7E10", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA4D0", Offset = "0x2AA8AD0", VA = "0x182AAA4D0", Slot = "32")]
		public void POEYAWACFXT(TCCETLNKNAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7EB0", Offset = "0x2AA64B0", VA = "0x182AA7EB0", Slot = "29")]
		public void FIZXBPVRZAS(SMIASRVRKMF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8FC0", Offset = "0x2AA75C0", VA = "0x182AA8FC0", Slot = "30")]
		public void NWSNNEOTPPP(TWGUFZQQAOX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAA00", Offset = "0x2AA9000", VA = "0x182AAAA00", Slot = "25")]
		protected override void QSEUHCVCWHT(OGWTEPJIVAO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAE10", Offset = "0x2AA9410", VA = "0x182AAAE10", Slot = "34")]
		public string UQHXVNMEZYC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7A40", Offset = "0x2AA6040", VA = "0x182AA7A40", Slot = "31")]
		public string AOCJRQCXMYK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB4A0", Offset = "0x2AA9AA0", VA = "0x182AAB4A0")]
		private void XZNDRPOYLVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA530", Offset = "0x2AA8B30", VA = "0x182AAA530", Slot = "33")]
		public void POIWLBWLHZW(TCCETLNKNAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7880", Offset = "0x2AA5E80", VA = "0x182AA7880")]
		private void AHYXWSMQHKV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7D00", Offset = "0x2AA6300", VA = "0x182AA7D00", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task AOOQWWRAJFT(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8340", Offset = "0x2AA6940", VA = "0x182AA8340")]
		public void HJWGUEOQBNW(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA2E0", Offset = "0x2AA88E0", VA = "0x182AAA2E0")]
		private void OAMVDIZXHHI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAC50", Offset = "0x2AA9250", VA = "0x182AAAC50")]
		private void TCHCQQEPDRK(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA89E0", Offset = "0x2AA6FE0", VA = "0x182AA89E0")]
		private void KILIFYHXJLJ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAF80", Offset = "0x2AA9580", VA = "0x182AAAF80")]
		private string VFLMKMWUQZG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAAE0", Offset = "0x2AA90E0", VA = "0x182AAAAE0")]
		private string SGEAEVWCHIJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF6D7D0", Offset = "0xF6BDD0", VA = "0x180F6D7D0")]
		internal void YSNJHRFYJPI(Id32<RSMVXMQQIAP> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8E00", Offset = "0x2AA7400", VA = "0x182AA8E00")]
		[CompilerGenerated]
		private void LCWXJYOUOHT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8D40", Offset = "0x2AA7340", VA = "0x182AA8D40")]
		[CompilerGenerated]
		private bool LCRQMRUXEWK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8C80", Offset = "0x2AA7280", VA = "0x182AA8C80")]
		[CompilerGenerated]
		private bool LCHCSEHCLZS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8F70", Offset = "0x2AA7570", VA = "0x182AA8F70")]
		[CompilerGenerated]
		private int LDRYYZQKABD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8EE0", Offset = "0x2AA74E0", VA = "0x182AA8EE0")]
		[CompilerGenerated]
		private bool LDMSBSWMQPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8ED0", Offset = "0x2AA74D0", VA = "0x182AA8ED0")]
		[CompilerGenerated]
		private void LDHLEMCPHEL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8E10", Offset = "0x2AA7410", VA = "0x182AA8E10")]
		[CompilerGenerated]
		private bool LDCEHFIRXTC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8C30", Offset = "0x2AA7230", VA = "0x182AA8C30")]
		[CompilerGenerated]
		private bool LBGUFWLPQUZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8BA0", Offset = "0x2AA71A0", VA = "0x182AA8BA0")]
		[CompilerGenerated]
		private bool LBBNIPRSHJQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8F70", Offset = "0x2AA7570", VA = "0x182AA8F70")]
		[CompilerGenerated]
		private int XOMWKOAPFWS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB3D0", Offset = "0x2AA99D0", VA = "0x182AAB3D0")]
		[CompilerGenerated]
		private bool XOSDHUUMPIB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB370", Offset = "0x2AA9970", VA = "0x182AAB370")]
		[CompilerGenerated]
		private object XOCIQAMUNAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA85B0", Offset = "0x2AA6BB0", VA = "0x182AA85B0")]
		[CompilerGenerated]
		private void XOHPNHGRWLJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB2A0", Offset = "0x2AA98A0", VA = "0x182AAB2A0")]
		[CompilerGenerated]
		private bool XNXBSTSXDOR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB210", Offset = "0x2AA9810", VA = "0x182AAB210")]
		[CompilerGenerated]
		private string XNHHAZLFBGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB290", Offset = "0x2AA9890", VA = "0x182AAB290")]
		[CompilerGenerated]
		private void XNMNYGFCKRZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB0C0", Offset = "0x2AA96C0", VA = "0x182AAB0C0")]
		[CompilerGenerated]
		private bool XMWTGLXKIJY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB190", Offset = "0x2AA9790", VA = "0x182AAB190")]
		[CompilerGenerated]
		private string XNCADSRHRVH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA7D0", Offset = "0x2AA8DD0", VA = "0x182AAA7D0")]
		[CompilerGenerated]
		private void QNVRLVSMQEJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA700", Offset = "0x2AA8D00", VA = "0x182AAA700")]
		[CompilerGenerated]
		private bool QNQKOOYPGTA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA680", Offset = "0x2AA8C80", VA = "0x182AAA680")]
		[CompilerGenerated]
		private string QNLDRIERXHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA670", Offset = "0x2AA8C70", VA = "0x182AAA670")]
		[CompilerGenerated]
		private void QNFWUBKUNWI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA930", Offset = "0x2AA8F30", VA = "0x182AAA930")]
		[CompilerGenerated]
		private bool QOQTAWUCBXT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA8C0", Offset = "0x2AA8EC0", VA = "0x182AAA8C0")]
		[CompilerGenerated]
		private string QOLMDQAESMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA8B0", Offset = "0x2AA8EB0", VA = "0x182AAA8B0")]
		[CompilerGenerated]
		private void QOGFGJGHJBB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA7E0", Offset = "0x2AA8DE0", VA = "0x182AAA7E0")]
		[CompilerGenerated]
		private bool QOAYJCMJZPS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA600", Offset = "0x2AA8C00", VA = "0x182AAA600")]
		[CompilerGenerated]
		private string QMFOHTPHSRP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA5F0", Offset = "0x2AA8BF0", VA = "0x182AAA5F0")]
		[CompilerGenerated]
		private void QMAHKMVKJGG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8610", Offset = "0x2AA6C10", VA = "0x182AA8610")]
		[CompilerGenerated]
		private bool JNEMNDKKAMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA86E0", Offset = "0x2AA6CE0", VA = "0x182AA86E0")]
		[CompilerGenerated]
		private string JNJTKKEHJXJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8750", Offset = "0x2AA6D50", VA = "0x182AA8750")]
		[CompilerGenerated]
		private void JNPAHQYETIS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8760", Offset = "0x2AA6D60", VA = "0x182AA8760")]
		[CompilerGenerated]
		private bool JNUHEXSCCUB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8830", Offset = "0x2AA6E30", VA = "0x182AA8830")]
		[CompilerGenerated]
		private string JNZOCELZMFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA88A0", Offset = "0x2AA6EA0", VA = "0x182AA88A0")]
		[CompilerGenerated]
		private void JOEUZLFWVQT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA88B0", Offset = "0x2AA6EB0", VA = "0x182AA88B0")]
		[CompilerGenerated]
		private bool JOKBWRZUFCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8980", Offset = "0x2AA6F80", VA = "0x182AA8980")]
		[CompilerGenerated]
		private object JOPITYTRONL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA85B0", Offset = "0x2AA6BB0", VA = "0x182AA85B0")]
		[CompilerGenerated]
		private void JLOJJBHFCZG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8270", Offset = "0x2AA6870", VA = "0x182AA8270")]
		[CompilerGenerated]
		private bool FLKKALDIEPB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class RTAMIEXOYNK
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class RTYGHQGWSFW : FVXBTFLYTRK<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public RTYGHQGWSFW CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0C60", Offset = "0x2AAF260", VA = "0x182AB0C60")]
				internal object GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0D10", Offset = "0x2AAF310", VA = "0x182AB0D10")]
				internal void GPRDWPZCBUZ(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6540", Offset = "0x2AB4B40", VA = "0x182AB6540")]
			public RTYGHQGWSFW(GCFTXZUHCVV a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2AB62D0", Offset = "0x2AB48D0", VA = "0x182AB62D0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class JGEAAQVLGWR : SNFMUNVNITV<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType MDYKABWAYZC
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFE70", Offset = "0x2AAE470", VA = "0x182AAFE70")]
			public JGEAAQVLGWR(GCFTXZUHCVV a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class PIQPZRQIAYB : FVXBTFLYTRK<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2AB21B0", Offset = "0x2AB07B0", VA = "0x182AB21B0")]
			public PIQPZRQIAYB(GCFTXZUHCVV a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2AB2050", Offset = "0x2AB0650", VA = "0x182AB2050", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1ED0", Offset = "0x2AB04D0", VA = "0x182AB1ED0")]
			[CompilerGenerated]
			private bool AAWHIYCEBDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1F20", Offset = "0x2AB0520", VA = "0x182AB1F20")]
			[CompilerGenerated]
			private void ABBOGEWBKOR(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class JUAXVURXSER : FVXBTFLYTRK<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public JUAXVURXSER CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0B20", Offset = "0x2AAF120", VA = "0x182AB0B20")]
				internal void GPLWZJFESJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1160", Offset = "0x2AAF760", VA = "0x182AB1160")]
				internal bool GPRDWPZCBUZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0950", Offset = "0x2AAEF50", VA = "0x182AB0950")]
				internal bool GPBJEVRJZMY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2AB09A0", Offset = "0x2AAEFA0", VA = "0x182AB09A0")]
				internal void GPGQCCLHIYH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2AB06A0", Offset = "0x2AAECA0", VA = "0x182AB06A0")]
				internal bool GOQVKIDPGQG()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB01E0", Offset = "0x2AAE7E0", VA = "0x182AB01E0")]
			public JUAXVURXSER(GCFTXZUHCVV a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFED0", Offset = "0x2AAE4D0", VA = "0x182AAFED0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class EBBVQYRIPLT : FVXBTFLYTRK<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public EBBVQYRIPLT CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> LHBWVQNJDZG;

				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0B70", Offset = "0x2AAF170", VA = "0x182AB0B70")]
				internal object? GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0620", Offset = "0x2AAEC20", VA = "0x182AB0620")]
				internal bool GOLONBJRXEX(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0F10", Offset = "0x2AAF510", VA = "0x182AB0F10")]
				internal void GPRDWPZCBUZ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2AB07B0", Offset = "0x2AAEDB0", VA = "0x182AB07B0")]
				internal string GPBJEVRJZMY(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0AD0", Offset = "0x2AAF0D0", VA = "0x182AB0AD0")]
				internal IReadOnlyList<object> GPGQCCLHIYH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB06F0", Offset = "0x2AAECF0", VA = "0x182AB06F0")]
				internal bool GOQVKIDPGQG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0760", Offset = "0x2AAED60", VA = "0x182AB0760")]
				internal bool GOWCHOXMQBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB04F0", Offset = "0x2AAEAF0", VA = "0x182AB04F0")]
				internal void GOGHPUPUNTO(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7810", Offset = "0x2AA5E10", VA = "0x182AA7810")]
			public EBBVQYRIPLT(GCFTXZUHCVV a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7120", Offset = "0x2AA5720", VA = "0x182AA7120", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class HSWFFFAQDBO : FVXBTFLYTRK<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public HSWFFFAQDBO CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0CC0", Offset = "0x2AAF2C0", VA = "0x182AB0CC0")]
				internal bool GPLWZJFESJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0DE0", Offset = "0x2AAF3E0", VA = "0x182AB0DE0")]
				internal void GPRDWPZCBUZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0900", Offset = "0x2AAEF00", VA = "0x182AB0900")]
				internal bool GPBJEVRJZMY()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF830", Offset = "0x2AADE30", VA = "0x182AAF830")]
			public HSWFFFAQDBO(GCFTXZUHCVV a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF620", Offset = "0x2AADC20", VA = "0x182AAF620", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class RCCNLRHGRJT : FVXBTFLYTRK<QEHVHCRDCYC>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class TBDIAOPJOEZ
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
					public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public TBDIAOPJOEZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<LYZTJSPJQLD>, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x2AB9F70", Offset = "0x2AB8570", VA = "0x182AB9F70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x2ABA350", Offset = "0x2AB8950", VA = "0x182ABA350", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public TBDIAOPJOEZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2ABA3C0", Offset = "0x2AB89C0", VA = "0x182ABA3C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2ABA750", Offset = "0x2AB8D50", VA = "0x182ABA750", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task CVJFRYMBCOT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string KHZLWMJSHFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public JFQCZHJIKAB.ALXDQNMOBSX ACJGDRDNIOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool BLLCKHRJMPW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public RCCNLRHGRJT CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public JFQCZHJIKAB CPKYQCCQOVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action TITXJHUIOVA;

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public TBDIAOPJOEZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6910", Offset = "0x2AB4F10", VA = "0x182AB6910")]
				internal bool IUWTVCNUEVS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
				internal string LCDMTJQAXCV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6BA0", Offset = "0x2AB51A0", VA = "0x182AB6BA0")]
				internal void LBNSBPIIUUU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6C20", Offset = "0x2AB5220", VA = "0x182AB6C20")]
				internal void LBSYYWCGEGD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x164BD00", Offset = "0x164A300", VA = "0x18164BD00")]
				internal bool LBDEHBUOBYC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6980", Offset = "0x2AB4F80", VA = "0x182AB6980")]
				internal void LBILEIOLLJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6940", Offset = "0x2AB4F40", VA = "0x182AB6940")]
				internal bool LASQMOGTJBK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6C70", Offset = "0x2AB5270", VA = "0x182AB6C70")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, IQRQYBTPXGA>> YDEBBBGAMIW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6820", Offset = "0x2AB4E20", VA = "0x182AB6820")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, IQRQYBTPXGA>> EVOFHTVKIZF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class PMCLZVAKTMZ
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
					public AsyncTaskMethodBuilder<Result<Id32<LYZTJSPJQLD>, IQRQYBTPXGA>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<LYZTJSPJQLD>, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x2AB9B90", Offset = "0x2AB8190", VA = "0x182AB9B90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x2AB9F00", Offset = "0x2AB8500", VA = "0x182AB9F00", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public RCCNLRHGRJT CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public TNLURBVFQWD UHKJNGAZJPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool SXHQCMTFULQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public JFQCZHJIKAB CPKYQCCQOVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public WCIVLDDQGBD ZQWYQJWMYJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action LFGMUHQGXBD;

				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public PMCLZVAKTMZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2730", Offset = "0x2AB0D30", VA = "0x182AB2730")]
				internal object? GPRDWPZCBUZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2550", Offset = "0x2AB0B50", VA = "0x182AB2550")]
				internal void GPBJEVRJZMY(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2640", Offset = "0x2AB0C40", VA = "0x182AB2640")]
				internal string GPGQCCLHIYH(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2350", Offset = "0x2AB0950", VA = "0x182AB2350")]
				internal IReadOnlyList<object> GOQVKIDPGQG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB23F0", Offset = "0x2AB09F0", VA = "0x182AB23F0")]
				internal void GOWCHOXMQBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2220", Offset = "0x2AB0820", VA = "0x182AB2220")]
				internal bool GOGHPUPUNTO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2290", Offset = "0x2AB0890", VA = "0x182AB2290")]
				internal void GOLONBJRXEX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2AB27A0", Offset = "0x2AB0DA0", VA = "0x182AB27A0")]
				internal void GRCADLIJPWK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2AB27F0", Offset = "0x2AB0DF0", VA = "0x182AB27F0")]
				internal void GRHHASCGZHT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2960", Offset = "0x2AB0F60", VA = "0x182AB2960")]
				internal bool NQHTLKXKZZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2AB2870", Offset = "0x2AB0E70", VA = "0x182AB2870")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<LYZTJSPJQLD>, IQRQYBTPXGA>> KENNBEMNINV()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<YRJDGOUPWNL>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4440", Offset = "0x2AB2A40", VA = "0x182AB4440", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2AB43D0", Offset = "0x2AB29D0", VA = "0x182AB43D0")]
			public RCCNLRHGRJT(GCFTXZUHCVV a, QEHVHCRDCYC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB33B0", Offset = "0x2AB19B0", VA = "0x182AB33B0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3D40", Offset = "0x2AB2340", VA = "0x182AB3D40")]
			private void VXAGJSDPBYQ(JFQCZHJIKAB a, Id32<LYZTJSPJQLD>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class VKYWZQGZTUU : ZIZOVKEJUZB<EJAOAKGGOLL>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x16CD670", Offset = "0x16CBC70", VA = "0x1816CD670", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool VDFLGOPAQMX
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool IIIKFDSMBDY
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool QGGXVVNXZDF
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x2ABCA60", Offset = "0x2ABB060", VA = "0x182ABCA60")]
			public VKYWZQGZTUU(GCFTXZUHCVV a, EJAOAKGGOLL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class BZWDYVMXVQK<a> : FVXBTFLYTRK<a> where a : notnull, HORRENEMKEC
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
				public AsyncTaskMethodBuilder<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public BZWDYVMXVQK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x4FD8DA0", Offset = "0x4FD73A0", VA = "0x184FD8DA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x4FD90F0", Offset = "0x4FD76F0", VA = "0x184FD90F0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public BZWDYVMXVQK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<QKZKTYBWUBB> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x5278FC0", Offset = "0x52775C0", VA = "0x185278FC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x5279310", Offset = "0x5277910", VA = "0x185279310", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<QKZKTYBWUBB>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x7215E90", Offset = "0x7214490", VA = "0x187215E90", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7215E60", Offset = "0x7214460", VA = "0x187215E60")]
			protected BZWDYVMXVQK(GCFTXZUHCVV a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7215C00", Offset = "0x7214200", VA = "0x187215C00", Slot = "122")]
			[AsyncStateMachine(typeof(BZWDYVMXVQK<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> NINOBROWHCX(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7215B60", Offset = "0x7214160", VA = "0x187215B60", Slot = "149")]
			public sealed override bool MIEUTIBMHNE(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7215DC0", Offset = "0x72143C0", VA = "0x187215DC0", Slot = "134")]
			protected sealed override bool WHUHKRPFOAQ(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7215D20", Offset = "0x7214320", VA = "0x187215D20", Slot = "135")]
			protected override bool PDEKZQHYWXZ(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7215A50", Offset = "0x7214050", VA = "0x187215A50", Slot = "123")]
			[AsyncStateMachine(typeof(BZWDYVMXVQK<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, IQRQYBTPXGA>> GLBCLRSXSSO(Id32<QKZKTYBWUBB> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class ZULMNZIDXQH : KEZLQRWUJUU<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public ZULMNZIDXQH CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1300", Offset = "0x2AAF900", VA = "0x182AB1300")]
				internal bool MNJJIHHVNDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1250", Offset = "0x2AAF850", VA = "0x182AB1250")]
				internal void MNECLANYDSM(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD2A0", Offset = "0x2ABB8A0", VA = "0x182ABD2A0")]
			public ZULMNZIDXQH(GCFTXZUHCVV a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD060", Offset = "0x2ABB660", VA = "0x182ABD060", Slot = "151")]
			protected override void CHRWEKIUYRV(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class ZZQMTAMDOIQ : FVXBTFLYTRK<MKOGQLPZOEZ>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class RPGDRVSGBNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int SCNAXJBGXBV;

				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public RPGDRVSGBNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4480", Offset = "0x2AB2A80", VA = "0x182AB4480")]
				internal bool RUMJUJRNBSH(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class XMEHEWGCGRP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public ZZQMTAMDOIQ CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> UEOQSTCZNMD;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XMEHEWGCGRP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2ABCC50", Offset = "0x2ABB250", VA = "0x182ABCC50")]
				internal int GPLWZJFESJQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x2ABCCF0", Offset = "0x2ABB2F0", VA = "0x182ABCCF0")]
				internal void GPRDWPZCBUZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2ABCBA0", Offset = "0x2ABB1A0", VA = "0x182ABCBA0")]
				internal string? GPBJEVRJZMY()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD800", Offset = "0x2ABBE00", VA = "0x182ABD800")]
			public ZZQMTAMDOIQ(GCFTXZUHCVV a, MKOGQLPZOEZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD770", Offset = "0x2ABBD70", VA = "0x182ABD770")]
			private int USCIRFBBQCX(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD650", Offset = "0x2ABBC50", VA = "0x182ABD650")]
			private void QLFBIYZDCWT(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD300", Offset = "0x2ABB900", VA = "0x182ABD300", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class SYGZJZYNJJC : ZIZOVKEJUZB<ZMKGSEYVHOR>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6610", Offset = "0x2AB4C10", VA = "0x182AB6610")]
			public SYGZJZYNJJC(GCFTXZUHCVV a, ZMKGSEYVHOR b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class ZIZOVKEJUZB<a> : FVXBTFLYTRK<a> where a : notnull, SIROMCNUKEB
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class IRJROOLAKFJ
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
					public IRJROOLAKFJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x3F83CD0", Offset = "0x3F822D0", VA = "0x183F83CD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public JFQCZHJIKAB CPKYQCCQOVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public ZIZOVKEJUZB<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action LHHDSXHGNKP;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public IRJROOLAKFJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x51DD410", Offset = "0x51DBA10", VA = "0x1851DD410")]
				internal void GPLWZJFESJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x51DD370", Offset = "0x51DB970", VA = "0x1851DD370")]
				[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.IRJROOLAKFJ.<<BuildConfigMenuInternal>b__6>d))]
				internal void GOGHPUPUNTO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x51DD680", Offset = "0x51DBC80", VA = "0x1851DD680")]
				internal bool GPRDWPZCBUZ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class IREKRHRDAUA
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
					public IREKRHRDAUA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x3F838D0", Offset = "0x3F81ED0", VA = "0x183F838D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string ZOYAFGAKMMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public IRJROOLAKFJ GOOXOIYUWOV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> LGGVGPLTSFW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> LHRRNKVBGHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action LHMKQEBDWVY;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public IREKRHRDAUA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x51DD010", Offset = "0x51DB610", VA = "0x1851DD010")]
				internal void GPBJEVRJZMY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				internal string GPGQCCLHIYH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
				internal void GOQVKIDPGQG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x51DCF70", Offset = "0x51DB570", VA = "0x1851DCF70")]
				[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.IREKRHRDAUA.<<BuildConfigMenuInternal>b__5>d))]
				internal void GOWCHOXMQBP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class MGNXEROXAMS
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
					public MGNXEROXAMS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<WRHWMQQUVHP>, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x3F81060", Offset = "0x3F7F660", VA = "0x183F81060", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public MGNXEROXAMS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3F817A0", Offset = "0x3F7FDA0", VA = "0x183F817A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public MGNXEROXAMS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<OVRKYFBGDJO>, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3F81980", Offset = "0x3F7FF80", VA = "0x183F81980", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public ZIZOVKEJUZB<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<QKZKTYBWUBB> JUKREXMFVSX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public JFQCZHJIKAB CPKYQCCQOVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public ZWPHYIPUSNT AFIYXFMFZAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int VGOAMYKXDVX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int EWNNROQSJYL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public HKFDOQDIWNO THDFFQRROIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string ABNBMYNQYTG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<SKAFPSIOIMI> OZJBYUZZEVT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public HKFDOQDIWNO FMAFQSHDXNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string WJHBZEDONQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<SKAFPSIOIMI> YTPJLLANCIC;

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MGNXEROXAMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x59478B0", Offset = "0x5945EB0", VA = "0x1859478B0")]
				internal bool OWLZJWMSEWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x5947840", Offset = "0x5945E40", VA = "0x185947840")]
				internal void OWGSMPSUVLA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x59471D0", Offset = "0x59457D0", VA = "0x1859471D0")]
				internal bool BARNJJWPMNZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x59477A0", Offset = "0x5945DA0", VA = "0x1859477A0")]
				[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.MGNXEROXAMS.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void OWBLPIYXLZR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5947760", Offset = "0x5945D60", VA = "0x185947760")]
				internal bool OVWESCFACOI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5947310", Offset = "0x5945910", VA = "0x185947310")]
				internal void BBMOYKYEYHJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x59473F0", Offset = "0x59459F0", VA = "0x1859473F0")]
				internal bool BCMXKSTRTMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x59474A0", Offset = "0x5945AA0", VA = "0x1859474A0")]
				internal void BCSEHZNPCXL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x5947A00", Offset = "0x5946000", VA = "0x185947A00")]
				internal bool UGSBYGVDWGB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x59476F0", Offset = "0x5945CF0", VA = "0x1859476F0")]
				internal bool OVQXUVLCTCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x5947680", Offset = "0x5945C80", VA = "0x185947680")]
				internal void OVLQXORFJRQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x59475E0", Offset = "0x5945BE0", VA = "0x1859475E0")]
				[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.MGNXEROXAMS.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void OVGKAHXIAGH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x5947580", Offset = "0x5945B80", VA = "0x185947580")]
				internal bool OVBDDBDKQUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x5947990", Offset = "0x5945F90", VA = "0x185947990")]
				internal bool OYCCNYPXCJD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x5947920", Offset = "0x5945F20", VA = "0x185947920")]
				internal void OXWVQRVZSXU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x5947210", Offset = "0x5945810", VA = "0x185947210")]
				[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.MGNXEROXAMS.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void BAWUGQQMVZI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x59472B0", Offset = "0x59458B0", VA = "0x1859472B0")]
				internal bool BBCBDXKKFKR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class MGTEBYIUJYB
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
					public MGTEBYIUJYB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x3F81350", Offset = "0x3F7F950", VA = "0x183F81350", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string CKQUFYDCNFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public MGNXEROXAMS GOOXOIYUWOV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> FJUFJCLMBDM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> FJZMGJFJKOV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action FJJROOXRIGU;

				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MGTEBYIUJYB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x59491F0", Offset = "0x59477F0", VA = "0x1859491F0")]
				internal void BAMGMDCSDCQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				internal string BBRVVRSCHSS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
				internal void BBXCSYLZREB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x5949550", Offset = "0x5947B50", VA = "0x185949550")]
				[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.MGTEBYIUJYB.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void BBHIBEEHOWA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class ZLDQEZYFTYJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool OZJBYUZZEVT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public ZWPHYIPUSNT AFIYXFMFZAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<SKAFPSIOIMI> APBWSYXIXAY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public ZIZOVKEJUZB<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<QKZKTYBWUBB> JUKREXMFVSX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int EOXUPTSIBOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> LGRJBCZOLCO;

				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ZLDQEZYFTYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x40DF490", Offset = "0x40DDA90", VA = "0x1840DF490")]
				internal bool NLAUHEUTWUL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class ZKYJHTEIKNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public TKNLLBEJAZY AVPTFRWELQH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public ZLDQEZYFTYJ GOOXOIYUWOV;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ZKYJHTEIKNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x40DF0E0", Offset = "0x40DD6E0", VA = "0x1840DF0E0")]
				internal void NLGBELORGFU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0x40DF250", Offset = "0x40DD850", VA = "0x1840DF250")]
				internal bool NLLIBSIOPRD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x40DF2A0", Offset = "0x40DD8A0", VA = "0x1840DF2A0")]
				internal void NLQOYZCLZCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x40DF430", Offset = "0x40DDA30", VA = "0x1840DF430")]
				internal bool NLVVWFWJINV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class ZKTCKMKLBBR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public SKAFPSIOIMI IVKRLQZWBSN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public ZKYJHTEIKNA GNZCWORCUGU;

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ZKTCKMKLBBR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x40DEEB0", Offset = "0x40DD4B0", VA = "0x1840DEEB0")]
				internal void NKVNJYAWNJC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class LAZVWXPPIEM
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
					public LAZVWXPPIEM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x3F852D0", Offset = "0x3F838D0", VA = "0x183F852D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> WKLYILLPHJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public HKFDOQDIWNO TRGBTUYDRHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool OZJBYUZZEVT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public ZWPHYIPUSNT AFIYXFMFZAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public TKNLLBEJAZY AVPTFRWELQH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string CKQUFYDCNFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public LAZVWXPPIEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x5466E00", Offset = "0x5465400", VA = "0x185466E00")]
				internal int ZYCASQQAKOC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x5466E40", Offset = "0x5465440", VA = "0x185466E40")]
				internal void ZYHHPXJXTZL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
				internal string ZXRMYDCFRRK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x5466D40", Offset = "0x5465340", VA = "0x185466D40")]
				[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.LAZVWXPPIEM.<<CreatePortItemV2>b__3>d))]
				internal void ZXWTVJWDBCT(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public ZIZOVKEJUZB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x4FD8980", Offset = "0x4FD6F80", VA = "0x184FD8980", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x4FD8D30", Offset = "0x4FD7330", VA = "0x184FD8D30", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public ZIZOVKEJUZB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<QKZKTYBWUBB> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x5279380", Offset = "0x5277980", VA = "0x185279380", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x5279710", Offset = "0x5277D10", VA = "0x185279710", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public ZIZOVKEJUZB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x52865A0", Offset = "0x5284BA0", VA = "0x1852865A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x5286B40", Offset = "0x5285140", VA = "0x185286B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<QKZKTYBWUBB>, bool> SRSDTRUALTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<QKZKTYBWUBB>, bool> YJGDSJCWUPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<QKZKTYBWUBB>, bool> OZBABIUHCBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<QKZKTYBWUBB>, bool> PAXKUUGRXYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<QKZKTYBWUBB>, bool> DSENWQPMWPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<QKZKTYBWUBB>, bool> VDYNPQMTQCE;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool VDFLGOPAQMX
			{
				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool IIIKFDSMBDY
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool QGGXVVNXZDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<YRJDGOUPWNL>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x40DEBC0", Offset = "0x40DD1C0", VA = "0x1840DEBC0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<QKZKTYBWUBB>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x40DEE20", Offset = "0x40DD420", VA = "0x1840DEE20", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<BZFRCGZKOVF>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x40DEC40", Offset = "0x40DD240", VA = "0x1840DEC40", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x40DE9F0", Offset = "0x40DCFF0", VA = "0x1840DE9F0")]
			public ZIZOVKEJUZB(GCFTXZUHCVV a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "154")]
			protected virtual bool METBRIOPTMK(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "155")]
			protected virtual bool FRKKUXYXCRD(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "156")]
			protected virtual bool QQJVSJJEVKU(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "157")]
			protected virtual void XDOTILKDYVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x40DE270", Offset = "0x40DC870", VA = "0x1840DE270", Slot = "149")]
			public override bool MIEUTIBMHNE(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x40DE310", Offset = "0x40DC910", VA = "0x1840DE310", Slot = "122")]
			[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> NINOBROWHCX(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x40DE100", Offset = "0x40DC700", VA = "0x1840DE100", Slot = "123")]
			[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, IQRQYBTPXGA>> GLBCLRSXSSO(Id32<QKZKTYBWUBB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x40DE670", Offset = "0x40DCC70", VA = "0x1840DE670", Slot = "124")]
			public override void VUMQXIBVMSC(Id32<QKZKTYBWUBB> index, Id32<QKZKTYBWUBB> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x40DE430", Offset = "0x40DCA30", VA = "0x1840DE430", Slot = "125")]
			public override IEnumerable<LOHJEAGYXDY> SOBGIISANTP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x40DE000", Offset = "0x40DC600", VA = "0x1840DE000")]
			[AsyncStateMachine(typeof(ZIZOVKEJUZB<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, IQRQYBTPXGA>> FQUKDOOHHGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "158")]
			protected virtual bool VSIUHVWXNBT(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "159")]
			protected virtual bool ZDGQMWFZMMN(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "160")]
			protected virtual bool VNUCVKVNSNG(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "161")]
			protected virtual bool UDRSCXGMAKS(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "162")]
			protected virtual bool ZRVUWKRBXIM(Id32<QKZKTYBWUBB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "163")]
			protected virtual bool OSOYYRIHRPL(Id32<QKZKTYBWUBB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "164")]
			protected virtual bool JREVNYYWBZV(Id32<QKZKTYBWUBB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "165")]
			protected virtual bool KKZPHJVZCFO(Id32<QKZKTYBWUBB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "166")]
			protected virtual bool OWOYEVLRRAM(Id32<QKZKTYBWUBB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "167")]
			protected virtual bool NALZKECLCGP(Id32<QKZKTYBWUBB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x40DDD80", Offset = "0x40DC380", VA = "0x1840DDD80", Slot = "168")]
			protected virtual List<HKFDOQDIWNO> FCZAJXXLOVJ(Id32<QKZKTYBWUBB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "169")]
			protected virtual void OSNMVHFUPMI(JFQCZHJIKAB a, MJFDITXXZZZ b, ZWPHYIPUSNT c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x40DBA10", Offset = "0x40DA010", VA = "0x1840DBA10", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x40DA0D0", Offset = "0x40D86D0", VA = "0x1840DA0D0")]
			private MJFDITXXZZZ AQSDQPXJYHT(JFQCZHJIKAB a, ZWPHYIPUSNT b, Id32<QKZKTYBWUBB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x40DC3B0", Offset = "0x40DA9B0", VA = "0x1840DC3B0")]
			private List<SKAFPSIOIMI> BVJQRZLYKGC(JFQCZHJIKAB a, ZWPHYIPUSNT b, MJFDITXXZZZ c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x40DD3F0", Offset = "0x40DB9F0", VA = "0x1840DD3F0")]
			private List<SKAFPSIOIMI> DKUJAMYZAEA(JFQCZHJIKAB a, ZWPHYIPUSNT b, TKNLLBEJAZY c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x40DE800", Offset = "0x40DCE00", VA = "0x1840DE800")]
			private HKFDOQDIWNO YXHFWNWXNRM(List<HKFDOQDIWNO> a, TKNLLBEJAZY b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x40DE210", Offset = "0x40DC810", VA = "0x1840DE210")]
			[CompilerGenerated]
			private LOHJEAGYXDY GWUPDHMJLSQ(QPBKESVYPXS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class LVAVSRBXDZE : FVXBTFLYTRK<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public LVAVSRBXDZE CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x2ABCAC0", Offset = "0x2ABB0C0", VA = "0x182ABCAC0")]
				internal int GPLWZJFESJQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x2ABCB10", Offset = "0x2ABB110", VA = "0x182ABCB10")]
				internal Task<bool> GPRDWPZCBUZ(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0400", Offset = "0x2AAEA00", VA = "0x182AB0400")]
			public LVAVSRBXDZE(GCFTXZUHCVV a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0250", Offset = "0x2AAE850", VA = "0x182AB0250", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class RRHDKMVNWAW : KEZLQRWUJUU<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public RRHDKMVNWAW CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1380", Offset = "0x2AAF980", VA = "0x182AB1380")]
				internal int MNJJIHHVNDV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x2AB11B0", Offset = "0x2AAF7B0", VA = "0x182AB11B0")]
				internal Task<bool> MNECLANYDSM(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2AB46E0", Offset = "0x2AB2CE0", VA = "0x182AB46E0")]
			public RRHDKMVNWAW(GCFTXZUHCVV a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2AB44C0", Offset = "0x2AB2AC0", VA = "0x182AB44C0", Slot = "151")]
			protected override void CHRWEKIUYRV(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class DDLYBMVWLHS : FVXBTFLYTRK<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0xF87B30", Offset = "0xF86130", VA = "0x180F87B30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA63C0", Offset = "0x2AA49C0", VA = "0x182AA63C0")]
			public DDLYBMVWLHS(GCFTXZUHCVV a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class EZOWLGAGYCY : FVXBTFLYTRK<BVAXERKHHAJ>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class AUWAEQXFGZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public EZOWLGAGYCY CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public JFQCZHJIKAB CPKYQCCQOVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> CONVYTOURQK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> COIPBMUXIFB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> CPIXNUQKDJU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> CPDQQNWMTYL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> COYJTHCPKNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> CNCZRYFNDOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> CMXSURLPUDQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> VOBXXIAPLJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> VOHEUOUMUUT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> VOMLRVOKEGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> VORSPCIHNRL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> VOWZMJCEXCU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> VPCGJPWCGOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> VPHNGWPZPZM;

				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public AUWAEQXFGZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C6D0", Offset = "0x2A9ACD0", VA = "0x182A9C6D0")]
				internal bool GPLWZJFESJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C720", Offset = "0x2A9AD20", VA = "0x182A9C720")]
				internal void GPRDWPZCBUZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C630", Offset = "0x2A9AC30", VA = "0x182A9C630")]
				internal bool GOQVKIDPGQG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C680", Offset = "0x2A9AC80", VA = "0x182A9C680")]
				internal bool GOWCHOXMQBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C5D0", Offset = "0x2A9ABD0", VA = "0x182A9C5D0")]
				internal void GOGHPUPUNTO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C780", Offset = "0x2A9AD80", VA = "0x182A9C780")]
				internal bool GRHHASCGZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DFE0", Offset = "0x2A9C5E0", VA = "0x182A9DFE0")]
				internal bool NQHTLKXKZZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DF80", Offset = "0x2A9C580", VA = "0x182A9DF80")]
				internal void NQCMOEDNQNS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DED0", Offset = "0x2A9C4D0", VA = "0x182A9DED0")]
				internal bool NPMRWJVVOFR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DE80", Offset = "0x2A9C480", VA = "0x182A9DE80")]
				internal bool NPHKZDBYEUI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DF20", Offset = "0x2A9C520", VA = "0x182A9DF20")]
				internal void NPXFQXJQHCJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2A9E030", Offset = "0x2A9C630", VA = "0x182A9E030")]
				internal bool NRSPSGGSOAM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6040", Offset = "0x2AA4640", VA = "0x182AA6040")]
				internal bool ZUQUPHSJYUB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5FF0", Offset = "0x2AA45F0", VA = "0x182AA5FF0")]
				internal bool ZULNSAYMPIS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5FA0", Offset = "0x2AA45A0", VA = "0x182AA5FA0")]
				internal bool ZUGGUUEPFXJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5F50", Offset = "0x2AA4550", VA = "0x182AA5F50")]
				internal bool ZTVTAGQUNAR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5F00", Offset = "0x2AA4500", VA = "0x182AA5F00")]
				internal bool ZTQMCZWXDPI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5130", Offset = "0x2AA3730", VA = "0x182AA5130")]
				internal bool SUURFQLWUVC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5180", Offset = "0x2AA3780", VA = "0x182AA5180")]
				internal bool SUZYCXFUEGL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2AA51D0", Offset = "0x2AA37D0", VA = "0x182AA51D0")]
				internal void SVFFADZRNRU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C4A0", Offset = "0x2A9AAA0", VA = "0x182A9C4A0")]
				internal bool FTPMSUOPKSB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C400", Offset = "0x2A9AA00", VA = "0x182A9C400")]
				internal bool FSZSBAGXIKA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C450", Offset = "0x2A9AA50", VA = "0x182A9C450")]
				internal bool FTEYYHAURVJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C3B0", Offset = "0x2A9A9B0", VA = "0x182A9C3B0")]
				internal bool FSULDTMZYYR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C310", Offset = "0x2A9A910", VA = "0x182A9C310")]
				internal bool FSEQLZFHWQQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5230", Offset = "0x2AA3830", VA = "0x182AA5230")]
				internal bool SVKLXKTOXDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4FE0", Offset = "0x2AA35E0", VA = "0x182AA4FE0")]
				internal bool STZPQPKHJBS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5030", Offset = "0x2AA3630", VA = "0x182AA5030")]
				internal void SUEWNWEESNB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5090", Offset = "0x2AA3690", VA = "0x182AA5090")]
				internal bool SUKDLCYCBYK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2AA50E0", Offset = "0x2AA36E0", VA = "0x182AA50E0")]
				internal bool SUPKIJRZLJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4F30", Offset = "0x2AA3530", VA = "0x182AA4F30")]
				internal void STEOBOIRXII(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4F90", Offset = "0x2AA3590", VA = "0x182AA4F90")]
				internal bool STJUYVCPGTR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2AA60F0", Offset = "0x2AA46F0", VA = "0x182AA60F0")]
				internal bool ZVLWEITZKNL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6090", Offset = "0x2AA4690", VA = "0x182AA6090")]
				internal void ZVGPHCACBCC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2A9E080", Offset = "0x2A9C680", VA = "0x182A9E080")]
				internal List<SKAFPSIOIMI> OIBGFFXKUWT(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C360", Offset = "0x2A9A960", VA = "0x182A9C360")]
				internal bool FSJXJFZFGBZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C4F0", Offset = "0x2A9AAF0", VA = "0x182A9C4F0")]
				internal int FVAIZPXWYTM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C540", Offset = "0x2A9AB40", VA = "0x182A9C540")]
				internal Task<bool> FVFPWWRUIEV(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D660", Offset = "0x2A9BC60", VA = "0x182A9D660")]
				internal bool LUDMGYDUFCT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D610", Offset = "0x2A9BC10", VA = "0x182A9D610")]
				internal bool LTYFJRJWVRK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D700", Offset = "0x2A9BD00", VA = "0x182A9D700")]
				internal bool LUOABLROXZL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D6B0", Offset = "0x2A9BCB0", VA = "0x182A9D6B0")]
				internal int LUITEEXROOC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D7A0", Offset = "0x2A9BDA0", VA = "0x182A9D7A0")]
				internal Task<bool> LUYNVZFJQWD(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D750", Offset = "0x2A9BD50", VA = "0x182A9D750")]
				internal bool LUTGYSLMHKU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D880", Offset = "0x2A9BE80", VA = "0x182A9D880")]
				internal bool LVJBQMTEJSV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D830", Offset = "0x2A9BE30", VA = "0x182A9D830")]
				internal bool LVDUTFZHAHM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D5C0", Offset = "0x2A9BBC0", VA = "0x182A9D5C0")]
				internal bool LSICFPGRYEQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2AA45E0", Offset = "0x2AA2BE0", VA = "0x182AA45E0")]
				internal bool RSBVYDEMVWA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2A9B930", Offset = "0x2A99F30", VA = "0x182A9B930")]
				internal string AOLVZLWXQXD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2A9B870", Offset = "0x2A99E70", VA = "0x182A9B870")]
				internal void ANWBHRPFOPC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BA30", Offset = "0x2A9A030", VA = "0x182A9BA30")]
				internal int APGXOMYNCQN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2A9B980", Offset = "0x2A99F80", VA = "0x182A9B980")]
				internal void AORCWSQVAIM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2A9B9E0", Offset = "0x2A99FE0", VA = "0x182A9B9E0")]
				internal bool AOWJTZKSJTV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2A9B7D0", Offset = "0x2A99DD0", VA = "0x182A9B7D0")]
				internal bool AMQLYCZVJZA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2A9B820", Offset = "0x2A99E20", VA = "0x182A9B820")]
				internal bool AMVSVJTSTKJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C940", Offset = "0x2A9AF40", VA = "0x182A9C940")]
				internal float HOXUAXLCXED()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C8E0", Offset = "0x2A9AEE0", VA = "0x182A9C8E0")]
				internal void HOSNDQRFNSU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C9E0", Offset = "0x2A9AFE0", VA = "0x182A9C9E0")]
				internal bool HPIHVKYXQAV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C990", Offset = "0x2A9AF90", VA = "0x182A9C990")]
				internal bool HPDAYEFAGPM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C820", Offset = "0x2A9AE20", VA = "0x182A9C820")]
				internal bool HOCSLWJNLKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4630", Offset = "0x2AA2C30", VA = "0x182AA4630")]
				internal bool RSMJSQSHOSS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4680", Offset = "0x2AA2C80", VA = "0x182AA4680")]
				internal bool RSRQPXMEYEB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2AA46D0", Offset = "0x2AA2CD0", VA = "0x182AA46D0")]
				internal bool RSWXNEGCHPK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4720", Offset = "0x2AA2D20", VA = "0x182AA4720")]
				internal void RTCEKKZZRAT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C7D0", Offset = "0x2A9ADD0", VA = "0x182A9C7D0")]
				internal string HNXLOPPQBZK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C870", Offset = "0x2A9AE70", VA = "0x182A9C870")]
				internal void HONGGJXIEHL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4B00", Offset = "0x2AA3100", VA = "0x182AA4B00")]
				internal bool RTHLHRTXAMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4B50", Offset = "0x2AA3150", VA = "0x182AA4B50")]
				internal bool RTMSEYNUJXL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4BA0", Offset = "0x2AA31A0", VA = "0x182AA4BA0")]
				internal bool RTRZCFHRTIU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4BF0", Offset = "0x2AA31F0", VA = "0x182AA4BF0")]
				internal void RTXFZMBPCUD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5CB0", Offset = "0x2AA42B0", VA = "0x182AA5CB0")]
				internal bool YSTAWVMPLOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5C60", Offset = "0x2AA4260", VA = "0x182AA5C60")]
				internal bool YSNTZOSSCDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5C10", Offset = "0x2AA4210", VA = "0x182AA5C10")]
				internal bool YSINCHYUSRR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5BC0", Offset = "0x2AA41C0", VA = "0x182AA5BC0")]
				internal bool YSDGFBEXJGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5DF0", Offset = "0x2AA43F0", VA = "0x182AA5DF0")]
				internal void YTOCLWOEXHT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5DA0", Offset = "0x2AA43A0", VA = "0x182AA5DA0")]
				internal bool YTIVOPUHNWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5D50", Offset = "0x2AA4350", VA = "0x182AA5D50")]
				internal bool YTDORJAKELB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5D00", Offset = "0x2AA4300", VA = "0x182AA5D00")]
				internal bool YSYHUCGMUZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5EB0", Offset = "0x2AA44B0", VA = "0x182AA5EB0")]
				internal bool YUJEAXPUJBD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5E50", Offset = "0x2AA4450", VA = "0x182AA5E50")]
				internal void YUDXDQVWZPU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CB70", Offset = "0x2A9B170", VA = "0x182A9CB70")]
				internal bool IOPSLKRISFU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CBC0", Offset = "0x2A9B1C0", VA = "0x182A9CBC0")]
				internal bool IOUZIRLGBRD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CAD0", Offset = "0x2A9B0D0", VA = "0x182A9CAD0")]
				internal bool IOFEQXDNZJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CB20", Offset = "0x2A9B120", VA = "0x182A9CB20")]
				internal bool IOKLODXLIUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CC10", Offset = "0x2A9B210", VA = "0x182A9CC10")]
				internal object IPAGFYFDLCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CC80", Offset = "0x2A9B280", VA = "0x182A9CC80")]
				internal void IPFNDEZAUNV(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CA30", Offset = "0x2A9B030", VA = "0x182A9CA30")]
				internal bool IMZPHIODUTA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CA80", Offset = "0x2A9B080", VA = "0x182A9CA80")]
				internal bool INEWEPIBEEJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2AA41F0", Offset = "0x2AA27F0", VA = "0x182AA41F0")]
				internal int PPBQMWFNYMU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4240", Offset = "0x2AA2840", VA = "0x182AA4240")]
				internal void PPRLEQNGAUV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4150", Offset = "0x2AA2750", VA = "0x182AA4150")]
				internal bool POGOXVDYMTK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA41A0", Offset = "0x2AA27A0", VA = "0x182AA41A0")]
				internal bool POWJPPLQPBL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4100", Offset = "0x2AA2700", VA = "0x182AA4100")]
				internal int PNLNIUCJBAA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D200", Offset = "0x2A9B800", VA = "0x182A9D200")]
				internal void JVDERPRWQQN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D1B0", Offset = "0x2A9B7B0", VA = "0x182A9D1B0")]
				internal bool JUXXUIXZHFE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D160", Offset = "0x2A9B760", VA = "0x182A9D160")]
				internal bool JUSQXCEBXTV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D110", Offset = "0x2A9B710", VA = "0x182A9D110")]
				internal bool JUNJZVKEOIM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D0C0", Offset = "0x2A9B6C0", VA = "0x182A9D0C0")]
				internal int JTXPIBCMMAL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D060", Offset = "0x2A9B660", VA = "0x182A9D060")]
				internal void JTSIKUIPCPC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D010", Offset = "0x2A9B610", VA = "0x182A9D010")]
				internal bool JTNBNNORTDT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CFC0", Offset = "0x2A9B5C0", VA = "0x182A9CFC0")]
				internal bool JTHUQGUUJSK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BF80", Offset = "0x2A9A580", VA = "0x182A9BF80")]
				internal bool CULZSXJUAYE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BE80", Offset = "0x2A9A480", VA = "0x182A9BE80")]
				internal object CTWFBDCBYQD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BEF0", Offset = "0x2A9A4F0", VA = "0x182A9BEF0")]
				internal void CUBLYJVZIBM(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BDE0", Offset = "0x2A9A3E0", VA = "0x182A9BDE0")]
				internal bool CSVWOVGPDLK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BE30", Offset = "0x2A9A430", VA = "0x182A9BE30")]
				internal bool CTBDMCAMMWT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5AB0", Offset = "0x2AA40B0", VA = "0x182AA5AB0")]
				internal object? WQBDLJWHUFV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5A20", Offset = "0x2AA4020", VA = "0x182AA5A20")]
				internal void WPVWODCKKUM(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5920", Offset = "0x2AA3F20", VA = "0x182AA5920")]
				internal bool WPGBWIUSIML()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2AA58D0", Offset = "0x2AA3ED0", VA = "0x182AA58D0")]
				internal int WPAUZCAUZBC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2AA59C0", Offset = "0x2AA3FC0", VA = "0x182AA59C0")]
				internal void WPQPQWINBJD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5970", Offset = "0x2AA3F70", VA = "0x182AA5970")]
				internal bool WPLITPOPRXU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5B70", Offset = "0x2AA4170", VA = "0x182AA5B70")]
				internal bool WRRGPLZMRSP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5B20", Offset = "0x2AA4120", VA = "0x182AA5B20")]
				internal bool WRLZSFFPIHG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4340", Offset = "0x2AA2940", VA = "0x182AA4340")]
				internal int QPHWZZNFQJU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4390", Offset = "0x2AA2990", VA = "0x182AA4390")]
				internal void QPNDXGHCZVD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2AA42A0", Offset = "0x2AA28A0", VA = "0x182AA42A0")]
				internal bool QOXJFLZKXNC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2AA42F0", Offset = "0x2AA28F0", VA = "0x182AA42F0")]
				internal bool QPCQCSTIGYL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2AA44A0", Offset = "0x2AA2AA0", VA = "0x182AA44A0")]
				internal bool QQCYPAOVCDE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2AA44F0", Offset = "0x2AA2AF0", VA = "0x182AA44F0")]
				internal float QQIFMHISLON()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2AA43F0", Offset = "0x2AA29F0", VA = "0x182AA43F0")]
				internal void QPSKUNBAJGM(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4450", Offset = "0x2AA2A50", VA = "0x182AA4450")]
				internal bool QPXRRTUXSRV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4540", Offset = "0x2AA2B40", VA = "0x182AA4540")]
				internal bool QQYAEBQKNWO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4590", Offset = "0x2AA2B90", VA = "0x182AA4590")]
				internal bool QRDHBIKHXHX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CDC0", Offset = "0x2A9B3C0", VA = "0x182A9CDC0")]
				internal float ISKJKCKMRRL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CD60", Offset = "0x2A9B360", VA = "0x182A9CD60")]
				internal void ISFCMVQPIGC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CD10", Offset = "0x2A9B310", VA = "0x182A9CD10")]
				internal bool IRZVPOWRYUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CED0", Offset = "0x2A9B4D0", VA = "0x182A9CED0")]
				internal bool ITAEBWSETZM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CE80", Offset = "0x2A9B480", VA = "0x182A9CE80")]
				internal string ISUXEPYHKOD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CE10", Offset = "0x2A9B410", VA = "0x182A9CE10")]
				internal void ISPQHJEKBCU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CF70", Offset = "0x2A9B570", VA = "0x182A9CF70")]
				internal bool IUAMOENRPEF(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2A9CF20", Offset = "0x2A9B520", VA = "0x182A9CF20")]
				internal bool ITVFQXTUFSW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BA80", Offset = "0x2A9A080", VA = "0x182A9BA80")]
				internal bool BRTELKCKBZC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BAD0", Offset = "0x2A9A0D0", VA = "0x182A9BAD0")]
				internal bool BRYLIQWHLKL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BB20", Offset = "0x2A9A120", VA = "0x182A9BB20")]
				internal string BSDSFXQEUVU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BB70", Offset = "0x2A9A170", VA = "0x182A9BB70")]
				internal void BSIZDEKCEHD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BBE0", Offset = "0x2A9A1E0", VA = "0x182A9BBE0")]
				internal bool BSOGALDZNSM(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BC30", Offset = "0x2A9A230", VA = "0x182A9BC30")]
				internal bool BSTMXRXWXDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BC80", Offset = "0x2A9A280", VA = "0x182A9BC80")]
				internal bool BSYTUYRUGPE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BCD0", Offset = "0x2A9A2D0", VA = "0x182A9BCD0")]
				internal bool BTEASFLRQAN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BD20", Offset = "0x2A9A320", VA = "0x182A9BD20")]
				internal string BTJHPMFOZLW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BD70", Offset = "0x2A9A370", VA = "0x182A9BD70")]
				internal void BTOOMSZMIXF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5680", Offset = "0x2AA3C80", VA = "0x182AA5680")]
				internal bool VTUUUFBRLFV(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5630", Offset = "0x2AA3C30", VA = "0x182AA5630")]
				internal bool VTPNWYHUBUM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5720", Offset = "0x2AA3D20", VA = "0x182AA5720")]
				internal bool VUFIOSPMECN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2AA56D0", Offset = "0x2AA3CD0", VA = "0x182AA56D0")]
				internal bool VUABRLVOURE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2AA57E0", Offset = "0x2AA3DE0", VA = "0x182AA57E0")]
				internal string VUPWJGDGWZF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5770", Offset = "0x2AA3D70", VA = "0x182AA5770")]
				internal void VUKPLZJJNNW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5880", Offset = "0x2AA3E80", VA = "0x182AA5880")]
				internal bool VVAKDTRBPVX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5830", Offset = "0x2AA3E30", VA = "0x182AA5830")]
				internal bool VUVDGMXEGKO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2AA55E0", Offset = "0x2AA3BE0", VA = "0x182AA55E0")]
				internal bool VSERQCYMNTB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5590", Offset = "0x2AA3B90", VA = "0x182AA5590")]
				internal bool VRZKSWEPEHS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3FA0", Offset = "0x2AA25A0", VA = "0x182AA3FA0")]
				internal string OTDPVMTOVNM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3FF0", Offset = "0x2AA25F0", VA = "0x182AA3FF0")]
				internal void OTIWSTNMEYV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3F00", Offset = "0x2AA2500", VA = "0x182AA3F00")]
				internal bool OSTCAZFUCQU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3F50", Offset = "0x2AA2550", VA = "0x182AA3F50")]
				internal bool OSYIYFZRMCD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3E60", Offset = "0x2AA2460", VA = "0x182AA3E60")]
				internal bool OSIOGLRZJUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3EB0", Offset = "0x2AA24B0", VA = "0x182AA3EB0")]
				internal bool OSNVDSLWTFL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3DA0", Offset = "0x2AA23A0", VA = "0x182AA3DA0")]
				internal string ORYALYEEQXK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3DF0", Offset = "0x2AA23F0", VA = "0x182AA3DF0")]
				internal void OSDHJEYCAIT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4060", Offset = "0x2AA2660", VA = "0x182AA4060")]
				internal bool OUTSZOWTTAG(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2AA40B0", Offset = "0x2AA26B0", VA = "0x182AA40B0")]
				internal bool OUYZWVQRCLP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D4B0", Offset = "0x2A9BAB0", VA = "0x182A9D4B0")]
				internal bool LNPVZZHDIQN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D460", Offset = "0x2A9BA60", VA = "0x182A9D460")]
				internal bool LNKPCSNFZFE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D410", Offset = "0x2A9BA10", VA = "0x182A9D410")]
				internal string LNFIFLTIPTV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D3A0", Offset = "0x2A9B9A0", VA = "0x182A9D3A0")]
				internal void LNABIEZLGIM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D350", Offset = "0x2A9B950", VA = "0x182A9D350")]
				internal bool LMUUKYFNWXD(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D300", Offset = "0x2A9B900", VA = "0x182A9D300")]
				internal bool LMPNNRLQNLU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D2B0", Offset = "0x2A9B8B0", VA = "0x182A9D2B0")]
				internal bool LMKGQKRTEAL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D260", Offset = "0x2A9B860", VA = "0x182A9D260")]
				internal bool LMEZTDXVUPC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D570", Offset = "0x2A9BB70", VA = "0x182A9D570")]
				internal string LPFZEBKIGDH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D500", Offset = "0x2A9BB00", VA = "0x182A9D500")]
				internal void LPASGUQKWRY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C130", Offset = "0x2A9A730", VA = "0x182A9C130")]
				internal bool EMYRBGZASYE(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C180", Offset = "0x2A9A780", VA = "0x182A9C180")]
				internal bool ENDXYNSYCJN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C1D0", Offset = "0x2A9A7D0", VA = "0x182A9C1D0")]
				internal bool ENJEVUMVLUW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C220", Offset = "0x2A9A820", VA = "0x182A9C220")]
				internal bool ENOLTBGSVGF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2A9BFD0", Offset = "0x2A9A5D0", VA = "0x182A9BFD0")]
				internal string EMDPMFXLHEU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C020", Offset = "0x2A9A620", VA = "0x182A9C020")]
				internal void EMIWJMRIQQD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C090", Offset = "0x2A9A690", VA = "0x182A9C090")]
				internal bool EMODGTLGABM(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C0E0", Offset = "0x2A9A6E0", VA = "0x182A9C0E0")]
				internal bool EMTKEAFDJMV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C270", Offset = "0x2A9A870", VA = "0x182A9C270")]
				internal bool EOOUFJCFQKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2A9C2C0", Offset = "0x2A9A8C0", VA = "0x182A9C2C0")]
				internal bool EOUBCPWCZWH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DCD0", Offset = "0x2A9C2D0", VA = "0x182A9DCD0")]
				internal string NMWDSCLVNXK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DD20", Offset = "0x2A9C320", VA = "0x182A9DD20")]
				internal void NNBKPJFSXIT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DD90", Offset = "0x2A9C390", VA = "0x182A9DD90")]
				internal bool NNLYJWTNQFL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DB70", Offset = "0x2A9C170", VA = "0x182A9DB70")]
				internal bool NMBCDBKGCEA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DBC0", Offset = "0x2A9C1C0", VA = "0x182A9DBC0")]
				internal bool NMGJAIEDLPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DC10", Offset = "0x2A9C210", VA = "0x182A9DC10")]
				internal string NMLPXOYAVAS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DC60", Offset = "0x2A9C260", VA = "0x182A9DC60")]
				internal void NMQWUVRYEMB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DDE0", Offset = "0x2A9C3E0", VA = "0x182A9DDE0")]
				internal bool NOMGWEPALKE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DE30", Offset = "0x2A9C430", VA = "0x182A9DE30")]
				internal bool NORNTLIXUVN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2AA54F0", Offset = "0x2AA3AF0", VA = "0x182AA54F0")]
				internal bool UNNIQUTYDPT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2AA54A0", Offset = "0x2AA3AA0", VA = "0x182AA54A0")]
				internal string UNIBTOAAUEK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5430", Offset = "0x2AA3A30", VA = "0x182AA5430")]
				internal void UNCUWHGDKTB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2AA53E0", Offset = "0x2AA39E0", VA = "0x182AA53E0")]
				internal bool UMXNZAMGBHS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5390", Offset = "0x2AA3990", VA = "0x182AA5390")]
				internal bool UMSHBTSIRWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5340", Offset = "0x2AA3940", VA = "0x182AA5340")]
				internal bool UMNAEMYLILA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2AA52F0", Offset = "0x2AA38F0", VA = "0x182AA52F0")]
				internal string UMHTHGENYZR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5280", Offset = "0x2AA3880", VA = "0x182AA5280")]
				internal void UMCMJZKQPOI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2AA5540", Offset = "0x2AA3B40", VA = "0x182AA5540")]
				internal bool UOYEXQDFRRE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2A9B8E0", Offset = "0x2A99EE0", VA = "0x182A9B8E0")]
				internal bool AOGPCFDAHLU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D980", Offset = "0x2A9BF80", VA = "0x182A9D980")]
				internal float MRAIVLEZXUC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D9D0", Offset = "0x2A9BFD0", VA = "0x182A9D9D0")]
				internal void MRFPSRYXHFL(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DA30", Offset = "0x2A9C030", VA = "0x182A9DA30")]
				internal bool MRKWPYSUQQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DA80", Offset = "0x2A9C080", VA = "0x182A9DA80")]
				internal bool MRQDNFMSACD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DAD0", Offset = "0x2A9C0D0", VA = "0x182A9DAD0")]
				internal bool MRVKKMGPJNM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2A9DB20", Offset = "0x2A9C120", VA = "0x182A9DB20")]
				internal int MSARHTAMSYV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D8D0", Offset = "0x2A9BED0", VA = "0x182A9D8D0")]
				internal void MOZRWVOAHKQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2A9D930", Offset = "0x2A9BF30", VA = "0x182A9D930")]
				internal bool MPEYUCHXQVZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4EE0", Offset = "0x2AA34E0", VA = "0x182AA4EE0")]
				internal bool SRJBMIAHITL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2AA4E90", Offset = "0x2AA3490", VA = "0x182AA4E90")]
				internal bool SRDUPBGJZIC()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class AVBHBXRCQLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string KUAWOQPFAJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public AUWAEQXFGZW GOOXOIYUWOV;

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public AVBHBXRCQLF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2ABDB60", Offset = "0x2ABC160", VA = "0x182ABDB60")]
				internal void RSHCVJYKFHJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class AVGNZEKZZWO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] EZVEGAINEWH;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public AVGNZEKZZWO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2ABE6E0", Offset = "0x2ABCCE0", VA = "0x182ABE6E0")]
				internal bool MQVBYELCOIT(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers YDBSSNOJYJU;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD470", Offset = "0x2AABA70", VA = "0x182AAD470")]
			public EZOWLGAGYCY(GCFTXZUHCVV a, BVAXERKHHAJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2AAB900", Offset = "0x2AA9F00", VA = "0x182AAB900", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class CGZNDKOTHKR : FVXBTFLYTRK<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF130", Offset = "0x2ABD730", VA = "0x182ABF130")]
			public CGZNDKOTHKR(GCFTXZUHCVV a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2ABE880", Offset = "0x2ABCE80", VA = "0x182ABE880", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEB30", Offset = "0x2ABD130", VA = "0x182ABEB30")]
			private static string FYVNWUYQSSV(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEEE0", Offset = "0x2ABD4E0", VA = "0x182ABEEE0")]
			[CompilerGenerated]
			private object? JJVICUUWOIO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEF80", Offset = "0x2ABD580", VA = "0x182ABEF80")]
			[CompilerGenerated]
			private void JKAPABOTXTX(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEC30", Offset = "0x2ABD230", VA = "0x182ABEC30")]
			[CompilerGenerated]
			private string JJKUIHHBVLW(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEE40", Offset = "0x2ABD440", VA = "0x182ABEE40")]
			[CompilerGenerated]
			private IReadOnlyList<object> JJQBFOAZEXF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF090", Offset = "0x2ABD690", VA = "0x182ABF090")]
			[CompilerGenerated]
			private string? JKQJRVWMABY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF0F0", Offset = "0x2ABD6F0", VA = "0x182ABF0F0")]
			[CompilerGenerated]
			private bool JKVQPCQJJNH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class YHWEBWJYZSP : FVXBTFLYTRK<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
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
					public XIPYLIIUTHZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60002FE")]
					[Cpp2IlInjected.Address(RVA = "0x2ACD1B0", Offset = "0x2ACB7B0", VA = "0x182ACD1B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60002FF")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public YHWEBWJYZSP CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6460", Offset = "0x2AD4A60", VA = "0x182AD6460")]
				internal string GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6750", Offset = "0x2AD4D50", VA = "0x182AD6750")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void GPRDWPZCBUZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5E40", Offset = "0x2AD4440", VA = "0x182AD5E40")]
				internal int GPBJEVRJZMY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2AD61D0", Offset = "0x2AD47D0", VA = "0x182AD61D0")]
				internal void GPGQCCLHIYH(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AD86F0", Offset = "0x2AD6CF0", VA = "0x182AD86F0")]
			public YHWEBWJYZSP(GCFTXZUHCVV a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AD83C0", Offset = "0x2AD69C0", VA = "0x182AD83C0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class XKODSMSUWGA : FVXBTFLYTRK<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class RPGDRVSGBNA
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
					public RPGDRVSGBNA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000313")]
					[Cpp2IlInjected.Address(RVA = "0x2ACCE70", Offset = "0x2ACB470", VA = "0x182ACCE70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000314")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public RPGDRVSGBNA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2ACD760", Offset = "0x2ACBD60", VA = "0x182ACD760", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public XKODSMSUWGA CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public RPGDRVSGBNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6410", Offset = "0x2AC4A10", VA = "0x182AC6410")]
				internal string GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6460", Offset = "0x2AC4A60", VA = "0x182AC6460")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void GPRDWPZCBUZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6330", Offset = "0x2AC4930", VA = "0x182AC6330")]
				internal int GPBJEVRJZMY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6380", Offset = "0x2AC4980", VA = "0x182AC6380")]
				internal Task<bool> GPGQCCLHIYH(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6210", Offset = "0x2AC4810", VA = "0x182AC6210")]
				internal string GOQVKIDPGQG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6260", Offset = "0x2AC4860", VA = "0x182AC6260")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void GOWCHOXMQBP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6130", Offset = "0x2AC4730", VA = "0x182AC6130")]
				internal bool GOGHPUPUNTO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6180", Offset = "0x2AC4780", VA = "0x182AC6180")]
				internal void GOLONBJRXEX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6530", Offset = "0x2AC4B30", VA = "0x182AC6530")]
				internal bool GRCADLIJPWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6580", Offset = "0x2AC4B80", VA = "0x182AC6580")]
				internal void GRHHASCGZHT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6710", Offset = "0x2AC4D10", VA = "0x182AC6710")]
				internal float NQHTLKXKZZB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6680", Offset = "0x2AC4C80", VA = "0x182AC6680")]
				internal void NQCMOEDNQNS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6800", Offset = "0x2AC4E00", VA = "0x182AC6800")]
				internal int NQSHFYLFSVT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6760", Offset = "0x2AC4D60", VA = "0x182AC6760")]
				internal void NQNAIRRIJKK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6610", Offset = "0x2AC4C10", VA = "0x182AC6610")]
				internal bool NPMRWJVVOFR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2AD7FE0", Offset = "0x2AD65E0", VA = "0x182AD7FE0")]
			public XKODSMSUWGA(GCFTXZUHCVV a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2AD7680", Offset = "0x2AD5C80", VA = "0x182AD7680", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class PIWJWOAVDDB : FVXBTFLYTRK<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public PIWJWOAVDDB CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6500", Offset = "0x2AD4B00", VA = "0x182AD6500")]
				internal Dictionary<string, EnumChoiceData> GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6940", Offset = "0x2AD4F40", VA = "0x182AD6940")]
				internal int GPRDWPZCBUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5E90", Offset = "0x2AD4490", VA = "0x182AD5E90")]
				internal void GPBJEVRJZMY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6150", Offset = "0x2AD4750", VA = "0x182AD6150")]
				internal bool GPGQCCLHIYH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5850", Offset = "0x2AC3E50", VA = "0x182AC5850")]
			public PIWJWOAVDDB(GCFTXZUHCVV a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2AC55A0", Offset = "0x2AC3BA0", VA = "0x182AC55A0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class ODLVSEHKAIO : FVXBTFLYTRK<EXTJBQYAYXR>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public ODLVSEHKAIO CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6350", Offset = "0x2AD4950", VA = "0x182AD6350")]
				internal void GPLWZJFESJQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4BA0", Offset = "0x2AC31A0", VA = "0x182AC4BA0")]
			public ODLVSEHKAIO(GCFTXZUHCVV a, EXTJBQYAYXR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4A20", Offset = "0x2AC3020", VA = "0x182AC4A20", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class LAVQVILNBWQ<a> : ZIZOVKEJUZB<a> where a : notnull, QZERBMOVQQY
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override QIIJQLZWJRR? HOOXRHOKBWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x5464660", Offset = "0x5462C60", VA = "0x185464660", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x54646C0", Offset = "0x5462CC0", VA = "0x1854646C0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xF84B40", Offset = "0xF83140", VA = "0x180F84B40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x54646A0", Offset = "0x5462CA0", VA = "0x1854646A0")]
			public LAVQVILNBWQ(GCFTXZUHCVV a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class TTAWTNCNTDC : LAVQVILNBWQ<ECWMIXYRRQB>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class AUWAEQXFGZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public TTAWTNCNTDC CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public AUWAEQXFGZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x2ABD9E0", Offset = "0x2ABBFE0", VA = "0x182ABD9E0")]
				internal object GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x2ABDA90", Offset = "0x2ABC090", VA = "0x182ABDA90")]
				internal void GPRDWPZCBUZ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2ABD900", Offset = "0x2ABBF00", VA = "0x182ABD900")]
				internal void GPBJEVRJZMY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? OPJRIDSMGAW;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7D30", Offset = "0x2AC6330", VA = "0x182AC7D30")]
			public TTAWTNCNTDC(GCFTXZUHCVV a, ECWMIXYRRQB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC77C0", Offset = "0x2AC5DC0", VA = "0x182AC77C0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class CTTGKEIJHGP : FVXBTFLYTRK<TOXBTNRASRG>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public CTTGKEIJHGP CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<FLWSVPBGFWX>> TJKESIUOWYR;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x2AC40F0", Offset = "0x2AC26F0", VA = "0x182AC40F0")]
				internal int GPRDWPZCBUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3730", Offset = "0x2AC1D30", VA = "0x182AC3730")]
				internal void GPBJEVRJZMY(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class MVUFAWQIRUG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<FLWSVPBGFWX> ZUGZMARQNVN;

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVUFAWQIRUG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2AC31C0", Offset = "0x2AC17C0", VA = "0x182AC31C0")]
				internal bool GOQVKIDPGQG(Id32<FLWSVPBGFWX> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2ABFA70", Offset = "0x2ABE070", VA = "0x182ABFA70")]
			public CTTGKEIJHGP(GCFTXZUHCVV a, TOXBTNRASRG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF560", Offset = "0x2ABDB60", VA = "0x182ABF560", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class RXATQVKPEFN : FVXBTFLYTRK<WIWZRDFTBHO>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xE81E30", Offset = "0xE80430", VA = "0x180E81E30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC68A0", Offset = "0x2AC4EA0", VA = "0x182AC68A0")]
			public RXATQVKPEFN(GCFTXZUHCVV a, WIWZRDFTBHO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class WKKWQRXBSAI : FVXBTFLYTRK<RUCLYRSMJZL>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0xC1A480", Offset = "0xC18A80", VA = "0x180C1A480", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4580", Offset = "0x2AD2B80", VA = "0x182AD4580")]
			public WKKWQRXBSAI(GCFTXZUHCVV a, RUCLYRSMJZL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "134")]
			protected override bool WHUHKRPFOAQ(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class BWEHFOKHUUU : FVXBTFLYTRK<JLJXWGVXDAB>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0xD8C2E0", Offset = "0xD8A8E0", VA = "0x180D8C2E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0x2ABE830", Offset = "0x2ABCE30", VA = "0x182ABE830", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2ABE7C0", Offset = "0x2ABCDC0", VA = "0x182ABE7C0")]
			public BWEHFOKHUUU(GCFTXZUHCVV a, JLJXWGVXDAB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class TIWAGYIMTRK : FVXBTFLYTRK<LDRWHBMGEFP>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x2AC7770", Offset = "0x2AC5D70", VA = "0x182AC7770", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7700", Offset = "0x2AC5D00", VA = "0x182AC7700")]
			public TIWAGYIMTRK(GCFTXZUHCVV a, LDRWHBMGEFP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class TIJXMHKXLAZ : KEZLQRWUJUU<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public TIJXMHKXLAZ CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC4520", Offset = "0x2AC2B20", VA = "0x182AC4520")]
				internal float MNJJIHHVNDV()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC43E0", Offset = "0x2AC29E0", VA = "0x182AC43E0")]
				internal void MNECLANYDSM(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC76A0", Offset = "0x2AC5CA0", VA = "0x182AC76A0")]
			public TIJXMHKXLAZ(GCFTXZUHCVV a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7430", Offset = "0x2AC5A30", VA = "0x182AC7430", Slot = "151")]
			protected override void CHRWEKIUYRV(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class UCHQOZVJCLM : FVXBTFLYTRK<THLWQWEDYPV>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2ACE140", Offset = "0x2ACC740", VA = "0x182ACE140")]
			public UCHQOZVJCLM(GCFTXZUHCVV a, THLWQWEDYPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class JWCINVVDNPE : FVXBTFLYTRK<THIDEVABVNR>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000353")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0E40", Offset = "0x2ABF440", VA = "0x182AC0E40")]
			public JWCINVVDNPE(GCFTXZUHCVV a, THIDEVABVNR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class ZAPBPEPLWWT : FVXBTFLYTRK<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public ZAPBPEPLWWT CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3B50", Offset = "0x2AC2150", VA = "0x182AC3B50")]
				internal bool GPLWZJFESJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3E80", Offset = "0x2AC2480", VA = "0x182AC3E80")]
				internal void GPRDWPZCBUZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8A50", Offset = "0x2AD7050", VA = "0x182AD8A50")]
			public ZAPBPEPLWWT(GCFTXZUHCVV a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2AD87C0", Offset = "0x2AD6DC0", VA = "0x182AD87C0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class OUKXESETBFN : FVXBTFLYTRK<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public OUKXESETBFN CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> LHBWVQNJDZG;

				[Cpp2IlInjected.Token(Token = "0x600035D")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3930", Offset = "0x2AC1F30", VA = "0x182AC3930")]
				internal object? GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3340", Offset = "0x2AC1940", VA = "0x182AC3340")]
				internal bool GOLONBJRXEX(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3C30", Offset = "0x2AC2230", VA = "0x182AC3C30")]
				internal void GPRDWPZCBUZ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2AC35E0", Offset = "0x2AC1BE0", VA = "0x182AC35E0")]
				internal string GPBJEVRJZMY(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3890", Offset = "0x2AC1E90", VA = "0x182AC3890")]
				internal IReadOnlyList<object> GPGQCCLHIYH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2AC33C0", Offset = "0x2AC19C0", VA = "0x182AC33C0")]
				internal bool GOQVKIDPGQG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3430", Offset = "0x2AC1A30", VA = "0x182AC3430")]
				internal bool GOWCHOXMQBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3210", Offset = "0x2AC1810", VA = "0x182AC3210")]
				internal void GOGHPUPUNTO(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5530", Offset = "0x2AC3B30", VA = "0x182AC5530")]
			public OUKXESETBFN(GCFTXZUHCVV a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4E50", Offset = "0x2AC3450", VA = "0x182AC4E50", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class XAMBZWBMGHD : FVXBTFLYTRK<ITSQTRQQIIS>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class RPGDRVSGBNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int SCNAXJBGXBV;

				[Cpp2IlInjected.Token(Token = "0x600036B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public RPGDRVSGBNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6860", Offset = "0x2AC4E60", VA = "0x182AC6860")]
				internal bool RUMJUJRNBSH(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class XMEHEWGCGRP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public XAMBZWBMGHD CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> UEOQSTCZNMD;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XMEHEWGCGRP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8100", Offset = "0x2AD6700", VA = "0x182AD8100")]
				internal int GPLWZJFESJQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0x2AD81A0", Offset = "0x2AD67A0", VA = "0x182AD81A0")]
				internal void GPRDWPZCBUZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8050", Offset = "0x2AD6650", VA = "0x182AD8050")]
				internal string? GPBJEVRJZMY()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4D90", Offset = "0x2AD3390", VA = "0x182AD4D90")]
			public XAMBZWBMGHD(GCFTXZUHCVV a, ITSQTRQQIIS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4D00", Offset = "0x2AD3300", VA = "0x182AD4D00")]
			private int USCIRFBBQCX(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4BE0", Offset = "0x2AD31E0", VA = "0x182AD4BE0")]
			private void QLFBIYZDCWT(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4890", Offset = "0x2AD2E90", VA = "0x182AD4890", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class ZZOGNXSIZFI : BZWDYVMXVQK<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0xF9EE30", Offset = "0xF9D430", VA = "0x180F9EE30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2AD90A0", Offset = "0x2AD76A0", VA = "0x182AD90A0")]
			public ZZOGNXSIZFI(GCFTXZUHCVV a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class MYUQRZIIYBW : KEZLQRWUJUU<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public MYUQRZIIYBW CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x6000375")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000376")]
				[Cpp2IlInjected.Address(RVA = "0x2AC45A0", Offset = "0x2AC2BA0", VA = "0x182AC45A0")]
				internal int MNJJIHHVNDV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x2AC4480", Offset = "0x2AC2A80", VA = "0x182AC4480")]
				internal void MNECLANYDSM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2AC49C0", Offset = "0x2AC2FC0", VA = "0x182AC49C0")]
			public MYUQRZIIYBW(GCFTXZUHCVV a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4750", Offset = "0x2AC2D50", VA = "0x182AC4750", Slot = "151")]
			protected override void CHRWEKIUYRV(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class ZFNHKJGYIXU : FVXBTFLYTRK<HBQQSTAXRAX>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public ZFNHKJGYIXU CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<FLWSVPBGFWX>> TJKESIUOWYR;

				[Cpp2IlInjected.Token(Token = "0x600037E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600037F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3FB0", Offset = "0x2AC25B0", VA = "0x182AC3FB0")]
				internal int GPRDWPZCBUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3480", Offset = "0x2AC1A80", VA = "0x182AC3480")]
				internal void GPBJEVRJZMY(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class MVUFAWQIRUG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<FLWSVPBGFWX> ZUGZMARQNVN;

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVUFAWQIRUG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3170", Offset = "0x2AC1770", VA = "0x182AC3170")]
				internal bool GOQVKIDPGQG(Id32<FLWSVPBGFWX> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8FD0", Offset = "0x2AD75D0", VA = "0x182AD8FD0")]
			public ZFNHKJGYIXU(GCFTXZUHCVV a, HBQQSTAXRAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8AC0", Offset = "0x2AD70C0", VA = "0x182AD8AC0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class MQYQWNRGKGA : FVXBTFLYTRK<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public MQYQWNRGKGA CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x6000385")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3AB0", Offset = "0x2AC20B0", VA = "0x182AC3AB0")]
				internal bool GPLWZJFESJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0x2AC4230", Offset = "0x2AC2830", VA = "0x182AC4230")]
				internal void GPRDWPZCBUZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3100", Offset = "0x2AC1700", VA = "0x182AC3100")]
			public MQYQWNRGKGA(GCFTXZUHCVV a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2F30", Offset = "0x2AC1530", VA = "0x182AC2F30", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class OPHWDNFXULO : FVXBTFLYTRK<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public OPHWDNFXULO CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3A60", Offset = "0x2AC2060", VA = "0x182AC3A60")]
				internal bool GPLWZJFESJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC42C0", Offset = "0x2AC28C0", VA = "0x182AC42C0")]
				internal void GPRDWPZCBUZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4DE0", Offset = "0x2AC33E0", VA = "0x182AC4DE0")]
			public OPHWDNFXULO(GCFTXZUHCVV a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4C10", Offset = "0x2AC3210", VA = "0x182AC4C10", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class SZSSCHOXMIC : FVXBTFLYTRK<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public SZSSCHOXMIC CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x600038F")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3B00", Offset = "0x2AC2100", VA = "0x182AC3B00")]
				internal int GPLWZJFESJQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0x2AC4350", Offset = "0x2AC2950", VA = "0x182AC4350")]
				internal void GPRDWPZCBUZ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC73C0", Offset = "0x2AC59C0", VA = "0x182AC73C0")]
			public SZSSCHOXMIC(GCFTXZUHCVV a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7170", Offset = "0x2AC5770", VA = "0x182AC7170", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class IIHSRSHETSR
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log WOAZIZZDVRE;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class XUNFQYHVPWW<a> : FVXBTFLYTRK<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class BUHEGFXHPGF
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
					public BUHEGFXHPGF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C6")]
					[Cpp2IlInjected.Address(RVA = "0x3F81C70", Offset = "0x3F80270", VA = "0x183F81C70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C7")]
					[Cpp2IlInjected.Address(RVA = "0x3F81FB0", Offset = "0x3F805B0", VA = "0x183F81FB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload WLWEZELXZHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public XUNFQYHVPWW<a> CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public BUHEGFXHPGF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x72126F0", Offset = "0x7210CF0", VA = "0x1872126F0")]
				[AsyncStateMachine(typeof(XUNFQYHVPWW<>.BUHEGFXHPGF.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task JYDYTPEGNNQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0x72127C0", Offset = "0x7210DC0", VA = "0x1872127C0")]
				internal void QQGENEVWPPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class EDWAHUFUCKX
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
					public EDWAHUFUCKX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003D9")]
					[Cpp2IlInjected.Address(RVA = "0x3F94890", Offset = "0x3F92E90", VA = "0x183F94890", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DA")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public EDWAHUFUCKX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3F95FA0", Offset = "0x3F945A0", VA = "0x183F95FA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0x3F966A0", Offset = "0x3F94CA0", VA = "0x183F966A0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public JFQCZHJIKAB.ALXDQNMOBSX ACJGDRDNIOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string NOTTMPDMACJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string BTVCJFYNNQP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public XUNFQYHVPWW<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper YWWBZASHWZB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool MAJNSKRDAGV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action KDDCJCHWAYX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool UCFWDEHLOXR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string USPCRHIXOUJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action FJEKRIDTYVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action YJYBZLEYXEN;

				[Cpp2IlInjected.Token(Token = "0x60003C8")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public EDWAHUFUCKX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0x4926650", Offset = "0x4924C50", VA = "0x184926650")]
				internal void MRXUPCKIQWO(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x49266A0", Offset = "0x4924CA0", VA = "0x1849266A0")]
				internal void MSDBMJEGAHX(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
				internal string GRROXOVIINP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x4926290", Offset = "0x4924890", VA = "0x184926290")]
				internal void GRMIAIBKZCG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0x4926280", Offset = "0x4924880", VA = "0x184926280")]
				internal bool GRHBDBHNPQX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x49261E0", Offset = "0x49247E0", VA = "0x1849261E0")]
				internal char GRBUFUNQGFO((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
				internal string? GSMQMPWXUGZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0xF93650", Offset = "0xF91C50", VA = "0x180F93650")]
				internal bool GSHJPJDAKVQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0x4926470", Offset = "0x4924A70", VA = "0x184926470")]
				internal void GSCCSCJDBKH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0x4926280", Offset = "0x4924880", VA = "0x184926280")]
				internal bool GRWVUVPFRYY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x4926140", Offset = "0x4924740", VA = "0x184926140")]
				[AsyncStateMachine(typeof(XUNFQYHVPWW<>.EDWAHUFUCKX.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void GQBLTMSDLAV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x4925F40", Offset = "0x4924540", VA = "0x184925F40")]
				internal void DXGBUKAPDYT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x4926710", Offset = "0x4924D10", VA = "0x184926710")]
				[AsyncStateMachine(typeof(XUNFQYHVPWW<>.EDWAHUFUCKX.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task ZSSYDRCKTYE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x4926530", Offset = "0x4924B30", VA = "0x184926530")]
				internal void MQMYIHBBCVD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x4926040", Offset = "0x4924640", VA = "0x184926040")]
				internal void FRGPQKCGBEF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x4926100", Offset = "0x4924700", VA = "0x184926100")]
				internal bool GPWEWFYGBPM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class ITTNULAAUZY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter YPXAGYBLTSP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public XUNFQYHVPWW<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<JFQCZHJIKAB.EHBKVHLZVIL> FKPGYDNBMWW;

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ITTNULAAUZY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0x51DF0B0", Offset = "0x51DD6B0", VA = "0x1851DF0B0")]
				internal bool TLKIOTHVLVM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0x51DEFF0", Offset = "0x51DD5F0", VA = "0x1851DEFF0")]
				internal void NRGLOYGKQFQ(JFQCZHJIKAB.EHBKVHLZVIL a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class ITYURRTYELH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool HBCBNRJNKMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public SKAFPSIOIMI NBWMEYXMGZN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public SKAFPSIOIMI VZSLYQCGTDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public SKAFPSIOIMI WHGJDKMXBRF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string OTEBQRGZRJS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public ITTNULAAUZY GOOXOIYUWOV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action LFBFXAWJNPU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action FKKAAWTEDLN;

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ITYURRTYELH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0xB56990", Offset = "0xB54F90", VA = "0x180B56990")]
				internal bool WHLVHRJJLGO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x51DF230", Offset = "0x51DD830", VA = "0x1851DF230")]
				internal void MDGYFWOFOJV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x51DF730", Offset = "0x51DDD30", VA = "0x1851DF730")]
				internal void TLFBRMNYCKD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x51DF330", Offset = "0x51DD930", VA = "0x1851DF330")]
				internal void TMFKDUJKXOW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x51DF350", Offset = "0x51DD950", VA = "0x1851DF350")]
				internal void TKETFESLHFK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x51DFB80", Offset = "0x51DE180", VA = "0x1851DFB80")]
				internal void TLPPMABSVGV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x51DF330", Offset = "0x51DD930", VA = "0x1851DF330")]
				internal void NRBERRMNGUH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class ITIZZXMGCDG
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
					public ITIZZXMGCDG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003EB")]
					[Cpp2IlInjected.Address(RVA = "0x3FA4110", Offset = "0x3FA2710", VA = "0x183FA4110", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EC")]
					[Cpp2IlInjected.Address(RVA = "0x3FA4740", Offset = "0x3FA2D40", VA = "0x183FA4740", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool ZXQVAYEVMSN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public ITYURRTYELH GNZCWORCUGU;

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ITIZZXMGCDG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x51DEBE0", Offset = "0x51DD1E0", VA = "0x1851DEBE0")]
				[AsyncStateMachine(typeof(XUNFQYHVPWW<>.ITIZZXMGCDG.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task SVEUKLHTJRL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x51DECB0", Offset = "0x51DD2B0", VA = "0x1851DECB0")]
				internal void TMKRBBDIHAF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class ITOGXEGDLOP
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
					public ITOGXEGDLOP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F0")]
					[Cpp2IlInjected.Address(RVA = "0x3FA3B10", Offset = "0x3FA2110", VA = "0x183FA3B10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F1")]
					[Cpp2IlInjected.Address(RVA = "0x3FA40B0", Offset = "0x3FA26B0", VA = "0x183FA40B0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload WYPKRGBPZJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public ITYURRTYELH GOEJTVLADSD;

				[Cpp2IlInjected.Token(Token = "0x60003ED")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ITOGXEGDLOP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EE")]
				[Cpp2IlInjected.Address(RVA = "0x51DED20", Offset = "0x51DD320", VA = "0x1851DED20")]
				[AsyncStateMachine(typeof(XUNFQYHVPWW<>.ITOGXEGDLOP.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task GVDEZGULPYY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0x51DEDF0", Offset = "0x51DD3F0", VA = "0x1851DEDF0")]
				internal void NQVXUKSPXIY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class NUCXBFCPWAP
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
					public NUCXBFCPWAP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F7")]
					[Cpp2IlInjected.Address(RVA = "0x3FA3630", Offset = "0x3FA1C30", VA = "0x183FA3630", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F8")]
					[Cpp2IlInjected.Address(RVA = "0x3FA3AB0", Offset = "0x3FA20B0", VA = "0x183FA3AB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public XUNFQYHVPWW<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload LMLPPANIKGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public JFQCZHJIKAB.EHBKVHLZVIL ACJGDRDNIOE;

				[Cpp2IlInjected.Token(Token = "0x60003F2")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public NUCXBFCPWAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F3")]
				[Cpp2IlInjected.Address(RVA = "0x5A8E010", Offset = "0x5A8C610", VA = "0x185A8E010")]
				[AsyncStateMachine(typeof(XUNFQYHVPWW<>.NUCXBFCPWAP.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task ZXUIGMQZGSG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0x5A8DA90", Offset = "0x5A8C090", VA = "0x185A8DA90")]
				internal bool ADPIYNJZYUA(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5A8DBC0", Offset = "0x5A8C1C0", VA = "0x185A8DBC0")]
				internal void AEFDQHRSBCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5A8DB70", Offset = "0x5A8C170", VA = "0x185A8DB70")]
				internal void ADZWTAXURQS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class JDPERVANSRK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string AJSYRZFCHPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public SKAFPSIOIMI EAIIIORJPNI;

				[Cpp2IlInjected.Token(Token = "0x60003F9")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public JDPERVANSRK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FA")]
				[Cpp2IlInjected.Address(RVA = "0x52AB4D0", Offset = "0x52A9AD0", VA = "0x1852AB4D0")]
				internal string? WCEIYKOVFOZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xC3D300", Offset = "0xC3B900", VA = "0x180C3D300")]
				internal bool WBZCBDUXWDQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x52AB460", Offset = "0x52A9A60", VA = "0x1852AB460")]
				internal void WBTVDXBAMSH(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool CTJPWLONUBK;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log WOAZIZZDVRE
			{
				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x4093D20", Offset = "0x4092320", VA = "0x184093D20")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x40953C0", Offset = "0x40939C0", VA = "0x1840953C0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected JFQCZHJIKAB CPKYQCCQOVS
			{
				[Cpp2IlInjected.Token(Token = "0x600039B")]
				[Cpp2IlInjected.Address(RVA = "0xAA9E90", Offset = "0xAA8490", VA = "0x180AA9E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0xAA9E70", Offset = "0xAA8470", VA = "0x180AA9E70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> HVXCKWEEVGH
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xB0E990", Offset = "0xB0CF90", VA = "0x180B0E990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xB99060", Offset = "0xB97660", VA = "0x180B99060")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected WCIVLDDQGBD DXIRPPEWFLE
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xB10300", Offset = "0xB0E900", VA = "0x180B10300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xB10E30", Offset = "0xB0F430", VA = "0x180B10E30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected MJFDITXXZZZ YSUMDDOIWEY
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xB0E9A0", Offset = "0xB0CFA0", VA = "0x180B0E9A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0xB0E7E0", Offset = "0xB0CDE0", VA = "0x180B0E7E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x4095390", Offset = "0x4093990", VA = "0x184095390")]
			protected XUNFQYHVPWW(GCFTXZUHCVV a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x4092570", Offset = "0x4090B70", VA = "0x184092570", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x4092520", Offset = "0x4090B20", VA = "0x184092520", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x4092650", Offset = "0x4090C50", VA = "0x184092650", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4093E20", Offset = "0x4092420", VA = "0x184093E20")]
			private void QYOJWPCCYTP(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x4090F20", Offset = "0x408F520", VA = "0x184090F20", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x4093670", Offset = "0x4091C70", VA = "0x184093670")]
			private void HDQVEADVBMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x4092BA0", Offset = "0x40911A0", VA = "0x184092BA0")]
			private void HBZAHKVQVVP(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "151")]
			protected virtual void JSVHBRSXZQU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x4094E90", Offset = "0x4093490", VA = "0x184094E90")]
			private void UIBVTYLTRUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4091AA0", Offset = "0x40900A0", VA = "0x184091AA0")]
			private void CZBPARTDYFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x40940E0", Offset = "0x40926E0", VA = "0x1840940E0")]
			private void SGQHDVCPHLJ(JFQCZHJIKAB.EHBKVHLZVIL a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x40929A0", Offset = "0x4090FA0", VA = "0x1840929A0")]
			private void GHGNVLJZQBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x4095030", Offset = "0x4093630", VA = "0x184095030")]
			protected void XDXBZONIXPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x4093D70", Offset = "0x4092370", VA = "0x184093D70")]
			private void JELGZAQEHSH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x4090F00", Offset = "0x408F500", VA = "0x184090F00")]
			private void AIQERCJNLYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x4091A40", Offset = "0x4090040", VA = "0x184091A40")]
			private void CQOOKFFATGO(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x40926A0", Offset = "0x4090CA0", VA = "0x1840926A0")]
			private string FEZKWYHIUIQ((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x40925C0", Offset = "0x4090BC0", VA = "0x1840925C0")]
			private string DOOHUAWRRPR(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x40919A0", Offset = "0x408FFA0", VA = "0x1840919A0")]
			[CompilerGenerated]
			private object? CPAUDRYJUUX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4091240", Offset = "0x408F840", VA = "0x184091240")]
			[CompilerGenerated]
			private void COVNGLEMLJO(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x40919D0", Offset = "0x408FFD0", VA = "0x1840919D0")]
			[CompilerGenerated]
			private IReadOnlyList<object> CPGBAYSHEGG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x40911B0", Offset = "0x408F7B0", VA = "0x1840911B0")]
			[CompilerGenerated]
			private void COFSOQWUJBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x4091160", Offset = "0x408F760", VA = "0x184091160")]
			[CompilerGenerated]
			private void CNFKCJBHNWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x4093DE0", Offset = "0x40923E0", VA = "0x184093DE0")]
			[CompilerGenerated]
			private void KRUFJBMSZXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x4095060", Offset = "0x4093660", VA = "0x184095060")]
			[CompilerGenerated]
			private void XYVBOKWXQSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x4091120", Offset = "0x408F720", VA = "0x184091120")]
			[CompilerGenerated]
			private void CKDLSDSUGBV(JFQCZHJIKAB.EHBKVHLZVIL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class PZSWVXQGISZ : XUNFQYHVPWW<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xD8C2E0", Offset = "0xD8A8E0", VA = "0x180D8C2E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5C40", Offset = "0x2AC4240", VA = "0x182AC5C40")]
			public PZSWVXQGISZ(GCFTXZUHCVV a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class XAPFYACEWRL : XUNFQYHVPWW<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type KITVDRHTKPY
				{
					[Cpp2IlInjected.Token(Token = "0x6000405")]
					[Cpp2IlInjected.Address(RVA = "0x2AC6CD0", Offset = "0x2AC52D0", VA = "0x182AC6CD0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope UCZGYZQMKYD
				{
					[Cpp2IlInjected.Token(Token = "0x6000406")]
					[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string CUHMVJLQTEB
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000404")]
				[Cpp2IlInjected.Address(RVA = "0x1486B80", Offset = "0x1485180", VA = "0x181486B80")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6D20", Offset = "0x2AC5320", VA = "0x182AC6D20", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6C00", Offset = "0x2AC5200", VA = "0x182AC6C00", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool LTZCKPPFHTI(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6AF0", Offset = "0x2AC50F0", VA = "0x182AC6AF0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6A60", Offset = "0x2AC5060", VA = "0x182AC6A60", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6910", Offset = "0x2AC4F10", VA = "0x182AC6910", Slot = "7")]
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
				protected virtual Type KITVDRHTKPY
				{
					[Cpp2IlInjected.Token(Token = "0x600040E")]
					[Cpp2IlInjected.Address(RVA = "0x2AC8150", Offset = "0x2AC6750", VA = "0x182AC8150", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers DXWROZZOHMJ
				{
					[Cpp2IlInjected.Token(Token = "0x600040F")]
					[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string CUHMVJLQTEB
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x1486B80", Offset = "0x1485180", VA = "0x181486B80")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000411")]
				[Cpp2IlInjected.Address(RVA = "0x2AC81A0", Offset = "0x2AC67A0", VA = "0x182AC81A0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000412")]
				[Cpp2IlInjected.Address(RVA = "0x2AC8080", Offset = "0x2AC6680", VA = "0x182AC8080", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool LTZCKPPFHTI(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2AC7F70", Offset = "0x2AC6570", VA = "0x182AC7F70", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2AC7D90", Offset = "0x2AC6390", VA = "0x182AC7D90", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2AC7E20", Offset = "0x2AC6420", VA = "0x182AC7E20", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
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
					public XIPYLIIUTHZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000423")]
					[Cpp2IlInjected.Address(RVA = "0x2ACC150", Offset = "0x2ACA750", VA = "0x182ACC150", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000424")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public XIPYLIIUTHZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2ACC570", Offset = "0x2ACAB70", VA = "0x182ACC570", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public XAPFYACEWRL CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public WCIVLDDQGBD NQQFZTKVKRW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> LFGMUHQGXBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> LFBFXAWJNPU;

				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6F90", Offset = "0x2AD5590", VA = "0x182AD6F90")]
				internal object? RNQWNFYNDPE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6ED0", Offset = "0x2AD54D0", VA = "0x182AD6ED0")]
				internal bool RMATJDVIGCK(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7070", Offset = "0x2AD5670", VA = "0x182AD7070")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void RNWDKMSKNAN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5A20", Offset = "0x2AD4020", VA = "0x182AD5A20")]
				internal IReadOnlyList<TargetPlayersSelection> FMTNFSMONUE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7210", Offset = "0x2AD5810", VA = "0x182AD7210")]
				internal object? ROREZNTZYTX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6F30", Offset = "0x2AD5530", VA = "0x182AD6F30")]
				internal bool RMGAGKPFPNT(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7140", Offset = "0x2AD5740", VA = "0x182AD7140")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void ROBKHTMHWLW(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> ERXMCKYDBEQ;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> DCYCTLQSIYC;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> KJTMVWGVCAC;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2AD59C0", Offset = "0x2AD3FC0", VA = "0x182AD59C0")]
			public XAPFYACEWRL(GCFTXZUHCVV a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4E00", Offset = "0x2AD3400", VA = "0x182AD4E00", Slot = "151")]
			protected override void JSVHBRSXZQU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2AD5360", Offset = "0x2AD3960", VA = "0x182AD5360")]
			private static IReadOnlyList<TargetPlayersSelection> WGCNIEFJAYP(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class MXBMHQMWPMK : SNFMUNVNITV<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType MDYKABWAYZC
			{
				[Cpp2IlInjected.Token(Token = "0x6000428")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x2AC46F0", Offset = "0x2AC2CF0", VA = "0x182AC46F0")]
			public MXBMHQMWPMK(GCFTXZUHCVV a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class GWLGTMRIURR : FVXBTFLYTRK<QPBKESVYPXS>
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0710", Offset = "0x2ABED10", VA = "0x182AC0710")]
			public GWLGTMRIURR(GCFTXZUHCVV a, QPBKESVYPXS b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class FVXBTFLYTRK<a> : LTLVYHVMHDH, IDisposable where a : notnull, QPBKESVYPXS
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class TBDIAOPJOEZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public FVXBTFLYTRK<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public GCFTXZUHCVV GWENIFQMAXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a JOZJMPXRKWY;

				[Cpp2IlInjected.Token(Token = "0x60004B5")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public TBDIAOPJOEZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0x6127F30", Offset = "0x6126530", VA = "0x186127F30")]
				internal UODOZOEUIVW JCJWYDBWCEF(ATQGBCEAFDF a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class TKYFDLNKUJJ
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
					public TKYFDLNKUJJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BB")]
					[Cpp2IlInjected.Address(RVA = "0x3F84740", Offset = "0x3F82D40", VA = "0x183F84740", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BC")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string CKQUFYDCNFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, IQRQYBTPXGA>> WIMEVKRIHPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public FVXBTFLYTRK<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> BDRFLUVDISK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public JFQCZHJIKAB CPKYQCCQOVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> ZMQAGKXLFUW;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public TKYFDLNKUJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				internal string GLBWDYDLTFV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
				internal void GKWPGRJOJUM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0x61300E0", Offset = "0x612E6E0", VA = "0x1861300E0")]
				[AsyncStateMachine(typeof(FVXBTFLYTRK<>.TKYFDLNKUJJ.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void GLMJYLRGMCN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class XACKTORHKQS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60004BD")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XACKTORHKQS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x407DE30", Offset = "0x407C430", VA = "0x18407DE30")]
				internal Result<string, IQRQYBTPXGA> JDCWWMNEQRD(string a)
				{
					return default(Result<string, IQRQYBTPXGA>);
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
				public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public FVXBTFLYTRK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0x5286BB0", Offset = "0x52851B0", VA = "0x185286BB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x5286E00", Offset = "0x5285400", VA = "0x185286E00", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public FVXBTFLYTRK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x5286E70", Offset = "0x5285470", VA = "0x185286E70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x5287170", Offset = "0x5285770", VA = "0x185287170", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly GCFTXZUHCVV JXPYTZINUCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool RDOYETQEFDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<QKZKTYBWUBB, UODOZOEUIVW> EJYUVBKGQRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<QKZKTYBWUBB, ZWPHYIPUSNT> OVALNLOBEZJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> GIFDALFBEXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<QKZKTYBWUBB>>? STTHWKMDGJS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<QKZKTYBWUBB>, ZWPHYIPUSNT>? IQOFMABTPHB;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected OIGOTMLEWKK ILTKTHFNKWF
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0x4F4BEB0", Offset = "0x4F4A4B0", VA = "0x184F4BEB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected XXXVQBZACHC XXXVQBZACHC
			{
				[Cpp2IlInjected.Token(Token = "0x600042B")]
				[Cpp2IlInjected.Address(RVA = "0x4F495D0", Offset = "0x4F47BD0", VA = "0x184F495D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected TNLURBVFQWD SDSPKXCJGRM
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x4F4BC90", Offset = "0x4F4A290", VA = "0x184F4BC90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a QPBKESVYPXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000430")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<KJWLGRGGWLZ> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000431")]
				[Cpp2IlInjected.Address(RVA = "0x16AA050", Offset = "0x16A8650", VA = "0x1816AA050", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<KJWLGRGGWLZ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<KOCDTBIOGSC> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D6E0", Offset = "0x4F4BCE0", VA = "0x184F4D6E0", Slot = "6")]
				get
				{
					return default(Id32<KOCDTBIOGSC>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D550", Offset = "0x4F4BB50", VA = "0x184F4D550", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D530", Offset = "0x4F4BB30", VA = "0x184F4D530", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x6000438")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D840", Offset = "0x4F4BE40", VA = "0x184F4D840", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<NRLXJRHPDTU> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xB9A680", Offset = "0xB98C80", VA = "0x180B9A680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<NRLXJRHPDTU>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0x1071FA0", Offset = "0x10705A0", VA = "0x181071FA0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xAF5370", Offset = "0xAF3970", VA = "0x180AF5370", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D400", Offset = "0x4F4BA00", VA = "0x184F4D400", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D430", Offset = "0x4F4BA30", VA = "0x184F4D430", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D460", Offset = "0x4F4BA60", VA = "0x184F4D460", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D6C0", Offset = "0x4F4BCC0", VA = "0x184F4D6C0", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D5F0", Offset = "0x4F4BBF0", VA = "0x184F4D5F0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D4D0", Offset = "0x4F4BAD0", VA = "0x184F4D4D0", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D4A0", Offset = "0x4F4BAA0", VA = "0x184F4D4A0", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x110F8F0", Offset = "0x110DEF0", VA = "0x18110F8F0", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x1836590", Offset = "0x1834B90", VA = "0x181836590")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D490", Offset = "0x4F4BA90", VA = "0x184F4D490", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D5A0", Offset = "0x4F4BBA0", VA = "0x184F4D5A0", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D660", Offset = "0x4F4BC60", VA = "0x184F4D660", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D690", Offset = "0x4F4BC90", VA = "0x184F4D690", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D5D0", Offset = "0x4F4BBD0", VA = "0x184F4D5D0", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual QJRENVEIHWK? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual QIIJQLZWJRR? HOOXRHOKBWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<BZFRCGZKOVF>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000477")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D500", Offset = "0x4F4BB00", VA = "0x184F4D500", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<YRJDGOUPWNL> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D610", Offset = "0x4F4BC10", VA = "0x184F4D610", Slot = "68")]
				get
				{
					return default(Id128<YRJDGOUPWNL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<YRJDGOUPWNL> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D570", Offset = "0x4F4BB70", VA = "0x184F4D570", Slot = "59")]
				get
				{
					return default(Id32<YRJDGOUPWNL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<YRJDGOUPWNL>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<YRJDGOUPWNL>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C350", Offset = "0x4F4A950", VA = "0x184F4C350", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xAB4A90", Offset = "0xAB3090", VA = "0x180AB4A90", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0xAB50B0", Offset = "0xAB36B0", VA = "0x180AB50B0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xAB49F0", Offset = "0xAB2FF0", VA = "0x180AB49F0", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xAB50A0", Offset = "0xAB36A0", VA = "0x180AB50A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<BZFRCGZKOVF> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D720", Offset = "0x4F4BD20", VA = "0x184F4D720", Slot = "69")]
				get
				{
					return default(Id32<BZFRCGZKOVF>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<BZFRCGZKOVF> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D640", Offset = "0x4F4BC40", VA = "0x184F4D640", Slot = "70")]
				get
				{
					return default(Id128<BZFRCGZKOVF>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<BZFRCGZKOVF>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D740", Offset = "0x4F4BD40", VA = "0x184F4D740", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<QKZKTYBWUBB, ZWPHYIPUSNT> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D800", Offset = "0x4F4BE00", VA = "0x184F4D800", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<QKZKTYBWUBB, ZWPHYIPUSNT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<QKZKTYBWUBB>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600049E")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action VAMFWBAUZLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000458")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C420", Offset = "0x4F4AA20", VA = "0x184F4C420", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000459")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AD00", Offset = "0x4F49300", VA = "0x184F4AD00", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate UATPFHDUNHY
			{
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A050", Offset = "0x4F48650", VA = "0x184F4A050", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045C")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A0F0", Offset = "0x4F486F0", VA = "0x184F4A0F0", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate DOUHGJOUQCV
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x4F4BA00", Offset = "0x4F4A000", VA = "0x184F4BA00", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x4F4BD70", Offset = "0x4F4A370", VA = "0x184F4BD70", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action VDACORBRAHD
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C270", Offset = "0x4F4A870", VA = "0x184F4C270", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x4F4ADA0", Offset = "0x4F493A0", VA = "0x184F4ADA0", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action DCEUXAKXDME
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x4F4BB10", Offset = "0x4F4A110", VA = "0x184F4BB10", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x4F49060", Offset = "0x4F47660", VA = "0x184F49060", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<QKZKTYBWUBB>, ZWPHYIPUSNT> YBQUGMBYXRX
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x4F49780", Offset = "0x4F47D80", VA = "0x184F49780", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0x4F49100", Offset = "0x4F47700", VA = "0x184F49100", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<QKZKTYBWUBB>, ZWPHYIPUSNT> CNZHNQPANEM
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C780", Offset = "0x4F4AD80", VA = "0x184F4C780", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C6C0", Offset = "0x4F4ACC0", VA = "0x184F4C6C0", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<QKZKTYBWUBB>> MSONFHEIHLA
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x4F491C0", Offset = "0x4F477C0", VA = "0x184F491C0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C5C0", Offset = "0x4F4ABC0", VA = "0x184F4C5C0", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<QKZKTYBWUBB>, Id32<QKZKTYBWUBB>> LINQMPGFWIF
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x4F4CEE0", Offset = "0x4F4B4E0", VA = "0x184F4CEE0", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C1B0", Offset = "0x4F4A7B0", VA = "0x184F4C1B0", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<QKZKTYBWUBB>, ZWPHYIPUSNT> FUBKYQGCCFL
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x4F4C0F0", Offset = "0x4F4A6F0", VA = "0x184F4C0F0", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x4F496C0", Offset = "0x4F47CC0", VA = "0x184F496C0", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<QKZKTYBWUBB>, Id32<QKZKTYBWUBB>> SHAKAHJVCMY
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x4F4BBD0", Offset = "0x4F4A1D0", VA = "0x184F4BBD0", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AE00", Offset = "0x4F49400", VA = "0x184F4AE00", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> SWSYMJXMGSB
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x4F4BF10", Offset = "0x4F4A510", VA = "0x184F4BF10", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AC40", Offset = "0x4F49240", VA = "0x184F4AC40", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x4F4CFA0", Offset = "0x4F4B5A0", VA = "0x184F4CFA0")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected FVXBTFLYTRK(GCFTXZUHCVV a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A710", Offset = "0x4F48D10", VA = "0x184F4A710", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x4F492A0", Offset = "0x4F478A0", VA = "0x184F492A0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B410", Offset = "0x4F49A10", VA = "0x184F4B410", Slot = "9")]
			public Task<Result<None, IQRQYBTPXGA>> PLECVAWCAOQ(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A8D0", Offset = "0x4F48ED0", VA = "0x184F4A8D0")]
			public bool ZMXSIVIJAFG([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A190", Offset = "0x4F48790", VA = "0x184F4A190")]
			public bool HJJAGRUOGFT([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AB80", Offset = "0x4F49180", VA = "0x184F4AB80", Slot = "34")]
			public void KSJAFPOPITP(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C4C0", Offset = "0x4F4AAC0", VA = "0x184F4C4C0", Slot = "35")]
			public Task XMWGXJZVRNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B8B0", Offset = "0x4F49EB0", VA = "0x184F4B8B0", Slot = "36")]
			[AsyncStateMachine(typeof(FVXBTFLYTRK<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, IQRQYBTPXGA>> QEUJAMKXAAY(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "119")]
			public virtual void CXBMUQMXGNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x10F8900", Offset = "0x10F6F00", VA = "0x1810F8900")]
			protected void ASTCQMHXFAR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x2353990", Offset = "0x2351F90", VA = "0x182353990")]
			protected void HWLVGDWIVFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x23337E0", Offset = "0x2331DE0", VA = "0x1823337E0")]
			private void YCSKWOZLRRS([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AEC0", Offset = "0x4F494C0", VA = "0x184F4AEC0", Slot = "122")]
			public virtual Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> NINOBROWHCX(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x4F49BD0", Offset = "0x4F481D0", VA = "0x184F49BD0", Slot = "123")]
			public virtual Task<Result<None, IQRQYBTPXGA>> GLBCLRSXSSO(Id32<QKZKTYBWUBB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "124")]
			public virtual void VUMQXIBVMSC(Id32<QKZKTYBWUBB> sourceId, Id32<QKZKTYBWUBB> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x4F4BE10", Offset = "0x4F4A410", VA = "0x184F4BE10", Slot = "125")]
			public virtual IEnumerable<LOHJEAGYXDY> SOBGIISANTP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C680", Offset = "0x4F4AC80", VA = "0x184F4C680", Slot = "126")]
			public Result<None, IQRQYBTPXGA> YDREEDTNQBK(string a)
			{
				return default(Result<None, IQRQYBTPXGA>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x4F4BFD0", Offset = "0x4F4A5D0", VA = "0x184F4BFD0", Slot = "50")]
			public bool UHUZCSKMJII([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A900", Offset = "0x4F48F00", VA = "0x184F4A900")]
			public bool KQVVBMDGYPP([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "128")]
			public virtual void XEAJVVZRLNB(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "129")]
			public virtual NYLIJNNAVYS SNXMPLECNHF([In] LBFFDUJJKWF audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C840", Offset = "0x4F4AE40", VA = "0x184F4C840")]
			protected void ZBUXMWHRKGX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C350", Offset = "0x4F4A950", VA = "0x184F4C350", Slot = "134")]
			protected virtual bool WHUHKRPFOAQ(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C320", Offset = "0x4F4A920", VA = "0x184F4C320", Slot = "96")]
			public bool WAZNCAJPSOS(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "135")]
			protected virtual bool PDEKZQHYWXZ(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected virtual void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x4F49840", Offset = "0x4F47E40", VA = "0x184F49840")]
			protected void GBYRYCXUQBB(JFQCZHJIKAB a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, IQRQYBTPXGA>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AFA0", Offset = "0x4F495A0", VA = "0x184F4AFA0")]
			protected void NNTHISFHQWN(JFQCZHJIKAB a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B5B0", Offset = "0x4F49BB0", VA = "0x184F4B5B0", Slot = "146")]
			protected virtual void QDZPPHKJMYI(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B230", Offset = "0x4F49830", VA = "0x184F4B230", Slot = "90")]
			public void NWSNNEOTPPP(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x4F48FF0", Offset = "0x4F475F0", VA = "0x184F48FF0", Slot = "91")]
			public CircuitsRigidTransform BSPVHZLNQBC()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "149")]
			public virtual bool MIEUTIBMHNE(Id32<QKZKTYBWUBB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AC20", Offset = "0x4F49220", VA = "0x184F4AC20")]
			private void KUTYQYPGBPV([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x4F48F30", Offset = "0x4F47530", VA = "0x184F48F30")]
			private void BQNTDLWILDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x10F8900", Offset = "0x10F6F00", VA = "0x1810F8900", Slot = "97")]
			private void NKYSNYNXSVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A1C0", Offset = "0x4F487C0", VA = "0x184F4A1C0", Slot = "99")]
			private void IINANBNRDRK(Id32<QKZKTYBWUBB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x4F49280", Offset = "0x4F47880", VA = "0x184F49280", Slot = "101")]
			private void CSJIGUIMOMR(Id32<QKZKTYBWUBB> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B470", Offset = "0x4F49A70", VA = "0x184F4B470", Slot = "103")]
			private void QDECSISNORV(Id32<QKZKTYBWUBB> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F49C90", Offset = "0x4F48290", VA = "0x184F49C90", Slot = "104")]
			private void GLOMRMPRZPN(Id32<QKZKTYBWUBB> sourceId, Id32<QKZKTYBWUBB> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AF80", Offset = "0x4F49580", VA = "0x184F4AF80", Slot = "105")]
			private void NMUWXVZHBJW(Id32<QKZKTYBWUBB> sourceId, Id32<QKZKTYBWUBB> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x2156BE0", Offset = "0x21551E0", VA = "0x182156BE0", Slot = "98")]
			private void TGYXLIUXNMD(Id32<QKZKTYBWUBB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x4F4CAC0", Offset = "0x4F4B0C0", VA = "0x184F4CAC0", Slot = "100")]
			private void ZSDTRLFFXZO(Id32<QKZKTYBWUBB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x4F4BAA0", Offset = "0x4F4A0A0", VA = "0x184F4BAA0", Slot = "102")]
			private void QLRTQWPXGSK(Id32<QKZKTYBWUBB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x4F4BBB0", Offset = "0x4F4A1B0", VA = "0x184F4BBB0", Slot = "106")]
			private void RMLZUBWFYFK(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C9A0", Offset = "0x4F4AFA0", VA = "0x184F4C9A0", Slot = "150")]
			[AsyncStateMachine(typeof(FVXBTFLYTRK<>.<RequestNameChange>d__224))]
			public Task<Result<None, IQRQYBTPXGA>> ZLGGWAJSBYS(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B1A0", Offset = "0x4F497A0", VA = "0x184F4B1A0", Slot = "57")]
			private void NVWSGCVVFWU(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C390", Offset = "0x4F4A990", VA = "0x184F4C390", Slot = "58")]
			private void WKKIOHWGRLF(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A8D0", Offset = "0x4F48ED0", VA = "0x184F4A8D0", Slot = "30")]
			private bool KNEWBVXSAYN([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A190", Offset = "0x4F48790", VA = "0x184F4A190", Slot = "32")]
			private bool HWZXHWTAZGA([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B280", Offset = "0x4F49880", VA = "0x184F4B280", Slot = "51")]
			private bool OBBUWSOBNOU([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A90", Offset = "0xAB3090", VA = "0x180AB4A90")]
			[CompilerGenerated]
			private string PCTXPYPFATI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B2A0", Offset = "0x4F498A0", VA = "0x184F4B2A0")]
			[CompilerGenerated]
			private void PCZENFJCKER(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class ZZCLOGNSHPT : BZWDYVMXVQK<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0xF9FDC0", Offset = "0xF9E3C0", VA = "0x180F9FDC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9040", Offset = "0x2AD7640", VA = "0x182AD9040")]
			public ZZCLOGNSHPT(GCFTXZUHCVV a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class CLHJUKFNFYR : FVXBTFLYTRK<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NAJWKCTVQNQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public CLHJUKFNFYR CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> PNRPPZVPGVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> JYWJVQIVXTG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C9")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6640", Offset = "0x2AD4C40", VA = "0x182AD6640")]
				internal int GPRDWPZCBUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5D00", Offset = "0x2AD4300", VA = "0x182AD5D00")]
				internal void GPBJEVRJZMY(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C6")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF480", Offset = "0x2ABDA80", VA = "0x182ABF480")]
			public CLHJUKFNFYR(GCFTXZUHCVV a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF1A0", Offset = "0x2ABD7A0", VA = "0x182ABF1A0", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class ERXZWRCDOUX : ZIZOVKEJUZB<WTXDNBTDAYA>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x2ABFC90", Offset = "0x2ABE290", VA = "0x182ABFC90")]
			public ERXZWRCDOUX(GCFTXZUHCVV a, WTXDNBTDAYA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class WORHUEZWICJ : FVXBTFLYTRK<RUHPUUQOXQC>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public WORHUEZWICJ CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60004D1")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x2AC38E0", Offset = "0x2AC1EE0", VA = "0x182AC38E0")]
				internal bool GPLWZJFESJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3BA0", Offset = "0x2AC21A0", VA = "0x182AC3BA0")]
				internal void GPRDWPZCBUZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AD47C0", Offset = "0x2AD2DC0", VA = "0x182AD47C0")]
			public WORHUEZWICJ(GCFTXZUHCVV a, RUHPUUQOXQC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AD45F0", Offset = "0x2AD2BF0", VA = "0x182AD45F0", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class UMRWTZFWDEC : FVXBTFLYTRK<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
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
					public XIPYLIIUTHZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F3")]
					[Cpp2IlInjected.Address(RVA = "0x2ACD4C0", Offset = "0x2ACBAC0", VA = "0x182ACD4C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F4")]
					[Cpp2IlInjected.Address(RVA = "0x2ACD6F0", Offset = "0x2ACBCF0", VA = "0x182ACD6F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZFBCIWFTQTK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public UMRWTZFWDEC CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> LOHHFFOAMXQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> HNDOHPXKEVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D8")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6820", Offset = "0x2AD4E20", VA = "0x182AD6820")]
				internal int GPRDWPZCBUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6010", Offset = "0x2AD4610", VA = "0x182AD6010")]
				internal void GPBJEVRJZMY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6260", Offset = "0x2AD4860", VA = "0x182AD6260")]
				internal int GPGQCCLHIYH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5BB0", Offset = "0x2AD41B0", VA = "0x182AD5BB0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> GOQVKIDPGQG(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6DF0", Offset = "0x2AD53F0", VA = "0x182AD6DF0")]
				internal int NRSPSGGSOAM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2AD74C0", Offset = "0x2AD5AC0", VA = "0x182AD74C0")]
				internal void SUURFQLWUVC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7550", Offset = "0x2AD5B50", VA = "0x182AD7550")]
				internal int SUZYCXFUEGL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2AD75A0", Offset = "0x2AD5BA0", VA = "0x182AD75A0")]
				internal void SVFFADZRNRU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7630", Offset = "0x2AD5C30", VA = "0x182AD7630")]
				internal int SVKLXKTOXDD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7350", Offset = "0x2AD5950", VA = "0x182AD7350")]
				internal void STZPQPKHJBS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2AD73E0", Offset = "0x2AD59E0", VA = "0x182AD73E0")]
				internal int SUEWNWEESNB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7430", Offset = "0x2AD5A30", VA = "0x182AD7430")]
				internal void SUKDLCYCBYK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5CB0", Offset = "0x2AD42B0", VA = "0x182AD5CB0")]
				internal float GOWCHOXMQBP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5AD0", Offset = "0x2AD40D0", VA = "0x182AD5AD0")]
				internal void GOGHPUPUNTO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5B60", Offset = "0x2AD4160", VA = "0x182AD5B60")]
				internal float GOLONBJRXEX()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6990", Offset = "0x2AD4F90", VA = "0x182AD6990")]
				internal void GRCADLIJPWK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6A20", Offset = "0x2AD5020", VA = "0x182AD6A20")]
				internal bool GRHHASCGZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6C80", Offset = "0x2AD5280", VA = "0x182AD6C80")]
				internal void NQHTLKXKZZB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6C30", Offset = "0x2AD5230", VA = "0x182AD6C30")]
				internal int NQCMOEDNQNS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6D60", Offset = "0x2AD5360", VA = "0x182AD6D60")]
				internal void NQSHFYLFSVT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6D10", Offset = "0x2AD5310", VA = "0x182AD6D10")]
				internal float NQNAIRRIJKK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6AC0", Offset = "0x2AD50C0", VA = "0x182AD6AC0")]
				internal void NPMRWJVVOFR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6A70", Offset = "0x2AD5070", VA = "0x182AD6A70")]
				internal float NPHKZDBYEUI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6BA0", Offset = "0x2AD51A0", VA = "0x182AD6BA0")]
				internal void NPXFQXJQHCJ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6B50", Offset = "0x2AD5150", VA = "0x182AD6B50")]
				internal bool NPRYTQPSXRA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2AD6E40", Offset = "0x2AD5440", VA = "0x182AD6E40")]
				internal void NRXWPNAPXLV(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x2ACF2A0", Offset = "0x2ACD8A0", VA = "0x182ACF2A0")]
			public UMRWTZFWDEC(GCFTXZUHCVV a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2ACE1B0", Offset = "0x2ACC7B0", VA = "0x182ACE1B0", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class KAYHWTCBUQB : KEZLQRWUJUU<RecNetImageNode>
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
				public KAYHWTCBUQB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004F9")]
				[Cpp2IlInjected.Address(RVA = "0x2ACCCF0", Offset = "0x2ACB2F0", VA = "0x182ACCCF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FA")]
				[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1380", Offset = "0x2ABF980", VA = "0x182AC1380")]
			public KAYHWTCBUQB(GCFTXZUHCVV a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0EB0", Offset = "0x2ABF4B0", VA = "0x182AC0EB0", Slot = "151")]
			protected override void CHRWEKIUYRV(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2AC12B0", Offset = "0x2ABF8B0", VA = "0x182AC12B0")]
			[CompilerGenerated]
			private string? DEBBETSLGXF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC11E0", Offset = "0x2ABF7E0", VA = "0x182AC11E0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void DDVUHMYNXLW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class SNFMUNVNITV<a> : FVXBTFLYTRK<a> where a : notnull, CTFZYNUAMFX
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class XMEHEWGCGRP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZFBCIWFTQTK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public SNFMUNVNITV<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> LOHHFFOAMXQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> HNDOHPXKEVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType AENMKZCLCPI;

				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XMEHEWGCGRP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GPLWZJFESJQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0x4089350", Offset = "0x4087950", VA = "0x184089350")]
				internal int GPRDWPZCBUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0x4089110", Offset = "0x4087710", VA = "0x184089110")]
				internal void GPBJEVRJZMY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x4089300", Offset = "0x4087900", VA = "0x184089300")]
				internal void GPGQCCLHIYH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x4089000", Offset = "0x4087600", VA = "0x184089000")]
				internal void GOQVKIDPGQG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x4088FA0", Offset = "0x40875A0", VA = "0x184088FA0")]
				internal bool GOWCHOXMQBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x4088F50", Offset = "0x4087550", VA = "0x184088F50")]
				internal void GOGHPUPUNTO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x4088FA0", Offset = "0x40875A0", VA = "0x184088FA0")]
				internal bool GOLONBJRXEX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x4089470", Offset = "0x4087A70", VA = "0x184089470")]
				internal float GRCADLIJPWK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x40894A0", Offset = "0x4087AA0", VA = "0x1840894A0")]
				internal void GRHHASCGZHT(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x408A2C0", Offset = "0x40888C0", VA = "0x18408A2C0")]
				internal float NQHTLKXKZZB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x408A230", Offset = "0x4088830", VA = "0x18408A230")]
				internal void NQCMOEDNQNS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x408A380", Offset = "0x4088980", VA = "0x18408A380")]
				internal float NQSHFYLFSVT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x408A2F0", Offset = "0x40888F0", VA = "0x18408A2F0")]
				internal void NQNAIRRIJKK(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType MDYKABWAYZC
			{
				[Cpp2IlInjected.Token(Token = "0x60004FD")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x4095390", Offset = "0x4093990", VA = "0x184095390")]
			public SNFMUNVNITV(GCFTXZUHCVV a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x5F86920", Offset = "0x5F84F20", VA = "0x185F86920", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class AXUQYBLDWZD : FVXBTFLYTRK<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0xF8AE60", Offset = "0xF89460", VA = "0x180F8AE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x2ABE750", Offset = "0x2ABCD50", VA = "0x182ABE750")]
			public AXUQYBLDWZD(GCFTXZUHCVV a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class GUHMHFORURE : TNCYXMDDCXA<FPMTWSENYBG>
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x2AC06B0", Offset = "0x2ABECB0", VA = "0x182AC06B0")]
			public GUHMHFORURE(GCFTXZUHCVV a, FPMTWSENYBG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class RNKOOSRAIVI : TNCYXMDDCXA<OUJYJZZCPGZ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2AC60D0", Offset = "0x2AC46D0", VA = "0x182AC60D0")]
			public RNKOOSRAIVI(GCFTXZUHCVV a, OUJYJZZCPGZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class TNCYXMDDCXA<a> : FVXBTFLYTRK<a> where a : notnull, NYTFXXZBWTE
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
				public TNCYXMDDCXA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051A")]
				[Cpp2IlInjected.Address(RVA = "0x3F84550", Offset = "0x3F82B50", VA = "0x183F84550", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051B")]
				[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class TYGMGLNVTBE
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
					public TYGMGLNVTBE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052B")]
					[Cpp2IlInjected.Address(RVA = "0x3F83250", Offset = "0x3F81850", VA = "0x183F83250", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052C")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public TYGMGLNVTBE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3F83620", Offset = "0x3F81C20", VA = "0x183F83620", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public TYGMGLNVTBE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3F83E90", Offset = "0x3F82490", VA = "0x183F83E90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public TYGMGLNVTBE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3F84260", Offset = "0x3F82860", VA = "0x183F84260", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int RQNIDISRYME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry LLFXJRPFBZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public TNCYXMDDCXA<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<WPCWYXTKXZN, bool> FKKAAWTEDLN;

				[Cpp2IlInjected.Token(Token = "0x6000520")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public TYGMGLNVTBE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000521")]
				[Cpp2IlInjected.Address(RVA = "0x61E5920", Offset = "0x61E3F20", VA = "0x1861E5920")]
				internal bool GPGQCCLHIYH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0x61E58B0", Offset = "0x61E3EB0", VA = "0x1861E58B0")]
				internal void GOQVKIDPGQG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
				internal string GOWCHOXMQBP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x61E56E0", Offset = "0x61E3CE0", VA = "0x1861E56E0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.TYGMGLNVTBE.<<BuildConfigMenuInternal>b__6>d))]
				internal void GOGHPUPUNTO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0x61E57A0", Offset = "0x61E3DA0", VA = "0x1861E57A0")]
				internal int GOLONBJRXEX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x61E5BA0", Offset = "0x61E41A0", VA = "0x1861E5BA0")]
				internal bool NQNAIRRIJKK(WPCWYXTKXZN a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x61E5980", Offset = "0x61E3F80", VA = "0x1861E5980")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.TYGMGLNVTBE.<<BuildConfigMenuInternal>b__8>d))]
				internal void GRCADLIJPWK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
				internal string NQHTLKXKZZB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x61E5AE0", Offset = "0x61E40E0", VA = "0x1861E5AE0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.TYGMGLNVTBE.<<BuildConfigMenuInternal>b__11>d))]
				internal void NQCMOEDNQNS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0x61E5BC0", Offset = "0x61E41C0", VA = "0x1861E5BC0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.TYGMGLNVTBE.<<BuildConfigMenuInternal>b__12>d))]
				internal void NQSHFYLFSVT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class PMCLZVAKTMZ
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000563")]
					[Cpp2IlInjected.Address(RVA = "0x3F7D690", Offset = "0x3F7BC90", VA = "0x183F7D690", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000564")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3F7DA10", Offset = "0x3F7C010", VA = "0x183F7DA10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3F7DDE0", Offset = "0x3F7C3E0", VA = "0x183F7DDE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3F7E3B0", Offset = "0x3F7C9B0", VA = "0x183F7E3B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3F7E640", Offset = "0x3F7CC40", VA = "0x183F7E640", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3F7E9D0", Offset = "0x3F7CFD0", VA = "0x183F7E9D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3F7ED60", Offset = "0x3F7D360", VA = "0x183F7ED60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3F7EFF0", Offset = "0x3F7D5F0", VA = "0x183F7EFF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3F7F380", Offset = "0x3F7D980", VA = "0x183F7F380", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3F7F710", Offset = "0x3F7DD10", VA = "0x183F7F710", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3F7FA90", Offset = "0x3F7E090", VA = "0x183F7FA90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3F7FD20", Offset = "0x3F7E320", VA = "0x183F7FD20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3F800B0", Offset = "0x3F7E6B0", VA = "0x183F800B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3F80340", Offset = "0x3F7E940", VA = "0x183F80340", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3F806D0", Offset = "0x3F7ECD0", VA = "0x183F806D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3F80A50", Offset = "0x3F7F050", VA = "0x183F80A50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
					public PMCLZVAKTMZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3F80DD0", Offset = "0x3F7F3D0", VA = "0x183F80DD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public TNCYXMDDCXA<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int RQNIDISRYME;

				[Cpp2IlInjected.Token(Token = "0x6000533")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public PMCLZVAKTMZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000534")]
				[Cpp2IlInjected.Address(RVA = "0x5C85C10", Offset = "0x5C84210", VA = "0x185C85C10")]
				internal bool ABUIXQTONOI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0x5C85C70", Offset = "0x5C84270", VA = "0x185C85C70")]
				internal void ABZPUXNLWZR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x5C86F10", Offset = "0x5C85510", VA = "0x185C86F10")]
				internal object PHUJMBAYCJZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x5C86E50", Offset = "0x5C85450", VA = "0x185C86E50")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__13>d))]
				internal void PHPCOUHASYQ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x5C872C0", Offset = "0x5C858C0", VA = "0x185C872C0")]
				internal string PIZYVPQIHAB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x5C87200", Offset = "0x5C85800", VA = "0x185C87200")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__15>d))]
				internal void PIURYIWKXOS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x5C87180", Offset = "0x5C85780", VA = "0x185C87180")]
				internal bool PIPLBCCNODJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x5C870F0", Offset = "0x5C856F0", VA = "0x185C870F0")]
				internal bool PIKEDVIQESA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x5C86DA0", Offset = "0x5C853A0", VA = "0x185C86DA0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__18>d))]
				internal void PGOUCMLNXTX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x5C86CF0", Offset = "0x5C852F0", VA = "0x185C86CF0")]
				internal int PGJNFFRQOIO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x5C87860", Offset = "0x5C85E60", VA = "0x185C87860")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__20>d))]
				internal void WIWCFGWVKZA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x5C87910", Offset = "0x5C85F10", VA = "0x185C87910")]
				internal bool WJBJCNQSUKJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x5C87700", Offset = "0x5C85D00", VA = "0x185C87700")]
				internal float WILOKTJASCI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x5C877B0", Offset = "0x5C85DB0", VA = "0x185C877B0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__23>d))]
				internal void WIQVIACYBNR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x5C875E0", Offset = "0x5C85BE0", VA = "0x185C875E0")]
				internal bool WIBAQFVFZFQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x5C87670", Offset = "0x5C85C70", VA = "0x185C87670")]
				internal bool WIGHNMPDIQZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x5C874A0", Offset = "0x5C85AA0", VA = "0x185C874A0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__26>d))]
				internal void WHQMVSHLGIY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x5C87550", Offset = "0x5C85B50", VA = "0x185C87550")]
				internal int WHVTSZBIPUH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x5C87360", Offset = "0x5C85960", VA = "0x185C87360")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__28>d))]
				internal void WHFZBETQNMG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x5C87410", Offset = "0x5C85A10", VA = "0x185C87410")]
				internal bool WHLFYLNNWXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x5C86130", Offset = "0x5C84730", VA = "0x185C86130")]
				internal float DDAUNQSEKSH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x5C86080", Offset = "0x5C84680", VA = "0x185C86080")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__31>d))]
				internal void DCVNQJYHBGY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x5C86240", Offset = "0x5C84840", VA = "0x185C86240")]
				internal bool DDLIIEFZDOZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x5C861C0", Offset = "0x5C847C0", VA = "0x185C861C0")]
				internal bool DDGBKXMBUDQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x5C86360", Offset = "0x5C84960", VA = "0x185C86360")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__34>d))]
				internal void DDVWCRTTWLR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x5C862D0", Offset = "0x5C848D0", VA = "0x185C862D0")]
				internal bool DDQPFKZWNAI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x5C864C0", Offset = "0x5C84AC0", VA = "0x185C864C0")]
				internal bool DEGJXFHOPIJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x5C86410", Offset = "0x5C84A10", VA = "0x185C86410")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__37>d))]
				internal void DEBCZYNRFXA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x5C86600", Offset = "0x5C84C00", VA = "0x185C86600")]
				internal int DEQXRSVJIFB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x5C86550", Offset = "0x5C84B50", VA = "0x185C86550")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__39>d))]
				internal void DELQUMBLYTS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x5C86A40", Offset = "0x5C85040", VA = "0x185C86A40")]
				internal bool JDUAZBBGOOI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x5C86AD0", Offset = "0x5C850D0", VA = "0x185C86AD0")]
				internal float JDZHWHVDXZR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x5C86B60", Offset = "0x5C85160", VA = "0x185C86B60")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__42>d))]
				internal void JEEOTOPBHLA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x5C86C10", Offset = "0x5C85210", VA = "0x185C86C10")]
				internal bool JEJVQVIYQWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x5C86880", Offset = "0x5C84E80", VA = "0x185C86880")]
				internal bool JCYZJZZRCUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x5C86900", Offset = "0x5C84F00", VA = "0x185C86900")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__45>d))]
				internal void JDEGHGTOMGH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x5C869B0", Offset = "0x5C84FB0", VA = "0x185C869B0")]
				internal bool JDJNENNLVRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x5C85CE0", Offset = "0x5C842E0", VA = "0x185C85CE0")]
				internal bool ACEWSEHJGLA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x5C85D70", Offset = "0x5C84370", VA = "0x185C85D70")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__3>d))]
				internal void ACKDPLBGPWJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x5C85E20", Offset = "0x5C84420", VA = "0x185C85E20")]
				internal int ACPKMRVDZHS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x5C85EB0", Offset = "0x5C844B0", VA = "0x185C85EB0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__5>d))]
				internal void ACURJYPBITB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x5C85F60", Offset = "0x5C84560", VA = "0x185C85F60")]
				internal bool ACZYHFIYSEK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x5C85FF0", Offset = "0x5C845F0", VA = "0x185C85FF0")]
				internal bool ADFFEMCWBPT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x5C85AC0", Offset = "0x5C840C0", VA = "0x185C85AC0")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__8>d))]
				internal void AAEFTOQJQBO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x5C85B70", Offset = "0x5C84170", VA = "0x185C85B70")]
				internal int AAJMQVKGZMX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x5C87040", Offset = "0x5C85640", VA = "0x185C87040")]
				[AsyncStateMachine(typeof(TNCYXMDDCXA<>.PMCLZVAKTMZ.<<AddConstraintOptions>b__10>d))]
				internal void PIEXGOOSVGR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x5C86FB0", Offset = "0x5C855B0", VA = "0x185C86FB0")]
				internal bool PHZQJHUVLVI()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> OKXUIGLSTAU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> XGBWSNBHVMB;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000514")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<WPCWYXTKXZN> HDNZVUDICXZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000515")]
				[Cpp2IlInjected.Address(RVA = "0x61CDF00", Offset = "0x61CC500", VA = "0x1861CDF00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x61CF610", Offset = "0x61CDC10", VA = "0x1861CF610")]
			public TNCYXMDDCXA(GCFTXZUHCVV a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x61CDD50", Offset = "0x61CC350", VA = "0x1861CDD50", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x61CCD50", Offset = "0x61CB350", VA = "0x1861CCD50", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x61CDF50", Offset = "0x61CC550", VA = "0x1861CDF50")]
			private MJFDITXXZZZ UYXQJIJMLLM(JFQCZHJIKAB a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x61CDE60", Offset = "0x61CC460", VA = "0x1861CDE60")]
			[AsyncStateMachine(typeof(TNCYXMDDCXA<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void LRDLYODKXUW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x61CDE00", Offset = "0x61CC400", VA = "0x1861CDE00")]
			[CompilerGenerated]
			private bool LQYFBHJNOJN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class ICYJSCIIRZQ : FVXBTFLYTRK<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class AUWAEQXFGZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public ICYJSCIIRZQ CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x600058A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public AUWAEQXFGZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0x2ABDA40", Offset = "0x2ABC040", VA = "0x182ABDA40")]
				internal int GPRDWPZCBUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0x2ABD870", Offset = "0x2ABBE70", VA = "0x182ABD870")]
				internal void GPBJEVRJZMY(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? WGXTXEPZWPB;

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0BC0", Offset = "0x2ABF1C0", VA = "0x182AC0BC0")]
			public ICYJSCIIRZQ(GCFTXZUHCVV a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0870", Offset = "0x2ABEE70", VA = "0x182AC0870", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class WXDOMAIXMQS : SNFMUNVNITV<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType MDYKABWAYZC
			{
				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4830", Offset = "0x2AD2E30", VA = "0x182AD4830")]
			public WXDOMAIXMQS(GCFTXZUHCVV a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class KBILQQWFOYB : ZIZOVKEJUZB<TTDLKVAUYZI>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x2AC13E0", Offset = "0x2ABF9E0", VA = "0x182AC13E0")]
			public KBILQQWFOYB(GCFTXZUHCVV a, TTDLKVAUYZI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class MBDGVNVXOAE : ZIZOVKEJUZB<BPMZHFOFQLP>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000592")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2ED0", Offset = "0x2AC14D0", VA = "0x182AC2ED0")]
			public MBDGVNVXOAE(GCFTXZUHCVV a, BPMZHFOFQLP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class SHZMKIOPBRS : KEZLQRWUJUU<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
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
					public MVZLYDKGBFP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000599")]
					[Cpp2IlInjected.Address(RVA = "0x2ACC9E0", Offset = "0x2ACAFE0", VA = "0x182ACC9E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059A")]
					[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public SHZMKIOPBRS CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x6000597")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000598")]
				[Cpp2IlInjected.Address(RVA = "0x2AC4620", Offset = "0x2AC2C20", VA = "0x182AC4620")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void MNJJIHHVNDV(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7110", Offset = "0x2AC5710", VA = "0x182AC7110")]
			public SHZMKIOPBRS(GCFTXZUHCVV a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6E10", Offset = "0x2AC5410", VA = "0x182AC6E10", Slot = "151")]
			protected override void CHRWEKIUYRV(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class KCCWVUVGHSL : SNFMUNVNITV<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType MDYKABWAYZC
			{
				[Cpp2IlInjected.Token(Token = "0x600059C")]
				[Cpp2IlInjected.Address(RVA = "0xD8C2E0", Offset = "0xD8A8E0", VA = "0x180D8C2E0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1440", Offset = "0x2ABFA40", VA = "0x182AC1440")]
			public KCCWVUVGHSL(GCFTXZUHCVV a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class CQHSTOGGDIK : FVXBTFLYTRK<YTNUIBMREZQ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0xF8B600", Offset = "0xF89C00", VA = "0x180F8B600", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF4F0", Offset = "0x2ABDAF0", VA = "0x182ABF4F0")]
			public CQHSTOGGDIK(GCFTXZUHCVV a, YTNUIBMREZQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class QQIZGAWXMKB : FVXBTFLYTRK<CKVVJMUMSLY>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A0")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A1")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool XVCNTJBAEKA
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6060", Offset = "0x2AC4660", VA = "0x182AC6060")]
			public QQIZGAWXMKB(GCFTXZUHCVV a, CKVVJMUMSLY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5CA0", Offset = "0x2AC42A0", VA = "0x182AC5CA0", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5FB0", Offset = "0x2AC45B0", VA = "0x182AC5FB0")]
			private int LCCLTDDEYEN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5FF0", Offset = "0x2AC45F0", VA = "0x182AC5FF0")]
			private void XXLBILWRQIZ(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class ULSJKIGMMIY : GWLGTMRIURR
		{
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0710", Offset = "0x2ABED10", VA = "0x182AC0710")]
			public ULSJKIGMMIY(GCFTXZUHCVV a, QPBKESVYPXS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class PZQOHQTNFKO : FVXBTFLYTRK<JNCERYXZEOT>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class XIPYLIIUTHZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public PZQOHQTNFKO CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XIPYLIIUTHZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AD")]
				[Cpp2IlInjected.Address(RVA = "0x2AD64B0", Offset = "0x2AD4AB0", VA = "0x182AD64B0")]
				internal int GPLWZJFESJQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x2AD65A0", Offset = "0x2AD4BA0", VA = "0x182AD65A0")]
				internal void GPRDWPZCBUZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2AD5FC0", Offset = "0x2AD45C0", VA = "0x182AD5FC0")]
				internal int GPBJEVRJZMY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2AD62B0", Offset = "0x2AD48B0", VA = "0x182AD62B0")]
				internal void GPGQCCLHIYH(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AA")]
				[Cpp2IlInjected.Address(RVA = "0x1315E20", Offset = "0x1314420", VA = "0x181315E20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5BD0", Offset = "0x2AC41D0", VA = "0x182AC5BD0")]
			public PZQOHQTNFKO(GCFTXZUHCVV a, JNCERYXZEOT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AC58C0", Offset = "0x2AC3EC0", VA = "0x182AC58C0", Slot = "145")]
			protected sealed override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class YIFTAKWUMET : KEZLQRWUJUU<WZTIHZXAZRG>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8760", Offset = "0x2AD6D60", VA = "0x182AD8760")]
			public YIFTAKWUMET(GCFTXZUHCVV a, WZTIHZXAZRG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class KEZLQRWUJUU<a> : FVXBTFLYTRK<a> where a : notnull, WZTIHZXAZRG
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class SSSKYROOASY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public KEZLQRWUJUU<a> CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.Token(Token = "0x60005B9")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public SSSKYROOASY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x5F95C20", Offset = "0x5F94220", VA = "0x185F95C20")]
				internal bool GPLWZJFESJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0x5F95C50", Offset = "0x5F94250", VA = "0x185F95C50")]
				internal void GPRDWPZCBUZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x5F95B60", Offset = "0x5F94160", VA = "0x185F95B60")]
				internal bool GPBJEVRJZMY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x5F95B90", Offset = "0x5F94190", VA = "0x185F95B90")]
				internal void GPGQCCLHIYH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x5F95A70", Offset = "0x5F94070", VA = "0x185F95A70")]
				internal bool GOQVKIDPGQG()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class OGOKSBBDBET
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public TNLURBVFQWD FBMTOPJRLJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public KEZLQRWUJUU<a> CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public OGOKSBBDBET()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x5BBF8C0", Offset = "0x5BBDEC0", VA = "0x185BBF8C0")]
				internal void MNJJIHHVNDV(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0xDED9C0", Offset = "0xDEBFC0", VA = "0x180DED9C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x53AE700", Offset = "0x53ACD00", VA = "0x1853AE700", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x53AE5F0", Offset = "0x53ACBF0", VA = "0x1853AE5F0")]
			protected KEZLQRWUJUU(GCFTXZUHCVV a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x53AE4C0", Offset = "0x53ACAC0", VA = "0x1853AE4C0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x53ADE70", Offset = "0x53AC470", VA = "0x1853ADE70", Slot = "145")]
			protected override void BLFETODJUSQ(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x53AE1E0", Offset = "0x53AC7E0", VA = "0x1853AE1E0", Slot = "151")]
			protected virtual void CHRWEKIUYRV(JFQCZHJIKAB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x53AE5B0", Offset = "0x53ACBB0", VA = "0x1853AE5B0", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4740", Offset = "0x2AB2D40", VA = "0x182AB4740")]
		public static LTLVYHVMHDH New(GCFTXZUHCVV circuitsManager, QPBKESVYPXS node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class GGXHKDDNBLR : KFAIYKGEPER, RLFKINAVQVG, TKNLLBEJAZY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<MXAREIUAFLA> JJFXJNLUOPU
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xF7F290", Offset = "0xF7D890", VA = "0x180F7F290", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<MXAREIUAFLA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<EKZRYTEBJRU> KIKATRVSPAV
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x1EC1490", Offset = "0x1EBFA90", VA = "0x181EC1490", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<EKZRYTEBJRU>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x25B6E10", Offset = "0x25B5410", VA = "0x1825B6E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<WRHWMQQUVHP> WENJBMDGKTL
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x14A16B0", Offset = "0x149FCB0", VA = "0x1814A16B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<VZKYGFGMPQU> LKPAHBDVPEP
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AC03C0", Offset = "0x2ABE9C0", VA = "0x182AC03C0", Slot = "22")]
			get
			{
				return default(Id32<VZKYGFGMPQU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0410", Offset = "0x2ABEA10", VA = "0x182AC0410")]
		private GGXHKDDNBLR(GCFTXZUHCVV a, QPBKESVYPXS b, NGDNSUEMIAG c, Id32<QKZKTYBWUBB> portGroupId, Id32<EKZRYTEBJRU> outputId, Id32<WRHWMQQUVHP> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0070", Offset = "0x2ABE670", VA = "0x182AC0070")]
		public static GGXHKDDNBLR New(GCFTXZUHCVV circuitsManager, QPBKESVYPXS node, NGDNSUEMIAG output, Id32<QKZKTYBWUBB> portGroupId, Id32<WRHWMQQUVHP> outputDefId, Id32<EKZRYTEBJRU> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x25B6E10", Offset = "0x25B5410", VA = "0x1825B6E10")]
		internal void AXFRTAMHPNL(Id32<EKZRYTEBJRU> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class KFAIYKGEPER : TKNLLBEJAZY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private TDQBLFOCFSP? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2E30", Offset = "0x2AC1430", VA = "0x182AC2E30")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2E40", Offset = "0x2AC1440", VA = "0x182AC2E40")]
			public TDQBLFOCFSP YKRQZPRGDXB(KFAIYKGEPER a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly QPBKESVYPXS ADLQZLTHWIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter JOJERFLDAZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly JFMUJRHLECS UADPRCOCDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<RENTXANSTDI> YJTXFRJECLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<ZFHRAVHSEOE> XPOXYAICJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool OPAKZTEHTNN;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> RLOSNNVAQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1BE0", Offset = "0x2AC01E0", VA = "0x182AC1BE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind AWWCTLDGDOA
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4510", Offset = "0xAC2B10", VA = "0x180AC4510", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<YRJDGOUPWNL> WUDVPFIHASV
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2AC15A0", Offset = "0x2ABFBA0", VA = "0x182AC15A0", Slot = "6")]
			get
			{
				return default(Id32<YRJDGOUPWNL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<YRJDGOUPWNL> RCXOEJRWTCA
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2470", Offset = "0x2AC0A70", VA = "0x182AC2470", Slot = "7")]
			get
			{
				return default(Id128<YRJDGOUPWNL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public WPCWYXTKXZN LDBIGTYVQRE
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1750", Offset = "0x2ABFD50", VA = "0x182AC1750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public OGRSLMQMIMZ VUDRMCXGDTF
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1770", Offset = "0x2ABFD70", VA = "0x182AC1770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected TDQBLFOCFSP PIMKNARJGPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1770", Offset = "0x2ABFD70", VA = "0x182AC1770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage QJDHSTXONDG
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1990", Offset = "0x2ABFF90", VA = "0x182AC1990", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<BZFRCGZKOVF> HYHXDYICWDE
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1F30", Offset = "0x2AC0530", VA = "0x182AC1F30", Slot = "9")]
			get
			{
				return default(Id128<BZFRCGZKOVF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<QKZKTYBWUBB> SWWAPWFLOST
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xF33300", Offset = "0xF31900", VA = "0x180F33300", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QKZKTYBWUBB>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x1ACCEF0", Offset = "0x1ACB4F0", VA = "0x181ACCEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<VZKYGFGMPQU> LKPAHBDVPEP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool TYRFKUDEQQE
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xFD3F90", Offset = "0xFD2590", VA = "0x180FD3F90", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2CE0", Offset = "0x2AC12E0", VA = "0x182AC2CE0")]
		protected KFAIYKGEPER(GCFTXZUHCVV a, QPBKESVYPXS b, JFMUJRHLECS c, Id32<QKZKTYBWUBB> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC18B0", Offset = "0x2ABFEB0", VA = "0x182AC18B0", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC14C0", Offset = "0x2ABFAC0", VA = "0x182AC14C0", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1B30", Offset = "0x2AC0130", VA = "0x182AC1B30", Slot = "14")]
		public void MVDLCWFSAVN(RENTXANSTDI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1800", Offset = "0x2ABFE00", VA = "0x182AC1800", Slot = "15")]
		public void HIDRQZNYLRH(ZFHRAVHSEOE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1F50", Offset = "0x2AC0550", VA = "0x182AC1F50")]
		private bool QBTDKTERHCQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AC24A0", Offset = "0x2AC0AA0", VA = "0x182AC24A0", Slot = "17")]
		public void XQXMJGWMVZR(OGWTEPJIVAO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2270", Offset = "0x2AC0870", VA = "0x182AC2270", Slot = "25")]
		protected virtual void QSEUHCVCWHT(OGWTEPJIVAO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC15D0", Offset = "0x2ABFBD0", VA = "0x182AC15D0", Slot = "20")]
		private void FEVHETCQMIO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1D80", Offset = "0x2AC0380", VA = "0x182AC1D80")]
		private void OGXOCMDLNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC22D0", Offset = "0x2AC08D0", VA = "0x182AC22D0")]
		private void UCBYGVRMDXT([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1D20", Offset = "0x2AC0320", VA = "0x182AC1D20", Slot = "18")]
		public void OGAGFTKJPKI(RENTXANSTDI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1AD0", Offset = "0x2AC00D0", VA = "0x182AC1AD0", Slot = "19")]
		public void LGODKLENLMW(ZFHRAVHSEOE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
		internal void WCFYZQXOZPB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC14A0", Offset = "0x2ABFAA0", VA = "0x182AC14A0")]
		internal void BTIVTLRSXGI(XXXVQBZACHC a, WPCWYXTKXZN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCEF0", Offset = "0x1ACB4F0", VA = "0x181ACCEF0")]
		internal void LJPQITLUCUH(Id32<QKZKTYBWUBB> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class UODOZOEUIVW : ZWPHYIPUSNT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class DODMLYZKXUA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public GCFTXZUHCVV GWENIFQMAXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public QPBKESVYPXS JOZJMPXRKWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<QKZKTYBWUBB> JUKREXMFVSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool DKSMHFJYDTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool ONBYTZZJPKL;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DODMLYZKXUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x2ABFAE0", Offset = "0x2ABE0E0", VA = "0x182ABFAE0")]
			internal EHTVPVUBDIO XEZBSAQLEVW((int PortDescIndex, int PortIndex, EBEBGUBYIAH InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x2ABFBC0", Offset = "0x2ABE1C0", VA = "0x182ABFBC0")]
			internal GGXHKDDNBLR XFEIPHKIOHF(NGDNSUEMIAG a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8290", Offset = "0x2AC6890", VA = "0x182AC8290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8700", Offset = "0x2AC6D00", VA = "0x182AC8700", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<OVRKYFBGDJO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC99A0", Offset = "0x2AC7FA0", VA = "0x182AC99A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9CF0", Offset = "0x2AC82F0", VA = "0x182AC9CF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9D60", Offset = "0x2AC8360", VA = "0x182AC9D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2ACA1E0", Offset = "0x2AC87E0", VA = "0x182ACA1E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<WRHWMQQUVHP> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2ACA250", Offset = "0x2AC8850", VA = "0x182ACA250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2ACA5A0", Offset = "0x2AC8BA0", VA = "0x182ACA5A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2ACADD0", Offset = "0x2AC93D0", VA = "0x182ACADD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB120", Offset = "0x2AC9720", VA = "0x182ACB120", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<OVRKYFBGDJO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2ACA610", Offset = "0x2AC8C10", VA = "0x182ACA610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2ACA980", Offset = "0x2AC8F80", VA = "0x182ACA980", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<WRHWMQQUVHP> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2ACA9F0", Offset = "0x2AC8FF0", VA = "0x182ACA9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2ACAD60", Offset = "0x2AC9360", VA = "0x182ACAD60", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public HKFDOQDIWNO type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<OVRKYFBGDJO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB190", Offset = "0x2AC9790", VA = "0x182ACB190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB530", Offset = "0x2AC9B30", VA = "0x182ACB530", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public HKFDOQDIWNO type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<WRHWMQQUVHP> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB5A0", Offset = "0x2AC9BA0", VA = "0x182ACB5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB940", Offset = "0x2AC9F40", VA = "0x182ACB940", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<OVRKYFBGDJO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<OVRKYFBGDJO> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB9B0", Offset = "0x2AC9FB0", VA = "0x182ACB9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2ACBD10", Offset = "0x2ACA310", VA = "0x182ACBD10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public UODOZOEUIVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<WRHWMQQUVHP> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<WRHWMQQUVHP> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private GNHUSEXYYOY <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2ACBD80", Offset = "0x2ACA380", VA = "0x182ACBD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2ACC0E0", Offset = "0x2ACA6E0", VA = "0x182ACC0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool SYPEGZAUQLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool ATMZYRNZOZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<RSMVXMQQIAP, EHTVPVUBDIO> IEZOACGVAWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<RSMVXMQQIAP, HELHZBNXFBJ> YTLTOOTHZXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly QPBKESVYPXS ADLQZLTHWIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<EKZRYTEBJRU, GGXHKDDNBLR> HXNMRFYTJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<EKZRYTEBJRU, RLFKINAVQVG> DCFJBBPBOVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? HUFITSTIWCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly ATQGBCEAFDF VJFXXXLBMTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<QKZKTYBWUBB> MCKNFEQKOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool RDOYETQEFDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? ZDDVOZSVSLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? AKZSUZYVCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<RSMVXMQQIAP>>? PPDYHNLBCPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<EKZRYTEBJRU>>? QSWNNQUTTRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private ZWPHYIPUSNT.PortGroupIdChangeDelegate? YOZXQMTHNVW;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool OBGVRRVZNDS
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2CF0", Offset = "0x2AD12F0", VA = "0x182AD2CF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool IOAJBJFJZBP
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AD00C0", Offset = "0x2ACE6C0", VA = "0x182AD00C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool JDUOCASRZTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2C30", Offset = "0x2AD1230", VA = "0x182AD2C30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<YRJDGOUPWNL> RCXOEJRWTCA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3490", Offset = "0x2AD1A90", VA = "0x182AD3490", Slot = "7")]
			get
			{
				return default(Id128<YRJDGOUPWNL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool YKEUXUUSHLD
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3E60", Offset = "0x2AD2460", VA = "0x182AD3E60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<RSMVXMQQIAP, HELHZBNXFBJ> CYIHXVVCFGN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<RSMVXMQQIAP, HELHZBNXFBJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2ACFC00", Offset = "0x2ACE200", VA = "0x182ACFC00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<BZFRCGZKOVF> HYHXDYICWDE
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2DB0", Offset = "0x2AD13B0", VA = "0x182AD2DB0", Slot = "11")]
			get
			{
				return default(Id128<BZFRCGZKOVF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<EKZRYTEBJRU, RLFKINAVQVG> TZXLIMBIXXA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<EKZRYTEBJRU, RLFKINAVQVG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<QKZKTYBWUBB> SWWAPWFLOST
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xC4BB90", Offset = "0xC4A190", VA = "0x180C4BB90", Slot = "13")]
			get
			{
				return default(Id32<QKZKTYBWUBB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? PTNSZOBAISD
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1190", Offset = "0x2ACF790", VA = "0x182AD1190", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3820", Offset = "0x2AD1E20", VA = "0x182AD3820", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? IRWEHYEIDFW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2AD30C0", Offset = "0x2AD16C0", VA = "0x182AD30C0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2AD34C0", Offset = "0x2AD1AC0", VA = "0x182AD34C0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<RSMVXMQQIAP?>, Id32<RSMVXMQQIAP?>>? YWOVSPBPISD
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3DA0", Offset = "0x2AD23A0", VA = "0x182AD3DA0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2B70", Offset = "0x2AD1170", VA = "0x182AD2B70", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<RSMVXMQQIAP?>, Id32<RSMVXMQQIAP?>>? ZGGVNQXIQFK
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2AD38C0", Offset = "0x2AD1EC0", VA = "0x182AD38C0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AD0000", Offset = "0x2ACE600", VA = "0x182AD0000", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<EKZRYTEBJRU?>, Id32<EKZRYTEBJRU?>>? QHRYRTSPYPA
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3630", Offset = "0x2AD1C30", VA = "0x182AD3630", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2AD0D20", Offset = "0x2ACF320", VA = "0x182AD0D20", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<EKZRYTEBJRU?>, Id32<EKZRYTEBJRU?>>? GCENPTZKJOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2ACFB40", Offset = "0x2ACE140", VA = "0x182ACFB40", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1360", Offset = "0x2ACF960", VA = "0x182AD1360", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<RSMVXMQQIAP?>, HELHZBNXFBJ?>? RGNGZHYHWXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2ACF9A0", Offset = "0x2ACDFA0", VA = "0x182ACF9A0", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2930", Offset = "0x2AD0F30", VA = "0x182AD2930", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<RSMVXMQQIAP?>>? JDIJGEPEZBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2AD29F0", Offset = "0x2AD0FF0", VA = "0x182AD29F0", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2AD10D0", Offset = "0x2ACF6D0", VA = "0x182AD10D0", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<RSMVXMQQIAP?>, HELHZBNXFBJ?>? CQINOTYDLQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2AD0740", Offset = "0x2ACED40", VA = "0x182AD0740", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2ACF310", Offset = "0x2ACD910", VA = "0x182ACF310", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<EKZRYTEBJRU?>, RLFKINAVQVG?>? KVKIDEQSEYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2870", Offset = "0x2AD0E70", VA = "0x182AD2870", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3980", Offset = "0x2AD1F80", VA = "0x182AD3980", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<EKZRYTEBJRU?>>? DOLENJIIMSE
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2ACFA80", Offset = "0x2ACE080", VA = "0x182ACFA80", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3570", Offset = "0x2AD1B70", VA = "0x182AD3570", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<EKZRYTEBJRU?>, RLFKINAVQVG?>? UPICQZKEKNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2AB0", Offset = "0x2AD10B0", VA = "0x182AD2AB0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1010", Offset = "0x2ACF610", VA = "0x182AD1010", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4480", Offset = "0x2AD2A80", VA = "0x182AD4480")]
		private UODOZOEUIVW(bool a, GCFTXZUHCVV b, bool c, ReadOnlyIdArray<RSMVXMQQIAP, EHTVPVUBDIO> inputs, ReadOnlyIdArray<RSMVXMQQIAP, HELHZBNXFBJ> inputsAsStaticInputs, QPBKESVYPXS d, ReadOnlyIdArray<EKZRYTEBJRU, GGXHKDDNBLR> outputs, ReadOnlyIdArray<EKZRYTEBJRU, RLFKINAVQVG> outputsAsStaticOutputs, string? overrideName, ATQGBCEAFDF e, Id32<QKZKTYBWUBB> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2320", Offset = "0x2AD0920", VA = "0x182AD2320")]
		public static UODOZOEUIVW New(bool canInteract, GCFTXZUHCVV circuitsManager, bool hasFunctionHeader, QPBKESVYPXS node, ATQGBCEAFDF portGroup, Id32<QKZKTYBWUBB> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0220", Offset = "0x2ACE820", VA = "0x182AD0220", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2DD0", Offset = "0x2AD13D0", VA = "0x182AD2DD0", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, IQRQYBTPXGA?>>? PJUQAWJFAOW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0DE0", Offset = "0x2ACF3E0", VA = "0x182AD0DE0")]
		private (GOLIWOQOWWZ?, int)? HVFZADWBQOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2AD21F0", Offset = "0x2AD07F0", VA = "0x182AD21F0", Slot = "58")]
		private void NQGKKHSBBJQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x254EEC0", Offset = "0x254D4C0", VA = "0x18254EEC0", Slot = "57")]
		private void UYZZRQJPGGN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0930", Offset = "0x2ACEF30", VA = "0x182AD0930", Slot = "61")]
		private void GIGDYDMBSDZ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2EC0", Offset = "0x2AD14C0", VA = "0x182AD2EC0", Slot = "63")]
		private void PNKHOYFIUNI(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF3F0", Offset = "0x2ACD9F0", VA = "0x182ACF3F0", Slot = "50")]
		private void ANSMYYWFMLL(int a, Id32<RSMVXMQQIAP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2300", Offset = "0x2AD0900", VA = "0x182AD2300", Slot = "54")]
		private void NYMACLYYXTU(int a, Id32<RSMVXMQQIAP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0D00", Offset = "0x2ACF300", VA = "0x182AD0D00", Slot = "49")]
		private void GTWJTMACDJK(int a, Id32<RSMVXMQQIAP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1DA0", Offset = "0x2AD03A0", VA = "0x182AD1DA0", Slot = "53")]
		private void NDWYFPIQEVH(int a, Id32<RSMVXMQQIAP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD17C0", Offset = "0x2ACFDC0", VA = "0x182AD17C0", Slot = "66")]
		private void MBBUOAWUXVP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x114DFD0", Offset = "0x114C5D0", VA = "0x18114DFD0", Slot = "65")]
		private void GCGEFZJBSDE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3380", Offset = "0x2AD1980", VA = "0x182AD3380", Slot = "60")]
		private void TCLGMVFLIFH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x254EEC0", Offset = "0x254D4C0", VA = "0x18254EEC0", Slot = "59")]
		private void VSHNPNALFYM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFC30", Offset = "0x2ACE230", VA = "0x182ACFC30", Slot = "62")]
		private void DFAFOBMFSUK(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2AD06B0", Offset = "0x2ACECB0", VA = "0x182AD06B0", Slot = "64")]
		private void EWYFPZSCUOZ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3EE0", Offset = "0x2AD24E0", VA = "0x182AD3EE0", Slot = "52")]
		private void ZRYCAWDAOVC(int a, Id32<EKZRYTEBJRU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF3D0", Offset = "0x2ACD9D0", VA = "0x182ACF3D0", Slot = "56")]
		private void AKSWRIFESKJ(int a, Id32<EKZRYTEBJRU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFA60", Offset = "0x2ACE060", VA = "0x182ACFA60", Slot = "51")]
		private void AVBUQRYMPOT(int a, Id32<EKZRYTEBJRU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1930", Offset = "0x2ACFF30", VA = "0x182AD1930", Slot = "55")]
		private void MOUBZRPYPFC(int a, Id32<EKZRYTEBJRU> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2F50", Offset = "0x2AD1550", VA = "0x182AD2F50", Slot = "68")]
		private void QHFOQBKHHXA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x114DFD0", Offset = "0x114C5D0", VA = "0x18114DFD0", Slot = "67")]
		private void OJUSBICXSOP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3B60", Offset = "0x2AD2160", VA = "0x182AD3B60", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, IQRQYBTPXGA?>>? YHFLPUZAMWP(Id32<OVRKYFBGDJO> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x2AD05A0", Offset = "0x2ACEBA0", VA = "0x182AD05A0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, IQRQYBTPXGA?>>? EUQBMJVFTAQ(Id32<WRHWMQQUVHP> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3A40", Offset = "0x2AD2040", VA = "0x182AD3A40", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, IQRQYBTPXGA?>>? YCMOAMAZBRT(Id32<OVRKYFBGDJO> inputDefId, Id32<OVRKYFBGDJO> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0100", Offset = "0x2ACE700", VA = "0x182AD0100", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, IQRQYBTPXGA?>>? DXGHBWGEXLO(Id32<WRHWMQQUVHP> outputDefId, Id32<WRHWMQQUVHP> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3170", Offset = "0x2AD1770", VA = "0x182AD3170", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, IQRQYBTPXGA?>>? RKGUJWWLGRV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3260", Offset = "0x2AD1860", VA = "0x182AD3260", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, IQRQYBTPXGA>> SGYFSDUBGHU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3C70", Offset = "0x2AD2270", VA = "0x182AD3C70", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, IQRQYBTPXGA>> YHXIOSBAFDD(Id32<OVRKYFBGDJO> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD36F0", Offset = "0x2AD1CF0", VA = "0x182AD36F0", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, IQRQYBTPXGA>> WHDTVIUBUWG(Id32<WRHWMQQUVHP> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0800", Offset = "0x2ACEE00", VA = "0x182AD0800", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, IQRQYBTPXGA>> GCUIZTJYUTQ(Id32<OVRKYFBGDJO> inputDefId, HKFDOQDIWNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1230", Offset = "0x2ACF830", VA = "0x182AD1230", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, IQRQYBTPXGA>> LAEESXKRWVF(Id32<WRHWMQQUVHP> outputDefId, HKFDOQDIWNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1420", Offset = "0x2ACFA20", VA = "0x182AD1420")]
		internal void LJPQITLUCUH(Id32<QKZKTYBWUBB> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class IXJRKHRRWZM : IJTKDTMSILD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface ETPODEKPKCV
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<YRJDGOUPWNL>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065D")]
				[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<YRJDGOUPWNL>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			XXXVQBZACHC XXXVQBZACHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> CSXYRKXOFFD(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> PUCCWNLORKU(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<SYHYWDYRXRO> CISKTSGDCML(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<UFGPJUQJOWM> QHFVGUDMWPK(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> DQXWRCJPDYB(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> UBBNAHQMADC(CancellationToken a);
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
			public AsyncTaskMethodBuilder<IXJRKHRRWZM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public GCFTXZUHCVV circuitsManager;

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
			private ETPODEKPKCV <selfDeps>5__2;

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
			private SYHYWDYRXRO <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private UFGPJUQJOWM <playerSaveData>5__8;

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
			private TaskAwaiter<SYHYWDYRXRO> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<UFGPJUQJOWM> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<ETPODEKPKCV.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<QFPJTZRYEHQ> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8770", Offset = "0x2AC6D70", VA = "0x182AC8770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9930", Offset = "0x2AC7F30", VA = "0x182AC9930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public QFPJTZRYEHQ QFPJTZRYEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DDSRGNTUTGY DDSRGNTUTGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public HDRSQBBYOQN HDRSQBBYOQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public ILTKTHFNKWF ILTKTHFNKWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x1183DB0", Offset = "0x11823B0", VA = "0x181183DB0")]
		private IXJRKHRRWZM(QFPJTZRYEHQ a, DDSRGNTUTGY b, HDRSQBBYOQN c, ILTKTHFNKWF d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0CD0", Offset = "0x2ABF2D0", VA = "0x182AC0CD0")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<IXJRKHRRWZM> JCASGJLUWVH(GCFTXZUHCVV a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0CB0", Offset = "0x2ABF2B0", VA = "0x182AC0CB0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class XNQVTLZGKGG : NKWZSYOTSHX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public MOCRVNMHDWK? ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2AD82C0", Offset = "0x2AD68C0", VA = "0x182AD82C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		internal XNQVTLZGKGG(GCFTXZUHCVV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class HDRSQBBYOQN : MOCRVNMHDWK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly QFPJTZRYEHQ FJIOLEKUBZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly XNQVTLZGKGG KOHPJXQMSEL;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> GTGGOUWJCOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0780", Offset = "0x2ABED80", VA = "0x182AC0780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE38300", Offset = "0xE36900", VA = "0x180E38300")]
		public HDRSQBBYOQN(GCFTXZUHCVV a, QFPJTZRYEHQ b, XNQVTLZGKGG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0820", Offset = "0x2ABEE20", VA = "0x182AC0820", Slot = "5")]
		public string ZOOLPHPAYVB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x2AC07C0", Offset = "0x2ABEDC0", VA = "0x182AC07C0", Slot = "6")]
		public void MBUEZPFWISO(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5F50", Offset = "0x2AE4550", VA = "0x182AE5F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6190", Offset = "0x2AE4790", VA = "0x182AE6190", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, IQRQYBTPXGA>> <>t__builder;

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
			private LOHJEAGYXDY[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6990", Offset = "0x2AE4F90", VA = "0x182AE6990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6D60", Offset = "0x2AE5360", VA = "0x182AE6D60", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public LOHJEAGYXDY action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB070", Offset = "0x2AE9670", VA = "0x182AEB070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB4F0", Offset = "0x2AE9AF0", VA = "0x182AEB4F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly MPBKAGBRDNH _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		public EVRequestExtended(MPBKAGBRDNH staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFCF0", Offset = "0x2ABE2F0", VA = "0x182ABFCF0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, IQRQYBTPXGA>> DWHUSIKYOHL(LOHJEAGYXDY a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFF10", Offset = "0x2ABE510", VA = "0x182ABFF10")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, IQRQYBTPXGA?>>? YPYJSJWCGNI(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFE20", Offset = "0x2ABE420", VA = "0x182ABFE20")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, IQRQYBTPXGA>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface UHKYITKHAZL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		IJTKDTMSILD? ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool DXOXKCLZKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<IJTKDTMSILD?>? GXMEQRTYTSR();

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task OKLFFNMVTBU(GCFTXZUHCVV a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface IJTKDTMSILD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		QFPJTZRYEHQ QFPJTZRYEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		DDSRGNTUTGY DDSRGNTUTGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		HDRSQBBYOQN HDRSQBBYOQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		ILTKTHFNKWF ILTKTHFNKWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class IZVIIMFRITM
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1450", Offset = "0x2ADFA50", VA = "0x182AE1450")]
		public static ReducerFactory<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>> EYDLPUHCDAX([In] this ReducerFactory<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class FZCLWMBWFCN : LHWEZEBZRXQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool DXOXKCLZKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9960", Offset = "0x2AD7F60", VA = "0x182AD9960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		internal FZCLWMBWFCN(GCFTXZUHCVV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class SLZZBETKHFQ : FVXNCDDGQUX
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3720", Offset = "0x2AE1D20", VA = "0x182AE3720", Slot = "4")]
		public MREQMUGUMWF? LMLJNJDGAOG(string? a, string? b, string? c, RoomDoorData.NVAURJSHQDD.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE37B0", Offset = "0x2AE1DB0", VA = "0x182AE37B0", Slot = "5")]
		public SXIWUQXLXHP LQTBRPQKPCQ(string a, string b, List<string> c, int d, int e, int f, int g, AXIVUFQHUTP h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3680", Offset = "0x2AE1C80", VA = "0x182AE3680", Slot = "6")]
		public AXIVUFQHUTP JKNFNNLOMFA(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public SLZZBETKHFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class LMWIOMDWWZE : OINRVFWZVZD
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
			public AsyncTaskMethodBuilder<OIGOTMLEWKK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public LMWIOMDWWZE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<IJTKDTMSILD?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6200", Offset = "0x2AE4800", VA = "0x182AE6200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6490", Offset = "0x2AE4A90", VA = "0x182AE6490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public OIGOTMLEWKK? ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2190", Offset = "0x2AE0790", VA = "0x182AE2190", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public ILTKTHFNKWF? SJFATDCUDYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2330", Offset = "0x2AE0930", VA = "0x182AE2330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool DFANYCGUVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2AE25E0", Offset = "0x2AE0BE0", VA = "0x182AE25E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool IQPTJHIJJGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2580", Offset = "0x2AE0B80", VA = "0x182AE2580", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x2AE29C0", Offset = "0x2AE0FC0", VA = "0x182AE29C0")]
		internal LMWIOMDWWZE(GCFTXZUHCVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2210", Offset = "0x2AE0810", VA = "0x182AE2210", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<OIGOTMLEWKK> GXMEQRTYTSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2640", Offset = "0x2AE0C40", VA = "0x182AE2640", Slot = "9")]
		public IReadOnlyDictionary<Id128<YRJDGOUPWNL>, Guid> ZIWCMVRTTHP(IEnumerable<UMNTAHYOPJM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2010", Offset = "0x2AE0610", VA = "0x182AE2010", Slot = "10")]
		public CircuitGraphToolMappingRegistryData CASGYAEOPMR(IEnumerable<UMNTAHYOPJM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2AE23B0", Offset = "0x2AE09B0", VA = "0x182AE23B0")]
		public Result<CircuitsRoomData, OYBEQJHIRPM> NHOPDVXWUDD([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, OYBEQJHIRPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2300", Offset = "0x2AE0900", VA = "0x182AE2300", Slot = "8")]
		private Result<CircuitsRoomData, OYBEQJHIRPM> KUAGIMGUTCI([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, OYBEQJHIRPM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class ILTKTHFNKWF : OIGOTMLEWKK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class ZSRBJMFJBMA
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class MVZLYDKGBFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int ZTQJSHTXGBR;

				[Cpp2IlInjected.Token(Token = "0x6000716")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public MVZLYDKGBFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x2AE2F40", Offset = "0x2AE1540", VA = "0x182AE2F40")]
				internal void NCYFWLFITNM(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x2AED960", Offset = "0x2AEBF60", VA = "0x182AED960")]
			public static Result<OIGOTMLEWKK.PrepareTemplateForCloneResult, MIWOMKTZBCT> YRCEFRNPVRH(ILTKTHFNKWF a, [In] OIGOTMLEWKK.PrepareTemplateForCloneArgs args)
			{
				return default(Result<OIGOTMLEWKK.PrepareTemplateForCloneResult, MIWOMKTZBCT>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC580", Offset = "0x2AEAB80", VA = "0x182AEC580")]
			internal static Result<(IWDYUGLPUGO, CircuitTemplateRootData), MIWOMKTZBCT> QWIJRKBXJZJ(ILTKTHFNKWF a, CircuitTemplateRootData b, bool c, [In] Id128<YRJDGOUPWNL> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(IWDYUGLPUGO, CircuitTemplateRootData), MIWOMKTZBCT>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2AEBCC0", Offset = "0x2AEA2C0", VA = "0x182AEBCC0")]
			private static void ADWQFJEPXFD(bool a, UMNTAHYOPJM b, IWDYUGLPUGO c, [In] Id128<YRJDGOUPWNL> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC150", Offset = "0x2AEA750", VA = "0x182AEC150")]
			public static void AUCFSQBDWBQ(QYYXSVXZQGV a, [In] OIGOTMLEWKK.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2AED3D0", Offset = "0x2AEB9D0", VA = "0x182AED3D0")]
			[CompilerGenerated]
			internal static bool THZGFVEXDDB(QFPJTZRYEHQ a, HYNHSLIJNYN b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC550", Offset = "0x2AEAB50", VA = "0x182AEC550")]
			[CompilerGenerated]
			internal static bool CZIJJJQOZJM(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class KSDKGWCCFCS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public ILTKTHFNKWF CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<YRJDGOUPWNL> DZQUZGXOBLQ;

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public KSDKGWCCFCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1FD0", Offset = "0x2AE05D0", VA = "0x182AE1FD0")]
			internal Id128<BZFRCGZKOVF> QORTEKVPPBH(Id32<BZFRCGZKOVF> a)
			{
				return default(Id128<BZFRCGZKOVF>);
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<MXAREIUAFLA> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<XYCEOHQMMOR> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6DD0", Offset = "0x2AE53D0", VA = "0x182AE6DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE73A0", Offset = "0x2AE59A0", VA = "0x182AE73A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<QKZKTYBWUBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<OVRKYFBGDJO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7410", Offset = "0x2AE5A10", VA = "0x182AE7410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7760", Offset = "0x2AE5D60", VA = "0x182AE7760", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<BZFRCGZKOVF>, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<KOCDTBIOGSC> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private QFPJTZRYEHQ <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7AB0", Offset = "0x2AE60B0", VA = "0x182AE7AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7EE0", Offset = "0x2AE64E0", VA = "0x182AE7EE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2AE77D0", Offset = "0x2AE5DD0", VA = "0x182AE77D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7A40", Offset = "0x2AE6040", VA = "0x182AE7A40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7F50", Offset = "0x2AE6550", VA = "0x182AE7F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8140", Offset = "0x2AE6740", VA = "0x182AE8140", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<YRJDGOUPWNL> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<BZFRCGZKOVF> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<BZFRCGZKOVF>> nodeIds;

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
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2AE81B0", Offset = "0x2AE67B0", VA = "0x182AE81B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8450", Offset = "0x2AE6A50", VA = "0x182AE8450", Slot = "5")]
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
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<YRJDGOUPWNL> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<BZFRCGZKOVF> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<BZFRCGZKOVF>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<QKZKTYBWUBB>, Id32<RSMVXMQQIAP>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<QKZKTYBWUBB>, Id32<EKZRYTEBJRU>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2AE84C0", Offset = "0x2AE6AC0", VA = "0x182AE84C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8A90", Offset = "0x2AE7090", VA = "0x182AE8A90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<YRJDGOUPWNL> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<BZFRCGZKOVF> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<BZFRCGZKOVF>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8AF0", Offset = "0x2AE70F0", VA = "0x182AE8AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8D00", Offset = "0x2AE7300", VA = "0x182AE8D00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<BZFRCGZKOVF> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<QKZKTYBWUBB> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<RSMVXMQQIAP> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8D70", Offset = "0x2AE7370", VA = "0x182AE8D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE90C0", Offset = "0x2AE76C0", VA = "0x182AE90C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<QKZKTYBWUBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<OVRKYFBGDJO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9130", Offset = "0x2AE7730", VA = "0x182AE9130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9510", Offset = "0x2AE7B10", VA = "0x182AE9510", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9580", Offset = "0x2AE7B80", VA = "0x182AE9580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9800", Offset = "0x2AE7E00", VA = "0x182AE9800", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<BZFRCGZKOVF> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<QKZKTYBWUBB> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<EKZRYTEBJRU> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9870", Offset = "0x2AE7E70", VA = "0x182AE9870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9BC0", Offset = "0x2AE81C0", VA = "0x182AE9BC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9C30", Offset = "0x2AE8230", VA = "0x182AE9C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9F70", Offset = "0x2AE8570", VA = "0x182AE9F70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9FE0", Offset = "0x2AE85E0", VA = "0x182AE9FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA270", Offset = "0x2AE8870", VA = "0x182AEA270", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA2E0", Offset = "0x2AE88E0", VA = "0x182AEA2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA570", Offset = "0x2AE8B70", VA = "0x182AEA570", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<BZFRCGZKOVF>>, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<YRJDGOUPWNL> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<UMNTAHYOPJM> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<QPBKESVYPXS>, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA5E0", Offset = "0x2AE8BE0", VA = "0x182AEA5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2AEAD70", Offset = "0x2AE9370", VA = "0x182AEAD70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<YRJDGOUPWNL> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<BZFRCGZKOVF> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<BZFRCGZKOVF>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2AEADE0", Offset = "0x2AE93E0", VA = "0x182AEADE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB000", Offset = "0x2AE9600", VA = "0x182AEB000", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public ILTKTHFNKWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<YRJDGOUPWNL> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<BZFRCGZKOVF> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB560", Offset = "0x2AE9B60", VA = "0x182AEB560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB780", Offset = "0x2AE9D80", VA = "0x182AEB780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly GCFTXZUHCVV JXPYTZINUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly QFPJTZRYEHQ FJIOLEKUBZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers YDBSSNOJYJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly LMWIOMDWWZE CRQYFVCUVSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<BZFRCGZKOVF>, LTLVYHVMHDH> RATXCMGWEWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<BZFRCGZKOVF>>? VDACORBRAHD;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<YRJDGOUPWNL> ZGYUJUACCSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2ADDD40", Offset = "0x2ADC340", VA = "0x182ADDD40", Slot = "4")]
			get
			{
				return default(Id128<YRJDGOUPWNL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers YFQTGRNOLWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2ADED60", Offset = "0x2ADD360", VA = "0x182ADED60", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> LJYPOGHWEEE
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x2ADFE00", Offset = "0x2ADE400", VA = "0x182ADFE00", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action XHGSECENTQP
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x2ADBF00", Offset = "0x2ADA500", VA = "0x182ADBF00", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF980", Offset = "0x2ADDF80", VA = "0x182ADF980", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> WSYWHBRWDNX
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2ADDBE0", Offset = "0x2ADC1E0", VA = "0x182ADDBE0", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2ADFC30", Offset = "0x2ADE230", VA = "0x182ADFC30", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0FF0", Offset = "0x2ADF5F0", VA = "0x182AE0FF0")]
		public ILTKTHFNKWF(GCFTXZUHCVV a, QFPJTZRYEHQ b, LMWIOMDWWZE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB5F0", Offset = "0x2AD9BF0", VA = "0x182ADB5F0", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAD20", Offset = "0x2AD9320", VA = "0x182ADAD20", Slot = "100")]
		public Id32<TMBNKSCAYWX> CTRSKNPACQU(Id32<YRJDGOUPWNL> graphId, Id32<XYCEOHQMMOR> inputId)
		{
			return default(Id32<TMBNKSCAYWX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0DA0", Offset = "0x2ADF3A0", VA = "0x182AE0DA0", Slot = "101")]
		public Id32<DJCBNTVWECC> ZMBORUMPUCL(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> outputId)
		{
			return default(Id32<DJCBNTVWECC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE6A0", Offset = "0x2ADCCA0", VA = "0x182ADE6A0", Slot = "6")]
		public (bool, bool) PNCMBHQXOXS(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> srcId, Id32<XYCEOHQMMOR> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBB80", Offset = "0x2ADA180", VA = "0x182ADBB80")]
		public bool EOZRUIAHEZL(Id32<YRJDGOUPWNL> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFAF0", Offset = "0x2ADE0F0", VA = "0x182ADFAF0", Slot = "8")]
		public bool RSSPIPKFMWF(HELHZBNXFBJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFB90", Offset = "0x2ADE190", VA = "0x182ADFB90", Slot = "9")]
		public bool RXAYILMNPOE(RLFKINAVQVG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC180", Offset = "0x2ADA780", VA = "0x182ADC180", Slot = "10")]
		public AbsoluteLegacyInputId? GMYPKEOVTWL(Id32<YRJDGOUPWNL> graphId, Id32<XYCEOHQMMOR> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD1D0", Offset = "0x2ADB7D0", VA = "0x182ADD1D0", Slot = "11")]
		public AbsoluteLegacyOutputId? JMFNQFWLSPI(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD3B0", Offset = "0x2ADB9B0", VA = "0x182ADD3B0", Slot = "12")]
		public Id32<MXAREIUAFLA>? KIWEFYXWLAQ(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<EKZRYTEBJRU> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB410", Offset = "0x2AD9A10", VA = "0x182ADB410", Slot = "13")]
		public Id32<XYCEOHQMMOR>? DGEVUINYUBL(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<RSMVXMQQIAP> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE3E0", Offset = "0x2ADC9E0", VA = "0x182ADE3E0", Slot = "14")]
		public IEnumerable<Id32<YRJDGOUPWNL>> PKKYMWGFYVX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEE80", Offset = "0x2ADD480", VA = "0x182ADEE80", Slot = "15")]
		public IEnumerable<Id32<XNCBTFCEIFB>> QUARZLRMIRQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA750", Offset = "0x2AD8D50", VA = "0x182ADA750", Slot = "22")]
		public string AXAJFWCHTXA(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9980", Offset = "0x2AD7F80", VA = "0x182AD9980", Slot = "16")]
		public Id32<XNCBTFCEIFB>? ACEHYTPZTIK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFC10", Offset = "0x2ADE210", VA = "0x182ADFC10", Slot = "17")]
		public int RYXRJUDOCKH(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC160", Offset = "0x2ADA760", VA = "0x182ADC160", Slot = "18")]
		public int GHGORUENJZO(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBF60", Offset = "0x2ADA560", VA = "0x182ADBF60", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] FEKLTVRBAFL(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFF90", Offset = "0x2ADE590", VA = "0x182ADFF90", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] TUIFNRXOAVI(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x393C180", Offset = "0x393A780", VA = "0x18393C180")]
		private static (CircuitTypeIdWrapper, string?)[]? RYSJWSHJVCD<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AE04A0", Offset = "0x2ADEAA0", VA = "0x182AE04A0", Slot = "21")]
		public string VQXTHHBSURY(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0480", Offset = "0x2ADEA80", VA = "0x182AE0480", Slot = "23")]
		public string VMJPNTYDGTV(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDAB0", Offset = "0x2ADC0B0", VA = "0x182ADDAB0")]
		public LTLVYHVMHDH? MKOYUAPWNEU([In] Id128<BZFRCGZKOVF> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB500", Offset = "0x2AD9B00", VA = "0x182ADB500", Slot = "30")]
		public Id32<KOCDTBIOGSC> DOSFNITBGZQ(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId)
		{
			return default(Id32<KOCDTBIOGSC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBF30", Offset = "0x2ADA530", VA = "0x182ADBF30")]
		public Id32<BZFRCGZKOVF> YRRYPFPARFX(Id32<YRJDGOUPWNL> graphId, [In] Id128<BZFRCGZKOVF> legacyNodeId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0A20", Offset = "0x2ADF020", VA = "0x182AE0A20", Slot = "40")]
		public Id32<BZFRCGZKOVF> XLAFSMDAEOC(Id32<YRJDGOUPWNL> graphId, Id32<XYCEOHQMMOR> inputId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE3C0", Offset = "0x2ADC9C0", VA = "0x182ADE3C0", Slot = "41")]
		public Id32<BZFRCGZKOVF> ONHLHNAVKVP(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> outputId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB3B0", Offset = "0x2AD99B0", VA = "0x182ADB3B0")]
		public Id32<BZFRCGZKOVF>? DESBUJYQSWV(Id32<YRJDGOUPWNL> graphId, [In] Id128<BZFRCGZKOVF> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0A90", Offset = "0x2ADF090", VA = "0x182AE0A90", Slot = "32")]
		public AbsoluteNodeId? XXNEGLRHKOH(Id32<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AE04D0", Offset = "0x2ADEAD0", VA = "0x182AE04D0", Slot = "33")]
		public long VVAYJTDULGQ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEC40", Offset = "0x2ADD240", VA = "0x182ADEC40")]
		private void PSRMRFBOMSU(Id128<BZFRCGZKOVF> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCFD0", Offset = "0x2ADB5D0", VA = "0x182ADCFD0", Slot = "38")]
		public IEnumerable<(Id32<YRJDGOUPWNL>, Id32<BZFRCGZKOVF>)> JDRGTIFUDLA(Id32<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB3E0", Offset = "0x2AD99E0", VA = "0x182ADB3E0", Slot = "39")]
		public Id32<XYCEOHQMMOR> DGEVUINYUBL(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<TMBNKSCAYWX> inputIndex)
		{
			return default(Id32<XYCEOHQMMOR>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD380", Offset = "0x2ADB980", VA = "0x182ADD380", Slot = "42")]
		public Id32<MXAREIUAFLA> KIWEFYXWLAQ(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<DJCBNTVWECC> outputIndex)
		{
			return default(Id32<MXAREIUAFLA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBB10", Offset = "0x2ADA110", VA = "0x182ADBB10")]
		private LTLVYHVMHDH? EGFFUOLACOD([In] Id128<BZFRCGZKOVF> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0440", Offset = "0x2ADEA40", VA = "0x182AE0440")]
		public QPBKESVYPXS? VJAZRIPEGAR([In] Id128<BZFRCGZKOVF> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD3E0", Offset = "0x2ADB9E0", VA = "0x182ADD3E0")]
		public MHPSHNFTXZN? XOWHYUCYOAQ([In] Id128<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0A40", Offset = "0x2ADF040", VA = "0x182AE0A40", Slot = "25")]
		public MHPSHNFTXZN? XOWHYUCYOAQ(Id32<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0B90", Offset = "0x2ADF190", VA = "0x182AE0B90", Slot = "34")]
		public IEnumerable<NewStaticEdge> YBYWFXNMPHW(Id32<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA9D0", Offset = "0x2AD8FD0", VA = "0x182ADA9D0", Slot = "35")]
		public bool BYGLAKEMJRW(Id32<XNCBTFCEIFB> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA780", Offset = "0x2AD8D80", VA = "0x182ADA780", Slot = "36")]
		public IEnumerable<StableStaticEdge> BLAOWCZILTW(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE450", Offset = "0x2ADCA50", VA = "0x182ADE450", Slot = "37")]
		public IEnumerable<StableStaticEdge> PKOGPWVXZGD(Id32<YRJDGOUPWNL> graphId, Id32<XYCEOHQMMOR> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF330", Offset = "0x2ADD930", VA = "0x182ADF330")]
		public Id32<YRJDGOUPWNL> WMHYPJOEPCF([In] Id128<YRJDGOUPWNL> graphId)
		{
			return default(Id32<YRJDGOUPWNL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAB50", Offset = "0x2AD9150", VA = "0x182ADAB50")]
		public Id32<YRJDGOUPWNL>? WRJUKRYLXFL([In] Id128<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2ADECC0", Offset = "0x2ADD2C0", VA = "0x182ADECC0")]
		private HYNHSLIJNYN? QBOAARKNRTZ([In] Id128<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD3E0", Offset = "0x2ADB9E0", VA = "0x182ADD3E0")]
		private MHPSHNFTXZN? POMLJGUBSPU([In] Id128<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBA00", Offset = "0x2ADA000", VA = "0x182ADBA00", Slot = "28")]
		public Id32<YRJDGOUPWNL>? EGDMUPRWSZC(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEE60", Offset = "0x2ADD460", VA = "0x182ADEE60", Slot = "46")]
		public Id128<YRJDGOUPWNL> QMUNSPZRKKI(Id32<YRJDGOUPWNL> graphId)
		{
			return default(Id128<YRJDGOUPWNL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD410", Offset = "0x2ADBA10", VA = "0x182ADD410", Slot = "47")]
		public Id128<BZFRCGZKOVF> LNOYVHUDKCS(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId)
		{
			return default(Id128<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEB40", Offset = "0x2ADD140", VA = "0x182ADEB40", Slot = "43")]
		public IEnumerable<HKFDOQDIWNO> POMCDARMOZW(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0720", Offset = "0x2ADED20", VA = "0x182AE0720", Slot = "44")]
		public HKFDOQDIWNO XAPSBKQMART(RoomVersion a, TKNLLBEJAZY b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC210", Offset = "0x2ADA810", VA = "0x182ADC210")]
		public NewStaticEdge HAPYOJQEBVN(Id32<YRJDGOUPWNL> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF840", Offset = "0x2ADDE40", VA = "0x182ADF840", Slot = "48")]
		public StableStaticEdge RESOJUTSMMS(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> srcId, Id32<XYCEOHQMMOR> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD230", Offset = "0x2ADB830", VA = "0x182ADD230", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, IQRQYBTPXGA>> JSAVCYVSAEX(Id32<YRJDGOUPWNL> parentGraphId, Id32<BZFRCGZKOVF> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFC50", Offset = "0x2ADE250", VA = "0x182ADFC50", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, IQRQYBTPXGA>> SLGZWKBCDTY(Id32<YRJDGOUPWNL> parentGraphId, Id128<BZFRCGZKOVF> boardNodeId, List<Id32<BZFRCGZKOVF>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0DC0", Offset = "0x2ADF3C0", VA = "0x182AE0DC0", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, IQRQYBTPXGA>> ZOVXSZCKVTN(Id32<YRJDGOUPWNL> parentGraphId, Id128<BZFRCGZKOVF> boardNodeId, List<Id32<BZFRCGZKOVF>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF6E0", Offset = "0x2ADDCE0", VA = "0x182ADF6E0", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, IQRQYBTPXGA>> REKYCNEPYWF(Id32<YRJDGOUPWNL> parentGraphId, Id128<BZFRCGZKOVF> boardNodeId, Id32<YRJDGOUPWNL> graphId, List<Id32<BZFRCGZKOVF>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEF10", Offset = "0x2ADD510", VA = "0x182ADEF10", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<QKZKTYBWUBB>, Id32<RSMVXMQQIAP>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<QKZKTYBWUBB>, Id32<EKZRYTEBJRU>)>) QURUPQASSIK(Id128<YRJDGOUPWNL> legacyGraphId, Id32<BZFRCGZKOVF> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<QKZKTYBWUBB>, Id32<RSMVXMQQIAP>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<QKZKTYBWUBB>, Id32<EKZRYTEBJRU>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AE04F0", Offset = "0x2ADEAF0", VA = "0x182AE04F0", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task WMXKSGNAUHK(Id128<YRJDGOUPWNL> legacyGraphId, Id128<BZFRCGZKOVF> boardNodeId, IReadOnlyList<Id128<BZFRCGZKOVF>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<QKZKTYBWUBB>, Id32<RSMVXMQQIAP>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<QKZKTYBWUBB>, Id32<EKZRYTEBJRU>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFAD0", Offset = "0x2ADE0D0", VA = "0x182ADFAD0", Slot = "55")]
		public bool RQYWUHRSKRC(Id32<YRJDGOUPWNL> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBFC0", Offset = "0x2ADA5C0", VA = "0x182ADBFC0", Slot = "56")]
		public bool FOGGUKAXUPW(Id32<YRJDGOUPWNL> graphId, Id32<XYCEOHQMMOR> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDA90", Offset = "0x2ADC090", VA = "0x182ADDA90", Slot = "57")]
		public bool LWBTXACQNSF(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC1E0", Offset = "0x2ADA7E0", VA = "0x182ADC1E0")]
		public Result<OIGOTMLEWKK.PrepareTemplateForCloneResult, MIWOMKTZBCT> GOVKVDOBYFH([In] OIGOTMLEWKK.PrepareTemplateForCloneArgs args)
		{
			return default(Result<OIGOTMLEWKK.PrepareTemplateForCloneResult, MIWOMKTZBCT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF9A0", Offset = "0x2ADDFA0", VA = "0x182ADF9A0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, IQRQYBTPXGA>> RJAJPZAMAQV(Id32<YRJDGOUPWNL> graphId, Id32<MXAREIUAFLA> srcId, Id32<XYCEOHQMMOR> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBFE0", Offset = "0x2ADA5E0", VA = "0x182ADBFE0", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<BZFRCGZKOVF>, IQRQYBTPXGA>> FZWRHRILPUQ(Id32<YRJDGOUPWNL> graphId, Id32<KOCDTBIOGSC> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0300", Offset = "0x2ADE900", VA = "0x182AE0300", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> VBHSVIWGPOV(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF360", Offset = "0x2ADD960", VA = "0x182ADF360", Slot = "62")]
		public Result<ControlPanelRootData, OYBEQJHIRPM> RDJKZCZYVNH(Id128<YRJDGOUPWNL> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, OYBEQJHIRPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC4C0", Offset = "0x2ADAAC0", VA = "0x182ADC4C0", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, IQRQYBTPXGA>> INHMEVGAIZP(Id128<YRJDGOUPWNL> graphId, Id128<BZFRCGZKOVF> inputNodeId, Id32<QKZKTYBWUBB> inputPortGroupId, Id32<RSMVXMQQIAP> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAD40", Offset = "0x2AD9340", VA = "0x182ADAD40", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, IQRQYBTPXGA>> CULFYJEACXK(Id128<YRJDGOUPWNL> graphId, Id128<BZFRCGZKOVF> outputNodeId, Id32<QKZKTYBWUBB> outputPortGroupId, Id32<EKZRYTEBJRU> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC300", Offset = "0x2ADA900", VA = "0x182ADC300", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, IQRQYBTPXGA>> HHHJKLTVNLH(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDD60", Offset = "0x2ADC360", VA = "0x182ADDD60", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<BZFRCGZKOVF>>, IQRQYBTPXGA>> ODTIZEFNNOG(Id128<YRJDGOUPWNL> intoGraphId, CircuitTemplateRootData a, IEnumerable<UMNTAHYOPJM> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0C50", Offset = "0x2ADF250", VA = "0x182AE0C50", Slot = "67")]
		public CircuitsData YLOQKLTUFJK()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBE70", Offset = "0x2ADA470", VA = "0x182ADBE70", Slot = "68")]
		public CircuitsData EPDGILBVKRD()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAB80", Offset = "0x2AD9180", VA = "0x182ADAB80", Slot = "71")]
		public CircuitsTemplateData COQWYLCOHXQ(TemplateSerializationReason a, Id32<YRJDGOUPWNL> sourceGraphId, IEnumerable<Id128<YRJDGOUPWNL>> graphIds, IEnumerable<Id128<BZFRCGZKOVF>> nodeIds, ISet<Id128<XHEPRZIYYMD>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF1A0", Offset = "0x2ADD7A0", VA = "0x182ADF1A0")]
		private CircuitsTemplateData QWDDQUOISWD(TemplateSerializationReason a, Id32<YRJDGOUPWNL> sourceGraphId, IEnumerable<Id128<YRJDGOUPWNL>> graphIds, IEnumerable<Id128<BZFRCGZKOVF>> nodeIds, ISet<Id128<XHEPRZIYYMD>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB690", Offset = "0x2AD9C90", VA = "0x182ADB690", Slot = "69")]
		public CircuitsTemplateData EAPGTPSQOMB(TemplateSerializationReason a, Id32<YRJDGOUPWNL> sourceGraphId, IEnumerable<Id128<BZFRCGZKOVF>> nodeIds, IEnumerable<UMNTAHYOPJM> b, ISet<Id128<XHEPRZIYYMD>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB8F0", Offset = "0x2AD9EF0", VA = "0x182ADB8F0", Slot = "70")]
		public CircuitsTemplateData EAPGTPSQOMB(TemplateSerializationReason a, Id32<YRJDGOUPWNL> sourceGraphId, IEnumerable<Id32<BZFRCGZKOVF>> nodeIds, IEnumerable<UMNTAHYOPJM> b, ISet<Id128<XHEPRZIYYMD>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAFE0", Offset = "0x2AD95E0", VA = "0x182ADAFE0")]
		private static IEnumerable<Id128<YRJDGOUPWNL>> DDUIULPSJIT(IEnumerable<UMNTAHYOPJM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDEC0", Offset = "0x2ADC4C0", VA = "0x182ADDEC0")]
		private IEnumerable<Id128<BZFRCGZKOVF>> ONEJMPVZANF(IEnumerable<UMNTAHYOPJM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC410", Offset = "0x2ADAA10", VA = "0x182ADC410", Slot = "72")]
		public List<UDJDWBKYLLQ> HVKCTUNFHKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD430", Offset = "0x2ADBA30", VA = "0x182ADD430")]
		public (List<UDJDWBKYLLQ>, bool) LPLJCCVOELL([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, UPEVSDLKQCG b, AMTRPXQSZYW c)
		{
			return default((List<UDJDWBKYLLQ>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFFF0", Offset = "0x2ADE5F0", VA = "0x182ADFFF0", Slot = "74")]
		public bool UAMVGVQDFMI(Id32<YRJDGOUPWNL> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAA30", Offset = "0x2AD9030", VA = "0x182ADAA30", Slot = "75")]
		public bool CFQWFBNXCAS(Id32<YRJDGOUPWNL> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC140", Offset = "0x2ADA740", VA = "0x182ADC140")]
		internal void GGITSCEEWWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0F10", Offset = "0x2ADF510", VA = "0x182AE0F10")]
		internal Task ZTGYMFZIBNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9DA0", Offset = "0x2AD83A0", VA = "0x182AD9DA0", Slot = "76")]
		public Result<Id32<MXAREIUAFLA>?, IQRQYBTPXGA> AVXMMDQGMDD(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<XYCEOHQMMOR> inputId)
		{
			return default(Result<Id32<MXAREIUAFLA>?, IQRQYBTPXGA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC620", Offset = "0x2ADAC20", VA = "0x182ADC620", Slot = "77")]
		public Result<Id32<XYCEOHQMMOR>?, IQRQYBTPXGA> ISXXFXZFYEZ(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<MXAREIUAFLA> outputId)
		{
			return default(Result<Id32<XYCEOHQMMOR>?, IQRQYBTPXGA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2ADED70", Offset = "0x2ADD370", VA = "0x182ADED70", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, IQRQYBTPXGA>> QJJZHFWUXQW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDC00", Offset = "0x2ADC200", VA = "0x182ADDC00", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, IQRQYBTPXGA>> MUXFBPFDLSE(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB440", Offset = "0x2AD9A40", VA = "0x182ADB440", Slot = "80")]
		public Id32<BZFRCGZKOVF>? DHACSZUZNQK(Id32<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0F30", Offset = "0x2ADF530", VA = "0x182AE0F30", Slot = "81")]
		public Id32<BZFRCGZKOVF>? ZZBGRANXQCP(Id32<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAAC0", Offset = "0x2AD90C0", VA = "0x182ADAAC0", Slot = "82")]
		public int CIGRCFGKPAT(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB520", Offset = "0x2AD9B20", VA = "0x182ADB520", Slot = "83")]
		public int DWXQRIEGAQE(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0640", Offset = "0x2ADEC40", VA = "0x182AE0640", Slot = "84")]
		public int WQQVJJMCGDD(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<OVRKYFBGDJO> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0220", Offset = "0x2ADE820", VA = "0x182AE0220", Slot = "85")]
		public int UYORVNKQGZV(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<OVRKYFBGDJO> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE00E0", Offset = "0x2ADE6E0", VA = "0x182AE00E0", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, IQRQYBTPXGA>> UQPQFICCMXZ(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<OVRKYFBGDJO> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFE50", Offset = "0x2ADE450", VA = "0x182ADFE50", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, IQRQYBTPXGA>> TJVWTKSUVCE(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<OVRKYFBGDJO> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0CE0", Offset = "0x2ADF2E0", VA = "0x182AE0CE0", Slot = "88")]
		public int ZKRSMKWDPTZ(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAEA0", Offset = "0x2AD94A0", VA = "0x182ADAEA0", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, IQRQYBTPXGA>> DACRGGXRXPH(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9C40", Offset = "0x2AD8240", VA = "0x182AD9C40", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, IQRQYBTPXGA>> AKEQPBCNZMC(Id32<YRJDGOUPWNL> graphId, Id32<BZFRCGZKOVF> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD060", Offset = "0x2ADB660", VA = "0x182ADD060", Slot = "91")]
		public bool JGLIZWQANLJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFB70", Offset = "0x2ADE170", VA = "0x182ADFB70", Slot = "97")]
		public IEnumerable<Id32<LYZTJSPJQLD>> RTBIZQQQKBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0C30", Offset = "0x2ADF230", VA = "0x182AE0C30", Slot = "98")]
		public string? YGISTDLHSFD(Id32<LYZTJSPJQLD> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBF20", Offset = "0x2ADA520", VA = "0x182ADBF20", Slot = "7")]
		private bool FDIQTMFTDLT(Id32<YRJDGOUPWNL> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD3E0", Offset = "0x2ADB9E0", VA = "0x182ADD3E0", Slot = "24")]
		private MHPSHNFTXZN LFXIZJKMGCU([In] Id128<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF330", Offset = "0x2ADD930", VA = "0x182ADF330", Slot = "26")]
		private Id32<YRJDGOUPWNL> QYXTQRORUVD([In] Id128<YRJDGOUPWNL> graphId)
		{
			return default(Id32<YRJDGOUPWNL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAB50", Offset = "0x2AD9150", VA = "0x182ADAB50", Slot = "27")]
		private Id32<YRJDGOUPWNL>? COJRSNHSTMF([In] Id128<YRJDGOUPWNL> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF080", Offset = "0x2ADD680", VA = "0x182ADF080", Slot = "29")]
		private LTLVYHVMHDH QVKFZZNHQAA([In] Id128<BZFRCGZKOVF> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBF30", Offset = "0x2ADA530", VA = "0x182ADBF30", Slot = "31")]
		private Id32<BZFRCGZKOVF> FEBKUZNYCGB(Id32<YRJDGOUPWNL> graphId, [In] Id128<BZFRCGZKOVF> legacyNodeId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC210", Offset = "0x2ADA810", VA = "0x182ADC210", Slot = "45")]
		private NewStaticEdge QSHXXBNZSHF(Id32<YRJDGOUPWNL> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC1E0", Offset = "0x2ADA7E0", VA = "0x182ADC1E0", Slot = "58")]
		private Result<OIGOTMLEWKK.PrepareTemplateForCloneResult, MIWOMKTZBCT> UVTHNGLLCPT([In] OIGOTMLEWKK.PrepareTemplateForCloneArgs args)
		{
			return default(Result<OIGOTMLEWKK.PrepareTemplateForCloneResult, MIWOMKTZBCT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0080", Offset = "0x2ADE680", VA = "0x182AE0080", Slot = "73")]
		private (List<UDJDWBKYLLQ>, bool) UOCDXQREXNT([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, UPEVSDLKQCG b, AMTRPXQSZYW c)
		{
			return default((List<UDJDWBKYLLQ>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC450", Offset = "0x2ADAA50", VA = "0x182ADC450")]
		[CompilerGenerated]
		private LRGAGZZTYVP INBPXHRXPWK(WPCWYXTKXZN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFDD0", Offset = "0x2ADE3D0", VA = "0x182ADFDD0")]
		[CompilerGenerated]
		private QPBKESVYPXS VAIFDNTHVFY(Id128<BZFRCGZKOVF> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFE20", Offset = "0x2ADE420", VA = "0x182ADFE20")]
		[CompilerGenerated]
		private HYNHSLIJNYN VANMAUNFERH(Id128<YRJDGOUPWNL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFDD0", Offset = "0x2ADE3D0", VA = "0x182ADFDD0")]
		[CompilerGenerated]
		private QPBKESVYPXS SZPKTKCBOVA(Id128<BZFRCGZKOVF> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFE20", Offset = "0x2ADE420", VA = "0x182ADFE20")]
		[CompilerGenerated]
		private HYNHSLIJNYN SZURQQVYYGJ(Id128<YRJDGOUPWNL> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class LRGAGZZTYVP : HKFDOQDIWNO
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
			public AsyncTaskMethodBuilder<Result<Id32<OVRKYFBGDJO>, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public LRGAGZZTYVP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<QKZKTYBWUBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<OVRKYFBGDJO>, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2AE59D0", Offset = "0x2AE3FD0", VA = "0x182AE59D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5C20", Offset = "0x2AE4220", VA = "0x182AE5C20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<WRHWMQQUVHP>, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public LRGAGZZTYVP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<YRJDGOUPWNL> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<BZFRCGZKOVF> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<QKZKTYBWUBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<WRHWMQQUVHP>, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5C90", Offset = "0x2AE4290", VA = "0x182AE5C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5EE0", Offset = "0x2AE44E0", VA = "0x182AE5EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly WPCWYXTKXZN ZAEZFMOPULG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly QFPJTZRYEHQ FJIOLEKUBZY;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey EYSKXGVGEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string OCANPTPUNPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2D00", Offset = "0x2AE1300", VA = "0x182AE2D00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public WPCWYXTKXZN WPCWYXTKXZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2EA0", Offset = "0x2AE14A0", VA = "0x182AE2EA0")]
		public LRGAGZZTYVP(WPCWYXTKXZN a, QFPJTZRYEHQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2D30", Offset = "0x2AE1330", VA = "0x182AE2D30", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<OVRKYFBGDJO>, IQRQYBTPXGA>> WQQZAQFRFAE(Id128<YRJDGOUPWNL> graphId, Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2B90", Offset = "0x2AE1190", VA = "0x182AE2B90", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<WRHWMQQUVHP>, IQRQYBTPXGA>> KYOHBYESJYJ(Id128<YRJDGOUPWNL> graphId, Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class TDQBLFOCFSP : OGRSLMQMIMZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly WPCWYXTKXZN QKHFPAHUBNB;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<WPCWYXTKXZN> DXIZUWPDFOD;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<WPCWYXTKXZN> VFMTBEYZCCQ;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<WPCWYXTKXZN> UVLODGYLVWB;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public WPCWYXTKXZN BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5810", Offset = "0x2AE3E10", VA = "0x182AE5810", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5800", Offset = "0x2AE3E00", VA = "0x182AE5800", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5860", Offset = "0x2AE3E60", VA = "0x182AE5860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5780", Offset = "0x2AE3D80", VA = "0x182AE5780", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3C40", Offset = "0x2AE2240", VA = "0x182AE3C40")]
		public bool IXSFUJNOUNW(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public TDQBLFOCFSP(WPCWYXTKXZN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3AB0", Offset = "0x2AE20B0", VA = "0x182AE3AB0")]
		internal static TypeKey GNQTCFTOIBX(WPCWYXTKXZN a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2D00", Offset = "0x2AE1300", VA = "0x182AE2D00", Slot = "3")]
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
	public readonly struct ActionDeps : ZHESUVALAPM.MMCLHALQCZX<LOHJEAGYXDY, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9820", Offset = "0x2AD7E20", VA = "0x182AD9820", Slot = "4")]
		public int VTIGBYSSQDB(None a, LOHJEAGYXDY b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9840", Offset = "0x2AD7E40", VA = "0x182AD9840", Slot = "5")]
		public LOHJEAGYXDY VZMVBJKFMHE(None a, LOHJEAGYXDY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9710", Offset = "0x2AD7D10", VA = "0x182AD9710", Slot = "6")]
		public LOHJEAGYXDY CWGMURTZBIB(None a, LOHJEAGYXDY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9740", Offset = "0x2AD7D40", VA = "0x182AD9740", Slot = "7")]
		public IReadOnlyList<LOHJEAGYXDY> HCHLPJAUPQL(None a, LOHJEAGYXDY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9850", Offset = "0x2AD7E50", VA = "0x182AD9850", Slot = "8")]
		public LOHJEAGYXDY[] YFGBXPDVSFQ(None a, LOHJEAGYXDY b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9800", Offset = "0x2AD7E00", VA = "0x182AD9800", Slot = "9")]
		public bool PWRHUNUJCAP(None a, LOHJEAGYXDY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9780", Offset = "0x2AD7D80", VA = "0x182AD9780", Slot = "10")]
		public bool LMZPVYPXEDZ(None a, LOHJEAGYXDY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9760", Offset = "0x2AD7D60", VA = "0x182AD9760", Slot = "11")]
		public bool HLVPTMOBWAH(None a, LOHJEAGYXDY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD97C0", Offset = "0x2AD7DC0", VA = "0x182AD97C0", Slot = "12")]
		public bool OLTZAMDITED(None a, LOHJEAGYXDY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD97A0", Offset = "0x2AD7DA0", VA = "0x182AD97A0", Slot = "13")]
		public bool MKJWTCZWPNX(None a, LOHJEAGYXDY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD97E0", Offset = "0x2AD7DE0", VA = "0x182AD97E0", Slot = "14")]
		public bool OZXVJMSQABO(None a, LOHJEAGYXDY b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class TFEDGSGTJQM : SVUOYNNHAFU
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract NSYQZFEHSAE.ETPODEKPKCV AJJBGENQMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract GCFTXZUHCVV.ETPODEKPKCV TAMVWCNWDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract IXJRKHRRWZM.ETPODEKPKCV KKWGCFWANYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV> HNQJNNXCKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5980", Offset = "0x2AE3F80", VA = "0x182AE5980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.ETPODEKPKCV KKRRWLHBOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract GNHUSEXYYOY BVEQRGODZUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract XKMIIYNPIFP VOIUHUXOAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract WBTIGOWHAUR XVOEQIEJWDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract AATAVYXKSWN KTBLMYHBMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract OYLYGLUJTWX DMLXLIZEOHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected TFEDGSGTJQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class NRCOGVQRMEE : CLSUDKYJBPS
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
			public AsyncTaskMethodBuilder<Result<MultiResult, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<LOHJEAGYXDY> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public NRCOGVQRMEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6500", Offset = "0x2AE4B00", VA = "0x182AE6500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6920", Offset = "0x2AE4F20", VA = "0x182AE6920", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public NRCOGVQRMEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public LOHJEAGYXDY action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB270", Offset = "0x2AE9870", VA = "0x182AEB270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB480", Offset = "0x2AE9A80", VA = "0x182AEB480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly MPBKAGBRDNH QMJVBYAJDVV;

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public NRCOGVQRMEE(MPBKAGBRDNH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2F60", Offset = "0x2AE1560", VA = "0x182AE2F60")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, IQRQYBTPXGA>> DWHUSIKYOHL(LOHJEAGYXDY a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3090", Offset = "0x2AE1690", VA = "0x182AE3090", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, IQRQYBTPXGA>> LFPTMEAKYVL(IReadOnlyList<LOHJEAGYXDY> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, LOHJEAGYXDY, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x1317F40", Offset = "0x1316540", VA = "0x181317F40")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, LOHJEAGYXDY, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3620", Offset = "0x2AE1C20", VA = "0x182AE3620")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class UZQELJMUJZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, LOHJEAGYXDY, PartialActionReassemblyDeps> RJWMRNTLXHA(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, LOHJEAGYXDY, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : WIXMXIZOYVQ.UWEOGEPSJXO<PartialActionPayload, Id128<PartialActionPayload.M>, LOHJEAGYXDY>
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3440", Offset = "0x2AE1A40", VA = "0x182AE3440", Slot = "7")]
		public LOHJEAGYXDY UAOKXXYEOSC(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x13118D0", Offset = "0x130FED0", VA = "0x1813118D0")]
		public Id128<PartialActionPayload.M> ZVGUBTYDHCQ([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x132C200", Offset = "0x132A800", VA = "0x18132C200")]
		public int CADDZLWEJNW([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3430", Offset = "0x2AE1A30", VA = "0x182AE3430")]
		public int SSAJDZDYTZN([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x132C200", Offset = "0x132A800", VA = "0x18132C200", Slot = "4")]
		private int DELPBQKBDCE([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3430", Offset = "0x2AE1A30", VA = "0x182AE3430", Slot = "5")]
		private int TWIUGDRVNNV([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x13118D0", Offset = "0x130FED0", VA = "0x1813118D0", Slot = "6")]
		private Id128<PartialActionPayload.M> RWYHGPJHLGI([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, LOHJEAGYXDY, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x1317F40", Offset = "0x1316540", VA = "0x181317F40")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, LOHJEAGYXDY, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3A50", Offset = "0x2AE2050", VA = "0x182AE3A50")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class PXWOMNWHXVW
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static SnapshotReassembly<PartialInitializePayload, LOHJEAGYXDY, SnapshotReassemblyDeps> RJWMRNTLXHA(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, LOHJEAGYXDY, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : ASMADUTVFRX.UWJVDLJPTIX<PartialInitializePayload, LOHJEAGYXDY>
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x150B310", Offset = "0x1509910", VA = "0x18150B310")]
		public int TRVLUPBCCKW([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3870", Offset = "0x2AE1E70", VA = "0x182AE3870", Slot = "5")]
		public LOHJEAGYXDY GIAWXAVGDEI(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x150B310", Offset = "0x1509910", VA = "0x18150B310", Slot = "4")]
		private int EJQJALLFWAC([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class OTUSXJAXVEU : VMQHICPCFYT, MIWOMKTZBCT, IQRQYBTPXGA, OYBEQJHIRPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly OYBEQJHIRPM? ZQJGYMVAOQC;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind CXTXOPLXEQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6A0", Offset = "0xAA9CA0", VA = "0x180AAB6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override OYBEQJHIRPM? JWXELWZLBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE31C0", Offset = "0x2AE17C0", VA = "0x182AE31C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE33F0", Offset = "0x2AE19F0", VA = "0x182AE33F0")]
		private OTUSXJAXVEU(PrepareTemplateForCloneErrKind a, OYBEQJHIRPM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE32C0", Offset = "0x2AE18C0", VA = "0x182AE32C0")]
		public static OTUSXJAXVEU JBUPDQMWNUY(OYBEQJHIRPM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3390", Offset = "0x2AE1990", VA = "0x182AE3390")]
		public static OTUSXJAXVEU ZPUIHTISRGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3330", Offset = "0x2AE1930", VA = "0x182AE3330")]
		public static OTUSXJAXVEU QCDXQDJFUSU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class IMXTUKVUMNZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x393D720", Offset = "0x393BD20", VA = "0x18393D720")]
		public static Result<TOk, MIWOMKTZBCT> FZERXJBXZXP<TOk>([In] this Result<TOk, MIWOMKTZBCT> self, OYBEQJHIRPM a) where TOk : notnull
		{
			return default(Result<TOk, MIWOMKTZBCT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x393D550", Offset = "0x393BB50", VA = "0x18393D550")]
		public static Result<a?, MIWOMKTZBCT?> FIOKFNRCADD<a>([In] this Result<a, MIWOMKTZBCT> self)
		{
			return default(Result<a, MIWOMKTZBCT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x393D6A0", Offset = "0x393BCA0", VA = "0x18393D6A0")]
		public static Result<b?, MIWOMKTZBCT?> FJLYFXICTGD<b>([In] this Result<b, MIWOMKTZBCT> self)
		{
			return default(Result<b, MIWOMKTZBCT>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface GNHUSEXYYOY
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XNWJJMCAOHG([In] Result<None, OYBEQJHIRPM> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class RYBHZINKFYW
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF270", Offset = "0x3CED870", VA = "0x183CEF270")]
		public static bool XNWJJMCAOHG<TOk, TErr>(this GNHUSEXYYOY a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, OYBEQJHIRPM
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface XKMIIYNPIFP
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		GYYCSYOYAST DPIKKLHIITU
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface WBTIGOWHAUR
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor HOEENHCUGQE(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface PPUPYVIEOQM
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface GYSERZIXQTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EAIAVYWLRWT? HVPOVWNGLJW(Id32<QKZKTYBWUBB> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface XUCBSQCRJOZ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface EAIAVYWLRWT
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XUCBSQCRJOZ? JXQJEKNUPDA(Id32<OVRKYFBGDJO> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PPUPYVIEOQM? ERXQBZTQDSZ(Id32<WRHWMQQUVHP> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface AATAVYXKSWN
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> HNZTTXKWHBT(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface OYLYGLUJTWX
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GYSERZIXQTR? BQTQWTERKBY([In] Id128<KJWLGRGGWLZ> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class JBWIOPUOKRM
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
			public readonly List<LOHJEAGYXDY> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9910", Offset = "0x2AD7F10", VA = "0x182AD9910")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<LOHJEAGYXDY> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9860", Offset = "0x2AD7E60", VA = "0x182AD9860")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly NVVVNDMWSNF<Diagnostic> XYPZMSUHZTC;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static JBWIOPUOKRM ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1B70", Offset = "0x2AE0170", VA = "0x182AE1B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool LNPCSDYDXXY
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xBE49C0", Offset = "0xBE2FC0", VA = "0x180BE49C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1D80", Offset = "0x2AE0380", VA = "0x182AE1D80")]
		public void ZWNDEVNGTTL(QFPJTZRYEHQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1890", Offset = "0x2ADFE90", VA = "0x182AE1890")]
		public void ATHPXFJSXKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1BC0", Offset = "0x2AE01C0", VA = "0x182AE1BC0")]
		private static string? VOCNGIRRCPQ([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1F30", Offset = "0x2AE0530", VA = "0x182AE1F30")]
		public JBWIOPUOKRM()
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
