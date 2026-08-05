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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1EA40", Offset = "0x2B1DA40", VA = "0x182B1EA40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1CF70", Offset = "0x2B1BF70", VA = "0x182B1CF70", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class ICGXRSEYDCA : IDisposable, BJUMBGVMPMR, RHBEVTOFNRW, HZDZKNYYBAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class RTTBFFUBHQH : ICTTKLBYQGC
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int UVNQWCUIGRF
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FF60", Offset = "0x2B1EF60", VA = "0x182B1FF60", Slot = "5")]
			public ZBDLQYWPAME DDGSJNGYEUP(VFCMMUNYJTZ.ICTTKLBYQGC a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void GTYVTIEZIJX();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void ZYOXWTOMFHC();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2B07910", Offset = "0x2B06910", VA = "0x182B07910", Slot = "13")]
			public virtual void HOYSMFAEHEU(ICGXRSEYDCA a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2B20090", Offset = "0x2B1F090", VA = "0x182B20090", Slot = "14")]
			public virtual void YPAMYJIIZAR(ICGXRSEYDCA a, AGLENQQYPWD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			protected RTTBFFUBHQH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ICTTKLBYQGC
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int UVNQWCUIGRF
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			ZBDLQYWPAME DDGSJNGYEUP(VFCMMUNYJTZ.ICTTKLBYQGC a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void GTYVTIEZIJX();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void ZYOXWTOMFHC();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void HOYSMFAEHEU(ICGXRSEYDCA a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void YPAMYJIIZAR(ICGXRSEYDCA a, AGLENQQYPWD b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, AGLENQQYPWD, ICGXRSEYDCA, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x137A110", Offset = "0x1379110", VA = "0x18137A110")]
			internal Reducer(Reducer<ActionKind, AGLENQQYPWD, ICGXRSEYDCA, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class CAKQIGJUQSF : WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly CAKQIGJUQSF HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private CAKQIGJUQSF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB79300", Offset = "0xB78300", VA = "0x180B79300", Slot = "4")]
			public ActionKind FUSKWAEUPWZ(AGLENQQYPWD a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2B19830", Offset = "0x2B18830", VA = "0x182B19830", Slot = "5")]
			public void HOYSMFAEHEU(ICGXRSEYDCA a, AGLENQQYPWD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2B19940", Offset = "0x2B18940", VA = "0x182B19940", Slot = "6")]
			public void YPAMYJIIZAR(ICGXRSEYDCA a, AGLENQQYPWD b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, AGLENQQYPWD, ICGXRSEYDCA, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2B208D0", Offset = "0x2B1F8D0", VA = "0x182B208D0")]
			internal ReducerFactory(ReducerFactory<ActionKind, AGLENQQYPWD, ICGXRSEYDCA, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B20880", Offset = "0x2B1F880", VA = "0x182B20880")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : DYPZVZBTZVR.JZLCIPLUUMV<AGLENQQYPWD, ICGXRSEYDCA>
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
				public AsyncTaskMethodBuilder<Result<object?, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public ICGXRSEYDCA receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public AGLENQQYPWD action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B22110", Offset = "0x2B21110", VA = "0x182B22110", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B222F0", Offset = "0x2B212F0", VA = "0x182B222F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB2F6E0", Offset = "0xB2E6E0", VA = "0x180B2F6E0", Slot = "4")]
			public Id32<DQQOGREBWGB> SYIMCCQOIGS(ICGXRSEYDCA a)
			{
				return default(Id32<DQQOGREBWGB>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B211B0", Offset = "0x2B201B0", VA = "0x182B211B0", Slot = "5")]
			public void ERKWVMFOTTH(ICGXRSEYDCA a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B21080", Offset = "0x2B20080", VA = "0x182B21080", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, BGYAXKJXFCB>> BBSKMHTYCDG(ICGXRSEYDCA a, AGLENQQYPWD b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B21210", Offset = "0x2B20210", VA = "0x182B21210", Slot = "7")]
			public AGLENQQYPWD[] NALQIHPHHQS(ICGXRSEYDCA a)
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
			public AsyncTaskMethodBuilder<Result<object?, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public ICGXRSEYDCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AGLENQQYPWD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B22360", Offset = "0x2B21360", VA = "0x182B22360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2B22550", Offset = "0x2B21550", VA = "0x182B22550", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ICGXRSEYDCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2B23A90", Offset = "0x2B22A90", VA = "0x182B23A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2B23D10", Offset = "0x2B22D10", VA = "0x182B23D10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ICGXRSEYDCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2B23D80", Offset = "0x2B22D80", VA = "0x182B23D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2B23F60", Offset = "0x2B22F60", VA = "0x182B23F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<DQQOGREBWGB> ATSOMHZHQLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer PPSCSDGJIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 RGAXTLORCSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly JVEJJWJVKSR LSNQHBREMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly AGDBBCFQBWL.CreationArgs JPWHKFOQYSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly ECERKASTBJS OCZXCOHCQYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly WNGLUIHQDBZ UXWHBNRDWPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly INKIUZFENHG NYKUICIOLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly EJLRQQSYDUB FVZBQGHZCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly DCUBLFRNOPJ AJRRKUUHTQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly NMCPBMAVUBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly PRBYADLHGVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest PYOJYHMITSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended UAYITMDUGGW;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal ICTTKLBYQGC ZHEIXYWXCVP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A7B0", Offset = "0x2B197B0", VA = "0x182B1A7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal ZBDLQYWPAME FCCKDXOZPRN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A800", Offset = "0x2B19800", VA = "0x182B1A800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A790", Offset = "0x2B19790", VA = "0x182B1A790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool GDLCCOYEMVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B4A0", Offset = "0x2B1A4A0", VA = "0x182B1B4A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B590", Offset = "0x2B1A590", VA = "0x182B1B590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public GGGEADYYYIT ECERKASTBJS
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BC30", Offset = "0x2B1AC30", VA = "0x182B1BC30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public XDVNNFLMVCN INKIUZFENHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BC40", Offset = "0x2B1AC40", VA = "0x182B1BC40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OAYBZJXSBWW DCUBLFRNOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BC60", Offset = "0x2B1AC60", VA = "0x182B1BC60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public VTCGOHQOOJI WNGLUIHQDBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B730", Offset = "0x2B1A730", VA = "0x182B1B730", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EGFYEMKSOVU EJLRQQSYDUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BC50", Offset = "0x2B1AC50", VA = "0x182B1BC50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AGDBBCFQBWL? AGDBBCFQBWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B4B0", Offset = "0x2B1A4B0", VA = "0x182B1B4B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B940", Offset = "0x2B1A940", VA = "0x182B1B940")]
		private ICGXRSEYDCA(JVEJJWJVKSR a, Id32<DQQOGREBWGB> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, ZBDLQYWPAME b, [In] AGDBBCFQBWL.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B110", Offset = "0x2B1A110", VA = "0x182B1B110")]
		public static ICGXRSEYDCA New(JVEJJWJVKSR deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<DQQOGREBWGB> actorId, Id32<LDCKCJVHREK> rootNetworkObjectId, RJNEMTAVLYW staticNetSys, YYFDGRCCPXY dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B1E0", Offset = "0x2B1A1E0", VA = "0x182B1B1E0")]
		public static ICGXRSEYDCA New(JVEJJWJVKSR dependencies, [In] RegistryV2 registryV2, Id32<DQQOGREBWGB> actorId, Id32<LDCKCJVHREK> rootNetworkObjectId, RJNEMTAVLYW staticNetSys, YYFDGRCCPXY dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A970", Offset = "0x2B19970", VA = "0x182B1A970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A810", Offset = "0x2B19810", VA = "0x182B1A810")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, BGYAXKJXFCB>> DWCRMJDCMFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B1ABA0", Offset = "0x2B19BA0", VA = "0x182B1ABA0")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, BGYAXKJXFCB>> GOOTDQEXFED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B740", Offset = "0x2B1A740", VA = "0x182B1B740")]
		internal void VTZMDCDVYAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AC90", Offset = "0x2B19C90", VA = "0x182B1AC90")]
		internal Option<AGLENQQYPWD> MXKTKYPRBHT([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<AGLENQQYPWD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A900", Offset = "0x2B19900", VA = "0x182B1A900")]
		internal bool DZYRFPQCMSK([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B5A0", Offset = "0x2B1A5A0", VA = "0x182B1B5A0")]
		internal Result<AGLENQQYPWD, BGYAXKJXFCB> TRVOYMQLIDP([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<AGLENQQYPWD, BGYAXKJXFCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AB50", Offset = "0x2B19B50", VA = "0x182B1AB50")]
		private void ERKWVMFOTTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A680", Offset = "0x2B19680", VA = "0x182B1A680")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, BGYAXKJXFCB>> ALNTBIAZDTT(AGLENQQYPWD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AD10", Offset = "0x2B19D10", VA = "0x182B1AD10")]
		private AGLENQQYPWD[] NALQIHPHHQS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class ZFBJIUYNQAU<a> : GJHFNOSHAUY, XNAQAPEZRTQ, TBKCGNLOMPR where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<GOPNEBMAEKM>? IWULKMUUTJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string RXKZZRVNGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a JBMRVYMFEKV;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<GOPNEBMAEKM>? VBQUCLXVVJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C980", Offset = "0x2E0B980", VA = "0x182E0C980", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x41BA620", Offset = "0x41B9620", VA = "0x1841BA620")]
		internal ZFBJIUYNQAU([In] Id128<GOPNEBMAEKM>? lastNode, Id32<PRDNNESEALZ>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class OAQKJYIRZUW
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EAC0", Offset = "0x2B1DAC0", VA = "0x182B1EAC0")]
		public static Result<DebugExecutionResult, XNAQAPEZRTQ> RAFEVZGZLGF([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, XNAQAPEZRTQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3B896A0", Offset = "0x3B886A0", VA = "0x183B896A0")]
		public static Result<TOk, XNAQAPEZRTQ> VQEHRELJWKT<TOk>([In] this Result<TOk, XNAQAPEZRTQ> self, [In] Id128<GOPNEBMAEKM>? lastNode, Id32<PRDNNESEALZ>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, XNAQAPEZRTQ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface JVEJJWJVKSR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		VFCMMUNYJTZ.ICTTKLBYQGC JBBUTJZDDDP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		ICGXRSEYDCA.ICTTKLBYQGC QHTVSOSZHGW
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		DEAYNPZYJML.ICTTKLBYQGC CKPYCFTRELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA> CAKQIGJUQSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.ICTTKLBYQGC OQRIIKETKQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		DUQMTWSATKX EBSKGPJZCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		YVVNDNVNRHU WFSNWXDAMMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		XDGOQWUJYOU FXOHAPKJXTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		QMQBHLTBDHS KRYVXSVOULN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		FTANEFSKGGW JPCFVWXLNYV
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
	public static class WCFCFEUIUYW
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B28680", Offset = "0x2B27680", VA = "0x182B28680")]
		public static AGLENQQYPWD HUHAQPGCGIZ(this AGLENQQYPWD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B28790", Offset = "0x2B27790", VA = "0x182B28790")]
		public static AGLENQQYPWD PRRYELAROUO(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public ICGXRSEYDCA root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B225C0", Offset = "0x2B215C0", VA = "0x182B225C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B22CF0", Offset = "0x2B21CF0", VA = "0x182B22CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B19CB0", Offset = "0x2B18CB0", VA = "0x182B19CB0")]
		public static AGLENQQYPWD BPNOVYSCGOD(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B19D70", Offset = "0x2B18D70", VA = "0x182B19D70")]
		public static ReduceAction<ActionKind, CompressedPayload> SFWZBARZXXU(AGLENQQYPWD actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B19BA0", Offset = "0x2B18BA0", VA = "0x182B19BA0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, BGYAXKJXFCB>> ALNTBIAZDTT(ICGXRSEYDCA a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A090", Offset = "0x2B19090", VA = "0x182B1A090")]
		public static AGLENQQYPWD BPNOVYSCGOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A1B0", Offset = "0x2B191B0", VA = "0x182B1A1B0")]
		public static ReduceAction<ActionKind, DestroyPayload> SFWZBARZXXU(AGLENQQYPWD actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A130", Offset = "0x2B19130", VA = "0x182B1A130")]
		public static Result<None, FHMLVXTYCOG> PPSMMPLBJDJ(ICGXRSEYDCA a, [In] DestroyPayload self)
		{
			return default(Result<None, FHMLVXTYCOG>);
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
			public AsyncTaskMethodBuilder<Result<None, FHMLVXTYCOG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ICGXRSEYDCA root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, FHMLVXTYCOG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B22DD0", Offset = "0x2B21DD0", VA = "0x182B22DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B23370", Offset = "0x2B22370", VA = "0x182B23370", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F13440", Offset = "0x1F12440", VA = "0x181F13440")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A470", Offset = "0x2B19470", VA = "0x182B1A470")]
		public static AGLENQQYPWD? BPNOVYSCGOD(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A570", Offset = "0x2B19570", VA = "0x182B1A570")]
		public static ReduceAction<ActionKind, FullInitializePayload> SFWZBARZXXU(AGLENQQYPWD actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A330", Offset = "0x2B19330", VA = "0x182B1A330")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, FHMLVXTYCOG>> ALNTBIAZDTT(ICGXRSEYDCA a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public ICGXRSEYDCA root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, BGYAXKJXFCB> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, TBKCGNLOMPR>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, TBKCGNLOMPR> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, TBKCGNLOMPR>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B22880", Offset = "0x2B21880", VA = "0x182B22880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B22D60", Offset = "0x2B21D60", VA = "0x182B22D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<AGLENQQYPWD> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
		private MultiPayload(IReadOnlyList<AGLENQQYPWD> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D740", Offset = "0x2B1C740", VA = "0x182B1D740")]
		public static AGLENQQYPWD BPNOVYSCGOD(IReadOnlyList<AGLENQQYPWD> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D800", Offset = "0x2B1C800", VA = "0x182B1D800")]
		public static ReduceAction<ActionKind, MultiPayload> SFWZBARZXXU(AGLENQQYPWD actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D600", Offset = "0x2B1C600", VA = "0x182B1D600")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, BGYAXKJXFCB>> ALNTBIAZDTT(ICGXRSEYDCA a, MultiPayload b)
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
		private sealed class BWOTNPDIUFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> SCMZXJVDGWC;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public BWOTNPDIUFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B196C0", Offset = "0x2B186C0", VA = "0x182B196C0")]
			internal AGLENQQYPWD ZBWWOBRAWLA(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2B1F610", Offset = "0x2B1E610", VA = "0x182B1F610")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F110", Offset = "0x2B1E110", VA = "0x182B1F110")]
		public static AGLENQQYPWD BPNOVYSCGOD(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F510", Offset = "0x2B1E510", VA = "0x182B1F510")]
		public static AGLENQQYPWD[] SIZIISMALPM(AGLENQQYPWD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F3C0", Offset = "0x2B1E3C0", VA = "0x182B1F3C0")]
		public static ReduceAction<ActionKind, PartialActionPayload> SFWZBARZXXU(AGLENQQYPWD actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F220", Offset = "0x2B1E220", VA = "0x182B1F220")]
		public static Result<AGLENQQYPWD, BGYAXKJXFCB> PPSMMPLBJDJ(ICGXRSEYDCA a, [In] PartialActionPayload self)
		{
			return default(Result<AGLENQQYPWD, BGYAXKJXFCB>);
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
			public AsyncTaskMethodBuilder<Result<bool, FHMLVXTYCOG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ICGXRSEYDCA root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, FHMLVXTYCOG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, FHMLVXTYCOG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B233E0", Offset = "0x2B223E0", VA = "0x182B233E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B23A20", Offset = "0x2B22A20", VA = "0x182B23A20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xE667E0", Offset = "0xE657E0", VA = "0x180E667E0")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F760", Offset = "0x2B1E760", VA = "0x182B1F760")]
		public static AGLENQQYPWD BPNOVYSCGOD(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F920", Offset = "0x2B1E920", VA = "0x182B1F920")]
		public static AGLENQQYPWD?[]? ZGALFPHEHCQ(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F840", Offset = "0x2B1E840", VA = "0x182B1F840")]
		public static ReduceAction<ActionKind, PartialInitializePayload> SFWZBARZXXU(AGLENQQYPWD actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F630", Offset = "0x2B1E630", VA = "0x182B1F630")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, FHMLVXTYCOG>> ALNTBIAZDTT(ICGXRSEYDCA a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class ECERKASTBJS : GGGEADYYYIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public MIWITNJLDRS? HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A220", Offset = "0x2B19220", VA = "0x182B1A220", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		internal ECERKASTBJS(ICGXRSEYDCA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class USZPYUIDWWX : MIWITNJLDRS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly AGDBBCFQBWL FLLQMDWLTRR;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAD9FF0", Offset = "0xAD8FF0", VA = "0x180AD9FF0")]
		public USZPYUIDWWX(ICGXRSEYDCA a, AGDBBCFQBWL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B27C30", Offset = "0x2B26C30", VA = "0x182B27C30", Slot = "4")]
		public Result<DebugExecutionResult, XNAQAPEZRTQ> STOTFNKXUNV(Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<JVDRBUQTLFY> inputId)
		{
			return default(Result<DebugExecutionResult, XNAQAPEZRTQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B27680", Offset = "0x2B26680", VA = "0x182B27680", Slot = "5")]
		public Result<DebugExecutionResult, XNAQAPEZRTQ> AGSFKTQJVOK(Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<XCMFJIKKBWV> outputId)
		{
			return default(Result<DebugExecutionResult, XNAQAPEZRTQ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class VFCMMUNYJTZ : ZBDLQYWPAME, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface ICTTKLBYQGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<SATWJHVPDBI> AYOHULDUPUD(ICGXRSEYDCA a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class RTTBFFUBHQH : ICTTKLBYQGC
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
				public AsyncTaskMethodBuilder<SATWJHVPDBI> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public ICGXRSEYDCA circuitsManager;

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
				private TaskAwaiter<DEAYNPZYJML> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2B216F0", Offset = "0x2B206F0", VA = "0x182B216F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2B218C0", Offset = "0x2B208C0", VA = "0x182B218C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FE00", Offset = "0x2B1EE00", VA = "0x182B1FE00", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<SATWJHVPDBI> AYOHULDUPUD(ICGXRSEYDCA a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
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
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			protected RTTBFFUBHQH()
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
			public AsyncTaskMethodBuilder<SATWJHVPDBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public VFCMMUNYJTZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B21930", Offset = "0x2B20930", VA = "0x182B21930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B21B30", Offset = "0x2B20B30", VA = "0x182B21B30", Slot = "5")]
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
			public VFCMMUNYJTZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ICGXRSEYDCA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<SATWJHVPDBI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B21BA0", Offset = "0x2B20BA0", VA = "0x182B21BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B220B0", Offset = "0x2B210B0", VA = "0x182B220B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ICTTKLBYQGC RAESGKCNHZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> CZYNSNYNKUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> JGCSIPEHIUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource RUEZPZUVSQA;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool GDLCCOYEMVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB31A30", Offset = "0xB30A30", VA = "0x180B31A30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB31040", Offset = "0xB30040", VA = "0x180B31040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1024EC0", Offset = "0x1023EC0", VA = "0x181024EC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1066920", Offset = "0x1065920", VA = "0x181066920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool UMWTFWAOXSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1BAA230", Offset = "0x1BA9230", VA = "0x181BAA230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1BAA240", Offset = "0x1BA9240", VA = "0x181BAA240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public SATWJHVPDBI? HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAD8F70", Offset = "0xAD7F70", VA = "0x180AD8F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B28350", Offset = "0x2B27350", VA = "0x182B28350", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<SATWJHVPDBI> OLJYHQOQTKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B28580", Offset = "0x2B27580", VA = "0x182B28580")]
		public VFCMMUNYJTZ(ICTTKLBYQGC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B28440", Offset = "0x2B27440", VA = "0x182B28440", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task SGUAUUEVRPX(ICGXRSEYDCA a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B281E0", Offset = "0x2B271E0", VA = "0x182B281E0", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class VGFDSLOLAHI : CQDTHEVKXVT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly SJCOOQFJORS HRPJTPQCOQL;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public VGFDSLOLAHI(SJCOOQFJORS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class UOHLCVTUTXL
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class LZUCJIINMAV<a> : ZPLAZZNSWLA where a : YNGCMLUUITO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a CREBEOLCVZU;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? WAWFGWKQQAM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xFD7E70", Offset = "0xFD6E70", VA = "0x180FD7E70", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<GOPNEBMAEKM>? FLZKBNHLCPW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x5603520", Offset = "0x5602520", VA = "0x185603520", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<LNVRVOESCOU> JTPZIJBCVOO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2E082A0", Offset = "0x2E072A0", VA = "0x182E082A0", Slot = "5")]
				get
				{
					return default(Id32<LNVRVOESCOU>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<LNVRVOESCOU>? EAGFORYEZRQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x56034A0", Offset = "0x56024A0", VA = "0x1856034A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
			public LZUCJIINMAV(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class NSJEHEAYFMB : LZUCJIINMAV<NPEPQFIOIIJ>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? WAWFGWKQQAM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x1105150", Offset = "0x1104150", VA = "0x181105150", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B1E970", Offset = "0x2B1D970", VA = "0x182B1E970")]
			public NSJEHEAYFMB(NPEPQFIOIIJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2B27500", Offset = "0x2B26500", VA = "0x182B27500")]
		public static ZPLAZZNSWLA New(YNGCMLUUITO graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class BRRUMOBBIOF : NEMTJOIPTHW, RAUCSROXRTI, JVEKMJHPKAZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class PVFILTBLFTB
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
				public PVFILTBLFTB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public DUQMTWSATKX errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B25160", Offset = "0x2B24160", VA = "0x182B25160", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B253D0", Offset = "0x2B243D0", VA = "0x182B253D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public BRRUMOBBIOF FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool GATNUZUDYSC;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public PVFILTBLFTB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F020", Offset = "0x2B1E020", VA = "0x182B1F020")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task HKDPTWJDOAL(DUQMTWSATKX a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ALKDSLXHLFB
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
				public ALKDSLXHLFB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x2B25430", Offset = "0x2B24430", VA = "0x182B25430", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x2B25710", Offset = "0x2B24710", VA = "0x182B25710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public BRRUMOBBIOF FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int GATNUZUDYSC;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public ALKDSLXHLFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B11C80", Offset = "0x2B10C80", VA = "0x182B11C80")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task YUGWDFORXHH(DUQMTWSATKX a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class MCMUCCAHCCC
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
				public MCMUCCAHCCC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x2B25C80", Offset = "0x2B24C80", VA = "0x182B25C80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x2B26130", Offset = "0x2B25130", VA = "0x182B26130", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string GATNUZUDYSC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public BRRUMOBBIOF FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int UNYDUZZLBNU;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public MCMUCCAHCCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B1CFF0", Offset = "0x2B1BFF0", VA = "0x182B1CFF0")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task UZPLGSGNPTJ(DUQMTWSATKX a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class AHVUYXZZXVL
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
				public AHVUYXZZXVL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x2B25770", Offset = "0x2B24770", VA = "0x182B25770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B25C20", Offset = "0x2B24C20", VA = "0x182B25C20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string GATNUZUDYSC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public BRRUMOBBIOF FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int UNYDUZZLBNU;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public AHVUYXZZXVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B11BB0", Offset = "0x2B10BB0", VA = "0x182B11BB0")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task KYYQVPZSPSL(DUQMTWSATKX a)
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
			public BRRUMOBBIOF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B23FD0", Offset = "0x2B22FD0", VA = "0x182B23FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B244D0", Offset = "0x2B234D0", VA = "0x182B244D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly PQGAYRMHEQI GMDAZNETANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<QTRSQQQKLLA> BWQCNIMKUCL;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private JVEJJWJVKSR RTTBFFUBHQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B19100", Offset = "0x2B18100", VA = "0x182B19100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<JVDRBUQTLFY> JZEUWLNBVAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xEC9D40", Offset = "0xEC8D40", VA = "0x180EC9D40", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<JVDRBUQTLFY>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFD5FC0", Offset = "0xFD4FC0", VA = "0x180FD5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<VKOSYOKYXNB> AXOYYIVONGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEA10", Offset = "0x2AADA10", VA = "0x182AAEA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<DRWFHSZKMVW> OBNXHZCRJKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1351A90", Offset = "0x1350A90", VA = "0x181351A90", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<DRWFHSZKMVW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<PRDNNESEALZ> LMUPEKJJOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B18560", Offset = "0x2B17560", VA = "0x182B18560", Slot = "22")]
			get
			{
				return default(Id32<PRDNNESEALZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool WAGOSQUNKCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B18050", Offset = "0x2B17050", VA = "0x182B18050", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B194A0", Offset = "0x2B184A0", VA = "0x182B194A0")]
		private BRRUMOBBIOF(ICGXRSEYDCA a, MOXNPQACASF b, PQGAYRMHEQI c, Id32<MMFHTWDPFRA> portGroupId, Id32<JVDRBUQTLFY> inputId, Id32<VKOSYOKYXNB> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B181B0", Offset = "0x2B171B0", VA = "0x182B181B0")]
		public static BRRUMOBBIOF New(ICGXRSEYDCA circuitsManager, MOXNPQACASF node, PQGAYRMHEQI input, Id32<MMFHTWDPFRA> portGroupId, Id32<VKOSYOKYXNB> inputDefId, Id32<JVDRBUQTLFY> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B17530", Offset = "0x2B16530", VA = "0x182B17530", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B15FC0", Offset = "0x2B14FC0", VA = "0x182B15FC0", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B17790", Offset = "0x2B16790", VA = "0x182B17790", Slot = "32")]
		public void KGPATZUAIBC(QTRSQQQKLLA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B17000", Offset = "0x2B16000", VA = "0x182B17000", Slot = "29")]
		public void HDNPCMVXSPZ(VBEDUSSGHHE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B16060", Offset = "0x2B15060", VA = "0x182B16060", Slot = "30")]
		public void HBJFJHQYLCC(KLDEUDVUVHO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B180D0", Offset = "0x2B170D0", VA = "0x182B180D0", Slot = "25")]
		protected override void MMLOBVDUMQE(GORIDUXUYDV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B17930", Offset = "0x2B16930", VA = "0x182B17930", Slot = "34")]
		public string KNBUVZZQOPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B19120", Offset = "0x2B18120", VA = "0x182B19120", Slot = "31")]
		public string YXJRMJURXGT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B18770", Offset = "0x2B17770", VA = "0x182B18770")]
		private void PINZGLQQPYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B193E0", Offset = "0x2B183E0", VA = "0x182B193E0", Slot = "33")]
		public void YZSVZDSNGUT(QTRSQQQKLLA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B18E70", Offset = "0x2B17E70", VA = "0x182B18E70")]
		private void SXNWPRFFTJW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B18990", Offset = "0x2B17990", VA = "0x182B18990", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task QMIVWDHAHTW(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B15610", Offset = "0x2B14610", VA = "0x182B15610")]
		public void BMGIUBNFFRL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B17EB0", Offset = "0x2B16EB0", VA = "0x182B17EB0")]
		private void LIDOYMSFVYN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B175D0", Offset = "0x2B165D0", VA = "0x182B175D0")]
		private void KEUMBJEVCYR(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B185B0", Offset = "0x2B175B0", VA = "0x182B185B0")]
		private void OPAPVUDGLXI(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B177F0", Offset = "0x2B167F0", VA = "0x182B177F0")]
		private string KKNOBEDEQPD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B173C0", Offset = "0x2B163C0", VA = "0x182B173C0")]
		private string IZAONUUTCCM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xFD5FC0", Offset = "0xFD4FC0", VA = "0x180FD5FC0")]
		internal void CJCUPQIIFRJ(Id32<JVDRBUQTLFY> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B15910", Offset = "0x2B14910", VA = "0x182B15910")]
		[CompilerGenerated]
		private void CJVVPEIEVXS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B15920", Offset = "0x2B14920", VA = "0x182B15920")]
		[CompilerGenerated]
		private bool CKBCMLCCFJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B159E0", Offset = "0x2B149E0", VA = "0x182B159E0")]
		[CompilerGenerated]
		private bool CKLQGYPWYFT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B15760", Offset = "0x2B14760", VA = "0x182B15760")]
		[CompilerGenerated]
		private int CJAUADGPKEI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B157B0", Offset = "0x2B147B0", VA = "0x182B157B0")]
		[CompilerGenerated]
		private bool CJGAXKAMTPR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B15840", Offset = "0x2B14840", VA = "0x182B15840")]
		[CompilerGenerated]
		private void CJLHUQUKDBA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B15850", Offset = "0x2B14850", VA = "0x182B15850")]
		[CompilerGenerated]
		private bool CJQORXOHMMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B15AA0", Offset = "0x2B14AA0", VA = "0x182B15AA0")]
		[CompilerGenerated]
		private bool CLLYTGLJTKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B15AF0", Offset = "0x2B14AF0", VA = "0x182B15AF0")]
		[CompilerGenerated]
		private bool CLRFQNFHCVV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B15760", Offset = "0x2B14760", VA = "0x182B15760")]
		[CompilerGenerated]
		private int DZAYADSWUBT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B15EF0", Offset = "0x2B14EF0", VA = "0x182B15EF0")]
		[CompilerGenerated]
		private bool DYVRCWYZKQK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B15E90", Offset = "0x2B14E90", VA = "0x182B15E90")]
		[CompilerGenerated]
		private object DYQKFQFCBFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B15E30", Offset = "0x2B14E30", VA = "0x182B15E30")]
		[CompilerGenerated]
		private void DYLDIJLERTS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B15D60", Offset = "0x2B14D60", VA = "0x182B15D60")]
		[CompilerGenerated]
		private bool DYAPNVXJYXA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B15CE0", Offset = "0x2B14CE0", VA = "0x182B15CE0")]
		[CompilerGenerated]
		private string DXVIQPDMPLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B15CD0", Offset = "0x2B14CD0", VA = "0x182B15CD0")]
		[CompilerGenerated]
		private void DXQBTIJPGAI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B15C00", Offset = "0x2B14C00", VA = "0x182B15C00")]
		[CompilerGenerated]
		private bool DXKUWBPRWOZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B15B80", Offset = "0x2B14B80", VA = "0x182B15B80")]
		[CompilerGenerated]
		private string DXFNYUVUNDQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B17B30", Offset = "0x2B16B30", VA = "0x182B17B30")]
		[CompilerGenerated]
		private void KTFQINOFTVA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B17B40", Offset = "0x2B16B40", VA = "0x182B17B40")]
		[CompilerGenerated]
		private bool KTKXFUIDDGJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B17AA0", Offset = "0x2B16AA0", VA = "0x182B17AA0")]
		[CompilerGenerated]
		private string KSVCOAALAYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B17B20", Offset = "0x2B16B20", VA = "0x182B17B20")]
		[CompilerGenerated]
		private void KTAJLGUIKJR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B17CF0", Offset = "0x2B16CF0", VA = "0x182B17CF0")]
		[CompilerGenerated]
		private bool KUARXOPVFOK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B17DC0", Offset = "0x2B16DC0", VA = "0x182B17DC0")]
		[CompilerGenerated]
		private string KUFYUVJSOZT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B17C10", Offset = "0x2B16C10", VA = "0x182B17C10")]
		[CompilerGenerated]
		private void KTQEDBCAMRS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B17C20", Offset = "0x2B16C20", VA = "0x182B17C20")]
		[CompilerGenerated]
		private bool KTVLAHVXWDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B17E30", Offset = "0x2B16E30", VA = "0x182B17E30")]
		[CompilerGenerated]
		private string KUVTMPRKRHU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B17EA0", Offset = "0x2B16EA0", VA = "0x182B17EA0")]
		[CompilerGenerated]
		private void KVBAJWLIATD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B18CC0", Offset = "0x2B17CC0", VA = "0x182B18CC0")]
		[CompilerGenerated]
		private bool RTWVHFWIJNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B18C50", Offset = "0x2B17C50", VA = "0x182B18C50")]
		[CompilerGenerated]
		private string RTROJZCLACA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B18E60", Offset = "0x2B17E60", VA = "0x182B18E60")]
		[CompilerGenerated]
		private void RUHJBTKDCKB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B18D90", Offset = "0x2B17D90", VA = "0x182B18D90")]
		[CompilerGenerated]
		private bool RUCCEMQFSYS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B18AB0", Offset = "0x2B17AB0", VA = "0x182B18AB0")]
		[CompilerGenerated]
		private string RTBTSEUSXTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B18AA0", Offset = "0x2B17AA0", VA = "0x182B18AA0")]
		[CompilerGenerated]
		private void RSWMUYAVOIQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B18B80", Offset = "0x2B17B80", VA = "0x182B18B80")]
		[CompilerGenerated]
		private bool RTMHMSINQQR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B18B20", Offset = "0x2B17B20", VA = "0x182B18B20")]
		[CompilerGenerated]
		private object RTHAPLOQHFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B15E30", Offset = "0x2B14E30", VA = "0x182B15E30")]
		[CompilerGenerated]
		private void RVMYLHZNHAD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B19030", Offset = "0x2B18030", VA = "0x182B19030")]
		[CompilerGenerated]
		private bool VVQXTYDKFKI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class BEXWTNWSTQV
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class UMYUSIBIXSX : QDOMVXBDPPR<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public UMYUSIBIXSX FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C870", Offset = "0x2B1B870", VA = "0x182B1C870")]
				internal object LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C3D0", Offset = "0x2B1B3D0", VA = "0x182B1C3D0")]
				internal void LKIYLCKNDRA(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B27490", Offset = "0x2B26490", VA = "0x182B27490")]
			public UMYUSIBIXSX(ICGXRSEYDCA a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2B27220", Offset = "0x2B26220", VA = "0x182B27220", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class QOTNBEBFCWG : OVERGDUXOHG<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType WTNUCHXCMID
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FDA0", Offset = "0x2B1EDA0", VA = "0x182B1FDA0")]
			public QOTNBEBFCWG(ICGXRSEYDCA a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class WUCORTDWEUY : QDOMVXBDPPR<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2B290B0", Offset = "0x2B280B0", VA = "0x182B290B0")]
			public WUCORTDWEUY(ICGXRSEYDCA a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2B28F50", Offset = "0x2B27F50", VA = "0x182B28F50", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2B28F00", Offset = "0x2B27F00", VA = "0x182B28F00")]
			[CompilerGenerated]
			private bool OUEEARQPBSZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2B28DD0", Offset = "0x2B27DD0", VA = "0x182B28DD0")]
			[CompilerGenerated]
			private void OTYXDKWRSHQ(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class KBHTELYOMYA : QDOMVXBDPPR<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public KBHTELYOMYA FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C8D0", Offset = "0x2B1B8D0", VA = "0x182B1C8D0")]
				internal void LKOFIJEKNCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C6F0", Offset = "0x2B1B6F0", VA = "0x182B1C6F0")]
				internal bool LKIYLCKNDRA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C1E0", Offset = "0x2B1B1E0", VA = "0x182B1C1E0")]
				internal bool LKDRNVQPUFR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C0B0", Offset = "0x2B1B0B0", VA = "0x182B1C0B0")]
				internal void LJYKQOWSKUI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CC60", Offset = "0x2B1BC60", VA = "0x182B1CC60")]
				internal bool LLJGXKFZYVT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BF80", Offset = "0x2B1AF80", VA = "0x182B1BF80")]
			public KBHTELYOMYA(ICGXRSEYDCA a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BC70", Offset = "0x2B1AC70", VA = "0x182B1BC70", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class RUOORZZHTJC : QDOMVXBDPPR<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public RUOORZZHTJC FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> RTJRFTOOUUZ;

				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C920", Offset = "0x2B1B920", VA = "0x182B1C920")]
				internal object? LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CA60", Offset = "0x2B1BA60", VA = "0x182B1CA60")]
				internal bool LKTMFPYHWNS(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C4A0", Offset = "0x2B1B4A0", VA = "0x182B1C4A0")]
				internal void LKIYLCKNDRA(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C230", Offset = "0x2B1B230", VA = "0x182B1C230")]
				internal string LKDRNVQPUFR(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C060", Offset = "0x2B1B060", VA = "0x182B1C060")]
				internal IReadOnlyList<object> LJYKQOWSKUI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CCB0", Offset = "0x2B1BCB0", VA = "0x182B1CCB0")]
				internal bool LLJGXKFZYVT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CC10", Offset = "0x2B1BC10", VA = "0x182B1CC10")]
				internal bool LLEAADMCPKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CAE0", Offset = "0x2B1BAE0", VA = "0x182B1CAE0")]
				internal void LKYTCWSFFZB(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2B20810", Offset = "0x2B1F810", VA = "0x182B20810")]
			public RUOORZZHTJC(ICGXRSEYDCA a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B20110", Offset = "0x2B1F110", VA = "0x182B20110", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class QDUWGOLRDDB : QDOMVXBDPPR<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public QDUWGOLRDDB FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CA10", Offset = "0x2B1BA10", VA = "0x182B1CA10")]
				internal bool LKOFIJEKNCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C740", Offset = "0x2B1B740", VA = "0x182B1C740")]
				internal void LKIYLCKNDRA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C380", Offset = "0x2B1B380", VA = "0x182B1C380")]
				internal bool LKDRNVQPUFR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FD30", Offset = "0x2B1ED30", VA = "0x182B1FD30")]
			public QDUWGOLRDDB(ICGXRSEYDCA a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FB20", Offset = "0x2B1EB20", VA = "0x182B1FB20", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class NKXFTZQQFXW : QDOMVXBDPPR<TNKVUILOUJH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class MVGSWCHOTEO
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
					public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public MVGSWCHOTEO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<LRWMKGDWIYW>, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x2B24910", Offset = "0x2B23910", VA = "0x182B24910", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B23CF0", VA = "0x182B24CF0", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public MVGSWCHOTEO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2B24D60", Offset = "0x2B23D60", VA = "0x182B24D60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2B250F0", Offset = "0x2B240F0", VA = "0x182B250F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task RCLTKHXQNJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string ZBXQQSQEWPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public HOLPEYTCWXS.MVZWSFBIDHA HWZALTGCEAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool YHHDVZMGIWZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public NKXFTZQQFXW FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public HOLPEYTCWXS FOZEXLPHECD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action BMFNFTZOTAF;

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public MVGSWCHOTEO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D0C0", Offset = "0x2B1C0C0", VA = "0x182B1D0C0")]
				internal bool HKNODXWLDTF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				internal string TQDLQOPKPCY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D320", Offset = "0x2B1C320", VA = "0x182B1D320")]
				internal void TQTGIIXCRKZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D2D0", Offset = "0x2B1C2D0", VA = "0x182B1D2D0")]
				internal void TQNZLCDFHZQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x169FBE0", Offset = "0x169EBE0", VA = "0x18169FBE0")]
				internal bool TRDUCWKXKHR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D3A0", Offset = "0x2B1C3A0", VA = "0x182B1D3A0")]
				internal void TQYNFPRAAWI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D5C0", Offset = "0x2B1C5C0", VA = "0x182B1D5C0")]
				internal bool TROHXJYSDEJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D1E0", Offset = "0x2B1C1E0", VA = "0x182B1D1E0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, BGYAXKJXFCB>> SALDNCTZPDV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D0F0", Offset = "0x2B1C0F0", VA = "0x182B1D0F0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, BGYAXKJXFCB>> MJRPRDHJJRO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class SCYSNCSTSXC
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
					public AsyncTaskMethodBuilder<Result<Id32<LRWMKGDWIYW>, BGYAXKJXFCB>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<LRWMKGDWIYW>, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x2B24530", Offset = "0x2B23530", VA = "0x182B24530", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x2B248A0", Offset = "0x2B238A0", VA = "0x182B248A0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public NKXFTZQQFXW FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public RRPMJEEQJEK GBMRKQNVAYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool JRUDLESRKIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public HOLPEYTCWXS FOZEXLPHECD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public LIDTGSJMWVY VGAJPHPPORP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action RRYUYYFHGTO;

				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public SCYSNCSTSXC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x2B20BF0", Offset = "0x2B1FBF0", VA = "0x182B20BF0")]
				internal object? LKIYLCKNDRA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x2B20B00", Offset = "0x2B1FB00", VA = "0x182B20B00")]
				internal void LKDRNVQPUFR(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2B20A10", Offset = "0x2B1FA10", VA = "0x182B20A10")]
				internal string LJYKQOWSKUI(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2B20EF0", Offset = "0x2B1FEF0", VA = "0x182B20EF0")]
				internal IReadOnlyList<object> LLJGXKFZYVT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2B20D90", Offset = "0x2B1FD90", VA = "0x182B20D90")]
				internal void LLEAADMCPKK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2B20D20", Offset = "0x2B1FD20", VA = "0x182B20D20")]
				internal bool LKYTCWSFFZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2B20C60", Offset = "0x2B1FC60", VA = "0x182B20C60")]
				internal void LKTMFPYHWNS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2B209C0", Offset = "0x2B1F9C0", VA = "0x182B209C0")]
				internal void LIYCEHBFPPP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2B20940", Offset = "0x2B1F940", VA = "0x182B20940")]
				internal void LISVHAHIGEG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2B208E0", Offset = "0x2B1F8E0", VA = "0x182B208E0")]
				internal bool KYYYWVIEBCC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2B20F90", Offset = "0x2B1FF90", VA = "0x182B20F90")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<LRWMKGDWIYW>, BGYAXKJXFCB>> RLJSIGIYFHU()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<LNVRVOESCOU>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E930", Offset = "0x2B1D930", VA = "0x182B1E930", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2B1E8C0", Offset = "0x2B1D8C0", VA = "0x182B1E8C0")]
			public NKXFTZQQFXW(ICGXRSEYDCA a, TNKVUILOUJH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2B1DF30", Offset = "0x2B1CF30", VA = "0x182B1DF30", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D8A0", Offset = "0x2B1C8A0", VA = "0x182B1D8A0")]
			private void PTUJYLIAXPX(HOLPEYTCWXS a, Id32<LRWMKGDWIYW>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class OUJRMLYNFKF : ZMRONPVQTEA<NRFBUNZTXLE>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x1F2BFC0", Offset = "0x1F2AFC0", VA = "0x181F2BFC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool LDDNHHWIRVS
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool WGUCAOEQPBR
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool UANEWABENXE
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x2B1EF60", Offset = "0x2B1DF60", VA = "0x182B1EF60")]
			public OUJRMLYNFKF(ICGXRSEYDCA a, NRFBUNZTXLE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class UHOKMOSTNPX<a> : QDOMVXBDPPR<a> where a : notnull, KCFHPUROLYT
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
				public AsyncTaskMethodBuilder<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public UHOKMOSTNPX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x5154F20", Offset = "0x5153F20", VA = "0x185154F20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x5155270", Offset = "0x5154270", VA = "0x185155270", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public UHOKMOSTNPX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<MMFHTWDPFRA> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x53F30F0", Offset = "0x53F20F0", VA = "0x1853F30F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x53F3440", Offset = "0x53F2440", VA = "0x1853F3440", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<MMFHTWDPFRA>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x65A6370", Offset = "0x65A5370", VA = "0x1865A6370", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x65A6340", Offset = "0x65A5340", VA = "0x1865A6340")]
			protected UHOKMOSTNPX(ICGXRSEYDCA a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x65A6220", Offset = "0x65A5220", VA = "0x1865A6220", Slot = "122")]
			[AsyncStateMachine(typeof(UHOKMOSTNPX<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> TSOCBKVIYBQ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x65A5F30", Offset = "0x65A4F30", VA = "0x1865A5F30", Slot = "149")]
			public sealed override bool FBVMLLXJEJJ(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x65A5FD0", Offset = "0x65A4FD0", VA = "0x1865A5FD0", Slot = "134")]
			protected sealed override bool OODRGKLIHLD(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x65A6180", Offset = "0x65A5180", VA = "0x1865A6180", Slot = "135")]
			protected override bool PVTWKUFZUKW(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x65A6070", Offset = "0x65A5070", VA = "0x1865A6070", Slot = "123")]
			[AsyncStateMachine(typeof(UHOKMOSTNPX<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, BGYAXKJXFCB>> OUOBZJVMFZX(Id32<MMFHTWDPFRA> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class TISYCBNXXZK : XQJSZXCPIPV<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public TISYCBNXXZK FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CD20", Offset = "0x2B1BD20", VA = "0x182B1CD20")]
				internal bool VTFNHPOCUGY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CEC0", Offset = "0x2B1BEC0", VA = "0x182B1CEC0")]
				internal void VTKUEWIADSH(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2B21690", Offset = "0x2B20690", VA = "0x182B21690")]
			public TISYCBNXXZK(ICGXRSEYDCA a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2B21450", Offset = "0x2B20450", VA = "0x182B21450", Slot = "151")]
			protected override void GCYUHCMHKPK(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class WERAYATZTAV : QDOMVXBDPPR<YBIHGRMOLFM>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class YNXANUMFTWX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int FTODNMFJEUY;

				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public YNXANUMFTWX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x2B33C30", Offset = "0x2B32C30", VA = "0x182B33C30")]
				internal bool ZPIAJEMPRPC(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class DABAUKZQTLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public WERAYATZTAV FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> RSEYPLSEGIW;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public DABAUKZQTLC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2B19FF0", Offset = "0x2B18FF0", VA = "0x182B19FF0")]
				internal int LKOFIJEKNCJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x2B19ED0", Offset = "0x2B18ED0", VA = "0x182B19ED0")]
				internal void LKIYLCKNDRA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2B19E20", Offset = "0x2B18E20", VA = "0x182B19E20")]
				internal string? LKDRNVQPUFR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2B28D60", Offset = "0x2B27D60", VA = "0x182B28D60")]
			public WERAYATZTAV(ICGXRSEYDCA a, YBIHGRMOLFM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2B28860", Offset = "0x2B27860", VA = "0x182B28860")]
			private int QDSCOJTYOKK(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2B28C40", Offset = "0x2B27C40", VA = "0x182B28C40")]
			private void YAKRDGYABOI(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2B288F0", Offset = "0x2B278F0", VA = "0x182B288F0", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class OUMLRAZVVAP : ZMRONPVQTEA<JIKQVQCLJGA>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2B1EFC0", Offset = "0x2B1DFC0", VA = "0x182B1EFC0")]
			public OUMLRAZVVAP(ICGXRSEYDCA a, JIKQVQCLJGA b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class ZMRONPVQTEA<a> : QDOMVXBDPPR<a> where a : notnull, JKVSVDBLPEM
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class SFMADHAQTVS
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
					public SFMADHAQTVS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x401D1C0", Offset = "0x401C1C0", VA = "0x18401D1C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public HOLPEYTCWXS FOZEXLPHECD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public ZMRONPVQTEA<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action RTEKIMURLJQ;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public SFMADHAQTVS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x618E040", Offset = "0x618D040", VA = "0x18618E040")]
				internal void LKOFIJEKNCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x618E320", Offset = "0x618D320", VA = "0x18618E320")]
				[AsyncStateMachine(typeof(ZMRONPVQTEA<>.SFMADHAQTVS.<<BuildConfigMenuInternal>b__6>d))]
				internal void LKYTCWSFFZB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x618DC50", Offset = "0x618CC50", VA = "0x18618DC50")]
				internal bool LKIYLCKNDRA()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class SFRHANUODHB
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
					public SFRHANUODHB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x401C9E0", Offset = "0x401B9E0", VA = "0x18401C9E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string NUDNFCKPAFQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public SFMADHAQTVS OYIFPNPIBTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> RUESUUQEGOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> RSTWNZGWSMY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action RSZDLGAUBYH;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public SFRHANUODHB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x618E3C0", Offset = "0x618D3C0", VA = "0x18618E3C0")]
				internal void LKDRNVQPUFR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				internal string LJYKQOWSKUI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
				internal void LLJGXKFZYVT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x618E730", Offset = "0x618D730", VA = "0x18618E730")]
				[AsyncStateMachine(typeof(ZMRONPVQTEA<>.SFRHANUODHB.<<BuildConfigMenuInternal>b__5>d))]
				internal void LLEAADMCPKK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class XYVUWTRFLQR
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
					public XYVUWTRFLQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<EBKDWIFBKMY>, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x401A050", Offset = "0x4019050", VA = "0x18401A050", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public XYVUWTRFLQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x401A7A0", Offset = "0x40197A0", VA = "0x18401A7A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public XYVUWTRFLQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<VKOSYOKYXNB>, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x401A980", Offset = "0x4019980", VA = "0x18401A980", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public ZMRONPVQTEA<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<MMFHTWDPFRA> TMTSGGYALTW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public HOLPEYTCWXS FOZEXLPHECD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public DEBFPVFXDBS SDBSEZJSZGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int KHIAVZESYKS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int DNCAVAABPOY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public MMEEXWRZTBL CDJWUENFOLO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string MQHQCXCSSWB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<KSTUYHQDXVF> YGLRPNGGDQQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public MMEEXWRZTBL VSDNVNCQTEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string ZNDZUBFOCLY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<KSTUYHQDXVF> RBFQZOAYNXX;

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XYVUWTRFLQR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x41908A0", Offset = "0x418F8A0", VA = "0x1841908A0")]
				internal bool XVMVJOMYJGQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x4190910", Offset = "0x418F910", VA = "0x184190910")]
				internal void XVSCGVGVSRZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x4190D20", Offset = "0x418FD20", VA = "0x184190D20")]
				internal bool ZESAYDUUDTW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4190980", Offset = "0x418F980", VA = "0x184190980")]
				[AsyncStateMachine(typeof(ZMRONPVQTEA<>.XYVUWTRFLQR.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void XVXJECATCDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4190A20", Offset = "0x418FA20", VA = "0x184190A20")]
				internal bool XWCQBIUQLOR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x4190E70", Offset = "0x418FE70", VA = "0x184190E70")]
				internal void ZFNCNEWJPNG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x4191030", Offset = "0x4190030", VA = "0x184191030")]
				internal bool ZGXYUAFRDOR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x4190F50", Offset = "0x418FF50", VA = "0x184190F50")]
				internal void ZGSRWTLTUDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x41907F0", Offset = "0x418F7F0", VA = "0x1841907F0")]
				internal bool GFZAOQKOVUG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x4190A60", Offset = "0x418FA60", VA = "0x184190A60")]
				internal bool XWHWYPONVAA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x4190AD0", Offset = "0x418FAD0", VA = "0x184190AD0")]
				internal void XWNDVWILELJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x4190B40", Offset = "0x418FB40", VA = "0x184190B40")]
				[AsyncStateMachine(typeof(ZMRONPVQTEA<>.XYVUWTRFLQR.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void XWSKTDCINWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x4190BE0", Offset = "0x418FBE0", VA = "0x184190BE0")]
				internal bool XWXRQJWFXIB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x4190C40", Offset = "0x418FC40", VA = "0x184190C40")]
				internal bool XXCYNQQDGTK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x4190CB0", Offset = "0x418FCB0", VA = "0x184190CB0")]
				internal void XXIFKXKAQET(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x4190DC0", Offset = "0x418FDC0", VA = "0x184190DC0")]
				[AsyncStateMachine(typeof(ZMRONPVQTEA<>.XYVUWTRFLQR.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void ZFHVPYCMGBX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x4190D60", Offset = "0x418FD60", VA = "0x184190D60")]
				internal bool ZFCOSRIOWQO()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class XYQNZMXICFI
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
					public XYQNZMXICFI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x401A340", Offset = "0x4019340", VA = "0x18401A340", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string CAAFPQBUHOW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public XYVUWTRFLQR OYIFPNPIBTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> KJWGWTHIVLH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> KJQZZMNLLZY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action KJLTCFTOCOP;

				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XYQNZMXICFI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x41903E0", Offset = "0x418F3E0", VA = "0x1841903E0")]
				internal void ZEXHVKORNFF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				internal string ZGCXEZEBRVH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
				internal void ZFXQHSKEIJY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x4190750", Offset = "0x418F750", VA = "0x184190750")]
				[AsyncStateMachine(typeof(ZMRONPVQTEA<>.XYQNZMXICFI.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void ZFSJKLQGYYP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class BROJGKSJPHQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool YGLRPNGGDQQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public DEBFPVFXDBS SDBSEZJSZGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<KSTUYHQDXVF> ZEWDJSTTUXX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public ZMRONPVQTEA<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<MMFHTWDPFRA> TMTSGGYALTW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int MYLUMDHNONH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> RTUFAHCJNRR;

				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public BROJGKSJPHQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x405A2F0", Offset = "0x40592F0", VA = "0x18405A2F0")]
				internal bool BGIFTFFSUVO()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class BRTQDRMGYSZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public JVEKMJHPKAZ IAFBRCMWMYS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public BROJGKSJPHQ OYIFPNPIBTY;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public BRTQDRMGYSZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x405A400", Offset = "0x4059400", VA = "0x18405A400")]
				internal void BGYAKZNKXDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0x405A3B0", Offset = "0x40593B0", VA = "0x18405A3B0")]
				internal bool BGSTNSTNNSG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x405A5D0", Offset = "0x40595D0", VA = "0x18405A5D0")]
				internal void BHIOFNBFQAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x405A570", Offset = "0x4059570", VA = "0x18405A570")]
				internal bool BHDHIGHIGOY()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class BRDVLXEOWKY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public KSTUYHQDXVF QWCZLAMCCCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public BRTQDRMGYSZ OYCYSGVKSIP;

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public BRDVLXEOWKY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x405A0D0", Offset = "0x40590D0", VA = "0x18405A0D0")]
				internal void BGNMQLZQEGX()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class NMFIJOSQTOH
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
					public NMFIJOSQTOH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x401E430", Offset = "0x401D430", VA = "0x18401E430", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> AOZZUNWPULW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public MMEEXWRZTBL BUPTODDMSYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool YGLRPNGGDQQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public DEBFPVFXDBS SDBSEZJSZGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public JVEKMJHPKAZ IAFBRCMWMYS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string CAAFPQBUHOW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public NMFIJOSQTOH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x5B68AE0", Offset = "0x5B67AE0", VA = "0x185B68AE0")]
				internal int QHKCROJDDLV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x5B68890", Offset = "0x5B67890", VA = "0x185B68890")]
				internal void QHEVUHPFUAM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60")]
				internal string QHUQMBWXWIN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x5B68B20", Offset = "0x5B67B20", VA = "0x185B68B20")]
				[AsyncStateMachine(typeof(ZMRONPVQTEA<>.NMFIJOSQTOH.<<CreatePortItemV2>b__3>d))]
				internal void QHPJOVDAMXE(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public ZMRONPVQTEA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x5154B00", Offset = "0x5153B00", VA = "0x185154B00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5154EB0", Offset = "0x5153EB0", VA = "0x185154EB0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public ZMRONPVQTEA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<MMFHTWDPFRA> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x53F34B0", Offset = "0x53F24B0", VA = "0x1853F34B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x53F37F0", Offset = "0x53F27F0", VA = "0x1853F37F0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public ZMRONPVQTEA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x53F8FA0", Offset = "0x53F7FA0", VA = "0x1853F8FA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x53F9550", Offset = "0x53F8550", VA = "0x1853F9550", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<MMFHTWDPFRA>, bool> DBWIRQMXUAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<MMFHTWDPFRA>, bool> YTXISVXQIWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<MMFHTWDPFRA>, bool> XOUWOEFDYQZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<MMFHTWDPFRA>, bool> IQZIYVPHCDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<MMFHTWDPFRA>, bool> MYDJLGZOZFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<MMFHTWDPFRA>, bool> UWOZGCAOCMT;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool LDDNHHWIRVS
			{
				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool WGUCAOEQPBR
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool UANEWABENXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<LNVRVOESCOU>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x41D3500", Offset = "0x41D2500", VA = "0x1841D3500", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<MMFHTWDPFRA>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x41D3780", Offset = "0x41D2780", VA = "0x1841D3780", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<GOPNEBMAEKM>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x41D3580", Offset = "0x41D2580", VA = "0x1841D3580", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x41D3330", Offset = "0x41D2330", VA = "0x1841D3330")]
			public ZMRONPVQTEA(ICGXRSEYDCA a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "154")]
			protected virtual bool KWZYJSLMTZL(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "155")]
			protected virtual bool OOPHQCPIHRY(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "156")]
			protected virtual bool ZXMQSQRHQJV(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "157")]
			protected virtual void LUWGYEJJWBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x41CF8C0", Offset = "0x41CE8C0", VA = "0x1841CF8C0", Slot = "149")]
			public override bool FBVMLLXJEJJ(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x41D1380", Offset = "0x41D0380", VA = "0x1841D1380", Slot = "122")]
			[AsyncStateMachine(typeof(ZMRONPVQTEA<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> TSOCBKVIYBQ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x41CF9C0", Offset = "0x41CE9C0", VA = "0x1841CF9C0", Slot = "123")]
			[AsyncStateMachine(typeof(ZMRONPVQTEA<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, BGYAXKJXFCB>> OUOBZJVMFZX(Id32<MMFHTWDPFRA> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x41D1730", Offset = "0x41D0730", VA = "0x1841D1730", Slot = "124")]
			public override void VAXMVKQFJQN(Id32<MMFHTWDPFRA> index, Id32<MMFHTWDPFRA> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x41CF660", Offset = "0x41CE660", VA = "0x1841CF660", Slot = "125")]
			public override IEnumerable<AGLENQQYPWD> CYVSSQWZBVQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x41CFAD0", Offset = "0x41CEAD0", VA = "0x1841CFAD0")]
			[AsyncStateMachine(typeof(ZMRONPVQTEA<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, BGYAXKJXFCB>> PEMADTBQNKF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "158")]
			protected virtual bool FSYMYXTTNHW(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "159")]
			protected virtual bool BVJIRVPLIWS(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "160")]
			protected virtual bool HUOXMLDNABR(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "161")]
			protected virtual bool WWWJPZIPUBZ(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "162")]
			protected virtual bool MGJWLQWJYZF(Id32<MMFHTWDPFRA> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "163")]
			protected virtual bool TURROYMQQQQ(Id32<MMFHTWDPFRA> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "164")]
			protected virtual bool HCEINUPYPMC(Id32<MMFHTWDPFRA> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "165")]
			protected virtual bool QZOSXYLEOKH(Id32<MMFHTWDPFRA> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "166")]
			protected virtual bool CPROPTVMIPN(Id32<MMFHTWDPFRA> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "167")]
			protected virtual bool SWOKZBGGFXQ(Id32<MMFHTWDPFRA> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x41D14A0", Offset = "0x41D04A0", VA = "0x1841D14A0", Slot = "168")]
			protected virtual List<MMEEXWRZTBL> UQXJYHYLMTG(Id32<MMFHTWDPFRA> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "169")]
			protected virtual void NODUGAYXWOZ(HOLPEYTCWXS a, LXZKKHCQIOC b, DEBFPVFXDBS c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x41D18D0", Offset = "0x41D08D0", VA = "0x1841D18D0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x41CFBD0", Offset = "0x41CEBD0", VA = "0x1841CFBD0")]
			private LXZKKHCQIOC QSQWLPFRXPS(HOLPEYTCWXS a, DEBFPVFXDBS b, Id32<MMFHTWDPFRA> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x41D2290", Offset = "0x41D1290", VA = "0x1841D2290")]
			private List<KSTUYHQDXVF> ZSRUBZNCTLX(HOLPEYTCWXS a, DEBFPVFXDBS b, LXZKKHCQIOC c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x41CECB0", Offset = "0x41CDCB0", VA = "0x1841CECB0")]
			private List<KSTUYHQDXVF> BXUTBIKQLCN(HOLPEYTCWXS a, DEBFPVFXDBS b, JVEKMJHPKAZ c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x41CEAC0", Offset = "0x41CDAC0", VA = "0x1841CEAC0")]
			private MMEEXWRZTBL BVNWZCFZFYB(List<MMEEXWRZTBL> a, JVEKMJHPKAZ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x41CF960", Offset = "0x41CE960", VA = "0x1841CF960")]
			[CompilerGenerated]
			private AGLENQQYPWD MFZRQQEXROF(MOXNPQACASF a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class TGJQCUBEKAL : QDOMVXBDPPR<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public TGJQCUBEKAL FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B19B50", Offset = "0x2B18B50", VA = "0x182B19B50")]
				internal int LKOFIJEKNCJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B19AC0", Offset = "0x2B18AC0", VA = "0x182B19AC0")]
				internal Task<bool> LKIYLCKNDRA(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2B213E0", Offset = "0x2B203E0", VA = "0x182B213E0")]
			public TGJQCUBEKAL(ICGXRSEYDCA a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2B21230", Offset = "0x2B20230", VA = "0x182B21230", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class YTCNGCHGEZN : XQJSZXCPIPV<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public YTCNGCHGEZN FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CDA0", Offset = "0x2B1BDA0", VA = "0x182B1CDA0")]
				internal int VTFNHPOCUGY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CE20", Offset = "0x2B1BE20", VA = "0x182B1CE20")]
				internal Task<bool> VTKUEWIADSH(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2B33E90", Offset = "0x2B32E90", VA = "0x182B33E90")]
			public YTCNGCHGEZN(ICGXRSEYDCA a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2B33C70", Offset = "0x2B32C70", VA = "0x182B33C70", Slot = "151")]
			protected override void GCYUHCMHKPK(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class KRTBGPBNDEB : QDOMVXBDPPR<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0xFDCA50", Offset = "0xFDBA50", VA = "0x180FDCA50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BFF0", Offset = "0x2B1AFF0", VA = "0x182B1BFF0")]
			public KRTBGPBNDEB(ICGXRSEYDCA a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class BMAJJYHEOJX : QDOMVXBDPPR<DCFBHQTDMWG>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class XDIBTWVITXT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public BMAJJYHEOJX FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public HOLPEYTCWXS FOZEXLPHECD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> WZPOLNHNZRV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> WZUVIUBLJDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> XAKQAOJDLLF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> XAPWXVDAUWO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> XAVDVBWYEHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> WXUEKEKLSTS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> WXZLHLEJCFB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> EABMMYVTFYV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> DZWFPSBVWNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> DZQYSLHYNCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> DZLRVEOBDQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> EAWOBZXIRSF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> EARHETDLIGW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> EAMAHMJNYVN;

				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XDIBTWVITXT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B3F0", Offset = "0x2B2A3F0", VA = "0x182B2B3F0")]
				internal bool LKOFIJEKNCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B390", Offset = "0x2B2A390", VA = "0x182B2B390")]
				internal void LKIYLCKNDRA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B4F0", Offset = "0x2B2A4F0", VA = "0x182B2B4F0")]
				internal bool LLJGXKFZYVT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B4A0", Offset = "0x2B2A4A0", VA = "0x182B2B4A0")]
				internal bool LLEAADMCPKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B440", Offset = "0x2B2A440", VA = "0x182B2B440")]
				internal void LKYTCWSFFZB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B340", Offset = "0x2B2A340", VA = "0x182B2B340")]
				internal bool LISVHAHIGEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B290", Offset = "0x2B2A290", VA = "0x182B2B290")]
				internal bool KYYYWVIEBCC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B2E0", Offset = "0x2B2A2E0", VA = "0x182B2B2E0")]
				internal void KZEFUCCBKNL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B1F0", Offset = "0x2B2A1F0", VA = "0x182B2B1F0")]
				internal bool KYDXHUGOPIS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B240", Offset = "0x2B2A240", VA = "0x182B2B240")]
				internal bool KYJEFBALYUB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B190", Offset = "0x2B2A190", VA = "0x182B2B190")]
				internal void KXTJNGSTWMA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B140", Offset = "0x2B2A140", VA = "0x182B2B140")]
				internal bool KXOCPZYWNAR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2B32F50", Offset = "0x2B31F50", VA = "0x182B32F50")]
				internal bool WYLQOLTOHKU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2B32FA0", Offset = "0x2B31FA0", VA = "0x182B32FA0")]
				internal bool WYQXLSNLQWD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2B32FF0", Offset = "0x2B31FF0", VA = "0x182B32FF0")]
				internal bool WYWEIZHJAHM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2B32E00", Offset = "0x2B31E00", VA = "0x182B32E00")]
				internal bool WWALVIOTYEQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2B32E50", Offset = "0x2B31E50", VA = "0x182B32E50")]
				internal bool WWFSSPIRHPZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2B298C0", Offset = "0x2B288C0", VA = "0x182B298C0")]
				internal bool DYHTYDABLJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2B29870", Offset = "0x2B28870", VA = "0x182B29870")]
				internal bool DYCNAWGEBYK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2B29810", Offset = "0x2B28810", VA = "0x182B29810")]
				internal void DXXGDPMGSNB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CC40", Offset = "0x2B2BC40", VA = "0x182B2CC40")]
				internal bool SVRFPLQZQJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CCE0", Offset = "0x2B2BCE0", VA = "0x182B2CCE0")]
				internal bool SWHAHFYRSRD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CC90", Offset = "0x2B2BC90", VA = "0x182B2CC90")]
				internal bool SWBTJZEUJFU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CB50", Offset = "0x2B2BB50", VA = "0x182B2CB50")]
				internal bool SUWEAKPKEPS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CBF0", Offset = "0x2B2BBF0", VA = "0x182B2CBF0")]
				internal bool SVLYSEXCGXT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2B297C0", Offset = "0x2B287C0", VA = "0x182B297C0")]
				internal bool DXRZGISJJBS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2B29A10", Offset = "0x2B28A10", VA = "0x182B29A10")]
				internal bool DZCVNEBQXDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2B299B0", Offset = "0x2B289B0", VA = "0x182B299B0")]
				internal void DYXOPXHTNRU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2B29960", Offset = "0x2B28960", VA = "0x182B29960")]
				internal bool DYSHSQNWEGL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2B29910", Offset = "0x2B28910", VA = "0x182B29910")]
				internal bool DYNAVJTYUVC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2B29760", Offset = "0x2B28760", VA = "0x182B29760")]
				internal void DWRQUAWWNWZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2B29710", Offset = "0x2B28710", VA = "0x182B29710")]
				internal bool DWMJWUCZELQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2B32EA0", Offset = "0x2B31EA0", VA = "0x182B32EA0")]
				internal bool WXQOZKRYVRK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2B32EF0", Offset = "0x2B31EF0", VA = "0x182B32EF0")]
				internal void WXVVWRLWFCT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CF90", Offset = "0x2B2BF90", VA = "0x182B2CF90")]
				internal List<KSTUYHQDXVF> VVLOLJATGMU(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CBA0", Offset = "0x2B2BBA0", VA = "0x182B2CBA0")]
				internal bool SVGRUYDEXMK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CB00", Offset = "0x2B2BB00", VA = "0x182B2CB00")]
				internal int SUGJIQHSCHR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CA70", Offset = "0x2B2BA70", VA = "0x182B2CA70")]
				internal Task<bool> SUBCLJNUSWI(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B920", Offset = "0x2B2A920", VA = "0x182B2B920")]
				internal bool LVFHOACUKCC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B970", Offset = "0x2B2A970", VA = "0x182B2B970")]
				internal bool LVKOLGWRTNL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B880", Offset = "0x2B2A880", VA = "0x182B2B880")]
				internal bool LUUTTMOZRFK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B8D0", Offset = "0x2B2A8D0", VA = "0x182B2B8D0")]
				internal int LVAAQTIXAQT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BA60", Offset = "0x2B2AA60", VA = "0x182B2BA60")]
				internal Task<bool> LWAJDBEJVVM(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BAF0", Offset = "0x2B2AAF0", VA = "0x182B2BAF0")]
				internal bool LWFQAHYHFGV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B9C0", Offset = "0x2B2A9C0", VA = "0x182B2B9C0")]
				internal bool LVPVINQPCYU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BA10", Offset = "0x2B2AA10", VA = "0x182B2BA10")]
				internal bool LVVCFUKMMKD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B830", Offset = "0x2B2A830", VA = "0x182B2B830")]
				internal bool LTULHETMWAR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A000", Offset = "0x2B29000", VA = "0x182B2A000")]
				internal bool EUOCPHURUJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2B29230", Offset = "0x2B28230", VA = "0x182B29230")]
				internal string BNLYBKSOPCO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2B291C0", Offset = "0x2B281C0", VA = "0x182B291C0")]
				internal void BNGREDYRFRF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2B29380", Offset = "0x2B28380", VA = "0x182B29380")]
				internal int BOGZQLUEAVY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2B29320", Offset = "0x2B28320", VA = "0x182B29320")]
				internal void BOBSTFAGRKP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2B292D0", Offset = "0x2B282D0", VA = "0x182B292D0")]
				internal bool BNWLVYGJHZG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2B29170", Offset = "0x2B28170", VA = "0x182B29170")]
				internal bool BMBBUPJHBBD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2B29120", Offset = "0x2B28120", VA = "0x182B29120")]
				internal bool BLVUXIPJRPU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CD30", Offset = "0x2B2BD30", VA = "0x182B2CD30")]
				internal float UMZZZZEJIVO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CD80", Offset = "0x2B2BD80", VA = "0x182B2CD80")]
				internal void UNFGXFYGSGX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CDE0", Offset = "0x2B2BDE0", VA = "0x182B2CDE0")]
				internal bool UNKNUMSEBSG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CE30", Offset = "0x2B2BE30", VA = "0x182B2CE30")]
				internal bool UNPURTMBLDP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CE80", Offset = "0x2B2BE80", VA = "0x182B2CE80")]
				internal bool UNVBPAFYUOY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2B29FB0", Offset = "0x2B28FB0", VA = "0x182B29FB0")]
				internal bool EUDOUUGXBNB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2B29F60", Offset = "0x2B28F60", VA = "0x182B29F60")]
				internal bool ETYHXNMZSBS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2B29F10", Offset = "0x2B28F10", VA = "0x182B29F10")]
				internal bool ETTBAGTCIQJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2B29B00", Offset = "0x2B28B00", VA = "0x182B29B00")]
				internal void ETNUCZZEZFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CED0", Offset = "0x2B2BED0", VA = "0x182B2CED0")]
				internal string UOAIMGZWEAH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CF20", Offset = "0x2B2BF20", VA = "0x182B2CF20")]
				internal void UOFPJNTTNLQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2B29AB0", Offset = "0x2B28AB0", VA = "0x182B29AB0")]
				internal bool ETINFTFHPTR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2B29A60", Offset = "0x2B28A60", VA = "0x182B29A60")]
				internal bool ETDGIMLKGII()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A310", Offset = "0x2B29310", VA = "0x182B2A310")]
				internal bool EWEFTJXWRWN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A050", Offset = "0x2B29050", VA = "0x182B2A050")]
				internal void EVYYWDDZILE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2B334F0", Offset = "0x2B324F0", VA = "0x182B334F0")]
				internal bool XTWXQPMPERK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2B33540", Offset = "0x2B32540", VA = "0x182B33540")]
				internal bool XUCENWGMOCT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2B33590", Offset = "0x2B32590", VA = "0x182B33590")]
				internal bool XUHLLDAJXOC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2B335E0", Offset = "0x2B325E0", VA = "0x182B335E0")]
				internal bool XUMSIJUHGZL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2B33330", Offset = "0x2B32330", VA = "0x182B33330")]
				internal void XTBWBOKZSYA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2B33400", Offset = "0x2B32400", VA = "0x182B33400")]
				internal bool XTHCYVEXCJJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2B33450", Offset = "0x2B32450", VA = "0x182B33450")]
				internal bool XTMJWBYULUS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2B334A0", Offset = "0x2B324A0", VA = "0x182B334A0")]
				internal bool XTRQTISRVGB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2B33630", Offset = "0x2B32630", VA = "0x182B33630")]
				internal bool XVNAURPUCEE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2B33680", Offset = "0x2B32680", VA = "0x182B33680")]
				internal void XVSHRYJRLPN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BC30", Offset = "0x2B2AC30", VA = "0x182B2BC30")]
				internal bool PATBJNPFWZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BBE0", Offset = "0x2B2ABE0", VA = "0x182B2BBE0")]
				internal bool PANUMGVINNS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BCD0", Offset = "0x2B2ACD0", VA = "0x182B2BCD0")]
				internal bool PBDPEBDAPVT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BC80", Offset = "0x2B2AC80", VA = "0x182B2BC80")]
				internal bool PAYIGUJDGKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BDB0", Offset = "0x2B2ADB0", VA = "0x182B2BDB0")]
				internal object PBYQTCEQBPD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BD20", Offset = "0x2B2AD20", VA = "0x182B2BD20")]
				internal void PBTJVVKSSDU(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BB90", Offset = "0x2B2AB90", VA = "0x182B2BB90")]
				internal bool OZCYFLMAZMH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BB40", Offset = "0x2B2AB40", VA = "0x182B2BB40")]
				internal bool OYXRIESDQAY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A9B0", Offset = "0x2B299B0", VA = "0x182B2A9B0")]
				internal int IAHDICBAQSB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A950", Offset = "0x2B29950", VA = "0x182B2A950")]
				internal void HZRIQHTIOKA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A900", Offset = "0x2B29900", VA = "0x182B2A900")]
				internal bool HZMBTAZLEYR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A8B0", Offset = "0x2B298B0", VA = "0x182B2A8B0")]
				internal bool HYWHBGRTCQQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AA00", Offset = "0x2B29A00", VA = "0x182B2AA00")]
				internal int IBXGMEEFOEV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2B33AD0", Offset = "0x2B32AD0", VA = "0x182B33AD0")]
				internal void ZQJLUEQAPMK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2B33B30", Offset = "0x2B32B30", VA = "0x182B33B30")]
				internal bool ZQOSRLJXYXT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2B33A30", Offset = "0x2B32A30", VA = "0x182B33A30")]
				internal bool ZPYXZRCFWPS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2B33A80", Offset = "0x2B32A80", VA = "0x182B33A80")]
				internal bool ZQEEWXWDGBB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2B33B80", Offset = "0x2B32B80", VA = "0x182B33B80")]
				internal int ZQTZOSDVIJC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2B33BD0", Offset = "0x2B32BD0", VA = "0x182B33BD0")]
				internal void ZQZGLYXSRUL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2B33990", Offset = "0x2B32990", VA = "0x182B33990")]
				internal bool ZOTIQCMVRZQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2B339E0", Offset = "0x2B329E0", VA = "0x182B339E0")]
				internal bool ZOYPNJGTBKZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A860", Offset = "0x2B29860", VA = "0x182B2A860")]
				internal bool GRAQSWYDFET()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A760", Offset = "0x2B29760", VA = "0x182B2A760")]
				internal object GQAIGPCQKAA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A7D0", Offset = "0x2B297D0", VA = "0x182B2A7D0")]
				internal void GQQCYJKIMIB(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A710", Offset = "0x2B29710", VA = "0x182B2A710")]
				internal bool GPKNOUUYHRZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A6C0", Offset = "0x2B296C0", VA = "0x182B2A6C0")]
				internal bool GPFGROBAYGQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B690", Offset = "0x2B2A690", VA = "0x182B2B690")]
				internal object? LPBBWTZVKBS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B700", Offset = "0x2B2A700", VA = "0x182B2B700")]
				internal void LPGIUATSTNB(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B540", Offset = "0x2B2A540", VA = "0x182B2B540")]
				internal bool LOGAHSYFYII()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B590", Offset = "0x2B2A590", VA = "0x182B2B590")]
				internal int LOLHEZSDHTR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B5E0", Offset = "0x2B2A5E0", VA = "0x182B2B5E0")]
				internal void LOQOCGMARFA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B640", Offset = "0x2B2A640", VA = "0x182B2B640")]
				internal bool LOVUZNFYAQJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B790", Offset = "0x2B2A790", VA = "0x182B2B790")]
				internal bool LQRFAWDAHOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B7E0", Offset = "0x2B2A7E0", VA = "0x182B2B7E0")]
				internal bool LQWLYCWXQZV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C980", Offset = "0x2B2B980", VA = "0x182B2C980")]
				internal int SPSGVMHXZUB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C920", Offset = "0x2B2B920", VA = "0x182B2C920")]
				internal void SPMZYFOAQIS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C8D0", Offset = "0x2B2B8D0", VA = "0x182B2C8D0")]
				internal bool SPHTAYUDGXJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C880", Offset = "0x2B2B880", VA = "0x182B2C880")]
				internal bool SPCMDSAFXMA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C830", Offset = "0x2B2B830", VA = "0x182B2C830")]
				internal bool SOXFGLGIOAR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C7E0", Offset = "0x2B2B7E0", VA = "0x182B2C7E0")]
				internal float SORYJEMLEPI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C780", Offset = "0x2B2B780", VA = "0x182B2C780")]
				internal void SOMRLXSNVDZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C730", Offset = "0x2B2B730", VA = "0x182B2C730")]
				internal bool SOHKOQYQLSQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CA20", Offset = "0x2B2BA20", VA = "0x182B2CA20")]
				internal bool SRIJZOLCXGV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C9D0", Offset = "0x2B2B9D0", VA = "0x182B2C9D0")]
				internal bool SRDDCHRFNVM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2B338E0", Offset = "0x2B328E0", VA = "0x182B338E0")]
				internal float YUDDCZVKGMK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2B33930", Offset = "0x2B32930", VA = "0x182B33930")]
				internal void YUIKAGPHPXT(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2B33890", Offset = "0x2B32890", VA = "0x182B33890")]
				internal bool YTSPIMHPNPS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2B33840", Offset = "0x2B32840", VA = "0x182B33840")]
				internal bool YTNILFNSEEJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2B33780", Offset = "0x2B32780", VA = "0x182B33780")]
				internal string YSXNTLGABWI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2B337D0", Offset = "0x2B327D0", VA = "0x182B337D0")]
				internal void YTCUQRZXLHR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2B336E0", Offset = "0x2B326E0", VA = "0x182B336E0")]
				internal bool YSMZYXSFIZQ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2B33730", Offset = "0x2B32730", VA = "0x182B33730")]
				internal bool YSSGWEMCSKZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A3B0", Offset = "0x2B293B0", VA = "0x182B2A3B0")]
				internal bool FOHVLJQTGFR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A360", Offset = "0x2B29360", VA = "0x182B2A360")]
				internal bool FOCOOCWVWUI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A470", Offset = "0x2B29470", VA = "0x182B2A470")]
				internal string FOSJFXENZCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A400", Offset = "0x2B29400", VA = "0x182B2A400")]
				internal void FONCIQKQPRA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A510", Offset = "0x2B29510", VA = "0x182B2A510")]
				internal bool FPCXAKSIRZB(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A4C0", Offset = "0x2B294C0", VA = "0x182B2A4C0")]
				internal bool FOXQDDYLINS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A5B0", Offset = "0x2B295B0", VA = "0x182B2A5B0")]
				internal bool FPNKUYGDKVT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A560", Offset = "0x2B29560", VA = "0x182B2A560")]
				internal bool FPIDXRMGBKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A670", Offset = "0x2B29670", VA = "0x182B2A670")]
				internal string FPXYPLTYDSL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A600", Offset = "0x2B29600", VA = "0x182B2A600")]
				internal void FPSRSFAAUHC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AEA0", Offset = "0x2B29EA0", VA = "0x182B2AEA0")]
				internal bool KSUTFPFFBBS(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AEF0", Offset = "0x2B29EF0", VA = "0x182B2AEF0")]
				internal bool KTAACVZCKNB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AF40", Offset = "0x2B29F40", VA = "0x182B2AF40")]
				internal bool KTFHACSZTYK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AF90", Offset = "0x2B29F90", VA = "0x182B2AF90")]
				internal bool KTKNXJMXDJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AFE0", Offset = "0x2B29FE0", VA = "0x182B2AFE0")]
				internal string KTPUUQGUMVC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B030", Offset = "0x2B2A030", VA = "0x182B2B030")]
				internal void KTVBRXARWGL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B0A0", Offset = "0x2B2A0A0", VA = "0x182B2B0A0")]
				internal bool KUAIPDUPFRU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B0F0", Offset = "0x2B2A0F0", VA = "0x182B2B0F0")]
				internal bool KUFPMKOMPDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AE00", Offset = "0x2B29E00", VA = "0x182B2AE00")]
				internal bool KREQBNCADOY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AE50", Offset = "0x2B29E50", VA = "0x182B2AE50")]
				internal bool KRJWYTVXNAH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C580", Offset = "0x2B2B580", VA = "0x182B2C580")]
				internal string RTLYEHNHQUB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C510", Offset = "0x2B2B510", VA = "0x182B2C510")]
				internal void RTGRHATKHIS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C4C0", Offset = "0x2B2B4C0", VA = "0x182B2C4C0")]
				internal bool RTBKJTZMXXJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C470", Offset = "0x2B2B470", VA = "0x182B2C470")]
				internal bool RSWDMNFPOMA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C6E0", Offset = "0x2B2B6E0", VA = "0x182B2C6E0")]
				internal bool RUGZTIOXCNL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C690", Offset = "0x2B2B690", VA = "0x182B2C690")]
				internal bool RUBSWBUZTCC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C640", Offset = "0x2B2B640", VA = "0x182B2C640")]
				internal string RTWLYVBCJQT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C5D0", Offset = "0x2B2B5D0", VA = "0x182B2C5D0")]
				internal void RTRFBOHFAFK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C420", Offset = "0x2B2B420", VA = "0x182B2C420")]
				internal bool RRVVAFKCTHH(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C3D0", Offset = "0x2B2B3D0", VA = "0x182B2C3D0")]
				internal bool RRQOCYQFJVY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2B33100", Offset = "0x2B32100", VA = "0x182B33100")]
				internal bool XRKHVMOAHNI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2B33150", Offset = "0x2B32150", VA = "0x182B33150")]
				internal bool XRPOSTHXQYR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B33040", Offset = "0x2B32040", VA = "0x182B33040")]
				internal string XQZUAZAFOQQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B33090", Offset = "0x2B32090", VA = "0x182B33090")]
				internal void XRFAYFUCYBZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B33240", Offset = "0x2B32240", VA = "0x182B33240")]
				internal bool XSFJKNPPTGS(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2B33290", Offset = "0x2B32290", VA = "0x182B33290")]
				internal bool XSKQHUJNCSB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B331A0", Offset = "0x2B321A0", VA = "0x182B331A0")]
				internal bool XRUVQABVAKA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2B331F0", Offset = "0x2B321F0", VA = "0x182B331F0")]
				internal bool XSACNGVSJVJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B332E0", Offset = "0x2B322E0", VA = "0x182B332E0")]
				internal string XTAKZORFFAC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B33390", Offset = "0x2B32390", VA = "0x182B33390")]
				internal void XTFRWVLCOLL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2B29580", Offset = "0x2B28580", VA = "0x182B29580")]
				internal bool DSDOGWXCLJJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2B29530", Offset = "0x2B28530", VA = "0x182B29530")]
				internal bool DRYHJQDFBYA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B29620", Offset = "0x2B28620", VA = "0x182B29620")]
				internal bool DSOCBKKXEGB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2B295D0", Offset = "0x2B285D0", VA = "0x182B295D0")]
				internal bool DSIVEDQZUUS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B29440", Offset = "0x2B28440", VA = "0x182B29440")]
				internal string DRIMRVVMZPZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2B293D0", Offset = "0x2B283D0", VA = "0x182B293D0")]
				internal void DRDFUPBPQEQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B294E0", Offset = "0x2B284E0", VA = "0x182B294E0")]
				internal bool DRTAMJJHSMR(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B29490", Offset = "0x2B28490", VA = "0x182B29490")]
				internal bool DRNTPCPKJBI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2B296C0", Offset = "0x2B286C0", VA = "0x182B296C0")]
				internal bool DTTRKZAHIWD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B29670", Offset = "0x2B28670", VA = "0x182B29670")]
				internal bool DTOKNSGJZKU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BE90", Offset = "0x2B2AE90", VA = "0x182B2BE90")]
				internal string PINCFTPXNZN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BE20", Offset = "0x2B2AE20", VA = "0x182B2BE20")]
				internal void PIHVIMWAEOE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BEE0", Offset = "0x2B2AEE0", VA = "0x182B2BEE0")]
				internal bool PISJDAJUXKW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BF80", Offset = "0x2B2AF80", VA = "0x182B2BF80")]
				internal bool PJIDUURMZSX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BF30", Offset = "0x2B2AF30", VA = "0x182B2BF30")]
				internal bool PJCWXNXPQHO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C040", Offset = "0x2B2B040", VA = "0x182B2C040")]
				internal string PJSRPIFHSPP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BFD0", Offset = "0x2B2AFD0", VA = "0x182B2BFD0")]
				internal void PJNKSBLKJEG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C0E0", Offset = "0x2B2B0E0", VA = "0x182B2C0E0")]
				internal bool PKDFJVTCLMH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C090", Offset = "0x2B2B090", VA = "0x182B2C090")]
				internal bool PJXYMOZFCAY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B2ACC0", Offset = "0x2B29CC0", VA = "0x182B2ACC0")]
				internal bool IOIJXJUOOGG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AD10", Offset = "0x2B29D10", VA = "0x182B2AD10")]
				internal string IONQUQOLXRP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AC00", Offset = "0x2B29C00", VA = "0x182B2AC00")]
				internal void INXWCWGTVJO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AC70", Offset = "0x2B29C70", VA = "0x182B2AC70")]
				internal bool IODDADAREUX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AB60", Offset = "0x2B29B60", VA = "0x182B2AB60")]
				internal bool INNIIISZCMW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2B2ABB0", Offset = "0x2B29BB0", VA = "0x182B2ABB0")]
				internal bool INSPFPMWLYF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AAA0", Offset = "0x2B29AA0", VA = "0x182B2AAA0")]
				internal string INCUNVFEJQE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AAF0", Offset = "0x2B29AF0", VA = "0x182B2AAF0")]
				internal void INIBLBZBTBN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AA50", Offset = "0x2B29A50", VA = "0x182B2AA50")]
				internal bool IMXNQOLHAEV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B29280", Offset = "0x2B28280", VA = "0x182B29280")]
				internal bool BNREYRMLYNX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C380", Offset = "0x2B2B380", VA = "0x182B2C380")]
				internal float QLQLHULCFVH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C320", Offset = "0x2B2B320", VA = "0x182B2C320")]
				internal void QLLEKNREWJY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C230", Offset = "0x2B2B230", VA = "0x182B2C230")]
				internal bool QKKVYFVSBFF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C1E0", Offset = "0x2B2B1E0", VA = "0x182B2C1E0")]
				internal bool QKFPAZBURTW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C2D0", Offset = "0x2B2B2D0", VA = "0x182B2C2D0")]
				internal bool QKVJSTJMUBX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C280", Offset = "0x2B2B280", VA = "0x182B2C280")]
				internal int QKQCVMPPKQO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C180", Offset = "0x2B2B180", VA = "0x182B2C180")]
				internal void QJPUJEUCPLV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C130", Offset = "0x2B2B130", VA = "0x182B2C130")]
				internal bool QJKNLYAFGAM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AD60", Offset = "0x2B29D60", VA = "0x182B2AD60")]
				internal bool JKOSOOPEXGG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B2ADB0", Offset = "0x2B29DB0", VA = "0x182B2ADB0")]
				internal bool JKTZLVJCGRP()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class XDCUWQBLKMK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string MTVINRNENAZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public XDIBTWVITXT OYIFPNPIBTY;

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XDCUWQBLKMK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DC90", Offset = "0x2B4CC90", VA = "0x182B4DC90")]
				internal void EUIVSBAUKYK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class XCXNZJHOBBB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] PGSEZDODGVA;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XCXNZJHOBBB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DC20", Offset = "0x2B4CC20", VA = "0x182B4DC20")]
				internal bool QLAQQADKDNG(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers FOEDRSSVQTN;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B154B0", Offset = "0x2B144B0", VA = "0x182B154B0")]
			public BMAJJYHEOJX(ICGXRSEYDCA a, DCFBHQTDMWG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2B138A0", Offset = "0x2B128A0", VA = "0x182B138A0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class EIBWQHVZJBE : QDOMVXBDPPR<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B38CC0", Offset = "0x2B37CC0", VA = "0x182B38CC0")]
			public EIBWQHVZJBE(ICGXRSEYDCA a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2B38410", Offset = "0x2B37410", VA = "0x182B38410", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B38BC0", Offset = "0x2B37BC0", VA = "0x182B38BC0")]
			private static string ZACOOJMOFTQ(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B38B20", Offset = "0x2B37B20", VA = "0x182B38B20")]
			[CompilerGenerated]
			private object? XCUFWZLZXYZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B38A10", Offset = "0x2B37A10", VA = "0x182B38A10")]
			[CompilerGenerated]
			private void XCOYZSSCONQ(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B38800", Offset = "0x2B37800", VA = "0x182B38800")]
			[CompilerGenerated]
			private string XCJSCLYFFCH(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B38760", Offset = "0x2B37760", VA = "0x182B38760")]
			[CompilerGenerated]
			private IReadOnlyList<object> XCELFFEHVQY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B38700", Offset = "0x2B37700", VA = "0x182B38700")]
			[CompilerGenerated]
			private string? XBZEHYKKMFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B386C0", Offset = "0x2B376C0", VA = "0x182B386C0")]
			[CompilerGenerated]
			private bool XBTXKRQNCUG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class BMYKCXIZEPG : QDOMVXBDPPR<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
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
					public CWRWNJLXLSS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60002FE")]
					[Cpp2IlInjected.Address(RVA = "0x2B4C1B0", Offset = "0x2B4B1B0", VA = "0x182B4C1B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60002FF")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public BMYKCXIZEPG FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x2B365B0", Offset = "0x2B355B0", VA = "0x182B365B0")]
				internal string LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B361C0", Offset = "0x2B351C0", VA = "0x182B361C0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void LKIYLCKNDRA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2B35E10", Offset = "0x2B34E10", VA = "0x182B35E10")]
				internal int LKDRNVQPUFR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B35AB0", Offset = "0x2B34AB0", VA = "0x182B35AB0")]
				internal void LJYKQOWSKUI(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B34830", Offset = "0x2B33830", VA = "0x182B34830")]
			public BMYKCXIZEPG(ICGXRSEYDCA a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B34500", Offset = "0x2B33500", VA = "0x182B34500", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class DJEKTNIXVYF : QDOMVXBDPPR<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class YNXANUMFTWX
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
					public YNXANUMFTWX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000313")]
					[Cpp2IlInjected.Address(RVA = "0x2B4BE70", Offset = "0x2B4AE70", VA = "0x182B4BE70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000314")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public YNXANUMFTWX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2B4C760", Offset = "0x2B4B760", VA = "0x182B4C760", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public DJEKTNIXVYF FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public YNXANUMFTWX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F440", Offset = "0x2B4E440", VA = "0x182B4F440")]
				internal string LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F370", Offset = "0x2B4E370", VA = "0x182B4F370")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void LKIYLCKNDRA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F320", Offset = "0x2B4E320", VA = "0x182B4F320")]
				internal int LKDRNVQPUFR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F290", Offset = "0x2B4E290", VA = "0x182B4F290")]
				internal Task<bool> LJYKQOWSKUI(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F640", Offset = "0x2B4E640", VA = "0x182B4F640")]
				internal string LLJGXKFZYVT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F570", Offset = "0x2B4E570", VA = "0x182B4F570")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void LLEAADMCPKK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F520", Offset = "0x2B4E520", VA = "0x182B4F520")]
				internal bool LKYTCWSFFZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F490", Offset = "0x2B4E490", VA = "0x182B4F490")]
				internal void LKTMFPYHWNS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F240", Offset = "0x2B4E240", VA = "0x182B4F240")]
				internal bool LIYCEHBFPPP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F1B0", Offset = "0x2B4E1B0", VA = "0x182B4F1B0")]
				internal void LISVHAHIGEG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F0D0", Offset = "0x2B4E0D0", VA = "0x182B4F0D0")]
				internal float KYYYWVIEBCC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F120", Offset = "0x2B4E120", VA = "0x182B4F120")]
				internal void KZEFUCCBKNL(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EFD0", Offset = "0x2B4DFD0", VA = "0x182B4EFD0")]
				internal int KYOLCHUJIFK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F030", Offset = "0x2B4E030", VA = "0x182B4F030")]
				internal void KYTRZOOGRQT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EF60", Offset = "0x2B4DF60", VA = "0x182B4EF60")]
				internal bool KYDXHUGOPIS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2B383A0", Offset = "0x2B373A0", VA = "0x182B383A0")]
			public DJEKTNIXVYF(ICGXRSEYDCA a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2B37A40", Offset = "0x2B36A40", VA = "0x182B37A40", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class SJXYFULTBHK : QDOMVXBDPPR<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public SJXYFULTBHK FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x2B36510", Offset = "0x2B35510", VA = "0x182B36510")]
				internal Dictionary<string, EnumChoiceData> LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x2B35FB0", Offset = "0x2B34FB0", VA = "0x182B35FB0")]
				internal int LKIYLCKNDRA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2B35B90", Offset = "0x2B34B90", VA = "0x182B35B90")]
				internal void LKDRNVQPUFR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2B35A30", Offset = "0x2B34A30", VA = "0x182B35A30")]
				internal bool LJYKQOWSKUI()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2B46A60", Offset = "0x2B45A60", VA = "0x182B46A60")]
			public SJXYFULTBHK(ICGXRSEYDCA a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2B467B0", Offset = "0x2B457B0", VA = "0x182B467B0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class UELQVBTWXPT : QDOMVXBDPPR<ABMRROJYFLU>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public UELQVBTWXPT FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x2B36400", Offset = "0x2B35400", VA = "0x182B36400")]
				internal void LKOFIJEKNCJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D2A0", Offset = "0x2B4C2A0", VA = "0x182B4D2A0")]
			public UELQVBTWXPT(ICGXRSEYDCA a, ABMRROJYFLU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D120", Offset = "0x2B4C120", VA = "0x182B4D120", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class UDULUERQBYT<a> : ZMRONPVQTEA<a> where a : notnull, OPVRPOHXWWB
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override TIVPUTBUVWI? JWHWQWCLAJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x64EF840", Offset = "0x64EE840", VA = "0x1864EF840", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x64EF8A0", Offset = "0x64EE8A0", VA = "0x1864EF8A0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xFDB2A0", Offset = "0xFDA2A0", VA = "0x180FDB2A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x64EF880", Offset = "0x64EE880", VA = "0x1864EF880")]
			public UDULUERQBYT(ICGXRSEYDCA a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class LNPTMCPBMVR : UDULUERQBYT<SMEPOWYSJWI>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class XDIBTWVITXT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public LNPTMCPBMVR FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XDIBTWVITXT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EAD0", Offset = "0x2B4DAD0", VA = "0x182B4EAD0")]
				internal object LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EA00", Offset = "0x2B4DA00", VA = "0x182B4EA00")]
				internal void LKIYLCKNDRA(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E8C0", Offset = "0x2B4D8C0", VA = "0x182B4E8C0")]
				internal void LKDRNVQPUFR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? MPAPMPGBCBZ;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D120", Offset = "0x2B3C120", VA = "0x182B3D120")]
			public LNPTMCPBMVR(ICGXRSEYDCA a, SMEPOWYSJWI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CBA0", Offset = "0x2B3BBA0", VA = "0x182B3CBA0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class MCQINFDOFBM : QDOMVXBDPPR<NSPQJFWSBKL>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public MCQINFDOFBM FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<OEYGGGUNRJW>> CFIWHARJRIC;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BC50", Offset = "0x2B3AC50", VA = "0x182B3BC50")]
				internal int LKIYLCKNDRA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B920", Offset = "0x2B3A920", VA = "0x182B3B920")]
				internal void LKDRNVQPUFR(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class LCJWXRCFJDJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<OEYGGGUNRJW> OTIBMHRUJUU;

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCJWXRCFJDJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CB00", Offset = "0x2B3BB00", VA = "0x182B3CB00")]
				internal bool LLJGXKFZYVT(Id32<OEYGGGUNRJW> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DC80", Offset = "0x2B3CC80", VA = "0x182B3DC80")]
			public MCQINFDOFBM(ICGXRSEYDCA a, NSPQJFWSBKL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D750", Offset = "0x2B3C750", VA = "0x182B3D750", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class SHBQNEPXTXY : QDOMVXBDPPR<BSLSYMVFYVB>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xEE0AC0", Offset = "0xEDFAC0", VA = "0x180EE0AC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2B46740", Offset = "0x2B45740", VA = "0x182B46740")]
			public SHBQNEPXTXY(ICGXRSEYDCA a, BSLSYMVFYVB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class XXSGVXKQAWF : QDOMVXBDPPR<YJQERDXKMKO>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0xC6B960", Offset = "0xC6A960", VA = "0x180C6B960", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EB30", Offset = "0x2B4DB30", VA = "0x182B4EB30")]
			public XXSGVXKQAWF(ICGXRSEYDCA a, YJQERDXKMKO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "134")]
			protected override bool OODRGKLIHLD(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class NWBOILMYBCR : QDOMVXBDPPR<WZJTGIKWXKK>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF70A0", VA = "0x180DF80A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0x2B40C50", Offset = "0x2B3FC50", VA = "0x182B40C50", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2B40BE0", Offset = "0x2B3FBE0", VA = "0x182B40BE0")]
			public NWBOILMYBCR(ICGXRSEYDCA a, WZJTGIKWXKK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class WPEBOZAYXEF : QDOMVXBDPPR<DIAPKFPCYNI>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DB70", Offset = "0x2B4CB70", VA = "0x182B4DB70", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DB00", Offset = "0x2B4CB00", VA = "0x182B4DB00")]
			public WPEBOZAYXEF(ICGXRSEYDCA a, DIAPKFPCYNI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class KRHDKAAHEQY : XQJSZXCPIPV<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public KRHDKAAHEQY FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C940", Offset = "0x2B3B940", VA = "0x182B3C940")]
				internal float VTFNHPOCUGY()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C9C0", Offset = "0x2B3B9C0", VA = "0x182B3C9C0")]
				internal void VTKUEWIADSH(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B5C0", Offset = "0x2B3A5C0", VA = "0x182B3B5C0")]
			public KRHDKAAHEQY(ICGXRSEYDCA a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B350", Offset = "0x2B3A350", VA = "0x182B3B350", Slot = "151")]
			protected override void GCYUHCMHKPK(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class QGQXLYBBWYB : QDOMVXBDPPR<BFHYZYXBXWS>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2B40D00", Offset = "0x2B3FD00", VA = "0x182B40D00")]
			public QGQXLYBBWYB(ICGXRSEYDCA a, BFHYZYXBXWS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class UYFMKSYVOEZ : QDOMVXBDPPR<VFRNGTFMYTE>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000353")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D550", Offset = "0x2B4C550", VA = "0x182B4D550")]
			public UYFMKSYVOEZ(ICGXRSEYDCA a, VFRNGTFMYTE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class DHAZOEOMLEU : QDOMVXBDPPR<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public DHAZOEOMLEU FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C360", Offset = "0x2B3B360", VA = "0x182B3C360")]
				internal bool LKOFIJEKNCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BF40", Offset = "0x2B3AF40", VA = "0x182B3BF40")]
				internal void LKIYLCKNDRA(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2B379D0", Offset = "0x2B369D0", VA = "0x182B379D0")]
			public DHAZOEOMLEU(ICGXRSEYDCA a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2B37740", Offset = "0x2B36740", VA = "0x182B37740", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class BRUXUCJKJGI : QDOMVXBDPPR<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public BRUXUCJKJGI FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> RTJRFTOOUUZ;

				[Cpp2IlInjected.Token(Token = "0x600035D")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C400", Offset = "0x2B3B400", VA = "0x182B3C400")]
				internal object? LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C580", Offset = "0x2B3B580", VA = "0x182B3C580")]
				internal bool LKTMFPYHWNS(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C070", Offset = "0x2B3B070", VA = "0x182B3C070")]
				internal void LKIYLCKNDRA(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B670", Offset = "0x2B3A670", VA = "0x182B3B670")]
				internal string LKDRNVQPUFR(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B620", Offset = "0x2B3A620", VA = "0x182B3B620")]
				internal IReadOnlyList<object> LJYKQOWSKUI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C780", Offset = "0x2B3B780", VA = "0x182B3C780")]
				internal bool LLJGXKFZYVT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C730", Offset = "0x2B3B730", VA = "0x182B3C730")]
				internal bool LLEAADMCPKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C600", Offset = "0x2B3B600", VA = "0x182B3C600")]
				internal void LKYTCWSFFZB(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2B34F90", Offset = "0x2B33F90", VA = "0x182B34F90")]
			public BRUXUCJKJGI(ICGXRSEYDCA a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2B348A0", Offset = "0x2B338A0", VA = "0x182B348A0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class DFLKQWYVRXI : QDOMVXBDPPR<KKGDIWSPNST>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class YNXANUMFTWX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int FTODNMFJEUY;

				[Cpp2IlInjected.Token(Token = "0x600036B")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public YNXANUMFTWX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F690", Offset = "0x2B4E690", VA = "0x182B4F690")]
				internal bool ZPIAJEMPRPC(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class DABAUKZQTLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public DFLKQWYVRXI FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> RSEYPLSEGIW;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public DABAUKZQTLC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2B36F40", Offset = "0x2B35F40", VA = "0x182B36F40")]
				internal int LKOFIJEKNCJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0x2B36E20", Offset = "0x2B35E20", VA = "0x182B36E20")]
				internal void LKIYLCKNDRA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2B36D70", Offset = "0x2B35D70", VA = "0x182B36D70")]
				internal string? LKDRNVQPUFR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2B376D0", Offset = "0x2B366D0", VA = "0x182B376D0")]
			public DFLKQWYVRXI(ICGXRSEYDCA a, KKGDIWSPNST b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2B371D0", Offset = "0x2B361D0", VA = "0x182B371D0")]
			private int QDSCOJTYOKK(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2B375B0", Offset = "0x2B365B0", VA = "0x182B375B0")]
			private void YAKRDGYABOI(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2B37260", Offset = "0x2B36260", VA = "0x182B37260", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class BTITIWBDSDZ : UHOKMOSTNPX<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0xFF47B0", Offset = "0xFF37B0", VA = "0x180FF47B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2B35000", Offset = "0x2B34000", VA = "0x182B35000")]
			public BTITIWBDSDZ(ICGXRSEYDCA a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class IUDJQUJDJBH : XQJSZXCPIPV<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public IUDJQUJDJBH FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x6000375")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000376")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C7F0", Offset = "0x2B3B7F0", VA = "0x182B3C7F0")]
				internal int VTFNHPOCUGY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CA60", Offset = "0x2B3BA60", VA = "0x182B3CA60")]
				internal void VTKUEWIADSH(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A230", Offset = "0x2B39230", VA = "0x182B3A230")]
			public IUDJQUJDJBH(ICGXRSEYDCA a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2B39FC0", Offset = "0x2B38FC0", VA = "0x182B39FC0", Slot = "151")]
			protected override void GCYUHCMHKPK(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class BEPYPPFYDZZ : QDOMVXBDPPR<GDMWAUUWWGE>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public BEPYPPFYDZZ FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<OEYGGGUNRJW>> CFIWHARJRIC;

				[Cpp2IlInjected.Token(Token = "0x600037E")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600037F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BB10", Offset = "0x2B3AB10", VA = "0x182B3BB10")]
				internal int LKIYLCKNDRA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B7C0", Offset = "0x2B3A7C0", VA = "0x182B3B7C0")]
				internal void LKDRNVQPUFR(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class LCJWXRCFJDJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<OEYGGGUNRJW> OTIBMHRUJUU;

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCJWXRCFJDJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CB50", Offset = "0x2B3BB50", VA = "0x182B3CB50")]
				internal bool LLJGXKFZYVT(Id32<OEYGGGUNRJW> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2B34420", Offset = "0x2B33420", VA = "0x182B34420")]
			public BEPYPPFYDZZ(ICGXRSEYDCA a, GDMWAUUWWGE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2B33EF0", Offset = "0x2B32EF0", VA = "0x182B33EF0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class QUYEXQEKCXL : QDOMVXBDPPR<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public QUYEXQEKCXL FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x6000385")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C530", Offset = "0x2B3B530", VA = "0x182B3C530")]
				internal bool LKOFIJEKNCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BE20", Offset = "0x2B3AE20", VA = "0x182B3BE20")]
				internal void LKIYLCKNDRA(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2B40F40", Offset = "0x2B3FF40", VA = "0x182B40F40")]
			public QUYEXQEKCXL(ICGXRSEYDCA a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2B40D70", Offset = "0x2B3FD70", VA = "0x182B40D70", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class UUAECWGJOCZ : QDOMVXBDPPR<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public UUAECWGJOCZ FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C310", Offset = "0x2B3B310", VA = "0x182B3C310")]
				internal bool LKOFIJEKNCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BA80", Offset = "0x2B3AA80", VA = "0x182B3BA80")]
				internal void LKIYLCKNDRA(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D4E0", Offset = "0x2B4C4E0", VA = "0x182B4D4E0")]
			public UUAECWGJOCZ(ICGXRSEYDCA a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D310", Offset = "0x2B4C310", VA = "0x182B4D310", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class TNDFZZXZTCL : QDOMVXBDPPR<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public TNDFZZXZTCL FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x600038F")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C3B0", Offset = "0x2B3B3B0", VA = "0x182B3C3B0")]
				internal int LKOFIJEKNCJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BEB0", Offset = "0x2B3AEB0", VA = "0x182B3BEB0")]
				internal void LKIYLCKNDRA(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2B46D20", Offset = "0x2B45D20", VA = "0x182B46D20")]
			public TNDFZZXZTCL(ICGXRSEYDCA a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2B46AD0", Offset = "0x2B45AD0", VA = "0x182B46AD0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class EOHKEYPXJOY
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log BMHSVNOOAKJ;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class INOKLNLEMQT<a> : QDOMVXBDPPR<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class DCEYDDAQGHA
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
					public DCEYDDAQGHA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C6")]
					[Cpp2IlInjected.Address(RVA = "0x401AC70", Offset = "0x4019C70", VA = "0x18401AC70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C7")]
					[Cpp2IlInjected.Address(RVA = "0x401AFB0", Offset = "0x4019FB0", VA = "0x18401AFB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload RULSQXQNPJX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public INOKLNLEMQT<a> FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public DCEYDDAQGHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x4439AE0", Offset = "0x4438AE0", VA = "0x184439AE0")]
				[AsyncStateMachine(typeof(INOKLNLEMQT<>.DCEYDDAQGHA.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task NWTCJAXUBLV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0x4439BB0", Offset = "0x4438BB0", VA = "0x184439BB0")]
				internal void RPOIVZQZDAE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class VICQOXFGHOY
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
					public VICQOXFGHOY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003D9")]
					[Cpp2IlInjected.Address(RVA = "0x402DE60", Offset = "0x402CE60", VA = "0x18402DE60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DA")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public VICQOXFGHOY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x402F640", Offset = "0x402E640", VA = "0x18402F640", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0x402FD50", Offset = "0x402ED50", VA = "0x18402FD50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public HOLPEYTCWXS.MVZWSFBIDHA HWZALTGCEAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string AMUGTPZKIPY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string MIHGVFBSRDS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public INOKLNLEMQT<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper PLHDAJTCBVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool YZFWCRDRQMY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action URBIMQZQGWC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool NWZDNSQAGNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string NAKXYREUENI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action KMCESPSFVGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action QLKOXESALAS;

				[Cpp2IlInjected.Token(Token = "0x60003C8")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public VICQOXFGHOY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0x66C2C80", Offset = "0x66C1C80", VA = "0x1866C2C80")]
				internal void TFQOOCHBIPF(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x66C2C10", Offset = "0x66C1C10", VA = "0x1866C2C10")]
				internal void TFLHQVNDZDW(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
				internal string CBOQHTJHUYG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x66C28C0", Offset = "0x66C18C0", VA = "0x1866C28C0")]
				internal void CBTXFADFEJP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0x5C79490", Offset = "0x5C78490", VA = "0x185C79490")]
				internal bool CBECNFVNCBO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x66C2820", Offset = "0x66C1820", VA = "0x1866C2820")]
				internal char CBJJKMPKLMX((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				internal string? CCJRWUKXGRQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0xFF3790", Offset = "0xFF2790", VA = "0x180FF3790")]
				internal bool CCOYUBEUQCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0x66C2A50", Offset = "0x66C1A50", VA = "0x1866C2A50")]
				internal void CBZECGXCNUY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0x5C79490", Offset = "0x5C78490", VA = "0x185C79490")]
				internal bool CCEKZNQZXGH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x66C2740", Offset = "0x66C1740", VA = "0x1866C2740")]
				[AsyncStateMachine(typeof(INOKLNLEMQT<>.VICQOXFGHOY.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void BZYNDRGCXLM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x66C2B10", Offset = "0x66C1B10", VA = "0x1866C2B10")]
				internal void SXZNXBMRDTE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x66C2DF0", Offset = "0x66C1DF0", VA = "0x1866C2DF0")]
				[AsyncStateMachine(typeof(INOKLNLEMQT<>.VICQOXFGHOY.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task YGSOMHLAWAD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x66C2CD0", Offset = "0x66C1CD0", VA = "0x1866C2CD0")]
				internal void THBKUXQIWQQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x66C2EC0", Offset = "0x66C1EC0", VA = "0x1866C2EC0")]
				internal void YKDMIHVNDLG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x66C27E0", Offset = "0x66C17E0", VA = "0x1866C27E0")]
				internal bool CADUAYAAGWV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class HJGCIJSHBUR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter ERFWDFAFVXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public INOKLNLEMQT<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<HOLPEYTCWXS.FHMKWDNOETS> KKRILUIYHER;

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public HJGCIJSHBUR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0x526B0D0", Offset = "0x526A0D0", VA = "0x18526B0D0")]
				internal bool WSLSNFBLJVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0x526B000", Offset = "0x526A000", VA = "0x18526B000")]
				internal void KFKOEOAPUOV(HOLPEYTCWXS.FHMKWDNOETS a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class HJAVLCYJSJI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool ZJAXTHCLYKS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public KSTUYHQDXVF RAAKGAWOBQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public KSTUYHQDXVF HYOOHLXBLDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public KSTUYHQDXVF JWBFSMTARNQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string PVVHNBFZIGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public HJGCIJSHBUR OYIFPNPIBTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action RSEBWEZEQEX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action KKBNUABGEWQ;

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public HJAVLCYJSJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0xBB6F90", Offset = "0xBB5F90", VA = "0x180BB6F90")]
				internal bool BFPLUPRYPMJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x526ADC0", Offset = "0x5269DC0", VA = "0x18526ADC0")]
				internal void XXBTCNFOUDK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x526A950", Offset = "0x5269950", VA = "0x18526A950")]
				internal void WSQZKLVITGK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x5269EE0", Offset = "0x5268EE0", VA = "0x185269EE0")]
				internal void WTGUCGDAVOL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x5269F00", Offset = "0x5268F00", VA = "0x185269F00")]
				internal void WSBESRNQQYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x526A300", Offset = "0x5269300", VA = "0x18526A300")]
				internal void WSGLPYHOAJS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x5269EE0", Offset = "0x5268EE0", VA = "0x185269EE0")]
				internal void KEUTMTSXSGU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class HIVONWEMIXZ
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
					public HIVONWEMIXZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003EB")]
					[Cpp2IlInjected.Address(RVA = "0x403E090", Offset = "0x403D090", VA = "0x18403E090", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EC")]
					[Cpp2IlInjected.Address(RVA = "0x403E6D0", Offset = "0x403D6D0", VA = "0x18403E6D0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool GATNUZUDYSC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public HJAVLCYJSJI OYCYSGVKSIP;

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public HIVONWEMIXZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x5269BE0", Offset = "0x5268BE0", VA = "0x185269BE0")]
				[AsyncStateMachine(typeof(INOKLNLEMQT<>.HIVONWEMIXZ.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task EEXZZOHTFUI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x5269CB0", Offset = "0x5268CB0", VA = "0x185269CB0")]
				internal void WTBNEZJDMDC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class HIQHQPKOZMQ
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
					public HIQHQPKOZMQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F0")]
					[Cpp2IlInjected.Address(RVA = "0x403DA80", Offset = "0x403CA80", VA = "0x18403DA80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F1")]
					[Cpp2IlInjected.Address(RVA = "0x403E030", Offset = "0x403D030", VA = "0x18403E030", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload GJGMHVGNLLP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public HJAVLCYJSJI OXXRVABNIXG;

				[Cpp2IlInjected.Token(Token = "0x60003ED")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public HIQHQPKOZMQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EE")]
				[Cpp2IlInjected.Address(RVA = "0x5269950", Offset = "0x5268950", VA = "0x185269950")]
				[AsyncStateMachine(typeof(INOKLNLEMQT<>.HIQHQPKOZMQ.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task MRASOAWUBHJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0x52698E0", Offset = "0x52688E0", VA = "0x1852698E0")]
				internal void KFAAKAMVBSD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class MGBCVPXOPLS
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
					public MGBCVPXOPLS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F7")]
					[Cpp2IlInjected.Address(RVA = "0x403D5A0", Offset = "0x403C5A0", VA = "0x18403D5A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F8")]
					[Cpp2IlInjected.Address(RVA = "0x403DA20", Offset = "0x403CA20", VA = "0x18403DA20", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public INOKLNLEMQT<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload WTNCRRHCOYN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public HOLPEYTCWXS.FHMKWDNOETS HWZALTGCEAF;

				[Cpp2IlInjected.Token(Token = "0x60003F2")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public MGBCVPXOPLS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F3")]
				[Cpp2IlInjected.Address(RVA = "0x5AE0DA0", Offset = "0x5ADFDA0", VA = "0x185AE0DA0")]
				[AsyncStateMachine(typeof(INOKLNLEMQT<>.MGBCVPXOPLS.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task MNMFJWIGHZH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0x5AE0B50", Offset = "0x5ADFB50", VA = "0x185AE0B50")]
				internal bool JLEDWFAUOPR(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5AE0C30", Offset = "0x5ADFC30", VA = "0x185AE0C30")]
				internal void JLJKTLURYBA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5AE0D50", Offset = "0x5ADFD50", VA = "0x185AE0D50")]
				internal void JLORQSOPHMJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class ALKDSLXHLFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string GOXNHUBJUAQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public KSTUYHQDXVF MSVILOMEKGT;

				[Cpp2IlInjected.Token(Token = "0x60003F9")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public ALKDSLXHLFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FA")]
				[Cpp2IlInjected.Address(RVA = "0x5741E80", Offset = "0x5740E80", VA = "0x185741E80")]
				internal string? BTBIVKSHMUO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xC93980", Offset = "0xC92980", VA = "0x180C93980")]
				internal bool BTGPSRMEWFX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x5741E10", Offset = "0x5740E10", VA = "0x185741E10")]
				internal void BSQVAXEMTXW(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool JPOYHSOFZZT;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log BMHSVNOOAKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x534DD20", Offset = "0x534CD20", VA = "0x18534DD20")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x5350190", Offset = "0x534F190", VA = "0x185350190", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected HOLPEYTCWXS FOZEXLPHECD
			{
				[Cpp2IlInjected.Token(Token = "0x600039B")]
				[Cpp2IlInjected.Address(RVA = "0xADC200", Offset = "0xADB200", VA = "0x180ADC200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0xADBF10", Offset = "0xADAF10", VA = "0x180ADBF10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> JLHKOJVLPEO
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xB553E0", Offset = "0xB543E0", VA = "0x180B553E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xB556A0", Offset = "0xB546A0", VA = "0x180B556A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected LIDTGSJMWVY XRNXHDZAGZH
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xB554C0", Offset = "0xB544C0", VA = "0x180B554C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xB556C0", Offset = "0xB546C0", VA = "0x180B556C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected LXZKKHCQIOC FFHVBBEENZH
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xB553D0", Offset = "0xB543D0", VA = "0x180B553D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0xB553B0", Offset = "0xB543B0", VA = "0x180B553B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x5350160", Offset = "0x534F160", VA = "0x185350160")]
			protected INOKLNLEMQT(ICGXRSEYDCA a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x534CE90", Offset = "0x534BE90", VA = "0x18534CE90", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x534CE30", Offset = "0x534BE30", VA = "0x18534CE30", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x534DCC0", Offset = "0x534CCC0", VA = "0x18534DCC0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x534EEF0", Offset = "0x534DEF0", VA = "0x18534EEF0")]
			private void TFVLCZGPPWQ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x534F1D0", Offset = "0x534E1D0", VA = "0x18534F1D0", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x534BC90", Offset = "0x534AC90", VA = "0x18534BC90")]
			private void BCKKIFGXHYS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x534C320", Offset = "0x534B320", VA = "0x18534C320")]
			private void BGULLCYIEIW(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "151")]
			protected virtual void ZZKWZNXZYVX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x534E7F0", Offset = "0x534D7F0", VA = "0x18534E7F0")]
			private void NAGREWGAVQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x534F350", Offset = "0x534E350", VA = "0x18534F350")]
			private void VOELDOJBQHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x534CEF0", Offset = "0x534BEF0", VA = "0x18534CEF0")]
			private void DLGGCCQFMWY(HOLPEYTCWXS.FHMKWDNOETS a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x534ECE0", Offset = "0x534DCE0", VA = "0x18534ECE0")]
			private void RRYBFXUQEOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x534E6B0", Offset = "0x534D6B0", VA = "0x18534E6B0")]
			protected void JGATYZRUPDW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x534E900", Offset = "0x534D900", VA = "0x18534E900")]
			private void NWIBKCYZSOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x534E7D0", Offset = "0x534D7D0", VA = "0x18534E7D0")]
			private void MSZRZCXAZOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x534E6E0", Offset = "0x534D6E0", VA = "0x18534E6E0")]
			private void JSIKMGHYZRX(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x534FE50", Offset = "0x534EE50", VA = "0x18534FE50")]
			private string ZIVKKMXHVAH((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x534E740", Offset = "0x534D740", VA = "0x18534E740")]
			private string LTNQUIULAIY(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x534DDC0", Offset = "0x534CDC0", VA = "0x18534DDC0")]
			[CompilerGenerated]
			private object? ICUMSXHCWIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x534DDF0", Offset = "0x534CDF0", VA = "0x18534DDF0")]
			[CompilerGenerated]
			private void ICZTQEBAFTJ(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x534E5A0", Offset = "0x534D5A0", VA = "0x18534E5A0")]
			[CompilerGenerated]
			private IReadOnlyList<object> IDKHKROUYQB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x534E620", Offset = "0x534D620", VA = "0x18534E620")]
			[CompilerGenerated]
			private void IDPOHYISIBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x534DD70", Offset = "0x534CD70", VA = "0x18534DD70")]
			[CompilerGenerated]
			private void IBJQMBXVIGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x534FE10", Offset = "0x534EE10", VA = "0x18534FE10")]
			[CompilerGenerated]
			private void XOTJQGBPIEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x534E970", Offset = "0x534D970", VA = "0x18534E970")]
			[CompilerGenerated]
			private void PABUTQRLWPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x534ECA0", Offset = "0x534DCA0", VA = "0x18534ECA0")]
			[CompilerGenerated]
			private void QOXWDSCYZRI(HOLPEYTCWXS.FHMKWDNOETS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class JWWUZRDQGVC : INOKLNLEMQT<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF70A0", VA = "0x180DF80A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A820", Offset = "0x2B39820", VA = "0x182B3A820")]
			public JWWUZRDQGVC(ICGXRSEYDCA a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class FSGSUOYCKNO : INOKLNLEMQT<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type DZZBIIBFAJJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000405")]
					[Cpp2IlInjected.Address(RVA = "0x2B466F0", Offset = "0x2B456F0", VA = "0x182B466F0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope EKTKIMGMFNS
				{
					[Cpp2IlInjected.Token(Token = "0x6000406")]
					[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string HJLVHILQWZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000404")]
				[Cpp2IlInjected.Address(RVA = "0x14E4A50", Offset = "0x14E3A50", VA = "0x1814E4A50")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0x2B46600", Offset = "0x2B45600", VA = "0x182B46600", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x2B46530", Offset = "0x2B45530", VA = "0x182B46530", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool PNAWNJNJAEX(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2B46420", Offset = "0x2B45420", VA = "0x182B46420", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2B46390", Offset = "0x2B45390", VA = "0x182B46390", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2B46240", Offset = "0x2B45240", VA = "0x182B46240", Slot = "7")]
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
				protected virtual Type DZZBIIBFAJJ
				{
					[Cpp2IlInjected.Token(Token = "0x600040E")]
					[Cpp2IlInjected.Address(RVA = "0x2B47240", Offset = "0x2B46240", VA = "0x182B47240", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers GMGSBMEPDPE
				{
					[Cpp2IlInjected.Token(Token = "0x600040F")]
					[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string HJLVHILQWZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x14E4A50", Offset = "0x14E3A50", VA = "0x1814E4A50")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000411")]
				[Cpp2IlInjected.Address(RVA = "0x2B47150", Offset = "0x2B46150", VA = "0x182B47150", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000412")]
				[Cpp2IlInjected.Address(RVA = "0x2B47080", Offset = "0x2B46080", VA = "0x182B47080", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool PNAWNJNJAEX(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2B46F70", Offset = "0x2B45F70", VA = "0x182B46F70", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2B46D90", Offset = "0x2B45D90", VA = "0x182B46D90", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2B46E20", Offset = "0x2B45E20", VA = "0x182B46E20", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
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
					public CWRWNJLXLSS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000423")]
					[Cpp2IlInjected.Address(RVA = "0x2B4B160", Offset = "0x2B4A160", VA = "0x182B4B160", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000424")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public CWRWNJLXLSS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2B4B570", Offset = "0x2B4A570", VA = "0x182B4B570", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public FSGSUOYCKNO FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public LIDTGSJMWVY CQSMFOHTVNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> RRYUYYFHGTO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> RSEBWEZEQEX;

				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x2B36900", Offset = "0x2B35900", VA = "0x182B36900")]
				internal object? RZZZLANDLLR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0x2B36C60", Offset = "0x2B35C60", VA = "0x182B36C60")]
				internal bool SBQCPCQIIYL(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2B36830", Offset = "0x2B35830", VA = "0x182B36830")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void RZUSNTTGCAI(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2B36CC0", Offset = "0x2B35CC0", VA = "0x182B36CC0")]
				internal IReadOnlyList<TargetPlayersSelection> WHMUPGPFRJD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2B369E0", Offset = "0x2B359E0", VA = "0x182B369E0")]
				internal object? SAPUCUUVNTS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2B36C00", Offset = "0x2B35C00", VA = "0x182B36C00")]
				internal bool SBKVRVWKZNC(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2B36B30", Offset = "0x2B35B30", VA = "0x182B36B30")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void SBFOUPCNQBT(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> IKXATBYRAVV;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> NSQSALAYUNL;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> TLINVHNPFPX;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2B39CE0", Offset = "0x2B38CE0", VA = "0x182B39CE0")]
			public FSGSUOYCKNO(ICGXRSEYDCA a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x2B39550", Offset = "0x2B38550", VA = "0x182B39550", Slot = "151")]
			protected override void ZZKWZNXZYVX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2B39140", Offset = "0x2B38140", VA = "0x182B39140")]
			private static IReadOnlyList<TargetPlayersSelection> NSHXGSCFVUS(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class ZICJAJFYVYJ : OVERGDUXOHG<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType WTNUCHXCMID
			{
				[Cpp2IlInjected.Token(Token = "0x6000428")]
				[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F730", Offset = "0x2B4E730", VA = "0x182B4F730")]
			public ZICJAJFYVYJ(ICGXRSEYDCA a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class IKMQPHZEFVS : QDOMVXBDPPR<MOXNPQACASF>
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2B39F50", Offset = "0x2B38F50", VA = "0x182B39F50")]
			public IKMQPHZEFVS(ICGXRSEYDCA a, MOXNPQACASF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class QDOMVXBDPPR<a> : VBGMMRXSCJI, IDisposable where a : notnull, MOXNPQACASF
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class MVGSWCHOTEO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public QDOMVXBDPPR<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public ICGXRSEYDCA XVYQYEGQVLO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a TOZOHSYJFSZ;

				[Cpp2IlInjected.Token(Token = "0x60004B5")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public MVGSWCHOTEO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0x5AE89A0", Offset = "0x5AE79A0", VA = "0x185AE89A0")]
				internal RYJYHFMMMVN KGIDYHTLDNU(IEIHZQZXXRC a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class ZYUNALGBUPM
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
					public ZYUNALGBUPM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BB")]
					[Cpp2IlInjected.Address(RVA = "0x401D870", Offset = "0x401C870", VA = "0x18401D870", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BC")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string CAAFPQBUHOW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, BGYAXKJXFCB>> LBJEOPOHXSH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public QDOMVXBDPPR<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> VAKARVZZSUV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public HOLPEYTCWXS FOZEXLPHECD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> ESXSQXSSFBT;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public ZYUNALGBUPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				internal string OBXVKXLFYLW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
				internal void OCDCIEFDHXF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0x4204190", Offset = "0x4203190", VA = "0x184204190")]
				[AsyncStateMachine(typeof(QDOMVXBDPPR<>.ZYUNALGBUPM.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void OCIJFKZARIO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class SLWMLNKPORB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60004BD")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public SLWMLNKPORB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x6193000", Offset = "0x6192000", VA = "0x186193000")]
				internal Result<string, BGYAXKJXFCB> WUTCYTLUCGO(string a)
				{
					return default(Result<string, BGYAXKJXFCB>);
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
				public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public QDOMVXBDPPR<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0x53F95C0", Offset = "0x53F85C0", VA = "0x1853F95C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x53F9810", Offset = "0x53F8810", VA = "0x1853F9810", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public QDOMVXBDPPR<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x53F9880", Offset = "0x53F8880", VA = "0x1853F9880", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x53F9B00", Offset = "0x53F8B00", VA = "0x1853F9B00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly ICGXRSEYDCA DIBNZELRTOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool EUNFGDTNHTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<MMFHTWDPFRA, RYJYHFMMMVN> WIWCGPVFKGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<MMFHTWDPFRA, DEBFPVFXDBS> DVSOFRBVOSI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> OHFMXXEUHLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<MMFHTWDPFRA>>? HMNREOMUYPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<MMFHTWDPFRA>, DEBFPVFXDBS>? AAKJYWJXYPS;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected SDUXUOJZYIJ SJCOOQFJORS
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0x5E2D740", Offset = "0x5E2C740", VA = "0x185E2D740")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected ZZZJGZASNDB ZZZJGZASNDB
			{
				[Cpp2IlInjected.Token(Token = "0x600042B")]
				[Cpp2IlInjected.Address(RVA = "0x5E2F350", Offset = "0x5E2E350", VA = "0x185E2F350")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected RRPMJEEQJEK VTYZXDTSMPP
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x5E30400", Offset = "0x5E2F400", VA = "0x185E30400")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a MOXNPQACASF
			{
				[Cpp2IlInjected.Token(Token = "0x6000430")]
				[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<ZOMVBRTCATC> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000431")]
				[Cpp2IlInjected.Address(RVA = "0x1718880", Offset = "0x1717880", VA = "0x181718880", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<ZOMVBRTCATC>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<SPOBLADDTYT> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0x5E30EF0", Offset = "0x5E2FEF0", VA = "0x185E30EF0", Slot = "6")]
				get
				{
					return default(Id32<SPOBLADDTYT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0x5E30D60", Offset = "0x5E2FD60", VA = "0x185E30D60", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x5E30D40", Offset = "0x5E2FD40", VA = "0x185E30D40", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x6000438")]
				[Cpp2IlInjected.Address(RVA = "0x5E31050", Offset = "0x5E30050", VA = "0x185E31050", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<SEUZJGPNHQJ> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xBE8B90", Offset = "0xBE7B90", VA = "0x180BE8B90", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<SEUZJGPNHQJ>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0x10B6990", Offset = "0x10B5990", VA = "0x1810B6990")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xB1CCF0", Offset = "0xB1BCF0", VA = "0x180B1CCF0", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0x5E30C10", Offset = "0x5E2FC10", VA = "0x185E30C10", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0x5E30C40", Offset = "0x5E2FC40", VA = "0x185E30C40", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x5E30C70", Offset = "0x5E2FC70", VA = "0x185E30C70", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x5E30ED0", Offset = "0x5E2FED0", VA = "0x185E30ED0", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x5E30E00", Offset = "0x5E2FE00", VA = "0x185E30E00", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x5E30CE0", Offset = "0x5E2FCE0", VA = "0x185E30CE0", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x5E30CB0", Offset = "0x5E2FCB0", VA = "0x185E30CB0", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x116C290", Offset = "0x116B290", VA = "0x18116C290", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x18A4EF0", Offset = "0x18A3EF0", VA = "0x1818A4EF0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x5E30CA0", Offset = "0x5E2FCA0", VA = "0x185E30CA0", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x5E30DB0", Offset = "0x5E2FDB0", VA = "0x185E30DB0", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x5E30E70", Offset = "0x5E2FE70", VA = "0x185E30E70", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x5E30EA0", Offset = "0x5E2FEA0", VA = "0x185E30EA0", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x5E30DE0", Offset = "0x5E2FDE0", VA = "0x185E30DE0", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual IARFLMREJWN? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual TIVPUTBUVWI? JWHWQWCLAJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<GOPNEBMAEKM>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000477")]
				[Cpp2IlInjected.Address(RVA = "0x5E30D10", Offset = "0x5E2FD10", VA = "0x185E30D10", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<LNVRVOESCOU> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x5E30E20", Offset = "0x5E2FE20", VA = "0x185E30E20", Slot = "68")]
				get
				{
					return default(Id128<LNVRVOESCOU>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<LNVRVOESCOU> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x5E30D80", Offset = "0x5E2FD80", VA = "0x185E30D80", Slot = "59")]
				get
				{
					return default(Id32<LNVRVOESCOU>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<LNVRVOESCOU>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<LNVRVOESCOU>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x5E2EEF0", Offset = "0x5E2DEF0", VA = "0x185E2EEF0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xAD6740", Offset = "0xAD5740", VA = "0x180AD6740", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0xAD68B0", Offset = "0xAD58B0", VA = "0x180AD68B0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xAD6ED0", Offset = "0xAD5ED0", VA = "0x180AD6ED0", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xAD6880", Offset = "0xAD5880", VA = "0x180AD6880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<GOPNEBMAEKM> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0x5E30F30", Offset = "0x5E2FF30", VA = "0x185E30F30", Slot = "69")]
				get
				{
					return default(Id32<GOPNEBMAEKM>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<GOPNEBMAEKM> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0x5E30E50", Offset = "0x5E2FE50", VA = "0x185E30E50", Slot = "70")]
				get
				{
					return default(Id128<GOPNEBMAEKM>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<GOPNEBMAEKM>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x5E30F50", Offset = "0x5E2FF50", VA = "0x185E30F50", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<MMFHTWDPFRA, DEBFPVFXDBS> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x5E31010", Offset = "0x5E30010", VA = "0x185E31010", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<MMFHTWDPFRA, DEBFPVFXDBS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<MMFHTWDPFRA>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600049E")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action QDJXWFQNPOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000458")]
				[Cpp2IlInjected.Address(RVA = "0x5E2EDB0", Offset = "0x5E2DDB0", VA = "0x185E2EDB0", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000459")]
				[Cpp2IlInjected.Address(RVA = "0x5E2F500", Offset = "0x5E2E500", VA = "0x185E2F500", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate MCOUIKBYTRH
			{
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x5E2EBA0", Offset = "0x5E2DBA0", VA = "0x185E2EBA0", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045C")]
				[Cpp2IlInjected.Address(RVA = "0x5E2EE50", Offset = "0x5E2DE50", VA = "0x185E2EE50", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate LFONTGWNRWG
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x5E2CC90", Offset = "0x5E2BC90", VA = "0x185E2CC90", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x5E2EB00", Offset = "0x5E2DB00", VA = "0x185E2EB00", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action WTUTNAIEEGK
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x5E30290", Offset = "0x5E2F290", VA = "0x185E30290", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x5E30090", Offset = "0x5E2F090", VA = "0x185E30090", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action FBRMWYTIACP
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x5E2EFF0", Offset = "0x5E2DFF0", VA = "0x185E2EFF0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x5E2FEA0", Offset = "0x5E2EEA0", VA = "0x185E2FEA0", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<MMFHTWDPFRA>, DEBFPVFXDBS> FPIFQJLPKIG
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x5E2F5A0", Offset = "0x5E2E5A0", VA = "0x185E2F5A0", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0x5E2CB10", Offset = "0x5E2BB10", VA = "0x185E2CB10", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<MMFHTWDPFRA>, DEBFPVFXDBS> NJOFSGDNSHD
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x5E2CA00", Offset = "0x5E2BA00", VA = "0x185E2CA00", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x5E2E030", Offset = "0x5E2D030", VA = "0x185E2E030", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<MMFHTWDPFRA>> JUZXBZXHEOL
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x5E2F660", Offset = "0x5E2E660", VA = "0x185E2F660", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x5E2CE70", Offset = "0x5E2BE70", VA = "0x185E2CE70", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<MMFHTWDPFRA>, Id32<MMFHTWDPFRA>> AWIAEETZHIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x5E30340", Offset = "0x5E2F340", VA = "0x185E30340", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x5E30670", Offset = "0x5E2F670", VA = "0x185E30670", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<MMFHTWDPFRA>, DEBFPVFXDBS> KSHWRBCVIBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x5E2F440", Offset = "0x5E2E440", VA = "0x185E2F440", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x5E2F720", Offset = "0x5E2E720", VA = "0x185E2F720", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<MMFHTWDPFRA>, Id32<MMFHTWDPFRA>> TVXBOSSEGLH
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x5E2F090", Offset = "0x5E2E090", VA = "0x185E2F090", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x5E305B0", Offset = "0x5E2F5B0", VA = "0x185E305B0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> VMHHNLIHSAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x5E304F0", Offset = "0x5E2F4F0", VA = "0x185E304F0", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x5E2CBD0", Offset = "0x5E2BBD0", VA = "0x185E2CBD0", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x5E307A0", Offset = "0x5E2F7A0", VA = "0x185E307A0")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected QDOMVXBDPPR(ICGXRSEYDCA a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x5E2E450", Offset = "0x5E2D450", VA = "0x185E2E450", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D3E0", Offset = "0x5E2C3E0", VA = "0x185E2D3E0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x5E30730", Offset = "0x5E2F730", VA = "0x185E30730", Slot = "9")]
			public Task<Result<None, BGYAXKJXFCB>> ZVRHIMHCZKR(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x5E30260", Offset = "0x5E2F260", VA = "0x185E30260")]
			public bool YDVWFOWOEOF([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CAC0", Offset = "0x5E2BAC0", VA = "0x185E2CAC0")]
			public bool KNKPATOJRZW([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x5E2FD00", Offset = "0x5E2ED00", VA = "0x185E2FD00", Slot = "34")]
			public void UYAEXTBYVSY(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x5E2FDA0", Offset = "0x5E2EDA0", VA = "0x185E2FDA0", Slot = "35")]
			public Task VFPECLOTNXS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x5E2FF40", Offset = "0x5E2EF40", VA = "0x185E2FF40", Slot = "36")]
			[AsyncStateMachine(typeof(QDOMVXBDPPR<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, BGYAXKJXFCB>> VRVCWRSSNGX(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "119")]
			public virtual void UNPYXWOATKQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x1164EE0", Offset = "0x1163EE0", VA = "0x181164EE0")]
			protected void GLCSBSVWSIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x23DA850", Offset = "0x23D9850", VA = "0x1823DA850")]
			protected void QFNLWSERZKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x23B8130", Offset = "0x23B7130", VA = "0x1823B8130")]
			private void JONVZMZPGMB([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x5E2F7E0", Offset = "0x5E2E7E0", VA = "0x185E2F7E0", Slot = "122")]
			public virtual Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> TSOCBKVIYBQ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EF30", Offset = "0x5E2DF30", VA = "0x185E2EF30", Slot = "123")]
			public virtual Task<Result<None, BGYAXKJXFCB>> OUOBZJVMFZX(Id32<MMFHTWDPFRA> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "124")]
			public virtual void VAXMVKQFJQN(Id32<MMFHTWDPFRA> sourceId, Id32<MMFHTWDPFRA> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CF30", Offset = "0x5E2BF30", VA = "0x185E2CF30", Slot = "125")]
			public virtual IEnumerable<AGLENQQYPWD> CYVSSQWZBVQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x5E2FCC0", Offset = "0x5E2ECC0", VA = "0x185E2FCC0", Slot = "126")]
			public Result<None, BGYAXKJXFCB> UVNNJCCSMTB(string a)
			{
				return default(Result<None, BGYAXKJXFCB>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x5E2E2A0", Offset = "0x5E2D2A0", VA = "0x185E2E2A0", Slot = "50")]
			public bool HPCCJQFEUFV([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x5E2DCF0", Offset = "0x5E2CCF0", VA = "0x185E2DCF0")]
			public bool FXXUSEIGYQY([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "128")]
			public virtual void QMRJENNVMJE(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "129")]
			public virtual VOTNSXMVXSN JAYFLLOEWFY([In] LTXRYVIQIKY audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x5E2E140", Offset = "0x5E2D140", VA = "0x185E2E140")]
			protected void HKUEQDXYGHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EEF0", Offset = "0x5E2DEF0", VA = "0x185E2EEF0", Slot = "134")]
			protected virtual bool OODRGKLIHLD(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x5E2ED80", Offset = "0x5E2DD80", VA = "0x185E2ED80", Slot = "96")]
			public bool NTHAEXHDSMX(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "135")]
			protected virtual bool PVTWKUFZUKW(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected virtual void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D040", Offset = "0x5E2C040", VA = "0x185E2D040")]
			protected void DPTQWDRKPSE(HOLPEYTCWXS a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, BGYAXKJXFCB>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x5E2F150", Offset = "0x5E2E150", VA = "0x185E2F150")]
			protected void RTKPTHKAWRA(HOLPEYTCWXS a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x5E2C6E0", Offset = "0x5E2B6E0", VA = "0x185E2C6E0", Slot = "146")]
			protected virtual void AVJXSOZTYIL(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x5E2E0F0", Offset = "0x5E2D0F0", VA = "0x185E2E0F0", Slot = "90")]
			public void HBJFJHQYLCC(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x5E2ED10", Offset = "0x5E2DD10", VA = "0x185E2ED10", Slot = "91")]
			public CircuitsRigidTransform NSSGAHFNEUH()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "149")]
			public virtual bool FBVMLLXJEJJ(Id32<MMFHTWDPFRA> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D720", Offset = "0x5E2C720", VA = "0x185E2D720")]
			private void ECGYECQTUDM([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E2DF70", Offset = "0x5E2CF70", VA = "0x185E2DF70")]
			private void GNJAQMTKIMX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x1164EE0", Offset = "0x1163EE0", VA = "0x181164EE0", Slot = "97")]
			private void PDJJLAYDSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D7A0", Offset = "0x5E2C7A0", VA = "0x185E2D7A0", Slot = "99")]
			private void FKBEVKZMGBN(Id32<MMFHTWDPFRA> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x4089A90", Offset = "0x4088A90", VA = "0x184089A90", Slot = "101")]
			private void WWDOSXJNUOQ(Id32<MMFHTWDPFRA> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CD30", Offset = "0x5E2BD30", VA = "0x185E2CD30", Slot = "103")]
			private void CRUOPRTBRSG(Id32<MMFHTWDPFRA> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x5E2E620", Offset = "0x5E2D620", VA = "0x185E2E620", Slot = "104")]
			private void JDWJQZNVXNE(Id32<MMFHTWDPFRA> sourceId, Id32<MMFHTWDPFRA> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EC60", Offset = "0x5E2DC60", VA = "0x185E2EC60", Slot = "105")]
			private void LNRIBAUQTKX(Id32<MMFHTWDPFRA> sourceId, Id32<MMFHTWDPFRA> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x21D0450", Offset = "0x21CF450", VA = "0x1821D0450", Slot = "98")]
			private void DFBXQUGDKFE(Id32<MMFHTWDPFRA> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x5E2F8A0", Offset = "0x5E2E8A0", VA = "0x185E2F8A0", Slot = "100")]
			private void USQEPSBAKSD(Id32<MMFHTWDPFRA> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CFD0", Offset = "0x5E2BFD0", VA = "0x185E2CFD0", Slot = "102")]
			private void DPAFSQESOZH(Id32<MMFHTWDPFRA> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EC40", Offset = "0x5E2DC40", VA = "0x185E2EC40", Slot = "106")]
			private void LFMYLIWZCXR(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5E2E9E0", Offset = "0x5E2D9E0", VA = "0x185E2E9E0", Slot = "150")]
			[AsyncStateMachine(typeof(QDOMVXBDPPR<>.<RequestNameChange>d__224))]
			public Task<Result<None, BGYAXKJXFCB>> JFYUEPCIWLX(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x5E2E3C0", Offset = "0x5E2D3C0", VA = "0x185E2E3C0", Slot = "57")]
			private void IRRPXXLRAKL(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EC80", Offset = "0x5E2DC80", VA = "0x185E2EC80", Slot = "58")]
			private void NOYNEYHJOOM(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x5E30260", Offset = "0x5E2F260", VA = "0x185E30260", Slot = "30")]
			private bool XVEWCKPVBMA([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CAC0", Offset = "0x5E2BAC0", VA = "0x185E2CAC0", Slot = "32")]
			private bool BNKOFYBHIEZ([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CAF0", Offset = "0x5E2BAF0", VA = "0x185E2CAF0", Slot = "51")]
			private bool BTJLSMZYVDP([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAD6740", Offset = "0xAD5740", VA = "0x180AD6740")]
			[CompilerGenerated]
			private string XUECHISTLTD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x5E300F0", Offset = "0x5E2F0F0", VA = "0x185E300F0")]
			[CompilerGenerated]
			private void XTYVKBYWCHU(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class PHGOEGHIIIS : UHOKMOSTNPX<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0xFDC590", Offset = "0xFDB590", VA = "0x180FDC590", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x2B40CA0", Offset = "0x2B3FCA0", VA = "0x182B40CA0")]
			public PHGOEGHIIIS(ICGXRSEYDCA a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class IYPPAKQDASU : QDOMVXBDPPR<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> WCIIYSSAUST;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public IYPPAKQDASU FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> QTOUKBVIVGB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> JYUXUHGRYTP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C9")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B360A0", Offset = "0x2B350A0", VA = "0x182B360A0")]
				internal int LKIYLCKNDRA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B35CC0", Offset = "0x2B34CC0", VA = "0x182B35CC0")]
				internal void LKDRNVQPUFR(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C6")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A570", Offset = "0x2B39570", VA = "0x182B3A570")]
			public IYPPAKQDASU(ICGXRSEYDCA a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A290", Offset = "0x2B39290", VA = "0x182B3A290", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class DDSDEMPYYIC : ZMRONPVQTEA<KCBSOWUROYL>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B36FE0", Offset = "0x2B35FE0", VA = "0x182B36FE0")]
			public DDSDEMPYYIC(ICGXRSEYDCA a, KCBSOWUROYL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class JGLANDIMOCE : QDOMVXBDPPR<STGFQSCMCMR>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public JGLANDIMOCE FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60004D1")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C2C0", Offset = "0x2B3B2C0", VA = "0x182B3C2C0")]
				internal bool LKOFIJEKNCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BD90", Offset = "0x2B3AD90", VA = "0x182B3BD90")]
				internal void LKIYLCKNDRA(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A7B0", Offset = "0x2B397B0", VA = "0x182B3A7B0")]
			public JGLANDIMOCE(ICGXRSEYDCA a, STGFQSCMCMR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A5E0", Offset = "0x2B395E0", VA = "0x182B3A5E0", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class NPJOQPBPJSZ : QDOMVXBDPPR<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
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
					public CWRWNJLXLSS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F3")]
					[Cpp2IlInjected.Address(RVA = "0x2B4C4C0", Offset = "0x2B4B4C0", VA = "0x182B4C4C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F4")]
					[Cpp2IlInjected.Address(RVA = "0x2B4C6F0", Offset = "0x2B4B6F0", VA = "0x182B4C6F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> HSFEGRRPLRN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public NPJOQPBPJSZ FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> UTXZSVGUUAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> GPIIBCUXWER;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D8")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0x2B36290", Offset = "0x2B35290", VA = "0x182B36290")]
				internal int LKIYLCKNDRA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0x2B35E60", Offset = "0x2B34E60", VA = "0x182B35E60")]
				internal void LKDRNVQPUFR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B35940", Offset = "0x2B34940", VA = "0x182B35940")]
				internal int LJYKQOWSKUI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B36730", Offset = "0x2B35730", VA = "0x182B36730")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> LLJGXKFZYVT(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B35490", Offset = "0x2B34490", VA = "0x182B35490")]
				internal int KXOCPZYWNAR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B35200", Offset = "0x2B34200", VA = "0x182B35200")]
				internal void DYHTYDABLJT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B351B0", Offset = "0x2B341B0", VA = "0x182B351B0")]
				internal int DYCNAWGEBYK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B35120", Offset = "0x2B34120", VA = "0x182B35120")]
				internal void DXXGDPMGSNB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B350D0", Offset = "0x2B340D0", VA = "0x182B350D0")]
				internal int DXRZGISJJBS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B35370", Offset = "0x2B34370", VA = "0x182B35370")]
				internal void DZCVNEBQXDD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B35320", Offset = "0x2B34320", VA = "0x182B35320")]
				internal int DYXOPXHTNRU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B35290", Offset = "0x2B34290", VA = "0x182B35290")]
				internal void DYSHSQNWEGL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B366E0", Offset = "0x2B356E0", VA = "0x182B366E0")]
				internal float LLEAADMCPKK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B36650", Offset = "0x2B35650", VA = "0x182B36650")]
				internal void LKYTCWSFFZB(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B36600", Offset = "0x2B35600", VA = "0x182B36600")]
				internal float LKTMFPYHWNS()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B358B0", Offset = "0x2B348B0", VA = "0x182B358B0")]
				internal void LIYCEHBFPPP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B35860", Offset = "0x2B34860", VA = "0x182B35860")]
				internal bool LISVHAHIGEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B35780", Offset = "0x2B34780", VA = "0x182B35780")]
				internal void KYYYWVIEBCC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2B35810", Offset = "0x2B34810", VA = "0x182B35810")]
				internal int KZEFUCCBKNL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B356A0", Offset = "0x2B346A0", VA = "0x182B356A0")]
				internal void KYOLCHUJIFK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2B35730", Offset = "0x2B34730", VA = "0x182B35730")]
				internal float KYTRZOOGRQT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2B355C0", Offset = "0x2B345C0", VA = "0x182B355C0")]
				internal void KYDXHUGOPIS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2B35650", Offset = "0x2B34650", VA = "0x182B35650")]
				internal float KYJEFBALYUB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B354E0", Offset = "0x2B344E0", VA = "0x182B354E0")]
				internal void KXTJNGSTWMA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B35570", Offset = "0x2B34570", VA = "0x182B35570")]
				internal bool KXYQKNMRFXJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B35400", Offset = "0x2B34400", VA = "0x182B35400")]
				internal void KXIVSTEZDPI(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x2B407F0", Offset = "0x2B3F7F0", VA = "0x182B407F0")]
			public NPJOQPBPJSZ(ICGXRSEYDCA a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F6F0", Offset = "0x2B3E6F0", VA = "0x182B3F6F0", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class LQXQWREAEKY : XQJSZXCPIPV<RecNetImageNode>
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
				public LQXQWREAEKY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004F9")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BCF0", Offset = "0x2B4ACF0", VA = "0x182B4BCF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FA")]
				[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D650", Offset = "0x2B3C650", VA = "0x182B3D650")]
			public LQXQWREAEKY(ICGXRSEYDCA a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D320", Offset = "0x2B3C320", VA = "0x182B3D320", Slot = "151")]
			protected override void GCYUHCMHKPK(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D180", Offset = "0x2B3C180", VA = "0x182B3D180")]
			[CompilerGenerated]
			private string? CRNCLDTGHXW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D250", Offset = "0x2B3C250", VA = "0x182B3D250")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void CRSJIKNDRJF(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class OVERGDUXOHG<a> : QDOMVXBDPPR<a> where a : notnull, KTWQKNSBUKU
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class DABAUKZQTLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> HSFEGRRPLRN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public OVERGDUXOHG<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> UTXZSVGUUAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> GPIIBCUXWER;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType WKMGHYBZYTB;

				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public DABAUKZQTLC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LKOFIJEKNCJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0x4438C50", Offset = "0x4437C50", VA = "0x184438C50")]
				internal int LKIYLCKNDRA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0x4438A60", Offset = "0x4437A60", VA = "0x184438A60")]
				internal void LKDRNVQPUFR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x4438A10", Offset = "0x4437A10", VA = "0x184438A10")]
				internal void LJYKQOWSKUI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x4438E20", Offset = "0x4437E20", VA = "0x184438E20")]
				internal void LLJGXKFZYVT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x4438D70", Offset = "0x4437D70", VA = "0x184438D70")]
				internal bool LLEAADMCPKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x4438DD0", Offset = "0x4437DD0", VA = "0x184438DD0")]
				internal void LKYTCWSFFZB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x4438D70", Offset = "0x4437D70", VA = "0x184438D70")]
				internal bool LKTMFPYHWNS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x44389E0", Offset = "0x44379E0", VA = "0x1844389E0")]
				internal float LIYCEHBFPPP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x4438950", Offset = "0x4437950", VA = "0x184438950")]
				internal void LISVHAHIGEG(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x4438890", Offset = "0x4437890", VA = "0x184438890")]
				internal float KYYYWVIEBCC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x44388C0", Offset = "0x44378C0", VA = "0x1844388C0")]
				internal void KZEFUCCBKNL(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x44387D0", Offset = "0x44377D0", VA = "0x1844387D0")]
				internal float KYOLCHUJIFK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x4438800", Offset = "0x4437800", VA = "0x184438800")]
				internal void KYTRZOOGRQT(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType WTNUCHXCMID
			{
				[Cpp2IlInjected.Token(Token = "0x60004FD")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x5350160", Offset = "0x534F160", VA = "0x185350160")]
			public OVERGDUXOHG(ICGXRSEYDCA a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x5CD3690", Offset = "0x5CD2690", VA = "0x185CD3690", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class BFEEJGFWSMQ : QDOMVXBDPPR<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0xFDEBB0", Offset = "0xFDDBB0", VA = "0x180FDEBB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x2B34490", Offset = "0x2B33490", VA = "0x182B34490")]
			public BFEEJGFWSMQ(ICGXRSEYDCA a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class KLQGTZXWTKV : JCREUSVPEHL<EKSOSPPXLZJ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x2B3ACB0", Offset = "0x2B39CB0", VA = "0x182B3ACB0")]
			public KLQGTZXWTKV(ICGXRSEYDCA a, EKSOSPPXLZJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class WZIZHNZAYSF : JCREUSVPEHL<UNBZMJXHLKW>
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DBC0", Offset = "0x2B4CBC0", VA = "0x182B4DBC0")]
			public WZIZHNZAYSF(ICGXRSEYDCA a, UNBZMJXHLKW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class JCREUSVPEHL<a> : QDOMVXBDPPR<a> where a : notnull, KFZNZLSJXHF
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
				public JCREUSVPEHL<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051A")]
				[Cpp2IlInjected.Address(RVA = "0x401D670", Offset = "0x401C670", VA = "0x18401D670", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051B")]
				[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class XTKJJUTWICP
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
					public XTKJJUTWICP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052B")]
					[Cpp2IlInjected.Address(RVA = "0x401C340", Offset = "0x401B340", VA = "0x18401C340", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052C")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public XTKJJUTWICP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x401C720", Offset = "0x401B720", VA = "0x18401C720", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public XTKJJUTWICP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x401CDE0", Offset = "0x401BDE0", VA = "0x18401CDE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public XTKJJUTWICP <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x401D380", Offset = "0x401C380", VA = "0x18401D380", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int KFKEAEYJQEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry CVFPWFSJOEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public JCREUSVPEHL<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<WQEPJKQGFSY, bool> KKBNUABGEWQ;

				[Cpp2IlInjected.Token(Token = "0x6000520")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XTKJJUTWICP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000521")]
				[Cpp2IlInjected.Address(RVA = "0x418D9D0", Offset = "0x418C9D0", VA = "0x18418D9D0")]
				internal bool LJYKQOWSKUI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0x418DC00", Offset = "0x418CC00", VA = "0x18418DC00")]
				internal void LLJGXKFZYVT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				internal string LLEAADMCPKK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x418DB40", Offset = "0x418CB40", VA = "0x18418DB40")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.XTKJJUTWICP.<<BuildConfigMenuInternal>b__6>d))]
				internal void LKYTCWSFFZB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0x418DA30", Offset = "0x418CA30", VA = "0x18418DA30")]
				internal int LKTMFPYHWNS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x418D840", Offset = "0x418C840", VA = "0x18418D840")]
				internal bool KYTRZOOGRQT(WQEPJKQGFSY a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x418D920", Offset = "0x418C920", VA = "0x18418D920")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.XTKJJUTWICP.<<BuildConfigMenuInternal>b__8>d))]
				internal void LIYCEHBFPPP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
				internal string KYYYWVIEBCC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x418D860", Offset = "0x418C860", VA = "0x18418D860")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.XTKJJUTWICP.<<BuildConfigMenuInternal>b__11>d))]
				internal void KZEFUCCBKNL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0x418D7A0", Offset = "0x418C7A0", VA = "0x18418D7A0")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.XTKJJUTWICP.<<BuildConfigMenuInternal>b__12>d))]
				internal void KYOLCHUJIFK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class SCYSNCSTSXC
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000563")]
					[Cpp2IlInjected.Address(RVA = "0x4016630", Offset = "0x4015630", VA = "0x184016630", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000564")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x40169C0", Offset = "0x40159C0", VA = "0x1840169C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x4016D90", Offset = "0x4015D90", VA = "0x184016D90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x4017370", Offset = "0x4016370", VA = "0x184017370", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x4017600", Offset = "0x4016600", VA = "0x184017600", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x4017990", Offset = "0x4016990", VA = "0x184017990", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x4017D20", Offset = "0x4016D20", VA = "0x184017D20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x4017FB0", Offset = "0x4016FB0", VA = "0x184017FB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x4018340", Offset = "0x4017340", VA = "0x184018340", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x40186D0", Offset = "0x40176D0", VA = "0x1840186D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x4018A60", Offset = "0x4017A60", VA = "0x184018A60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x4018CF0", Offset = "0x4017CF0", VA = "0x184018CF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x4019080", Offset = "0x4018080", VA = "0x184019080", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x4019310", Offset = "0x4018310", VA = "0x184019310", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x40196A0", Offset = "0x40186A0", VA = "0x1840196A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x4019A30", Offset = "0x4018A30", VA = "0x184019A30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
					public SCYSNCSTSXC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x4019DC0", Offset = "0x4018DC0", VA = "0x184019DC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public JCREUSVPEHL<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int KFKEAEYJQEH;

				[Cpp2IlInjected.Token(Token = "0x6000533")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public SCYSNCSTSXC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000534")]
				[Cpp2IlInjected.Address(RVA = "0x618AF10", Offset = "0x6189F10", VA = "0x18618AF10")]
				internal bool LFBLMBXNRAN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0x618AEA0", Offset = "0x6189EA0", VA = "0x18618AEA0")]
				internal void LEWEOVDQHPE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x618A8B0", Offset = "0x61898B0", VA = "0x18618A8B0")]
				internal object JYGEFUKCOCQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x618A950", Offset = "0x6189950", VA = "0x18618A950")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__13>d))]
				internal void JYLLDBDZXNZ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x618A750", Offset = "0x6189750", VA = "0x18618A750")]
				internal string JXVQLGWHVFY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x618A7F0", Offset = "0x61897F0", VA = "0x18618A7F0")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__15>d))]
				internal void JYAXINQFERH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x618A640", Offset = "0x6189640", VA = "0x18618A640")]
				internal bool JXLCQTINCJG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x618A6C0", Offset = "0x61896C0", VA = "0x18618A6C0")]
				internal bool JXQJOACKLUP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x618AB50", Offset = "0x6189B50", VA = "0x18618AB50")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__18>d))]
				internal void KAGVEKBCEMC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x618AC00", Offset = "0x6189C00", VA = "0x18618AC00")]
				internal int KAMCBQUZNXL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x618A1F0", Offset = "0x61891F0", VA = "0x18618A1F0")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__20>d))]
				internal void CXZNBPPURGZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x618A160", Offset = "0x6189160", VA = "0x18618A160")]
				internal bool CXUGEIVXHVQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x618A0B0", Offset = "0x61890B0", VA = "0x18618A0B0")]
				internal float CXOZHCBZYKH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x6189FF0", Offset = "0x6188FF0", VA = "0x186189FF0")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__23>d))]
				internal void CXJSJVICOYY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x618A470", Offset = "0x6189470", VA = "0x18618A470")]
				internal bool CYUOQQRKDAJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x618A3E0", Offset = "0x61893E0", VA = "0x18618A3E0")]
				internal bool CYPHTJXMTPA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x618A330", Offset = "0x6189330", VA = "0x18618A330")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__26>d))]
				internal void CYKAWDDPKDR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x618A2A0", Offset = "0x61892A0", VA = "0x18618A2A0")]
				internal int CYETYWJSASI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x618A590", Offset = "0x6189590", VA = "0x18618A590")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__28>d))]
				internal void CZPQFRSZOTT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x618A500", Offset = "0x6189500", VA = "0x18618A500")]
				internal bool CZKJIKZCFIK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x618B750", Offset = "0x618A750", VA = "0x18618B750")]
				internal float VXIICXHSBOQ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x618B7E0", Offset = "0x618A7E0", VA = "0x18618B7E0")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__31>d))]
				internal void VXNPAEBPKZZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x618B8A0", Offset = "0x618A8A0", VA = "0x18618B8A0")]
				internal bool VXSVXKVMULI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x618B930", Offset = "0x618A930", VA = "0x18618B930")]
				internal bool VXYCURPKDWR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x618B9B0", Offset = "0x618A9B0", VA = "0x18618B9B0")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__34>d))]
				internal void VYDJRYJHNIA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x618BA60", Offset = "0x618AA60", VA = "0x18618BA60")]
				internal bool VYIQPFDEWTJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x618BAF0", Offset = "0x618AAF0", VA = "0x18618BAF0")]
				internal bool VYNXMLXCGES()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x618BB80", Offset = "0x618AB80", VA = "0x18618BB80")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__37>d))]
				internal void VYTEJSQZPQB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x618BC30", Offset = "0x618AC30", VA = "0x18618BC30")]
				internal int VYYLGZKWZBK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x618BCC0", Offset = "0x618ACC0", VA = "0x18618BCC0")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__39>d))]
				internal void VZDSEGEUIMT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x618B570", Offset = "0x618A570", VA = "0x18618B570")]
				internal bool RVOFQFAQFRR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x618B4E0", Offset = "0x618A4E0", VA = "0x18618B4E0")]
				internal float RVIYSYGSWGI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x618B690", Offset = "0x618A690", VA = "0x18618B690")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__42>d))]
				internal void RVYTKSOKYOJ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x618B600", Offset = "0x618A600", VA = "0x18618B600")]
				internal bool RVTMNLUNPDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x618B3D0", Offset = "0x618A3D0", VA = "0x18618B3D0")]
				internal bool RUTEBDZATYH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x618B320", Offset = "0x618A320", VA = "0x18618B320")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__45>d))]
				internal void RUNXDXFDKMY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x618B450", Offset = "0x618A450", VA = "0x18618B450")]
				internal bool RVDRVRMVMUZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x618AE10", Offset = "0x6189E10", VA = "0x18618AE10")]
				internal bool LEQXROJSYDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x618AD60", Offset = "0x6189D60", VA = "0x18618AD60")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__3>d))]
				internal void LELQUHPVOSM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x618B140", Offset = "0x618A140", VA = "0x18618B140")]
				internal int LFWNBCZDCTX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x618B090", Offset = "0x618A090", VA = "0x18618B090")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__5>d))]
				internal void LFRGDWFFTIO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x618B000", Offset = "0x618A000", VA = "0x18618B000")]
				internal bool LFLZGPLIJXF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x618AF70", Offset = "0x6189F70", VA = "0x18618AF70")]
				internal bool LFGSJIRLALW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x618B270", Offset = "0x618A270", VA = "0x18618B270")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__8>d))]
				internal void LGROQEASONH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x618B1D0", Offset = "0x618A1D0", VA = "0x18618B1D0")]
				internal int LGMHSXGVFBY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x618AA10", Offset = "0x6189A10", VA = "0x18618AA10")]
				[AsyncStateMachine(typeof(JCREUSVPEHL<>.SCYSNCSTSXC.<<AddConstraintOptions>b__10>d))]
				internal void JYQSAHXXGZI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x618AAC0", Offset = "0x6189AC0", VA = "0x18618AAC0")]
				internal bool JYVYXORUQKR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> IBUPNIJEOPX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> UABIKXEAXZW;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000514")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<WQEPJKQGFSY> SYYFBHESBBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000515")]
				[Cpp2IlInjected.Address(RVA = "0x540BC10", Offset = "0x540AC10", VA = "0x18540BC10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x540CE00", Offset = "0x540BE00", VA = "0x18540CE00")]
			public JCREUSVPEHL(ICGXRSEYDCA a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x540A400", Offset = "0x5409400", VA = "0x18540A400", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x540BD70", Offset = "0x540AD70", VA = "0x18540BD70", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x540A4B0", Offset = "0x54094B0", VA = "0x18540A4B0")]
			private LXZKKHCQIOC JCAZLITOYPF(HOLPEYTCWXS a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x540BCC0", Offset = "0x540ACC0", VA = "0x18540BCC0")]
			[AsyncStateMachine(typeof(JCREUSVPEHL<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void RXQFPTKWKRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x540BC60", Offset = "0x540AC60", VA = "0x18540BC60")]
			[CompilerGenerated]
			private bool RXAKXZDEIJW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class VUOGUKNOKAL : QDOMVXBDPPR<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class XDIBTWVITXT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public VUOGUKNOKAL FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x600058A")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public XDIBTWVITXT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E9B0", Offset = "0x2B4D9B0", VA = "0x182B4E9B0")]
				internal int LKIYLCKNDRA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E830", Offset = "0x2B4D830", VA = "0x182B4E830")]
				internal void LKDRNVQPUFR(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? EVGGXTTBQBE;

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D980", Offset = "0x2B4C980", VA = "0x182B4D980")]
			public VUOGUKNOKAL(ICGXRSEYDCA a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D620", Offset = "0x2B4C620", VA = "0x182B4D620", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class NFGSPPJBRZH : OVERGDUXOHG<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType WTNUCHXCMID
			{
				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F690", Offset = "0x2B3E690", VA = "0x182B3F690")]
			public NFGSPPJBRZH(ICGXRSEYDCA a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class HZQZMDNEHNU : ZMRONPVQTEA<SMXBEUGBBMH>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x2B39EF0", Offset = "0x2B38EF0", VA = "0x182B39EF0")]
			public HZQZMDNEHNU(ICGXRSEYDCA a, SMXBEUGBBMH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class UZADNHNBZXL : ZMRONPVQTEA<KUXIEOFOUSK>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000592")]
				[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D5C0", Offset = "0x2B4C5C0", VA = "0x182B4D5C0")]
			public UZADNHNBZXL(ICGXRSEYDCA a, KUXIEOFOUSK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class XYSJLMXJKTB : XQJSZXCPIPV<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
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
					public LCEQAKIHZSA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000599")]
					[Cpp2IlInjected.Address(RVA = "0x2B4B9E0", Offset = "0x2B4A9E0", VA = "0x182B4B9E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059A")]
					[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public XYSJLMXJKTB FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x6000597")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000598")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C870", Offset = "0x2B3B870", VA = "0x182B3C870")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void VTFNHPOCUGY(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EEA0", Offset = "0x2B4DEA0", VA = "0x182B4EEA0")]
			public XYSJLMXJKTB(ICGXRSEYDCA a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EBA0", Offset = "0x2B4DBA0", VA = "0x182B4EBA0", Slot = "151")]
			protected override void GCYUHCMHKPK(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class XZUOTINXKRY : OVERGDUXOHG<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType WTNUCHXCMID
			{
				[Cpp2IlInjected.Token(Token = "0x600059C")]
				[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF70A0", VA = "0x180DF80A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EF00", Offset = "0x2B4DF00", VA = "0x182B4EF00")]
			public XZUOTINXKRY(ICGXRSEYDCA a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class CGWHAFQFGZF : QDOMVXBDPPR<NCTIXHBDIQB>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0xFF23D0", Offset = "0xFF13D0", VA = "0x180FF23D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x2B35060", Offset = "0x2B34060", VA = "0x182B35060")]
			public CGWHAFQFGZF(ICGXRSEYDCA a, NCTIXHBDIQB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class KBEKBXQNWJM : QDOMVXBDPPR<YFNVWVNEYPZ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A0")]
				[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A1")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool RZYDYTCLEQT
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AC40", Offset = "0x2B39C40", VA = "0x182B3AC40")]
			public KBEKBXQNWJM(ICGXRSEYDCA a, YFNVWVNEYPZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A8F0", Offset = "0x2B398F0", VA = "0x182B3A8F0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AC00", Offset = "0x2B39C00", VA = "0x182B3AC00")]
			private int ZSTDGFLWAWA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A880", Offset = "0x2B39880", VA = "0x182B3A880")]
			private void NQCHOYHQSIA(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class LSZRLSDITAV : IKMQPHZEFVS
		{
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B39F50", Offset = "0x2B38F50", VA = "0x182B39F50")]
			public LSZRLSDITAV(ICGXRSEYDCA a, MOXNPQACASF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class NSTTHFJXSQX : QDOMVXBDPPR<PWBEGTWPKUY>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public NSTTHFJXSQX FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AD")]
				[Cpp2IlInjected.Address(RVA = "0x2B363B0", Offset = "0x2B353B0", VA = "0x182B363B0")]
				internal int LKOFIJEKNCJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B36000", Offset = "0x2B35000", VA = "0x182B36000")]
				internal void LKIYLCKNDRA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B35B40", Offset = "0x2B34B40", VA = "0x182B35B40")]
				internal int LKDRNVQPUFR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B35990", Offset = "0x2B34990", VA = "0x182B35990")]
				internal void LJYKQOWSKUI(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AA")]
				[Cpp2IlInjected.Address(RVA = "0x138C8F0", Offset = "0x138B8F0", VA = "0x18138C8F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B40B70", Offset = "0x2B3FB70", VA = "0x182B40B70")]
			public NSTTHFJXSQX(ICGXRSEYDCA a, PWBEGTWPKUY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B40860", Offset = "0x2B3F860", VA = "0x182B40860", Slot = "145")]
			protected sealed override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class YQCBEAGNOBW : XQJSZXCPIPV<YZIUSBWCMYB>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F6D0", Offset = "0x2B4E6D0", VA = "0x182B4F6D0")]
			public YQCBEAGNOBW(ICGXRSEYDCA a, YZIUSBWCMYB b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class XQJSZXCPIPV<a> : QDOMVXBDPPR<a> where a : notnull, YZIUSBWCMYB
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class HTMXAPREZJT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public XQJSZXCPIPV<a> FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.Token(Token = "0x60005B9")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public HTMXAPREZJT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x5271550", Offset = "0x5270550", VA = "0x185271550")]
				internal bool LKOFIJEKNCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0x52714C0", Offset = "0x52704C0", VA = "0x1852714C0")]
				internal void LKIYLCKNDRA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x5271490", Offset = "0x5270490", VA = "0x185271490")]
				internal bool LKDRNVQPUFR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x5271400", Offset = "0x5270400", VA = "0x185271400")]
				internal void LJYKQOWSKUI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x5271580", Offset = "0x5270580", VA = "0x185271580")]
				internal bool LLJGXKFZYVT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class BWOTNPDIUFE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public RRPMJEEQJEK ZSYTMZROVUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public XQJSZXCPIPV<a> FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public BWOTNPDIUFE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x40606C0", Offset = "0x405F6C0", VA = "0x1840606C0")]
				internal void VTFNHPOCUGY(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0xE2AC50", Offset = "0xE29C50", VA = "0x180E2AC50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x4189070", Offset = "0x4188070", VA = "0x184189070", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x4188F60", Offset = "0x4187F60", VA = "0x184188F60")]
			protected XQJSZXCPIPV(ICGXRSEYDCA a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x4188810", Offset = "0x4187810", VA = "0x184188810", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x4188BE0", Offset = "0x4187BE0", VA = "0x184188BE0", Slot = "145")]
			protected override void VFSCTJGHBKP(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x4188910", Offset = "0x4187910", VA = "0x184188910", Slot = "151")]
			protected virtual void GCYUHCMHKPK(HOLPEYTCWXS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x4188BA0", Offset = "0x4187BA0", VA = "0x184188BA0", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B11D50", Offset = "0x2B10D50", VA = "0x182B11D50")]
		public static VBGMMRXSCJI New(ICGXRSEYDCA circuitsManager, MOXNPQACASF node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class KQHNHFUQMNU : NEMTJOIPTHW, BVCKRSDOJRJ, JVEKMJHPKAZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<GVZPIOKFAXL> TCREOZCYUQB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xFD7160", Offset = "0xFD6160", VA = "0x180FD7160", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GVZPIOKFAXL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<XCMFJIKKBWV> JTXGRLVTPKI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F237B0", Offset = "0x1F227B0", VA = "0x181F237B0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<XCMFJIKKBWV>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x262F8F0", Offset = "0x262E8F0", VA = "0x18262F8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<EBKDWIFBKMY> CAOEJYYQKOO
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x1501BA0", Offset = "0x1500BA0", VA = "0x181501BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<PRDNNESEALZ> LMUPEKJJOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B060", Offset = "0x2B3A060", VA = "0x182B3B060", Slot = "22")]
			get
			{
				return default(Id32<PRDNNESEALZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B0B0", Offset = "0x2B3A0B0", VA = "0x182B3B0B0")]
		private KQHNHFUQMNU(ICGXRSEYDCA a, MOXNPQACASF b, RLBSMOILGHN c, Id32<MMFHTWDPFRA> portGroupId, Id32<XCMFJIKKBWV> outputId, Id32<EBKDWIFBKMY> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AD10", Offset = "0x2B39D10", VA = "0x182B3AD10")]
		public static KQHNHFUQMNU New(ICGXRSEYDCA circuitsManager, MOXNPQACASF node, RLBSMOILGHN output, Id32<MMFHTWDPFRA> portGroupId, Id32<EBKDWIFBKMY> outputDefId, Id32<XCMFJIKKBWV> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x262F8F0", Offset = "0x262E8F0", VA = "0x18262F8F0")]
		internal void WQZLDHUFATM(Id32<XCMFJIKKBWV> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class NEMTJOIPTHW : JVEKMJHPKAZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private YXKFHPMFNGA? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D6B0", Offset = "0x2B3C6B0", VA = "0x182B3D6B0")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D6C0", Offset = "0x2B3C6C0", VA = "0x182B3D6C0")]
			public YXKFHPMFNGA XPHUUKFPQRQ(NEMTJOIPTHW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly MOXNPQACASF RVQVWCRTSBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter GBVYSVNCGVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly DOAACCJBNGX XINPCTOBMSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<UMGILOLQSSB> GAVRTPKWZJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<PUKGFTNAJSX> ARLZQXMUUAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool ESLVKRBONTI;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> AGIJLXXDEJI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E6C0", Offset = "0x2B3D6C0", VA = "0x182B3E6C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind CXYQGRJKSYP
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xAEC5F0", Offset = "0xAEB5F0", VA = "0x180AEC5F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<LNVRVOESCOU> JTPZIJBCVOO
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EFF0", Offset = "0x2B3DFF0", VA = "0x182B3EFF0", Slot = "6")]
			get
			{
				return default(Id32<LNVRVOESCOU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<LNVRVOESCOU> NSEERVUCLUD
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E800", Offset = "0x2B3D800", VA = "0x182B3E800", Slot = "7")]
			get
			{
				return default(Id128<LNVRVOESCOU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public WQEPJKQGFSY OPOAJVXBHKV
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EA00", Offset = "0x2B3DA00", VA = "0x182B3EA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public ZDEDFBVKWCC IQBDOEYDPQW
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E830", Offset = "0x2B3D830", VA = "0x182B3E830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected YXKFHPMFNGA XTTTHKDBNUF
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E830", Offset = "0x2B3D830", VA = "0x182B3E830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage LPZNCQKGUGL
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EEB0", Offset = "0x2B3DEB0", VA = "0x182B3EEB0", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xAD6760", Offset = "0xAD5760", VA = "0x180AD6760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<GOPNEBMAEKM> TDTYZSLMBOT
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DD10", Offset = "0x2B3CD10", VA = "0x182B3DD10", Slot = "9")]
			get
			{
				return default(Id128<GOPNEBMAEKM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<MMFHTWDPFRA> SCTCPKLFUNW
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xF8B490", Offset = "0xF8A490", VA = "0x180F8B490", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<MMFHTWDPFRA>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x1B42120", Offset = "0x1B41120", VA = "0x181B42120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<PRDNNESEALZ> LMUPEKJJOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool CIZXXJSBJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1029800", Offset = "0x1028800", VA = "0x181029800", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F540", Offset = "0x2B3E540", VA = "0x182B3F540")]
		protected NEMTJOIPTHW(ICGXRSEYDCA a, MOXNPQACASF b, DOAACCJBNGX c, Id32<MMFHTWDPFRA> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E8C0", Offset = "0x2B3D8C0", VA = "0x182B3E8C0", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E580", Offset = "0x2B3D580", VA = "0x182B3E580", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EAD0", Offset = "0x2B3DAD0", VA = "0x182B3EAD0", Slot = "14")]
		public void OSMNKISRBKY(UMGILOLQSSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EA20", Offset = "0x2B3DA20", VA = "0x182B3EA20", Slot = "15")]
		public void OHRDNHTGYSG(PUKGFTNAJSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F080", Offset = "0x2B3E080", VA = "0x182B3F080")]
		private bool XFQHOSULUJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DD30", Offset = "0x2B3CD30", VA = "0x182B3DD30", Slot = "17")]
		public void COLSSRWKINE(GORIDUXUYDV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E9A0", Offset = "0x2B3D9A0", VA = "0x182B3E9A0", Slot = "25")]
		protected virtual void MMLOBVDUMQE(GORIDUXUYDV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ED30", Offset = "0x2B3DD30", VA = "0x182B3ED30", Slot = "20")]
		private void SQRTESIQZUL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EB80", Offset = "0x2B3DB80", VA = "0x182B3EB80")]
		private void QCPNGCDRBUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F3A0", Offset = "0x2B3E3A0", VA = "0x182B3F3A0")]
		private void ZVTKXZBMBVC([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F020", Offset = "0x2B3E020", VA = "0x182B3F020", Slot = "18")]
		public void UNIZJGUXHTD(UMGILOLQSSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E660", Offset = "0x2B3D660", VA = "0x182B3E660", Slot = "19")]
		public void EBKQJYUGBCP(PUKGFTNAJSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xAD6760", Offset = "0xAD5760", VA = "0x180AD6760")]
		internal void AEPWUGRJAUE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DCF0", Offset = "0x2B3CCF0", VA = "0x182B3DCF0")]
		internal void AHZEXBBJWEH(ZZZJGZASNDB a, WQEPJKQGFSY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x1B42120", Offset = "0x1B41120", VA = "0x181B42120")]
		internal void FTJRAWPTSNM(Id32<MMFHTWDPFRA> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class RYJYHFMMMVN : DEBFPVFXDBS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class GYAMUFPWSJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public ICGXRSEYDCA XVYQYEGQVLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public MOXNPQACASF TOZOHSYJFSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<MMFHTWDPFRA> TMTSGGYALTW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool MHCAHXSBWCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool UCTVWEULKWU;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public GYAMUFPWSJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x2B39E10", Offset = "0x2B38E10", VA = "0x182B39E10")]
			internal BRRUMOBBIOF SOLGHUQBTCT((int PortDescIndex, int PortIndex, PQGAYRMHEQI InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x2B39D40", Offset = "0x2B38D40", VA = "0x182B39D40")]
			internal KQHNHFUQMNU SOFZKNWEJRK(RLBSMOILGHN a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2B47290", Offset = "0x2B46290", VA = "0x182B47290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2B47700", Offset = "0x2B46700", VA = "0x182B47700", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<VKOSYOKYXNB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2B489B0", Offset = "0x2B479B0", VA = "0x182B489B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2B48D00", Offset = "0x2B47D00", VA = "0x182B48D00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2B48D70", Offset = "0x2B47D70", VA = "0x182B48D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2B491F0", Offset = "0x2B481F0", VA = "0x182B491F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<EBKDWIFBKMY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2B49260", Offset = "0x2B48260", VA = "0x182B49260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2B495B0", Offset = "0x2B485B0", VA = "0x182B495B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2B49DE0", Offset = "0x2B48DE0", VA = "0x182B49DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A130", Offset = "0x2B49130", VA = "0x182B4A130", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<VKOSYOKYXNB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2B49620", Offset = "0x2B48620", VA = "0x182B49620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2B49990", Offset = "0x2B48990", VA = "0x182B49990", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<EBKDWIFBKMY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2B49A00", Offset = "0x2B48A00", VA = "0x182B49A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2B49D70", Offset = "0x2B48D70", VA = "0x182B49D70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public MMEEXWRZTBL type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<VKOSYOKYXNB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A1A0", Offset = "0x2B491A0", VA = "0x182B4A1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A540", Offset = "0x2B49540", VA = "0x182B4A540", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public MMEEXWRZTBL type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<EBKDWIFBKMY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A5B0", Offset = "0x2B495B0", VA = "0x182B4A5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A950", Offset = "0x2B49950", VA = "0x182B4A950", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<VKOSYOKYXNB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<VKOSYOKYXNB> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A9C0", Offset = "0x2B499C0", VA = "0x182B4A9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4AD20", Offset = "0x2B49D20", VA = "0x182B4AD20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public RYJYHFMMMVN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<EBKDWIFBKMY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<EBKDWIFBKMY> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private DUQMTWSATKX <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4AD90", Offset = "0x2B49D90", VA = "0x182B4AD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B0F0", Offset = "0x2B4A0F0", VA = "0x182B4B0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool OJIBATMOUWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool SSJIFLETRZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<JVDRBUQTLFY, BRRUMOBBIOF> EKWRPUQZXDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<JVDRBUQTLFY, RAUCSROXRTI> FCMVLTCVRSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly MOXNPQACASF RVQVWCRTSBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<XCMFJIKKBWV, KQHNHFUQMNU> ESKESNZNKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<XCMFJIKKBWV, BVCKRSDOJRJ> KUEOORNHBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? WJYMBYCDZDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly IEIHZQZXXRC EBMYCUIREMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<MMFHTWDPFRA> CGGIICQQZKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool EUNFGDTNHTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? LDHSJIAQIQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? YNBDNTKEITY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<JVDRBUQTLFY>>? GRLXXEFANWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<XCMFJIKKBWV>>? LNUKVLXOKWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private DEBFPVFXDBS.PortGroupIdChangeDelegate? ZIFSETNRZRT;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool HLFLWKCQTDD
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B42610", Offset = "0x2B41610", VA = "0x182B42610", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool XTBWGJKIDEW
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x2B40FB0", Offset = "0x2B3FFB0", VA = "0x182B40FB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool CAWDLUHIEBS
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B45FC0", Offset = "0x2B44FC0", VA = "0x182B45FC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<LNVRVOESCOU> NSEERVUCLUD
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B426D0", Offset = "0x2B416D0", VA = "0x182B426D0", Slot = "7")]
			get
			{
				return default(Id128<LNVRVOESCOU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool IKMIHOLPGPY
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B44070", Offset = "0x2B43070", VA = "0x182B44070", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<JVDRBUQTLFY, RAUCSROXRTI> VOVOXYIDXVW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<JVDRBUQTLFY, RAUCSROXRTI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B45F90", Offset = "0x2B44F90", VA = "0x182B45F90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<GOPNEBMAEKM> TDTYZSLMBOT
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B41270", Offset = "0x2B40270", VA = "0x182B41270", Slot = "11")]
			get
			{
				return default(Id128<GOPNEBMAEKM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<XCMFJIKKBWV, BVCKRSDOJRJ> FCKVJIZCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<XCMFJIKKBWV, BVCKRSDOJRJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<MMFHTWDPFRA> SCTCPKLFUNW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xC850D0", Offset = "0xC840D0", VA = "0x180C850D0", Slot = "13")]
			get
			{
				return default(Id32<MMFHTWDPFRA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? QBAZXGKMMHM
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B432E0", Offset = "0x2B422E0", VA = "0x182B432E0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B44910", Offset = "0x2B43910", VA = "0x182B44910", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? JMQLXPRIVVL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B41F10", Offset = "0x2B40F10", VA = "0x182B41F10", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B45740", Offset = "0x2B44740", VA = "0x182B45740", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<JVDRBUQTLFY?>, Id32<JVDRBUQTLFY?>>? CYTZXNQZVMS
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B446A0", Offset = "0x2B436A0", VA = "0x182B446A0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B44CB0", Offset = "0x2B43CB0", VA = "0x182B44CB0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<JVDRBUQTLFY?>, Id32<JVDRBUQTLFY?>>? XXCXYUBRDZF
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B41900", Offset = "0x2B40900", VA = "0x182B41900", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B42DD0", Offset = "0x2B41DD0", VA = "0x182B42DD0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<XCMFJIKKBWV?>, Id32<XCMFJIKKBWV?>>? ORRBJVQUUVP
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B42F50", Offset = "0x2B41F50", VA = "0x182B42F50", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2B42D10", Offset = "0x2B41D10", VA = "0x182B42D10", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<XCMFJIKKBWV?>, Id32<XCMFJIKKBWV?>>? HFWHIAVOHWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2B449B0", Offset = "0x2B439B0", VA = "0x182B449B0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2B45DF0", Offset = "0x2B44DF0", VA = "0x182B45DF0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<JVDRBUQTLFY?>, RAUCSROXRTI?>? BDHVIOUSYNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2B41D40", Offset = "0x2B40D40", VA = "0x182B41D40", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2B41290", Offset = "0x2B40290", VA = "0x182B41290", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<JVDRBUQTLFY?>>? LQLHSPFDZFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2B43160", Offset = "0x2B42160", VA = "0x182B43160", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2B40FF0", Offset = "0x2B3FFF0", VA = "0x182B40FF0", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<JVDRBUQTLFY?>, RAUCSROXRTI?>? HPXUZCTGRSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2B43220", Offset = "0x2B42220", VA = "0x182B43220", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2B44D70", Offset = "0x2B43D70", VA = "0x182B44D70", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<XCMFJIKKBWV?>, BVCKRSDOJRJ?>? WGKQMQYWAVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2B43E90", Offset = "0x2B42E90", VA = "0x182B43E90", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2B41840", Offset = "0x2B40840", VA = "0x182B41840", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<XCMFJIKKBWV?>>? GMYSDYNTXYP
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2B45ED0", Offset = "0x2B44ED0", VA = "0x182B45ED0", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2B46080", Offset = "0x2B45080", VA = "0x182B46080", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<XCMFJIKKBWV?>, BVCKRSDOJRJ?>? MHVLFARGZHM
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2B44760", Offset = "0x2B43760", VA = "0x182B44760", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2B42E90", Offset = "0x2B41E90", VA = "0x182B42E90", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2B46140", Offset = "0x2B45140", VA = "0x182B46140")]
		private RYJYHFMMMVN(bool a, ICGXRSEYDCA b, bool c, ReadOnlyIdArray<JVDRBUQTLFY, BRRUMOBBIOF> inputs, ReadOnlyIdArray<JVDRBUQTLFY, RAUCSROXRTI> inputsAsStaticInputs, MOXNPQACASF d, ReadOnlyIdArray<XCMFJIKKBWV, KQHNHFUQMNU> outputs, ReadOnlyIdArray<XCMFJIKKBWV, BVCKRSDOJRJ> outputsAsStaticOutputs, string? overrideName, IEIHZQZXXRC e, Id32<MMFHTWDPFRA> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2B43940", Offset = "0x2B42940", VA = "0x182B43940")]
		public static RYJYHFMMMVN New(bool canInteract, ICGXRSEYDCA circuitsManager, bool hasFunctionHeader, MOXNPQACASF node, IEIHZQZXXRC portGroup, Id32<MMFHTWDPFRA> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2B419C0", Offset = "0x2B409C0", VA = "0x182B419C0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2B42C20", Offset = "0x2B41C20", VA = "0x182B42C20", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, BGYAXKJXFCB?>>? JKJFLCMECSL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2B44A70", Offset = "0x2B43A70", VA = "0x182B44A70")]
		private (ULPVUJHRMYK?, int)? TQRCMCMLMMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2B45CE0", Offset = "0x2B44CE0", VA = "0x182B45CE0", Slot = "58")]
		private void WEHZNQVGXWZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x25D66A0", Offset = "0x25D56A0", VA = "0x1825D66A0", Slot = "57")]
		private void NUTJGZENAZW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2B41350", Offset = "0x2B40350", VA = "0x182B41350", Slot = "61")]
		private void AUPSGVVARVM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2B42700", Offset = "0x2B41700", VA = "0x182B42700", Slot = "63")]
		private void HBIURFUQLMB(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2B440F0", Offset = "0x2B430F0", VA = "0x182B440F0", Slot = "50")]
		private void QUFVECXACDG(int a, Id32<JVDRBUQTLFY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2B45EB0", Offset = "0x2B44EB0", VA = "0x182B45EB0", Slot = "54")]
		private void WZMIPRWNIKZ(int a, Id32<JVDRBUQTLFY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2B44F60", Offset = "0x2B43F60", VA = "0x182B44F60", Slot = "49")]
		private void ULHNOOFCGZZ(int a, Id32<JVDRBUQTLFY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2B43380", Offset = "0x2B42380", VA = "0x182B43380", Slot = "53")]
		private void NWOXPPMHUVG(int a, Id32<JVDRBUQTLFY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2B424A0", Offset = "0x2B414A0", VA = "0x182B424A0", Slot = "66")]
		private void GDZWVXYPTCS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3C40", Offset = "0x11A2C40", VA = "0x1811A3C40", Slot = "65")]
		private void GMGNSUGZNPZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2B44F80", Offset = "0x2B43F80", VA = "0x182B44F80", Slot = "60")]
		private void VFMJOFUALGA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x25D66A0", Offset = "0x25D56A0", VA = "0x1825D66A0", Slot = "59")]
		private void QBNGCZUZZZV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2B45910", Offset = "0x2B44910", VA = "0x182B45910", Slot = "62")]
		private void WATGONICENT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2B410B0", Offset = "0x2B400B0", VA = "0x182B410B0", Slot = "64")]
		private void AGDAKNSFIII(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2B451A0", Offset = "0x2B441A0", VA = "0x182B451A0", Slot = "52")]
		private void VNQMNFZQPVB(int a, Id32<XCMFJIKKBWV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2B43010", Offset = "0x2B42010", VA = "0x182B43010", Slot = "56")]
		private void MHZQACLRNAY(int a, Id32<XCMFJIKKBWV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2B42C00", Offset = "0x2B41C00", VA = "0x182B42C00", Slot = "51")]
		private void IQAOVLIGRAS(int a, Id32<XCMFJIKKBWV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2B42790", Offset = "0x2B41790", VA = "0x182B42790", Slot = "55")]
		private void IDLSJQJQVRR(int a, Id32<XCMFJIKKBWV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2B437D0", Offset = "0x2B427D0", VA = "0x182B437D0", Slot = "68")]
		private void NWZOAAWMXWD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x11A3C40", Offset = "0x11A2C40", VA = "0x1811A3C40", Slot = "67")]
		private void YPQPZBQJLAM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2B41E00", Offset = "0x2B40E00", VA = "0x182B41E00", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, BGYAXKJXFCB?>>? EMGDNLYXPZY(Id32<VKOSYOKYXNB> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x2B45090", Offset = "0x2B44090", VA = "0x182B45090", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, BGYAXKJXFCB?>>? VINDKJTVXWP(Id32<EBKDWIFBKMY> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B457F0", Offset = "0x2B447F0", VA = "0x182B457F0", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, BGYAXKJXFCB?>>? VQHRJBRFWMA(Id32<VKOSYOKYXNB> inputDefId, Id32<VKOSYOKYXNB> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F50", Offset = "0x2B42F50", VA = "0x182B43F50", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, BGYAXKJXFCB?>>? PFEBEEHUZDV(Id32<EBKDWIFBKMY> outputDefId, Id32<EBKDWIFBKMY> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2B44820", Offset = "0x2B43820", VA = "0x182B44820", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, BGYAXKJXFCB?>>? RUVDNRKVLHW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2B41720", Offset = "0x2B40720", VA = "0x182B41720", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, BGYAXKJXFCB>> BDAHCOAFQSD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2B43030", Offset = "0x2B42030", VA = "0x182B43030", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, BGYAXKJXFCB>> MVYFVMBHTAQ(Id32<VKOSYOKYXNB> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2B41140", Offset = "0x2B40140", VA = "0x182B41140", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, BGYAXKJXFCB>> APVBNGLBFXX(Id32<EBKDWIFBKMY> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2B42370", Offset = "0x2B41370", VA = "0x182B42370", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, BGYAXKJXFCB>> GCBTFKWMIUP(Id32<VKOSYOKYXNB> inputDefId, MMEEXWRZTBL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2B44E30", Offset = "0x2B43E30", VA = "0x182B44E30", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, BGYAXKJXFCB>> UAUQGVWQUPC(Id32<EBKDWIFBKMY> outputDefId, MMEEXWRZTBL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2B41FC0", Offset = "0x2B40FC0", VA = "0x182B41FC0")]
		internal void FTJRAWPTSNM(Id32<MMFHTWDPFRA> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class DEAYNPZYJML : SATWJHVPDBI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface ICTTKLBYQGC
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<LNVRVOESCOU>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065D")]
				[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<LNVRVOESCOU>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			ZZZJGZASNDB ZZZJGZASNDB
			{
				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> ITENEJUIYBW(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> PAPRICEPMLZ(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<VIDZMMRWGND> HKAWSNNRQPK(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<RMSEJYRZGFH> VCXIBUPMMFX(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> RRQLKSMRGDA(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> ECYOKOJPDPT(CancellationToken a);
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
			public AsyncTaskMethodBuilder<DEAYNPZYJML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public ICGXRSEYDCA circuitsManager;

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
			private ICTTKLBYQGC <selfDeps>5__2;

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
			private VIDZMMRWGND <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private RMSEJYRZGFH <playerSaveData>5__8;

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
			private TaskAwaiter<VIDZMMRWGND> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<RMSEJYRZGFH> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<ICTTKLBYQGC.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<AGDBBCFQBWL> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x2B47770", Offset = "0x2B46770", VA = "0x182B47770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x2B48940", Offset = "0x2B47940", VA = "0x182B48940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public AGDBBCFQBWL AGDBBCFQBWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public USZPYUIDWWX USZPYUIDWWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public ZTEQHNVBKCY ZTEQHNVBKCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public SJCOOQFJORS SJCOOQFJORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x11FB640", Offset = "0x11FA640", VA = "0x1811FB640")]
		private DEAYNPZYJML(AGDBBCFQBWL a, USZPYUIDWWX b, ZTEQHNVBKCY c, SJCOOQFJORS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x2B37060", Offset = "0x2B36060", VA = "0x182B37060")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<DEAYNPZYJML> TXIDKKKXPRC(ICGXRSEYDCA a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2B37040", Offset = "0x2B36040", VA = "0x182B37040", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class WNGLUIHQDBZ : VTCGOHQOOJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public MMKGAUJIIYF? HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D9F0", Offset = "0x2B4C9F0", VA = "0x182B4D9F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		internal WNGLUIHQDBZ(ICGXRSEYDCA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class ZTEQHNVBKCY : MMKGAUJIIYF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly AGDBBCFQBWL FLLQMDWLTRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly WNGLUIHQDBZ UCGNYAEXIHC;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> OYUMKUUELMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F790", Offset = "0x2B4E790", VA = "0x182B4F790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE84FF0", Offset = "0xE83FF0", VA = "0x180E84FF0")]
		public ZTEQHNVBKCY(ICGXRSEYDCA a, AGDBBCFQBWL b, WNGLUIHQDBZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F7D0", Offset = "0x2B4E7D0", VA = "0x182B4F7D0", Slot = "5")]
		public string OZZNTDICUXY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F820", Offset = "0x2B4E820", VA = "0x182B4F820", Slot = "6")]
		public void PDVSFOYSFMV(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A6D0", Offset = "0x2B596D0", VA = "0x182B5A6D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A910", Offset = "0x2B59910", VA = "0x182B5A910", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, BGYAXKJXFCB>> <>t__builder;

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
			private AGLENQQYPWD[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B120", Offset = "0x2B5A120", VA = "0x182B5B120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B4F0", Offset = "0x2B5A4F0", VA = "0x182B5B4F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public AGLENQQYPWD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F830", Offset = "0x2B5E830", VA = "0x182B5F830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FC40", Offset = "0x2B5EC40", VA = "0x182B5FC40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly RJNEMTAVLYW _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
		public EVRequestExtended(RJNEMTAVLYW staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2B39010", Offset = "0x2B38010", VA = "0x182B39010")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, BGYAXKJXFCB>> QDTWMNGQOPY(AGLENQQYPWD a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2B38DC0", Offset = "0x2B37DC0", VA = "0x182B38DC0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, BGYAXKJXFCB?>>? CTQDFNFPOUN(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2B38F20", Offset = "0x2B37F20", VA = "0x182B38F20")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, BGYAXKJXFCB>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface ZBDLQYWPAME : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		SATWJHVPDBI? HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool GDLCCOYEMVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<SATWJHVPDBI?>? OLJYHQOQTKE();

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task SGUAUUEVRPX(ICGXRSEYDCA a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface SATWJHVPDBI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		AGDBBCFQBWL AGDBBCFQBWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		USZPYUIDWWX USZPYUIDWWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		ZTEQHNVBKCY ZTEQHNVBKCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		SJCOOQFJORS SJCOOQFJORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class QNGNPUCYUXH
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2B51880", Offset = "0x2B50880", VA = "0x182B51880")]
		public static ReducerFactory<ActionKind, AGLENQQYPWD, ICGXRSEYDCA, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>> HEZGKLJLVES([In] this ReducerFactory<ActionKind, AGLENQQYPWD, ICGXRSEYDCA, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, AGLENQQYPWD, ICGXRSEYDCA, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class INKIUZFENHG : XDVNNFLMVCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool GDLCCOYEMVR
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x2B51590", Offset = "0x2B50590", VA = "0x182B51590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		internal INKIUZFENHG(ICGXRSEYDCA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class EJLRQQSYDUB : EGFYEMKSOVU
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2B50D50", Offset = "0x2B4FD50", VA = "0x182B50D50", Slot = "4")]
		public WHIAOEXSATK? OXMSZFMONOX(string? a, string? b, string? c, RoomDoorData.PGFUJMMTYOK.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2B50DE0", Offset = "0x2B4FDE0", VA = "0x182B50DE0", Slot = "5")]
		public KTWAABBDCDA SFPEYVFNAQX(string a, string b, List<string> c, int d, int e, int f, int g, ONRWHMVRCKQ h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2B50EA0", Offset = "0x2B4FEA0", VA = "0x182B50EA0", Slot = "6")]
		public ONRWHMVRCKQ XHMXLKUAZID(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public EJLRQQSYDUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class DCUBLFRNOPJ : OAYBZJXSBWW
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
			public AsyncTaskMethodBuilder<SDUXUOJZYIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public DCUBLFRNOPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<SATWJHVPDBI?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A980", Offset = "0x2B59980", VA = "0x182B5A980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AC20", Offset = "0x2B59C20", VA = "0x182B5AC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public SDUXUOJZYIJ? HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x2B504F0", Offset = "0x2B4F4F0", VA = "0x182B504F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public SJCOOQFJORS? MTQRZVPIRCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x2B500C0", Offset = "0x2B4F0C0", VA = "0x182B500C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool WKEUMGIAMAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F6C0", VA = "0x182B506C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool XRSRJLNNRRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2B50660", Offset = "0x2B4F660", VA = "0x182B50660", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x2B50A70", Offset = "0x2B4FA70", VA = "0x182B50A70")]
		internal DCUBLFRNOPJ(ICGXRSEYDCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2B50570", Offset = "0x2B4F570", VA = "0x182B50570", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<SDUXUOJZYIJ> OLJYHQOQTKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2B50140", Offset = "0x2B4F140", VA = "0x182B50140", Slot = "9")]
		public IReadOnlyDictionary<Id128<LNVRVOESCOU>, Guid> HDRTWNOPJLE(IEnumerable<MQHFFIUQXTL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2B508F0", Offset = "0x2B4F8F0", VA = "0x182B508F0", Slot = "10")]
		public CircuitGraphToolMappingRegistryData YWXUIANDQWA(IEnumerable<MQHFFIUQXTL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2B50720", Offset = "0x2B4F720", VA = "0x182B50720")]
		public Result<CircuitsRoomData, TBKCGNLOMPR> XRMVQVCVNEQ([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, TBKCGNLOMPR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2B504C0", Offset = "0x2B4F4C0", VA = "0x182B504C0", Slot = "8")]
		private Result<CircuitsRoomData, TBKCGNLOMPR> NDYZRHLUZGZ([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, TBKCGNLOMPR>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class SJCOOQFJORS : SDUXUOJZYIJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class VWBTDXLOVWD
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class LCEQAKIHZSA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int OBNODZGSZUQ;

				[Cpp2IlInjected.Token(Token = "0x6000716")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public LCEQAKIHZSA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x2B51600", Offset = "0x2B50600", VA = "0x182B51600")]
				internal void AYYDXQLHQWF(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x2B60910", Offset = "0x2B5F910", VA = "0x182B60910")]
			public static Result<SDUXUOJZYIJ.PrepareTemplateForCloneResult, FJYIIDDGAPS> IUKOSOXMDUK(SJCOOQFJORS a, [In] SDUXUOJZYIJ.PrepareTemplateForCloneArgs args)
			{
				return default(Result<SDUXUOJZYIJ.PrepareTemplateForCloneResult, FJYIIDDGAPS>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x2B60E50", Offset = "0x2B5FE50", VA = "0x182B60E50")]
			internal static Result<(IFATFPEPAOZ, CircuitTemplateRootData), FJYIIDDGAPS> PDJBLKEAUHG(SJCOOQFJORS a, CircuitTemplateRootData b, bool c, [In] Id128<LNVRVOESCOU> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(IFATFPEPAOZ, CircuitTemplateRootData), FJYIIDDGAPS>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2B60480", Offset = "0x2B5F480", VA = "0x182B60480")]
			private static void CLHLIOBQGDI(bool a, MQHFFIUQXTL b, IFATFPEPAOZ c, [In] Id128<LNVRVOESCOU> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2B62110", Offset = "0x2B61110", VA = "0x182B62110")]
			public static void YKOHVLKOPAP(AXHRZJQIHWM a, [In] SDUXUOJZYIJ.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2B61B80", Offset = "0x2B60B80", VA = "0x182B61B80")]
			[CompilerGenerated]
			internal static bool UQFPMMUACMS(AGDBBCFQBWL a, YNGCMLUUITO b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2B60E20", Offset = "0x2B5FE20", VA = "0x182B60E20")]
			[CompilerGenerated]
			internal static bool KCIBPVLQOPN(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class IBFESINCEOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public SJCOOQFJORS FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<LNVRVOESCOU> DJGJPGFZAGZ;

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public IBFESINCEOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x2B51550", Offset = "0x2B50550", VA = "0x182B51550")]
			internal Id128<GOPNEBMAEKM> SOSGKFYHIJI(Id32<GOPNEBMAEKM> a)
			{
				return default(Id128<GOPNEBMAEKM>);
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<GVZPIOKFAXL> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<DRWFHSZKMVW> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B560", Offset = "0x2B5A560", VA = "0x182B5B560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BB30", Offset = "0x2B5AB30", VA = "0x182B5BB30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<MMFHTWDPFRA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<VKOSYOKYXNB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BBA0", Offset = "0x2B5ABA0", VA = "0x182B5BBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BEF0", Offset = "0x2B5AEF0", VA = "0x182B5BEF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<GOPNEBMAEKM>, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<SPOBLADDTYT> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private AGDBBCFQBWL <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C240", Offset = "0x2B5B240", VA = "0x182B5C240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C670", Offset = "0x2B5B670", VA = "0x182B5C670", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BF60", Offset = "0x2B5AF60", VA = "0x182B5BF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C1D0", Offset = "0x2B5B1D0", VA = "0x182B5C1D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C6E0", Offset = "0x2B5B6E0", VA = "0x182B5C6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C8D0", Offset = "0x2B5B8D0", VA = "0x182B5C8D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<LNVRVOESCOU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<GOPNEBMAEKM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<GOPNEBMAEKM>> nodeIds;

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
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C940", Offset = "0x2B5B940", VA = "0x182B5C940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2B5CBE0", Offset = "0x2B5BBE0", VA = "0x182B5CBE0", Slot = "5")]
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
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<LNVRVOESCOU> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<GOPNEBMAEKM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<GOPNEBMAEKM>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<MMFHTWDPFRA>, Id32<JVDRBUQTLFY>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<MMFHTWDPFRA>, Id32<XCMFJIKKBWV>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2B5CC50", Offset = "0x2B5BC50", VA = "0x182B5CC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D230", Offset = "0x2B5C230", VA = "0x182B5D230", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<LNVRVOESCOU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<GOPNEBMAEKM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<GOPNEBMAEKM>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D290", Offset = "0x2B5C290", VA = "0x182B5D290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D4A0", Offset = "0x2B5C4A0", VA = "0x182B5D4A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<GOPNEBMAEKM> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<MMFHTWDPFRA> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<JVDRBUQTLFY> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D510", Offset = "0x2B5C510", VA = "0x182B5D510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D860", Offset = "0x2B5C860", VA = "0x182B5D860", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<MMFHTWDPFRA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<VKOSYOKYXNB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D8D0", Offset = "0x2B5C8D0", VA = "0x182B5D8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DCB0", Offset = "0x2B5CCB0", VA = "0x182B5DCB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DD20", Offset = "0x2B5CD20", VA = "0x182B5DD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DFA0", Offset = "0x2B5CFA0", VA = "0x182B5DFA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<GOPNEBMAEKM> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<MMFHTWDPFRA> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<XCMFJIKKBWV> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E010", Offset = "0x2B5D010", VA = "0x182B5E010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E360", Offset = "0x2B5D360", VA = "0x182B5E360", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E3D0", Offset = "0x2B5D3D0", VA = "0x182B5E3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E710", Offset = "0x2B5D710", VA = "0x182B5E710", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E780", Offset = "0x2B5D780", VA = "0x182B5E780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2B5EA10", Offset = "0x2B5DA10", VA = "0x182B5EA10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2B5EA80", Offset = "0x2B5DA80", VA = "0x182B5EA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2B5ED10", Offset = "0x2B5DD10", VA = "0x182B5ED10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<GOPNEBMAEKM>>, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<LNVRVOESCOU> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<MQHFFIUQXTL> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<MOXNPQACASF>, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2B5ED80", Offset = "0x2B5DD80", VA = "0x182B5ED80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F530", Offset = "0x2B5E530", VA = "0x182B5F530", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<LNVRVOESCOU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<GOPNEBMAEKM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<GOPNEBMAEKM>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F5A0", Offset = "0x2B5E5A0", VA = "0x182B5F5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F7C0", Offset = "0x2B5E7C0", VA = "0x182B5F7C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public SJCOOQFJORS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<LNVRVOESCOU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<GOPNEBMAEKM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FD20", Offset = "0x2B5ED20", VA = "0x182B5FD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FF40", Offset = "0x2B5EF40", VA = "0x182B5FF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly ICGXRSEYDCA DIBNZELRTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly AGDBBCFQBWL FLLQMDWLTRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers FOEDRSSVQTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly DCUBLFRNOPJ OXYTPMOPYZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<GOPNEBMAEKM>, VBGMMRXSCJI> DFBGXQETIVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<GOPNEBMAEKM>>? WTUTNAIEEGK;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<LNVRVOESCOU> FLXAYOICBVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2B52630", Offset = "0x2B51630", VA = "0x182B52630", Slot = "4")]
			get
			{
				return default(Id128<LNVRVOESCOU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers KYYNDAAHTNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2B55730", Offset = "0x2B54730", VA = "0x182B55730", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> VJLURXZJRFT
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B53900", Offset = "0x2B52900", VA = "0x182B53900", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action MWJCPPUSDCM
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B581B0", Offset = "0x2B571B0", VA = "0x182B581B0", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B54A60", Offset = "0x2B53A60", VA = "0x182B54A60", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> PDZDMFOQKGU
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B52990", Offset = "0x2B51990", VA = "0x182B52990", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B52BB0", Offset = "0x2B51BB0", VA = "0x182B52BB0", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2B59A90", Offset = "0x2B58A90", VA = "0x182B59A90")]
		public SJCOOQFJORS(ICGXRSEYDCA a, AGDBBCFQBWL b, DCUBLFRNOPJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2B529F0", Offset = "0x2B519F0", VA = "0x182B529F0", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2B55710", Offset = "0x2B54710", VA = "0x182B55710", Slot = "100")]
		public Id32<DGVMSKMKDFG> NAWDQEUFSWT(Id32<LNVRVOESCOU> graphId, Id32<DRWFHSZKMVW> inputId)
		{
			return default(Id32<DGVMSKMKDFG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2B59170", Offset = "0x2B58170", VA = "0x182B59170", Slot = "101")]
		public Id32<GMKOAAXXZUL> XUSXYVBNEVA(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> outputId)
		{
			return default(Id32<GMKOAAXXZUL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2B54AA0", Offset = "0x2B53AA0", VA = "0x182B54AA0", Slot = "6")]
		public (bool, bool) MLMWEJZHBAZ(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> srcId, Id32<DRWFHSZKMVW> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2B56A50", Offset = "0x2B55A50", VA = "0x182B56A50")]
		public bool RPEYQEAMWWQ(Id32<LNVRVOESCOU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2B58E10", Offset = "0x2B57E10", VA = "0x182B58E10", Slot = "8")]
		public bool WJYBRWJKOUK(RAUCSROXRTI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2B52F60", Offset = "0x2B51F60", VA = "0x182B52F60", Slot = "9")]
		public bool GJKCLYICZNP(BVCKRSDOJRJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2B549A0", Offset = "0x2B539A0", VA = "0x182B549A0", Slot = "10")]
		public AbsoluteLegacyInputId? LRJKGOQFYNU(Id32<LNVRVOESCOU> graphId, Id32<DRWFHSZKMVW> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2B54A00", Offset = "0x2B53A00", VA = "0x182B54A00", Slot = "11")]
		public AbsoluteLegacyOutputId? MAAPBIJHTWR(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2B58290", Offset = "0x2B57290", VA = "0x182B58290", Slot = "12")]
		public Id32<GVZPIOKFAXL>? SZLJDBRNQNJ(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<XCMFJIKKBWV> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2B55E00", Offset = "0x2B54E00", VA = "0x182B55E00", Slot = "13")]
		public Id32<DRWFHSZKMVW>? QPLTLCBPOTW(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<JVDRBUQTLFY> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2B52E10", Offset = "0x2B51E10", VA = "0x182B52E10", Slot = "14")]
		public IEnumerable<Id32<LNVRVOESCOU>> FWPFYUJPHTO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2B527B0", Offset = "0x2B517B0", VA = "0x182B527B0", Slot = "15")]
		public IEnumerable<Id32<JDLMLHMLFIE>> BVGGCXJXQQL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B54740", Offset = "0x2B53740", VA = "0x182B54740", Slot = "22")]
		public string LHVUNDTNTMX(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B59600", Offset = "0x2B58600", VA = "0x182B59600", Slot = "16")]
		public Id32<JDLMLHMLFIE>? ZTMDNCMVJEN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B59030", Offset = "0x2B58030", VA = "0x182B59030", Slot = "17")]
		public int XRTYQTONKDW(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B58E90", Offset = "0x2B57E90", VA = "0x182B58E90", Slot = "18")]
		public int WKMYZQIHMQZ(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B52870", Offset = "0x2B51870", VA = "0x182B52870", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] CNZSSIZQRBM(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B58420", Offset = "0x2B57420", VA = "0x182B58420", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] TEGBLGGEWDN(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D79C30", Offset = "0x3D78C30", VA = "0x183D79C30")]
		private static (CircuitTypeIdWrapper, string?)[]? PSSVLLJQIHW<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B56D50", Offset = "0x2B55D50", VA = "0x182B56D50", Slot = "21")]
		public string RQKSFEEWCMJ(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B54A80", Offset = "0x2B53A80", VA = "0x182B54A80", Slot = "23")]
		public string MLMILGKJWPW(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B52BD0", Offset = "0x2B51BD0", VA = "0x182B52BD0")]
		public VBGMMRXSCJI? FAPFZPYELFV([In] Id128<GOPNEBMAEKM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B52DF0", Offset = "0x2B51DF0", VA = "0x182B52DF0", Slot = "30")]
		public Id32<SPOBLADDTYT> FVCKKVQRQKT(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId)
		{
			return default(Id32<SPOBLADDTYT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B52840", Offset = "0x2B51840", VA = "0x182B52840")]
		public Id32<GOPNEBMAEKM> CKMPZMNMBOO(Id32<LNVRVOESCOU> graphId, [In] Id128<GOPNEBMAEKM> legacyNodeId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B54580", Offset = "0x2B53580", VA = "0x182B54580", Slot = "40")]
		public Id32<GOPNEBMAEKM> JRPFZKKNDTB(Id32<LNVRVOESCOU> graphId, Id32<DRWFHSZKMVW> inputId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B59010", Offset = "0x2B58010", VA = "0x182B59010", Slot = "41")]
		public Id32<GOPNEBMAEKM> WWIDKEHQJVA(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> outputId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B55F60", Offset = "0x2B54F60", VA = "0x182B55F60")]
		public Id32<GOPNEBMAEKM>? QVZVGNTJRGO(Id32<LNVRVOESCOU> graphId, [In] Id128<GOPNEBMAEKM> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B585F0", Offset = "0x2B575F0", VA = "0x182B585F0", Slot = "32")]
		public AbsoluteNodeId? TRXEDBRFHUQ(Id32<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B582C0", Offset = "0x2B572C0", VA = "0x182B582C0", Slot = "33")]
		public long TBGACNQGFQZ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B598C0", Offset = "0x2B588C0", VA = "0x182B598C0")]
		private void ZUBJBHXRYMR(Id128<GOPNEBMAEKM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B58900", Offset = "0x2B57900", VA = "0x182B58900", Slot = "38")]
		public IEnumerable<(Id32<LNVRVOESCOU>, Id32<GOPNEBMAEKM>)> UYXRDBLEVVZ(Id32<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B55DD0", Offset = "0x2B54DD0", VA = "0x182B55DD0", Slot = "39")]
		public Id32<DRWFHSZKMVW> QPLTLCBPOTW(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<DGVMSKMKDFG> inputIndex)
		{
			return default(Id32<DRWFHSZKMVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B58260", Offset = "0x2B57260", VA = "0x182B58260", Slot = "42")]
		public Id32<GVZPIOKFAXL> SZLJDBRNQNJ(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<GMKOAAXXZUL> outputIndex)
		{
			return default(Id32<GVZPIOKFAXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B58700", Offset = "0x2B57700", VA = "0x182B58700")]
		private VBGMMRXSCJI? USIGNQHKNNI([In] Id128<GOPNEBMAEKM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B594C0", Offset = "0x2B584C0", VA = "0x182B594C0")]
		public MOXNPQACASF? ZFTYAMPQUSY([In] Id128<GOPNEBMAEKM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D00", Offset = "0x2B51D00", VA = "0x182B52D00")]
		public ZPLAZZNSWLA? UZLYPCXZWLT([In] Id128<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B58990", Offset = "0x2B57990", VA = "0x182B58990", Slot = "25")]
		public ZPLAZZNSWLA? UZLYPCXZWLT(Id32<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B54F40", Offset = "0x2B53F40", VA = "0x182B54F40", Slot = "34")]
		public IEnumerable<NewStaticEdge> MMVKZEVGWNV(Id32<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B525D0", Offset = "0x2B515D0", VA = "0x182B525D0", Slot = "35")]
		public bool ATQSGHOGQET(Id32<JDLMLHMLFIE> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B57B10", Offset = "0x2B56B10", VA = "0x182B57B10", Slot = "36")]
		public IEnumerable<StableStaticEdge> SGWITQCTYEP(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B55280", Offset = "0x2B54280", VA = "0x182B55280", Slot = "37")]
		public IEnumerable<StableStaticEdge> MYQTSQYJUZU(Id32<LNVRVOESCOU> graphId, Id32<DRWFHSZKMVW> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B55CA0", Offset = "0x2B54CA0", VA = "0x182B55CA0")]
		public Id32<LNVRVOESCOU> OSRGCPUIQCA([In] Id128<LNVRVOESCOU> graphId)
		{
			return default(Id32<LNVRVOESCOU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B54710", Offset = "0x2B53710", VA = "0x182B54710")]
		public Id32<LNVRVOESCOU>? ZJNDFSSIVSA([In] Id128<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B54670", Offset = "0x2B53670", VA = "0x182B54670")]
		private YNGCMLUUITO? KMDFHYZASQM([In] Id128<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D00", Offset = "0x2B51D00", VA = "0x182B52D00")]
		private ZPLAZZNSWLA? FMOSCMYWYFJ([In] Id128<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B554D0", Offset = "0x2B544D0", VA = "0x182B554D0", Slot = "28")]
		public Id32<LNVRVOESCOU>? MZMZFCUKMBF(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B53550", Offset = "0x2B52550", VA = "0x182B53550", Slot = "46")]
		public Id128<LNVRVOESCOU> IJWNGVCNKGJ(Id32<LNVRVOESCOU> graphId)
		{
			return default(Id128<LNVRVOESCOU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B55DB0", Offset = "0x2B54DB0", VA = "0x182B55DB0", Slot = "47")]
		public Id128<GOPNEBMAEKM> PTCPDFLTKJT(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId)
		{
			return default(Id128<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B59500", Offset = "0x2B58500", VA = "0x182B59500", Slot = "43")]
		public IEnumerable<MMEEXWRZTBL> ZQSVOZVDBSP(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B57D60", Offset = "0x2B56D60", VA = "0x182B57D60", Slot = "44")]
		public MMEEXWRZTBL SGZQIJKLWPI(RoomVersion a, JVEKMJHPKAZ b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B548B0", Offset = "0x2B538B0", VA = "0x182B548B0")]
		public NewStaticEdge LQSZFRMSPCE(Id32<LNVRVOESCOU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B52490", Offset = "0x2B51490", VA = "0x182B52490", Slot = "48")]
		public StableStaticEdge AFDQXTDKAPD(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> srcId, Id32<DRWFHSZKMVW> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B58B80", Offset = "0x2B57B80", VA = "0x182B58B80", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, BGYAXKJXFCB>> VBYNEWDCWHW(Id32<LNVRVOESCOU> parentGraphId, Id32<GOPNEBMAEKM> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B59320", Offset = "0x2B58320", VA = "0x182B59320", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, BGYAXKJXFCB>> YWVSYEYQDAF(Id32<LNVRVOESCOU> parentGraphId, Id128<GOPNEBMAEKM> boardNodeId, List<Id32<GOPNEBMAEKM>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B58060", Offset = "0x2B57060", VA = "0x182B58060", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, BGYAXKJXFCB>> SRYGZAHQLFI(Id32<LNVRVOESCOU> parentGraphId, Id128<GOPNEBMAEKM> boardNodeId, List<Id32<GOPNEBMAEKM>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B533F0", Offset = "0x2B523F0", VA = "0x182B533F0", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, BGYAXKJXFCB>> IGWELHAOTGC(Id32<LNVRVOESCOU> parentGraphId, Id128<GOPNEBMAEKM> boardNodeId, Id32<LNVRVOESCOU> graphId, List<Id32<GOPNEBMAEKM>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B58480", Offset = "0x2B57480", VA = "0x182B58480", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<MMFHTWDPFRA>, Id32<JVDRBUQTLFY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<MMFHTWDPFRA>, Id32<XCMFJIKKBWV>)>) TRTDSZZSKST(Id128<LNVRVOESCOU> legacyGraphId, Id32<GOPNEBMAEKM> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<MMFHTWDPFRA>, Id32<JVDRBUQTLFY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<MMFHTWDPFRA>, Id32<XCMFJIKKBWV>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B59940", Offset = "0x2B58940", VA = "0x182B59940", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task ZXYEFGDRYEN(Id128<LNVRVOESCOU> legacyGraphId, Id128<GOPNEBMAEKM> boardNodeId, IReadOnlyList<Id128<GOPNEBMAEKM>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<MMFHTWDPFRA>, Id32<JVDRBUQTLFY>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<MMFHTWDPFRA>, Id32<XCMFJIKKBWV>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B59300", Offset = "0x2B58300", VA = "0x182B59300", Slot = "55")]
		public bool YJVVTSUGGIN(Id32<LNVRVOESCOU> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B529B0", Offset = "0x2B519B0", VA = "0x182B529B0", Slot = "56")]
		public bool DERGWZBRBZP(Id32<LNVRVOESCOU> graphId, Id32<DRWFHSZKMVW> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B529D0", Offset = "0x2B519D0", VA = "0x182B529D0", Slot = "57")]
		public bool DYGKVAEAFWK(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B55230", Offset = "0x2B54230", VA = "0x182B55230")]
		public Result<SDUXUOJZYIJ.PrepareTemplateForCloneResult, FJYIIDDGAPS> MUMNFHVTPES([In] SDUXUOJZYIJ.PrepareTemplateForCloneArgs args)
		{
			return default(Result<SDUXUOJZYIJ.PrepareTemplateForCloneResult, FJYIIDDGAPS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B55E30", Offset = "0x2B54E30", VA = "0x182B55E30", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, BGYAXKJXFCB>> QRTXEPLBSJS(Id32<LNVRVOESCOU> graphId, Id32<GVZPIOKFAXL> srcId, Id32<DRWFHSZKMVW> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B53070", Offset = "0x2B52070", VA = "0x182B53070", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<GOPNEBMAEKM>, BGYAXKJXFCB>> GQKEMUDJUFD(Id32<LNVRVOESCOU> graphId, Id32<SPOBLADDTYT> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B582E0", Offset = "0x2B572E0", VA = "0x182B582E0", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> TCOJMBESCYA(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B566D0", Offset = "0x2B556D0", VA = "0x182B566D0", Slot = "62")]
		public Result<ControlPanelRootData, TBKCGNLOMPR> RETMJPKBZZM(Id128<LNVRVOESCOU> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, TBKCGNLOMPR>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B53960", Offset = "0x2B52960", VA = "0x182B53960", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, BGYAXKJXFCB>> JHCEZLGTKLM(Id128<LNVRVOESCOU> graphId, Id128<GOPNEBMAEKM> inputNodeId, Id32<MMFHTWDPFRA> inputPortGroupId, Id32<JVDRBUQTLFY> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B58EB0", Offset = "0x2B57EB0", VA = "0x182B58EB0", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, BGYAXKJXFCB>> WTZRUUWGQBT(Id128<LNVRVOESCOU> graphId, Id128<GOPNEBMAEKM> outputNodeId, Id32<MMFHTWDPFRA> outputPortGroupId, Id32<XCMFJIKKBWV> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B53AC0", Offset = "0x2B52AC0", VA = "0x182B53AC0", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, BGYAXKJXFCB>> JIHKYVKHLSW(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B54FE0", Offset = "0x2B53FE0", VA = "0x182B54FE0", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<GOPNEBMAEKM>>, BGYAXKJXFCB>> MNSBRJBNJOT(Id128<LNVRVOESCOU> intoGraphId, CircuitTemplateRootData a, IEnumerable<MQHFFIUQXTL> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B52A90", Offset = "0x2B51A90", VA = "0x182B52A90", Slot = "67")]
		public CircuitsData ECHVPBWMHRP()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B52FE0", Offset = "0x2B51FE0", VA = "0x182B52FE0", Slot = "68")]
		public CircuitsData GMKTSPAOQSI()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B589E0", Offset = "0x2B579E0", VA = "0x182B589E0", Slot = "71")]
		public CircuitsTemplateData VBPTQTPIKYP(TemplateSerializationReason a, Id32<LNVRVOESCOU> sourceGraphId, IEnumerable<Id128<LNVRVOESCOU>> graphIds, IEnumerable<Id128<GOPNEBMAEKM>> nodeIds, ISet<Id128<KJRRKGEGKOM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B58770", Offset = "0x2B57770", VA = "0x182B58770")]
		private CircuitsTemplateData UWZAVFQPXTU(TemplateSerializationReason a, Id32<LNVRVOESCOU> sourceGraphId, IEnumerable<Id128<LNVRVOESCOU>> graphIds, IEnumerable<Id128<GOPNEBMAEKM>> nodeIds, ISet<Id128<KJRRKGEGKOM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B53680", Offset = "0x2B52680", VA = "0x182B53680", Slot = "69")]
		public CircuitsTemplateData IKAFJVNUMJM(TemplateSerializationReason a, Id32<LNVRVOESCOU> sourceGraphId, IEnumerable<Id128<GOPNEBMAEKM>> nodeIds, IEnumerable<MQHFFIUQXTL> b, ISet<Id128<KJRRKGEGKOM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B53570", Offset = "0x2B52570", VA = "0x182B53570", Slot = "70")]
		public CircuitsTemplateData IKAFJVNUMJM(TemplateSerializationReason a, Id32<LNVRVOESCOU> sourceGraphId, IEnumerable<Id32<GOPNEBMAEKM>> nodeIds, IEnumerable<MQHFFIUQXTL> b, ISet<Id128<KJRRKGEGKOM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B56D80", Offset = "0x2B55D80", VA = "0x182B56D80")]
		private static IEnumerable<Id128<LNVRVOESCOU>> RSDGHRZBIFA(IEnumerable<MQHFFIUQXTL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B557A0", Offset = "0x2B547A0", VA = "0x182B557A0")]
		private IEnumerable<Id128<GOPNEBMAEKM>> OPPPTWXMVJG(IEnumerable<MQHFFIUQXTL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B53920", Offset = "0x2B52920", VA = "0x182B53920", Slot = "72")]
		public List<XSIUJUNSGUD> IYBKODZIIBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B55FC0", Offset = "0x2B54FC0", VA = "0x182B55FC0")]
		public (List<XSIUJUNSGUD>, bool) QXYBXCGAJIO([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, CZELBKTCHRD b, TAUFXFXZSLV c)
		{
			return default((List<XSIUJUNSGUD>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B52B20", Offset = "0x2B51B20", VA = "0x182B52B20", Slot = "74")]
		public bool EKZKSYFBAUX(Id32<LNVRVOESCOU> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B52400", Offset = "0x2B51400", VA = "0x182B52400", Slot = "75")]
		public bool ADGSWHXDMQR(Id32<LNVRVOESCOU> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B594A0", Offset = "0x2B584A0", VA = "0x182B594A0")]
		internal void ZFQNEMBLSYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B55260", Offset = "0x2B54260", VA = "0x182B55260")]
		internal Task MXMFSGOZCDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B53BD0", Offset = "0x2B52BD0", VA = "0x182B53BD0", Slot = "76")]
		public Result<Id32<GVZPIOKFAXL>?, BGYAXKJXFCB> JLHXHQKBHYM(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<DRWFHSZKMVW> inputId)
		{
			return default(Result<Id32<GVZPIOKFAXL>?, BGYAXKJXFCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B57160", Offset = "0x2B56160", VA = "0x182B57160", Slot = "77")]
		public Result<Id32<DRWFHSZKMVW>?, BGYAXKJXFCB> RVLMLADCMVW(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<GVZPIOKFAXL> outputId)
		{
			return default(Result<Id32<DRWFHSZKMVW>?, BGYAXKJXFCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B55140", Offset = "0x2B54140", VA = "0x182B55140", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, BGYAXKJXFCB>> MPNJATHWSMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B555D0", Offset = "0x2B545D0", VA = "0x182B555D0", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, BGYAXKJXFCB>> NAQQAEZTZND(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D30", Offset = "0x2B51D30", VA = "0x182B52D30", Slot = "80")]
		public Id32<GOPNEBMAEKM>? FNTEGLSYCWP(Id32<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B55CD0", Offset = "0x2B54CD0", VA = "0x182B55CD0", Slot = "81")]
		public Id32<GOPNEBMAEKM>? OXJUDAJBGMU(Id32<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B581D0", Offset = "0x2B571D0", VA = "0x182B581D0", Slot = "82")]
		public int SYMOTJETPIO(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B545A0", Offset = "0x2B535A0", VA = "0x182B545A0", Slot = "83")]
		public int JVQICHVTORV(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B52E80", Offset = "0x2B51E80", VA = "0x182B52E80", Slot = "84")]
		public int GAKCFYHLBJO(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<VKOSYOKYXNB> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B53310", Offset = "0x2B52310", VA = "0x182B53310", Slot = "85")]
		public int HYYSKCVQQLY(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<VKOSYOKYXNB> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B58CD0", Offset = "0x2B57CD0", VA = "0x182B58CD0", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, BGYAXKJXFCB>> VBYSYIRPZAY(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<VKOSYOKYXNB> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B531D0", Offset = "0x2B521D0", VA = "0x182B531D0", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, BGYAXKJXFCB>> HBEXZXDSWHH(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<VKOSYOKYXNB> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B528D0", Offset = "0x2B518D0", VA = "0x182B528D0", Slot = "88")]
		public int CYKTESPKVNC(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B54770", Offset = "0x2B53770", VA = "0x182B54770", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, BGYAXKJXFCB>> LKEMFLCDVPY(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B52650", Offset = "0x2B51650", VA = "0x182B52650", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, BGYAXKJXFCB>> BIVZZRKRZJB(Id32<LNVRVOESCOU> graphId, Id32<GOPNEBMAEKM> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B59190", Offset = "0x2B58190", VA = "0x182B59190", Slot = "91")]
		public bool XZCGNCVZPHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D90", Offset = "0x2B54D90", VA = "0x182B55D90", Slot = "97")]
		public IEnumerable<Id32<LRWMKGDWIYW>> PQIPILTWGAS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B538E0", Offset = "0x2B528E0", VA = "0x182B538E0", Slot = "98")]
		public string? IODFGRJTIHY(Id32<LRWMKGDWIYW> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B586F0", Offset = "0x2B576F0", VA = "0x182B586F0", Slot = "7")]
		private bool TYINFGAANWI(Id32<LNVRVOESCOU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D00", Offset = "0x2B51D00", VA = "0x182B52D00", Slot = "24")]
		private ZPLAZZNSWLA WMWCCMOSFBX([In] Id128<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2B55CA0", Offset = "0x2B54CA0", VA = "0x182B55CA0", Slot = "26")]
		private Id32<LNVRVOESCOU> PZSHTXXEVXW([In] Id128<LNVRVOESCOU> graphId)
		{
			return default(Id32<LNVRVOESCOU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2B54710", Offset = "0x2B53710", VA = "0x182B54710", Slot = "27")]
		private Id32<LNVRVOESCOU>? LDJPPWZZFLS([In] Id128<LNVRVOESCOU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2B59050", Offset = "0x2B58050", VA = "0x182B59050", Slot = "29")]
		private VBGMMRXSCJI XTTEGHNPNNZ([In] Id128<GOPNEBMAEKM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2B52840", Offset = "0x2B51840", VA = "0x182B52840", Slot = "31")]
		private Id32<GOPNEBMAEKM> JOMVOZJXNAO(Id32<LNVRVOESCOU> graphId, [In] Id128<GOPNEBMAEKM> legacyNodeId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2B548B0", Offset = "0x2B538B0", VA = "0x182B548B0", Slot = "45")]
		private NewStaticEdge QDSBOSXHXFS(Id32<LNVRVOESCOU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B55230", Offset = "0x2B54230", VA = "0x182B55230", Slot = "58")]
		private Result<SDUXUOJZYIJ.PrepareTemplateForCloneResult, FJYIIDDGAPS> XCUOETOIPLQ([In] SDUXUOJZYIJ.PrepareTemplateForCloneArgs args)
		{
			return default(Result<SDUXUOJZYIJ.PrepareTemplateForCloneResult, FJYIIDDGAPS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2B55740", Offset = "0x2B54740", VA = "0x182B55740", Slot = "73")]
		private (List<XSIUJUNSGUD>, bool) NYNQWUVDMIW([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, CZELBKTCHRD b, TAUFXFXZSLV c)
		{
			return default((List<XSIUJUNSGUD>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2B56630", Offset = "0x2B55630", VA = "0x182B56630")]
		[CompilerGenerated]
		private FZESCWZWBPY QXZBZYWWNVV(WQEPJKQGFSY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2B566A0", Offset = "0x2B556A0", VA = "0x182B566A0")]
		[CompilerGenerated]
		private MOXNPQACASF QYBGRCMXLZR(Id128<GOPNEBMAEKM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2B55F90", Offset = "0x2B54F90", VA = "0x182B55F90")]
		[CompilerGenerated]
		private YNGCMLUUITO QXVZTVTACOI(Id128<LNVRVOESCOU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2B566A0", Offset = "0x2B556A0", VA = "0x182B566A0")]
		[CompilerGenerated]
		private MOXNPQACASF XSAXVJIPYDF(Id128<GOPNEBMAEKM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2B55F90", Offset = "0x2B54F90", VA = "0x182B55F90")]
		[CompilerGenerated]
		private YNGCMLUUITO XRVQYCOSORW(Id128<LNVRVOESCOU> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class FZESCWZWBPY : MMEEXWRZTBL
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
			public AsyncTaskMethodBuilder<Result<Id32<VKOSYOKYXNB>, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public FZESCWZWBPY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<MMFHTWDPFRA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<VKOSYOKYXNB>, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A150", Offset = "0x2B59150", VA = "0x182B5A150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A3A0", Offset = "0x2B593A0", VA = "0x182B5A3A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<EBKDWIFBKMY>, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public FZESCWZWBPY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<LNVRVOESCOU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<GOPNEBMAEKM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<MMFHTWDPFRA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<EBKDWIFBKMY>, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A410", Offset = "0x2B59410", VA = "0x182B5A410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A660", Offset = "0x2B59660", VA = "0x182B5A660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly WQEPJKQGFSY ZTTTYRGRRIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly AGDBBCFQBWL FLLQMDWLTRR;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey HRYGTRPETWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string YSMQLSOUTZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x2B510B0", Offset = "0x2B500B0", VA = "0x182B510B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public WQEPJKQGFSY WQEPJKQGFSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2B51250", Offset = "0x2B50250", VA = "0x182B51250")]
		public FZESCWZWBPY(WQEPJKQGFSY a, AGDBBCFQBWL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2B510E0", Offset = "0x2B500E0", VA = "0x182B510E0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<VKOSYOKYXNB>, BGYAXKJXFCB>> OHNAKNENBXR(Id128<LNVRVOESCOU> graphId, Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2B50F40", Offset = "0x2B4FF40", VA = "0x182B50F40", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<EBKDWIFBKMY>, BGYAXKJXFCB>> AWQGUJUFQTG(Id128<LNVRVOESCOU> graphId, Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class YXKFHPMFNGA : ZDEDFBVKWCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly WQEPJKQGFSY RUBKUPLWLTO;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<WQEPJKQGFSY> AOANNDMUALE;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<WQEPJKQGFSY> QWPHOZRJWGT;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<WQEPJKQGFSY> YZVYYHWZENQ;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public WQEPJKQGFSY OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2B64570", Offset = "0x2B63570", VA = "0x182B64570", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x2B64560", Offset = "0x2B63560", VA = "0x182B64560", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x2B645C0", Offset = "0x2B635C0", VA = "0x182B645C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2B644E0", Offset = "0x2B634E0", VA = "0x182B644E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B62920", Offset = "0x2B61920", VA = "0x182B62920")]
		public bool RTJDIESGOFD(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public YXKFHPMFNGA(WQEPJKQGFSY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2B62790", Offset = "0x2B61790", VA = "0x182B62790")]
		internal static TypeKey BRRCWJNIEIW(WQEPJKQGFSY a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B510B0", Offset = "0x2B500B0", VA = "0x182B510B0", Slot = "3")]
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
	public readonly struct ActionDeps : DYPZVZBTZVR.CWZBPJLOXEW<AGLENQQYPWD, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FF90", Offset = "0x2B4EF90", VA = "0x182B4FF90", Slot = "4")]
		public int FITBBFBDIXW(None a, AGLENQQYPWD b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2B50080", Offset = "0x2B4F080", VA = "0x182B50080", Slot = "5")]
		public AGLENQQYPWD SUPDULSUHUT(None a, AGLENQQYPWD b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2B50050", Offset = "0x2B4F050", VA = "0x182B50050", Slot = "6")]
		public AGLENQQYPWD NIBIFAPTQKA(None a, AGLENQQYPWD b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2B50090", Offset = "0x2B4F090", VA = "0x182B50090", Slot = "7")]
		public IReadOnlyList<AGLENQQYPWD> ZKXBDFCJFEG(None a, AGLENQQYPWD b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2B500B0", Offset = "0x2B4F0B0", VA = "0x182B500B0", Slot = "8")]
		public AGLENQQYPWD[] ZRZSKJMDOJP(None a, AGLENQQYPWD b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FF70", Offset = "0x2B4EF70", VA = "0x182B4FF70", Slot = "9")]
		public bool ACWWFMWUBSK(None a, AGLENQQYPWD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FFB0", Offset = "0x2B4EFB0", VA = "0x182B4FFB0", Slot = "10")]
		public bool FLUABPDUEGE(None a, AGLENQQYPWD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2B50010", Offset = "0x2B4F010", VA = "0x182B50010", Slot = "11")]
		public bool GCZCXPSFWEG(None a, AGLENQQYPWD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FFD0", Offset = "0x2B4EFD0", VA = "0x182B4FFD0", Slot = "12")]
		public bool FXCMRHMRYWU(None a, AGLENQQYPWD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FFF0", Offset = "0x2B4EFF0", VA = "0x182B4FFF0", Slot = "13")]
		public bool FZGUGQEYYKK(None a, AGLENQQYPWD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2B50030", Offset = "0x2B4F030", VA = "0x182B50030", Slot = "14")]
		public bool NGJBVWHPXGH(None a, AGLENQQYPWD b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class JNCFJALOQXT : JVEJJWJVKSR
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract VFCMMUNYJTZ.ICTTKLBYQGC JBBUTJZDDDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract ICGXRSEYDCA.ICTTKLBYQGC QHTVSOSZHGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract DEAYNPZYJML.ICTTKLBYQGC CKPYCFTRELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA> CAKQIGJUQSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x2B515B0", Offset = "0x2B505B0", VA = "0x182B515B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.ICTTKLBYQGC OQRIIKETKQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract DUQMTWSATKX EBSKGPJZCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract YVVNDNVNRHU WFSNWXDAMMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract XDGOQWUJYOU FXOHAPKJXTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract QMQBHLTBDHS KRYVXSVOULN
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract FTANEFSKGGW JPCFVWXLNYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected JNCFJALOQXT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class GCOXYPIOILX : XWWPGKGAISL
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
			public AsyncTaskMethodBuilder<Result<MultiResult, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<AGLENQQYPWD> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public GCOXYPIOILX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AC90", Offset = "0x2B59C90", VA = "0x182B5AC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B0B0", Offset = "0x2B5A0B0", VA = "0x182B5B0B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public GCOXYPIOILX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public AGLENQQYPWD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FA30", Offset = "0x2B5EA30", VA = "0x182B5FA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FCB0", Offset = "0x2B5ECB0", VA = "0x182B5FCB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly RJNEMTAVLYW IQJDBEKUAQY;

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public GCOXYPIOILX(RJNEMTAVLYW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2B512F0", Offset = "0x2B502F0", VA = "0x182B512F0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, BGYAXKJXFCB>> QDTWMNGQOPY(AGLENQQYPWD a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2B51420", Offset = "0x2B50420", VA = "0x182B51420", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, BGYAXKJXFCB>> VQURAFBHXVA(IReadOnlyList<AGLENQQYPWD> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, AGLENQQYPWD, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x137A110", Offset = "0x1379110", VA = "0x18137A110")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, AGLENQQYPWD, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2B51820", Offset = "0x2B50820", VA = "0x182B51820")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class YEDYOAJPXDS
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, AGLENQQYPWD, PartialActionReassemblyDeps> UHBUGJCPEOX(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, AGLENQQYPWD, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : NEQOMUKDWNT.XRRCBJBDPQX<PartialActionPayload, Id128<PartialActionPayload.M>, AGLENQQYPWD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2B51620", Offset = "0x2B50620", VA = "0x182B51620", Slot = "7")]
		public AGLENQQYPWD FENNTPYQTBL(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x136BDF0", Offset = "0x136ADF0", VA = "0x18136BDF0")]
		public Id128<PartialActionPayload.M> QSDCLZZIYMF([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x13A1600", Offset = "0x13A0600", VA = "0x1813A1600")]
		public int LBWUHYSPVDF([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2B51810", Offset = "0x2B50810", VA = "0x182B51810")]
		public int YYSOKLGBISQ([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x13A1600", Offset = "0x13A0600", VA = "0x1813A1600", Slot = "4")]
		private int QNYGYIVBNKR([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2B51810", Offset = "0x2B50810", VA = "0x182B51810", Slot = "5")]
		private int USRQUJWIIBE([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x136BDF0", Offset = "0x136ADF0", VA = "0x18136BDF0", Slot = "6")]
		private Id128<PartialActionPayload.M> ZITESJWQCGD([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, AGLENQQYPWD, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x137A110", Offset = "0x1379110", VA = "0x18137A110")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, AGLENQQYPWD, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A0F0", Offset = "0x2B590F0", VA = "0x182B5A0F0")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class QCAJKLVDERB
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0")]
		public static SnapshotReassembly<PartialInitializePayload, AGLENQQYPWD, SnapshotReassemblyDeps> UHBUGJCPEOX(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, AGLENQQYPWD, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : CYPJEFJIJWA.XRLVECHGGFO<PartialInitializePayload, AGLENQQYPWD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x119D9B0", Offset = "0x119C9B0", VA = "0x18119D9B0")]
		public int GLSNERBTZOV([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2B59F00", Offset = "0x2B58F00", VA = "0x182B59F00", Slot = "5")]
		public AGLENQQYPWD EOXDDPFYNFV(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x119D9B0", Offset = "0x119C9B0", VA = "0x18119D9B0", Slot = "4")]
		private int JLSOYAQXCNZ([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class WKGFUTTWRHH : GJHFNOSHAUY, FJYIIDDGAPS, BGYAXKJXFCB, TBKCGNLOMPR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly TBKCGNLOMPR? ASTKJNHLSHD;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind BSZGMEOZKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xAD13D0", Offset = "0xAD03D0", VA = "0x180AD13D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override TBKCGNLOMPR? YVZKHIIWJZY
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B62520", Offset = "0x2B61520", VA = "0x182B62520", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B62750", Offset = "0x2B61750", VA = "0x182B62750")]
		private WKGFUTTWRHH(PrepareTemplateForCloneErrKind a, TBKCGNLOMPR? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B626E0", Offset = "0x2B616E0", VA = "0x182B626E0")]
		public static WKGFUTTWRHH XHUJSQMSDDD(TBKCGNLOMPR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B62680", Offset = "0x2B61680", VA = "0x182B62680")]
		public static WKGFUTTWRHH LMVDDDVELJX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B62620", Offset = "0x2B61620", VA = "0x182B62620")]
		public static WKGFUTTWRHH FTMDHZOKZSP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class BAWSTVJJCYI
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x36A0140", Offset = "0x369F140", VA = "0x1836A0140")]
		public static Result<TOk, FJYIIDDGAPS> COKUWTCZICO<TOk>([In] this Result<TOk, FJYIIDDGAPS> self, TBKCGNLOMPR a) where TOk : notnull
		{
			return default(Result<TOk, FJYIIDDGAPS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x36A04D0", Offset = "0x369F4D0", VA = "0x1836A04D0")]
		public static Result<a?, FJYIIDDGAPS?> PLGIRKMAKDK<a>([In] this Result<a, FJYIIDDGAPS> self)
		{
			return default(Result<a, FJYIIDDGAPS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x36A0380", Offset = "0x369F380", VA = "0x1836A0380")]
		public static Result<b?, FJYIIDDGAPS?> CTISTMCISIS<b>([In] this Result<b, FJYIIDDGAPS> self)
		{
			return default(Result<b, FJYIIDDGAPS>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface DUQMTWSATKX
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PBPQUFKUWQF([In] Result<None, TBKCGNLOMPR> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class IQFGLBZKJPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x39EF8D0", Offset = "0x39EE8D0", VA = "0x1839EF8D0")]
		public static bool PBPQUFKUWQF<TOk, TErr>(this DUQMTWSATKX a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, TBKCGNLOMPR
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface YVVNDNVNRHU
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		VBDHXKKGPBY EVGGHXOZBIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface XDGOQWUJYOU
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor ZWSKNQEFCKN(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface QVASNGNUJON
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface FIFOCXACINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZTMCJYPKMQI? UUZOXHIHFNN(Id32<MMFHTWDPFRA> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface ZAXXBVQPHNA
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface ZTMCJYPKMQI
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZAXXBVQPHNA? HAFYIWDZBWZ(Id32<VKOSYOKYXNB> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QVASNGNUJON? UBOSJETOBNO(Id32<EBKDWIFBKMY> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface QMQBHLTBDHS
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> WEMRIFHACEW(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface FTANEFSKGGW
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FIFOCXACINM? OTVTHECDBTN([In] Id128<ZOMVBRTCATC> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class SDMDNUTBPDX
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
			public readonly List<AGLENQQYPWD> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B50D00", Offset = "0x2B4FD00", VA = "0x182B50D00")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<AGLENQQYPWD> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B50C50", Offset = "0x2B4FC50", VA = "0x182B50C50")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly IUVYEGBWOJQ<Diagnostic> NQAWDBZAISP;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static SDMDNUTBPDX HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x2B52160", Offset = "0x2B51160", VA = "0x182B52160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool PFVREDOXLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xB21E00", Offset = "0xB20E00", VA = "0x180B21E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xC3C9E0", Offset = "0xC3B9E0", VA = "0x180C3C9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B521B0", Offset = "0x2B511B0", VA = "0x182B521B0")]
		public void VDNOEUFJRWW(AGDBBCFQBWL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B51E80", Offset = "0x2B50E80", VA = "0x182B51E80")]
		public void JUHNQGBTOTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B51CC0", Offset = "0x2B50CC0", VA = "0x182B51CC0")]
		private static string? DACBRAHDNDR([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B52360", Offset = "0x2B51360", VA = "0x182B52360")]
		public SDMDNUTBPDX()
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
