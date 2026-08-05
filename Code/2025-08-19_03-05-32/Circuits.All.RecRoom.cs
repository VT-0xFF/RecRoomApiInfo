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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A845C0", Offset = "0x2A833C0", VA = "0x182A845C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A83F50", Offset = "0x2A82D50", VA = "0x182A83F50", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class SQESMBBMMXQ : IDisposable, DGXRHLTUZNR, VZUVKYBUHQC, UNBBTMAPQXV
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class JSRFTFIQFIZ : ZLOMSCLYJNW
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int QJFIYCRSYNT
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2A81780", Offset = "0x2A80580", VA = "0x182A81780", Slot = "5")]
			public AYIPZYLYXPE YFVRDXGDPHH(LPFVMTQVGRX.ZLOMSCLYJNW a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void LBFWZBIRKUT();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void XLBIPLINQXQ();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2A71440", Offset = "0x2A70240", VA = "0x182A71440", Slot = "13")]
			public virtual void OXMGBAFQAVM(SQESMBBMMXQ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2A81700", Offset = "0x2A80500", VA = "0x182A81700", Slot = "14")]
			public virtual void QSCVNXFRFIP(SQESMBBMMXQ a, TWGQWHZWPAR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			protected JSRFTFIQFIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ZLOMSCLYJNW
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int QJFIYCRSYNT
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			AYIPZYLYXPE YFVRDXGDPHH(LPFVMTQVGRX.ZLOMSCLYJNW a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LBFWZBIRKUT();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void XLBIPLINQXQ();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void OXMGBAFQAVM(SQESMBBMMXQ a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void QSCVNXFRFIP(SQESMBBMMXQ a, TWGQWHZWPAR b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12B3B90", Offset = "0x12B2990", VA = "0x1812B3B90")]
			internal Reducer(Reducer<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class BNOHTPALDTZ : JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly BNOHTPALDTZ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private BNOHTPALDTZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC8BA50", Offset = "0xC8A850", VA = "0x180C8BA50", Slot = "4")]
			public ActionKind MOALJMDQZTV(TWGQWHZWPAR a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E930", Offset = "0x2A7D730", VA = "0x182A7E930", Slot = "5")]
			public void OXMGBAFQAVM(SQESMBBMMXQ a, TWGQWHZWPAR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2A7EA40", Offset = "0x2A7D840", VA = "0x182A7EA40", Slot = "6")]
			public void QSCVNXFRFIP(SQESMBBMMXQ a, TWGQWHZWPAR b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2A85B30", Offset = "0x2A84930", VA = "0x182A85B30")]
			internal ReducerFactory(ReducerFactory<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2A85AE0", Offset = "0x2A848E0", VA = "0x182A85AE0")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : XQXZMUBXLZL.DWJYUUNGKFV<TWGQWHZWPAR, SQESMBBMMXQ>
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
				public AsyncTaskMethodBuilder<Result<object?, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public SQESMBBMMXQ receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public TWGQWHZWPAR action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2A88100", Offset = "0x2A86F00", VA = "0x182A88100", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2A882E0", Offset = "0x2A870E0", VA = "0x182A882E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB1F440", Offset = "0xB1E240", VA = "0x180B1F440", Slot = "4")]
			public Id32<YCAINYDNLEL> ZKUDHKRHHVS(SQESMBBMMXQ a)
			{
				return default(Id32<YCAINYDNLEL>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2A87370", Offset = "0x2A86170", VA = "0x182A87370", Slot = "5")]
			public void LRFWKSYKFFJ(SQESMBBMMXQ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A873D0", Offset = "0x2A861D0", VA = "0x182A873D0", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, IGWAJAWUKJF>> SXKEKMTCUKK(SQESMBBMMXQ a, TWGQWHZWPAR b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A87350", Offset = "0x2A86150", VA = "0x182A87350", Slot = "7")]
			public TWGQWHZWPAR[] JLOOYZNAFUU(SQESMBBMMXQ a)
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
			public AsyncTaskMethodBuilder<Result<object?, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public SQESMBBMMXQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public TWGQWHZWPAR action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2A88350", Offset = "0x2A87150", VA = "0x182A88350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2A88540", Offset = "0x2A87340", VA = "0x182A88540", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public SQESMBBMMXQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2A89A80", Offset = "0x2A88880", VA = "0x182A89A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2A89D00", Offset = "0x2A88B00", VA = "0x182A89D00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public SQESMBBMMXQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2A89D70", Offset = "0x2A88B70", VA = "0x182A89D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2A89F50", Offset = "0x2A88D50", VA = "0x182A89F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<YCAINYDNLEL> ZTCPJTVVDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer JEBAZTXESXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 TATWJDAIPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly GMJPGHKCHRR ZEUAMDDCFSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly QCQTPBNJHXP.CreationArgs REPCURPEQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly WLYGUQOAGOG PQIRIESONRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly FUCJYBVUJEN EARPVLRDTOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly FTRIKGTBENM FYZJLCUVMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly JWQZMAHNKYL GQHGCSQWSDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly GZDOLFCVQSB JZCZRITPJCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly SZSDWFPYCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly YIWICSULTBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest XLOKATMPCRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended WJDFJXJALUA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal ZLOMSCLYJNW DFJJYUDBWLV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2A868A0", Offset = "0x2A856A0", VA = "0x182A868A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal AYIPZYLYXPE MYLVKUNYCMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2A86D70", Offset = "0x2A85B70", VA = "0x182A86D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2A87000", Offset = "0x2A85E00", VA = "0x182A87000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool FCGOGSZXJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2A86E70", Offset = "0x2A85C70", VA = "0x182A86E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A86230", Offset = "0x2A85030", VA = "0x182A86230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public SDFISTTFXWB WLYGUQOAGOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2A87310", Offset = "0x2A86110", VA = "0x182A87310", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OSTVCSSHBGP FTRIKGTBENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2A87320", Offset = "0x2A86120", VA = "0x182A87320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KDAJBBLLCEQ GZDOLFCVQSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2A87340", Offset = "0x2A86140", VA = "0x182A87340", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OHNNIEAVYVG FUCJYBVUJEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2A86840", Offset = "0x2A85640", VA = "0x182A86840", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public XGPBBHKGHAM JWQZMAHNKYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2A87330", Offset = "0x2A86130", VA = "0x182A87330", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public QCQTPBNJHXP? QCQTPBNJHXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2A86D80", Offset = "0x2A85B80", VA = "0x182A86D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2A87020", Offset = "0x2A85E20", VA = "0x182A87020")]
		private SQESMBBMMXQ(GMJPGHKCHRR a, Id32<YCAINYDNLEL> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, AYIPZYLYXPE b, [In] QCQTPBNJHXP.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A868F0", Offset = "0x2A856F0", VA = "0x182A868F0")]
		public static SQESMBBMMXQ New(GMJPGHKCHRR deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<YCAINYDNLEL> actorId, Id32<DMDLWDYEPPG> rootNetworkObjectId, EGZVYBEHFSY staticNetSys, OYPORLQHLJO dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2A869C0", Offset = "0x2A857C0", VA = "0x182A869C0")]
		public static SQESMBBMMXQ New(GMJPGHKCHRR dependencies, [In] RegistryV2 registryV2, Id32<YCAINYDNLEL> actorId, Id32<DMDLWDYEPPG> rootNetworkObjectId, EGZVYBEHFSY staticNetSys, OYPORLQHLJO dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2A86050", Offset = "0x2A84E50", VA = "0x182A86050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2A85E70", Offset = "0x2A84C70", VA = "0x182A85E70")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, IGWAJAWUKJF>> BJGYTMVKQYX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2A85F60", Offset = "0x2A84D60", VA = "0x182A85F60")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, IGWAJAWUKJF>> DRYLZGEGKYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2A86640", Offset = "0x2A85440", VA = "0x182A86640")]
		internal void LMIXLOQQQWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A86C80", Offset = "0x2A85A80", VA = "0x182A86C80")]
		internal Option<TWGQWHZWPAR> RMIXWJOQTBN([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<TWGQWHZWPAR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A86D00", Offset = "0x2A85B00", VA = "0x182A86D00")]
		internal bool RNLQNSKXSNC([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A86E80", Offset = "0x2A85C80", VA = "0x182A86E80")]
		internal Result<TWGQWHZWPAR, IGWAJAWUKJF> XWGNGAQEXFJ([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<TWGQWHZWPAR, IGWAJAWUKJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2A86850", Offset = "0x2A85650", VA = "0x182A86850")]
		private void LRFWKSYKFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A85D60", Offset = "0x2A84B60", VA = "0x182A85D60")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, IGWAJAWUKJF>> ADCQHCDNIZR(TWGQWHZWPAR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A86240", Offset = "0x2A85040", VA = "0x182A86240")]
		private TWGQWHZWPAR[] JLOOYZNAFUU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class IVQKSOVQHGW<a> : RHLDYTPLBXY, JSQOPJRWQVC, XDRQUNZRUHP where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<KSHTGNRFKHE>? HEVPOTOBMSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string AYLMHGPFJYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a YTUDXKSFVRJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<KSHTGNRFKHE>? EZKJEXHGXUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2D6D4A0", Offset = "0x2D6C2A0", VA = "0x182D6D4A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x52EBA80", Offset = "0x52EA880", VA = "0x1852EBA80")]
		internal IVQKSOVQHGW([In] Id128<KSHTGNRFKHE>? lastNode, Id32<LZWQSLFTVFT>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class WOQFEVMFWEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BED0", Offset = "0x2A9ACD0", VA = "0x182A9BED0")]
		public static Result<DebugExecutionResult, JSQOPJRWQVC> UDIRTTESUHR([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, JSQOPJRWQVC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3E86180", Offset = "0x3E84F80", VA = "0x183E86180")]
		public static Result<TOk, JSQOPJRWQVC> SGYTMQNKXNL<TOk>([In] this Result<TOk, JSQOPJRWQVC> self, [In] Id128<KSHTGNRFKHE>? lastNode, Id32<LZWQSLFTVFT>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, JSQOPJRWQVC>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GMJPGHKCHRR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		LPFVMTQVGRX.ZLOMSCLYJNW CGAUFAQGAED
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		SQESMBBMMXQ.ZLOMSCLYJNW ASIJCYYYTEU
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		TJDAFASHBMR.ZLOMSCLYJNW GKLYXYZYSVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ> BNOHTPALDTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.ZLOMSCLYJNW TFCUKQZSBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		EMOXSDWCFKN TWTJQHHARIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VADHWBRYBMQ BNJTVCTNMZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		OBAYIOUBMIS WHTCTRONSTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		HJJZQHCBFAG CKWNRKHWSIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		CNVYILPYZTW PYMUGAXKGMD
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
	public static class TKMVYPIADLS
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2A875D0", Offset = "0x2A863D0", VA = "0x182A875D0")]
		public static TWGQWHZWPAR TGUTIXLHRMP(this TWGQWHZWPAR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2A87500", Offset = "0x2A86300", VA = "0x182A87500")]
		public static TWGQWHZWPAR DQSEUONJFZC(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public SQESMBBMMXQ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2A885B0", Offset = "0x2A873B0", VA = "0x182A885B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CE0", Offset = "0x2A87AE0", VA = "0x182A88CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FBE0", Offset = "0x2A7E9E0", VA = "0x182A7FBE0")]
		public static TWGQWHZWPAR SCFDPFQZIDX(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FCA0", Offset = "0x2A7EAA0", VA = "0x182A7FCA0")]
		public static ReduceAction<ActionKind, CompressedPayload> YXFPAPMHRQM(TWGQWHZWPAR actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FAD0", Offset = "0x2A7E8D0", VA = "0x182A7FAD0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, IGWAJAWUKJF>> ADCQHCDNIZR(SQESMBBMMXQ a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FDD0", Offset = "0x2A7EBD0", VA = "0x182A7FDD0")]
		public static TWGQWHZWPAR SCFDPFQZIDX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FE70", Offset = "0x2A7EC70", VA = "0x182A7FE70")]
		public static ReduceAction<ActionKind, DestroyPayload> YXFPAPMHRQM(TWGQWHZWPAR actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FD50", Offset = "0x2A7EB50", VA = "0x182A7FD50")]
		public static Result<None, XVHVDWKBFCE> DMYPNYVRMZX(SQESMBBMMXQ a, [In] DestroyPayload self)
		{
			return default(Result<None, XVHVDWKBFCE>);
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
			public AsyncTaskMethodBuilder<Result<None, XVHVDWKBFCE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public SQESMBBMMXQ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, XVHVDWKBFCE> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2A88DC0", Offset = "0x2A87BC0", VA = "0x182A88DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2A89360", Offset = "0x2A88160", VA = "0x182A89360", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E4AB30", Offset = "0x1E49930", VA = "0x181E4AB30")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A80BC0", Offset = "0x2A7F9C0", VA = "0x182A80BC0")]
		public static TWGQWHZWPAR? SCFDPFQZIDX(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A80CC0", Offset = "0x2A7FAC0", VA = "0x182A80CC0")]
		public static ReduceAction<ActionKind, FullInitializePayload> YXFPAPMHRQM(TWGQWHZWPAR actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A80A80", Offset = "0x2A7F880", VA = "0x182A80A80")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, XVHVDWKBFCE>> ADCQHCDNIZR(SQESMBBMMXQ a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public SQESMBBMMXQ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, IGWAJAWUKJF> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, XDRQUNZRUHP>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, XDRQUNZRUHP> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, XDRQUNZRUHP>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2A88870", Offset = "0x2A87670", VA = "0x182A88870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2A88D50", Offset = "0x2A87B50", VA = "0x182A88D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<TWGQWHZWPAR> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		private MultiPayload(IReadOnlyList<TWGQWHZWPAR> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2A84460", Offset = "0x2A83260", VA = "0x182A84460")]
		public static TWGQWHZWPAR SCFDPFQZIDX(IReadOnlyList<TWGQWHZWPAR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2A84520", Offset = "0x2A83320", VA = "0x182A84520")]
		public static ReduceAction<ActionKind, MultiPayload> YXFPAPMHRQM(TWGQWHZWPAR actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A84320", Offset = "0x2A83120", VA = "0x182A84320")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, IGWAJAWUKJF>> ADCQHCDNIZR(SQESMBBMMXQ a, MultiPayload b)
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
		private sealed class ZRSJAVAQQNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> NXCADOHQGPK;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZRSJAVAQQNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FC50", Offset = "0x2A9EA50", VA = "0x182A9FC50")]
			internal TWGQWHZWPAR NVZMTVBIALW(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2A84B90", Offset = "0x2A83990", VA = "0x182A84B90")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A84930", Offset = "0x2A83730", VA = "0x182A84930")]
		public static TWGQWHZWPAR SCFDPFQZIDX(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A846A0", Offset = "0x2A834A0", VA = "0x182A846A0")]
		public static TWGQWHZWPAR[] DDTBMAIAYYM(TWGQWHZWPAR a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2A84A40", Offset = "0x2A83840", VA = "0x182A84A40")]
		public static ReduceAction<ActionKind, PartialActionPayload> YXFPAPMHRQM(TWGQWHZWPAR actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A847A0", Offset = "0x2A835A0", VA = "0x182A847A0")]
		public static Result<TWGQWHZWPAR, IGWAJAWUKJF> DMYPNYVRMZX(SQESMBBMMXQ a, [In] PartialActionPayload self)
		{
			return default(Result<TWGQWHZWPAR, IGWAJAWUKJF>);
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
			public AsyncTaskMethodBuilder<Result<bool, XVHVDWKBFCE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public SQESMBBMMXQ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, XVHVDWKBFCE> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, XVHVDWKBFCE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2A893D0", Offset = "0x2A881D0", VA = "0x182A893D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2A89A10", Offset = "0x2A88810", VA = "0x182A89A10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xDCD320", Offset = "0xDCC120", VA = "0x180DCD320")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2A84ED0", Offset = "0x2A83CD0", VA = "0x182A84ED0")]
		public static TWGQWHZWPAR SCFDPFQZIDX(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2A84CE0", Offset = "0x2A83AE0", VA = "0x182A84CE0")]
		public static TWGQWHZWPAR?[]? AMXGPITKRXA(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2A84FB0", Offset = "0x2A83DB0", VA = "0x182A84FB0")]
		public static ReduceAction<ActionKind, PartialInitializePayload> YXFPAPMHRQM(TWGQWHZWPAR actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2A84BB0", Offset = "0x2A839B0", VA = "0x182A84BB0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, XVHVDWKBFCE>> ADCQHCDNIZR(SQESMBBMMXQ a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class WLYGUQOAGOG : SDFISTTFXWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public PJKDTWMBYBM? GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2A9BDC0", Offset = "0x2A9ABC0", VA = "0x182A9BDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		internal WLYGUQOAGOG(SQESMBBMMXQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class ELGZDWCPQNL : PJKDTWMBYBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly QCQTPBNJHXP DDZJRTGYFSV;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public ELGZDWCPQNL(SQESMBBMMXQ a, QCQTPBNJHXP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FF20", Offset = "0x2A7ED20", VA = "0x182A7FF20", Slot = "4")]
		public Result<DebugExecutionResult, JSQOPJRWQVC> BKIJKHWENAN(Id128<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<TAGQJDWMKQY> inputId)
		{
			return default(Result<DebugExecutionResult, JSQOPJRWQVC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2A804D0", Offset = "0x2A7F2D0", VA = "0x182A804D0", Slot = "5")]
		public Result<DebugExecutionResult, JSQOPJRWQVC> DUFHXEWTFSY(Id128<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<MEQLWUNNBJN> outputId)
		{
			return default(Result<DebugExecutionResult, JSQOPJRWQVC>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class LPFVMTQVGRX : AYIPZYLYXPE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface ZLOMSCLYJNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<YOFTFORYWYQ> KEXERYEUZMZ(SQESMBBMMXQ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class JSRFTFIQFIZ : ZLOMSCLYJNW
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
				public AsyncTaskMethodBuilder<YOFTFORYWYQ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public SQESMBBMMXQ circuitsManager;

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
				private TaskAwaiter<TJDAFASHBMR> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2A876E0", Offset = "0x2A864E0", VA = "0x182A876E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2A878B0", Offset = "0x2A866B0", VA = "0x182A878B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2A815A0", Offset = "0x2A803A0", VA = "0x182A815A0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<YOFTFORYWYQ> KEXERYEUZMZ(SQESMBBMMXQ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
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
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			protected JSRFTFIQFIZ()
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
			public AsyncTaskMethodBuilder<YOFTFORYWYQ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public LPFVMTQVGRX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2A87920", Offset = "0x2A86720", VA = "0x182A87920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2A87B20", Offset = "0x2A86920", VA = "0x182A87B20", Slot = "5")]
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
			public LPFVMTQVGRX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public SQESMBBMMXQ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<YOFTFORYWYQ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2A87B90", Offset = "0x2A86990", VA = "0x182A87B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2A880A0", Offset = "0x2A86EA0", VA = "0x182A880A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ZLOMSCLYJNW JGLYIVPXDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> CTDXRZJHHUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> JNQZNWTQHYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource ZWWUYCILSNU;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool FCGOGSZXJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC12EC0", Offset = "0xC11CC0", VA = "0x180C12EC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC56AC0", Offset = "0xC558C0", VA = "0x180C56AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF6D050", Offset = "0xF6BE50", VA = "0x180F6D050", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xFB6170", Offset = "0xFB4F70", VA = "0x180FB6170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool NHDMQDQMZNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1AF39F0", Offset = "0x1AF27F0", VA = "0x181AF39F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1AF3A00", Offset = "0x1AF2800", VA = "0x181AF3A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public YOFTFORYWYQ? GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A83AE0", Offset = "0x2A828E0", VA = "0x182A83AE0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<YOFTFORYWYQ> OQZOHOBIURI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A83D10", Offset = "0x2A82B10", VA = "0x182A83D10")]
		public LPFVMTQVGRX(ZLOMSCLYJNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A83BD0", Offset = "0x2A829D0", VA = "0x182A83BD0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task XLUTMZIGPVJ(SQESMBBMMXQ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2A83970", Offset = "0x2A82770", VA = "0x182A83970", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class DJATNJGFHYM : VRBOJQGOWRF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly VHVTYYKGQWO VECXYQIAGTL;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public DJATNJGFHYM(VHVTYYKGQWO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class INUVVAHVIOL
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class HPHFCDHQGFN<a> : JWKBEMIEJCU where a : QNLBMLMRCBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a VTMARAJENJO;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? TRKCOPUKNPY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xF26EA0", Offset = "0xF25CA0", VA = "0x180F26EA0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<KSHTGNRFKHE>? JGABJAIXPKC
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x5209AF0", Offset = "0x52088F0", VA = "0x185209AF0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<DINEWLJZVXU> AFDTTBFKAAA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2D69280", Offset = "0x2D68080", VA = "0x182D69280", Slot = "5")]
				get
				{
					return default(Id32<DINEWLJZVXU>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<DINEWLJZVXU>? XWUYJRYYHXO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x5209A70", Offset = "0x5208870", VA = "0x185209A70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
			public HPHFCDHQGFN(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class WDBBQYRHZNZ : HPHFCDHQGFN<QYDTWJDFKFZ>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? TRKCOPUKNPY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x1044500", Offset = "0x1043300", VA = "0x181044500", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A9BCF0", Offset = "0x2A9AAF0", VA = "0x182A9BCF0")]
			public WDBBQYRHZNZ(QYDTWJDFKFZ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2A81420", Offset = "0x2A80220", VA = "0x182A81420")]
		public static JWKBEMIEJCU New(QNLBMLMRCBE graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class VTTOXVMBUGL : EBFWVJZXQPI, EEQNEYOCGVS, ENFFXWRYOWP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class HDCOZLYGOPH
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
				public HDCOZLYGOPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public EMOXSDWCFKN errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x2A8B160", Offset = "0x2A89F60", VA = "0x182A8B160", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x2A8B3D0", Offset = "0x2A8A1D0", VA = "0x182A8B3D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public VTTOXVMBUGL WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool MBOOQWZPTSE;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public HDCOZLYGOPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2A81050", Offset = "0x2A7FE50", VA = "0x182A81050")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task PLUNBZHPYHT(EMOXSDWCFKN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ABSHQAFZKQB
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
				public ABSHQAFZKQB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x2A8B430", Offset = "0x2A8A230", VA = "0x182A8B430", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x2A8B710", Offset = "0x2A8A510", VA = "0x182A8B710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public VTTOXVMBUGL WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int MBOOQWZPTSE;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ABSHQAFZKQB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E730", Offset = "0x2A7D530", VA = "0x182A7E730")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task CWLZSZEXNSH(EMOXSDWCFKN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class LZXPMSDOCGI
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
				public LZXPMSDOCGI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x2A8BC80", Offset = "0x2A8AA80", VA = "0x182A8BC80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x2A8C130", Offset = "0x2A8AF30", VA = "0x182A8C130", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string MBOOQWZPTSE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public VTTOXVMBUGL WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int UGKOXXXRONG;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LZXPMSDOCGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2A83E80", Offset = "0x2A82C80", VA = "0x182A83E80")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task GPKDHAPYKYJ(EMOXSDWCFKN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class AFGQJODGXZR
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
				public AFGQJODGXZR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x2A8B770", Offset = "0x2A8A570", VA = "0x182A8B770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x2A8BC20", Offset = "0x2A8AA20", VA = "0x182A8BC20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string MBOOQWZPTSE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public VTTOXVMBUGL WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int UGKOXXXRONG;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public AFGQJODGXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E800", Offset = "0x2A7D600", VA = "0x182A7E800")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task RRIKKDBWLQV(EMOXSDWCFKN a)
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
			public VTTOXVMBUGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2A89FC0", Offset = "0x2A88DC0", VA = "0x182A89FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A4D0", Offset = "0x2A892D0", VA = "0x182A8A4D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly QQLEQPIAOLA BILYNSSDGJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<UKWLAFVDYXO> YDAEGBWYINL;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private GMJPGHKCHRR JSRFTFIQFIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A99240", Offset = "0x2A98040", VA = "0x182A99240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<TAGQJDWMKQY> GIGMMLLCGOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE2BA00", Offset = "0xE2A800", VA = "0x180E2BA00", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<TAGQJDWMKQY>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xF17CB0", Offset = "0xF16AB0", VA = "0x180F17CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<LJLJBSUERVT> TOGVRAJPTZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B270", Offset = "0x2A1A070", VA = "0x182A1B270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<UTWGPDLERGC> YMAYMIUJEVW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x128BCF0", Offset = "0x128AAF0", VA = "0x18128BCF0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<UTWGPDLERGC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<LZWQSLFTVFT> JOCYUAJHWYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A98730", Offset = "0x2A97530", VA = "0x182A98730", Slot = "22")]
			get
			{
				return default(Id32<LZWQSLFTVFT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool AYNCACPEDFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A97EC0", Offset = "0x2A96CC0", VA = "0x182A97EC0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BAC0", Offset = "0x2A9A8C0", VA = "0x182A9BAC0")]
		private VTTOXVMBUGL(SQESMBBMMXQ a, FDTJOQJNBIL b, QQLEQPIAOLA c, Id32<TDADSARCMWU> portGroupId, Id32<TAGQJDWMKQY> inputId, Id32<LJLJBSUERVT> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A98940", Offset = "0x2A97740", VA = "0x182A98940")]
		public static VTTOXVMBUGL New(SQESMBBMMXQ circuitsManager, FDTJOQJNBIL node, QQLEQPIAOLA input, Id32<TDADSARCMWU> portGroupId, Id32<LJLJBSUERVT> inputDefId, Id32<TAGQJDWMKQY> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A980B0", Offset = "0x2A96EB0", VA = "0x182A980B0", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A97F40", Offset = "0x2A96D40", VA = "0x182A97F40", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A820", Offset = "0x2A99620", VA = "0x182A9A820", Slot = "32")]
		public void RVOVHCOETRY(UKWLAFVDYXO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A99260", Offset = "0x2A98060", VA = "0x182A99260", Slot = "29")]
		public void RFBSQXTHKUF(PKPEEAYTUCE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A99700", Offset = "0x2A98500", VA = "0x182A99700", Slot = "30")]
		public void RPYZBMJIIMY(VTNXVIFKPLM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A99620", Offset = "0x2A98420", VA = "0x182A99620", Slot = "25")]
		protected override void RLGXQXWRSYO(LJAXFGDMSRT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AD70", Offset = "0x2A99B70", VA = "0x182A9AD70", Slot = "34")]
		public string SSDEPPGWQVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AAB0", Offset = "0x2A998B0", VA = "0x182A9AAB0", Slot = "31")]
		public string SPJBDZGTOSV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B890", Offset = "0x2A9A690", VA = "0x182A9B890")]
		private void ZHDPRMSJFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A97FE0", Offset = "0x2A96DE0", VA = "0x182A97FE0", Slot = "33")]
		public void FXUFXUHDSIN(UKWLAFVDYXO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B6D0", Offset = "0x2A9A4D0", VA = "0x182A9B6D0")]
		private void XWIPPWZSEJA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B450", Offset = "0x2A9A250", VA = "0x182A9B450", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task VYPOOUKCBTI(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A985E0", Offset = "0x2A973E0", VA = "0x182A985E0")]
		public void KIVYSVMGWQP(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AEE0", Offset = "0x2A99CE0", VA = "0x182A9AEE0")]
		private void UAJKAAOKQTF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A98780", Offset = "0x2A97580", VA = "0x182A98780")]
		private void NQDKOBARPGL(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A97C30", Offset = "0x2A96A30", VA = "0x182A97C30")]
		private void DAICNRKRAUE(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A99100", Offset = "0x2A97F00", VA = "0x182A99100")]
		private string QQLVTGKAKHJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B560", Offset = "0x2A9A360", VA = "0x182A9B560")]
		private string XSEWKTKVCZM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF17CB0", Offset = "0xF16AB0", VA = "0x180F17CB0")]
		internal void FSVGVNUKAYN(Id32<TAGQJDWMKQY> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A880", Offset = "0x2A99680", VA = "0x182A9A880")]
		[CompilerGenerated]
		private void RVTRLMGNWDA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A890", Offset = "0x2A99690", VA = "0x182A9A890")]
		[CompilerGenerated]
		private bool RVYYITALFOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A760", Offset = "0x2A99560", VA = "0x182A9A760")]
		[CompilerGenerated]
		private bool RVOKOFMQMRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A98220", Offset = "0x2A97020", VA = "0x182A98220")]
		[CompilerGenerated]
		private int RWOTANIDHWK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AA20", Offset = "0x2A99820", VA = "0x182A9AA20")]
		[CompilerGenerated]
		private bool RWTZXUCARHT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A950", Offset = "0x2A99750", VA = "0x182A9A950")]
		[CompilerGenerated]
		private void RWEFFZUIOZS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A960", Offset = "0x2A99760", VA = "0x182A9A960")]
		[CompilerGenerated]
		private bool RWJMDGOFYLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A680", Offset = "0x2A99480", VA = "0x182A9A680")]
		[CompilerGenerated]
		private bool RUDOHKDIYQG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A6D0", Offset = "0x2A994D0", VA = "0x182A9A6D0")]
		[CompilerGenerated]
		private bool RUIVEQXGIBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A98220", Offset = "0x2A97020", VA = "0x182A98220")]
		[CompilerGenerated]
		private int JHTHWPHKNHZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A98150", Offset = "0x2A96F50", VA = "0x182A98150")]
		[CompilerGenerated]
		private bool JHOAZINNDWQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A982D0", Offset = "0x2A970D0", VA = "0x182A982D0")]
		[CompilerGenerated]
		private object JIDVRCVFGER()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A98270", Offset = "0x2A97070", VA = "0x182A98270")]
		[CompilerGenerated]
		private void JHYOTWBHWTI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A98330", Offset = "0x2A97130", VA = "0x182A98330")]
		[CompilerGenerated]
		private bool JIJCOJPCPQA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A98410", Offset = "0x2A97210", VA = "0x182A98410")]
		[CompilerGenerated]
		private string JIYXGDWURYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A98400", Offset = "0x2A97200", VA = "0x182A98400")]
		[CompilerGenerated]
		private void JITQIXCXIMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A98510", Offset = "0x2A97310", VA = "0x182A98510")]
		[CompilerGenerated]
		private bool JJJLARKPKUT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A98490", Offset = "0x2A97290", VA = "0x182A98490")]
		[CompilerGenerated]
		private string JJEEDKQSBJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A98D70", Offset = "0x2A97B70", VA = "0x182A98D70")]
		[CompilerGenerated]
		private void OMGFQUVWIEA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A98D80", Offset = "0x2A97B80", VA = "0x182A98D80")]
		[CompilerGenerated]
		private bool OMLMOBPTRPJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A98E50", Offset = "0x2A97C50", VA = "0x182A98E50")]
		[CompilerGenerated]
		private string OMQTLIJRBAS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A98ED0", Offset = "0x2A97CD0", VA = "0x182A98ED0")]
		[CompilerGenerated]
		private void OMWAIPDOKMB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A98EE0", Offset = "0x2A97CE0", VA = "0x182A98EE0")]
		[CompilerGenerated]
		private bool ONBHFVXLTXK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A98FB0", Offset = "0x2A97DB0", VA = "0x182A98FB0")]
		[CompilerGenerated]
		private string ONGODCRJDIT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A99020", Offset = "0x2A97E20", VA = "0x182A99020")]
		[CompilerGenerated]
		private void ONLVAJLGMUC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A99030", Offset = "0x2A97E30", VA = "0x182A99030")]
		[CompilerGenerated]
		private bool ONRBXQFDWFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A98CF0", Offset = "0x2A97AF0", VA = "0x182A98CF0")]
		[CompilerGenerated]
		private string OKQCMSSRKRG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A98D60", Offset = "0x2A97B60", VA = "0x182A98D60")]
		[CompilerGenerated]
		private void OKVJJZMOUCP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B1D0", Offset = "0x2A99FD0", VA = "0x182A9B1D0")]
		[CompilerGenerated]
		private bool VMXKPNDYXWJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B160", Offset = "0x2A99F60", VA = "0x182A9B160")]
		[CompilerGenerated]
		private string VMSDSGKBOLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B150", Offset = "0x2A99F50", VA = "0x182A9B150")]
		[CompilerGenerated]
		private void VMMWUZQEEZR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B080", Offset = "0x2A99E80", VA = "0x182A9B080")]
		[CompilerGenerated]
		private bool VMHPXSWGVOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B3E0", Offset = "0x2A9A1E0", VA = "0x182A9B3E0")]
		[CompilerGenerated]
		private string VNSMEOFOJPT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B3D0", Offset = "0x2A9A1D0", VA = "0x182A9B3D0")]
		[CompilerGenerated]
		private void VNNFHHLRAEK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B300", Offset = "0x2A9A100", VA = "0x182A9B300")]
		[CompilerGenerated]
		private bool VNHYKARTQTB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B2A0", Offset = "0x2A9A0A0", VA = "0x182A9B2A0")]
		[CompilerGenerated]
		private object VNCRMTXWHHS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A98270", Offset = "0x2A97070", VA = "0x182A98270")]
		[CompilerGenerated]
		private void VLHHLLAUAJP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A97DF0", Offset = "0x2A96BF0", VA = "0x182A97DF0")]
		[CompilerGenerated]
		private bool DJUYFKGRWOS()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class JYRGPRGOAPR
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class HQJKYQHBSQZ : OAOZZKUFIDL<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public HQJKYQHBSQZ WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F300", Offset = "0x2A7E100", VA = "0x182A7F300")]
				internal object FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x2A7EE10", Offset = "0x2A7DC10", VA = "0x182A7EE10")]
				internal void FUUBPHYMSZO(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2A813B0", Offset = "0x2A801B0", VA = "0x182A813B0")]
			public HQJKYQHBSQZ(SQESMBBMMXQ a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2A81140", Offset = "0x2A7FF40", VA = "0x182A81140", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class BHRUYQGJKBS : BNGOKRALVTA<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType YLRADNSNNPL
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E8D0", Offset = "0x2A7D6D0", VA = "0x182A7E8D0")]
			public BHRUYQGJKBS(SQESMBBMMXQ a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class MIMYUGRXGAO : OAOZZKUFIDL<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2A842B0", Offset = "0x2A830B0", VA = "0x182A842B0")]
			public MIMYUGRXGAO(SQESMBBMMXQ a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2A84150", Offset = "0x2A82F50", VA = "0x182A84150", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2A84100", Offset = "0x2A82F00", VA = "0x182A84100")]
			[CompilerGenerated]
			private bool WULKSOUHZHV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2A83FD0", Offset = "0x2A82DD0", VA = "0x182A83FD0")]
			[CompilerGenerated]
			private void WUGDVIAKPWM(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class ZXLCFLGZPBY : OAOZZKUFIDL<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public ZXLCFLGZPBY WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F450", Offset = "0x2A7E250", VA = "0x182A7F450")]
				internal void FUZIMOSKCKX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F260", Offset = "0x2A7E060", VA = "0x182A7F260")]
				internal bool FUUBPHYMSZO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F670", Offset = "0x2A7E470", VA = "0x182A7F670")]
				internal bool FVJWHCGEVHP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F4A0", Offset = "0x2A7E2A0", VA = "0x182A7F4A0")]
				internal void FVEPJVMHLWG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F8D0", Offset = "0x2A7E6D0", VA = "0x182A7F8D0")]
				internal bool FVUKBPTZOEH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA0870", Offset = "0x2A9F670", VA = "0x182AA0870")]
			public ZXLCFLGZPBY(SQESMBBMMXQ a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA0560", Offset = "0x2A9F360", VA = "0x182AA0560", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class YKDTXBOGECK : OAOZZKUFIDL<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public YKDTXBOGECK WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> CBQIOSOCRXF;

				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F360", Offset = "0x2A7E160", VA = "0x182A7F360")]
				internal object? FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F920", Offset = "0x2A7E720", VA = "0x182A7F920")]
				internal bool FVZQYWNWXPQ(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2A7EEE0", Offset = "0x2A7DCE0", VA = "0x182A7EEE0")]
				internal void FUUBPHYMSZO(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F6C0", Offset = "0x2A7E4C0", VA = "0x182A7F6C0")]
				internal string FVJWHCGEVHP(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F5D0", Offset = "0x2A7E3D0", VA = "0x182A7F5D0")]
				internal IReadOnlyList<object> FVEPJVMHLWG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F860", Offset = "0x2A7E660", VA = "0x182A7F860")]
				internal bool FVUKBPTZOEH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F810", Offset = "0x2A7E610", VA = "0x182A7F810")]
				internal bool FVPDEJACESY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F9A0", Offset = "0x2A7E7A0", VA = "0x182A7F9A0")]
				internal void FWEXWDHUHAZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E9D0", Offset = "0x2A9D7D0", VA = "0x182A9E9D0")]
			public YKDTXBOGECK(SQESMBBMMXQ a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E2D0", Offset = "0x2A9D0D0", VA = "0x182A9E2D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class GTAYSMQKCVX : OAOZZKUFIDL<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public GTAYSMQKCVX WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F2B0", Offset = "0x2A7E0B0", VA = "0x182A7F2B0")]
				internal bool FUZIMOSKCKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F130", Offset = "0x2A7DF30", VA = "0x182A7F130")]
				internal void FUUBPHYMSZO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2A7F620", Offset = "0x2A7E420", VA = "0x182A7F620")]
				internal bool FVJWHCGEVHP()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2A80FE0", Offset = "0x2A7FDE0", VA = "0x182A80FE0")]
			public GTAYSMQKCVX(SQESMBBMMXQ a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2A80DD0", Offset = "0x2A7FBD0", VA = "0x182A80DD0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class ZPXNQKJHNSG : OAOZZKUFIDL<VEOFFGUHYOL>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class ROWRFPJNAWU
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
					public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public ROWRFPJNAWU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<ZSZVPFOYVHO>, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x2A8A910", Offset = "0x2A89710", VA = "0x182A8A910", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x2A8ACF0", Offset = "0x2A89AF0", VA = "0x182A8ACF0", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public ROWRFPJNAWU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2A8AD60", Offset = "0x2A89B60", VA = "0x182A8AD60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2A8B0F0", Offset = "0x2A89EF0", VA = "0x182A8B0F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task EKIBAXZITGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string DFXXTMAOKZY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public DWVMJQUITOW.ETFEXRFRZQU UVNXYAJHTGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool ZBVTBEWZJED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public ZPXNQKJHNSG WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public DWVMJQUITOW DKEALQBNYOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action MMVLRUFBGXR;

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ROWRFPJNAWU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x2A85AB0", Offset = "0x2A848B0", VA = "0x182A85AB0")]
				internal bool YELQTILLWXX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				internal string KHKVRHMUJVA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2A857D0", Offset = "0x2A845D0", VA = "0x182A857D0")]
				internal void KHFOUASXAJR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x2A85780", Offset = "0x2A84580", VA = "0x182A85780")]
				internal void KHAHWTYZQYI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x15BE870", Offset = "0x15BD670", VA = "0x1815BE870")]
				internal bool KILEDPIHEZT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2A85890", Offset = "0x2A84690", VA = "0x182A85890")]
				internal void KIFXGIOJVOK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x2A85850", Offset = "0x2A84650", VA = "0x182A85850")]
				internal bool KIAQJBUMMDB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2A85690", Offset = "0x2A84490", VA = "0x182A85690")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, IGWAJAWUKJF>> DQEJNRFRRKZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2A855A0", Offset = "0x2A843A0", VA = "0x182A855A0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, IGWAJAWUKJF>> AJGADVIBZMC()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class ZVGRUIXYDWS
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
					public AsyncTaskMethodBuilder<Result<Id32<ZSZVPFOYVHO>, IGWAJAWUKJF>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<ZSZVPFOYVHO>, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x2A8A530", Offset = "0x2A89330", VA = "0x182A8A530", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x2A8A8A0", Offset = "0x2A896A0", VA = "0x182A8A8A0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public ZPXNQKJHNSG WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public PCBXNHFFHWA DNQVQJFKFXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool ZCONTTCQOAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public DWVMJQUITOW DKEALQBNYOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public EBBOVOSUCEY BCMYPOQXNWL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action CCQRBAJPNBY;

				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZVGRUIXYDWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x2A9FDC0", Offset = "0x2A9EBC0", VA = "0x182A9FDC0")]
				internal object? FUUBPHYMSZO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x2A9FF20", Offset = "0x2A9ED20", VA = "0x182A9FF20")]
				internal void FVJWHCGEVHP(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2A9FE30", Offset = "0x2A9EC30", VA = "0x182A9FE30")]
				internal string FVEPJVMHLWG(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA0170", Offset = "0x2A9EF70", VA = "0x182AA0170")]
				internal IReadOnlyList<object> FVUKBPTZOEH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA0010", Offset = "0x2A9EE10", VA = "0x182AA0010")]
				internal void FVPDEJACESY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2AA02D0", Offset = "0x2A9F0D0", VA = "0x182AA02D0")]
				internal bool FWEXWDHUHAZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2AA0210", Offset = "0x2A9F010", VA = "0x182AA0210")]
				internal void FVZQYWNWXPQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2AA03C0", Offset = "0x2A9F1C0", VA = "0x182AA03C0")]
				internal void FWPLQQVOZXR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2AA0340", Offset = "0x2A9F140", VA = "0x182AA0340")]
				internal void FWKETKBRQMI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2AA0410", Offset = "0x2A9F210", VA = "0x182AA0410")]
				internal bool JHSTJHKLUXS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2AA0470", Offset = "0x2A9F270", VA = "0x182AA0470")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<ZSZVPFOYVHO>, IGWAJAWUKJF>> MWETRQDWKQI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<DINEWLJZVXU>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x2A9FC10", Offset = "0x2A9EA10", VA = "0x182A9FC10", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FBA0", Offset = "0x2A9E9A0", VA = "0x182A9FBA0")]
			public ZPXNQKJHNSG(SQESMBBMMXQ a, VEOFFGUHYOL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2A9F210", Offset = "0x2A9E010", VA = "0x182A9F210", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2A9EB80", Offset = "0x2A9D980", VA = "0x182A9EB80")]
			private void TZAMXGOQBWX(DWVMJQUITOW a, Id32<ZSZVPFOYVHO>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class ZJDSUUZOBFV : XMXHVDDZHBA<LIHKPVXTPJW>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x167B4A0", Offset = "0x167A2A0", VA = "0x18167B4A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool SBBMWCWKXLI
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool XNCMYVYTQXH
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool JSMWPEXRWOQ
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x2A9EA40", Offset = "0x2A9D840", VA = "0x182A9EA40")]
			public ZJDSUUZOBFV(SQESMBBMMXQ a, LIHKPVXTPJW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class TSFLVLAAGDN<a> : OAOZZKUFIDL<a> where a : notnull, EDMDFOQKONX
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
				public AsyncTaskMethodBuilder<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public TSFLVLAAGDN<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x50F00F0", Offset = "0x50EEEF0", VA = "0x1850F00F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x50F0440", Offset = "0x50EF240", VA = "0x1850F0440", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public TSFLVLAAGDN<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<TDADSARCMWU> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x5390600", Offset = "0x538F400", VA = "0x185390600", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x5390950", Offset = "0x538F750", VA = "0x185390950", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<TDADSARCMWU>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x622F930", Offset = "0x622E730", VA = "0x18622F930", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x622F900", Offset = "0x622E700", VA = "0x18622F900")]
			protected TSFLVLAAGDN(SQESMBBMMXQ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x622F6A0", Offset = "0x622E4A0", VA = "0x18622F6A0", Slot = "122")]
			[AsyncStateMachine(typeof(TSFLVLAAGDN<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> KBECSBQJIBS(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x622F860", Offset = "0x622E660", VA = "0x18622F860", Slot = "149")]
			public sealed override bool UTPUPVIFFKV(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x622F7C0", Offset = "0x622E5C0", VA = "0x18622F7C0", Slot = "134")]
			protected sealed override bool MTUJGLUJXEL(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x622F600", Offset = "0x622E400", VA = "0x18622F600", Slot = "135")]
			protected override bool GWMMHYFMTZS(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x622F4F0", Offset = "0x622E2F0", VA = "0x18622F4F0", Slot = "123")]
			[AsyncStateMachine(typeof(TSFLVLAAGDN<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, IGWAJAWUKJF>> BEJVPBITIPZ(Id32<TDADSARCMWU> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class QYHNWDGXJKK : GOYEQGFPMCJ<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public QYHNWDGXJKK WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x2A7EBC0", Offset = "0x2A7D9C0", VA = "0x182A7EBC0")]
				internal bool EJIWEXPPLIG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x2A7ECC0", Offset = "0x2A7DAC0", VA = "0x182A7ECC0")]
				internal void EJODCEJMUTP(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2A85540", Offset = "0x2A84340", VA = "0x182A85540")]
			public QYHNWDGXJKK(SQESMBBMMXQ a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2A85300", Offset = "0x2A84100", VA = "0x182A85300", Slot = "151")]
			protected override void AKQXZFHDGDA(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class KGKDWRGVJST : OAOZZKUFIDL<XYFJDOMLVZW>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class EERSQRFLGMR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int ULVOFDBGWWO;

				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public EERSQRFLGMR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x2A7FEE0", Offset = "0x2A7ECE0", VA = "0x182A7FEE0")]
				internal bool DSMQMEIZCGG(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class QFVEKDSMASK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public KGKDWRGVJST WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> DNDITAIIHBG;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public QFVEKDSMASK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2A851B0", Offset = "0x2A83FB0", VA = "0x182A851B0")]
				internal int FUZIMOSKCKX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x2A85090", Offset = "0x2A83E90", VA = "0x182A85090")]
				internal void FUUBPHYMSZO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2A85250", Offset = "0x2A84050", VA = "0x182A85250")]
				internal string? FVJWHCGEVHP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2A83900", Offset = "0x2A82700", VA = "0x182A83900")]
			public KGKDWRGVJST(SQESMBBMMXQ a, XYFJDOMLVZW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2A83400", Offset = "0x2A82200", VA = "0x182A83400")]
			private int AOJVZEMMUSI(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2A83490", Offset = "0x2A82290", VA = "0x182A83490")]
			private void MGRKNBYKPPM(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2A835B0", Offset = "0x2A823B0", VA = "0x182A835B0", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class ONXFKPJSOJX : XMXHVDDZHBA<YJSQMLLNTYK>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2A84640", Offset = "0x2A83440", VA = "0x182A84640")]
			public ONXFKPJSOJX(SQESMBBMMXQ a, YJSQMLLNTYK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class XMXHVDDZHBA<a> : OAOZZKUFIDL<a> where a : notnull, BQFPTTQQDQO
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class BWQLRALYOFU
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
					public BWQLRALYOFU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x3F49550", Offset = "0x3F48350", VA = "0x183F49550", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public DWVMJQUITOW DKEALQBNYOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public XMXHVDDZHBA<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action CBLBRLUFILW;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public BWQLRALYOFU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x70F7B00", Offset = "0x70F6900", VA = "0x1870F7B00")]
				internal void FUZIMOSKCKX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x70F7DE0", Offset = "0x70F6BE0", VA = "0x1870F7DE0")]
				[AsyncStateMachine(typeof(XMXHVDDZHBA<>.BWQLRALYOFU.<<BuildConfigMenuInternal>b__6>d))]
				internal void FWEXWDHUHAZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x70F7740", Offset = "0x70F6540", VA = "0x1870F7740")]
				internal bool FUUBPHYMSZO()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class BWVSOHFVXRD
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
					public BWVSOHFVXRD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x3F49150", Offset = "0x3F47F50", VA = "0x183F49150", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string PNPNBABISZS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public BWQLRALYOFU YLNIYCOGBOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> CAVGZRMNGDV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> CBVPLZIABIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action CCAWJGBXKTX;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public BWVSOHFVXRD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x70F7E80", Offset = "0x70F6C80", VA = "0x1870F7E80")]
				internal void FVJWHCGEVHP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				internal string FVEPJVMHLWG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
				internal void FVUKBPTZOEH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x70F81F0", Offset = "0x70F6FF0", VA = "0x1870F81F0")]
				[AsyncStateMachine(typeof(XMXHVDDZHBA<>.BWVSOHFVXRD.<<BuildConfigMenuInternal>b__5>d))]
				internal void FVPDEJACESY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class PZBIRBWFHJR
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
					public PZBIRBWFHJR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<OKZGLREOVOG>, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x3F467F0", Offset = "0x3F455F0", VA = "0x183F467F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public PZBIRBWFHJR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3F46F40", Offset = "0x3F45D40", VA = "0x183F46F40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public PZBIRBWFHJR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<LJLJBSUERVT>, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3F47120", Offset = "0x3F45F20", VA = "0x183F47120", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public XMXHVDDZHBA<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<TDADSARCMWU> AJZTYKAPHUC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public DWVMJQUITOW DKEALQBNYOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public NXDEFHNCTOS QXVXMUQZOQN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int XXNWOVPNMJS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int FDKBMDQCXSK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public BYYXKEXKPED ODNOHLMKADM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string PDLMHHSQWQX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<HLFMYWGLVZH> FAOFVAQXNIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public BYYXKEXKPED QHMGMCNLRFZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string MFYRFDFKSRC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<HLFMYWGLVZH> QVUVHFCKQRB;

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public PZBIRBWFHJR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x5D72490", Offset = "0x5D71290", VA = "0x185D72490")]
				internal bool DBDNTMSAPOO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x5D72500", Offset = "0x5D71300", VA = "0x185D72500")]
				internal void DBIUQTLXYZX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x5D72AD0", Offset = "0x5D718D0", VA = "0x185D72AD0")]
				internal bool JUONMJUNGJE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x5D723B0", Offset = "0x5D711B0", VA = "0x185D723B0")]
				[AsyncStateMachine(typeof(XMXHVDDZHBA<>.PZBIRBWFHJR.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void DASZYZEFWRW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5D72450", Offset = "0x5D71250", VA = "0x185D72450")]
				internal bool DAYGWFYDGDF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5D72B10", Offset = "0x5D71910", VA = "0x185D72B10")]
				internal void JVJPBKWCSCO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x5D72910", Offset = "0x5D71710", VA = "0x185D72910")]
				internal bool JSTDLAXKZLB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x5D72830", Offset = "0x5D71630", VA = "0x185D72830")]
				internal void JSNWNUDNPZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x5D72BF0", Offset = "0x5D719F0", VA = "0x185D72BF0")]
				internal bool PSHQGIBINRC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x5D72670", Offset = "0x5D71470", VA = "0x185D72670")]
				internal bool DBYPINTQBHY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x5D726E0", Offset = "0x5D714E0", VA = "0x185D726E0")]
				internal void DCDWFUNNKTH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x5D72570", Offset = "0x5D71370", VA = "0x185D72570")]
				[AsyncStateMachine(typeof(XMXHVDDZHBA<>.PZBIRBWFHJR.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void DBOBOAFVILG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x5D72610", Offset = "0x5D71410", VA = "0x185D72610")]
				internal bool DBTILGZSRWP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x5D72750", Offset = "0x5D71550", VA = "0x185D72750")]
				internal bool DCTQXOVFNBI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x5D727C0", Offset = "0x5D715C0", VA = "0x185D727C0")]
				internal void DCYXUVPCWMR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x5D72A20", Offset = "0x5D71820", VA = "0x185D72A20")]
				[AsyncStateMachine(typeof(XMXHVDDZHBA<>.PZBIRBWFHJR.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void JUJGPDAPWXV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x5D729C0", Offset = "0x5D717C0", VA = "0x185D729C0")]
				internal bool JUDZRWGSNMM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class PYWBTVCHXYI
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
					public PYWBTVCHXYI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x3F46AE0", Offset = "0x3F458E0", VA = "0x183F46AE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string RLOGPBKPXDS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public PZBIRBWFHJR YLNIYCOGBOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> AVTBRHLKCMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> AVNUUARMTAY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action AWDPLUZEVIZ;

				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public PYWBTVCHXYI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x5D71B20", Offset = "0x5D70920", VA = "0x185D71B20")]
				internal void JUTUJQOKPUN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				internal string JVEIEECFIRF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
				internal void JUZBGXIHZFW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x5D71E90", Offset = "0x5D70C90", VA = "0x185D71E90")]
				[AsyncStateMachine(typeof(XMXHVDDZHBA<>.PYWBTVCHXYI.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void JVOVYRQABNX()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class LINQHRUDEAM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool FAOFVAQXNIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public NXDEFHNCTOS QXVXMUQZOQN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<HLFMYWGLVZH> LHJFZFTDHEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public XMXHVDDZHBA<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<TDADSARCMWU> AJZTYKAPHUC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int IQQJVOKGDML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> CBFUUFAHZAN;

				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public LINQHRUDEAM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x558BCF0", Offset = "0x558AAF0", VA = "0x18558BCF0")]
				internal bool YKQBSUYVEOK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class LISXEYOANLV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public ENFFXWRYOWP SQRXAUPCTAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public LINQHRUDEAM YLNIYCOGBOE;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public LISXEYOANLV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x558BDA0", Offset = "0x558ABA0", VA = "0x18558BDA0")]
				internal void YKKUVOEXVDB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0x558BD50", Offset = "0x558AB50", VA = "0x18558BD50")]
				internal bool YKFNYHLALRS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x558BF70", Offset = "0x558AD70", VA = "0x18558BF70")]
				internal void YLQKFCUHZTD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x558BF10", Offset = "0x558AD10", VA = "0x18558BF10")]
				internal bool YLLDHWAKQHU()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class LIYECFHXWXE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public HLFMYWGLVZH GRQKPJZMZXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public LISXEYOANLV YMDDPWVYDWF;

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public LIYECFHXWXE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x558C230", Offset = "0x558B030", VA = "0x18558C230")]
				internal void YKVIQBSSNZT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class EWIXPHPBAJT
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
					public EWIXPHPBAJT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x3F4ABA0", Offset = "0x3F499A0", VA = "0x183F4ABA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> RXTQDLKSSDY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public BYYXKEXKPED BVSSRNMSPMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool FAOFVAQXNIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public NXDEFHNCTOS QXVXMUQZOQN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public ENFFXWRYOWP SQRXAUPCTAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string RLOGPBKPXDS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public EWIXPHPBAJT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x4A5A340", Offset = "0x4A59140", VA = "0x184A5A340")]
				internal int MJCNOPUBECR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x4A5A0E0", Offset = "0x4A58EE0", VA = "0x184A5A0E0")]
				internal void MIXGRJADURI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
				internal string MIRZUCGGLFZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x4A5A020", Offset = "0x4A58E20", VA = "0x184A5A020")]
				[AsyncStateMachine(typeof(XMXHVDDZHBA<>.EWIXPHPBAJT.<<CreatePortItemV2>b__3>d))]
				internal void MIMSWVMJBUQ(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public XMXHVDDZHBA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x50EFCD0", Offset = "0x50EEAD0", VA = "0x1850EFCD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x50F0080", Offset = "0x50EEE80", VA = "0x1850F0080", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public XMXHVDDZHBA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<TDADSARCMWU> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x53909C0", Offset = "0x538F7C0", VA = "0x1853909C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x5390D70", Offset = "0x538FB70", VA = "0x185390D70", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public XMXHVDDZHBA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x539E080", Offset = "0x539CE80", VA = "0x18539E080", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x539E630", Offset = "0x539D430", VA = "0x18539E630", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<TDADSARCMWU>, bool> TSQRSIFYSFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<TDADSARCMWU>, bool> ZBJHPGTFZKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<TDADSARCMWU>, bool> VPIULZKNIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<TDADSARCMWU>, bool> ZYUDXILOKOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<TDADSARCMWU>, bool> PHVSBEIWJJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<TDADSARCMWU>, bool> ELIAXPKQNHD;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool SBBMWCWKXLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool XNCMYVYTQXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool JSMWPEXRWOQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<DINEWLJZVXU>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x40905C0", Offset = "0x408F3C0", VA = "0x1840905C0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<TDADSARCMWU>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x4090830", Offset = "0x408F630", VA = "0x184090830", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<KSHTGNRFKHE>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x4090640", Offset = "0x408F440", VA = "0x184090640", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x40903F0", Offset = "0x408F1F0", VA = "0x1840903F0")]
			public XMXHVDDZHBA(SQESMBBMMXQ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "154")]
			protected virtual bool ECOVKBLCNFN(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "155")]
			protected virtual bool FQPQZDTPWYI(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "156")]
			protected virtual bool AOPFVSXSCXP(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "157")]
			protected virtual void UYSZLTLWDCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x408DD40", Offset = "0x408CB40", VA = "0x18408DD40", Slot = "149")]
			public override bool UTPUPVIFFKV(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x408D160", Offset = "0x408BF60", VA = "0x18408D160", Slot = "122")]
			[AsyncStateMachine(typeof(XMXHVDDZHBA<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> KBECSBQJIBS(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x408BB50", Offset = "0x408A950", VA = "0x18408BB50", Slot = "123")]
			[AsyncStateMachine(typeof(XMXHVDDZHBA<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, IGWAJAWUKJF>> BEJVPBITIPZ(Id32<TDADSARCMWU> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x408F820", Offset = "0x408E620", VA = "0x18408F820", Slot = "124")]
			public override void XMSGAUMCFSP(Id32<TDADSARCMWU> index, Id32<TDADSARCMWU> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x408BC60", Offset = "0x408AA60", VA = "0x18408BC60", Slot = "125")]
			public override IEnumerable<TWGQWHZWPAR> BSXGULCUBDO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x408DC40", Offset = "0x408CA40", VA = "0x18408DC40")]
			[AsyncStateMachine(typeof(XMXHVDDZHBA<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, IGWAJAWUKJF>> SZINKZITRTV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "158")]
			protected virtual bool GNPVQTTMHVM(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "159")]
			protected virtual bool JKJLOLBNNMM(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "160")]
			protected virtual bool OWLEBGDYUWN(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "161")]
			protected virtual bool FFNCMHAFHLT(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "162")]
			protected virtual bool VSVBWGDTLXD(Id32<TDADSARCMWU> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "163")]
			protected virtual bool QRTFHNUCRWG(Id32<TDADSARCMWU> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "164")]
			protected virtual bool MNTHAMRTYGM(Id32<TDADSARCMWU> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "165")]
			protected virtual bool CFIKYBUSYXP(Id32<TDADSARCMWU> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "166")]
			protected virtual bool DQVENYAWWBH(Id32<TDADSARCMWU> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "167")]
			protected virtual bool WLWDGITCJPK(Id32<TDADSARCMWU> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x408F590", Offset = "0x408E390", VA = "0x18408F590", Slot = "168")]
			protected virtual List<BYYXKEXKPED> WQLRHEWXKTM(Id32<TDADSARCMWU> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "169")]
			protected virtual void RJTJFGKXOGH(DWVMJQUITOW a, ZVLVZAXDPUU b, NXDEFHNCTOS c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x408F9D0", Offset = "0x408E7D0", VA = "0x18408F9D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x408DDE0", Offset = "0x408CBE0", VA = "0x18408DDE0")]
			private ZVLVZAXDPUU VEXBHPFNSKW(DWVMJQUITOW a, NXDEFHNCTOS b, Id32<TDADSARCMWU> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x408BEC0", Offset = "0x408ACC0", VA = "0x18408BEC0")]
			private List<HLFMYWGLVZH> HFDEYRTKBSX(DWVMJQUITOW a, NXDEFHNCTOS b, ZVLVZAXDPUU c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x408D280", Offset = "0x408C080", VA = "0x18408D280")]
			private List<HLFMYWGLVZH> LMNGGDLCOSH(DWVMJQUITOW a, NXDEFHNCTOS b, ENFFXWRYOWP c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x408CF70", Offset = "0x408BD70", VA = "0x18408CF70")]
			private BYYXKEXKPED JRSYWRGYSVV(List<BYYXKEXKPED> a, ENFFXWRYOWP b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4090390", Offset = "0x408F190", VA = "0x184090390")]
			[CompilerGenerated]
			private TWGQWHZWPAR XUAFDJCZJOP(FDTJOQJNBIL a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class SBNFXZTYMYJ : OAOZZKUFIDL<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public SBNFXZTYMYJ WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x2A9EB30", Offset = "0x2A9D930", VA = "0x182A9EB30")]
				internal int FUZIMOSKCKX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x2A9EAA0", Offset = "0x2A9D8A0", VA = "0x182A9EAA0")]
				internal Task<bool> FUUBPHYMSZO(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2A85CF0", Offset = "0x2A84AF0", VA = "0x182A85CF0")]
			public SBNFXZTYMYJ(SQESMBBMMXQ a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2A85B40", Offset = "0x2A84940", VA = "0x182A85B40", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class XWMMARWJHRT : GOYEQGFPMCJ<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public XWMMARWJHRT WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x2A7EC40", Offset = "0x2A7DA40", VA = "0x182A7EC40")]
				internal int EJIWEXPPLIG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x2A7ED70", Offset = "0x2A7DB70", VA = "0x182A7ED70")]
				internal Task<bool> EJODCEJMUTP(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E270", Offset = "0x2A9D070", VA = "0x182A9E270")]
			public XWMMARWJHRT(SQESMBBMMXQ a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E050", Offset = "0x2A9CE50", VA = "0x182A9E050", Slot = "151")]
			protected override void AKQXZFHDGDA(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class LRDMBSPEKVJ : OAOZZKUFIDL<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0xF449E0", Offset = "0xF437E0", VA = "0x180F449E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2A83E10", Offset = "0x2A82C10", VA = "0x182A83E10")]
			public LRDMBSPEKVJ(SQESMBBMMXQ a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class WPILTUNEUFN : OAOZZKUFIDL<JLEFDRVJKMA>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class URZEQUFXAGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public WPILTUNEUFN WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public DWVMJQUITOW DKEALQBNYOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> CQQZJIQKEEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> CQBEROISBWM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> CPVXUHOUSLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> CPGDCNHCQDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> CPLJZUAZZOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> CSBVQDZRSFY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> CSHCNKTPBRH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> JRCXKUEPKLN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> JQXQNNKSBAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> JRNLFHSKDIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> JRIEIAYMTWW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> JRXYZVGEWEX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> JRSSCOMHMTO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> JSIMUITZPBP;

				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public URZEQUFXAGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E650", Offset = "0x2A8D450", VA = "0x182A8E650")]
				internal bool FUZIMOSKCKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E5F0", Offset = "0x2A8D3F0", VA = "0x182A8E5F0")]
				internal void FUUBPHYMSZO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E6F0", Offset = "0x2A8D4F0", VA = "0x182A8E6F0")]
				internal bool FVUKBPTZOEH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E6A0", Offset = "0x2A8D4A0", VA = "0x182A8E6A0")]
				internal bool FVPDEJACESY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E740", Offset = "0x2A8D540", VA = "0x182A8E740")]
				internal void FWEXWDHUHAZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E7A0", Offset = "0x2A8D5A0", VA = "0x182A8E7A0")]
				internal bool FWKETKBRQMI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F140", Offset = "0x2A8DF40", VA = "0x182A8F140")]
				internal bool JHSTJHKLUXS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F190", Offset = "0x2A8DF90", VA = "0x182A8F190")]
				internal void JHYAGOEJEJB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F1F0", Offset = "0x2A8DFF0", VA = "0x182A8F1F0")]
				internal bool JINUYIMBGRC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F240", Offset = "0x2A8E040", VA = "0x182A8F240")]
				internal bool JITBVPFYQCL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F290", Offset = "0x2A8E090", VA = "0x182A8F290")]
				internal void JIYISVZVZNU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F2F0", Offset = "0x2A8E0F0", VA = "0x182A8F2F0")]
				internal bool JJODKQHOBVV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2A971B0", Offset = "0x2A95FB0", VA = "0x182A971B0")]
				internal bool XIGBRQZBOPA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2A97200", Offset = "0x2A96000", VA = "0x182A97200")]
				internal bool XILIOXSYYAJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2A97160", Offset = "0x2A95F60", VA = "0x182A97160")]
				internal bool XHVNXDLGVSI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2A97300", Offset = "0x2A96100", VA = "0x182A97300")]
				internal bool XKRGKUDVXVE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2A97350", Offset = "0x2A96150", VA = "0x182A97350")]
				internal bool XKWNIAXTHGN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D8E0", Offset = "0x2A8C6E0", VA = "0x182A8D8E0")]
				internal bool DJUJSCJTEEL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D890", Offset = "0x2A8C690", VA = "0x182A8D890")]
				internal bool DJPCUVPVUTC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D980", Offset = "0x2A8C780", VA = "0x182A8D980")]
				internal void DKEXMPXNXBD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2A961E0", Offset = "0x2A94FE0", VA = "0x182A961E0")]
				internal bool RKXMSGGBADU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2A96190", Offset = "0x2A94F90", VA = "0x182A96190")]
				internal bool RKSFUZMDQSL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2A96140", Offset = "0x2A94F40", VA = "0x182A96140")]
				internal bool RKMYXSSGHHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2A960F0", Offset = "0x2A94EF0", VA = "0x182A960F0")]
				internal bool RKCLDFELOKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2A960A0", Offset = "0x2A94EA0", VA = "0x182A960A0")]
				internal bool RJXEFYKOEZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D930", Offset = "0x2A8C730", VA = "0x182A8D930")]
				internal bool DJZQPJDQNPU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DA40", Offset = "0x2A8C840", VA = "0x182A8DA40")]
				internal bool DKPLHDLIPXV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D9E0", Offset = "0x2A8C7E0", VA = "0x182A8D9E0")]
				internal void DKKEJWRLGMM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DAE0", Offset = "0x2A8C8E0", VA = "0x182A8DAE0")]
				internal bool DKZZBQZDIUN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DA90", Offset = "0x2A8C890", VA = "0x182A8DA90")]
				internal bool DKUSEKFFZJE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D830", Offset = "0x2A8C630", VA = "0x182A8D830")]
				internal void DIEGOAGOGRR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D7E0", Offset = "0x2A8C5E0", VA = "0x182A8D7E0")]
				internal bool DHYZQTMQXGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2A97250", Offset = "0x2A96050", VA = "0x182A97250")]
				internal bool XJBDGSARAIK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2A972A0", Offset = "0x2A960A0", VA = "0x182A972A0")]
				internal void XJGKDYUOJTT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F7F0", Offset = "0x2A8E5F0", VA = "0x182A8F7F0")]
				internal List<HLFMYWGLVZH> LVOYUOKGGWG(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2A96050", Offset = "0x2A94E50", VA = "0x182A96050")]
				internal bool RJRXIRQQVNS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2A96000", Offset = "0x2A94E00", VA = "0x182A96000")]
				internal int RJMQLKWTMCJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2A95F70", Offset = "0x2A94D70", VA = "0x182A95F70")]
				internal Task<bool> RJHJOECWCRA(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F510", Offset = "0x2A8E310", VA = "0x182A8F510")]
				internal bool KKLOQURVTWU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F560", Offset = "0x2A8E360", VA = "0x182A8F560")]
				internal bool KKQVOBLTDID()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F5B0", Offset = "0x2A8E3B0", VA = "0x182A8F5B0")]
				internal bool KKWCLIFQMTM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F600", Offset = "0x2A8E400", VA = "0x182A8F600")]
				internal int KLBJIOZNWEV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F390", Offset = "0x2A8E190", VA = "0x182A8F390")]
				internal Task<bool> KJQNBTQGIDK(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F420", Offset = "0x2A8E220", VA = "0x182A8F420")]
				internal bool KJVTZAKDROT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F470", Offset = "0x2A8E270", VA = "0x182A8F470")]
				internal bool KKBAWHEBBAC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F4C0", Offset = "0x2A8E2C0", VA = "0x182A8F4C0")]
				internal bool KKGHTNXYKLL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F340", Offset = "0x2A8E140", VA = "0x182A8F340")]
				internal bool KJASJZIOFVJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E210", Offset = "0x2A8D010", VA = "0x182A8E210")]
				internal bool FFYQWPDJZAT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EE90", Offset = "0x2A8DC90", VA = "0x182A8EE90")]
				internal string GZMUGBZOHVC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EF30", Offset = "0x2A8DD30", VA = "0x182A8EF30")]
				internal void HACOXWHGKDD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EFA0", Offset = "0x2A8DDA0", VA = "0x182A8EFA0")]
				internal int HAHVVDBDTOM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F040", Offset = "0x2A8DE40", VA = "0x182A8F040")]
				internal void HAXQMXIVVWN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EFF0", Offset = "0x2A8DDF0", VA = "0x182A8EFF0")]
				internal bool HASJPQOYMLE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F0F0", Offset = "0x2A8DEF0", VA = "0x182A8F0F0")]
				internal bool HBIEHKWQOTF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F0A0", Offset = "0x2A8DEA0", VA = "0x182A8F0A0")]
				internal bool HBCXKECTFHW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D3D0", Offset = "0x2A8C1D0", VA = "0x182A8D3D0")]
				internal float AFNIUYYCRNE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D420", Offset = "0x2A8C220", VA = "0x182A8D420")]
				internal void AFSPSFSAAYN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D330", Offset = "0x2A8C130", VA = "0x182A8D330")]
				internal bool AFCVALKHYQM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D380", Offset = "0x2A8C180", VA = "0x182A8D380")]
				internal bool AFIBXSEFIBV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D290", Offset = "0x2A8C090", VA = "0x182A8D290")]
				internal bool AESHFXWNFTU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E2B0", Offset = "0x2A8D0B0", VA = "0x182A8E2B0")]
				internal bool FGJERCRERXL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E260", Offset = "0x2A8D060", VA = "0x182A8E260")]
				internal bool FGDXTVXHIMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E120", Offset = "0x2A8CF20", VA = "0x182A8E120")]
				internal bool FFDPHOBUNHJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DD20", Offset = "0x2A8CB20", VA = "0x182A8DD20")]
				internal void FEYIKHHXDWA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D2E0", Offset = "0x2A8C0E0", VA = "0x182A8D2E0")]
				internal string AEXODEQKPFD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D220", Offset = "0x2A8C020", VA = "0x182A8D220")]
				internal void AEHTLKISMXC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E1C0", Offset = "0x2A8CFC0", VA = "0x182A8E1C0")]
				internal bool FFODCBPPGEB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E170", Offset = "0x2A8CF70", VA = "0x182A8E170")]
				internal bool FFIWEUVRWSS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E5A0", Offset = "0x2A8D3A0", VA = "0x182A8E5A0")]
				internal bool FHOUARGOWNN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E300", Offset = "0x2A8D100", VA = "0x182A8E300")]
				internal void FHJNDKMRNCE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2A976E0", Offset = "0x2A964E0", VA = "0x182A976E0")]
				internal bool YFHLXWVHJIK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2A97730", Offset = "0x2A96530", VA = "0x182A97730")]
				internal bool YFMSVDPESTT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2A97640", Offset = "0x2A96440", VA = "0x182A97640")]
				internal bool YEWYDJHMQLS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2A97690", Offset = "0x2A96490", VA = "0x182A97690")]
				internal bool YFCFAQBJZXB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2A97820", Offset = "0x2A96620", VA = "0x182A97820")]
				internal void YGCNMXWWVBU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2A97880", Offset = "0x2A96680", VA = "0x182A97880")]
				internal bool YGHUKEQUEND()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2A97780", Offset = "0x2A96580", VA = "0x182A97780")]
				internal bool YFRZSKJCCFC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2A977D0", Offset = "0x2A965D0", VA = "0x182A977D0")]
				internal bool YFXGPRCZLQL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2A978D0", Offset = "0x2A966D0", VA = "0x182A978D0")]
				internal bool YGXPBYYMGVE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2A97920", Offset = "0x2A96720", VA = "0x182A97920")]
				internal void YHCVZFSJQGN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2A963C0", Offset = "0x2A951C0", VA = "0x182A963C0")]
				internal bool SHJCGRUOSPD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2A96370", Offset = "0x2A95170", VA = "0x182A96370")]
				internal bool SHDVJLARJDU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2A96320", Offset = "0x2A95120", VA = "0x182A96320")]
				internal bool SGYOMEGTZSL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2A962D0", Offset = "0x2A950D0", VA = "0x182A962D0")]
				internal bool SGTHOXMWQHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2A964A0", Offset = "0x2A952A0", VA = "0x182A964A0")]
				internal object SHTQBFIJLLV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2A96410", Offset = "0x2A95210", VA = "0x182A96410")]
				internal void SHOJDYOMCAM(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2A96280", Offset = "0x2A95080", VA = "0x182A96280")]
				internal bool SFSZCPRJVCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2A96230", Offset = "0x2A95030", VA = "0x182A96230")]
				internal bool SFNSFIXMLRA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F6A0", Offset = "0x2A8E4A0", VA = "0x182A8F6A0")]
				internal int LGXEFGGJMID()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F6F0", Offset = "0x2A8E4F0", VA = "0x182A8F6F0")]
				internal void LHCLCNAGVTM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F750", Offset = "0x2A8E550", VA = "0x182A8F750")]
				internal bool LHSFUHHYYBN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F7A0", Offset = "0x2A8E5A0", VA = "0x182A8F7A0")]
				internal bool LHXMROBWHMW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F650", Offset = "0x2A8E450", VA = "0x182A8F650")]
				internal int LFHBBEDEOVJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2A973A0", Offset = "0x2A961A0", VA = "0x182A973A0")]
				internal void XWXTBRERGDS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2A97400", Offset = "0x2A96200", VA = "0x182A97400")]
				internal bool XXCZYXYOPPB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2A97450", Offset = "0x2A96250", VA = "0x182A97450")]
				internal bool XXIGWESLZAK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2A974A0", Offset = "0x2A962A0", VA = "0x182A974A0")]
				internal bool XXNNTLMJILT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2A974F0", Offset = "0x2A962F0", VA = "0x182A974F0")]
				internal int XYDILFUBKTU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2A97540", Offset = "0x2A96340", VA = "0x182A97540")]
				internal void XYIPIMNYUFD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2A975A0", Offset = "0x2A963A0", VA = "0x182A975A0")]
				internal bool XYNWFTHWDQM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2A975F0", Offset = "0x2A963F0", VA = "0x182A975F0")]
				internal bool XYTDDABTNBV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DB30", Offset = "0x2A8C930", VA = "0x182A8DB30")]
				internal bool EXOYAJMTVWB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DC10", Offset = "0x2A8CA10", VA = "0x182A8DC10")]
				internal object EYESSDULYEC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DB80", Offset = "0x2A8C980", VA = "0x182A8DB80")]
				internal void EXZLUXAOOST(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DCD0", Offset = "0x2A8CAD0", VA = "0x182A8DCD0")]
				internal bool EZFBELPYTIV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2A8DC80", Offset = "0x2A8CA80", VA = "0x182A8DC80")]
				internal bool EYZUHEWBJXM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2A956E0", Offset = "0x2A944E0", VA = "0x182A956E0")]
				internal object? LYGCZBUWLOK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2A95750", Offset = "0x2A94550", VA = "0x182A95750")]
				internal void LYLJWIOTUZT(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2A95640", Offset = "0x2A94440", VA = "0x182A95640")]
				internal bool LXLBKATGZVA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2A95690", Offset = "0x2A94490", VA = "0x182A95690")]
				internal int LXQIHHNEJGJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2A95590", Offset = "0x2A94390", VA = "0x182A95590")]
				internal void LXANPNFMGYI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2A955F0", Offset = "0x2A943F0", VA = "0x182A955F0")]
				internal bool LXFUMTZJQJR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2A957E0", Offset = "0x2A945E0", VA = "0x182A957E0")]
				internal bool LZWGDDYBJBE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2A95830", Offset = "0x2A94630", VA = "0x182A95830")]
				internal bool MABNAKRYSMN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2A96610", Offset = "0x2A95410", VA = "0x182A96610")]
				internal int SYXHXUCZBGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2A965B0", Offset = "0x2A953B0", VA = "0x182A965B0")]
				internal void SYSBANJBRVK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2A966B0", Offset = "0x2A954B0", VA = "0x182A966B0")]
				internal bool SZHVSHQTUDL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2A96660", Offset = "0x2A95460", VA = "0x182A96660")]
				internal bool SZCOVAWWKSC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2A96750", Offset = "0x2A95550", VA = "0x182A96750")]
				internal bool SZSJMVEONAD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2A96700", Offset = "0x2A95500", VA = "0x182A96700")]
				internal float SZNCPOKRDOU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2A967F0", Offset = "0x2A955F0", VA = "0x182A967F0")]
				internal void TACXHISJFWV(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2A967A0", Offset = "0x2A955A0", VA = "0x182A967A0")]
				internal bool SZXQKBYLWLM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2A96560", Offset = "0x2A95360", VA = "0x182A96560")]
				internal bool SXHETRZUDTZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2A96510", Offset = "0x2A95310", VA = "0x182A96510")]
				internal bool SXBXWLFWUIQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2A97B30", Offset = "0x2A96930", VA = "0x182A97B30")]
				internal float YZQOJEMBFCU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2A97B80", Offset = "0x2A96980", VA = "0x182A97B80")]
				internal void YZVVGLFYOOD(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2A97BE0", Offset = "0x2A969E0", VA = "0x182A97BE0")]
				internal bool ZABCDRZVXZM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2A97A20", Offset = "0x2A96820", VA = "0x182A97A20")]
				internal bool YZATRKEJCUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2A97A70", Offset = "0x2A96870", VA = "0x182A97A70")]
				internal string YZGAOQYGMGC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2A97AC0", Offset = "0x2A968C0", VA = "0x182A97AC0")]
				internal void YZLHLXSDVRL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2A97980", Offset = "0x2A96780", VA = "0x182A97980")]
				internal bool YYALFCIWHQA(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2A979D0", Offset = "0x2A967D0", VA = "0x182A979D0")]
				internal bool YYFSCJCTRBJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EB00", Offset = "0x2A8D900", VA = "0x182A8EB00")]
				internal bool GAHTHWUDUVD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EAB0", Offset = "0x2A8D8B0", VA = "0x182A8EAB0")]
				internal bool GACMKQAGLJU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EA60", Offset = "0x2A8D860", VA = "0x182A8EA60")]
				internal string FZXFNJGJBYL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E9F0", Offset = "0x2A8D7F0", VA = "0x182A8E9F0")]
				internal void FZRYQCMLSNC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E9A0", Offset = "0x2A8D7A0", VA = "0x182A8E9A0")]
				internal bool FZMRSVSOJBT(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E950", Offset = "0x2A8D750", VA = "0x182A8E950")]
				internal bool FZHKVOYQZQK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E900", Offset = "0x2A8D700", VA = "0x182A8E900")]
				internal bool FZCDYIETQFB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E8B0", Offset = "0x2A8D6B0", VA = "0x182A8E8B0")]
				internal bool FYWXBBKWGTS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E860", Offset = "0x2A8D660", VA = "0x182A8E860")]
				internal string FYRQDUQYXIJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E7F0", Offset = "0x2A8D5F0", VA = "0x182A8E7F0")]
				internal void FYMJGNXBNXA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2A95920", Offset = "0x2A94720", VA = "0x182A95920")]
				internal bool MUMLQGPMUOK(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2A95970", Offset = "0x2A94770", VA = "0x182A95970")]
				internal bool MURSNNJKDZT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2A95880", Offset = "0x2A94680", VA = "0x182A95880")]
				internal bool MUBXVTBSBRS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2A958D0", Offset = "0x2A946D0", VA = "0x182A958D0")]
				internal bool MUHESZVPLDB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2A95A60", Offset = "0x2A94860", VA = "0x182A95A60")]
				internal string MVHNFHRCGHU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2A95AB0", Offset = "0x2A948B0", VA = "0x182A95AB0")]
				internal void MVMUCOKZPTD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2A959C0", Offset = "0x2A947C0", VA = "0x182A959C0")]
				internal bool MUWZKUDHNLC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2A95A10", Offset = "0x2A94810", VA = "0x182A95A10")]
				internal bool MVCGIAXEWWL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2A95B20", Offset = "0x2A94920", VA = "0x182A95B20")]
				internal bool MWCOUISRSBE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2A95B70", Offset = "0x2A94970", VA = "0x182A95B70")]
				internal bool MWHVRPMPBMN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2A96A20", Offset = "0x2A95820", VA = "0x182A96A20")]
				internal string TVDQOYXPKGT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2A969B0", Offset = "0x2A957B0", VA = "0x182A969B0")]
				internal void TUYJRSDSAVK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2A96AC0", Offset = "0x2A958C0", VA = "0x182A96AC0")]
				internal bool TVOEJMLKDDL(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2A96A70", Offset = "0x2A95870", VA = "0x182A96A70")]
				internal bool TVIXMFRMTSC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2A968A0", Offset = "0x2A956A0", VA = "0x182A968A0")]
				internal bool TUIOZXVZYNJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2A96850", Offset = "0x2A95650", VA = "0x182A96850")]
				internal bool TUDICRCCPCA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2A96960", Offset = "0x2A95760", VA = "0x182A96960")]
				internal string TUTCULJURKB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2A968F0", Offset = "0x2A956F0", VA = "0x182A968F0")]
				internal void TUNVXEPXHYS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2A96B60", Offset = "0x2A95960", VA = "0x182A96B60")]
				internal bool TWTTTBAUHTN(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2A96B10", Offset = "0x2A95910", VA = "0x182A96B10")]
				internal bool TWOMVUGWYIE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D540", Offset = "0x2A8C340", VA = "0x182A8D540")]
				internal bool AVUVNRFRZZC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D590", Offset = "0x2A8C390", VA = "0x182A8D590")]
				internal bool AWACKXZPJKL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D5E0", Offset = "0x2A8C3E0", VA = "0x182A8D5E0")]
				internal string AWFJIETMSVU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D630", Offset = "0x2A8C430", VA = "0x182A8D630")]
				internal void AWKQFLNKCHD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D6A0", Offset = "0x2A8C4A0", VA = "0x182A8D6A0")]
				internal bool AWPXCSHHLSM(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D6F0", Offset = "0x2A8C4F0", VA = "0x182A8D6F0")]
				internal bool AWVDZZBEVDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D740", Offset = "0x2A8C540", VA = "0x182A8D740")]
				internal bool AXAKXFVCEPE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D790", Offset = "0x2A8C590", VA = "0x182A8D790")]
				internal bool AXFRUMOZOAN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D480", Offset = "0x2A8C280", VA = "0x182A8D480")]
				internal string AUESJPCNCMI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2A8D4D0", Offset = "0x2A8C2D0", VA = "0x182A8D4D0")]
				internal void AUJZGVWKLXR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2A8ECE0", Offset = "0x2A8DAE0", VA = "0x182A8ECE0")]
				internal bool GWOBZBOUDVD(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EC90", Offset = "0x2A8DA90", VA = "0x182A8EC90")]
				internal bool GWIVBUUWUJU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EC40", Offset = "0x2A8DA40", VA = "0x182A8EC40")]
				internal bool GWDOEOAZKYL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EBF0", Offset = "0x2A8D9F0", VA = "0x182A8EBF0")]
				internal bool GVYHHHHCBNC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EE40", Offset = "0x2A8DC40", VA = "0x182A8EE40")]
				internal string GXJDOCQJPON()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EDD0", Offset = "0x2A8DBD0", VA = "0x182A8EDD0")]
				internal void GXDWQVWMGDE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2A8ED80", Offset = "0x2A8DB80", VA = "0x182A8ED80")]
				internal bool GWYPTPCOWRV(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2A8ED30", Offset = "0x2A8DB30", VA = "0x182A8ED30")]
				internal bool GWTIWIIRNGM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EBA0", Offset = "0x2A8D9A0", VA = "0x182A8EBA0")]
				internal bool GUXYUZLPGIJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EB50", Offset = "0x2A8D950", VA = "0x182A8EB50")]
				internal bool GUSRXSRRWXA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2A96D10", Offset = "0x2A95B10", VA = "0x182A96D10")]
				internal string UEUCJOPANRD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2A96CA0", Offset = "0x2A95AA0", VA = "0x182A96CA0")]
				internal void UEOVMHVDEFU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2A96C50", Offset = "0x2A95A50", VA = "0x182A96C50")]
				internal bool UEEHRUHILJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2A96E70", Offset = "0x2A95C70", VA = "0x182A96E70")]
				internal bool UFPDYPQPZKN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2A96E20", Offset = "0x2A95C20", VA = "0x182A96E20")]
				internal bool UFJXBIWSPZE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2A96DD0", Offset = "0x2A95BD0", VA = "0x182A96DD0")]
				internal string UFEQECCVGNV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2A96D60", Offset = "0x2A95B60", VA = "0x182A96D60")]
				internal void UEZJGVIXXCM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2A96C00", Offset = "0x2A95A00", VA = "0x182A96C00")]
				internal bool UDDZFMLVQEJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2A96BB0", Offset = "0x2A959B0", VA = "0x182A96BB0")]
				internal bool UCYSIFRYGTA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2A95C10", Offset = "0x2A94A10", VA = "0x182A95C10")]
				internal bool NECXKWGXXYU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2A95C60", Offset = "0x2A94A60", VA = "0x182A95C60")]
				internal string NEIEIDAVHKD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2A95CB0", Offset = "0x2A94AB0", VA = "0x182A95CB0")]
				internal void NENLFJUSQVM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2A95D20", Offset = "0x2A94B20", VA = "0x182A95D20")]
				internal bool NESSCQOQAGV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2A95D70", Offset = "0x2A94B70", VA = "0x182A95D70")]
				internal bool NEXYZXINJSE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2A95DC0", Offset = "0x2A94BC0", VA = "0x182A95DC0")]
				internal bool NFDFXECKTDN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2A95E10", Offset = "0x2A94C10", VA = "0x182A95E10")]
				internal string NFIMUKWICOW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2A95E60", Offset = "0x2A94C60", VA = "0x182A95E60")]
				internal void NFNTRRQFMAF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2A95BC0", Offset = "0x2A949C0", VA = "0x182A95BC0")]
				internal bool NCSBEAXQJXJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2A8EEE0", Offset = "0x2A8DCE0", VA = "0x182A8EEE0")]
				internal bool GZSBDITLRGL(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2A97060", Offset = "0x2A95E60", VA = "0x182A97060")]
				internal float VAPXGFVWDUL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2A97000", Offset = "0x2A95E00", VA = "0x182A97000")]
				internal void VAKQIZBYUJC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2A96FB0", Offset = "0x2A95DB0", VA = "0x182A96FB0")]
				internal bool VAFJLSIBKXT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2A96F60", Offset = "0x2A95D60", VA = "0x182A96F60")]
				internal bool VAACOLOEBMK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2A96F10", Offset = "0x2A95D10", VA = "0x182A96F10")]
				internal bool UZUVREUGSBB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2A96EC0", Offset = "0x2A95CC0", VA = "0x182A96EC0")]
				internal int UZPOTYAJIPS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2A97100", Offset = "0x2A95F00", VA = "0x182A97100")]
				internal void VCQOEVMVUDX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2A970B0", Offset = "0x2A95EB0", VA = "0x182A970B0")]
				internal bool VCLHHOSYKSO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2A95ED0", Offset = "0x2A94CD0", VA = "0x182A95ED0")]
				internal bool OAJGCBBOGYU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2A95F20", Offset = "0x2A94D20", VA = "0x182A95F20")]
				internal bool OAOMZHVLQKD()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class URTXTNLZQVG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string ZDZQPCGBWRB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public URZEQUFXAGP YLNIYCOGBOE;

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public URTXTNLZQVG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8670", Offset = "0x2AB7470", VA = "0x182AB8670")]
				internal void FFTJZIJMPPK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class USJSLHTRTDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] PFREMDCQYIE;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public USJSLHTRTDH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2AB94F0", Offset = "0x2AB82F0", VA = "0x182AB94F0")]
				internal bool VAVEDMPTNFU(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers KWMNRUOXVKB;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2A9DEF0", Offset = "0x2A9CCF0", VA = "0x182A9DEF0")]
			public WPILTUNEUFN(SQESMBBMMXQ a, JLEFDRVJKMA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2A9C370", Offset = "0x2A9B170", VA = "0x182A9C370", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class DIGYFUZNPLW : OAOZZKUFIDL<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x2AA49B0", Offset = "0x2AA37B0", VA = "0x182AA49B0")]
			public DIGYFUZNPLW(SQESMBBMMXQ a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4700", Offset = "0x2AA3500", VA = "0x182AA4700", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4600", Offset = "0x2AA3400", VA = "0x182AA4600")]
			private static string TNFOBYXROQY(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4210", Offset = "0x2AA3010", VA = "0x182AA4210")]
			[CompilerGenerated]
			private object? MEGPLVYLTVV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4100", Offset = "0x2AA2F00", VA = "0x182AA4100")]
			[CompilerGenerated]
			private void MEBIOPEOKKM(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4350", Offset = "0x2AA3150", VA = "0x182AA4350")]
			[CompilerGenerated]
			private string MERDGJMGMSN(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2AA42B0", Offset = "0x2AA30B0", VA = "0x182AA42B0")]
			[CompilerGenerated]
			private IReadOnlyList<object> MELWJCSJDHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2AA45A0", Offset = "0x2AA33A0", VA = "0x182AA45A0")]
			[CompilerGenerated]
			private string? MFBRAXABFPF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4560", Offset = "0x2AA3360", VA = "0x182AA4560")]
			[CompilerGenerated]
			private bool MEWKDQGDWDW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class BTQEEPBWBSG : OAOZZKUFIDL<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
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
					public ZLLAWYXLGFG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60002FE")]
					[Cpp2IlInjected.Address(RVA = "0x2AB6250", Offset = "0x2AB5050", VA = "0x182AB6250", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60002FF")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public BTQEEPBWBSG WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB290", Offset = "0x2ABA090", VA = "0x182ABB290")]
				internal string FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAEE0", Offset = "0x2AB9CE0", VA = "0x182ABAEE0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void FUUBPHYMSZO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB800", Offset = "0x2ABA600", VA = "0x182ABB800")]
				internal int FVJWHCGEVHP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB380", Offset = "0x2ABA180", VA = "0x182ABB380")]
				internal void FVEPJVMHLWG(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA18E0", Offset = "0x2AA06E0", VA = "0x182AA18E0")]
			public BTQEEPBWBSG(SQESMBBMMXQ a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AA15B0", Offset = "0x2AA03B0", VA = "0x182AA15B0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class RAGHVRXLKGL : OAOZZKUFIDL<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class EERSQRFLGMR
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
					public EERSQRFLGMR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000313")]
					[Cpp2IlInjected.Address(RVA = "0x2AB6560", Offset = "0x2AB5360", VA = "0x182AB6560", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000314")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public EERSQRFLGMR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2AB6B40", Offset = "0x2AB5940", VA = "0x182AB6B40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public RAGHVRXLKGL WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public EERSQRFLGMR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6550", Offset = "0x2AA5350", VA = "0x182AA6550")]
				internal string FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6480", Offset = "0x2AA5280", VA = "0x182AA6480")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void FUUBPHYMSZO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6630", Offset = "0x2AA5430", VA = "0x182AA6630")]
				internal int FVJWHCGEVHP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2AA65A0", Offset = "0x2AA53A0", VA = "0x182AA65A0")]
				internal Task<bool> FVEPJVMHLWG(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6750", Offset = "0x2AA5550", VA = "0x182AA6750")]
				internal string FVUKBPTZOEH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6680", Offset = "0x2AA5480", VA = "0x182AA6680")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void FVPDEJACESY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6830", Offset = "0x2AA5630", VA = "0x182AA6830")]
				internal bool FWEXWDHUHAZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2AA67A0", Offset = "0x2AA55A0", VA = "0x182AA67A0")]
				internal void FVZQYWNWXPQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6910", Offset = "0x2AA5710", VA = "0x182AA6910")]
				internal bool FWPLQQVOZXR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6880", Offset = "0x2AA5680", VA = "0x182AA6880")]
				internal void FWKETKBRQMI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6960", Offset = "0x2AA5760", VA = "0x182AA6960")]
				internal float JHSTJHKLUXS()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA69B0", Offset = "0x2AA57B0", VA = "0x182AA69B0")]
				internal void JHYAGOEJEJB(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6A40", Offset = "0x2AA5840", VA = "0x182AA6A40")]
				internal int JIDHDUYGNUK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6AA0", Offset = "0x2AA58A0", VA = "0x182AA6AA0")]
				internal void JIIOBBSDXFT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6B40", Offset = "0x2AA5940", VA = "0x182AA6B40")]
				internal bool JINUYIMBGRC()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2AAACB0", Offset = "0x2AA9AB0", VA = "0x182AAACB0")]
			public RAGHVRXLKGL(SQESMBBMMXQ a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2AAA350", Offset = "0x2AA9150", VA = "0x182AAA350", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class GCLIOFTDYAS : OAOZZKUFIDL<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public GCLIOFTDYAS WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB2E0", Offset = "0x2ABA0E0", VA = "0x182ABB2E0")]
				internal Dictionary<string, EnumChoiceData> FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB0E0", Offset = "0x2AB9EE0", VA = "0x182ABB0E0")]
				internal int FUUBPHYMSZO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB6D0", Offset = "0x2ABA4D0", VA = "0x182ABB6D0")]
				internal void FVJWHCGEVHP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB4B0", Offset = "0x2ABA2B0", VA = "0x182ABB4B0")]
				internal bool FVEPJVMHLWG()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2AA78B0", Offset = "0x2AA66B0", VA = "0x182AA78B0")]
			public GCLIOFTDYAS(SQESMBBMMXQ a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7600", Offset = "0x2AA6400", VA = "0x182AA7600", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class LJZELOYHDPV : OAOZZKUFIDL<HUMJUGGLWFW>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public LJZELOYHDPV WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB180", Offset = "0x2AB9F80", VA = "0x182ABB180")]
				internal void FUZIMOSKCKX()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8820", Offset = "0x2AA7620", VA = "0x182AA8820")]
			public LJZELOYHDPV(SQESMBBMMXQ a, HUMJUGGLWFW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2AA86A0", Offset = "0x2AA74A0", VA = "0x182AA86A0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class USTNNZJEWIN<a> : XMXHVDDZHBA<a> where a : notnull, AZSSVRZWVVF
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override JZUQHNZNXWS? RKTOOWAKTVF
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x6423550", Offset = "0x6422350", VA = "0x186423550", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x64235B0", Offset = "0x64223B0", VA = "0x1864235B0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xF2E120", Offset = "0xF2CF20", VA = "0x180F2E120", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x6423590", Offset = "0x6422390", VA = "0x186423590")]
			public USTNNZJEWIN(SQESMBBMMXQ a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class OCYKSHSZWHL : USTNNZJEWIN<XTCGAQPRURU>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class URZEQUFXAGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public OCYKSHSZWHL WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public URZEQUFXAGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9310", Offset = "0x2AB8110", VA = "0x182AB9310")]
				internal object FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB91F0", Offset = "0x2AB7FF0", VA = "0x182AB91F0")]
				internal void FUUBPHYMSZO(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9370", Offset = "0x2AB8170", VA = "0x182AB9370")]
				internal void FVJWHCGEVHP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? UUADTWOKAAZ;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9C60", Offset = "0x2AA8A60", VA = "0x182AA9C60")]
			public OCYKSHSZWHL(SQESMBBMMXQ a, XTCGAQPRURU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x2AA96F0", Offset = "0x2AA84F0", VA = "0x182AA96F0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class HFUBYJHJXFS : OAOZZKUFIDL<VFGUQFVMBKB>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public HFUBYJHJXFS WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<OUFJYXOYDZY>> XIFIDBDYXFG;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x2AA1EA0", Offset = "0x2AA0CA0", VA = "0x182AA1EA0")]
				internal int FUUBPHYMSZO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2CA0", Offset = "0x2AA1AA0", VA = "0x182AA2CA0")]
				internal void FVJWHCGEVHP(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class CFCMCYVGPQJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<OUFJYXOYDZY> RBDPJXMAXCG;

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CFCMCYVGPQJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2AA30C0", Offset = "0x2AA1EC0", VA = "0x182AA30C0")]
				internal bool FVUKBPTZOEH(Id32<OUFJYXOYDZY> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7F00", Offset = "0x2AA6D00", VA = "0x182AA7F00")]
			public HFUBYJHJXFS(SQESMBBMMXQ a, VFGUQFVMBKB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2AA79F0", Offset = "0x2AA67F0", VA = "0x182AA79F0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class GTWZELRZAAQ : OAOZZKUFIDL<LPUDLTYKIUB>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xE262A0", Offset = "0xE250A0", VA = "0x180E262A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7980", Offset = "0x2AA6780", VA = "0x182AA7980")]
			public GTWZELRZAAQ(SQESMBBMMXQ a, LPUDLTYKIUB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class BPTXIMMNIHF : OAOZZKUFIDL<VFRMUKGKCKA>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0xBCD920", Offset = "0xBCC720", VA = "0x180BCD920", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1540", Offset = "0x2AA0340", VA = "0x182AA1540")]
			public BPTXIMMNIHF(SQESMBBMMXQ a, VFRMUKGKCKA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "134")]
			protected override bool MTUJGLUJXEL(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class KBYLOCVDNKT : OAOZZKUFIDL<KQYTRAURJQA>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0x2AA85E0", Offset = "0x2AA73E0", VA = "0x182AA85E0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8570", Offset = "0x2AA7370", VA = "0x182AA8570")]
			public KBYLOCVDNKT(SQESMBBMMXQ a, KQYTRAURJQA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class OAYQXSGUVOX : OAOZZKUFIDL<NFBRETHJKTC>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x2AA96A0", Offset = "0x2AA84A0", VA = "0x182AA96A0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9630", Offset = "0x2AA8430", VA = "0x182AA9630")]
			public OAYQXSGUVOX(SQESMBBMMXQ a, NFBRETHJKTC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class ONETTXCCKLE : GOYEQGFPMCJ<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public ONETTXCCKLE WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA1CE0", Offset = "0x2AA0AE0", VA = "0x182AA1CE0")]
				internal float EJIWEXPPLIG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA1D60", Offset = "0x2AA0B60", VA = "0x182AA1D60")]
				internal void EJODCEJMUTP(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9FA0", Offset = "0x2AA8DA0", VA = "0x182AA9FA0")]
			public ONETTXCCKLE(SQESMBBMMXQ a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9D30", Offset = "0x2AA8B30", VA = "0x182AA9D30", Slot = "151")]
			protected override void AKQXZFHDGDA(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class LQVEBOCFZRZ : OAOZZKUFIDL<NJXTPWFIIQY>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8890", Offset = "0x2AA7690", VA = "0x182AA8890")]
			public LQVEBOCFZRZ(SQESMBBMMXQ a, NJXTPWFIIQY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class KXLDXIFBCHR : OAOZZKUFIDL<MIGAWCCCVYM>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000353")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8630", Offset = "0x2AA7430", VA = "0x182AA8630")]
			public KXLDXIFBCHR(SQESMBBMMXQ a, MIGAWCCCVYM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class CMOSMXPJKKC : OAOZZKUFIDL<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public CMOSMXPJKKC WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2780", Offset = "0x2AA1580", VA = "0x182AA2780")]
				internal bool FUZIMOSKCKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0x2AA25B0", Offset = "0x2AA13B0", VA = "0x182AA25B0")]
				internal void FUUBPHYMSZO(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3F70", Offset = "0x2AA2D70", VA = "0x182AA3F70")]
			public CMOSMXPJKKC(SQESMBBMMXQ a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3CE0", Offset = "0x2AA2AE0", VA = "0x182AA3CE0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class NFEYXSHACQW : OAOZZKUFIDL<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public NFEYXSHACQW WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> CBQIOSOCRXF;

				[Cpp2IlInjected.Token(Token = "0x600035D")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x2AA27D0", Offset = "0x2AA15D0", VA = "0x182AA27D0")]
				internal object? FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2EC0", Offset = "0x2AA1CC0", VA = "0x182AA2EC0")]
				internal bool FVZQYWNWXPQ(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2360", Offset = "0x2AA1160", VA = "0x182AA2360")]
				internal void FUUBPHYMSZO(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2AA29F0", Offset = "0x2AA17F0", VA = "0x182AA29F0")]
				internal string FVJWHCGEVHP(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2AA29A0", Offset = "0x2AA17A0", VA = "0x182AA29A0")]
				internal IReadOnlyList<object> FVEPJVMHLWG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2E50", Offset = "0x2AA1C50", VA = "0x182AA2E50")]
				internal bool FVUKBPTZOEH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2E00", Offset = "0x2AA1C00", VA = "0x182AA2E00")]
				internal bool FVPDEJACESY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2F40", Offset = "0x2AA1D40", VA = "0x182AA2F40")]
				internal void FWEXWDHUHAZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9090", Offset = "0x2AA7E90", VA = "0x182AA9090")]
			public NFEYXSHACQW(SQESMBBMMXQ a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA89A0", Offset = "0x2AA77A0", VA = "0x182AA89A0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class AHYDVBBFCKY : OAOZZKUFIDL<LRUFRDRZELX>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class EERSQRFLGMR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int ULVOFDBGWWO;

				[Cpp2IlInjected.Token(Token = "0x600036B")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public EERSQRFLGMR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036C")]
				[Cpp2IlInjected.Address(RVA = "0x2AA6440", Offset = "0x2AA5240", VA = "0x182AA6440")]
				internal bool DSMQMEIZCGG(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class QFVEKDSMASK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public AHYDVBBFCKY WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> DNDITAIIHBG;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public QFVEKDSMASK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2AAA200", Offset = "0x2AA9000", VA = "0x182AAA200")]
				internal int FUZIMOSKCKX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0x2AAA0E0", Offset = "0x2AA8EE0", VA = "0x182AAA0E0")]
				internal void FUUBPHYMSZO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2AAA2A0", Offset = "0x2AA90A0", VA = "0x182AAA2A0")]
				internal string? FVJWHCGEVHP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2AA10A0", Offset = "0x2A9FEA0", VA = "0x182AA10A0")]
			public AHYDVBBFCKY(SQESMBBMMXQ a, LRUFRDRZELX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2AA0BA0", Offset = "0x2A9F9A0", VA = "0x182AA0BA0")]
			private int AOJVZEMMUSI(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2AA0C30", Offset = "0x2A9FA30", VA = "0x182AA0C30")]
			private void MGRKNBYKPPM(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2AA0D50", Offset = "0x2A9FB50", VA = "0x182AA0D50", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class OZHTJTCYRMJ : TSFLVLAAGDN<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0xF2D740", Offset = "0xF2C540", VA = "0x180F2D740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2AAA000", Offset = "0x2AA8E00", VA = "0x182AAA000")]
			public OZHTJTCYRMJ(SQESMBBMMXQ a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class ZKWLXHRDOMD : GOYEQGFPMCJ<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public ZKWLXHRDOMD WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x6000375")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000376")]
				[Cpp2IlInjected.Address(RVA = "0x2AA1C60", Offset = "0x2AA0A60", VA = "0x182AA1C60")]
				internal int EJIWEXPPLIG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x2AA1E00", Offset = "0x2AA0C00", VA = "0x182AA1E00")]
				internal void EJODCEJMUTP(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA510", Offset = "0x2AB9310", VA = "0x182ABA510")]
			public ZKWLXHRDOMD(SQESMBBMMXQ a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA2A0", Offset = "0x2AB90A0", VA = "0x182ABA2A0", Slot = "151")]
			protected override void AKQXZFHDGDA(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class TYWNFMUVPDH : OAOZZKUFIDL<WNQGYTMHGHE>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public TYWNFMUVPDH WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<OUFJYXOYDZY>> XIFIDBDYXFG;

				[Cpp2IlInjected.Token(Token = "0x600037E")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600037F")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2100", Offset = "0x2AA0F00", VA = "0x182AA2100")]
				internal int FUUBPHYMSZO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2B40", Offset = "0x2AA1940", VA = "0x182AA2B40")]
				internal void FVJWHCGEVHP(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class CFCMCYVGPQJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<OUFJYXOYDZY> RBDPJXMAXCG;

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CFCMCYVGPQJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2AA3070", Offset = "0x2AA1E70", VA = "0x182AA3070")]
				internal bool FVUKBPTZOEH(Id32<OUFJYXOYDZY> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2AB10F0", Offset = "0x2AAFEF0", VA = "0x182AB10F0")]
			public TYWNFMUVPDH(SQESMBBMMXQ a, WNQGYTMHGHE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0BE0", Offset = "0x2AAF9E0", VA = "0x182AB0BE0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class BXCOYALGRWL : OAOZZKUFIDL<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public BXCOYALGRWL WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x6000385")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0x2AA26E0", Offset = "0x2AA14E0", VA = "0x182AA26E0")]
				internal bool FUZIMOSKCKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0x2AA1FE0", Offset = "0x2AA0DE0", VA = "0x182AA1FE0")]
				internal void FUUBPHYMSZO(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1B20", Offset = "0x2AA0920", VA = "0x182AA1B20")]
			public BXCOYALGRWL(SQESMBBMMXQ a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1950", Offset = "0x2AA0750", VA = "0x182AA1950", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class HXEOPEIGZQD : OAOZZKUFIDL<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public HXEOPEIGZQD WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038B")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2730", Offset = "0x2AA1530", VA = "0x182AA2730")]
				internal bool FUZIMOSKCKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2070", Offset = "0x2AA0E70", VA = "0x182AA2070")]
				internal void FUUBPHYMSZO(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2AA81A0", Offset = "0x2AA6FA0", VA = "0x182AA81A0")]
			public HXEOPEIGZQD(SQESMBBMMXQ a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7FD0", Offset = "0x2AA6DD0", VA = "0x182AA7FD0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class AAVSSRYYHAR : OAOZZKUFIDL<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public AAVSSRYYHAR WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x600038F")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2950", Offset = "0x2AA1750", VA = "0x182AA2950")]
				internal int FUZIMOSKCKX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0x2AA22D0", Offset = "0x2AA10D0", VA = "0x182AA22D0")]
				internal void FUUBPHYMSZO(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA0B30", Offset = "0x2A9F930", VA = "0x182AA0B30")]
			public AAVSSRYYHAR(SQESMBBMMXQ a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA08E0", Offset = "0x2A9F6E0", VA = "0x182AA08E0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class PAILWTDZEWC
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log IRJSVORGEBN;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class TSNNWDXTZVL<a> : OAOZZKUFIDL<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class FPNPCYKNTBK
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
					public FPNPCYKNTBK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C6")]
					[Cpp2IlInjected.Address(RVA = "0x3F47410", Offset = "0x3F46210", VA = "0x183F47410", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C7")]
					[Cpp2IlInjected.Address(RVA = "0x3F47750", Offset = "0x3F46550", VA = "0x183F47750", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload RGFFCYJKWWD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public TSNNWDXTZVL<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public FPNPCYKNTBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x5059F10", Offset = "0x5058D10", VA = "0x185059F10")]
				[AsyncStateMachine(typeof(TSNNWDXTZVL<>.FPNPCYKNTBK.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task NBOMNVBZDWJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0x5059FE0", Offset = "0x5058DE0", VA = "0x185059FE0")]
				internal void VGIVLDKSWUG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class UEZIPMBRLCS
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
					public UEZIPMBRLCS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003D9")]
					[Cpp2IlInjected.Address(RVA = "0x3F5A5C0", Offset = "0x3F593C0", VA = "0x183F5A5C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DA")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public UEZIPMBRLCS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3F5BD70", Offset = "0x3F5AB70", VA = "0x183F5BD70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0x3F5C480", Offset = "0x3F5B280", VA = "0x183F5C480", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public DWVMJQUITOW.ETFEXRFRZQU UVNXYAJHTGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string AVOALQYXSBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string MRNYBKRVZGS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public TSNNWDXTZVL<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper TAFFKGIXKMQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool ERCQAACOKIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action TZNPIBLLXUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool NHQENXAGPRK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string OBHQITGDQQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action ATCQAXMSJUU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action FSYLGDLMVPW;

				[Cpp2IlInjected.Token(Token = "0x60003C8")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public UEZIPMBRLCS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0x640E280", Offset = "0x640D080", VA = "0x18640E280")]
				internal void MWIZVETDEOJ(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x640E210", Offset = "0x640D010", VA = "0x18640E210")]
				internal void MWDSXXZFVDA(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
				internal string QBNNEISVFUY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x640E390", Offset = "0x640D190", VA = "0x18640E390")]
				internal void QBSUBPMSPGH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B550", Offset = "0x5C2A350", VA = "0x185C2B550")]
				internal bool QBYAYWGPYRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x640E520", Offset = "0x640D320", VA = "0x18640E520")]
				internal char QCDHWDANICZ((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				internal string? QASLPHRFUBO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0xF4C210", Offset = "0xF4B010", VA = "0x180F4C210")]
				internal bool QAXSMOLDDMX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0x640E2D0", Offset = "0x640D0D0", VA = "0x18640E2D0")]
				internal void QBCZJVFAMYG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B550", Offset = "0x5C2A350", VA = "0x185C2B550")]
				internal bool QBIGHBYXWJP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x640E5C0", Offset = "0x640D3C0", VA = "0x18640E5C0")]
				[AsyncStateMachine(typeof(TSNNWDXTZVL<>.UEZIPMBRLCS.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void QDDQIKWADHS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x640DFF0", Offset = "0x640CDF0", VA = "0x18640DFF0")]
				internal void KCPPXAUGQRW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x640E760", Offset = "0x640D560", VA = "0x18640E760")]
				[AsyncStateMachine(typeof(TSNNWDXTZVL<>.UEZIPMBRLCS.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task YNWZYFVDREV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x640E0F0", Offset = "0x640CEF0", VA = "0x18640E0F0")]
				internal void MUNPTVWAXQG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x640E6A0", Offset = "0x640D4A0", VA = "0x18640E6A0")]
				internal void TQNSDOOMEHQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x640E660", Offset = "0x640D460", VA = "0x18640E660")]
				internal bool QDIXFRPXMTB()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class PPBVCVHKSNR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter JISYQEIGJDU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public TSNNWDXTZVL<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<DWVMJQUITOW.HTYPVLYGIAS> AUYACGJUQSX;

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public PPBVCVHKSNR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F1E0", Offset = "0x5D5DFE0", VA = "0x185D5F1E0")]
				internal bool TJKMQZHBLGR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F110", Offset = "0x5D5DF10", VA = "0x185D5F110")]
				internal void KWUGVGDGIIH(DWVMJQUITOW.HTYPVLYGIAS a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class POWOFONNJCI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool FOIIXTXFLQE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public HLFMYWGLVZH TZZBCAYCPZI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public HLFMYWGLVZH USBGOEBXVQH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public HLFMYWGLVZH AVVUQJVANME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string XQLYAZANQSX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public PPBVCVHKSNR YLNIYCOGBOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action CCVXYHDMWNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action AVDGZNDSAEG;

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public POWOFONNJCI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0xC15810", Offset = "0xC14610", VA = "0x180C15810")]
				internal bool RLNORHFZOUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x5D5DEC0", Offset = "0x5D5CCC0", VA = "0x185D5DEC0")]
				internal void AVKPAPNNVUK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x5D5DFE0", Offset = "0x5D5CDE0", VA = "0x185D5DFE0")]
				internal void TIURZEZJIYQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x5D5DFC0", Offset = "0x5D5CDC0", VA = "0x185D5DFC0")]
				internal void TIPLBYFLZNH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x5D5EAB0", Offset = "0x5D5D8B0", VA = "0x185D5EAB0")]
				internal void TJVALMUWEDJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x5D5E450", Offset = "0x5D5D250", VA = "0x185D5E450")]
				internal void TJFFTSNEBVI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x5D5DFC0", Offset = "0x5D5CDC0", VA = "0x185D5DFC0")]
				internal void KWZNSMXDRTQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class PPMIXIVFLKJ
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
					public PPMIXIVFLKJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003EB")]
					[Cpp2IlInjected.Address(RVA = "0x3F69B40", Offset = "0x3F68940", VA = "0x183F69B40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EC")]
					[Cpp2IlInjected.Address(RVA = "0x3F6A180", Offset = "0x3F68F80", VA = "0x183F6A180", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool MBOOQWZPTSE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public POWOFONNJCI YMDDPWVYDWF;

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public PPMIXIVFLKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F410", Offset = "0x5D5E210", VA = "0x185D5F410")]
				[AsyncStateMachine(typeof(TSNNWDXTZVL<>.PPMIXIVFLKJ.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task OZMFHRHFVEG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F4E0", Offset = "0x5D5E2E0", VA = "0x185D5F4E0")]
				internal void TIKEERLOQBY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class PPHCACBIBZA
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
					public PPHCACBIBZA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F0")]
					[Cpp2IlInjected.Address(RVA = "0x3F69530", Offset = "0x3F68330", VA = "0x183F69530", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F1")]
					[Cpp2IlInjected.Address(RVA = "0x3F69AE0", Offset = "0x3F688E0", VA = "0x183F69AE0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload IRZGZMESFTJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public POWOFONNJCI YLXWSQCAUKW;

				[Cpp2IlInjected.Token(Token = "0x60003ED")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public PPHCACBIBZA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EE")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F220", Offset = "0x5D5E020", VA = "0x185D5F220")]
				[AsyncStateMachine(typeof(TSNNWDXTZVL<>.PPHCACBIBZA.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task EUAZOLWIWKR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F2F0", Offset = "0x5D5E0F0", VA = "0x185D5F2F0")]
				internal void KXEUPTRBBEZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class LWJGTEGGOWS
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
					public LWJGTEGGOWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F7")]
					[Cpp2IlInjected.Address(RVA = "0x3F69050", Offset = "0x3F67E50", VA = "0x183F69050", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F8")]
					[Cpp2IlInjected.Address(RVA = "0x3F694D0", Offset = "0x3F682D0", VA = "0x183F694D0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public TSNNWDXTZVL<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload QCEHVNALPGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public DWVMJQUITOW.HTYPVLYGIAS UVNXYAJHTGD;

				[Cpp2IlInjected.Token(Token = "0x60003F2")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public LWJGTEGGOWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F3")]
				[Cpp2IlInjected.Address(RVA = "0x5597590", Offset = "0x5596390", VA = "0x185597590")]
				[AsyncStateMachine(typeof(TSNNWDXTZVL<>.LWJGTEGGOWS.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task GMFDOEAFLSP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0x55974B0", Offset = "0x55962B0", VA = "0x1855974B0")]
				internal bool EWBSDQELAFP(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5597340", Offset = "0x5596140", VA = "0x185597340")]
				internal void EVLXLVWSXXO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5597460", Offset = "0x5596260", VA = "0x185597460")]
				internal void EVREJCQQHIX()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class ABSHQAFZKQB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string CFPLZGTQYCG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public HLFMYWGLVZH JGALSVHXEXT;

				[Cpp2IlInjected.Token(Token = "0x60003F9")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ABSHQAFZKQB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FA")]
				[Cpp2IlInjected.Address(RVA = "0x5679710", Offset = "0x5678510", VA = "0x185679710")]
				internal string? ECVGQXBOXFG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xC5FB80", Offset = "0xC5E980", VA = "0x180C5FB80")]
				internal bool EDANODVMGQP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x5679730", Offset = "0x5678530", VA = "0x185679730")]
				internal void EDFULKPJQBY(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool XFEVSWGBJLR;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log IRJSVORGEBN
			{
				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x6231410", Offset = "0x6230210", VA = "0x186231410")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x6233E30", Offset = "0x6232C30", VA = "0x186233E30", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected DWVMJQUITOW DKEALQBNYOF
			{
				[Cpp2IlInjected.Token(Token = "0x600039B")]
				[Cpp2IlInjected.Address(RVA = "0xAC7170", Offset = "0xAC5F70", VA = "0x180AC7170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0xAC7430", Offset = "0xAC6230", VA = "0x180AC7430")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> WKRGKMEYOPW
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xB4EAC0", Offset = "0xB4D8C0", VA = "0x180B4EAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xB4DDE0", Offset = "0xB4CBE0", VA = "0x180B4DDE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected EBBOVOSUCEY TNLVDKHBIKD
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xB4EAE0", Offset = "0xB4D8E0", VA = "0x180B4EAE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xB4E1C0", Offset = "0xB4CFC0", VA = "0x180B4E1C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected ZVLVZAXDPUU RZEONENRDXV
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xB4EAD0", Offset = "0xB4D8D0", VA = "0x180B4EAD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0xB4DF40", Offset = "0xB4CD40", VA = "0x180B4DF40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x6233E00", Offset = "0x6232C00", VA = "0x186233E00")]
			protected TSNNWDXTZVL(SQESMBBMMXQ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x622FAF0", Offset = "0x622E8F0", VA = "0x18622FAF0", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x622FA90", Offset = "0x622E890", VA = "0x18622FA90", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x6230C30", Offset = "0x622FA30", VA = "0x186230C30", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x6232ED0", Offset = "0x6231CD0", VA = "0x186232ED0")]
			private void SLATETQHHSG(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x6233C80", Offset = "0x6232A80", VA = "0x186233C80", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x6230D20", Offset = "0x622FB20", VA = "0x186230D20")]
			private void FEZXIZKFZVC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x6232330", Offset = "0x6231130", VA = "0x186232330")]
			private void QKTNGVRNUTO(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "151")]
			protected virtual void AQMFWCAQHML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x6232DC0", Offset = "0x6231BC0", VA = "0x186232DC0")]
			private void SDJWRERNFZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x62331B0", Offset = "0x6231FB0", VA = "0x1862331B0")]
			private void ULMNGIUAJVU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x622FE50", Offset = "0x622EC50", VA = "0x18622FE50")]
			private void DTTHDUSWHLM(DWVMJQUITOW.HTYPVLYGIAS a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x6231790", Offset = "0x6230590", VA = "0x186231790")]
			private void NYECRXFCDIY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x62313E0", Offset = "0x62301E0", VA = "0x1862313E0")]
			protected void HFAKHMPCTWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x62319A0", Offset = "0x62307A0", VA = "0x1862319A0")]
			private void PYDWCDLUKMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x622FA70", Offset = "0x622E870", VA = "0x18622FA70")]
			private void BSHVEBXIUQU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x622F9D0", Offset = "0x622E7D0", VA = "0x18622F9D0")]
			private void AJDXIFOZAXR(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x622FB50", Offset = "0x622E950", VA = "0x18622FB50")]
			private string DIEBGTFUSDL((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6230C90", Offset = "0x622FA90", VA = "0x186230C90")]
			private string EGKDWEUNVBA(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x6231AE0", Offset = "0x62308E0", VA = "0x186231AE0")]
			[CompilerGenerated]
			private object? QBIECYVBKIO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x6231B10", Offset = "0x6230910", VA = "0x186231B10")]
			[CompilerGenerated]
			private void QBNLAFOYTTX(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x6231A60", Offset = "0x6230860", VA = "0x186231A60")]
			[CompilerGenerated]
			private IReadOnlyList<object> QBCXFSBEAXF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x62322A0", Offset = "0x62310A0", VA = "0x1862322A0")]
			[CompilerGenerated]
			private void QCDFRZWQWBY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x6231A10", Offset = "0x6230810", VA = "0x186231A10")]
			[CompilerGenerated]
			private void PZXHWDLTWHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x622FA30", Offset = "0x622E830", VA = "0x18622FA30")]
			[CompilerGenerated]
			private void BBLEJBKGOKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x6231460", Offset = "0x6230260", VA = "0x186231460")]
			[CompilerGenerated]
			private void JURCMEPYGJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x62313A0", Offset = "0x62301A0", VA = "0x1862313A0")]
			[CompilerGenerated]
			private void HCNDYHFDYVK(DWVMJQUITOW.HTYPVLYGIAS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class ROHSWJJLHDY : TSNNWDXTZVL<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AAAD20", Offset = "0x2AA9B20", VA = "0x182AAAD20")]
			public ROHSWJJLHDY(SQESMBBMMXQ a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class CIWVASYPJSC : TSNNWDXTZVL<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type AJGMYVEHKXH
				{
					[Cpp2IlInjected.Token(Token = "0x6000405")]
					[Cpp2IlInjected.Address(RVA = "0x2AAB140", Offset = "0x2AA9F40", VA = "0x182AAB140", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope JPQBXCTALBY
				{
					[Cpp2IlInjected.Token(Token = "0x6000406")]
					[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string VXXRPQSUAGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000404")]
				[Cpp2IlInjected.Address(RVA = "0x141FAF0", Offset = "0x141E8F0", VA = "0x18141FAF0")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0x2AAB190", Offset = "0x2AA9F90", VA = "0x182AAB190", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x2AAB070", Offset = "0x2AA9E70", VA = "0x182AAB070", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool IKAQPGIIUAB(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2AAAF60", Offset = "0x2AA9D60", VA = "0x182AAAF60", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2AAAD80", Offset = "0x2AA9B80", VA = "0x182AAAD80", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2AAAE10", Offset = "0x2AA9C10", VA = "0x182AAAE10", Slot = "7")]
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
				protected virtual Type AJGMYVEHKXH
				{
					[Cpp2IlInjected.Token(Token = "0x600040E")]
					[Cpp2IlInjected.Address(RVA = "0x2AB1520", Offset = "0x2AB0320", VA = "0x182AB1520", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers JUTVAUKRIAY
				{
					[Cpp2IlInjected.Token(Token = "0x600040F")]
					[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string VXXRPQSUAGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x141FAF0", Offset = "0x141E8F0", VA = "0x18141FAF0")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000411")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1570", Offset = "0x2AB0370", VA = "0x182AB1570", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000412")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1450", Offset = "0x2AB0250", VA = "0x182AB1450", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool IKAQPGIIUAB(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1340", Offset = "0x2AB0140", VA = "0x182AB1340", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2AB12B0", Offset = "0x2AB00B0", VA = "0x182AB12B0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1160", Offset = "0x2AAFF60", VA = "0x182AB1160", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
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
					public ZLLAWYXLGFG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000423")]
					[Cpp2IlInjected.Address(RVA = "0x2AB5540", Offset = "0x2AB4340", VA = "0x182AB5540", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000424")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZLLAWYXLGFG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2AB5950", Offset = "0x2AB4750", VA = "0x182AB5950", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public CIWVASYPJSC WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public EBBOVOSUCEY ZVTLZJRGHQB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> CCQRBAJPNBY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> CCVXYHDMWNH;

				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA700", Offset = "0x2AB9500", VA = "0x182ABA700")]
				internal object? ANMERSOPWNP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA5D0", Offset = "0x2AB93D0", VA = "0x182ABA5D0")]
				internal bool ALWBNQLKZAV(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA630", Offset = "0x2AB9430", VA = "0x182ABA630")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void ANGXULUSNCG(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2ABC160", Offset = "0x2ABAF60", VA = "0x182ABC160")]
				internal IReadOnlyList<TargetPlayersSelection> NKPSHVXOCAL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA8B0", Offset = "0x2AB96B0", VA = "0x182ABA8B0")]
				internal object? AOBZJMWHYVQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA570", Offset = "0x2AB9370", VA = "0x182ABA570")]
				internal bool ALQUQJRNPPM(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA7E0", Offset = "0x2AB95E0", VA = "0x182ABA7E0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void ANWSMGCKPKH(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> OZDNQILSJHX;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> GZJUYPTMOMP;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> ZXJDRAGVOJN;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3C80", Offset = "0x2AA2A80", VA = "0x182AA3C80")]
			public CIWVASYPJSC(SQESMBBMMXQ a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3110", Offset = "0x2AA1F10", VA = "0x182AA3110", Slot = "151")]
			protected override void AQMFWCAQHML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3670", Offset = "0x2AA2470", VA = "0x182AA3670")]
			private static IReadOnlyList<TargetPlayersSelection> NSMXKUGAJUI(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class VIDNYXZHMMX : BNGOKRALVTA<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType YLRADNSNNPL
			{
				[Cpp2IlInjected.Token(Token = "0x6000428")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9560", Offset = "0x2AB8360", VA = "0x182AB9560")]
			public VIDNYXZHMMX(SQESMBBMMXQ a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class AMFEQOWNTBA : OAOZZKUFIDL<FDTJOQJNBIL>
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1110", Offset = "0x2A9FF10", VA = "0x182AA1110")]
			public AMFEQOWNTBA(SQESMBBMMXQ a, FDTJOQJNBIL b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class OAOZZKUFIDL<a> : QDPJHBURBMQ, IDisposable where a : notnull, FDTJOQJNBIL
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class ROWRFPJNAWU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public OAOZZKUFIDL<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public SQESMBBMMXQ WJIRMVPJVZQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a VLIWURBHSIX;

				[Cpp2IlInjected.Token(Token = "0x60004B5")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ROWRFPJNAWU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0x5E7A200", Offset = "0x5E79000", VA = "0x185E7A200")]
				internal SGKRYXEZWIF XPXPVYPPWIU(WDXMACYERUS a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class SPCGLRUCFDW
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
					public SPCGLRUCFDW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BB")]
					[Cpp2IlInjected.Address(RVA = "0x3F49FE0", Offset = "0x3F48DE0", VA = "0x183F49FE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BC")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string RLOGPBKPXDS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, IGWAJAWUKJF>> BDBLTLGUHXP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public OAOZZKUFIDL<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> PZGOERAWNPR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public DWVMJQUITOW DKEALQBNYOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> TLQSPWPDHKP;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public SPCGLRUCFDW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				internal string EDOYUXXXTZA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
				internal void EDUFSERVDKJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0x60F8570", Offset = "0x60F7370", VA = "0x1860F8570")]
				[AsyncStateMachine(typeof(OAOZZKUFIDL<>.SPCGLRUCFDW.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void EDELAKKDBCI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class MYQPOZSZPYJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60004BD")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public MYQPOZSZPYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x5A6F780", Offset = "0x5A6E580", VA = "0x185A6F780")]
				internal Result<string, IGWAJAWUKJF> CGEYRSBBVSI(string a)
				{
					return default(Result<string, IGWAJAWUKJF>);
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
				public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public OAOZZKUFIDL<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0x539E6A0", Offset = "0x539D4A0", VA = "0x18539E6A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x539E8F0", Offset = "0x539D6F0", VA = "0x18539E8F0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public OAOZZKUFIDL<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x539E960", Offset = "0x539D760", VA = "0x18539E960", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x539EC70", Offset = "0x539DA70", VA = "0x18539EC70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly SQESMBBMMXQ BLMNABJGIMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool QRLVPRAAPIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<TDADSARCMWU, SGKRYXEZWIF> FRHQKAPIERR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<TDADSARCMWU, NXDEFHNCTOS> HAUBXEWRREC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> THHIZDVRKIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<TDADSARCMWU>>? JJQRLQLRNRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<TDADSARCMWU>, NXDEFHNCTOS>? POWLHQZYFEO;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected LCNHFLDFADN VHVTYYKGQWO
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0x5C63000", Offset = "0x5C61E00", VA = "0x185C63000")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected KLWLFKHUOPD KLWLFKHUOPD
			{
				[Cpp2IlInjected.Token(Token = "0x600042B")]
				[Cpp2IlInjected.Address(RVA = "0x5C61FA0", Offset = "0x5C60DA0", VA = "0x185C61FA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected PCBXNHFFHWA TGOJDUZJTQH
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x5C61040", Offset = "0x5C5FE40", VA = "0x185C61040")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a FDTJOQJNBIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000430")]
				[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<ANEJQQKWRHI> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000431")]
				[Cpp2IlInjected.Address(RVA = "0x1669DE0", Offset = "0x1668BE0", VA = "0x181669DE0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<ANEJQQKWRHI>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<KUBDOTYWEDD> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0x5C64E90", Offset = "0x5C63C90", VA = "0x185C64E90", Slot = "6")]
				get
				{
					return default(Id32<KUBDOTYWEDD>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0x5C64D00", Offset = "0x5C63B00", VA = "0x185C64D00", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x5C64CE0", Offset = "0x5C63AE0", VA = "0x185C64CE0", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x6000438")]
				[Cpp2IlInjected.Address(RVA = "0x5C64FF0", Offset = "0x5C63DF0", VA = "0x185C64FF0", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<PSZMTIJLKYP> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xB45FA0", Offset = "0xB44DA0", VA = "0x180B45FA0", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<PSZMTIJLKYP>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0x10073B0", Offset = "0x10061B0", VA = "0x1810073B0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xB0DD60", Offset = "0xB0CB60", VA = "0x180B0DD60", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0x5C64BB0", Offset = "0x5C639B0", VA = "0x185C64BB0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0x5C64BE0", Offset = "0x5C639E0", VA = "0x185C64BE0", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x5C64C10", Offset = "0x5C63A10", VA = "0x185C64C10", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x5C64E70", Offset = "0x5C63C70", VA = "0x185C64E70", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x5C64DA0", Offset = "0x5C63BA0", VA = "0x185C64DA0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x5C64C80", Offset = "0x5C63A80", VA = "0x185C64C80", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x5C64C50", Offset = "0x5C63A50", VA = "0x185C64C50", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x10BF040", Offset = "0x10BDE40", VA = "0x1810BF040", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x17E7590", Offset = "0x17E6390", VA = "0x1817E7590")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x5C64C40", Offset = "0x5C63A40", VA = "0x185C64C40", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x5C64D50", Offset = "0x5C63B50", VA = "0x185C64D50", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x5C64E10", Offset = "0x5C63C10", VA = "0x185C64E10", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x5C64E40", Offset = "0x5C63C40", VA = "0x185C64E40", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x5C64D80", Offset = "0x5C63B80", VA = "0x185C64D80", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual LBWQVDSXKHJ? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual JZUQHNZNXWS? RKTOOWAKTVF
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<KSHTGNRFKHE>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000477")]
				[Cpp2IlInjected.Address(RVA = "0x5C64CB0", Offset = "0x5C63AB0", VA = "0x185C64CB0", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<DINEWLJZVXU> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x5C64DC0", Offset = "0x5C63BC0", VA = "0x185C64DC0", Slot = "68")]
				get
				{
					return default(Id128<DINEWLJZVXU>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<DINEWLJZVXU> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x5C64D20", Offset = "0x5C63B20", VA = "0x185C64D20", Slot = "59")]
				get
				{
					return default(Id32<DINEWLJZVXU>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<DINEWLJZVXU>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<DINEWLJZVXU>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x5C632E0", Offset = "0x5C620E0", VA = "0x185C632E0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0xAC81C0", Offset = "0xAC6FC0", VA = "0x180AC81C0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xAC8140", Offset = "0xAC6F40", VA = "0x180AC8140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<KSHTGNRFKHE> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0x5C64ED0", Offset = "0x5C63CD0", VA = "0x185C64ED0", Slot = "69")]
				get
				{
					return default(Id32<KSHTGNRFKHE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<KSHTGNRFKHE> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0x5C64DF0", Offset = "0x5C63BF0", VA = "0x185C64DF0", Slot = "70")]
				get
				{
					return default(Id128<KSHTGNRFKHE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<KSHTGNRFKHE>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x5C64EF0", Offset = "0x5C63CF0", VA = "0x185C64EF0", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<TDADSARCMWU, NXDEFHNCTOS> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x5C64FB0", Offset = "0x5C63DB0", VA = "0x185C64FB0", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<TDADSARCMWU, NXDEFHNCTOS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<TDADSARCMWU>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600049E")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action IIDFPSQRQYO
			{
				[Cpp2IlInjected.Token(Token = "0x6000458")]
				[Cpp2IlInjected.Address(RVA = "0x5C63940", Offset = "0x5C62740", VA = "0x185C63940", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000459")]
				[Cpp2IlInjected.Address(RVA = "0x5C63E30", Offset = "0x5C62C30", VA = "0x185C63E30", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate AEPJUFDXIKH
			{
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x5C620A0", Offset = "0x5C60EA0", VA = "0x185C620A0", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045C")]
				[Cpp2IlInjected.Address(RVA = "0x5C62BB0", Offset = "0x5C619B0", VA = "0x185C62BB0", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate NVVRGZOIIZK
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x5C62AE0", Offset = "0x5C618E0", VA = "0x185C62AE0", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x5C645E0", Offset = "0x5C633E0", VA = "0x185C645E0", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action HLMIEIKIFFC
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x5C60800", Offset = "0x5C5F600", VA = "0x185C60800", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x5C612C0", Offset = "0x5C600C0", VA = "0x185C612C0", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action WYGARNLVOJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x5C63060", Offset = "0x5C61E60", VA = "0x185C63060", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x5C64540", Offset = "0x5C63340", VA = "0x185C64540", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<TDADSARCMWU>, NXDEFHNCTOS> RHKUHLDNMFS
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x5C64480", Offset = "0x5C63280", VA = "0x185C64480", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0x5C640C0", Offset = "0x5C62EC0", VA = "0x185C640C0", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<TDADSARCMWU>, NXDEFHNCTOS> EYUSBEQSLWT
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x5C63ED0", Offset = "0x5C62CD0", VA = "0x185C63ED0", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x5C62870", Offset = "0x5C61670", VA = "0x185C62870", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<TDADSARCMWU>> CAXVAHZAQTX
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x5C64260", Offset = "0x5C63060", VA = "0x185C64260", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x5C63410", Offset = "0x5C62210", VA = "0x185C63410", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<TDADSARCMWU>, Id32<TDADSARCMWU>> RRMCYGXYRGQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x5C61EE0", Offset = "0x5C60CE0", VA = "0x185C61EE0", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x5C63D20", Offset = "0x5C62B20", VA = "0x185C63D20", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<TDADSARCMWU>, NXDEFHNCTOS> XKUZRGSEQDS
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x5C63F90", Offset = "0x5C62D90", VA = "0x185C63F90", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x5C64680", Offset = "0x5C63480", VA = "0x185C64680", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<TDADSARCMWU>, Id32<TDADSARCMWU>> WZFBMMCZQUD
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x5C63100", Offset = "0x5C61F00", VA = "0x185C63100", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x5C643C0", Offset = "0x5C631C0", VA = "0x185C643C0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> DRJXOABBDXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x5C64180", Offset = "0x5C62F80", VA = "0x185C64180", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x5C63320", Offset = "0x5C62120", VA = "0x185C63320", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x5C64740", Offset = "0x5C63540", VA = "0x185C64740")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected OAOZZKUFIDL(SQESMBBMMXQ a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x5C61D10", Offset = "0x5C60B10", VA = "0x185C61D10", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x5C60AF0", Offset = "0x5C5F8F0", VA = "0x185C60AF0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x5C62930", Offset = "0x5C61730", VA = "0x185C62930", Slot = "9")]
			public Task<Result<None, IGWAJAWUKJF>> KGMFDGJNXST(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x5C62B80", Offset = "0x5C61980", VA = "0x185C62B80")]
			public bool KKKVHKPRMMT([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x5C63910", Offset = "0x5C62710", VA = "0x185C63910")]
			public bool ULSBQWMZZJA([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x5C64320", Offset = "0x5C63120", VA = "0x185C64320", Slot = "34")]
			public void WKHAZOSMJIW(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x5C61990", Offset = "0x5C60790", VA = "0x185C61990", Slot = "35")]
			public Task HDKYSGGWTJI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x5C61A90", Offset = "0x5C60890", VA = "0x185C61A90", Slot = "36")]
			[AsyncStateMachine(typeof(OAOZZKUFIDL<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, IGWAJAWUKJF>> HEHZSAVDMQV(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "119")]
			public virtual void KNWPESLJUMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x10ADED0", Offset = "0x10ACCD0", VA = "0x1810ADED0")]
			protected void ADNIFXXIEAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x22DFC00", Offset = "0x22DEA00", VA = "0x1822DFC00")]
			protected void FQTBAGPFOBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x22A11E0", Offset = "0x229FFE0", VA = "0x1822A11E0")]
			private void RKTRDDSPPUT([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x5C627B0", Offset = "0x5C615B0", VA = "0x185C627B0", Slot = "122")]
			public virtual Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> KBECSBQJIBS(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x5C60610", Offset = "0x5C5F410", VA = "0x185C60610", Slot = "123")]
			public virtual Task<Result<None, IGWAJAWUKJF>> BEJVPBITIPZ(Id32<TDADSARCMWU> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "124")]
			public virtual void XMSGAUMCFSP(Id32<TDADSARCMWU> sourceId, Id32<TDADSARCMWU> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x5C606D0", Offset = "0x5C5F4D0", VA = "0x185C606D0", Slot = "125")]
			public virtual IEnumerable<TWGQWHZWPAR> BSXGULCUBDO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x5C608B0", Offset = "0x5C5F6B0", VA = "0x185C608B0", Slot = "126")]
			public Result<None, IGWAJAWUKJF> DDMNFFTHANL(string a)
			{
				return default(Result<None, IGWAJAWUKJF>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x5C631C0", Offset = "0x5C61FC0", VA = "0x185C631C0", Slot = "50")]
			public bool MLAFZIZWLVL([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x5C61320", Offset = "0x5C60120", VA = "0x185C61320")]
			public bool GBYLSDXVOLM([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "128")]
			public virtual void OUKVRANRSJG(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "129")]
			public virtual BRWAWVHTLWT XJTKXEURSLO([In] MUFNPIGOHJE audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x5C608F0", Offset = "0x5C5F6F0", VA = "0x185C608F0")]
			protected void DTXVNYBNUAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x5C632E0", Offset = "0x5C620E0", VA = "0x185C632E0", Slot = "134")]
			protected virtual bool MTUJGLUJXEL(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x5C633E0", Offset = "0x5C621E0", VA = "0x185C633E0", Slot = "96")]
			public bool NCHWWVXUJWF(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "135")]
			protected virtual bool GWMMHYFMTZS(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected virtual void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x5C62C50", Offset = "0x5C61A50", VA = "0x185C62C50")]
			protected void LHQRDXBCVIC(DWVMJQUITOW a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, IGWAJAWUKJF>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x5C60E40", Offset = "0x5C5FC40", VA = "0x185C60E40")]
			protected void EGIGJQBNYFO(DWVMJQUITOW a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x5C639E0", Offset = "0x5C627E0", VA = "0x185C639E0", Slot = "146")]
			protected virtual void QHIWMVJFBBX(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x5C63DE0", Offset = "0x5C62BE0", VA = "0x185C63DE0", Slot = "90")]
			public void RPYZBMJIIMY(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x5C64050", Offset = "0x5C62E50", VA = "0x185C64050", Slot = "91")]
			public CircuitsRigidTransform UKEUJTLHIUN()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "149")]
			public virtual bool UTPUPVIFFKV(Id32<TDADSARCMWU> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x5C615A0", Offset = "0x5C603A0", VA = "0x185C615A0")]
			private void GTKPBRXFNRC([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C61BE0", Offset = "0x5C609E0", VA = "0x185C61BE0")]
			private void HFQEAQYSDYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x10ADED0", Offset = "0x10ACCD0", VA = "0x1810ADED0", Slot = "97")]
			private void BICMNAIEHHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x5C62260", Offset = "0x5C61060", VA = "0x185C62260", Slot = "99")]
			private void JZBHXIMHVQN(Id32<TDADSARCMWU> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x5C634D0", Offset = "0x5C622D0", VA = "0x185C634D0", Slot = "101")]
			private void OPVXKPGKZYC(Id32<TDADSARCMWU> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5C629A0", Offset = "0x5C617A0", VA = "0x185C629A0", Slot = "103")]
			private void KHYDACJZNHK(Id32<TDADSARCMWU> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x5C615C0", Offset = "0x5C603C0", VA = "0x185C615C0", Slot = "104")]
			private void HCKXAVRSBCE(Id32<TDADSARCMWU> sourceId, Id32<TDADSARCMWU> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x5C612A0", Offset = "0x5C600A0", VA = "0x185C612A0", Slot = "105")]
			private void ESSWQUQOEAB(Id32<TDADSARCMWU> sourceId, Id32<TDADSARCMWU> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x20FCB90", Offset = "0x20FB990", VA = "0x1820FCB90", Slot = "98")]
			private void KCDVGGKMJNC(Id32<TDADSARCMWU> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x5C634F0", Offset = "0x5C622F0", VA = "0x185C634F0", Slot = "100")]
			private void OPYNQGCEHWZ(Id32<TDADSARCMWU> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x5C61CA0", Offset = "0x5C60AA0", VA = "0x185C61CA0", Slot = "102")]
			private void HIVBEOJDRWX(Id32<TDADSARCMWU> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x5C64240", Offset = "0x5C63040", VA = "0x185C64240", Slot = "106")]
			private void VGUCLDQTXHX(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5C62140", Offset = "0x5C60F40", VA = "0x185C62140", Slot = "150")]
			[AsyncStateMachine(typeof(OAOZZKUFIDL<>.<RequestNameChange>d__224))]
			public Task<Result<None, IGWAJAWUKJF>> JXPKTWAGYUX(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x5C60A60", Offset = "0x5C5F860", VA = "0x185C60A60", Slot = "57")]
			private void DZZJWTXFGCR(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x5C60770", Offset = "0x5C5F570", VA = "0x185C60770", Slot = "58")]
			private void CMHJNFFDFKO(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x5C62B80", Offset = "0x5C61980", VA = "0x185C62B80", Slot = "30")]
			private bool UBEBJOYDGFE([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x5C63910", Offset = "0x5C62710", VA = "0x185C63910", Slot = "32")]
			private bool OVRQLVKUKSX([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x5C63D00", Offset = "0x5C62B00", VA = "0x185C63D00", Slot = "51")]
			private bool QJTXMVQTDFN([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			[CompilerGenerated]
			private string ERDZXXHOEUD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C61130", Offset = "0x5C5FF30", VA = "0x185C61130")]
			[CompilerGenerated]
			private void EQYTAQNQVIU(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class DICCDJKNASI : TSFLVLAAGDN<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0xF2F020", Offset = "0xF2DE20", VA = "0x180F2F020", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x2AA40A0", Offset = "0x2AA2EA0", VA = "0x182AA40A0")]
			public DICCDJKNASI(SQESMBBMMXQ a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class BODWADJCVYO : OAOZZKUFIDL<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> HDYVEDFKCHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public BODWADJCVYO WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> ZIWWUCJJCPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> LCUPABAIRSX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C9")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0x2ABADC0", Offset = "0x2AB9BC0", VA = "0x182ABADC0")]
				internal int FUUBPHYMSZO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB580", Offset = "0x2ABA380", VA = "0x182ABB580")]
				internal void FVJWHCGEVHP(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C6")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AA14D0", Offset = "0x2AA02D0", VA = "0x182AA14D0")]
			public BODWADJCVYO(SQESMBBMMXQ a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2AA11F0", Offset = "0x2A9FFF0", VA = "0x182AA11F0", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class HNPVUCCEGTG : XMXHVDDZHBA<MVSWGLQBHFH>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7F70", Offset = "0x2AA6D70", VA = "0x182AA7F70")]
			public HNPVUCCEGTG(SQESMBBMMXQ a, MVSWGLQBHFH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class FUMBMEXOZXQ : OAOZZKUFIDL<GKJWAIQFRTZ>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public FUMBMEXOZXQ WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60004D1")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2900", Offset = "0x2AA1700", VA = "0x182AA2900")]
				internal bool FUZIMOSKCKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0x2AA2240", Offset = "0x2AA1040", VA = "0x182AA2240")]
				internal void FUUBPHYMSZO(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7590", Offset = "0x2AA6390", VA = "0x182AA7590")]
			public FUMBMEXOZXQ(SQESMBBMMXQ a, GKJWAIQFRTZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AA73C0", Offset = "0x2AA61C0", VA = "0x182AA73C0", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class UPHSSNLSUUH : OAOZZKUFIDL<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
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
					public ZLLAWYXLGFG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F3")]
					[Cpp2IlInjected.Address(RVA = "0x2AB68A0", Offset = "0x2AB56A0", VA = "0x182AB68A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F4")]
					[Cpp2IlInjected.Address(RVA = "0x2AB6AD0", Offset = "0x2AB58D0", VA = "0x182AB6AD0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EXHUHYXHGMR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public UPHSSNLSUUH WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> REZFGTVIAIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> GDAYGFUFVFV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D8")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAFB0", Offset = "0x2AB9DB0", VA = "0x182ABAFB0")]
				internal int FUUBPHYMSZO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB8A0", Offset = "0x2ABA6A0", VA = "0x182ABB8A0")]
				internal void FVJWHCGEVHP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB530", Offset = "0x2ABA330", VA = "0x182ABB530")]
				internal int FVEPJVMHLWG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBA40", Offset = "0x2ABA840", VA = "0x182ABBA40")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> FVUKBPTZOEH(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2ABC110", Offset = "0x2ABAF10", VA = "0x182ABC110")]
				internal int JJODKQHOBVV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAA40", Offset = "0x2AB9840", VA = "0x182ABAA40")]
				internal void DJUJSCJTEEL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA9F0", Offset = "0x2AB97F0", VA = "0x182ABA9F0")]
				internal int DJPCUVPVUTC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAB20", Offset = "0x2AB9920", VA = "0x182ABAB20")]
				internal void DKEXMPXNXBD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAAD0", Offset = "0x2AB98D0", VA = "0x182ABAAD0")]
				internal int DJZQPJDQNPU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAC00", Offset = "0x2AB9A00", VA = "0x182ABAC00")]
				internal void DKPLHDLIPXV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2ABABB0", Offset = "0x2AB99B0", VA = "0x182ABABB0")]
				internal int DKKEJWRLGMM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAC90", Offset = "0x2AB9A90", VA = "0x182ABAC90")]
				internal void DKZZBQZDIUN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB9F0", Offset = "0x2ABA7F0", VA = "0x182ABB9F0")]
				internal float FVPDEJACESY()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBB90", Offset = "0x2ABA990", VA = "0x182ABBB90")]
				internal void FWEXWDHUHAZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBB40", Offset = "0x2ABA940", VA = "0x182ABBB40")]
				internal float FVZQYWNWXPQ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBC70", Offset = "0x2ABAA70", VA = "0x182ABBC70")]
				internal void FWPLQQVOZXR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBC20", Offset = "0x2ABAA20", VA = "0x182ABBC20")]
				internal bool FWKETKBRQMI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBD00", Offset = "0x2ABAB00", VA = "0x182ABBD00")]
				internal void JHSTJHKLUXS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBD90", Offset = "0x2ABAB90", VA = "0x182ABBD90")]
				internal int JHYAGOEJEJB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBDE0", Offset = "0x2ABABE0", VA = "0x182ABBDE0")]
				internal void JIDHDUYGNUK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBE70", Offset = "0x2ABAC70", VA = "0x182ABBE70")]
				internal float JIIOBBSDXFT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBEC0", Offset = "0x2ABACC0", VA = "0x182ABBEC0")]
				internal void JINUYIMBGRC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBF50", Offset = "0x2ABAD50", VA = "0x182ABBF50")]
				internal float JITBVPFYQCL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2ABBFA0", Offset = "0x2ABADA0", VA = "0x182ABBFA0")]
				internal void JIYISVZVZNU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2ABC030", Offset = "0x2ABAE30", VA = "0x182ABC030")]
				internal bool JJDPQCTTIZD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2ABC080", Offset = "0x2ABAE80", VA = "0x182ABC080")]
				internal void JJIWNJNQSKM(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8600", Offset = "0x2AB7400", VA = "0x182AB8600")]
			public UPHSSNLSUUH(SQESMBBMMXQ a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7500", Offset = "0x2AB6300", VA = "0x182AB7500", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class NMHXVFDCSOS : GOYEQGFPMCJ<RecNetImageNode>
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
				public NMHXVFDCSOS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004F9")]
				[Cpp2IlInjected.Address(RVA = "0x2AB60D0", Offset = "0x2AB4ED0", VA = "0x182AB60D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FA")]
				[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x2AA95D0", Offset = "0x2AA83D0", VA = "0x182AA95D0")]
			public NMHXVFDCSOS(SQESMBBMMXQ a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9100", Offset = "0x2AA7F00", VA = "0x182AA9100", Slot = "151")]
			protected override void AKQXZFHDGDA(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9430", Offset = "0x2AA8230", VA = "0x182AA9430")]
			[CompilerGenerated]
			private string? SCYDZRZJTRE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9500", Offset = "0x2AA8300", VA = "0x182AA9500")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void SDDKWYTHDCN(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class BNGOKRALVTA<a> : OAOZZKUFIDL<a> where a : notnull, DLECKKONWPQ
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class QFVEKDSMASK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EXHUHYXHGMR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public BNGOKRALVTA<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> REZFGTVIAIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> GDAYGFUFVFV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType MSWIEQBAMQZ;

				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public QFVEKDSMASK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FUZIMOSKCKX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9970", Offset = "0x5DD8770", VA = "0x185DD9970")]
				internal int FUUBPHYMSZO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9AE0", Offset = "0x5DD88E0", VA = "0x185DD9AE0")]
				internal void FVJWHCGEVHP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9A90", Offset = "0x5DD8890", VA = "0x185DD9A90")]
				internal void FVEPJVMHLWG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9D30", Offset = "0x5DD8B30", VA = "0x185DD9D30")]
				internal void FVUKBPTZOEH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9CD0", Offset = "0x5DD8AD0", VA = "0x185DD9CD0")]
				internal bool FVPDEJACESY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9E40", Offset = "0x5DD8C40", VA = "0x185DD9E40")]
				internal void FWEXWDHUHAZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9CD0", Offset = "0x5DD8AD0", VA = "0x185DD9CD0")]
				internal bool FVZQYWNWXPQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9F20", Offset = "0x5DD8D20", VA = "0x185DD9F20")]
				internal float FWPLQQVOZXR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x5DD9E90", Offset = "0x5DD8C90", VA = "0x185DD9E90")]
				internal void FWKETKBRQMI(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x5DDA9E0", Offset = "0x5DD97E0", VA = "0x185DDA9E0")]
				internal float JHSTJHKLUXS()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x5DDAA10", Offset = "0x5DD9810", VA = "0x185DDAA10")]
				internal void JHYAGOEJEJB(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x5DDAAA0", Offset = "0x5DD98A0", VA = "0x185DDAAA0")]
				internal float JIDHDUYGNUK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x5DDAAD0", Offset = "0x5DD98D0", VA = "0x185DDAAD0")]
				internal void JIIOBBSDXFT(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType YLRADNSNNPL
			{
				[Cpp2IlInjected.Token(Token = "0x60004FD")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x6233E00", Offset = "0x6232C00", VA = "0x186233E00")]
			public BNGOKRALVTA(SQESMBBMMXQ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x70F29D0", Offset = "0x70F17D0", VA = "0x1870F29D0", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class ARLHPXPGHIS : OAOZZKUFIDL<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0xF4CB90", Offset = "0xF4B990", VA = "0x180F4CB90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1180", Offset = "0x2A9FF80", VA = "0x182AA1180")]
			public ARLHPXPGHIS(SQESMBBMMXQ a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class DAQNEQJIQIP : TKKXOZMNEQX<DRHCBSFFMSF>
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4040", Offset = "0x2AA2E40", VA = "0x182AA4040")]
			public DAQNEQJIQIP(SQESMBBMMXQ a, DRHCBSFFMSF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class ZCMPVHTVCPF : TKKXOZMNEQX<NEDFHZXXODK>
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA240", Offset = "0x2AB9040", VA = "0x182ABA240")]
			public ZCMPVHTVCPF(SQESMBBMMXQ a, NEDFHZXXODK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class TKKXOZMNEQX<a> : OAOZZKUFIDL<a> where a : notnull, MIGFTCFJVJX
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
				public TKKXOZMNEQX<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051A")]
				[Cpp2IlInjected.Address(RVA = "0x3F49DE0", Offset = "0x3F48BE0", VA = "0x183F49DE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051B")]
				[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class WCODKRWUAFT
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
					public WCODKRWUAFT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052B")]
					[Cpp2IlInjected.Address(RVA = "0x3F48AB0", Offset = "0x3F478B0", VA = "0x183F48AB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052C")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public WCODKRWUAFT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3F48E90", Offset = "0x3F47C90", VA = "0x183F48E90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public WCODKRWUAFT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3F49710", Offset = "0x3F48510", VA = "0x183F49710", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public WCODKRWUAFT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3F49AF0", Offset = "0x3F488F0", VA = "0x183F49AF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int CVPZGQUGLTT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry BDWIMQJHIFH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public TKKXOZMNEQX<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<JHOEKUEVGUO, bool> AVDGZNDSAEG;

				[Cpp2IlInjected.Token(Token = "0x6000520")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public WCODKRWUAFT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000521")]
				[Cpp2IlInjected.Address(RVA = "0x68D3010", Offset = "0x68D1E10", VA = "0x1868D3010")]
				internal bool FVEPJVMHLWG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0x68D3070", Offset = "0x68D1E70", VA = "0x1868D3070")]
				internal void FVUKBPTZOEH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				internal string FVPDEJACESY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x68D31F0", Offset = "0x68D1FF0", VA = "0x1868D31F0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.WCODKRWUAFT.<<BuildConfigMenuInternal>b__6>d))]
				internal void FWEXWDHUHAZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0x68D30E0", Offset = "0x68D1EE0", VA = "0x1868D30E0")]
				internal int FVZQYWNWXPQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x68D34C0", Offset = "0x68D22C0", VA = "0x1868D34C0")]
				internal bool JIIOBBSDXFT(JHOEKUEVGUO a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x68D32B0", Offset = "0x68D20B0", VA = "0x1868D32B0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.WCODKRWUAFT.<<BuildConfigMenuInternal>b__8>d))]
				internal void FWPLQQVOZXR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
				internal string JHSTJHKLUXS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x68D3360", Offset = "0x68D2160", VA = "0x1868D3360")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.WCODKRWUAFT.<<BuildConfigMenuInternal>b__11>d))]
				internal void JHYAGOEJEJB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0x68D3420", Offset = "0x68D2220", VA = "0x1868D3420")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.WCODKRWUAFT.<<BuildConfigMenuInternal>b__12>d))]
				internal void JIDHDUYGNUK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class ZVGRUIXYDWS
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000563")]
					[Cpp2IlInjected.Address(RVA = "0x3F42DD0", Offset = "0x3F41BD0", VA = "0x183F42DD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000564")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3F43160", Offset = "0x3F41F60", VA = "0x183F43160", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3F43530", Offset = "0x3F42330", VA = "0x183F43530", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3F43B10", Offset = "0x3F42910", VA = "0x183F43B10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3F43DA0", Offset = "0x3F42BA0", VA = "0x183F43DA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3F44130", Offset = "0x3F42F30", VA = "0x183F44130", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3F444C0", Offset = "0x3F432C0", VA = "0x183F444C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3F44750", Offset = "0x3F43550", VA = "0x183F44750", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3F44AE0", Offset = "0x3F438E0", VA = "0x183F44AE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3F44E70", Offset = "0x3F43C70", VA = "0x183F44E70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3F45200", Offset = "0x3F44000", VA = "0x183F45200", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3F45490", Offset = "0x3F44290", VA = "0x183F45490", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3F45820", Offset = "0x3F44620", VA = "0x183F45820", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3F45AB0", Offset = "0x3F448B0", VA = "0x183F45AB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3F45E40", Offset = "0x3F44C40", VA = "0x183F45E40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3F461D0", Offset = "0x3F44FD0", VA = "0x183F461D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
					public ZVGRUIXYDWS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3F46560", Offset = "0x3F45360", VA = "0x183F46560", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public TKKXOZMNEQX<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int CVPZGQUGLTT;

				[Cpp2IlInjected.Token(Token = "0x6000533")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZVGRUIXYDWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000534")]
				[Cpp2IlInjected.Address(RVA = "0x413BF20", Offset = "0x413AD20", VA = "0x18413BF20")]
				internal bool MAUGAKFUGNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0x413BEB0", Offset = "0x413ACB0", VA = "0x18413BEB0")]
				internal void MAOZDDLWXBW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x413B8D0", Offset = "0x413A6D0", VA = "0x18413B8D0")]
				internal object IAGKQRGGNHA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x413B970", Offset = "0x413A770", VA = "0x18413B970")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__13>d))]
				internal void IALRNYADWSJ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x413B520", Offset = "0x413A320", VA = "0x18413B520")]
				internal string HZAVHCQWIQY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x413B5C0", Offset = "0x413A3C0", VA = "0x18413B5C0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__15>d))]
				internal void HZGCEJKTSCH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x413B680", Offset = "0x413A480", VA = "0x18413B680")]
				internal bool HZLJBQERBNQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x413B700", Offset = "0x413A500", VA = "0x18413B700")]
				internal bool HZQPYWYOKYZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x413B3C0", Offset = "0x413A1C0", VA = "0x18413B3C0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__18>d))]
				internal void HYFTSBPGWXO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x413B470", Offset = "0x413A270", VA = "0x18413B470")]
				internal int HYLAPIJEGIX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x413B010", Offset = "0x4139E10", VA = "0x18413B010")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__20>d))]
				internal void CVIZBYDZZOH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x413AF80", Offset = "0x4139D80", VA = "0x18413AF80")]
				internal bool CVDSERKCQCY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x413B180", Offset = "0x4139F80", VA = "0x18413B180")]
				internal float CVTMWLRUSKZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x413B0C0", Offset = "0x4139EC0", VA = "0x18413B0C0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__23>d))]
				internal void CVOFZEXXIZQ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x4139BD0", Offset = "0x41389D0", VA = "0x184139BD0")]
				internal bool CUNXMXCKNUX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x41392D0", Offset = "0x41380D0", VA = "0x1841392D0")]
				internal bool CUIQPQINEJO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x413AAA0", Offset = "0x41398A0", VA = "0x18413AAA0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__26>d))]
				internal void CUYLHKQFGRP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x413A340", Offset = "0x4139140", VA = "0x18413A340")]
				internal int CUTEKDWHXGG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x413B2C0", Offset = "0x413A0C0", VA = "0x18413B2C0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__28>d))]
				internal void CWZCGAHEXBB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x413B230", Offset = "0x413A030", VA = "0x18413B230")]
				internal bool CWTVITNHNPS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x413C750", Offset = "0x413B550", VA = "0x18413C750")]
				internal float VURUDFVXJVY()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x413C7E0", Offset = "0x413B5E0", VA = "0x18413C7E0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__31>d))]
				internal void VUXBAMPUTHH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x413C640", Offset = "0x413B440", VA = "0x18413C640")]
				internal bool VUHGISICQZG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x413C6D0", Offset = "0x413B4D0", VA = "0x18413C6D0")]
				internal bool VUMNFZCAAKP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x413C9E0", Offset = "0x413B7E0", VA = "0x18413C9E0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__34>d))]
				internal void VVMVSGXMVPI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x413CA90", Offset = "0x413B890", VA = "0x18413CA90")]
				internal bool VVSCPNRKFAR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x413C8A0", Offset = "0x413B6A0", VA = "0x18413C8A0")]
				internal bool VVCHXTJSCSQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x413C930", Offset = "0x413B730", VA = "0x18413C930")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__37>d))]
				internal void VVHOVADPMDZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x413CB20", Offset = "0x413B920", VA = "0x18413CB20")]
				internal int VWHXHHZCHIS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x413CBB0", Offset = "0x413B9B0", VA = "0x18413CBB0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__39>d))]
				internal void VWNEEOSZQUB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x413C3F0", Offset = "0x413B1F0", VA = "0x18413C3F0")]
				internal bool NXUGNITELDP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x413C360", Offset = "0x413B160", VA = "0x18413C360")]
				internal float NXOZQBZHBSG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x413C2A0", Offset = "0x413B0A0", VA = "0x18413C2A0")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__42>d))]
				internal void NXJSSVFJSGX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x413C210", Offset = "0x413B010", VA = "0x18413C210")]
				internal bool NXELVOLMIVO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x413C5C0", Offset = "0x413B3C0", VA = "0x18413C5C0")]
				internal bool NYPICJUTWWZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x413C510", Offset = "0x413B310", VA = "0x18413C510")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__45>d))]
				internal void NYKBFDAWNLQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x413C480", Offset = "0x413B280", VA = "0x18413C480")]
				internal bool NYEUHWGZEAH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x413C030", Offset = "0x413AE30", VA = "0x18413C030")]
				internal bool MBETUXTOZJX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x413BF80", Offset = "0x413AD80", VA = "0x18413BF80")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__3>d))]
				internal void MAZMXQZRPYO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x413BD00", Offset = "0x413AB00", VA = "0x18413BD00")]
				internal int LZZELJEEUTV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x413BC50", Offset = "0x413AA50", VA = "0x18413BC50")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__5>d))]
				internal void LZTXOCKHLIM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x413BE20", Offset = "0x413AC20", VA = "0x18413BE20")]
				internal bool MAJSFWRZNQN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x413BD90", Offset = "0x413AB90", VA = "0x18413BD90")]
				internal bool MAELIPYCEFE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x413C160", Offset = "0x413AF60", VA = "0x18413C160")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__8>d))]
				internal void MCKJEMIZDZZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x413C0C0", Offset = "0x413AEC0", VA = "0x18413C0C0")]
				internal int MCFCHFPBUOQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x413B790", Offset = "0x413A590", VA = "0x18413B790")]
				[AsyncStateMachine(typeof(TKKXOZMNEQX<>.ZVGRUIXYDWS.<<AddConstraintOptions>b__10>d))]
				internal void HZVWWDSLUKI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x413B840", Offset = "0x413A640", VA = "0x18413B840")]
				internal bool IABDTKMJDVR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> MMTAKAMPMRJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> VKPSMHGCKFI;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000514")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<JHOEKUEVGUO> IHCTMRTUFCA
			{
				[Cpp2IlInjected.Token(Token = "0x6000515")]
				[Cpp2IlInjected.Address(RVA = "0x62244F0", Offset = "0x62232F0", VA = "0x1862244F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x6226DB0", Offset = "0x6225BB0", VA = "0x186226DB0")]
			public TKKXOZMNEQX(SQESMBBMMXQ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x6225BE0", Offset = "0x62249E0", VA = "0x186225BE0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6225DA0", Offset = "0x6224BA0", VA = "0x186225DA0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x6224540", Offset = "0x6223340", VA = "0x186224540")]
			private ZVLVZAXDPUU CVKSUABGHKJ(DWVMJQUITOW a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x6225C90", Offset = "0x6224A90", VA = "0x186225C90")]
			[AsyncStateMachine(typeof(TKKXOZMNEQX<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void KERIYDOHCZN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x6225D40", Offset = "0x6224B40", VA = "0x186225D40")]
			[CompilerGenerated]
			private bool KEWPVKIEMKW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class TPLWXBMXXQV : OAOZZKUFIDL<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class URZEQUFXAGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public TPLWXBMXXQV WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x600058A")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public URZEQUFXAGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0x2AB92C0", Offset = "0x2AB80C0", VA = "0x182AB92C0")]
				internal int FUUBPHYMSZO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9460", Offset = "0x2AB8260", VA = "0x182AB9460")]
				internal void FVJWHCGEVHP(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? XLFCDXJYKBC;

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0B70", Offset = "0x2AAF970", VA = "0x182AB0B70")]
			public TPLWXBMXXQV(SQESMBBMMXQ a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0820", Offset = "0x2AAF620", VA = "0x182AB0820", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class CZAKBHOZPRR : BNGOKRALVTA<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType YLRADNSNNPL
			{
				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3FE0", Offset = "0x2AA2DE0", VA = "0x182AA3FE0")]
			public CZAKBHOZPRR(SQESMBBMMXQ a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class TOHRALISQSA : XMXHVDDZHBA<OIWDXCSWNZH>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x2AB07C0", Offset = "0x2AAF5C0", VA = "0x182AB07C0")]
			public TOHRALISQSA(SQESMBBMMXQ a, OIWDXCSWNZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class WHYWDEGWJST : XMXHVDDZHBA<JZIVAEYCKOA>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000592")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA030", Offset = "0x2AB8E30", VA = "0x182ABA030")]
			public WHYWDEGWJST(SQESMBBMMXQ a, JZIVAEYCKOA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class IGAONZXQRAZ : GOYEQGFPMCJ<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
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
					public CEXFFSBJGFA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000599")]
					[Cpp2IlInjected.Address(RVA = "0x2AB5DC0", Offset = "0x2AB4BC0", VA = "0x182AB5DC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059A")]
					[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public IGAONZXQRAZ WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x6000597")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000598")]
				[Cpp2IlInjected.Address(RVA = "0x2AA1B90", Offset = "0x2AA0990", VA = "0x182AA1B90")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void EJIWEXPPLIG(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8510", Offset = "0x2AA7310", VA = "0x182AA8510")]
			public IGAONZXQRAZ(SQESMBBMMXQ a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8210", Offset = "0x2AA7010", VA = "0x182AA8210", Slot = "151")]
			protected override void AKQXZFHDGDA(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class DNNSMQJKHBS : BNGOKRALVTA<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType YLRADNSNNPL
			{
				[Cpp2IlInjected.Token(Token = "0x600059C")]
				[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4A20", Offset = "0x2AA3820", VA = "0x182AA4A20")]
			public DNNSMQJKHBS(SQESMBBMMXQ a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class OHMUSRSMBCN : OAOZZKUFIDL<RFAGLRXJDCP>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0xF32FB0", Offset = "0xF31DB0", VA = "0x180F32FB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9CC0", Offset = "0x2AA8AC0", VA = "0x182AA9CC0")]
			public OHMUSRSMBCN(SQESMBBMMXQ a, RFAGLRXJDCP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class VUJVIZKAHMU : OAOZZKUFIDL<GJKIEFVFCHD>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A0")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A1")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool ZROKYHLOMCB
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9FC0", Offset = "0x2AB8DC0", VA = "0x182AB9FC0")]
			public VUJVIZKAHMU(SQESMBBMMXQ a, GJKIEFVFCHD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9CB0", Offset = "0x2AB8AB0", VA = "0x182AB9CB0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9C00", Offset = "0x2AB8A00", VA = "0x182AB9C00")]
			private int SSLNLPERROC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9C40", Offset = "0x2AB8A40", VA = "0x182AB9C40")]
			private void UDOFKFDYRXU(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class XAJETNZSQBR : AMFEQOWNTBA
		{
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1110", Offset = "0x2A9FF10", VA = "0x182AA1110")]
			public XAJETNZSQBR(SQESMBBMMXQ a, FDTJOQJNBIL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class ELUNYGEOHSJ : OAOZZKUFIDL<RJKYKHXOKQS>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class ZLLAWYXLGFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public ELUNYGEOHSJ WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZLLAWYXLGFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AD")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB130", Offset = "0x2AB9F30", VA = "0x182ABB130")]
				internal int FUZIMOSKCKX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAD20", Offset = "0x2AB9B20", VA = "0x182ABAD20")]
				internal void FUUBPHYMSZO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB850", Offset = "0x2ABA650", VA = "0x182ABB850")]
				internal int FVJWHCGEVHP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2ABB410", Offset = "0x2ABA210", VA = "0x182ABB410")]
				internal void FVEPJVMHLWG(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AA")]
				[Cpp2IlInjected.Address(RVA = "0x12C42F0", Offset = "0x12C30F0", VA = "0x1812C42F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6EC0", Offset = "0x2AA5CC0", VA = "0x182AA6EC0")]
			public ELUNYGEOHSJ(SQESMBBMMXQ a, RJKYKHXOKQS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6BB0", Offset = "0x2AA59B0", VA = "0x182AA6BB0", Slot = "145")]
			protected sealed override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class GSXKFBGMMPM : GOYEQGFPMCJ<TLYQYAHIWRZ>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7920", Offset = "0x2AA6720", VA = "0x182AA7920")]
			public GSXKFBGMMPM(SQESMBBMMXQ a, TLYQYAHIWRZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class GOYEQGFPMCJ<a> : OAOZZKUFIDL<a> where a : notnull, TLYQYAHIWRZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class EIGBKFCSTWH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public GOYEQGFPMCJ<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.Token(Token = "0x60005B9")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public EIGBKFCSTWH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x495E120", Offset = "0x495CF20", VA = "0x18495E120")]
				internal bool FUZIMOSKCKX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0x495E090", Offset = "0x495CE90", VA = "0x18495E090")]
				internal void FUUBPHYMSZO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x495E1E0", Offset = "0x495CFE0", VA = "0x18495E1E0")]
				internal bool FVJWHCGEVHP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x495E150", Offset = "0x495CF50", VA = "0x18495E150")]
				internal void FVEPJVMHLWG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x495E210", Offset = "0x495D010", VA = "0x18495E210")]
				internal bool FVUKBPTZOEH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class ZRSJAVAQQNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public PCBXNHFFHWA APSKNTDSNCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public GOYEQGFPMCJ<a> WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZRSJAVAQQNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4137B70", Offset = "0x4136970", VA = "0x184137B70")]
				internal void EJIWEXPPLIG(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0xD8DD70", Offset = "0xD8CB70", VA = "0x180D8DD70", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x5186C30", Offset = "0x5185A30", VA = "0x185186C30", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x5186B20", Offset = "0x5185920", VA = "0x185186B20")]
			protected GOYEQGFPMCJ(SQESMBBMMXQ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x5186660", Offset = "0x5185460", VA = "0x185186660", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x51867A0", Offset = "0x51855A0", VA = "0x1851867A0", Slot = "145")]
			protected override void XSUWSEACOXD(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x5186370", Offset = "0x5185170", VA = "0x185186370", Slot = "151")]
			protected virtual void AKQXZFHDGDA(DWVMJQUITOW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x5186760", Offset = "0x5185560", VA = "0x185186760", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2A818B0", Offset = "0x2A806B0", VA = "0x182A818B0")]
		public static QDPJHBURBMQ New(SQESMBBMMXQ circuitsManager, FDTJOQJNBIL node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class VNVGVFFAVFS : EBFWVJZXQPI, OIEGLUSQFBX, ENFFXWRYOWP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<LQRVDHOTVET> NHBDLJHSZZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xF1B7E0", Offset = "0xF1A5E0", VA = "0x180F1B7E0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<LQRVDHOTVET>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<MEQLWUNNBJN> XKSNEOFBGBI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x1E817E0", Offset = "0x1E805E0", VA = "0x181E817E0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<MEQLWUNNBJN>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x2502300", Offset = "0x2501100", VA = "0x182502300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<OKZGLREOVOG> BPNYXPYTXUI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x143E450", Offset = "0x143D250", VA = "0x18143E450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<LZWQSLFTVFT> JOCYUAJHWYY
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AB95C0", Offset = "0x2AB83C0", VA = "0x182AB95C0", Slot = "22")]
			get
			{
				return default(Id32<LZWQSLFTVFT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9960", Offset = "0x2AB8760", VA = "0x182AB9960")]
		private VNVGVFFAVFS(SQESMBBMMXQ a, FDTJOQJNBIL b, BLWDMRQIPXD c, Id32<TDADSARCMWU> portGroupId, Id32<MEQLWUNNBJN> outputId, Id32<OKZGLREOVOG> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9610", Offset = "0x2AB8410", VA = "0x182AB9610")]
		public static VNVGVFFAVFS New(SQESMBBMMXQ circuitsManager, FDTJOQJNBIL node, BLWDMRQIPXD output, Id32<TDADSARCMWU> portGroupId, Id32<OKZGLREOVOG> outputDefId, Id32<MEQLWUNNBJN> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2502300", Offset = "0x2501100", VA = "0x182502300")]
		internal void MWPXIRCXWRK(Id32<MEQLWUNNBJN> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class EBFWVJZXQPI : ENFFXWRYOWP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private GBHGHXYKHWO? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8900", Offset = "0x2AA7700", VA = "0x182AA8900")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8910", Offset = "0x2AA7710", VA = "0x182AA8910")]
			public GBHGHXYKHWO EDBXGGLDQAQ(EBFWVJZXQPI a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly FDTJOQJNBIL RQALDJIQDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter DRYCIRYGPXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly TKGOMXLZIOR BFKLELDQLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<RMFLNFTPBXV> ATJDNIPXMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<GTRSFYTDDVP> NBMRCEMZQOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool ACSVPIRQRRW;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> CUXGYDHCDIY
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5BA0", Offset = "0x2AA49A0", VA = "0x182AA5BA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind BNPEBYZXXBX
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xADBF70", Offset = "0xADAD70", VA = "0x180ADBF70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<DINEWLJZVXU> AFDTTBFKAAA
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5F80", Offset = "0x2AA4D80", VA = "0x182AA5F80", Slot = "6")]
			get
			{
				return default(Id32<DINEWLJZVXU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<DINEWLJZVXU> DGHEMOWLZOR
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5EF0", Offset = "0x2AA4CF0", VA = "0x182AA5EF0", Slot = "7")]
			get
			{
				return default(Id128<DINEWLJZVXU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public JHOEKUEVGUO IQAAZAHDLWD
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4A80", Offset = "0x2AA3880", VA = "0x182AA4A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public JFUKTDYQATS YAVEQUGEZHG
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4AA0", Offset = "0x2AA38A0", VA = "0x182AA4AA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected GBHGHXYKHWO FENFLIBUTPF
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4AA0", Offset = "0x2AA38A0", VA = "0x182AA4AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage OPNMLEMHHQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4C10", Offset = "0x2AA3A10", VA = "0x182AA4C10", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<KSHTGNRFKHE> AFJBZURQZRD
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AA58C0", Offset = "0x2AA46C0", VA = "0x182AA58C0", Slot = "9")]
			get
			{
				return default(Id128<KSHTGNRFKHE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<TDADSARCMWU> JRKQDRERMPA
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xECA790", Offset = "0xEC9590", VA = "0x180ECA790", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<TDADSARCMWU>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D0D0", Offset = "0x1A8BED0", VA = "0x181A8D0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<LZWQSLFTVFT> JOCYUAJHWYY
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool KVUFHVTKYKV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xF7B8E0", Offset = "0xF7A6E0", VA = "0x180F7B8E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA62F0", Offset = "0x2AA50F0", VA = "0x182AA62F0")]
		protected EBFWVJZXQPI(SQESMBBMMXQ a, FDTJOQJNBIL b, TKGOMXLZIOR c, Id32<TDADSARCMWU> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA57E0", Offset = "0x2AA45E0", VA = "0x182AA57E0", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4B30", Offset = "0x2AA3930", VA = "0x182AA4B30", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4D50", Offset = "0x2AA3B50", VA = "0x182AA4D50", Slot = "14")]
		public void EUBTBGSTSFI(RMFLNFTPBXV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5A90", Offset = "0x2AA4890", VA = "0x182AA5A90", Slot = "15")]
		public void KVKPZVZTMTC(GTRSFYTDDVP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5FD0", Offset = "0x2AA4DD0", VA = "0x182AA5FD0")]
		private bool ZOAMSQUWWOT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4E00", Offset = "0x2AA3C00", VA = "0x182AA4E00", Slot = "17")]
		public void HLKYSWZOOYY(LJAXFGDMSRT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5CE0", Offset = "0x2AA4AE0", VA = "0x182AA5CE0", Slot = "25")]
		protected virtual void RLGXQXWRSYO(LJAXFGDMSRT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5650", Offset = "0x2AA4450", VA = "0x182AA5650", Slot = "20")]
		private void IELCRYYMBCF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5D40", Offset = "0x2AA4B40", VA = "0x182AA5D40")]
		private void RVUKDNKPLNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA58E0", Offset = "0x2AA46E0", VA = "0x182AA58E0")]
		private void KNJHRDVWKMS([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5F20", Offset = "0x2AA4D20", VA = "0x182AA5F20", Slot = "18")]
		public void SRUPLLBVPBB(RMFLNFTPBXV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5B40", Offset = "0x2AA4940", VA = "0x182AA5B40", Slot = "19")]
		public void KZQFFGAHJRH(GTRSFYTDDVP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
		internal void CHJZRNKGJMC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5FB0", Offset = "0x2AA4DB0", VA = "0x182AA5FB0")]
		internal void YOTEBWTWDKV(KLWLFKHUOPD a, JHOEKUEVGUO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D0D0", Offset = "0x1A8BED0", VA = "0x181A8D0D0")]
		internal void CFOOOMOJBPS(Id32<TDADSARCMWU> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class SGKRYXEZWIF : NXDEFHNCTOS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class XSSHNVXEYLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public SQESMBBMMXQ WJIRMVPJVZQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public FDTJOQJNBIL VLIWURBHSIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<TDADSARCMWU> AJZTYKAPHUC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool NQMJWBNVUQZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool XPSVXGGUFHI;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public XSSHNVXEYLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA160", Offset = "0x2AB8F60", VA = "0x182ABA160")]
			internal VTTOXVMBUGL AHLCPYFTAFT((int PortDescIndex, int PortIndex, QQLEQPIAOLA InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA090", Offset = "0x2AB8E90", VA = "0x182ABA090")]
			internal VNVGVFFAVFS AHFVSRLVQUK(BLWDMRQIPXD a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1660", Offset = "0x2AB0460", VA = "0x182AB1660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1AD0", Offset = "0x2AB08D0", VA = "0x182AB1AD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<LJLJBSUERVT> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB2D90", Offset = "0x2AB1B90", VA = "0x182AB2D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB30E0", Offset = "0x2AB1EE0", VA = "0x182AB30E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3150", Offset = "0x2AB1F50", VA = "0x182AB3150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB35D0", Offset = "0x2AB23D0", VA = "0x182AB35D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<OKZGLREOVOG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3640", Offset = "0x2AB2440", VA = "0x182AB3640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3990", Offset = "0x2AB2790", VA = "0x182AB3990", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2AB41C0", Offset = "0x2AB2FC0", VA = "0x182AB41C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4510", Offset = "0x2AB3310", VA = "0x182AB4510", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<LJLJBSUERVT> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3A00", Offset = "0x2AB2800", VA = "0x182AB3A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3D70", Offset = "0x2AB2B70", VA = "0x182AB3D70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<OKZGLREOVOG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3DE0", Offset = "0x2AB2BE0", VA = "0x182AB3DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4150", Offset = "0x2AB2F50", VA = "0x182AB4150", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public BYYXKEXKPED type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<LJLJBSUERVT> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4580", Offset = "0x2AB3380", VA = "0x182AB4580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4920", Offset = "0x2AB3720", VA = "0x182AB4920", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public BYYXKEXKPED type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<OKZGLREOVOG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4990", Offset = "0x2AB3790", VA = "0x182AB4990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4D30", Offset = "0x2AB3B30", VA = "0x182AB4D30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<LJLJBSUERVT> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<LJLJBSUERVT> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4DA0", Offset = "0x2AB3BA0", VA = "0x182AB4DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5100", Offset = "0x2AB3F00", VA = "0x182AB5100", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public SGKRYXEZWIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<OKZGLREOVOG> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<OKZGLREOVOG> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private EMOXSDWCFKN <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5170", Offset = "0x2AB3F70", VA = "0x182AB5170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB54D0", Offset = "0x2AB42D0", VA = "0x182AB54D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool OHEPXBIEFRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool UIVLQJBXHZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<TAGQJDWMKQY, VTTOXVMBUGL> VSPSDZTLPMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<TAGQJDWMKQY, EEQNEYOCGVS> PMRDNFTNUDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly FDTJOQJNBIL RQALDJIQDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<MEQLWUNNBJN, VNVGVFFAVFS> ZHDOIKDDNUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<MEQLWUNNBJN, OIEGLUSQFBX> HNFKRHSSLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? HKEMMXSZAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly WDXMACYERUS ZPPTRBSBXDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<TDADSARCMWU> VIVRGRTQKXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool QRLVPRAAPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? ISBBSBIQTZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? WRTVVRBCTRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<TAGQJDWMKQY>>? BUNSVSGWLQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<MEQLWUNNBJN>>? JHNPXKQEHSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private NXDEFHNCTOS.PortGroupIdChangeDelegate? VNVINVNVGWL;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool FZJOJSNVDUX
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF810", Offset = "0x2AAE610", VA = "0x182AAF810", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool WGDDKQIJYDW
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0220", Offset = "0x2AAF020", VA = "0x182AB0220", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool WDYZSXGNDUW
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AABF60", Offset = "0x2AAAD60", VA = "0x182AABF60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<DINEWLJZVXU> DGHEMOWLZOR
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEFC0", Offset = "0x2AADDC0", VA = "0x182AAEFC0", Slot = "7")]
			get
			{
				return default(Id128<DINEWLJZVXU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool DOGSKXOUBUA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD6E0", Offset = "0x2AAC4E0", VA = "0x182AAD6E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<TAGQJDWMKQY, EEQNEYOCGVS> BLDAZTQDASG
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<TAGQJDWMKQY, EEQNEYOCGVS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2AAED30", Offset = "0x2AADB30", VA = "0x182AAED30", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<KSHTGNRFKHE> AFJBZURQZRD
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x2AADBD0", Offset = "0x2AAC9D0", VA = "0x182AADBD0", Slot = "11")]
			get
			{
				return default(Id128<KSHTGNRFKHE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<MEQLWUNNBJN, OIEGLUSQFBX> PAHPBXBPTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<MEQLWUNNBJN, OIEGLUSQFBX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<TDADSARCMWU> JRKQDRERMPA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xC4F9C0", Offset = "0xC4E7C0", VA = "0x180C4F9C0", Slot = "13")]
			get
			{
				return default(Id32<TDADSARCMWU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? HZSUTERKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD640", Offset = "0x2AAC440", VA = "0x182AAD640", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AAB970", Offset = "0x2AAA770", VA = "0x182AAB970", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? OYPXUPYBACT
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEC80", Offset = "0x2AADA80", VA = "0x182AAEC80", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEFF0", Offset = "0x2AADDF0", VA = "0x182AAEFF0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<TAGQJDWMKQY?>, Id32<TAGQJDWMKQY?>>? OFMWSQWECDW
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD580", Offset = "0x2AAC380", VA = "0x182AAD580", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF9E0", Offset = "0x2AAE7E0", VA = "0x182AAF9E0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<TAGQJDWMKQY?>, Id32<TAGQJDWMKQY?>>? JLOBSZSISHT
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD1D0", Offset = "0x2AABFD0", VA = "0x182AAD1D0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD0F0", Offset = "0x2AABEF0", VA = "0x182AAD0F0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<MEQLWUNNBJN?>, Id32<MEQLWUNNBJN?>>? RFHKNXDBVOT
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0380", Offset = "0x2AAF180", VA = "0x182AB0380", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD430", Offset = "0x2AAC230", VA = "0x182AAD430", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<MEQLWUNNBJN?>, Id32<MEQLWUNNBJN?>>? COECPNFBFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFAA0", Offset = "0x2AAE8A0", VA = "0x182AAFAA0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF1C0", Offset = "0x2AADFC0", VA = "0x182AAF1C0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<TAGQJDWMKQY?>, EEQNEYOCGVS?>? QCRLJCLUWOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2AACE40", Offset = "0x2AABC40", VA = "0x182AACE40", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD350", Offset = "0x2AAC150", VA = "0x182AAD350", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<TAGQJDWMKQY?>>? MXSLAHVBPZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2AADE30", Offset = "0x2AACC30", VA = "0x182AADE30", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEEE0", Offset = "0x2AADCE0", VA = "0x182AAEEE0", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<TAGQJDWMKQY?>, EEQNEYOCGVS?>? NXXJHQBZFVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEBC0", Offset = "0x2AAD9C0", VA = "0x182AAEBC0", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF510", Offset = "0x2AAE310", VA = "0x182AAF510", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<MEQLWUNNBJN?>, OIEGLUSQFBX?>? ISCVGJJLJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2AAED60", Offset = "0x2AADB60", VA = "0x182AAED60", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEE20", Offset = "0x2AADC20", VA = "0x182AAEE20", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<MEQLWUNNBJN?>>? JCVBTMZBYXP
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2AABDE0", Offset = "0x2AAABE0", VA = "0x182AABDE0", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2AACF00", Offset = "0x2AABD00", VA = "0x182AACF00", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<MEQLWUNNBJN?>, OIEGLUSQFBX?>? KVILGRQCHBS
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD290", Offset = "0x2AAC090", VA = "0x182AAD290", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2AABEA0", Offset = "0x2AAACA0", VA = "0x182AABEA0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0440", Offset = "0x2AAF240", VA = "0x182AB0440")]
		private SGKRYXEZWIF(bool a, SQESMBBMMXQ b, bool c, ReadOnlyIdArray<TAGQJDWMKQY, VTTOXVMBUGL> inputs, ReadOnlyIdArray<TAGQJDWMKQY, EEQNEYOCGVS> inputsAsStaticInputs, FDTJOQJNBIL d, ReadOnlyIdArray<MEQLWUNNBJN, VNVGVFFAVFS> outputs, ReadOnlyIdArray<MEQLWUNNBJN, OIEGLUSQFBX> outputsAsStaticOutputs, string? overrideName, WDXMACYERUS e, Id32<TDADSARCMWU> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE3D0", Offset = "0x2AAD1D0", VA = "0x182AAE3D0")]
		public static SGKRYXEZWIF New(bool canInteract, SQESMBBMMXQ circuitsManager, bool hasFunctionHeader, FDTJOQJNBIL node, WDXMACYERUS portGroup, Id32<TDADSARCMWU> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2AACAA0", Offset = "0x2AAB8A0", VA = "0x182AACAA0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB880", Offset = "0x2AAA680", VA = "0x182AAB880", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, IGWAJAWUKJF?>>? BLZRWQFNZIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB280", Offset = "0x2AAA080", VA = "0x182AAB280")]
		private (BMZPZYIDITK?, int)? AKTMRLREODT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF8D0", Offset = "0x2AAE6D0", VA = "0x182AAF8D0", Slot = "58")]
		private void XGSBIOPJTJR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x24E0DA0", Offset = "0x24DFBA0", VA = "0x1824E0DA0", Slot = "57")]
		private void WIQTSMGPCDA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE000", Offset = "0x2AACE00", VA = "0x182AAE000", Slot = "61")]
		private void LPYVZUYXYDW(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2AACA10", Offset = "0x2AAB810", VA = "0x182AACA10", Slot = "63")]
		private void DVCWUNWPYIX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFB60", Offset = "0x2AAE960", VA = "0x182AAFB60", Slot = "50")]
		private void YPXPVFYZLZQ(int a, Id32<TAGQJDWMKQY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEFA0", Offset = "0x2AADDA0", VA = "0x182AAEFA0", Slot = "54")]
		private void RXRGIWAAWRV(int a, Id32<TAGQJDWMKQY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2AADEF0", Offset = "0x2AACCF0", VA = "0x182AADEF0", Slot = "49")]
		private void LFWNPYCLOMF(int a, Id32<TAGQJDWMKQY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC5C0", Offset = "0x2AAB3C0", VA = "0x182AAC5C0", Slot = "53")]
		private void DTIZMBVXKIK(int a, Id32<TAGQJDWMKQY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE920", Offset = "0x2AAD720", VA = "0x182AAE920", Slot = "66")]
		private void OBUSLHTNJBW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x10F47A0", Offset = "0x10F35A0", VA = "0x1810F47A0", Slot = "65")]
		private void SPZYCVQEWBT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0110", Offset = "0x2AAEF10", VA = "0x182AB0110", Slot = "60")]
		private void YTGWBGDKVTI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x24E0DA0", Offset = "0x24DFBA0", VA = "0x1824E0DA0", Slot = "59")]
		private void BUNARUVDVXL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB4B0", Offset = "0x2AAA2B0", VA = "0x182AAB4B0", Slot = "62")]
		private void AVARNXHYDLJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD4F0", Offset = "0x2AAC2F0", VA = "0x182AAD4F0", Slot = "64")]
		private void HYJRKAUAUXQ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC020", Offset = "0x2AAAE20", VA = "0x182AAC020", Slot = "52")]
		private void DKCOKAJOCDH(int a, Id32<MEQLWUNNBJN> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD410", Offset = "0x2AAC210", VA = "0x182AAD410", Slot = "56")]
		private void HRCZEYNLBFM(int a, Id32<MEQLWUNNBJN> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD1B0", Offset = "0x2AABFB0", VA = "0x182AAD1B0", Slot = "51")]
		private void EYELASUMWWY(int a, Id32<MEQLWUNNBJN> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD760", Offset = "0x2AAC560", VA = "0x182AAD760", Slot = "55")]
		private void JEPZPOXVXUJ(int a, Id32<MEQLWUNNBJN> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF3A0", Offset = "0x2AAE1A0", VA = "0x182AAF3A0", Slot = "68")]
		private void UTXKODIYFRL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x10F47A0", Offset = "0x10F35A0", VA = "0x1810F47A0", Slot = "67")]
		private void YHLRPUJRJCO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF700", Offset = "0x2AAE500", VA = "0x182AAF700", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, IGWAJAWUKJF?>>? VYNUCDZCAAQ(Id32<LJLJBSUERVT> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x2AADD20", Offset = "0x2AACB20", VA = "0x182AADD20", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, IGWAJAWUKJF?>>? KSMLJUNKBNX(Id32<OKZGLREOVOG> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF280", Offset = "0x2AAE080", VA = "0x182AAF280", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, IGWAJAWUKJF?>>? UGWHGGDOYTI(Id32<LJLJBSUERVT> inputDefId, Id32<LJLJBSUERVT> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF0A0", Offset = "0x2AADEA0", VA = "0x182AAF0A0", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, IGWAJAWUKJF?>>? TMROEVEGUON(Id32<OKZGLREOVOG> outputDefId, Id32<OKZGLREOVOG> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2AADF10", Offset = "0x2AACD10", VA = "0x182AADF10", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, IGWAJAWUKJF?>>? LLYQLGRRWJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0260", Offset = "0x2AAF060", VA = "0x182AB0260", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, IGWAJAWUKJF>> ZKOQTMIJORT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEA90", Offset = "0x2AAD890", VA = "0x182AAEA90", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, IGWAJAWUKJF>> OGYDRYNZOUK(Id32<LJLJBSUERVT> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2AACFC0", Offset = "0x2AABDC0", VA = "0x182AACFC0", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, IGWAJAWUKJF>> ENFFSBGMTSD(Id32<OKZGLREOVOG> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF5D0", Offset = "0x2AAE3D0", VA = "0x182AAF5D0", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, IGWAJAWUKJF>> VUPCDOIKZKB(Id32<LJLJBSUERVT> inputDefId, BYYXKEXKPED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2AADBF0", Offset = "0x2AAC9F0", VA = "0x182AADBF0", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, IGWAJAWUKJF>> KAUVWOUKVRY(Id32<OKZGLREOVOG> outputDefId, BYYXKEXKPED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2AABA10", Offset = "0x2AAA810", VA = "0x182AABA10")]
		internal void CFOOOMOJBPS(Id32<TDADSARCMWU> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class TJDAFASHBMR : YOFTFORYWYQ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface ZLOMSCLYJNW
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<DINEWLJZVXU>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065D")]
				[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<DINEWLJZVXU>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			KLWLFKHUOPD KLWLFKHUOPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> EDSKYKCEVZE(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> XWKBEBJDVXT(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<OMPJFSIDVZF> TQJQNJPYCEO(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<MMCRDVBAEMD> RNCYVNNSMAT(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> VYUXAAZINPC(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> MPQBQBQSXSH(CancellationToken a);
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
			public AsyncTaskMethodBuilder<TJDAFASHBMR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public SQESMBBMMXQ circuitsManager;

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
			private ZLOMSCLYJNW <selfDeps>5__2;

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
			private OMPJFSIDVZF <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private MMCRDVBAEMD <playerSaveData>5__8;

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
			private TaskAwaiter<OMPJFSIDVZF> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<MMCRDVBAEMD> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<ZLOMSCLYJNW.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<QCQTPBNJHXP> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1B40", Offset = "0x2AB0940", VA = "0x182AB1B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB2D20", Offset = "0x2AB1B20", VA = "0x182AB2D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public QCQTPBNJHXP QCQTPBNJHXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public ELGZDWCPQNL ELGZDWCPQNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public TFLSPKGBAAO TFLSPKGBAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public VHVTYYKGQWO VHVTYYKGQWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x111AC60", Offset = "0x1119A60", VA = "0x18111AC60")]
		private TJDAFASHBMR(QCQTPBNJHXP a, ELGZDWCPQNL b, TFLSPKGBAAO c, VHVTYYKGQWO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0650", Offset = "0x2AAF450", VA = "0x182AB0650")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<TJDAFASHBMR> WPPYIAFLPGO(SQESMBBMMXQ a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0630", Offset = "0x2AAF430", VA = "0x182AB0630", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class FUCJYBVUJEN : OHNNIEAVYVG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public AOCWOPNIZIH? GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2AA72B0", Offset = "0x2AA60B0", VA = "0x182AA72B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		internal FUCJYBVUJEN(SQESMBBMMXQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class TFLSPKGBAAO : AOCWOPNIZIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly QCQTPBNJHXP DDZJRTGYFSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly FUCJYBVUJEN TLZVZBGFNRE;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> KVTXWYSXQXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x2AB05A0", Offset = "0x2AAF3A0", VA = "0x182AB05A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xDF2D50", Offset = "0xDF1B50", VA = "0x180DF2D50")]
		public TFLSPKGBAAO(SQESMBBMMXQ a, QCQTPBNJHXP b, FUCJYBVUJEN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2AB05E0", Offset = "0x2AAF3E0", VA = "0x182AB05E0", Slot = "5")]
		public string YJMCUNZYZGY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0540", Offset = "0x2AAF340", VA = "0x182AB0540", Slot = "6")]
		public void JZVVEUOVVSL(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC33E0", Offset = "0x2AC21E0", VA = "0x182AC33E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3620", Offset = "0x2AC2420", VA = "0x182AC3620", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, IGWAJAWUKJF>> <>t__builder;

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
			private TWGQWHZWPAR[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3E40", Offset = "0x2AC2C40", VA = "0x182AC3E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4210", Offset = "0x2AC3010", VA = "0x182AC4210", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public TWGQWHZWPAR action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8540", Offset = "0x2AC7340", VA = "0x182AC8540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8950", Offset = "0x2AC7750", VA = "0x182AC8950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly EGZVYBEHFSY _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		public EVRequestExtended(EGZVYBEHFSY staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7180", Offset = "0x2AA5F80", VA = "0x182AA7180")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, IGWAJAWUKJF>> OBLLNKKDQTC(TWGQWHZWPAR a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6F30", Offset = "0x2AA5D30", VA = "0x182AA6F30")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, IGWAJAWUKJF?>>? AQEUGSJOIZB(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7090", Offset = "0x2AA5E90", VA = "0x182AA7090")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, IGWAJAWUKJF>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface AYIPZYLYXPE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		YOFTFORYWYQ? GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool FCGOGSZXJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<YOFTFORYWYQ?>? OQZOHOBIURI();

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task XLUTMZIGPVJ(SQESMBBMMXQ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface YOFTFORYWYQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		QCQTPBNJHXP QCQTPBNJHXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		ELGZDWCPQNL ELGZDWCPQNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		TFLSPKGBAAO TFLSPKGBAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		VHVTYYKGQWO VHVTYYKGQWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class RIDDXRGCGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2AC27E0", Offset = "0x2AC15E0", VA = "0x182AC27E0")]
		public static ReducerFactory<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>> CTJSEFFEZBW([In] this ReducerFactory<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class FTRIKGTBENM : OSTVCSSHBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool FCGOGSZXJEF
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x2ABCD00", Offset = "0x2ABBB00", VA = "0x182ABCD00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		internal FTRIKGTBENM(SQESMBBMMXQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class JWQZMAHNKYL : XGPBBHKGHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF8D0", Offset = "0x2ABE6D0", VA = "0x182ABF8D0", Slot = "4")]
		public FWYTGAMZWCC? QHHQICOMPHT(string? a, string? b, string? c, RoomDoorData.NGCTHUAORUY.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF960", Offset = "0x2ABE760", VA = "0x182ABF960", Slot = "5")]
		public BAMCXBOUDGE XBYWIBYTLDT(string a, string b, List<string> c, int d, int e, int f, int g, HBJXYDZTNRI h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF830", Offset = "0x2ABE630", VA = "0x182ABF830", Slot = "6")]
		public HBJXYDZTNRI KWHXNNEMNYN(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public JWQZMAHNKYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class GZDOLFCVQSB : KDAJBBLLCEQ
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
			public AsyncTaskMethodBuilder<LCNHFLDFADN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public GZDOLFCVQSB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<YOFTFORYWYQ?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3690", Offset = "0x2AC2490", VA = "0x182AC3690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3940", Offset = "0x2AC2740", VA = "0x182AC3940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public LCNHFLDFADN? GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEC20", Offset = "0x2ABDA20", VA = "0x182ABEC20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public VHVTYYKGQWO? CXLVLYGALIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEE80", Offset = "0x2ABDC80", VA = "0x182ABEE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool OYTSACCQTWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF570", Offset = "0x2ABE370", VA = "0x182ABF570", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool QUVKJCQIMJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2ABECA0", Offset = "0x2ABDAA0", VA = "0x182ABECA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF5D0", Offset = "0x2ABE3D0", VA = "0x182ABF5D0")]
		internal GZDOLFCVQSB(SQESMBBMMXQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF100", Offset = "0x2ABDF00", VA = "0x182ABF100", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<LCNHFLDFADN> OQZOHOBIURI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF1F0", Offset = "0x2ABDFF0", VA = "0x182ABF1F0", Slot = "9")]
		public IReadOnlyDictionary<Id128<DINEWLJZVXU>, Guid> TDESERELKAI(IEnumerable<LZGZZRSUFGL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2ABED00", Offset = "0x2ABDB00", VA = "0x182ABED00", Slot = "10")]
		public CircuitGraphToolMappingRegistryData CTQZZNUNNVA(IEnumerable<LZGZZRSUFGL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEF30", Offset = "0x2ABDD30", VA = "0x182ABEF30")]
		public Result<CircuitsRoomData, XDRQUNZRUHP> LSIEMSIXFUW([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, XDRQUNZRUHP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEF00", Offset = "0x2ABDD00", VA = "0x182ABEF00", Slot = "8")]
		private Result<CircuitsRoomData, XDRQUNZRUHP> IAVEVBCDGFF([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, XDRQUNZRUHP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class VHVTYYKGQWO : LCNHFLDFADN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class QCOYNQONDXH
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int XSNOKFPXAYG;

				[Cpp2IlInjected.Token(Token = "0x6000716")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x2ABC970", Offset = "0x2ABB770", VA = "0x182ABC970")]
				internal void DKLLURBBZVF(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC15D0", Offset = "0x2AC03D0", VA = "0x182AC15D0")]
			public static Result<LCNHFLDFADN.PrepareTemplateForCloneResult, DAXFGKUQCIS> SMBNSVPWLRK(VHVTYYKGQWO a, [In] LCNHFLDFADN.PrepareTemplateForCloneArgs args)
			{
				return default(Result<LCNHFLDFADN.PrepareTemplateForCloneResult, DAXFGKUQCIS>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x2ABFFF0", Offset = "0x2ABEDF0", VA = "0x182ABFFF0")]
			internal static Result<(VPINFVQPFLR, CircuitTemplateRootData), DAXFGKUQCIS> AASEBKLNIDU(VHVTYYKGQWO a, CircuitTemplateRootData b, bool c, [In] Id128<DINEWLJZVXU> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(VPINFVQPFLR, CircuitTemplateRootData), DAXFGKUQCIS>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1130", Offset = "0x2ABFF30", VA = "0x182AC1130")]
			private static void FUTOIWQKIUE(bool a, LZGZZRSUFGL b, VPINFVQPFLR c, [In] Id128<DINEWLJZVXU> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0D20", Offset = "0x2ABFB20", VA = "0x182AC0D20")]
			public static void BNKDXRQMVZD(YWKRMCXBOWC a, [In] LCNHFLDFADN.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1AE0", Offset = "0x2AC08E0", VA = "0x182AC1AE0")]
			[CompilerGenerated]
			internal static bool URCQBOMEKRK(QCQTPBNJHXP a, QNLBMLMRCBE b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2070", Offset = "0x2AC0E70", VA = "0x182AC2070")]
			[CompilerGenerated]
			internal static bool ZVAEIOZZTFD(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class HBQWEJNAGJX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public VHVTYYKGQWO WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<DINEWLJZVXU> WMENVSJZXYT;

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public HBQWEJNAGJX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF7A0", Offset = "0x2ABE5A0", VA = "0x182ABF7A0")]
			internal Id128<KSHTGNRFKHE> BCODAECJMRK(Id32<KSHTGNRFKHE> a)
			{
				return default(Id128<KSHTGNRFKHE>);
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<LQRVDHOTVET> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<UTWGPDLERGC> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4280", Offset = "0x2AC3080", VA = "0x182AC4280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4850", Offset = "0x2AC3650", VA = "0x182AC4850", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<TDADSARCMWU> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<LJLJBSUERVT> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC48C0", Offset = "0x2AC36C0", VA = "0x182AC48C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4C10", Offset = "0x2AC3A10", VA = "0x182AC4C10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<KSHTGNRFKHE>, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<KUBDOTYWEDD> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private QCQTPBNJHXP <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4F60", Offset = "0x2AC3D60", VA = "0x182AC4F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5390", Offset = "0x2AC4190", VA = "0x182AC5390", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4C80", Offset = "0x2AC3A80", VA = "0x182AC4C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4EF0", Offset = "0x2AC3CF0", VA = "0x182AC4EF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5400", Offset = "0x2AC4200", VA = "0x182AC5400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2AC55F0", Offset = "0x2AC43F0", VA = "0x182AC55F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<DINEWLJZVXU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<KSHTGNRFKHE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<KSHTGNRFKHE>> nodeIds;

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
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5660", Offset = "0x2AC4460", VA = "0x182AC5660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5900", Offset = "0x2AC4700", VA = "0x182AC5900", Slot = "5")]
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
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<DINEWLJZVXU> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<KSHTGNRFKHE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<KSHTGNRFKHE>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<TDADSARCMWU>, Id32<TAGQJDWMKQY>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<TDADSARCMWU>, Id32<MEQLWUNNBJN>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5970", Offset = "0x2AC4770", VA = "0x182AC5970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5F50", Offset = "0x2AC4D50", VA = "0x182AC5F50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<DINEWLJZVXU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<KSHTGNRFKHE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<KSHTGNRFKHE>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5FB0", Offset = "0x2AC4DB0", VA = "0x182AC5FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC61C0", Offset = "0x2AC4FC0", VA = "0x182AC61C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<KSHTGNRFKHE> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<TDADSARCMWU> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<TAGQJDWMKQY> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6230", Offset = "0x2AC5030", VA = "0x182AC6230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6580", Offset = "0x2AC5380", VA = "0x182AC6580", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<TDADSARCMWU> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<LJLJBSUERVT> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC65F0", Offset = "0x2AC53F0", VA = "0x182AC65F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2AC69D0", Offset = "0x2AC57D0", VA = "0x182AC69D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6A40", Offset = "0x2AC5840", VA = "0x182AC6A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6CC0", Offset = "0x2AC5AC0", VA = "0x182AC6CC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<KSHTGNRFKHE> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<TDADSARCMWU> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<MEQLWUNNBJN> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6D30", Offset = "0x2AC5B30", VA = "0x182AC6D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7080", Offset = "0x2AC5E80", VA = "0x182AC7080", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2AC70F0", Offset = "0x2AC5EF0", VA = "0x182AC70F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7430", Offset = "0x2AC6230", VA = "0x182AC7430", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2AC74A0", Offset = "0x2AC62A0", VA = "0x182AC74A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7730", Offset = "0x2AC6530", VA = "0x182AC7730", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2AC77A0", Offset = "0x2AC65A0", VA = "0x182AC77A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7A30", Offset = "0x2AC6830", VA = "0x182AC7A30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<KSHTGNRFKHE>>, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<DINEWLJZVXU> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<LZGZZRSUFGL> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<FDTJOQJNBIL>, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7AA0", Offset = "0x2AC68A0", VA = "0x182AC7AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8240", Offset = "0x2AC7040", VA = "0x182AC8240", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<DINEWLJZVXU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<KSHTGNRFKHE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<KSHTGNRFKHE>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC82B0", Offset = "0x2AC70B0", VA = "0x182AC82B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC84D0", Offset = "0x2AC72D0", VA = "0x182AC84D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public VHVTYYKGQWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<DINEWLJZVXU> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<KSHTGNRFKHE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8A30", Offset = "0x2AC7830", VA = "0x182AC8A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8C50", Offset = "0x2AC7A50", VA = "0x182AC8C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly SQESMBBMMXQ BLMNABJGIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly QCQTPBNJHXP DDZJRTGYFSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers KWMNRUOXVKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly GZDOLFCVQSB ESWAFTZZJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<KSHTGNRFKHE>, QDPJHBURBMQ> GYNYYIQDNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<KSHTGNRFKHE>>? HLMIEIKIFFC;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<DINEWLJZVXU> TZLPNXUTJPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD070", Offset = "0x2ACBE70", VA = "0x182ACD070", Slot = "4")]
			get
			{
				return default(Id128<DINEWLJZVXU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers SMOFBJJWFRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD090", Offset = "0x2ACBE90", VA = "0x182ACD090", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> MRGAPHIXAAH
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD440", Offset = "0x2ACC240", VA = "0x182ACD440", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action JLDBJFJJIEG
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD320", Offset = "0x2ACC120", VA = "0x182ACD320", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2ACBE00", Offset = "0x2ACAC00", VA = "0x182ACBE00", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> HKXJPXLMVIO
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2ACC230", Offset = "0x2ACB030", VA = "0x182ACC230", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2AC99A0", Offset = "0x2AC87A0", VA = "0x182AC99A0", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0800", Offset = "0x2ACF600", VA = "0x182AD0800")]
		public VHVTYYKGQWO(SQESMBBMMXQ a, QCQTPBNJHXP b, GZDOLFCVQSB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA940", Offset = "0x2AC9740", VA = "0x182ACA940", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCEB0", Offset = "0x2ACBCB0", VA = "0x182ACCEB0", Slot = "100")]
		public Id32<AHQFLUVQZVQ> MCIDHPRIION(Id32<DINEWLJZVXU> graphId, Id32<UTWGPDLERGC> inputId)
		{
			return default(Id32<AHQFLUVQZVQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE680", Offset = "0x2ACD480", VA = "0x182ACE680", Slot = "101")]
		public Id32<VCUZDXNTYTX> SVYIYKJWFXO(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> outputId)
		{
			return default(Id32<VCUZDXNTYTX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE8E0", Offset = "0x2ACD6E0", VA = "0x182ACE8E0", Slot = "6")]
		public (bool, bool) UJINPKKMXQD(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> srcId, Id32<UTWGPDLERGC> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD460", Offset = "0x2ACC260", VA = "0x182ACD460")]
		public bool PVJLOADPECK(Id32<DINEWLJZVXU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEEA0", Offset = "0x2ACDCA0", VA = "0x182ACEEA0", Slot = "8")]
		public bool UUTMMWEXEIM(EEQNEYOCGVS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBB60", Offset = "0x2ACA960", VA = "0x182ACBB60", Slot = "9")]
		public bool JGZGFCAIGZJ(OIEGLUSQFBX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC93D0", Offset = "0x2AC81D0", VA = "0x182AC93D0", Slot = "10")]
		public AbsoluteLegacyInputId? BAKVRSPBEZG(Id32<DINEWLJZVXU> graphId, Id32<UTWGPDLERGC> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC070", Offset = "0x2ACAE70", VA = "0x182ACC070", Slot = "11")]
		public AbsoluteLegacyOutputId? KFDDHVGLKWD(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEF50", Offset = "0x2ACDD50", VA = "0x182ACEF50", Slot = "12")]
		public Id32<LQRVDHOTVET>? VINNYMAMSJD(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<MEQLWUNNBJN> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC91C0", Offset = "0x2AC7FC0", VA = "0x182AC91C0", Slot = "13")]
		public Id32<UTWGPDLERGC>? AEHWJOBKPDQ(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<TAGQJDWMKQY> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD150", Offset = "0x2ACBF50", VA = "0x182ACD150", Slot = "14")]
		public IEnumerable<Id32<DINEWLJZVXU>> NWEPPRCACZU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB570", Offset = "0x2ACA370", VA = "0x182ACB570", Slot = "15")]
		public IEnumerable<Id32<QNBOJXRXLEO>> HSQMOXBRWUZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBCB0", Offset = "0x2ACAAB0", VA = "0x182ACBCB0", Slot = "22")]
		public string JMOQGOHMQFP(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDD20", Offset = "0x2ACCB20", VA = "0x182ACDD20", Slot = "16")]
		public Id32<QNBOJXRXLEO>? QRAGVGYQYDZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD0A0", Offset = "0x2ACBEA0", VA = "0x182ACD0A0", Slot = "17")]
		public int NICUEUHLRCS(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD420", Offset = "0x2ACC220", VA = "0x182ACD420", Slot = "18")]
		public int PMYYEZXWDXB(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9450", Offset = "0x2AC8250", VA = "0x182AC9450", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] BEZMRCSZUKE(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD010", Offset = "0x2ACBE10", VA = "0x182ACD010", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] MXMWBTXQSTX(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E72EF0", Offset = "0x3E71CF0", VA = "0x183E72EF0")]
		private static (CircuitTypeIdWrapper, string?)[]? IUCPUQKXTOW<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC98D0", Offset = "0x2AC86D0", VA = "0x182AC98D0", Slot = "21")]
		public string CLPONLIHMQX(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEF80", Offset = "0x2ACDD80", VA = "0x182ACEF80", Slot = "23")]
		public string VNTNNRWBKJU(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB600", Offset = "0x2ACA400", VA = "0x182ACB600")]
		public QDPJHBURBMQ? HYBFKALWIUB([In] Id128<KSHTGNRFKHE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9430", Offset = "0x2AC8230", VA = "0x182AC9430", Slot = "30")]
		public Id32<KUBDOTYWEDD> BBNCGGDSUYN(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId)
		{
			return default(Id32<KUBDOTYWEDD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAFE0", Offset = "0x2AC9DE0", VA = "0x182ACAFE0")]
		public Id32<KSHTGNRFKHE> FBVFBJMUZGM(Id32<DINEWLJZVXU> graphId, [In] Id128<KSHTGNRFKHE> legacyNodeId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD3D0", Offset = "0x2ACC1D0", VA = "0x182ACD3D0", Slot = "40")]
		public Id32<KSHTGNRFKHE> OSZLBCKNDLT(Id32<DINEWLJZVXU> graphId, Id32<UTWGPDLERGC> inputId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAC50", Offset = "0x2AC9A50", VA = "0x182ACAC50", Slot = "41")]
		public Id32<KSHTGNRFKHE> EFUCWCEPHBO(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> outputId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD3F0", Offset = "0x2ACC1F0", VA = "0x182ACD3F0")]
		public Id32<KSHTGNRFKHE>? PKRRUCNFBQE(Id32<DINEWLJZVXU> graphId, [In] Id128<KSHTGNRFKHE> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEDA0", Offset = "0x2ACDBA0", VA = "0x182ACEDA0", Slot = "32")]
		public AbsoluteNodeId? USTKXVRDYUC(Id32<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA720", Offset = "0x2AC9520", VA = "0x182ACA720", Slot = "33")]
		public long DVYIZUAUBTR()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF820", Offset = "0x2ACE620", VA = "0x182ACF820")]
		private void XXSNRPLEIYD(Id128<KSHTGNRFKHE> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAF50", Offset = "0x2AC9D50", VA = "0x182ACAF50", Slot = "38")]
		public IEnumerable<(Id32<DINEWLJZVXU>, Id32<KSHTGNRFKHE>)> FAQZDGDCWUR(Id32<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC91F0", Offset = "0x2AC7FF0", VA = "0x182AC91F0", Slot = "39")]
		public Id32<UTWGPDLERGC> AEHWJOBKPDQ(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<AHQFLUVQZVQ> inputIndex)
		{
			return default(Id32<UTWGPDLERGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEF20", Offset = "0x2ACDD20", VA = "0x182ACEF20", Slot = "42")]
		public Id32<LQRVDHOTVET> VINNYMAMSJD(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<VCUZDXNTYTX> outputIndex)
		{
			return default(Id32<LQRVDHOTVET>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9930", Offset = "0x2AC8730", VA = "0x182AC9930")]
		private QDPJHBURBMQ? COHSWEOLZBC([In] Id128<KSHTGNRFKHE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA5E0", Offset = "0x2AC93E0", VA = "0x182ACA5E0")]
		public FDTJOQJNBIL? DOFIKSMZMKW([In] Id128<KSHTGNRFKHE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD760", Offset = "0x2ACC560", VA = "0x182ACD760")]
		public JWKBEMIEJCU? RLRTYTFHXDR([In] Id128<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE140", Offset = "0x2ACCF40", VA = "0x182ACE140", Slot = "25")]
		public JWKBEMIEJCU? RLRTYTFHXDR(Id32<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA540", Offset = "0x2AC9340", VA = "0x182ACA540", Slot = "34")]
		public IEnumerable<NewStaticEdge> DIRXIRDXBQV(Id32<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA6C0", Offset = "0x2AC94C0", VA = "0x182ACA6C0", Slot = "35")]
		public bool DVSXEVEPNEV(Id32<QNBOJXRXLEO> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBE20", Offset = "0x2ACAC20", VA = "0x182ACBE20", Slot = "36")]
		public IEnumerable<StableStaticEdge> KEBNREXMFHT(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA9E0", Offset = "0x2AC97E0", VA = "0x182ACA9E0", Slot = "37")]
		public IEnumerable<StableStaticEdge> EAOEEGDEFXW(Id32<DINEWLJZVXU> graphId, Id32<UTWGPDLERGC> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA510", Offset = "0x2AC9310", VA = "0x182ACA510")]
		public Id32<DINEWLJZVXU> DEWKINKSRBA([In] Id128<DINEWLJZVXU> graphId)
		{
			return default(Id32<DINEWLJZVXU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA4E0", Offset = "0x2AC92E0", VA = "0x182ACA4E0")]
		public Id32<DINEWLJZVXU>? DAQSIICQIYW([In] Id128<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA620", Offset = "0x2AC9420", VA = "0x182ACA620")]
		private QNLBMLMRCBE? DVEQPUAUKYW([In] Id128<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD760", Offset = "0x2ACC560", VA = "0x182ACD760")]
		private JWKBEMIEJCU? RJGPHGERSBT([In] Id128<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF700", Offset = "0x2ACE500", VA = "0x182ACF700", Slot = "28")]
		public Id32<DINEWLJZVXU>? XRIATSGEVFT(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF2C0", Offset = "0x2ACE0C0", VA = "0x182ACF2C0", Slot = "46")]
		public Id128<DINEWLJZVXU> XFXWMWSWFIT(Id32<DINEWLJZVXU> graphId)
		{
			return default(Id128<DINEWLJZVXU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9880", Offset = "0x2AC8680", VA = "0x182AC9880", Slot = "47")]
		public Id128<KSHTGNRFKHE> CKWRZAORDSL(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId)
		{
			return default(Id128<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF1C0", Offset = "0x2ACDFC0", VA = "0x182ACF1C0", Slot = "43")]
		public IEnumerable<BYYXKEXKPED> WTHBWEYKWHL(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF400", Offset = "0x2ACE200", VA = "0x182ACF400", Slot = "44")]
		public BYYXKEXKPED XJWGRGFGQSI(RoomVersion a, ENFFXWRYOWP b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE6A0", Offset = "0x2ACD4A0", VA = "0x182ACE6A0")]
		public NewStaticEdge ZUZPRELFHLU(Id32<DINEWLJZVXU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCED0", Offset = "0x2ACBCD0", VA = "0x182ACCED0", Slot = "48")]
		public StableStaticEdge MMZBOKRFGRZ(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> srcId, Id32<UTWGPDLERGC> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE190", Offset = "0x2ACCF90", VA = "0x182ACE190", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, IGWAJAWUKJF>> SJCYMYTGXPA(Id32<DINEWLJZVXU> parentGraphId, Id32<KSHTGNRFKHE> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9230", Offset = "0x2AC8030", VA = "0x182AC9230", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, IGWAJAWUKJF>> ANMXRTUZYCX(Id32<DINEWLJZVXU> parentGraphId, Id128<KSHTGNRFKHE> boardNodeId, List<Id32<KSHTGNRFKHE>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCC00", Offset = "0x2ACBA00", VA = "0x182ACCC00", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, IGWAJAWUKJF>> KUCAQHDSXAA(Id32<DINEWLJZVXU> parentGraphId, Id128<KSHTGNRFKHE> boardNodeId, List<Id32<KSHTGNRFKHE>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD1C0", Offset = "0x2ACBFC0", VA = "0x182ACD1C0", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, IGWAJAWUKJF>> OJZJOJKGWEY(Id32<DINEWLJZVXU> parentGraphId, Id128<KSHTGNRFKHE> boardNodeId, Id32<DINEWLJZVXU> graphId, List<Id32<KSHTGNRFKHE>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA370", Offset = "0x2AC9170", VA = "0x182ACA370", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<TDADSARCMWU>, Id32<TAGQJDWMKQY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<TDADSARCMWU>, Id32<MEQLWUNNBJN>)>) CXWJADHWFWN(Id128<DINEWLJZVXU> legacyGraphId, Id32<KSHTGNRFKHE> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<TDADSARCMWU>, Id32<TAGQJDWMKQY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<TDADSARCMWU>, Id32<MEQLWUNNBJN>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB420", Offset = "0x2ACA220", VA = "0x182ACB420", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task HEVFBHPOFLV(Id128<DINEWLJZVXU> legacyGraphId, Id128<KSHTGNRFKHE> boardNodeId, IReadOnlyList<Id128<KSHTGNRFKHE>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<TDADSARCMWU>, Id32<TAGQJDWMKQY>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<TDADSARCMWU>, Id32<MEQLWUNNBJN>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACED80", Offset = "0x2ACDB80", VA = "0x182ACED80", Slot = "55")]
		public bool UKIPPDXLCTZ(Id32<DINEWLJZVXU> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCE90", Offset = "0x2ACBC90", VA = "0x182ACCE90", Slot = "56")]
		public bool LXJWGAFHPYX(Id32<DINEWLJZVXU> graphId, Id32<UTWGPDLERGC> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF800", Offset = "0x2ACE600", VA = "0x182ACF800", Slot = "57")]
		public bool XXEZGKBLPEI(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9190", Offset = "0x2AC7F90", VA = "0x182AC9190")]
		public Result<LCNHFLDFADN.PrepareTemplateForCloneResult, DAXFGKUQCIS> ADRQRTGNVPO([In] LCNHFLDFADN.PrepareTemplateForCloneArgs args)
		{
			return default(Result<LCNHFLDFADN.PrepareTemplateForCloneResult, DAXFGKUQCIS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFA40", Offset = "0x2ACE840", VA = "0x182ACFA40", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, IGWAJAWUKJF>> YLMCYHJBELA(Id32<DINEWLJZVXU> graphId, Id32<LQRVDHOTVET> srcId, Id32<UTWGPDLERGC> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF060", Offset = "0x2ACDE60", VA = "0x182ACF060", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<KSHTGNRFKHE>, IGWAJAWUKJF>> WPBVSERYUXV(Id32<DINEWLJZVXU> graphId, Id32<KUBDOTYWEDD> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCD50", Offset = "0x2ACBB50", VA = "0x182ACCD50", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> LHNJCTAJIZU(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE300", Offset = "0x2ACD100", VA = "0x182ACE300", Slot = "62")]
		public Result<ControlPanelRootData, XDRQUNZRUHP> SRNRYZPEIXW(Id128<DINEWLJZVXU> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, XDRQUNZRUHP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF8E0", Offset = "0x2ACE6E0", VA = "0x182ACF8E0", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, IGWAJAWUKJF>> YEZBVTCHGDO(Id128<DINEWLJZVXU> graphId, Id128<KSHTGNRFKHE> inputNodeId, Id32<TDADSARCMWU> inputPortGroupId, Id32<TAGQJDWMKQY> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDFE0", Offset = "0x2ACCDE0", VA = "0x182ACDFE0", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, IGWAJAWUKJF>> QWUTAZFZQVB(Id128<DINEWLJZVXU> graphId, Id128<KSHTGNRFKHE> outputNodeId, Id32<TDADSARCMWU> outputPortGroupId, Id32<MEQLWUNNBJN> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB230", Offset = "0x2ACA030", VA = "0x182ACB230", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, IGWAJAWUKJF>> FQJBFJBJLJO(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC0D0", Offset = "0x2ACAED0", VA = "0x182ACC0D0", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<KSHTGNRFKHE>>, IGWAJAWUKJF>> KJMPFBACQCR(Id128<DINEWLJZVXU> intoGraphId, CircuitTemplateRootData a, IEnumerable<LZGZZRSUFGL> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE850", Offset = "0x2ACD650", VA = "0x182ACE850", Slot = "67")]
		public CircuitsData TPZKFXMJUBB()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD0C0", Offset = "0x2ACBEC0", VA = "0x182ACD0C0", Slot = "68")]
		public CircuitsData NTOZEIKNQQC()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAC70", Offset = "0x2AC9A70", VA = "0x182ACAC70", Slot = "71")]
		public CircuitsTemplateData EIUXSOLZOKV(TemplateSerializationReason a, Id32<DINEWLJZVXU> sourceGraphId, IEnumerable<Id128<DINEWLJZVXU>> graphIds, IEnumerable<Id128<KSHTGNRFKHE>> nodeIds, ISet<Id128<KGPKSSYXHLM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA7B0", Offset = "0x2AC95B0", VA = "0x182ACA7B0")]
		private CircuitsTemplateData DYQSHLERBJW(TemplateSerializationReason a, Id32<DINEWLJZVXU> sourceGraphId, IEnumerable<Id128<DINEWLJZVXU>> graphIds, IEnumerable<Id128<KSHTGNRFKHE>> nodeIds, ISet<Id128<KGPKSSYXHLM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFF40", Offset = "0x2ACED40", VA = "0x182ACFF40", Slot = "69")]
		public CircuitsTemplateData ZLRGADFSOKU(TemplateSerializationReason a, Id32<DINEWLJZVXU> sourceGraphId, IEnumerable<Id128<KSHTGNRFKHE>> nodeIds, IEnumerable<LZGZZRSUFGL> b, ISet<Id128<KGPKSSYXHLM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFE30", Offset = "0x2ACEC30", VA = "0x182ACFE30", Slot = "70")]
		public CircuitsTemplateData ZLRGADFSOKU(TemplateSerializationReason a, Id32<DINEWLJZVXU> sourceGraphId, IEnumerable<Id32<KSHTGNRFKHE>> nodeIds, IEnumerable<LZGZZRSUFGL> b, ISet<Id128<KGPKSSYXHLM>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC94B0", Offset = "0x2AC82B0", VA = "0x182AC94B0")]
		private static IEnumerable<Id128<DINEWLJZVXU>> BUSPDTLYZQA(IEnumerable<LZGZZRSUFGL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD790", Offset = "0x2ACC590", VA = "0x182ACD790")]
		private IEnumerable<Id128<KSHTGNRFKHE>> QCWNOLSLOIC(IEnumerable<LZGZZRSUFGL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF8A0", Offset = "0x2ACE6A0", VA = "0x182ACF8A0", Slot = "72")]
		public List<JCYCVTQGDFH> XZCVPLFVMWV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AD01A0", Offset = "0x2ACEFA0", VA = "0x182AD01A0")]
		public (List<JCYCVTQGDFH>, bool) ZODCDBIMRIE([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, QKASVDEMKQP b, BGNXQNLAHIJ c)
		{
			return default((List<JCYCVTQGDFH>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDC90", Offset = "0x2ACCA90", VA = "0x182ACDC90", Slot = "74")]
		public bool QDNGATDLYYB(Id32<DINEWLJZVXU> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFCB0", Offset = "0x2ACEAB0", VA = "0x182ACFCB0", Slot = "75")]
		public bool YXIKSPRDALZ(Id32<DINEWLJZVXU> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC93B0", Offset = "0x2AC81B0", VA = "0x182AC93B0")]
		internal void ARRFWJBUSRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAC30", Offset = "0x2AC9A30", VA = "0x182ACAC30")]
		internal Task EEOFIISCURA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC250", Offset = "0x2ACB050", VA = "0x182ACC250", Slot = "76")]
		public Result<Id32<LQRVDHOTVET>?, IGWAJAWUKJF> KNHFGDJECZE(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<UTWGPDLERGC> inputId)
		{
			return default(Result<Id32<LQRVDHOTVET>?, IGWAJAWUKJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC99C0", Offset = "0x2AC87C0", VA = "0x182AC99C0", Slot = "77")]
		public Result<Id32<UTWGPDLERGC>?, IGWAJAWUKJF> CRJGYWHJKSC(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<LQRVDHOTVET> outputId)
		{
			return default(Result<Id32<UTWGPDLERGC>?, IGWAJAWUKJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFD40", Offset = "0x2ACEB40", VA = "0x182ACFD40", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, IGWAJAWUKJF>> ZBFMCDKUBTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAE10", Offset = "0x2AC9C10", VA = "0x182ACAE10", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, IGWAJAWUKJF>> EWVCHLOIRNZ(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEFA0", Offset = "0x2ACDDA0", VA = "0x182ACEFA0", Slot = "80")]
		public Id32<KSHTGNRFKHE>? WJZCFQZCSGV(Id32<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE790", Offset = "0x2ACD590", VA = "0x182ACE790", Slot = "81")]
		public Id32<KSHTGNRFKHE>? TPFGBOWYOBE(Id32<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD340", Offset = "0x2ACC140", VA = "0x182ACD340", Slot = "82")]
		public int OSULVWYLEOE(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBBE0", Offset = "0x2ACA9E0", VA = "0x182ACBBE0", Slot = "83")]
		public int JMLQVKGHHJH(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB340", Offset = "0x2ACA140", VA = "0x182ACB340", Slot = "84")]
		public int HEODCNZHQQK(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<LJLJBSUERVT> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB010", Offset = "0x2AC9E10", VA = "0x182ACB010", Slot = "85")]
		public int FKVWKPUQUAI(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<LJLJBSUERVT> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB0F0", Offset = "0x2AC9EF0", VA = "0x182ACB0F0", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, IGWAJAWUKJF>> FMOYNJEAPIO(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<LJLJBSUERVT> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB750", Offset = "0x2ACA550", VA = "0x182ACB750", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, IGWAJAWUKJF>> IBURWTMVOGT(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, Id32<LJLJBSUERVT> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBCE0", Offset = "0x2ACAAE0", VA = "0x182ACBCE0", Slot = "88")]
		public int JOCIOWVHNAS(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACFB70", Offset = "0x2ACE970", VA = "0x182ACFB70", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, IGWAJAWUKJF>> YTBJHEIPZAI(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB890", Offset = "0x2ACA690", VA = "0x182ACB890", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, IGWAJAWUKJF>> JECLZUDNBTX(Id32<DINEWLJZVXU> graphId, Id32<KSHTGNRFKHE> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB9F0", Offset = "0x2ACA7F0", VA = "0x182ACB9F0", Slot = "91")]
		public bool JGUEQOKDQGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE2E0", Offset = "0x2ACD0E0", VA = "0x182ACE2E0", Slot = "97")]
		public IEnumerable<Id32<ZSZVPFOYVHO>> SNJDNYWPGDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB730", Offset = "0x2ACA530", VA = "0x182ACB730", Slot = "98")]
		public string? HYMXUWIHHEU(Id32<ZSZVPFOYVHO> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9220", Offset = "0x2AC8020", VA = "0x182AC9220", Slot = "7")]
		private bool AKQSFYINZEO(Id32<DINEWLJZVXU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD760", Offset = "0x2ACC560", VA = "0x182ACD760", Slot = "24")]
		private JWKBEMIEJCU PZULQLECQLB([In] Id128<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA510", Offset = "0x2AC9310", VA = "0x182ACA510", Slot = "26")]
		private Id32<DINEWLJZVXU> VPGLWPZURVM([In] Id128<DINEWLJZVXU> graphId)
		{
			return default(Id32<DINEWLJZVXU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA4E0", Offset = "0x2AC92E0", VA = "0x182ACA4E0", Slot = "27")]
		private Id32<DINEWLJZVXU>? TGMCUEHXVQW([In] Id128<DINEWLJZVXU> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF2E0", Offset = "0x2ACE0E0", VA = "0x182ACF2E0", Slot = "29")]
		private QDPJHBURBMQ XJTGAVRJHTT([In] Id128<KSHTGNRFKHE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAFE0", Offset = "0x2AC9DE0", VA = "0x182ACAFE0", Slot = "31")]
		private Id32<KSHTGNRFKHE> YDLMFTGJHBS(Id32<DINEWLJZVXU> graphId, [In] Id128<KSHTGNRFKHE> legacyNodeId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE6A0", Offset = "0x2ACD4A0", VA = "0x182ACE6A0", Slot = "45")]
		private NewStaticEdge TMKWEEBGJRE(Id32<DINEWLJZVXU> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9190", Offset = "0x2AC7F90", VA = "0x182AC9190", Slot = "58")]
		private Result<LCNHFLDFADN.PrepareTemplateForCloneResult, DAXFGKUQCIS> DVWFGBIFZYI([In] LCNHFLDFADN.PrepareTemplateForCloneArgs args)
		{
			return default(Result<LCNHFLDFADN.PrepareTemplateForCloneResult, DAXFGKUQCIS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBDA0", Offset = "0x2ACABA0", VA = "0x182ACBDA0", Slot = "73")]
		private (List<JCYCVTQGDFH>, bool) JPYTQLKAOZK([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, QKASVDEMKQP b, BGNXQNLAHIJ c)
		{
			return default((List<JCYCVTQGDFH>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA740", Offset = "0x2AC9540", VA = "0x182ACA740")]
		[CompilerGenerated]
		private NKLIRBSCJPK DWEFYJVQMJP(JHOEKUEVGUO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9900", Offset = "0x2AC8700", VA = "0x182AC9900")]
		[CompilerGenerated]
		private FDTJOQJNBIL CLSUIJLQAON(Id128<KSHTGNRFKHE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC98A0", Offset = "0x2AC86A0", VA = "0x182AC98A0")]
		[CompilerGenerated]
		private QNLBMLMRCBE CLNNLCRSRDE(Id128<DINEWLJZVXU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9900", Offset = "0x2AC8700", VA = "0x182AC9900")]
		[CompilerGenerated]
		private FDTJOQJNBIL IQTHIWWSNZT(Id128<KSHTGNRFKHE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC98A0", Offset = "0x2AC86A0", VA = "0x182AC98A0")]
		[CompilerGenerated]
		private QNLBMLMRCBE IQOALQCVEOK(Id128<DINEWLJZVXU> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class NKLIRBSCJPK : BYYXKEXKPED
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
			public AsyncTaskMethodBuilder<Result<Id32<LJLJBSUERVT>, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public NKLIRBSCJPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<TDADSARCMWU> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<LJLJBSUERVT>, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2E60", Offset = "0x2AC1C60", VA = "0x182AC2E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x2AC30B0", Offset = "0x2AC1EB0", VA = "0x182AC30B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<OKZGLREOVOG>, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public NKLIRBSCJPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<DINEWLJZVXU> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<KSHTGNRFKHE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<TDADSARCMWU> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<OKZGLREOVOG>, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3120", Offset = "0x2AC1F20", VA = "0x182AC3120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3370", Offset = "0x2AC2170", VA = "0x182AC3370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly JHOEKUEVGUO KNZPFGNVUVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly QCQTPBNJHXP DDZJRTGYFSV;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey DOADRMZVTZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string GWELLUUBZAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD120", Offset = "0x2ABBF20", VA = "0x182ABD120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public JHOEKUEVGUO JHOEKUEVGUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFD00", Offset = "0x2ABEB00", VA = "0x182ABFD00")]
		public NKLIRBSCJPK(JHOEKUEVGUO a, QCQTPBNJHXP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFB90", Offset = "0x2ABE990", VA = "0x182ABFB90", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<LJLJBSUERVT>, IGWAJAWUKJF>> GQXAXOHHITX(Id128<DINEWLJZVXU> graphId, Id128<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFA20", Offset = "0x2ABE820", VA = "0x182ABFA20", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<OKZGLREOVOG>, IGWAJAWUKJF>> CGIVFSIJYEC(Id128<DINEWLJZVXU> graphId, Id128<KSHTGNRFKHE> nodeId, Id32<TDADSARCMWU> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class GBHGHXYKHWO : JFUKTDYQATS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly JHOEKUEVGUO AWGGIHKHCIW;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<JHOEKUEVGUO> VRLSYRLUJYM;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<JHOEKUEVGUO> NLQCAJSBAWZ;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<JHOEKUEVGUO> IENGNQNAOSQ;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public JHOEKUEVGUO QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEAB0", Offset = "0x2ABD8B0", VA = "0x182ABEAB0", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEAA0", Offset = "0x2ABD8A0", VA = "0x182ABEAA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEB00", Offset = "0x2ABD900", VA = "0x182ABEB00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2ABEA20", Offset = "0x2ABD820", VA = "0x182ABEA20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCEB0", Offset = "0x2ABBCB0", VA = "0x182ABCEB0")]
		public bool JWCZNXMOHLN(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public GBHGHXYKHWO(JHOEKUEVGUO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCD20", Offset = "0x2ABBB20", VA = "0x182ABCD20")]
		internal static TypeKey GMUITXGUHNO(JHOEKUEVGUO a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD120", Offset = "0x2ABBF20", VA = "0x182ABD120", Slot = "3")]
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
	public readonly struct ActionDeps : XQXZMUBXLZL.GIUHKLOTLFC<TWGQWHZWPAR, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC820", Offset = "0x2ABB620", VA = "0x182ABC820", Slot = "4")]
		public int AAEJFJPGIYW(None a, TWGQWHZWPAR b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC880", Offset = "0x2ABB680", VA = "0x182ABC880", Slot = "5")]
		public TWGQWHZWPAR HXQMNDWPDQR(None a, TWGQWHZWPAR b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC920", Offset = "0x2ABB720", VA = "0x182ABC920", Slot = "6")]
		public TWGQWHZWPAR TTTJARSNBJU(None a, TWGQWHZWPAR b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC890", Offset = "0x2ABB690", VA = "0x182ABC890", Slot = "7")]
		public IReadOnlyList<TWGQWHZWPAR> JCYHWUSUFZK(None a, TWGQWHZWPAR b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC910", Offset = "0x2ABB710", VA = "0x182ABC910", Slot = "8")]
		public TWGQWHZWPAR[] RJFNOEFESNR(None a, TWGQWHZWPAR b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC8B0", Offset = "0x2ABB6B0", VA = "0x182ABC8B0", Slot = "9")]
		public bool LIGHKFDBVKM(None a, TWGQWHZWPAR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC8D0", Offset = "0x2ABB6D0", VA = "0x182ABC8D0", Slot = "10")]
		public bool NOOSZGSAZLY(None a, TWGQWHZWPAR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC860", Offset = "0x2ABB660", VA = "0x182ABC860", Slot = "11")]
		public bool GIKJGPTPCJW(None a, TWGQWHZWPAR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC840", Offset = "0x2ABB640", VA = "0x182ABC840", Slot = "12")]
		public bool AZKHMOTEYBU(None a, TWGQWHZWPAR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC950", Offset = "0x2ABB750", VA = "0x182ABC950", Slot = "13")]
		public bool YJRNWIAQUTC(None a, TWGQWHZWPAR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC8F0", Offset = "0x2ABB6F0", VA = "0x182ABC8F0", Slot = "14")]
		public bool RGXJVYJSTWV(None a, TWGQWHZWPAR b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class IGKUETUDTWP : GMJPGHKCHRR
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract LPFVMTQVGRX.ZLOMSCLYJNW CGAUFAQGAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract SQESMBBMMXQ.ZLOMSCLYJNW ASIJCYYYTEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract TJDAFASHBMR.ZLOMSCLYJNW GKLYXYZYSVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ> BNOHTPALDTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF7E0", Offset = "0x2ABE5E0", VA = "0x182ABF7E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.ZLOMSCLYJNW TFCUKQZSBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract EMOXSDWCFKN TWTJQHHARIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract VADHWBRYBMQ BNJTVCTNMZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract OBAYIOUBMIS WHTCTRONSTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract HJJZQHCBFAG CKWNRKHWSIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract CNVYILPYZTW PYMUGAXKGMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected IGKUETUDTWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class VPKTSHJAHPV : FHDVVRQJWQR
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
			public AsyncTaskMethodBuilder<Result<MultiResult, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<TWGQWHZWPAR> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public VPKTSHJAHPV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC39B0", Offset = "0x2AC27B0", VA = "0x182AC39B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3DD0", Offset = "0x2AC2BD0", VA = "0x182AC3DD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public VPKTSHJAHPV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public TWGQWHZWPAR action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8740", Offset = "0x2AC7540", VA = "0x182AC8740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2AC89C0", Offset = "0x2AC77C0", VA = "0x182AC89C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly EGZVYBEHFSY WTHGPGNGCAS;

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public VPKTSHJAHPV(EGZVYBEHFSY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0D90", Offset = "0x2ACFB90", VA = "0x182AD0D90")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, IGWAJAWUKJF>> OBLLNKKDQTC(TWGQWHZWPAR a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0C60", Offset = "0x2ACFA60", VA = "0x182AD0C60", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, IGWAJAWUKJF>> AWVKRTZUAJW(IReadOnlyList<TWGQWHZWPAR> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, TWGQWHZWPAR, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x12B3B90", Offset = "0x12B2990", VA = "0x1812B3B90")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, TWGQWHZWPAR, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFF90", Offset = "0x2ABED90", VA = "0x182ABFF90")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class PRCXBTEFQHU
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, TWGQWHZWPAR, PartialActionReassemblyDeps> XLQIESCGZEZ(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, TWGQWHZWPAR, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : NTDEOCDVDNZ.XZMMFITJJKF<PartialActionPayload, Id128<PartialActionPayload.M>, TWGQWHZWPAR>
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFDB0", Offset = "0x2ABEBB0", VA = "0x182ABFDB0", Slot = "7")]
		public TWGQWHZWPAR ICLWHHMRJPN(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x12A5620", Offset = "0x12A4420", VA = "0x1812A5620")]
		public Id128<PartialActionPayload.M> UMZFWTPBCBN([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x12DD4A0", Offset = "0x12DC2A0", VA = "0x1812DD4A0")]
		public int JMPZEFNLPKZ([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFDA0", Offset = "0x2ABEBA0", VA = "0x182ABFDA0")]
		public int NRJJAGOSKBM([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x12DD4A0", Offset = "0x12DC2A0", VA = "0x1812DD4A0", Slot = "4")]
		private int XTSRIEOOMMT([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFDA0", Offset = "0x2ABEBA0", VA = "0x182ABFDA0", Slot = "5")]
		private int CMMLDAMBPJC([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x12A5620", Offset = "0x12A4420", VA = "0x1812A5620", Slot = "6")]
		private Id128<PartialActionPayload.M> JIEOVIQSYEB([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, TWGQWHZWPAR, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x12B3B90", Offset = "0x12B2990", VA = "0x1812B3B90")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, TWGQWHZWPAR, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2E00", Offset = "0x2AC1C00", VA = "0x182AC2E00")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class VXWNESMXJUJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static SnapshotReassembly<PartialInitializePayload, TWGQWHZWPAR, SnapshotReassemblyDeps> XLQIESCGZEZ(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, TWGQWHZWPAR, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : MNZCXRPNVSO.XZHFIBZLZYW<PartialInitializePayload, TWGQWHZWPAR>
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x148DAD0", Offset = "0x148C8D0", VA = "0x18148DAD0")]
		public int SFEJUAIZIAD([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2C20", Offset = "0x2AC1A20", VA = "0x182AC2C20", Slot = "5")]
		public TWGQWHZWPAR QMANLCDNJVP(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x148DAD0", Offset = "0x148C8D0", VA = "0x18148DAD0", Slot = "4")]
		private int LIROXEAIBCJ([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class DIHPMSCGPGH : RHLDYTPLBXY, DAXFGKUQCIS, IGWAJAWUKJF, XDRQUNZRUHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly XDRQUNZRUHP? ZWGMXIQZUPJ;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind JSZILMLWUMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override XDRQUNZRUHP? ZHIQNPFNDPK
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC990", Offset = "0x2ABB790", VA = "0x182ABC990", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCBC0", Offset = "0x2ABB9C0", VA = "0x182ABCBC0")]
		private DIHPMSCGPGH(PrepareTemplateForCloneErrKind a, XDRQUNZRUHP? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCB50", Offset = "0x2ABB950", VA = "0x182ABCB50")]
		public static DIHPMSCGPGH UWBTNZOYWDB(XDRQUNZRUHP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCA90", Offset = "0x2ABB890", VA = "0x182ABCA90")]
		public static DIHPMSCGPGH OXXZXZZZZUH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCAF0", Offset = "0x2ABB8F0", VA = "0x182ABCAF0")]
		public static DIHPMSCGPGH UGHFWXCZANT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class GPLCBJNSDRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x3910890", Offset = "0x390F690", VA = "0x183910890")]
		public static Result<TOk, DAXFGKUQCIS> CYQXWYHRWCY<TOk>([In] this Result<TOk, DAXFGKUQCIS> self, XDRQUNZRUHP a) where TOk : notnull
		{
			return default(Result<TOk, DAXFGKUQCIS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x3910C20", Offset = "0x390FA20", VA = "0x183910C20")]
		public static Result<a?, DAXFGKUQCIS?> RTOZIGXIERE<a>([In] this Result<a, DAXFGKUQCIS> self)
		{
			return default(Result<a, DAXFGKUQCIS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3910AD0", Offset = "0x390F8D0", VA = "0x183910AD0")]
		public static Result<b?, DAXFGKUQCIS?> MXQGEXEFFJS<b>([In] this Result<b, DAXFGKUQCIS> self)
		{
			return default(Result<b, DAXFGKUQCIS>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface EMOXSDWCFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HXHYXAIYMXB([In] Result<None, XDRQUNZRUHP> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class KZSSGTLQXDR
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x39ECFF0", Offset = "0x39EBDF0", VA = "0x1839ECFF0")]
		public static bool HXHYXAIYMXB<TOk, TErr>(this EMOXSDWCFKN a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, XDRQUNZRUHP
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface VADHWBRYBMQ
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		BWRMFYYLKFG JPYOYELUYJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface OBAYIOUBMIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor KMDJSLCIOTN(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface RJOKXXZYZET
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface YHYTRIRIJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		XETNOQWIMKC? FVMRYDKORJP(Id32<TDADSARCMWU> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface DNXBTWUJFQI
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface XETNOQWIMKC
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DNXBTWUJFQI? IZBINLKTWWH(Id32<LJLJBSUERVT> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RJOKXXZYZET? HJHXMZJNULE(Id32<OKZGLREOVOG> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface HJJZQHCBFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> BOCUIDZLYIE(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface CNVYILPYZTW
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YHYTRIRIJPC? KPWRLXBQWAR([In] Id128<ANEJQQKWRHI> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class QFOLHNWPOFZ
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
			public readonly List<TWGQWHZWPAR> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2ABCCB0", Offset = "0x2ABBAB0", VA = "0x182ABCCB0")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<TWGQWHZWPAR> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2ABCC00", Offset = "0x2ABBA00", VA = "0x182ABCC00")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly QOPXRPAWYIE<Diagnostic> MQEOVGFLAWZ;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static QFOLHNWPOFZ GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC20A0", Offset = "0x2AC0EA0", VA = "0x182AC20A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool ECKKAIXLKER
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC20F0", Offset = "0x2AC0EF0", VA = "0x182AC20F0")]
		public void DTGBLEHJIQY(QCQTPBNJHXP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2370", Offset = "0x2AC1170", VA = "0x182AC2370")]
		public void PZVMDKJCNUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC21B0", Offset = "0x2AC0FB0", VA = "0x182AC21B0")]
		private static string? NBIHTDPHKTH([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2740", Offset = "0x2AC1540", VA = "0x182AC2740")]
		public QFOLHNWPOFZ()
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
