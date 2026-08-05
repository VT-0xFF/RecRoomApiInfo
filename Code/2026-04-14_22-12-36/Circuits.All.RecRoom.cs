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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1CCA0", Offset = "0x2B1B8A0", VA = "0x182B1CCA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1C340", Offset = "0x2B1AF40", VA = "0x182B1C340", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class XXEAPKVABFJ : IDisposable, DYEPWGGWKEA, CNJWCYVXBGJ, JVGPPCFBWKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class BLFMBBVUXNY : ODRSNXNZSZX
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int WPKYTONSOYO
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B14AF0", Offset = "0x2B136F0", VA = "0x182B14AF0", Slot = "5")]
			public XVENBBMCSIN BGUZMDCHWUC(HLQSLBGKSFS.ODRSNXNZSZX a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void SMFAAABNEQG();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void ZBOTPKSSUGB();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2B03680", Offset = "0x2B02280", VA = "0x182B03680", Slot = "13")]
			public virtual void BUOAZLJHQOX(XXEAPKVABFJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2B14D80", Offset = "0x2B13980", VA = "0x182B14D80", Slot = "14")]
			public virtual void IKEFLBMLIHC(XXEAPKVABFJ a, FXFJUDAMIWO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			protected BLFMBBVUXNY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ODRSNXNZSZX
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int WPKYTONSOYO
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			XVENBBMCSIN BGUZMDCHWUC(HLQSLBGKSFS.ODRSNXNZSZX a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SMFAAABNEQG();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void ZBOTPKSSUGB();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void BUOAZLJHQOX(XXEAPKVABFJ a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void IKEFLBMLIHC(XXEAPKVABFJ a, FXFJUDAMIWO b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12B8AE0", Offset = "0x12B76E0", VA = "0x1812B8AE0")]
			internal Reducer(Reducer<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class ZKACJCVERLI : JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly ZKACJCVERLI UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private ZKACJCVERLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1522A20", Offset = "0x1521620", VA = "0x181522A20", Slot = "4")]
			public ActionKind NIXMCLOKLLQ(FXFJUDAMIWO a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2B36640", Offset = "0x2B35240", VA = "0x182B36640", Slot = "5")]
			public void BUOAZLJHQOX(XXEAPKVABFJ a, FXFJUDAMIWO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2B36740", Offset = "0x2B35340", VA = "0x182B36740", Slot = "6")]
			public void IKEFLBMLIHC(XXEAPKVABFJ a, FXFJUDAMIWO b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2B1E620", Offset = "0x2B1D220", VA = "0x182B1E620")]
			internal ReducerFactory(ReducerFactory<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B1E5D0", Offset = "0x2B1D1D0", VA = "0x182B1E5D0")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : BROQOKBSSNY.HMOGKZJGOJU<FXFJUDAMIWO, XXEAPKVABFJ>
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
				public AsyncTaskMethodBuilder<Result<object?, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public XXEAPKVABFJ receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public FXFJUDAMIWO action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B211D0", Offset = "0x2B1FDD0", VA = "0x182B211D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B213B0", Offset = "0x2B1FFB0", VA = "0x182B213B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD542B0", Offset = "0xD52EB0", VA = "0x180D542B0", Slot = "4")]
			public Id32<GEJEFIAWMNS> LRKCOWRBQBH(XXEAPKVABFJ a)
			{
				return default(Id32<GEJEFIAWMNS>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B201A0", Offset = "0x2B1EDA0", VA = "0x182B201A0", Slot = "5")]
			public void GPLJXYNFNHU(XXEAPKVABFJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B20200", Offset = "0x2B1EE00", VA = "0x182B20200", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, LYQWSZGLQZW>> PWQNBYGKYEP(XXEAPKVABFJ a, FXFJUDAMIWO b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B20180", Offset = "0x2B1ED80", VA = "0x182B20180", Slot = "7")]
			public FXFJUDAMIWO[] CIOTDKNDXUX(XXEAPKVABFJ a)
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
			public AsyncTaskMethodBuilder<Result<object?, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public XXEAPKVABFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public FXFJUDAMIWO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B21420", Offset = "0x2B20020", VA = "0x182B21420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2B21610", Offset = "0x2B20210", VA = "0x182B21610", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public XXEAPKVABFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2B22B40", Offset = "0x2B21740", VA = "0x182B22B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2B22DC0", Offset = "0x2B219C0", VA = "0x182B22DC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public XXEAPKVABFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2B22E30", Offset = "0x2B21A30", VA = "0x182B22E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2B23010", Offset = "0x2B21C10", VA = "0x182B23010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<GEJEFIAWMNS> JIKDBTVVWUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer WNFKSRZSIRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 SNUJREMDPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly HAHYOVHKCDQ CPZTXHJFAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly UVZHGVMFUGK.CreationArgs JRDCOPAULIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly WWEJMWWXKUT KLHHEZXEFCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly RGCQDGKZILM LAJQWNKJGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly ZMZHZWJQYGR WTVRMTJGTPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly CKBXBIEZVZQ FGZKSQFJXLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly WSHJYNNKVMC DESPCIZKDSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly VELLWUXUXII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly ULVGVYFKGYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest TSEJSHODISI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended FKIQTCLPVWV;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal ODRSNXNZSZX TBBOXBIHTQY
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B34A10", Offset = "0x2B33610", VA = "0x182B34A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal XVENBBMCSIN QEMFXQMHBOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B33940", Offset = "0x2B32540", VA = "0x182B33940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B34980", Offset = "0x2B33580", VA = "0x182B34980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool ATPYNSOEZHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2B34180", Offset = "0x2B32D80", VA = "0x182B34180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B34BF0", Offset = "0x2B337F0", VA = "0x182B34BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public SJARTMFVJBA WWEJMWWXKUT
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B34EF0", Offset = "0x2B33AF0", VA = "0x182B34EF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EQFICGHEXRE ZMZHZWJQYGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B34F00", Offset = "0x2B33B00", VA = "0x182B34F00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public QIKCKNGZMSF WSHJYNNKVMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B34F20", Offset = "0x2B33B20", VA = "0x182B34F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EEERQAOJJHT RGCQDGKZILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B34810", Offset = "0x2B33410", VA = "0x182B34810", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public XMDBMIVUYYH CKBXBIEZVZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2B34F10", Offset = "0x2B33B10", VA = "0x182B34F10", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public UVZHGVMFUGK? UVZHGVMFUGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B348A0", Offset = "0x2B334A0", VA = "0x182B348A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B34C00", Offset = "0x2B33800", VA = "0x182B34C00")]
		private XXEAPKVABFJ(HAHYOVHKCDQ a, Id32<GEJEFIAWMNS> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, XVENBBMCSIN b, [In] UVZHGVMFUGK.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B34190", Offset = "0x2B32D90", VA = "0x182B34190")]
		public static XXEAPKVABFJ New(HAHYOVHKCDQ deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<GEJEFIAWMNS> actorId, Id32<STFYXSIYFLB> rootNetworkObjectId, HATGOKICMKB staticNetSys, UNRLRPNONNX dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B34260", Offset = "0x2B32E60", VA = "0x182B34260")]
		public static XXEAPKVABFJ New(HAHYOVHKCDQ dependencies, [In] RegistryV2 registryV2, Id32<GEJEFIAWMNS> actorId, Id32<STFYXSIYFLB> rootNetworkObjectId, HATGOKICMKB staticNetSys, UNRLRPNONNX dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B33E60", Offset = "0x2B32A60", VA = "0x182B33E60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B34720", Offset = "0x2B33320", VA = "0x182B34720")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, LYQWSZGLQZW>> QBMKJPSHGCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B34090", Offset = "0x2B32C90", VA = "0x182B34090")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, LYQWSZGLQZW>> HATCZXAZSEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B34520", Offset = "0x2B33120", VA = "0x182B34520")]
		internal void QAMFKIEXEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B34820", Offset = "0x2B33420", VA = "0x182B34820")]
		internal Option<FXFJUDAMIWO> RGEOUGOSVSO([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<FXFJUDAMIWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B349A0", Offset = "0x2B335A0", VA = "0x182B349A0")]
		internal bool WCMUZCTCFZD([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B34A60", Offset = "0x2B33660", VA = "0x182B34A60")]
		internal Result<FXFJUDAMIWO, LYQWSZGLQZW> XKVTTUJCTUK([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<FXFJUDAMIWO, LYQWSZGLQZW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B34040", Offset = "0x2B32C40", VA = "0x182B34040")]
		private void GPLJXYNFNHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B33950", Offset = "0x2B32550", VA = "0x182B33950")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, LYQWSZGLQZW>> CDWZVVJBTZE(FXFJUDAMIWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B33A60", Offset = "0x2B32660", VA = "0x182B33A60")]
		private FXFJUDAMIWO[] CIOTDKNDXUX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class RHPUVJRBQYP<a> : ARGBUOZFZQD, ODGEVSCCMZV, SCULPNIXVDU where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<NYBQVHGBIMX>? PFYBETOENAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string YRNJBNRLCIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a HBLTVDNEEXS;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<NYBQVHGBIMX>? ZPNWFQPXRMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AF60", Offset = "0x2E09B60", VA = "0x182E0AF60", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x767AA70", Offset = "0x7679670", VA = "0x18767AA70")]
		internal RHPUVJRBQYP([In] Id128<NYBQVHGBIMX>? lastNode, Id32<ODUYWEZJSCU>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class PZZQZOZPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CEA0", Offset = "0x2B1BAA0", VA = "0x182B1CEA0")]
		public static Result<DebugExecutionResult, ODGEVSCCMZV> ZNZIKYVHIGY([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, ODGEVSCCMZV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3D96320", Offset = "0x3D94F20", VA = "0x183D96320")]
		public static Result<TOk, ODGEVSCCMZV> PWAFYEXRECY<TOk>([In] this Result<TOk, ODGEVSCCMZV> self, [In] Id128<NYBQVHGBIMX>? lastNode, Id32<ODUYWEZJSCU>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, ODGEVSCCMZV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface HAHYOVHKCDQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		HLQSLBGKSFS.ODRSNXNZSZX SWMSEXOCKHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		XXEAPKVABFJ.ODRSNXNZSZX KUDMWPWEUFT
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		GFREUFWJHCW.ODRSNXNZSZX CNTZRWREGMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ> ZKACJCVERLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.ODRSNXNZSZX HZQEDPZHDBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		SZNXFZCEGDW WDOKEZLXTRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		CNGANKRQXIV WFSWMWLMNXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		WNSVIDJHVWR IPYCYPEMXYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		LGZSDACFKQJ XFDGRKSQAAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		CBQIBVXTUYH ALSEHUSRKSO
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
	public static class WYCEAFQQYMZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B334C0", Offset = "0x2B320C0", VA = "0x182B334C0")]
		public static FXFJUDAMIWO QQMEEPOQELO(this FXFJUDAMIWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B333F0", Offset = "0x2B31FF0", VA = "0x182B333F0")]
		public static FXFJUDAMIWO BQPJFLJMXHN(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public XXEAPKVABFJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B21680", Offset = "0x2B20280", VA = "0x182B21680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B21DA0", Offset = "0x2B209A0", VA = "0x182B21DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B19BD0", Offset = "0x2B187D0", VA = "0x182B19BD0")]
		public static FXFJUDAMIWO CHAWHDSMOPW(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B19C90", Offset = "0x2B18890", VA = "0x182B19C90")]
		public static ReduceAction<ActionKind, CompressedPayload> KWYIOGGXFTD(FXFJUDAMIWO actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B19AC0", Offset = "0x2B186C0", VA = "0x182B19AC0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, LYQWSZGLQZW>> CDWZVVJBTZE(XXEAPKVABFJ a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A4A0", Offset = "0x2B190A0", VA = "0x182B1A4A0")]
		public static FXFJUDAMIWO CHAWHDSMOPW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A540", Offset = "0x2B19140", VA = "0x182B1A540")]
		public static ReduceAction<ActionKind, DestroyPayload> KWYIOGGXFTD(FXFJUDAMIWO actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A5B0", Offset = "0x2B191B0", VA = "0x182B1A5B0")]
		public static Result<None, THQIDYNYSUZ> MSRCUBIIEOS(XXEAPKVABFJ a, [In] DestroyPayload self)
		{
			return default(Result<None, THQIDYNYSUZ>);
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
			public AsyncTaskMethodBuilder<Result<None, THQIDYNYSUZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public XXEAPKVABFJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, THQIDYNYSUZ> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B21E80", Offset = "0x2B20A80", VA = "0x182B21E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B22420", Offset = "0x2B21020", VA = "0x182B22420", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F36790", Offset = "0x1F35390", VA = "0x181F36790")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A7E0", Offset = "0x2B193E0", VA = "0x182B1A7E0")]
		public static FXFJUDAMIWO? CHAWHDSMOPW(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A8E0", Offset = "0x2B194E0", VA = "0x182B1A8E0")]
		public static ReduceAction<ActionKind, FullInitializePayload> KWYIOGGXFTD(FXFJUDAMIWO actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A6A0", Offset = "0x2B192A0", VA = "0x182B1A6A0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, THQIDYNYSUZ>> CDWZVVJBTZE(XXEAPKVABFJ a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public XXEAPKVABFJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, LYQWSZGLQZW> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, SCULPNIXVDU>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, SCULPNIXVDU> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, SCULPNIXVDU>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B21940", Offset = "0x2B20540", VA = "0x182B21940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B21E10", Offset = "0x2B20A10", VA = "0x182B21E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<FXFJUDAMIWO> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		private MultiPayload(IReadOnlyList<FXFJUDAMIWO> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CB40", Offset = "0x2B1B740", VA = "0x182B1CB40")]
		public static FXFJUDAMIWO CHAWHDSMOPW(IReadOnlyList<FXFJUDAMIWO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CC00", Offset = "0x2B1B800", VA = "0x182B1CC00")]
		public static ReduceAction<ActionKind, MultiPayload> KWYIOGGXFTD(FXFJUDAMIWO actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CA00", Offset = "0x2B1B600", VA = "0x182B1CA00")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, LYQWSZGLQZW>> CDWZVVJBTZE(XXEAPKVABFJ a, MultiPayload b)
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
		private sealed class ACFWOTACWWL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> EVWILNFBSKT;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ACFWOTACWWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B14630", Offset = "0x2B13230", VA = "0x182B14630")]
			internal FXFJUDAMIWO JSCKIOJNTVB(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2B1D840", Offset = "0x2B1C440", VA = "0x182B1D840")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D340", Offset = "0x2B1BF40", VA = "0x182B1D340")]
		public static FXFJUDAMIWO CHAWHDSMOPW(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D740", Offset = "0x2B1C340", VA = "0x182B1D740")]
		public static FXFJUDAMIWO[] UMQSUSLENDF(FXFJUDAMIWO a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D450", Offset = "0x2B1C050", VA = "0x182B1D450")]
		public static ReduceAction<ActionKind, PartialActionPayload> KWYIOGGXFTD(FXFJUDAMIWO actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D5A0", Offset = "0x2B1C1A0", VA = "0x182B1D5A0")]
		public static Result<FXFJUDAMIWO, LYQWSZGLQZW> MSRCUBIIEOS(XXEAPKVABFJ a, [In] PartialActionPayload self)
		{
			return default(Result<FXFJUDAMIWO, LYQWSZGLQZW>);
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
			public AsyncTaskMethodBuilder<Result<bool, THQIDYNYSUZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public XXEAPKVABFJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, THQIDYNYSUZ> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, THQIDYNYSUZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B22490", Offset = "0x2B21090", VA = "0x182B22490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B22AD0", Offset = "0x2B216D0", VA = "0x182B22AD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD9A860", Offset = "0xD99460", VA = "0x180D9A860")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D990", Offset = "0x2B1C590", VA = "0x182B1D990")]
		public static FXFJUDAMIWO CHAWHDSMOPW(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DA70", Offset = "0x2B1C670", VA = "0x182B1DA70")]
		public static FXFJUDAMIWO?[]? FXWWIZGUWTN(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DC70", Offset = "0x2B1C870", VA = "0x182B1DC70")]
		public static ReduceAction<ActionKind, PartialInitializePayload> KWYIOGGXFTD(FXFJUDAMIWO actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D860", Offset = "0x2B1C460", VA = "0x182B1D860")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, THQIDYNYSUZ>> CDWZVVJBTZE(XXEAPKVABFJ a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class WWEJMWWXKUT : SJARTMFVJBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public AKLAAMXYOQJ? UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B33010", Offset = "0x2B31C10", VA = "0x182B33010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		internal WWEJMWWXKUT(XXEAPKVABFJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class CYXAPTBONCA : AKLAAMXYOQJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly UVZHGVMFUGK YDCCNTNQGNU;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1560", VA = "0x180CF2960")]
		public CYXAPTBONCA(XXEAPKVABFJ a, UVZHGVMFUGK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B18F60", Offset = "0x2B17B60", VA = "0x182B18F60", Slot = "4")]
		public Result<DebugExecutionResult, ODGEVSCCMZV> LEEGLXZMZPI(Id128<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<YGYJAOJPYZV> inputId)
		{
			return default(Result<DebugExecutionResult, ODGEVSCCMZV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B19510", Offset = "0x2B18110", VA = "0x182B19510", Slot = "5")]
		public Result<DebugExecutionResult, ODGEVSCCMZV> ZNOEEPTASPD(Id128<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<BOADJKKKFWS> outputId)
		{
			return default(Result<DebugExecutionResult, ODGEVSCCMZV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HLQSLBGKSFS : XVENBBMCSIN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface ODRSNXNZSZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<QNOYLKOFSQJ> BPDYRAPHVHC(XXEAPKVABFJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void QEZKTPHXOFK(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class BLFMBBVUXNY : ODRSNXNZSZX
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
				public AsyncTaskMethodBuilder<QNOYLKOFSQJ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public XXEAPKVABFJ circuitsManager;

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
				private TaskAwaiter<GFREUFWJHCW> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2B20780", Offset = "0x2B1F380", VA = "0x182B20780", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2B20950", Offset = "0x2B1F550", VA = "0x182B20950", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B14C20", Offset = "0x2B13820", VA = "0x182B14C20", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<QNOYLKOFSQJ> BPDYRAPHVHC(XXEAPKVABFJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void QEZKTPHXOFK(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			protected BLFMBBVUXNY()
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
			public AsyncTaskMethodBuilder<QNOYLKOFSQJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HLQSLBGKSFS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B209C0", Offset = "0x2B1F5C0", VA = "0x182B209C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B20BC0", Offset = "0x2B1F7C0", VA = "0x182B20BC0", Slot = "5")]
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
			public HLQSLBGKSFS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public XXEAPKVABFJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<QNOYLKOFSQJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B20C30", Offset = "0x2B1F830", VA = "0x182B20C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B21170", Offset = "0x2B1FD70", VA = "0x182B21170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ODRSNXNZSZX XBSGLFJHVQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> TYGTOGHFZSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> NBOEYZMUQPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource FIQBLMJNGQD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool ATPYNSOEZHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C970", VA = "0x180D4DD70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DCD0", VA = "0x180D4F0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF45580", Offset = "0xF44180", VA = "0x180F45580", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xF8C5D0", Offset = "0xF8B1D0", VA = "0x180F8C5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool INJMALVELGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1ABDA00", Offset = "0x1ABC600", VA = "0x181ABDA00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1B0C280", Offset = "0x1B0AE80", VA = "0x181B0C280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public QNOYLKOFSQJ? UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF3130", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BC10", Offset = "0x2B1A810", VA = "0x182B1BC10", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<QNOYLKOFSQJ> UURDZGUEJHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BD00", Offset = "0x2B1A900", VA = "0x182B1BD00")]
		public HLQSLBGKSFS(ODRSNXNZSZX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BAD0", Offset = "0x2B1A6D0", VA = "0x182B1BAD0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task SNNUVSLYUCG(XXEAPKVABFJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B960", Offset = "0x2B1A560", VA = "0x182B1B960", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class CFTUETIQJFD : FSVLWNXDUYM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly KEHJKNTJZOR BETZWLWEYUA;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public CFTUETIQJFD(KEHJKNTJZOR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class ONNUUHEIGKK
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class SUAULYCLTSY<a> : MHPCUTAZFHR where a : WRFHDLXQCSV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a OOTXTBAPZNB;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? JXGBECVCNWR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xF09840", Offset = "0xF08440", VA = "0x180F09840", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<NYBQVHGBIMX>? CINDVGNVCQB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x79326D0", Offset = "0x79312D0", VA = "0x1879326D0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<GNQADATMYDH> SJRWWGJZADD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2E06E30", Offset = "0x2E05A30", VA = "0x182E06E30", Slot = "5")]
				get
				{
					return default(Id32<GNQADATMYDH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<GNQADATMYDH>? OBNSMBEJBRD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x7932650", Offset = "0x7931250", VA = "0x187932650", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
			public SUAULYCLTSY(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class BQZJUJSQLHM : SUAULYCLTSY<KCFUSCZQKMY>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? JXGBECVCNWR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x1037800", Offset = "0x1036400", VA = "0x181037800", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B14E00", Offset = "0x2B13A00", VA = "0x182B14E00")]
			public BQZJUJSQLHM(KCFUSCZQKMY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CD20", Offset = "0x2B1B920", VA = "0x182B1CD20")]
		public static MHPCUTAZFHR New(WRFHDLXQCSV graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class BURBBHTOTEG : YORQLJFLTEB, XSKRLXQDISL, WSYNBUDJKHM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class XKXJREZMWEQ
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
				public XKXJREZMWEQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public SZNXFZCEGDW errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B24210", Offset = "0x2B22E10", VA = "0x182B24210", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B24480", Offset = "0x2B23080", VA = "0x182B24480", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public BURBBHTOTEG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool BGRSASFVZVT;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public XKXJREZMWEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B335D0", Offset = "0x2B321D0", VA = "0x182B335D0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task PIBVEDCCKAQ(SZNXFZCEGDW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class MLTHIYPQCOI
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
				public MLTHIYPQCOI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x2B244E0", Offset = "0x2B230E0", VA = "0x182B244E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x2B247C0", Offset = "0x2B233C0", VA = "0x182B247C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public BURBBHTOTEG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int BGRSASFVZVT;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public MLTHIYPQCOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C3C0", Offset = "0x2B1AFC0", VA = "0x182B1C3C0")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task BSJIPVZRAKO(SZNXFZCEGDW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class TBMIUWRZTOR
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
				public TBMIUWRZTOR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x2B24D30", Offset = "0x2B23930", VA = "0x182B24D30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B251E0", Offset = "0x2B23DE0", VA = "0x182B251E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string BGRSASFVZVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public BURBBHTOTEG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int GBXQMFXRHJJ;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public TBMIUWRZTOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B20330", Offset = "0x2B1EF30", VA = "0x182B20330")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task WNUAAAFYTEE(SZNXFZCEGDW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class YOJQYAVUVKO
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
				public YOJQYAVUVKO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B24820", Offset = "0x2B23420", VA = "0x182B24820", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B24CD0", Offset = "0x2B238D0", VA = "0x182B24CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string BGRSASFVZVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public BURBBHTOTEG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int GBXQMFXRHJJ;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public YOJQYAVUVKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B36000", Offset = "0x2B34C00", VA = "0x182B36000")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task DKDVXYMXEGU(SZNXFZCEGDW a)
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
			public BURBBHTOTEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2B23080", Offset = "0x2B21C80", VA = "0x182B23080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B23580", Offset = "0x2B22180", VA = "0x182B23580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly RGFQHCKBATZ DIXKMAZENPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<YRBFQITLNZF> STFWQWYSWLG;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private HAHYOVHKCDQ BLFMBBVUXNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B15A20", Offset = "0x2B14620", VA = "0x182B15A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<YGYJAOJPYZV> PTRQGJTXVWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE06CD0", Offset = "0xE058D0", VA = "0x180E06CD0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YGYJAOJPYZV>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xF09970", Offset = "0xF08570", VA = "0x180F09970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<THUAKEIUEGQ> JNSRAYOIGMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1600", Offset = "0x2AB0200", VA = "0x182AB1600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<CCKCDLBLEMF> ZWZXQRXMJPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1290B00", Offset = "0x128F700", VA = "0x181290B00", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<CCKCDLBLEMF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<ODUYWEZJSCU> TLWCVAMIDZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B170B0", Offset = "0x2B15CB0", VA = "0x182B170B0", Slot = "22")]
			get
			{
				return default(Id32<ODUYWEZJSCU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool HASDETSUXTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B188B0", Offset = "0x2B174B0", VA = "0x182B188B0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B18D40", Offset = "0x2B17940", VA = "0x182B18D40")]
		private BURBBHTOTEG(XXEAPKVABFJ a, KTFAJFRQMLO b, RGFQHCKBATZ c, Id32<BNOAYSCHUMT> portGroupId, Id32<YGYJAOJPYZV> inputId, Id32<THUAKEIUEGQ> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B161C0", Offset = "0x2B14DC0", VA = "0x182B161C0")]
		public static BURBBHTOTEG New(XXEAPKVABFJ circuitsManager, KTFAJFRQMLO node, RGFQHCKBATZ input, Id32<BNOAYSCHUMT> portGroupId, Id32<THUAKEIUEGQ> inputDefId, Id32<YGYJAOJPYZV> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B15980", Offset = "0x2B14580", VA = "0x182B15980", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B152B0", Offset = "0x2B13EB0", VA = "0x182B152B0", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B15CD0", Offset = "0x2B148D0", VA = "0x182B15CD0", Slot = "32")]
		public void MIIBBIQYSAN(YRBFQITLNZF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B15E00", Offset = "0x2B14A00", VA = "0x182B15E00", Slot = "29")]
		public void NEBTPWZXCLI(LLNJZDYWOIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B174F0", Offset = "0x2B160F0", VA = "0x182B174F0", Slot = "30")]
		public void WEDUMPUXOZH(YIWDQFVMFNV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B16560", Offset = "0x2B15160", VA = "0x182B16560", Slot = "25")]
		protected override void PAEETNJFKXT(ORBNQOVUKDU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B18740", Offset = "0x2B17340", VA = "0x182B18740", Slot = "34")]
		public string XAMGZYOHEAW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B18480", Offset = "0x2B17080", VA = "0x182B18480", Slot = "31")]
		public string WPTUOWAFTPA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B15090", Offset = "0x2B13C90", VA = "0x182B15090")]
		private void DYSLIXKVTKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B17100", Offset = "0x2B15D00", VA = "0x182B17100", Slot = "33")]
		public void TZFWVUULIWY(YRBFQITLNZF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B17330", Offset = "0x2B15F30", VA = "0x182B17330")]
		private void WCPBNSOIXGF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B16FA0", Offset = "0x2B15BA0", VA = "0x182B16FA0", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task SYPWUWBZUCF(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B15A40", Offset = "0x2B14640", VA = "0x182B15A40")]
		public void KRBWUENOFPK(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B157E0", Offset = "0x2B143E0", VA = "0x182B157E0")]
		private void GJZYNKSKENY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B16DE0", Offset = "0x2B159E0", VA = "0x182B16DE0")]
		private void SCMOVDLTNEM(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B14ED0", Offset = "0x2B13AD0", VA = "0x182B14ED0")]
		private void ARKOOWYUXRV(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B15B90", Offset = "0x2B14790", VA = "0x182B15B90")]
		private string KXTGYENIFKA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B171C0", Offset = "0x2B15DC0", VA = "0x182B171C0")]
		private string VRJWGNSNINT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF09970", Offset = "0xF08570", VA = "0x180F09970")]
		internal void OGBIWFBZQTE(Id32<YGYJAOJPYZV> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B16B90", Offset = "0x2B15790", VA = "0x182B16B90")]
		[CompilerGenerated]
		private void RNMYDLJEKJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B16AD0", Offset = "0x2B156D0", VA = "0x182B16AD0")]
		[CompilerGenerated]
		private bool RNHRGEPHAYO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B16A10", Offset = "0x2B15610", VA = "0x182B16A10")]
		[CompilerGenerated]
		private bool RMXDLRBMIBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B15570", Offset = "0x2B14170", VA = "0x182B15570")]
		[CompilerGenerated]
		private int ROHZSMKTWDH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B16C70", Offset = "0x2B15870", VA = "0x182B16C70")]
		[CompilerGenerated]
		private bool ROCSVFQWMRY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B16C60", Offset = "0x2B15860", VA = "0x182B16C60")]
		[CompilerGenerated]
		private void RNXLXYWZDGP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B16BA0", Offset = "0x2B157A0", VA = "0x182B16BA0")]
		[CompilerGenerated]
		private bool RNSFASDBTVG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B16D90", Offset = "0x2B15990", VA = "0x182B16D90")]
		[CompilerGenerated]
		private bool RPDBHNMJHWR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B16D00", Offset = "0x2B15900", VA = "0x182B16D00")]
		[CompilerGenerated]
		private bool ROXUKGSLYLI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B15570", Offset = "0x2B14170", VA = "0x182B15570")]
		[CompilerGenerated]
		private int FFZTJLPKGWO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B155C0", Offset = "0x2B141C0", VA = "0x182B155C0")]
		[CompilerGenerated]
		private bool FGFAGSJHQHX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B154B0", Offset = "0x2B140B0", VA = "0x182B154B0")]
		[CompilerGenerated]
		private object FFPFOYBPNZW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B15510", Offset = "0x2B14110", VA = "0x182B15510")]
		[CompilerGenerated]
		private void FFUMMEVMXLF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B153E0", Offset = "0x2B13FE0", VA = "0x182B153E0")]
		[CompilerGenerated]
		private bool FFJYRRHSEON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B15350", Offset = "0x2B13F50", VA = "0x182B15350")]
		[CompilerGenerated]
		private string FEUDZXAACGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B153D0", Offset = "0x2B13FD0", VA = "0x182B153D0")]
		[CompilerGenerated]
		private void FEZKXDTXLRV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B15690", Offset = "0x2B14290", VA = "0x182B15690")]
		[CompilerGenerated]
		private bool FHPWNNSPEJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B15760", Offset = "0x2B14360", VA = "0x182B15760")]
		[CompilerGenerated]
		private string FHVDKUMMNUR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B18A90", Offset = "0x2B17690", VA = "0x182B18A90")]
		[CompilerGenerated]
		private void YFIOKTHHREF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B189C0", Offset = "0x2B175C0", VA = "0x182B189C0")]
		[CompilerGenerated]
		private bool YFDHNMNKHSW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B18940", Offset = "0x2B17540", VA = "0x182B18940")]
		[CompilerGenerated]
		private string YEYAQFTMYHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B18930", Offset = "0x2B17530", VA = "0x182B18930")]
		[CompilerGenerated]
		private void YESTSYZPOWE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B18BF0", Offset = "0x2B177F0", VA = "0x182B18BF0")]
		[CompilerGenerated]
		private bool YGDPZUIXCXP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B18B80", Offset = "0x2B17780", VA = "0x182B18B80")]
		[CompilerGenerated]
		private string YFYJCNOZTMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B18B70", Offset = "0x2B17770", VA = "0x182B18B70")]
		[CompilerGenerated]
		private void YFTCFGVCKAX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B18AA0", Offset = "0x2B176A0", VA = "0x182B18AA0")]
		[CompilerGenerated]
		private bool YFNVIABFAPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B18CD0", Offset = "0x2B178D0", VA = "0x182B18CD0")]
		[CompilerGenerated]
		private string YGYROVKMOQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B18CC0", Offset = "0x2B178C0", VA = "0x182B18CC0")]
		[CompilerGenerated]
		private void YGTKROQPFFQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B16640", Offset = "0x2B15240", VA = "0x182B16640")]
		[CompilerGenerated]
		private bool RERJMAZFBLW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B16710", Offset = "0x2B15310", VA = "0x182B16710")]
		[CompilerGenerated]
		private string REWQJHTCKXF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B16780", Offset = "0x2B15380", VA = "0x182B16780")]
		[CompilerGenerated]
		private void RFBXGOMZUIO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B16790", Offset = "0x2B15390", VA = "0x182B16790")]
		[CompilerGenerated]
		private bool RFHEDVGXDTX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B16860", Offset = "0x2B15460", VA = "0x182B16860")]
		[CompilerGenerated]
		private string RFMLBCAUNFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B168D0", Offset = "0x2B154D0", VA = "0x182B168D0")]
		[CompilerGenerated]
		private void RFRRYIURWQP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B168E0", Offset = "0x2B154E0", VA = "0x182B168E0")]
		[CompilerGenerated]
		private bool RFWYVPOPGBY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B169B0", Offset = "0x2B155B0", VA = "0x182B169B0")]
		[CompilerGenerated]
		private object RGCFSWIMPNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B15510", Offset = "0x2B14110", VA = "0x182B15510")]
		[CompilerGenerated]
		private void RGHMQDCJYYQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B15D30", Offset = "0x2B14930", VA = "0x182B15D30")]
		[CompilerGenerated]
		private bool NCXGZISDFOX()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class SVKCKVNUKXG
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class WWHYTVBDBUE : TCDLISVYSIA<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public WWHYTVBDBUE DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B460", Offset = "0x2B1A060", VA = "0x182B1B460")]
				internal object VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B4C0", Offset = "0x2B1A0C0", VA = "0x182B1B4C0")]
				internal void VPCSDYEVDWN(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2B33380", Offset = "0x2B31F80", VA = "0x182B33380")]
			public WWHYTVBDBUE(XXEAPKVABFJ a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x2B33110", Offset = "0x2B31D10", VA = "0x182B33110", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class ZCNZVCSNFXT : KNJJYDUMGUT<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType MZMMVWGOQKQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2B365E0", Offset = "0x2B351E0", VA = "0x182B365E0")]
			public ZCNZVCSNFXT(XXEAPKVABFJ a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class BGWGFKGIDRD : TCDLISVYSIA<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2B14A80", Offset = "0x2B13680", VA = "0x182B14A80")]
			public BGWGFKGIDRD(XXEAPKVABFJ a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2B14920", Offset = "0x2B13520", VA = "0x182B14920", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2B147A0", Offset = "0x2B133A0", VA = "0x182B147A0")]
			[CompilerGenerated]
			private bool FJKYROBAVTQ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2B147F0", Offset = "0x2B133F0", VA = "0x182B147F0")]
			[CompilerGenerated]
			private void FJQFOUUYFEZ(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class TRARJEMBTMF : TCDLISVYSIA<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public TRARJEMBTMF DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B2D0", Offset = "0x2B19ED0", VA = "0x182B1B2D0")]
				internal void VOXLGRKXULE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B7E0", Offset = "0x2B1A3E0", VA = "0x182B1B7E0")]
				internal bool VPCSDYEVDWN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AF60", Offset = "0x2B19B60", VA = "0x182B1AF60")]
				internal bool VOMXMDXDBOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B150", Offset = "0x2B19D50", VA = "0x182B1B150")]
				internal void VOSEJKRAKZV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AEC0", Offset = "0x2B19AC0", VA = "0x182B1AEC0")]
				internal bool VOCJRQJIIRU()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2B20710", Offset = "0x2B1F310", VA = "0x182B20710")]
			public TRARJEMBTMF(XXEAPKVABFJ a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2B20400", Offset = "0x2B1F000", VA = "0x182B20400", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class DOONASCBZVH : TCDLISVYSIA<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public DOONASCBZVH DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> QKMPXLJQQQM;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B370", Offset = "0x2B19F70", VA = "0x182B1B370")]
				internal object? VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1ADD0", Offset = "0x2B199D0", VA = "0x182B1ADD0")]
				internal bool VNXCUJPKZGL(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B590", Offset = "0x2B1A190", VA = "0x182B1B590")]
				internal void VPCSDYEVDWN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B000", Offset = "0x2B19C00", VA = "0x182B1B000")]
				internal string VOMXMDXDBOM(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B280", Offset = "0x2B19E80", VA = "0x182B1B280")]
				internal IReadOnlyList<object> VOSEJKRAKZV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AE50", Offset = "0x2B19A50", VA = "0x182B1AE50")]
				internal bool VOCJRQJIIRU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AF10", Offset = "0x2B19B10", VA = "0x182B1AF10")]
				internal bool VOHQOXDFSDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x2B1ACA0", Offset = "0x2B198A0", VA = "0x182B1ACA0")]
				internal void VNRVXCVNPVC(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A430", Offset = "0x2B19030", VA = "0x182B1A430")]
			public DOONASCBZVH(XXEAPKVABFJ a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2B19D40", Offset = "0x2B18940", VA = "0x182B19D40", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class KEJOUWTZCUE : TCDLISVYSIA<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public KEJOUWTZCUE DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B320", Offset = "0x2B19F20", VA = "0x182B1B320")]
				internal bool VOXLGRKXULE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B830", Offset = "0x2B1A430", VA = "0x182B1B830")]
				internal void VPCSDYEVDWN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AFB0", Offset = "0x2B19BB0", VA = "0x182B1AFB0")]
				internal bool VOMXMDXDBOM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C070", Offset = "0x2B1AC70", VA = "0x182B1C070")]
			public KEJOUWTZCUE(XXEAPKVABFJ a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BE60", Offset = "0x2B1AA60", VA = "0x182B1BE60", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class YJFQXDSIKBX : TCDLISVYSIA<XFTJOWLBHXA>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class WLUGBDBSDJT
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
					public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public WLUGBDBSDJT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<BYAWOSQMXDX>, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2B239C0", Offset = "0x2B225C0", VA = "0x182B239C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2B23DA0", Offset = "0x2B229A0", VA = "0x182B23DA0", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public WLUGBDBSDJT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x2B23E10", Offset = "0x2B22A10", VA = "0x182B23E10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x2B241A0", Offset = "0x2B22DA0", VA = "0x182B241A0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task NBLGDMZZJED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string LINDAWWSHDX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public MNKEWZIOFVL.NQKMGIVLPWH SLXCXYNVCRW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool YEBCZGPUAXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public YJFQXDSIKBX DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public MNKEWZIOFVL QVGVYCKIBBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action CTXUNVLXPCK;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public WLUGBDBSDJT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2B32EF0", Offset = "0x2B31AF0", VA = "0x182B32EF0")]
				internal bool WVMQBZCCVSE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
				internal string WSYLNHJDTIZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x2B32E20", Offset = "0x2B31A20", VA = "0x182B32E20")]
				internal void WSIQVNBLRAY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2B32EA0", Offset = "0x2B31AA0", VA = "0x182B32EA0")]
				internal void WSNXSTVJAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x160AE20", Offset = "0x1609A20", VA = "0x18160AE20")]
				internal bool WRYDAZNQYEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2B32C00", Offset = "0x2B31800", VA = "0x182B32C00")]
				internal void WSDJYGHOHPP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2B32BC0", Offset = "0x2B317C0", VA = "0x182B32BC0")]
				internal bool WRNPGLZWFHO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x2B32F20", Offset = "0x2B31B20", VA = "0x182B32F20")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, LYQWSZGLQZW>> YCFZTMITSUW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x2B32AD0", Offset = "0x2B316D0", VA = "0x182B32AD0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, LYQWSZGLQZW>> RIFVAOKMZQT()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class QWQABXVDRJP
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
					public AsyncTaskMethodBuilder<Result<Id32<BYAWOSQMXDX>, LYQWSZGLQZW>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<BYAWOSQMXDX>, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x2B235E0", Offset = "0x2B221E0", VA = "0x182B235E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x2B23950", Offset = "0x2B22550", VA = "0x182B23950", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public YJFQXDSIKBX DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public ZEQAUYTRFYT AOAUKXQAORE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool GDFCYQZVZTU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public MNKEWZIOFVL QVGVYCKIBBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public EVUOQCSWTPL HWXPXBHUQRO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action QLXMEGSYERX;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QWQABXVDRJP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E560", Offset = "0x2B1D160", VA = "0x182B1E560")]
				internal object? VPCSDYEVDWN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E380", Offset = "0x2B1CF80", VA = "0x182B1E380")]
				internal void VOMXMDXDBOM(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E470", Offset = "0x2B1D070", VA = "0x182B1E470")]
				internal string VOSEJKRAKZV(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E180", Offset = "0x2B1CD80", VA = "0x182B1E180")]
				internal IReadOnlyList<object> VOCJRQJIIRU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E220", Offset = "0x2B1CE20", VA = "0x182B1E220")]
				internal void VOHQOXDFSDD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E050", Offset = "0x2B1CC50", VA = "0x182B1E050")]
				internal bool VNRVXCVNPVC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E0C0", Offset = "0x2B1CCC0", VA = "0x182B1E0C0")]
				internal void VNXCUJPKZGL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DF80", Offset = "0x2B1CB80", VA = "0x182B1DF80")]
				internal void VNHICPHSWYK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DFD0", Offset = "0x2B1CBD0", VA = "0x182B1DFD0")]
				internal void VNMOZWBQGJT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DF20", Offset = "0x2B1CB20", VA = "0x182B1DF20")]
				internal bool QJBGITFPLML()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DE30", Offset = "0x2B1CA30", VA = "0x182B1DE30")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<BYAWOSQMXDX>, LYQWSZGLQZW>> BHDHFXMFJRB()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<GNQADATMYDH>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x2B35FC0", Offset = "0x2B34BC0", VA = "0x182B35FC0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2B35F50", Offset = "0x2B34B50", VA = "0x182B35F50")]
			public YJFQXDSIKBX(XXEAPKVABFJ a, XFTJOWLBHXA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2B34F30", Offset = "0x2B33B30", VA = "0x182B34F30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2B358C0", Offset = "0x2B344C0", VA = "0x182B358C0")]
			private void WJDRCZEVXBG(MNKEWZIOFVL a, Id32<BYAWOSQMXDX>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class GITTITRFQZW : QGPHXRWTWSX<UYMLENSMZSR>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1F4D3E0", Offset = "0x1F4BFE0", VA = "0x181F4D3E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool PSTAQOPBTPN
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool DCENTTTDRTI
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool HALMWIIVEIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A9F0", Offset = "0x2B195F0", VA = "0x182B1A9F0")]
			public GITTITRFQZW(XXEAPKVABFJ a, UYMLENSMZSR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class GUTZLGQLIKS<a> : TCDLISVYSIA<a> where a : notnull, ZJAQHOFZUKO
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
				public AsyncTaskMethodBuilder<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public GUTZLGQLIKS<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x64CCFB0", Offset = "0x64CBBB0", VA = "0x1864CCFB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x64CD300", Offset = "0x64CBF00", VA = "0x1864CD300", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public GUTZLGQLIKS<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<BNOAYSCHUMT> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6A97370", Offset = "0x6A95F70", VA = "0x186A97370", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x6A976C0", Offset = "0x6A962C0", VA = "0x186A976C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<BNOAYSCHUMT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x63DF990", Offset = "0x63DE590", VA = "0x1863DF990", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x63DF960", Offset = "0x63DE560", VA = "0x1863DF960")]
			protected GUTZLGQLIKS(XXEAPKVABFJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x63DF550", Offset = "0x63DE150", VA = "0x1863DF550", Slot = "122")]
			[AsyncStateMachine(typeof(GUTZLGQLIKS<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> ASXFQEVLWTB(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x63DF820", Offset = "0x63DE420", VA = "0x1863DF820", Slot = "149")]
			public sealed override bool UHTRHCFSMMC(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x63DF670", Offset = "0x63DE270", VA = "0x1863DF670", Slot = "134")]
			protected sealed override bool MBXSZUZYXXW(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x63DF8C0", Offset = "0x63DE4C0", VA = "0x1863DF8C0", Slot = "135")]
			protected override bool VJIJKMPWYXZ(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x63DF710", Offset = "0x63DE310", VA = "0x1863DF710", Slot = "123")]
			[AsyncStateMachine(typeof(GUTZLGQLIKS<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, LYQWSZGLQZW>> ORXSIYCZEWW(Id32<BNOAYSCHUMT> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class YQJIRLRJICH : RVCQXCJMDWQ<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public YQJIRLRJICH DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x2B1ABA0", Offset = "0x2B197A0", VA = "0x182B1ABA0")]
				internal bool KAUUERWXLRZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AAF0", Offset = "0x2B196F0", VA = "0x182B1AAF0")]
				internal void KAPNHLDACGQ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2B36310", Offset = "0x2B34F10", VA = "0x182B36310")]
			public YQJIRLRJICH(XXEAPKVABFJ a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2B360D0", Offset = "0x2B34CD0", VA = "0x182B360D0", Slot = "151")]
			protected override void IRNAQBPVSIH(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class MMTHRWJOBNC : TCDLISVYSIA<KLOJSDZDWXT>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class LZUZORPWDSO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int VNVJKGCIPXR;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LZUZORPWDSO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C300", Offset = "0x2B1AF00", VA = "0x182B1C300")]
				internal bool IDMPFJBBQTZ(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class YYTPHXDUXQN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public MMTHRWJOBNC DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> IINFWPTSFCH;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public YYTPHXDUXQN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2B36420", Offset = "0x2B35020", VA = "0x182B36420")]
				internal int VOXLGRKXULE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x2B364C0", Offset = "0x2B350C0", VA = "0x182B364C0")]
				internal void VPCSDYEVDWN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x2B36370", Offset = "0x2B34F70", VA = "0x182B36370")]
				internal string? VOMXMDXDBOM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C990", Offset = "0x2B1B590", VA = "0x182B1C990")]
			public MMTHRWJOBNC(XXEAPKVABFJ a, KLOJSDZDWXT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C490", Offset = "0x2B1B090", VA = "0x182B1C490")]
			private int NTABHEPYLJV(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C870", Offset = "0x2B1B470", VA = "0x182B1C870")]
			private void VCLZIJQKIUP(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C520", Offset = "0x2B1B120", VA = "0x182B1C520", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class JCJQEHOMZFK : QGPHXRWTWSX<VOBYZHJAVHP>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BE00", Offset = "0x2B1AA00", VA = "0x182B1BE00")]
			public JCJQEHOMZFK(XXEAPKVABFJ a, VOBYZHJAVHP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class QGPHXRWTWSX<a> : TCDLISVYSIA<a> where a : notnull, MGUSFDEEFIF
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class LFGYZMWMHTR
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
					public LFGYZMWMHTR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x41C3420", Offset = "0x41C2020", VA = "0x1841C3420", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public MNKEWZIOFVL QVGVYCKIBBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public QGPHXRWTWSX<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action QKRWUSDOABV;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LFGYZMWMHTR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x686AA50", Offset = "0x6869650", VA = "0x18686AA50")]
				internal void VOXLGRKXULE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x686A9B0", Offset = "0x68695B0", VA = "0x18686A9B0")]
				[AsyncStateMachine(typeof(QGPHXRWTWSX<>.LFGYZMWMHTR.<<BuildConfigMenuInternal>b__6>d))]
				internal void VNRVXCVNPVC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x686AD20", Offset = "0x6869920", VA = "0x18686AD20")]
				internal bool VPCSDYEVDWN()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class LFBSCGCOYII
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
					public LFBSCGCOYII <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x41C3020", Offset = "0x41C1C20", VA = "0x1841C3020", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string UYUAMLXFETD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public LFGYZMWMHTR FWYXBYDFGWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> QJROIKIBEXC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> QLCKPFRISYN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action QKXDRYXLJNE;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LFBSCGCOYII()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x686A650", Offset = "0x6869250", VA = "0x18686A650")]
				internal void VOMXMDXDBOM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				internal string VOSEJKRAKZV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
				internal void VOCJRQJIIRU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x686A5B0", Offset = "0x68691B0", VA = "0x18686A5B0")]
				[AsyncStateMachine(typeof(QGPHXRWTWSX<>.LFBSCGCOYII.<<BuildConfigMenuInternal>b__5>d))]
				internal void VOHQOXDFSDD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class PVEMMDQTAIS
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
					public PVEMMDQTAIS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<LOGOYWSDYON>, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x41C07C0", Offset = "0x41BF3C0", VA = "0x1841C07C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public PVEMMDQTAIS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x41C0F00", Offset = "0x41BFB00", VA = "0x1841C0F00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public PVEMMDQTAIS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<THUAKEIUEGQ>, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x41C10E0", Offset = "0x41BFCE0", VA = "0x1841C10E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public QGPHXRWTWSX<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<BNOAYSCHUMT> OOKLYEKYKFV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public MNKEWZIOFVL QVGVYCKIBBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public KYCFNPVYGVL LDSWMPHVBKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int TZKPJZRGHPT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int PYCFFGBQNFR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public GVQMAXHLXBC GHEYDMWDBET;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string CILPZVQFEYE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<QNHHNFLUXCI> DFSVWIZIAOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public GVQMAXHLXBC HDOODMANVUE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string DEGKXHGHDJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<QNHHNFLUXCI> DDBBBDCXAVA;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public PVEMMDQTAIS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x73D2B30", Offset = "0x73D1730", VA = "0x1873D2B30")]
				internal bool MEXQDLXWPQR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x73D2AC0", Offset = "0x73D16C0", VA = "0x1873D2AC0")]
				internal void MESJGFDZGFI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x73D2D30", Offset = "0x73D1930", VA = "0x1873D2D30")]
				internal bool QSXHRQYANKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x73D2A20", Offset = "0x73D1620", VA = "0x1873D2A20")]
				[AsyncStateMachine(typeof(QGPHXRWTWSX<>.PVEMMDQTAIS.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void MENCIYKBWTZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x73D29E0", Offset = "0x73D15E0", VA = "0x1873D29E0")]
				internal bool MEHVLRQENIQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x73D2E70", Offset = "0x73D1A70", VA = "0x1873D2E70")]
				internal void QTSJGRZPZED()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x73D2BA0", Offset = "0x73D17A0", VA = "0x1873D2BA0")]
				internal bool QRMLKVOSZJI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x73D2C50", Offset = "0x73D1850", VA = "0x1873D2C50")]
				internal void QRRSICIQIUR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x73D2670", Offset = "0x73D1270", VA = "0x1873D2670")]
				internal bool JSLJQFJVHDT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x73D2970", Offset = "0x73D1570", VA = "0x1873D2970")]
				internal bool MECOOKWHDXH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x73D2900", Offset = "0x73D1500", VA = "0x1873D2900")]
				internal void MDXHRECJULY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x73D2860", Offset = "0x73D1460", VA = "0x1873D2860")]
				[AsyncStateMachine(typeof(QGPHXRWTWSX<>.PVEMMDQTAIS.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void MDSATXIMLAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x73D2800", Offset = "0x73D1400", VA = "0x1873D2800")]
				internal bool MDMTWQOPBPG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x73D2790", Offset = "0x73D1390", VA = "0x1873D2790")]
				internal bool MDHMZJURSDX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x73D2720", Offset = "0x73D1320", VA = "0x1873D2720")]
				internal void MDCGCDAUISO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x73D2D70", Offset = "0x73D1970", VA = "0x1873D2D70")]
				[AsyncStateMachine(typeof(QGPHXRWTWSX<>.PVEMMDQTAIS.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void QTCOOXRXWWC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x73D2E10", Offset = "0x73D1A10", VA = "0x1873D2E10")]
				internal bool QTHVMELVGHL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class PVJTJKKQJUB
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
					public PVJTJKKQJUB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x41C0AB0", Offset = "0x41BF6B0", VA = "0x1841C0AB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string VGZUXWTJQFD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public PVEMMDQTAIS FWYXBYDFGWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> JQFTQQPTVPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> JQLANXJRFAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action JPVFWDBZCSM;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public PVJTJKKQJUB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x73D2F50", Offset = "0x73D1B50", VA = "0x1873D2F50")]
				internal void QSSAUKEDDZK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				internal string QTXQDYTNIPM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
				internal void QUCXBFNKSAV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x73D32B0", Offset = "0x73D1EB0", VA = "0x1873D32B0")]
				[AsyncStateMachine(typeof(QGPHXRWTWSX<>.PVJTJKKQJUB.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void QTNCJLFSPSU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class LBSQFYZEUKB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool DFSVWIZIAOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public KYCFNPVYGVL LDSWMPHVBKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<QNHHNFLUXCI> UZVIRYQZQOY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public QGPHXRWTWSX<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<BNOAYSCHUMT> OOKLYEKYKFV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int VTQUAOQSQOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> QKCCCXVVXTU;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LBSQFYZEUKB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x6865170", Offset = "0x6863D70", VA = "0x186865170")]
				internal bool VDSESQPQOQD()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class LBNJISFHKYS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public WSYNBUDJKHM MKFGRKMLJWD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public LBSQFYZEUKB FWYXBYDFGWV;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LBNJISFHKYS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x6864DC0", Offset = "0x68639C0", VA = "0x186864DC0")]
				internal void VDXLPXJNYBM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x6864F30", Offset = "0x6863B30", VA = "0x186864F30")]
				internal bool VECSNEDLHMV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x6864F80", Offset = "0x6863B80", VA = "0x186864F80")]
				internal void VEHZKKXIQYE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x6865110", Offset = "0x6863D10", VA = "0x186865110")]
				internal bool VENGHRRGAJN()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class LBICLLLKBNJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public QNHHNFLUXCI SIXODBZSJAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public LBNJISFHKYS FWJCKDVNEOU;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LBICLLLKBNJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x6864B90", Offset = "0x6863790", VA = "0x186864B90")]
				internal void VDMXVJVTFEU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class GILYMGREUCQ
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
					public GILYMGREUCQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x41C42A0", Offset = "0x41C2EA0", VA = "0x1841C42A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> NHOSMTSGLFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public GVQMAXHLXBC DZKLLJHWSTL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool DFSVWIZIAOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public KYCFNPVYGVL LDSWMPHVBKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public WSYNBUDJKHM MKFGRKMLJWD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string VGZUXWTJQFD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public GILYMGREUCQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x636F0C0", Offset = "0x636DCC0", VA = "0x18636F0C0")]
				internal int UNIYKMJDKAO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x636F100", Offset = "0x636DD00", VA = "0x18636F100")]
				internal void UNOFHTDATLX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
				internal string UMYKPYVIRDW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x636F000", Offset = "0x636DC00", VA = "0x18636F000")]
				[AsyncStateMachine(typeof(QGPHXRWTWSX<>.GILYMGREUCQ.<<CreatePortItemV2>b__3>d))]
				internal void UNDRNFPGAPF(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public QGPHXRWTWSX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x64CCB90", Offset = "0x64CB790", VA = "0x1864CCB90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x64CCF40", Offset = "0x64CBB40", VA = "0x1864CCF40", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public QGPHXRWTWSX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<BNOAYSCHUMT> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x6A97730", Offset = "0x6A96330", VA = "0x186A97730", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x6A97AC0", Offset = "0x6A966C0", VA = "0x186A97AC0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public QGPHXRWTWSX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x6B1E480", Offset = "0x6B1D080", VA = "0x186B1E480", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x6B1EA20", Offset = "0x6B1D620", VA = "0x186B1EA20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<BNOAYSCHUMT>, bool> BCTTZFAVJDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<BNOAYSCHUMT>, bool> APGQWIXYCKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<BNOAYSCHUMT>, bool> WASBARZTFKS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<BNOAYSCHUMT>, bool> ZDWZPRSDTYB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<BNOAYSCHUMT>, bool> BUOVDAVYOHV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<BNOAYSCHUMT>, bool> JZHYWCUUNJK;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool PSTAQOPBTPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool DCENTTTDRTI
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool HALMWIIVEIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<GNQADATMYDH>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x7632FA0", Offset = "0x7631BA0", VA = "0x187632FA0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<BNOAYSCHUMT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x7633210", Offset = "0x7631E10", VA = "0x187633210", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<NYBQVHGBIMX>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x7633020", Offset = "0x7631C20", VA = "0x187633020", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x7632DD0", Offset = "0x76319D0", VA = "0x187632DD0")]
			public QGPHXRWTWSX(XXEAPKVABFJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "154")]
			protected virtual bool LZPCPNRDSJE(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "155")]
			protected virtual bool XZZRUTEKGXH(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "156")]
			protected virtual bool BWHVIQCZCZK(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "157")]
			protected virtual void OTLFQCOKUSG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x7632760", Offset = "0x7631360", VA = "0x187632760", Slot = "149")]
			public override bool UHTRHCFSMMC(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x762E470", Offset = "0x762D070", VA = "0x18762E470", Slot = "122")]
			[AsyncStateMachine(typeof(QGPHXRWTWSX<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> ASXFQEVLWTB(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x7632650", Offset = "0x7631250", VA = "0x187632650", Slot = "123")]
			[AsyncStateMachine(typeof(QGPHXRWTWSX<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, LYQWSZGLQZW>> ORXSIYCZEWW(Id32<BNOAYSCHUMT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7631B20", Offset = "0x7630720", VA = "0x187631B20", Slot = "124")]
			public override void KQERDJXKSJE(Id32<BNOAYSCHUMT> index, Id32<BNOAYSCHUMT> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7632B80", Offset = "0x7631780", VA = "0x187632B80", Slot = "125")]
			public override IEnumerable<FXFJUDAMIWO> YFWUOVWSJNT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x7632800", Offset = "0x7631400", VA = "0x187632800")]
			[AsyncStateMachine(typeof(QGPHXRWTWSX<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, LYQWSZGLQZW>> VZYZWISIAJS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "158")]
			protected virtual bool CUVGSMHVZVT(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "159")]
			protected virtual bool OLRVTNSEGWB(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "160")]
			protected virtual bool OPTVLQMMWXS(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "161")]
			protected virtual bool INHYGHNEDCO(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "162")]
			protected virtual bool KITLLHVKGXK(Id32<BNOAYSCHUMT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "163")]
			protected virtual bool ALARLEKYVYB(Id32<BNOAYSCHUMT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "164")]
			protected virtual bool DMDUVWAKDHJ(Id32<BNOAYSCHUMT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "165")]
			protected virtual bool WUKRUUBHCQY(Id32<BNOAYSCHUMT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "166")]
			protected virtual bool HJQQDNELYVW(Id32<BNOAYSCHUMT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "167")]
			protected virtual bool ZSKGUTJWNGD(Id32<BNOAYSCHUMT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7632900", Offset = "0x7631500", VA = "0x187632900", Slot = "168")]
			protected virtual List<GVQMAXHLXBC> XUJPIBHMDFV(Id32<BNOAYSCHUMT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "169")]
			protected virtual void COTCTZVGWGA(MNKEWZIOFVL a, XVJZGXTRVOP b, KYCFNPVYGVL c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7631CB0", Offset = "0x76308B0", VA = "0x187631CB0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x762FF80", Offset = "0x762EB80", VA = "0x18762FF80")]
			private XVJZGXTRVOP GZYOJBAAWLT(MNKEWZIOFVL a, KYCFNPVYGVL b, Id32<BNOAYSCHUMT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x762E590", Offset = "0x762D190", VA = "0x18762E590")]
			private List<QNHHNFLUXCI> EIHGUPCTQCS(MNKEWZIOFVL a, KYCFNPVYGVL b, XVJZGXTRVOP c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x762F5F0", Offset = "0x762E1F0", VA = "0x18762F5F0")]
			private List<QNHHNFLUXCI> FGAXBBFLAVO(MNKEWZIOFVL a, KYCFNPVYGVL b, WSYNBUDJKHM c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7631930", Offset = "0x7630530", VA = "0x187631930")]
			private GVQMAXHLXBC JEMUGDIKZHQ(List<GVQMAXHLXBC> a, WSYNBUDJKHM b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x76318D0", Offset = "0x76304D0", VA = "0x1876318D0")]
			[CompilerGenerated]
			private FXFJUDAMIWO IIOGXTKQTYE(KTFAJFRQMLO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class KLQBNLYFUWG : TCDLISVYSIA<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public KLQBNLYFUWG DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DD50", Offset = "0x2B1C950", VA = "0x182B1DD50")]
				internal int VOXLGRKXULE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DDA0", Offset = "0x2B1C9A0", VA = "0x182B1DDA0")]
				internal Task<bool> VPCSDYEVDWN(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C290", Offset = "0x2B1AE90", VA = "0x182B1C290")]
			public KLQBNLYFUWG(XXEAPKVABFJ a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C0E0", Offset = "0x2B1ACE0", VA = "0x182B1C0E0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class XPFLFQITTPE : RVCQXCJMDWQ<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public XPFLFQITTPE DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AC20", Offset = "0x2B19820", VA = "0x182B1AC20")]
				internal int KAUUERWXLRZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AA50", Offset = "0x2B19650", VA = "0x182B1AA50")]
				internal Task<bool> KAPNHLDACGQ(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2B338E0", Offset = "0x2B324E0", VA = "0x182B338E0")]
			public XPFLFQITTPE(XXEAPKVABFJ a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B336C0", Offset = "0x2B322C0", VA = "0x182B336C0", Slot = "151")]
			protected override void IRNAQBPVSIH(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class FSDGULRFVSM : TCDLISVYSIA<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xF1C560", Offset = "0xF1B160", VA = "0x180F1C560", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A630", Offset = "0x2B19230", VA = "0x182B1A630")]
			public FSDGULRFVSM(XXEAPKVABFJ a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class WEQWBDMGEWI : TCDLISVYSIA<KRTFKRGVEHH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class UFMXOEVUXJC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public WEQWBDMGEWI DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public MNKEWZIOFVL QVGVYCKIBBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> LPUQQVINIXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> LPPJTOOPZMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> LQPSFWKCURI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> LQKLIPQFLFZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> LQFELIWIBUQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> LRQASEFPPWB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> LRKTUXLSGKS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> EPISPJUICQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> EPNZMQOFMCH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> EPTGJXICVNQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> EPYNHECAEYZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> EQDUEKVXOKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> EQJBBRPUXVR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> EQOHYYJSHHA;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UFMXOEVUXJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2B30340", Offset = "0x2B2EF40", VA = "0x182B30340")]
				internal bool VOXLGRKXULE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2B30390", Offset = "0x2B2EF90", VA = "0x182B30390")]
				internal void VPCSDYEVDWN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2B302A0", Offset = "0x2B2EEA0", VA = "0x182B302A0")]
				internal bool VOCJRQJIIRU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2B302F0", Offset = "0x2B2EEF0", VA = "0x182B302F0")]
				internal bool VOHQOXDFSDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2B30240", Offset = "0x2B2EE40", VA = "0x182B30240")]
				internal void VNRVXCVNPVC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2B301F0", Offset = "0x2B2EDF0", VA = "0x182B301F0")]
				internal bool VNMOZWBQGJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F1C0", Offset = "0x2B2DDC0", VA = "0x182B2F1C0")]
				internal bool QJBGITFPLML()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F160", Offset = "0x2B2DD60", VA = "0x182B2F160")]
				internal void QIVZLMLSCBC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F0B0", Offset = "0x2B2DCB0", VA = "0x182B2F0B0")]
				internal bool QIGETSDZZTB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F060", Offset = "0x2B2DC60", VA = "0x182B2F060")]
				internal bool QIAXWLKCQHS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F100", Offset = "0x2B2DD00", VA = "0x182B2F100")]
				internal void QIQSOFRUSPT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F010", Offset = "0x2B2DC10", VA = "0x182B2F010")]
				internal bool QHFWHKINEOI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2B27000", Offset = "0x2B25C00", VA = "0x182B27000")]
				internal bool DGVTJPMVGER()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2B26FB0", Offset = "0x2B25BB0", VA = "0x182B26FB0")]
				internal bool DGQMMISXWTI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2B26F60", Offset = "0x2B25B60", VA = "0x182B26F60")]
				internal bool DGLFPBZANHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2B27150", Offset = "0x2B25D50", VA = "0x182B27150")]
				internal bool DJGYCSRPPKV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2B27100", Offset = "0x2B25D00", VA = "0x182B27100")]
				internal bool DJBRFLXSFZM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2B30540", Offset = "0x2B2F140", VA = "0x182B30540")]
				internal bool WGZPZYGICFS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2B30590", Offset = "0x2B2F190", VA = "0x182B30590")]
				internal bool WHEWXFAFLRB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2B305E0", Offset = "0x2B2F1E0", VA = "0x182B305E0")]
				internal void WHKDULUCVCK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2B27C40", Offset = "0x2B26840", VA = "0x182B27C40")]
				internal bool IMIZQCWTWFL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2B27BA0", Offset = "0x2B267A0", VA = "0x182B27BA0")]
				internal bool ILTEYIPBTXK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2B27BF0", Offset = "0x2B267F0", VA = "0x182B27BF0")]
				internal bool ILYLVPIZDIT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2B27B50", Offset = "0x2B26750", VA = "0x182B27B50")]
				internal bool ILNYBBVEKMB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2B27AB0", Offset = "0x2B266B0", VA = "0x182B27AB0")]
				internal bool IKYDJHNMIEA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2B30640", Offset = "0x2B2F240", VA = "0x182B30640")]
				internal bool WHPKRSOAENT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2B303F0", Offset = "0x2B2EFF0", VA = "0x182B303F0")]
				internal bool WGEOKXESQMI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2B30440", Offset = "0x2B2F040", VA = "0x182B30440")]
				internal void WGJVIDYPZXR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2B304A0", Offset = "0x2B2F0A0", VA = "0x182B304A0")]
				internal bool WGPCFKSNJJA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2B304F0", Offset = "0x2B2F0F0", VA = "0x182B304F0")]
				internal bool WGUJCRMKSUJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2B30690", Offset = "0x2B2F290", VA = "0x182B30690")]
				internal void WIPTEAJMZSM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2B306F0", Offset = "0x2B2F2F0", VA = "0x182B306F0")]
				internal bool WIVABHDKJDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2B270B0", Offset = "0x2B25CB0", VA = "0x182B270B0")]
				internal bool DHQUYQOKRYB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2B27050", Offset = "0x2B25C50", VA = "0x182B27050")]
				internal void DHLOBJUNIMS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2B29200", Offset = "0x2B27E00", VA = "0x182B29200")]
				internal List<QNHHNFLUXCI> PYCFZJKARKP(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2B27B00", Offset = "0x2B26700", VA = "0x182B27B00")]
				internal bool ILDKGOHJRPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2B279D0", Offset = "0x2B265D0", VA = "0x182B279D0")]
				internal int IKNPOTZRPHI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2B27A20", Offset = "0x2B26620", VA = "0x182B27A20")]
				internal Task<bool> IKSWMATOYSR(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2B28BE0", Offset = "0x2B277E0", VA = "0x182B28BE0")]
				internal bool PGILBFYFMNJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2B28B90", Offset = "0x2B27790", VA = "0x182B28B90")]
				internal bool PGDEDZEIDCA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2B28C80", Offset = "0x2B27880", VA = "0x182B28C80")]
				internal bool PGSYVTMAFKB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2B28C30", Offset = "0x2B27830", VA = "0x182B28C30")]
				internal int PGNRYMSCVYS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2B28D20", Offset = "0x2B27920", VA = "0x182B28D20")]
				internal Task<bool> PHDMQGZUYGT(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2B28CD0", Offset = "0x2B278D0", VA = "0x182B28CD0")]
				internal bool PGYFTAFXOVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2B28E00", Offset = "0x2B27A00", VA = "0x182B28E00")]
				internal bool PHOAKUNPRDL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2B28DB0", Offset = "0x2B279B0", VA = "0x182B28DB0")]
				internal bool PHITNNTSHSC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2B28E50", Offset = "0x2B27A50", VA = "0x182B28E50")]
				internal bool PHTHIBHNAOU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F9C0", Offset = "0x2B2E5C0", VA = "0x182B2F9C0")]
				internal bool VKTHITLRTFS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2B266D0", Offset = "0x2B252D0", VA = "0x182B266D0")]
				internal string CGKBKFVXBZT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2B26610", Offset = "0x2B25210", VA = "0x182B26610")]
				internal void CFUGSLOEZRS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2B267D0", Offset = "0x2B253D0", VA = "0x182B267D0")]
				internal int CHFCZGXMNTD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2B26720", Offset = "0x2B25320", VA = "0x182B26720")]
				internal void CGPIHMPULLC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2B26780", Offset = "0x2B25380", VA = "0x182B26780")]
				internal bool CGUPETJRUWL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2B26820", Offset = "0x2B25420", VA = "0x182B26820")]
				internal bool CHUXRBFEQBE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2B26870", Offset = "0x2B25470", VA = "0x182B26870")]
				internal bool CIAEOHZBZMN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2B27E00", Offset = "0x2B26A00", VA = "0x182B27E00")]
				internal float JGVZLRKCIGT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2B27DA0", Offset = "0x2B269A0", VA = "0x182B27DA0")]
				internal void JGQSOKQEYVK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2B27EA0", Offset = "0x2B26AA0", VA = "0x182B27EA0")]
				internal bool JHGNGEXXBDL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2B27E50", Offset = "0x2B26A50", VA = "0x182B27E50")]
				internal bool JHBGIYDZRSC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2B27CE0", Offset = "0x2B268E0", VA = "0x182B27CE0")]
				internal bool JGAXWQIMWNJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FAB0", Offset = "0x2B2E6B0", VA = "0x182B2FAB0")]
				internal bool VLDVDGZMMCK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FB50", Offset = "0x2B2E750", VA = "0x182B2FB50")]
				internal bool VLJCANTJVNT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FBF0", Offset = "0x2B2E7F0", VA = "0x182B2FBF0")]
				internal bool VLOIXUNHEZC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FCB0", Offset = "0x2B2E8B0", VA = "0x182B2FCB0")]
				internal void VLTPVBHEOKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2B27C90", Offset = "0x2B26890", VA = "0x182B27C90")]
				internal string JFVQZJOPNCA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2B27D30", Offset = "0x2B26930", VA = "0x182B27D30")]
				internal void JGLLRDWHPKB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2B30100", Offset = "0x2B2ED00", VA = "0x182B30100")]
				internal bool VLYWSIBBXVU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2B301A0", Offset = "0x2B2EDA0", VA = "0x182B301A0")]
				internal bool VMEDPOUZHHD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F5F0", Offset = "0x2B2E1F0", VA = "0x182B2F5F0")]
				internal bool VJDEERIMVSY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F640", Offset = "0x2B2E240", VA = "0x182B2F640")]
				internal void VJILBYCKFEH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2B26A60", Offset = "0x2B25660", VA = "0x182B26A60")]
				internal bool CLKMHLTUIYB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2B26A10", Offset = "0x2B25610", VA = "0x182B26A10")]
				internal bool CLFFKEZWZMS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2B269C0", Offset = "0x2B255C0", VA = "0x182B269C0")]
				internal bool CKZYMYFZQBJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2B26970", Offset = "0x2B25570", VA = "0x182B26970")]
				internal bool CKURPRMCGQA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2B26BA0", Offset = "0x2B257A0", VA = "0x182B26BA0")]
				internal void CMFNWMVJURL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2B26B50", Offset = "0x2B25750", VA = "0x182B26B50")]
				internal bool CMAGZGBMLGC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2B26B00", Offset = "0x2B25700", VA = "0x182B26B00")]
				internal bool CLVABZHPBUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2B26AB0", Offset = "0x2B256B0", VA = "0x182B26AB0")]
				internal bool CLPTESNRSJK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2B26920", Offset = "0x2B25520", VA = "0x182B26920")]
				internal bool CJUJDJQPLLH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2B268C0", Offset = "0x2B254C0", VA = "0x182B268C0")]
				internal void CJPCGCWSBZY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2B27430", Offset = "0x2B26030", VA = "0x182B27430")]
				internal bool HJKXLIVMNVA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2B27480", Offset = "0x2B26080", VA = "0x182B27480")]
				internal bool HJQEIPPJXGJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2B27390", Offset = "0x2B25F90", VA = "0x182B27390")]
				internal bool HJAJQVHRUYI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2B273E0", Offset = "0x2B25FE0", VA = "0x182B273E0")]
				internal bool HJFQOCBPEJR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2B274D0", Offset = "0x2B260D0", VA = "0x182B274D0")]
				internal object HJVLFWJHGRS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2B27540", Offset = "0x2B26140", VA = "0x182B27540")]
				internal void HKASDDDEQDB(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2B275D0", Offset = "0x2B261D0", VA = "0x182B275D0")]
				internal bool HLBAPKYRLHU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2B27620", Offset = "0x2B26220", VA = "0x182B27620")]
				internal bool HLGHMRSOUTD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2B287D0", Offset = "0x2B273D0", VA = "0x182B287D0")]
				internal int OJWVMUJRUCA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2B28870", Offset = "0x2B27470", VA = "0x182B28870")]
				internal void OKMQEORJWKB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2B286E0", Offset = "0x2B272E0", VA = "0x182B286E0")]
				internal bool OJBTXTICIIQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2B28730", Offset = "0x2B27330", VA = "0x182B28730")]
				internal bool OJROPNPUKQR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2B28A80", Offset = "0x2B27680", VA = "0x182B28A80")]
				internal int OLMYQWMWROU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2B28340", Offset = "0x2B26F40", VA = "0x182B28340")]
				internal void KMSTXLWDURD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2B282F0", Offset = "0x2B26EF0", VA = "0x182B282F0")]
				internal bool KMNNAFCGLFU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2B282A0", Offset = "0x2B26EA0", VA = "0x182B282A0")]
				internal bool KMIGCYIJBUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2B28250", Offset = "0x2B26E50", VA = "0x182B28250")]
				internal bool KMCZFROLSJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2B28200", Offset = "0x2B26E00", VA = "0x182B28200")]
				internal int KLNENXGTQBB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2B281A0", Offset = "0x2B26DA0", VA = "0x182B281A0")]
				internal void KLHXQQMWGPS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2B283F0", Offset = "0x2B26FF0", VA = "0x182B283F0")]
				internal bool KOIXBNZISDX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2B283A0", Offset = "0x2B26FA0", VA = "0x182B283A0")]
				internal bool KODQEHFLISO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2B272A0", Offset = "0x2B25EA0", VA = "0x182B272A0")]
				internal bool DMBOYTOBEYU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2B271A0", Offset = "0x2B25DA0", VA = "0x182B271A0")]
				internal object DLLUGZGJCQT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2B27210", Offset = "0x2B25E10", VA = "0x182B27210")]
				internal void DLRBEGAGMCC(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2B272F0", Offset = "0x2B25EF0", VA = "0x182B272F0")]
				internal bool DNRSCVRGCLO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2B27340", Offset = "0x2B25F40", VA = "0x182B27340")]
				internal bool DNWZACLDLWX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2B30D00", Offset = "0x2B2F900", VA = "0x182B30D00")]
				internal object? XODFHONIOFN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2B30C70", Offset = "0x2B2F870", VA = "0x182B30C70")]
				internal void XNXYKHTLEUE(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2B30B70", Offset = "0x2B2F770", VA = "0x182B30B70")]
				internal bool XNIDSNLTCMD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2B30B20", Offset = "0x2B2F720", VA = "0x182B30B20")]
				internal int XNCWVGRVTAU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2B30C10", Offset = "0x2B2F810", VA = "0x182B30C10")]
				internal void XNSRNAZNVIV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2B30BC0", Offset = "0x2B2F7C0", VA = "0x182B30BC0")]
				internal bool XNNKPUFQLXM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2B30AD0", Offset = "0x2B2F6D0", VA = "0x182B30AD0")]
				internal bool XMNCDMKDQST()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2B30A80", Offset = "0x2B2F680", VA = "0x182B30A80")]
				internal bool XMHVGFQGHHK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F350", Offset = "0x2B2DF50", VA = "0x182B2F350")]
				internal int RNJYWEEGKJM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F3A0", Offset = "0x2B2DFA0", VA = "0x182B2F3A0")]
				internal void RNPFTKYDTUV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F2B0", Offset = "0x2B2DEB0", VA = "0x182B2F2B0")]
				internal bool RMZLBQQLRMU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F300", Offset = "0x2B2DF00", VA = "0x182B2F300")]
				internal bool RNERYXKJAYD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F4B0", Offset = "0x2B2E0B0", VA = "0x182B2F4B0")]
				internal bool ROFALFFVWCW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F500", Offset = "0x2B2E100", VA = "0x182B2F500")]
				internal float ROKHILZTFOF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F400", Offset = "0x2B2E000", VA = "0x182B2F400")]
				internal void RNUMQRSBDGE(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F460", Offset = "0x2B2E060", VA = "0x182B2F460")]
				internal bool RNZTNYLYMRN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F210", Offset = "0x2B2DE10", VA = "0x182B2F210")]
				internal bool RLTVSCBBMWS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F260", Offset = "0x2B2DE60", VA = "0x182B2F260")]
				internal bool RLZCPIUYWIB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2B28040", Offset = "0x2B26C40", VA = "0x182B28040")]
				internal float JQMLGHBNLRD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2B27FE0", Offset = "0x2B26BE0", VA = "0x182B27FE0")]
				internal void JQHEJAHQCFU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2B27F90", Offset = "0x2B26B90", VA = "0x182B27F90")]
				internal bool JQBXLTNSSUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2B28150", Offset = "0x2B26D50", VA = "0x182B28150")]
				internal bool JRCFYBJFNZE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2B28100", Offset = "0x2B26D00", VA = "0x182B28100")]
				internal string JQWZAUPIENV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2B28090", Offset = "0x2B26C90", VA = "0x182B28090")]
				internal void JQRSDNVKVCM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2B27F40", Offset = "0x2B26B40", VA = "0x182B27F40")]
				internal bool JOWICEYIOEJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2B27EF0", Offset = "0x2B26AF0", VA = "0x182B27EF0")]
				internal bool JORBEYELETA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2B26CC0", Offset = "0x2B258C0", VA = "0x182B26CC0")]
				internal bool CPVGHOTKVYU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2B26D10", Offset = "0x2B25910", VA = "0x182B26D10")]
				internal bool CQANEVNIFKD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2B26D60", Offset = "0x2B25960", VA = "0x182B26D60")]
				internal string CQFUCCHFOVM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2B26DB0", Offset = "0x2B259B0", VA = "0x182B26DB0")]
				internal void CQLAZJBCYGV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2B26E20", Offset = "0x2B25A20", VA = "0x182B26E20")]
				internal bool CQQHWPVAHSE(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2B26E70", Offset = "0x2B25A70", VA = "0x182B26E70")]
				internal bool CQVOTWOXRDN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2B26EC0", Offset = "0x2B25AC0", VA = "0x182B26EC0")]
				internal bool CRAVRDIVAOW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2B26F10", Offset = "0x2B25B10", VA = "0x182B26F10")]
				internal bool CRGCOKCSKAF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B26C00", Offset = "0x2B25800", VA = "0x182B26C00")]
				internal string COFDDMQFYMA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B26C50", Offset = "0x2B25850", VA = "0x182B26C50")]
				internal void COKKATKDHXJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B30790", Offset = "0x2B2F390", VA = "0x182B30790")]
				internal bool WLKKABFYPGL(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B30740", Offset = "0x2B2F340", VA = "0x182B30740")]
				internal bool WLFDCUMBFVC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2B30830", Offset = "0x2B2F430", VA = "0x182B30830")]
				internal bool WLUXUOTTIDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2B307E0", Offset = "0x2B2F3E0", VA = "0x182B307E0")]
				internal bool WLPQXHZVYRU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2B308F0", Offset = "0x2B2F4F0", VA = "0x182B308F0")]
				internal string WMFLPCHOAZV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2B30880", Offset = "0x2B2F480", VA = "0x182B30880")]
				internal void WMAERVNQROM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B30990", Offset = "0x2B2F590", VA = "0x182B30990")]
				internal bool WMPZJPVITWN(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B30940", Offset = "0x2B2F540", VA = "0x182B30940")]
				internal bool WMKSMJBLKLE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2B30A30", Offset = "0x2B2F630", VA = "0x182B30A30")]
				internal bool WNANEDJDMTF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2B309E0", Offset = "0x2B2F5E0", VA = "0x182B309E0")]
				internal bool WMVGGWPGDHW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B29140", Offset = "0x2B27D40", VA = "0x182B29140")]
				internal string PRFRRRKPPNE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B29190", Offset = "0x2B27D90", VA = "0x182B29190")]
				internal void PRKYOYEMYYN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B290A0", Offset = "0x2B27CA0", VA = "0x182B290A0")]
				internal bool PQVDXDWUWQM(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B290F0", Offset = "0x2B27CF0", VA = "0x182B290F0")]
				internal bool PRAKUKQSGBV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B29000", Offset = "0x2B27C00", VA = "0x182B29000")]
				internal bool PQKQCQJADTU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2B29050", Offset = "0x2B27C50", VA = "0x182B29050")]
				internal bool PQPWZXCXNFD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2B28F40", Offset = "0x2B27B40", VA = "0x182B28F40")]
				internal string PQACICVFKXC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2B28F90", Offset = "0x2B27B90", VA = "0x182B28F90")]
				internal void PQFJFJPCUIL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2B28EA0", Offset = "0x2B27AA0", VA = "0x182B28EA0")]
				internal bool PPPONPHKSAK(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2B28EF0", Offset = "0x2B27AF0", VA = "0x182B28EF0")]
				internal bool PPUVKWBIBLT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B27980", Offset = "0x2B26580", VA = "0x182B27980")]
				internal bool HUIEBUHWQUV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B27930", Offset = "0x2B26530", VA = "0x182B27930")]
				internal bool HUCXENNZHJM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B278E0", Offset = "0x2B264E0", VA = "0x182B278E0")]
				internal string HTXQHGUBXYD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2B27870", Offset = "0x2B26470", VA = "0x182B27870")]
				internal void HTSJKAAEOMU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B27820", Offset = "0x2B26420", VA = "0x182B27820")]
				internal bool HTNCMTGHFBL(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2B277D0", Offset = "0x2B263D0", VA = "0x182B277D0")]
				internal bool HTHVPMMJVQC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B27780", Offset = "0x2B26380", VA = "0x182B27780")]
				internal bool HTCOSFSMMET()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B27730", Offset = "0x2B26330", VA = "0x182B27730")]
				internal bool HSXHUYYPCTK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2B276E0", Offset = "0x2B262E0", VA = "0x182B276E0")]
				internal string HSSAXSERTIB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2B27670", Offset = "0x2B26270", VA = "0x182B27670")]
				internal void HSMUALKUJWS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B264D0", Offset = "0x2B250D0", VA = "0x182B264D0")]
				internal bool BTOXQJYUMYU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2B26520", Offset = "0x2B25120", VA = "0x182B26520")]
				internal bool BTUENQSRWKD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B26570", Offset = "0x2B25170", VA = "0x182B26570")]
				internal bool BTZLKXMPFVM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2B265C0", Offset = "0x2B251C0", VA = "0x182B265C0")]
				internal bool BUESIEGMPGV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B26370", Offset = "0x2B24F70", VA = "0x182B26370")]
				internal string BSTWBIXFBFK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B263C0", Offset = "0x2B24FC0", VA = "0x182B263C0")]
				internal void BSZCYPRCKQT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2B26430", Offset = "0x2B25030", VA = "0x182B26430")]
				internal bool BTEJVWKZUCC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B26480", Offset = "0x2B25080", VA = "0x182B26480")]
				internal bool BTJQTDEXDNL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B262D0", Offset = "0x2B24ED0", VA = "0x182B262D0")]
				internal bool BRYUMHVPPMA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B26320", Offset = "0x2B24F20", VA = "0x182B26320")]
				internal bool BSEBJOPMYXJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B28A30", Offset = "0x2B27630", VA = "0x182B28A30")]
				internal string OLIXFWYODCU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B28AD0", Offset = "0x2B276D0", VA = "0x182B28AD0")]
				internal void OLOEDDSLMOD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B28B40", Offset = "0x2B27740", VA = "0x182B28B40")]
				internal bool OLYRXRGGFKV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2B288D0", Offset = "0x2B274D0", VA = "0x182B288D0")]
				internal bool OKNVQVWYRJK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B28920", Offset = "0x2B27520", VA = "0x182B28920")]
				internal bool OKTCOCQWAUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B28970", Offset = "0x2B27570", VA = "0x182B28970")]
				internal string OKYJLJKTKGC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B289C0", Offset = "0x2B275C0", VA = "0x182B289C0")]
				internal void OLDQIQEQTRL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B28780", Offset = "0x2B27380", VA = "0x182B28780")]
				internal bool OJSUBUVJFQA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B28820", Offset = "0x2B27420", VA = "0x182B28820")]
				internal bool OJYAZBPGPBJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B30150", Offset = "0x2B2ED50", VA = "0x182B30150")]
				internal bool VMACEPGQSVD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2B300B0", Offset = "0x2B2ECB0", VA = "0x182B300B0")]
				internal string VLUVHIMTJJU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FC40", Offset = "0x2B2E840", VA = "0x182B2FC40")]
				internal void VLPOKBSVZYL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FBA0", Offset = "0x2B2E7A0", VA = "0x182B2FBA0")]
				internal bool VLKHMUYYQNC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FB00", Offset = "0x2B2E700", VA = "0x182B2FB00")]
				internal bool VLFAPOFBHBT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FA60", Offset = "0x2B2E660", VA = "0x182B2FA60")]
				internal bool VKZTSHLDXQK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FA10", Offset = "0x2B2E610", VA = "0x182B2FA10")]
				internal string VKUMVARGOFB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F950", Offset = "0x2B2E550", VA = "0x182B2F950")]
				internal void VKPFXTXJETS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F900", Offset = "0x2B2E500", VA = "0x182B2F900")]
				internal bool VKESDGJOLXA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B26680", Offset = "0x2B25280", VA = "0x182B26680")]
				internal bool CGEUMZBZSOK(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B28440", Offset = "0x2B27040", VA = "0x182B28440")]
				internal float NJAPSXEYXAK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B28490", Offset = "0x2B27090", VA = "0x182B28490")]
				internal void NJFWQDYWGLT(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B284F0", Offset = "0x2B270F0", VA = "0x182B284F0")]
				internal bool NJLDNKSTPXC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B28540", Offset = "0x2B27140", VA = "0x182B28540")]
				internal bool NJQKKRMQZIL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B28590", Offset = "0x2B27190", VA = "0x182B28590")]
				internal bool NJVRHYGOITU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B285E0", Offset = "0x2B271E0", VA = "0x182B285E0")]
				internal int NKAYFFALSFD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B28630", Offset = "0x2B27230", VA = "0x182B28630")]
				internal void NKGFCLUJBQM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B28690", Offset = "0x2B27290", VA = "0x182B28690")]
				internal bool NKLLZSOGLBV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F5A0", Offset = "0x2B2E1A0", VA = "0x182B2F5A0")]
				internal bool UJHGXBZGTWB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F550", Offset = "0x2B2E150", VA = "0x182B2F550")]
				internal bool UJBZZVFJKKS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class UFSELLPSGUL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string FJSSURUCBGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public UFMXOEVUXJC FWYXBYDFGWV;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UFSELLPSGUL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B4ED90", Offset = "0x2B4D990", VA = "0x182B4ED90")]
				internal void VKYOGAFPCRB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class UFXLISJPQFU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] GAPVVSXPZSD;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UFXLISJPQFU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F920", Offset = "0x2B4E520", VA = "0x182B4F920")]
				internal bool NIVIVQLBNPB(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers FCMPEMDFMKC;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B32970", Offset = "0x2B31570", VA = "0x182B32970")]
			public WEQWBDMGEWI(XXEAPKVABFJ a, KRTFKRGVEHH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B30D70", Offset = "0x2B2F970", VA = "0x182B30D70", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class LQOFRSCWUBX : TCDLISVYSIA<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D240", Offset = "0x2B3BE40", VA = "0x182B3D240")]
			public LQOFRSCWUBX(XXEAPKVABFJ a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CF90", Offset = "0x2B3BB90", VA = "0x182B3CF90", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C990", Offset = "0x2B3B590", VA = "0x182B3C990")]
			private static string FIFNGRSYVYV(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CD40", Offset = "0x2B3B940", VA = "0x182B3CD40")]
			[CompilerGenerated]
			private object? MCRIIRWRBZY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CDE0", Offset = "0x2B3B9E0", VA = "0x182B3CDE0")]
			[CompilerGenerated]
			private void MCWPFYQOLLH(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CA90", Offset = "0x2B3B690", VA = "0x182B3CA90")]
			[CompilerGenerated]
			private string MCGUOEIWJDG(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CCA0", Offset = "0x2B3B8A0", VA = "0x182B3CCA0")]
			[CompilerGenerated]
			private IReadOnlyList<object> MCMBLLCTSOP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CEF0", Offset = "0x2B3BAF0", VA = "0x182B3CEF0")]
			[CompilerGenerated]
			private string? MDMJXSYGNTI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CF50", Offset = "0x2B3BB50", VA = "0x182B3CF50")]
			[CompilerGenerated]
			private bool MDRQUZSDXER()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class HAQFSBDZSBV : TCDLISVYSIA<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
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
					public QMUJENUQTSD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x2B4D520", Offset = "0x2B4C120", VA = "0x182B4D520", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public HAQFSBDZSBV DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2B40510", Offset = "0x2B3F110", VA = "0x182B40510")]
				internal string VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B40720", Offset = "0x2B3F320", VA = "0x182B40720")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void VPCSDYEVDWN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B40020", Offset = "0x2B3EC20", VA = "0x182B40020")]
				internal int VOMXMDXDBOM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B40230", Offset = "0x2B3EE30", VA = "0x182B40230")]
				internal void VOSEJKRAKZV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B39440", Offset = "0x2B38040", VA = "0x182B39440")]
			public HAQFSBDZSBV(XXEAPKVABFJ a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B39110", Offset = "0x2B37D10", VA = "0x182B39110", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class NDMDHRSMCYU : TCDLISVYSIA<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class LZUZORPWDSO
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
					public LZUZORPWDSO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2B4D830", Offset = "0x2B4C430", VA = "0x182B4D830", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public LZUZORPWDSO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x2B4DE10", Offset = "0x2B4CA10", VA = "0x182B4DE10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public NDMDHRSMCYU DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LZUZORPWDSO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DBD0", Offset = "0x2B3C7D0", VA = "0x182B3DBD0")]
				internal string VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DC20", Offset = "0x2B3C820", VA = "0x182B3DC20")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void VPCSDYEVDWN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DAF0", Offset = "0x2B3C6F0", VA = "0x182B3DAF0")]
				internal int VOMXMDXDBOM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DB40", Offset = "0x2B3C740", VA = "0x182B3DB40")]
				internal Task<bool> VOSEJKRAKZV(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D9D0", Offset = "0x2B3C5D0", VA = "0x182B3D9D0")]
				internal string VOCJRQJIIRU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DA20", Offset = "0x2B3C620", VA = "0x182B3DA20")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void VOHQOXDFSDD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D8F0", Offset = "0x2B3C4F0", VA = "0x182B3D8F0")]
				internal bool VNRVXCVNPVC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D940", Offset = "0x2B3C540", VA = "0x182B3D940")]
				internal void VNXCUJPKZGL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D810", Offset = "0x2B3C410", VA = "0x182B3D810")]
				internal bool VNHICPHSWYK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D860", Offset = "0x2B3C460", VA = "0x182B3D860")]
				internal void VNMOZWBQGJT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D6C0", Offset = "0x2B3C2C0", VA = "0x182B3D6C0")]
				internal float QJBGITFPLML()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D630", Offset = "0x2B3C230", VA = "0x182B3D630")]
				internal void QIVZLMLSCBC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D7B0", Offset = "0x2B3C3B0", VA = "0x182B3D7B0")]
				internal int QJLUDGTKEJD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D710", Offset = "0x2B3C310", VA = "0x182B3D710")]
				internal void QJGNFZZMUXU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D5C0", Offset = "0x2B3C1C0", VA = "0x182B3D5C0")]
				internal bool QIGETSDZZTB()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E6F0", Offset = "0x2B3D2F0", VA = "0x182B3E6F0")]
			public NDMDHRSMCYU(XXEAPKVABFJ a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DD90", Offset = "0x2B3C990", VA = "0x182B3DD90", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class GLWPQYSHHNF : TCDLISVYSIA<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public GLWPQYSHHNF DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2B40560", Offset = "0x2B3F160", VA = "0x182B40560")]
				internal Dictionary<string, EnumChoiceData> VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2B409A0", Offset = "0x2B3F5A0", VA = "0x182B409A0")]
				internal int VPCSDYEVDWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FEF0", Offset = "0x2B3EAF0", VA = "0x182B3FEF0")]
				internal void VOMXMDXDBOM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x2B401B0", Offset = "0x2B3EDB0", VA = "0x182B401B0")]
				internal bool VOSEJKRAKZV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2B38E40", Offset = "0x2B37A40", VA = "0x182B38E40")]
			public GLWPQYSHHNF(XXEAPKVABFJ a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2B38B90", Offset = "0x2B37790", VA = "0x182B38B90", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class GPNPBMJOYHA : TCDLISVYSIA<JSXTHWZVNFB>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public GPNPBMJOYHA DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x2B403B0", Offset = "0x2B3EFB0", VA = "0x182B403B0")]
				internal void VOXLGRKXULE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2B39030", Offset = "0x2B37C30", VA = "0x182B39030")]
			public GPNPBMJOYHA(XXEAPKVABFJ a, JSXTHWZVNFB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x2B38EB0", Offset = "0x2B37AB0", VA = "0x182B38EB0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class HHSFWNIAZQM<a> : QGPHXRWTWSX<a> where a : notnull, HOPDVXZISWE
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override SEVVSWFCYQX? UYPSYPGJCWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x647BE80", Offset = "0x647AA80", VA = "0x18647BE80", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x647BEE0", Offset = "0x647AAE0", VA = "0x18647BEE0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xF25AB0", Offset = "0xF246B0", VA = "0x180F25AB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x647BEC0", Offset = "0x647AAC0", VA = "0x18647BEC0")]
			public HHSFWNIAZQM(XXEAPKVABFJ a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class OCDUSNAJRAA : HHSFWNIAZQM<LSTCJXZSMZL>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class UFMXOEVUXJC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public OCDUSNAJRAA DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UFMXOEVUXJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EC10", Offset = "0x2B4D810", VA = "0x182B4EC10")]
				internal object VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4ECC0", Offset = "0x2B4D8C0", VA = "0x182B4ECC0")]
				internal void VPCSDYEVDWN(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EB30", Offset = "0x2B4D730", VA = "0x182B4EB30")]
				internal void VOMXMDXDBOM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? SCRWWTPCVZI;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F040", Offset = "0x2B3DC40", VA = "0x182B3F040")]
			public OCDUSNAJRAA(XXEAPKVABFJ a, LSTCJXZSMZL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EAC0", Offset = "0x2B3D6C0", VA = "0x182B3EAC0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class FAEKUAIYYNF : TCDLISVYSIA<PFLBLUUMWPS>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public FAEKUAIYYNF DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<BTONDMOTLQL>> FESKGGFGAOV;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A860", Offset = "0x2B39460", VA = "0x182B3A860")]
				internal int VPCSDYEVDWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2B39C20", Offset = "0x2B38820", VA = "0x182B39C20")]
				internal void VOMXMDXDBOM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class HGJAXSNYTZU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<BTONDMOTLQL> DEHEUXILURJ;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGJAXSNYTZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x2B39500", Offset = "0x2B38100", VA = "0x182B39500")]
				internal bool VOCJRQJIIRU(Id32<BTONDMOTLQL> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2B380B0", Offset = "0x2B36CB0", VA = "0x182B380B0")]
			public FAEKUAIYYNF(XXEAPKVABFJ a, PFLBLUUMWPS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x2B37B80", Offset = "0x2B36780", VA = "0x182B37B80", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class REZINEOLWDB : TCDLISVYSIA<CEAGYVTHVUE>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xD210B0", Offset = "0xD1FCB0", VA = "0x180D210B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x2B41700", Offset = "0x2B40300", VA = "0x182B41700")]
			public REZINEOLWDB(XXEAPKVABFJ a, CEAGYVTHVUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class GXFYUATNADK : TCDLISVYSIA<TBVZMSKJXXX>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x2B390A0", Offset = "0x2B37CA0", VA = "0x182B390A0")]
			public GXFYUATNADK(XXEAPKVABFJ a, TBVZMSKJXXX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "134")]
			protected override bool MBXSZUZYXXW(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class OLBXAMGJVZW : TCDLISVYSIA<MZVYLJAGVNH>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F110", Offset = "0x2B3DD10", VA = "0x182B3F110", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F0A0", Offset = "0x2B3DCA0", VA = "0x182B3F0A0")]
			public OLBXAMGJVZW(XXEAPKVABFJ a, MZVYLJAGVNH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class FEEAWJHNBRS : TCDLISVYSIA<ETZBVZIRYWV>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x2B38190", Offset = "0x2B36D90", VA = "0x182B38190", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2B38120", Offset = "0x2B36D20", VA = "0x182B38120")]
			public FEEAWJHNBRS(XXEAPKVABFJ a, ETZBVZIRYWV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class UBVCQJOCRIR : RVCQXCJMDWQ<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public UBVCQJOCRIR DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x2B39710", Offset = "0x2B38310", VA = "0x182B39710")]
				internal float KAUUERWXLRZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x2B39550", Offset = "0x2B38150", VA = "0x182B39550")]
				internal void KAPNHLDACGQ(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EA40", Offset = "0x2B4D640", VA = "0x182B4EA40")]
			public UBVCQJOCRIR(XXEAPKVABFJ a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E7D0", Offset = "0x2B4D3D0", VA = "0x182B4E7D0", Slot = "151")]
			protected override void IRNAQBPVSIH(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class SSVBQHFLTXI : TCDLISVYSIA<OJYOAIHVOTN>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2B47190", Offset = "0x2B45D90", VA = "0x182B47190")]
			public SSVBQHFLTXI(XXEAPKVABFJ a, OJYOAIHVOTN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class RXLYPUTQQGS : TCDLISVYSIA<BTHPJTQJKZN>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2B418D0", Offset = "0x2B404D0", VA = "0x182B418D0")]
			public RXLYPUTQQGS(XXEAPKVABFJ a, BTHPJTQJKZN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class JCIJIVLWIHR : TCDLISVYSIA<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public JCIJIVLWIHR DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A100", Offset = "0x2B38D00", VA = "0x182B3A100")]
				internal bool VOXLGRKXULE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A1F0", Offset = "0x2B38DF0", VA = "0x182B3A1F0")]
				internal void VPCSDYEVDWN(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BA30", Offset = "0x2B3A630", VA = "0x182B3BA30")]
			public JCIJIVLWIHR(XXEAPKVABFJ a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B7A0", Offset = "0x2B3A3A0", VA = "0x182B3B7A0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class AEXQENZERUX : TCDLISVYSIA<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public AEXQENZERUX DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> QKMPXLJQQQM;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2B39FD0", Offset = "0x2B38BD0", VA = "0x182B39FD0")]
				internal object? VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2B39990", Offset = "0x2B38590", VA = "0x182B39990")]
				internal bool VNXCUJPKZGL(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A610", Offset = "0x2B39210", VA = "0x182B3A610")]
				internal void VPCSDYEVDWN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2B39AD0", Offset = "0x2B386D0", VA = "0x182B39AD0")]
				internal string VOMXMDXDBOM(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2B39EE0", Offset = "0x2B38AE0", VA = "0x182B39EE0")]
				internal IReadOnlyList<object> VOSEJKRAKZV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2B39A10", Offset = "0x2B38610", VA = "0x182B39A10")]
				internal bool VOCJRQJIIRU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2B39A80", Offset = "0x2B38680", VA = "0x182B39A80")]
				internal bool VOHQOXDFSDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x2B39860", Offset = "0x2B38460", VA = "0x182B39860")]
				internal void VNRVXCVNPVC(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2B36FA0", Offset = "0x2B35BA0", VA = "0x182B36FA0")]
			public AEXQENZERUX(XXEAPKVABFJ a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2B368C0", Offset = "0x2B354C0", VA = "0x182B368C0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class DNSFIPHDLEN : TCDLISVYSIA<MSPRUCEXQAC>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class LZUZORPWDSO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int VNVJKGCIPXR;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LZUZORPWDSO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D580", Offset = "0x2B3C180", VA = "0x182B3D580")]
				internal bool IDMPFJBBQTZ(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class YYTPHXDUXQN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public DNSFIPHDLEN DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> IINFWPTSFCH;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public YYTPHXDUXQN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2B516E0", Offset = "0x2B502E0", VA = "0x182B516E0")]
				internal int VOXLGRKXULE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x2B51780", Offset = "0x2B50380", VA = "0x182B51780")]
				internal void VPCSDYEVDWN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x2B51630", Offset = "0x2B50230", VA = "0x182B51630")]
				internal string? VOMXMDXDBOM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2B37730", Offset = "0x2B36330", VA = "0x182B37730")]
			public DNSFIPHDLEN(XXEAPKVABFJ a, MSPRUCEXQAC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2B37230", Offset = "0x2B35E30", VA = "0x182B37230")]
			private int NTABHEPYLJV(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2B37610", Offset = "0x2B36210", VA = "0x182B37610")]
			private void VCLZIJQKIUP(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2B372C0", Offset = "0x2B35EC0", VA = "0x182B372C0", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class LJMZQQMGJZI : GUTZLGQLIKS<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xF2F330", Offset = "0xF2DF30", VA = "0x180F2F330", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C930", Offset = "0x2B3B530", VA = "0x182B3C930")]
			public LJMZQQMGJZI(XXEAPKVABFJ a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class LVFGAKEBPYU : RVCQXCJMDWQ<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public LVFGAKEBPYU DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2B39690", Offset = "0x2B38290", VA = "0x182B39690")]
				internal int KAUUERWXLRZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x2B395F0", Offset = "0x2B381F0", VA = "0x182B395F0")]
				internal void KAPNHLDACGQ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D520", Offset = "0x2B3C120", VA = "0x182B3D520")]
			public LVFGAKEBPYU(XXEAPKVABFJ a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D2B0", Offset = "0x2B3BEB0", VA = "0x182B3D2B0", Slot = "151")]
			protected override void IRNAQBPVSIH(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class GKMVQPEZPCK : TCDLISVYSIA<INITDSLBRIP>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public GKMVQPEZPCK DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<BTONDMOTLQL>> FESKGGFGAOV;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A320", Offset = "0x2B38F20", VA = "0x182B3A320")]
				internal int VPCSDYEVDWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2B39D80", Offset = "0x2B38980", VA = "0x182B39D80")]
				internal void VOMXMDXDBOM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class HGJAXSNYTZU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<BTONDMOTLQL> DEHEUXILURJ;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGJAXSNYTZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x2B394B0", Offset = "0x2B380B0", VA = "0x182B394B0")]
				internal bool VOCJRQJIIRU(Id32<BTONDMOTLQL> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2B38B20", Offset = "0x2B37720", VA = "0x182B38B20")]
			public GKMVQPEZPCK(XXEAPKVABFJ a, INITDSLBRIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2B385F0", Offset = "0x2B371F0", VA = "0x182B385F0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class KSYQVYRRSTO : TCDLISVYSIA<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public KSYQVYRRSTO DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x2B39F80", Offset = "0x2B38B80", VA = "0x182B39F80")]
				internal bool VOXLGRKXULE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A460", Offset = "0x2B39060", VA = "0x182B3A460")]
				internal void VPCSDYEVDWN(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C8C0", Offset = "0x2B3B4C0", VA = "0x182B3C8C0")]
			public KSYQVYRRSTO(XXEAPKVABFJ a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C6F0", Offset = "0x2B3B2F0", VA = "0x182B3C6F0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class XFPSHZTVEPO : TCDLISVYSIA<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public XFPSHZTVEPO DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A150", Offset = "0x2B38D50", VA = "0x182B3A150")]
				internal bool VOXLGRKXULE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A9A0", Offset = "0x2B395A0", VA = "0x182B3A9A0")]
				internal void VPCSDYEVDWN(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FBC0", Offset = "0x2B4E7C0", VA = "0x182B4FBC0")]
			public XFPSHZTVEPO(XXEAPKVABFJ a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F9F0", Offset = "0x2B4E5F0", VA = "0x182B4F9F0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class QNSPHQDZLOC : TCDLISVYSIA<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public QNSPHQDZLOC DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A1A0", Offset = "0x2B38DA0", VA = "0x182B3A1A0")]
				internal int VOXLGRKXULE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A580", Offset = "0x2B39180", VA = "0x182B3A580")]
				internal void VPCSDYEVDWN(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2B413F0", Offset = "0x2B3FFF0", VA = "0x182B413F0")]
			public QNSPHQDZLOC(XXEAPKVABFJ a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2B411A0", Offset = "0x2B3FDA0", VA = "0x182B411A0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class DCUKKXCIEXD
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log KZEIFDHBWKO;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class YDLPKXGGFQK<a> : TCDLISVYSIA<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class NSPBPFWQIHX
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
					public NSPBPFWQIHX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x41C13D0", Offset = "0x41BFFD0", VA = "0x1841C13D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x41C1710", Offset = "0x41C0310", VA = "0x1841C1710", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload KTCELDXMRGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public YDLPKXGGFQK<a> DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public NSPBPFWQIHX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x715BC50", Offset = "0x715A850", VA = "0x18715BC50")]
				[AsyncStateMachine(typeof(YDLPKXGGFQK<>.NSPBPFWQIHX.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task CZXLLJAYTTE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x715BD20", Offset = "0x715A920", VA = "0x18715BD20")]
				internal void VAZQPYZZZRH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class SXYABIUSGFB
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
					public SXYABIUSGFB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x41D6350", Offset = "0x41D4F50", VA = "0x1841D6350", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public SXYABIUSGFB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x41D7AB0", Offset = "0x41D66B0", VA = "0x1841D7AB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x41D81C0", Offset = "0x41D6DC0", VA = "0x1841D81C0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public MNKEWZIOFVL.NQKMGIVLPWH SLXCXYNVCRW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string GSGKYDESUKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string VPPHWCHITQH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public YDLPKXGGFQK<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper WMEVETIMXFV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool GDAHCFHLKMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action LBFAMTWLFKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool HGVFUYIOMUX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string TKIEIVWHTFT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action JSWFHAOLOGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action DQHOUHIHDMN;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public SXYABIUSGFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x793C920", Offset = "0x793B520", VA = "0x18793C920")]
				internal void KOYKYQVULAG(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x793C970", Offset = "0x793B570", VA = "0x18793C970")]
				internal void KPDRVXPRULP(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
				internal string HAYMHRRYEMB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x793C5A0", Offset = "0x793B1A0", VA = "0x18793C5A0")]
				internal void HATFKKYAVAS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x726C250", Offset = "0x726AE50", VA = "0x18726C250")]
				internal bool HANYNEEDLPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x793C500", Offset = "0x793B100", VA = "0x18793C500")]
				internal char HAIRPXKGCEA((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
				internal string? HBTNWSTNQFL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xF3B2F0", Offset = "0xF39EF0", VA = "0x180F3B2F0")]
				internal bool HBOGZLZQGUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x793C780", Offset = "0x793B380", VA = "0x18793C780")]
				internal void HBJACFFSXIT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x726C250", Offset = "0x726AE50", VA = "0x18726C250")]
				internal bool HBDTEYLVNXK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x793C880", Offset = "0x793B480", VA = "0x18793C880")]
				[AsyncStateMachine(typeof(YDLPKXGGFQK<>.SXYABIUSGFB.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void HCOPLTVDBYV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x793C340", Offset = "0x793AF40", VA = "0x18793C340")]
				internal void ALQOLAZHFFB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x793CB00", Offset = "0x793B700", VA = "0x18793CB00")]
				[AsyncStateMachine(typeof(YDLPKXGGFQK<>.SXYABIUSGFB.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task WFUZAMKLAHK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x793C9E0", Offset = "0x793B5E0", VA = "0x18793C9E0")]
				internal void KQTUZZSWRYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x793C440", Offset = "0x793B040", VA = "0x18793C440")]
				internal void DOHFZYNRVHX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x793C840", Offset = "0x793B440", VA = "0x18793C840")]
				internal bool HCJIONBFSNM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class OERIHQMSFXQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter EGNKDENCHFR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public YDLPKXGGFQK<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<MNKEWZIOFVL.BATXIFHYHCP> JRAVFRRJHIO;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public OERIHQMSFXQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x72A26B0", Offset = "0x72A12B0", VA = "0x1872A26B0")]
				internal bool ZZLYCGUQWFQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x72A25F0", Offset = "0x72A11F0", VA = "0x1872A25F0")]
				internal void EXSVDCKYAPE(MNKEWZIOFVL.BATXIFHYHCP a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class OEWPEXGPPIZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool JUSBCWSOOBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public QNHHNFLUXCI IJGFAHVAOCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public QNHHNFLUXCI VTINVRPFNVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public QNHHNFLUXCI PZEDDQYXSAD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string MSSOFDOXSYA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public OERIHQMSFXQ FWYXBYDFGWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action QLSFGZZAVGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action JQVOIKXLXXF;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public OEWPEXGPPIZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xF40FF0", Offset = "0xF3FBF0", VA = "0x180F40FF0")]
				internal bool FOGQRUXNNCG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x72A2710", Offset = "0x72A1310", VA = "0x1872A2710")]
				internal void STWSWIYMQEP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x72A2BF0", Offset = "0x72A17F0", VA = "0x1872A2BF0")]
				internal void ZZGRFAATMUH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x72A26F0", Offset = "0x72A12F0", VA = "0x1872A26F0")]
				internal void ZXATJDPWMZM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x72A2810", Offset = "0x72A1410", VA = "0x1872A2810")]
				internal void ZYGISSFGRPO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x72A3040", Offset = "0x72A1C40", VA = "0x1872A3040")]
				internal void ZZREZNOOFQZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x72A26F0", Offset = "0x72A12F0", VA = "0x1872A26F0")]
				internal void EXNOFVRARDV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class OEGUNCYXNAY
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
					public OEGUNCYXNAY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x41ECBE0", Offset = "0x41EB7E0", VA = "0x1841ECBE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x41ED220", Offset = "0x41EBE20", VA = "0x1841ED220", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool BGRSASFVZVT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public OEWPEXGPPIZ FWJCKDVNEOU;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public OEGUNCYXNAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x72A2170", Offset = "0x72A0D70", VA = "0x1872A2170")]
				[AsyncStateMachine(typeof(YDLPKXGGFQK<>.OEGUNCYXNAY.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task DPJMSKVJQAR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x72A2240", Offset = "0x72A0E40", VA = "0x1872A2240")]
				internal void ZXGAGKJTWKV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class OEMBKJSUWMH
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
					public OEMBKJSUWMH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x41EC5E0", Offset = "0x41EB1E0", VA = "0x1841EC5E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x41ECB80", Offset = "0x41EB780", VA = "0x1841ECB80", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload FQLQLPPHJGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public OEWPEXGPPIZ FWOJHKPKOAD;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public OEMBKJSUWMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x72A2320", Offset = "0x72A0F20", VA = "0x1872A2320")]
				[AsyncStateMachine(typeof(YDLPKXGGFQK<>.OEMBKJSUWMH.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task LDSHVHCOLGM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x72A22B0", Offset = "0x72A0EB0", VA = "0x1872A22B0")]
				internal void EXIHIOXDHSM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class ZREJSMQIMLJ
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
					public ZREJSMQIMLJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x41EC100", Offset = "0x41EAD00", VA = "0x1841EC100", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x41EC580", Offset = "0x41EB180", VA = "0x1841EC580", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public YDLPKXGGFQK<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload NGLMXUOGGAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public MNKEWZIOFVL.BATXIFHYHCP SLXCXYNVCRW;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public ZREJSMQIMLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5147740", Offset = "0x5146340", VA = "0x185147740")]
				[AsyncStateMachine(typeof(YDLPKXGGFQK<>.ZREJSMQIMLJ.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task HBDYYTIPKOG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5147810", Offset = "0x5146410", VA = "0x185147810")]
				internal bool LABNUMCKLXG(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x5147940", Offset = "0x5146540", VA = "0x185147940")]
				internal void LARIMGKCOFH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x51478F0", Offset = "0x51464F0", VA = "0x1851478F0")]
				internal void LAMBOZQFETY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class MLTHIYPQCOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string XXPBLTSUFTN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public QNHHNFLUXCI NQDNCQNOZQS;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public MLTHIYPQCOI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x6F0E6B0", Offset = "0x6F0D2B0", VA = "0x186F0E6B0")]
				internal string? BKHNDPTWREN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xE968E0", Offset = "0xE954E0", VA = "0x180E968E0")]
				internal bool BKCGGIZZHTE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x6F0E640", Offset = "0x6F0D240", VA = "0x186F0E640")]
				internal void BJWZJCGBYHV(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool JCBERMUEOEU;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log KZEIFDHBWKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x510D440", Offset = "0x510C040", VA = "0x18510D440")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x510D830", Offset = "0x510C430", VA = "0x18510D830", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected MNKEWZIOFVL QVGVYCKIBBG
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xCF2B20", Offset = "0xCF1720", VA = "0x180CF2B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xCF2B70", Offset = "0xCF1770", VA = "0x180CF2B70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> OOFGSYKLPED
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xDB5A90", Offset = "0xDB4690", VA = "0x180DB5A90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x11054E0", Offset = "0x11040E0", VA = "0x1811054E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected EVUOQCSWTPL HZODOUVEVTM
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xF6C370", Offset = "0xF6AF70", VA = "0x180F6C370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x1725820", Offset = "0x1724420", VA = "0x181725820")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected XVJZGXTRVOP ZLIAPXTZBKQ
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xF6C380", Offset = "0xF6AF80", VA = "0x180F6C380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x1722720", Offset = "0x1721320", VA = "0x181722720")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x510D800", Offset = "0x510C400", VA = "0x18510D800")]
			protected YDLPKXGGFQK(XXEAPKVABFJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x5109430", Offset = "0x5108030", VA = "0x185109430", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x51093E0", Offset = "0x5107FE0", VA = "0x1851093E0", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x5109480", Offset = "0x5108080", VA = "0x185109480", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x510B2A0", Offset = "0x5109EA0", VA = "0x18510B2A0")]
			private void HJEUPBZTHPL(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x510C700", Offset = "0x510B300", VA = "0x18510C700", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5109F50", Offset = "0x5108B50", VA = "0x185109F50")]
			private void FPANUZKJLAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x510C960", Offset = "0x510B560", VA = "0x18510C960")]
			private void QMCDFIUFTGN(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "151")]
			protected virtual void HOPANNEVROQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x510B100", Offset = "0x5109D00", VA = "0x18510B100")]
			private void HIWOOMDEJDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x51094D0", Offset = "0x51080D0", VA = "0x1851094D0")]
			private void EBCPDDNOEFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x510B890", Offset = "0x510A490", VA = "0x18510B890")]
			private void NTINPIBKRKL(MNKEWZIOFVL.BATXIFHYHCP a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x510A610", Offset = "0x5109210", VA = "0x18510A610")]
			private void GERZDOCPSLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x510B560", Offset = "0x510A160", VA = "0x18510B560")]
			protected void JKTRMFENQPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x5109370", Offset = "0x5107F70", VA = "0x185109370")]
			private void CVIAAQQLDGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x510C6E0", Offset = "0x510B2E0", VA = "0x18510C6E0")]
			private void NWODHZPJHIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x510C900", Offset = "0x510B500", VA = "0x18510C900")]
			private void PENXVJHXDFY(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x510B590", Offset = "0x510A190", VA = "0x18510B590")]
			private string MUEAXANFINO((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x510C650", Offset = "0x510B250", VA = "0x18510C650")]
			private string NVPJRKPXCDN(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x510B010", Offset = "0x5109C10", VA = "0x18510B010")]
			[CompilerGenerated]
			private object? HHISEWJDZSP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x510A8A0", Offset = "0x51094A0", VA = "0x18510A8A0")]
			[CompilerGenerated]
			private void HHDLHPPGQHG(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x510B040", Offset = "0x5109C40", VA = "0x18510B040")]
			[CompilerGenerated]
			private IReadOnlyList<object> HHNZCDDBJDY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x510A810", Offset = "0x5109410", VA = "0x18510A810")]
			[CompilerGenerated]
			private void HGNQPVHONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x510B0B0", Offset = "0x5109CB0", VA = "0x18510B0B0")]
			[CompilerGenerated]
			private void HITOLRSLNUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x510D490", Offset = "0x510C090", VA = "0x18510D490")]
			[CompilerGenerated]
			private void XKYDCFLAZDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x510D4D0", Offset = "0x510C0D0", VA = "0x18510D4D0")]
			[CompilerGenerated]
			private void XWXACFCAWDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x5109330", Offset = "0x5107F30", VA = "0x185109330")]
			[CompilerGenerated]
			private void CDLRXTWUILR(MNKEWZIOFVL.BATXIFHYHCP a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class IRNWXQMAXER : YDLPKXGGFQK<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B740", Offset = "0x2B3A340", VA = "0x182B3B740")]
			public IRNWXQMAXER(XXEAPKVABFJ a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class JSYYNUQXUZD : YDLPKXGGFQK<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type OPWBCPNCURM
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x2B41C90", Offset = "0x2B40890", VA = "0x182B41C90", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope QXKTUEWRMGP
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string ZIXQMBVKNAZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x142D830", Offset = "0x142C430", VA = "0x18142D830")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2B41CE0", Offset = "0x2B408E0", VA = "0x182B41CE0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2B41DD0", Offset = "0x2B409D0", VA = "0x182B41DD0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool XJINPLHNWWW(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2B41B80", Offset = "0x2B40780", VA = "0x182B41B80", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x2B41AF0", Offset = "0x2B406F0", VA = "0x182B41AF0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x2B419A0", Offset = "0x2B405A0", VA = "0x182B419A0", Slot = "7")]
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
				protected virtual Type OPWBCPNCURM
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x2B48740", Offset = "0x2B47340", VA = "0x182B48740", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers VGTJPMCDMUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string ZIXQMBVKNAZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x142D830", Offset = "0x142C430", VA = "0x18142D830")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2B48790", Offset = "0x2B47390", VA = "0x182B48790", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2B48880", Offset = "0x2B47480", VA = "0x182B48880", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool XJINPLHNWWW(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2B48630", Offset = "0x2B47230", VA = "0x182B48630", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x2B485A0", Offset = "0x2B471A0", VA = "0x182B485A0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x2B48450", Offset = "0x2B47050", VA = "0x182B48450", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
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
					public QMUJENUQTSD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2B4C810", Offset = "0x2B4B410", VA = "0x182B4C810", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QMUJENUQTSD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x2B4CC20", Offset = "0x2B4B820", VA = "0x182B4CC20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public JSYYNUQXUZD DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public EVUOQCSWTPL JLXQHGZVMFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> QLXMEGSYERX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> QLSFGZZAVGO;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F160", Offset = "0x2B3DD60", VA = "0x182B3F160")]
				internal object? OOVZCQJXSVE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F530", Offset = "0x2B3E130", VA = "0x182B3F530")]
				internal bool OQMCGSNCQHY(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F240", Offset = "0x2B3DE40", VA = "0x182B3F240")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void OPBFZXDVCGN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2B40D20", Offset = "0x2B3F920", VA = "0x182B40D20")]
				internal IReadOnlyList<TargetPlayersSelection> WICRCDOSSCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F3E0", Offset = "0x2B3DFE0", VA = "0x182B3F3E0")]
				internal object? OPWHOYFKNZX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F590", Offset = "0x2B3E190", VA = "0x182B3F590")]
				internal bool OQRJDZGZZTH(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F310", Offset = "0x2B3DF10", VA = "0x182B3F310")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void OPGMXDXSLRW(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> XTINNCBXVDS;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> EEZNTLUUKRY;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> IPSHMIYPNAO;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C690", Offset = "0x2B3B290", VA = "0x182B3C690")]
			public JSYYNUQXUZD(XXEAPKVABFJ a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BAA0", Offset = "0x2B3A6A0", VA = "0x182B3BAA0", Slot = "151")]
			protected override void HOPANNEVROQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C020", Offset = "0x2B3AC20", VA = "0x182B3C020")]
			private static IReadOnlyList<TargetPlayersSelection> XCXBJWWJJTV(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class ARHMSJJRDBY : KNJJYDUMGUT<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType MZMMVWGOQKQ
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2B37010", Offset = "0x2B35C10", VA = "0x182B37010")]
			public ARHMSJJRDBY(XXEAPKVABFJ a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class BSGSKGWBRTZ : TCDLISVYSIA<KTFAJFRQMLO>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2B370D0", Offset = "0x2B35CD0", VA = "0x182B370D0")]
			public BSGSKGWBRTZ(XXEAPKVABFJ a, KTFAJFRQMLO b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class TCDLISVYSIA<a> : NPOSFCMHTQF, IDisposable where a : notnull, KTFAJFRQMLO
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class WLUGBDBSDJT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public TCDLISVYSIA<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public XXEAPKVABFJ WNUGETGNPTN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a EOEQGJOKNAI;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public WLUGBDBSDJT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x85D26D0", Offset = "0x85D12D0", VA = "0x1885D26D0")]
				internal SNRMYWHFTJS VEXFNNTLLWN(NXDSHMFFKMH a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class IXXURIELXNF
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
					public IXXURIELXNF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x41C3E90", Offset = "0x41C2A90", VA = "0x1841C3E90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string VGZUXWTJQFD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, LYQWSZGLQZW>> CRNDAVDQERU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public TCDLISVYSIA<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> YJPVGVKYUZU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public MNKEWZIOFVL QVGVYCKIBBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> YXFNFERQCNY;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public IXXURIELXNF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				internal string DKRJRWVCVIP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
				internal void DKMCUQBFLXG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x65B3B70", Offset = "0x65B2770", VA = "0x1865B3B70")]
				[AsyncStateMachine(typeof(TCDLISVYSIA<>.IXXURIELXNF.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void DLBXMKIXOFH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class UVMXRGUFEJI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UVMXRGUFEJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x7D55260", Offset = "0x7D53E60", VA = "0x187D55260")]
				internal Result<string, LYQWSZGLQZW> KEXTYKALKEN(string a)
				{
					return default(Result<string, LYQWSZGLQZW>);
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
				public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public TCDLISVYSIA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x6B1EA90", Offset = "0x6B1D690", VA = "0x186B1EA90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x6B1ECE0", Offset = "0x6B1D8E0", VA = "0x186B1ECE0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public TCDLISVYSIA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x6B1ED50", Offset = "0x6B1D950", VA = "0x186B1ED50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x6B1F050", Offset = "0x6B1DC50", VA = "0x186B1F050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly XXEAPKVABFJ DJOACGOLDJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool CGCPGKOLIQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<BNOAYSCHUMT, SNRMYWHFTJS> ALPZATHHQHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<BNOAYSCHUMT, KYCFNPVYGVL> YDUSQDVTAMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> LUHIPTKIJIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<BNOAYSCHUMT>>? YTPVVAWJHDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<BNOAYSCHUMT>, KYCFNPVYGVL>? MKUFJVXWAKP;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected EOMRJYDEACK KEHJKNTJZOR
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x7A84930", Offset = "0x7A83530", VA = "0x187A84930")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected LEWVSLHMGCM LEWVSLHMGCM
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x7A852A0", Offset = "0x7A83EA0", VA = "0x187A852A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected ZEQAUYTRFYT XLWWLSNHTUC
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x7A84990", Offset = "0x7A83590", VA = "0x187A84990")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a KTFAJFRQMLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<VJPEKKVEEYH> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x166D350", Offset = "0x166BF50", VA = "0x18166D350", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<VJPEKKVEEYH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<GAWNVANSVBY> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x7A882E0", Offset = "0x7A86EE0", VA = "0x187A882E0", Slot = "6")]
				get
				{
					return default(Id32<GAWNVANSVBY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x7A88150", Offset = "0x7A86D50", VA = "0x187A88150", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x7A88130", Offset = "0x7A86D30", VA = "0x187A88130", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x7A88440", Offset = "0x7A87040", VA = "0x187A88440", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<SIQZVIOBMBM> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD66FC0", Offset = "0xD65BC0", VA = "0x180D66FC0", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<SIQZVIOBMBM>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD68130", Offset = "0xD66D30", VA = "0x180D68130")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xD3F510", Offset = "0xD3E110", VA = "0x180D3F510", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x7A88000", Offset = "0x7A86C00", VA = "0x187A88000", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x7A88030", Offset = "0x7A86C30", VA = "0x187A88030", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x7A88060", Offset = "0x7A86C60", VA = "0x187A88060", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x7A882C0", Offset = "0x7A86EC0", VA = "0x187A882C0", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x7A881F0", Offset = "0x7A86DF0", VA = "0x187A881F0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x7A880D0", Offset = "0x7A86CD0", VA = "0x187A880D0", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x7A880A0", Offset = "0x7A86CA0", VA = "0x187A880A0", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x10AC030", Offset = "0x10AAC30", VA = "0x1810AC030", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x1807A30", Offset = "0x1806630", VA = "0x181807A30")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x7A88090", Offset = "0x7A86C90", VA = "0x187A88090", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x7A881A0", Offset = "0x7A86DA0", VA = "0x187A881A0", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x7A88260", Offset = "0x7A86E60", VA = "0x187A88260", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x7A88290", Offset = "0x7A86E90", VA = "0x187A88290", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x7A881D0", Offset = "0x7A86DD0", VA = "0x187A881D0", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual JHADXGHLEEK? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual SEVVSWFCYQX? UYPSYPGJCWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<NYBQVHGBIMX>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x7A88100", Offset = "0x7A86D00", VA = "0x187A88100", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<GNQADATMYDH> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x7A88210", Offset = "0x7A86E10", VA = "0x187A88210", Slot = "68")]
				get
				{
					return default(Id128<GNQADATMYDH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<GNQADATMYDH> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x7A88170", Offset = "0x7A86D70", VA = "0x187A88170", Slot = "59")]
				get
				{
					return default(Id32<GNQADATMYDH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<GNQADATMYDH>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<GNQADATMYDH>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x7A859C0", Offset = "0x7A845C0", VA = "0x187A859C0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xCF7720", Offset = "0xCF6320", VA = "0x180CF7720", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xCF76E0", Offset = "0xCF62E0", VA = "0x180CF76E0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xCF7D90", Offset = "0xCF6990", VA = "0x180CF7D90", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xCF7750", Offset = "0xCF6350", VA = "0x180CF7750")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<NYBQVHGBIMX> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x7A88320", Offset = "0x7A86F20", VA = "0x187A88320", Slot = "69")]
				get
				{
					return default(Id32<NYBQVHGBIMX>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<NYBQVHGBIMX> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x7A88240", Offset = "0x7A86E40", VA = "0x187A88240", Slot = "70")]
				get
				{
					return default(Id128<NYBQVHGBIMX>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<NYBQVHGBIMX>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x7A88340", Offset = "0x7A86F40", VA = "0x187A88340", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<BNOAYSCHUMT, KYCFNPVYGVL> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x7A88400", Offset = "0x7A87000", VA = "0x187A88400", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<BNOAYSCHUMT, KYCFNPVYGVL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<BNOAYSCHUMT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action NIPBRXYIECT
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x7A845D0", Offset = "0x7A831D0", VA = "0x187A845D0", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x7A877C0", Offset = "0x7A863C0", VA = "0x187A877C0", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate LZMGXJDRDAG
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x7A83D20", Offset = "0x7A82920", VA = "0x187A83D20", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x7A87190", Offset = "0x7A85D90", VA = "0x187A87190", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate SOWWDLIYTTX
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x7A861C0", Offset = "0x7A84DC0", VA = "0x187A861C0", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x7A85570", Offset = "0x7A84170", VA = "0x187A85570", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action CHWGJGTSWUJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x7A84130", Offset = "0x7A82D30", VA = "0x187A84130", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x7A85940", Offset = "0x7A84540", VA = "0x187A85940", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action JWIZAJMGHNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x7A84E30", Offset = "0x7A83A30", VA = "0x187A84E30", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x7A86930", Offset = "0x7A85530", VA = "0x187A86930", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<BNOAYSCHUMT>, KYCFNPVYGVL> QMHIVNBJOFD
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x7A856A0", Offset = "0x7A842A0", VA = "0x187A856A0", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x7A869D0", Offset = "0x7A855D0", VA = "0x187A869D0", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<BNOAYSCHUMT>, KYCFNPVYGVL> VBDRAIYIJGA
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x7A854B0", Offset = "0x7A840B0", VA = "0x187A854B0", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x7A84750", Offset = "0x7A83350", VA = "0x187A84750", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<BNOAYSCHUMT>> SYDONMSSXDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x7A87230", Offset = "0x7A85E30", VA = "0x187A87230", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x7A86260", Offset = "0x7A84E60", VA = "0x187A86260", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<BNOAYSCHUMT>, Id32<BNOAYSCHUMT>> TAWPTNWZHAZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x7A87AE0", Offset = "0x7A866E0", VA = "0x187A87AE0", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x7A84690", Offset = "0x7A83290", VA = "0x187A84690", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<BNOAYSCHUMT>, KYCFNPVYGVL> PHGVCIMAOMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x7A85390", Offset = "0x7A83F90", VA = "0x187A85390", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x7A85760", Offset = "0x7A84360", VA = "0x187A85760", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<BNOAYSCHUMT>, Id32<BNOAYSCHUMT>> MQABFLLNUJW
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x7A86320", Offset = "0x7A84F20", VA = "0x187A86320", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x7A84510", Offset = "0x7A83110", VA = "0x187A84510", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> HCYCMDNMZYB
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x7A85020", Offset = "0x7A83C20", VA = "0x187A85020", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x7A87700", Offset = "0x7A86300", VA = "0x187A87700", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x7A87BA0", Offset = "0x7A867A0", VA = "0x187A87BA0")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected TCDLISVYSIA(XXEAPKVABFJ a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x7A850E0", Offset = "0x7A83CE0", VA = "0x187A850E0", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x7A841E0", Offset = "0x7A82DE0", VA = "0x187A841E0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x7A85450", Offset = "0x7A84050", VA = "0x187A85450", Slot = "9")]
			public Task<Result<None, LYQWSZGLQZW>> JSQUADWKQOY(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x7A86C40", Offset = "0x7A85840", VA = "0x187A86C40")]
			public bool TMNTTFRGXPG([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x7A83AE0", Offset = "0x7A826E0", VA = "0x187A83AE0")]
			public bool CQAIDCGHMOR([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x7A85D90", Offset = "0x7A84990", VA = "0x187A85D90", Slot = "34")]
			public void NRQUHBBFQCB(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x7A86AD0", Offset = "0x7A856D0", VA = "0x187A86AD0", Slot = "35")]
			public Task RVPNSDUYUBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x7A84ED0", Offset = "0x7A83AD0", VA = "0x187A84ED0", Slot = "36")]
			[AsyncStateMachine(typeof(TCDLISVYSIA<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, LYQWSZGLQZW>> IOVLZRUJZZC(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "119")]
			public virtual void NONCEAHIIGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x109F340", Offset = "0x109DF40", VA = "0x18109F340")]
			protected void WWWEZKCNPPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x214DDB0", Offset = "0x214C9B0", VA = "0x18214DDB0")]
			protected void GBDKLIQFMWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x212F220", Offset = "0x212DE20", VA = "0x18212F220")]
			private void RNUYCETBREM([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x7A83B10", Offset = "0x7A82710", VA = "0x187A83B10", Slot = "122")]
			public virtual Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> ASXFQEVLWTB(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x7A85FC0", Offset = "0x7A84BC0", VA = "0x187A85FC0", Slot = "123")]
			public virtual Task<Result<None, LYQWSZGLQZW>> ORXSIYCZEWW(Id32<BNOAYSCHUMT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "124")]
			public virtual void KQERDJXKSJE(Id32<BNOAYSCHUMT> sourceId, Id32<BNOAYSCHUMT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x7A87460", Offset = "0x7A86060", VA = "0x187A87460", Slot = "125")]
			public virtual IEnumerable<FXFJUDAMIWO> YFWUOVWSJNT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x7A87090", Offset = "0x7A85C90", VA = "0x187A87090", Slot = "126")]
			public Result<None, LYQWSZGLQZW> VWOGKJSCFNO(string a)
			{
				return default(Result<None, LYQWSZGLQZW>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x7A84810", Offset = "0x7A83410", VA = "0x187A84810", Slot = "50")]
			public bool HPJMVSGAEIE([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x7A87860", Offset = "0x7A86460", VA = "0x187A87860")]
			public bool ZMXPMYDOTQR([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "128")]
			public virtual void QQKSAOTBWNN(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "129")]
			public virtual BZUHBALWOAG GZYHQMRETJR([In] CJWZHUMHDQV audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x7A85E30", Offset = "0x7A84A30", VA = "0x187A85E30")]
			protected void NVONCKUGFNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x7A859C0", Offset = "0x7A845C0", VA = "0x187A859C0", Slot = "134")]
			protected virtual bool MBXSZUZYXXW(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x7A85F90", Offset = "0x7A84B90", VA = "0x187A85F90", Slot = "96")]
			public bool OQWEQMTKIOK(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "135")]
			protected virtual bool VJIJKMPWYXZ(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected virtual void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x7A85A00", Offset = "0x7A84600", VA = "0x187A85A00")]
			protected void MNHETOUHVYX(MNKEWZIOFVL a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, LYQWSZGLQZW>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x7A87500", Offset = "0x7A86100", VA = "0x187A87500")]
			protected void YPPLXIGSVFT(MNKEWZIOFVL a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x7A83DC0", Offset = "0x7A829C0", VA = "0x187A83DC0", Slot = "146")]
			protected virtual void DMGPEFUCRNS(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x7A870D0", Offset = "0x7A85CD0", VA = "0x187A870D0", Slot = "90")]
			public void WEDUMPUXOZH(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x7A86BD0", Offset = "0x7A857D0", VA = "0x187A86BD0", Slot = "91")]
			public CircuitsRigidTransform TFJLEIAPSRS()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "149")]
			public virtual bool UHTRHCFSMMC(Id32<BNOAYSCHUMT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x7A86A90", Offset = "0x7A85690", VA = "0x187A86A90")]
			private void RELFZNNJPBZ([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x7A83C60", Offset = "0x7A82860", VA = "0x187A83C60")]
			private void CKZTUOSQYXC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x109F340", Offset = "0x109DF40", VA = "0x18109F340", Slot = "97")]
			private void KVOGXFCKRPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x7A863E0", Offset = "0x7A84FE0", VA = "0x187A863E0", Slot = "99")]
			private void QZWQYNCUYQQ(Id32<BNOAYSCHUMT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x4FD8FD0", Offset = "0x4FD7BD0", VA = "0x184FD8FD0", Slot = "101")]
			private void DZNBIIKODGB(Id32<BNOAYSCHUMT> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x7A86080", Offset = "0x7A84C80", VA = "0x187A86080", Slot = "103")]
			private void PBTFDKUJWKD(Id32<BNOAYSCHUMT> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x7A84A70", Offset = "0x7A83670", VA = "0x187A84A70", Slot = "104")]
			private void ILCPGYOIEHR(Id32<BNOAYSCHUMT> sourceId, Id32<BNOAYSCHUMT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x7A86AB0", Offset = "0x7A856B0", VA = "0x187A86AB0", Slot = "105")]
			private void RMHJGKWHKCQ(Id32<BNOAYSCHUMT> sourceId, Id32<BNOAYSCHUMT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x173DCF0", Offset = "0x173C8F0", VA = "0x18173DCF0", Slot = "98")]
			private void XGSTVRASVKX(Id32<BNOAYSCHUMT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x7A86C70", Offset = "0x7A85870", VA = "0x187A86C70", Slot = "100")]
			private void VEWKXXQGLUQ(Id32<BNOAYSCHUMT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x7A87120", Offset = "0x7A85D20", VA = "0x187A87120", Slot = "102")]
			private void WEFTWCFEPMC(Id32<BNOAYSCHUMT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x7A859A0", Offset = "0x7A845A0", VA = "0x187A859A0", Slot = "106")]
			private void LZUXIZPVVQA(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x7A85820", Offset = "0x7A84420", VA = "0x187A85820", Slot = "150")]
			[AsyncStateMachine(typeof(TCDLISVYSIA<>.<RequestNameChange>d__224))]
			public Task<Result<None, LYQWSZGLQZW>> LLZJCZDRTFI(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x7A85610", Offset = "0x7A84210", VA = "0x187A85610", Slot = "57")]
			private void KGOLCKTDYME(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x7A83BD0", Offset = "0x7A827D0", VA = "0x187A83BD0", Slot = "58")]
			private void BHGDBCVCRUT(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x7A86C40", Offset = "0x7A85840", VA = "0x187A86C40", Slot = "30")]
			private bool TYXEVTETEWR([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x7A83AE0", Offset = "0x7A826E0", VA = "0x187A83AE0", Slot = "32")]
			private bool AETECDOLMUI([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x7A84670", Offset = "0x7A83270", VA = "0x187A84670", Slot = "51")]
			private bool GRSUNXTKUPO([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF7720", Offset = "0xCF6320", VA = "0x180CF7720")]
			[CompilerGenerated]
			private string YDOICTNCCYO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x7A872F0", Offset = "0x7A85EF0", VA = "0x187A872F0")]
			[CompilerGenerated]
			private void YDTPAAGZMJX(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class YEWNNCJZHSF : GUTZLGQLIKS<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xF229E0", Offset = "0xF215E0", VA = "0x180F229E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FC30", Offset = "0x2B4E830", VA = "0x182B4FC30")]
			public YEWNNCJZHSF(XXEAPKVABFJ a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class HSFADGMQDFH : TCDLISVYSIA<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NVELGQPHRTI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public HSFADGMQDFH DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> RBIKYCTEOWI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> MSDESDMUMJW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B407F0", Offset = "0x2B3F3F0", VA = "0x182B407F0")]
				internal int VPCSDYEVDWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B40070", Offset = "0x2B3EC70", VA = "0x182B40070")]
				internal void VOMXMDXDBOM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AD10", Offset = "0x2B39910", VA = "0x182B3AD10")]
			public HSFADGMQDFH(XXEAPKVABFJ a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AA30", Offset = "0x2B39630", VA = "0x182B3AA30", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class RNIGHRGKJIT : QGPHXRWTWSX<VUXIBZNXCYQ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B41870", Offset = "0x2B40470", VA = "0x182B41870")]
			public RNIGHRGKJIT(XXEAPKVABFJ a, VUXIBZNXCYQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class QXCXYFAMDCV : TCDLISVYSIA<ZGOTWMZQSWC>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public QXCXYFAMDCV DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B39F30", Offset = "0x2B38B30", VA = "0x182B39F30")]
				internal bool VOXLGRKXULE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A4F0", Offset = "0x2B390F0", VA = "0x182B3A4F0")]
				internal void VPCSDYEVDWN(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B41630", Offset = "0x2B40230", VA = "0x182B41630")]
			public QXCXYFAMDCV(XXEAPKVABFJ a, ZGOTWMZQSWC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B41460", Offset = "0x2B40060", VA = "0x182B41460", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class TFUCREDNBJY : TCDLISVYSIA<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
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
					public QMUJENUQTSD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x2B4DB70", Offset = "0x2B4C770", VA = "0x182B4DB70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x2B4DDA0", Offset = "0x2B4C9A0", VA = "0x182B4DDA0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BPPXHKYUUYI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public TFUCREDNBJY DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> YVFASBKPRPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> BJBTDBLAEXE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B40600", Offset = "0x2B3F200", VA = "0x182B40600")]
				internal int VPCSDYEVDWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FD60", Offset = "0x2B3E960", VA = "0x182B3FD60")]
				internal void VOMXMDXDBOM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B402C0", Offset = "0x2B3EEC0", VA = "0x182B402C0")]
				internal int VOSEJKRAKZV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FC10", Offset = "0x2B3E810", VA = "0x182B3FC10")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> VOCJRQJIIRU(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F5F0", Offset = "0x2B3E1F0", VA = "0x182B3F5F0")]
				internal int QHFWHKINEOI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B40B60", Offset = "0x2B3F760", VA = "0x182B40B60")]
				internal void WGZPZYGICFS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B40BF0", Offset = "0x2B3F7F0", VA = "0x182B40BF0")]
				internal int WHEWXFAFLRB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B40C40", Offset = "0x2B3F840", VA = "0x182B40C40")]
				internal void WHKDULUCVCK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B40CD0", Offset = "0x2B3F8D0", VA = "0x182B40CD0")]
				internal int WHPKRSOAENT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B409F0", Offset = "0x2B3F5F0", VA = "0x182B409F0")]
				internal void WGEOKXESQMI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B40A80", Offset = "0x2B3F680", VA = "0x182B40A80")]
				internal int WGJVIDYPZXR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B40AD0", Offset = "0x2B3F6D0", VA = "0x182B40AD0")]
				internal void WGPCFKSNJJA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FD10", Offset = "0x2B3E910", VA = "0x182B3FD10")]
				internal float VOHQOXDFSDD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FB30", Offset = "0x2B3E730", VA = "0x182B3FB30")]
				internal void VNRVXCVNPVC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FBC0", Offset = "0x2B3E7C0", VA = "0x182B3FBC0")]
				internal float VNXCUJPKZGL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FA50", Offset = "0x2B3E650", VA = "0x182B3FA50")]
				internal void VNHICPHSWYK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FAE0", Offset = "0x2B3E6E0", VA = "0x182B3FAE0")]
				internal bool VNMOZWBQGJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F8E0", Offset = "0x2B3E4E0", VA = "0x182B3F8E0")]
				internal void QJBGITFPLML(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F890", Offset = "0x2B3E490", VA = "0x182B3F890")]
				internal int QIVZLMLSCBC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F9C0", Offset = "0x2B3E5C0", VA = "0x182B3F9C0")]
				internal void QJLUDGTKEJD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F970", Offset = "0x2B3E570", VA = "0x182B3F970")]
				internal float QJGNFZZMUXU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F720", Offset = "0x2B3E320", VA = "0x182B3F720")]
				internal void QIGETSDZZTB(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F6D0", Offset = "0x2B3E2D0", VA = "0x182B3F6D0")]
				internal float QIAXWLKCQHS()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F800", Offset = "0x2B3E400", VA = "0x182B3F800")]
				internal void QIQSOFRUSPT(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F7B0", Offset = "0x2B3E3B0", VA = "0x182B3F7B0")]
				internal bool QILLQYXXJEK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F640", Offset = "0x2B3E240", VA = "0x182B3F640")]
				internal void QHLDERCKNZR(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B483E0", Offset = "0x2B46FE0", VA = "0x182B483E0")]
			public TFUCREDNBJY(XXEAPKVABFJ a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B472F0", Offset = "0x2B45EF0", VA = "0x182B472F0", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class ZMBATNECHCB : RVCQXCJMDWQ<RecNetImageNode>
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
				public ZMBATNECHCB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B4D3A0", Offset = "0x2B4BFA0", VA = "0x182B4D3A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B51D70", Offset = "0x2B50970", VA = "0x182B51D70")]
			public ZMBATNECHCB(XXEAPKVABFJ a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B51A40", Offset = "0x2B50640", VA = "0x182B51A40", Slot = "151")]
			protected override void IRNAQBPVSIH(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B51970", Offset = "0x2B50570", VA = "0x182B51970")]
			[CompilerGenerated]
			private string? DTXMPRDZTTR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B518A0", Offset = "0x2B504A0", VA = "0x182B518A0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void DTSFSKKCKII(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class KNJJYDUMGUT<a> : TCDLISVYSIA<a> where a : notnull, JYWFZASKOIZ
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class YYTPHXDUXQN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BPPXHKYUUYI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public KNJJYDUMGUT<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> YVFASBKPRPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> BJBTDBLAEXE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType LBPADSKDPBI;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public YYTPHXDUXQN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> VOXLGRKXULE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x51272C0", Offset = "0x5125EC0", VA = "0x1851272C0")]
				internal int VPCSDYEVDWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x5127080", Offset = "0x5125C80", VA = "0x185127080")]
				internal void VOMXMDXDBOM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x5127270", Offset = "0x5125E70", VA = "0x185127270")]
				internal void VOSEJKRAKZV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x5126F70", Offset = "0x5125B70", VA = "0x185126F70")]
				internal void VOCJRQJIIRU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x5126F10", Offset = "0x5125B10", VA = "0x185126F10")]
				internal bool VOHQOXDFSDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x5126EC0", Offset = "0x5125AC0", VA = "0x185126EC0")]
				internal void VNRVXCVNPVC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x5126F10", Offset = "0x5125B10", VA = "0x185126F10")]
				internal bool VNXCUJPKZGL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x5126E00", Offset = "0x5125A00", VA = "0x185126E00")]
				internal float VNHICPHSWYK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x5126E30", Offset = "0x5125A30", VA = "0x185126E30")]
				internal void VNMOZWBQGJT(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x5126CB0", Offset = "0x51258B0", VA = "0x185126CB0")]
				internal float QJBGITFPLML()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x5126C20", Offset = "0x5125820", VA = "0x185126C20")]
				internal void QIVZLMLSCBC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x5126D70", Offset = "0x5125970", VA = "0x185126D70")]
				internal float QJLUDGTKEJD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x5126CE0", Offset = "0x51258E0", VA = "0x185126CE0")]
				internal void QJGNFZZMUXU(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType MZMMVWGOQKQ
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x510D800", Offset = "0x510C400", VA = "0x18510D800")]
			public KNJJYDUMGUT(XXEAPKVABFJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x679F250", Offset = "0x679DE50", VA = "0x18679F250", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class GGIJIKTLMYN : TCDLISVYSIA<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xF3D440", Offset = "0xF3C040", VA = "0x180F3D440", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2B38580", Offset = "0x2B37180", VA = "0x182B38580")]
			public GGIJIKTLMYN(XXEAPKVABFJ a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class QYYDEHWUADA : BEEAOEXECTY<XXKDDQGSGLK>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x2B416A0", Offset = "0x2B402A0", VA = "0x182B416A0")]
			public QYYDEHWUADA(XXEAPKVABFJ a, XXKDDQGSGLK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class CKLKCPRDERA : BEEAOEXECTY<XZAHDJSJOXD>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x2B37140", Offset = "0x2B35D40", VA = "0x182B37140")]
			public CKLKCPRDERA(XXEAPKVABFJ a, XZAHDJSJOXD b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class BEEAOEXECTY<a> : TCDLISVYSIA<a> where a : notnull, URXRMPEQDDQ
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
				public BEEAOEXECTY<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x41C3CA0", Offset = "0x41C28A0", VA = "0x1841C3CA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class VQBWICMRXIG
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
					public VQBWICMRXIG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x41C29A0", Offset = "0x41C15A0", VA = "0x1841C29A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public VQBWICMRXIG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x41C2D70", Offset = "0x41C1970", VA = "0x1841C2D70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public VQBWICMRXIG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x41C35E0", Offset = "0x41C21E0", VA = "0x1841C35E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public VQBWICMRXIG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x41C39B0", Offset = "0x41C25B0", VA = "0x1841C39B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int PMHRBJOKSGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry UBGCJVIUSXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public BEEAOEXECTY<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<VEGTAJZNKQL, bool> JQVOIKXLXXF;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public VQBWICMRXIG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x7E5B110", Offset = "0x7E59D10", VA = "0x187E5B110")]
				internal bool VOSEJKRAKZV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x7E5B0A0", Offset = "0x7E59CA0", VA = "0x187E5B0A0")]
				internal void VOCJRQJIIRU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
				internal string VOHQOXDFSDD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x7E5AED0", Offset = "0x7E59AD0", VA = "0x187E5AED0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.VQBWICMRXIG.<<BuildConfigMenuInternal>b__6>d))]
				internal void VNRVXCVNPVC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x7E5AF90", Offset = "0x7E59B90", VA = "0x187E5AF90")]
				internal int VNXCUJPKZGL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x7E5ACB0", Offset = "0x7E598B0", VA = "0x187E5ACB0")]
				internal bool QJGNFZZMUXU(VEGTAJZNKQL a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x7E5AE20", Offset = "0x7E59A20", VA = "0x187E5AE20")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.VQBWICMRXIG.<<BuildConfigMenuInternal>b__8>d))]
				internal void VNHICPHSWYK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
				internal string QJBGITFPLML()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x7E5ABF0", Offset = "0x7E597F0", VA = "0x187E5ABF0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.VQBWICMRXIG.<<BuildConfigMenuInternal>b__11>d))]
				internal void QIVZLMLSCBC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x7E5ACD0", Offset = "0x7E598D0", VA = "0x187E5ACD0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.VQBWICMRXIG.<<BuildConfigMenuInternal>b__12>d))]
				internal void QJLUDGTKEJD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class QWQABXVDRJP
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x41BCDF0", Offset = "0x41BB9F0", VA = "0x1841BCDF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x41BD170", Offset = "0x41BBD70", VA = "0x1841BD170", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x41BD540", Offset = "0x41BC140", VA = "0x1841BD540", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x41BDB10", Offset = "0x41BC710", VA = "0x1841BDB10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x41BDDA0", Offset = "0x41BC9A0", VA = "0x1841BDDA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x41BE130", Offset = "0x41BCD30", VA = "0x1841BE130", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x41BE4C0", Offset = "0x41BD0C0", VA = "0x1841BE4C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x41BE750", Offset = "0x41BD350", VA = "0x1841BE750", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x41BEAE0", Offset = "0x41BD6E0", VA = "0x1841BEAE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x41BEE70", Offset = "0x41BDA70", VA = "0x1841BEE70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x41BF1F0", Offset = "0x41BDDF0", VA = "0x1841BF1F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x41BF480", Offset = "0x41BE080", VA = "0x1841BF480", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x41BF810", Offset = "0x41BE410", VA = "0x1841BF810", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x41BFAA0", Offset = "0x41BE6A0", VA = "0x1841BFAA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x41BFE30", Offset = "0x41BEA30", VA = "0x1841BFE30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x41C01B0", Offset = "0x41BEDB0", VA = "0x1841C01B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
					public QWQABXVDRJP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x41C0530", Offset = "0x41BF130", VA = "0x1841C0530", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public BEEAOEXECTY<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int PMHRBJOKSGI;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QWQABXVDRJP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x7644640", Offset = "0x7643240", VA = "0x187644640")]
				internal bool LUYQSCMYQJW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x76446A0", Offset = "0x76432A0", VA = "0x1876446A0")]
				internal void LVDXPJGVZVF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x7643A50", Offset = "0x7642650", VA = "0x187643A50")]
				internal object DFODOCDFZTJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x7643990", Offset = "0x7642590", VA = "0x187643990")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__13>d))]
				internal void DFIWQVJIQIA(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x7643E00", Offset = "0x7642A00", VA = "0x187643E00")]
				internal string DGTSXQSQEJL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x7643D40", Offset = "0x7642940", VA = "0x187643D40")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__15>d))]
				internal void DGOMAJYSUYC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x7643CC0", Offset = "0x76428C0", VA = "0x187643CC0")]
				internal bool DGJFDDEVLMT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x7643C30", Offset = "0x7642830", VA = "0x187643C30")]
				internal bool DGDYFWKYCBK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x7643F50", Offset = "0x7642B50", VA = "0x187643F50")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__18>d))]
				internal void DHOUMRUFQCV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x7643EA0", Offset = "0x7642AA0", VA = "0x187643EA0")]
				internal int DHJNPLAIGRM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x76443C0", Offset = "0x7642FC0", VA = "0x1876443C0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__20>d))]
				internal void KGPWHHZDIIK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x7644470", Offset = "0x7643070", VA = "0x187644470")]
				internal bool KGVDEOTARTT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x7644260", Offset = "0x7642E60", VA = "0x187644260")]
				internal float KGFIMULIPLS()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x7644310", Offset = "0x7642F10", VA = "0x187644310")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__23>d))]
				internal void KGKPKBFFYXB(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x7644140", Offset = "0x7642D40", VA = "0x187644140")]
				internal bool KFUUSGXNWPA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x76441D0", Offset = "0x7642DD0", VA = "0x1876441D0")]
				internal bool KGABPNRLGAJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x7644000", Offset = "0x7642C00", VA = "0x187644000")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__26>d))]
				internal void KFKGXTJTDSI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x76440B0", Offset = "0x7642CB0", VA = "0x1876440B0")]
				internal int KFPNVADQNDR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x7644500", Offset = "0x7643100", VA = "0x187644500")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__28>d))]
				internal void KIFZLKCIFVE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x76445B0", Offset = "0x76431B0", VA = "0x1876445B0")]
				internal bool KILGIQWFPGN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x7645030", Offset = "0x7643C30", VA = "0x187645030")]
				internal float RHHBGAHFYAT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x7644F80", Offset = "0x7643B80", VA = "0x187644F80")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__31>d))]
				internal void RHBUITNIOPK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x7645140", Offset = "0x7643D40", VA = "0x187645140")]
				internal bool RHRPANVAQXL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x76450C0", Offset = "0x7643CC0", VA = "0x1876450C0")]
				internal bool RHMIDHBDHMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x7645260", Offset = "0x7643E60", VA = "0x187645260")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__34>d))]
				internal void RICCVBIVJUD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x76451D0", Offset = "0x7643DD0", VA = "0x1876451D0")]
				internal bool RHWVXUOYAIU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x76453C0", Offset = "0x7643FC0", VA = "0x1876453C0")]
				internal bool RIMQPOWQCQV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x7645310", Offset = "0x7643F10", VA = "0x187645310")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__37>d))]
				internal void RIHJSICSTFM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x7644EF0", Offset = "0x7643AF0", VA = "0x187644EF0")]
				internal int RFQYBYEBANZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x7644E40", Offset = "0x7643A40", VA = "0x187644E40")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__39>d))]
				internal void RFLRERKDRCQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x7646F00", Offset = "0x7645B00", VA = "0x187646F00")]
				internal bool YHYGESPINTC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x7646F90", Offset = "0x7645B90", VA = "0x187646F90")]
				internal float YIDNBZJFXEL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x7647020", Offset = "0x7645C20", VA = "0x187647020")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__42>d))]
				internal void YIITZGDDGPU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x76470D0", Offset = "0x7645CD0", VA = "0x1876470D0")]
				internal bool YIOAWMXAQBD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x7646D40", Offset = "0x7645940", VA = "0x187646D40")]
				internal bool YHDEPRNTBZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x7646DC0", Offset = "0x76459C0", VA = "0x187646DC0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__45>d))]
				internal void YHILMYHQLLB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x7646E70", Offset = "0x7645A70", VA = "0x187646E70")]
				internal bool YHNSKFBNUWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x7644710", Offset = "0x7643310", VA = "0x187644710")]
				internal bool LVJEMQATJGO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x76447A0", Offset = "0x76433A0", VA = "0x1876447A0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__3>d))]
				internal void LVOLJWUQSRX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x7644850", Offset = "0x7643450", VA = "0x187644850")]
				internal int LVTSHDOOCDG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x76448E0", Offset = "0x76434E0", VA = "0x1876448E0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__5>d))]
				internal void LVYZEKILLOP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x7644990", Offset = "0x7643590", VA = "0x187644990")]
				internal bool LWEGBRCIUZY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x7644A20", Offset = "0x7643620", VA = "0x187644A20")]
				internal bool LWJMYXWGELH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x7644AB0", Offset = "0x76436B0", VA = "0x187644AB0")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__8>d))]
				internal void LWOTWEQDNWQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x7644B60", Offset = "0x7643760", VA = "0x187644B60")]
				internal int LWUATLKAXHZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x7643B80", Offset = "0x7642780", VA = "0x187643B80")]
				[AsyncStateMachine(typeof(BEEAOEXECTY<>.QWQABXVDRJP.<<AddConstraintOptions>b__10>d))]
				internal void DFYRIPRASQB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x7643AF0", Offset = "0x76426F0", VA = "0x187643AF0")]
				internal bool DFTKLIXDJES()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> PGYDNKCCRQE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> GLUJKPYCTAR;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<VEGTAJZNKQL> RONYDSGVNIT
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x4F0C7C0", Offset = "0x4F0B3C0", VA = "0x184F0C7C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x4F0D930", Offset = "0x4F0C530", VA = "0x184F0D930")]
			public BEEAOEXECTY(XXEAPKVABFJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x4F0C710", Offset = "0x4F0B310", VA = "0x184F0C710", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x4F0C810", Offset = "0x4F0B410", VA = "0x184F0C810", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x4F0B050", Offset = "0x4F09C50", VA = "0x184F0B050")]
			private XVJZGXTRVOP DPOXOKJCFLM(MNKEWZIOFVL a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x4F0D890", Offset = "0x4F0C490", VA = "0x184F0D890")]
			[AsyncStateMachine(typeof(BEEAOEXECTY<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void QZHBYRIBGFQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x4F0D830", Offset = "0x4F0C430", VA = "0x184F0D830")]
			[CompilerGenerated]
			private bool QZBVBKODWUH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class QNITYYCOENU : TCDLISVYSIA<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class UFMXOEVUXJC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public QNITYYCOENU DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UFMXOEVUXJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EC70", Offset = "0x2B4D870", VA = "0x182B4EC70")]
				internal int VPCSDYEVDWN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EAA0", Offset = "0x2B4D6A0", VA = "0x182B4EAA0")]
				internal void VOMXMDXDBOM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? YLIKLDFNKJV;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x2B41130", Offset = "0x2B3FD30", VA = "0x182B41130")]
			public QNITYYCOENU(XXEAPKVABFJ a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x2B40DD0", Offset = "0x2B3F9D0", VA = "0x182B40DD0", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class FXSGMZHHXMW : KNJJYDUMGUT<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType MZMMVWGOQKQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x2B381E0", Offset = "0x2B36DE0", VA = "0x182B381E0")]
			public FXSGMZHHXMW(XXEAPKVABFJ a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class BQHVVGRFYEZ : QGPHXRWTWSX<ONBLBLMOVCS>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x2B37070", Offset = "0x2B35C70", VA = "0x182B37070")]
			public BQHVVGRFYEZ(XXEAPKVABFJ a, ONBLBLMOVCS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class EKXHPDAEZKU : QGPHXRWTWSX<WVNGKYDZRZX>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2B377A0", Offset = "0x2B363A0", VA = "0x182B377A0")]
			public EKXHPDAEZKU(XXEAPKVABFJ a, WVNGKYDZRZX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class NONNCFTLOAQ : RVCQXCJMDWQ<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
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
					public HGOHUZHWDLD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x2B4D090", Offset = "0x2B4BC90", VA = "0x182B4D090", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public NONNCFTLOAQ DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x2B39790", Offset = "0x2B38390", VA = "0x182B39790")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void KAUUERWXLRZ(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EA60", Offset = "0x2B3D660", VA = "0x182B3EA60")]
			public NONNCFTLOAQ(XXEAPKVABFJ a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E760", Offset = "0x2B3D360", VA = "0x182B3E760", Slot = "151")]
			protected override void IRNAQBPVSIH(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class RXSVQCVVYNJ : KNJJYDUMGUT<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType MZMMVWGOQKQ
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x2B41940", Offset = "0x2B40540", VA = "0x182B41940")]
			public RXSVQCVVYNJ(XXEAPKVABFJ a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class SHFLSLGZJGG : TCDLISVYSIA<JWDVCHMDLEO>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xF1B000", Offset = "0xF19C00", VA = "0x180F1B000", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B41EA0", Offset = "0x2B40AA0", VA = "0x182B41EA0")]
			public SHFLSLGZJGG(XXEAPKVABFJ a, JWDVCHMDLEO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class ZXSAXWOAIPP : TCDLISVYSIA<MHRPVPWKOOC>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool RWQTHYMWCJK
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B52190", Offset = "0x2B50D90", VA = "0x182B52190")]
			public ZXSAXWOAIPP(XXEAPKVABFJ a, MHRPVPWKOOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B51E40", Offset = "0x2B50A40", VA = "0x182B51E40", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B52150", Offset = "0x2B50D50", VA = "0x182B52150")]
			private int XZXKOZXHMBL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B51DD0", Offset = "0x2B509D0", VA = "0x182B51DD0")]
			private void LACYTBKUEON(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class JWDQPPVFUPC : BSGSKGWBRTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B370D0", Offset = "0x2B35CD0", VA = "0x182B370D0")]
			public JWDQPPVFUPC(XXEAPKVABFJ a, KTFAJFRQMLO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class IDMPFQJFRRA : TCDLISVYSIA<UFNJWAIDZAT>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class QMUJENUQTSD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public IDMPFQJFRRA DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public QMUJENUQTSD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B404C0", Offset = "0x2B3F0C0", VA = "0x182B404C0")]
				internal int VOXLGRKXULE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B40900", Offset = "0x2B3F500", VA = "0x182B40900")]
				internal void VPCSDYEVDWN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3FEA0", Offset = "0x2B3EAA0", VA = "0x182B3FEA0")]
				internal int VOMXMDXDBOM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B40310", Offset = "0x2B3EF10", VA = "0x182B40310")]
				internal void VOSEJKRAKZV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xD27E90", Offset = "0xD26A90", VA = "0x180D27E90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B6D0", Offset = "0x2B3A2D0", VA = "0x182B3B6D0")]
			public IDMPFQJFRRA(XXEAPKVABFJ a, UFNJWAIDZAT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B3C0", Offset = "0x2B39FC0", VA = "0x182B3B3C0", Slot = "145")]
			protected sealed override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class UHYVLUXTYGP : RVCQXCJMDWQ<KJRXRAIBNAQ>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F990", Offset = "0x2B4E590", VA = "0x182B4F990")]
			public UHYVLUXTYGP(XXEAPKVABFJ a, KJRXRAIBNAQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class RVCQXCJMDWQ<a> : TCDLISVYSIA<a> where a : notnull, KJRXRAIBNAQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class MDJIIFNDRCE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public RVCQXCJMDWQ<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public MDJIIFNDRCE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x6EBDAD0", Offset = "0x6EBC6D0", VA = "0x186EBDAD0")]
				internal bool VOXLGRKXULE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x6EBDB00", Offset = "0x6EBC700", VA = "0x186EBDB00")]
				internal void VPCSDYEVDWN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x6EBDA10", Offset = "0x6EBC610", VA = "0x186EBDA10")]
				internal bool VOMXMDXDBOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x6EBDA40", Offset = "0x6EBC640", VA = "0x186EBDA40")]
				internal void VOSEJKRAKZV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x6EBD9A0", Offset = "0x6EBC5A0", VA = "0x186EBD9A0")]
				internal bool VOCJRQJIIRU()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class ACFWOTACWWL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public ZEQAUYTRFYT SETTGJNBPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public RVCQXCJMDWQ<a> DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public ACFWOTACWWL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x71C1760", Offset = "0x71C0360", VA = "0x1871C1760")]
				internal void KAUUERWXLRZ(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xD5A490", Offset = "0xD59090", VA = "0x180D5A490", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x769F930", Offset = "0x769E530", VA = "0x18769F930", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x769F820", Offset = "0x769E420", VA = "0x18769F820")]
			protected RVCQXCJMDWQ(XXEAPKVABFJ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x769F0A0", Offset = "0x769DCA0", VA = "0x18769F0A0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x769F470", Offset = "0x769E070", VA = "0x18769F470", Slot = "145")]
			protected override void ORGUQZCRGYU(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x769F190", Offset = "0x769DD90", VA = "0x18769F190", Slot = "151")]
			protected virtual void IRNAQBPVSIH(MNKEWZIOFVL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x769F7E0", Offset = "0x769E3E0", VA = "0x18769F7E0", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E630", Offset = "0x2B1D230", VA = "0x182B1E630")]
		public static NPOSFCMHTQF New(XXEAPKVABFJ circuitsManager, KTFAJFRQMLO node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class HVEHXQHLVQX : YORQLJFLTEB, RVXZWEYZRXG, WSYNBUDJKHM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<HSLAWAWHJXI> YHIRFEABRRU
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xEF0700", Offset = "0xEEF300", VA = "0x180EF0700", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<HSLAWAWHJXI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<BOADJKKKFWS> JFXTGZCUMFX
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x1513A80", Offset = "0x1512680", VA = "0x181513A80", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BOADJKKKFWS>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x23DB9A0", Offset = "0x23DA5A0", VA = "0x1823DB9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<LOGOYWSDYON> PJVOTDRUPGB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x144A990", Offset = "0x1449590", VA = "0x18144A990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<ODUYWEZJSCU> TLWCVAMIDZN
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B0D0", Offset = "0x2B39CD0", VA = "0x182B3B0D0", Slot = "22")]
			get
			{
				return default(Id32<ODUYWEZJSCU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B120", Offset = "0x2B39D20", VA = "0x182B3B120")]
		private HVEHXQHLVQX(XXEAPKVABFJ a, KTFAJFRQMLO b, VYOENVQBEXQ c, Id32<BNOAYSCHUMT> portGroupId, Id32<BOADJKKKFWS> outputId, Id32<LOGOYWSDYON> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AD80", Offset = "0x2B39980", VA = "0x182B3AD80")]
		public static HVEHXQHLVQX New(XXEAPKVABFJ circuitsManager, KTFAJFRQMLO node, VYOENVQBEXQ output, Id32<BNOAYSCHUMT> portGroupId, Id32<LOGOYWSDYON> outputDefId, Id32<BOADJKKKFWS> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x23DB9A0", Offset = "0x23DA5A0", VA = "0x1823DB9A0")]
		internal void ZKTNWMQZDXP(Id32<BOADJKKKFWS> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class YORQLJFLTEB : WSYNBUDJKHM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private XRSZPXGRLFJ? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DCF0", Offset = "0x2B3C8F0", VA = "0x182B3DCF0")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DD00", Offset = "0x2B3C900", VA = "0x182B3DD00")]
			public XRSZPXGRLFJ HZBZDRHTVPJ(YORQLJFLTEB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly KTFAJFRQMLO ONUJMVJVADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter CKOSGUDQWNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly YZGFSTWVNLM JIDDALIGOFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<MISKJVOSQZQ> FKNGVOZHHRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<JAVNBNSFSYI> RAMUQHOKNLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool MFTAPDJTMID;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> SCXMJKKPZOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B50300", Offset = "0x2B4EF00", VA = "0x182B50300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind ZVTLQPNRTIM
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD70", Offset = "0xD0B970", VA = "0x180D0CD70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<GNQADATMYDH> SJRWWGJZADD
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FC90", Offset = "0x2B4E890", VA = "0x182B4FC90", Slot = "6")]
			get
			{
				return default(Id32<GNQADATMYDH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<GNQADATMYDH> SVPJTVBLWVG
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FE60", Offset = "0x2B4EA60", VA = "0x182B4FE60", Slot = "7")]
			get
			{
				return default(Id128<GNQADATMYDH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public VEGTAJZNKQL ZPIMULZCFGO
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B50A60", Offset = "0x2B4F660", VA = "0x182B50A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public MIJHAUZGAMR HNJTNNNAIQX
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2B50440", Offset = "0x2B4F040", VA = "0x182B50440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected XRSZPXGRLFJ YDOSOGJYVSG
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B50440", Offset = "0x2B4F040", VA = "0x182B50440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage MKEEYUQXZBK
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B50810", Offset = "0x2B4F410", VA = "0x182B50810", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<NYBQVHGBIMX> USKNOJBCOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B507F0", Offset = "0x2B4F3F0", VA = "0x182B507F0", Slot = "9")]
			get
			{
				return default(Id128<NYBQVHGBIMX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<BNOAYSCHUMT> ATMHHTPTTPF
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xEEF700", Offset = "0xEEE300", VA = "0x180EEF700", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BNOAYSCHUMT>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1AAA870", Offset = "0x1AA9470", VA = "0x181AAA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<ODUYWEZJSCU> TLWCVAMIDZN
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool QQWWEZYVVAA
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xF50890", Offset = "0xF4F490", VA = "0x180F50890", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B514E0", Offset = "0x2B500E0", VA = "0x182B514E0")]
		protected YORQLJFLTEB(XXEAPKVABFJ a, KTFAJFRQMLO b, YZGFSTWVNLM c, Id32<BNOAYSCHUMT> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B501C0", Offset = "0x2B4EDC0", VA = "0x182B501C0", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FE90", Offset = "0x2B4EA90", VA = "0x182B4FE90", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B50950", Offset = "0x2B4F550", VA = "0x182B50950", Slot = "14")]
		public void NRUVMWXRMPZ(MISKJVOSQZQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B500F0", Offset = "0x2B4ECF0", VA = "0x182B500F0", Slot = "15")]
		public void IOVHBXIAPUR(JAVNBNSFSYI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B504D0", Offset = "0x2B4F0D0", VA = "0x182B504D0")]
		private bool LJFARFEANXW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B50C90", Offset = "0x2B4F890", VA = "0x182B50C90", Slot = "17")]
		public void YVCZUHXCZTF(ORBNQOVUKDU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B50A00", Offset = "0x2B4F600", VA = "0x182B50A00", Slot = "25")]
		protected virtual void PAEETNJFKXT(ORBNQOVUKDU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FF70", Offset = "0x2B4EB70", VA = "0x182B4FF70", Slot = "20")]
		private void HZNJTIRUOSK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B50AE0", Offset = "0x2B4F6E0", VA = "0x182B50AE0")]
		private void SUBXASSTKUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FCC0", Offset = "0x2B4E8C0", VA = "0x182B4FCC0")]
		private void BOGFDDTHWQN([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B502A0", Offset = "0x2B4EEA0", VA = "0x182B502A0", Slot = "18")]
		public void JBZHMRNWYUQ(MISKJVOSQZQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B50A80", Offset = "0x2B4F680", VA = "0x182B50A80", Slot = "19")]
		public void SRMZTATHPRM(JAVNBNSFSYI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
		internal void QRWTQZRELEP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B501A0", Offset = "0x2B4EDA0", VA = "0x182B501A0")]
		internal void IPFVACHZGBO(LEWVSLHMGCM a, VEGTAJZNKQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA870", Offset = "0x1AA9470", VA = "0x181AAA870")]
		internal void VVTJNBNJWCL(Id32<BNOAYSCHUMT> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class SNRMYWHFTJS : KYCFNPVYGVL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class FZCYHEXAVKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public XXEAPKVABFJ WNUGETGNPTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public KTFAJFRQMLO EOEQGJOKNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<BNOAYSCHUMT> OOKLYEKYKFV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool ONUOZRVGHWM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool HTJSOJUBBHZ;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FZCYHEXAVKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2B38240", Offset = "0x2B36E40", VA = "0x182B38240")]
			internal BURBBHTOTEG QUOIEJGCUCE((int PortDescIndex, int PortIndex, RGFQHCKBATZ InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2B38320", Offset = "0x2B36F20", VA = "0x182B38320")]
			internal HVEHXQHLVQX QUTPBQAADNN(VYOENVQBEXQ a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2B48950", Offset = "0x2B47550", VA = "0x182B48950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2B48DC0", Offset = "0x2B479C0", VA = "0x182B48DC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<THUAKEIUEGQ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A060", Offset = "0x2B48C60", VA = "0x182B4A060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A3B0", Offset = "0x2B48FB0", VA = "0x182B4A3B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A420", Offset = "0x2B49020", VA = "0x182B4A420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A8A0", Offset = "0x2B494A0", VA = "0x182B4A8A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<LOGOYWSDYON> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A910", Offset = "0x2B49510", VA = "0x182B4A910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2B4AC60", Offset = "0x2B49860", VA = "0x182B4AC60", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B490", Offset = "0x2B4A090", VA = "0x182B4B490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B7E0", Offset = "0x2B4A3E0", VA = "0x182B4B7E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<THUAKEIUEGQ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2B4ACD0", Offset = "0x2B498D0", VA = "0x182B4ACD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B040", Offset = "0x2B49C40", VA = "0x182B4B040", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<LOGOYWSDYON> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B0B0", Offset = "0x2B49CB0", VA = "0x182B4B0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B420", Offset = "0x2B4A020", VA = "0x182B4B420", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public GVQMAXHLXBC type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<THUAKEIUEGQ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B850", Offset = "0x2B4A450", VA = "0x182B4B850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BBF0", Offset = "0x2B4A7F0", VA = "0x182B4BBF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public GVQMAXHLXBC type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<LOGOYWSDYON> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BC60", Offset = "0x2B4A860", VA = "0x182B4BC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C000", Offset = "0x2B4AC00", VA = "0x182B4C000", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<THUAKEIUEGQ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<THUAKEIUEGQ> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C070", Offset = "0x2B4AC70", VA = "0x182B4C070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C3D0", Offset = "0x2B4AFD0", VA = "0x182B4C3D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public SNRMYWHFTJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<LOGOYWSDYON> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<LOGOYWSDYON> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private SZNXFZCEGDW <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C440", Offset = "0x2B4B040", VA = "0x182B4C440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C7A0", Offset = "0x2B4B3A0", VA = "0x182B4C7A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool DYBGUHRUYXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool PCBTDUBIGSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<YGYJAOJPYZV, BURBBHTOTEG> YKODRHNNTOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<YGYJAOJPYZV, XSKRLXQDISL> TKQPWXYZPST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly KTFAJFRQMLO ONUJMVJVADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<BOADJKKKFWS, HVEHXQHLVQX> PXQGOIJDTGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<BOADJKKKFWS, RVXZWEYZRXG> LHJKGFOHQNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? EYPVPMFPTDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly NXDSHMFFKMH MVFSJHLQZZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<BNOAYSCHUMT> CPYJQFOLJQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool CGCPGKOLIQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? YZYWKTRTKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? QRBVMHOPJPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<YGYJAOJPYZV>>? SCWJZDFWERF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<BOADJKKKFWS>>? YOYZLHETDEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private KYCFNPVYGVL.PortGroupIdChangeDelegate? UDFNUGMVZKM;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool ZPJQFXFMFKM
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B46910", Offset = "0x2B45510", VA = "0x182B46910", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool ECROPPDTJAR
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B44990", Offset = "0x2B43590", VA = "0x182B44990", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool EEKAXNBZEFR
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B42A00", Offset = "0x2B41600", VA = "0x182B42A00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<GNQADATMYDH> SVPJTVBLWVG
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B429D0", Offset = "0x2B415D0", VA = "0x182B429D0", Slot = "7")]
			get
			{
				return default(Id128<GNQADATMYDH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool OBKXCNOHCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B42150", Offset = "0x2B40D50", VA = "0x182B42150", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<YGYJAOJPYZV, XSKRLXQDISL> SQBOCQBZKIF
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<YGYJAOJPYZV, XSKRLXQDISL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B44420", Offset = "0x2B43020", VA = "0x182B44420", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<NYBQVHGBIMX> USKNOJBCOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B43F90", Offset = "0x2B42B90", VA = "0x182B43F90", Slot = "11")]
			get
			{
				return default(Id128<NYBQVHGBIMX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<BOADJKKKFWS, RVXZWEYZRXG> SGHAHVWJTAG
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<BOADJKKKFWS, RVXZWEYZRXG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<BNOAYSCHUMT> ATMHHTPTTPF
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x101B930", Offset = "0x101A530", VA = "0x18101B930", Slot = "13")]
			get
			{
				return default(Id32<BNOAYSCHUMT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? YGAGRUPTFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B43D80", Offset = "0x2B42980", VA = "0x182B43D80", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B432F0", Offset = "0x2B41EF0", VA = "0x182B432F0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? FNGQUANITMI
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B43240", Offset = "0x2B41E40", VA = "0x182B43240", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B421D0", Offset = "0x2B40DD0", VA = "0x182B421D0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<YGYJAOJPYZV?>, Id32<YGYJAOJPYZV?>>? KIFNZPRKLCH
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B43450", Offset = "0x2B42050", VA = "0x182B43450", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B46C10", Offset = "0x2B45810", VA = "0x182B46C10", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<YGYJAOJPYZV?>, Id32<YGYJAOJPYZV?>>? HXXWLADCFCM
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B42AC0", Offset = "0x2B416C0", VA = "0x182B42AC0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2B42B80", Offset = "0x2B41780", VA = "0x182B42B80", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<BOADJKKKFWS?>, Id32<BOADJKKKFWS?>>? LXUFCVHHIXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2B456A0", Offset = "0x2B442A0", VA = "0x182B456A0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2B45E90", Offset = "0x2B44A90", VA = "0x182B45E90", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<BOADJKKKFWS?>, Id32<BOADJKKKFWS?>>? QJURTTHXQNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2B46CD0", Offset = "0x2B458D0", VA = "0x182B46CD0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2B455E0", Offset = "0x2B441E0", VA = "0x182B455E0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<YGYJAOJPYZV?>, XSKRLXQDISL?>? UCBONALFANW
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2B45250", Offset = "0x2B43E50", VA = "0x182B45250", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2B449D0", Offset = "0x2B435D0", VA = "0x182B449D0", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<YGYJAOJPYZV?>>? TPXAHEWOHBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2B45440", Offset = "0x2B44040", VA = "0x182B45440", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2B45190", Offset = "0x2B43D90", VA = "0x182B45190", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<YGYJAOJPYZV?>, XSKRLXQDISL?>? VZYYIIOBLYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2B43BA0", Offset = "0x2B427A0", VA = "0x182B43BA0", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2B42280", Offset = "0x2B40E80", VA = "0x182B42280", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<BOADJKKKFWS?>, RVXZWEYZRXG?>? LUSXRHPVSMT
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2B43510", Offset = "0x2B42110", VA = "0x182B43510", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2B46E80", Offset = "0x2B45A80", VA = "0x182B46E80", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<BOADJKKKFWS?>>? BWKIFDTWNCY
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2B45500", Offset = "0x2B44100", VA = "0x182B45500", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2B45F50", Offset = "0x2B44B50", VA = "0x182B45F50", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<BOADJKKKFWS?>, RVXZWEYZRXG?>? UTEJZLRDPQX
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x2B43390", Offset = "0x2B41F90", VA = "0x182B43390", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x2B46F40", Offset = "0x2B45B40", VA = "0x182B46F40", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2B47090", Offset = "0x2B45C90", VA = "0x182B47090")]
		private SNRMYWHFTJS(bool a, XXEAPKVABFJ b, bool c, ReadOnlyIdArray<YGYJAOJPYZV, BURBBHTOTEG> inputs, ReadOnlyIdArray<YGYJAOJPYZV, XSKRLXQDISL> inputsAsStaticInputs, KTFAJFRQMLO d, ReadOnlyIdArray<BOADJKKKFWS, HVEHXQHLVQX> outputs, ReadOnlyIdArray<BOADJKKKFWS, RVXZWEYZRXG> outputsAsStaticOutputs, string? overrideName, NXDSHMFFKMH e, Id32<BNOAYSCHUMT> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2B44C40", Offset = "0x2B43840", VA = "0x182B44C40")]
		public static SNRMYWHFTJS New(bool canInteract, XXEAPKVABFJ circuitsManager, bool hasFunctionHeader, KTFAJFRQMLO node, NXDSHMFFKMH portGroup, Id32<BNOAYSCHUMT> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2B42DB0", Offset = "0x2B419B0", VA = "0x182B42DB0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2B428E0", Offset = "0x2B414E0", VA = "0x182B428E0", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, LYQWSZGLQZW?>>? CFAKAZYUFDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2B469D0", Offset = "0x2B455D0", VA = "0x182B469D0")]
		private (UZFXTAHMPZP?, int)? XENRJSWVSFQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2B43130", Offset = "0x2B41D30", VA = "0x182B43130", Slot = "58")]
		private void ETKKPUHJFTU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x23904D0", Offset = "0x238F0D0", VA = "0x1823904D0", Slot = "57")]
		private void AXDAEWIVKGV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2B44450", Offset = "0x2B43050", VA = "0x182B44450", Slot = "61")]
		private void MEZPWQRNCWD(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2B44A90", Offset = "0x2B43690", VA = "0x182B44A90", Slot = "63")]
		private void MZZIUZWYLBM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2B435D0", Offset = "0x2B421D0", VA = "0x182B435D0", Slot = "50")]
		private void IOYZUVDRTGJ(int a, Id32<YGYJAOJPYZV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2B455C0", Offset = "0x2B441C0", VA = "0x182B455C0", Slot = "54")]
		private void QLBRPEEUGTQ(int a, Id32<YGYJAOJPYZV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2B43B80", Offset = "0x2B42780", VA = "0x182B43B80", Slot = "49")]
		private void IXBOMWFWMMA(int a, Id32<YGYJAOJPYZV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2B464C0", Offset = "0x2B450C0", VA = "0x182B464C0", Slot = "53")]
		private void WEIETFUJDAN(int a, Id32<YGYJAOJPYZV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2B42C40", Offset = "0x2B41840", VA = "0x182B42C40", Slot = "66")]
		private void DXUCCKSENBX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4D0", Offset = "0x10FD0D0", VA = "0x1810FE4D0", Slot = "65")]
		private void LHVTADQMEMS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2B41F10", Offset = "0x2B40B10", VA = "0x182B41F10", Slot = "60")]
		private void AJNMQGFMIUB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x23904D0", Offset = "0x238F0D0", VA = "0x1823904D0", Slot = "59")]
		private void NFUUMRNYQWU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2B45AC0", Offset = "0x2B446C0", VA = "0x182B45AC0", Slot = "62")]
		private void ULIKEXPRMBI(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2B47000", Offset = "0x2B45C00", VA = "0x182B47000", Slot = "64")]
		private void ZGNJASZGSFT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2B42340", Offset = "0x2B40F40", VA = "0x182B42340", Slot = "52")]
		private void BYIOBBBHUKY(int a, Id32<BOADJKKKFWS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F70", Offset = "0x2B42B70", VA = "0x182B43F70", Slot = "56")]
		private void KRULVOEZBWV(int a, Id32<BOADJKKKFWS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F50", Offset = "0x2B42B50", VA = "0x182B43F50", Slot = "51")]
		private void KBOXBPAKBOT(int a, Id32<BOADJKKKFWS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2B43FB0", Offset = "0x2B42BB0", VA = "0x182B43FB0", Slot = "55")]
		private void LSKQKAEAQEQ(int a, Id32<BOADJKKKFWS> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2B44820", Offset = "0x2B43420", VA = "0x182B44820", Slot = "68")]
		private void MKTLYGITZPA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4D0", Offset = "0x10FD0D0", VA = "0x1810FE4D0", Slot = "67")]
		private void IZIARROPJVF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B45880", Offset = "0x2B44480", VA = "0x182B45880", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, LYQWSZGLQZW?>>? TXAQEFWOCUD(Id32<THUAKEIUEGQ> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2B46010", Offset = "0x2B44C10", VA = "0x182B46010", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, LYQWSZGLQZW?>>? VMUKWFSZZSM(Id32<LOGOYWSDYON> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2B45760", Offset = "0x2B44360", VA = "0x182B45760", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, LYQWSZGLQZW?>>? TDNLOYAMYGF(Id32<THUAKEIUEGQ> inputDefId, Id32<THUAKEIUEGQ> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2B43C60", Offset = "0x2B42860", VA = "0x182B43C60", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, LYQWSZGLQZW?>>? JJPASJBDPVK(Id32<LOGOYWSDYON> outputDefId, Id32<LOGOYWSDYON> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2B46D90", Offset = "0x2B45990", VA = "0x182B46D90", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, LYQWSZGLQZW?>>? YPHTMUIALAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2B44B20", Offset = "0x2B43720", VA = "0x182B44B20", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, LYQWSZGLQZW>> NITRUALOCTM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2B42020", Offset = "0x2B40C20", VA = "0x182B42020", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, LYQWSZGLQZW>> AKEWSDTVKHX(Id32<THUAKEIUEGQ> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2B45310", Offset = "0x2B43F10", VA = "0x182B45310", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, LYQWSZGLQZW>> ORWARURCYKO(Id32<LOGOYWSDYON> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2B43E20", Offset = "0x2B42A20", VA = "0x182B43E20", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, LYQWSZGLQZW>> JVMLPMMYKLA(Id32<THUAKEIUEGQ> inputDefId, GVQMAXHLXBC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2B45990", Offset = "0x2B44590", VA = "0x182B45990", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, LYQWSZGLQZW>> UKGUUPSBQNV(Id32<LOGOYWSDYON> outputDefId, GVQMAXHLXBC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2B46120", Offset = "0x2B44D20", VA = "0x182B46120")]
		internal void VVTJNBNJWCL(Id32<BNOAYSCHUMT> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class GFREUFWJHCW : QNOYLKOFSQJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface ODRSNXNZSZX
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<GNQADATMYDH>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<GNQADATMYDH>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			LEWVSLHMGCM LEWVSLHMGCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> AWSZELEBEWN(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> RVVDASCJTUY(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<PQNICHBJXRG> JKBYATXEJPB(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<WTDQFLYTVGY> ZMTBCCUJIAI(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> OQRSRFVBEYF(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> XINEUXSLEMI(CancellationToken a);
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
			public AsyncTaskMethodBuilder<GFREUFWJHCW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public XXEAPKVABFJ circuitsManager;

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
			private ODRSNXNZSZX <selfDeps>5__2;

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
			private PQNICHBJXRG <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private WTDQFLYTVGY <playerSaveData>5__8;

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
			private TaskAwaiter<PQNICHBJXRG> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<WTDQFLYTVGY> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<ODRSNXNZSZX.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<UVZHGVMFUGK> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2B48E30", Offset = "0x2B47A30", VA = "0x182B48E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x2B49FF0", Offset = "0x2B48BF0", VA = "0x182B49FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public UVZHGVMFUGK UVZHGVMFUGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public CYXAPTBONCA CYXAPTBONCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public SYNKKRIBQFD SYNKKRIBQFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public KEHJKNTJZOR KEHJKNTJZOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1120590", Offset = "0x111F190", VA = "0x181120590")]
		private GFREUFWJHCW(UVZHGVMFUGK a, CYXAPTBONCA b, SYNKKRIBQFD c, KEHJKNTJZOR d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x2B383F0", Offset = "0x2B36FF0", VA = "0x182B383F0")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<GFREUFWJHCW> DQEKPYXKQNX(XXEAPKVABFJ a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x2B38560", Offset = "0x2B37160", VA = "0x182B38560", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class RGCQDGKZILM : EEERQAOJJHT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public KQXQRPUSXTI? UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x2B41770", Offset = "0x2B40370", VA = "0x182B41770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		internal RGCQDGKZILM(XXEAPKVABFJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class SYNKKRIBQFD : KQXQRPUSXTI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly UVZHGVMFUGK YDCCNTNQGNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly RGCQDGKZILM ONEZLEFHVBN;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> EQADLBYZETX
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x2B472B0", Offset = "0x2B45EB0", VA = "0x182B472B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xDD8300", Offset = "0xDD6F00", VA = "0x180DD8300")]
		public SYNKKRIBQFD(XXEAPKVABFJ a, UVZHGVMFUGK b, RGCQDGKZILM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x2B47200", Offset = "0x2B45E00", VA = "0x182B47200", Slot = "5")]
		public string PLTECZSWWWX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2B47250", Offset = "0x2B45E50", VA = "0x182B47250", Slot = "6")]
		public void TSMFVPCMYOO(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BA00", Offset = "0x2B5A600", VA = "0x182B5BA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BC40", Offset = "0x2B5A840", VA = "0x182B5BC40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, LYQWSZGLQZW>> <>t__builder;

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
			private FXFJUDAMIWO[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C440", Offset = "0x2B5B040", VA = "0x182B5C440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C810", Offset = "0x2B5B410", VA = "0x182B5C810", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public FXFJUDAMIWO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x2B60B30", Offset = "0x2B5F730", VA = "0x182B60B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x2B60F40", Offset = "0x2B5FB40", VA = "0x182B60F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly HATGOKICMKB _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		public EVRequestExtended(HATGOKICMKB staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2B37A50", Offset = "0x2B36650", VA = "0x182B37A50")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, LYQWSZGLQZW>> NRYLSGMUOIZ(FXFJUDAMIWO a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2B378F0", Offset = "0x2B364F0", VA = "0x182B378F0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, LYQWSZGLQZW?>>? MUXPAMPFERI(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2B37800", Offset = "0x2B36400", VA = "0x182B37800")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, LYQWSZGLQZW>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface XVENBBMCSIN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		QNOYLKOFSQJ? UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool ATPYNSOEZHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<QNOYLKOFSQJ?>? UURDZGUEJHP();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task SNNUVSLYUCG(XXEAPKVABFJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface QNOYLKOFSQJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		UVZHGVMFUGK UVZHGVMFUGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		CYXAPTBONCA CYXAPTBONCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		SYNKKRIBQFD SYNKKRIBQFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		KEHJKNTJZOR KEHJKNTJZOR
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class DUIMJXGATLQ
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2B52F00", Offset = "0x2B51B00", VA = "0x182B52F00")]
		public static ReducerFactory<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>> AVLLBPFBCQL([In] this ReducerFactory<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class ZMZHZWJQYGR : EQFICGHEXRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool ATPYNSOEZHS
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x2B67180", Offset = "0x2B65D80", VA = "0x182B67180", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		internal ZMZHZWJQYGR(XXEAPKVABFJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class CKBXBIEZVZQ : XMDBMIVUYYH
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2B52DD0", Offset = "0x2B519D0", VA = "0x182B52DD0", Slot = "4")]
		public RFLVGEDKILL? OYGCCXTWAAK(string? a, string? b, string? c, RoomDoorData.TCTYKJDUXLX.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D00", Offset = "0x2B51900", VA = "0x182B52D00", Slot = "5")]
		public VACCOMDUVZD HKFOJLENVSI(string a, string b, List<string> c, int d, int e, int f, int g, LWORYGMRXNX h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x2B52E60", Offset = "0x2B51A60", VA = "0x182B52E60", Slot = "6")]
		public LWORYGMRXNX XFPSQBKUQNI(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public CKBXBIEZVZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class WSHJYNNKVMC : QIKCKNGZMSF
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
			public AsyncTaskMethodBuilder<EOMRJYDEACK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public WSHJYNNKVMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<QNOYLKOFSQJ?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BCB0", Offset = "0x2B5A8B0", VA = "0x182B5BCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BF40", Offset = "0x2B5AB40", VA = "0x182B5BF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public EOMRJYDEACK? UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2B62350", Offset = "0x2B60F50", VA = "0x182B62350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public KEHJKNTJZOR? NEVUTTDTHHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2B622D0", Offset = "0x2B60ED0", VA = "0x182B622D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool UXUZAVQREDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2B62270", Offset = "0x2B60E70", VA = "0x182B62270", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool DPACYKHIDQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2B62920", Offset = "0x2B61520", VA = "0x182B62920", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2B62C20", Offset = "0x2B61820", VA = "0x182B62C20")]
		internal WSHJYNNKVMC(XXEAPKVABFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2B629B0", Offset = "0x2B615B0", VA = "0x182B629B0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<EOMRJYDEACK> UURDZGUEJHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2B623D0", Offset = "0x2B60FD0", VA = "0x182B623D0", Slot = "9")]
		public IReadOnlyDictionary<Id128<GNQADATMYDH>, Guid> PFAROLNHEXD(IEnumerable<YMQXVRQNJLQ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2B62AA0", Offset = "0x2B616A0", VA = "0x182B62AA0", Slot = "10")]
		public CircuitGraphToolMappingRegistryData ZRPQWMIDVOF(IEnumerable<YMQXVRQNJLQ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x2B62750", Offset = "0x2B61350", VA = "0x182B62750")]
		public Result<CircuitsRoomData, SCULPNIXVDU> QZZGETOOWBH([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, SCULPNIXVDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2B62980", Offset = "0x2B61580", VA = "0x182B62980", Slot = "8")]
		private Result<CircuitsRoomData, SCULPNIXVDU> UNEIMVDVPUU([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, SCULPNIXVDU>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class KEHJKNTJZOR : EOMRJYDEACK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class YTBMFCAQACI
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int OGYROGBFCZZ;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2B53440", Offset = "0x2B52040", VA = "0x182B53440")]
				internal void STIALZDSKFY(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2B66C70", Offset = "0x2B65870", VA = "0x182B66C70")]
			public static Result<EOMRJYDEACK.PrepareTemplateForCloneResult, RTVNPFLLCNZ> XTRREELNPZX(KEHJKNTJZOR a, [In] EOMRJYDEACK.PrepareTemplateForCloneArgs args)
			{
				return default(Result<EOMRJYDEACK.PrepareTemplateForCloneResult, RTVNPFLLCNZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2B65A10", Offset = "0x2B64610", VA = "0x182B65A10")]
			internal static Result<(VYCXURPXVRU, CircuitTemplateRootData), RTVNPFLLCNZ> VBUPCLUIYWL(KEHJKNTJZOR a, CircuitTemplateRootData b, bool c, [In] Id128<GNQADATMYDH> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(VYCXURPXVRU, CircuitTemplateRootData), RTVNPFLLCNZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2B65550", Offset = "0x2B64150", VA = "0x182B65550")]
			private static void JYHCUTZRJRL(bool a, YMQXVRQNJLQ b, VYCXURPXVRU c, [In] Id128<GNQADATMYDH> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2B66870", Offset = "0x2B65470", VA = "0x182B66870")]
			public static void XCABGBTIBRU(NEAYWMKOJYN a, [In] EOMRJYDEACK.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2B64FC0", Offset = "0x2B63BC0", VA = "0x182B64FC0")]
			[CompilerGenerated]
			internal static bool FDAXQCNBEJZ(UVZHGVMFUGK a, WRFHDLXQCSV b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x2B659E0", Offset = "0x2B645E0", VA = "0x182B659E0")]
			[CompilerGenerated]
			internal static bool SBHDQIOZFHA(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class SYBXOOZKNZU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public KEHJKNTJZOR DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<GNQADATMYDH> MVOMHJAUCTU;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public SYBXOOZKNZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B1F0", Offset = "0x2B59DF0", VA = "0x182B5B1F0")]
			internal Id128<NYBQVHGBIMX> WJXSVSHJRIR(Id32<NYBQVHGBIMX> a)
			{
				return default(Id128<NYBQVHGBIMX>);
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<HSLAWAWHJXI> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<CCKCDLBLEMF> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C880", Offset = "0x2B5B480", VA = "0x182B5C880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2B5CE50", Offset = "0x2B5BA50", VA = "0x182B5CE50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<BNOAYSCHUMT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<THUAKEIUEGQ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2B5CEC0", Offset = "0x2B5BAC0", VA = "0x182B5CEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D210", Offset = "0x2B5BE10", VA = "0x182B5D210", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<NYBQVHGBIMX>, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<GAWNVANSVBY> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private UVZHGVMFUGK <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D560", Offset = "0x2B5C160", VA = "0x182B5D560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D990", Offset = "0x2B5C590", VA = "0x182B5D990", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D280", Offset = "0x2B5BE80", VA = "0x182B5D280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D4F0", Offset = "0x2B5C0F0", VA = "0x182B5D4F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DA00", Offset = "0x2B5C600", VA = "0x182B5DA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DBF0", Offset = "0x2B5C7F0", VA = "0x182B5DBF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<GNQADATMYDH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<NYBQVHGBIMX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<NYBQVHGBIMX>> nodeIds;

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
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DC60", Offset = "0x2B5C860", VA = "0x182B5DC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DF00", Offset = "0x2B5CB00", VA = "0x182B5DF00", Slot = "5")]
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
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<GNQADATMYDH> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<NYBQVHGBIMX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<NYBQVHGBIMX>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<BNOAYSCHUMT>, Id32<YGYJAOJPYZV>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<BNOAYSCHUMT>, Id32<BOADJKKKFWS>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DF70", Offset = "0x2B5CB70", VA = "0x182B5DF70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E540", Offset = "0x2B5D140", VA = "0x182B5E540", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<GNQADATMYDH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<NYBQVHGBIMX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<NYBQVHGBIMX>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E5A0", Offset = "0x2B5D1A0", VA = "0x182B5E5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E7B0", Offset = "0x2B5D3B0", VA = "0x182B5E7B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<NYBQVHGBIMX> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<BNOAYSCHUMT> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<YGYJAOJPYZV> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E820", Offset = "0x2B5D420", VA = "0x182B5E820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2B5EB70", Offset = "0x2B5D770", VA = "0x182B5EB70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<BNOAYSCHUMT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<THUAKEIUEGQ> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2B5EBE0", Offset = "0x2B5D7E0", VA = "0x182B5EBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2B5EFC0", Offset = "0x2B5DBC0", VA = "0x182B5EFC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F030", Offset = "0x2B5DC30", VA = "0x182B5F030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F2B0", Offset = "0x2B5DEB0", VA = "0x182B5F2B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<NYBQVHGBIMX> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<BNOAYSCHUMT> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<BOADJKKKFWS> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F320", Offset = "0x2B5DF20", VA = "0x182B5F320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F670", Offset = "0x2B5E270", VA = "0x182B5F670", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F6E0", Offset = "0x2B5E2E0", VA = "0x182B5F6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FA20", Offset = "0x2B5E620", VA = "0x182B5FA20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FA90", Offset = "0x2B5E690", VA = "0x182B5FA90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FD20", Offset = "0x2B5E920", VA = "0x182B5FD20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FD90", Offset = "0x2B5E990", VA = "0x182B5FD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2B60020", Offset = "0x2B5EC20", VA = "0x182B60020", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<NYBQVHGBIMX>>, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<GNQADATMYDH> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<YMQXVRQNJLQ> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<KTFAJFRQMLO>, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2B60090", Offset = "0x2B5EC90", VA = "0x182B60090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2B60830", Offset = "0x2B5F430", VA = "0x182B60830", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<GNQADATMYDH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<NYBQVHGBIMX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<NYBQVHGBIMX>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2B608A0", Offset = "0x2B5F4A0", VA = "0x182B608A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B60AC0", Offset = "0x2B5F6C0", VA = "0x182B60AC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public KEHJKNTJZOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<GNQADATMYDH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<NYBQVHGBIMX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2B61020", Offset = "0x2B5FC20", VA = "0x182B61020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2B61240", Offset = "0x2B5FE40", VA = "0x182B61240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly XXEAPKVABFJ DJOACGOLDJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly UVZHGVMFUGK YDCCNTNQGNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers FCMPEMDFMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly WSHJYNNKVMC QLXNKPKMYFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<NYBQVHGBIMX>, NPOSFCMHTQF> VICJPXPTUDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<NYBQVHGBIMX>>? CHWGJGTSWUJ;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<GNQADATMYDH> EYWJPLNVMAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x2B585B0", Offset = "0x2B571B0", VA = "0x182B585B0", Slot = "4")]
			get
			{
				return default(Id128<GNQADATMYDH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers TLVBMUCUIUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2B55D80", Offset = "0x2B54980", VA = "0x182B55D80", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> DPWYFUVRJNW
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B591C0", Offset = "0x2B57DC0", VA = "0x182B591C0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action DTVEKQIVSMT
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A2D0", Offset = "0x2B58ED0", VA = "0x182B5A2D0", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B577C0", Offset = "0x2B563C0", VA = "0x182B577C0", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> UWRJSZCKWTX
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B57190", Offset = "0x2B55D90", VA = "0x182B57190", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B56A50", Offset = "0x2B55650", VA = "0x182B56A50", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AAD0", Offset = "0x2B596D0", VA = "0x182B5AAD0")]
		public KEHJKNTJZOR(XXEAPKVABFJ a, UVZHGVMFUGK b, WSHJYNNKVMC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2B545F0", Offset = "0x2B531F0", VA = "0x182B545F0", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2B55720", Offset = "0x2B54320", VA = "0x182B55720", Slot = "100")]
		public Id32<QXOKFCPPCNZ> FYRHOIOADQY(Id32<GNQADATMYDH> graphId, Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<QXOKFCPPCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2B55760", Offset = "0x2B54360", VA = "0x182B55760", Slot = "101")]
		public Id32<INHIQYBSXOG> GHQNHRIYTWX(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<INHIQYBSXOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2B55780", Offset = "0x2B54380", VA = "0x182B55780", Slot = "6")]
		public (bool, bool) GLVMTKFSWYI(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2B54300", Offset = "0x2B52F00", VA = "0x182B54300")]
		public bool DWESNDMIAFT(Id32<GNQADATMYDH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2B581B0", Offset = "0x2B56DB0", VA = "0x182B581B0", Slot = "8")]
		public bool PTJZACIFZAF(XSKRLXQDISL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2B59140", Offset = "0x2B57D40", VA = "0x182B59140", Slot = "9")]
		public bool RILECFOVYHO(RVXZWEYZRXG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A140", Offset = "0x2B58D40", VA = "0x182B5A140", Slot = "10")]
		public AbsoluteLegacyInputId? WBIVVUZEARZ(Id32<GNQADATMYDH> graphId, Id32<CCKCDLBLEMF> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2B57130", Offset = "0x2B55D30", VA = "0x182B57130", Slot = "11")]
		public AbsoluteLegacyOutputId? LMSKJSEGDTM(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A900", Offset = "0x2B59500", VA = "0x182B5A900", Slot = "12")]
		public Id32<HSLAWAWHJXI>? ZOBSDJNELUA(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<BOADJKKKFWS> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2B56BB0", Offset = "0x2B557B0", VA = "0x182B56BB0", Slot = "13")]
		public Id32<CCKCDLBLEMF>? JGJFFTRDEIF(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<YGYJAOJPYZV> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B53D10", Offset = "0x2B52910", VA = "0x182B53D10", Slot = "14")]
		public IEnumerable<Id32<GNQADATMYDH>> CLVTWHYXMTD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B54770", Offset = "0x2B53370", VA = "0x182B54770", Slot = "15")]
		public IEnumerable<Id32<RTWBXADMJQX>> ETBRHBYVHQO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B574D0", Offset = "0x2B560D0", VA = "0x182B574D0", Slot = "22")]
		public string MGXXTBTDKDE(Id32<RTWBXADMJQX> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B57500", Offset = "0x2B56100", VA = "0x182B57500", Slot = "16")]
		public Id32<RTWBXADMJQX>? MKMZNTQFLEK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B53B70", Offset = "0x2B52770", VA = "0x182B53B70", Slot = "17")]
		public int BXPCLOKRLPR(Id32<RTWBXADMJQX> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B54750", Offset = "0x2B53350", VA = "0x182B54750", Slot = "18")]
		public int EMAKKTMTIOY(Id32<RTWBXADMJQX> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B58550", Offset = "0x2B57150", VA = "0x182B58550", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] QAVOIIZUIRT(Id32<RTWBXADMJQX> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B546F0", Offset = "0x2B532F0", VA = "0x182B546F0", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] EGHHOCBEDCS(Id32<RTWBXADMJQX> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3BE4AE0", Offset = "0x3BE36E0", VA = "0x183BE4AE0")]
		private static (CircuitTypeIdWrapper, string?)[]? DKPVXECOXGD<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A200", Offset = "0x2B58E00", VA = "0x182B5A200", Slot = "21")]
		public string XGRUVZLLWTM(Id32<RTWBXADMJQX> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B53B90", Offset = "0x2B52790", VA = "0x182B53B90", Slot = "23")]
		public string CBZBPJZFNYP(Id32<RTWBXADMJQX> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B57D50", Offset = "0x2B56950", VA = "0x182B57D50")]
		public NPOSFCMHTQF? OBPWZMAPYQA([In] Id128<NYBQVHGBIMX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B542E0", Offset = "0x2B52EE0", VA = "0x182B542E0", Slot = "30")]
		public Id32<GAWNVANSVBY> DPKTVJQSSES(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32<GAWNVANSVBY>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B54000", Offset = "0x2B52C00", VA = "0x182B54000")]
		public Id32<NYBQVHGBIMX> MCXSKZRCNIB(Id32<GNQADATMYDH> graphId, [In] Id128<NYBQVHGBIMX> legacyNodeId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B53FE0", Offset = "0x2B52BE0", VA = "0x182B53FE0", Slot = "40")]
		public Id32<NYBQVHGBIMX> CYNQEIPYYCC(Id32<GNQADATMYDH> graphId, Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B55C20", Offset = "0x2B54820", VA = "0x182B55C20", Slot = "41")]
		public Id32<NYBQVHGBIMX> GMOPBQPDBZD(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B59FE0", Offset = "0x2B58BE0", VA = "0x182B59FE0")]
		public Id32<NYBQVHGBIMX>? VOOSLGAAJMV(Id32<GNQADATMYDH> graphId, [In] Id128<NYBQVHGBIMX> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A6B0", Offset = "0x2B592B0", VA = "0x182B5A6B0", Slot = "32")]
		public AbsoluteNodeId? YIHGAVFKGLV(Id32<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B57800", Offset = "0x2B56400", VA = "0x182B57800", Slot = "33")]
		public long MYSUHZAUTGY()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B57E80", Offset = "0x2B56A80", VA = "0x182B57E80")]
		private void OIMTGUYOYGE(Id128<NYBQVHGBIMX> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B53AE0", Offset = "0x2B526E0", VA = "0x182B53AE0", Slot = "38")]
		public IEnumerable<(Id32<GNQADATMYDH>, Id32<NYBQVHGBIMX>)> BVJSYEXHMPU(Id32<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B56BE0", Offset = "0x2B557E0", VA = "0x182B56BE0", Slot = "39")]
		public Id32<CCKCDLBLEMF> JGJFFTRDEIF(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A930", Offset = "0x2B59530", VA = "0x182B5A930", Slot = "42")]
		public Id32<HSLAWAWHJXI> ZOBSDJNELUA(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B595F0", Offset = "0x2B581F0", VA = "0x182B595F0")]
		private NPOSFCMHTQF? TYXBJSXULZJ([In] Id128<NYBQVHGBIMX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B538D0", Offset = "0x2B524D0", VA = "0x182B538D0")]
		public KTFAJFRQMLO? AQLJDQKCJRD([In] Id128<NYBQVHGBIMX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B54800", Offset = "0x2B53400", VA = "0x182B54800")]
		public MHPCUTAZFHR? TICHQCHLWJG([In] Id128<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B59580", Offset = "0x2B58180", VA = "0x182B59580", Slot = "25")]
		public MHPCUTAZFHR? TICHQCHLWJG(Id32<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B59660", Offset = "0x2B58260", VA = "0x182B59660", Slot = "34")]
		public IEnumerable<NewStaticEdge> UGLSCKRQSVW(Id32<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B570D0", Offset = "0x2B55CD0", VA = "0x182B570D0", Slot = "35")]
		public bool KZYOQAMPOCY(Id32<RTWBXADMJQX> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B56800", Offset = "0x2B55400", VA = "0x182B56800", Slot = "36")]
		public IEnumerable<StableStaticEdge> IJREUFOMSUY(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B58AD0", Offset = "0x2B576D0", VA = "0x182B58AD0", Slot = "37")]
		public IEnumerable<StableStaticEdge> QPXDXSDFIYL(Id32<GNQADATMYDH> graphId, Id32<CCKCDLBLEMF> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B59410", Offset = "0x2B58010", VA = "0x182B59410")]
		public Id32<GNQADATMYDH> SSGCXYYTUAF([In] Id128<GNQADATMYDH> graphId)
		{
			return default(Id32<GNQADATMYDH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B53FB0", Offset = "0x2B52BB0", VA = "0x182B53FB0")]
		public Id32<GNQADATMYDH>? CVXQUOSUMYZ([In] Id128<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A230", Offset = "0x2B58E30", VA = "0x182B5A230")]
		private WRFHDLXQCSV? XJPJMFHXATV([In] Id128<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B54800", Offset = "0x2B53400", VA = "0x182B54800")]
		private MHPCUTAZFHR? OKYMZCUEDQG([In] Id128<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B59700", Offset = "0x2B58300", VA = "0x182B59700", Slot = "28")]
		public Id32<GNQADATMYDH>? UMXOQZJUWKQ(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B55380", Offset = "0x2B53F80", VA = "0x182B55380", Slot = "46")]
		public Id128<GNQADATMYDH> FOZRRJKYXMQ(Id32<GNQADATMYDH> graphId)
		{
			return default(Id128<GNQADATMYDH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B577E0", Offset = "0x2B563E0", VA = "0x182B577E0", Slot = "47")]
		public Id128<NYBQVHGBIMX> MYFHRXOWMOS(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id128<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B57F40", Offset = "0x2B56B40", VA = "0x182B57F40", Slot = "43")]
		public IEnumerable<GVQMAXHLXBC> PENIZDSVDNK(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D20", Offset = "0x2B57920", VA = "0x182B58D20", Slot = "44")]
		public GVQMAXHLXBC QQLUCZMSGMV(RoomVersion a, WSYNBUDJKHM b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B57C60", Offset = "0x2B56860", VA = "0x182B57C60")]
		public NewStaticEdge XHWAYFERQYT(Id32<GNQADATMYDH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B56A70", Offset = "0x2B55670", VA = "0x182B56A70", Slot = "48")]
		public StableStaticEdge IWXVBVAJAJA(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A7B0", Offset = "0x2B593B0", VA = "0x182B5A7B0", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, LYQWSZGLQZW>> ZDOFUUKUJNB(Id32<GNQADATMYDH> parentGraphId, Id32<NYBQVHGBIMX> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B53490", Offset = "0x2B52090", VA = "0x182B53490", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, LYQWSZGLQZW>> AEQRZOCZVMW(Id32<GNQADATMYDH> parentGraphId, Id128<NYBQVHGBIMX> boardNodeId, List<Id32<NYBQVHGBIMX>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B57380", Offset = "0x2B55F80", VA = "0x182B57380", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, LYQWSZGLQZW>> LYKCDQEHVSX(Id32<GNQADATMYDH> parentGraphId, Id128<NYBQVHGBIMX> boardNodeId, List<Id32<NYBQVHGBIMX>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B583F0", Offset = "0x2B56FF0", VA = "0x182B583F0", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, LYQWSZGLQZW>> PZWDPDVPFAV(Id32<GNQADATMYDH> parentGraphId, Id128<NYBQVHGBIMX> boardNodeId, Id32<GNQADATMYDH> graphId, List<Id32<NYBQVHGBIMX>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B59E70", Offset = "0x2B58A70", VA = "0x182B59E70", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<BNOAYSCHUMT>, Id32<YGYJAOJPYZV>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<BNOAYSCHUMT>, Id32<BOADJKKKFWS>)>) VDGMEKBSNPQ(Id128<GNQADATMYDH> legacyGraphId, Id32<NYBQVHGBIMX> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<BNOAYSCHUMT>, Id32<YGYJAOJPYZV>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<BNOAYSCHUMT>, Id32<BOADJKKKFWS>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B58040", Offset = "0x2B56C40", VA = "0x182B58040", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task PFRRLXBKWGU(Id128<GNQADATMYDH> legacyGraphId, Id128<NYBQVHGBIMX> boardNodeId, IReadOnlyList<Id128<NYBQVHGBIMX>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<BNOAYSCHUMT>, Id32<YGYJAOJPYZV>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<BNOAYSCHUMT>, Id32<BOADJKKKFWS>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A690", Offset = "0x2B59290", VA = "0x182B5A690", Slot = "55")]
		public bool YAMHQRFLNYQ(Id32<GNQADATMYDH> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B595D0", Offset = "0x2B581D0", VA = "0x182B595D0", Slot = "56")]
		public bool TWHTYLXVPJO(Id32<GNQADATMYDH> graphId, Id32<CCKCDLBLEMF> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B57F20", Offset = "0x2B56B20", VA = "0x182B57F20", Slot = "57")]
		public bool OSHGRTQOOAN(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B53460", Offset = "0x2B52060", VA = "0x182B53460")]
		public Result<EOMRJYDEACK.PrepareTemplateForCloneResult, RTVNPFLLCNZ> CAHZJSEWDZT([In] EOMRJYDEACK.PrepareTemplateForCloneArgs args)
		{
			return default(Result<EOMRJYDEACK.PrepareTemplateForCloneResult, RTVNPFLLCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A010", Offset = "0x2B58C10", VA = "0x182B5A010", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, LYQWSZGLQZW>> VVEYBOPIYZT(Id32<GNQADATMYDH> graphId, Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B59220", Offset = "0x2B57E20", VA = "0x182B59220", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<NYBQVHGBIMX>, LYQWSZGLQZW>> SHBMEVNXKJK(Id32<GNQADATMYDH> graphId, Id32<GAWNVANSVBY> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B59440", Offset = "0x2B58040", VA = "0x182B59440", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> TDMHXXMMMJL(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B553A0", Offset = "0x2B53FA0", VA = "0x182B553A0", Slot = "62")]
		public Result<ControlPanelRootData, SCULPNIXVDU> FQNFWOWCRTT(Id128<GNQADATMYDH> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, SCULPNIXVDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B53BB0", Offset = "0x2B527B0", VA = "0x182B53BB0", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, LYQWSZGLQZW>> CJBSPXNWEQB(Id128<GNQADATMYDH> graphId, Id128<NYBQVHGBIMX> inputNodeId, Id32<BNOAYSCHUMT> inputPortGroupId, Id32<YGYJAOJPYZV> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B53610", Offset = "0x2B52210", VA = "0x182B53610", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, LYQWSZGLQZW>> AIJNZRYIVPG(Id128<GNQADATMYDH> graphId, Id128<NYBQVHGBIMX> outputNodeId, Id32<BNOAYSCHUMT> outputPortGroupId, Id32<BOADJKKKFWS> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B57270", Offset = "0x2B55E70", VA = "0x182B57270", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, LYQWSZGLQZW>> LXESZAPMKNP(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B53D80", Offset = "0x2B52980", VA = "0x182B53D80", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<NYBQVHGBIMX>>, LYQWSZGLQZW>> CMQRAVFDYXI(Id128<GNQADATMYDH> intoGraphId, CircuitTemplateRootData a, IEnumerable<YMQXVRQNJLQ> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B53910", Offset = "0x2B52510", VA = "0x182B53910", Slot = "67")]
		public CircuitsData BFNMGGUKKIY()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B59380", Offset = "0x2B57F80", VA = "0x182B59380", Slot = "68")]
		public CircuitsData SRNHXIPPQXX()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B58230", Offset = "0x2B56E30", VA = "0x182B58230", Slot = "71")]
		public CircuitsTemplateData PULOJUOZZEG(TemplateSerializationReason a, Id32<GNQADATMYDH> sourceGraphId, IEnumerable<Id128<GNQADATMYDH>> graphIds, IEnumerable<Id128<NYBQVHGBIMX>> nodeIds, ISet<Id128<FHADUUSLUOP>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A2F0", Offset = "0x2B58EF0", VA = "0x182B5A2F0")]
		private CircuitsTemplateData XNCNKVDHACD(TemplateSerializationReason a, Id32<GNQADATMYDH> sourceGraphId, IEnumerable<Id128<GNQADATMYDH>> graphIds, IEnumerable<Id128<NYBQVHGBIMX>> nodeIds, ISet<Id128<FHADUUSLUOP>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B56D60", Offset = "0x2B55960", VA = "0x182B56D60", Slot = "69")]
		public CircuitsTemplateData KYICCAUQTUV(TemplateSerializationReason a, Id32<GNQADATMYDH> sourceGraphId, IEnumerable<Id128<NYBQVHGBIMX>> nodeIds, IEnumerable<YMQXVRQNJLQ> b, ISet<Id128<FHADUUSLUOP>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B56FC0", Offset = "0x2B55BC0", VA = "0x182B56FC0", Slot = "70")]
		public CircuitsTemplateData KYICCAUQTUV(TemplateSerializationReason a, Id32<GNQADATMYDH> sourceGraphId, IEnumerable<Id32<NYBQVHGBIMX>> nodeIds, IEnumerable<YMQXVRQNJLQ> b, ISet<Id128<FHADUUSLUOP>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B57820", Offset = "0x2B56420", VA = "0x182B57820")]
		private static IEnumerable<Id128<GNQADATMYDH>> NKNADSEIHLV(IEnumerable<YMQXVRQNJLQ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B585D0", Offset = "0x2B571D0", VA = "0x182B585D0")]
		private IEnumerable<Id128<NYBQVHGBIMX>> QLNCKREFEIP(IEnumerable<YMQXVRQNJLQ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B591E0", Offset = "0x2B57DE0", VA = "0x182B591E0", Slot = "72")]
		public List<NDAUWUAEWVI> RVIMMEWXCDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B59800", Offset = "0x2B58400", VA = "0x182B59800")]
		public (List<NDAUWUAEWVI>, bool) UPWTLDXAATD([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, CCEZIAZAKCW b, GYLDOFPAMRI c)
		{
			return default((List<NDAUWUAEWVI>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A510", Offset = "0x2B59110", VA = "0x182B5A510", Slot = "74")]
		public bool XPKZGSKAJOE(Id32<GNQADATMYDH> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B54110", Offset = "0x2B52D10", VA = "0x182B54110", Slot = "75")]
		public bool DLQLIGUXDAW(Id32<GNQADATMYDH> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B58190", Offset = "0x2B56D90", VA = "0x182B58190")]
		internal void PNAZCQVIQJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B55740", Offset = "0x2B54340", VA = "0x182B55740")]
		internal Task GCZYQEQTUIR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B55E50", Offset = "0x2B54A50", VA = "0x182B55E50", Slot = "76")]
		public Result<Id32<HSLAWAWHJXI>?, LYQWSZGLQZW> IDJPUEPISWF(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<CCKCDLBLEMF> inputId)
		{
			return default(Result<Id32<HSLAWAWHJXI>?, LYQWSZGLQZW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B54830", Offset = "0x2B53430", VA = "0x182B54830", Slot = "77")]
		public Result<Id32<CCKCDLBLEMF>?, LYQWSZGLQZW> EXLGMJVTDLP(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<HSLAWAWHJXI> outputId)
		{
			return default(Result<Id32<CCKCDLBLEMF>?, LYQWSZGLQZW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A5A0", Offset = "0x2B591A0", VA = "0x182B5A5A0", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, LYQWSZGLQZW>> XYDYJBGZOPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B541A0", Offset = "0x2B52DA0", VA = "0x182B541A0", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, LYQWSZGLQZW>> DPISPDGDXIA(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B552C0", Offset = "0x2B53EC0", VA = "0x182B552C0", Slot = "80")]
		public Id32<NYBQVHGBIMX>? FHZHZPPWHWW(Id32<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B571B0", Offset = "0x2B55DB0", VA = "0x182B571B0", Slot = "81")]
		public Id32<NYBQVHGBIMX>? LPIPWMDHMNJ(Id32<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A480", Offset = "0x2B59080", VA = "0x182B5A480", Slot = "82")]
		public int XODRMSIMXHF(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B53EE0", Offset = "0x2B52AE0", VA = "0x182B53EE0", Slot = "83")]
		public int COCDNGTJFPK(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B54030", Offset = "0x2B52C30", VA = "0x182B54030", Slot = "84")]
		public int DKUQNQTPFQF(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<THUAKEIUEGQ> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B551E0", Offset = "0x2B53DE0", VA = "0x182B551E0", Slot = "85")]
		public int FDRVQNWQQMX(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<THUAKEIUEGQ> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B56C10", Offset = "0x2B55810", VA = "0x182B56C10", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, LYQWSZGLQZW>> KEZLVYUTVTN(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<THUAKEIUEGQ> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B539A0", Offset = "0x2B525A0", VA = "0x182B539A0", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, LYQWSZGLQZW>> BLRRSUYCMOY(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, Id32<THUAKEIUEGQ> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D90", Offset = "0x2B54990", VA = "0x182B55D90", Slot = "88")]
		public int HTJRKNCZYXF(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B55C40", Offset = "0x2B54840", VA = "0x182B55C40", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, LYQWSZGLQZW>> GNNWYBVXNKJ(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B53770", Offset = "0x2B52370", VA = "0x182B53770", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, LYQWSZGLQZW>> AMFWGFKDWZE(Id32<GNQADATMYDH> graphId, Id32<NYBQVHGBIMX> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A960", Offset = "0x2B59560", VA = "0x182B5A960", Slot = "91")]
		public bool ZRWCDEDVCVB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B57F00", Offset = "0x2B56B00", VA = "0x182B57F00", Slot = "97")]
		public IEnumerable<Id32<BYAWOSQMXDX>> ONBBBBDVFVH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2B583D0", Offset = "0x2B56FD0", VA = "0x182B583D0", Slot = "98")]
		public string? PZKNEELXAFD(Id32<BYAWOSQMXDX> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2B56D50", Offset = "0x2B55950", VA = "0x182B56D50", Slot = "7")]
		private bool KNWTRKPBXHD(Id32<GNQADATMYDH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2B54800", Offset = "0x2B53400", VA = "0x182B54800", Slot = "24")]
		private MHPCUTAZFHR EWBTWSBSZCA([In] Id128<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2B59410", Offset = "0x2B58010", VA = "0x182B59410", Slot = "26")]
		private Id32<GNQADATMYDH> XOIYZYRYONL([In] Id128<GNQADATMYDH> graphId)
		{
			return default(Id32<GNQADATMYDH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2B53FB0", Offset = "0x2B52BB0", VA = "0x182B53FB0", Slot = "27")]
		private Id32<GNQADATMYDH>? DZDEIGAPYXD([In] Id128<GNQADATMYDH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2B59020", Offset = "0x2B57C20", VA = "0x182B59020", Slot = "29")]
		private NPOSFCMHTQF QVZENCZXSRW([In] Id128<NYBQVHGBIMX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B54000", Offset = "0x2B52C00", VA = "0x182B54000", Slot = "31")]
		private Id32<NYBQVHGBIMX> DGIDUIPPJUJ(Id32<GNQADATMYDH> graphId, [In] Id128<NYBQVHGBIMX> legacyNodeId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2B57C60", Offset = "0x2B56860", VA = "0x182B57C60", Slot = "45")]
		private NewStaticEdge NTGCTKRJLHJ(Id32<GNQADATMYDH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2B53460", Offset = "0x2B52060", VA = "0x182B53460", Slot = "58")]
		private Result<EOMRJYDEACK.PrepareTemplateForCloneResult, RTVNPFLLCNZ> ABPIFNTNBMN([In] EOMRJYDEACK.PrepareTemplateForCloneArgs args)
		{
			return default(Result<EOMRJYDEACK.PrepareTemplateForCloneResult, RTVNPFLLCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A1A0", Offset = "0x2B58DA0", VA = "0x182B5A1A0", Slot = "73")]
		private (List<NDAUWUAEWVI>, bool) XCVKUFYDXKR([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, CCEZIAZAKCW b, GYLDOFPAMRI c)
		{
			return default((List<NDAUWUAEWVI>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2B57BF0", Offset = "0x2B567F0", VA = "0x182B57BF0")]
		[CompilerGenerated]
		private UVAGMVFXMFX NPDUQGLDSWW(VEGTAJZNKQL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2B54690", Offset = "0x2B53290", VA = "0x182B54690")]
		[CompilerGenerated]
		private KTFAJFRQMLO YHPLYQAKVNY(Id128<NYBQVHGBIMX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2B546C0", Offset = "0x2B532C0", VA = "0x182B546C0")]
		[CompilerGenerated]
		private WRFHDLXQCSV YHUSVWUIEZH(Id128<GNQADATMYDH> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2B54690", Offset = "0x2B53290", VA = "0x182B54690")]
		[CompilerGenerated]
		private KTFAJFRQMLO EAMZHHZZNIO(Id128<NYBQVHGBIMX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2B546C0", Offset = "0x2B532C0", VA = "0x182B546C0")]
		[CompilerGenerated]
		private WRFHDLXQCSV EASGEOTWWTX(Id128<GNQADATMYDH> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class UVAGMVFXMFX : GVQMAXHLXBC
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
			public AsyncTaskMethodBuilder<Result<Id32<THUAKEIUEGQ>, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public UVAGMVFXMFX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<BNOAYSCHUMT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<THUAKEIUEGQ>, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B480", Offset = "0x2B5A080", VA = "0x182B5B480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B6D0", Offset = "0x2B5A2D0", VA = "0x182B5B6D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<LOGOYWSDYON>, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public UVAGMVFXMFX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<GNQADATMYDH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<NYBQVHGBIMX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<BNOAYSCHUMT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<LOGOYWSDYON>, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B740", Offset = "0x2B5A340", VA = "0x182B5B740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B990", Offset = "0x2B5A590", VA = "0x182B5B990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly VEGTAJZNKQL UROBPLORHXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly UVZHGVMFUGK YDCCNTNQGNU;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey KPULWLWMOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF270", VA = "0x180D00670", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string YYGBBSQVFLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x2B618F0", Offset = "0x2B604F0", VA = "0x182B618F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public VEGTAJZNKQL VEGTAJZNKQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2B61A90", Offset = "0x2B60690", VA = "0x182B61A90")]
		public UVAGMVFXMFX(VEGTAJZNKQL a, UVZHGVMFUGK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2B61780", Offset = "0x2B60380", VA = "0x182B61780", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<THUAKEIUEGQ>, LYQWSZGLQZW>> CGDTXSNNXBK(Id128<GNQADATMYDH> graphId, Id128<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2B61920", Offset = "0x2B60520", VA = "0x182B61920", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<LOGOYWSDYON>, LYQWSZGLQZW>> XKJFTHKWJEZ(Id128<GNQADATMYDH> graphId, Id128<NYBQVHGBIMX> nodeId, Id32<BNOAYSCHUMT> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class XRSZPXGRLFJ : MIJHAUZGAMR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly VEGTAJZNKQL LQRVLOPHYNV;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<VEGTAJZNKQL> LBWDUQNYLWL;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<VEGTAJZNKQL> EQAOATBNYPO;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<VEGTAJZNKQL> BOLEFRSOYRX;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public VEGTAJZNKQL XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2B64BE0", Offset = "0x2B637E0", VA = "0x182B64BE0", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2B64BD0", Offset = "0x2B637D0", VA = "0x182B64BD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2B64C30", Offset = "0x2B63830", VA = "0x182B64C30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2B64B50", Offset = "0x2B63750", VA = "0x182B64B50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2B62F90", Offset = "0x2B61B90", VA = "0x182B62F90")]
		public bool VPWDAIBPJGY(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public XRSZPXGRLFJ(VEGTAJZNKQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2B62E00", Offset = "0x2B61A00", VA = "0x182B62E00")]
		internal static TypeKey IREKBNGTKUR(VEGTAJZNKQL a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2B618F0", Offset = "0x2B604F0", VA = "0x182B618F0", Slot = "3")]
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
	public readonly struct ActionDeps : BROQOKBSSNY.YKZQUSYDSWF<FXFJUDAMIWO, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2B52A40", Offset = "0x2B51640", VA = "0x182B52A40", Slot = "4")]
		public int OYXEXLDCGMH(None a, FXFJUDAMIWO b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2B529B0", Offset = "0x2B515B0", VA = "0x182B529B0", Slot = "5")]
		public FXFJUDAMIWO GKEVOQPHTSS(None a, FXFJUDAMIWO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2B52A10", Offset = "0x2B51610", VA = "0x182B52A10", Slot = "6")]
		public FXFJUDAMIWO ODYEYUEQJRX(None a, FXFJUDAMIWO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2B52950", Offset = "0x2B51550", VA = "0x182B52950", Slot = "7")]
		public IReadOnlyList<FXFJUDAMIWO> CSHNESOYXML(None a, FXFJUDAMIWO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2B529E0", Offset = "0x2B515E0", VA = "0x182B529E0", Slot = "8")]
		public FXFJUDAMIWO[] LQGJYPVZJUG(None a, FXFJUDAMIWO b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2B52970", Offset = "0x2B51570", VA = "0x182B52970", Slot = "9")]
		public bool FMUNCUCAWSL(None a, FXFJUDAMIWO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2B52A60", Offset = "0x2B51660", VA = "0x182B52A60", Slot = "10")]
		public bool SCIGTHQOBAD(None a, FXFJUDAMIWO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B529C0", Offset = "0x2B515C0", VA = "0x182B529C0", Slot = "11")]
		public bool IOBOTFFQSVV(None a, FXFJUDAMIWO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2B52990", Offset = "0x2B51590", VA = "0x182B52990", Slot = "12")]
		public bool FQNQCNJTWHJ(None a, FXFJUDAMIWO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2B52A80", Offset = "0x2B51680", VA = "0x182B52A80", Slot = "13")]
		public bool VTGCBVPAEPX(None a, FXFJUDAMIWO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2B529F0", Offset = "0x2B515F0", VA = "0x182B529F0", Slot = "14")]
		public bool MTVQSCZDHPG(None a, FXFJUDAMIWO b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class LNXNQHAWWHS : HAHYOVHKCDQ
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract HLQSLBGKSFS.ODRSNXNZSZX SWMSEXOCKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract XXEAPKVABFJ.ODRSNXNZSZX KUDMWPWEUFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract GFREUFWJHCW.ODRSNXNZSZX CNTZRWREGMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ> ZKACJCVERLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AF40", Offset = "0x2B59B40", VA = "0x182B5AF40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.ODRSNXNZSZX HZQEDPZHDBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract SZNXFZCEGDW WDOKEZLXTRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract CNGANKRQXIV WFSWMWLMNXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract WNSVIDJHVWR IPYCYPEMXYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract LGZSDACFKQJ XFDGRKSQAAE
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract CBQIBVXTUYH ALSEHUSRKSO
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected LNXNQHAWWHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class BRGNUUNCGBK : VQSMLZFTUYU
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
			public AsyncTaskMethodBuilder<Result<MultiResult, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<FXFJUDAMIWO> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public BRGNUUNCGBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BFB0", Offset = "0x2B5ABB0", VA = "0x182B5BFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C3D0", Offset = "0x2B5AFD0", VA = "0x182B5C3D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public BRGNUUNCGBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public FXFJUDAMIWO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2B60D30", Offset = "0x2B5F930", VA = "0x182B60D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2B60FB0", Offset = "0x2B5FBB0", VA = "0x182B60FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly HATGOKICMKB ZANOBJGVLZV;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public BRGNUUNCGBK(HATGOKICMKB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2B52BD0", Offset = "0x2B517D0", VA = "0x182B52BD0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, LYQWSZGLQZW>> NRYLSGMUOIZ(FXFJUDAMIWO a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2B52AA0", Offset = "0x2B516A0", VA = "0x182B52AA0", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, LYQWSZGLQZW>> HGEJOZOHWGJ(IReadOnlyList<FXFJUDAMIWO> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FXFJUDAMIWO, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x12B8AE0", Offset = "0x12B76E0", VA = "0x1812B8AE0")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FXFJUDAMIWO, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B190", Offset = "0x2B59D90", VA = "0x182B5B190")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class JHPXIIPYJWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FXFJUDAMIWO, PartialActionReassemblyDeps> QOPCXEBIBWS(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FXFJUDAMIWO, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : ALPHHFYIIRA.VCVAKIZRWMY<PartialActionPayload, Id128<PartialActionPayload.M>, FXFJUDAMIWO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AF90", Offset = "0x2B59B90", VA = "0x182B5AF90", Slot = "7")]
		public FXFJUDAMIWO GMTRNTABLCO(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x12ABB40", Offset = "0x12AA740", VA = "0x1812ABB40")]
		public Id128<PartialActionPayload.M> NKRXGMBDOGU([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x102B9F0", Offset = "0x102A5F0", VA = "0x18102B9F0")]
		public int SSMUINUJJTK([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B180", Offset = "0x2B59D80", VA = "0x182B5B180")]
		public int LRIHXJUVERJ([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x102B9F0", Offset = "0x102A5F0", VA = "0x18102B9F0", Slot = "4")]
		private int RCQJUCLBONS([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B180", Offset = "0x2B59D80", VA = "0x182B5B180", Slot = "5")]
		private int WGQTONEUPXZ([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x12ABB40", Offset = "0x12AA740", VA = "0x1812ABB40", Slot = "6")]
		private Id128<PartialActionPayload.M> MQAFZTAASZO([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, FXFJUDAMIWO, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x12B8AE0", Offset = "0x12B76E0", VA = "0x1812B8AE0")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, FXFJUDAMIWO, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B420", Offset = "0x2B5A020", VA = "0x182B5B420")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class FIROUVJODKU
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0")]
		public static SnapshotReassembly<PartialInitializePayload, FXFJUDAMIWO, SnapshotReassemblyDeps> QOPCXEBIBWS(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, FXFJUDAMIWO, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : EKBONRRLKQF.VDAHHPTPFYH<PartialInitializePayload, FXFJUDAMIWO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x102B990", Offset = "0x102A590", VA = "0x18102B990")]
		public int WFYUGQNOLBU([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B230", Offset = "0x2B59E30", VA = "0x182B5B230", Slot = "5")]
		public FXFJUDAMIWO MTDELWOFSOI(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x102B990", Offset = "0x102A590", VA = "0x18102B990", Slot = "4")]
		private int VUMUJZXHPPQ([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class XWJEQVCOSAI : ARGBUOZFZQD, RTVNPFLLCNZ, LYQWSZGLQZW, SCULPNIXVDU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly SCULPNIXVDU? HUIUFMWNZKC;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind JPOHFKUZLGS
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xCF8B80", Offset = "0xCF7780", VA = "0x180CF8B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override SCULPNIXVDU? MMGQYJNJTCH
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B64D50", Offset = "0x2B63950", VA = "0x182B64D50", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B64F80", Offset = "0x2B63B80", VA = "0x182B64F80")]
		private XWJEQVCOSAI(PrepareTemplateForCloneErrKind a, SCULPNIXVDU? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B64F10", Offset = "0x2B63B10", VA = "0x182B64F10")]
		public static XWJEQVCOSAI WDQHHOXNAUM(SCULPNIXVDU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2B64EB0", Offset = "0x2B63AB0", VA = "0x182B64EB0")]
		public static XWJEQVCOSAI VXRNGXZSOHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x2B64E50", Offset = "0x2B63A50", VA = "0x182B64E50")]
		public static XWJEQVCOSAI SIBWJTTVBPG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class NVHHQDLRYZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3D59400", Offset = "0x3D58000", VA = "0x183D59400")]
		public static Result<TOk, RTVNPFLLCNZ> NZKKEOHUKXL<TOk>([In] this Result<TOk, RTVNPFLLCNZ> self, SCULPNIXVDU a) where TOk : notnull
		{
			return default(Result<TOk, RTVNPFLLCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x3D59380", Offset = "0x3D57F80", VA = "0x183D59380")]
		public static Result<a?, RTVNPFLLCNZ?> IYXGGXHLCZP<a>([In] this Result<a, RTVNPFLLCNZ> self)
		{
			return default(Result<a, RTVNPFLLCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x3D59230", Offset = "0x3D57E30", VA = "0x183D59230")]
		public static Result<b?, RTVNPFLLCNZ?> CGBXPYTVXGD<b>([In] this Result<b, RTVNPFLLCNZ> self)
		{
			return default(Result<b, RTVNPFLLCNZ>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface SZNXFZCEGDW
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool QFZTOAODTXC([In] Result<None, SCULPNIXVDU> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class FHFKUNIKJVM
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDCC0", Offset = "0x3ABC8C0", VA = "0x183ABDCC0")]
		public static bool QFZTOAODTXC<TOk, TErr>(this SZNXFZCEGDW a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, SCULPNIXVDU
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface CNGANKRQXIV
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		SDSGZEUUWRN YQTEFQFJPLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface WNSVIDJHVWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor VIMIFHQSXTK(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface FVZNZURIEIM
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface UKIHQPXWSHB
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KQXWWBSEEID? XMVXMBRDCLG(Id32<BNOAYSCHUMT> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface REVRSLLGKJX
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface KQXWWBSEEID
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		REVRSLLGKJX? LGEKWPCRNQG(Id32<THUAKEIUEGQ> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FVZNZURIEIM? SEDNTZICPFD(Id32<LOGOYWSDYON> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface LGZSDACFKQJ
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> JJTJBIWFBKB(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface CBQIBVXTUYH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UKIHQPXWSHB? ZCYLECTEUFY([In] Id128<VJPEKKVEEYH> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class VLZLILPILMS
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
			public readonly List<FXFJUDAMIWO> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B533F0", Offset = "0x2B51FF0", VA = "0x182B533F0")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<FXFJUDAMIWO> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2B53340", Offset = "0x2B51F40", VA = "0x182B53340")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly IFUPDXXXCYH<Diagnostic> SSXMNTKVDOU;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static VLZLILPILMS UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2B61CF0", Offset = "0x2B608F0", VA = "0x182B61CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool CQTTTOVNBHY
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD44270", Offset = "0xD42E70", VA = "0x180D44270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xE0B9D0", Offset = "0xE0A5D0", VA = "0x180E0B9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B61D40", Offset = "0x2B60940", VA = "0x182B61D40")]
		public void REROXDVIRVH(UVZHGVMFUGK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B61E00", Offset = "0x2B60A00", VA = "0x182B61E00")]
		public void XGUXMSCBSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B61B30", Offset = "0x2B60730", VA = "0x182B61B30")]
		private static string? IENLOZFWGUO([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B621D0", Offset = "0x2B60DD0", VA = "0x182B621D0")]
		public VLZLILPILMS()
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
