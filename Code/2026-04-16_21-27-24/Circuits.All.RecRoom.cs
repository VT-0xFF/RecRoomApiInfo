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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B210B0", Offset = "0x2B1FEB0", VA = "0x182B210B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1FA70", Offset = "0x2B1E870", VA = "0x182B1FA70", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LLXPXHNGEHC : IDisposable, MZISMHNRVBH, PBQCHHTXQRC, ZMGNQKODDBP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class BGPGQHFDQMD : VAEKADQIRNQ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int ZGVCEPKXULJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C780", Offset = "0x2B0B580", VA = "0x182B0C780", Slot = "5")]
			public MVPDPCIQCZK JYDVFJKURUD(CCKWHATKPBN.VAEKADQIRNQ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void BSVAKVESYQR();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void ZMWKOQLICTO();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE700", Offset = "0x2AFD500", VA = "0x182AFE700", Slot = "13")]
			public virtual void NLIDBWXTTVK(LLXPXHNGEHC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C8B0", Offset = "0x2B0B6B0", VA = "0x182B0C8B0", Slot = "14")]
			public virtual void KHNWMNPHRQR(LLXPXHNGEHC a, JGWKKBUFZYH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			protected BGPGQHFDQMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface VAEKADQIRNQ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int ZGVCEPKXULJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			MVPDPCIQCZK JYDVFJKURUD(CCKWHATKPBN.VAEKADQIRNQ a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void BSVAKVESYQR();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void ZMWKOQLICTO();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void NLIDBWXTTVK(LLXPXHNGEHC a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void KHNWMNPHRQR(LLXPXHNGEHC a, JGWKKBUFZYH b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
			internal Reducer(Reducer<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class KCUMYMULKAR : PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly KCUMYMULKAR GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KCUMYMULKAR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x151A880", Offset = "0x1519680", VA = "0x18151A880", Slot = "4")]
			public ActionKind SQJRFTPNJUV(JGWKKBUFZYH a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2B1DFC0", Offset = "0x2B1CDC0", VA = "0x182B1DFC0", Slot = "5")]
			public void NLIDBWXTTVK(LLXPXHNGEHC a, JGWKKBUFZYH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2B1DEB0", Offset = "0x2B1CCB0", VA = "0x182B1DEB0", Slot = "6")]
			public void KHNWMNPHRQR(LLXPXHNGEHC a, JGWKKBUFZYH b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2B22660", Offset = "0x2B21460", VA = "0x182B22660")]
			internal ReducerFactory(ReducerFactory<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B22610", Offset = "0x2B21410", VA = "0x182B22610")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : CACFZSSVVJB.MMQTUXUFWIF<JGWKKBUFZYH, LLXPXHNGEHC>
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
				public AsyncTaskMethodBuilder<Result<object?, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public LLXPXHNGEHC receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public JGWKKBUFZYH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B27460", Offset = "0x2B26260", VA = "0x182B27460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B27640", Offset = "0x2B26440", VA = "0x182B27640", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD4BB50", Offset = "0xD4A950", VA = "0x180D4BB50", Slot = "4")]
			public Id32<QOLQCAXXJSV> LQTXKHYZMUW(LLXPXHNGEHC a)
			{
				return default(Id32<QOLQCAXXJSV>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B26950", Offset = "0x2B25750", VA = "0x182B26950", Slot = "5")]
			public void WSSXZGTHMEZ(LLXPXHNGEHC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B26800", Offset = "0x2B25600", VA = "0x182B26800", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, KXUOEYSOWHL>> DLYYCINMCJS(LLXPXHNGEHC a, JGWKKBUFZYH b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B26930", Offset = "0x2B25730", VA = "0x182B26930", Slot = "7")]
			public JGWKKBUFZYH[] SSVOZPDPRFA(LLXPXHNGEHC a)
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
			public AsyncTaskMethodBuilder<Result<object?, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public LLXPXHNGEHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public JGWKKBUFZYH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B276B0", Offset = "0x2B264B0", VA = "0x182B276B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2B278A0", Offset = "0x2B266A0", VA = "0x182B278A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public LLXPXHNGEHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2B28DD0", Offset = "0x2B27BD0", VA = "0x182B28DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2B29050", Offset = "0x2B27E50", VA = "0x182B29050", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LLXPXHNGEHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2B290C0", Offset = "0x2B27EC0", VA = "0x182B290C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2B292A0", Offset = "0x2B280A0", VA = "0x182B292A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<QOLQCAXXJSV> BEBABPRGBRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer PYPBNUNVSHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 HRKZDGYRLPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly ADMWIPYDBOF QBJFSLHHGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly KQGIQGHQWFJ.CreationArgs PJVSRYUXWAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly SGVFZXNUYTC CMLGWDRQAMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly ASQXBOGBPNB ZPPRCZKMQMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly RQYUBWNGBFC ZHQYCNYOJUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly CKJZCISSPQR QPOCHAYMLRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly BLLRRQUGYXB DWYGRRHNCWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly MBBCHQWBJQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly OPUPGUUVVGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest PISRSGMRZNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended YRNJAWAERNM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal VAEKADQIRNQ SNMEZQIIQUR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B1E870", Offset = "0x2B1D670", VA = "0x182B1E870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal MVPDPCIQCZK EVWWFKQWMEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F050", Offset = "0x2B1DE50", VA = "0x182B1F050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1EAC0", Offset = "0x2B1D8C0", VA = "0x182B1EAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool CNIJHGRHCUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F1F0", Offset = "0x2B1DFF0", VA = "0x182B1F1F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B1EB60", Offset = "0x2B1D960", VA = "0x182B1EB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public USQINPJLSUT SGVFZXNUYTC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FA30", Offset = "0x2B1E830", VA = "0x182B1FA30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ZSLWBLIWJVX RQYUBWNGBFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FA40", Offset = "0x2B1E840", VA = "0x182B1FA40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OMCYRLAITOG BLLRRQUGYXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FA60", Offset = "0x2B1E860", VA = "0x182B1FA60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CKOFKQCSIRY ASQXBOGBPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B1E570", Offset = "0x2B1D370", VA = "0x182B1E570", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public YSFHOOMHOEO CKJZCISSPQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FA50", Offset = "0x2B1E850", VA = "0x182B1FA50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KQGIQGHQWFJ? KQGIQGHQWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B1EF70", Offset = "0x2B1DD70", VA = "0x182B1EF70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F740", Offset = "0x2B1E540", VA = "0x182B1F740")]
		private LLXPXHNGEHC(ADMWIPYDBOF a, Id32<QOLQCAXXJSV> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, MVPDPCIQCZK b, [In] KQGIQGHQWFJ.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EEA0", Offset = "0x2B1DCA0", VA = "0x182B1EEA0")]
		public static LLXPXHNGEHC New(ADMWIPYDBOF deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<QOLQCAXXJSV> actorId, Id32<KXSFMFRUWWC> rootNetworkObjectId, KVHMMDKOSSW staticNetSys, QJXQIKIKVWS dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EBE0", Offset = "0x2B1D9E0", VA = "0x182B1EBE0")]
		public static LLXPXHNGEHC New(ADMWIPYDBOF dependencies, [In] RegistryV2 registryV2, Id32<QOLQCAXXJSV> actorId, Id32<KXSFMFRUWWC> rootNetworkObjectId, KVHMMDKOSSW staticNetSys, QJXQIKIKVWS dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E690", Offset = "0x2B1D490", VA = "0x182B1E690", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E480", Offset = "0x2B1D280", VA = "0x182B1E480")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, KXUOEYSOWHL>> AAAGEPPYTYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F600", Offset = "0x2B1E400", VA = "0x182B1F600")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, KXUOEYSOWHL>> VNARPCAQJLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E8C0", Offset = "0x2B1D6C0", VA = "0x182B1E8C0")]
		internal void HDBZQQFRHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EAE0", Offset = "0x2B1D8E0", VA = "0x182B1EAE0")]
		internal Option<JGWKKBUFZYH> IQBPCRBUIBT([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<JGWKKBUFZYH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EB70", Offset = "0x2B1D970", VA = "0x182B1EB70")]
		internal bool KFNLZILUDSG([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F060", Offset = "0x2B1DE60", VA = "0x182B1F060")]
		internal Result<JGWKKBUFZYH, KXUOEYSOWHL> RNHLJGVPVMZ([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<JGWKKBUFZYH, KXUOEYSOWHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F6F0", Offset = "0x2B1E4F0", VA = "0x182B1F6F0")]
		private void WSSXZGTHMEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E580", Offset = "0x2B1D380", VA = "0x182B1E580")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, KXUOEYSOWHL>> CZTOHZTUOJL(JGWKKBUFZYH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F200", Offset = "0x2B1E000", VA = "0x182B1F200")]
		private JGWKKBUFZYH[] SSVOZPDPRFA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class XIRUCCCSVVO<a> : TDAXDIBDDUE, GHMCCVBDFQW, SEZYOHJZPUT where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<MVBOYPURKWM>? ITIGPUGICXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string KEMPFKGIOQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a PXUWVBIVPWJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<MVBOYPURKWM>? YPATAGEAPMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E060D0", Offset = "0x2E04ED0", VA = "0x182E060D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x50819A0", Offset = "0x50807A0", VA = "0x1850819A0")]
		internal XIRUCCCSVVO([In] Id128<MVBOYPURKWM>? lastNode, Id32<JLWXVUGZAYX>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ZONJHHLYMYS
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D390", Offset = "0x2B2C190", VA = "0x182B2D390")]
		public static Result<DebugExecutionResult, GHMCCVBDFQW> WHXBIACULGF([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, GHMCCVBDFQW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4121270", Offset = "0x4120070", VA = "0x184121270")]
		public static Result<TOk, GHMCCVBDFQW> VZTLDHZZWPJ<TOk>([In] this Result<TOk, GHMCCVBDFQW> self, [In] Id128<MVBOYPURKWM>? lastNode, Id32<JLWXVUGZAYX>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, GHMCCVBDFQW>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ADMWIPYDBOF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		CCKWHATKPBN.VAEKADQIRNQ YMNHPYMKYKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		LLXPXHNGEHC.VAEKADQIRNQ GVUJLRGXJNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		QMPJCTMUYTR.VAEKADQIRNQ LVRLWVTOYCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC> KCUMYMULKAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.VAEKADQIRNQ ZGPDNETMEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		XXFEIMFXUFV POIJMWMPEWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		UHFIXPZEGDI YHGIWREOJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		VILOZUKICQY VEAWHMVIPAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		BFKKVPEWDDK FYKMOQQNFCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		SULRVJJWMBY ZJJEOPUGPNL
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
	public static class IRGQYRBBCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D570", Offset = "0x2B1C370", VA = "0x182B1D570")]
		public static JGWKKBUFZYH ZWAUKJIJZTP(this JGWKKBUFZYH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D4A0", Offset = "0x2B1C2A0", VA = "0x182B1D4A0")]
		public static JGWKKBUFZYH QUHHVMPTKZU(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public LLXPXHNGEHC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B27910", Offset = "0x2B26710", VA = "0x182B27910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B28030", Offset = "0x2B26E30", VA = "0x182B28030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B10BC0", Offset = "0x2B0F9C0", VA = "0x182B10BC0")]
		public static JGWKKBUFZYH ZMGUDEPWQXJ(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B10B10", Offset = "0x2B0F910", VA = "0x182B10B10")]
		public static ReduceAction<ActionKind, CompressedPayload> ORHWXUJNYNM(JGWKKBUFZYH actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B10A00", Offset = "0x2B0F800", VA = "0x182B10A00")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, KXUOEYSOWHL>> CZTOHZTUOJL(LLXPXHNGEHC a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B118D0", Offset = "0x2B106D0", VA = "0x182B118D0")]
		public static JGWKKBUFZYH ZMGUDEPWQXJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B117E0", Offset = "0x2B105E0", VA = "0x182B117E0")]
		public static ReduceAction<ActionKind, DestroyPayload> ORHWXUJNYNM(JGWKKBUFZYH actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B11850", Offset = "0x2B10650", VA = "0x182B11850")]
		public static Result<None, GFBUJJTFVYG> OUIDBMKEHPJ(LLXPXHNGEHC a, [In] DestroyPayload self)
		{
			return default(Result<None, GFBUJJTFVYG>);
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
			public AsyncTaskMethodBuilder<Result<None, GFBUJJTFVYG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public LLXPXHNGEHC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, GFBUJJTFVYG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B28110", Offset = "0x2B26F10", VA = "0x182B28110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B286B0", Offset = "0x2B274B0", VA = "0x182B286B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F2BCE0", Offset = "0x1F2AAE0", VA = "0x181F2BCE0")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C770", Offset = "0x2B1B570", VA = "0x182B1C770")]
		public static JGWKKBUFZYH? ZMGUDEPWQXJ(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C660", Offset = "0x2B1B460", VA = "0x182B1C660")]
		public static ReduceAction<ActionKind, FullInitializePayload> ORHWXUJNYNM(JGWKKBUFZYH actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C520", Offset = "0x2B1B320", VA = "0x182B1C520")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, GFBUJJTFVYG>> CZTOHZTUOJL(LLXPXHNGEHC a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public LLXPXHNGEHC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, KXUOEYSOWHL> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, SEZYOHJZPUT>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, SEZYOHJZPUT> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, SEZYOHJZPUT>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B27BD0", Offset = "0x2B269D0", VA = "0x182B27BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B280A0", Offset = "0x2B26EA0", VA = "0x182B280A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<JGWKKBUFZYH> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private MultiPayload(IReadOnlyList<JGWKKBUFZYH> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FE50", Offset = "0x2B1EC50", VA = "0x182B1FE50")]
		public static JGWKKBUFZYH ZMGUDEPWQXJ(IReadOnlyList<JGWKKBUFZYH> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FDB0", Offset = "0x2B1EBB0", VA = "0x182B1FDB0")]
		public static ReduceAction<ActionKind, MultiPayload> ORHWXUJNYNM(JGWKKBUFZYH actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FC70", Offset = "0x2B1EA70", VA = "0x182B1FC70")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, KXUOEYSOWHL>> CZTOHZTUOJL(LLXPXHNGEHC a, MultiPayload b)
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
		private sealed class BEKRWCFQTJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> ESQMKBJEQHQ;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BEKRWCFQTJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C4B0", Offset = "0x2B0B2B0", VA = "0x182B0C4B0")]
			internal JGWKKBUFZYH DETAHQPLNLE(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2B21E20", Offset = "0x2B20C20", VA = "0x182B21E20")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B21D10", Offset = "0x2B20B10", VA = "0x182B21D10")]
		public static JGWKKBUFZYH ZMGUDEPWQXJ(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B21C10", Offset = "0x2B20A10", VA = "0x182B21C10")]
		public static JGWKKBUFZYH[] WZCEWUYMGZU(JGWKKBUFZYH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B21920", Offset = "0x2B20720", VA = "0x182B21920")]
		public static ReduceAction<ActionKind, PartialActionPayload> ORHWXUJNYNM(JGWKKBUFZYH actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B21A70", Offset = "0x2B20870", VA = "0x182B21A70")]
		public static Result<JGWKKBUFZYH, KXUOEYSOWHL> OUIDBMKEHPJ(LLXPXHNGEHC a, [In] PartialActionPayload self)
		{
			return default(Result<JGWKKBUFZYH, KXUOEYSOWHL>);
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
			public AsyncTaskMethodBuilder<Result<bool, GFBUJJTFVYG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public LLXPXHNGEHC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, GFBUJJTFVYG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, GFBUJJTFVYG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B28720", Offset = "0x2B27520", VA = "0x182B28720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B28D60", Offset = "0x2B27B60", VA = "0x182B28D60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD90730", Offset = "0xD8F530", VA = "0x180D90730")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B22250", Offset = "0x2B21050", VA = "0x182B22250")]
		public static JGWKKBUFZYH ZMGUDEPWQXJ(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B21F70", Offset = "0x2B20D70", VA = "0x182B21F70")]
		public static JGWKKBUFZYH?[]? KPUJQVBTRXG(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B22170", Offset = "0x2B20F70", VA = "0x182B22170")]
		public static ReduceAction<ActionKind, PartialInitializePayload> ORHWXUJNYNM(JGWKKBUFZYH actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B21E40", Offset = "0x2B20C40", VA = "0x182B21E40")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, GFBUJJTFVYG>> CZTOHZTUOJL(LLXPXHNGEHC a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class SGVFZXNUYTC : USQINPJLSUT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public TAFOBISEWIQ? GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B22670", Offset = "0x2B21470", VA = "0x182B22670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		internal SGVFZXNUYTC(LLXPXHNGEHC a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class DTVWGYMCAFJ : TAFOBISEWIQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly KQGIQGHQWFJ MRRWNSCAHPV;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		public DTVWGYMCAFJ(LLXPXHNGEHC a, KQGIQGHQWFJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B11230", Offset = "0x2B10030", VA = "0x182B11230", Slot = "4")]
		public Result<DebugExecutionResult, GHMCCVBDFQW> FJZVAEKIZLV(Id128<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<LMZHXZTZMKK> inputId)
		{
			return default(Result<DebugExecutionResult, GHMCCVBDFQW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C80", Offset = "0x2B0FA80", VA = "0x182B10C80", Slot = "5")]
		public Result<DebugExecutionResult, GHMCCVBDFQW> AQJPLAOHXLI(Id128<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<GSCEPPXRFGV> outputId)
		{
			return default(Result<DebugExecutionResult, GHMCCVBDFQW>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class CCKWHATKPBN : MVPDPCIQCZK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface VAEKADQIRNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<JIWOOULRLNI> HUGUCLXYAZV(LLXPXHNGEHC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void ORRSOQRQXDD(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class BGPGQHFDQMD : VAEKADQIRNQ
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
				public AsyncTaskMethodBuilder<JIWOOULRLNI> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public LLXPXHNGEHC circuitsManager;

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
				private TaskAwaiter<QMPJCTMUYTR> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2B26A10", Offset = "0x2B25810", VA = "0x182B26A10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2B26BE0", Offset = "0x2B259E0", VA = "0x182B26BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C620", Offset = "0x2B0B420", VA = "0x182B0C620", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<JIWOOULRLNI> HUGUCLXYAZV(LLXPXHNGEHC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void ORRSOQRQXDD(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			protected BGPGQHFDQMD()
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
			public AsyncTaskMethodBuilder<JIWOOULRLNI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CCKWHATKPBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B26C50", Offset = "0x2B25A50", VA = "0x182B26C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B26E50", Offset = "0x2B25C50", VA = "0x182B26E50", Slot = "5")]
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
			public CCKWHATKPBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public LLXPXHNGEHC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<JIWOOULRLNI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B26EC0", Offset = "0x2B25CC0", VA = "0x182B26EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B27400", Offset = "0x2B26200", VA = "0x182B27400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly VAEKADQIRNQ BJEOXILCYDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> QUCRTRRCLNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> HRXXOCLFTFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource AYWZYDEKTME;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool CNIJHGRHCUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD44660", Offset = "0xD43460", VA = "0x180D44660", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD44D80", Offset = "0xD43B80", VA = "0x180D44D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF3F420", Offset = "0xF3E220", VA = "0x180F3F420", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xF84480", Offset = "0xF83280", VA = "0x180F84480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool QLHELGWWZMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3790", Offset = "0x1AB2590", VA = "0x181AB3790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1B080C0", Offset = "0x1B06EC0", VA = "0x181B080C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public JIWOOULRLNI? GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B50", Offset = "0xCE6950", VA = "0x180CE7B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ECC0", Offset = "0x2B0DAC0", VA = "0x182B0ECC0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<JIWOOULRLNI> YUTABFJSTLS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EDB0", Offset = "0x2B0DBB0", VA = "0x182B0EDB0")]
		public CCKWHATKPBN(VAEKADQIRNQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EB80", Offset = "0x2B0D980", VA = "0x182B0EB80", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task QYUMOCPMOJP(LLXPXHNGEHC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EA10", Offset = "0x2B0D810", VA = "0x182B0EA10", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class UMVSLNEDARM : GPJUCJNGRTH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly FWCMWMNGSOA FPZHKGQYKZZ;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public UMVSLNEDARM(FWCMWMNGSOA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class MNMHBKFVMHX
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class HATQIUZKJWV<a> : VECMIZPXZIC where a : LBBVNSEAAOY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a OUYPENSYRDY;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? ZJWZXNTXSDG
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xEE69F0", Offset = "0xEE57F0", VA = "0x180EE69F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<MVBOYPURKWM>? UAWLJAYMMGY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x6455A20", Offset = "0x6454820", VA = "0x186455A20", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<VFKNGTPUEMY> GVZZKOSKQLI
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2E07900", Offset = "0x2E06700", VA = "0x182E07900", Slot = "5")]
				get
				{
					return default(Id32<VFKNGTPUEMY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<VFKNGTPUEMY>? KTPCWYKTBXU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6455AD0", Offset = "0x64548D0", VA = "0x186455AD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
			public HATQIUZKJWV(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class GOEANLWLORL : HATQIUZKJWV<ZJWEQLATCYB>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? ZJWZXNTXSDG
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x1033340", Offset = "0x1032140", VA = "0x181033340", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C870", Offset = "0x2B1B670", VA = "0x182B1C870")]
			public GOEANLWLORL(ZJWEQLATCYB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FAF0", Offset = "0x2B1E8F0", VA = "0x182B1FAF0")]
		public static VECMIZPXZIC New(LBBVNSEAAOY graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class SUTBLLTSGFX : ASFIUQEBYGU, MNOVJCUCTWS, EJMDVNERXCJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class YQFWVSBGPST
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
				public YQFWVSBGPST <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public XXFEIMFXUFV errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A4A0", Offset = "0x2B292A0", VA = "0x182B2A4A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A710", Offset = "0x2B29510", VA = "0x182B2A710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public SUTBLLTSGFX XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool KDKILMVHHVA;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YQFWVSBGPST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D2A0", Offset = "0x2B2C0A0", VA = "0x182B2D2A0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task QXOENXMJQHF(XXFEIMFXUFV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class NRXDWRITMNV
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
				public NRXDWRITMNV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A770", Offset = "0x2B29570", VA = "0x182B2A770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AA50", Offset = "0x2B29850", VA = "0x182B2AA50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public SUTBLLTSGFX XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int KDKILMVHHVA;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public NRXDWRITMNV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B20FE0", Offset = "0x2B1FDE0", VA = "0x182B20FE0")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task JZNOHWFQGFP(XXFEIMFXUFV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class IYQMCZATMGK
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
				public IYQMCZATMGK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AFC0", Offset = "0x2B29DC0", VA = "0x182B2AFC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B470", Offset = "0x2B2A270", VA = "0x182B2B470", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string KDKILMVHHVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public SUTBLLTSGFX XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int DLDMLULUPMG;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public IYQMCZATMGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D680", Offset = "0x2B1C480", VA = "0x182B1D680")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task RATEVMUCICP(XXFEIMFXUFV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class EFEPWUJFGHT
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
				public EFEPWUJFGHT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AAB0", Offset = "0x2B298B0", VA = "0x182B2AAB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B2AF60", Offset = "0x2B29D60", VA = "0x182B2AF60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string KDKILMVHHVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public SUTBLLTSGFX XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int DLDMLULUPMG;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EFEPWUJFGHT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B11970", Offset = "0x2B10770", VA = "0x182B11970")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task JFMXJRCIQID(XXFEIMFXUFV a)
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
			public SUTBLLTSGFX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2B29310", Offset = "0x2B28110", VA = "0x182B29310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B29810", Offset = "0x2B28610", VA = "0x182B29810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly WAEZPDCZVBS JCDDXSATERU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<CLNUDLJMWUS> BOKHMMDZXAT;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private ADMWIPYDBOF BGPGQHFDQMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B24400", Offset = "0x2B23200", VA = "0x182B24400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<LMZHXZTZMKK> XYBDNVTIGFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE00A00", Offset = "0xDFF800", VA = "0x180E00A00", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<LMZHXZTZMKK>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xEE6DF0", Offset = "0xEE5BF0", VA = "0x180EE6DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<KKVGGBONUEH> IYZYSZJJSNR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AA72D0", Offset = "0x2AA60D0", VA = "0x182AA72D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<QLUJOYTGVHG> SQQEXMDFGWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1287B00", Offset = "0x1286900", VA = "0x181287B00", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QLUJOYTGVHG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<JLWXVUGZAYX> RNAIGZXNMVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B25680", Offset = "0x2B24480", VA = "0x182B25680", Slot = "22")]
			get
			{
				return default(Id32<JLWXVUGZAYX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool JRQSLTBFMRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B25E00", Offset = "0x2B24C00", VA = "0x182B25E00", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B265E0", Offset = "0x2B253E0", VA = "0x182B265E0")]
		private SUTBLLTSGFX(LLXPXHNGEHC a, RHNNOHYQJTP b, WAEZPDCZVBS c, Id32<JZROSXUIZUS> portGroupId, Id32<LMZHXZTZMKK> inputId, Id32<KKVGGBONUEH> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B24DD0", Offset = "0x2B23BD0", VA = "0x182B24DD0")]
		public static SUTBLLTSGFX New(LLXPXHNGEHC circuitsManager, RHNNOHYQJTP node, WAEZPDCZVBS input, Id32<JZROSXUIZUS> portGroupId, Id32<KKVGGBONUEH> inputDefId, Id32<LMZHXZTZMKK> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B24360", Offset = "0x2B23160", VA = "0x182B24360", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B22A20", Offset = "0x2B21820", VA = "0x182B22A20", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B25990", Offset = "0x2B24790", VA = "0x182B25990", Slot = "32")]
		public void SNWKJXRKPVG(CLNUDLJMWUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B23FA0", Offset = "0x2B22DA0", VA = "0x182B23FA0", Slot = "29")]
		public void ISFWJVMUCQP(UIHJAJFOYHY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B22AC0", Offset = "0x2B218C0", VA = "0x182B22AC0", Slot = "30")]
		public void EKGLSWLZJCK(LONNGXTNMIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B247A0", Offset = "0x2B235A0", VA = "0x182B247A0", Slot = "25")]
		protected override void MPTMCGDYLPK(LLHGVIFHYRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B23E30", Offset = "0x2B22C30", VA = "0x182B23E30", Slot = "34")]
		public string GWTRMUMRKJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B256D0", Offset = "0x2B244D0", VA = "0x182B256D0", Slot = "31")]
		public string SBOYYZIBQHN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B25FF0", Offset = "0x2B24DF0", VA = "0x182B25FF0")]
		private void XAXHJDJQVXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B24D10", Offset = "0x2B23B10", VA = "0x182B24D10", Slot = "33")]
		public void NBUPVTAAEQD(CLNUDLJMWUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B245E0", Offset = "0x2B233E0", VA = "0x182B245E0")]
		private void MDYPUPRWFXC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B22770", Offset = "0x2B21570", VA = "0x182B22770", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task AUDXKHAOERO(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B23B20", Offset = "0x2B22920", VA = "0x182B23B20")]
		public void GFDNPUCMPRT(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B22880", Offset = "0x2B21680", VA = "0x182B22880")]
		private void CZIQQVJXWUZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B24420", Offset = "0x2B23220", VA = "0x182B24420")]
		private void LEHUOMURHUN(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B23C70", Offset = "0x2B22A70", VA = "0x182B23C70")]
		private void GMIFRYLSSVY(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B25170", Offset = "0x2B23F70", VA = "0x182B25170")]
		private string OCDSUVQLTJD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B25E80", Offset = "0x2B24C80", VA = "0x182B25E80")]
		private string WHSTVXENKDK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xEE6DF0", Offset = "0xEE5BF0", VA = "0x180EE6DF0")]
		internal void XAZUZSRHQOL(Id32<LMZHXZTZMKK> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B254F0", Offset = "0x2B242F0", VA = "0x182B254F0")]
		[CompilerGenerated]
		private void PBLMVAYCAYU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B25500", Offset = "0x2B24300", VA = "0x182B25500")]
		[CompilerGenerated]
		private bool PBQTSHRZKKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B255C0", Offset = "0x2B243C0", VA = "0x182B255C0")]
		[CompilerGenerated]
		private bool PCBHMVFUDGV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B24B70", Offset = "0x2B23970", VA = "0x182B24B70")]
		[CompilerGenerated]
		private int PAQLFZWMPFK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B25390", Offset = "0x2B24190", VA = "0x182B25390")]
		[CompilerGenerated]
		private bool PAVSDGQJYQT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B25420", Offset = "0x2B24220", VA = "0x182B25420")]
		[CompilerGenerated]
		private void PBAZANKHICC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B25430", Offset = "0x2B24230", VA = "0x182B25430")]
		[CompilerGenerated]
		private bool PBGFXUEERNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B252B0", Offset = "0x2B240B0", VA = "0x182B252B0")]
		[CompilerGenerated]
		private bool OZVJQYUXDMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B25300", Offset = "0x2B24100", VA = "0x182B25300")]
		[CompilerGenerated]
		private bool PAAQOFOUMXJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B24B70", Offset = "0x2B23970", VA = "0x182B24B70")]
		[CompilerGenerated]
		private int MRZOBHTXYJD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B24AA0", Offset = "0x2B238A0", VA = "0x182B24AA0")]
		[CompilerGenerated]
		private bool MRUHEBAAOXU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B24A40", Offset = "0x2B23840", VA = "0x182B24A40")]
		[CompilerGenerated]
		private object MRPAGUGDFML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B249E0", Offset = "0x2B237E0", VA = "0x182B249E0")]
		[CompilerGenerated]
		private void MRJTJNMFWBC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B24910", Offset = "0x2B23710", VA = "0x182B24910")]
		[CompilerGenerated]
		private bool MQZFOZYLDEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B24890", Offset = "0x2B23690", VA = "0x182B24890")]
		[CompilerGenerated]
		private string MQTYRTENTTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B24880", Offset = "0x2B23680", VA = "0x182B24880")]
		[CompilerGenerated]
		private void MQORUMKQKHS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B24C40", Offset = "0x2B23A40", VA = "0x182B24C40")]
		[CompilerGenerated]
		private bool MTPRFJXCVVX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B24BC0", Offset = "0x2B239C0", VA = "0x182B24BC0")]
		[CompilerGenerated]
		private string MTKKIDDFMKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B00", Offset = "0x2B24900", VA = "0x182B25B00")]
		[CompilerGenerated]
		private void SSSUMSDACFE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B10", Offset = "0x2B24910", VA = "0x182B25B10")]
		[CompilerGenerated]
		private bool SSYBJYWXLQN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B25A70", Offset = "0x2B24870", VA = "0x182B25A70")]
		[CompilerGenerated]
		private string SSIGSEPFJIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B25AF0", Offset = "0x2B248F0", VA = "0x182B25AF0")]
		[CompilerGenerated]
		private void SSNNPLJCSTV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B25CC0", Offset = "0x2B24AC0", VA = "0x182B25CC0")]
		[CompilerGenerated]
		private bool STNWBTEPNYO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B25D90", Offset = "0x2B24B90", VA = "0x182B25D90")]
		[CompilerGenerated]
		private string STTCYZYMXJX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B25BE0", Offset = "0x2B249E0", VA = "0x182B25BE0")]
		[CompilerGenerated]
		private void STDIHFQUVBW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B25BF0", Offset = "0x2B249F0", VA = "0x182B25BF0")]
		[CompilerGenerated]
		private bool STIPEMKSENF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B259F0", Offset = "0x2B247F0", VA = "0x182B259F0")]
		[CompilerGenerated]
		private string SRCRIPZVESK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B25A60", Offset = "0x2B24860", VA = "0x182B25A60")]
		[CompilerGenerated]
		private void SRHYFWTSODT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B26430", Offset = "0x2B25230", VA = "0x182B26430")]
		[CompilerGenerated]
		private bool ZTJZLKLCRXN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B263C0", Offset = "0x2B251C0", VA = "0x182B263C0")]
		[CompilerGenerated]
		private string ZTESODRFIME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B265D0", Offset = "0x2B253D0", VA = "0x182B265D0")]
		[CompilerGenerated]
		private void ZTUNFXYXKUF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B26500", Offset = "0x2B25300", VA = "0x182B26500")]
		[CompilerGenerated]
		private bool ZTPGIRFABIW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B26220", Offset = "0x2B25020", VA = "0x182B26220")]
		[CompilerGenerated]
		private string ZSOXWJJNGED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B26210", Offset = "0x2B25010", VA = "0x182B26210")]
		[CompilerGenerated]
		private void ZSJQZCPPWSU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B262F0", Offset = "0x2B250F0", VA = "0x182B262F0")]
		[CompilerGenerated]
		private bool ZSZLQWXHZAV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B26290", Offset = "0x2B25090", VA = "0x182B26290")]
		[CompilerGenerated]
		private object ZSUETQDKPPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B249E0", Offset = "0x2B237E0", VA = "0x182B249E0")]
		[CompilerGenerated]
		private void ZRTWHIHXUKT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B23A50", Offset = "0x2B22850", VA = "0x182B23A50")]
		[CompilerGenerated]
		private bool EVCALKREZQU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class CPWOWIJGIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class QKRZGQVWUBV : KBJUJVKWDYX<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public QKRZGQVWUBV XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C0A0", Offset = "0x2B0AEA0", VA = "0x182B0C0A0")]
				internal object THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x2B0BBB0", Offset = "0x2B0A9B0", VA = "0x182B0BBB0")]
				internal void THULNZWJZKW(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2B225A0", Offset = "0x2B213A0", VA = "0x182B225A0")]
			public QKRZGQVWUBV(LLXPXHNGEHC a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x2B22330", Offset = "0x2B21130", VA = "0x182B22330", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class PPFCEXCJUDU : ICXTCJVNTCM<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType TDVSUGBFLAX
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2B218C0", Offset = "0x2B206C0", VA = "0x182B218C0")]
			public PPFCEXCJUDU(LLXPXHNGEHC a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class HRITWCEGDKI : KBJUJVKWDYX<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2B1CC90", Offset = "0x2B1BA90", VA = "0x182B1CC90")]
			public HRITWCEGDKI(LLXPXHNGEHC a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C9B0", Offset = "0x2B1B7B0", VA = "0x182B1C9B0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2B1CC40", Offset = "0x2B1BA40", VA = "0x182B1CC40")]
			[CompilerGenerated]
			private bool LUCKHMVUYSN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2B1CB10", Offset = "0x2B1B910", VA = "0x182B1CB10")]
			[CompilerGenerated]
			private void LTXDKGBXPHE(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class BHVSAMZDFSI : KBJUJVKWDYX<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public BHVSAMZDFSI XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C000", Offset = "0x2B0AE00", VA = "0x182B0C000")]
				internal void THZSLGQHIWF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2B0BB60", Offset = "0x2B0A960", VA = "0x182B0BB60")]
				internal bool THULNZWJZKW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B970", Offset = "0x2B0A770", VA = "0x182B0B970")]
				internal bool THPEQTCMPZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B7F0", Offset = "0x2B0A5F0", VA = "0x182B0B7F0")]
				internal void THJXTMIPGOE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C3F0", Offset = "0x2B0B1F0", VA = "0x182B0C3F0")]
				internal bool TIUUAHRWUPP()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2B0CC40", Offset = "0x2B0BA40", VA = "0x182B0CC40")]
			public BHVSAMZDFSI(LLXPXHNGEHC a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C930", Offset = "0x2B0B730", VA = "0x182B0C930", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class JEMXMHCYRQU : KBJUJVKWDYX<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public JEMXMHCYRQU XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> EPVAUNZHLTH;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C100", Offset = "0x2B0AF00", VA = "0x182B0C100")]
				internal object? THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C1F0", Offset = "0x2B0AFF0", VA = "0x182B0C1F0")]
				internal bool TIEZINKESHO(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2B0BC80", Offset = "0x2B0AA80", VA = "0x182B0BC80")]
				internal void THULNZWJZKW(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2B0BA10", Offset = "0x2B0A810", VA = "0x182B0BA10")]
				internal string THPEQTCMPZN(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B920", Offset = "0x2B0A720", VA = "0x182B0B920")]
				internal IReadOnlyList<object> THJXTMIPGOE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C440", Offset = "0x2B0B240", VA = "0x182B0C440")]
				internal bool TIUUAHRWUPP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C3A0", Offset = "0x2B0B1A0", VA = "0x182B0C3A0")]
				internal bool TIPNDAXZLEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C270", Offset = "0x2B0B070", VA = "0x182B0C270")]
				internal void TIKGFUECBSX(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2B1DE40", Offset = "0x2B1CC40", VA = "0x182B1DE40")]
			public JEMXMHCYRQU(LLXPXHNGEHC a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D750", Offset = "0x2B1C550", VA = "0x182B1D750", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class HXQVDFQDXFV : KBJUJVKWDYX<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public HXQVDFQDXFV XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2B0C050", Offset = "0x2B0AE50", VA = "0x182B0C050")]
				internal bool THZSLGQHIWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x2B0BED0", Offset = "0x2B0ACD0", VA = "0x182B0BED0")]
				internal void THULNZWJZKW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B9C0", Offset = "0x2B0A7C0", VA = "0x182B0B9C0")]
				internal bool THPEQTCMPZN()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2B1CF10", Offset = "0x2B1BD10", VA = "0x182B1CF10")]
			public HXQVDFQDXFV(LLXPXHNGEHC a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2B1CD00", Offset = "0x2B1BB00", VA = "0x182B1CD00", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class NAORMXLEQGM : KBJUJVKWDYX<UFHMYXISLWR>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class WYUZZVKPLDI
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
					public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public WYUZZVKPLDI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<PUDUKHYUWDI>, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2B29C50", Offset = "0x2B28A50", VA = "0x182B29C50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2B2A030", Offset = "0x2B28E30", VA = "0x182B2A030", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public WYUZZVKPLDI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x2B2A0A0", Offset = "0x2B28EA0", VA = "0x182B2A0A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x2B2A430", Offset = "0x2B29230", VA = "0x182B2A430", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task HWNZSSJKLRE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string EXXMHWXZZGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public WTNZWELDSYY.OYANJREGTWC EENLUMHIPIR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool FGLFMCUOEPX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public NAORMXLEQGM XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public WTNZWELDSYY HZRHTRQMOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action LFJRMTSOLHH;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public WYUZZVKPLDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2D270", Offset = "0x2B2C070", VA = "0x182B2D270")]
				internal bool SLVPSLYIIRF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				internal string CMZKTVDYIJG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CDB0", Offset = "0x2B2BBB0", VA = "0x182B2CDB0")]
				internal void CNPFLPLQKRH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CD60", Offset = "0x2B2BB60", VA = "0x182B2CD60")]
				internal void CNJYOIRTBFY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x16056D0", Offset = "0x16044D0", VA = "0x1816056D0")]
				internal bool CNZTGCZLDNZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CE30", Offset = "0x2B2BC30", VA = "0x182B2CE30")]
				internal void CNUMIWFNUCQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2B2D050", Offset = "0x2B2BE50", VA = "0x182B2D050")]
				internal bool COKHAQNFWKR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x2B2D180", Offset = "0x2B2BF80", VA = "0x182B2D180")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, KXUOEYSOWHL>> ROILKEYLDBB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x2B2D090", Offset = "0x2B2BE90", VA = "0x182B2D090")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, KXUOEYSOWHL>> PVBHDXRAVAI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class UACGPVXXMUQ
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
					public AsyncTaskMethodBuilder<Result<Id32<PUDUKHYUWDI>, KXUOEYSOWHL>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<PUDUKHYUWDI>, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x2B29870", Offset = "0x2B28670", VA = "0x182B29870", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x2B29BE0", Offset = "0x2B289E0", VA = "0x182B29BE0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public NAORMXLEQGM XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public DDEDPKRJVXM POIWVRYXJTZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool RZMGYAFRHVB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public WTNZWELDSYY HZRHTRQMOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public OJZPKGWLZJE YVUUOKCIHEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action ERQKVWWJSRK;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public UACGPVXXMUQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C7A0", Offset = "0x2B2B5A0", VA = "0x182B2C7A0")]
				internal object? THULNZWJZKW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C6B0", Offset = "0x2B2B4B0", VA = "0x182B2C6B0")]
				internal void THPEQTCMPZN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C5C0", Offset = "0x2B2B3C0", VA = "0x182B2C5C0")]
				internal string THJXTMIPGOE(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CAA0", Offset = "0x2B2B8A0", VA = "0x182B2CAA0")]
				internal IReadOnlyList<object> TIUUAHRWUPP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C940", Offset = "0x2B2B740", VA = "0x182B2C940")]
				internal void TIPNDAXZLEG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C8D0", Offset = "0x2B2B6D0", VA = "0x182B2C8D0")]
				internal bool TIKGFUECBSX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C810", Offset = "0x2B2B610", VA = "0x182B2C810")]
				internal void TIEZINKESHO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CBC0", Offset = "0x2B2B9C0", VA = "0x182B2CBC0")]
				internal void TJPVPITMGIZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CB40", Offset = "0x2B2B940", VA = "0x182B2CB40")]
				internal void TJKOSBZOWXQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x2B2C560", Offset = "0x2B2B360", VA = "0x182B2C560")]
				internal bool GORNIMMSAOG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x2B2CC10", Offset = "0x2B2BA10", VA = "0x182B2CC10")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<PUDUKHYUWDI>, KXUOEYSOWHL>> UFHLGWPZZIK()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<VFKNGTPUEMY>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x2B20FA0", Offset = "0x2B1FDA0", VA = "0x182B20FA0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2B20F30", Offset = "0x2B1FD30", VA = "0x182B20F30")]
			public NAORMXLEQGM(LLXPXHNGEHC a, UFHMYXISLWR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FF10", Offset = "0x2B1ED10", VA = "0x182B1FF10", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2B208A0", Offset = "0x2B1F6A0", VA = "0x182B208A0")]
			private void ENZOUTABAIZ(WTNZWELDSYY a, Id32<PUDUKHYUWDI>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class VEOZCBGBLCF : OTWRLMXKIIM<TNNURYQFADI>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1F3F8A0", Offset = "0x1F3E6A0", VA = "0x181F3F8A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool XWLPBXQPTPG
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool FRXTGGISQVN
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool QKCULOTJARE
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2B2CD00", Offset = "0x2B2BB00", VA = "0x182B2CD00")]
			public VEOZCBGBLCF(LLXPXHNGEHC a, TNNURYQFADI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class DHPGNARRYIZ<a> : KBJUJVKWDYX<a> where a : notnull, DQNDWDLEFEL
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
				public AsyncTaskMethodBuilder<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public DHPGNARRYIZ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x64AF1D0", Offset = "0x64ADFD0", VA = "0x1864AF1D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x64AF520", Offset = "0x64AE320", VA = "0x1864AF520", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public DHPGNARRYIZ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<JZROSXUIZUS> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6AAA860", Offset = "0x6AA9660", VA = "0x186AAA860", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x6AAABB0", Offset = "0x6AA99B0", VA = "0x186AAABB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<JZROSXUIZUS>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x532E4B0", Offset = "0x532D2B0", VA = "0x18532E4B0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x532E480", Offset = "0x532D280", VA = "0x18532E480")]
			protected DHPGNARRYIZ(LLXPXHNGEHC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x532E110", Offset = "0x532CF10", VA = "0x18532E110", Slot = "122")]
			[AsyncStateMachine(typeof(DHPGNARRYIZ<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> MHPCPSFSVBE(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x532E3E0", Offset = "0x532D1E0", VA = "0x18532E3E0", Slot = "149")]
			public sealed override bool ZULHNUQVRVV(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x532E340", Offset = "0x532D140", VA = "0x18532E340", Slot = "134")]
			protected sealed override bool YEVCODTPDUJ(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x532E070", Offset = "0x532CE70", VA = "0x18532E070", Slot = "135")]
			protected override bool FHONXKGWKOW(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x532E230", Offset = "0x532D030", VA = "0x18532E230", Slot = "123")]
			[AsyncStateMachine(typeof(DHPGNARRYIZ<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, KXUOEYSOWHL>> MMMZDJENDIJ(Id32<JZROSXUIZUS> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class HYRGUEDXJMM : QUKBOKSTSIL<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public HYRGUEDXJMM XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B5A0", Offset = "0x2B0A3A0", VA = "0x182B0B5A0")]
				internal bool HWQXIQNOGGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B740", Offset = "0x2B0A540", VA = "0x182B0B740")]
				internal void HWWEFXHLPRR(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D1C0", Offset = "0x2B1BFC0", VA = "0x182B1D1C0")]
			public HYRGUEDXJMM(LLXPXHNGEHC a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2B1CF80", Offset = "0x2B1BD80", VA = "0x182B1CF80", Slot = "151")]
			protected override void GTLEJOLGLKI(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class PILTHYBETYV : KBJUJVKWDYX<UEMJAGSVBJM>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class FXRJPUNQTQT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int YKXFLXLNGIA;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FXRJPUNQTQT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C4E0", Offset = "0x2B1B2E0", VA = "0x182B1C4E0")]
				internal bool RBBIXRGJHXS(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class KRDFVZFEZPK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public PILTHYBETYV XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> NKLQCVSYRBY;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KRDFVZFEZPK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E3E0", Offset = "0x2B1D1E0", VA = "0x182B1E3E0")]
				internal int THZSLGQHIWF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E2C0", Offset = "0x2B1D0C0", VA = "0x182B1E2C0")]
				internal void THULNZWJZKW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E210", Offset = "0x2B1D010", VA = "0x182B1E210")]
				internal string? THPEQTCMPZN()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2B21850", Offset = "0x2B20650", VA = "0x182B21850")]
			public PILTHYBETYV(LLXPXHNGEHC a, UEMJAGSVBJM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2B21350", Offset = "0x2B20150", VA = "0x182B21350")]
			private int AIHRCXIQKLI(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2B21730", Offset = "0x2B20530", VA = "0x182B21730")]
			private void PDDYOZIFCIA(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2B213E0", Offset = "0x2B201E0", VA = "0x182B213E0", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class TOILDUPYCYL : OTWRLMXKIIM<JPCAWOKTYNW>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2B269B0", Offset = "0x2B257B0", VA = "0x182B269B0")]
			public TOILDUPYCYL(LLXPXHNGEHC a, JPCAWOKTYNW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class OTWRLMXKIIM<a> : KBJUJVKWDYX<a> where a : notnull, KIQVWXHSFVK
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class RYQFGLCIRJK
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
					public RYQFGLCIRJK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x41A9F10", Offset = "0x41A8D10", VA = "0x1841A9F10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public WTNZWELDSYY HZRHTRQMOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public OTWRLMXKIIM<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action EPPTXHFKCHY;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public RYQFGLCIRJK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x7652F60", Offset = "0x7651D60", VA = "0x187652F60")]
				internal void THZSLGQHIWF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x7653230", Offset = "0x7652030", VA = "0x187653230")]
				[AsyncStateMachine(typeof(OTWRLMXKIIM<>.RYQFGLCIRJK.<<BuildConfigMenuInternal>b__6>d))]
				internal void TIKGFUECBSX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x7652BC0", Offset = "0x76519C0", VA = "0x187652BC0")]
				internal bool THULNZWJZKW()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class RYVMDRWGAUT
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
					public RYVMDRWGAUT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x41A9740", Offset = "0x41A8540", VA = "0x1841A9740", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string DRVPNDNLNAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public RYQFGLCIRJK DODNVPQZHNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> EQQCJPAWXMR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> EPFGCTRPJLG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action EPKNAALMSWP;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public RYVMDRWGAUT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x76532D0", Offset = "0x76520D0", VA = "0x1876532D0")]
				internal void THPEQTCMPZN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				internal string THJXTMIPGOE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				internal void TIUUAHRWUPP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x7653630", Offset = "0x7652430", VA = "0x187653630")]
				[AsyncStateMachine(typeof(OTWRLMXKIIM<>.RYVMDRWGAUT.<<BuildConfigMenuInternal>b__5>d))]
				internal void TIPNDAXZLEG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class EZRPNFOJXLL
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
					public EZRPNFOJXLL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<ECXPGDQVCNG>, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x41A6EE0", Offset = "0x41A5CE0", VA = "0x1841A6EE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public EZRPNFOJXLL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x41A7620", Offset = "0x41A6420", VA = "0x1841A7620", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public EZRPNFOJXLL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<KKVGGBONUEH>, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x41A7800", Offset = "0x41A6600", VA = "0x1841A7800", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public OTWRLMXKIIM<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<JZROSXUIZUS> COIOZZGOOBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public WTNZWELDSYY HZRHTRQMOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public GQSGWEUJXVS RWZXODHJQLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int NBSTGBIVWRE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int KXQTQICIHWY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public WIBHTRDJIRP FXFGGQLVQGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string OZJUIMWBQKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<DUQUSUOTFQH> GQEKVRDWSNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public WIBHTRDJIRP FURZQFNJXLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string IBGFMGKTYDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<DUQUSUOTFQH> OJBVRHYUTXX;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public EZRPNFOJXLL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x5B666C0", Offset = "0x5B654C0", VA = "0x185B666C0")]
				internal bool RDJTPGHVDZK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x5B66730", Offset = "0x5B65530", VA = "0x185B66730")]
				internal void RDPAMNBSNKT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5B66310", Offset = "0x5B65110", VA = "0x185B66310")]
				internal bool BUHDRSYIARO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5B667A0", Offset = "0x5B655A0", VA = "0x185B667A0")]
				[AsyncStateMachine(typeof(OTWRLMXKIIM<>.EZRPNFOJXLL.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void RDUHJTVPWWC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x5B66840", Offset = "0x5B65640", VA = "0x185B66840")]
				internal bool RDZOHAPNGHL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x5B66450", Offset = "0x5B65250", VA = "0x185B66450")]
				internal void BVCFGTZXMKY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x5B66260", Offset = "0x5B65060", VA = "0x185B66260")]
				internal bool BTGVFLCVFMV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x5B66180", Offset = "0x5B64F80", VA = "0x185B66180")]
				internal void BTBOIEIXWBM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x5B66530", Offset = "0x5B65330", VA = "0x185B66530")]
				internal bool IVODIFOCSRY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x5B66880", Offset = "0x5B65680", VA = "0x185B66880")]
				internal bool REEVEHJKPSU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x5B668F0", Offset = "0x5B656F0", VA = "0x185B668F0")]
				internal void REKCBODHZED(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x5B66960", Offset = "0x5B65760", VA = "0x185B66960")]
				[AsyncStateMachine(typeof(OTWRLMXKIIM<>.EZRPNFOJXLL.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void REPIYUXFIPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x5B66A00", Offset = "0x5B65800", VA = "0x185B66A00")]
				internal bool REUPWBRCSAV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x5B665E0", Offset = "0x5B653E0", VA = "0x185B665E0")]
				internal bool RBTQLEEQGMQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x5B66650", Offset = "0x5B65450", VA = "0x185B66650")]
				internal void RBYXIKYNPXZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x5B663B0", Offset = "0x5B651B0", VA = "0x185B663B0")]
				[AsyncStateMachine(typeof(OTWRLMXKIIM<>.EZRPNFOJXLL.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void BUWYJNGACZP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x5B66350", Offset = "0x5B65150", VA = "0x185B66350")]
				internal bool BURRMGMCTOG()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class EZMIPYUMOAC
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
					public EZMIPYUMOAC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x41A71D0", Offset = "0x41A5FD0", VA = "0x1841A71D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string AUPZFZULOTI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public EZRPNFOJXLL DODNVPQZHNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> FPSKJECSJSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> FPNDLXIVAHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action FPHWOQOXQWH;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public EZMIPYUMOAC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x5B592F0", Offset = "0x5B580F0", VA = "0x185B592F0")]
				internal void BUMKOZSFKCX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				internal string BVRZYOHPOSZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				internal void BVMTBHNSFHQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x5B59650", Offset = "0x5B58450", VA = "0x185B59650")]
				[AsyncStateMachine(typeof(OTWRLMXKIIM<>.EZMIPYUMOAC.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void BVHMEATUVWH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class RVBWMXFBDZU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool GQEKVRDWSNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public GQSGWEUJXVS RWZXODHJQLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<DUQUSUOTFQH> VDTIEFMROOB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public OTWRLMXKIIM<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<JZROSXUIZUS> COIOZZGOOBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int LLARUDTJPFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> EQFOPBNCEPZ;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public RVBWMXFBDZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x76522E0", Offset = "0x76510E0", VA = "0x1876522E0")]
				internal bool NVURJPXATAM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class RVHDKDYYNLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public EJMDVNERXCJ VEJYIQANHKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public RVBWMXFBDZU DODNVPQZHNM;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public RVHDKDYYNLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x7652390", Offset = "0x7651190", VA = "0x187652390")]
				internal void NWKMBKESVIN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7652340", Offset = "0x7651140", VA = "0x187652340")]
				internal bool NWFFEDKVLXE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x7652560", Offset = "0x7651360", VA = "0x187652560")]
				internal void NWUZVXSNOFF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x7652500", Offset = "0x7651300", VA = "0x187652500")]
				internal bool NWPSYQYQETW()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class RURISJRGLDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public DUQUSUOTFQH NEKNFQIHEPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public RVHDKDYYNLD DNYGYIXBYCD;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public RURISJRGLDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x76520B0", Offset = "0x7650EB0", VA = "0x1876520B0")]
				internal void NVZYGWQYCLV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class WMLYSDTPQWD
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
					public WMLYSDTPQWD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x41AA9C0", Offset = "0x41A97C0", VA = "0x1841AA9C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> CBODZEGEBQA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public WIBHTRDJIRP NSSILIPJZYE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool GQEKVRDWSNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public GQSGWEUJXVS RWZXODHJQLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public EJMDVNERXCJ VEJYIQANHKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string AUPZFZULOTI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public WMLYSDTPQWD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x85ACF60", Offset = "0x85ABD60", VA = "0x1885ACF60")]
				internal int HRQCKXFVQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x85ACD00", Offset = "0x85ABB00", VA = "0x1885ACD00")]
				internal void HRKVNQLYGQU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
				internal string HSAQFKTQIYV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x85ACFA0", Offset = "0x85ABDA0", VA = "0x1885ACFA0")]
				[AsyncStateMachine(typeof(OTWRLMXKIIM<>.WMLYSDTPQWD.<<CreatePortItemV2>b__3>d))]
				internal void HRVJIDZSZNM(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public OTWRLMXKIIM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x64AEDB0", Offset = "0x64ADBB0", VA = "0x1864AEDB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x64AF160", Offset = "0x64ADF60", VA = "0x1864AF160", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public OTWRLMXKIIM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<JZROSXUIZUS> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x6AAAC20", Offset = "0x6AA9A20", VA = "0x186AAAC20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x6AAAFB0", Offset = "0x6AA9DB0", VA = "0x186AAAFB0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public OTWRLMXKIIM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x6B33B90", Offset = "0x6B32990", VA = "0x186B33B90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x6B34130", Offset = "0x6B32F30", VA = "0x186B34130", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<JZROSXUIZUS>, bool> FSGQRJWITOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<JZROSXUIZUS>, bool> QYTBMTCXYKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<JZROSXUIZUS>, bool> RBOBTHKUMCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<JZROSXUIZUS>, bool> FXMGIJLRDDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<JZROSXUIZUS>, bool> XWRQVEDUNYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<JZROSXUIZUS>, bool> WFPQVHLYCLF;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool XWLPBXQPTPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool FRXTGGISQVN
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool QKCULOTJARE
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<VFKNGTPUEMY>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x72B0D00", Offset = "0x72AFB00", VA = "0x1872B0D00", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<JZROSXUIZUS>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x72B0F70", Offset = "0x72AFD70", VA = "0x1872B0F70", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<MVBOYPURKWM>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x72B0D80", Offset = "0x72AFB80", VA = "0x1872B0D80", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x72B0B30", Offset = "0x72AF930", VA = "0x1872B0B30")]
			public OTWRLMXKIIM(LLXPXHNGEHC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "154")]
			protected virtual bool BWAUHCKGIHD(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "155")]
			protected virtual bool XMCMRENSQTY(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "156")]
			protected virtual bool HQTOUGUBANV(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "157")]
			protected virtual void LDWLKPRAIAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x72B0A90", Offset = "0x72AF890", VA = "0x1872B0A90", Slot = "149")]
			public override bool ZULHNUQVRVV(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x72AE0B0", Offset = "0x72ACEB0", VA = "0x1872AE0B0", Slot = "122")]
			[AsyncStateMachine(typeof(OTWRLMXKIIM<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> MHPCPSFSVBE(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x72AE1D0", Offset = "0x72ACFD0", VA = "0x1872AE1D0", Slot = "123")]
			[AsyncStateMachine(typeof(OTWRLMXKIIM<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, KXUOEYSOWHL>> MMMZDJENDIJ(Id32<JZROSXUIZUS> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x72ADE20", Offset = "0x72ACC20", VA = "0x1872ADE20", Slot = "124")]
			public override void IUGXBVFTPEF(Id32<JZROSXUIZUS> index, Id32<JZROSXUIZUS> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x72ACB70", Offset = "0x72AB970", VA = "0x1872ACB70", Slot = "125")]
			public override IEnumerable<JGWKKBUFZYH> DUJBWDOEHRQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x72ADFB0", Offset = "0x72ACDB0", VA = "0x1872ADFB0")]
			[AsyncStateMachine(typeof(OTWRLMXKIIM<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, KXUOEYSOWHL>> KYWCTPXLODH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "158")]
			protected virtual bool PVPJCWSCGII(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "159")]
			protected virtual bool PLKUAYQQPDU(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "160")]
			protected virtual bool FHAAHQDGANZ(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "161")]
			protected virtual bool LNJZQAVADLJ(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "162")]
			protected virtual bool GVRHKWRFHAL(Id32<JZROSXUIZUS> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "163")]
			protected virtual bool ARAKABQDFCI(Id32<JZROSXUIZUS> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "164")]
			protected virtual bool WEPCIWBFFIS(Id32<JZROSXUIZUS> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "165")]
			protected virtual bool QKCLFMYATEX(Id32<JZROSXUIZUS> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "166")]
			protected virtual bool LEBQEYQNHMP(Id32<JZROSXUIZUS> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "167")]
			protected virtual bool AJVRQPMLBJM(Id32<JZROSXUIZUS> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x72AFE20", Offset = "0x72AEC20", VA = "0x1872AFE20", Slot = "168")]
			protected virtual List<WIBHTRDJIRP> QCUZTMTONUI(Id32<JZROSXUIZUS> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "169")]
			protected virtual void PNZUKLGHIHP(WTNZWELDSYY a, TPAZGFUMDNI b, GQSGWEUJXVS c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x72AC1D0", Offset = "0x72AAFD0", VA = "0x1872AC1D0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x72AE2E0", Offset = "0x72AD0E0", VA = "0x1872AE2E0")]
			private TPAZGFUMDNI NERXAWDZYBC(WTNZWELDSYY a, GQSGWEUJXVS b, Id32<JZROSXUIZUS> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x72ACDC0", Offset = "0x72ABBC0", VA = "0x1872ACDC0")]
			private List<DUQUSUOTFQH> EQXHIEGCDWR(WTNZWELDSYY a, GQSGWEUJXVS b, TPAZGFUMDNI c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x72B0100", Offset = "0x72AEF00", VA = "0x1872B0100")]
			private List<DUQUSUOTFQH> WRSUXWAHEQN(WTNZWELDSYY a, GQSGWEUJXVS b, EJMDVNERXCJ c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x72AFC30", Offset = "0x72AEA30", VA = "0x1872AFC30")]
			private WIBHTRDJIRP PGIZSHKFUPH(List<WIBHTRDJIRP> a, EJMDVNERXCJ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x72B00A0", Offset = "0x72AEEA0", VA = "0x1872B00A0")]
			[CompilerGenerated]
			private JGWKKBUFZYH VYJWLUTSEDX(RHNNOHYQJTP a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class OIDDZRBBVKL : KBJUJVKWDYX<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public OIDDZRBBVKL XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E1C0", Offset = "0x2B1CFC0", VA = "0x182B1E1C0")]
				internal int THZSLGQHIWF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E130", Offset = "0x2B1CF30", VA = "0x182B1E130")]
				internal Task<bool> THULNZWJZKW(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2B212E0", Offset = "0x2B200E0", VA = "0x182B212E0")]
			public OIDDZRBBVKL(LLXPXHNGEHC a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2B21130", Offset = "0x2B1FF30", VA = "0x182B21130", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class IQWTUUFKSBN : QUKBOKSTSIL<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public IQWTUUFKSBN XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B620", Offset = "0x2B0A420", VA = "0x182B0B620")]
				internal int HWQXIQNOGGI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B6A0", Offset = "0x2B0A4A0", VA = "0x182B0B6A0")]
				internal Task<bool> HWWEFXHLPRR(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D440", Offset = "0x2B1C240", VA = "0x182B1D440")]
			public IQWTUUFKSBN(LLXPXHNGEHC a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D220", Offset = "0x2B1C020", VA = "0x182B1D220", Slot = "151")]
			protected override void GTLEJOLGLKI(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class GZCAHLZWPSV : KBJUJVKWDYX<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xF0CE90", Offset = "0xF0BC90", VA = "0x180F0CE90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C940", Offset = "0x2B1B740", VA = "0x182B1C940")]
			public GZCAHLZWPSV(LLXPXHNGEHC a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class BJSIJNSOWEB : KBJUJVKWDYX<RACXRABOFIO>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class FUIFISZXLYJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public BJSIJNSOWEB XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public WTNZWELDSYY HZRHTRQMOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> CJLPQAMYPDJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> CJQWNHGVYOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> CKGRFBOOAWT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> CKLYCIILKIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> CKREZPCITTL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> CKWLWVWGDEU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> CLBSUCQDMQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> JJXNRMBDVKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> JJSGUFHGLZA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> JJMZWYNJCNR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> JJHSZRTLTCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> JKSPGNCTHDT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> JKNIJGIVXSK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> JKIBLZOYOHB;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FUIFISZXLYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B150", Offset = "0x2B19F50", VA = "0x182B1B150")]
				internal bool THZSLGQHIWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B0F0", Offset = "0x2B19EF0", VA = "0x182B1B0F0")]
				internal void THULNZWJZKW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B250", Offset = "0x2B1A050", VA = "0x182B1B250")]
				internal bool TIUUAHRWUPP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B200", Offset = "0x2B1A000", VA = "0x182B1B200")]
				internal bool TIPNDAXZLEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B1A0", Offset = "0x2B19FA0", VA = "0x182B1B1A0")]
				internal void TIKGFUECBSX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B2A0", Offset = "0x2B1A0A0", VA = "0x182B1B2A0")]
				internal bool TJKOSBZOWXQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2B13150", Offset = "0x2B11F50", VA = "0x182B13150")]
				internal bool GORNIMMSAOG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2B131A0", Offset = "0x2B11FA0", VA = "0x182B131A0")]
				internal void GOWUFTGPJZP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2B130B0", Offset = "0x2B11EB0", VA = "0x182B130B0")]
				internal bool GNWLTLLCOUW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2B13100", Offset = "0x2B11F00", VA = "0x182B13100")]
				internal bool GOBSQSEZYGF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2B13050", Offset = "0x2B11E50", VA = "0x182B13050")]
				internal void GNLXYXXHVYE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2B13200", Offset = "0x2B12000", VA = "0x182B13200")]
				internal bool GQMXJVJUHMJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2B1ACC0", Offset = "0x2B19AC0", VA = "0x182B1ACC0")]
				internal bool SOEFACYCGWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AD10", Offset = "0x2B19B10", VA = "0x182B1AD10")]
				internal bool SOJLXJRZQIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AD60", Offset = "0x2B19B60", VA = "0x182B1AD60")]
				internal bool SOOSUQLWZTQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2B1ADB0", Offset = "0x2B19BB0", VA = "0x182B1ADB0")]
				internal bool SOZGPDZRSQI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AE00", Offset = "0x2B19C00", VA = "0x182B1AE00")]
				internal bool SPENMKTPCBR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C290", Offset = "0x2B1B090", VA = "0x182B1C290")]
				internal bool ZOAIJUEPKVX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C240", Offset = "0x2B1B040", VA = "0x182B1C240")]
				internal bool ZNVBMNKSBKO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C1E0", Offset = "0x2B1AFE0", VA = "0x182B1C1E0")]
				internal void ZNPUPGQURZF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A4B0", Offset = "0x2B192B0", VA = "0x182B1A4B0")]
				internal bool OLJUBCVNPVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A550", Offset = "0x2B19350", VA = "0x182B1A550")]
				internal bool OLZOSXDFSDH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A500", Offset = "0x2B19300", VA = "0x182B1A500")]
				internal bool OLUHVQJIIRY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A3C0", Offset = "0x2B191C0", VA = "0x182B1A3C0")]
				internal bool OKOSMBTYEBW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A460", Offset = "0x2B19260", VA = "0x182B1A460")]
				internal bool OLENDWBQGJX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C190", Offset = "0x2B1AF90", VA = "0x182B1C190")]
				internal bool ZNKNRZWXINW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C3E0", Offset = "0x2B1B1E0", VA = "0x182B1C3E0")]
				internal bool ZOVJYVGEWPH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C380", Offset = "0x2B1B180", VA = "0x182B1C380")]
				internal void ZOQDBOMHNDY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C330", Offset = "0x2B1B130", VA = "0x182B1C330")]
				internal bool ZOKWEHSKDSP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C2E0", Offset = "0x2B1B0E0", VA = "0x182B1C2E0")]
				internal bool ZOFPHAYMUHG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C480", Offset = "0x2B1B280", VA = "0x182B1C480")]
				internal void ZPQLNWHUIIR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C430", Offset = "0x2B1B230", VA = "0x182B1C430")]
				internal bool ZPLEQPNWYXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AC10", Offset = "0x2B19A10", VA = "0x182B1AC10")]
				internal bool SNJDLBWMVDO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AC60", Offset = "0x2B19A60", VA = "0x182B1AC60")]
				internal void SNOKIIQKEOX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2B13250", Offset = "0x2B12050", VA = "0x182B13250")]
				internal List<DUQUSUOTFQH> HJATSXMWHMQ(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A410", Offset = "0x2B19210", VA = "0x182B1A410")]
				internal bool OKZGGPHSWYO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A630", Offset = "0x2B19430", VA = "0x182B1A630")]
				internal int ONFECLSPWTJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A5A0", Offset = "0x2B193A0", VA = "0x182B1A5A0")]
				internal Task<bool> OMZXFEYSNIA(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2B19100", Offset = "0x2B17F00", VA = "0x182B19100")]
				internal bool HKXVZRHIJOG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2B19150", Offset = "0x2B17F50", VA = "0x182B19150")]
				internal bool HLDCWYBFSZP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2B19060", Offset = "0x2B17E60", VA = "0x182B19060")]
				internal bool HKNIFDTNQRO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2B190B0", Offset = "0x2B17EB0", VA = "0x182B190B0")]
				internal int HKSPCKNLACX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2B19240", Offset = "0x2B18040", VA = "0x182B19240")]
				internal Task<bool> HLSXOSIXVHQ(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2B192D0", Offset = "0x2B180D0", VA = "0x182B192D0")]
				internal bool HLYELZCVESZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2B191A0", Offset = "0x2B17FA0", VA = "0x182B191A0")]
				internal bool HLIJUEVDCKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2B191F0", Offset = "0x2B17FF0", VA = "0x182B191F0")]
				internal bool HLNQRLPALWH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2B19320", Offset = "0x2B18120", VA = "0x182B19320")]
				internal bool HMTGBAEKQMJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2B122E0", Offset = "0x2B110E0", VA = "0x182B122E0")]
				internal bool AQTDRHLZJUZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B6A0", Offset = "0x2B1A4A0", VA = "0x182B1B6A0")]
				internal string UPLWKVTTWDY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B630", Offset = "0x2B1A430", VA = "0x182B1B630")]
				internal void UPGPNOZWMSP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B8B0", Offset = "0x2B1A6B0", VA = "0x182B1B8B0")]
				internal int UQGXZWVJHXI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B850", Offset = "0x2B1A650", VA = "0x182B1B850")]
				internal void UQBRCQBLYLZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B790", Offset = "0x2B1A590", VA = "0x182B1B790")]
				internal bool UPWKFJHOPAQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BA10", Offset = "0x2B1A810", VA = "0x182B1BA10")]
				internal bool URHGMEQWDCB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B950", Offset = "0x2B1A750", VA = "0x182B1B950")]
				internal bool URBZOXWYTQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A160", Offset = "0x2B18F60", VA = "0x182B1A160")]
				internal float NOZYJKFOPWY()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A1B0", Offset = "0x2B18FB0", VA = "0x182B1A1B0")]
				internal void NPFFGQZLZIH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A210", Offset = "0x2B19010", VA = "0x182B1A210")]
				internal bool NPKMDXTJITQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A260", Offset = "0x2B19060", VA = "0x182B1A260")]
				internal bool NPPTBENGSEZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A2B0", Offset = "0x2B190B0", VA = "0x182B1A2B0")]
				internal bool NPUZYLHEBQI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2B12290", Offset = "0x2B11090", VA = "0x182B12290")]
				internal bool AQIPWTYEQYH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2B12240", Offset = "0x2B11040", VA = "0x182B12240")]
				internal bool AQDIZNEHHMY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2B121F0", Offset = "0x2B10FF0", VA = "0x182B121F0")]
				internal bool APYCCGKJYBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2B11DF0", Offset = "0x2B10BF0", VA = "0x182B11DF0")]
				internal void APSVEZQMOQG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A300", Offset = "0x2B19100", VA = "0x182B1A300")]
				internal string NQAGVSBBLBR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A350", Offset = "0x2B19150", VA = "0x182B1A350")]
				internal void NQFNSYUYUNA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2B11DA0", Offset = "0x2B10BA0", VA = "0x182B11DA0")]
				internal bool APNOHSWPFEX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2B11D50", Offset = "0x2B10B50", VA = "0x182B11D50")]
				internal bool APIHKMCRVTO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2B11D00", Offset = "0x2B10B00", VA = "0x182B11D00")]
				internal bool APDANFIUMIF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2B11A40", Offset = "0x2B10840", VA = "0x182B11A40")]
				internal void AOXTPYOXCWW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B4F0", Offset = "0x2B1A2F0", VA = "0x182B1B4F0")]
				internal bool TQBYSPDWUCQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B540", Offset = "0x2B1A340", VA = "0x182B1B540")]
				internal bool TQHFPVXUDNZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B590", Offset = "0x2B1A390", VA = "0x182B1B590")]
				internal bool TQMMNCRRMZI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B5E0", Offset = "0x2B1A3E0", VA = "0x182B1B5E0")]
				internal bool TQRTKJLOWKR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B3A0", Offset = "0x2B1A1A0", VA = "0x182B1B3A0")]
				internal void TPGXDOCHIJG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B400", Offset = "0x2B1A200", VA = "0x182B1B400")]
				internal bool TPMEAUWERUP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B450", Offset = "0x2B1A250", VA = "0x182B1B450")]
				internal bool TPRKYBQCBFY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B4A0", Offset = "0x2B1A2A0", VA = "0x182B1B4A0")]
				internal bool TPWRVIJZKRH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B2F0", Offset = "0x2B1A0F0", VA = "0x182B1B2F0")]
				internal bool TOLVONARWPW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B340", Offset = "0x2B1A140", VA = "0x182B1B340")]
				internal void TORCLTUPGBF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A6D0", Offset = "0x2B194D0", VA = "0x182B1A6D0")]
				internal bool PHVJPOKBIGP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A680", Offset = "0x2B19480", VA = "0x182B1A680")]
				internal bool PHQCSHQDYVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A770", Offset = "0x2B19570", VA = "0x182B1A770")]
				internal bool PIFXKBXWBDH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A720", Offset = "0x2B19520", VA = "0x182B1A720")]
				internal bool PIAQMVDYRRY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A850", Offset = "0x2B19650", VA = "0x182B1A850")]
				internal object PJAYZCZLMWR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A7C0", Offset = "0x2B195C0", VA = "0x182B1A7C0")]
				internal void PIVSBWFODLI(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A910", Offset = "0x2B19710", VA = "0x182B1A910")]
				internal bool PJLMTQNGFTJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A8C0", Offset = "0x2B196C0", VA = "0x182B1A8C0")]
				internal bool PJGFWJTIWIA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2B197D0", Offset = "0x2B185D0", VA = "0x182B197D0")]
				internal int INVYELIPRYR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2B19770", Offset = "0x2B18570", VA = "0x182B19770")]
				internal void INGDMRAXPQQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2B19720", Offset = "0x2B18520", VA = "0x182B19720")]
				internal bool INAWPKHAGFH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2B196D0", Offset = "0x2B184D0", VA = "0x182B196D0")]
				internal bool IMLBXPZIDXG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2B19680", Offset = "0x2B18480", VA = "0x182B19680")]
				internal int IMFVAJFKULX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AEF0", Offset = "0x2B19CF0", VA = "0x182B1AEF0")]
				internal void SSJKDPRFWNU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AF50", Offset = "0x2B19D50", VA = "0x182B1AF50")]
				internal bool SSORAWLDFZD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AE50", Offset = "0x2B19C50", VA = "0x182B1AE50")]
				internal bool SRYWJCDLDRC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AEA0", Offset = "0x2B19CA0", VA = "0x182B1AEA0")]
				internal bool SSEDGIXINCL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AFA0", Offset = "0x2B19DA0", VA = "0x182B1AFA0")]
				internal int SSTXYDFAPKM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AFF0", Offset = "0x2B19DF0", VA = "0x182B1AFF0")]
				internal void SSZEVJYXYVV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B050", Offset = "0x2B19E50", VA = "0x182B1B050")]
				internal bool STZNHRUKUAO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B0A0", Offset = "0x2B19EA0", VA = "0x182B1B0A0")]
				internal bool SUEUEYOIDLX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C0A0", Offset = "0x2B1AEA0", VA = "0x182B1C0A0")]
				internal bool YTCQPAAIAJV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BFA0", Offset = "0x2B1ADA0", VA = "0x182B1BFA0")]
				internal object YSCICSEVFFC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C010", Offset = "0x2B1AE10", VA = "0x182B1C010")]
				internal void YSSCUMMNHND(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C140", Offset = "0x2B1AF40", VA = "0x182B1C140")]
				internal bool YUSTTCDMXWP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C0F0", Offset = "0x2B1AEF0", VA = "0x182B1C0F0")]
				internal bool YUNMVVJPOLG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2B12F50", Offset = "0x2B11D50", VA = "0x182B12F50")]
				internal object? EXNMWNNUHCE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2B12FC0", Offset = "0x2B11DC0", VA = "0x182B12FC0")]
				internal void EXSTTUHRQNN(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2B12E00", Offset = "0x2B11C00", VA = "0x182B12E00")]
				internal bool EWSLHMMEVIU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2B12E50", Offset = "0x2B11C50", VA = "0x182B12E50")]
				internal int EWXSETGCEUD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2B12EA0", Offset = "0x2B11CA0", VA = "0x182B12EA0")]
				internal void EXCZBZZZOFM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2B12F00", Offset = "0x2B11D00", VA = "0x182B12F00")]
				internal bool EXIFZGTWXQV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2B12D60", Offset = "0x2B11B60", VA = "0x182B12D60")]
				internal bool EVXJSLKPJPK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2B12DB0", Offset = "0x2B11BB0", VA = "0x182B12DB0")]
				internal bool EWCQPSEMTAT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A110", Offset = "0x2B18F10", VA = "0x182B1A110")]
				internal int LYERVFVWWUN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A0B0", Offset = "0x2B18EB0", VA = "0x182B1A0B0")]
				internal void LXZKXZBZNJE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A060", Offset = "0x2B18E60", VA = "0x182B1A060")]
				internal bool LXUEASICDXV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A010", Offset = "0x2B18E10", VA = "0x182B1A010")]
				internal bool LXOXDLOEUMM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2B19FC0", Offset = "0x2B18DC0", VA = "0x182B19FC0")]
				internal bool LXJQGEUHLBD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2B19F70", Offset = "0x2B18D70", VA = "0x182B19F70")]
				internal float LXEJIYAKBPU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2B19F10", Offset = "0x2B18D10", VA = "0x182B19F10")]
				internal void LWZCLRGMSEL(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2B19EC0", Offset = "0x2B18CC0", VA = "0x182B19EC0")]
				internal bool LWTVOKMPITC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2B19E70", Offset = "0x2B18C70", VA = "0x182B19E70")]
				internal bool LWOORDSRZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2B19E20", Offset = "0x2B18C20", VA = "0x182B19E20")]
				internal bool LWJHTWYUPWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AAC0", Offset = "0x2B198C0", VA = "0x182B1AAC0")]
				internal float QWFCZCXPBRM()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AB10", Offset = "0x2B19910", VA = "0x182B1AB10")]
				internal void QWKJWJRMLCV(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AA70", Offset = "0x2B19870", VA = "0x182B1AA70")]
				internal bool QVUPEPJUIUU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AA20", Offset = "0x2B19820", VA = "0x182B1AA20")]
				internal bool QVPIHIPWZJL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A960", Offset = "0x2B19760", VA = "0x182B1A960")]
				internal string QUZNPOIEXBK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A9B0", Offset = "0x2B197B0", VA = "0x182B1A9B0")]
				internal void QVEUMVCCGMT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2B1AB70", Offset = "0x2B19970", VA = "0x182B1AB70")]
				internal bool QXVGDFATZEG(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2B1ABC0", Offset = "0x2B199C0", VA = "0x182B1ABC0")]
				internal bool QYANALURIPP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BD50", Offset = "0x2B1AB50", VA = "0x182B1BD50")]
				internal bool XWWHXVFRRJV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BD00", Offset = "0x2B1AB00", VA = "0x182B1BD00")]
				internal bool XWRBAOLUHYM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BE10", Offset = "0x2B1AC10", VA = "0x182B1BE10")]
				internal string XXGVSITMKGN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BDA0", Offset = "0x2B1ABA0", VA = "0x182B1BDA0")]
				internal void XXBOVBZPAVE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BEB0", Offset = "0x2B1ACB0", VA = "0x182B1BEB0")]
				internal bool XXRJMWHHDDF(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BE60", Offset = "0x2B1AC60", VA = "0x182B1BE60")]
				internal bool XXMCPPNJTRW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BF50", Offset = "0x2B1AD50", VA = "0x182B1BF50")]
				internal bool XYBXHJVBVZX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BF00", Offset = "0x2B1AD00", VA = "0x182B1BF00")]
				internal bool XXWQKDBEMOO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BCB0", Offset = "0x2B1AAB0", VA = "0x182B1BCB0")]
				internal string XVGETTCMTXB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BC40", Offset = "0x2B1AA40", VA = "0x182B1BC40")]
				internal void XVAXWMIPKLS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B12A20", Offset = "0x2B11820", VA = "0x182B12A20")]
				internal bool DUURPAGKIDC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B12A70", Offset = "0x2B11870", VA = "0x182B12A70")]
				internal bool DUZYMHAHROL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2B12AC0", Offset = "0x2B118C0", VA = "0x182B12AC0")]
				internal bool DVFFJNUFAZU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2B12B10", Offset = "0x2B11910", VA = "0x182B12B10")]
				internal bool DVKMGUOCKLD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2B12B60", Offset = "0x2B11960", VA = "0x182B12B60")]
				internal string DVPTEBHZTWM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2B12BB0", Offset = "0x2B119B0", VA = "0x182B12BB0")]
				internal void DVVABIBXDHV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B12C20", Offset = "0x2B11A20", VA = "0x182B12C20")]
				internal bool DWAGYOVUMTE(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B12C70", Offset = "0x2B11A70", VA = "0x182B12C70")]
				internal bool DWFNVVPRWEN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2B12CC0", Offset = "0x2B11AC0", VA = "0x182B12CC0")]
				internal bool DWKUTCJPFPW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2B12D10", Offset = "0x2B11B10", VA = "0x182B12D10")]
				internal bool DWQBQJDMPBF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B19BD0", Offset = "0x2B189D0", VA = "0x182B19BD0")]
				internal string KVLWNSOMXVL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B19B60", Offset = "0x2B18960", VA = "0x182B19B60")]
				internal void KVGPQLUPOKC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B19B10", Offset = "0x2B18910", VA = "0x182B19B10")]
				internal bool KVBITFASEYT(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B19AC0", Offset = "0x2B188C0", VA = "0x182B19AC0")]
				internal bool KUWBVYGUVNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B19D30", Offset = "0x2B18B30", VA = "0x182B19D30")]
				internal bool KWGYCTQCJOV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2B19CE0", Offset = "0x2B18AE0", VA = "0x182B19CE0")]
				internal bool KWBRFMWFADM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2B19C90", Offset = "0x2B18A90", VA = "0x182B19C90")]
				internal string KVWKIGCHQSD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2B19C20", Offset = "0x2B18A20", VA = "0x182B19C20")]
				internal void KVRDKZIKHGU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2B19DD0", Offset = "0x2B18BD0", VA = "0x182B19DD0")]
				internal bool KXBZRURRVIF(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2B19D80", Offset = "0x2B18B80", VA = "0x182B19D80")]
				internal bool KWWSUNXULWW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BA60", Offset = "0x2B1A860", VA = "0x182B1BA60")]
				internal bool URIOCHTGEMW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BAB0", Offset = "0x2B1A8B0", VA = "0x182B1BAB0")]
				internal bool URNUZONDNYF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B900", Offset = "0x2B1A700", VA = "0x182B1B900")]
				internal string UQYAHUFLLQE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B9A0", Offset = "0x2B1A7A0", VA = "0x182B1B9A0")]
				internal void URDHFAZIVBN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BBA0", Offset = "0x2B1A9A0", VA = "0x182B1BBA0")]
				internal bool USDPRIUVQGG(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BBF0", Offset = "0x2B1A9F0", VA = "0x182B1BBF0")]
				internal bool USIWOPOSZRP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BB00", Offset = "0x2B1A900", VA = "0x182B1BB00")]
				internal bool URTBWVHAXJO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BB50", Offset = "0x2B1A950", VA = "0x182B1BB50")]
				internal bool URYIUCAYGUX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B740", Offset = "0x2B1A540", VA = "0x182B1B740")]
				internal string UPSKYFQBHAC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B7E0", Offset = "0x2B1A5E0", VA = "0x182B1B7E0")]
				internal void UPXRVMJYQLL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B12840", Offset = "0x2B11640", VA = "0x182B12840")]
				internal bool BRZTBABIUFF(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2B127F0", Offset = "0x2B115F0", VA = "0x182B127F0")]
				internal bool BRUMDTHLKTW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B12930", Offset = "0x2B11730", VA = "0x182B12930")]
				internal bool BSKGVNPDNBX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2B128E0", Offset = "0x2B116E0", VA = "0x182B128E0")]
				internal bool BSEZYGVGDQO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B12700", Offset = "0x2B11500", VA = "0x182B12700")]
				internal string BRERLYZTILV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B12690", Offset = "0x2B11490", VA = "0x182B12690")]
				internal void BQZKOSFVZAM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2B127A0", Offset = "0x2B115A0", VA = "0x182B127A0")]
				internal bool BRPFGMNOBIN(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B12750", Offset = "0x2B11550", VA = "0x182B12750")]
				internal bool BRJYJFTQRXE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B125F0", Offset = "0x2B113F0", VA = "0x182B125F0")]
				internal bool BQJPWXYDWSL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B12550", Offset = "0x2B11350", VA = "0x182B12550")]
				internal bool BQEIZREGNHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B19480", Offset = "0x2B18280", VA = "0x182B19480")]
				internal string HRBOSFEVZDR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B19410", Offset = "0x2B18210", VA = "0x182B19410")]
				internal void HQWHUYKYPSI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B194D0", Offset = "0x2B182D0", VA = "0x182B194D0")]
				internal bool HRGVPLYTIPA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2B19570", Offset = "0x2B18370", VA = "0x182B19570")]
				internal bool HRWQHGGLKXB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B19520", Offset = "0x2B18320", VA = "0x182B19520")]
				internal bool HRRJJZMOBLS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B19630", Offset = "0x2B18430", VA = "0x182B19630")]
				internal string HSHEBTUGDTT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B195C0", Offset = "0x2B183C0", VA = "0x182B195C0")]
				internal void HSBXENAIUIK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B193C0", Offset = "0x2B181C0", VA = "0x182B193C0")]
				internal bool HPLLODBRBQX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B19370", Offset = "0x2B18170", VA = "0x182B19370")]
				internal bool HPGEQWHTSFO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B125A0", Offset = "0x2B113A0", VA = "0x182B125A0")]
				internal bool BQIIGUVTVHQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2B12640", Offset = "0x2B11440", VA = "0x182B12640")]
				internal string BQNPEBPRESZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2B12490", Offset = "0x2B11290", VA = "0x182B12490")]
				internal void BPXUMHHZCKY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2B12500", Offset = "0x2B11300", VA = "0x182B12500")]
				internal bool BQDBJOBWLWH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2B123F0", Offset = "0x2B111F0", VA = "0x182B123F0")]
				internal bool BPNGRTUEJOG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2B12440", Offset = "0x2B11240", VA = "0x182B12440")]
				internal bool BPSNPAOBSZP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B12330", Offset = "0x2B11130", VA = "0x182B12330")]
				internal string BPCSXGGJQRO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B12380", Offset = "0x2B11180", VA = "0x182B12380")]
				internal void BPHZUNAHACX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B12890", Offset = "0x2B11690", VA = "0x182B12890")]
				internal bool BSDSIDSWCFT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B6F0", Offset = "0x2B1A4F0", VA = "0x182B1B6F0")]
				internal bool UPRDICNRFPH(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B199C0", Offset = "0x2B187C0", VA = "0x182B199C0")]
				internal float JNQJRFMHMWR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B19960", Offset = "0x2B18760", VA = "0x182B19960")]
				internal void JNLCTYSKDLI(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B19870", Offset = "0x2B18670", VA = "0x182B19870")]
				internal bool JMKUHQWXIGP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B19820", Offset = "0x2B18620", VA = "0x182B19820")]
				internal bool JMFNKKCZYVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B19910", Offset = "0x2B18710", VA = "0x182B19910")]
				internal bool JMVICEKSBDH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B198C0", Offset = "0x2B186C0", VA = "0x182B198C0")]
				internal int JMQBEXQURRY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B19A60", Offset = "0x2B18860", VA = "0x182B19A60")]
				internal void JOVZAUBRRMT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B19A10", Offset = "0x2B18810", VA = "0x182B19A10")]
				internal bool JOQSDNHUIBK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B12980", Offset = "0x2B11780", VA = "0x182B12980")]
				internal bool CMOQXZQKEHQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B129D0", Offset = "0x2B117D0", VA = "0x182B129D0")]
				internal bool CMTXVGKHNSZ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class FUCYLMGACNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string CVIMCGRPAMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public FUIFISZXLYJ DODNVPQZHNM;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FUCYLMGACNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B37900", Offset = "0x2B36700", VA = "0x182B37900")]
				internal void AQNWUASCAJQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class FTXROFMCTBR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] JFZAJNGVQRY;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FTXROFMCTBR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B37890", Offset = "0x2B36690", VA = "0x182B37890")]
				internal bool JNAOZLEPKOQ(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers GVDKJPPTFOD;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E8B0", Offset = "0x2B0D6B0", VA = "0x182B0E8B0")]
			public BJSIJNSOWEB(LLXPXHNGEHC a, RACXRABOFIO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0CCB0", Offset = "0x2B0BAB0", VA = "0x182B0CCB0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class XONXKMGSEWG : KBJUJVKWDYX<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B47450", Offset = "0x2B46250", VA = "0x182B47450")]
			public XONXKMGSEWG(LLXPXHNGEHC a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B46BA0", Offset = "0x2B459A0", VA = "0x182B46BA0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B47350", Offset = "0x2B46150", VA = "0x182B47350")]
			private static string YKUDDZQJAMK(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B472B0", Offset = "0x2B460B0", VA = "0x182B472B0")]
			[CompilerGenerated]
			private object? UWDYAUDMQVT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B471A0", Offset = "0x2B45FA0", VA = "0x182B471A0")]
			[CompilerGenerated]
			private void UVYRDNJPHKK(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B46F90", Offset = "0x2B45D90", VA = "0x182B46F90")]
			[CompilerGenerated]
			private string UVTKGGPRXZB(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B46EF0", Offset = "0x2B45CF0", VA = "0x182B46EF0")]
			[CompilerGenerated]
			private IReadOnlyList<object> UVODIZVUONS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B46E90", Offset = "0x2B45C90", VA = "0x182B46E90")]
			[CompilerGenerated]
			private string? UVIWLTBXFCJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B46E50", Offset = "0x2B45C50", VA = "0x182B46E50")]
			[CompilerGenerated]
			private bool UVDPOMHZVRA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class JUSEPIPMNEQ : KBJUJVKWDYX<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
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
					public KGMFPJNILMO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x2B45990", Offset = "0x2B44790", VA = "0x182B45990", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public JUSEPIPMNEQ XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B980", Offset = "0x2B3A780", VA = "0x182B3B980")]
				internal string THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B540", Offset = "0x2B3A340", VA = "0x182B3B540")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void THULNZWJZKW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AFE0", Offset = "0x2B39DE0", VA = "0x182B3AFE0")]
				internal int THPEQTCMPZN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3ADE0", Offset = "0x2B39BE0", VA = "0x182B3ADE0")]
				internal void THJXTMIPGOE(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A8B0", Offset = "0x2B396B0", VA = "0x182B3A8B0")]
			public JUSEPIPMNEQ(LLXPXHNGEHC a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A580", Offset = "0x2B39380", VA = "0x182B3A580", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class NIKUNQLJRCJ : KBJUJVKWDYX<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class FXRJPUNQTQT
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
					public FXRJPUNQTQT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2B45650", Offset = "0x2B44450", VA = "0x182B45650", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public FXRJPUNQTQT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x2B45F40", Offset = "0x2B44D40", VA = "0x182B45F40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public NIKUNQLJRCJ XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FXRJPUNQTQT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2B38BC0", Offset = "0x2B379C0", VA = "0x182B38BC0")]
				internal string THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2B38AF0", Offset = "0x2B378F0", VA = "0x182B38AF0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void THULNZWJZKW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2B38AA0", Offset = "0x2B378A0", VA = "0x182B38AA0")]
				internal int THPEQTCMPZN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2B38A10", Offset = "0x2B37810", VA = "0x182B38A10")]
				internal Task<bool> THJXTMIPGOE(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2B38DC0", Offset = "0x2B37BC0", VA = "0x182B38DC0")]
				internal string TIUUAHRWUPP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2B38CF0", Offset = "0x2B37AF0", VA = "0x182B38CF0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void TIPNDAXZLEG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2B38CA0", Offset = "0x2B37AA0", VA = "0x182B38CA0")]
				internal bool TIKGFUECBSX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2B38C10", Offset = "0x2B37A10", VA = "0x182B38C10")]
				internal void TIEZINKESHO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2B38EA0", Offset = "0x2B37CA0", VA = "0x182B38EA0")]
				internal bool TJPVPITMGIZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2B38E10", Offset = "0x2B37C10", VA = "0x182B38E10")]
				internal void TJKOSBZOWXQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2B388F0", Offset = "0x2B376F0", VA = "0x182B388F0")]
				internal float GORNIMMSAOG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2B38940", Offset = "0x2B37740", VA = "0x182B38940")]
				internal void GOWUFTGPJZP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2B387F0", Offset = "0x2B375F0", VA = "0x182B387F0")]
				internal int GOGZNYYXHRO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x2B38850", Offset = "0x2B37650", VA = "0x182B38850")]
				internal void GOMGLFSURCX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x2B38780", Offset = "0x2B37580", VA = "0x182B38780")]
				internal bool GNWLTLLCOUW()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D740", Offset = "0x2B3C540", VA = "0x182B3D740")]
			public NIKUNQLJRCJ(LLXPXHNGEHC a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CDE0", Offset = "0x2B3BBE0", VA = "0x182B3CDE0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class SNKAUFXJUXW : KBJUJVKWDYX<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public SNKAUFXJUXW XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B9D0", Offset = "0x2B3A7D0", VA = "0x182B3B9D0")]
				internal Dictionary<string, EnumChoiceData> THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B7D0", Offset = "0x2B3A5D0", VA = "0x182B3B7D0")]
				internal int THULNZWJZKW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B300", Offset = "0x2B3A100", VA = "0x182B3B300")]
				internal void THPEQTCMPZN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AE70", Offset = "0x2B39C70", VA = "0x182B3AE70")]
				internal bool THJXTMIPGOE()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F230", Offset = "0x2B3E030", VA = "0x182B3F230")]
			public SNKAUFXJUXW(LLXPXHNGEHC a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EF80", Offset = "0x2B3DD80", VA = "0x182B3EF80", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class RBGCNORMWKB : KBJUJVKWDYX<NMLFDVMAFXU>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public RBGCNORMWKB XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B870", Offset = "0x2B3A670", VA = "0x182B3B870")]
				internal void THZSLGQHIWF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E480", Offset = "0x2B3D280", VA = "0x182B3E480")]
			public RBGCNORMWKB(LLXPXHNGEHC a, NMLFDVMAFXU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E300", Offset = "0x2B3D100", VA = "0x182B3E300", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class JUNANJOJNBJ<a> : OTWRLMXKIIM<a> where a : notnull, XMMEHVKPWIV
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override XUIFPTGWGWM? AWVFPPAZEDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x6678800", Offset = "0x6677600", VA = "0x186678800", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x6678860", Offset = "0x6677660", VA = "0x186678860", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xF39740", Offset = "0xF38540", VA = "0x180F39740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6678840", Offset = "0x6677640", VA = "0x186678840")]
			public JUNANJOJNBJ(LLXPXHNGEHC a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class EANOYLSZQVZ : JUNANJOJNBJ<LYKEDRYMWQY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class FUIFISZXLYJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public EANOYLSZQVZ XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FUIFISZXLYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2B38720", Offset = "0x2B37520", VA = "0x182B38720")]
				internal object THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x2B38600", Offset = "0x2B37400", VA = "0x182B38600")]
				internal void THULNZWJZKW(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x2B38490", Offset = "0x2B37290", VA = "0x182B38490")]
				internal void THPEQTCMPZN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? XXBOJHVEXMX;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2B36F10", Offset = "0x2B35D10", VA = "0x182B36F10")]
			public EANOYLSZQVZ(LLXPXHNGEHC a, LYKEDRYMWQY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2B36990", Offset = "0x2B35790", VA = "0x182B36990", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class AHPFQLYDALM : KBJUJVKWDYX<DIJBWAXIDXJ>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public AHPFQLYDALM XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<YMZQCHJNMJC>> MQTGGITENCO;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x2B30480", Offset = "0x2B2F280", VA = "0x182B30480")]
				internal int THULNZWJZKW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FE80", Offset = "0x2B2EC80", VA = "0x182B2FE80")]
				internal void THPEQTCMPZN(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class BBBPZVCGPLB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<YMZQCHJNMJC> COZIQRYMDTO;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BBBPZVCGPLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x2B30D50", Offset = "0x2B2FB50", VA = "0x182B30D50")]
				internal bool TIUUAHRWUPP(Id32<YMZQCHJNMJC> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DD60", Offset = "0x2B2CB60", VA = "0x182B2DD60")]
			public AHPFQLYDALM(LLXPXHNGEHC a, DIJBWAXIDXJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D830", Offset = "0x2B2C630", VA = "0x182B2D830", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class YIRCUVXNMVA : KBJUJVKWDYX<IXTAOBSRKYT>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xD17FB0", Offset = "0xD16DB0", VA = "0x180D17FB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x2B48680", Offset = "0x2B47480", VA = "0x182B48680")]
			public YIRCUVXNMVA(LLXPXHNGEHC a, IXTAOBSRKYT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class BPFUHHBYBQV : KBJUJVKWDYX<VNLQRMKIRXA>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x2B30DF0", Offset = "0x2B2FBF0", VA = "0x182B30DF0")]
			public BPFUHHBYBQV(LLXPXHNGEHC a, VNLQRMKIRXA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "134")]
			protected override bool YEVCODTPDUJ(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class BVYZOIVOREV : KBJUJVKWDYX<RDXMLAVZWYC>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x2B30F60", Offset = "0x2B2FD60", VA = "0x182B30F60", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2B30EF0", Offset = "0x2B2FCF0", VA = "0x182B30EF0")]
			public BVYZOIVOREV(LLXPXHNGEHC a, RDXMLAVZWYC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class NJZSMJHTFKB : KBJUJVKWDYX<GFBHKZIYCOO>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D820", Offset = "0x2B3C620", VA = "0x182B3D820", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D7B0", Offset = "0x2B3C5B0", VA = "0x182B3D7B0")]
			public NJZSMJHTFKB(LLXPXHNGEHC a, GFBHKZIYCOO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class YXFWGYXRBCI : QUKBOKSTSIL<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public YXFWGYXRBCI XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F9C0", Offset = "0x2B2E7C0", VA = "0x182B2F9C0")]
				internal float HWQXIQNOGGI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FA40", Offset = "0x2B2E840", VA = "0x182B2FA40")]
				internal void HWWEFXHLPRR(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2B48960", Offset = "0x2B47760", VA = "0x182B48960")]
			public YXFWGYXRBCI(LLXPXHNGEHC a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2B486F0", Offset = "0x2B474F0", VA = "0x182B486F0", Slot = "151")]
			protected override void GTLEJOLGLKI(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class HHFNIKRVQRX : KBJUJVKWDYX<BLFYFSZXWHE>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2B398B0", Offset = "0x2B386B0", VA = "0x182B398B0")]
			public HHFNIKRVQRX(LLXPXHNGEHC a, BLFYFSZXWHE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class HWDBZJGQFVD : KBJUJVKWDYX<BFUSSHUZNKK>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2B39C30", Offset = "0x2B38A30", VA = "0x182B39C30")]
			public HWDBZJGQFVD(LLXPXHNGEHC a, BFUSSHUZNKK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class TXNCXASHXHW : KBJUJVKWDYX<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public TXNCXASHXHW XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x2B30950", Offset = "0x2B2F750", VA = "0x182B30950")]
				internal bool THZSLGQHIWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x2B30350", Offset = "0x2B2F150", VA = "0x182B30350")]
				internal void THULNZWJZKW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2B40510", Offset = "0x2B3F310", VA = "0x182B40510")]
			public TXNCXASHXHW(LLXPXHNGEHC a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2B40280", Offset = "0x2B3F080", VA = "0x182B40280", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class ZNUMMPJPHGQ : KBJUJVKWDYX<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public ZNUMMPJPHGQ XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> EPVAUNZHLTH;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2B30820", Offset = "0x2B2F620", VA = "0x182B30820")]
				internal object? THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2B30AE0", Offset = "0x2B2F8E0", VA = "0x182B30AE0")]
				internal bool TIEZINKESHO(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2B30070", Offset = "0x2B2EE70", VA = "0x182B30070")]
				internal void THULNZWJZKW(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FBD0", Offset = "0x2B2E9D0", VA = "0x182B2FBD0")]
				internal string THPEQTCMPZN(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FB80", Offset = "0x2B2E980", VA = "0x182B2FB80")]
				internal IReadOnlyList<object> THJXTMIPGOE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2B30CE0", Offset = "0x2B2FAE0", VA = "0x182B30CE0")]
				internal bool TIUUAHRWUPP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2B30C90", Offset = "0x2B2FA90", VA = "0x182B30C90")]
				internal bool TIPNDAXZLEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x2B30B60", Offset = "0x2B2F960", VA = "0x182B30B60")]
				internal void TIKGFUECBSX(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2B49100", Offset = "0x2B47F00", VA = "0x182B49100")]
			public ZNUMMPJPHGQ(LLXPXHNGEHC a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2B48A20", Offset = "0x2B47820", VA = "0x182B48A20", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class HCRQKWOESKG : KBJUJVKWDYX<UNOLXNGKKAT>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class FXRJPUNQTQT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int YKXFLXLNGIA;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FXRJPUNQTQT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2B389D0", Offset = "0x2B377D0", VA = "0x182B389D0")]
				internal bool RBBIXRGJHXS(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class KRDFVZFEZPK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public HCRQKWOESKG XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> NKLQCVSYRBY;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KRDFVZFEZPK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C7C0", Offset = "0x2B3B5C0", VA = "0x182B3C7C0")]
				internal int THZSLGQHIWF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C6A0", Offset = "0x2B3B4A0", VA = "0x182B3C6A0")]
				internal void THULNZWJZKW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C5F0", Offset = "0x2B3B3F0", VA = "0x182B3C5F0")]
				internal string? THPEQTCMPZN()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2B394C0", Offset = "0x2B382C0", VA = "0x182B394C0")]
			public HCRQKWOESKG(LLXPXHNGEHC a, UNOLXNGKKAT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2B38FC0", Offset = "0x2B37DC0", VA = "0x182B38FC0")]
			private int AIHRCXIQKLI(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2B393A0", Offset = "0x2B381A0", VA = "0x182B393A0")]
			private void PDDYOZIFCIA(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2B39050", Offset = "0x2B37E50", VA = "0x182B39050", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class ILSQWCCTGWD : DHPGNARRYIZ<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xF21130", Offset = "0xF1FF30", VA = "0x180F21130", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2B39D90", Offset = "0x2B38B90", VA = "0x182B39D90")]
			public ILSQWCCTGWD(LLXPXHNGEHC a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class NDZJFOFABKN : QUKBOKSTSIL<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public NDZJFOFABKN XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F940", Offset = "0x2B2E740", VA = "0x182B2F940")]
				internal int HWQXIQNOGGI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FAE0", Offset = "0x2B2E8E0", VA = "0x182B2FAE0")]
				internal void HWWEFXHLPRR(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CD80", Offset = "0x2B3BB80", VA = "0x182B3CD80")]
			public NDZJFOFABKN(LLXPXHNGEHC a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CB10", Offset = "0x2B3B910", VA = "0x182B3CB10", Slot = "151")]
			protected override void GTLEJOLGLKI(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class EVAGEOIEDAL : KBJUJVKWDYX<JTJGGNLWFCI>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public EVAGEOIEDAL XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<YMZQCHJNMJC>> MQTGGITENCO;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x2B305C0", Offset = "0x2B2F3C0", VA = "0x182B305C0")]
				internal int THULNZWJZKW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FD20", Offset = "0x2B2EB20", VA = "0x182B2FD20")]
				internal void THPEQTCMPZN(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class BBBPZVCGPLB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<YMZQCHJNMJC> COZIQRYMDTO;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BBBPZVCGPLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x2B30DA0", Offset = "0x2B2FBA0", VA = "0x182B30DA0")]
				internal bool TIUUAHRWUPP(Id32<YMZQCHJNMJC> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2B374A0", Offset = "0x2B362A0", VA = "0x182B374A0")]
			public EVAGEOIEDAL(LLXPXHNGEHC a, JTJGGNLWFCI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2B36F70", Offset = "0x2B35D70", VA = "0x182B36F70", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class VXUWJGETIQZ : KBJUJVKWDYX<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public VXUWJGETIQZ XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x2B309A0", Offset = "0x2B2F7A0", VA = "0x182B309A0")]
				internal bool THZSLGQHIWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x2B2FFE0", Offset = "0x2B2EDE0", VA = "0x182B2FFE0")]
				internal void THULNZWJZKW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2B46AD0", Offset = "0x2B458D0", VA = "0x182B46AD0")]
			public VXUWJGETIQZ(LLXPXHNGEHC a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2B46900", Offset = "0x2B45700", VA = "0x182B46900", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class RMDHLHUHYUF : KBJUJVKWDYX<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public RMDHLHUHYUF XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x2B30A40", Offset = "0x2B2F840", VA = "0x182B30A40")]
				internal bool THZSLGQHIWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x2B30700", Offset = "0x2B2F500", VA = "0x182B30700")]
				internal void THULNZWJZKW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EA10", Offset = "0x2B3D810", VA = "0x182B3EA10")]
			public RMDHLHUHYUF(LLXPXHNGEHC a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E840", Offset = "0x2B3D640", VA = "0x182B3E840", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class TKSUSSBMKWH : KBJUJVKWDYX<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public TKSUSSBMKWH XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x2B309F0", Offset = "0x2B2F7F0", VA = "0x182B309F0")]
				internal int THZSLGQHIWF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x2B30790", Offset = "0x2B2F590", VA = "0x182B30790")]
				internal void THULNZWJZKW(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F4F0", Offset = "0x2B3E2F0", VA = "0x182B3F4F0")]
			public TKSUSSBMKWH(LLXPXHNGEHC a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F2A0", Offset = "0x2B3E0A0", VA = "0x182B3F2A0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class BPZQJOFZPTW
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log KNJEMMUNATP;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class PIHADCMPAIT<a> : KBJUJVKWDYX<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class FSAELSPRGFE
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
					public FSAELSPRGFE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x41A7AF0", Offset = "0x41A68F0", VA = "0x1841A7AF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x41A7E30", Offset = "0x41A6C30", VA = "0x1841A7E30", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload GNWJSCZDBBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public PIHADCMPAIT<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FSAELSPRGFE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x62A93D0", Offset = "0x62A81D0", VA = "0x1862A93D0")]
				[AsyncStateMachine(typeof(PIHADCMPAIT<>.FSAELSPRGFE.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task ZDKTVJJONHV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x62A92B0", Offset = "0x62A80B0", VA = "0x1862A92B0")]
				internal void MJMTRVAZOSM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class LSCQLSERMGE
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
					public LSCQLSERMGE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x41BCA70", Offset = "0x41BB870", VA = "0x1841BCA70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public LSCQLSERMGE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x41BE1D0", Offset = "0x41BCFD0", VA = "0x1841BE1D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x41BE8E0", Offset = "0x41BD6E0", VA = "0x1841BE8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public WTNZWELDSYY.OYANJREGTWC EENLUMHIPIR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string HFZHJZZYNVA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string HRGDBLIECOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public PIHADCMPAIT<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper IRDPTXZOFGS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool GVAULOIARME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action OKZWALBAMPY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool WDHQEAFTOEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string WDKKNXWUGFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action FOSBWWHFOOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action MKSEGOZQVFQ;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public LSCQLSERMGE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x68C12E0", Offset = "0x68C00E0", VA = "0x1868C12E0")]
				internal void WPKCEECFLST(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x68C1270", Offset = "0x68C0070", VA = "0x1868C1270")]
				internal void WPEVGXIICHK(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
				internal string ZDSZPFGEOTQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x68C13E0", Offset = "0x68C01E0", VA = "0x1868C13E0")]
				internal void ZDYGMMABYEZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x68C1330", Offset = "0x68C0130", VA = "0x1868C1330")]
				internal bool ZDILURSJVWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x68C1340", Offset = "0x68C0140", VA = "0x1868C1340")]
				internal char ZDNSRYMHFIH((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				internal string? ZEOBEGHUANA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xF1A8E0", Offset = "0xF196E0", VA = "0x180F1A8E0")]
				internal bool ZETIBNBRJYJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x68C15C0", Offset = "0x68C03C0", VA = "0x1868C15C0")]
				internal void ZEDNJSTZHQI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x68C1330", Offset = "0x68C0130", VA = "0x1868C1330")]
				internal bool ZEIUGZNWRBR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x68C1680", Offset = "0x68C0480", VA = "0x1868C1680")]
				[AsyncStateMachine(typeof(PIHADCMPAIT<>.LSCQLSERMGE.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void ZFJCTHJJMGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x68C0F80", Offset = "0x68BFD80", VA = "0x1868C0F80")]
				internal void IOBJBYFYCYW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x68C1080", Offset = "0x68BFE80", VA = "0x1868C1080")]
				[AsyncStateMachine(typeof(PIHADCMPAIT<>.LSCQLSERMGE.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task IPQFNITIVTB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x68C1150", Offset = "0x68BFF50", VA = "0x1868C1150")]
				internal void WNOSCVFDEUQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x68C0EC0", Offset = "0x68BFCC0", VA = "0x1868C0EC0")]
				internal void BNKNIBDXQPS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x68C1720", Offset = "0x68C0520", VA = "0x1868C1720")]
				internal bool ZFOJQODGVRT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class XTGCFERSGLX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter LCICNNBTLHS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public PIHADCMPAIT<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<WTNZWELDSYY.OLWSEMVTLNS> FQNLYFEHVMJ;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public XTGCFERSGLX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x5088AF0", Offset = "0x50878F0", VA = "0x185088AF0")]
				internal bool HMAKCLNCIXR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x5088A30", Offset = "0x5087830", VA = "0x185088A30")]
				internal void CGBOOOQFHGR(WTNZWELDSYY.OLWSEMVTLNS a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class XTAVHXXUXAO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool XACDPSIWVLU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public DUQUSUOTFQH IXEPPAUUSCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public DUQUSUOTFQH UPPPFWROHXX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public DUQUSUOTFQH KEHHYHFBFAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string RDFINPDLGLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public XTGCFERSGLX DODNVPQZHNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action ERVRTDQHCCT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action FPXRGKWPTEI;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public XTAVHXXUXAO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xF3A300", Offset = "0xF39100", VA = "0x180F3A300")]
				internal bool ZRSWKJCWEXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x5087AA0", Offset = "0x50868A0", VA = "0x185087AA0")]
				internal void BQIKQIZBPZC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x50885E0", Offset = "0x50873E0", VA = "0x1850885E0")]
				internal void HMFQZSGZSJA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x5087BA0", Offset = "0x50869A0", VA = "0x185087BA0")]
				internal void HJPFJIIHZRN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x5087BC0", Offset = "0x50869C0", VA = "0x185087BC0")]
				internal void HLPWHXZHQAZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x5087FA0", Offset = "0x5086DA0", VA = "0x185087FA0")]
				internal void HLVDFETEZMI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x5087BA0", Offset = "0x50869A0", VA = "0x185087BA0")]
				internal void CFLTWUINEYQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class XSVOKRDXNPF
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
					public XSVOKRDXNPF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x41D3300", Offset = "0x41D2100", VA = "0x1841D3300", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x41D3940", Offset = "0x41D2740", VA = "0x1841D3940", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool KDKILMVHHVA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public XTAVHXXUXAO DNYGYIXBYCD;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public XSVOKRDXNPF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x50879D0", Offset = "0x50867D0", VA = "0x1850879D0")]
				[AsyncStateMachine(typeof(PIHADCMPAIT<>.XSVOKRDXNPF.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task PDQHEIZAHFW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x5087960", Offset = "0x5086760", VA = "0x185087960")]
				internal void HJJYMBOKQGE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class XSQHNKKAEDW
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
					public XSQHNKKAEDW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x41D2D00", Offset = "0x41D1B00", VA = "0x1841D2D00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x41D32A0", Offset = "0x41D20A0", VA = "0x1841D32A0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload WQDEZVUUOYB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public XTAVHXXUXAO DNTABCDEOQU;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public XSQHNKKAEDW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x5087890", Offset = "0x5086690", VA = "0x185087890")]
				[AsyncStateMachine(typeof(PIHADCMPAIT<>.XSQHNKKAEDW.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task VKKVEMHANAH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x5087820", Offset = "0x5086620", VA = "0x185087820")]
				internal void CFRAUBCKOJZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class ZTAPQDVUGTO
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
					public ZTAPQDVUGTO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x41D2820", Offset = "0x41D1620", VA = "0x1841D2820", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x41D2CA0", Offset = "0x41D1AA0", VA = "0x1841D2CA0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public PIHADCMPAIT<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload OSTZDDYZVZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public WTNZWELDSYY.OLWSEMVTLNS EENLUMHIPIR;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public ZTAPQDVUGTO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5122B70", Offset = "0x5121970", VA = "0x185122B70")]
				[AsyncStateMachine(typeof(PIHADCMPAIT<>.ZTAPQDVUGTO.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task HBAPSOGKVBX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5122920", Offset = "0x5121720", VA = "0x185122920")]
				internal bool DTDJMJSYHMT(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x5122A00", Offset = "0x5121800", VA = "0x185122A00")]
				internal void DTIQJQMVQYC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x5122B20", Offset = "0x5121920", VA = "0x185122B20")]
				internal void DTNXGXGTAJL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class NRXDWRITMNV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string VIYSITFASNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public DUQUSUOTFQH FQOCGVLTZRZ;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public NRXDWRITMNV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x710F920", Offset = "0x710E720", VA = "0x18710F920")]
				internal string? XPLVVFDOLEC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xE8E710", Offset = "0xE8D510", VA = "0x180E8E710")]
				internal bool XPRCSLXLUPL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x710F860", Offset = "0x710E660", VA = "0x18710F860")]
				internal void XPBIARPTSHK(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool SNPFEDYIIXL;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log KNJEMMUNATP
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x73ACE20", Offset = "0x73ABC20", VA = "0x1873ACE20")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x73AF8B0", Offset = "0x73AE6B0", VA = "0x1873AF8B0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected WTNZWELDSYY HZRHTRQMOJF
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xCEA140", Offset = "0xCE8F40", VA = "0x180CEA140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xCE9E40", Offset = "0xCE8C40", VA = "0x180CE9E40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> IZMRLCEQORQ
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xDAC3A0", Offset = "0xDAB1A0", VA = "0x180DAC3A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x10FC8A0", Offset = "0x10FB6A0", VA = "0x1810FC8A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected OJZPKGWLZJE PSUZBOSNHBT
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xF61EF0", Offset = "0xF60CF0", VA = "0x180F61EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x1718C60", Offset = "0x1717A60", VA = "0x181718C60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected TPAZGFUMDNI ZRUTMDXKKDH
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xF61F00", Offset = "0xF60D00", VA = "0x180F61F00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x171B840", Offset = "0x171A640", VA = "0x18171B840")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x6577390", Offset = "0x6576190", VA = "0x186577390")]
			protected PIHADCMPAIT(LLXPXHNGEHC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x73ACEC0", Offset = "0x73ABCC0", VA = "0x1873ACEC0", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x73ACE70", Offset = "0x73ABC70", VA = "0x1873ACE70", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x73AD110", Offset = "0x73ABF10", VA = "0x1873AD110", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x73AF030", Offset = "0x73ADE30", VA = "0x1873AF030")]
			private void LRFOKHDXTOI(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x73AB770", Offset = "0x73AA570", VA = "0x1873AB770", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x73AB970", Offset = "0x73AA770", VA = "0x1873AB970")]
			private void BBXUQARTJWW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x73ADC20", Offset = "0x73ACA20", VA = "0x1873ADC20")]
			private void FWDORZVGFVI(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "151")]
			protected virtual void XTMIMNLIDMV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x73AF680", Offset = "0x73AE480", VA = "0x1873AF680")]
			private void RVLXWKUHMUF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x73AD1A0", Offset = "0x73ABFA0", VA = "0x1873AD1A0")]
			private void ERJTLKVXLYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x73AC0C0", Offset = "0x73AAEC0", VA = "0x1873AC0C0")]
			private void CBKFUCQMRJW(WTNZWELDSYY.OLWSEMVTLNS a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x73ACF10", Offset = "0x73ABD10", VA = "0x1873ACF10")]
			private void DWFVSMKMJGW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x73AF2F0", Offset = "0x73AE0F0", VA = "0x1873AF2F0")]
			protected void NQQYWJGQGEY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x73AF820", Offset = "0x73AE620", VA = "0x1873AF820")]
			private void VEZIVGDLIKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x73AF890", Offset = "0x73AE690", VA = "0x1873AF890")]
			private void VQWJPQTUVAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x73AF320", Offset = "0x73AE120", VA = "0x1873AF320")]
			private void OIBBGCNORMR(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x73AF380", Offset = "0x73AE180", VA = "0x1873AF380")]
			private string QFBTZXEIXLB((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x73AC030", Offset = "0x73AAE30", VA = "0x1873AC030")]
			private string CBIRNMNDYWE(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x73AE740", Offset = "0x73AD540", VA = "0x1873AE740")]
			[CompilerGenerated]
			private object? KXPCZFQJTSY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x73AE770", Offset = "0x73AD570", VA = "0x1873AE770")]
			[CompilerGenerated]
			private void KXUJWMKHDEH(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x73AEEE0", Offset = "0x73ADCE0", VA = "0x1873AEEE0")]
			[CompilerGenerated]
			private IReadOnlyList<object> KYEXQZYBWAZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x73AEF50", Offset = "0x73ADD50", VA = "0x1873AEF50")]
			[CompilerGenerated]
			private void KYKEOGRZFMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x73AEFE0", Offset = "0x73ADDE0", VA = "0x1873AEFE0")]
			[CompilerGenerated]
			private void KZKNAONMARB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x73AD160", Offset = "0x73ABF60", VA = "0x1873AD160")]
			[CompilerGenerated]
			private void EMAPJDNCLQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x73AB440", Offset = "0x73AA240", VA = "0x1873AB440")]
			[CompilerGenerated]
			private void AMFGFRPRBQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x73AE700", Offset = "0x73AD500", VA = "0x1873AE700")]
			[CompilerGenerated]
			private void IWPAXQQRLBA(WTNZWELDSYY.OLWSEMVTLNS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class XLRTGGIDTOU : PIHADCMPAIT<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2B46B40", Offset = "0x2B45940", VA = "0x182B46B40")]
			public XLRTGGIDTOU(LLXPXHNGEHC a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class TRLLOSGWKFW : PIHADCMPAIT<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type VZLUXMAJKRJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x2B3ED70", Offset = "0x2B3DB70", VA = "0x182B3ED70", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope TEVQDBMOQIA
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string ALFYGILKTXA
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x1424830", Offset = "0x1423630", VA = "0x181424830")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EDC0", Offset = "0x2B3DBC0", VA = "0x182B3EDC0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EEB0", Offset = "0x2B3DCB0", VA = "0x182B3EEB0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool WJJAKQGJTCH(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EC60", Offset = "0x2B3DA60", VA = "0x182B3EC60", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EBD0", Offset = "0x2B3D9D0", VA = "0x182B3EBD0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EA80", Offset = "0x2B3D880", VA = "0x182B3EA80", Slot = "7")]
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
				protected virtual Type VZLUXMAJKRJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x2B40870", Offset = "0x2B3F670", VA = "0x182B40870", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers XKCLQHAUVSO
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string ALFYGILKTXA
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x1424830", Offset = "0x1423630", VA = "0x181424830")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2B408C0", Offset = "0x2B3F6C0", VA = "0x182B408C0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2B409B0", Offset = "0x2B3F7B0", VA = "0x182B409B0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool WJJAKQGJTCH(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2B40760", Offset = "0x2B3F560", VA = "0x182B40760", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x2B40580", Offset = "0x2B3F380", VA = "0x182B40580", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x2B40610", Offset = "0x2B3F410", VA = "0x182B40610", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
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
					public KGMFPJNILMO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2B44940", Offset = "0x2B43740", VA = "0x182B44940", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public KGMFPJNILMO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x2B44D50", Offset = "0x2B43B50", VA = "0x182B44D50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public TRLLOSGWKFW XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public OJZPKGWLZJE RHUNWWJOEVV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> ERQKVWWJSRK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> ERVRTDQHCCT;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C2F0", Offset = "0x2B3B0F0", VA = "0x182B3C2F0")]
				internal object? ZTEPANPCJHB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C1C0", Offset = "0x2B3AFC0", VA = "0x182B3C1C0")]
				internal bool ZROLWLLXLUH(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C220", Offset = "0x2B3B020", VA = "0x182B3C220")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void ZSZIDGVEZVS(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BD80", Offset = "0x2B3AB80", VA = "0x182B3BD80")]
				internal IReadOnlyList<TargetPlayersSelection> UZJZAJNDQFH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C3D0", Offset = "0x2B3B1D0", VA = "0x182B3C3D0")]
				internal object? ZTUJSHWULPC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C160", Offset = "0x2B3AF60", VA = "0x182B3C160")]
				internal bool ZRJEZESACIY(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C520", Offset = "0x2B3B320", VA = "0x182B3C520")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void ZUKEKCEMNXD(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> XRCCVQSXMDR;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> LPDCDCQKVIR;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> FSDGIUWMEZH;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2B401C0", Offset = "0x2B3EFC0", VA = "0x182B401C0")]
			public TRLLOSGWKFW(LLXPXHNGEHC a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FA30", Offset = "0x2B3E830", VA = "0x182B3FA30", Slot = "151")]
			protected override void XTMIMNLIDMV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F5D0", Offset = "0x2B3E3D0", VA = "0x182B3F5D0")]
			private static IReadOnlyList<TargetPlayersSelection> NMXDDTUNHXU(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class DARMSNDZWAV : ICXTCJVNTCM<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType TDVSUGBFLAX
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2B31010", Offset = "0x2B2FE10", VA = "0x182B31010")]
			public DARMSNDZWAV(LLXPXHNGEHC a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class FYLBSLZOGPC : KBJUJVKWDYX<RHNNOHYQJTP>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2B38EF0", Offset = "0x2B37CF0", VA = "0x182B38EF0")]
			public FYLBSLZOGPC(LLXPXHNGEHC a, RHNNOHYQJTP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class KBJUJVKWDYX<a> : RCFAQTSGIYC, IDisposable where a : notnull, RHNNOHYQJTP
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class WYUZZVKPLDI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public KBJUJVKWDYX<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public LLXPXHNGEHC GRUXNLQUKNO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a NNIIVWRQNNL;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public WYUZZVKPLDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x85BD900", Offset = "0x85BC700", VA = "0x1885BD900")]
				internal DSBKSSHVDXN QFRUAXVRXFM(SYNKFENOJGY a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class DAGFSZJIMBY
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
					public DAGFSZJIMBY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x41AA5B0", Offset = "0x41A93B0", VA = "0x1841AA5B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string AUPZFZULOTI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, KXUOEYSOWHL>> GKPPGOEITNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public KBJUJVKWDYX<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> JNDAOQFRXOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public WTNZWELDSYY HZRHTRQMOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> OSDPPJBXUZX;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public DAGFSZJIMBY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				internal string ZEFXXULAFDC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				internal void ZELEVBEXOOL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x5328DD0", Offset = "0x5327BD0", VA = "0x185328DD0")]
				[AsyncStateMachine(typeof(KBJUJVKWDYX<>.DAGFSZJIMBY.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void ZEQLSHYUXZU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class YKISGIPBTMX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public YKISGIPBTMX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x50A04D0", Offset = "0x509F2D0", VA = "0x1850A04D0")]
				internal Result<string, KXUOEYSOWHL> FREAPRAPSHU(string a)
				{
					return default(Result<string, KXUOEYSOWHL>);
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
				public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public KBJUJVKWDYX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x6B341A0", Offset = "0x6B32FA0", VA = "0x186B341A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x6B343F0", Offset = "0x6B331F0", VA = "0x186B343F0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public KBJUJVKWDYX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x6B34460", Offset = "0x6B33260", VA = "0x186B34460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x6B34760", Offset = "0x6B33560", VA = "0x186B34760", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly LLXPXHNGEHC HAZSGTNUZYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool AWJRYNEGZZT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<JZROSXUIZUS, DSBKSSHVDXN> QKAXUJHIDAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<JZROSXUIZUS, GQSGWEUJXVS> UNKHXIGLPJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> JLGIMJSYELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<JZROSXUIZUS>>? KUPARSDBAHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<JZROSXUIZUS>, GQSGWEUJXVS>? QQJRBQDPYAQ;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected JOTUAXHHOSV FWCMWMNGSOA
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x676AEE0", Offset = "0x6769CE0", VA = "0x18676AEE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected NGVEIXANPDZ NGVEIXANPDZ
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x676A5A0", Offset = "0x67693A0", VA = "0x18676A5A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected DDEDPKRJVXM ZOPFKZYXSZT
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x676B3E0", Offset = "0x676A1E0", VA = "0x18676B3E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a RHNNOHYQJTP
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<MIMXYJWAARO> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x1667940", Offset = "0x1666740", VA = "0x181667940", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<MIMXYJWAARO>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<CELSXRFYLJZ> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x676BE20", Offset = "0x676AC20", VA = "0x18676BE20", Slot = "6")]
				get
				{
					return default(Id32<CELSXRFYLJZ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x676BC90", Offset = "0x676AA90", VA = "0x18676BC90", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x676BC70", Offset = "0x676AA70", VA = "0x18676BC70", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x676BF80", Offset = "0x676AD80", VA = "0x18676BF80", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<PYGQCMVVAXX> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD5E1B0", Offset = "0xD5CFB0", VA = "0x180D5E1B0", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<PYGQCMVVAXX>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD5F4A0", Offset = "0xD5E2A0", VA = "0x180D5F4A0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xD36B30", Offset = "0xD35930", VA = "0x180D36B30", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x676BB40", Offset = "0x676A940", VA = "0x18676BB40", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x676BB70", Offset = "0x676A970", VA = "0x18676BB70", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x676BBA0", Offset = "0x676A9A0", VA = "0x18676BBA0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x676BE00", Offset = "0x676AC00", VA = "0x18676BE00", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x676BD30", Offset = "0x676AB30", VA = "0x18676BD30", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x676BC10", Offset = "0x676AA10", VA = "0x18676BC10", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x676BBE0", Offset = "0x676A9E0", VA = "0x18676BBE0", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x10B9770", Offset = "0x10B8570", VA = "0x1810B9770", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x17FEA30", Offset = "0x17FD830", VA = "0x1817FEA30")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x676BBD0", Offset = "0x676A9D0", VA = "0x18676BBD0", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x676BCE0", Offset = "0x676AAE0", VA = "0x18676BCE0", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x676BDA0", Offset = "0x676ABA0", VA = "0x18676BDA0", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x676BDD0", Offset = "0x676ABD0", VA = "0x18676BDD0", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x676BD10", Offset = "0x676AB10", VA = "0x18676BD10", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual FKXBKLWMKCJ? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual XUIFPTGWGWM? AWVFPPAZEDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<MVBOYPURKWM>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x676BC40", Offset = "0x676AA40", VA = "0x18676BC40", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<VFKNGTPUEMY> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x676BD50", Offset = "0x676AB50", VA = "0x18676BD50", Slot = "68")]
				get
				{
					return default(Id128<VFKNGTPUEMY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<VFKNGTPUEMY> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x676BCB0", Offset = "0x676AAB0", VA = "0x18676BCB0", Slot = "59")]
				get
				{
					return default(Id32<VFKNGTPUEMY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<VFKNGTPUEMY>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<VFKNGTPUEMY>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x676B340", Offset = "0x676A140", VA = "0x18676B340", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xCF4890", Offset = "0xCF3690", VA = "0x180CF4890", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xCF4810", Offset = "0xCF3610", VA = "0x180CF4810")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xCF4840", Offset = "0xCF3640", VA = "0x180CF4840", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xCF4830", Offset = "0xCF3630", VA = "0x180CF4830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<MVBOYPURKWM> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x676BE60", Offset = "0x676AC60", VA = "0x18676BE60", Slot = "69")]
				get
				{
					return default(Id32<MVBOYPURKWM>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<MVBOYPURKWM> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x676BD80", Offset = "0x676AB80", VA = "0x18676BD80", Slot = "70")]
				get
				{
					return default(Id128<MVBOYPURKWM>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<MVBOYPURKWM>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x676BE80", Offset = "0x676AC80", VA = "0x18676BE80", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<JZROSXUIZUS, GQSGWEUJXVS> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x676BF40", Offset = "0x676AD40", VA = "0x18676BF40", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<JZROSXUIZUS, GQSGWEUJXVS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<JZROSXUIZUS>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action YORNVBRYBCI
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x676AE40", Offset = "0x6769C40", VA = "0x18676AE40", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x6767FE0", Offset = "0x6766DE0", VA = "0x186767FE0", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate JGETTUNIBCN
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x6769330", Offset = "0x6768130", VA = "0x186769330", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x676A500", Offset = "0x6769300", VA = "0x18676A500", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate PMYDLKNSJRY
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x6767D40", Offset = "0x6766B40", VA = "0x186767D40", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x6767F40", Offset = "0x6766D40", VA = "0x186767F40", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action MEWHMXOEETQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x6767C90", Offset = "0x6766A90", VA = "0x186767C90", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x676B380", Offset = "0x676A180", VA = "0x18676B380", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action ZTOKFYXDIJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x676A690", Offset = "0x6769490", VA = "0x18676A690", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x6767EA0", Offset = "0x6766CA0", VA = "0x186767EA0", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<JZROSXUIZUS>, GQSGWEUJXVS> XCLSMBWGSAG
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x67687D0", Offset = "0x67675D0", VA = "0x1867687D0", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x6768890", Offset = "0x6767690", VA = "0x186768890", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<JZROSXUIZUS>, GQSGWEUJXVS> UVGPODTYSBP
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x67693D0", Offset = "0x67681D0", VA = "0x1867693D0", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x6767700", Offset = "0x6766500", VA = "0x186767700", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<JZROSXUIZUS>> KHTLALUJZKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x6767DE0", Offset = "0x6766BE0", VA = "0x186767DE0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x676AF40", Offset = "0x6769D40", VA = "0x18676AF40", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<JZROSXUIZUS>, Id32<JZROSXUIZUS>> BXXBVGIRMJQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x676B620", Offset = "0x676A420", VA = "0x18676B620", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x676B130", Offset = "0x6769F30", VA = "0x18676B130", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<JZROSXUIZUS>, GQSGWEUJXVS> VYCMQJTRHFE
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x676AD80", Offset = "0x6769B80", VA = "0x18676AD80", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x676ABA0", Offset = "0x67699A0", VA = "0x18676ABA0", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<JZROSXUIZUS>, Id32<JZROSXUIZUS>> MULNPNCMFBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x6769AF0", Offset = "0x67688F0", VA = "0x186769AF0", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x6768710", Offset = "0x6767510", VA = "0x186768710", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> TVRGLJJFLQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x6769CB0", Offset = "0x6768AB0", VA = "0x186769CB0", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x6767640", Offset = "0x6766440", VA = "0x186767640", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x676B6E0", Offset = "0x676A4E0", VA = "0x18676B6E0")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected KBJUJVKWDYX(LLXPXHNGEHC a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x6768950", Offset = "0x6767750", VA = "0x186768950", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x6767860", Offset = "0x6766660", VA = "0x186767860", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x6769120", Offset = "0x6767F20", VA = "0x186769120", Slot = "9")]
			public Task<Result<None, KXUOEYSOWHL>> KIPCQKUSCVH(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x6769180", Offset = "0x6767F80", VA = "0x186769180")]
			public bool XGRQRERSDIN([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x6768B40", Offset = "0x6767940", VA = "0x186768B40")]
			public bool JEDDTLQJACY([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x676B000", Offset = "0x6769E00", VA = "0x18676B000", Slot = "34")]
			public void XGOXSDXRKBO(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x676A930", Offset = "0x6769730", VA = "0x18676A930", Slot = "35")]
			public Task UEQZHJJANYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x676B1F0", Offset = "0x6769FF0", VA = "0x18676B1F0", Slot = "36")]
			[AsyncStateMachine(typeof(KBJUJVKWDYX<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, KXUOEYSOWHL>> YEPUEPOVGIP(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "119")]
			public virtual void FOEWVGRGTIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x108BE30", Offset = "0x108AC30", VA = "0x18108BE30")]
			protected void MZESUNAOEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x2145FB0", Offset = "0x2144DB0", VA = "0x182145FB0")]
			protected void YKVJUSUPBXR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x2124850", Offset = "0x2123650", VA = "0x182124850")]
			private void JJPUHJWNCUZ([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x67691B0", Offset = "0x6767FB0", VA = "0x1867691B0", Slot = "122")]
			public virtual Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> MHPCPSFSVBE(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x6769270", Offset = "0x6768070", VA = "0x186769270", Slot = "123")]
			public virtual Task<Result<None, KXUOEYSOWHL>> MMMZDJENDIJ(Id32<JZROSXUIZUS> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "124")]
			public virtual void IUGXBVFTPEF(Id32<JZROSXUIZUS> sourceId, Id32<JZROSXUIZUS> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x67677C0", Offset = "0x67665C0", VA = "0x1867677C0", Slot = "125")]
			public virtual IEnumerable<JGWKKBUFZYH> DUJBWDOEHRQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x6769BB0", Offset = "0x67689B0", VA = "0x186769BB0", Slot = "126")]
			public Result<None, KXUOEYSOWHL> OIBAERYOMUP(string a)
			{
				return default(Result<None, KXUOEYSOWHL>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x6769000", Offset = "0x6767E00", VA = "0x186769000", Slot = "50")]
			public bool KFQXOLQDWGT([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x6769870", Offset = "0x6768670", VA = "0x186769870")]
			public bool NZOTNQXEITS([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "128")]
			public virtual void VQXVFMLZTPE(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "129")]
			public virtual CSDXQPGYSGZ BVPMVKIVOUC([In] LYAASBGQQTG audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x676B4C0", Offset = "0x676A2C0", VA = "0x18676B4C0")]
			protected void ZBLCHRLNMVO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x676B340", Offset = "0x676A140", VA = "0x18676B340", Slot = "134")]
			protected virtual bool YEVCODTPDUJ(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x6768B10", Offset = "0x6767910", VA = "0x186768B10", Slot = "96")]
			public bool JCTTXVQWGOT(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "135")]
			protected virtual bool FHONXKGWKOW(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected virtual void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x676A170", Offset = "0x6768F70", VA = "0x18676A170")]
			protected void QMRJFADXWEU(WTNZWELDSYY a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, KXUOEYSOWHL>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x676A730", Offset = "0x6769530", VA = "0x18676A730")]
			protected void RJBLTDCGAJA(WTNZWELDSYY a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x6769DE0", Offset = "0x6768BE0", VA = "0x186769DE0", Slot = "146")]
			protected virtual void PPZYFLVGNHB(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x6767B90", Offset = "0x6766990", VA = "0x186767B90", Slot = "90")]
			public void EKGLSWLZJCK(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x6768B70", Offset = "0x6767970", VA = "0x186768B70", Slot = "91")]
			public CircuitsRigidTransform JMMWMHXOYPJ()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "149")]
			public virtual bool ZULHNUQVRVV(Id32<JZROSXUIZUS> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x6769850", Offset = "0x6768650", VA = "0x186769850")]
			private void NWEOKRGCMHU([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x6769BF0", Offset = "0x67689F0", VA = "0x186769BF0")]
			private void ONBYWCZYMIX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x108BE30", Offset = "0x108AC30", VA = "0x18108BE30", Slot = "97")]
			private void SGNUUWKYMXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x67681C0", Offset = "0x6766FC0", VA = "0x1867681C0", Slot = "99")]
			private void IKOVCKDFRDN(Id32<JZROSXUIZUS> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x4EE6130", Offset = "0x4EE4F30", VA = "0x184EE6130", Slot = "101")]
			private void DRQDZYMCTYQ(Id32<JZROSXUIZUS> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x6768080", Offset = "0x6766E80", VA = "0x186768080", Slot = "103")]
			private void ICUGUNOWMGS(Id32<JZROSXUIZUS> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x6769490", Offset = "0x6768290", VA = "0x186769490", Slot = "104")]
			private void NSPRFIDLPBU(Id32<JZROSXUIZUS> sourceId, Id32<JZROSXUIZUS> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x6767620", Offset = "0x6766420", VA = "0x186767620", Slot = "105")]
			private void ANNKRFKMZVZ(Id32<JZROSXUIZUS> sourceId, Id32<JZROSXUIZUS> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x1736330", Offset = "0x1735130", VA = "0x181736330", Slot = "98")]
			private void PLNXYIAQSAW(Id32<JZROSXUIZUS> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x6768BE0", Offset = "0x67679E0", VA = "0x186768BE0", Slot = "100")]
			private void JPAAOQBMZRJ(Id32<JZROSXUIZUS> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x6769D70", Offset = "0x6768B70", VA = "0x186769D70", Slot = "102")]
			private void PFQUZLBVHGR(Id32<JZROSXUIZUS> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x6767C70", Offset = "0x6766A70", VA = "0x186767C70", Slot = "106")]
			private void FDYACXGPZFR(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x676AC60", Offset = "0x6769A60", VA = "0x18676AC60", Slot = "150")]
			[AsyncStateMachine(typeof(KBJUJVKWDYX<>.<RequestNameChange>d__224))]
			public Task<Result<None, KXUOEYSOWHL>> VMBRTTJDBPD(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x6767BE0", Offset = "0x67669E0", VA = "0x186767BE0", Slot = "57")]
			private void EVHLNWMGAHJ(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x676B0A0", Offset = "0x6769EA0", VA = "0x18676B0A0", Slot = "58")]
			private void XYIPURNSEMI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x6769180", Offset = "0x6767F80", VA = "0x186769180", Slot = "30")]
			private bool MEUZYTWUYAM([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x6768B40", Offset = "0x6767940", VA = "0x186768B40", Slot = "32")]
			private bool NJGRBTQZUPT([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x676A150", Offset = "0x6768F50", VA = "0x18676A150", Slot = "51")]
			private bool QEMWNZPZAQR([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4890", Offset = "0xCF3690", VA = "0x180CF4890")]
			[CompilerGenerated]
			private string UIDTUFHONSF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x676AA30", Offset = "0x6769830", VA = "0x18676AA30")]
			[CompilerGenerated]
			private void UHYMWYNREGW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class CZABJAODLGK : DHPGNARRYIZ<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xF04BB0", Offset = "0xF039B0", VA = "0x180F04BB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2B30FB0", Offset = "0x2B2FDB0", VA = "0x182B30FB0")]
			public CZABJAODLGK(LLXPXHNGEHC a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class RKCAHPXICKM : KBJUJVKWDYX<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> WXVGLAFORFZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public RKCAHPXICKM XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> OLTQXICDCVX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> NATBSJKYVCV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B430", Offset = "0x2B3A230", VA = "0x182B3B430")]
				internal int THULNZWJZKW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B080", Offset = "0x2B39E80", VA = "0x182B3B080")]
				internal void THPEQTCMPZN(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E7D0", Offset = "0x2B3D5D0", VA = "0x182B3E7D0")]
			public RKCAHPXICKM(LLXPXHNGEHC a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E4F0", Offset = "0x2B3D2F0", VA = "0x182B3E4F0", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class YYDRTHLXVOC : OTWRLMXKIIM<CEIACCWKIGH>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B489C0", Offset = "0x2B477C0", VA = "0x182B489C0")]
			public YYDRTHLXVOC(LLXPXHNGEHC a, CEIACCWKIGH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class HVZJSLDHZHG : KBJUJVKWDYX<BZUXYXVJVMV>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public HVZJSLDHZHG XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B30A90", Offset = "0x2B2F890", VA = "0x182B30A90")]
				internal bool THZSLGQHIWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B302C0", Offset = "0x2B2F0C0", VA = "0x182B302C0")]
				internal void THULNZWJZKW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B39BC0", Offset = "0x2B389C0", VA = "0x182B39BC0")]
			public HVZJSLDHZHG(LLXPXHNGEHC a, BZUXYXVJVMV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B399F0", Offset = "0x2B387F0", VA = "0x182B399F0", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class YAKERUHXMFH : KBJUJVKWDYX<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
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
					public KGMFPJNILMO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x2B45CA0", Offset = "0x2B44AA0", VA = "0x182B45CA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x2B45ED0", Offset = "0x2B44CD0", VA = "0x182B45ED0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NIRDECYLBLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public YAKERUHXMFH XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> GAVSVFWHKZD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> LQOVEHZJZSR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B610", Offset = "0x2B3A410", VA = "0x182B3B610")]
				internal int THULNZWJZKW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B1C0", Offset = "0x2B39FC0", VA = "0x182B3B1C0")]
				internal void THPEQTCMPZN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AF90", Offset = "0x2B39D90", VA = "0x182B3AF90")]
				internal int THJXTMIPGOE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BBA0", Offset = "0x2B3A9A0", VA = "0x182B3BBA0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> TIUUAHRWUPP(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AD90", Offset = "0x2B39B90", VA = "0x182B3AD90")]
				internal int GQMXJVJUHMJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BF60", Offset = "0x2B3AD60", VA = "0x182B3BF60")]
				internal void ZOAIJUEPKVX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BF10", Offset = "0x2B3AD10", VA = "0x182B3BF10")]
				internal int ZNVBMNKSBKO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BE80", Offset = "0x2B3AC80", VA = "0x182B3BE80")]
				internal void ZNPUPGQURZF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BE30", Offset = "0x2B3AC30", VA = "0x182B3BE30")]
				internal int ZNKNRZWXINW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C0D0", Offset = "0x2B3AED0", VA = "0x182B3C0D0")]
				internal void ZOVJYVGEWPH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C080", Offset = "0x2B3AE80", VA = "0x182B3C080")]
				internal int ZOQDBOMHNDY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BFF0", Offset = "0x2B3ADF0", VA = "0x182B3BFF0")]
				internal void ZOKWEHSKDSP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BB50", Offset = "0x2B3A950", VA = "0x182B3BB50")]
				internal float TIPNDAXZLEG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BAC0", Offset = "0x2B3A8C0", VA = "0x182B3BAC0")]
				internal void TIKGFUECBSX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BA70", Offset = "0x2B3A870", VA = "0x182B3BA70")]
				internal float TIEZINKESHO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BCF0", Offset = "0x2B3AAF0", VA = "0x182B3BCF0")]
				internal void TJPVPITMGIZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BCA0", Offset = "0x2B3AAA0", VA = "0x182B3BCA0")]
				internal bool TJKOSBZOWXQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AC20", Offset = "0x2B39A20", VA = "0x182B3AC20")]
				internal void GORNIMMSAOG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2B3ACB0", Offset = "0x2B39AB0", VA = "0x182B3ACB0")]
				internal int GOWUFTGPJZP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AB40", Offset = "0x2B39940", VA = "0x182B3AB40")]
				internal void GOGZNYYXHRO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3ABD0", Offset = "0x2B399D0", VA = "0x182B3ABD0")]
				internal float GOMGLFSURCX()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AA60", Offset = "0x2B39860", VA = "0x182B3AA60")]
				internal void GNWLTLLCOUW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AAF0", Offset = "0x2B398F0", VA = "0x182B3AAF0")]
				internal float GOBSQSEZYGF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A980", Offset = "0x2B39780", VA = "0x182B3A980")]
				internal void GNLXYXXHVYE(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AA10", Offset = "0x2B39810", VA = "0x182B3AA10")]
				internal bool GNREWERFFJN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AD00", Offset = "0x2B39B00", VA = "0x182B3AD00")]
				internal void GQHQMOPWYBA(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B485B0", Offset = "0x2B473B0", VA = "0x182B485B0")]
			public YAKERUHXMFH(LLXPXHNGEHC a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B474C0", Offset = "0x2B462C0", VA = "0x182B474C0", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class QTJALRVPIQM : QUKBOKSTSIL<RecNetImageNode>
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
				public QTJALRVPIQM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B454D0", Offset = "0x2B442D0", VA = "0x182B454D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E2A0", Offset = "0x2B3D0A0", VA = "0x182B3E2A0")]
			public QTJALRVPIQM(LLXPXHNGEHC a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DDD0", Offset = "0x2B3CBD0", VA = "0x182B3DDD0", Slot = "151")]
			protected override void GTLEJOLGLKI(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E100", Offset = "0x2B3CF00", VA = "0x182B3E100")]
			[CompilerGenerated]
			private string? RIXKCKRPEEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E1D0", Offset = "0x2B3CFD0", VA = "0x182B3E1D0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void RJCQZRLMNPJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class ICXTCJVNTCM<a> : KBJUJVKWDYX<a> where a : notnull, RTSVKTHTXFS
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class KRDFVZFEZPK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NIRDECYLBLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public ICXTCJVNTCM<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> GAVSVFWHKZD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> LQOVEHZJZSR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType YURNXKFIQXJ;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KRDFVZFEZPK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> THZSLGQHIWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x6796A40", Offset = "0x6795840", VA = "0x186796A40")]
				internal int THULNZWJZKW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x6796850", Offset = "0x6795650", VA = "0x186796850")]
				internal void THPEQTCMPZN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x6796800", Offset = "0x6795600", VA = "0x186796800")]
				internal void THJXTMIPGOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x6796C10", Offset = "0x6795A10", VA = "0x186796C10")]
				internal void TIUUAHRWUPP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x6796B60", Offset = "0x6795960", VA = "0x186796B60")]
				internal bool TIPNDAXZLEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x6796BC0", Offset = "0x67959C0", VA = "0x186796BC0")]
				internal void TIKGFUECBSX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x6796B60", Offset = "0x6795960", VA = "0x186796B60")]
				internal bool TIEZINKESHO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x6796DB0", Offset = "0x6795BB0", VA = "0x186796DB0")]
				internal float TJPVPITMGIZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x6796D20", Offset = "0x6795B20", VA = "0x186796D20")]
				internal void TJKOSBZOWXQ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x67966E0", Offset = "0x67954E0", VA = "0x1867966E0")]
				internal float GORNIMMSAOG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x6796710", Offset = "0x6795510", VA = "0x186796710")]
				internal void GOWUFTGPJZP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x6796620", Offset = "0x6795420", VA = "0x186796620")]
				internal float GOGZNYYXHRO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x6796650", Offset = "0x6795450", VA = "0x186796650")]
				internal void GOMGLFSURCX(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType TDVSUGBFLAX
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x6577390", Offset = "0x6576190", VA = "0x186577390")]
			public ICXTCJVNTCM(LLXPXHNGEHC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x6576980", Offset = "0x6575780", VA = "0x186576980", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class TOAPFESTXGI : KBJUJVKWDYX<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xF34B10", Offset = "0xF33910", VA = "0x180F34B10", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F560", Offset = "0x2B3E360", VA = "0x182B3F560")]
			public TOAPFESTXGI(LLXPXHNGEHC a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class MDBXGRJVARL : FQLYDQRWMSN<IKCEJUKPDLN>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C900", Offset = "0x2B3B700", VA = "0x182B3C900")]
			public MDBXGRJVARL(LLXPXHNGEHC a, IKCEJUKPDLN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class JVKHCZBKFGR : FQLYDQRWMSN<EMGGVUCRDXM>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A920", Offset = "0x2B39720", VA = "0x182B3A920")]
			public JVKHCZBKFGR(LLXPXHNGEHC a, EMGGVUCRDXM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class FQLYDQRWMSN<a> : KBJUJVKWDYX<a> where a : notnull, GYQIKOLQJRZ
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
				public FQLYDQRWMSN<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x41AA3C0", Offset = "0x41A91C0", VA = "0x1841AA3C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class QNWEWNJMZCT
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
					public QNWEWNJMZCT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x41A90C0", Offset = "0x41A7EC0", VA = "0x1841A90C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public QNWEWNJMZCT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x41A9490", Offset = "0x41A8290", VA = "0x1841A9490", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public QNWEWNJMZCT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x41A9B40", Offset = "0x41A8940", VA = "0x1841A9B40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public QNWEWNJMZCT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x41AA0D0", Offset = "0x41A8ED0", VA = "0x1841AA0D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int ALPNKJZOFUT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry YITORTJZDWX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public FQLYDQRWMSN<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<QUZNMKSIOOE, bool> FPXRGKWPTEI;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public QNWEWNJMZCT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x75F91F0", Offset = "0x75F7FF0", VA = "0x1875F91F0")]
				internal bool THJXTMIPGOE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x75F9420", Offset = "0x75F8220", VA = "0x1875F9420")]
				internal void TIUUAHRWUPP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				internal string TIPNDAXZLEG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x75F9360", Offset = "0x75F8160", VA = "0x1875F9360")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.QNWEWNJMZCT.<<BuildConfigMenuInternal>b__6>d))]
				internal void TIKGFUECBSX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x75F9250", Offset = "0x75F8050", VA = "0x1875F9250")]
				internal int TIEZINKESHO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x75F9060", Offset = "0x75F7E60", VA = "0x1875F9060")]
				internal bool GOMGLFSURCX(QUZNMKSIOOE a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x75F9490", Offset = "0x75F8290", VA = "0x1875F9490")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.QNWEWNJMZCT.<<BuildConfigMenuInternal>b__8>d))]
				internal void TJPVPITMGIZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
				internal string GORNIMMSAOG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x75F9080", Offset = "0x75F7E80", VA = "0x1875F9080")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.QNWEWNJMZCT.<<BuildConfigMenuInternal>b__11>d))]
				internal void GOWUFTGPJZP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x75F8FC0", Offset = "0x75F7DC0", VA = "0x1875F8FC0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.QNWEWNJMZCT.<<BuildConfigMenuInternal>b__12>d))]
				internal void GOGZNYYXHRO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class UACGPVXXMUQ
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x41A3510", Offset = "0x41A2310", VA = "0x1841A3510", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x41A3890", Offset = "0x41A2690", VA = "0x1841A3890", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x41A3C60", Offset = "0x41A2A60", VA = "0x1841A3C60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x41A4230", Offset = "0x41A3030", VA = "0x1841A4230", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x41A44C0", Offset = "0x41A32C0", VA = "0x1841A44C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x41A4850", Offset = "0x41A3650", VA = "0x1841A4850", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x41A4BE0", Offset = "0x41A39E0", VA = "0x1841A4BE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x41A4E70", Offset = "0x41A3C70", VA = "0x1841A4E70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x41A5200", Offset = "0x41A4000", VA = "0x1841A5200", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x41A5590", Offset = "0x41A4390", VA = "0x1841A5590", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x41A5910", Offset = "0x41A4710", VA = "0x1841A5910", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x41A5BA0", Offset = "0x41A49A0", VA = "0x1841A5BA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x41A5F30", Offset = "0x41A4D30", VA = "0x1841A5F30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x41A61C0", Offset = "0x41A4FC0", VA = "0x1841A61C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x41A6550", Offset = "0x41A5350", VA = "0x1841A6550", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x41A68D0", Offset = "0x41A56D0", VA = "0x1841A68D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
					public UACGPVXXMUQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x41A6C50", Offset = "0x41A5A50", VA = "0x1841A6C50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public FQLYDQRWMSN<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int ALPNKJZOFUT;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public UACGPVXXMUQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE9D0", Offset = "0x7CCD7D0", VA = "0x187CCE9D0")]
				internal bool MXBGPGFDDEF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE960", Offset = "0x7CCD760", VA = "0x187CCE960")]
				internal void MWVZRZLFTSW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x7CCF060", Offset = "0x7CCDE60", VA = "0x187CCF060")]
				internal object TBQWPVBBSLW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x7CCF100", Offset = "0x7CCDF00", VA = "0x187CCF100")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__13>d))]
				internal void TBWDNBUZBXF(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEF00", Offset = "0x7CCDD00", VA = "0x187CCEF00")]
				internal string TBGIVHNGZPE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEFA0", Offset = "0x7CCDDA0", VA = "0x187CCEFA0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__15>d))]
				internal void TBLPSOHEJAN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEDF0", Offset = "0x7CCDBF0", VA = "0x187CCEDF0")]
				internal bool TAVVATZMGSM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEE70", Offset = "0x7CCDC70", VA = "0x187CCEE70")]
				internal bool TBBBYATJQDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEC90", Offset = "0x7CCDA90", VA = "0x187CCEC90")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__18>d))]
				internal void TALHGGLRNVU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x7CCED40", Offset = "0x7CCDB40", VA = "0x187CCED40")]
				internal int TAQODNFOXHD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE3C0", Offset = "0x7CCD1C0", VA = "0x187CCE3C0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__20>d))]
				internal void MBKFLQGTVQF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE330", Offset = "0x7CCD130", VA = "0x187CCE330")]
				internal bool MBEYOJMWMEW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE280", Offset = "0x7CCD080", VA = "0x187CCE280")]
				internal float MAZRRCSZCTN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE1D0", Offset = "0x7CCCFD0", VA = "0x187CCE1D0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__23>d))]
				internal void MAUKTVZBTIE(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE640", Offset = "0x7CCD440", VA = "0x187CCE640")]
				internal bool MCFHARIJHJP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE5B0", Offset = "0x7CCD3B0", VA = "0x187CCE5B0")]
				internal bool MCAADKOLXYG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE500", Offset = "0x7CCD300", VA = "0x187CCE500")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__26>d))]
				internal void MBUTGDUOOMX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE470", Offset = "0x7CCD270", VA = "0x187CCE470")]
				internal int MBPMIXARFBO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE120", Offset = "0x7CCCF20", VA = "0x187CCE120")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__28>d))]
				internal void LZUCHODOYDL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE090", Offset = "0x7CCCE90", VA = "0x187CCE090")]
				internal bool LZOVKHJROSC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC280", Offset = "0x7CCB080", VA = "0x187CCC280")]
				internal float GAQZAFXRRUE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC310", Offset = "0x7CCB110", VA = "0x187CCC310")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__31>d))]
				internal void GAWFXMRPBFN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC3C0", Offset = "0x7CCB1C0", VA = "0x187CCC3C0")]
				internal bool GBBMUTLMKQW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC450", Offset = "0x7CCB250", VA = "0x187CCC450")]
				internal bool GBGTSAFJUCF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC4D0", Offset = "0x7CCB2D0", VA = "0x187CCC4D0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__34>d))]
				internal void GBMAPGZHDNO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC580", Offset = "0x7CCB380", VA = "0x187CCC580")]
				internal bool GBRHMNTEMYX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC610", Offset = "0x7CCB410", VA = "0x187CCC610")]
				internal bool GBWOJUNBWKG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC6A0", Offset = "0x7CCB4A0", VA = "0x187CCC6A0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__37>d))]
				internal void GCBVHBGZFVP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC140", Offset = "0x7CCAF40", VA = "0x187CCC140")]
				internal int FZAVWDUMUHK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x7CCC1D0", Offset = "0x7CCAFD0", VA = "0x187CCC1D0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__39>d))]
				internal void FZGCTKOKDST(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x7CCBD80", Offset = "0x7CCAB80", VA = "0x187CCBD80")]
				internal bool AYYYAFRPKAX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x7CCBCF0", Offset = "0x7CCAAF0", VA = "0x187CCBCF0")]
				internal float AYTRCYXSAPO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x7CCBEA0", Offset = "0x7CCACA0", VA = "0x187CCBEA0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__42>d))]
				internal void AZJLUTFKCXP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x7CCBE10", Offset = "0x7CCAC10", VA = "0x187CCBE10")]
				internal bool AZEEXMLMTMG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x7CCBBE0", Offset = "0x7CCA9E0", VA = "0x187CCBBE0")]
				internal bool AYDWLEPZYHN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x7CCBB30", Offset = "0x7CCA930", VA = "0x187CCBB30")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__45>d))]
				internal void AXYPNXWCOWE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x7CCBC60", Offset = "0x7CCAA60", VA = "0x187CCBC60")]
				internal bool AYOKFSDUREF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE8D0", Offset = "0x7CCD6D0", VA = "0x187CCE8D0")]
				internal bool MWQSUSRIKHN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE820", Offset = "0x7CCD620", VA = "0x187CCE820")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__3>d))]
				internal void MWLLXLXLAWE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEC00", Offset = "0x7CCDA00", VA = "0x187CCEC00")]
				internal int MXWIEHGSOXP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEB50", Offset = "0x7CCD950", VA = "0x187CCEB50")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__5>d))]
				internal void MXRBHAMVFMG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEAC0", Offset = "0x7CCD8C0", VA = "0x187CCEAC0")]
				internal bool MXLUJTSXWAX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x7CCEA30", Offset = "0x7CCD830", VA = "0x187CCEA30")]
				internal bool MXGNMMZAMPO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE770", Offset = "0x7CCD570", VA = "0x187CCE770")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__8>d))]
				internal void MVLDLEBYFRL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x7CCE6D0", Offset = "0x7CCD4D0", VA = "0x187CCE6D0")]
				internal int MVFWNXIAWGC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x7CCF1C0", Offset = "0x7CCDFC0", VA = "0x187CCF1C0")]
				[AsyncStateMachine(typeof(FQLYDQRWMSN<>.UACGPVXXMUQ.<<AddConstraintOptions>b__10>d))]
				internal void TCBKKIOWLIO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x7CCF270", Offset = "0x7CCE070", VA = "0x187CCF270")]
				internal bool TCGRHPITUTX()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> UDASBXFULYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> PMGDSJPJNNW;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<QUZNMKSIOOE> JALYTMLZHBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x62A8990", Offset = "0x62A7790", VA = "0x1862A8990")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x62A89E0", Offset = "0x62A77E0", VA = "0x1862A89E0")]
			public FQLYDQRWMSN(LLXPXHNGEHC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x62A7120", Offset = "0x62A5F20", VA = "0x1862A7120", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x62A6100", Offset = "0x62A4F00", VA = "0x1862A6100", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x62A72D0", Offset = "0x62A60D0", VA = "0x1862A72D0")]
			private TPAZGFUMDNI TNMCYFOIPXR(WTNZWELDSYY a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x62A7230", Offset = "0x62A6030", VA = "0x1862A7230")]
			[AsyncStateMachine(typeof(FQLYDQRWMSN<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void PZOEKUSCMQB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x62A71D0", Offset = "0x62A5FD0", VA = "0x1862A71D0")]
			[CompilerGenerated]
			private bool PYYJTAKKKIA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class OXMBNRGDWXV : KBJUJVKWDYX<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class FUIFISZXLYJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public OXMBNRGDWXV XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FUIFISZXLYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x2B386D0", Offset = "0x2B374D0", VA = "0x182B386D0")]
				internal int THULNZWJZKW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x2B38570", Offset = "0x2B37370", VA = "0x182B38570")]
				internal void THPEQTCMPZN(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? KXEYSHSTNKO;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DBD0", Offset = "0x2B3C9D0", VA = "0x182B3DBD0")]
			public OXMBNRGDWXV(LLXPXHNGEHC a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D870", Offset = "0x2B3C670", VA = "0x182B3D870", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class GVMIMFIGTYZ : ICXTCJVNTCM<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType TDVSUGBFLAX
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x2B38F60", Offset = "0x2B37D60", VA = "0x182B38F60")]
			public GVMIMFIGTYZ(LLXPXHNGEHC a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class YFYOJIISMZQ : OTWRLMXKIIM<JGHLQBCNLBV>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x2B48620", Offset = "0x2B47420", VA = "0x182B48620")]
			public YFYOJIISMZQ(LLXPXHNGEHC a, JGHLQBCNLBV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class TXGINUOERZH : OTWRLMXKIIM<SJORCYKVULA>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2B40220", Offset = "0x2B3F020", VA = "0x182B40220")]
			public TXGINUOERZH(LLXPXHNGEHC a, SJORCYKVULA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class JSHRPAZQJXN : QUKBOKSTSIL<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
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
					public BAWJCOIJFZS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x2B451C0", Offset = "0x2B43FC0", VA = "0x182B451C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public JSHRPAZQJXN XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F870", Offset = "0x2B2E670", VA = "0x182B2F870")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void HWQXIQNOGGI(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A520", Offset = "0x2B39320", VA = "0x182B3A520")]
			public JSHRPAZQJXN(LLXPXHNGEHC a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A220", Offset = "0x2B39020", VA = "0x182B3A220", Slot = "151")]
			protected override void GTLEJOLGLKI(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class DVMJVKFDBJE : ICXTCJVNTCM<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType TDVSUGBFLAX
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x2B36930", Offset = "0x2B35730", VA = "0x182B36930")]
			public DVMJVKFDBJE(LLXPXHNGEHC a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class HOLMFZVRMCL : KBJUJVKWDYX<VYWHDCWWHIV>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xF021D0", Offset = "0xF00FD0", VA = "0x180F021D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B39980", Offset = "0x2B38780", VA = "0x182B39980")]
			public HOLMFZVRMCL(LLXPXHNGEHC a, VYWHDCWWHIV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class JGFMOTFCFSW : KBJUJVKWDYX<TUEABSNRVIL>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool VIVQWOUKWET
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A1B0", Offset = "0x2B38FB0", VA = "0x182B3A1B0")]
			public JGFMOTFCFSW(LLXPXHNGEHC a, TUEABSNRVIL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B39DF0", Offset = "0x2B38BF0", VA = "0x182B39DF0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A100", Offset = "0x2B38F00", VA = "0x182B3A100")]
			private int CDJOGYKPPAA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A140", Offset = "0x2B38F40", VA = "0x182B3A140")]
			private void VBIFFCRVBSQ(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class OLXLYOKRIMJ : FYLBSLZOGPC
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B38EF0", Offset = "0x2B37CF0", VA = "0x182B38EF0")]
			public OLXLYOKRIMJ(LLXPXHNGEHC a, RHNNOHYQJTP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class HFSDSFMCFTN : KBJUJVKWDYX<CSEESALEULK>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public HFSDSFMCFTN XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B820", Offset = "0x2B3A620", VA = "0x182B3B820")]
				internal int THZSLGQHIWF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B730", Offset = "0x2B3A530", VA = "0x182B3B730")]
				internal void THULNZWJZKW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B030", Offset = "0x2B39E30", VA = "0x182B3B030")]
				internal int THPEQTCMPZN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AEF0", Offset = "0x2B39CF0", VA = "0x182B3AEF0")]
				internal void THJXTMIPGOE(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xD1ED90", Offset = "0xD1DB90", VA = "0x180D1ED90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B39840", Offset = "0x2B38640", VA = "0x182B39840")]
			public HFSDSFMCFTN(LLXPXHNGEHC a, CSEESALEULK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B39530", Offset = "0x2B38330", VA = "0x182B39530", Slot = "145")]
			protected sealed override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class HIGXUTVDHYE : QUKBOKSTSIL<JTEFRZMDVTP>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B39920", Offset = "0x2B38720", VA = "0x182B39920")]
			public HIGXUTVDHYE(LLXPXHNGEHC a, JTEFRZMDVTP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class QUKBOKSTSIL<a> : KBJUJVKWDYX<a> where a : notnull, JTEFRZMDVTP
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class PDHGCPSPZDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public QUKBOKSTSIL<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public PDHGCPSPZDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x739F2B0", Offset = "0x739E0B0", VA = "0x18739F2B0")]
				internal bool THZSLGQHIWF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x739F220", Offset = "0x739E020", VA = "0x18739F220")]
				internal void THULNZWJZKW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x739F1F0", Offset = "0x739DFF0", VA = "0x18739F1F0")]
				internal bool THPEQTCMPZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x739F160", Offset = "0x739DF60", VA = "0x18739F160")]
				internal void THJXTMIPGOE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x739F2E0", Offset = "0x739E0E0", VA = "0x18739F2E0")]
				internal bool TIUUAHRWUPP()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class BEKRWCFQTJI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public DDEDPKRJVXM UJFNZJSNUXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public QUKBOKSTSIL<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BEKRWCFQTJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x4EB37B0", Offset = "0x4EB25B0", VA = "0x184EB37B0")]
				internal void HWQXIQNOGGI(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xD51490", Offset = "0xD50290", VA = "0x180D51490", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x75FA080", Offset = "0x75F8E80", VA = "0x1875FA080", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x75F9F70", Offset = "0x75F8D70", VA = "0x1875F9F70")]
			protected QUKBOKSTSIL(LLXPXHNGEHC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x75F9B60", Offset = "0x75F8960", VA = "0x1875F9B60", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x75F97F0", Offset = "0x75F85F0", VA = "0x1875F97F0", Slot = "145")]
			protected override void ATPRXHZGBIT(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x75F9C50", Offset = "0x75F8A50", VA = "0x1875F9C50", Slot = "151")]
			protected virtual void GTLEJOLGLKI(WTNZWELDSYY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x75F9F30", Offset = "0x75F8D30", VA = "0x1875F9F30", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EEB0", Offset = "0x2B0DCB0", VA = "0x182B0EEB0")]
		public static RCFAQTSGIYC New(LLXPXHNGEHC circuitsManager, RHNNOHYQJTP node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class DAXQQWKRPBA : ASFIUQEBYGU, UJTJHRBJORV, EJMDVNERXCJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<ADNWLQIRYCV> SQMDLVVWWZH
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xEFC1E0", Offset = "0xEFAFE0", VA = "0x180EFC1E0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<ADNWLQIRYCV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<GSCEPPXRFGV> FKDKAOLNOMA
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x150B2E0", Offset = "0x150A0E0", VA = "0x18150B2E0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GSCEPPXRFGV>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x23D29A0", Offset = "0x23D17A0", VA = "0x1823D29A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<ECXPGDQVCNG> WOUFEHZGMDM
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x143F260", Offset = "0x143E060", VA = "0x18143F260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<JLWXVUGZAYX> RNAIGZXNMVI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B313C0", Offset = "0x2B301C0", VA = "0x182B313C0", Slot = "22")]
			get
			{
				return default(Id32<JLWXVUGZAYX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B31410", Offset = "0x2B30210", VA = "0x182B31410")]
		private DAXQQWKRPBA(LLXPXHNGEHC a, RHNNOHYQJTP b, RMMJZKVAGYT c, Id32<JZROSXUIZUS> portGroupId, Id32<GSCEPPXRFGV> outputId, Id32<ECXPGDQVCNG> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B31070", Offset = "0x2B2FE70", VA = "0x182B31070")]
		public static DAXQQWKRPBA New(LLXPXHNGEHC circuitsManager, RHNNOHYQJTP node, RMMJZKVAGYT output, Id32<JZROSXUIZUS> portGroupId, Id32<ECXPGDQVCNG> outputDefId, Id32<GSCEPPXRFGV> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x23D29A0", Offset = "0x23D17A0", VA = "0x1823D29A0")]
		internal void VMCEOLZMTOC(Id32<GSCEPPXRFGV> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class ASFIUQEBYGU : EJMDVNERXCJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private VKPDSJMBHGQ? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C860", Offset = "0x2B3B660", VA = "0x182B3C860")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C870", Offset = "0x2B3B670", VA = "0x182B3C870")]
			public VKPDSJMBHGQ IBYJLGVILPY(ASFIUQEBYGU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly RHNNOHYQJTP QDVZSGCUNKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter QXSMMSUJANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly HGGRTRYERAD PBRMZNQVFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<HDXYIKUSRWF> TJQHIQKCCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<XUPEIDPVXKP> YEYSTFVWZMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool YMBXFOGYSZA;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> KOJZEXVHDRE
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B2EDC0", Offset = "0x2B2DBC0", VA = "0x182B2EDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind IANNOZJJDWP
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xD03CE0", Offset = "0xD02AE0", VA = "0x180D03CE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<VFKNGTPUEMY> GVZZKOSKQLI
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DFC0", Offset = "0x2B2CDC0", VA = "0x182B2DFC0", Slot = "6")]
			get
			{
				return default(Id32<VFKNGTPUEMY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<VFKNGTPUEMY> EVOJSUDBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DE30", Offset = "0x2B2CC30", VA = "0x182B2DE30", Slot = "7")]
			get
			{
				return default(Id128<VFKNGTPUEMY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public QUZNMKSIOOE AMTJXBGTSGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F270", Offset = "0x2B2E070", VA = "0x182B2F270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public TSAPSMXEATI PLCZODLNKZI
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F1E0", Offset = "0x2B2DFE0", VA = "0x182B2F1E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected VKPDSJMBHGQ AJBBBUFDTEV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F1E0", Offset = "0x2B2DFE0", VA = "0x182B2F1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage NFVZLEOYEZF
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F290", Offset = "0x2B2E090", VA = "0x182B2F290", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<MVBOYPURKWM> NWJBNCEDCTN
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F1C0", Offset = "0x2B2DFC0", VA = "0x182B2F1C0", Slot = "9")]
			get
			{
				return default(Id128<MVBOYPURKWM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<JZROSXUIZUS> YPSSOCIGWUY
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xEE5F80", Offset = "0xEE4D80", VA = "0x180EE5F80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<JZROSXUIZUS>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1AA2FA0", Offset = "0x1AA1DA0", VA = "0x181AA2FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<JLWXVUGZAYX> RNAIGZXNMVI
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool ZOCZPCYAEUX
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xF423C0", Offset = "0xF411C0", VA = "0x180F423C0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F620", Offset = "0x2B2E420", VA = "0x182B2F620")]
		protected ASFIUQEBYGU(LLXPXHNGEHC a, RHNNOHYQJTP b, HGGRTRYERAD c, Id32<JZROSXUIZUS> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E310", Offset = "0x2B2D110", VA = "0x182B2E310", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DE60", Offset = "0x2B2CC60", VA = "0x182B2DE60", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EF00", Offset = "0x2B2DD00", VA = "0x182B2EF00", Slot = "14")]
		public void LKPUPJCSJSY(HDXYIKUSRWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F3D0", Offset = "0x2B2E1D0", VA = "0x182B2F3D0", Slot = "15")]
		public void WNPFVEUSYQC(XUPEIDPVXKP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DFF0", Offset = "0x2B2CDF0", VA = "0x182B2DFF0")]
		private bool IJAKXQAMWNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E570", Offset = "0x2B2D370", VA = "0x182B2E570", Slot = "17")]
		public void LGEEUZYQBKG(LLHGVIFHYRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F160", Offset = "0x2B2DF60", VA = "0x182B2F160", Slot = "25")]
		protected virtual void MPTMCGDYLPK(LLHGVIFHYRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E3F0", Offset = "0x2B2D1F0", VA = "0x182B2E3F0", Slot = "20")]
		private void KXJZOHXZQNF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EFB0", Offset = "0x2B2DDB0", VA = "0x182B2EFB0")]
		private void MNKNQJYUTFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F480", Offset = "0x2B2E280", VA = "0x182B2F480")]
		private void XEBBHKESCGM([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DDD0", Offset = "0x2B2CBD0", VA = "0x182B2DDD0", Slot = "18")]
		public void AQNBTXIQPEJ(HDXYIKUSRWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DF60", Offset = "0x2B2CD60", VA = "0x182B2DF60", Slot = "19")]
		public void HFJAECUXBYT(XUPEIDPVXKP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
		internal void ICXUSNKIVYI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DF40", Offset = "0x2B2CD40", VA = "0x182B2DF40")]
		internal void FCWYOQAFCYX(NGVEIXANPDZ a, QUZNMKSIOOE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2FA0", Offset = "0x1AA1DA0", VA = "0x181AA2FA0")]
		internal void BGXASJLLNZQ(Id32<JZROSXUIZUS> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class DSBKSSHVDXN : GQSGWEUJXVS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class MWANHRAESJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public LLXPXHNGEHC GRUXNLQUKNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public RHNNOHYQJTP NNIIVWRQNNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<JZROSXUIZUS> COIOZZGOOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool YUSHFDZWAJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool GOCNLKGTCCU;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public MWANHRAESJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CA30", Offset = "0x2B3B830", VA = "0x182B3CA30")]
			internal SUTBLLTSGFX STCFGWQIDTZ((int PortDescIndex, int PortIndex, WAEZPDCZVBS InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C960", Offset = "0x2B3B760", VA = "0x182B3C960")]
			internal DAXQQWKRPBA SSWYJPWKUIQ(RMMJZKVAGYT a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2B40A80", Offset = "0x2B3F880", VA = "0x182B40A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2B40EF0", Offset = "0x2B3FCF0", VA = "0x182B40EF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<KKVGGBONUEH> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2B42190", Offset = "0x2B40F90", VA = "0x182B42190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2B424E0", Offset = "0x2B412E0", VA = "0x182B424E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2B42550", Offset = "0x2B41350", VA = "0x182B42550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2B429D0", Offset = "0x2B417D0", VA = "0x182B429D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<ECXPGDQVCNG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2B42A40", Offset = "0x2B41840", VA = "0x182B42A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2B42D90", Offset = "0x2B41B90", VA = "0x182B42D90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2B435C0", Offset = "0x2B423C0", VA = "0x182B435C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2B43910", Offset = "0x2B42710", VA = "0x182B43910", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<KKVGGBONUEH> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2B42E00", Offset = "0x2B41C00", VA = "0x182B42E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2B43170", Offset = "0x2B41F70", VA = "0x182B43170", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<ECXPGDQVCNG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2B431E0", Offset = "0x2B41FE0", VA = "0x182B431E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2B43550", Offset = "0x2B42350", VA = "0x182B43550", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public WIBHTRDJIRP type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<KKVGGBONUEH> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2B43980", Offset = "0x2B42780", VA = "0x182B43980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2B43D20", Offset = "0x2B42B20", VA = "0x182B43D20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public WIBHTRDJIRP type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<ECXPGDQVCNG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2B43D90", Offset = "0x2B42B90", VA = "0x182B43D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2B44130", Offset = "0x2B42F30", VA = "0x182B44130", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<KKVGGBONUEH> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<KKVGGBONUEH> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2B441A0", Offset = "0x2B42FA0", VA = "0x182B441A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2B44500", Offset = "0x2B43300", VA = "0x182B44500", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public DSBKSSHVDXN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<ECXPGDQVCNG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<ECXPGDQVCNG> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private XXFEIMFXUFV <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x2B44570", Offset = "0x2B43370", VA = "0x182B44570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x2B448D0", Offset = "0x2B436D0", VA = "0x182B448D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool MLELWXCPLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool YWTYETNNZRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<LMZHXZTZMKK, SUTBLLTSGFX> GJDBYFSVAXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<LMZHXZTZMKK, MNOVJCUCTWS> FQHBCSCQMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly RHNNOHYQJTP QDVZSGCUNKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<GSCEPPXRFGV, DAXQQWKRPBA> NGZWYRDLHEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<GSCEPPXRFGV, UJTJHRBJORV> RUXNDTDBFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? NVDWVNPGHUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly SYNKFENOJGY ZGSOACBMFRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<JZROSXUIZUS> FROMGRNOJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool AWJRYNEGZZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? VMYCYBZNKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? GTUGEQJHAYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<LMZHXZTZMKK>>? YLKUEAXUUIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<GSCEPPXRFGV>>? NXRVMXBXZHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private GQSGWEUJXVS.PortGroupIdChangeDelegate? MVRKVPZAQGF;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool QUPJPZANTRX
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B33540", Offset = "0x2B32340", VA = "0x182B33540", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool SUNMZQMWIWW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B32CE0", Offset = "0x2B31AE0", VA = "0x182B32CE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool SGIPPNXETEA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B32020", Offset = "0x2B30E20", VA = "0x182B32020", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<VFKNGTPUEMY> EVOJSUDBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B31850", Offset = "0x2B30650", VA = "0x182B31850", Slot = "7")]
			get
			{
				return default(Id128<VFKNGTPUEMY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool UVDOCFQBCHA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B317D0", Offset = "0x2B305D0", VA = "0x182B317D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<LMZHXZTZMKK, MNOVJCUCTWS> DATGAKDCFWU
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<LMZHXZTZMKK, MNOVJCUCTWS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B34250", Offset = "0x2B33050", VA = "0x182B34250", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<MVBOYPURKWM> NWJBNCEDCTN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B34EA0", Offset = "0x2B33CA0", VA = "0x182B34EA0", Slot = "11")]
			get
			{
				return default(Id128<MVBOYPURKWM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<GSCEPPXRFGV, UJTJHRBJORV> RQRLHTQNUCN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<GSCEPPXRFGV, UJTJHRBJORV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<JZROSXUIZUS> YPSSOCIGWUY
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x10136E0", Offset = "0x10124E0", VA = "0x1810136E0", Slot = "13")]
			get
			{
				return default(Id32<JZROSXUIZUS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? DLWDZCFGUSW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B35700", Offset = "0x2B34500", VA = "0x182B35700", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B31F80", Offset = "0x2B30D80", VA = "0x182B31F80", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? JNJQNONRGVX
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B33490", Offset = "0x2B32290", VA = "0x182B33490", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B34CD0", Offset = "0x2B33AD0", VA = "0x182B34CD0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<LMZHXZTZMKK?>, Id32<LMZHXZTZMKK?>>? MQAEKUKEQEG
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B33E50", Offset = "0x2B32C50", VA = "0x182B33E50", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B32A40", Offset = "0x2B31840", VA = "0x182B32A40", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<LMZHXZTZMKK?>, Id32<LMZHXZTZMKK?>>? FJNKKIOSYPV
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B33D90", Offset = "0x2B32B90", VA = "0x182B33D90", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2B357A0", Offset = "0x2B345A0", VA = "0x182B357A0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<GSCEPPXRFGV?>, Id32<GSCEPPXRFGV?>>? ZOHTEBQTYZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2B33CD0", Offset = "0x2B32AD0", VA = "0x182B33CD0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2B365F0", Offset = "0x2B353F0", VA = "0x182B365F0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<GSCEPPXRFGV?>, Id32<GSCEPPXRFGV?>>? COUIBMACAKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2B32D20", Offset = "0x2B31B20", VA = "0x182B32D20", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2B34080", Offset = "0x2B32E80", VA = "0x182B34080", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<LMZHXZTZMKK?>, MNOVJCUCTWS?>? XOIYEYZTEZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2B36770", Offset = "0x2B35570", VA = "0x182B36770", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2B33340", Offset = "0x2B32140", VA = "0x182B33340", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<LMZHXZTZMKK?>>? QBERZLCFZWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2B363B0", Offset = "0x2B351B0", VA = "0x182B363B0", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2B35F00", Offset = "0x2B34D00", VA = "0x182B35F00", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<LMZHXZTZMKK?>, MNOVJCUCTWS?>? IOYNVYCTDPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2B32740", Offset = "0x2B31540", VA = "0x182B32740", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2B36530", Offset = "0x2B35330", VA = "0x182B36530", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<GSCEPPXRFGV?>, UJTJHRBJORV?>? JIPZOCTETTY
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2B320E0", Offset = "0x2B30EE0", VA = "0x182B320E0", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2B366B0", Offset = "0x2B354B0", VA = "0x182B366B0", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<GSCEPPXRFGV?>>? MBWYMDMTKJR
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2B36470", Offset = "0x2B35270", VA = "0x182B36470", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2B362F0", Offset = "0x2B350F0", VA = "0x182B362F0", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<GSCEPPXRFGV?>, UJTJHRBJORV?>? ICTKOBTVGIO
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x2B31EA0", Offset = "0x2B30CA0", VA = "0x182B31EA0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x2B36100", Offset = "0x2B34F00", VA = "0x182B36100", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2B36830", Offset = "0x2B35630", VA = "0x182B36830")]
		private DSBKSSHVDXN(bool a, LLXPXHNGEHC b, bool c, ReadOnlyIdArray<LMZHXZTZMKK, SUTBLLTSGFX> inputs, ReadOnlyIdArray<LMZHXZTZMKK, MNOVJCUCTWS> inputsAsStaticInputs, RHNNOHYQJTP d, ReadOnlyIdArray<GSCEPPXRFGV, DAXQQWKRPBA> outputs, ReadOnlyIdArray<GSCEPPXRFGV, UJTJHRBJORV> outputsAsStaticOutputs, string? overrideName, SYNKFENOJGY e, Id32<JZROSXUIZUS> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2B34280", Offset = "0x2B33080", VA = "0x182B34280")]
		public static DSBKSSHVDXN New(bool canInteract, LLXPXHNGEHC circuitsManager, bool hasFunctionHeader, RHNNOHYQJTP node, SYNKFENOJGY portGroup, Id32<JZROSXUIZUS> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2B321A0", Offset = "0x2B30FA0", VA = "0x182B321A0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2B32520", Offset = "0x2B31320", VA = "0x182B32520", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, KXUOEYSOWHL?>>? EEZZVWBDRAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2B32800", Offset = "0x2B31600", VA = "0x182B32800")]
		private (DGIELOZOQSW?, int)? FBDKFGWXIOT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2B33600", Offset = "0x2B32400", VA = "0x182B33600", Slot = "58")]
		private void JSECNBZEWMZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2396F90", Offset = "0x2395D90", VA = "0x182396F90", Slot = "57")]
		private void NIHALWMCMXK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2B35330", Offset = "0x2B34130", VA = "0x182B35330", Slot = "61")]
		private void QCICWCBAMGO(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2B33400", Offset = "0x2B32200", VA = "0x182B33400", Slot = "63")]
		private void IIQXYSCOFYJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2B35860", Offset = "0x2B34660", VA = "0x182B35860", Slot = "50")]
		private void SNSDYKPNLUI(int a, Id32<LMZHXZTZMKK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2B360E0", Offset = "0x2B34EE0", VA = "0x182B360E0", Slot = "54")]
		private void UDQRVLXNOJD(int a, Id32<LMZHXZTZMKK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2B33710", Offset = "0x2B32510", VA = "0x182B33710", Slot = "49")]
		private void KYRKGFOXIET(int a, Id32<LMZHXZTZMKK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2B32EF0", Offset = "0x2B31CF0", VA = "0x182B32EF0", Slot = "53")]
		private void ICXEYXIOPQM(int a, Id32<LMZHXZTZMKK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2B31D30", Offset = "0x2B30B30", VA = "0x182B31D30", Slot = "66")]
		private void DBBRIJXZBPA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x10FA860", Offset = "0x10F9660", VA = "0x1810FA860", Slot = "65")]
		private void WGWRLVOGKHV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2B34140", Offset = "0x2B32F40", VA = "0x182B34140", Slot = "60")]
		private void NNGRKWRAXYU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2396F90", Offset = "0x2395D90", VA = "0x182396F90", Slot = "59")]
		private void LBCIBSMLEHF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2B34900", Offset = "0x2B33700", VA = "0x182B34900", Slot = "62")]
		private void OJLHTTQXREJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B00", Offset = "0x2B31900", VA = "0x182B32B00", Slot = "64")]
		private void GAKAXUCHRIM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2B33730", Offset = "0x2B32530", VA = "0x182B33730", Slot = "52")]
		private void LBSTBTRWQCD(int a, Id32<GSCEPPXRFGV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B90", Offset = "0x2B31990", VA = "0x182B32B90", Slot = "56")]
		private void GFRKGRASTOU(int a, Id32<GSCEPPXRFGV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2B31F60", Offset = "0x2B30D60", VA = "0x182B31F60", Slot = "51")]
		private void DEXMJXHXRQS(int a, Id32<GSCEPPXRFGV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2B34EC0", Offset = "0x2B33CC0", VA = "0x182B34EC0", Slot = "55")]
		private void PSMBGFUTKFV(int a, Id32<GSCEPPXRFGV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2B33F10", Offset = "0x2B32D10", VA = "0x182B33F10", Slot = "68")]
		private void NHLWTBSBFXB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x10FA860", Offset = "0x10F9660", VA = "0x1810FA860", Slot = "67")]
		private void FDQANHASUBO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B32DE0", Offset = "0x2B31BE0", VA = "0x182B32DE0", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, KXUOEYSOWHL?>>? HSDALZMEWVU(Id32<KKVGGBONUEH> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C20", Offset = "0x2B30A20", VA = "0x182B31C20", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, KXUOEYSOWHL?>>? BSSNXLOCHHV(Id32<ECXPGDQVCNG> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2B35FC0", Offset = "0x2B34DC0", VA = "0x182B35FC0", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, KXUOEYSOWHL?>>? TLGIWNIPGXK(Id32<KKVGGBONUEH> inputDefId, Id32<KKVGGBONUEH> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2B316B0", Offset = "0x2B304B0", VA = "0x182B316B0", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, KXUOEYSOWHL?>>? AFCASXWSKMP(Id32<ECXPGDQVCNG> outputDefId, Id32<ECXPGDQVCNG> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2B35E10", Offset = "0x2B34C10", VA = "0x182B35E10", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, KXUOEYSOWHL?>>? SRNDJVFQLWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2B34D80", Offset = "0x2B33B80", VA = "0x182B34D80", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, KXUOEYSOWHL>> PFEHKEJRIOT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2B361C0", Offset = "0x2B34FC0", VA = "0x182B361C0", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, KXUOEYSOWHL>> VEEFURDKJDK(Id32<KKVGGBONUEH> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2B32610", Offset = "0x2B31410", VA = "0x182B32610", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, KXUOEYSOWHL>> EIVYKKUEJOB(Id32<ECXPGDQVCNG> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2B347D0", Offset = "0x2B335D0", VA = "0x182B347D0", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, KXUOEYSOWHL>> OHNMHLEBWXJ(Id32<KKVGGBONUEH> inputDefId, WIBHTRDJIRP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2B32BB0", Offset = "0x2B319B0", VA = "0x182B32BB0", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, KXUOEYSOWHL>> GHNEUMMIAQA(Id32<ECXPGDQVCNG> outputDefId, WIBHTRDJIRP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2B31880", Offset = "0x2B30680", VA = "0x182B31880")]
		internal void BGXASJLLNZQ(Id32<JZROSXUIZUS> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class QMPJCTMUYTR : JIWOOULRLNI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface VAEKADQIRNQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<VFKNGTPUEMY>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<VFKNGTPUEMY>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			NGVEIXANPDZ NGVEIXANPDZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> IHSEPREMFWI(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> DLQHZUVIOOD(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<QQTMRMGIVHL> XYHFQGQTOYA(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<OLWPCSTJAJP> RDBPHSTCAJH(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> GTLZUYMLGFU(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> EHKSOMSWIFT(CancellationToken a);
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
			public AsyncTaskMethodBuilder<QMPJCTMUYTR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public LLXPXHNGEHC circuitsManager;

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
			private VAEKADQIRNQ <selfDeps>5__2;

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
			private QQTMRMGIVHL <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private OLWPCSTJAJP <playerSaveData>5__8;

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
			private TaskAwaiter<QQTMRMGIVHL> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<OLWPCSTJAJP> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<VAEKADQIRNQ.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<KQGIQGHQWFJ> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2B40F60", Offset = "0x2B3FD60", VA = "0x182B40F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x2B42120", Offset = "0x2B40F20", VA = "0x182B42120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public KQGIQGHQWFJ KQGIQGHQWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DTVWGYMCAFJ DTVWGYMCAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public IEHBRUQETQY IEHBRUQETQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public FWCMWMNGSOA FWCMWMNGSOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1117370", Offset = "0x1116170", VA = "0x181117370")]
		private QMPJCTMUYTR(KQGIQGHQWFJ a, DTVWGYMCAFJ b, IEHBRUQETQY c, FWCMWMNGSOA d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DC40", Offset = "0x2B3CA40", VA = "0x182B3DC40")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<QMPJCTMUYTR> AZGBFOPLRRC(LLXPXHNGEHC a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DDB0", Offset = "0x2B3CBB0", VA = "0x182B3DDB0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class ASQXBOGBPNB : CKOFKQCSIRY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public DPQXPCGEPOV? GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F770", Offset = "0x2B2E570", VA = "0x182B2F770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		internal ASQXBOGBPNB(LLXPXHNGEHC a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class IEHBRUQETQY : DPQXPCGEPOV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly KQGIQGHQWFJ MRRWNSCAHPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly ASQXBOGBPNB VBQXWOALLYE;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> JKNUYWEEFCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x2B39CF0", Offset = "0x2B38AF0", VA = "0x182B39CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xDB85D0", Offset = "0xDB73D0", VA = "0x180DB85D0")]
		public IEHBRUQETQY(LLXPXHNGEHC a, KQGIQGHQWFJ b, ASQXBOGBPNB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x2B39CA0", Offset = "0x2B38AA0", VA = "0x182B39CA0", Slot = "5")]
		public string MHBREHJHIHY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2B39D30", Offset = "0x2B38B30", VA = "0x182B39D30", Slot = "6")]
		public void WHKOODFFYAR(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2B55990", Offset = "0x2B54790", VA = "0x182B55990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2B55BD0", Offset = "0x2B549D0", VA = "0x182B55BD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, KXUOEYSOWHL>> <>t__builder;

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
			private JGWKKBUFZYH[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2B563D0", Offset = "0x2B551D0", VA = "0x182B563D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2B567A0", Offset = "0x2B555A0", VA = "0x182B567A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public JGWKKBUFZYH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AAC0", Offset = "0x2B598C0", VA = "0x182B5AAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AF40", Offset = "0x2B59D40", VA = "0x182B5AF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly KVHMMDKOSSW _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		public EVRequestExtended(KVHMMDKOSSW staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2B37760", Offset = "0x2B36560", VA = "0x182B37760")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, KXUOEYSOWHL>> VXFKWVSXXWO(JGWKKBUFZYH a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2B37510", Offset = "0x2B36310", VA = "0x182B37510")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, KXUOEYSOWHL?>>? DIMTORJFOMV(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2B37670", Offset = "0x2B36470", VA = "0x182B37670")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, KXUOEYSOWHL>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface MVPDPCIQCZK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		JIWOOULRLNI? GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool CNIJHGRHCUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<JIWOOULRLNI?>? YUTABFJSTLS();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task QYUMOCPMOJP(LLXPXHNGEHC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface JIWOOULRLNI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		KQGIQGHQWFJ KQGIQGHQWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		DTVWGYMCAFJ DTVWGYMCAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		IEHBRUQETQY IEHBRUQETQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		FWCMWMNGSOA FWCMWMNGSOA
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class ZIDUMWQPXUZ
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DC80", Offset = "0x2B5CA80", VA = "0x182B5DC80")]
		public static ReducerFactory<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>> BEBOFEYSTNQ([In] this ReducerFactory<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class RQYUBWNGBFC : ZSLWBLIWJVX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool CNIJHGRHCUT
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x2B52FE0", Offset = "0x2B51DE0", VA = "0x182B52FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		internal RQYUBWNGBFC(LLXPXHNGEHC a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class CKJZCISSPQR : YSFHOOMHOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A6A0", Offset = "0x2B494A0", VA = "0x182B4A6A0", Slot = "4")]
		public QVAECGOHISE? OQZMOSWLJWH(string? a, string? b, string? c, RoomDoorData.SFCQHHVLTYC.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A730", Offset = "0x2B49530", VA = "0x182B4A730", Slot = "5")]
		public POEXEFDWBXM YVMSMZRKTCX(string a, string b, List<string> c, int d, int e, int f, int g, BIBLRNEKMWA h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A600", Offset = "0x2B49400", VA = "0x182B4A600", Slot = "6")]
		public BIBLRNEKMWA JFAHIQVDXVZ(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public CKJZCISSPQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class BLLRRQUGYXB : OMCYRLAITOG
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
			public AsyncTaskMethodBuilder<JOTUAXHHOSV> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public BLLRRQUGYXB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<JIWOOULRLNI?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2B55C40", Offset = "0x2B54A40", VA = "0x182B55C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2B55ED0", Offset = "0x2B54CD0", VA = "0x182B55ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public JOTUAXHHOSV? GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2B49E10", Offset = "0x2B48C10", VA = "0x182B49E10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public FWCMWMNGSOA? PCDPXUYZLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2B49E90", Offset = "0x2B48C90", VA = "0x182B49E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool OVOUOWMJLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2B49F10", Offset = "0x2B48D10", VA = "0x182B49F10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool CNNVGAETXSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2B49DB0", Offset = "0x2B48BB0", VA = "0x182B49DB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A3E0", Offset = "0x2B491E0", VA = "0x182B4A3E0")]
		internal BLLRRQUGYXB(LLXPXHNGEHC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A2F0", Offset = "0x2B490F0", VA = "0x182B4A2F0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<JOTUAXHHOSV> YUTABFJSTLS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2B49F70", Offset = "0x2B48D70", VA = "0x182B49F70", Slot = "9")]
		public IReadOnlyDictionary<Id128<VFKNGTPUEMY>, Guid> VEZLUWZCDMS(IEnumerable<PBCTZJZFZQR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2B49A30", Offset = "0x2B48830", VA = "0x182B49A30", Slot = "10")]
		public CircuitGraphToolMappingRegistryData IHJPOTYBPXS(IEnumerable<PBCTZJZFZQR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x2B49BE0", Offset = "0x2B489E0", VA = "0x182B49BE0")]
		public Result<CircuitsRoomData, SEZYOHJZPUT> PHJHELVYHFO([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, SEZYOHJZPUT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2B49BB0", Offset = "0x2B489B0", VA = "0x182B49BB0", Slot = "8")]
		private Result<CircuitsRoomData, SEZYOHJZPUT> NGSOVKRMPSR([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, SEZYOHJZPUT>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class FWCMWMNGSOA : JOTUAXHHOSV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class SGUWFBCNDXR
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class BAWJCOIJFZS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int DFXRLIJJAHW;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public BAWJCOIJFZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2B49A10", Offset = "0x2B48810", VA = "0x182B49A10")]
				internal void YVYHWNUQKGN(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2B54CB0", Offset = "0x2B53AB0", VA = "0x182B54CB0")]
			public static Result<JOTUAXHHOSV.PrepareTemplateForCloneResult, KTYXBBLRCBW> YFLRTADXTVQ(FWCMWMNGSOA a, [In] JOTUAXHHOSV.PrepareTemplateForCloneArgs args)
			{
				return default(Result<JOTUAXHHOSV.PrepareTemplateForCloneResult, KTYXBBLRCBW>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2B53000", Offset = "0x2B51E00", VA = "0x182B53000")]
			internal static Result<(AWSLABQICSJ, CircuitTemplateRootData), KTYXBBLRCBW> AJUSJHBCSJC(FWCMWMNGSOA a, CircuitTemplateRootData b, bool c, [In] Id128<VFKNGTPUEMY> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(AWSLABQICSJ, CircuitTemplateRootData), KTYXBBLRCBW>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2B54290", Offset = "0x2B53090", VA = "0x182B54290")]
			private static void OUAIULDVYTA(bool a, PBCTZJZFZQR b, AWSLABQICSJ c, [In] Id128<VFKNGTPUEMY> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2B53E90", Offset = "0x2B52C90", VA = "0x182B53E90")]
			public static void CROUVMZSXVV(XXNMIZBSSLG a, [In] JOTUAXHHOSV.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2B54720", Offset = "0x2B53520", VA = "0x182B54720")]
			[CompilerGenerated]
			internal static bool XECXLQVRWOO(KQGIQGHQWFJ a, LBBVNSEAAOY b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x2B53E60", Offset = "0x2B52C60", VA = "0x182B53E60")]
			[CompilerGenerated]
			internal static bool CBYOFELLXGD(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class CHLASOLICSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public FWCMWMNGSOA XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<VFKNGTPUEMY> YXILNKMLYCZ;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public CHLASOLICSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A5C0", Offset = "0x2B493C0", VA = "0x182B4A5C0")]
			internal Id128<MVBOYPURKWM> RWBGTVZJJMO(Id32<MVBOYPURKWM> a)
			{
				return default(Id128<MVBOYPURKWM>);
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<ADNWLQIRYCV> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<QLUJOYTGVHG> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2B56810", Offset = "0x2B55610", VA = "0x182B56810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2B56DE0", Offset = "0x2B55BE0", VA = "0x182B56DE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<JZROSXUIZUS> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<KKVGGBONUEH> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2B56E50", Offset = "0x2B55C50", VA = "0x182B56E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2B571A0", Offset = "0x2B55FA0", VA = "0x182B571A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<MVBOYPURKWM>, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<CELSXRFYLJZ> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private KQGIQGHQWFJ <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2B574F0", Offset = "0x2B562F0", VA = "0x182B574F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2B57920", Offset = "0x2B56720", VA = "0x182B57920", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2B57210", Offset = "0x2B56010", VA = "0x182B57210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2B57480", Offset = "0x2B56280", VA = "0x182B57480", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2B57990", Offset = "0x2B56790", VA = "0x182B57990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2B57B80", Offset = "0x2B56980", VA = "0x182B57B80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<VFKNGTPUEMY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<MVBOYPURKWM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<MVBOYPURKWM>> nodeIds;

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
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2B57BF0", Offset = "0x2B569F0", VA = "0x182B57BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2B57E90", Offset = "0x2B56C90", VA = "0x182B57E90", Slot = "5")]
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
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<VFKNGTPUEMY> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<MVBOYPURKWM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<MVBOYPURKWM>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<JZROSXUIZUS>, Id32<LMZHXZTZMKK>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<JZROSXUIZUS>, Id32<GSCEPPXRFGV>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2B57F00", Offset = "0x2B56D00", VA = "0x182B57F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2B584D0", Offset = "0x2B572D0", VA = "0x182B584D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<VFKNGTPUEMY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<MVBOYPURKWM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<MVBOYPURKWM>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2B58530", Offset = "0x2B57330", VA = "0x182B58530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2B58740", Offset = "0x2B57540", VA = "0x182B58740", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<MVBOYPURKWM> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<JZROSXUIZUS> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<LMZHXZTZMKK> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2B587B0", Offset = "0x2B575B0", VA = "0x182B587B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2B58B00", Offset = "0x2B57900", VA = "0x182B58B00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<JZROSXUIZUS> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<KKVGGBONUEH> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2B58B70", Offset = "0x2B57970", VA = "0x182B58B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2B58F50", Offset = "0x2B57D50", VA = "0x182B58F50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2B58FC0", Offset = "0x2B57DC0", VA = "0x182B58FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2B59240", Offset = "0x2B58040", VA = "0x182B59240", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<MVBOYPURKWM> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<JZROSXUIZUS> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<GSCEPPXRFGV> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B592B0", Offset = "0x2B580B0", VA = "0x182B592B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2B59600", Offset = "0x2B58400", VA = "0x182B59600", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2B59670", Offset = "0x2B58470", VA = "0x182B59670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2B599B0", Offset = "0x2B587B0", VA = "0x182B599B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2B59A20", Offset = "0x2B58820", VA = "0x182B59A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2B59CB0", Offset = "0x2B58AB0", VA = "0x182B59CB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2B59D20", Offset = "0x2B58B20", VA = "0x182B59D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2B59FB0", Offset = "0x2B58DB0", VA = "0x182B59FB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<MVBOYPURKWM>>, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<VFKNGTPUEMY> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<PBCTZJZFZQR> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<RHNNOHYQJTP>, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A020", Offset = "0x2B58E20", VA = "0x182B5A020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A7C0", Offset = "0x2B595C0", VA = "0x182B5A7C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<VFKNGTPUEMY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<MVBOYPURKWM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<MVBOYPURKWM>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5A830", Offset = "0x2B59630", VA = "0x182B5A830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AA50", Offset = "0x2B59850", VA = "0x182B5AA50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public FWCMWMNGSOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<VFKNGTPUEMY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<MVBOYPURKWM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AFB0", Offset = "0x2B59DB0", VA = "0x182B5AFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B1D0", Offset = "0x2B59FD0", VA = "0x182B5B1D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly LLXPXHNGEHC HAZSGTNUZYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly KQGIQGHQWFJ MRRWNSCAHPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers GVDKJPPTFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly BLLRRQUGYXB GZDBDQFCLVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<MVBOYPURKWM>, RCFAQTSGIYC> NRVYWKNPQJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<MVBOYPURKWM>>? MEWHMXOEETQ;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<VFKNGTPUEMY> IEACVMUMPRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CDD0", Offset = "0x2B4BBD0", VA = "0x182B4CDD0", Slot = "4")]
			get
			{
				return default(Id128<VFKNGTPUEMY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers VSODADWLCIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2B4AC00", Offset = "0x2B49A00", VA = "0x182B4AC00", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> UPFQTGEITVL
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F810", Offset = "0x2B4E610", VA = "0x182B4F810", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action KXMLARZFEGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CA40", Offset = "0x2B4B840", VA = "0x182B4CA40", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B51DD0", Offset = "0x2B50BD0", VA = "0x182B51DD0", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> TTYGBPQHXXG
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B511A0", Offset = "0x2B4FFA0", VA = "0x182B511A0", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F700", Offset = "0x2B4E500", VA = "0x182B4F700", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2B51F70", Offset = "0x2B50D70", VA = "0x182B51F70")]
		public FWCMWMNGSOA(LLXPXHNGEHC a, KQGIQGHQWFJ b, BLLRRQUGYXB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AD60", Offset = "0x2B49B60", VA = "0x182B4AD60", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AD00", Offset = "0x2B49B00", VA = "0x182B4AD00", Slot = "100")]
		public Id32<OZEAUEUOYEU> DXUXSKZYXWP(Id32<VFKNGTPUEMY> graphId, Id32<QLUJOYTGVHG> inputId)
		{
			return default(Id32<OZEAUEUOYEU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B720", Offset = "0x2B4A520", VA = "0x182B4B720", Slot = "101")]
		public Id32<NBIAOKUHZAL> HAMGMGQTHKK(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> outputId)
		{
			return default(Id32<NBIAOKUHZAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D9D0", Offset = "0x2B4C7D0", VA = "0x182B4D9D0", Slot = "6")]
		public (bool, bool) OXSELLVTIYF(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FA60", Offset = "0x2B4E860", VA = "0x182B4FA60")]
		public bool VAJVIQBLJVO(Id32<VFKNGTPUEMY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C820", Offset = "0x2B4B620", VA = "0x182B4C820", Slot = "8")]
		public bool JUCWWSPTNVE(MNOVJCUCTWS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F5F0", Offset = "0x2B4E3F0", VA = "0x182B4F5F0", Slot = "9")]
		public bool TBXOVKNBSSZ(UJTJHRBJORV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AAB0", Offset = "0x2B498B0", VA = "0x182B4AAB0", Slot = "10")]
		public AbsoluteLegacyInputId? BYCKCPDYBAC(Id32<VFKNGTPUEMY> graphId, Id32<QLUJOYTGVHG> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A990", Offset = "0x2B49790", VA = "0x182B4A990", Slot = "11")]
		public AbsoluteLegacyOutputId? BAZBZIDCTOR(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F7B0", Offset = "0x2B4E5B0", VA = "0x182B4F7B0", Slot = "12")]
		public Id32<ADNWLQIRYCV>? UIHMCXGAVWL(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<GSCEPPXRFGV> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D3E0", Offset = "0x2B4C1E0", VA = "0x182B4D3E0", Slot = "13")]
		public Id32<QLUJOYTGVHG>? NHCFLSOHSEE(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<LMZHXZTZMKK> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BB00", Offset = "0x2B4A900", VA = "0x182B4BB00", Slot = "14")]
		public IEnumerable<Id32<VFKNGTPUEMY>> IPVPFUZHIIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D570", Offset = "0x2B4C370", VA = "0x182B4D570", Slot = "15")]
		public IEnumerable<Id32<YTGXVMERIIQ>> NMAFENZPEVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A900", Offset = "0x2B49700", VA = "0x182B4A900", Slot = "22")]
		public string AGRJSVFQSBJ(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CDF0", Offset = "0x2B4BBF0", VA = "0x182B4CDF0", Slot = "16")]
		public Id32<YTGXVMERIIQ>? MIXHMBWRJBD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B511C0", Offset = "0x2B4FFC0", VA = "0x182B511C0", Slot = "17")]
		public int WOXNVVHZNMI(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D600", Offset = "0x2B4C400", VA = "0x182B4D600", Slot = "18")]
		public int NOMTUVJOYMB(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F590", Offset = "0x2B4E390", VA = "0x182B4F590", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] SYZYJRHRKOG(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F830", Offset = "0x2B4E630", VA = "0x182B4F830", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] UOTDWETIJZN(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3AA98E0", Offset = "0x3AA86E0", VA = "0x183AA98E0")]
		private static (CircuitTypeIdWrapper, string?)[]? KSASRSQOTLK<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B518A0", Offset = "0x2B506A0", VA = "0x182B518A0", Slot = "21")]
		public string YHGJRSIEWQZ(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F570", Offset = "0x2B4E370", VA = "0x182B4F570", Slot = "23")]
		public string SQNLTRKVWZK(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C910", Offset = "0x2B4B710", VA = "0x182B4C910")]
		public RCFAQTSGIYC? LJQCUIBSJQH([In] Id128<MVBOYPURKWM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B511E0", Offset = "0x2B4FFE0", VA = "0x182B511E0", Slot = "30")]
		public Id32<CELSXRFYLJZ> WXQHATBPYIP(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32<CELSXRFYLJZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B470", Offset = "0x2B4A270", VA = "0x182B4B470")]
		public Id32<MVBOYPURKWM> GAVEYOSJHBI(Id32<VFKNGTPUEMY> graphId, [In] Id128<MVBOYPURKWM> legacyNodeId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B51DF0", Offset = "0x2B50BF0", VA = "0x182B51DF0", Slot = "40")]
		public Id32<MVBOYPURKWM> ZKHLFEZHNSL(Id32<VFKNGTPUEMY> graphId, Id32<QLUJOYTGVHG> inputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B51450", Offset = "0x2B50250", VA = "0x182B51450", Slot = "41")]
		public Id32<MVBOYPURKWM> XPHVGVPPROW(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> outputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B910", Offset = "0x2B4A710", VA = "0x182B4B910")]
		public Id32<MVBOYPURKWM>? HTZHKZZKFBQ(Id32<VFKNGTPUEMY> graphId, [In] Id128<MVBOYPURKWM> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B1B0", Offset = "0x2B49FB0", VA = "0x182B4B1B0", Slot = "32")]
		public AbsoluteNodeId? FXQCQQBWDPC(Id32<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F670", Offset = "0x2B4E470", VA = "0x182B4F670", Slot = "33")]
		public long TPBCJZVTOJL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D950", Offset = "0x2B4C750", VA = "0x182B4D950")]
		private void OUITKPZIRQF(Id128<MVBOYPURKWM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D0B0", Offset = "0x2B4BEB0", VA = "0x182B4D0B0", Slot = "38")]
		public IEnumerable<(Id32<VFKNGTPUEMY>, Id32<MVBOYPURKWM>)> MKVQVCSHOTZ(Id32<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D3B0", Offset = "0x2B4C1B0", VA = "0x182B4D3B0", Slot = "39")]
		public Id32<QLUJOYTGVHG> NHCFLSOHSEE(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> inputIndex)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F7E0", Offset = "0x2B4E5E0", VA = "0x182B4F7E0", Slot = "42")]
		public Id32<ADNWLQIRYCV> UIHMCXGAVWL(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> outputIndex)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C8A0", Offset = "0x2B4B6A0", VA = "0x182B4C8A0")]
		private RCFAQTSGIYC? KMQYNBSFGUO([In] Id128<MVBOYPURKWM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AD20", Offset = "0x2B49B20", VA = "0x182B4AD20")]
		public RHNNOHYQJTP? DYYONSVZUBC([In] Id128<MVBOYPURKWM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AC80", Offset = "0x2B49A80", VA = "0x182B4AC80")]
		public VECMIZPXZIC? DCYFVWGAQLL([In] Id128<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AC30", Offset = "0x2B49A30", VA = "0x182B4AC30", Slot = "25")]
		public VECMIZPXZIC? DCYFVWGAQLL(Id32<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ECB0", Offset = "0x2B4DAB0", VA = "0x182B4ECB0", Slot = "34")]
		public IEnumerable<NewStaticEdge> RONWLJORQEH(Id32<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B940", Offset = "0x2B4A740", VA = "0x182B4B940", Slot = "35")]
		public bool HWLVKLNDWAT(Id32<YTGXVMERIIQ> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B51200", Offset = "0x2B50000", VA = "0x182B51200", Slot = "36")]
		public IEnumerable<StableStaticEdge> XLQDLEOBTJZ(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EE30", Offset = "0x2B4DC30", VA = "0x182B4EE30", Slot = "37")]
		public IEnumerable<StableStaticEdge> RZLBQLZFVFQ(Id32<VFKNGTPUEMY> graphId, Id32<QLUJOYTGVHG> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E030", Offset = "0x2B4CE30", VA = "0x182B4E030")]
		public Id32<VFKNGTPUEMY> QTRPDMABKKY([In] Id128<VFKNGTPUEMY> graphId)
		{
			return default(Id32<VFKNGTPUEMY>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ACD0", Offset = "0x2B49AD0", VA = "0x182B4ACD0")]
		public Id32<VFKNGTPUEMY>? DVBXMHDGXDW([In] Id128<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D7A0", Offset = "0x2B4C5A0", VA = "0x182B4D7A0")]
		private LBBVNSEAAOY? ONOJZLLTCQM([In] Id128<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AC80", Offset = "0x2B49A80", VA = "0x182B4AC80")]
		private VECMIZPXZIC? VDFPSRMLDSL([In] Id128<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B620", Offset = "0x2B4A420", VA = "0x182B4B620", Slot = "28")]
		public Id32<VFKNGTPUEMY>? GSUUTPGUTJR(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ACB0", Offset = "0x2B49AB0", VA = "0x182B4ACB0", Slot = "46")]
		public Id128<VFKNGTPUEMY> DIOPOWTIBTL(Id32<VFKNGTPUEMY> graphId)
		{
			return default(Id128<VFKNGTPUEMY>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AC10", Offset = "0x2B49A10", VA = "0x182B4AC10", Slot = "47")]
		public Id128<MVBOYPURKWM> CYKZIYEIASR(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id128<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B370", Offset = "0x2B4A170", VA = "0x182B4B370", Slot = "43")]
		public IEnumerable<WIBHTRDJIRP> FZZGAEQEBQT(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B50D60", Offset = "0x2B4FB60", VA = "0x182B50D60", Slot = "44")]
		public WIBHTRDJIRP WDIXJVTBLSO(RoomVersion a, EJMDVNERXCJ b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D6B0", Offset = "0x2B4C4B0", VA = "0x182B4D6B0")]
		public NewStaticEdge WRBQIAYKVZO(Id32<VFKNGTPUEMY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B51060", Offset = "0x2B4FE60", VA = "0x182B51060", Slot = "48")]
		public StableStaticEdge WGCPCROIYSN(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CB20", Offset = "0x2B4B920", VA = "0x182B4CB20", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, KXUOEYSOWHL>> MFVHFNLQMCI(Id32<VFKNGTPUEMY> parentGraphId, Id32<MVBOYPURKWM> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B4A0", Offset = "0x2B4A2A0", VA = "0x182B4B4A0", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, KXUOEYSOWHL>> GNNGVCPPPSR(Id32<VFKNGTPUEMY> parentGraphId, Id128<MVBOYPURKWM> boardNodeId, List<Id32<MVBOYPURKWM>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B50110", Offset = "0x2B4EF10", VA = "0x182B50110", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, KXUOEYSOWHL>> VVXZPYAPVBY(Id32<VFKNGTPUEMY> parentGraphId, Id128<MVBOYPURKWM> boardNodeId, List<Id32<MVBOYPURKWM>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B51E10", Offset = "0x2B50C10", VA = "0x182B51E10", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, KXUOEYSOWHL>> ZZSFHMRBGQC(Id32<VFKNGTPUEMY> parentGraphId, Id128<MVBOYPURKWM> boardNodeId, Id32<VFKNGTPUEMY> graphId, List<Id32<MVBOYPURKWM>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FFA0", Offset = "0x2B4EDA0", VA = "0x182B4FFA0", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<JZROSXUIZUS>, Id32<LMZHXZTZMKK>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<JZROSXUIZUS>, Id32<GSCEPPXRFGV>)>) VQODHIDZBMT(Id128<VFKNGTPUEMY> legacyGraphId, Id32<MVBOYPURKWM> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<JZROSXUIZUS>, Id32<LMZHXZTZMKK>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<JZROSXUIZUS>, Id32<GSCEPPXRFGV>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D140", Offset = "0x2B4BF40", VA = "0x182B4D140", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task MMPPVDYPFMR(Id128<VFKNGTPUEMY> legacyGraphId, Id128<MVBOYPURKWM> boardNodeId, IReadOnlyList<Id128<MVBOYPURKWM>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<JZROSXUIZUS>, Id32<LMZHXZTZMKK>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<JZROSXUIZUS>, Id32<GSCEPPXRFGV>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DE70", Offset = "0x2B4CC70", VA = "0x182B4DE70", Slot = "55")]
		public bool PFVOTZOZSRT(Id32<VFKNGTPUEMY> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F960", Offset = "0x2B4E760", VA = "0x182B4F960", Slot = "56")]
		public bool USEWIJAADJH(Id32<VFKNGTPUEMY> graphId, Id32<QLUJOYTGVHG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B190", Offset = "0x2B49F90", VA = "0x182B4B190", Slot = "57")]
		public bool FTLJGQLOJXI(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A9F0", Offset = "0x2B497F0", VA = "0x182B4A9F0")]
		public Result<JOTUAXHHOSV.PrepareTemplateForCloneResult, KTYXBBLRCBW> BGWYTSUEEOK([In] JOTUAXHHOSV.PrepareTemplateForCloneArgs args)
		{
			return default(Result<JOTUAXHHOSV.PrepareTemplateForCloneResult, KTYXBBLRCBW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B50C30", Offset = "0x2B4FA30", VA = "0x182B50C30", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, KXUOEYSOWHL>> WCSXYCSXFGM(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AE90", Offset = "0x2B49C90", VA = "0x182B4AE90", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<MVBOYPURKWM>, KXUOEYSOWHL>> EWWOHTETKFD(Id32<VFKNGTPUEMY> graphId, Id32<CELSXRFYLJZ> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B9A0", Offset = "0x2B4A7A0", VA = "0x182B4B9A0", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> IFAAJAUVLXW(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C4A0", Offset = "0x2B4B2A0", VA = "0x182B4C4A0", Slot = "62")]
		public Result<ControlPanelRootData, SEZYOHJZPUT> JOKQFDOVCVI(Id128<VFKNGTPUEMY> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, SEZYOHJZPUT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BB70", Offset = "0x2B4A970", VA = "0x182B4BB70", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, KXUOEYSOWHL>> IVUHTEKQFRU(Id128<VFKNGTPUEMY> graphId, Id128<MVBOYPURKWM> inputNodeId, Id32<JZROSXUIZUS> inputPortGroupId, Id32<LMZHXZTZMKK> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E060", Offset = "0x2B4CE60", VA = "0x182B4E060", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, KXUOEYSOWHL>> RFXXRMSAUSR(Id128<VFKNGTPUEMY> graphId, Id128<MVBOYPURKWM> outputNodeId, Id32<JZROSXUIZUS> outputPortGroupId, Id32<GSCEPPXRFGV> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D840", Offset = "0x2B4C640", VA = "0x182B4D840", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, KXUOEYSOWHL>> OPSVNKXDIEG(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D410", Offset = "0x2B4C210", VA = "0x182B4D410", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<MVBOYPURKWM>>, KXUOEYSOWHL>> NJUAVSAGNBF(Id128<VFKNGTPUEMY> intoGraphId, CircuitTemplateRootData a, IEnumerable<PBCTZJZFZQR> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B740", Offset = "0x2B4A540", VA = "0x182B4B740", Slot = "67")]
		public CircuitsData HBTOPXIVEUN()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D620", Offset = "0x2B4C420", VA = "0x182B4D620", Slot = "68")]
		public CircuitsData NURICYHOVKM()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DE90", Offset = "0x2B4CC90", VA = "0x182B4DE90", Slot = "71")]
		public CircuitsTemplateData QOHVNXTEEHJ(TemplateSerializationReason a, Id32<VFKNGTPUEMY> sourceGraphId, IEnumerable<Id128<VFKNGTPUEMY>> graphIds, IEnumerable<Id128<MVBOYPURKWM>> nodeIds, ISet<Id128<AUVZLDEFMDS>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B000", Offset = "0x2B49E00", VA = "0x182B4B000")]
		private CircuitsTemplateData FGJJFWRMVWO(TemplateSerializationReason a, Id32<VFKNGTPUEMY> sourceGraphId, IEnumerable<Id128<VFKNGTPUEMY>> graphIds, IEnumerable<Id128<MVBOYPURKWM>> nodeIds, ISet<Id128<AUVZLDEFMDS>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F190", Offset = "0x2B4DF90", VA = "0x182B4F190", Slot = "69")]
		public CircuitsTemplateData SBOVVXLTUOK(TemplateSerializationReason a, Id32<VFKNGTPUEMY> sourceGraphId, IEnumerable<Id128<MVBOYPURKWM>> nodeIds, IEnumerable<PBCTZJZFZQR> b, ISet<Id128<AUVZLDEFMDS>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F080", Offset = "0x2B4DE80", VA = "0x182B4F080", Slot = "70")]
		public CircuitsTemplateData SBOVVXLTUOK(TemplateSerializationReason a, Id32<VFKNGTPUEMY> sourceGraphId, IEnumerable<Id32<MVBOYPURKWM>> nodeIds, IEnumerable<PBCTZJZFZQR> b, ISet<Id128<AUVZLDEFMDS>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B514D0", Offset = "0x2B502D0", VA = "0x182B514D0")]
		private static IEnumerable<Id128<VFKNGTPUEMY>> YEPRJWGRRUO(IEnumerable<PBCTZJZFZQR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B518D0", Offset = "0x2B506D0", VA = "0x182B518D0")]
		private IEnumerable<Id128<MVBOYPURKWM>> YYMLNQETJMI(IEnumerable<PBCTZJZFZQR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F3F0", Offset = "0x2B4E1F0", VA = "0x182B4F3F0", Slot = "72")]
		public List<IRQJQOQVZSL> SJIYDVOYJDV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BE10", Offset = "0x2B4AC10", VA = "0x182B4BE10")]
		public (List<IRQJQOQVZSL>, bool) JGFLYOPSONA([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, XLCRJVDDJGZ b, ADOZTPJQCJZ c)
		{
			return default((List<IRQJQOQVZSL>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AA20", Offset = "0x2B49820", VA = "0x182B4AA20", Slot = "74")]
		public bool BRALIHAIVSX(Id32<VFKNGTPUEMY> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F720", Offset = "0x2B4E520", VA = "0x182B4F720", Slot = "75")]
		public bool UFFXCZLAGJP(Id32<VFKNGTPUEMY> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C480", Offset = "0x2B4B280", VA = "0x182B4C480")]
		internal void JGUQWLTIZKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F980", Offset = "0x2B4E780", VA = "0x182B4F980")]
		internal Task USSBJQCINLS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E300", Offset = "0x2B4D100", VA = "0x182B4E300", Slot = "76")]
		public Result<Id32<ADNWLQIRYCV>?, KXUOEYSOWHL> RMWZEHDEOHK(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<QLUJOYTGVHG> inputId)
		{
			return default(Result<Id32<ADNWLQIRYCV>?, KXUOEYSOWHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B50260", Offset = "0x2B4F060", VA = "0x182B50260", Slot = "77")]
		public Result<Id32<QLUJOYTGVHG>?, KXUOEYSOWHL> VXDWKMXKVYM(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<ADNWLQIRYCV> outputId)
		{
			return default(Result<Id32<QLUJOYTGVHG>?, KXUOEYSOWHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AB10", Offset = "0x2B49910", VA = "0x182B4AB10", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, KXUOEYSOWHL>> CAPQKRYYEUF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F430", Offset = "0x2B4E230", VA = "0x182B4F430", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, KXUOEYSOWHL>> SPCTDCQQMPD(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F9A0", Offset = "0x2B4E7A0", VA = "0x182B4F9A0", Slot = "80")]
		public Id32<MVBOYPURKWM>? UUVUVFUCNHB(Id32<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CA60", Offset = "0x2B4B860", VA = "0x182B4CA60", Slot = "81")]
		public Id32<MVBOYPURKWM>? LZAVBVRTLDC(Id32<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AE00", Offset = "0x2B49C00", VA = "0x182B4AE00", Slot = "82")]
		public int EPGYXFEYXHY(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F890", Offset = "0x2B4E690", VA = "0x182B4F890", Slot = "83")]
		public int UPKZWZLJVGP(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FEC0", Offset = "0x2B4ECC0", VA = "0x182B4FEC0", Slot = "84")]
		public int VOIZLXWRMAU(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<KKVGGBONUEH> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED50", Offset = "0x2B4DB50", VA = "0x182B4ED50", Slot = "85")]
		public int RVPXIKVPDLM(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<KKVGGBONUEH> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BCD0", Offset = "0x2B4AAD0", VA = "0x182B4BCD0", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, KXUOEYSOWHL>> JCTCHNKSEZS(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<KKVGGBONUEH> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B7D0", Offset = "0x2B4A5D0", VA = "0x182B4B7D0", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, KXUOEYSOWHL>> HJTGBCRFZBX(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, Id32<KKVGGBONUEH> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B2B0", Offset = "0x2B4A0B0", VA = "0x182B4B2B0", Slot = "88")]
		public int FYWWRHYLJQU(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E1C0", Offset = "0x2B4CFC0", VA = "0x182B4E1C0", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, KXUOEYSOWHL>> RMTTLJDJENY(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CC70", Offset = "0x2B4BA70", VA = "0x182B4CC70", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, KXUOEYSOWHL>> MGTQXMPSHVR(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FD50", Offset = "0x2B4EB50", VA = "0x182B4FD50", Slot = "91")]
		public bool VJGNBNCXNNY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BAE0", Offset = "0x2B4A8E0", VA = "0x182B4BAE0", Slot = "97")]
		public IEnumerable<Id32<PUDUKHYUWDI>> INJMUZQDBHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2B50C10", Offset = "0x2B4FA10", VA = "0x182B50C10", Slot = "98")]
		public string? VZUROSXXUFU(Id32<PUDUKHYUWDI> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AFF0", Offset = "0x2B49DF0", VA = "0x182B4AFF0", Slot = "7")]
		private bool EXWOOAINTHW(Id32<VFKNGTPUEMY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AC80", Offset = "0x2B49A80", VA = "0x182B4AC80", Slot = "24")]
		private VECMIZPXZIC UFUIXQFPRNP([In] Id128<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E030", Offset = "0x2B4CE30", VA = "0x182B4E030", Slot = "26")]
		private Id32<VFKNGTPUEMY> WKEMMVTRRRC([In] Id128<VFKNGTPUEMY> graphId)
		{
			return default(Id32<VFKNGTPUEMY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ACD0", Offset = "0x2B49AD0", VA = "0x182B4ACD0", Slot = "27")]
		private Id32<VFKNGTPUEMY>? WHWTLISADDK([In] Id128<VFKNGTPUEMY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D290", Offset = "0x2B4C090", VA = "0x182B4D290", Slot = "29")]
		private RCFAQTSGIYC MMYCLMBQKVF([In] Id128<MVBOYPURKWM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B470", Offset = "0x2B4A270", VA = "0x182B4B470", Slot = "31")]
		private Id32<MVBOYPURKWM> PVZRGJMZRFE(Id32<VFKNGTPUEMY> graphId, [In] Id128<MVBOYPURKWM> legacyNodeId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D6B0", Offset = "0x2B4C4B0", VA = "0x182B4D6B0", Slot = "45")]
		private NewStaticEdge NVPLONLBKMI(Id32<VFKNGTPUEMY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A9F0", Offset = "0x2B497F0", VA = "0x182B4A9F0", Slot = "58")]
		private Result<JOTUAXHHOSV.PrepareTemplateForCloneResult, KTYXBBLRCBW> HJOELZWBYES([In] JOTUAXHHOSV.PrepareTemplateForCloneArgs args)
		{
			return default(Result<JOTUAXHHOSV.PrepareTemplateForCloneResult, KTYXBBLRCBW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2B51470", Offset = "0x2B50270", VA = "0x182B51470", Slot = "73")]
		private (List<IRQJQOQVZSL>, bool) XWNRGQMOFPM([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, XLCRJVDDJGZ b, ADOZTPJQCJZ c)
		{
			return default((List<IRQJQOQVZSL>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F690", Offset = "0x2B4E490", VA = "0x182B4F690")]
		[CompilerGenerated]
		private XUZODVAORGK TPMIGDQEEXN(QUZNMKSIOOE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A960", Offset = "0x2B49760", VA = "0x182B4A960")]
		[CompilerGenerated]
		private RHNNOHYQJTP ANBFUWADJZR(Id128<MVBOYPURKWM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A930", Offset = "0x2B49730", VA = "0x182B4A930")]
		[CompilerGenerated]
		private LBBVNSEAAOY AMVYXPGGAOI(Id128<VFKNGTPUEMY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A960", Offset = "0x2B49760", VA = "0x182B4A960")]
		[CompilerGenerated]
		private RHNNOHYQJTP GJKJDOKCHCT(Id128<MVBOYPURKWM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A930", Offset = "0x2B49730", VA = "0x182B4A930")]
		[CompilerGenerated]
		private LBBVNSEAAOY GJFCGHQEXRK(Id128<VFKNGTPUEMY> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class XUZODVAORGK : WIBHTRDJIRP
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
			public AsyncTaskMethodBuilder<Result<Id32<KKVGGBONUEH>, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public XUZODVAORGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<JZROSXUIZUS> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<KKVGGBONUEH>, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2B55410", Offset = "0x2B54210", VA = "0x182B55410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2B55660", Offset = "0x2B54460", VA = "0x182B55660", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<ECXPGDQVCNG>, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public XUZODVAORGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<VFKNGTPUEMY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<MVBOYPURKWM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<JZROSXUIZUS> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<ECXPGDQVCNG>, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2B556D0", Offset = "0x2B544D0", VA = "0x182B556D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2B55920", Offset = "0x2B54720", VA = "0x182B55920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly QUZNMKSIOOE GLHHAFEKGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly KQGIQGHQWFJ MRRWNSCAHPV;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey LXWPTBZALGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string GYGRUXNKJIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BB10", Offset = "0x2B5A910", VA = "0x182B5BB10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public QUZNMKSIOOE QUZNMKSIOOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D970", Offset = "0x2B5C770", VA = "0x182B5D970")]
		public XUZODVAORGK(QUZNMKSIOOE a, KQGIQGHQWFJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D800", Offset = "0x2B5C600", VA = "0x182B5D800", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<KKVGGBONUEH>, KXUOEYSOWHL>> WNWTYPJUDTR(Id128<VFKNGTPUEMY> graphId, Id128<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D690", Offset = "0x2B5C490", VA = "0x182B5D690", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<ECXPGDQVCNG>, KXUOEYSOWHL>> FXZPGMLJTJW(Id128<VFKNGTPUEMY> graphId, Id128<MVBOYPURKWM> nodeId, Id32<JZROSXUIZUS> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class VKPDSJMBHGQ : TSAPSMXEATI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly QUZNMKSIOOE SWAVKVRSZMU;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<QUZNMKSIOOE> ZSHXOBDOMJA;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<QUZNMKSIOOE> YEQDFIYUIIH;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<QUZNMKSIOOE> LFUMAZISWMS;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public QUZNMKSIOOE YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D520", Offset = "0x2B5C320", VA = "0x182B5D520", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D510", Offset = "0x2B5C310", VA = "0x182B5D510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D570", Offset = "0x2B5C370", VA = "0x182B5D570", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D490", Offset = "0x2B5C290", VA = "0x182B5D490", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B8A0", Offset = "0x2B5A6A0", VA = "0x182B5B8A0")]
		public bool PPXSQRKLNWN(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public VKPDSJMBHGQ(QUZNMKSIOOE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B710", Offset = "0x2B5A510", VA = "0x182B5B710")]
		internal static TypeKey KFAJALWLQSC(QUZNMKSIOOE a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BB10", Offset = "0x2B5A910", VA = "0x182B5BB10", Slot = "3")]
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
	public readonly struct ActionDeps : CACFZSSVVJB.YBIHNSSNITM<JGWKKBUFZYH, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2B49960", Offset = "0x2B48760", VA = "0x182B49960", Slot = "4")]
		public int TRZBMSLQOTW(None a, JGWKKBUFZYH b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2B499A0", Offset = "0x2B487A0", VA = "0x182B499A0", Slot = "5")]
		public JGWKKBUFZYH XDQLBPHMOAX(None a, JGWKKBUFZYH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2B498D0", Offset = "0x2B486D0", VA = "0x182B498D0", Slot = "6")]
		public JGWKKBUFZYH LEQOWQQZQCY(None a, JGWKKBUFZYH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2B499D0", Offset = "0x2B487D0", VA = "0x182B499D0", Slot = "7")]
		public IReadOnlyList<JGWKKBUFZYH> ZBRJPEBFCIS(None a, JGWKKBUFZYH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2B498C0", Offset = "0x2B486C0", VA = "0x182B498C0", Slot = "8")]
		public JGWKKBUFZYH[] HQXFFZTUGUR(None a, JGWKKBUFZYH b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2B499B0", Offset = "0x2B487B0", VA = "0x182B499B0", Slot = "9")]
		public bool XFRSOVXZGZA(None a, JGWKKBUFZYH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2B49980", Offset = "0x2B48780", VA = "0x182B49980", Slot = "10")]
		public bool VUHGCVUIQMA(None a, JGWKKBUFZYH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B49900", Offset = "0x2B48700", VA = "0x182B49900", Slot = "11")]
		public bool MSIUPUROAZM(None a, JGWKKBUFZYH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2B49920", Offset = "0x2B48720", VA = "0x182B49920", Slot = "12")]
		public bool OEDTKALEXIU(None a, JGWKKBUFZYH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2B499F0", Offset = "0x2B487F0", VA = "0x182B499F0", Slot = "13")]
		public bool ZUOYBTFATNY(None a, JGWKKBUFZYH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2B49940", Offset = "0x2B48740", VA = "0x182B49940", Slot = "14")]
		public bool OLHUFYNPXXV(None a, JGWKKBUFZYH b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class ZWNIUWJHTNL : ADMWIPYDBOF
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract CCKWHATKPBN.VAEKADQIRNQ YMNHPYMKYKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract LLXPXHNGEHC.VAEKADQIRNQ GVUJLRGXJNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract QMPJCTMUYTR.VAEKADQIRNQ LVRLWVTOYCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC> KCUMYMULKAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E0C0", Offset = "0x2B5CEC0", VA = "0x182B5E0C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.VAEKADQIRNQ ZGPDNETMEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract XXFEIMFXUFV POIJMWMPEWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract UHFIXPZEGDI YHGIWREOJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract VILOZUKICQY VEAWHMVIPAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract BFKKVPEWDDK FYKMOQQNFCT
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract SULRVJJWMBY ZJJEOPUGPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected ZWNIUWJHTNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class OGQUPTXRYBL : XRSIHOOSRTV
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
			public AsyncTaskMethodBuilder<Result<MultiResult, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<JGWKKBUFZYH> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public OGQUPTXRYBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2B55F40", Offset = "0x2B54D40", VA = "0x182B55F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2B56360", Offset = "0x2B55160", VA = "0x182B56360", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public OGQUPTXRYBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public JGWKKBUFZYH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2B5ACC0", Offset = "0x2B59AC0", VA = "0x182B5ACC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AED0", Offset = "0x2B59CD0", VA = "0x182B5AED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly KVHMMDKOSSW OGZKMBTZYLK;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public OGQUPTXRYBL(KVHMMDKOSSW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2B52C50", Offset = "0x2B51A50", VA = "0x182B52C50")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, KXUOEYSOWHL>> VXFKWVSXXWO(JGWKKBUFZYH a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2B52B20", Offset = "0x2B51920", VA = "0x182B52B20", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, KXUOEYSOWHL>> AHHPLAZSRHE(IReadOnlyList<JGWKKBUFZYH> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, JGWKKBUFZYH, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, JGWKKBUFZYH, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2B52F80", Offset = "0x2B51D80", VA = "0x182B52F80")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class VJODIWEVSWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, JGWKKBUFZYH, PartialActionReassemblyDeps> OVGQIVVGLQH(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, JGWKKBUFZYH, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : HUWGQUXDXZP.EXOUKTTMMZJ<PartialActionPayload, Id128<PartialActionPayload.M>, JGWKKBUFZYH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D90", Offset = "0x2B51B90", VA = "0x182B52D90", Slot = "7")]
		public JGWKKBUFZYH QWSUALZXAQR(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x12A3120", Offset = "0x12A1F20", VA = "0x1812A3120")]
		public Id128<PartialActionPayload.M> OEZOXZTTWWJ([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x1024B50", Offset = "0x1023950", VA = "0x181024B50")]
		public int SSFRZTTJUDB([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D80", Offset = "0x2B51B80", VA = "0x182B52D80")]
		public int QKLXLQUQJDC([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x1024B50", Offset = "0x1023950", VA = "0x181024B50", Slot = "4")]
		private int UYOOKGRHJOR([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2B52D80", Offset = "0x2B51B80", VA = "0x182B52D80", Slot = "5")]
		private int SIYKIJYJZLM([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x12A3120", Offset = "0x12A1F20", VA = "0x1812A3120", Slot = "6")]
		private Id128<PartialActionPayload.M> FONIQMGQAXZ([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, JGWKKBUFZYH, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, JGWKKBUFZYH, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B553B0", Offset = "0x2B541B0", VA = "0x182B553B0")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class NZAXDNTJOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0")]
		public static SnapshotReassembly<PartialInitializePayload, JGWKKBUFZYH, SnapshotReassemblyDeps> OVGQIVVGLQH(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, JGWKKBUFZYH, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : RLLWNNSTVPW.EXJNNMZPDOA<PartialInitializePayload, JGWKKBUFZYH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x1024BB0", Offset = "0x10239B0", VA = "0x181024BB0")]
		public int ILPYELZOJTT([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B551C0", Offset = "0x2B53FC0", VA = "0x182B551C0", Slot = "5")]
		public JGWKKBUFZYH QXHBUULKSVZ(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x1024BB0", Offset = "0x10239B0", VA = "0x181024BB0", Slot = "4")]
		private int VPRMTYPYOPF([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class ZHMUQIQSQHT : TDAXDIBDDUE, KTYXBBLRCBW, KXUOEYSOWHL, SEZYOHJZPUT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly SEZYOHJZPUT? QOOVSKOXVLH;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind DAPXUDJAJEL
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xCED350", Offset = "0xCEC150", VA = "0x180CED350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override SEZYOHJZPUT? IQPPLEIUSSC
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DA80", Offset = "0x2B5C880", VA = "0x182B5DA80", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DC40", Offset = "0x2B5CA40", VA = "0x182B5DC40")]
		private ZHMUQIQSQHT(PrepareTemplateForCloneErrKind a, SEZYOHJZPUT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DA10", Offset = "0x2B5C810", VA = "0x182B5DA10")]
		public static ZHMUQIQSQHT DDYOHKIGVQR(SEZYOHJZPUT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DBE0", Offset = "0x2B5C9E0", VA = "0x182B5DBE0")]
		public static ZHMUQIQSQHT LMECYDGDLBX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DB80", Offset = "0x2B5C980", VA = "0x182B5DB80")]
		public static ZHMUQIQSQHT JVYGAFAWYMH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class YAJWFKGPFIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x4116D10", Offset = "0x4115B10", VA = "0x184116D10")]
		public static Result<TOk, KTYXBBLRCBW> SVNEUQIRRRM<TOk>([In] this Result<TOk, KTYXBBLRCBW> self, SEZYOHJZPUT a) where TOk : notnull
		{
			return default(Result<TOk, KTYXBBLRCBW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x4116B40", Offset = "0x4115940", VA = "0x184116B40")]
		public static Result<a?, KTYXBBLRCBW?> HOESUWILEWU<a>([In] this Result<a, KTYXBBLRCBW> self)
		{
			return default(Result<a, KTYXBBLRCBW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x4116C90", Offset = "0x4115A90", VA = "0x184116C90")]
		public static Result<b?, KTYXBBLRCBW?> PAJERHYCVHI<b>([In] this Result<b, KTYXBBLRCBW> self)
		{
			return default(Result<b, KTYXBBLRCBW>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface XXFEIMFXUFV
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IWNMYVVYEFD([In] Result<None, SEZYOHJZPUT> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class RKMXKZUSKMV
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x3E34120", Offset = "0x3E32F20", VA = "0x183E34120")]
		public static bool IWNMYVVYEFD<TOk, TErr>(this XXFEIMFXUFV a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, SEZYOHJZPUT
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface UHFIXPZEGDI
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		XEQZGTZPMCK OUWBNJXCEXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface VILOZUKICQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor SUQDKOCKJGZ(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface UWLVIVVQMMN
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface YGCNPLXPMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JIUVPZYRUNG? KWBOFOESPXR(Id32<JZROSXUIZUS> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface GILBAPGCIGS
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface JIUVPZYRUNG
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GILBAPGCIGS? SFFECSMCSJX(Id32<KKVGGBONUEH> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UWLVIVVQMMN? SHTNQYXZIIE(Id32<ECXPGDQVCNG> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface BFKKVPEWDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> EKXIVNPXIAG(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface SULRVJJWMBY
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YGCNPLXPMIO? JNYGLPFDSYP([In] Id128<MIMXYJWAARO> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class IHFDSRDKWBP
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
			public readonly List<JGWKKBUFZYH> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A8B0", Offset = "0x2B496B0", VA = "0x182B4A8B0")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<JGWKKBUFZYH> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A800", Offset = "0x2B49600", VA = "0x182B4A800")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly IOOSVLZKQUC<Diagnostic> RUCUGXJPTAH;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static IHFDSRDKWBP GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2B52940", Offset = "0x2B51740", VA = "0x182B52940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool RXUHPXLEDFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD3CC00", Offset = "0xD3BA00", VA = "0x180D3CC00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xE0DF60", Offset = "0xE0CD60", VA = "0x180E0DF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B52880", Offset = "0x2B51680", VA = "0x182B52880")]
		public void OJKTSYRKZJY(KQGIQGHQWFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B525A0", Offset = "0x2B513A0", VA = "0x182B525A0")]
		public void JZJTZYDLNWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B523E0", Offset = "0x2B511E0", VA = "0x182B523E0")]
		private static string? CPAHPMFDBST([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B52A80", Offset = "0x2B51880", VA = "0x182B52A80")]
		public IHFDSRDKWBP()
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
