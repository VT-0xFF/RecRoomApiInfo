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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x287F8D0", Offset = "0x287E0D0", VA = "0x18287F8D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x287EFD0", Offset = "0x287D7D0", VA = "0x18287EFD0", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class WUFOVRVICVI : IDisposable, NJGRZRZNSSX, SQWWKBIAPXQ, QSFYHFVEOWT
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class VOHKIDOFRIF : ZVDGYJVWQXS
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int HLOELWGHGRH
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x288D410", Offset = "0x288BC10", VA = "0x18288D410", Slot = "5")]
			public GWUCTVNWOHE ZJBTICZALNX(USDOVPRHJYZ.ZVDGYJVWQXS a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void MWNQCCSIIOD();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void CQYOPPXHXVM();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x286DB20", Offset = "0x286C320", VA = "0x18286DB20", Slot = "13")]
			public virtual void UYIQLOFRWJY(WUFOVRVICVI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x288D230", Offset = "0x288BA30", VA = "0x18288D230", Slot = "14")]
			public virtual void TVXGPLCNJID(WUFOVRVICVI a, UZPYRKQPSNH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			protected VOHKIDOFRIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ZVDGYJVWQXS
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int HLOELWGHGRH
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			GWUCTVNWOHE ZJBTICZALNX(USDOVPRHJYZ.ZVDGYJVWQXS a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void MWNQCCSIIOD();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void CQYOPPXHXVM();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void UYIQLOFRWJY(WUFOVRVICVI a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void TVXGPLCNJID(WUFOVRVICVI a, UZPYRKQPSNH b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, UZPYRKQPSNH, WUFOVRVICVI, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
			internal Reducer(Reducer<ActionKind, UZPYRKQPSNH, WUFOVRVICVI, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class AIZPACHMDAL : ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly AIZPACHMDAL QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private AIZPACHMDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x12A1C10", Offset = "0x12A0410", VA = "0x1812A1C10", Slot = "4")]
			public ActionKind INQWKGUZWUL(UZPYRKQPSNH a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2877E10", Offset = "0x2876610", VA = "0x182877E10", Slot = "5")]
			public void UYIQLOFRWJY(WUFOVRVICVI a, UZPYRKQPSNH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2877D00", Offset = "0x2876500", VA = "0x182877D00", Slot = "6")]
			public void TVXGPLCNJID(WUFOVRVICVI a, UZPYRKQPSNH b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, UZPYRKQPSNH, WUFOVRVICVI, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x28829D0", Offset = "0x28811D0", VA = "0x1828829D0")]
			internal ReducerFactory(ReducerFactory<ActionKind, UZPYRKQPSNH, WUFOVRVICVI, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2882980", Offset = "0x2881180", VA = "0x182882980")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : WJCXSIBAOJT.IOXFUTEZPJN<UZPYRKQPSNH, WUFOVRVICVI>
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
				public AsyncTaskMethodBuilder<Result<object?, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public WUFOVRVICVI receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public UZPYRKQPSNH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2883BD0", Offset = "0x28823D0", VA = "0x182883BD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2883DB0", Offset = "0x28825B0", VA = "0x182883DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB10170", Offset = "0xB0E970", VA = "0x180B10170", Slot = "4")]
			public Id32<ZORKRESYKMD> KRXXVVLKKZK(WUFOVRVICVI a)
			{
				return default(Id32<ZORKRESYKMD>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2882DD0", Offset = "0x28815D0", VA = "0x182882DD0", Slot = "5")]
			public void XJBBNLIOUNZ(WUFOVRVICVI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2882C80", Offset = "0x2881480", VA = "0x182882C80", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, SPRIBHSTRKT>> NPBBJAIZAHE(WUFOVRVICVI a, UZPYRKQPSNH b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2882DB0", Offset = "0x28815B0", VA = "0x182882DB0", Slot = "7")]
			public UZPYRKQPSNH[] PNLTOGLYJII(WUFOVRVICVI a)
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
			public AsyncTaskMethodBuilder<Result<object?, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public WUFOVRVICVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public UZPYRKQPSNH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2883E20", Offset = "0x2882620", VA = "0x182883E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2884010", Offset = "0x2882810", VA = "0x182884010", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public WUFOVRVICVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2885540", Offset = "0x2883D40", VA = "0x182885540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x28857C0", Offset = "0x2883FC0", VA = "0x1828857C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public WUFOVRVICVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2885830", Offset = "0x2884030", VA = "0x182885830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2885A10", Offset = "0x2884210", VA = "0x182885A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<ZORKRESYKMD> PQSVSNYONVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer MTQBSJRLNGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 RTLKWXUXEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly YMJQTRDYOVJ BFCLWNWRFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly MONBQIUQOND.CreationArgs AXCWFQBZSGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly PYVYNENRTPM XIKXZWSNOZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly MFPHAPTIQKB WOQZDNCKATS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly VZSSPUNIJYG NATPYODOKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly APEJHQPIFSP EUWBWUQGMXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly NNJKMUFBXEV UGZXEMLHQQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly GNBEYXIUXWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly VHTIVZWZVIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest SDPDNAGPLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended VSOZPBLCGYA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal ZVDGYJVWQXS QGCIQPQNNXN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2898530", Offset = "0x2896D30", VA = "0x182898530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal GWUCTVNWOHE OVJPGVZBQNT
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2899020", Offset = "0x2897820", VA = "0x182899020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2899170", Offset = "0x2897970", VA = "0x182899170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool FWPXZZHPHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2898520", Offset = "0x2896D20", VA = "0x182898520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2898A00", Offset = "0x2897200", VA = "0x182898A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public KPKCFYGHLRH PYVYNENRTPM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2899480", Offset = "0x2897C80", VA = "0x182899480", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UUGPZWYKYBJ VZSSPUNIJYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2899490", Offset = "0x2897C90", VA = "0x182899490", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EWIDHKPBELO NNJKMUFBXEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x28994B0", Offset = "0x2897CB0", VA = "0x1828994B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NZIZKTKPFPC MFPHAPTIQKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2898A10", Offset = "0x2897210", VA = "0x182898A10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IRVABWOEAUE APEJHQPIFSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x28994A0", Offset = "0x2897CA0", VA = "0x1828994A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MONBQIUQOND? MONBQIUQOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2897F50", Offset = "0x2896750", VA = "0x182897F50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2899190", Offset = "0x2897990", VA = "0x182899190")]
		private WUFOVRVICVI(YMJQTRDYOVJ a, Id32<ZORKRESYKMD> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, GWUCTVNWOHE b, [In] MONBQIUQOND.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2898670", Offset = "0x2896E70", VA = "0x182898670")]
		public static WUFOVRVICVI New(YMJQTRDYOVJ deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<ZORKRESYKMD> actorId, Id32<SJYBMYLJCNS> rootNetworkObjectId, KIQIZMMDNIQ staticNetSys, YXPWXONPQVW dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2898740", Offset = "0x2896F40", VA = "0x182898740")]
		public static WUFOVRVICVI New(YMJQTRDYOVJ dependencies, [In] RegistryV2 registryV2, Id32<ZORKRESYKMD> actorId, Id32<SJYBMYLJCNS> rootNetworkObjectId, KIQIZMMDNIQ staticNetSys, YXPWXONPQVW dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28981C0", Offset = "0x28969C0", VA = "0x1828981C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2898580", Offset = "0x2896D80", VA = "0x182898580")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, SPRIBHSTRKT>> JHYRQYHLDWL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2899030", Offset = "0x2897830", VA = "0x182899030")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, SPRIBHSTRKT>> WVBUFXLWBUV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2898E20", Offset = "0x2897620", VA = "0x182898E20")]
		internal void RBWQNUOGHQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2897ED0", Offset = "0x28966D0", VA = "0x182897ED0")]
		internal Option<UZPYRKQPSNH> BJIHPRXFQZV([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<UZPYRKQPSNH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28984B0", Offset = "0x2896CB0", VA = "0x1828984B0")]
		internal bool GUVZUGQYMII([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2898040", Offset = "0x2896840", VA = "0x182898040")]
		internal Result<UZPYRKQPSNH, SPRIBHSTRKT> DXAKIRYKKSX([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<UZPYRKQPSNH, SPRIBHSTRKT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2899120", Offset = "0x2897920", VA = "0x182899120")]
		private void XJBBNLIOUNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28983A0", Offset = "0x2896BA0", VA = "0x1828983A0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, SPRIBHSTRKT>> FWECNHQWFVB(UZPYRKQPSNH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2898A20", Offset = "0x2897220", VA = "0x182898A20")]
		private UZPYRKQPSNH[] PNLTOGLYJII()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class EYMEMGCPTCS<a> : GPJDWMBBLWO, FPIPAJSNWLS, ZVSGMZZHZEF where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<CATHGSEFVUK>? TYVXWARWKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a AROSVOGBSTV;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<CATHGSEFVUK>? KNGRWGYCBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2B6E670", Offset = "0x2B6CE70", VA = "0x182B6E670", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4785420", Offset = "0x4783C20", VA = "0x184785420")]
		internal EYMEMGCPTCS([In] Id128<CATHGSEFVUK>? lastNode, Id32<YPMXJKHDXAR>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class CNNIRPQETSU
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2879D50", Offset = "0x2878550", VA = "0x182879D50")]
		public static Result<DebugExecutionResult, FPIPAJSNWLS> IUBTGNDBJCD([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, FPIPAJSNWLS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x349C720", Offset = "0x349AF20", VA = "0x18349C720")]
		public static Result<TOk, FPIPAJSNWLS> SAZPPSHIDXT<TOk>([In] this Result<TOk, FPIPAJSNWLS> self, [In] Id128<CATHGSEFVUK>? lastNode, Id32<YPMXJKHDXAR>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, FPIPAJSNWLS>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface YMJQTRDYOVJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		USDOVPRHJYZ.ZVDGYJVWQXS ZWFVDBYFRZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		WUFOVRVICVI.ZVDGYJVWQXS GWXMDICXLBG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		UODJRLEVSXT.ZVDGYJVWQXS KYVASCOZIDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI> AIZPACHMDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.ZVDGYJVWQXS VMPVWCQGZFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		JDJZIVHVKYR ZMXIIHZYOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		HBXNNDQOUSM FSGGIZXFAUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		JMIZFOBJITY DOXWMKSIFVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		GQGQFHQZALQ UZRORNEAVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		UHZWDRMUWQU HMZZDAZSRHV
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
	public static class OOGIOIBDAIY
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x287FA20", Offset = "0x287E220", VA = "0x18287FA20")]
		public static UZPYRKQPSNH KUSANZCFKBF(this UZPYRKQPSNH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x287FB30", Offset = "0x287E330", VA = "0x18287FB30")]
		public static UZPYRKQPSNH OCFFWBJJICY(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public WUFOVRVICVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2884080", Offset = "0x2882880", VA = "0x182884080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28847A0", Offset = "0x2882FA0", VA = "0x1828847A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x287B380", Offset = "0x2879B80", VA = "0x18287B380")]
		public static UZPYRKQPSNH JSDTFNOSAUB(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x287B440", Offset = "0x2879C40", VA = "0x18287B440")]
		public static ReduceAction<ActionKind, CompressedPayload> UYJGILICUSA(UZPYRKQPSNH actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x287B270", Offset = "0x2879A70", VA = "0x18287B270")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, SPRIBHSTRKT>> FWECNHQWFVB(WUFOVRVICVI a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x287B4F0", Offset = "0x2879CF0", VA = "0x18287B4F0")]
		public static UZPYRKQPSNH JSDTFNOSAUB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x287B610", Offset = "0x2879E10", VA = "0x18287B610")]
		public static ReduceAction<ActionKind, DestroyPayload> UYJGILICUSA(UZPYRKQPSNH actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x287B590", Offset = "0x2879D90", VA = "0x18287B590")]
		public static Result<None, UKTPHMNXTOY> TQCQCFLVQEN(WUFOVRVICVI a, [In] DestroyPayload self)
		{
			return default(Result<None, UKTPHMNXTOY>);
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
			public AsyncTaskMethodBuilder<Result<None, UKTPHMNXTOY>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public WUFOVRVICVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, UKTPHMNXTOY> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2884880", Offset = "0x2883080", VA = "0x182884880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2884E20", Offset = "0x2883620", VA = "0x182884E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C99A20", Offset = "0x1C98220", VA = "0x181C99A20")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x287B7C0", Offset = "0x2879FC0", VA = "0x18287B7C0")]
		public static UZPYRKQPSNH? JSDTFNOSAUB(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x287B8C0", Offset = "0x287A0C0", VA = "0x18287B8C0")]
		public static ReduceAction<ActionKind, FullInitializePayload> UYJGILICUSA(UZPYRKQPSNH actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x287B680", Offset = "0x2879E80", VA = "0x18287B680")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, UKTPHMNXTOY>> FWECNHQWFVB(WUFOVRVICVI a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public WUFOVRVICVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, SPRIBHSTRKT> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, ZVSGMZZHZEF>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, ZVSGMZZHZEF> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, ZVSGMZZHZEF>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2884340", Offset = "0x2882B40", VA = "0x182884340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2884810", Offset = "0x2883010", VA = "0x182884810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<UZPYRKQPSNH> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		private MultiPayload(IReadOnlyList<UZPYRKQPSNH> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x287F200", Offset = "0x287DA00", VA = "0x18287F200")]
		public static UZPYRKQPSNH JSDTFNOSAUB(IReadOnlyList<UZPYRKQPSNH> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x287F2C0", Offset = "0x287DAC0", VA = "0x18287F2C0")]
		public static ReduceAction<ActionKind, MultiPayload> UYJGILICUSA(UZPYRKQPSNH actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x287F0C0", Offset = "0x287D8C0", VA = "0x18287F0C0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, SPRIBHSTRKT>> FWECNHQWFVB(WUFOVRVICVI a, MultiPayload b)
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
		private sealed class CUVLNHMVYHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> QAKNFRGPFTS;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CUVLNHMVYHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x287A1F0", Offset = "0x28789F0", VA = "0x18287A1F0")]
			internal UZPYRKQPSNH WOYPCCFUUWE(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2880300", Offset = "0x287EB00", VA = "0x182880300")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x287FF10", Offset = "0x287E710", VA = "0x18287FF10")]
		public static UZPYRKQPSNH JSDTFNOSAUB(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x287FE10", Offset = "0x287E610", VA = "0x18287FE10")]
		public static UZPYRKQPSNH[] BYJPFTFNNUU(UZPYRKQPSNH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28801B0", Offset = "0x287E9B0", VA = "0x1828801B0")]
		public static ReduceAction<ActionKind, PartialActionPayload> UYJGILICUSA(UZPYRKQPSNH actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2880020", Offset = "0x287E820", VA = "0x182880020")]
		public static Result<UZPYRKQPSNH, SPRIBHSTRKT> TQCQCFLVQEN(WUFOVRVICVI a, [In] PartialActionPayload self)
		{
			return default(Result<UZPYRKQPSNH, SPRIBHSTRKT>);
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
			public AsyncTaskMethodBuilder<Result<bool, UKTPHMNXTOY>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public WUFOVRVICVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, UKTPHMNXTOY> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, UKTPHMNXTOY>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2884E90", Offset = "0x2883690", VA = "0x182884E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28854D0", Offset = "0x2883CD0", VA = "0x1828854D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xB146D0", Offset = "0xB12ED0", VA = "0x180B146D0")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2880640", Offset = "0x287EE40", VA = "0x182880640")]
		public static UZPYRKQPSNH JSDTFNOSAUB(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2880320", Offset = "0x287EB20", VA = "0x182880320")]
		public static UZPYRKQPSNH?[]? EAWFRHKGXKO(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2880720", Offset = "0x287EF20", VA = "0x182880720")]
		public static ReduceAction<ActionKind, PartialInitializePayload> UYJGILICUSA(UZPYRKQPSNH actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2880510", Offset = "0x287ED10", VA = "0x182880510")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, UKTPHMNXTOY>> FWECNHQWFVB(WUFOVRVICVI a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class PYVYNENRTPM : KPKCFYGHLRH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CXJYZXVVTXY? QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x287FD10", Offset = "0x287E510", VA = "0x18287FD10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		internal PYVYNENRTPM(WUFOVRVICVI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class BVVLUTOYBEF : CXJYZXVVTXY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly MONBQIUQOND FXFVFYWEEKN;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xABC070", Offset = "0xABA870", VA = "0x180ABC070")]
		public BVVLUTOYBEF(WUFOVRVICVI a, MONBQIUQOND b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28796D0", Offset = "0x2877ED0", VA = "0x1828796D0", Slot = "4")]
		public Result<DebugExecutionResult, FPIPAJSNWLS> HPWQMEPORRH(Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<CLOCUIODAVK> inputId)
		{
			return default(Result<DebugExecutionResult, FPIPAJSNWLS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2879120", Offset = "0x2877920", VA = "0x182879120", Slot = "5")]
		public Result<DebugExecutionResult, FPIPAJSNWLS> FBPAKCQHJYI(Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<RYQAJTIFIUP> outputId)
		{
			return default(Result<DebugExecutionResult, FPIPAJSNWLS>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class USDOVPRHJYZ : GWUCTVNWOHE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface ZVDGYJVWQXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<ORNTCHYXYPW> ULUEHIOQJKB(WUFOVRVICVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void RCYEGXGWMET(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class VOHKIDOFRIF : ZVDGYJVWQXS
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
				public AsyncTaskMethodBuilder<ORNTCHYXYPW> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public WUFOVRVICVI circuitsManager;

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
				private TaskAwaiter<UODJRLEVSXT> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2883180", Offset = "0x2881980", VA = "0x182883180", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2883350", Offset = "0x2881B50", VA = "0x182883350", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x288D2B0", Offset = "0x288BAB0", VA = "0x18288D2B0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<ORNTCHYXYPW> ULUEHIOQJKB(WUFOVRVICVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void RCYEGXGWMET(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			protected VOHKIDOFRIF()
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
			public AsyncTaskMethodBuilder<ORNTCHYXYPW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public USDOVPRHJYZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28833C0", Offset = "0x2881BC0", VA = "0x1828833C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28835C0", Offset = "0x2881DC0", VA = "0x1828835C0", Slot = "5")]
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
			public USDOVPRHJYZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public WUFOVRVICVI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<ORNTCHYXYPW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2883630", Offset = "0x2881E30", VA = "0x182883630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2883B70", Offset = "0x2882370", VA = "0x182883B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ZVDGYJVWQXS FPRKQLVLHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> MEIZQJRPDSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> USTSSLJSTHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource HPSVQPYHPZM;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool FWPXZZHPHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB046C0", Offset = "0xB02EC0", VA = "0x180B046C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB045B0", Offset = "0xB02DB0", VA = "0x180B045B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCBFFA0", Offset = "0xCBE7A0", VA = "0x180CBFFA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD06E10", Offset = "0xD05610", VA = "0x180D06E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GSDVJNSIEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x181DE10", Offset = "0x181C610", VA = "0x18181DE10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x186FB70", Offset = "0x186E370", VA = "0x18186FB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ORNTCHYXYPW? QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB2B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2888E50", Offset = "0x2887650", VA = "0x182888E50", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<ORNTCHYXYPW> OEPQNVATAPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2889080", Offset = "0x2887880", VA = "0x182889080")]
		public USDOVPRHJYZ(ZVDGYJVWQXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2888F40", Offset = "0x2887740", VA = "0x182888F40", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task WQGPVIEVCNZ(WUFOVRVICVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2888CE0", Offset = "0x28874E0", VA = "0x182888CE0", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class NDCMHEQDFLK : IYIVKDQYSHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly SMTWMJSHTAK WOPSEWMLHJH;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public NDCMHEQDFLK(SMTWMJSHTAK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class XKCFIMIIUSP
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class AOBTNQIURFF<a> : QCLYYAWWCMI where a : QOPESGRMHHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a JEEQQRVNDPG;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? DUQSNZRSAVU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xC6A370", Offset = "0xC68B70", VA = "0x180C6A370", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<CATHGSEFVUK>? CMANLHMZSEG
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x544D5A0", Offset = "0x544BDA0", VA = "0x18544D5A0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<VAEORNAZREW> TPRAXEVDNOU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B6AD80", Offset = "0x2B69580", VA = "0x182B6AD80", Slot = "5")]
				get
				{
					return default(Id32<VAEORNAZREW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<VAEORNAZREW>? QFGRFZPLJPS
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x544D650", Offset = "0x544BE50", VA = "0x18544D650", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
			public AOBTNQIURFF(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class OFLRPXGRFWD : AOBTNQIURFF<GNNGDJBVYNN>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? DUQSNZRSAVU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xDC3630", Offset = "0xDC1E30", VA = "0x180DC3630", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x287F950", Offset = "0x287E150", VA = "0x18287F950")]
			public OFLRPXGRFWD(GNNGDJBVYNN a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x28994C0", Offset = "0x2897CC0", VA = "0x1828994C0")]
		public static QCLYYAWWCMI New(QOPESGRMHHI graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class VIAFYVXSFTB : RKCKKEDEFWK, IGMMKFROMTK, XHHKBSRZIYH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class LKNKIBAMZQN
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
				public LKNKIBAMZQN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public JDJZIVHVKYR errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x2886C20", Offset = "0x2885420", VA = "0x182886C20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x2886E90", Offset = "0x2885690", VA = "0x182886E90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public VIAFYVXSFTB BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool TNGWVLCUTUU;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public LKNKIBAMZQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x287EEE0", Offset = "0x287D6E0", VA = "0x18287EEE0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task ODECKRWYJLT(JDJZIVHVKYR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class BUGNOQDRGAV
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
				public BUGNOQDRGAV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x2886EF0", Offset = "0x28856F0", VA = "0x182886EF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x28871D0", Offset = "0x28859D0", VA = "0x1828871D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public VIAFYVXSFTB BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int TNGWVLCUTUU;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public BUGNOQDRGAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2879050", Offset = "0x2877850", VA = "0x182879050")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task QZYFSBQPHQH(JDJZIVHVKYR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class PTDBVDQQLVC
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
				public PTDBVDQQLVC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x2887740", Offset = "0x2885F40", VA = "0x182887740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x2887BF0", Offset = "0x28863F0", VA = "0x182887BF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string TNGWVLCUTUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public VIAFYVXSFTB BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int TRPVHJWOCVK;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public PTDBVDQQLVC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x287FC40", Offset = "0x287E440", VA = "0x18287FC40")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task VAWKRYIFKOZ(JDJZIVHVKYR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class BXUWIEAYTKL
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
				public BXUWIEAYTKL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x2887230", Offset = "0x2885A30", VA = "0x182887230", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x28876E0", Offset = "0x2885EE0", VA = "0x1828876E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string TNGWVLCUTUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public VIAFYVXSFTB BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int TRPVHJWOCVK;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public BXUWIEAYTKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2879C80", Offset = "0x2878480", VA = "0x182879C80")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task CZSAAFVGBEZ(JDJZIVHVKYR a)
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
			public VIAFYVXSFTB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2885A80", Offset = "0x2884280", VA = "0x182885A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2885F90", Offset = "0x2884790", VA = "0x182885F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly VIYOADZLFJE MDTTMWAPSRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<SHHTDAZPMGE> FTOJMHQSWQR;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private YMJQTRDYOVJ VOHKIDOFRIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2889850", Offset = "0x2888050", VA = "0x182889850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<CLOCUIODAVK> BUZJJGXNWIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB89190", Offset = "0xB87990", VA = "0x180B89190", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<CLOCUIODAVK>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xC6DC00", Offset = "0xC6C400", VA = "0x180C6DC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<ITYZVGJUOOJ> KFYOPCWMXJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2814190", Offset = "0x2812990", VA = "0x182814190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<WZTXETPFGMO> VBCQMIJJFAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xFEC2E0", Offset = "0xFEAAE0", VA = "0x180FEC2E0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WZTXETPFGMO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<YPMXJKHDXAR> XBXCHAIVHII
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2889F50", Offset = "0x2888750", VA = "0x182889F50", Slot = "22")]
			get
			{
				return default(Id32<YPMXJKHDXAR>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool AKEOOTAKRGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x288CF80", Offset = "0x288B780", VA = "0x18288CF80", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x288D000", Offset = "0x288B800", VA = "0x18288D000")]
		private VIAFYVXSFTB(WUFOVRVICVI a, LBKZHWCVPSD b, VIYOADZLFJE c, Id32<JIWIEDNGUWY> portGroupId, Id32<CLOCUIODAVK> inputId, Id32<ITYZVGJUOOJ> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x288B0F0", Offset = "0x28898F0", VA = "0x18288B0F0")]
		public static VIAFYVXSFTB New(WUFOVRVICVI circuitsManager, LBKZHWCVPSD node, VIYOADZLFJE input, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId, Id32<CLOCUIODAVK> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x288A490", Offset = "0x2888C90", VA = "0x18288A490", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2889670", Offset = "0x2887E70", VA = "0x182889670", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x288B4A0", Offset = "0x2889CA0", VA = "0x18288B4A0", Slot = "32")]
		public void OJFUCYXZTSS(SHHTDAZPMGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x288AD30", Offset = "0x2889530", VA = "0x18288AD30", Slot = "29")]
		public void NPSAJNYEBEV(VAOGVSXWKOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x288BBF0", Offset = "0x288A3F0", VA = "0x18288BBF0", Slot = "30")]
		public void YROWMZJRUFK(KGFRRRIUBTI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x288AA20", Offset = "0x2889220", VA = "0x18288AA20", Slot = "25")]
		protected override void LPOQUNNMJRU(FMAAJTLCBCR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2889500", Offset = "0x2887D00", VA = "0x182889500", Slot = "34")]
		public string DAUQGKCXVUL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x288A1D0", Offset = "0x28889D0", VA = "0x18288A1D0", Slot = "31")]
		public string IGCTTYQDAUN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x288AB00", Offset = "0x2889300", VA = "0x18288AB00")]
		private void NEWNALGUCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x288A110", Offset = "0x2888910", VA = "0x18288A110", Slot = "33")]
		public void HJNWBBBLACN(SHHTDAZPMGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2889180", Offset = "0x2887980", VA = "0x182889180")]
		private void BFUPGOFILLM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2889A10", Offset = "0x2888210", VA = "0x182889A10", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task FYLBARTENCG(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x288BAA0", Offset = "0x288A2A0", VA = "0x18288BAA0")]
		public void WLUBNCMCXST(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2889870", Offset = "0x2888070", VA = "0x182889870")]
		private void FKLBPPMOXNB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x288B500", Offset = "0x2889D00", VA = "0x18288B500")]
		private void QMVTNEEZERV(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2889340", Offset = "0x2887B40", VA = "0x182889340")]
		private void CXAZMUEQQAA(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2889710", Offset = "0x2887F10", VA = "0x182889710")]
		private string EQRDRECEAPV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2889FA0", Offset = "0x28887A0", VA = "0x182889FA0")]
		private string HBJJLOOWUNY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xC6DC00", Offset = "0xC6C400", VA = "0x180C6DC00")]
		internal void JGVBRHWXKTL(Id32<CLOCUIODAVK> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x288A880", Offset = "0x2889080", VA = "0x18288A880")]
		[CompilerGenerated]
		private void LIZZUIMVPSS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x288A890", Offset = "0x2889090", VA = "0x18288A890")]
		[CompilerGenerated]
		private bool LJFGRPGSZEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x288A7C0", Offset = "0x2888FC0", VA = "0x18288A7C0")]
		[CompilerGenerated]
		private bool LIUSXBSYGHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x288A6E0", Offset = "0x2888EE0", VA = "0x18288A6E0")]
		[CompilerGenerated]
		private int LIEYFHLGDZI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x288A730", Offset = "0x2888F30", VA = "0x18288A730")]
		[CompilerGenerated]
		private bool LIKFCOFDNKR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x288A610", Offset = "0x2888E10", VA = "0x18288A610")]
		[CompilerGenerated]
		private void LHUKKTXLLCQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x288A620", Offset = "0x2888E20", VA = "0x18288A620")]
		[CompilerGenerated]
		private bool LHZRIARIUNZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x288A530", Offset = "0x2888D30", VA = "0x18288A530")]
		[CompilerGenerated]
		private bool LHJWQGJQSFY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x288A580", Offset = "0x2888D80", VA = "0x18288A580")]
		[CompilerGenerated]
		private bool LHPDNNDOBRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x288A6E0", Offset = "0x2888EE0", VA = "0x18288A6E0")]
		[CompilerGenerated]
		private int TKVOTTULLTF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x288B970", Offset = "0x288A170", VA = "0x18288B970")]
		[CompilerGenerated]
		private bool TKQHWNAOCHW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x288BA40", Offset = "0x288A240", VA = "0x18288BA40")]
		[CompilerGenerated]
		private object TLGCOHIGEPX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2889EF0", Offset = "0x28886F0", VA = "0x182889EF0")]
		[CompilerGenerated]
		private void TLAVRAOIVEO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x288B810", Offset = "0x288A010", VA = "0x18288B810")]
		[CompilerGenerated]
		private bool TJVGHLYYQOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x288B8F0", Offset = "0x288A0F0", VA = "0x18288B8F0")]
		[CompilerGenerated]
		private string TKLAZGGQSWN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x288B8E0", Offset = "0x288A0E0", VA = "0x18288B8E0")]
		[CompilerGenerated]
		private void TKFUBZMTJLE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x288B740", Offset = "0x2889F40", VA = "0x18288B740")]
		[CompilerGenerated]
		private bool TJFLPRRGOGL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x288B6C0", Offset = "0x2889EC0", VA = "0x18288B6C0")]
		[CompilerGenerated]
		private string TJAESKXJEVC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x288CD90", Offset = "0x288B590", VA = "0x18288CD90")]
		[CompilerGenerated]
		private void ZITYKYVECMM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x288CDA0", Offset = "0x288B5A0", VA = "0x18288CDA0")]
		[CompilerGenerated]
		private bool ZIZFIFPBLXV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x288CE70", Offset = "0x288B670", VA = "0x18288CE70")]
		[CompilerGenerated]
		private string ZJEMFMIYVJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x288CEF0", Offset = "0x288B6F0", VA = "0x18288CEF0")]
		[CompilerGenerated]
		private void ZJJTCTCWEUN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x288CB70", Offset = "0x288B370", VA = "0x18288CB70")]
		[CompilerGenerated]
		private bool ZHYWVXTOQTC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x288CC40", Offset = "0x288B440", VA = "0x18288CC40")]
		[CompilerGenerated]
		private string ZIEDTENMAEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x288CCB0", Offset = "0x288B4B0", VA = "0x18288CCB0")]
		[CompilerGenerated]
		private void ZIJKQLHJJPU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x288CCC0", Offset = "0x288B4C0", VA = "0x18288CCC0")]
		[CompilerGenerated]
		private bool ZIORNSBGTBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x288CF00", Offset = "0x288B700", VA = "0x18288CF00")]
		[CompilerGenerated]
		private string ZKKBPAYIZZG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x288CF70", Offset = "0x288B770", VA = "0x18288CF70")]
		[CompilerGenerated]
		private void ZKPIMHSGJKP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2889E20", Offset = "0x2888620", VA = "0x182889E20")]
		[CompilerGenerated]
		private bool GJLDJRDGSEV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2889DB0", Offset = "0x28885B0", VA = "0x182889DB0")]
		[CompilerGenerated]
		private string GJFWMKJJITM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2889DA0", Offset = "0x28885A0", VA = "0x182889DA0")]
		[CompilerGenerated]
		private void GJAPPDPLZID(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2889CD0", Offset = "0x28884D0", VA = "0x182889CD0")]
		[CompilerGenerated]
		private bool GIVIRWVOPWU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2889C60", Offset = "0x2888460", VA = "0x182889C60")]
		[CompilerGenerated]
		private string GIQBUQBRGLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2889C50", Offset = "0x2888450", VA = "0x182889C50")]
		[CompilerGenerated]
		private void GIKUXJHTXAC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2889B80", Offset = "0x2888380", VA = "0x182889B80")]
		[CompilerGenerated]
		private bool GIFOACNWNOT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2889B20", Offset = "0x2888320", VA = "0x182889B20")]
		[CompilerGenerated]
		private object GIAHCVTZEDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2889EF0", Offset = "0x28886F0", VA = "0x182889EF0")]
		[CompilerGenerated]
		private void GLBGNTGLPRP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x288A950", Offset = "0x2889150", VA = "0x18288A950")]
		[CompilerGenerated]
		private bool LNYBDWRSNAW()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class RNPSOQYCXNN
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class HMRRDJVPIDP : CDXKHVRXGLX<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public HMRRDJVPIDP BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x287AAC0", Offset = "0x28792C0", VA = "0x18287AAC0")]
				internal object TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x287A670", Offset = "0x2878E70", VA = "0x18287A670")]
				internal void TTFCDDDXNGU(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x287BEC0", Offset = "0x287A6C0", VA = "0x18287BEC0")]
			public HMRRDJVPIDP(WUFOVRVICVI a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287A450", VA = "0x18287BC50", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class JWDYZJBFCJO : SMHIBYSWCDQ<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType APVBWANODKZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x287E360", Offset = "0x287CB60", VA = "0x18287E360")]
			public JWDYZJBFCJO(WUFOVRVICVI a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class QQJXRNONLMO : CDXKHVRXGLX<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2880AE0", Offset = "0x287F2E0", VA = "0x182880AE0")]
			public QQJXRNONLMO(WUFOVRVICVI a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2880800", Offset = "0x287F000", VA = "0x182880800", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2880A90", Offset = "0x287F290", VA = "0x182880A90")]
			[CompilerGenerated]
			private bool ZPVTEDTUPLR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2880960", Offset = "0x287F160", VA = "0x182880960")]
			[CompilerGenerated]
			private void ZPQMGWZXGAI(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class KHKXPXKVPKC : CDXKHVRXGLX<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public KHKXPXKVPKC BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x287AB70", Offset = "0x2879370", VA = "0x18287AB70")]
				internal void TTKJAJXUWSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x287A620", Offset = "0x2878E20", VA = "0x18287A620")]
				internal bool TTFCDDDXNGU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x287AE80", Offset = "0x2879680", VA = "0x18287AE80")]
				internal bool TTUWUXLPPOV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x287ACB0", Offset = "0x28794B0", VA = "0x18287ACB0")]
				internal void TTPPXQRSGDM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x287A3B0", Offset = "0x2878BB0", VA = "0x18287A3B0")]
				internal bool TSPHLIWFKYT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x287EE70", Offset = "0x287D670", VA = "0x18287EE70")]
			public KHKXPXKVPKC(WUFOVRVICVI a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x287EB60", Offset = "0x287D360", VA = "0x18287EB60", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class YAHUGKLVZDY : CDXKHVRXGLX<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public YAHUGKLVZDY BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> HGJBZNYLKJR;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x287ABC0", Offset = "0x28793C0", VA = "0x18287ABC0")]
				internal object? TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x287A470", Offset = "0x2878C70", VA = "0x18287A470")]
				internal bool TSUOIPQCUKC(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x287A870", Offset = "0x2879070", VA = "0x18287A870")]
				internal void TTFCDDDXNGU(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x287AED0", Offset = "0x28796D0", VA = "0x18287AED0")]
				internal string TTUWUXLPPOV(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x287ADE0", Offset = "0x28795E0", VA = "0x18287ADE0")]
				internal IReadOnlyList<object> TTPPXQRSGDM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x287A400", Offset = "0x2878C00", VA = "0x18287A400")]
				internal bool TSPHLIWFKYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x287A360", Offset = "0x2878B60", VA = "0x18287A360")]
				internal bool TSKAOCCIBNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x287A4F0", Offset = "0x2878CF0", VA = "0x18287A4F0")]
				internal void TSZVFWKADVL(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2899D30", Offset = "0x2898530", VA = "0x182899D30")]
			public YAHUGKLVZDY(WUFOVRVICVI a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2899640", Offset = "0x2897E40", VA = "0x182899640", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class QRIYYFFQUIF : CDXKHVRXGLX<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public QRIYYFFQUIF BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x287AB20", Offset = "0x2879320", VA = "0x18287AB20")]
				internal bool TTKJAJXUWSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x287A740", Offset = "0x2878F40", VA = "0x18287A740")]
				internal void TTFCDDDXNGU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x287AE30", Offset = "0x2879630", VA = "0x18287AE30")]
				internal bool TTUWUXLPPOV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2880D60", Offset = "0x287F560", VA = "0x182880D60")]
			public QRIYYFFQUIF(WUFOVRVICVI a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2880B50", Offset = "0x287F350", VA = "0x182880B50", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class BJZCJLRFCSG : CDXKHVRXGLX<TPBDAAMDDPZ>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class JHXZLDGKHPS
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
					public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public JHXZLDGKHPS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<FHFSLOAARZW>, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x28863D0", Offset = "0x2884BD0", VA = "0x1828863D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x28867B0", Offset = "0x2884FB0", VA = "0x1828867B0", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public JHXZLDGKHPS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x2886820", Offset = "0x2885020", VA = "0x182886820", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x2886BB0", Offset = "0x28853B0", VA = "0x182886BB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task WIPFBTOEMOQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string PKKBXTELLJQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public IEYQOFDLLGC.WBXFUMIJEYE ZUYAUHFUWRF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool MMSNYSWHMKX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public BJZCJLRFCSG BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public IEYQOFDLLGC JWRPDAYPJQJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action FQVDMWDWUNZ;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public JHXZLDGKHPS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x287DE20", Offset = "0x287C620", VA = "0x18287DE20")]
				internal bool HPYFWDHIDFL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				internal string QJSXESDDIBA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x287E2E0", Offset = "0x287CAE0", VA = "0x18287E2E0")]
				internal void QJNQHLJFYPR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x287E290", Offset = "0x287CA90", VA = "0x18287E290")]
				internal void QJIJKEPIPEI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x134A970", Offset = "0x1349170", VA = "0x18134A970")]
				internal bool QJDCMXVLFSZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x287E070", Offset = "0x287C870", VA = "0x18287E070")]
				internal void QIXVPRBNWHQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x287E030", Offset = "0x287C830", VA = "0x18287E030")]
				internal bool QISOSKHQMWH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x287DF40", Offset = "0x287C740", VA = "0x18287DF40")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, SPRIBHSTRKT>> OCFMPOKGUIV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x287DE50", Offset = "0x287C650", VA = "0x18287DE50")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, SPRIBHSTRKT>> LFYVCUTRJGS()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class JZDWTNUPEWK
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
					public AsyncTaskMethodBuilder<Result<Id32<FHFSLOAARZW>, SPRIBHSTRKT>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<FHFSLOAARZW>, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x2885FF0", Offset = "0x28847F0", VA = "0x182885FF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x2886360", Offset = "0x2884B60", VA = "0x182886360", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public BJZCJLRFCSG BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public MPXBTOPSSLG COJLAGMMWIZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool JUKJENEEPHP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public IEYQOFDLLGC JWRPDAYPJQJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public SYZCVXWMDUY RJYIBNCODLN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action HFTHHTQTIBQ;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public JZDWTNUPEWK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x287E750", Offset = "0x287CF50", VA = "0x18287E750")]
				internal object? TTFCDDDXNGU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x287E8B0", Offset = "0x287D0B0", VA = "0x18287E8B0")]
				internal void TTUWUXLPPOV(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x287E7C0", Offset = "0x287CFC0", VA = "0x18287E7C0")]
				internal string TTPPXQRSGDM(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x287E580", Offset = "0x287CD80", VA = "0x18287E580")]
				internal IReadOnlyList<object> TSPHLIWFKYT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x287E420", Offset = "0x287CC20", VA = "0x18287E420")]
				internal void TSKAOCCIBNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x287E6E0", Offset = "0x287CEE0", VA = "0x18287E6E0")]
				internal bool TSZVFWKADVL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x287E620", Offset = "0x287CE20", VA = "0x18287E620")]
				internal void TSUOIPQCUKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x287EA20", Offset = "0x287D220", VA = "0x18287EA20")]
				internal void TVAMEMAZUEX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x287E9A0", Offset = "0x287D1A0", VA = "0x18287E9A0")]
				internal void TUVFHFHCKTO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x287E3C0", Offset = "0x287CBC0", VA = "0x18287E3C0")]
				internal bool AYDRUPCFPTC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x287EA70", Offset = "0x287D270", VA = "0x18287EA70")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<FHFSLOAARZW>, SPRIBHSTRKT>> ZJCFQOUNRKE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<VAEORNAZREW>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x2879010", Offset = "0x2877810", VA = "0x182879010", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2878FA0", Offset = "0x28777A0", VA = "0x182878FA0")]
			public BJZCJLRFCSG(WUFOVRVICVI a, TPBDAAMDDPZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2877F80", Offset = "0x2876780", VA = "0x182877F80", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2878910", Offset = "0x2877110", VA = "0x182878910")]
			private void VVROMPGKOGP(IEYQOFDLLGC a, Id32<FHFSLOAARZW>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class YRJGYUSIUHR : MMMKPOJFBVM<ZPVSLVSTYCE>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1CA98F0", Offset = "0x1CA80F0", VA = "0x181CA98F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool JSWKWCCQQCK
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool QSSCCSQPHYV
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool WJPTRWYWUMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2899DA0", Offset = "0x28985A0", VA = "0x182899DA0")]
			public YRJGYUSIUHR(WUFOVRVICVI a, ZPVSLVSTYCE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class WMQHLOLFCUX<a> : CDXKHVRXGLX<a> where a : notnull, HBJDYBVBQGJ
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
				public AsyncTaskMethodBuilder<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public WMQHLOLFCUX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x4E33E10", Offset = "0x4E32610", VA = "0x184E33E10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x4E34160", Offset = "0x4E32960", VA = "0x184E34160", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public WMQHLOLFCUX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<JIWIEDNGUWY> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x5103E20", Offset = "0x5102620", VA = "0x185103E20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x5104170", Offset = "0x5102970", VA = "0x185104170", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<JIWIEDNGUWY>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x66B6090", Offset = "0x66B4890", VA = "0x1866B6090", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x66B6060", Offset = "0x66B4860", VA = "0x1866B6060")]
			protected WMQHLOLFCUX(WUFOVRVICVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x66B5CF0", Offset = "0x66B44F0", VA = "0x1866B5CF0", Slot = "122")]
			[AsyncStateMachine(typeof(WMQHLOLFCUX<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> NPFVKWIFNJK(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x66B5FC0", Offset = "0x66B47C0", VA = "0x1866B5FC0", Slot = "149")]
			public sealed override bool ZEUPXIHMVKB(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x66B5C50", Offset = "0x66B4450", VA = "0x1866B5C50", Slot = "134")]
			protected sealed override bool ITASEUWQBBV(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x66B5F20", Offset = "0x66B4720", VA = "0x1866B5F20", Slot = "135")]
			protected override bool YBNWZPRIWZK(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x66B5E10", Offset = "0x66B4610", VA = "0x1866B5E10", Slot = "123")]
			[AsyncStateMachine(typeof(WMQHLOLFCUX<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, SPRIBHSTRKT>> OCGBGORZVLJ(Id32<JIWIEDNGUWY> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class SDKSGWBVMFM : SWIKTYSXHQN<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public SDKSGWBVMFM BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x287B0A0", Offset = "0x28798A0", VA = "0x18287B0A0")]
				internal bool UXIPSUAWAVU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x287B120", Offset = "0x2879920", VA = "0x18287B120")]
				internal void UXNWQAUTKHD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2882C20", Offset = "0x2881420", VA = "0x182882C20")]
			public SDKSGWBVMFM(WUFOVRVICVI a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x28829E0", Offset = "0x28811E0", VA = "0x1828829E0", Slot = "151")]
			protected override void CEIDJWPHJMW(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class NITABDEXSRF : CDXKHVRXGLX<OGAENFRWSEY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class OVYXGTZWSNL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int MDLKPPRGHPU;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public OVYXGTZWSNL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x287FC00", Offset = "0x287E400", VA = "0x18287FC00")]
				internal bool QLOCIOGLKWK(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class TPKTMYRKYMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public NITABDEXSRF BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> NTTEGIGXLTG;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TPKTMYRKYMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2882F50", Offset = "0x2881750", VA = "0x182882F50")]
				internal int TTKJAJXUWSD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x2882E30", Offset = "0x2881630", VA = "0x182882E30")]
				internal void TTFCDDDXNGU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x2882FF0", Offset = "0x28817F0", VA = "0x182882FF0")]
				internal string? TTUWUXLPPOV()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x287F860", Offset = "0x287E060", VA = "0x18287F860")]
			public NITABDEXSRF(WUFOVRVICVI a, OGAENFRWSEY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x287F360", Offset = "0x287DB60", VA = "0x18287F360")]
			private int HKYLKACYVHG(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x287F740", Offset = "0x287DF40", VA = "0x18287F740")]
			private void KCRLGBXXHHI(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x287F3F0", Offset = "0x287DBF0", VA = "0x18287F3F0", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class RJKRJOOTUFT : MMMKPOJFBVM<NDEWMDKOEBY>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2880DD0", Offset = "0x287F5D0", VA = "0x182880DD0")]
			public RJKRJOOTUFT(WUFOVRVICVI a, NDEWMDKOEBY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class MMMKPOJFBVM<a> : CDXKHVRXGLX<a> where a : notnull, FNJDKHJFNPU
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class NAISWONUTDQ
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
					public NAISWONUTDQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x3CD0100", Offset = "0x3CCE900", VA = "0x183CD0100", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public IEYQOFDLLGC JWRPDAYPJQJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public MMMKPOJFBVM<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action HGDVCHEOAYI;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public NAISWONUTDQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x587EF40", Offset = "0x587D740", VA = "0x18587EF40")]
				internal void TTKJAJXUWSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x587EA40", Offset = "0x587D240", VA = "0x18587EA40")]
				[AsyncStateMachine(typeof(MMMKPOJFBVM<>.NAISWONUTDQ.<<BuildConfigMenuInternal>b__6>d))]
				internal void TSZVFWKADVL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x587EAE0", Offset = "0x587D2E0", VA = "0x18587EAE0")]
				internal bool TTFCDDDXNGU()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class NANZTVHSCOZ
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
					public NANZTVHSCOZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x3CCF930", Offset = "0x3CCE130", VA = "0x183CCF930", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string LZYPMAYICSE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public NAISWONUTDQ GPYHOBUULHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> HHEDOPAAWDB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> HGOIWUSITVA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action HGTPUBMGDGJ;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public NANZTVHSCOZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x587F2A0", Offset = "0x587DAA0", VA = "0x18587F2A0")]
				internal void TTUWUXLPPOV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				internal string TTPPXQRSGDM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
				internal void TSPHLIWFKYT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x587F200", Offset = "0x587DA00", VA = "0x18587F200")]
				[AsyncStateMachine(typeof(MMMKPOJFBVM<>.NANZTVHSCOZ.<<BuildConfigMenuInternal>b__5>d))]
				internal void TSKAOCCIBNK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class IKLFJXTOAOP
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
					public IKLFJXTOAOP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<XSORAGHTHUW>, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3CCD0C0", Offset = "0x3CCB8C0", VA = "0x183CCD0C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public IKLFJXTOAOP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3CCD800", Offset = "0x3CCC000", VA = "0x183CCD800", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public IKLFJXTOAOP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<ITYZVGJUOOJ>, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x3CCD9E0", Offset = "0x3CCC1E0", VA = "0x183CCD9E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public MMMKPOJFBVM<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<JIWIEDNGUWY> SSDIYFRNGIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public IEYQOFDLLGC JWRPDAYPJQJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public EXEXARECGOC OSAXXELICNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int HXRQUWHXODS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int TVFXKWMZCPY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public YBETPIMTIQD BKUTWMOWHOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string KZHBSXTCGUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<VTREXZDFCRH> JYVQVBNFPQK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public YBETPIMTIQD GFOVUCJVCBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string PDXTUCOVLKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<VTREXZDFCRH> SSYJWRXFNQT;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public IKLFJXTOAOP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x5006740", Offset = "0x5004F40", VA = "0x185006740")]
				internal bool AZMBYIUBSDM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x50067B0", Offset = "0x5004FB0", VA = "0x1850067B0")]
				internal void AZRIVPNZBOV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5006BE0", Offset = "0x50053E0", VA = "0x185006BE0")]
				internal bool CHGMYOICNLI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5006660", Offset = "0x5004E60", VA = "0x185006660")]
				[AsyncStateMachine(typeof(MMMKPOJFBVM<>.IKLFJXTOAOP.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void AZBODVGGZGU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x5006700", Offset = "0x5004F00", VA = "0x185006700")]
				internal bool AZGVBCAEISD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x50069F0", Offset = "0x50051F0", VA = "0x1850069F0")]
				internal void CGLLJNGNBRY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x5006910", Offset = "0x5005110", VA = "0x185006910")]
				internal bool CFLCXFLAGNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x5006820", Offset = "0x5005020", VA = "0x185006820")]
				internal void CFFVZYRCXBW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x5006C20", Offset = "0x5005420", VA = "0x185006C20")]
				internal bool IEZPSMOXUTG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x5006580", Offset = "0x5004D80", VA = "0x185006580")]
				internal bool AYRAJHSMGKC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x50065F0", Offset = "0x5004DF0", VA = "0x1850065F0")]
				internal void AYWHGOMJPVL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x5006480", Offset = "0x5004C80", VA = "0x185006480")]
				[AsyncStateMachine(typeof(MMMKPOJFBVM<>.IKLFJXTOAOP.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void AYGMOUERNNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x5006520", Offset = "0x5004D20", VA = "0x185006520")]
				internal bool AYLTMAYOWYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x50063A0", Offset = "0x5004BA0", VA = "0x1850063A0")]
				internal bool AXVYUGQWUQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x5006410", Offset = "0x5004C10", VA = "0x185006410")]
				internal void AYBFRNKUECB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x5006B40", Offset = "0x5005340", VA = "0x185006B40")]
				[AsyncStateMachine(typeof(MMMKPOJFBVM<>.IKLFJXTOAOP.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void CHBGBHOFDZZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x5006AE0", Offset = "0x50052E0", VA = "0x185006AE0")]
				internal bool CGVZEAUHUOQ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class IKFYMQZQRDG
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
					public IKFYMQZQRDG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x3CCD3B0", Offset = "0x3CCBBB0", VA = "0x183CCD3B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string OYQTFJCYEQQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public IKLFJXTOAOP GPYHOBUULHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> HUEQUGLBJZV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> HTZJWZREAOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action HUPEOTYWCWN;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public IKFYMQZQRDG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x5006040", Offset = "0x5004840", VA = "0x185006040")]
				internal void CHLTVVBZWWR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				internal string CGGEMGMPSGP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
				internal void CGAXOZSSIVG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x5005FA0", Offset = "0x50047A0", VA = "0x185005FA0")]
				[AsyncStateMachine(typeof(MMMKPOJFBVM<>.IKFYMQZQRDG.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void CGQSGUAKLDH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class WFTKWXJFSZG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool JYVQVBNFPQK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public EXEXARECGOC OSAXXELICNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<VTREXZDFCRH> GUANXPTSDOT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public MMMKPOJFBVM<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<JIWIEDNGUWY> SSDIYFRNGIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int MRWNMMXWPXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> HHORJCNVOZT;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WFTKWXJFSZG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x66AFB70", Offset = "0x66AE370", VA = "0x1866AFB70")]
				internal bool QJFSIFKKRNM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class WFYRUEDDCKP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public XHHKBSRZIYH TIKWMVPHZNW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public WFTKWXJFSZG GPYHOBUULHO;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WFYRUEDDCKP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x66AFE10", Offset = "0x66AE610", VA = "0x1866AFE10")]
				internal void QJALKYQNICD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x66AFDC0", Offset = "0x66AE5C0", VA = "0x1866AFDC0")]
				internal bool QIVENRWPYQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x66AFC30", Offset = "0x66AE430", VA = "0x1866AFC30")]
				internal void QIPXQLCSPFL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x66AFBD0", Offset = "0x66AE3D0", VA = "0x1866AFBD0")]
				internal bool QIKQTEIVFUC()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class WGDYRKXALVY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public VTREXZDFCRH UFTSXWINEPQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public WFYRUEDDCKP GQOCFWCMNPP;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WGDYRKXALVY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x66AFF80", Offset = "0x66AE780", VA = "0x1866AFF80")]
				internal void QJKZFMEIAYV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class QJALWJEXTLX
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
					public QJALWJEXTLX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x3CD0BC0", Offset = "0x3CCF3C0", VA = "0x183CD0BC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> DDPNADWHCJQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public YBETPIMTIQD PXQGQAZLSKW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool JYVQVBNFPQK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public EXEXARECGOC OSAXXELICNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public XHHKBSRZIYH TIKWMVPHZNW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string OYQTFJCYEQQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public QJALWJEXTLX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x5BD1DE0", Offset = "0x5BD05E0", VA = "0x185BD1DE0")]
				internal int AGEEUVPCZDX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x5BD1B70", Offset = "0x5BD0370", VA = "0x185BD1B70")]
				internal void AFYXXOVFPSO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
				internal string AFTRAIBIGHF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x5BD1AB0", Offset = "0x5BD02B0", VA = "0x185BD1AB0")]
				[AsyncStateMachine(typeof(MMMKPOJFBVM<>.QJALWJEXTLX.<<CreatePortItemV2>b__3>d))]
				internal void AFOKDBHKWVW(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public MMMKPOJFBVM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x4E339F0", Offset = "0x4E321F0", VA = "0x184E339F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x4E33DA0", Offset = "0x4E325A0", VA = "0x184E33DA0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public MMMKPOJFBVM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<JIWIEDNGUWY> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x51041E0", Offset = "0x51029E0", VA = "0x1851041E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x5104510", Offset = "0x5102D10", VA = "0x185104510", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public MMMKPOJFBVM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x5109B10", Offset = "0x5108310", VA = "0x185109B10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x510A0B0", Offset = "0x51088B0", VA = "0x18510A0B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<JIWIEDNGUWY>, bool> KHTXMJXVCHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<JIWIEDNGUWY>, bool> IWPDVAFLXWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<JIWIEDNGUWY>, bool> BIXVCCMNSTF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<JIWIEDNGUWY>, bool> TBQBMOFXJUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<JIWIEDNGUWY>, bool> IIREOTPOGOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<JIWIEDNGUWY>, bool> ZPVDMZHGEHL;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool JSWKWCCQQCK
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool QSSCCSQPHYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool WJPTRWYWUMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<VAEORNAZREW>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x57F3950", Offset = "0x57F2150", VA = "0x1857F3950", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<JIWIEDNGUWY>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x57F3BB0", Offset = "0x57F23B0", VA = "0x1857F3BB0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<CATHGSEFVUK>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x57F39D0", Offset = "0x57F21D0", VA = "0x1857F39D0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x57F3780", Offset = "0x57F1F80", VA = "0x1857F3780")]
			public MMMKPOJFBVM(WUFOVRVICVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "154")]
			protected virtual bool VTPYXPPTOLJ(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "155")]
			protected virtual bool QVQAGTCWWLO(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "156")]
			protected virtual bool NQXZZAVNBDX(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "157")]
			protected virtual void IDRQABZZSUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x57F36E0", Offset = "0x57F1EE0", VA = "0x1857F36E0", Slot = "149")]
			public override bool ZEUPXIHMVKB(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x57F0AE0", Offset = "0x57EF2E0", VA = "0x1857F0AE0", Slot = "122")]
			[AsyncStateMachine(typeof(MMMKPOJFBVM<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> NPFVKWIFNJK(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x57F0E80", Offset = "0x57EF680", VA = "0x1857F0E80", Slot = "123")]
			[AsyncStateMachine(typeof(MMMKPOJFBVM<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, SPRIBHSTRKT>> OCGBGORZVLJ(Id32<JIWIEDNGUWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x57F0F90", Offset = "0x57EF790", VA = "0x1857F0F90", Slot = "124")]
			public override void PWISEFOPQMT(Id32<JIWIEDNGUWY> index, Id32<JIWIEDNGUWY> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x57F08A0", Offset = "0x57EF0A0", VA = "0x1857F08A0", Slot = "125")]
			public override IEnumerable<UZPYRKQPSNH> NJUIEDFXFJG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x57F33F0", Offset = "0x57F1BF0", VA = "0x1857F33F0")]
			[AsyncStateMachine(typeof(MMMKPOJFBVM<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, SPRIBHSTRKT>> VRSHGUQLWOH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "158")]
			protected virtual bool QLEUUUYJBDU(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "159")]
			protected virtual bool UIJJZHOOXDC(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "160")]
			protected virtual bool VONGNHQMWCR(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "161")]
			protected virtual bool NLQOBPUFBUF(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "162")]
			protected virtual bool SGRXNTMUMGN(Id32<JIWIEDNGUWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "163")]
			protected virtual bool YELYGTMVXZE(Id32<JIWIEDNGUWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "164")]
			protected virtual bool UHBYTQNQFNO(Id32<JIWIEDNGUWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "165")]
			protected virtual bool YKPUEHSOSIB(Id32<JIWIEDNGUWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "166")]
			protected virtual bool HCJUCXUAJRP(Id32<JIWIEDNGUWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "167")]
			protected virtual bool PKXULRVHCNO(Id32<JIWIEDNGUWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x57F0C00", Offset = "0x57EF400", VA = "0x1857F0C00", Slot = "168")]
			protected virtual List<YBETPIMTIQD> NPZWANVJDFQ(Id32<JIWIEDNGUWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "169")]
			protected virtual void WTTHMZXCJXN(IEYQOFDLLGC a, GSUPJLFMFYA b, EXEXARECGOC c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x57EEE90", Offset = "0x57ED690", VA = "0x1857EEE90", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x57F1AB0", Offset = "0x57F02B0", VA = "0x1857F1AB0")]
			private GSUPJLFMFYA VMFIAEDIHYS(IEYQOFDLLGC a, EXEXARECGOC b, Id32<JIWIEDNGUWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x57EF830", Offset = "0x57EE030", VA = "0x1857EF830")]
			private List<VTREXZDFCRH> LOXXVKKNBYX(IEYQOFDLLGC a, EXEXARECGOC b, GSUPJLFMFYA c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x57F1120", Offset = "0x57EF920", VA = "0x1857F1120")]
			private List<VTREXZDFCRH> RVDIFBQOXPN(IEYQOFDLLGC a, EXEXARECGOC b, XHHKBSRZIYH c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x57F34F0", Offset = "0x57F1CF0", VA = "0x1857F34F0")]
			private YBETPIMTIQD YSWDBOUKOWH(List<YBETPIMTIQD> a, XHHKBSRZIYH b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x57EEE30", Offset = "0x57ED630", VA = "0x1857EEE30")]
			[CompilerGenerated]
			private UZPYRKQPSNH DGZRLSNAZMH(LBKZHWCVPSD a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class HPLASSBHPVP : CDXKHVRXGLX<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public HPLASSBHPVP BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x2883130", Offset = "0x2881930", VA = "0x182883130")]
				internal int TTKJAJXUWSD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x28830A0", Offset = "0x28818A0", VA = "0x1828830A0")]
				internal Task<bool> TTFCDDDXNGU(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x287C0E0", Offset = "0x287A8E0", VA = "0x18287C0E0")]
			public HPLASSBHPVP(WUFOVRVICVI a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x287BF30", Offset = "0x287A730", VA = "0x18287BF30", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class HHZQZSNBWGZ : SWIKTYSXHQN<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public HHZQZSNBWGZ BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x287B020", Offset = "0x2879820", VA = "0x18287B020")]
				internal int UXIPSUAWAVU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x287B1D0", Offset = "0x28799D0", VA = "0x18287B1D0")]
				internal Task<bool> UXNWQAUTKHD(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x287BBF0", Offset = "0x287A3F0", VA = "0x18287BBF0")]
			public HHZQZSNBWGZ(WUFOVRVICVI a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x287B9D0", Offset = "0x287A1D0", VA = "0x18287B9D0", Slot = "151")]
			protected override void CEIDJWPHJMW(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class MSYNSCFHEIH : CDXKHVRXGLX<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xC8CF00", Offset = "0xC8B700", VA = "0x180C8CF00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x287F050", Offset = "0x287D850", VA = "0x18287F050")]
			public MSYNSCFHEIH(WUFOVRVICVI a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class IADHBDONIQL : CDXKHVRXGLX<ZVKEUEHTKXG>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class WSROETRUXZR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public IADHBDONIQL BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public IEYQOFDLLGC JWRPDAYPJQJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> TZYMSELHJSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> TZISAKDPHKY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> UATOHFMWVMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> UADTPLFETEI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> UAJAMRZCCPR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> UBJIYZUOXUK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> UBOPWGOMHFT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> BAKKTPZMPZZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> BAFDWJFPGOQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> BAUYODNHIWR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> BAPRQWTJZLI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> AZPJEOXXEGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> AZKCHIDZUVG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> AZZWZCLRXDH;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WSROETRUXZR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2896420", Offset = "0x2894C20", VA = "0x182896420")]
				internal bool TTKJAJXUWSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x28963C0", Offset = "0x2894BC0", VA = "0x1828963C0")]
				internal void TTFCDDDXNGU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2896310", Offset = "0x2894B10", VA = "0x182896310")]
				internal bool TSPHLIWFKYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x28962C0", Offset = "0x2894AC0", VA = "0x1828962C0")]
				internal bool TSKAOCCIBNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2896360", Offset = "0x2894B60", VA = "0x182896360")]
				internal void TSZVFWKADVL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2896470", Offset = "0x2894C70", VA = "0x182896470")]
				internal bool TUVFHFHCKTO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x288D690", Offset = "0x288BE90", VA = "0x18288D690")]
				internal bool AYDRUPCFPTC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x288D6E0", Offset = "0x288BEE0", VA = "0x18288D6E0")]
				internal void AYIYRVWCZEL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x288D590", Offset = "0x288BD90", VA = "0x18288D590")]
				internal bool AXIQFOAQDZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x288D5E0", Offset = "0x288BDE0", VA = "0x18288D5E0")]
				internal bool AXNXCUUNNLB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x288D630", Offset = "0x288BE30", VA = "0x18288D630")]
				internal void AXTEABOKWWK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x288D540", Offset = "0x288BD40", VA = "0x18288D540")]
				internal bool AWSVNTSYBRR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2895320", Offset = "0x2893B20", VA = "0x182895320")]
				internal bool OTUQQSHGQYC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2895370", Offset = "0x2893B70", VA = "0x182895370")]
				internal bool OTZXNZBEAJL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x28952D0", Offset = "0x2893AD0", VA = "0x1828952D0")]
				internal bool OTKCWETLYBK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x28953C0", Offset = "0x2893BC0", VA = "0x1828953C0")]
				internal bool OUPSFTIWCRM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2895410", Offset = "0x2893C10", VA = "0x182895410")]
				internal bool OUUZDACTMCV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2896F20", Offset = "0x2895720", VA = "0x182896F20")]
				internal bool VTQUAJNTUXB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2896ED0", Offset = "0x28956D0", VA = "0x182896ED0")]
				internal bool VTLNDCTWLLS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2896FC0", Offset = "0x28957C0", VA = "0x182896FC0")]
				internal void VUBHUXBONTT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x288E260", Offset = "0x288CA60", VA = "0x18288E260")]
				internal bool GVWUONJAXBA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x288E210", Offset = "0x288CA10", VA = "0x18288E210")]
				internal bool GVRNRGPDNPR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x288E1C0", Offset = "0x288C9C0", VA = "0x18288E1C0")]
				internal bool GVMGTZVGEEI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x288E350", Offset = "0x288CB50", VA = "0x18288E350")]
				internal bool GWRWDOKQIUK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x288E300", Offset = "0x288CB00", VA = "0x18288E300")]
				internal bool GWMPGHQSZJB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2896F70", Offset = "0x2895770", VA = "0x182896F70")]
				internal bool VTWAXQHREIK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2896DE0", Offset = "0x28955E0", VA = "0x182896DE0")]
				internal bool VSVSLIMEJDR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2896D80", Offset = "0x2895580", VA = "0x182896D80")]
				internal void VSQLOBSGZSI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2896E80", Offset = "0x2895680", VA = "0x182896E80")]
				internal bool VTGGFVZZCAJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2896E30", Offset = "0x2895630", VA = "0x182896E30")]
				internal bool VTAZIPGBSPA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2897070", Offset = "0x2895870", VA = "0x182897070")]
				internal void VVGXELQYSJV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2897020", Offset = "0x2895820", VA = "0x182897020")]
				internal bool VVBQHEXBIYM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2895220", Offset = "0x2893A20", VA = "0x182895220")]
				internal bool OSZPBRFRFES()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2895270", Offset = "0x2893A70", VA = "0x182895270")]
				internal void OTEVYXZOOQB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x288F4F0", Offset = "0x288DCF0", VA = "0x18288F4F0")]
				internal List<VTREXZDFCRH> OAFEPSUUDRY(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x288E2B0", Offset = "0x288CAB0", VA = "0x18288E2B0")]
				internal bool GWHIJAWVPXS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x288E430", Offset = "0x288CC30", VA = "0x18288E430")]
				internal int GXSEPWGDDZD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x288E3A0", Offset = "0x288CBA0", VA = "0x18288E3A0")]
				internal Task<bool> GXMXSPMFUNU(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2897BC0", Offset = "0x28963C0", VA = "0x182897BC0")]
				internal bool ZVKWNBUVQUA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2897C10", Offset = "0x2896410", VA = "0x182897C10")]
				internal bool ZVQDKIOTAFJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2897C60", Offset = "0x2896460", VA = "0x182897C60")]
				internal bool ZVVKHPIQJQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2897CB0", Offset = "0x28964B0", VA = "0x182897CB0")]
				internal int ZWAREWCNTCB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2897D00", Offset = "0x2896500", VA = "0x182897D00")]
				internal Task<bool> ZWFYCCWLCNK(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2897D90", Offset = "0x2896590", VA = "0x182897D90")]
				internal bool ZWLEZJQILYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2897DE0", Offset = "0x28965E0", VA = "0x182897DE0")]
				internal bool ZWQLWQKFVKC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2897E30", Offset = "0x2896630", VA = "0x182897E30")]
				internal bool ZWVSTXEDEVL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2897E80", Offset = "0x2896680", VA = "0x182897E80")]
				internal bool ZXGGOKRXXSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x28967B0", Offset = "0x2894FB0", VA = "0x1828967B0")]
				internal bool TXMMVWUDAAT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x288D990", Offset = "0x288C190", VA = "0x18288D990")]
				internal string DRTIYGPNFBG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x288DA30", Offset = "0x288C230", VA = "0x18288DA30")]
				internal void DSJDQAXFHJH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x288D830", Offset = "0x288C030", VA = "0x18288D830")]
				internal int DQYHJFNXTHW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x288D930", Offset = "0x288C130", VA = "0x18288D930")]
				internal void DROCAZVPVPX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x288D8E0", Offset = "0x288C0E0", VA = "0x18288D8E0")]
				internal bool DRIVDTBSMEO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x288DB40", Offset = "0x288C340", VA = "0x18288DB40")]
				internal bool DTOSZPMPLZJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x288DAF0", Offset = "0x288C2F0", VA = "0x18288DAF0")]
				internal bool DTJMCISSCOA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2897810", Offset = "0x2896010", VA = "0x182897810")]
				internal float XRFJKDAIKQO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2897860", Offset = "0x2896060", VA = "0x182897860")]
				internal void XRKQHJUFUBX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2897770", Offset = "0x2895F70", VA = "0x182897770")]
				internal bool XQUVPPMNRTW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x28977C0", Offset = "0x2895FC0", VA = "0x1828977C0")]
				internal bool XRACMWGLBFF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2897930", Offset = "0x2896130", VA = "0x182897930")]
				internal bool XSAKZEBXWJY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2896850", Offset = "0x2895050", VA = "0x182896850")]
				internal bool TXXAQKHXSXL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2896800", Offset = "0x2895000", VA = "0x182896800")]
				internal bool TXRTTDOAJMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2896C90", Offset = "0x2895490", VA = "0x182896C90")]
				internal bool TYHOKXVSLUD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x28968A0", Offset = "0x28950A0", VA = "0x1828968A0")]
				internal void TYCHNRBVCIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2897980", Offset = "0x2896180", VA = "0x182897980")]
				internal string XSFRWKVVFVH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x28978C0", Offset = "0x28960C0", VA = "0x1828978C0")]
				internal void XRPXEQODDNG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2896D30", Offset = "0x2895530", VA = "0x182896D30")]
				internal bool TYSCFLJNEQV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2896CE0", Offset = "0x28954E0", VA = "0x182896CE0")]
				internal bool TYMVIEPPVFM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2896760", Offset = "0x2894F60", VA = "0x182896760")]
				internal bool TVWJRUQYCNZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x28964C0", Offset = "0x2894CC0", VA = "0x1828964C0")]
				internal void TVRCUNXATCQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x288F3A0", Offset = "0x288DBA0", VA = "0x18288F3A0")]
				internal bool NWTGKMLAWES()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x288F3F0", Offset = "0x288DBF0", VA = "0x18288F3F0")]
				internal bool NWYNHTEYFQB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x288F300", Offset = "0x288DB00", VA = "0x18288F300")]
				internal bool NWISPYXGDIA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x288F350", Offset = "0x288DB50", VA = "0x18288F350")]
				internal bool NWNZNFRDMTJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x288F250", Offset = "0x288DA50", VA = "0x18288F250")]
				internal void NVYEVLJLKLI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x288F2B0", Offset = "0x288DAB0", VA = "0x18288F2B0")]
				internal bool NWDLSSDITWR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x288F1B0", Offset = "0x288D9B0", VA = "0x18288F1B0")]
				internal bool NVNRAXVQROQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x288F200", Offset = "0x288DA00", VA = "0x18288F200")]
				internal bool NVSXYEPOAZZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x288F440", Offset = "0x288DC40", VA = "0x18288F440")]
				internal bool NYJJOOOFTRM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x288F490", Offset = "0x288DC90", VA = "0x18288F490")]
				internal void NYOQLVIDDCV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x288E710", Offset = "0x288CF10", VA = "0x18288E710")]
				internal bool JRHOBQZOXLL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x288E6C0", Offset = "0x288CEC0", VA = "0x18288E6C0")]
				internal bool JRCHEKFROAC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x288E670", Offset = "0x288CE70", VA = "0x18288E670")]
				internal bool JQXAHDLUEOT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x288E620", Offset = "0x288CE20", VA = "0x18288E620")]
				internal bool JQRTJWRWVDK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x288E5B0", Offset = "0x288CDB0", VA = "0x18288E5B0")]
				internal object JQBYSCKESVJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x288E520", Offset = "0x288CD20", VA = "0x18288E520")]
				internal void JPWRUVQHJKA(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x288E7B0", Offset = "0x288CFB0", VA = "0x18288E7B0")]
				internal bool JSXRFTCTUYF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x288E760", Offset = "0x288CF60", VA = "0x18288E760")]
				internal bool JSSKIMIWLMW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x288D7E0", Offset = "0x288BFE0", VA = "0x18288D7E0")]
				internal int DQTONNKKDAT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x288D880", Offset = "0x288C080", VA = "0x18288D880")]
				internal void DQYVKUEHMMC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x288D740", Offset = "0x288BF40", VA = "0x18288D740")]
				internal bool DPYMYMIURHJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x288D790", Offset = "0x288BF90", VA = "0x18288D790")]
				internal bool DQDTVTCSASS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x288DAA0", Offset = "0x288C2A0", VA = "0x18288DAA0")]
				internal int DSJRRPNPANN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x28960D0", Offset = "0x28948D0", VA = "0x1828960D0")]
				internal void RRTCZYXSUUU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2896130", Offset = "0x2894930", VA = "0x182896130")]
				internal bool RRYJXFRQEGD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2896180", Offset = "0x2894980", VA = "0x182896180")]
				internal bool RSDQUMLNNRM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x28961D0", Offset = "0x28949D0", VA = "0x1828961D0")]
				internal bool RSIXRTFKXCV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2896020", Offset = "0x2894820", VA = "0x182896020")]
				internal int RRIPFLJYBYC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2896070", Offset = "0x2894870", VA = "0x182896070")]
				internal void RRNWCSDVLJL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2896220", Offset = "0x2894A20", VA = "0x182896220")]
				internal bool RTJGEBAXSHO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2896270", Offset = "0x2894A70", VA = "0x182896270")]
				internal bool RTONBHUVBSX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2897AD0", Offset = "0x28962D0", VA = "0x182897AD0")]
				internal bool YSKHYRFVKND()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2897A60", Offset = "0x2896260", VA = "0x182897A60")]
				internal object YRJZMJKIPIK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x28979D0", Offset = "0x28961D0", VA = "0x1828979D0")]
				internal void YRESPCQLFXB(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2897B70", Offset = "0x2896370", VA = "0x182897B70")]
				internal bool YUALCTJAHZX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2897B20", Offset = "0x2896320", VA = "0x182897B20")]
				internal bool YTVEFMPCYOO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x288DF70", Offset = "0x288C770", VA = "0x18288DF70")]
				internal object? ETDOKBOXOJE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x288DFE0", Offset = "0x288C7E0", VA = "0x18288DFE0")]
				internal void ETIVHIIUXUN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x288E120", Offset = "0x288C920", VA = "0x18288E120")]
				internal bool ETYPZCQNACO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x288E170", Offset = "0x288C970", VA = "0x18288E170")]
				internal int EUDWWJKKJNX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x288E070", Offset = "0x288C870", VA = "0x18288E070")]
				internal void ETOCEPCSHFW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x288E0D0", Offset = "0x288C8D0", VA = "0x18288E0D0")]
				internal bool ETTJBVWPQRF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x288DED0", Offset = "0x288C6D0", VA = "0x18288DED0")]
				internal bool ERNLFZLSQWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x288DF20", Offset = "0x288C720", VA = "0x18288DF20")]
				internal bool ERSSDGFQAHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x288F0C0", Offset = "0x288D8C0", VA = "0x18288F0C0")]
				internal int LTUTITXAEBN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x288F060", Offset = "0x288D860", VA = "0x18288F060")]
				internal void LTPMLNDCUQE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x288F160", Offset = "0x288D960", VA = "0x18288F160")]
				internal bool LUFHDHKUWYF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x288F110", Offset = "0x288D910", VA = "0x18288F110")]
				internal bool LUAAGAQXNMW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x288EF60", Offset = "0x288D760", VA = "0x18288EF60")]
				internal bool LSZRTSVKSID()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x288EF10", Offset = "0x288D710", VA = "0x18288EF10")]
				internal float LSUKWMBNIWU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x288F000", Offset = "0x288D800", VA = "0x18288F000")]
				internal void LTKFOGJFLEV(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x288EFB0", Offset = "0x288D7B0", VA = "0x18288EFB0")]
				internal bool LTEYQZPIBTM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x288EEC0", Offset = "0x288D6C0", VA = "0x18288EEC0")]
				internal bool LSEQERTVGOT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x288EE70", Offset = "0x288D670", VA = "0x18288EE70")]
				internal bool LRZJHKZXXDK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2895BA0", Offset = "0x28943A0", VA = "0x182895BA0")]
				internal float QVMUIUDCLUU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2895C60", Offset = "0x2894460", VA = "0x182895C60")]
				internal void QVSBGAWZVGD(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2895D10", Offset = "0x2894510", VA = "0x182895D10")]
				internal bool QVXIDHQXERM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2895E50", Offset = "0x2894650", VA = "0x182895E50")]
				internal bool QWNCVBYPGZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2895EA0", Offset = "0x28946A0", VA = "0x182895EA0")]
				internal string QWSJSISMQKW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2895F60", Offset = "0x2894760", VA = "0x182895F60")]
				internal void QWXQPPMJZWF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2895A60", Offset = "0x2894260", VA = "0x182895A60")]
				internal bool QTWRERZXOIA(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2895AB0", Offset = "0x28942B0", VA = "0x182895AB0")]
				internal bool QUBYBYTUXTJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x28975E0", Offset = "0x2895DE0", VA = "0x1828975E0")]
				internal bool WWGAUEMEPQV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2897590", Offset = "0x2895D90", VA = "0x182897590")]
				internal bool WWATWXSHGFM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2897540", Offset = "0x2895D40", VA = "0x182897540")]
				internal string WVVMZQYJWUD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x28974D0", Offset = "0x2895CD0", VA = "0x1828974D0")]
				internal void WVQGCKEMNIU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2897720", Offset = "0x2895F20", VA = "0x182897720")]
				internal bool WXBCJFNUBKF(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x28976D0", Offset = "0x2895ED0", VA = "0x1828976D0")]
				internal bool WWVVLYTWRYW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2897680", Offset = "0x2895E80", VA = "0x182897680")]
				internal bool WWQOORZZINN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2897630", Offset = "0x2895E30", VA = "0x182897630")]
				internal bool WWLHRLGBZCE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2897480", Offset = "0x2895C80", VA = "0x182897480")]
				internal string WUPXQCIZSEB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2897410", Offset = "0x2895C10", VA = "0x182897410")]
				internal void WUKQSVPCISS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x288DE30", Offset = "0x288C630", VA = "0x18288DE30")]
				internal bool DWXFSWUHFJE(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x288DE80", Offset = "0x288C680", VA = "0x18288DE80")]
				internal bool DXCMQDOEOUN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x288DD90", Offset = "0x288C590", VA = "0x18288DD90")]
				internal bool DWMRYJGMMMM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x288DDE0", Offset = "0x288C5E0", VA = "0x18288DDE0")]
				internal bool DWRYVQAJVXV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x288DCD0", Offset = "0x288C4D0", VA = "0x18288DCD0")]
				internal string DWCEDVSRTPU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x288DD20", Offset = "0x288C520", VA = "0x18288DD20")]
				internal void DWHLBCMPDBD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x288DC30", Offset = "0x288C430", VA = "0x18288DC30")]
				internal bool DVRQJIEXATC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x288DC80", Offset = "0x288C480", VA = "0x18288DC80")]
				internal bool DVWXGOYUKEL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x288DB90", Offset = "0x288C390", VA = "0x18288DB90")]
				internal bool DVHCOURCHWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x288DBE0", Offset = "0x288C3E0", VA = "0x18288DBE0")]
				internal bool DVMJMBKZRHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x288EB80", Offset = "0x288D380", VA = "0x18288EB80")]
				internal string KRBYBGPQFCL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x288EB10", Offset = "0x288D310", VA = "0x18288EB10")]
				internal void KQWRDZVSVRC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x288EC20", Offset = "0x288D420", VA = "0x18288EC20")]
				internal bool KRMLVUDKXZD(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x288EBD0", Offset = "0x288D3D0", VA = "0x18288EBD0")]
				internal bool KRHEYNJNONU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x288ECC0", Offset = "0x288D4C0", VA = "0x18288ECC0")]
				internal bool KRWZQHRFQVV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x288EC70", Offset = "0x288D470", VA = "0x18288EC70")]
				internal bool KRRSTAXIHKM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x288ED80", Offset = "0x288D580", VA = "0x18288ED80")]
				internal string KSHNKVFAJSN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x288ED10", Offset = "0x288D510", VA = "0x18288ED10")]
				internal void KSCGNOLDAHE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x288EE20", Offset = "0x288D620", VA = "0x18288EE20")]
				internal bool KSSBFISVCPF(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x288EDD0", Offset = "0x288D5D0", VA = "0x18288EDD0")]
				internal bool KSMUIBYXTDW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2895660", Offset = "0x2893E60", VA = "0x182895660")]
				internal bool OZINEHJLQYM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x28956B0", Offset = "0x2893EB0", VA = "0x1828956B0")]
				internal bool OZNUBODJAJV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2895700", Offset = "0x2893F00", VA = "0x182895700")]
				internal string OZTAYUXGJVE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2895750", Offset = "0x2893F50", VA = "0x182895750")]
				internal void OZYHWBRDTGN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2895520", Offset = "0x2893D20", VA = "0x182895520")]
				internal bool OYNLPGHWFFC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2895570", Offset = "0x2893D70", VA = "0x182895570")]
				internal bool OYSSMNBTOQL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x28955C0", Offset = "0x2893DC0", VA = "0x1828955C0")]
				internal bool OYXZJTVQYBU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2895610", Offset = "0x2893E10", VA = "0x182895610")]
				internal bool OZDGHAPOHND()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2895460", Offset = "0x2893C60", VA = "0x182895460")]
				internal string OXSKAFGGTLS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x28954B0", Offset = "0x2893CB0", VA = "0x1828954B0")]
				internal void OXXQXMAECXB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x28973C0", Offset = "0x2895BC0", VA = "0x1828973C0")]
				internal bool VZZSCZROGQV(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2897370", Offset = "0x2895B70", VA = "0x182897370")]
				internal bool VZULFSXQXFM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2897320", Offset = "0x2895B20", VA = "0x182897320")]
				internal bool VZPEIMDTNUD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x28972D0", Offset = "0x2895AD0", VA = "0x1828972D0")]
				internal bool VZJXLFJWEIU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2897280", Offset = "0x2895A80", VA = "0x182897280")]
				internal string VZEQNYPYUXL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2897210", Offset = "0x2895A10", VA = "0x182897210")]
				internal void VYZJQRWBLMC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x28971C0", Offset = "0x28959C0", VA = "0x1828971C0")]
				internal bool VYUCTLCECAT(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2897170", Offset = "0x2895970", VA = "0x182897170")]
				internal bool VYOVWEIGSPK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2897120", Offset = "0x2895920", VA = "0x182897120")]
				internal bool VYJOYXOJJEB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x28970D0", Offset = "0x28958D0", VA = "0x1828970D0")]
				internal bool VYEIBQULZSS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2895FD0", Offset = "0x28947D0", VA = "0x182895FD0")]
				internal string QXARBTEZKXH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2895EF0", Offset = "0x28946F0", VA = "0x182895EF0")]
				internal void QWVKEMLCBLY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2895E00", Offset = "0x2894600", VA = "0x182895E00")]
				internal bool QWKWJYXHIPG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2895DB0", Offset = "0x28945B0", VA = "0x182895DB0")]
				internal bool QWFPMSDJZDX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2895D60", Offset = "0x2894560", VA = "0x182895D60")]
				internal bool QWAIPLJMPSO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2895CC0", Offset = "0x28944C0", VA = "0x182895CC0")]
				internal string QVVBSEPPGHF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2895BF0", Offset = "0x28943F0", VA = "0x182895BF0")]
				internal void QVPUUXVRWVW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2895B50", Offset = "0x2894350", VA = "0x182895B50")]
				internal bool QVKNXRBUNKN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2895B00", Offset = "0x2894300", VA = "0x182895B00")]
				internal bool QVFHAKHXDZE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x288E9B0", Offset = "0x288D1B0", VA = "0x18288E9B0")]
				internal bool JWJMDAWWVEY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x288EA00", Offset = "0x288D200", VA = "0x18288EA00")]
				internal string JWOTAHQUEQH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x288EA50", Offset = "0x288D250", VA = "0x18288EA50")]
				internal void JWTZXOKROBQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x288EAC0", Offset = "0x288D2C0", VA = "0x18288EAC0")]
				internal bool JWZGUVEOXMZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x288E850", Offset = "0x288D050", VA = "0x18288E850")]
				internal bool JVOKNZVHJLO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x288E8A0", Offset = "0x288D0A0", VA = "0x18288E8A0")]
				internal bool JVTRLGPESWX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x288E8F0", Offset = "0x288D0F0", VA = "0x18288E8F0")]
				internal string JVYYINJCCIG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x288E940", Offset = "0x288D140", VA = "0x18288E940")]
				internal void JWEFFUCZLTP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x288E800", Offset = "0x288D000", VA = "0x18288E800")]
				internal bool JUYPWFNPHDN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x288D9E0", Offset = "0x288C1E0", VA = "0x18288D9E0")]
				internal bool DRYPVNJKOMP(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2895820", Offset = "0x2894020", VA = "0x182895820")]
				internal float PTXHZSJUTBN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x28957C0", Offset = "0x2893FC0", VA = "0x1828957C0")]
				internal void PTSBCLPXJQE(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2895960", Offset = "0x2894160", VA = "0x182895960")]
				internal bool PVCXJGZEXRP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2895910", Offset = "0x2894110", VA = "0x182895910")]
				internal bool PUXQMAFHOGG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x28958C0", Offset = "0x28940C0", VA = "0x1828958C0")]
				internal bool PUSJOTLKEUX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2895870", Offset = "0x2894070", VA = "0x182895870")]
				internal int PUNCRMRMVJO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2895A00", Offset = "0x2894200", VA = "0x182895A00")]
				internal void PVXYYIAUJKZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x28959B0", Offset = "0x28941B0", VA = "0x1828959B0")]
				internal bool PVSSBBGWZZQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x288E480", Offset = "0x288CC80", VA = "0x18288E480")]
				internal bool ITQQVNPMWFW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x288E4D0", Offset = "0x288CCD0", VA = "0x18288E4D0")]
				internal bool ITVXSUJKFRF()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class WSMHHMXXOOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string KGFLXQCRILR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public WSROETRUXZR GPYHOBUULHO;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WSMHHMXXOOI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x28B3C70", Offset = "0x28B2470", VA = "0x1828B3C70")]
				internal void TXHFYQAFQPK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class WTCBZHFPQWJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] ODVXYCVJHZS;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WTCBZHFPQWJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x28B4AF0", Offset = "0x28B32F0", VA = "0x1828B4AF0")]
				internal bool PUCOWZDSCMW(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers QEKFVWFKQSJ;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x287DCC0", Offset = "0x287C4C0", VA = "0x18287DCC0")]
			public IADHBDONIQL(WUFOVRVICVI a, ZVKEUEHTKXG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x287C150", Offset = "0x287A950", VA = "0x18287C150", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class EIRWGYBUPSE : CDXKHVRXGLX<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x289CCC0", Offset = "0x289B4C0", VA = "0x18289CCC0")]
			public EIRWGYBUPSE(WUFOVRVICVI a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x289C410", Offset = "0x289AC10", VA = "0x18289C410", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x289CBC0", Offset = "0x289B3C0", VA = "0x18289CBC0")]
			private static string NTHBGMJNPOM(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x289C870", Offset = "0x289B070", VA = "0x18289C870")]
			[CompilerGenerated]
			private object? KGAOKWPQUXR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x289C760", Offset = "0x289AF60", VA = "0x18289C760")]
			[CompilerGenerated]
			private void KFVHNPVTLMI(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x289C9B0", Offset = "0x289B1B0", VA = "0x18289C9B0")]
			[CompilerGenerated]
			private string KGLCFKDLNUJ(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x289C910", Offset = "0x289B110", VA = "0x18289C910")]
			[CompilerGenerated]
			private IReadOnlyList<object> KGFVIDJOEJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x289C700", Offset = "0x289AF00", VA = "0x18289C700")]
			[CompilerGenerated]
			private string? KFFMVVOBJEH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x289C6C0", Offset = "0x289AEC0", VA = "0x18289C6C0")]
			[CompilerGenerated]
			private bool KFAFYOUDZSY()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class GSSMQXPZSVA : CDXKHVRXGLX<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
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
					public TSTXUAFEGEM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x28B24A0", Offset = "0x28B0CA0", VA = "0x1828B24A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public GSSMQXPZSVA BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x28AAEE0", Offset = "0x28A96E0", VA = "0x1828AAEE0")]
				internal string TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x28AAD20", Offset = "0x28A9520", VA = "0x1828AAD20")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void TTFCDDDXNGU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x28AB510", Offset = "0x28A9D10", VA = "0x1828AB510")]
				internal int TTUWUXLPPOV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x28AB110", Offset = "0x28A9910", VA = "0x1828AB110")]
				internal void TTPPXQRSGDM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x289FB50", Offset = "0x289E350", VA = "0x18289FB50")]
			public GSSMQXPZSVA(WUFOVRVICVI a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x289F820", Offset = "0x289E020", VA = "0x18289F820", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class FAJBHCFVXDB : CDXKHVRXGLX<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class OVYXGTZWSNL
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
					public OVYXGTZWSNL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x28B2160", Offset = "0x28B0960", VA = "0x1828B2160", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public OVYXGTZWSNL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x28B2A50", Offset = "0x28B1250", VA = "0x1828B2A50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public FAJBHCFVXDB BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public OVYXGTZWSNL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x28A6790", Offset = "0x28A4F90", VA = "0x1828A6790")]
				internal string TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x28A66C0", Offset = "0x28A4EC0", VA = "0x1828A66C0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void TTFCDDDXNGU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x28A6870", Offset = "0x28A5070", VA = "0x1828A6870")]
				internal int TTUWUXLPPOV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x28A67E0", Offset = "0x28A4FE0", VA = "0x1828A67E0")]
				internal Task<bool> TTPPXQRSGDM(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x28A6590", Offset = "0x28A4D90", VA = "0x1828A6590")]
				internal string TSPHLIWFKYT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x28A64C0", Offset = "0x28A4CC0", VA = "0x1828A64C0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void TSKAOCCIBNK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x28A6670", Offset = "0x28A4E70", VA = "0x1828A6670")]
				internal bool TSZVFWKADVL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x28A65E0", Offset = "0x28A4DE0", VA = "0x1828A65E0")]
				internal void TSUOIPQCUKC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x28A6950", Offset = "0x28A5150", VA = "0x1828A6950")]
				internal bool TVAMEMAZUEX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x28A68C0", Offset = "0x28A50C0", VA = "0x1828A68C0")]
				internal void TUVFHFHCKTO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x28A62A0", Offset = "0x28A4AA0", VA = "0x1828A62A0")]
				internal float AYDRUPCFPTC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x28A62F0", Offset = "0x28A4AF0", VA = "0x1828A62F0")]
				internal void AYIYRVWCZEL(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x28A6380", Offset = "0x28A4B80", VA = "0x1828A6380")]
				internal int AYOFPCQAIPU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x28A63E0", Offset = "0x28A4BE0", VA = "0x1828A63E0")]
				internal void AYTMMJJXSBD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x28A6230", Offset = "0x28A4A30", VA = "0x1828A6230")]
				internal bool AXIQFOAQDZS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x289E690", Offset = "0x289CE90", VA = "0x18289E690")]
			public FAJBHCFVXDB(WUFOVRVICVI a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x289DD30", Offset = "0x289C530", VA = "0x18289DD30", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class RRHCRXLARCW : CDXKHVRXGLX<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public RRHCRXLARCW BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x28AAE40", Offset = "0x28A9640", VA = "0x1828AAE40")]
				internal Dictionary<string, EnumChoiceData> TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x28AACD0", Offset = "0x28A94D0", VA = "0x1828AACD0")]
				internal int TTFCDDDXNGU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x28AB560", Offset = "0x28A9D60", VA = "0x1828AB560")]
				internal void TTUWUXLPPOV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x28AB040", Offset = "0x28A9840", VA = "0x1828AB040")]
				internal bool TTPPXQRSGDM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x28A9860", Offset = "0x28A8060", VA = "0x1828A9860")]
			public RRHCRXLARCW(WUFOVRVICVI a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x28A95B0", Offset = "0x28A7DB0", VA = "0x1828A95B0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class VQJDQNPJUVZ : CDXKHVRXGLX<YPEMTSZUVTK>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public VQJDQNPJUVZ BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x28AAF30", Offset = "0x28A9730", VA = "0x1828AAF30")]
				internal void TTKJAJXUWSD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x28B39C0", Offset = "0x28B21C0", VA = "0x1828B39C0")]
			public VQJDQNPJUVZ(WUFOVRVICVI a, YPEMTSZUVTK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x28B3840", Offset = "0x28B2040", VA = "0x1828B3840", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class SGPSDURLXPX<a> : MMMKPOJFBVM<a> where a : notnull, OKSMTUACATZ
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override XHJXGPOIEEW? SAIDSKWASAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x5E64650", Offset = "0x5E62E50", VA = "0x185E64650", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x5E646B0", Offset = "0x5E62EB0", VA = "0x185E646B0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xC92EB0", Offset = "0xC916B0", VA = "0x180C92EB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x5E64690", Offset = "0x5E62E90", VA = "0x185E64690")]
			public SGPSDURLXPX(WUFOVRVICVI a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class GDGOBTXQZYR : SGPSDURLXPX<YPLOSRHQJQG>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class WSROETRUXZR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public GDGOBTXQZYR BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WSROETRUXZR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x28B4910", Offset = "0x28B3110", VA = "0x1828B4910")]
				internal object TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x28B4840", Offset = "0x28B3040", VA = "0x1828B4840")]
				internal void TTFCDDDXNGU(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x28B4970", Offset = "0x28B3170", VA = "0x1828B4970")]
				internal void TTUWUXLPPOV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? COSWVRCJQTP;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x289F6D0", Offset = "0x289DED0", VA = "0x18289F6D0")]
			public GDGOBTXQZYR(WUFOVRVICVI a, YPLOSRHQJQG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x289F160", Offset = "0x289D960", VA = "0x18289F160", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class LAGQJQGFFQY : CDXKHVRXGLX<TYGENATCFZH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public LAGQJQGFFQY BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<RBMJELGIMTE>> VVOQYRMQLIE;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x289A470", Offset = "0x2898C70", VA = "0x18289A470")]
				internal int TTFCDDDXNGU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x289AEC0", Offset = "0x28996C0", VA = "0x18289AEC0")]
				internal void TTUWUXLPPOV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class CYPBECEAVCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<RBMJELGIMTE> RTWXOFCGKGO;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYPBECEAVCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x289B4E0", Offset = "0x2899CE0", VA = "0x18289B4E0")]
				internal bool TSPHLIWFKYT(Id32<RBMJELGIMTE> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x28A5510", Offset = "0x28A3D10", VA = "0x1828A5510")]
			public LAGQJQGFFQY(WUFOVRVICVI a, TYGENATCFZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x28A5000", Offset = "0x28A3800", VA = "0x1828A5000", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class GLYRKLTTNXK : CDXKHVRXGLX<NFOEXNXGBSF>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xB7DCA0", Offset = "0xB7C4A0", VA = "0x180B7DCA0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x289F730", Offset = "0x289DF30", VA = "0x18289F730")]
			public GLYRKLTTNXK(WUFOVRVICVI a, NFOEXNXGBSF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class LRMWOPZQIYP : CDXKHVRXGLX<DFTQBORYJVC>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xBB6D70", Offset = "0xBB5570", VA = "0x180BB6D70", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x28A55E0", Offset = "0x28A3DE0", VA = "0x1828A55E0")]
			public LRMWOPZQIYP(WUFOVRVICVI a, DFTQBORYJVC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "134")]
			protected override bool ITASEUWQBBV(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class SMOZSSHODPV : CDXKHVRXGLX<JRYUOBLZIBO>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x28A9EA0", Offset = "0x28A86A0", VA = "0x1828A9EA0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x28A9E30", Offset = "0x28A8630", VA = "0x1828A9E30")]
			public SMOZSSHODPV(WUFOVRVICVI a, JRYUOBLZIBO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class JUPWWJFSAOP : CDXKHVRXGLX<PQEWKROMNOE>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x28A4F50", Offset = "0x28A3750", VA = "0x1828A4F50", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x28A4EE0", Offset = "0x28A36E0", VA = "0x1828A4EE0")]
			public JUPWWJFSAOP(WUFOVRVICVI a, PQEWKROMNOE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class WTMINCPMJYC : SWIKTYSXHQN<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public WTMINCPMJYC BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x289B180", Offset = "0x2899980", VA = "0x18289B180")]
				internal float UXIPSUAWAVU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x289B350", Offset = "0x2899B50", VA = "0x18289B350")]
				internal void UXNWQAUTKHD(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x28B4DD0", Offset = "0x28B35D0", VA = "0x1828B4DD0")]
			public WTMINCPMJYC(WUFOVRVICVI a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x28B4B60", Offset = "0x28B3360", VA = "0x1828B4B60", Slot = "151")]
			protected override void CEIDJWPHJMW(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class HJKMMOBDZYP : CDXKHVRXGLX<QAFEJOLQKZS>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x289FBC0", Offset = "0x289E3C0", VA = "0x18289FBC0")]
			public HJKMMOBDZYP(WUFOVRVICVI a, QAFEJOLQKZS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class AWILUHXNBTR : CDXKHVRXGLX<QCCUTRWSRTC>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2899E00", Offset = "0x2898600", VA = "0x182899E00")]
			public AWILUHXNBTR(WUFOVRVICVI a, QCCUTRWSRTC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class YPYEPGJHWAK : CDXKHVRXGLX<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public YPYEPGJHWAK BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x289AC80", Offset = "0x2899480", VA = "0x18289AC80")]
				internal bool TTKJAJXUWSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x289A810", Offset = "0x2899010", VA = "0x18289A810")]
				internal void TTFCDDDXNGU(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x28B52D0", Offset = "0x28B3AD0", VA = "0x1828B52D0")]
			public YPYEPGJHWAK(WUFOVRVICVI a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x28B5040", Offset = "0x28B3840", VA = "0x1828B5040", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class FAMPKESWPKS : CDXKHVRXGLX<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public FAMPKESWPKS BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> HGJBZNYLKJR;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x289AA60", Offset = "0x2899260", VA = "0x18289AA60")]
				internal object? TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x289A070", Offset = "0x2898870", VA = "0x18289A070")]
				internal bool TSUOIPQCUKC(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x289A220", Offset = "0x2898A20", VA = "0x18289A220")]
				internal void TTFCDDDXNGU(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x289AD70", Offset = "0x2899570", VA = "0x18289AD70")]
				internal string TTUWUXLPPOV(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x289AD20", Offset = "0x2899520", VA = "0x18289AD20")]
				internal IReadOnlyList<object> TTPPXQRSGDM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x289A000", Offset = "0x2898800", VA = "0x18289A000")]
				internal bool TSPHLIWFKYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2899FB0", Offset = "0x28987B0", VA = "0x182899FB0")]
				internal bool TSKAOCCIBNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x289A0F0", Offset = "0x28988F0", VA = "0x18289A0F0")]
				internal void TSZVFWKADVL(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x289EDE0", Offset = "0x289D5E0", VA = "0x18289EDE0")]
			public FAMPKESWPKS(WUFOVRVICVI a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x289E700", Offset = "0x289CF00", VA = "0x18289E700", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class OWCBSJKLWEA : CDXKHVRXGLX<ISDBYLCYHJD>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class OVYXGTZWSNL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int MDLKPPRGHPU;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public OVYXGTZWSNL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x28A6480", Offset = "0x28A4C80", VA = "0x1828A6480")]
				internal bool QLOCIOGLKWK(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class TPKTMYRKYMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public OWCBSJKLWEA BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> NTTEGIGXLTG;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TPKTMYRKYMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x28AA160", Offset = "0x28A8960", VA = "0x1828AA160")]
				internal int TTKJAJXUWSD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x28AA040", Offset = "0x28A8840", VA = "0x1828AA040")]
				internal void TTFCDDDXNGU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x28AA200", Offset = "0x28A8A00", VA = "0x1828AA200")]
				internal string? TTUWUXLPPOV()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x28A6EA0", Offset = "0x28A56A0", VA = "0x1828A6EA0")]
			public OWCBSJKLWEA(WUFOVRVICVI a, ISDBYLCYHJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x28A69A0", Offset = "0x28A51A0", VA = "0x1828A69A0")]
			private int HKYLKACYVHG(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x28A6D80", Offset = "0x28A5580", VA = "0x1828A6D80")]
			private void KCRLGBXXHHI(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x28A6A30", Offset = "0x28A5230", VA = "0x1828A6A30", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class EXNTFZEFGRH : WMQHLOLFCUX<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xCA1510", Offset = "0xC9FD10", VA = "0x180CA1510", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x289DC70", Offset = "0x289C470", VA = "0x18289DC70")]
			public EXNTFZEFGRH(WUFOVRVICVI a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class OEJVEYJDPQD : SWIKTYSXHQN<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public OEJVEYJDPQD BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x289B2D0", Offset = "0x2899AD0", VA = "0x18289B2D0")]
				internal int UXIPSUAWAVU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x289B3F0", Offset = "0x2899BF0", VA = "0x18289B3F0")]
				internal void UXNWQAUTKHD(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x28A5B20", Offset = "0x28A4320", VA = "0x1828A5B20")]
			public OEJVEYJDPQD(WUFOVRVICVI a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x28A58B0", Offset = "0x28A40B0", VA = "0x1828A58B0", Slot = "151")]
			protected override void CEIDJWPHJMW(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class EQLTTXWTCLP : CDXKHVRXGLX<NTAKHGSGPQS>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public EQLTTXWTCLP BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<RBMJELGIMTE>> VVOQYRMQLIE;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x289A6D0", Offset = "0x2898ED0", VA = "0x18289A6D0")]
				internal int TTFCDDDXNGU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x289B020", Offset = "0x2899820", VA = "0x18289B020")]
				internal void TTUWUXLPPOV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class CYPBECEAVCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<RBMJELGIMTE> RTWXOFCGKGO;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYPBECEAVCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x289B490", Offset = "0x2899C90", VA = "0x18289B490")]
				internal bool TSPHLIWFKYT(Id32<RBMJELGIMTE> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x289D240", Offset = "0x289BA40", VA = "0x18289D240")]
			public EQLTTXWTCLP(WUFOVRVICVI a, NTAKHGSGPQS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x289CD30", Offset = "0x289B530", VA = "0x18289CD30", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class VRREIODCTZZ : CDXKHVRXGLX<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public VRREIODCTZZ BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x289AC30", Offset = "0x2899430", VA = "0x18289AC30")]
				internal bool TTKJAJXUWSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x289A640", Offset = "0x2898E40", VA = "0x18289A640")]
				internal void TTFCDDDXNGU(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x28B3C00", Offset = "0x28B2400", VA = "0x1828B3C00")]
			public VRREIODCTZZ(WUFOVRVICVI a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x28B3A30", Offset = "0x28B2230", VA = "0x1828B3A30", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class FPTHTQJIMHV : CDXKHVRXGLX<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public FPTHTQJIMHV BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x289ABE0", Offset = "0x28993E0", VA = "0x18289ABE0")]
				internal bool TTKJAJXUWSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x289A9D0", Offset = "0x28991D0", VA = "0x18289A9D0")]
				internal void TTFCDDDXNGU(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x289F020", Offset = "0x289D820", VA = "0x18289F020")]
			public FPTHTQJIMHV(WUFOVRVICVI a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x289EE50", Offset = "0x289D650", VA = "0x18289EE50", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class DDNNJJNCQKV : CDXKHVRXGLX<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public DDNNJJNCQKV BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x289ACD0", Offset = "0x28994D0", VA = "0x18289ACD0")]
				internal int TTKJAJXUWSD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x289A940", Offset = "0x2899140", VA = "0x18289A940")]
				internal void TTFCDDDXNGU(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x289B780", Offset = "0x2899F80", VA = "0x18289B780")]
			public DDNNJJNCQKV(WUFOVRVICVI a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x289B530", Offset = "0x2899D30", VA = "0x18289B530", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class GORHUJGGFXQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log WKLAFLLOLVN;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class XOSUZMQEQCJ<a> : CDXKHVRXGLX<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class XQTSCXJHXWU
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
					public XQTSCXJHXWU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x3CCDCD0", Offset = "0x3CCC4D0", VA = "0x183CCDCD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x3CCE010", Offset = "0x3CCC810", VA = "0x183CCE010", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload XGCOHDSZKDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public XOSUZMQEQCJ<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public XQTSCXJHXWU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x3E3FF90", Offset = "0x3E3E790", VA = "0x183E3FF90")]
				[AsyncStateMachine(typeof(XOSUZMQEQCJ<>.XQTSCXJHXWU.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task AGKRIOYKHJH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x3E40060", Offset = "0x3E3E860", VA = "0x183E40060")]
				internal void QSYMYLCSAQC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class PWRKORNXZES
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
					public PWRKORNXZES <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3CE1090", Offset = "0x3CDF890", VA = "0x183CE1090", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public PWRKORNXZES <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x3CE27A0", Offset = "0x3CE0FA0", VA = "0x183CE27A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x3CE2EA0", Offset = "0x3CE16A0", VA = "0x183CE2EA0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public IEYQOFDLLGC.WBXFUMIJEYE ZUYAUHFUWRF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string AENIOYIHNHS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string GDBKSLHRPQK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public XOSUZMQEQCJ<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper FUIHCSULDHS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool DWBDWIHEAPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action KMDZGEXURVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool QBSAQDRMWOY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string HGPMKMHGSAU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action HTEIHYPOOVC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action NSYCAMNJMMM;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public PWRKORNXZES()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x5AC4DC0", Offset = "0x5AC35C0", VA = "0x185AC4DC0")]
				internal void EKFMBEJFXUV(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x5AC4D50", Offset = "0x5AC3550", VA = "0x185AC4D50")]
				internal void EKAFDXPIOJM(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
				internal string RGJIOIHLCNG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x5AC5180", Offset = "0x5AC3980", VA = "0x185AC5180")]
				internal void RGOPLPBILYP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x59AA1C0", Offset = "0x59A89C0", VA = "0x1859AA1C0")]
				internal bool RGTWIVVFVJY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x5AC5360", Offset = "0x5AC3B60", VA = "0x185AC5360")]
				internal char RGZDGCPDEVH((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				internal string? RHEKDJJAOGQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xC87D80", Offset = "0xC86580", VA = "0x180C87D80")]
				internal bool RHJRAQCXXRZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x5AC5400", Offset = "0x5AC3C00", VA = "0x185AC5400")]
				internal void RHOXXWWVHDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x59AA1C0", Offset = "0x59A89C0", VA = "0x1859AA1C0")]
				internal bool RHUEVDQSQOR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x5AC50A0", Offset = "0x5AC38A0", VA = "0x185AC50A0")]
				[AsyncStateMachine(typeof(XOSUZMQEQCJ<>.PWRKORNXZES.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void RETFKGEGFAM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x5AC4E10", Offset = "0x5AC3610", VA = "0x185AC4E10")]
				internal void HGNWOLANCAM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x5AC4FD0", Offset = "0x5AC37D0", VA = "0x185AC4FD0")]
				[AsyncStateMachine(typeof(XOSUZMQEQCJ<>.PWRKORNXZES.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task QFXWNSESOAF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x5AC4C30", Offset = "0x5AC3430", VA = "0x185AC4C30")]
				internal void EIKBZVMDQWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x5AC4F10", Offset = "0x5AC3710", VA = "0x185AC4F10")]
				internal void LKWQZWRINNE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x5AC5140", Offset = "0x5AC3940", VA = "0x185AC5140")]
				internal bool REYMHMYDOLV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class MNZROWWUYWL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter GALQLLSLHLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public XOSUZMQEQCJ<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<IEYQOFDLLGC.JWHQUASNMWK> HUZSJHMQVTF;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public MNZROWWUYWL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x57F5C80", Offset = "0x57F4480", VA = "0x1857F5C80")]
				internal bool AUFAGIYJQAN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x57F5CC0", Offset = "0x57F44C0", VA = "0x1857F5CC0")]
				internal void CICXCWMPLSD(IEYQOFDLLGC.JWHQUASNMWK a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class MNUKRQCXPLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool ALNBQSWRSHW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public VTREXZDFCRH VCSQDPRBJZU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public VTREXZDFCRH KDWCMGLYWNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public VTREXZDFCRH PGZQRCWILGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string VNSLOTXVGBV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public MNZROWWUYWL GPYHOBUULHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action HFYOFAKQRMZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action HVEZGOGOFEO;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public MNUKRQCXPLC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xCA8660", Offset = "0xCA6E60", VA = "0x180CA8660")]
				internal bool QHIIKVKTIMX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x57F5B80", Offset = "0x57F4380", VA = "0x1857F5B80")]
				internal void FOJKYLVVPRM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x57F50D0", Offset = "0x57F38D0", VA = "0x1857F50D0")]
				internal void ATPFOOQRNSM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x57F5B60", Offset = "0x57F4360", VA = "0x1857F5B60")]
				internal void AVABVJZZBTX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x57F4CF0", Offset = "0x57F34F0", VA = "0x1857F4CF0")]
				internal void ASZKWUIZLKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x57F5520", Offset = "0x57F3D20", VA = "0x1857F5520")]
				internal void ATZTJCEMGPE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x57F5B60", Offset = "0x57F4360", VA = "0x1857F5B60")]
				internal void CIIEADGMVDM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class MOKFJKKPRTD
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
					public MOKFJKKPRTD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x3CF1CF0", Offset = "0x3CF04F0", VA = "0x183CF1CF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x3CF2320", Offset = "0x3CF0B20", VA = "0x183CF2320", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool TNGWVLCUTUU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public MNUKRQCXPLC GQOCFWCMNPP;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public MOKFJKKPRTD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x57F5F30", Offset = "0x57F4730", VA = "0x1857F5F30")]
				[AsyncStateMachine(typeof(XOSUZMQEQCJ<>.MOKFJKKPRTD.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task CQGPFXDRKIW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x57F5EC0", Offset = "0x57F46C0", VA = "0x1857F5EC0")]
				internal void AUUUYDGBSIO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class MOEYMDQSIHU
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
					public MOEYMDQSIHU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x3CF16F0", Offset = "0x3CEFEF0", VA = "0x183CF16F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x3CF1C90", Offset = "0x3CF0490", VA = "0x183CF1C90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload LDWBXNTIDTN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public MNUKRQCXPLC GQIVIPIPEEG;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public MOEYMDQSIHU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x57F5DF0", Offset = "0x57F45F0", VA = "0x1857F5DF0")]
				[AsyncStateMachine(typeof(XOSUZMQEQCJ<>.MOEYMDQSIHU.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task ZCMUTAVIHBL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x57F5D80", Offset = "0x57F4580", VA = "0x1857F5D80")]
				internal void CINKXKAKEOV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class GNSJUUVFLZM
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
					public GNSJUUVFLZM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x3CF1210", Offset = "0x3CEFA10", VA = "0x183CF1210", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x3CF1690", Offset = "0x3CEFE90", VA = "0x183CF1690", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public XOSUZMQEQCJ<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload GFZZZWWVHOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public IEYQOFDLLGC.JWHQUASNMWK ZUYAUHFUWRF;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public GNSJUUVFLZM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x4E9BCA0", Offset = "0x4E9A4A0", VA = "0x184E9BCA0")]
				[AsyncStateMachine(typeof(XOSUZMQEQCJ<>.GNSJUUVFLZM.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task KXSKKCLEUYL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x4E9BEE0", Offset = "0x4E9A6E0", VA = "0x184E9BEE0")]
				internal bool UEIHWUAIHLD(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x4E9BD70", Offset = "0x4E9A570", VA = "0x184E9BD70")]
				internal void UDSNEZSQFDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x4E9BE90", Offset = "0x4E9A690", VA = "0x184E9BE90")]
				internal void UDXUCGMNOOL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class BUGNOQDRGAV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string TNNJZOEWZSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public VTREXZDFCRH YPEPYCCILFX;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public BUGNOQDRGAV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x6F6FD60", Offset = "0x6F6E560", VA = "0x186F6FD60")]
				internal string? GVNNLMADISE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xC4B8B0", Offset = "0xC4A0B0", VA = "0x180C4B8B0")]
				internal bool GVSUISUASDN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x6F6FD80", Offset = "0x6F6E580", VA = "0x186F6FD80")]
				internal void GVYBFZNYBOW(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool NOIVWULJPMD;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log WKLAFLLOLVN
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x3E3B4F0", Offset = "0x3E39CF0", VA = "0x183E3B4F0")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x3E3D760", Offset = "0x3E3BF60", VA = "0x183E3D760", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected IEYQOFDLLGC JWRPDAYPJQJ
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAA980", VA = "0x180AAC180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xAAC120", Offset = "0xAAA920", VA = "0x180AAC120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> RUGUYXTZTSY
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xB30730", Offset = "0xB2EF30", VA = "0x180B30730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xE6D500", Offset = "0xE6BD00", VA = "0x180E6D500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected SYZCVXWMDUY INSDIRSFWUD
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xCE65E0", Offset = "0xCE4DE0", VA = "0x180CE65E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x1485930", Offset = "0x1484130", VA = "0x181485930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected GSUPJLFMFYA LLYGXEZUEVZ
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xCE65F0", Offset = "0xCE4DF0", VA = "0x180CE65F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x1485970", Offset = "0x1484170", VA = "0x181485970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x3E3D730", Offset = "0x3E3BF30", VA = "0x183E3D730")]
			protected XOSUZMQEQCJ(WUFOVRVICVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x3E3A0D0", Offset = "0x3E388D0", VA = "0x183E3A0D0", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x3E3A080", Offset = "0x3E38880", VA = "0x183E3A080", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3E3A190", Offset = "0x3E38990", VA = "0x183E3A190", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x3E3C1E0", Offset = "0x3E3A9E0", VA = "0x183E3C1E0")]
			private void RRIAATWHIEK(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x3E3B2F0", Offset = "0x3E39AF0", VA = "0x183E3B2F0", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3E3CFA0", Offset = "0x3E3B7A0", VA = "0x183E3CFA0")]
			private void VSRHAXDWXFW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x3E3C4A0", Offset = "0x3E3ACA0", VA = "0x183E3C4A0")]
			private void ULHSSQOSZYM(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "151")]
			protected virtual void VFSZUXAYTMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x3E3B770", Offset = "0x3E39F70", VA = "0x183E3B770")]
			private void PLNEBBAWABN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x3E3A1E0", Offset = "0x3E389E0", VA = "0x183E3A1E0")]
			private void FLOFMSPAWEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x3E392C0", Offset = "0x3E37AC0", VA = "0x183E392C0")]
			private void COBJXLCYHGC(IEYQOFDLLGC.JWHQUASNMWK a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x3E3B570", Offset = "0x3E39D70", VA = "0x183E3B570")]
			private void OEWHMOMKBBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x3E3B540", Offset = "0x3E39D40", VA = "0x183E3B540")]
			protected void NOLAZKPZJBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x3E3A120", Offset = "0x3E38920", VA = "0x183E3A120")]
			private void DZPYTINMACE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x3E3CF80", Offset = "0x3E3B780", VA = "0x183E3CF80")]
			private void UMWDTCDPZHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x3E3AC60", Offset = "0x3E39460", VA = "0x183E3AC60")]
			private void FMSKNMEBSNR(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x3E3AFF0", Offset = "0x3E397F0", VA = "0x183E3AFF0")]
			private string IJTDPSWYYPX((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x3E3D660", Offset = "0x3E3BE60", VA = "0x183E3D660")]
			private string WTGUOQXWNGC(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x3E3BA10", Offset = "0x3E3A210", VA = "0x183E3BA10")]
			[CompilerGenerated]
			private object? RDLUODYDHNM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x3E3BA40", Offset = "0x3E3A240", VA = "0x183E3BA40")]
			[CompilerGenerated]
			private void RDRBLKSAQYV(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x3E3B9A0", Offset = "0x3E3A1A0", VA = "0x183E3B9A0")]
			[CompilerGenerated]
			private IReadOnlyList<object> RDGNQXEFYCD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x3E3B910", Offset = "0x3E3A110", VA = "0x183E3B910")]
			[CompilerGenerated]
			private void RCQSZCWNVUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x3E3C190", Offset = "0x3E3A990", VA = "0x183E3C190")]
			[CompilerGenerated]
			private void RFHEPMVFOLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x3E39280", Offset = "0x3E37A80", VA = "0x183E39280")]
			[CompilerGenerated]
			private void BSHTFCJREVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x3E3ACC0", Offset = "0x3E394C0", VA = "0x183E3ACC0")]
			[CompilerGenerated]
			private void HFOBYCCRYVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x3E3D6F0", Offset = "0x3E3BEF0", VA = "0x183E3D6F0")]
			[CompilerGenerated]
			private void YOZSWBNKGUQ(IEYQOFDLLGC.JWHQUASNMWK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class XBULZHMUQNE : XOSUZMQEQCJ<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x28B4E30", Offset = "0x28B3630", VA = "0x1828B4E30")]
			public XBULZHMUQNE(WUFOVRVICVI a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class ECUPYBBDCCK : XOSUZMQEQCJ<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type GLKJALEMNSJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x28A98D0", Offset = "0x28A80D0", VA = "0x1828A98D0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope LOSNROVSTQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string YSVIYBPADJG
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x1192780", Offset = "0x1190F80", VA = "0x181192780")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x28A9C10", Offset = "0x28A8410", VA = "0x1828A9C10", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x28A9D00", Offset = "0x28A8500", VA = "0x1828A9D00", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool UNDXSTMFBNH(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x28A9B00", Offset = "0x28A8300", VA = "0x1828A9B00", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x28A9A70", Offset = "0x28A8270", VA = "0x1828A9A70", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x28A9920", Offset = "0x28A8120", VA = "0x1828A9920", Slot = "7")]
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
				protected virtual Type GLKJALEMNSJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x28AD080", Offset = "0x28AB880", VA = "0x1828AD080", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers HAFOMKELOJS
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string YSVIYBPADJG
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x1192780", Offset = "0x1190F80", VA = "0x181192780")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x28AD3C0", Offset = "0x28ABBC0", VA = "0x1828AD3C0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x28AD4B0", Offset = "0x28ABCB0", VA = "0x1828AD4B0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool UNDXSTMFBNH(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x28AD2B0", Offset = "0x28ABAB0", VA = "0x1828AD2B0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x28AD0D0", Offset = "0x28AB8D0", VA = "0x1828AD0D0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x28AD160", Offset = "0x28AB960", VA = "0x1828AD160", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
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
					public TSTXUAFEGEM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x28B1450", Offset = "0x28AFC50", VA = "0x1828B1450", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public TSTXUAFEGEM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x28B1860", Offset = "0x28B0060", VA = "0x1828B1860", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public ECUPYBBDCCK BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public SYZCVXWMDUY YPQSYJKUELL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> HFTHHTQTIBQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> HFYOFAKQRMZ;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x28ABA50", Offset = "0x28AA250", VA = "0x1828ABA50")]
				internal object? ULGFPYIKDHD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x28ABB90", Offset = "0x28AA390", VA = "0x1828ABB90")]
				internal bool UMWIUALPATX(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x28AB980", Offset = "0x28AA180", VA = "0x1828AB980")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void ULAYSROMTVU(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x28AA710", Offset = "0x28A8F10", VA = "0x1828AA710")]
				internal IReadOnlyList<TargetPlayersSelection> LWNFJMXTAKL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x28AB840", Offset = "0x28AA040", VA = "0x1828AB840")]
				internal object? UKFXDQMXICK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x28ABB30", Offset = "0x28AA330", VA = "0x1828ABB30")]
				internal bool UMRBWTRRRIO(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x28AB770", Offset = "0x28A9F70", VA = "0x1828AB770")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void UKAQGJSZYRB(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> GAWDYXYXOJD;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> SHBCWAIQUFB;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> VXGYGUWCRHB;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x289C3B0", Offset = "0x289ABB0", VA = "0x18289C3B0")]
			public ECUPYBBDCCK(WUFOVRVICVI a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x289BC50", Offset = "0x289A450", VA = "0x18289BC50", Slot = "151")]
			protected override void VFSZUXAYTMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x289B7F0", Offset = "0x2899FF0", VA = "0x18289B7F0")]
			private static IReadOnlyList<TargetPlayersSelection> RMXTWYQRWQQ(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class VPNYWTCILEP : SMHIBYSWCDQ<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType APVBWANODKZ
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x28B37E0", Offset = "0x28B1FE0", VA = "0x1828B37E0")]
			public VPNYWTCILEP(WUFOVRVICVI a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class BNFZQRBMGMC : CDXKHVRXGLX<LBKZHWCVPSD>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2899EE0", Offset = "0x28986E0", VA = "0x182899EE0")]
			public BNFZQRBMGMC(WUFOVRVICVI a, LBKZHWCVPSD b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class CDXKHVRXGLX<a> : VGSZPQPOABG, IDisposable where a : notnull, LBKZHWCVPSD
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class JHXZLDGKHPS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public CDXKHVRXGLX<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public WUFOVRVICVI KGBPSSWNJNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a WMECKZVJVQP;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public JHXZLDGKHPS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x50CC9A0", Offset = "0x50CB1A0", VA = "0x1850CC9A0")]
				internal IASDLGVPPGZ MTANUXOADJK(AYIQQYBPIPE a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class BCKZUPOPWBS
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
					public BCKZUPOPWBS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x3CD07A0", Offset = "0x3CCEFA0", VA = "0x183CD07A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string OYQTFJCYEQQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, SPRIBHSTRKT>> FDVOHGFWXMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public CDXKHVRXGLX<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> ZYLWPERKTAD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public IEYQOFDLLGC JWRPDAYPJQJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> JYKLNRAXFQH;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public BCKZUPOPWBS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				internal string ZOWAFFXINPA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
				internal void ZPBHCMRFXAJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x6F652B0", Offset = "0x6F63AB0", VA = "0x186F652B0")]
				[AsyncStateMachine(typeof(CDXKHVRXGLX<>.BCKZUPOPWBS.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void ZOLMKSJNUSI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class NDOLOCBQQHL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public NDOLOCBQQHL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x58826A0", Offset = "0x5880EA0", VA = "0x1858826A0")]
				internal Result<string, SPRIBHSTRKT> OTKUOORDMCY(string a)
				{
					return default(Result<string, SPRIBHSTRKT>);
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
				public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public CDXKHVRXGLX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x510A120", Offset = "0x5108920", VA = "0x18510A120", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x510A370", Offset = "0x5108B70", VA = "0x18510A370", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public CDXKHVRXGLX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x510A3E0", Offset = "0x5108BE0", VA = "0x18510A3E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x510A660", Offset = "0x5108E60", VA = "0x18510A660", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly WUFOVRVICVI TRSINEQQQBZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool XNJGUASHGIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<JIWIEDNGUWY, IASDLGVPPGZ> IATYBPQXUXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<JIWIEDNGUWY, EXEXARECGOC> CZCCHDNBMFQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> MKCNRAVSDVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<JIWIEDNGUWY>>? XIAWHSYHSOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<JIWIEDNGUWY>, EXEXARECGOC>? JKUVDYYTQXY;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected LIKWTTGVGUH SMTWMJSHTAK
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x3D6FDC0", Offset = "0x3D6E5C0", VA = "0x183D6FDC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected UZDPQANMDSF UZDPQANMDSF
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x3D70A70", Offset = "0x3D6F270", VA = "0x183D70A70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected MPXBTOPSSLG XESRGXRBXTN
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x3D70760", Offset = "0x3D6EF60", VA = "0x183D70760")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a LBKZHWCVPSD
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<YJGJBYABSIW> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x13DBF00", Offset = "0x13DA700", VA = "0x1813DBF00", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<YJGJBYABSIW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<EIHRYTCDBRP> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x3D71C60", Offset = "0x3D70460", VA = "0x183D71C60", Slot = "6")]
				get
				{
					return default(Id32<EIHRYTCDBRP>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x3D71AD0", Offset = "0x3D702D0", VA = "0x183D71AD0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x3D71AB0", Offset = "0x3D702B0", VA = "0x183D71AB0", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x3D71DC0", Offset = "0x3D705C0", VA = "0x183D71DC0", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<GEWLTDJAIBZ> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD59440", Offset = "0xD57C40", VA = "0x180D59440", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<GEWLTDJAIBZ>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD596D0", Offset = "0xD57ED0", VA = "0x180D596D0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xAFCE50", Offset = "0xAFB650", VA = "0x180AFCE50", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x3D71980", Offset = "0x3D70180", VA = "0x183D71980", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x3D719B0", Offset = "0x3D701B0", VA = "0x183D719B0", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x3D719E0", Offset = "0x3D701E0", VA = "0x183D719E0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x3D71C40", Offset = "0x3D70440", VA = "0x183D71C40", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x3D71B70", Offset = "0x3D70370", VA = "0x183D71B70", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x3D71A50", Offset = "0x3D70250", VA = "0x183D71A50", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x3D71A20", Offset = "0x3D70220", VA = "0x183D71A20", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xE2B330", Offset = "0xE29B30", VA = "0x180E2B330", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x156A500", Offset = "0x1568D00", VA = "0x18156A500")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x3D71A10", Offset = "0x3D70210", VA = "0x183D71A10", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x3D71B20", Offset = "0x3D70320", VA = "0x183D71B20", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x3D71BE0", Offset = "0x3D703E0", VA = "0x183D71BE0", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x3D71C10", Offset = "0x3D70410", VA = "0x183D71C10", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x3D71B50", Offset = "0x3D70350", VA = "0x183D71B50", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual XNCDZOSFRIX? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual XHJXGPOIEEW? SAIDSKWASAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<CATHGSEFVUK>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x3D71A80", Offset = "0x3D70280", VA = "0x183D71A80", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<VAEORNAZREW> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x3D71B90", Offset = "0x3D70390", VA = "0x183D71B90", Slot = "68")]
				get
				{
					return default(Id128<VAEORNAZREW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<VAEORNAZREW> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x3D71AF0", Offset = "0x3D702F0", VA = "0x183D71AF0", Slot = "59")]
				get
				{
					return default(Id32<VAEORNAZREW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<VAEORNAZREW>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<VAEORNAZREW>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x3D6E6A0", Offset = "0x3D6CEA0", VA = "0x183D6E6A0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xABA0A0", Offset = "0xAB88A0", VA = "0x180ABA0A0", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xABA750", Offset = "0xAB8F50", VA = "0x180ABA750")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xABA0E0", Offset = "0xAB88E0", VA = "0x180ABA0E0", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xAB9FF0", Offset = "0xAB87F0", VA = "0x180AB9FF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<CATHGSEFVUK> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x3D71CA0", Offset = "0x3D704A0", VA = "0x183D71CA0", Slot = "69")]
				get
				{
					return default(Id32<CATHGSEFVUK>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<CATHGSEFVUK> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x3D71BC0", Offset = "0x3D703C0", VA = "0x183D71BC0", Slot = "70")]
				get
				{
					return default(Id128<CATHGSEFVUK>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<CATHGSEFVUK>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x3D71CC0", Offset = "0x3D704C0", VA = "0x183D71CC0", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<JIWIEDNGUWY, EXEXARECGOC> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x3D71D80", Offset = "0x3D70580", VA = "0x183D71D80", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<JIWIEDNGUWY, EXEXARECGOC>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<JIWIEDNGUWY>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action VURHGBKESNI
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x3D6E020", Offset = "0x3D6C820", VA = "0x183D6E020", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x3D6DB40", Offset = "0x3D6C340", VA = "0x183D6DB40", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate MEFWHSQSEKL
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x3D6F380", Offset = "0x3D6DB80", VA = "0x183D6F380", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x3D6D500", Offset = "0x3D6BD00", VA = "0x183D6D500", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate XZXDBHCLSPC
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x3D70100", Offset = "0x3D6E900", VA = "0x183D70100", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x3D6E480", Offset = "0x3D6CC80", VA = "0x183D6E480", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action HHUSJKLMABS
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x3D6D450", Offset = "0x3D6BC50", VA = "0x183D6D450", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x3D70CD0", Offset = "0x3D6F4D0", VA = "0x183D70CD0", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action RNQODFSMOBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x3D6F2E0", Offset = "0x3D6DAE0", VA = "0x183D6F2E0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x3D6D600", Offset = "0x3D6BE00", VA = "0x183D6D600", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<JIWIEDNGUWY>, EXEXARECGOC> TOVMGHOHATK
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x3D6DF20", Offset = "0x3D6C720", VA = "0x183D6DF20", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x3D6EB50", Offset = "0x3D6D350", VA = "0x183D6EB50", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<JIWIEDNGUWY>, EXEXARECGOC> NNJQACTYXMD
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x3D70EC0", Offset = "0x3D6F6C0", VA = "0x183D70EC0", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x3D6F160", Offset = "0x3D6D960", VA = "0x183D6F160", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<JIWIEDNGUWY>> RQBUAPJRGMR
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x3D6F420", Offset = "0x3D6DC20", VA = "0x183D6F420", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x3D70C10", Offset = "0x3D6F410", VA = "0x183D70C10", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<JIWIEDNGUWY>, Id32<JIWIEDNGUWY>> SEAPSXCLSYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x3D6E0C0", Offset = "0x3D6C8C0", VA = "0x183D6E0C0", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x3D71250", Offset = "0x3D6FA50", VA = "0x183D71250", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<JIWIEDNGUWY>, EXEXARECGOC> FOKZDNIPZXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x3D6D740", Offset = "0x3D6BF40", VA = "0x183D6D740", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x3D6E5E0", Offset = "0x3D6CDE0", VA = "0x183D6E5E0", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<JIWIEDNGUWY>, Id32<JIWIEDNGUWY>> TVKERWQGPMT
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x3D70FD0", Offset = "0x3D6F7D0", VA = "0x183D70FD0", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x3D6E520", Offset = "0x3D6CD20", VA = "0x183D6E520", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> WVADNPCWKJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x3D6F220", Offset = "0x3D6DA20", VA = "0x183D6F220", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x3D70990", Offset = "0x3D6F190", VA = "0x183D70990", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x3D71510", Offset = "0x3D6FD10", VA = "0x183D71510")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected CDXKHVRXGLX(WUFOVRVICVI a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x3D6E6E0", Offset = "0x3D6CEE0", VA = "0x183D6E6E0", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x3D6D800", Offset = "0x3D6C000", VA = "0x183D6D800", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x3D6D5A0", Offset = "0x3D6BDA0", VA = "0x183D6D5A0", Slot = "9")]
			public Task<Result<None, SPRIBHSTRKT>> CGXADSPFNUL(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x3D700D0", Offset = "0x3D6E8D0", VA = "0x183D700D0")]
			public bool OJIEDYOUWTJ([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x3D70B70", Offset = "0x3D6F370", VA = "0x183D70B70")]
			public bool XZFINCLHYDU([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x3D6D6A0", Offset = "0x3D6BEA0", VA = "0x183D6D6A0", Slot = "34")]
			public void CVVTICOVZGG(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x3D70D30", Offset = "0x3D6F530", VA = "0x183D70D30", Slot = "35")]
			public Task XGTDQFYBOEK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x3D6EA00", Offset = "0x3D6D200", VA = "0x183D6EA00", Slot = "36")]
			[AsyncStateMachine(typeof(CDXKHVRXGLX<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, SPRIBHSTRKT>> JRFTVKFNYAJ(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "119")]
			public virtual void HILDBBOZJXQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xDFAB90", Offset = "0xDF9390", VA = "0x180DFAB90")]
			protected void RXDOMLUSSFU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x1E91A50", Offset = "0x1E90250", VA = "0x181E91A50")]
			protected void TWQGKYBUWSR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x1E70640", Offset = "0x1E6EE40", VA = "0x181E70640")]
			private void BQKWOAYUCPV([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x3D6FF50", Offset = "0x3D6E750", VA = "0x183D6FF50", Slot = "122")]
			public virtual Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> NPFVKWIFNJK(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x3D70010", Offset = "0x3D6E810", VA = "0x183D70010", Slot = "123")]
			public virtual Task<Result<None, SPRIBHSTRKT>> OCGBGORZVLJ(Id32<JIWIEDNGUWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "124")]
			public virtual void PWISEFOPQMT(Id32<JIWIEDNGUWY> sourceId, Id32<JIWIEDNGUWY> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x3D6FEB0", Offset = "0x3D6E6B0", VA = "0x183D6FEB0", Slot = "125")]
			public virtual IEnumerable<UZPYRKQPSNH> NJUIEDFXFJG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x3D6DFE0", Offset = "0x3D6C7E0", VA = "0x183D6DFE0", Slot = "126")]
			public Result<None, SPRIBHSTRKT> FIJGSCWHWXT(string a)
			{
				return default(Result<None, SPRIBHSTRKT>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x3D6FCA0", Offset = "0x3D6E4A0", VA = "0x183D6FCA0", Slot = "50")]
			public bool MMYWEMDTITH([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x3D6DBE0", Offset = "0x3D6C3E0", VA = "0x183D6DBE0")]
			public bool EOYPUDEABPE([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "128")]
			public virtual void MCTRROWAJIA(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "129")]
			public virtual RZZYLYVYVIL BGBDUKHMIVG([In] USAZVGSRDYS audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x3D6E8A0", Offset = "0x3D6D0A0", VA = "0x183D6E8A0")]
			protected void JJSFEMFKMVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x3D6E6A0", Offset = "0x3D6CEA0", VA = "0x183D6E6A0", Slot = "134")]
			protected virtual bool ITASEUWQBBV(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x3D71090", Offset = "0x3D6F890", VA = "0x183D71090", Slot = "96")]
			public bool YWFDDJPXDGR(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "135")]
			protected virtual bool YBNWZPRIWZK(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected virtual void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x3D6F900", Offset = "0x3D6E100", VA = "0x183D6F900")]
			protected void MJBIGFKFLIO(IEYQOFDLLGC a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, SPRIBHSTRKT>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x3D71310", Offset = "0x3D6FB10", VA = "0x183D71310")]
			protected void ZYSAHIUHGDG(IEYQOFDLLGC a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x3D6E180", Offset = "0x3D6C980", VA = "0x183D6E180", Slot = "146")]
			protected virtual void HJLCYSWSCKF(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x3D70F80", Offset = "0x3D6F780", VA = "0x183D70F80", Slot = "90")]
			public void YROWMZJRUFK(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x3D70BA0", Offset = "0x3D6F3A0", VA = "0x183D70BA0", Slot = "91")]
			public CircuitsRigidTransform UKMPWWCEVFT()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "149")]
			public virtual bool ZEUPXIHMVKB(Id32<JIWIEDNGUWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x3D70A50", Offset = "0x3D6F250", VA = "0x183D70A50")]
			private void SUWNNHLRSCQ([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x3D6DE60", Offset = "0x3D6C660", VA = "0x183D6DE60")]
			private void EVQVHCDBMNX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xDFAB90", Offset = "0xDF9390", VA = "0x180DFAB90", Slot = "97")]
			private void SINCHBDGHFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x3D6EC10", Offset = "0x3D6D410", VA = "0x183D6EC10", Slot = "99")]
			private void KJZLPYPAMRD(Id32<JIWIEDNGUWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x3D70E30", Offset = "0x3D6F630", VA = "0x183D70E30", Slot = "101")]
			private void XNMMEVLXTNU(Id32<JIWIEDNGUWY> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x3D70850", Offset = "0x3D6F050", VA = "0x183D70850", Slot = "103")]
			private void SFTQQBVWKJG(Id32<JIWIEDNGUWY> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x3D70270", Offset = "0x3D6EA70", VA = "0x183D70270", Slot = "104")]
			private void QGKUPAQBUXC(Id32<JIWIEDNGUWY> sourceId, Id32<JIWIEDNGUWY> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x3D701C0", Offset = "0x3D6E9C0", VA = "0x183D701C0", Slot = "105")]
			private void POBTICHAAAF(Id32<JIWIEDNGUWY> sourceId, Id32<JIWIEDNGUWY> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x14F8690", Offset = "0x14F6E90", VA = "0x1814F8690", Slot = "98")]
			private void LSHUYANSBHS(Id32<JIWIEDNGUWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x3D6F4E0", Offset = "0x3D6DCE0", VA = "0x183D6F4E0", Slot = "100")]
			private void LURGVGFSQNT(Id32<JIWIEDNGUWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x3D70E50", Offset = "0x3D6F650", VA = "0x183D70E50", Slot = "102")]
			private void YOGQRNDMPFN(Id32<JIWIEDNGUWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x3D71230", Offset = "0x3D6FA30", VA = "0x183D71230", Slot = "106")]
			private void ZIACKNZLXHD(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x3D70640", Offset = "0x3D6EE40", VA = "0x183D70640", Slot = "150")]
			[AsyncStateMachine(typeof(CDXKHVRXGLX<>.<RequestNameChange>d__224))]
			public Task<Result<None, SPRIBHSTRKT>> QZTANKYLCZB(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x3D6FE20", Offset = "0x3D6E620", VA = "0x183D6FE20", Slot = "57")]
			private void NEXSOOUVAWF(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x3D701E0", Offset = "0x3D6E9E0", VA = "0x183D701E0", Slot = "58")]
			private void PWZDMEUDWZI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x3D700D0", Offset = "0x3D6E8D0", VA = "0x183D700D0", Slot = "30")]
			private bool RLMULBPOGNY([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x3D70B70", Offset = "0x3D6F370", VA = "0x183D70B70", Slot = "32")]
			private bool TUGUJMHZZFJ([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x3D701A0", Offset = "0x3D6E9A0", VA = "0x183D701A0", Slot = "51")]
			private bool PNSWXIMZZOP([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xABA0A0", Offset = "0xAB88A0", VA = "0x180ABA0A0")]
			[CompilerGenerated]
			private string YXXCZWXJDOX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x3D710C0", Offset = "0x3D6F8C0", VA = "0x183D710C0")]
			[CompilerGenerated]
			private void YXRWCQDLUDO(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class BOVOYFTWUVG : WMQHLOLFCUX<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xC89530", Offset = "0xC87D30", VA = "0x180C89530", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2899F50", Offset = "0x2898750", VA = "0x182899F50")]
			public BOVOYFTWUVG(WUFOVRVICVI a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class OSLOGWRGECC : CDXKHVRXGLX<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> CSSMTCWFOXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public OSLOGWRGECC BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> OBWFUCBAPJZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> IYZAGTRFCRZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x28AA9F0", Offset = "0x28A91F0", VA = "0x1828AA9F0")]
				internal int TTFCDDDXNGU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x28AB380", Offset = "0x28A9B80", VA = "0x1828AB380")]
				internal void TTUWUXLPPOV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x28A61C0", Offset = "0x28A49C0", VA = "0x1828A61C0")]
			public OSLOGWRGECC(WUFOVRVICVI a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x28A5EE0", Offset = "0x28A46E0", VA = "0x1828A5EE0", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class NCGZYTZZBGI : MMMKPOJFBVM<SWVYATRHDPH>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x28A5850", Offset = "0x28A4050", VA = "0x1828A5850")]
			public NCGZYTZZBGI(WUFOVRVICVI a, SWVYATRHDPH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class UEVNKHLMKVE : CDXKHVRXGLX<MSAWKFKASBF>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public UEVNKHLMKVE BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x289AB90", Offset = "0x2899390", VA = "0x18289AB90")]
				internal bool TTKJAJXUWSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x289A5B0", Offset = "0x2898DB0", VA = "0x18289A5B0")]
				internal void TTFCDDDXNGU(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x28B35E0", Offset = "0x28B1DE0", VA = "0x1828B35E0")]
			public UEVNKHLMKVE(WUFOVRVICVI a, MSAWKFKASBF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x28B3410", Offset = "0x28B1C10", VA = "0x1828B3410", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class TVEPWOYJUFR : CDXKHVRXGLX<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
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
					public TSTXUAFEGEM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x28B27B0", Offset = "0x28B0FB0", VA = "0x1828B27B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x28B29E0", Offset = "0x28B11E0", VA = "0x1828B29E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> COJVKVEBXYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public TVEPWOYJUFR BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> SSSAPLGKTAX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> COFDLRVAOSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x28AAB00", Offset = "0x28A9300", VA = "0x1828AAB00")]
				internal int TTFCDDDXNGU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x28AB240", Offset = "0x28A9A40", VA = "0x1828AB240")]
				internal void TTUWUXLPPOV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x28AB0C0", Offset = "0x28A98C0", VA = "0x1828AB0C0")]
				internal int TTPPXQRSGDM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x28AA810", Offset = "0x28A9010", VA = "0x1828AA810")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> TSPHLIWFKYT(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x28AA340", Offset = "0x28A8B40", VA = "0x1828AA340")]
				internal int AWSVNTSYBRR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x28ABDB0", Offset = "0x28AA5B0", VA = "0x1828ABDB0")]
				internal void VTQUAJNTUXB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x28ABD60", Offset = "0x28AA560", VA = "0x1828ABD60")]
				internal int VTLNDCTWLLS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x28ABE90", Offset = "0x28AA690", VA = "0x1828ABE90")]
				internal void VUBHUXBONTT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x28ABE40", Offset = "0x28AA640", VA = "0x1828ABE40")]
				internal int VTWAXQHREIK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x28ABC40", Offset = "0x28AA440", VA = "0x1828ABC40")]
				internal void VSVSLIMEJDR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x28ABBF0", Offset = "0x28AA3F0", VA = "0x1828ABBF0")]
				internal int VSQLOBSGZSI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x28ABCD0", Offset = "0x28AA4D0", VA = "0x1828ABCD0")]
				internal void VTGGFVZZCAJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x28AA7C0", Offset = "0x28A8FC0", VA = "0x1828AA7C0")]
				internal float TSKAOCCIBNK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x28AA960", Offset = "0x28A9160", VA = "0x1828AA960")]
				internal void TSZVFWKADVL(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x28AA910", Offset = "0x28A9110", VA = "0x1828AA910")]
				internal float TSUOIPQCUKC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x28AB6E0", Offset = "0x28A9EE0", VA = "0x1828AB6E0")]
				internal void TVAMEMAZUEX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x28AB690", Offset = "0x28A9E90", VA = "0x1828AB690")]
				internal bool TUVFHFHCKTO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x28AA550", Offset = "0x28A8D50", VA = "0x1828AA550")]
				internal void AYDRUPCFPTC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x28AA5E0", Offset = "0x28A8DE0", VA = "0x1828AA5E0")]
				internal int AYIYRVWCZEL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x28AA630", Offset = "0x28A8E30", VA = "0x1828AA630")]
				internal void AYOFPCQAIPU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x28AA6C0", Offset = "0x28A8EC0", VA = "0x1828AA6C0")]
				internal float AYTMMJJXSBD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x28AA390", Offset = "0x28A8B90", VA = "0x1828AA390")]
				internal void AXIQFOAQDZS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x28AA420", Offset = "0x28A8C20", VA = "0x1828AA420")]
				internal float AXNXCUUNNLB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x28AA470", Offset = "0x28A8C70", VA = "0x1828AA470")]
				internal void AXTEABOKWWK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x28AA500", Offset = "0x28A8D00", VA = "0x1828AA500")]
				internal bool AXYKXIIIGHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x28AA2B0", Offset = "0x28A8AB0", VA = "0x1828AA2B0")]
				internal void AWNOQMZASGI(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x28AD010", Offset = "0x28AB810", VA = "0x1828AD010")]
			public TVEPWOYJUFR(WUFOVRVICVI a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x28ABF20", Offset = "0x28AA720", VA = "0x1828ABF20", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class RJTSLTZLZPI : SWIKTYSXHQN<RecNetImageNode>
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
				public RJTSLTZLZPI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x28B1FE0", Offset = "0x28B07E0", VA = "0x1828B1FE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x28A7B90", Offset = "0x28A6390", VA = "0x1828A7B90")]
			public RJTSLTZLZPI(WUFOVRVICVI a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x28A76C0", Offset = "0x28A5EC0", VA = "0x1828A76C0", Slot = "151")]
			protected override void CEIDJWPHJMW(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x28A79F0", Offset = "0x28A61F0", VA = "0x1828A79F0")]
			[CompilerGenerated]
			private string? FBYOUEHEUFE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x28A7AC0", Offset = "0x28A62C0", VA = "0x1828A7AC0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void FCDVRLBCDQN(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class SMHIBYSWCDQ<a> : CDXKHVRXGLX<a> where a : notnull, WWKQCSJWIDE
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class TPKTMYRKYMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> COJVKVEBXYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public SMHIBYSWCDQ<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> SSSAPLGKTAX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> COFDLRVAOSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType DJDZSMSMZIR;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TPKTMYRKYMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> TTKJAJXUWSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA5C0", Offset = "0x5FA8DC0", VA = "0x185FAA5C0")]
				internal int TTFCDDDXNGU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA730", Offset = "0x5FA8F30", VA = "0x185FAA730")]
				internal void TTUWUXLPPOV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA6E0", Offset = "0x5FA8EE0", VA = "0x185FAA6E0")]
				internal void TTPPXQRSGDM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA460", Offset = "0x5FA8C60", VA = "0x185FAA460")]
				internal void TSPHLIWFKYT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA400", Offset = "0x5FA8C00", VA = "0x185FAA400")]
				internal bool TSKAOCCIBNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA570", Offset = "0x5FA8D70", VA = "0x185FAA570")]
				internal void TSZVFWKADVL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA400", Offset = "0x5FA8C00", VA = "0x185FAA400")]
				internal bool TSUOIPQCUKC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA9B0", Offset = "0x5FA91B0", VA = "0x185FAA9B0")]
				internal float TVAMEMAZUEX()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x5FAA920", Offset = "0x5FA9120", VA = "0x185FAA920")]
				internal void TUVFHFHCKTO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x5FA9630", Offset = "0x5FA7E30", VA = "0x185FA9630")]
				internal float AYDRUPCFPTC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x5FA9660", Offset = "0x5FA7E60", VA = "0x185FA9660")]
				internal void AYIYRVWCZEL(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x5FA96F0", Offset = "0x5FA7EF0", VA = "0x185FA96F0")]
				internal float AYOFPCQAIPU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x5FA9720", Offset = "0x5FA7F20", VA = "0x185FA9720")]
				internal void AYTMMJJXSBD(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType APVBWANODKZ
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x3E3D730", Offset = "0x3E3BF30", VA = "0x183E3D730")]
			public SMHIBYSWCDQ(WUFOVRVICVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x5E69C40", Offset = "0x5E68440", VA = "0x185E69C40", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class FSLFTNPOZLQ : CDXKHVRXGLX<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xC9A7A0", Offset = "0xC98FA0", VA = "0x180C9A7A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x289F090", Offset = "0x289D890", VA = "0x18289F090")]
			public FSLFTNPOZLQ(WUFOVRVICVI a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class MHBLGRVCIMT : RLVJIKTWRVF<TVFGPQCQQBT>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x28A57F0", Offset = "0x28A3FF0", VA = "0x1828A57F0")]
			public MHBLGRVCIMT(WUFOVRVICVI a, TVFGPQCQQBT b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class KSFEOPMRTAD : RLVJIKTWRVF<IASYWKTMGSA>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x28A4FA0", Offset = "0x28A37A0", VA = "0x1828A4FA0")]
			public KSFEOPMRTAD(WUFOVRVICVI a, IASYWKTMGSA b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class RLVJIKTWRVF<a> : CDXKHVRXGLX<a> where a : notnull, MJYQAJTIRGJ
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
				public RLVJIKTWRVF<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x3CD05B0", Offset = "0x3CCEDB0", VA = "0x183CD05B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class WYCMMTINYUJ
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
					public WYCMMTINYUJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3CCF2B0", Offset = "0x3CCDAB0", VA = "0x183CCF2B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public WYCMMTINYUJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3CCF680", Offset = "0x3CCDE80", VA = "0x183CCF680", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public WYCMMTINYUJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3CCFD30", Offset = "0x3CCE530", VA = "0x183CCFD30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public WYCMMTINYUJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x3CD02C0", Offset = "0x3CCEAC0", VA = "0x183CD02C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int DWACUWIQEPL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry FOHPFKOSFMZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public RLVJIKTWRVF<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<RVNMAEXWNBU, bool> HVEZGOGOFEO;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WYCMMTINYUJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x66C2730", Offset = "0x66C0F30", VA = "0x1866C2730")]
				internal bool TTPPXQRSGDM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x66C24F0", Offset = "0x66C0CF0", VA = "0x1866C24F0")]
				internal void TSPHLIWFKYT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				internal string TSKAOCCIBNK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x66C2670", Offset = "0x66C0E70", VA = "0x1866C2670")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.WYCMMTINYUJ.<<BuildConfigMenuInternal>b__6>d))]
				internal void TSZVFWKADVL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x66C2560", Offset = "0x66C0D60", VA = "0x1866C2560")]
				internal int TSUOIPQCUKC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x66C2420", Offset = "0x66C0C20", VA = "0x1866C2420")]
				internal bool AYTMMJJXSBD(RVNMAEXWNBU a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x66C2790", Offset = "0x66C0F90", VA = "0x1866C2790")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.WYCMMTINYUJ.<<BuildConfigMenuInternal>b__8>d))]
				internal void TVAMEMAZUEX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
				internal string AYDRUPCFPTC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x66C22C0", Offset = "0x66C0AC0", VA = "0x1866C22C0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.WYCMMTINYUJ.<<BuildConfigMenuInternal>b__11>d))]
				internal void AYIYRVWCZEL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x66C2380", Offset = "0x66C0B80", VA = "0x1866C2380")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.WYCMMTINYUJ.<<BuildConfigMenuInternal>b__12>d))]
				internal void AYOFPCQAIPU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class JZDWTNUPEWK
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3CC96F0", Offset = "0x3CC7EF0", VA = "0x183CC96F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3CC9A70", Offset = "0x3CC8270", VA = "0x183CC9A70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3CC9E40", Offset = "0x3CC8640", VA = "0x183CC9E40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3CCA410", Offset = "0x3CC8C10", VA = "0x183CCA410", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3CCA6A0", Offset = "0x3CC8EA0", VA = "0x183CCA6A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3CCAA30", Offset = "0x3CC9230", VA = "0x183CCAA30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3CCADC0", Offset = "0x3CC95C0", VA = "0x183CCADC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3CCB050", Offset = "0x3CC9850", VA = "0x183CCB050", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3CCB3E0", Offset = "0x3CC9BE0", VA = "0x183CCB3E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3CCB770", Offset = "0x3CC9F70", VA = "0x183CCB770", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3CCBAF0", Offset = "0x3CCA2F0", VA = "0x183CCBAF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3CCBD80", Offset = "0x3CCA580", VA = "0x183CCBD80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3CCC110", Offset = "0x3CCA910", VA = "0x183CCC110", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3CCC3A0", Offset = "0x3CCABA0", VA = "0x183CCC3A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3CCC730", Offset = "0x3CCAF30", VA = "0x183CCC730", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3CCCAB0", Offset = "0x3CCB2B0", VA = "0x183CCCAB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
					public JZDWTNUPEWK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x3CCCE30", Offset = "0x3CCB630", VA = "0x183CCCE30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public RLVJIKTWRVF<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int DWACUWIQEPL;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public JZDWTNUPEWK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x50DD9C0", Offset = "0x50DC1C0", VA = "0x1850DD9C0")]
				internal bool JCLIIWZNKSX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x50DD950", Offset = "0x50DC150", VA = "0x1850DD950")]
				internal void JCGBLQFQBHO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x50DD430", Offset = "0x50DBC30", VA = "0x1850DD430")]
				internal object EAWMJJTJGJE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x50DD4D0", Offset = "0x50DBCD0", VA = "0x1850DD4D0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__13>d))]
				internal void EBBTGQNGPUN(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x50DD590", Offset = "0x50DBD90", VA = "0x1850DD590")]
				internal string EBHADXHDZFW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x50DD630", Offset = "0x50DBE30", VA = "0x1850DD630")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__15>d))]
				internal void EBMHBEBBIRF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x50DD6F0", Offset = "0x50DBEF0", VA = "0x1850DD6F0")]
				internal bool EBRNYKUYSCO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x50DD770", Offset = "0x50DBF70", VA = "0x1850DD770")]
				internal bool EBWUVROWBNX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x50DD190", Offset = "0x50DB990", VA = "0x1850DD190")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__18>d))]
				internal void DYVVKUCJPZS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x50DD240", Offset = "0x50DBA40", VA = "0x1850DD240")]
				internal int DZBCIAWGZLB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x50E03F0", Offset = "0x50DEBF0", VA = "0x1850E03F0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__20>d))]
				internal void YVZAUQRCSQL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x50E0360", Offset = "0x50DEB60", VA = "0x1850E0360")]
				internal bool YVTTXJXFJFC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x50E0550", Offset = "0x50DED50", VA = "0x1850E0550")]
				internal float YWJOPEEXLND()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x50E04A0", Offset = "0x50DECA0", VA = "0x1850E04A0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__23>d))]
				internal void YWEHRXLACBU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x50E0690", Offset = "0x50DEE90", VA = "0x1850E0690")]
				internal bool YWUCJRSSEJV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x50E0600", Offset = "0x50DEE00", VA = "0x1850E0600")]
				internal bool YWOVMKYUUYM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x50E07B0", Offset = "0x50DEFB0", VA = "0x1850E07B0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__26>d))]
				internal void YXEQEFGMXGN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x50E0720", Offset = "0x50DEF20", VA = "0x1850E0720")]
				internal int YWZJGYMPNVE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x50E08F0", Offset = "0x50DF0F0", VA = "0x1850E08F0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__28>d))]
				internal void YXPDYSUHQDF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x50E0860", Offset = "0x50DF060", VA = "0x1850E0860")]
				internal bool YXJXBMAKGRW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x50DE8F0", Offset = "0x50DD0F0", VA = "0x1850DE8F0")]
				internal float SBUIMGVTSXE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x50DE980", Offset = "0x50DD180", VA = "0x1850DE980")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__31>d))]
				internal void SBZPJNPRCIN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x50DE7E0", Offset = "0x50DCFE0", VA = "0x1850DE7E0")]
				internal bool SBJURTHZAAM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x50DE870", Offset = "0x50DD070", VA = "0x1850DE870")]
				internal bool SBPBPABWJLV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x50DE6A0", Offset = "0x50DCEA0", VA = "0x1850DE6A0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__34>d))]
				internal void SAZGXFUEHDU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x50DE750", Offset = "0x50DCF50", VA = "0x1850DE750")]
				internal bool SBENUMOBQPD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x50DE560", Offset = "0x50DCD60", VA = "0x1850DE560")]
				internal bool SAOTCSGJOHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x50DE5F0", Offset = "0x50DCDF0", VA = "0x1850DE5F0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__37>d))]
				internal void SATZZZAGXSL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x50DE420", Offset = "0x50DCC20", VA = "0x1850DE420")]
				internal int SAEFIESOVKK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x50DE4B0", Offset = "0x50DCCB0", VA = "0x1850DE4B0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__39>d))]
				internal void SAJMFLMMEVT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x50DE1A0", Offset = "0x50DC9A0", VA = "0x1850DE1A0")]
				internal bool LXJMETIHMEV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x50DE110", Offset = "0x50DC910", VA = "0x1850DE110")]
				internal float LXEFHMOKCTM()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x50DE060", Offset = "0x50DC860", VA = "0x1850DE060")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__42>d))]
				internal void LWYYKFUMTID(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x50DDFD0", Offset = "0x50DC7D0", VA = "0x1850DDFD0")]
				internal bool LWTRMZAPJWU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x50DDF50", Offset = "0x50DC750", VA = "0x1850DDF50")]
				internal bool LWOKPSGSALL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x50DDEA0", Offset = "0x50DC6A0", VA = "0x1850DDEA0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__45>d))]
				internal void LWJDSLMURAC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x50DDE10", Offset = "0x50DC610", VA = "0x1850DDE10")]
				internal bool LWDWVESXHOT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x50DDAD0", Offset = "0x50DC2D0", VA = "0x1850DDAD0")]
				internal bool JCVWDKNIDPP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x50DDA20", Offset = "0x50DC220", VA = "0x1850DDA20")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__3>d))]
				internal void JCQPGDTKUEG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x50DDC10", Offset = "0x50DC410", VA = "0x1850DDC10")]
				internal int JDGJXYBCWMH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x50DDB60", Offset = "0x50DC360", VA = "0x1850DDB60")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__5>d))]
				internal void JDBDARHFNAY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x50DDD30", Offset = "0x50DC530", VA = "0x1850DDD30")]
				internal bool JDQXSLOXPIZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x50DDCA0", Offset = "0x50DC4A0", VA = "0x1850DDCA0")]
				internal bool JDLQVEVAFXQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x50DD8A0", Offset = "0x50DC0A0", VA = "0x1850DD8A0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__8>d))]
				internal void JAVFEUWINGD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x50DD800", Offset = "0x50DC000", VA = "0x1850DD800")]
				internal int JAPYHOCLDUU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x50DD2F0", Offset = "0x50DBAF0", VA = "0x1850DD2F0")]
				[AsyncStateMachine(typeof(RLVJIKTWRVF<>.JZDWTNUPEWK.<<AddConstraintOptions>b__10>d))]
				internal void EALYOWFONMM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x50DD3A0", Offset = "0x50DBBA0", VA = "0x1850DD3A0")]
				internal bool EARFMCZLWXV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> VFDLPWITNQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> NQMZNASJOKC;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<RVNMAEXWNBU> AJNVPMTQCBC
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x5C10270", Offset = "0x5C0EA70", VA = "0x185C10270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x5C102C0", Offset = "0x5C0EAC0", VA = "0x185C102C0")]
			public RLVJIKTWRVF(WUFOVRVICVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x5C0F090", Offset = "0x5C0D890", VA = "0x185C0F090", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x5C0F240", Offset = "0x5C0DA40", VA = "0x185C0F240", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x5C0D9B0", Offset = "0x5C0C1B0", VA = "0x185C0D9B0")]
			private GSUPJLFMFYA CVIZMJDFOAF(IEYQOFDLLGC a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x5C0F140", Offset = "0x5C0D940", VA = "0x185C0F140")]
			[AsyncStateMachine(typeof(RLVJIKTWRVF<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void FSKBWKSHEWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x5C0F1E0", Offset = "0x5C0D9E0", VA = "0x185C0F1E0")]
			[CompilerGenerated]
			private bool FSPITRMEOHQ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class ZHMJQOQPMND : CDXKHVRXGLX<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class WSROETRUXZR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public ZHMJQOQPMND BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WSROETRUXZR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x28B47F0", Offset = "0x28B2FF0", VA = "0x1828B47F0")]
				internal int TTFCDDDXNGU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x28B4A60", Offset = "0x28B3260", VA = "0x1828B4A60")]
				internal void TTUWUXLPPOV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? BDSJGUFQDGQ;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x28B5690", Offset = "0x28B3E90", VA = "0x1828B5690")]
			public ZHMJQOQPMND(WUFOVRVICVI a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x28B5340", Offset = "0x28B3B40", VA = "0x1828B5340", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class SHBDTBGIIGH : SMHIBYSWCDQ<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType APVBWANODKZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x28A9DD0", Offset = "0x28A85D0", VA = "0x1828A9DD0")]
			public SHBDTBGIIGH(WUFOVRVICVI a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class TFXAFNCUDSY : MMMKPOJFBVM<GHZZTXKCVLH>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x28A9FE0", Offset = "0x28A87E0", VA = "0x1828A9FE0")]
			public TFXAFNCUDSY(WUFOVRVICVI a, GHZZTXKCVLH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class GCPOTYQGMJV : MMMKPOJFBVM<ADWDOHHCFYE>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x289F100", Offset = "0x289D900", VA = "0x18289F100")]
			public GCPOTYQGMJV(WUFOVRVICVI a, ADWDOHHCFYE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class OFGEZPNWDEV : SWIKTYSXHQN<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
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
					public CYJUGVKDLRI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x28B1CD0", Offset = "0x28B04D0", VA = "0x1828B1CD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public OFGEZPNWDEV BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x289B200", Offset = "0x2899A00", VA = "0x18289B200")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void UXIPSUAWAVU(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x28A5E80", Offset = "0x28A4680", VA = "0x1828A5E80")]
			public OFGEZPNWDEV(WUFOVRVICVI a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x28A5B80", Offset = "0x28A4380", VA = "0x1828A5B80", Slot = "151")]
			protected override void CEIDJWPHJMW(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class EYBNNDJLYFC : SMHIBYSWCDQ<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType APVBWANODKZ
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x289DCD0", Offset = "0x289C4D0", VA = "0x18289DCD0")]
			public EYBNNDJLYFC(WUFOVRVICVI a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class BJGFIMPORGJ : CDXKHVRXGLX<EBWXKGZGFLB>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xC922D0", Offset = "0xC90AD0", VA = "0x180C922D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2899E70", Offset = "0x2898670", VA = "0x182899E70")]
			public BJGFIMPORGJ(WUFOVRVICVI a, EBWXKGZGFLB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class QHBSMTYEDEY : CDXKHVRXGLX<XTCSPMSUWND>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool MAQRTWFMYNH
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x28A72D0", Offset = "0x28A5AD0", VA = "0x1828A72D0")]
			public QHBSMTYEDEY(WUFOVRVICVI a, XTCSPMSUWND b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x28A6F10", Offset = "0x28A5710", VA = "0x1828A6F10", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x28A7220", Offset = "0x28A5A20", VA = "0x1828A7220")]
			private int RTZRKONOLMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x28A7260", Offset = "0x28A5A60", VA = "0x1828A7260")]
			private void YRYORZMJDEG(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class TNUMRBMBZRZ : BNFZQRBMGMC
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2899EE0", Offset = "0x28986E0", VA = "0x182899EE0")]
			public TNUMRBMBZRZ(WUFOVRVICVI a, LBKZHWCVPSD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class QOMTPBZEQFT : CDXKHVRXGLX<VASUFDYEFWW>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class TSTXUAFEGEM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public QOMTPBZEQFT BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public TSTXUAFEGEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x28AADF0", Offset = "0x28A95F0", VA = "0x1828AADF0")]
				internal int TTKJAJXUWSD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x28AAC30", Offset = "0x28A9430", VA = "0x1828AAC30")]
				internal void TTFCDDDXNGU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x28AB4C0", Offset = "0x28A9CC0", VA = "0x1828AB4C0")]
				internal int TTUWUXLPPOV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x28AB1A0", Offset = "0x28A99A0", VA = "0x1828AB1A0")]
				internal void TTPPXQRSGDM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038980", VA = "0x18103A180", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x28A7650", Offset = "0x28A5E50", VA = "0x1828A7650")]
			public QOMTPBZEQFT(WUFOVRVICVI a, VASUFDYEFWW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x28A7340", Offset = "0x28A5B40", VA = "0x1828A7340", Slot = "145")]
			protected sealed override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class LCGHRPRFJRY : SWIKTYSXHQN<SQOIPDMLVXV>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x28A5580", Offset = "0x28A3D80", VA = "0x1828A5580")]
			public LCGHRPRFJRY(WUFOVRVICVI a, SQOIPDMLVXV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class SWIKTYSXHQN<a> : CDXKHVRXGLX<a> where a : notnull, SQOIPDMLVXV
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class OZNGAHXEFXB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public SWIKTYSXHQN<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public OZNGAHXEFXB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x5A00BA0", Offset = "0x59FF3A0", VA = "0x185A00BA0")]
				internal bool TTKJAJXUWSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x5A00B10", Offset = "0x59FF310", VA = "0x185A00B10")]
				internal void TTFCDDDXNGU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x5A00C60", Offset = "0x59FF460", VA = "0x185A00C60")]
				internal bool TTUWUXLPPOV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x5A00BD0", Offset = "0x59FF3D0", VA = "0x185A00BD0")]
				internal void TTPPXQRSGDM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x5A00AA0", Offset = "0x59FF2A0", VA = "0x185A00AA0")]
				internal bool TSPHLIWFKYT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class CUVLNHMVYHS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public MPXBTOPSSLG SJITJHRPLTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public SWIKTYSXHQN<a> BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CUVLNHMVYHS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x3EFB5D0", Offset = "0x3EF9DD0", VA = "0x183EFB5D0")]
				internal void UXIPSUAWAVU(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xBBBDE0", Offset = "0xBBA5E0", VA = "0x180BBBDE0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x5EB9070", Offset = "0x5EB7870", VA = "0x185EB9070", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x5EB8F60", Offset = "0x5EB7760", VA = "0x185EB8F60")]
			protected SWIKTYSXHQN(WUFOVRVICVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x5EB8AC0", Offset = "0x5EB72C0", VA = "0x185EB8AC0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x5EB8BB0", Offset = "0x5EB73B0", VA = "0x185EB8BB0", Slot = "145")]
			protected override void JKPMUTSEYTP(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x5EB87E0", Offset = "0x5EB6FE0", VA = "0x185EB87E0", Slot = "151")]
			protected virtual void CEIDJWPHJMW(IEYQOFDLLGC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x5EB8F20", Offset = "0x5EB7720", VA = "0x185EB8F20", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2880E30", Offset = "0x287F630", VA = "0x182880E30")]
		public static VGSZPQPOABG New(WUFOVRVICVI circuitsManager, LBKZHWCVPSD node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class ETFCFJBRPEY : RKCKKEDEFWK, VYRBTYZQMFH, XHHKBSRZIYH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<NNBWOXGQYLV> KNWMBUATUGX
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xC7E4C0", Offset = "0xC7CCC0", VA = "0x180C7E4C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<NNBWOXGQYLV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<RYQAJTIFIUP> SZKJBGPBHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x128D3D0", Offset = "0x128BBD0", VA = "0x18128D3D0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<RYQAJTIFIUP>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x20DE2B0", Offset = "0x20DCAB0", VA = "0x1820DE2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<XSORAGHTHUW> BJKGGGXPUBW
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x11C4E40", Offset = "0x11C3640", VA = "0x1811C4E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<YPMXJKHDXAR> XBXCHAIVHII
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x289D2B0", Offset = "0x289BAB0", VA = "0x18289D2B0", Slot = "22")]
			get
			{
				return default(Id32<YPMXJKHDXAR>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x289D650", Offset = "0x289BE50", VA = "0x18289D650")]
		private ETFCFJBRPEY(WUFOVRVICVI a, LBKZHWCVPSD b, UCKPCGEHWVP c, Id32<JIWIEDNGUWY> portGroupId, Id32<RYQAJTIFIUP> outputId, Id32<XSORAGHTHUW> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x289D300", Offset = "0x289BB00", VA = "0x18289D300")]
		public static ETFCFJBRPEY New(WUFOVRVICVI circuitsManager, LBKZHWCVPSD node, UCKPCGEHWVP output, Id32<JIWIEDNGUWY> portGroupId, Id32<XSORAGHTHUW> outputDefId, Id32<RYQAJTIFIUP> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x20DE2B0", Offset = "0x20DCAB0", VA = "0x1820DE2B0")]
		internal void EAKFPMAPCPC(Id32<RYQAJTIFIUP> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class RKCKKEDEFWK : XHHKBSRZIYH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private DLQLWOIRJEW? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x28A5650", Offset = "0x28A3E50", VA = "0x1828A5650")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x28A5660", Offset = "0x28A3E60", VA = "0x1828A5660")]
			public DLQLWOIRJEW PEDUPEQJFFO(RKCKKEDEFWK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly LBKZHWCVPSD DVUEQOBDAMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter DXLSCPPLJSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly OLLSNOQTGAR WJWEJJYJYEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<RRSSDQZVWAD> FTOZNXWSUAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<YSBXJZBYJIV> IDEDAHNPSMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool UILELLTSACM;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> YVPBBRQSSTS
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x28A7F60", Offset = "0x28A6760", VA = "0x1828A7F60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind GNNSZLMCXMN
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xACB460", Offset = "0xAC9C60", VA = "0x180ACB460", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<VAEORNAZREW> TPRAXEVDNOU
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x28A7BF0", Offset = "0x28A63F0", VA = "0x1828A7BF0", Slot = "6")]
			get
			{
				return default(Id32<VAEORNAZREW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<VAEORNAZREW> DDOKUOFBUAV
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x28A9200", Offset = "0x28A7A00", VA = "0x1828A9200", Slot = "7")]
			get
			{
				return default(Id128<VAEORNAZREW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public RVNMAEXWNBU ZQTLPICSJNB
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x28A7E60", Offset = "0x28A6660", VA = "0x1828A7E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public FUCFUCZHAKA BXQWLFOXMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x28A7DD0", Offset = "0x28A65D0", VA = "0x1828A7DD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected DLQLWOIRJEW TFYWTTVKNHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x28A7DD0", Offset = "0x28A65D0", VA = "0x1828A7DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage PMCGEUHUVNL
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x28A9010", Offset = "0x28A7810", VA = "0x1828A9010", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<CATHGSEFVUK> OPHVPCKNUUV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x28A93E0", Offset = "0x28A7BE0", VA = "0x1828A93E0", Slot = "9")]
			get
			{
				return default(Id128<CATHGSEFVUK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<JIWIEDNGUWY> IBZEBSUYLHI
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xC16C90", Offset = "0xC15490", VA = "0x180C16C90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<JIWIEDNGUWY>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1808920", Offset = "0x1807120", VA = "0x181808920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<YPMXJKHDXAR> XBXCHAIVHII
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool DSVWMQVRCNT
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xCC8520", Offset = "0xCC6D20", VA = "0x180CC8520", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x28A9460", Offset = "0x28A7C60", VA = "0x1828A9460")]
		protected RKCKKEDEFWK(WUFOVRVICVI a, LBKZHWCVPSD b, OLLSNOQTGAR c, Id32<JIWIEDNGUWY> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x28A88F0", Offset = "0x28A70F0", VA = "0x1828A88F0", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x28A7E80", Offset = "0x28A6680", VA = "0x1828A7E80", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x28A8C20", Offset = "0x28A7420", VA = "0x1828A8C20", Slot = "14")]
		public void MDCGKSVQMSS(RRSSDQZVWAD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x28A9150", Offset = "0x28A7950", VA = "0x1828A9150", Slot = "15")]
		public void QNQHHXYORHC(YSBXJZBYJIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x28A8CD0", Offset = "0x28A74D0", VA = "0x1828A8CD0")]
		private bool MFSPNBONZKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x28A80A0", Offset = "0x28A68A0", VA = "0x1828A80A0", Slot = "17")]
		public void FYMGZZUXLOE(FMAAJTLCBCR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x28A8BC0", Offset = "0x28A73C0", VA = "0x1828A8BC0", Slot = "25")]
		protected virtual void LPOQUNNMJRU(FMAAJTLCBCR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x28A89D0", Offset = "0x28A71D0", VA = "0x1828A89D0", Slot = "20")]
		private void JYUSZFUABGJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x28A7C20", Offset = "0x28A6420", VA = "0x1828A7C20")]
		private void BQEXQJVLEUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x28A9230", Offset = "0x28A7A30", VA = "0x1828A9230")]
		private void UWPAPPHKYKS([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x28A8B60", Offset = "0x28A7360", VA = "0x1828A8B60", Slot = "18")]
		public void KQOHJBUFVHZ(RRSSDQZVWAD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x28A9400", Offset = "0x28A7C00", VA = "0x1828A9400", Slot = "19")]
		public void YBEZAVARFWZ(YSBXJZBYJIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
		internal void RHDWLAMYFJU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x28A8FF0", Offset = "0x28A77F0", VA = "0x1828A8FF0")]
		internal void NPTVNQVACHD(UZDPQANMDSF a, RVNMAEXWNBU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1808920", Offset = "0x1807120", VA = "0x181808920")]
		internal void ZCGFIFPGABO(Id32<JIWIEDNGUWY> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class IASDLGVPPGZ : EXEXARECGOC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class XMRBXUWTVKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public WUFOVRVICVI KGBPSSWNJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public LBKZHWCVPSD WMECKZVJVQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<JIWIEDNGUWY> SSDIYFRNGIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool GTLJGGDHDAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool ZBARPVTXYCK;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public XMRBXUWTVKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x28B4F60", Offset = "0x28B3760", VA = "0x1828B4F60")]
			internal VIAFYVXSFTB BMFHCSDLAXT((int PortDescIndex, int PortIndex, VIYOADZLFJE InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x28B4E90", Offset = "0x28B3690", VA = "0x1828B4E90")]
			internal ETFCFJBRPEY BMAAFLJNRMK(UCKPCGEHWVP a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x28AD580", Offset = "0x28ABD80", VA = "0x1828AD580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x28AD9F0", Offset = "0x28AC1F0", VA = "0x1828AD9F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<ITYZVGJUOOJ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x28AECA0", Offset = "0x28AD4A0", VA = "0x1828AECA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x28AEFF0", Offset = "0x28AD7F0", VA = "0x1828AEFF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x28AF060", Offset = "0x28AD860", VA = "0x1828AF060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x28AF4E0", Offset = "0x28ADCE0", VA = "0x1828AF4E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<XSORAGHTHUW> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x28AF550", Offset = "0x28ADD50", VA = "0x1828AF550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x28AF8A0", Offset = "0x28AE0A0", VA = "0x1828AF8A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x28B00D0", Offset = "0x28AE8D0", VA = "0x1828B00D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x28B0420", Offset = "0x28AEC20", VA = "0x1828B0420", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<ITYZVGJUOOJ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x28AF910", Offset = "0x28AE110", VA = "0x1828AF910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x28AFC80", Offset = "0x28AE480", VA = "0x1828AFC80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<XSORAGHTHUW> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x28AFCF0", Offset = "0x28AE4F0", VA = "0x1828AFCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x28B0060", Offset = "0x28AE860", VA = "0x1828B0060", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public YBETPIMTIQD type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<ITYZVGJUOOJ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x28B0490", Offset = "0x28AEC90", VA = "0x1828B0490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x28B0830", Offset = "0x28AF030", VA = "0x1828B0830", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public YBETPIMTIQD type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<XSORAGHTHUW> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x28B08A0", Offset = "0x28AF0A0", VA = "0x1828B08A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x28B0C40", Offset = "0x28AF440", VA = "0x1828B0C40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<ITYZVGJUOOJ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<ITYZVGJUOOJ> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x28B0CB0", Offset = "0x28AF4B0", VA = "0x1828B0CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x28B1010", Offset = "0x28AF810", VA = "0x1828B1010", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public IASDLGVPPGZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<XSORAGHTHUW> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<XSORAGHTHUW> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private JDJZIVHVKYR <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x28B1080", Offset = "0x28AF880", VA = "0x1828B1080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x28B13E0", Offset = "0x28AFBE0", VA = "0x1828B13E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool OQTEOSAXJNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool IVMVVECYKYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<CLOCUIODAVK, VIAFYVXSFTB> UTNSKBRUGTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<CLOCUIODAVK, IGMMKFROMTK> ASYEPENHYBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly LBKZHWCVPSD DVUEQOBDAMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<RYQAJTIFIUP, ETFCFJBRPEY> GZUMHCNAECS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<RYQAJTIFIUP, VYRBTYZQMFH> JIZDSECDKTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? OPVRWSGGHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly AYIQQYBPIPE VFSKOLDPZEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<JIWIEDNGUWY> KWFLCLYHVUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool XNJGUASHGIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? MSNKMGGSQFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? HGBYKUZIEZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<CLOCUIODAVK>>? BJMWRCGTREY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<RYQAJTIFIUP>>? AKDBDZNIIDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private EXEXARECGOC.PortGroupIdChangeDelegate? DJMCMZVSXEH;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool DIHTSCKDGPB
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x28A1080", Offset = "0x289F880", VA = "0x1828A1080", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool QMKYAVYNLKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x28A0BB0", Offset = "0x289F3B0", VA = "0x1828A0BB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool HGHBCNAHCNU
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x28A4280", Offset = "0x28A2A80", VA = "0x1828A4280", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<VAEORNAZREW> DDOKUOFBUAV
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x28A3640", Offset = "0x28A1E40", VA = "0x1828A3640", Slot = "7")]
			get
			{
				return default(Id128<VAEORNAZREW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool BGKSLQQLPFK
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x28A3FC0", Offset = "0x28A27C0", VA = "0x1828A3FC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<CLOCUIODAVK, IGMMKFROMTK> NRCBNCHXRGW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<CLOCUIODAVK, IGMMKFROMTK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x28A3210", Offset = "0x28A1A10", VA = "0x1828A3210", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<CATHGSEFVUK> OPHVPCKNUUV
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x28A4180", Offset = "0x28A2980", VA = "0x1828A4180", Slot = "11")]
			get
			{
				return default(Id128<CATHGSEFVUK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<RYQAJTIFIUP, VYRBTYZQMFH> USGSXJAIKQX
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<RYQAJTIFIUP, VYRBTYZQMFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<JIWIEDNGUWY> IBZEBSUYLHI
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0xD7CAE0", Offset = "0xD7B2E0", VA = "0x180D7CAE0", Slot = "13")]
			get
			{
				return default(Id32<JIWIEDNGUWY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? VSVFLXBJEII
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x28A0A00", Offset = "0x289F200", VA = "0x1828A0A00", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x28A4D40", Offset = "0x28A3540", VA = "0x1828A4D40", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? ZJPDZEGBLEH
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x28A3F10", Offset = "0x28A2710", VA = "0x1828A3F10", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x28A0930", Offset = "0x289F130", VA = "0x1828A0930", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<CLOCUIODAVK?>, Id32<CLOCUIODAVK?>>? SDPKURGYUKM
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x28A16F0", Offset = "0x289FEF0", VA = "0x1828A16F0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x28A4430", Offset = "0x28A2C30", VA = "0x1828A4430", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<CLOCUIODAVK?>, Id32<CLOCUIODAVK?>>? VYYUUTHGUYF
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x28A0CB0", Offset = "0x289F4B0", VA = "0x1828A0CB0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x28A3240", Offset = "0x28A1A40", VA = "0x1828A3240", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<RYQAJTIFIUP?>, Id32<RYQAJTIFIUP?>>? QUICVJXEKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x289FDB0", Offset = "0x289E5B0", VA = "0x18289FDB0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x28A3580", Offset = "0x28A1D80", VA = "0x1828A3580", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<RYQAJTIFIUP?>, Id32<RYQAJTIFIUP?>>? PGKVBUDKIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x28A3430", Offset = "0x28A1C30", VA = "0x1828A3430", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x28A4C80", Offset = "0x28A3480", VA = "0x1828A4C80", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<CLOCUIODAVK?>, IGMMKFROMTK?>? BRRXNLNOWAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x28A07B0", Offset = "0x289EFB0", VA = "0x1828A07B0", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x289FCF0", Offset = "0x289E4F0", VA = "0x18289FCF0", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<CLOCUIODAVK?>>? TPERQAHTJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x289FC30", Offset = "0x289E430", VA = "0x18289FC30", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x28A1E20", Offset = "0x28A0620", VA = "0x1828A1E20", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<CLOCUIODAVK?>, IGMMKFROMTK?>? RCCQVIBOPVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x28A3960", Offset = "0x28A2160", VA = "0x1828A3960", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x28A0870", Offset = "0x289F070", VA = "0x1828A0870", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<RYQAJTIFIUP?>, VYRBTYZQMFH?>? XLWSZTVALIU
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x28A0BF0", Offset = "0x289F3F0", VA = "0x1828A0BF0", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x28A3670", Offset = "0x28A1E70", VA = "0x1828A3670", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<RYQAJTIFIUP?>>? SZQWZKJDIJX
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x28A0110", Offset = "0x289E910", VA = "0x1828A0110", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x28A41C0", Offset = "0x28A29C0", VA = "0x1828A41C0", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<RYQAJTIFIUP?>, VYRBTYZQMFH?>? ADRKDFAZTWU
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x28A23C0", Offset = "0x28A0BC0", VA = "0x1828A23C0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x28A17B0", Offset = "0x289FFB0", VA = "0x1828A17B0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x28A4DE0", Offset = "0x28A35E0", VA = "0x1828A4DE0")]
		private IASDLGVPPGZ(bool a, WUFOVRVICVI b, bool c, ReadOnlyIdArray<CLOCUIODAVK, VIAFYVXSFTB> inputs, ReadOnlyIdArray<CLOCUIODAVK, IGMMKFROMTK> inputsAsStaticInputs, LBKZHWCVPSD d, ReadOnlyIdArray<RYQAJTIFIUP, ETFCFJBRPEY> outputs, ReadOnlyIdArray<RYQAJTIFIUP, VYRBTYZQMFH> outputsAsStaticOutputs, string? overrideName, AYIQQYBPIPE e, Id32<JIWIEDNGUWY> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x28A2480", Offset = "0x28A0C80", VA = "0x1828A2480")]
		public static IASDLGVPPGZ New(bool canInteract, WUFOVRVICVI circuitsManager, bool hasFunctionHeader, LBKZHWCVPSD node, AYIQQYBPIPE portGroup, Id32<JIWIEDNGUWY> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x28A02E0", Offset = "0x289EAE0", VA = "0x1828A02E0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x28A4340", Offset = "0x28A2B40", VA = "0x1828A4340", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, SPRIBHSTRKT?>>? XSGASHJTHKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x28A3730", Offset = "0x28A1F30", VA = "0x1828A3730")]
		private (CNIJCELVRSU?, int)? TIFKEUKXLSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x28A0D70", Offset = "0x289F570", VA = "0x1828A0D70", Slot = "58")]
		private void KPDPHWUOMPF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x20C4120", Offset = "0x20C2920", VA = "0x1820C4120", Slot = "57")]
		private void NBWVKAEQRDI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x28A48B0", Offset = "0x28A30B0", VA = "0x1828A48B0", Slot = "61")]
		private void ZGBKLFEXTSI(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x28A34F0", Offset = "0x28A1CF0", VA = "0x1828A34F0", Slot = "63")]
		private void RPSRTARNSVR(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x28A1870", Offset = "0x28A0070", VA = "0x1828A1870", Slot = "50")]
		private void NCSIHIKEOKW(int a, Id32<CLOCUIODAVK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x28A4160", Offset = "0x28A2960", VA = "0x1828A4160", Slot = "54")]
		private void WAANSVHRVEX(int a, Id32<CLOCUIODAVK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x28A09E0", Offset = "0x289F1E0", VA = "0x1828A09E0", Slot = "49")]
		private void GMXUMBPUMAB(int a, Id32<CLOCUIODAVK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x28A1F70", Offset = "0x28A0770", VA = "0x1828A1F70", Slot = "53")]
		private void NRWALNQAPMK(int a, Id32<CLOCUIODAVK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x289FFA0", Offset = "0x289E7A0", VA = "0x18289FFA0", Slot = "66")]
		private void DAJOMVSAJGA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE6B210", Offset = "0xE69A10", VA = "0x180E6B210", Slot = "65")]
		private void QGJUWFLVPWZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x28A01D0", Offset = "0x289E9D0", VA = "0x1828A01D0", Slot = "60")]
		private void DDIVEFDIAPY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x20C4120", Offset = "0x20C2920", VA = "0x1820C4120", Slot = "59")]
		private void CVBTAJBRHQN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x28A3A20", Offset = "0x28A2220", VA = "0x1828A3A20", Slot = "62")]
		private void UEKBNOLIUMH(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x28A1EE0", Offset = "0x28A06E0", VA = "0x1828A1EE0", Slot = "64")]
		private void NPLTLUNAYSO(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x28A2B40", Offset = "0x28A1340", VA = "0x1828A2B40", Slot = "52")]
		private void ORQHCAOAIQJ(int a, Id32<RYQAJTIFIUP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x28A1260", Offset = "0x289FA60", VA = "0x1828A1260", Slot = "56")]
		private void MFVVWQXIHLM(int a, Id32<RYQAJTIFIUP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x28A41A0", Offset = "0x28A29A0", VA = "0x1828A41A0", Slot = "51")]
		private void WTQDHQUBHQE(int a, Id32<RYQAJTIFIUP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x28A1280", Offset = "0x289FA80", VA = "0x1828A1280", Slot = "55")]
		private void MKNTZQUVZZL(int a, Id32<RYQAJTIFIUP> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x28A29D0", Offset = "0x28A11D0", VA = "0x1828A29D0", Slot = "68")]
		private void OPQHKDMLWTH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE6B210", Offset = "0xE69A10", VA = "0x180E6B210", Slot = "67")]
		private void SNQEIIGTSKW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E80", Offset = "0x289F680", VA = "0x1828A0E80", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, SPRIBHSTRKT?>>? KRLEGYSXHXS(Id32<ITYZVGJUOOJ> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x28A0AA0", Offset = "0x289F2A0", VA = "0x1828A0AA0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, SPRIBHSTRKT?>>? HBHYJXAHWUZ(Id32<XSORAGHTHUW> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x28A4040", Offset = "0x28A2840", VA = "0x1828A4040", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, SPRIBHSTRKT?>>? VGLEHCFHYHE(Id32<ITYZVGJUOOJ> inputDefId, Id32<ITYZVGJUOOJ> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x28A3DF0", Offset = "0x28A25F0", VA = "0x1828A3DF0", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, SPRIBHSTRKT?>>? UGKGCCQEWTH(Id32<XSORAGHTHUW> outputDefId, Id32<XSORAGHTHUW> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x28A0F90", Offset = "0x289F790", VA = "0x1828A0F90", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, SPRIBHSTRKT?>>? LIGCSFMKBQC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x28A1140", Offset = "0x289F940", VA = "0x1828A1140", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, SPRIBHSTRKT>> MCYLFPFZQRP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x28A30E0", Offset = "0x28A18E0", VA = "0x1828A30E0", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, SPRIBHSTRKT>> OVEEKSAEENE(Id32<ITYZVGJUOOJ> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x28A0680", Offset = "0x289EE80", VA = "0x1828A0680", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, SPRIBHSTRKT>> FAVITSQPRFR(Id32<XSORAGHTHUW> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x289FE70", Offset = "0x289E670", VA = "0x18289FE70", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, SPRIBHSTRKT>> CNAUDAMCLHT(Id32<ITYZVGJUOOJ> inputDefId, YBETPIMTIQD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x28A3300", Offset = "0x28A1B00", VA = "0x1828A3300", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, SPRIBHSTRKT>> QOBJYDZEJKS(Id32<XSORAGHTHUW> outputDefId, YBETPIMTIQD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x28A44F0", Offset = "0x28A2CF0", VA = "0x1828A44F0")]
		internal void ZCGFIFPGABO(Id32<JIWIEDNGUWY> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class UODJRLEVSXT : ORNTCHYXYPW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface ZVDGYJVWQXS
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<VAEORNAZREW>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<VAEORNAZREW>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			UZDPQANMDSF UZDPQANMDSF
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> FBNERRUSCKS(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> IFBSLPXLJMV(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<QLBYSLYPNIL> QUXJEWFOLTY(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<TJUJUSPIWTZ> PHVNACIDNLN(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> NHBIAEWZQHK(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> PUJSNXPMDZV(CancellationToken a);
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
			public AsyncTaskMethodBuilder<UODJRLEVSXT> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public WUFOVRVICVI circuitsManager;

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
			private ZVDGYJVWQXS <selfDeps>5__2;

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
			private QLBYSLYPNIL <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private TJUJUSPIWTZ <playerSaveData>5__8;

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
			private TaskAwaiter<QLBYSLYPNIL> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<TJUJUSPIWTZ> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<ZVDGYJVWQXS.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<MONBQIUQOND> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x28ADA60", Offset = "0x28AC260", VA = "0x1828ADA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x28AEC30", Offset = "0x28AD430", VA = "0x1828AEC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public MONBQIUQOND MONBQIUQOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public BVVLUTOYBEF BVVLUTOYBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public TABGCWOYUYC TABGCWOYUYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public SMTWMJSHTAK SMTWMJSHTAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE718D0", Offset = "0xE700D0", VA = "0x180E718D0")]
		private UODJRLEVSXT(MONBQIUQOND a, BVVLUTOYBEF b, TABGCWOYUYC c, SMTWMJSHTAK d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x28B3670", Offset = "0x28B1E70", VA = "0x1828B3670")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<UODJRLEVSXT> RLYHLDBUHAW(WUFOVRVICVI a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x28B3650", Offset = "0x28B1E50", VA = "0x1828B3650", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class MFPHAPTIQKB : NZIZKTKPFPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public FJRPBHOZJHN? QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x28A56F0", Offset = "0x28A3EF0", VA = "0x1828A56F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		internal MFPHAPTIQKB(WUFOVRVICVI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class TABGCWOYUYC : FJRPBHOZJHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly MONBQIUQOND FXFVFYWEEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly MFPHAPTIQKB YEEGTYGXITA;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> NJJHZCQUJYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x28A9FA0", Offset = "0x28A87A0", VA = "0x1828A9FA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xB332D0", Offset = "0xB31AD0", VA = "0x180B332D0")]
		public TABGCWOYUYC(WUFOVRVICVI a, MONBQIUQOND b, MFPHAPTIQKB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x28A9F50", Offset = "0x28A8750", VA = "0x1828A9F50", Slot = "5")]
		public string OJAOBJOBEBK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x28A9EF0", Offset = "0x28A86F0", VA = "0x1828A9EF0", Slot = "6")]
		public void OIQNLPKHOHJ(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x28C3C50", Offset = "0x28C2450", VA = "0x1828C3C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x28C3E90", Offset = "0x28C2690", VA = "0x1828C3E90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, SPRIBHSTRKT>> <>t__builder;

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
			private UZPYRKQPSNH[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x28C46A0", Offset = "0x28C2EA0", VA = "0x1828C46A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x28C4A70", Offset = "0x28C3270", VA = "0x1828C4A70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public UZPYRKQPSNH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x28C8D80", Offset = "0x28C7580", VA = "0x1828C8D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x28C9200", Offset = "0x28C7A00", VA = "0x1828C9200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly KIQIZMMDNIQ _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		public EVRequestExtended(KIQIZMMDNIQ staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x289D9E0", Offset = "0x289C1E0", VA = "0x18289D9E0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, SPRIBHSTRKT>> KQBNDACPJAY(UZPYRKQPSNH a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x289DB10", Offset = "0x289C310", VA = "0x18289DB10")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, SPRIBHSTRKT?>>? VABSQPUEITR(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x289D8F0", Offset = "0x289C0F0", VA = "0x18289D8F0")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, SPRIBHSTRKT>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface GWUCTVNWOHE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		ORNTCHYXYPW? QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool FWPXZZHPHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<ORNTCHYXYPW?>? OEPQNVATAPI();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task WQGPVIEVCNZ(WUFOVRVICVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface ORNTCHYXYPW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		MONBQIUQOND MONBQIUQOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		BVVLUTOYBEF BVVLUTOYBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		TABGCWOYUYC TABGCWOYUYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		SMTWMJSHTAK SMTWMJSHTAK
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class XVCYMUIQPUH
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9D70", Offset = "0x28C8570", VA = "0x1828C9D70")]
		public static ReducerFactory<ActionKind, UZPYRKQPSNH, WUFOVRVICVI, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>> QVVXHJNKLJK([In] this ReducerFactory<ActionKind, UZPYRKQPSNH, WUFOVRVICVI, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, UZPYRKQPSNH, WUFOVRVICVI, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class VZSSPUNIJYG : UUGPZWYKYBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool FWPXZZHPHON
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x28C9D50", Offset = "0x28C8550", VA = "0x1828C9D50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		internal VZSSPUNIJYG(WUFOVRVICVI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class APEJHQPIFSP : IRVABWOEAUE
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x28B5E00", Offset = "0x28B4600", VA = "0x1828B5E00", Slot = "4")]
		public ZAYCEXSFJGK? SBJGTTWQBFT(string? a, string? b, string? c, RoomDoorData.LTMCDKJGFXW.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x28B5E90", Offset = "0x28B4690", VA = "0x1828B5E90", Slot = "5")]
		public SKUIWDFVJFS SVQRMYLRLWB(string a, string b, List<string> c, int d, int e, int f, int g, SPLNGXUPLQO h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x28B5D60", Offset = "0x28B4560", VA = "0x1828B5D60", Slot = "6")]
		public SPLNGXUPLQO LBMCKAOWVYJ(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public APEJHQPIFSP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class NNJKMUFBXEV : EWIDHKPBELO
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
			public AsyncTaskMethodBuilder<LIKWTTGVGUH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public NNJKMUFBXEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<ORNTCHYXYPW?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x28C3F00", Offset = "0x28C2700", VA = "0x1828C3F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x28C41A0", Offset = "0x28C29A0", VA = "0x1828C41A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public LIKWTTGVGUH? QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x28BA8D0", Offset = "0x28B90D0", VA = "0x1828BA8D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public SMTWMJSHTAK? SDUGBUMHBDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x28BAA40", Offset = "0x28B9240", VA = "0x1828BAA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool LJXNRBSJBPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x28BAAC0", Offset = "0x28B92C0", VA = "0x1828BAAC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool FOIZZWNXBNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x28BA4F0", Offset = "0x28B8CF0", VA = "0x1828BA4F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x28BAE70", Offset = "0x28B9670", VA = "0x1828BAE70")]
		internal NNJKMUFBXEV(WUFOVRVICVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x28BA950", Offset = "0x28B9150", VA = "0x1828BA950", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<LIKWTTGVGUH> OEPQNVATAPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x28BA550", Offset = "0x28B8D50", VA = "0x1828BA550", Slot = "9")]
		public IReadOnlyDictionary<Id128<VAEORNAZREW>, Guid> KNLQSNIAMNC(IEnumerable<PHWYRKJBQIP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x28BAB20", Offset = "0x28B9320", VA = "0x1828BAB20", Slot = "10")]
		public CircuitGraphToolMappingRegistryData SFQLQZDUODE(IEnumerable<PHWYRKJBQIP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x28BACA0", Offset = "0x28B94A0", VA = "0x1828BACA0")]
		public Result<CircuitsRoomData, ZVSGMZZHZEF> UDQCPIVCSJU([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, ZVSGMZZHZEF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x28BA4C0", Offset = "0x28B8CC0", VA = "0x1828BA4C0", Slot = "8")]
		private Result<CircuitsRoomData, ZVSGMZZHZEF> FDTPBZQMJEX([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, ZVSGMZZHZEF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class SMTWMJSHTAK : LIKWTTGVGUH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class NGSFYSFOATX
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class CYJUGVKDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int EKIQFAQZUAK;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public CYJUGVKDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x28B60B0", Offset = "0x28B48B0", VA = "0x1828B60B0")]
				internal void LLJIHRLYCFN(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x28B9BB0", Offset = "0x28B83B0", VA = "0x1828B9BB0")]
			public static Result<LIKWTTGVGUH.PrepareTemplateForCloneResult, VFHGFKHTIMO> WCEBZPFQAIM(SMTWMJSHTAK a, [In] LIKWTTGVGUH.PrepareTemplateForCloneArgs args)
			{
				return default(Result<LIKWTTGVGUH.PrepareTemplateForCloneResult, VFHGFKHTIMO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x28B83C0", Offset = "0x28B6BC0", VA = "0x1828B83C0")]
			internal static Result<(EIUDGSWCLMT, CircuitTemplateRootData), VFHGFKHTIMO> BQXHEZJWJLM(SMTWMJSHTAK a, CircuitTemplateRootData b, bool c, [In] Id128<VAEORNAZREW> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(EIUDGSWCLMT, CircuitTemplateRootData), VFHGFKHTIMO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x28B9180", Offset = "0x28B7980", VA = "0x1828B9180")]
			private static void PEAQLSOEMMY(bool a, PHWYRKJBQIP b, EIUDGSWCLMT c, [In] Id128<VAEORNAZREW> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x28BA0C0", Offset = "0x28B88C0", VA = "0x1828BA0C0")]
			public static void WFYOOQYHZXD(HDPCUABSWTU a, [In] LIKWTTGVGUH.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x28B9620", Offset = "0x28B7E20", VA = "0x1828B9620")]
			[CompilerGenerated]
			internal static bool RDFHIURWZUM(MONBQIUQOND a, QOPESGRMHHI b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x28B9150", Offset = "0x28B7950", VA = "0x1828B9150")]
			[CompilerGenerated]
			internal static bool ENYSJGVFJNP(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class MUFYEDYBQPX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public SMTWMJSHTAK BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<VAEORNAZREW> SPBARKHXFVN;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public MUFYEDYBQPX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x28B8380", Offset = "0x28B6B80", VA = "0x1828B8380")]
			internal Id128<CATHGSEFVUK> KIBNTWVTFXO(Id32<CATHGSEFVUK> a)
			{
				return default(Id128<CATHGSEFVUK>);
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<NNBWOXGQYLV> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<WZTXETPFGMO> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x28C4AE0", Offset = "0x28C32E0", VA = "0x1828C4AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x28C50B0", Offset = "0x28C38B0", VA = "0x1828C50B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<JIWIEDNGUWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<ITYZVGJUOOJ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x28C5120", Offset = "0x28C3920", VA = "0x1828C5120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x28C5470", Offset = "0x28C3C70", VA = "0x1828C5470", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<CATHGSEFVUK>, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<EIHRYTCDBRP> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private MONBQIUQOND <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x28C57C0", Offset = "0x28C3FC0", VA = "0x1828C57C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x28C5BF0", Offset = "0x28C43F0", VA = "0x1828C5BF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x28C54E0", Offset = "0x28C3CE0", VA = "0x1828C54E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x28C5750", Offset = "0x28C3F50", VA = "0x1828C5750", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x28C5C60", Offset = "0x28C4460", VA = "0x1828C5C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x28C5E50", Offset = "0x28C4650", VA = "0x1828C5E50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<VAEORNAZREW> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<CATHGSEFVUK> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<CATHGSEFVUK>> nodeIds;

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
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x28C5EC0", Offset = "0x28C46C0", VA = "0x1828C5EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x28C6160", Offset = "0x28C4960", VA = "0x1828C6160", Slot = "5")]
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
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<VAEORNAZREW> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<CATHGSEFVUK> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<CATHGSEFVUK>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<JIWIEDNGUWY>, Id32<CLOCUIODAVK>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<JIWIEDNGUWY>, Id32<RYQAJTIFIUP>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x28C61D0", Offset = "0x28C49D0", VA = "0x1828C61D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x28C67A0", Offset = "0x28C4FA0", VA = "0x1828C67A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<VAEORNAZREW> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<CATHGSEFVUK> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<CATHGSEFVUK>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x28C6800", Offset = "0x28C5000", VA = "0x1828C6800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x28C6A10", Offset = "0x28C5210", VA = "0x1828C6A10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<CATHGSEFVUK> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<JIWIEDNGUWY> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<CLOCUIODAVK> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x28C6A80", Offset = "0x28C5280", VA = "0x1828C6A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x28C6DD0", Offset = "0x28C55D0", VA = "0x1828C6DD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<JIWIEDNGUWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<ITYZVGJUOOJ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x28C6E40", Offset = "0x28C5640", VA = "0x1828C6E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x28C7220", Offset = "0x28C5A20", VA = "0x1828C7220", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x28C7290", Offset = "0x28C5A90", VA = "0x1828C7290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x28C7510", Offset = "0x28C5D10", VA = "0x1828C7510", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<CATHGSEFVUK> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<JIWIEDNGUWY> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<RYQAJTIFIUP> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x28C7580", Offset = "0x28C5D80", VA = "0x1828C7580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x28C78D0", Offset = "0x28C60D0", VA = "0x1828C78D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x28C7940", Offset = "0x28C6140", VA = "0x1828C7940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x28C7C80", Offset = "0x28C6480", VA = "0x1828C7C80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x28C7CF0", Offset = "0x28C64F0", VA = "0x1828C7CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x28C7F80", Offset = "0x28C6780", VA = "0x1828C7F80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x28C7FF0", Offset = "0x28C67F0", VA = "0x1828C7FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x28C8280", Offset = "0x28C6A80", VA = "0x1828C8280", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<CATHGSEFVUK>>, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<VAEORNAZREW> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<PHWYRKJBQIP> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<LBKZHWCVPSD>, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x28C82F0", Offset = "0x28C6AF0", VA = "0x1828C82F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x28C8A80", Offset = "0x28C7280", VA = "0x1828C8A80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<VAEORNAZREW> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<CATHGSEFVUK> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<CATHGSEFVUK>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x28C8AF0", Offset = "0x28C72F0", VA = "0x1828C8AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x28C8D10", Offset = "0x28C7510", VA = "0x1828C8D10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public SMTWMJSHTAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<VAEORNAZREW> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<CATHGSEFVUK> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x28C9270", Offset = "0x28C7A70", VA = "0x1828C9270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x28C9490", Offset = "0x28C7C90", VA = "0x1828C9490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly WUFOVRVICVI TRSINEQQQBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly MONBQIUQOND FXFVFYWEEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers QEKFVWFKQSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly NNJKMUFBXEV LUDMMXFNTIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<CATHGSEFVUK>, VGSZPQPOABG> FLWBLLQFTIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<CATHGSEFVUK>>? HHUSJKLMABS;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<VAEORNAZREW> YILRVLPINBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x28BDDB0", Offset = "0x28BC5B0", VA = "0x1828BDDB0", Slot = "4")]
			get
			{
				return default(Id128<VAEORNAZREW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers RWNJJRZVHRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x28BC570", Offset = "0x28BAD70", VA = "0x1828BC570", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> XLNELLSVTNF
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x28BEF40", Offset = "0x28BD740", VA = "0x1828BEF40", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action APMQMZBDQWG
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x28BC230", Offset = "0x28BAA30", VA = "0x1828BC230", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x28BDC30", Offset = "0x28BC430", VA = "0x1828BDC30", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> HKIHPWTCSVM
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x28C25D0", Offset = "0x28C0DD0", VA = "0x1828C25D0", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x28BDBF0", Offset = "0x28BC3F0", VA = "0x1828BDBF0", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x28C3030", Offset = "0x28C1830", VA = "0x1828C3030")]
		public SMTWMJSHTAK(WUFOVRVICVI a, MONBQIUQOND b, NNJKMUFBXEV c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x28BC810", Offset = "0x28BB010", VA = "0x1828BC810", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x28BC770", Offset = "0x28BAF70", VA = "0x1828BC770", Slot = "100")]
		public Id32<LGADMMDLSJA> DNVYKXBHJYR(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId)
		{
			return default(Id32<LGADMMDLSJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x28BED80", Offset = "0x28BD580", VA = "0x1828BED80", Slot = "101")]
		public Id32<ODOZBJITLFD> MUDFNWQIFDS(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId)
		{
			return default(Id32<ODOZBJITLFD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x28C2A20", Offset = "0x28C1220", VA = "0x1828C2A20", Slot = "6")]
		public (bool, bool) YTFHTZZCQEL(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x28BE560", Offset = "0x28BCD60", VA = "0x1828BE560")]
		public bool LXATKHGQGLU(Id32<VAEORNAZREW> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x28C0F10", Offset = "0x28BF710", VA = "0x1828C0F10", Slot = "8")]
		public bool UPKHGOAHATS(IGMMKFROMTK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x28C05E0", Offset = "0x28BEDE0", VA = "0x1828C05E0", Slot = "9")]
		public bool SGSWEFKOSXJ(VYRBTYZQMFH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x28C1BA0", Offset = "0x28C03A0", VA = "0x1828C1BA0", Slot = "10")]
		public AbsoluteLegacyInputId? WOXOHVSIWIM(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x28BC790", Offset = "0x28BAF90", VA = "0x1828BC790", Slot = "11")]
		public AbsoluteLegacyOutputId? DSAOHOOFGYT(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x28BE530", Offset = "0x28BCD30", VA = "0x1828BE530", Slot = "12")]
		public Id32<NNBWOXGQYLV>? LCGIXXMKEIZ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<RYQAJTIFIUP> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x28BCB60", Offset = "0x28BB360", VA = "0x1828BCB60", Slot = "13")]
		public Id32<WZTXETPFGMO>? EWMMVTXPEOS(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<CLOCUIODAVK> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x28BCA10", Offset = "0x28BB210", VA = "0x1828BCA10", Slot = "14")]
		public IEnumerable<Id32<VAEORNAZREW>> EENPNQETMXE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x28BCAA0", Offset = "0x28BB2A0", VA = "0x1828BCAA0", Slot = "15")]
		public IEnumerable<Id32<IRHDXXZWZGG>> ERBRDCYHKEV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x28BDCF0", Offset = "0x28BC4F0", VA = "0x1828BDCF0", Slot = "22")]
		public string HCPSCUHBVCN(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x28BD6E0", Offset = "0x28BBEE0", VA = "0x1828BD6E0", Slot = "16")]
		public Id32<IRHDXXZWZGG>? GIORCPGYISX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x28C0340", Offset = "0x28BEB40", VA = "0x1828C0340", Slot = "17")]
		public int RKOJATGIALY(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x28C1C00", Offset = "0x28C0400", VA = "0x1828C1C00", Slot = "18")]
		public int XPQFFMUWCSD(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x28BE3B0", Offset = "0x28BCBB0", VA = "0x1828BE3B0", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] JIZVZQRVWEM(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x28BE060", Offset = "0x28BC860", VA = "0x1828BE060", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] IJYCVBGQODT(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A34950", Offset = "0x3A33150", VA = "0x183A34950")]
		private static (CircuitTypeIdWrapper, string?)[]? DAJTGPKLDTI<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x28BC250", Offset = "0x28BAA50", VA = "0x1828BC250", Slot = "21")]
		public string BMQZSKIMYCX(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x28BD690", Offset = "0x28BBE90", VA = "0x1828BD690", Slot = "23")]
		public string GABBCLWPTRU(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x28BDEA0", Offset = "0x28BC6A0", VA = "0x1828BDEA0")]
		public VGSZPQPOABG? IAHHLQAOFWN([In] Id128<CATHGSEFVUK> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x28C1B80", Offset = "0x28C0380", VA = "0x1828C1B80", Slot = "30")]
		public Id32<EIHRYTCDBRP> WNCTSJTWSDT(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId)
		{
			return default(Id32<EIHRYTCDBRP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x28BBBC0", Offset = "0x28BA3C0", VA = "0x1828BBBC0")]
		public Id32<CATHGSEFVUK> ZGSWDRPSMAI(Id32<VAEORNAZREW> graphId, [In] Id128<CATHGSEFVUK> legacyNodeId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x28C07D0", Offset = "0x28BEFD0", VA = "0x1828C07D0", Slot = "40")]
		public Id32<CATHGSEFVUK> SOFSYMKTMXT(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x28BDC10", Offset = "0x28BC410", VA = "0x1828BDC10", Slot = "41")]
		public Id32<CATHGSEFVUK> GQHJPONAARW(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x28C0310", Offset = "0x28BEB10", VA = "0x1828C0310")]
		public Id32<CATHGSEFVUK>? RGCDQYRSAAE(Id32<VAEORNAZREW> graphId, [In] Id128<CATHGSEFVUK> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x28C0380", Offset = "0x28BEB80", VA = "0x1828C0380", Slot = "32")]
		public AbsoluteNodeId? RVJRDFFXNWG(Id32<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x28BCA80", Offset = "0x28BB280", VA = "0x1828BCA80", Slot = "33")]
		public long EFTPYSZRELB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x28BEDC0", Offset = "0x28BD5C0", VA = "0x1828BEDC0")]
		private void NEOESPPLXKH(Id128<CATHGSEFVUK> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x28C2FA0", Offset = "0x28C17A0", VA = "0x1828C2FA0", Slot = "38")]
		public IEnumerable<(Id32<VAEORNAZREW>, Id32<CATHGSEFVUK>)> ZGZCLMNCAVT(Id32<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x28BCB30", Offset = "0x28BB330", VA = "0x1828BCB30", Slot = "39")]
		public Id32<WZTXETPFGMO> EWMMVTXPEOS(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<LGADMMDLSJA> inputIndex)
		{
			return default(Id32<WZTXETPFGMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x28BE500", Offset = "0x28BCD00", VA = "0x1828BE500", Slot = "42")]
		public Id32<NNBWOXGQYLV> LCGIXXMKEIZ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<ODOZBJITLFD> outputIndex)
		{
			return default(Id32<NNBWOXGQYLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x28BDD20", Offset = "0x28BC520", VA = "0x1828BDD20")]
		private VGSZPQPOABG? HVIJNJHRXMQ([In] Id128<CATHGSEFVUK> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x28C0C30", Offset = "0x28BF430", VA = "0x1828C0C30")]
		public LBKZHWCVPSD? TZHCJZZIVZI([In] Id128<CATHGSEFVUK> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x28BE4D0", Offset = "0x28BCCD0", VA = "0x1828BE4D0")]
		public QCLYYAWWCMI? UTPMZKXPLJJ([In] Id128<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x28C1490", Offset = "0x28BFC90", VA = "0x1828C1490", Slot = "25")]
		public QCLYYAWWCMI? UTPMZKXPLJJ(Id32<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x28BDC50", Offset = "0x28BC450", VA = "0x1828BDC50", Slot = "34")]
		public IEnumerable<NewStaticEdge> HBNFQGNGOAN(Id32<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x28BC710", Offset = "0x28BAF10", VA = "0x1828BC710", Slot = "35")]
		public bool DKRJSWHSQEF(Id32<IRHDXXZWZGG> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x28C09E0", Offset = "0x28BF1E0", VA = "0x1828C09E0", Slot = "36")]
		public IEnumerable<StableStaticEdge> TLNALZWTODD(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x28BD9A0", Offset = "0x28BC1A0", VA = "0x1828BD9A0", Slot = "37")]
		public IEnumerable<StableStaticEdge> GLUITIQRYCA(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x28BE0C0", Offset = "0x28BC8C0", VA = "0x1828BE0C0")]
		public Id32<VAEORNAZREW> IKMUJHFTRSK([In] Id128<VAEORNAZREW> graphId)
		{
			return default(Id32<VAEORNAZREW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x28BD6B0", Offset = "0x28BBEB0", VA = "0x1828BD6B0")]
		public Id32<VAEORNAZREW>? GCMIYTHZMRY([In] Id128<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x28BE430", Offset = "0x28BCC30", VA = "0x1828BE430")]
		private QOPESGRMHHI? KJNRLYUIKNY([In] Id128<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x28BE4D0", Offset = "0x28BCCD0", VA = "0x1828BE4D0")]
		private QCLYYAWWCMI? OKWTIKEYFRD([In] Id128<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x28BC470", Offset = "0x28BAC70", VA = "0x1828BC470", Slot = "28")]
		public Id32<VAEORNAZREW>? CYFRETOFQVT(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x28C0EF0", Offset = "0x28BF6F0", VA = "0x1828C0EF0", Slot = "46")]
		public Id128<VAEORNAZREW> UNQQHMVZGUD(Id32<VAEORNAZREW> graphId)
		{
			return default(Id128<VAEORNAZREW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x28C1B60", Offset = "0x28C0360", VA = "0x1828C1B60", Slot = "47")]
		public Id128<CATHGSEFVUK> VWGUHQLCMDJ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId)
		{
			return default(Id128<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x28BB9D0", Offset = "0x28BA1D0", VA = "0x1828BB9D0", Slot = "43")]
		public IEnumerable<YBETPIMTIQD> AAZWMEFPWWB(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x28BBE20", Offset = "0x28BA620", VA = "0x1828BBE20", Slot = "44")]
		public YBETPIMTIQD AZQDCBAWZIM(RoomVersion a, XHHKBSRZIYH b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAD0", Offset = "0x28BA2D0", VA = "0x1828BBAD0")]
		public NewStaticEdge EZLOQJYAZCS(Id32<VAEORNAZREW> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x28C0C70", Offset = "0x28BF470", VA = "0x1828C0C70", Slot = "48")]
		public StableStaticEdge UAPPJLUPDHV(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x28C28D0", Offset = "0x28C10D0", VA = "0x1828C28D0", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, SPRIBHSTRKT>> YMDFQDBYHDM(Id32<VAEORNAZREW> parentGraphId, Id32<CATHGSEFVUK> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x28C2750", Offset = "0x28C0F50", VA = "0x1828C2750", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, SPRIBHSTRKT>> YILLUZDHDAL(Id32<VAEORNAZREW> parentGraphId, Id128<CATHGSEFVUK> boardNodeId, List<Id32<CATHGSEFVUK>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x28BE260", Offset = "0x28BCA60", VA = "0x1828BE260", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, SPRIBHSTRKT>> IZIUHGIVWNO(Id32<VAEORNAZREW> parentGraphId, Id128<CATHGSEFVUK> boardNodeId, List<Id32<CATHGSEFVUK>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x28BD330", Offset = "0x28BBB30", VA = "0x1828BD330", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, SPRIBHSTRKT>> FRQRPZXZVKM(Id32<VAEORNAZREW> parentGraphId, Id128<CATHGSEFVUK> boardNodeId, Id32<VAEORNAZREW> graphId, List<Id32<CATHGSEFVUK>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x28BE0F0", Offset = "0x28BC8F0", VA = "0x1828BE0F0", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<JIWIEDNGUWY>, Id32<CLOCUIODAVK>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<JIWIEDNGUWY>, Id32<RYQAJTIFIUP>)>) IMVOGVQKUGV(Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<JIWIEDNGUWY>, Id32<CLOCUIODAVK>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<JIWIEDNGUWY>, Id32<RYQAJTIFIUP>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x28C0680", Offset = "0x28BEE80", VA = "0x1828C0680", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task SLQXANYPNAX(Id128<VAEORNAZREW> legacyGraphId, Id128<CATHGSEFVUK> boardNodeId, IReadOnlyList<Id128<CATHGSEFVUK>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<JIWIEDNGUWY>, Id32<CLOCUIODAVK>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<JIWIEDNGUWY>, Id32<RYQAJTIFIUP>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x28BC7F0", Offset = "0x28BAFF0", VA = "0x1828BC7F0", Slot = "55")]
		public bool DXMTWIVWTEP(Id32<VAEORNAZREW> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x28BE410", Offset = "0x28BCC10", VA = "0x1828BE410", Slot = "56")]
		public bool JKDALZJVJVZ(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x28C0660", Offset = "0x28BEE60", VA = "0x1828C0660", Slot = "57")]
		public bool SLMSYKFLDZK(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x28BC200", Offset = "0x28BAA00", VA = "0x1828BC200")]
		public Result<LIKWTTGVGUH.PrepareTemplateForCloneResult, VFHGFKHTIMO> CGFNASRMVSE([In] LIKWTTGVGUH.PrepareTemplateForCloneArgs args)
		{
			return default(Result<LIKWTTGVGUH.PrepareTemplateForCloneResult, VFHGFKHTIMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x28C01A0", Offset = "0x28BE9A0", VA = "0x1828C01A0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, SPRIBHSTRKT>> QNKPBBQVURY(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x28BC310", Offset = "0x28BAB10", VA = "0x1828BC310", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<CATHGSEFVUK>, SPRIBHSTRKT>> CODUEZKXASD(Id32<VAEORNAZREW> graphId, Id32<EIHRYTCDBRP> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x28BD550", Offset = "0x28BBD50", VA = "0x1828BD550", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> GAAIJMDNDJM(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x28BE990", Offset = "0x28BD190", VA = "0x1828BE990", Slot = "62")]
		public Result<ControlPanelRootData, ZVSGMZZHZEF> MQUPKGZHEHK(Id128<VAEORNAZREW> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, ZVSGMZZHZEF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x28BC8B0", Offset = "0x28BB0B0", VA = "0x1828BC8B0", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, SPRIBHSTRKT>> EAHGWVNVHJS(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> inputNodeId, Id32<JIWIEDNGUWY> inputPortGroupId, Id32<CLOCUIODAVK> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x28C0480", Offset = "0x28BEC80", VA = "0x1828C0480", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, SPRIBHSTRKT>> RXIISSGZOFV(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> outputNodeId, Id32<JIWIEDNGUWY> outputPortGroupId, Id32<RYQAJTIFIUP> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x28BBBF0", Offset = "0x28BA3F0", VA = "0x1828BBBF0", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, SPRIBHSTRKT>> AOSPIUAXROY(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x28C14E0", Offset = "0x28BFCE0", VA = "0x1828C14E0", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<CATHGSEFVUK>>, SPRIBHSTRKT>> UUTBJRWESGV(Id128<VAEORNAZREW> intoGraphId, CircuitTemplateRootData a, IEnumerable<PHWYRKJBQIP> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x28BDFD0", Offset = "0x28BC7D0", VA = "0x1828BDFD0", Slot = "67")]
		public CircuitsData IHFNEXNYIUH()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x28BEEA0", Offset = "0x28BD6A0", VA = "0x1828BEEA0", Slot = "68")]
		public CircuitsData OIXEHOURPCG()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x28C1730", Offset = "0x28BFF30", VA = "0x1828C1730", Slot = "71")]
		public CircuitsTemplateData VCIUIPAHVUZ(TemplateSerializationReason a, Id32<VAEORNAZREW> sourceGraphId, IEnumerable<Id128<VAEORNAZREW>> graphIds, IEnumerable<Id128<CATHGSEFVUK>> nodeIds, ISet<Id128<MSOPKGVLNVM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x28BC580", Offset = "0x28BAD80", VA = "0x1828BC580")]
		private CircuitsTemplateData DJGCLUQHQYY(TemplateSerializationReason a, Id32<VAEORNAZREW> sourceGraphId, IEnumerable<Id128<VAEORNAZREW>> graphIds, IEnumerable<Id128<CATHGSEFVUK>> nodeIds, ISet<Id128<MSOPKGVLNVM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x28BFF40", Offset = "0x28BE740", VA = "0x1828BFF40", Slot = "69")]
		public CircuitsTemplateData PVHIWYWDFNW(TemplateSerializationReason a, Id32<VAEORNAZREW> sourceGraphId, IEnumerable<Id128<CATHGSEFVUK>> nodeIds, IEnumerable<PHWYRKJBQIP> b, ISet<Id128<MSOPKGVLNVM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x28BFE30", Offset = "0x28BE630", VA = "0x1828BFE30", Slot = "70")]
		public CircuitsTemplateData PVHIWYWDFNW(TemplateSerializationReason a, Id32<VAEORNAZREW> sourceGraphId, IEnumerable<Id32<CATHGSEFVUK>> nodeIds, IEnumerable<PHWYRKJBQIP> b, ISet<Id128<MSOPKGVLNVM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x28BF020", Offset = "0x28BD820", VA = "0x1828BF020")]
		private static IEnumerable<Id128<VAEORNAZREW>> OZZLEFLLVDG(IEnumerable<PHWYRKJBQIP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x28C0F90", Offset = "0x28BF790", VA = "0x1828C0F90")]
		private IEnumerable<Id128<CATHGSEFVUK>> USUAKUALEPQ(IEnumerable<PHWYRKJBQIP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x28C02D0", Offset = "0x28BEAD0", VA = "0x1828C02D0", Slot = "72")]
		public List<RNDCLZSKOMZ> RDMOUDAJBQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x28BCB90", Offset = "0x28BB390", VA = "0x1828BCB90")]
		public (List<RNDCLZSKOMZ>, bool) FNKKIKLANNO([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, WJNNGZCVIXN b, SIDHHOOLKJP c)
		{
			return default((List<RNDCLZSKOMZ>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x28BFDA0", Offset = "0x28BE5A0", VA = "0x1828BFDA0", Slot = "74")]
		public bool PNOJMBDKPQB(Id32<VAEORNAZREW> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x28BC280", Offset = "0x28BAA80", VA = "0x1828BC280", Slot = "75")]
		public bool BYGPOEDYWXN(Id32<VAEORNAZREW> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x28C0880", Offset = "0x28BF080", VA = "0x1828C0880")]
		internal void TCCKHYOULTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x28BEDA0", Offset = "0x28BD5A0", VA = "0x1828BEDA0")]
		internal Task MUYKMDBMBRA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x28BF3F0", Offset = "0x28BDBF0", VA = "0x1828BF3F0", Slot = "76")]
		public Result<Id32<NNBWOXGQYLV>?, SPRIBHSTRKT> PJPRCZHUVJE(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<WZTXETPFGMO> inputId)
		{
			return default(Result<Id32<NNBWOXGQYLV>?, SPRIBHSTRKT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x28C1C20", Offset = "0x28C0420", VA = "0x1828C1C20", Slot = "77")]
		public Result<Id32<WZTXETPFGMO>?, SPRIBHSTRKT> XQVVRJNUHZM(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<NNBWOXGQYLV> outputId)
		{
			return default(Result<Id32<WZTXETPFGMO>?, SPRIBHSTRKT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x28C1640", Offset = "0x28BFE40", VA = "0x1828C1640", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, SPRIBHSTRKT>> UZRIXDRKFSH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x28BD1F0", Offset = "0x28BB9F0", VA = "0x1828BD1F0", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, SPRIBHSTRKT>> FOJWRKBVVGT(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x28BEF60", Offset = "0x28BD760", VA = "0x1828BEF60", Slot = "80")]
		public Id32<CATHGSEFVUK>? OZQVNJDIQHX(Id32<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x28BBD00", Offset = "0x28BA500", VA = "0x1828BBD00", Slot = "81")]
		public Id32<CATHGSEFVUK>? ATYQPGQQLSS(Id32<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x28C07F0", Offset = "0x28BEFF0", VA = "0x1828C07F0", Slot = "82")]
		public int SZAWIVVRYZC(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x28BDDD0", Offset = "0x28BC5D0", VA = "0x1828BDDD0", Slot = "83")]
		public int HYYLNOHVJOZ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x28BC120", Offset = "0x28BA920", VA = "0x1828BC120", Slot = "84")]
		public int BBGVYOMDFAC(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x28C2EC0", Offset = "0x28C16C0", VA = "0x1828C2EC0", Slot = "85")]
		public int ZCSFUJXXPXS(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x28C0DB0", Offset = "0x28BF5B0", VA = "0x1828C0DB0", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, SPRIBHSTRKT>> UFLIYJYUKYW(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x28BE850", Offset = "0x28BD050", VA = "0x1828BE850", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, SPRIBHSTRKT>> MGNLYEABVHB(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x28BD490", Offset = "0x28BBC90", VA = "0x1828BD490", Slot = "88")]
		public int FVZNZXUXSDM(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x28C08A0", Offset = "0x28BF0A0", VA = "0x1828C08A0", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, SPRIBHSTRKT>> TKUUTTLTXJC(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x28C25F0", Offset = "0x28C0DF0", VA = "0x1828C25F0", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, SPRIBHSTRKT>> YIFHTPTQILX(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x28C19F0", Offset = "0x28C01F0", VA = "0x1828C19F0", Slot = "91")]
		public bool VTUXWOVBNWE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x28C0360", Offset = "0x28BEB60", VA = "0x1828C0360", Slot = "97")]
		public IEnumerable<Id32<FHFSLOAARZW>> RNOGUPCHAXK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x28BDD90", Offset = "0x28BC590", VA = "0x1828BDD90", Slot = "98")]
		public string? HWCHNJYYHSU(Id32<FHFSLOAARZW> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x28BEF30", Offset = "0x28BD730", VA = "0x1828BEF30", Slot = "7")]
		private bool OLKVGBZFAGC(Id32<VAEORNAZREW> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x28BE4D0", Offset = "0x28BCCD0", VA = "0x1828BE4D0", Slot = "24")]
		private QCLYYAWWCMI KRSEWZAZKQT([In] Id128<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x28BE0C0", Offset = "0x28BC8C0", VA = "0x1828BE0C0", Slot = "26")]
		private Id32<VAEORNAZREW> UPVWDBCJCBE([In] Id128<VAEORNAZREW> graphId)
		{
			return default(Id32<VAEORNAZREW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x28BD6B0", Offset = "0x28BBEB0", VA = "0x1828BD6B0", Slot = "27")]
		private Id32<VAEORNAZREW>? LWUJVGQRYEW([In] Id128<VAEORNAZREW> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x28C18D0", Offset = "0x28C00D0", VA = "0x1828C18D0", Slot = "29")]
		private VGSZPQPOABG VMLECIHRTCR([In] Id128<CATHGSEFVUK> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x28BBBC0", Offset = "0x28BA3C0", VA = "0x1828BBBC0", Slot = "31")]
		private Id32<CATHGSEFVUK> ALMUPYBUNIY(Id32<VAEORNAZREW> graphId, [In] Id128<CATHGSEFVUK> legacyNodeId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAD0", Offset = "0x28BA2D0", VA = "0x1828BBAD0", Slot = "45")]
		private NewStaticEdge AFCBUSBCHFI(Id32<VAEORNAZREW> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x28BC200", Offset = "0x28BAA00", VA = "0x1828BC200", Slot = "58")]
		private Result<LIKWTTGVGUH.PrepareTemplateForCloneResult, VFHGFKHTIMO> BCXQONBIQUY([In] LIKWTTGVGUH.PrepareTemplateForCloneArgs args)
		{
			return default(Result<LIKWTTGVGUH.PrepareTemplateForCloneResult, VFHGFKHTIMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x28BEE40", Offset = "0x28BD640", VA = "0x1828BEE40", Slot = "73")]
		private (List<RNDCLZSKOMZ>, bool) OCELUKNNIOU([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, WJNNGZCVIXN b, SIDHHOOLKJP c)
		{
			return default((List<RNDCLZSKOMZ>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x28BED10", Offset = "0x28BD510", VA = "0x1828BED10")]
		[CompilerGenerated]
		private VPWJRZGESQY MRCOPVJNDWV(RVNMAEXWNBU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x28BBDF0", Offset = "0x28BA5F0", VA = "0x1828BBDF0")]
		[CompilerGenerated]
		private LBKZHWCVPSD PINJWRXCTBH(Id128<CATHGSEFVUK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x28BBDC0", Offset = "0x28BA5C0", VA = "0x1828BBDC0")]
		[CompilerGenerated]
		private QOPESGRMHHI PIICZLDFJPY(Id128<VAEORNAZREW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x28BBDF0", Offset = "0x28BA5F0", VA = "0x1828BBDF0")]
		[CompilerGenerated]
		private LBKZHWCVPSD AVNTWRSNAOR(Id128<CATHGSEFVUK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x28BBDC0", Offset = "0x28BA5C0", VA = "0x1828BBDC0")]
		[CompilerGenerated]
		private QOPESGRMHHI AVIMZKYPRDI(Id128<VAEORNAZREW> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class VPWJRZGESQY : YBETPIMTIQD
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
			public AsyncTaskMethodBuilder<Result<Id32<ITYZVGJUOOJ>, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public VPWJRZGESQY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<JIWIEDNGUWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<ITYZVGJUOOJ>, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x28C36D0", Offset = "0x28C1ED0", VA = "0x1828C36D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x28C3920", Offset = "0x28C2120", VA = "0x1828C3920", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<XSORAGHTHUW>, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public VPWJRZGESQY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<VAEORNAZREW> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<CATHGSEFVUK> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<JIWIEDNGUWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<XSORAGHTHUW>, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x28C3990", Offset = "0x28C2190", VA = "0x1828C3990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x28C3BE0", Offset = "0x28C23E0", VA = "0x1828C3BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly RVNMAEXWNBU NXRWPEPNZYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly MONBQIUQOND FXFVFYWEEKN;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey BDXCGXTXCPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string FLOIORYHPSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x28B64D0", Offset = "0x28B4CD0", VA = "0x1828B64D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public RVNMAEXWNBU RVNMAEXWNBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x28C9CB0", Offset = "0x28C84B0", VA = "0x1828C9CB0")]
		public VPWJRZGESQY(RVNMAEXWNBU a, MONBQIUQOND b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x28C99D0", Offset = "0x28C81D0", VA = "0x1828C99D0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<ITYZVGJUOOJ>, SPRIBHSTRKT>> NZTOPEHYLEF(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x28C9B40", Offset = "0x28C8340", VA = "0x1828C9B40", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<XSORAGHTHUW>, SPRIBHSTRKT>> QVLTCCXLIRE(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class DLQLWOIRJEW : FUCFUCZHAKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly RVNMAEXWNBU IHWJHUUFOEC;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<RVNMAEXWNBU> SDULKEPTSJS;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<RVNMAEXWNBU> FZYYFZQBRXX;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<RVNMAEXWNBU> GLETNGMMYII;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public RVNMAEXWNBU QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x28B7E60", Offset = "0x28B6660", VA = "0x1828B7E60", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x28B7E50", Offset = "0x28B6650", VA = "0x1828B7E50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x28B7EB0", Offset = "0x28B66B0", VA = "0x1828B7EB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x28B7DD0", Offset = "0x28B65D0", VA = "0x1828B7DD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x28B60D0", Offset = "0x28B48D0", VA = "0x1828B60D0")]
		public bool OJCDRUUEASX(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public DLQLWOIRJEW(RVNMAEXWNBU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x28B6340", Offset = "0x28B4B40", VA = "0x1828B6340")]
		internal static TypeKey PJJXINCTSNO(RVNMAEXWNBU a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x28B64D0", Offset = "0x28B4CD0", VA = "0x1828B64D0", Slot = "3")]
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
	public readonly struct ActionDeps : WJCXSIBAOJT.PGUVLZIIUJS<UZPYRKQPSNH, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x28B5FA0", Offset = "0x28B47A0", VA = "0x1828B5FA0", Slot = "4")]
		public int FHCWOIETFTQ(None a, UZPYRKQPSNH b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x28B6010", Offset = "0x28B4810", VA = "0x1828B6010", Slot = "5")]
		public UZPYRKQPSNH ILNGCYDVHQF(None a, UZPYRKQPSNH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x28B5FE0", Offset = "0x28B47E0", VA = "0x1828B5FE0", Slot = "6")]
		public UZPYRKQPSNH HXTCSKWYRJQ(None a, UZPYRKQPSNH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x28B5FC0", Offset = "0x28B47C0", VA = "0x1828B5FC0", Slot = "7")]
		public IReadOnlyList<UZPYRKQPSNH> GTIRSZPGYJC(None a, UZPYRKQPSNH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x28B6040", Offset = "0x28B4840", VA = "0x1828B6040", Slot = "8")]
		public UZPYRKQPSNH[] SPKZRULCSLZ(None a, UZPYRKQPSNH b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x28B6070", Offset = "0x28B4870", VA = "0x1828B6070", Slot = "9")]
		public bool YGDHOHTXEPS(None a, UZPYRKQPSNH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x28B6050", Offset = "0x28B4850", VA = "0x1828B6050", Slot = "10")]
		public bool SVHKTAHJAHA(None a, UZPYRKQPSNH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F60", Offset = "0x28B4760", VA = "0x1828B5F60", Slot = "11")]
		public bool BJMUWMPQKZC(None a, UZPYRKQPSNH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x28B6020", Offset = "0x28B4820", VA = "0x1828B6020", Slot = "12")]
		public bool NINDFFGAYJA(None a, UZPYRKQPSNH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F80", Offset = "0x28B4780", VA = "0x1828B5F80", Slot = "13")]
		public bool CBJNMOXSGOY(None a, UZPYRKQPSNH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x28B6090", Offset = "0x28B4890", VA = "0x1828B6090", Slot = "14")]
		public bool YNMWOWWNDMV(None a, UZPYRKQPSNH b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class GBNEEJCGTZF : YMJQTRDYOVJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract USDOVPRHJYZ.ZVDGYJVWQXS ZWFVDBYFRZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract WUFOVRVICVI.ZVDGYJVWQXS GWXMDICXLBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract UODJRLEVSXT.ZVDGYJVWQXS KYVASCOZIDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI> AIZPACHMDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x28B80D0", Offset = "0x28B68D0", VA = "0x1828B80D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.ZVDGYJVWQXS VMPVWCQGZFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract JDJZIVHVKYR ZMXIIHZYOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract HBXNNDQOUSM FSGGIZXFAUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract JMIZFOBJITY DOXWMKSIFVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract GQGQFHQZALQ UZRORNEAVIV
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract UHZWDRMUWQU HMZZDAZSRHV
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected GBNEEJCGTZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class MAEHGAOFPZN : ZDAEVGBZTIJ
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
			public AsyncTaskMethodBuilder<Result<MultiResult, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<UZPYRKQPSNH> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public MAEHGAOFPZN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x28C4210", Offset = "0x28C2A10", VA = "0x1828C4210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x28C4630", Offset = "0x28C2E30", VA = "0x1828C4630", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public MAEHGAOFPZN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public UZPYRKQPSNH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x28C8F80", Offset = "0x28C7780", VA = "0x1828C8F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x28C9190", Offset = "0x28C7990", VA = "0x1828C9190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly KIQIZMMDNIQ CCXWSTGTELQ;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public MAEHGAOFPZN(KIQIZMMDNIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x28B8120", Offset = "0x28B6920", VA = "0x1828B8120")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, SPRIBHSTRKT>> KQBNDACPJAY(UZPYRKQPSNH a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x28B8250", Offset = "0x28B6A50", VA = "0x1828B8250", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, SPRIBHSTRKT>> YXEKKXYPGCI(IReadOnlyList<UZPYRKQPSNH> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, UZPYRKQPSNH, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, UZPYRKQPSNH, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x28BB970", Offset = "0x28BA170", VA = "0x1828BB970")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class RDHHQHZHVAS
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, UZPYRKQPSNH, PartialActionReassemblyDeps> XKPULYNVEYB(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, UZPYRKQPSNH, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : OHANVWTTLEX.BZZUHUVHMDL<PartialActionPayload, Id128<PartialActionPayload.M>, UZPYRKQPSNH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x28BB780", Offset = "0x28B9F80", VA = "0x1828BB780", Slot = "7")]
		public UZPYRKQPSNH AHOKIEHYJYH(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x1023DB0", Offset = "0x10225B0", VA = "0x181023DB0")]
		public Id128<PartialActionPayload.M> ORCJTGZXCZJ([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x103DD60", Offset = "0x103C560", VA = "0x18103DD60")]
		public int FEVSAZTRSPX([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x28BB960", Offset = "0x28BA160", VA = "0x1828BB960")]
		public int RIRNHMVXCNA([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x103DD60", Offset = "0x103C560", VA = "0x18103DD60", Slot = "4")]
		private int KRTSQOWMQXR([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB960", Offset = "0x28BA160", VA = "0x1828BB960", Slot = "5")]
		private int NEJMVXZTLRW([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x1023DB0", Offset = "0x10225B0", VA = "0x181023DB0", Slot = "6")]
		private Id128<PartialActionPayload.M> VZIQELOKPQJ([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, UZPYRKQPSNH, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, UZPYRKQPSNH, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x28C3670", Offset = "0x28C1E70", VA = "0x1828C3670")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class QNSWERFQAYB
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0")]
		public static SnapshotReassembly<PartialInitializePayload, UZPYRKQPSNH, SnapshotReassemblyDeps> XKPULYNVEYB(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, UZPYRKQPSNH, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : RBJXPEJGOQC.BZUNKOBKCSC<PartialInitializePayload, UZPYRKQPSNH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xE5BAA0", Offset = "0xE5A2A0", VA = "0x180E5BAA0")]
		public int EYFDHNJDTRJ([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x28C3490", Offset = "0x28C1C90", VA = "0x1828C3490", Slot = "5")]
		public UZPYRKQPSNH YBIGNVMPIEJ(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xE5BAA0", Offset = "0xE5A2A0", VA = "0x180E5BAA0", Slot = "4")]
		private int ZWVLALICNHL([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class YPIAGJQICKP : GPJDWMBBLWO, VFHGFKHTIMO, SPRIBHSTRKT, ZVSGMZZHZEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly ZVSGMZZHZEF? WVQTCVLPXNV;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind OHCPFBUROHL
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xAB1220", Offset = "0xAAFA20", VA = "0x180AB1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override ZVSGMZZHZEF? JSNKYXLBWJO
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x28CA210", Offset = "0x28C8A10", VA = "0x1828CA210", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x28CA3E0", Offset = "0x28C8BE0", VA = "0x1828CA3E0")]
		private YPIAGJQICKP(PrepareTemplateForCloneErrKind a, ZVSGMZZHZEF? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x28CA370", Offset = "0x28C8B70", VA = "0x1828CA370")]
		public static YPIAGJQICKP SOQCDBFPLRN(ZVSGMZZHZEF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x28CA1B0", Offset = "0x28C89B0", VA = "0x1828CA1B0")]
		public static YPIAGJQICKP CPDFOKGZMDZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x28CA310", Offset = "0x28C8B10", VA = "0x1828CA310")]
		public static YPIAGJQICKP LQPTNWGMUFP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class HGAOSRUPHTU
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x36D2670", Offset = "0x36D0E70", VA = "0x1836D2670")]
		public static Result<TOk, VFHGFKHTIMO> KLBHTTDJTRK<TOk>([In] this Result<TOk, VFHGFKHTIMO> self, ZVSGMZZHZEF a) where TOk : notnull
		{
			return default(Result<TOk, VFHGFKHTIMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x36D25F0", Offset = "0x36D0DF0", VA = "0x1836D25F0")]
		public static Result<a?, VFHGFKHTIMO?> JSIGAWHBHAW<a>([In] this Result<a, VFHGFKHTIMO> self)
		{
			return default(Result<a, VFHGFKHTIMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x36D24A0", Offset = "0x36D0CA0", VA = "0x1836D24A0")]
		public static Result<b?, VFHGFKHTIMO?> AUXDSSNGOKY<b>([In] this Result<b, VFHGFKHTIMO> self)
		{
			return default(Result<b, VFHGFKHTIMO>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface JDJZIVHVKYR
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UXVZDFLEASP([In] Result<None, ZVSGMZZHZEF> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class TQQFAUDPIRV
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x3A7EBC0", Offset = "0x3A7D3C0", VA = "0x183A7EBC0")]
		public static bool UXVZDFLEASP<TOk, TErr>(this JDJZIVHVKYR a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, ZVSGMZZHZEF
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface HBXNNDQOUSM
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		XBMWUHKVFEA WQETLTKBGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface JMIZFOBJITY
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor NAJFICRCIMH(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface MROKHZDWAJR
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface IPJIQLDRPBS
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UEAJODIBGXU? PDJDFTVMYVX(Id32<JIWIEDNGUWY> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface BFUIDMCOJVC
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface UEAJODIBGXU
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BFUIDMCOJVC? ZDIRXFQGNXF(Id32<ITYZVGJUOOJ> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MROKHZDWAJR? KVYUUBJTUQW(Id32<XSORAGHTHUW> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface GQGQFHQZALQ
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> UZWJKGCCKYA(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface UHZWDRMUWQU
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IPJIQLDRPBS? PQCBXTFNLBX([In] Id128<YJGJBYABSIW> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class PZGULTBNZZJ
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
			public readonly List<UZPYRKQPSNH> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x28B8080", Offset = "0x28B6880", VA = "0x1828B8080")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<UZPYRKQPSNH> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x28B7FD0", Offset = "0x28B67D0", VA = "0x1828B7FD0")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly VPLKYNMBHVC<Diagnostic> SCBAULWFXSJ;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static PZGULTBNZZJ QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x28BB4E0", Offset = "0x28B9CE0", VA = "0x1828BB4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool KHVDTRPSNON
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB01D60", VA = "0x180B03560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xB857D0", Offset = "0xB83FD0", VA = "0x180B857D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x28BB530", Offset = "0x28B9D30", VA = "0x1828BB530")]
		public void OFCREJJWIZC(MONBQIUQOND a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x28BB200", Offset = "0x28B9A00", VA = "0x1828BB200")]
		public void IFIJPNAWGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x28BB040", Offset = "0x28B9840", VA = "0x1828BB040")]
		private static string? DNIDVWNHXTP([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x28BB6E0", Offset = "0x28B9EE0", VA = "0x1828BB6E0")]
		public PZGULTBNZZJ()
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
